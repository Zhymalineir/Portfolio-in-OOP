Imports System.IO

Public Class level1

    Private WithEvents animTimer As New Timer()
    Private WithEvents countdownTimer As New Timer()

    ' Jump frame numbers in order. 0 means "idle".
    Private ReadOnly jumpSeq As Integer() = {0, 1, 2, 3, 2, 1, 0}

    Private Const MoveDuration As Integer = 700
    Private Const BoatDuration As Integer = 1500
    Private Const StartTime As Integer = 60

    Private timeLeft As Integer = StartTime

    Private characters As PictureBox()
    Private imageCache As New Dictionary(Of String, Image)

    Private Class MoveAnim
        Public StartPos As Point
        Public EndPos As Point
        Public Watch As Stopwatch
        Public Dir As String        ' "left" or "right"
        Public StartIdle As Integer ' idle image number at the start (1 or 2)
        Public EndIdle As Integer   ' idle image number at the end (1 or 2)
        Public StartSlot As Integer = -1   ' >= 0 means they start the move sitting in the boat
        Public EndSlot As Integer = -1     ' >= 0 means they finish the move sitting in the boat
    End Class
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000   ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
    Private Class TPictureBox
        Inherits PictureBox

        Public Sub New()
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            BackColor = Color.Transparent
        End Sub

        Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
            If Parent Is Nothing Then
                MyBase.OnPaintBackground(pevent)
                Return
            End If

            Dim g As Graphics = pevent.Graphics

            ' 1) Parent background (form color / background image)
            Dim state = g.Save()
            g.TranslateTransform(-Left, -Top)
            Using pe As New PaintEventArgs(g, New Rectangle(Location, Size))
                InvokePaintBackground(Parent, pe)
                InvokePaint(Parent, pe)
            End Using
            g.Restore(state)

            ' 2) Siblings behind this control (higher index = further back)
            Dim myIndex As Integer = Parent.Controls.GetChildIndex(Me)
            For i As Integer = Parent.Controls.Count - 1 To myIndex + 1 Step -1
                Dim sib As Control = Parent.Controls(i)
                If Not sib.Visible OrElse Not sib.Bounds.IntersectsWith(Bounds) Then Continue For

                Dim pic = TryCast(sib, PictureBox)
                If pic IsNot Nothing AndAlso pic.Image IsNot Nothing Then
                    g.DrawImage(pic.Image, New Rectangle(sib.Left - Left, sib.Top - Top, sib.Width, sib.Height))
                End If
            Next
        End Sub

        Protected Overrides Sub OnMove(e As EventArgs)
            MyBase.OnMove(e)
            Invalidate()
        End Sub
    End Class

    ' Replaces a designer PictureBox with a TPictureBox that has the same settings
    Private Function MakeTransparent(old As PictureBox) As PictureBox
        Dim p As Control = old.Parent
        Dim idx As Integer = p.Controls.GetChildIndex(old)

        Dim nb As New TPictureBox()
        nb.Name = old.Name              ' GetPrefix depends on this
        nb.Size = old.Size
        nb.Location = old.Location
        nb.Image = old.Image
        nb.SizeMode = old.SizeMode
        nb.Anchor = old.Anchor
        nb.Cursor = old.Cursor
        nb.Visible = old.Visible
        nb.Tag = old.Tag

        p.Controls.Remove(old)
        old.Dispose()
        p.Controls.Add(nb)
        p.Controls.SetChildIndex(nb, idx)   ' keep the same z-order
        Return nb
    End Function

    Private activeAnims As New Dictionary(Of PictureBox, MoveAnim)

    ' Starting bank (right side, where they are when the form loads)
    Private originalPos As New Dictionary(Of PictureBox, Point)

    ' Far bank (left side, where they land when the boat is at 309, 397)
    Private farPos As New Dictionary(Of PictureBox, Point)

    ' False = on the starting bank (right), True = on the far bank (left)
    Private onFarBank As New Dictionary(Of PictureBox, Boolean)

    ' Slot positions RELATIVE to the boat's top-left corner
    Private ReadOnly slotOffsets As Point() = {
        New Point(576 - 456, 348 - 397),   ' slot 0 (first slot)
        New Point(488 - 456, 348 - 397)    ' slot 1 (second slot)
    }

    Private slotOwner(1) As PictureBox
    Private assignedSlot As New Dictionary(Of PictureBox, Integer)

    ' Boat state
    Private ReadOnly boatDockA As New Point(456, 397)
    Private ReadOnly boatDockB As New Point(309, 397)
    Private boatAtA As Boolean = True
    Private boatMoving As Boolean = False
    Private boatStart As Point
    Private boatEnd As Point
    Private boatWatch As Stopwatch

    ' Set to True once the game is won or lost; blocks all clicks
    Private gameOver As Boolean = False

    Private Sub level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage = New Bitmap(Me.BackgroundImage, Me.ClientSize)
            Me.BackgroundImageLayout = ImageLayout.None
        End If

        Boat = MakeTransparent(Boat)
        Priest1 = MakeTransparent(Priest1)
        Priest2 = MakeTransparent(Priest2)
        Priest3 = MakeTransparent(Priest3)
        Devil1 = MakeTransparent(Devil1)
        Devil2 = MakeTransparent(Devil2)
        Devil3 = MakeTransparent(Devil3)
        gobtn = MakeTransparent(gobtn)
        restartbtn = MakeTransparent(restartbtn)

        characters = {Priest1, Priest2, Priest3, Devil1, Devil2, Devil3}

        animTimer.Interval = 15
        countdownTimer.Interval = 1000

        Boat.Location = boatDockA
        Boat.Image = GetImage("pnd_boat_left.png")

        farPos(Priest1) = New Point(203, 196)
        farPos(Priest2) = New Point(203, 315)
        farPos(Priest3) = New Point(203, 445)
        farPos(Devil1) = New Point(61, 247)
        farPos(Devil2) = New Point(61, 346)
        farPos(Devil3) = New Point(61, 445)

        For Each pb As PictureBox In characters
            originalPos(pb) = pb.Location
            onFarBank(pb) = False
            SetIdle(pb, 1)
            AddHandler pb.Click, AddressOf Character_Click
        Next

        ' The go button now moves the boat, and the restart button resets the game
        AddHandler gobtn.Click, AddressOf Go_Click
        AddHandler restartbtn.Click, AddressOf Restart_Click

        timeLeft = StartTime
        UpdateTimerLabel()
        countdownTimer.Start()
    End Sub

    Private Function GetPrefix(pb As PictureBox) As String
        Return pb.Name.TrimEnd("0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c).ToLower()
    End Function

    Private Function GetImage(fileName As String) As Image
        If Not imageCache.ContainsKey(fileName) Then
            Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", fileName)
            Using temp As Image = Image.FromFile(path)
                imageCache(fileName) = New Bitmap(temp)
            End Using
        End If
        Return imageCache(fileName)
    End Function

    ' charactername_idle_1.png or charactername_idle_2.png
    Private Sub SetIdle(pb As PictureBox, idleNum As Integer)
        pb.Image = GetImage(GetPrefix(pb) & "_idle_" & idleNum & ".png")
    End Sub

    ' charactername_jump_1_left.png ... charactername_jump_3_right.png
    Private Sub SetJump(pb As PictureBox, jumpNum As Integer, dir As String)
        pb.Image = GetImage(GetPrefix(pb) & "_jump_" & jumpNum & "_" & dir & ".png")
    End Sub
    Private Sub SetSit(pb As PictureBox, slot As Integer)
        Dim dir As String = If(slot = 0, "right", "left")
        pb.Image = GetImage(GetPrefix(pb) & "_sit_" & dir & ".png")
    End Sub
    Private Function GetSlotPos(slot As Integer) As Point
        Return New Point(Boat.Left + slotOffsets(slot).X, Boat.Top + slotOffsets(slot).Y)
    End Function

    Private Function FindFreeSlot() As Integer
        For i As Integer = 0 To slotOwner.Length - 1
            If slotOwner(i) Is Nothing Then Return i
        Next
        Return -1
    End Function

    Private Sub UpdateTimerLabel()
        timerlbl.Text = "Time Left: " & timeLeft
    End Sub

    ' Ends the game once: stops the clock, blocks clicks, shows the message
    Private Sub EndGame(message As String)
        If gameOver Then Return
        gameOver = True
        countdownTimer.Stop()
        MessageBox.Show(message)
    End Sub

    ' ---------- GAME OVER CHECK ----------
    Private Function IsGameOver(boatSailing As Boolean) As Boolean
        Dim priests(1) As Integer ' index 0 = starting bank, 1 = far bank
        Dim devils(1) As Integer

        For Each pb As PictureBox In characters
            Dim side As Integer

            If assignedSlot.ContainsKey(pb) Then
                If boatSailing Then Continue For
                side = If(boatAtA, 0, 1)
            Else
                side = If(onFarBank(pb), 1, 0)
            End If

            If GetPrefix(pb) = "priest" Then
                priests(side) += 1
            Else
                devils(side) += 1
            End If
        Next

        For side As Integer = 0 To 1
            If priests(side) > 0 AndAlso devils(side) > priests(side) Then Return True
        Next
        Return False
    End Function

    ' ---------- WIN CHECK ----------
    ' All six on the left (far) bank, and nobody left on the boat
    Private Function HasWon() As Boolean
        If assignedSlot.Count > 0 Then Return False
        For Each pb As PictureBox In characters
            If Not onFarBank(pb) Then Return False
        Next
        Return True
    End Function

    Private Sub StartMove(pb As PictureBox, target As Point, dir As String, startIdle As Integer, endIdle As Integer,
                      Optional startSlot As Integer = -1, Optional endSlot As Integer = -1)
        Dim a As New MoveAnim()
        a.StartPos = pb.Location
        a.EndPos = target
        a.Watch = Stopwatch.StartNew()
        a.Dir = dir
        a.StartIdle = startIdle
        a.EndIdle = endIdle
        a.StartSlot = startSlot
        a.EndSlot = endSlot
        activeAnims(pb) = a

        pb.BringToFront()
        If Not animTimer.Enabled Then animTimer.Start()
    End Sub

    Private Sub Character_Click(sender As Object, e As EventArgs)
        If gameOver Then Return

        Dim pb As PictureBox = DirectCast(sender, PictureBox)

        If boatMoving Then Return
        If activeAnims.ContainsKey(pb) Then Return

        ' Idle image of the bank this character is currently associated with
        Dim currentIdle As Integer = If(onFarBank(pb), 2, 1)

        If assignedSlot.ContainsKey(pb) Then
            Dim slot As Integer = assignedSlot(pb)
            slotOwner(slot) = Nothing
            assignedSlot.Remove(pb)

            If boatAtA Then
                onFarBank(pb) = False
                StartMove(pb, originalPos(pb), "right", currentIdle, 1, slot, -1)
            Else
                onFarBank(pb) = True
                StartMove(pb, farPos(pb), "left", currentIdle, 2, slot, -1)
            End If
        Else
            If onFarBank(pb) = boatAtA Then Return

            Dim slot As Integer = FindFreeSlot()
            If slot = -1 Then Return

            slotOwner(slot) = pb
            assignedSlot(pb) = slot

            Dim dir As String = If(onFarBank(pb), "right", "left")
            StartMove(pb, GetSlotPos(slot), dir, currentIdle, currentIdle, -1, slot)
        End If
    End Sub

    ' Was Boat_Click: now triggered by the gobtn picturebox
    Private Sub Go_Click(sender As Object, e As EventArgs)
        If gameOver Then Return
        If boatMoving Then Return
        If activeAnims.Count > 0 Then Return
        If assignedSlot.Count = 0 Then Return ' nobody on board: boat can't move

        If IsGameOver(True) Then
            EndGame("Game Over")
            Return
        End If

        boatStart = Boat.Location
        boatEnd = If(boatAtA, boatDockB, boatDockA)
        boatAtA = Not boatAtA

        boatWatch = Stopwatch.StartNew()
        boatMoving = True

        Boat.BringToFront()
        For Each pb As PictureBox In assignedSlot.Keys
            pb.BringToFront()
        Next

        If Not animTimer.Enabled Then animTimer.Start()
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs)
        ' Stop everything that's running
        animTimer.Stop()
        countdownTimer.Stop()
        activeAnims.Clear()
        boatMoving = False

        ' Clear the boat
        assignedSlot.Clear()
        slotOwner(0) = Nothing
        slotOwner(1) = Nothing

        ' Put the boat back at the start
        boatAtA = True
        Boat.Location = boatDockA
        Boat.Image = GetImage("pnd_boat_left.png")

        ' Put every character back on the starting bank
        For Each pb As PictureBox In characters
            pb.Location = originalPos(pb)
            onFarBank(pb) = False
            SetIdle(pb, 1)
        Next

        ' Reset the clock and unlock the game
        gameOver = False
        timeLeft = StartTime
        UpdateTimerLabel()
        countdownTimer.Start()
    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        If gameOver Then
            countdownTimer.Stop()
            Return
        End If

        timeLeft -= 1
        UpdateTimerLabel()

        If timeLeft <= 0 Then
            EndGame("Times up! You lost!")
        End If
    End Sub

    Private Sub animTimer_Tick(sender As Object, e As EventArgs) Handles animTimer.Tick
        Dim boatArrived As Boolean = False
        Dim characterLanded As Boolean = False

        ' --- Character jumps/slides ---
        For Each pb As PictureBox In activeAnims.Keys.ToList()
            Dim a As MoveAnim = activeAnims(pb)

            Dim t As Double = Math.Min(1.0, a.Watch.ElapsedMilliseconds / MoveDuration)

            Dim idx As Integer = Math.Min(CInt(Math.Floor(t * jumpSeq.Length)), jumpSeq.Length - 1)
            Dim n As Integer = jumpSeq(idx)

            If n = 0 Then
                If idx = 0 Then
                    If a.StartSlot >= 0 Then SetSit(pb, a.StartSlot) Else SetIdle(pb, a.StartIdle)
                Else
                    If a.EndSlot >= 0 Then SetSit(pb, a.EndSlot) Else SetIdle(pb, a.EndIdle)
                End If
            Else
                SetJump(pb, n, a.Dir)
            End If

            Dim eased As Double = t * t * (3 - 2 * t)
            pb.Location = New Point(
                CInt(a.StartPos.X + (a.EndPos.X - a.StartPos.X) * eased),
                CInt(a.StartPos.Y + (a.EndPos.Y - a.StartPos.Y) * eased))

            If t >= 1.0 Then
                pb.Location = a.EndPos
                If a.EndSlot >= 0 Then SetSit(pb, a.EndSlot) Else SetIdle(pb, a.EndIdle)
                activeAnims.Remove(pb)
                characterLanded = True
            End If
        Next

        ' --- Boat + passengers ---
        If boatMoving Then
            Dim t As Double = Math.Min(1.0, boatWatch.ElapsedMilliseconds / BoatDuration)
            Dim eased As Double = t * t * (3 - 2 * t)

            Boat.Location = New Point(
                CInt(boatStart.X + (boatEnd.X - boatStart.X) * eased),
                CInt(boatStart.Y + (boatEnd.Y - boatStart.Y) * eased))

            For Each kvp In assignedSlot
                kvp.Key.Location = GetSlotPos(kvp.Value)
            Next

            If t >= 1.0 Then
                Boat.Location = boatEnd
                For Each kvp In assignedSlot
                    kvp.Key.Location = GetSlotPos(kvp.Value)
                Next
                boatMoving = False
                boatArrived = True

                Boat.Image = GetImage(If(boatAtA, "pnd_boat_left.png", "pnd_boat_right.png"))
            End If
        End If

        If activeAnims.Count = 0 AndAlso Not boatMoving Then animTimer.Stop()

        ' If time ran out mid-animation, don't show win/lose messages on top of it
        If gameOver Then Return

        ' Passengers now count for the bank the boat arrived at
        If boatArrived AndAlso IsGameOver(False) Then
            EndGame("Game Over")
            Return
        End If

        ' Win check once the last jump has finished
        If characterLanded AndAlso activeAnims.Count = 0 AndAlso HasWon() Then
            EndGame("You Win!")
        End If
    End Sub
End Class