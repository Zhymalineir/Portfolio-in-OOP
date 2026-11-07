Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class week8

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Shared Sub EnableDoubleBuffer(c As Control)
        GetType(Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic) _
            .SetValue(c, True, Nothing)
    End Sub

    Private ReadOnly panelColor As Color = ColorTranslator.FromHtml("#c7e8f7")

    Private frames() As Image
    Private frameIndex As Integer = 0
    Private ReadOnly spinTimer As New System.Windows.Forms.Timer() With {.Interval = 400}

    Private Const DRAG_STEP As Integer = 30
    Private Const DRAG_RIGHT_TURNS As Integer = 1
    Private dragging As Boolean = False
    Private dragStartX As Integer

    Private lessonHandlerAttached As Boolean = False

    Private Const INTRO_TEXT As String =
        "DIALOG BOX" & vbCrLf & vbCrLf &
        "Dialog boxes are built-in Windows Forms boxes used for tasks such as opening and saving files, " &
        "printing, choosing colors and fonts, and setting page options. " &
        "They reduce the developer's time and workload."

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer,
                                          <MarshalAs(UnmanagedType.Bool)> bShow As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_SETREDRAW As Integer = &HB

    Private Sub SetRedraw(c As Control, enabled As Boolean)
        SendMessage(c.Handle, WM_SETREDRAW, New IntPtr(If(enabled, 1, 0)), IntPtr.Zero)
        If enabled Then c.Invalidate(True)
    End Sub

    Private page1Image As Image
    Private page2Image As Image

    Private Const SB_BOTH As Integer = 3
    Private hidingScrollBars As Boolean = False

    Private Sub HidePanel2ScrollBars()
        If hidingScrollBars OrElse Not Panel2.IsHandleCreated Then Return
        hidingScrollBars = True
        ShowScrollBar(Panel2.Handle, SB_BOTH, False)
        hidingScrollBars = False
    End Sub

    Private Sub Panel2_ScrollBarEvents(sender As Object, e As EventArgs) Handles Panel2.Layout, Panel2.Resize, Panel2.VisibleChanged, Panel2.HandleCreated
        HidePanel2ScrollBars()
    End Sub

    Private Sub Panel2_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel2.Scroll
        HidePanel2ScrollBars()
    End Sub

    Private Sub ReparentTo(newParent As Control, makeTransparent As Boolean, ParamArray controlNames() As String)
        For Each name As String In controlNames
            Dim found() As Control = Me.Controls.Find(name, True)
            If found.Length = 0 Then
                Debug.WriteLine("ReparentTo: no control named '" & name & "' was found")
                Continue For
            End If

            Dim c As Control = found(0)
            If c Is newParent OrElse c.Parent Is Nothing Then Continue For

            Dim screenLocation As Point = c.Parent.PointToScreen(c.Location)
            c.Parent = newParent
            c.Location = newParent.PointToClient(screenLocation)
            If makeTransparent Then
                If Not TrySetTransparent(c) Then
                    Debug.WriteLine("ReparentTo: " & c.Name & " (" & c.GetType().Name & ") can't be transparent")
                End If
            End If
            EnableDoubleBuffer(c)
            c.BringToFront()
        Next
    End Sub

    Private Shared Function TrySetTransparent(c As Control) As Boolean
        Try
            c.BackColor = Color.Transparent
            Return True
        Catch ex As ArgumentException
            Return False
        End Try
    End Function

    Private Sub ShowPage1()
        SetRedraw(Me, False)
        Try
            Me.BackgroundImage = page1Image
            PictureBox1.Image = page1Image
            Panel2.Visible = False
            RTB2.BackColor = panelColor
            RTB2.Text = INTRO_TEXT
            RTB2.Select(0, 0)
            RTB2.Visible = True
        Finally
            SetRedraw(Me, True)
        End Try
    End Sub

    Private Sub week8_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RTB2.Select(0, 0)
        Me.ActiveControl = Nothing
    End Sub

    Private Sub ShowPage2()
        SetRedraw(Me, False)
        Try
            Me.BackgroundImage = page2Image
            PictureBox1.Image = page2Image
            RTB2.Visible = False
            Panel2.Visible = True
            HidePanel2ScrollBars()
        Finally
            SetRedraw(Me, True)
        End Try
    End Sub

    Private Sub week8_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DoubleBuffered = True
        EnableDoubleBuffer(bg)

        page1Image = My.Resources.wk8a
        page2Image = My.Resources.wk8b

        ReparentTo(bg, False, "PictureBox1")
        ReparentTo(bg, True, "uibar", "lvlname", "clock",
                   "weapon1", "weapon2", "weapon3", "weapon4", "weapon5", "weapon6",
                   "backbtn", "picAvatar")
        ReparentTo(PictureBox1, True, "pb1", "pb2")

        Panel2.BackColor = panelColor
        RTB2.TabStop = False

        frames = {My.Resources.me1, My.Resources.me2, My.Resources.me3, My.Resources.me4}
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picAvatar.Image = frames(0)
        picAvatar.Cursor = Cursors.Hand

        AddHandler spinTimer.Tick, Sub(s, ev) Rotate(1)

        ShowPage1()
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        ShowPage1()
    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        ShowPage2()
    End Sub

    Private Sub Rotate(direction As Integer)
        If frames Is Nothing Then Return
        frameIndex = (frameIndex + direction + frames.Length) Mod frames.Length
        picAvatar.Image = frames(frameIndex)
    End Sub

    Private Sub week8_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If picAvatar.ClientRectangle.Contains(picAvatar.PointToClient(Cursor.Position)) Then
            Rotate(If(e.Delta > 0, 1, -1))
        End If
    End Sub

    Private Sub picAvatar_MouseDown(sender As Object, e As MouseEventArgs) Handles picAvatar.MouseDown
        If e.Button <> MouseButtons.Left Then Return

        spinTimer.Stop()
        dragging = True
        dragStartX = e.X
        picAvatar.Cursor = Cursors.SizeWE
    End Sub

    Private Sub picAvatar_MouseMove(sender As Object, e As MouseEventArgs) Handles picAvatar.MouseMove
        If Not dragging Then Return

        Dim dx As Integer = e.X - dragStartX

        While Math.Abs(dx) >= DRAG_STEP
            Dim dir As Integer = If(dx > 0, 1, -1)
            Rotate(dir * DRAG_RIGHT_TURNS)
            dragStartX += dir * DRAG_STEP
            dx = e.X - dragStartX
        End While
    End Sub

    Private Sub picAvatar_MouseUp(sender As Object, e As MouseEventArgs) Handles picAvatar.MouseUp
        dragging = False
        picAvatar.Cursor = Cursors.Hand
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim lessonForm As Lesson = Application.OpenForms.OfType(Of Lesson)().FirstOrDefault()
        If lessonForm Is Nothing Then
            lessonForm = New Lesson()
            lessonHandlerAttached = False
        End If
        If Not lessonHandlerAttached Then
            AddHandler lessonForm.FormClosed, Sub(s, ev) Me.Show()
            lessonHandlerAttached = True
        End If
        Me.Hide()
        lessonForm.Show()
    End Sub

    Private Sub week8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        spinTimer.Dispose()
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub dialog_color_Click(sender As Object, e As EventArgs) Handles dialog_color.Click
        Using cd As New ColorDialog()
            If cd.ShowDialog() = DialogResult.OK Then
                Me.BackColor = cd.Color
            End If
        End Using
    End Sub

    Private Sub dialog_openfile_Click(sender As Object, e As EventArgs) Handles dialog_openfile.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Open File"
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("You selected: " & ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub dialog_font_Click(sender As Object, e As EventArgs) Handles dialog_font.Click
        Using fd As New FontDialog()
            fd.Font = Me.Font
            If fd.ShowDialog() = DialogResult.OK Then
                Me.Font = fd.Font
            End If
        End Using
    End Sub

    Private Sub dialog_savefile_Click(sender As Object, e As EventArgs) Handles dialog_savefile.Click
        Using sfd As New SaveFileDialog()
            sfd.Title = "Save File"
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            If sfd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Save to: " & sfd.FileName)
            End If
        End Using
    End Sub

    Private Sub dialog_print_Click(sender As Object, e As EventArgs) Handles dialog_print.Click
        Using pd As New PrintDialog()
            pd.PrinterSettings = New PrinterSettings()
            If pd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Printer selected: " & pd.PrinterSettings.PrinterName)
            End If
        End Using
    End Sub

End Class