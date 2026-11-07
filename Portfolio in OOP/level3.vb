Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Threading.Tasks

Public Class level3

    ' ---------- Settings ----------
    Private ReadOnly EnemySize As New Size(79, 89)
    Private ReadOnly SpawnPoint As New Point(551, 48)
    Private ReadOnly LaneTargets() As Point = {
        New Point(430, 414),   ' lane 0 -> A
        New Point(510, 414),   ' lane 1 -> S
        New Point(592, 414),   ' lane 2 -> K
        New Point(674, 414)    ' lane 3 -> L
    }
    Private Const EnemySpeed As Single = 20.0F
    Private Const SpawnCheckMs As Integer = 10   ' how often we check if it's time to spawn (not the spawn rate)
    Private Const MaxMisses As Integer = 3

    ' ---------- Spawn pattern ----------
    ' Each entry is SpawnEntry(howMany, seconds):
    '   howMany = how many devils spawn (1 to 4). The lanes are random
    '             (never the same lane twice in the same entry).
    '   seconds = WHEN they spawn, in seconds after the game starts. Decimals are fine
    '             (0.5 = half a second, 2.75 = two and three quarter seconds).
    ' Entries don't have to be in order.
    ' Example: New SpawnEntry(2, 5.5) = two devils spawn at 5.5 seconds.
    Private Class SpawnEntry
        Public HowMany As Integer
        Public TimeSec As Double
        Public Done As Boolean = False

        Public Sub New(howMany As Integer, timeSec As Double)
            Me.HowMany = howMany
            Me.TimeSec = timeSec
        End Sub
    End Class

    Private ReadOnly SpawnPattern() As SpawnEntry = {
        New SpawnEntry(1, 1.8),
        New SpawnEntry(1, 2.1),
        New SpawnEntry(1, 2.6),
        New SpawnEntry(1, 3.2),
        New SpawnEntry(1, 3.6),
        New SpawnEntry(1, 4.1),
        New SpawnEntry(1, 4.6),
        New SpawnEntry(1, 5.3),
        New SpawnEntry(1, 5.8),
        New SpawnEntry(1, 6.3),
        New SpawnEntry(2, 6.8),
        New SpawnEntry(1, 7.4),
        New SpawnEntry(1, 7.8),
        New SpawnEntry(1, 8.3),
        New SpawnEntry(1, 8.8),
        New SpawnEntry(1, 9.2),
        New SpawnEntry(1, 9.7),
        New SpawnEntry(1, 10.1),
        New SpawnEntry(1, 10.5),
        New SpawnEntry(1, 11.0),
        New SpawnEntry(1, 11.5),
        New SpawnEntry(2, 12.1),
        New SpawnEntry(1, 12.6),
        New SpawnEntry(1, 13.0),
        New SpawnEntry(2, 13.6),
        New SpawnEntry(3, 14.2),
        New SpawnEntry(1, 14.7),
        New SpawnEntry(1, 15.1),
        New SpawnEntry(3, 15.6),
        New SpawnEntry(1, 16.1),
        New SpawnEntry(2, 16.6),
        New SpawnEntry(1, 17.1),
        New SpawnEntry(1, 17.7),
        New SpawnEntry(1, 18.1),
        New SpawnEntry(1, 18.5),
        New SpawnEntry(2, 19.0),
        New SpawnEntry(1, 19.5),
        New SpawnEntry(2, 19.9),
        New SpawnEntry(2, 20.4),
        New SpawnEntry(1, 20.8),
        New SpawnEntry(1, 21.3),
        New SpawnEntry(1, 21.8),
        New SpawnEntry(1, 22.3),
        New SpawnEntry(1, 22.7),
        New SpawnEntry(2, 23.2),
        New SpawnEntry(1, 23.7),
        New SpawnEntry(1, 24.1),
        New SpawnEntry(2, 24.5),
        New SpawnEntry(1, 25.0),
        New SpawnEntry(1, 25.5),
        New SpawnEntry(2, 26.1),
        New SpawnEntry(2, 26.6),
        New SpawnEntry(1, 27.1),
        New SpawnEntry(1, 27.6),
        New SpawnEntry(1, 28.3),
        New SpawnEntry(2, 28.7),
        New SpawnEntry(2, 29.3),
        New SpawnEntry(1, 29.7),
        New SpawnEntry(4, 30.4),
        New SpawnEntry(1, 30.7),
        New SpawnEntry(1, 31.1),
        New SpawnEntry(2, 31.6),
        New SpawnEntry(1, 32.1),
        New SpawnEntry(1, 32.7),
        New SpawnEntry(1, 33.2),
        New SpawnEntry(2, 33.8),
        New SpawnEntry(2, 34.3),
        New SpawnEntry(1, 34.7),
        New SpawnEntry(2, 35.3),
        New SpawnEntry(1, 35.7),
        New SpawnEntry(2, 36.2),
        New SpawnEntry(2, 36.6),
        New SpawnEntry(1, 37.1),
        New SpawnEntry(1, 37.7),
        New SpawnEntry(2, 38.2),
        New SpawnEntry(3, 38.7),
        New SpawnEntry(1, 39.3),
        New SpawnEntry(2, 39.8),
        New SpawnEntry(1, 40.3),
        New SpawnEntry(2, 40.9),
        New SpawnEntry(2, 41.4),
        New SpawnEntry(4, 41.8),
        New SpawnEntry(2, 42.4),
        New SpawnEntry(1, 42.9),
        New SpawnEntry(1, 43.3),
        New SpawnEntry(2, 43.8),
        New SpawnEntry(1, 44.4),
        New SpawnEntry(1, 45.0),
        New SpawnEntry(1, 45.5),
        New SpawnEntry(1, 46.0),
        New SpawnEntry(1, 46.5),
        New SpawnEntry(2, 47.1),
        New SpawnEntry(1, 47.7),
        New SpawnEntry(1, 48.2),
        New SpawnEntry(1, 48.7),
        New SpawnEntry(2, 49.2),
        New SpawnEntry(1, 49.8),
        New SpawnEntry(1, 50.3),
        New SpawnEntry(1, 50.8),
        New SpawnEntry(2, 51.3),
        New SpawnEntry(2, 51.8),
        New SpawnEntry(2, 52.3),
        New SpawnEntry(1, 52.9),
        New SpawnEntry(1, 53.4),
        New SpawnEntry(1, 54.1),
        New SpawnEntry(2, 54.6),
        New SpawnEntry(3, 55.1),
        New SpawnEntry(1, 55.7),
        New SpawnEntry(1, 56.2),
        New SpawnEntry(1, 56.7),
        New SpawnEntry(1, 57.2),
        New SpawnEntry(1, 57.8),
        New SpawnEntry(2, 58.3),
        New SpawnEntry(1, 58.8),
        New SpawnEntry(1, 59.3),
        New SpawnEntry(1, 59.8),
        New SpawnEntry(1, 60.2),
        New SpawnEntry(1, 60.7),
        New SpawnEntry(3, 61.2),
        New SpawnEntry(2, 61.8),
        New SpawnEntry(1, 62.3),
        New SpawnEntry(2, 62.8),
        New SpawnEntry(2, 63.2),
        New SpawnEntry(1, 63.7),
        New SpawnEntry(2, 64.2),
        New SpawnEntry(2, 64.7),
        New SpawnEntry(2, 65.2),
        New SpawnEntry(2, 65.8),
        New SpawnEntry(1, 66.3),
        New SpawnEntry(1, 66.7),
        New SpawnEntry(1, 67.2)
    }
    Private ReadOnly spawnClock As New System.Diagnostics.Stopwatch()
    Private Const LoopPattern As Boolean = True   ' True = start over after the last entry, False = stop spawning
    Private Const LoopGapSec As Double = 2.0      ' pause (seconds) after the last entry before the pattern restarts

    ' ---------- Music ----------
    ' Where in the song the music starts, in milliseconds. 0 = from the beginning,
    ' 5000 = start at the 5 second mark, 90000 = start at 1:30, etc.
    Private Const BgmStartMs As Integer = 0

    ' Windows built-in media API (lets us start a wav from any position)
    Private Declare Auto Function mciSendString Lib "winmm.dll" (
        ByVal command As String,
        ByVal returnString As System.Text.StringBuilder,
        ByVal returnSize As Integer,
        ByVal hwndCallback As IntPtr) As Integer

    ' ---------- Timing windows ----------
    ' Distance (in pixels) between the devil and the line when you press the key.
    ' Smaller = more accurate. At speed 3 and 16ms ticks, 1px is about 5.3ms.
    Private Const GreatWindow As Single = 30.0F       ' <= 30px  -> Great
    Private Const NotBadWindow As Single = 70.0F      ' <= 70px  -> Not Bad
    Private Const IzzFineWindow As Single = 120.0F    ' <= 120px -> Izz Fine
    ' Pressing earlier than that (or with nothing in the lane) -> ???
    ' Devil reaching the line -> Hell Nah

    ' ---------- Ratings / stat counters ----------
    Private Enum Rating
        Great = 0
        NotBad = 1
        IzzFine = 2
        HellNah = 3
        Unknown = 4     ' the "???"
    End Enum

    Private statLabels() As Label                ' lbl_great, lbl_notbad, lbl_izzfine, lbl_hellnah, lbl_questionmark
    Private ReadOnly statNames() As String = {"Great", "Not Bad", "Izz Fine", "Hell Nah", "???"}
    Private ReadOnly statColors() As Color = {Color.Cyan, Color.Lime, Color.Yellow, Color.Red, Color.White}
    Private statCounts(4) As Integer
    Private statRects(4) As Rectangle
    Private statFonts(4) As Font
    Private statAligns(4) As ContentAlignment

    ' ---------- Enemy (no PictureBox anymore, it's just data that gets painted) ----------
    Private Class Enemy
        Public Lane As Integer
        Public Pos As PointF
    End Class

    Private enemies As New List(Of Enemy)
    Private rnd As New Random()
    Private score As Integer = 0
    Private combo As Integer = 0
    Private misses As Integer = 0

    ' Base points per rating (same order as the Rating enum): Great, Not Bad, Izz Fine, Hell Nah, ???
    Private ReadOnly statPoints() As Integer = {300, 200, 100, 0, 0}
    Private Const ComboPerBonus As Integer = 10      ' every 10 combo...
    Private Const BonusPerStep As Double = 0.1       ' ...adds +0.1 to the multiplier

    Private gameStarted As Boolean = False   ' becomes True only after btn_start disappears
    Private startClicked As Boolean = False  ' stops double clicks on btn_start
    Private gameOver As Boolean = False
    Private ratingToken As Integer = 0

    ' lbl_rating is also painted by us now (outlined)
    Private ratingText As String = ""
    Private ratingColor As Color = Color.White
    Private ratingRect As Rectangle
    Private ratingFont As Font
    Private ratingAlign As ContentAlignment

    ' ---------- Timers ----------
    Private WithEvents spawnTimer As New Timer() With {.Interval = SpawnCheckMs}
    Private WithEvents moveTimer As New Timer() With {.Interval = 16}
    Private WithEvents animTimer As New Timer() With {.Interval = 150}

    ' ---------- Images ----------
    Private devilFrames(3) As Image
    Private devilFrameIndex As Integer = 0   ' 0..3 (devil_1 .. devil_4)
    Private devilDirection As Integer = 1    ' +1 going 1->4, -1 going 4->1
    Private priestIdle As Image
    Private priestAttack1 As Image
    Private priestAttack2 As Image

    ' ---------- Priests (painted by us; the PictureBoxes are only used for position/size) ----------
    Private priestRects(3) As Rectangle
    Private priestImages(3) As Image

    Private Function LoadAsset(fileName As String) As Image
        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "assets", fileName)
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Return Image.FromStream(fs)
        End Using
    End Function

    Public Sub New()
        InitializeComponent()
        ' Stops flicker when we repaint every frame
        Me.DoubleBuffered = True
    End Sub

    ' Same behavior as PictureBox SizeMode = Zoom
    Private Sub DrawZoomed(g As Graphics, img As Image, bounds As Rectangle)
        Dim scale As Double = Math.Min(bounds.Width / img.Width, bounds.Height / img.Height)
        Dim w As Integer = CInt(img.Width * scale)
        Dim h As Integer = CInt(img.Height * scale)
        Dim x As Integer = bounds.X + (bounds.Width - w) \ 2
        Dim y As Integer = bounds.Y + (bounds.Height - h) \ 2
        g.DrawImage(img, New Rectangle(x, y, w, h))
    End Sub

    ' ---------- Outlined text helpers ----------
    ' Turns a label's TextAlign into a StringFormat (no wrapping, so long text never breaks into lines)
    Private Function MakeStringFormat(align As ContentAlignment) As StringFormat
        Dim sf As New StringFormat()
        sf.FormatFlags = StringFormatFlags.NoWrap

        Select Case align
            Case ContentAlignment.TopLeft, ContentAlignment.MiddleLeft, ContentAlignment.BottomLeft
                sf.Alignment = StringAlignment.Near
            Case ContentAlignment.TopCenter, ContentAlignment.MiddleCenter, ContentAlignment.BottomCenter
                sf.Alignment = StringAlignment.Center
            Case Else
                sf.Alignment = StringAlignment.Far
        End Select

        Select Case align
            Case ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight
                sf.LineAlignment = StringAlignment.Near
            Case ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight
                sf.LineAlignment = StringAlignment.Center
            Case Else
                sf.LineAlignment = StringAlignment.Far
        End Select

        Return sf
    End Function

    Private Sub DrawOutlinedText(g As Graphics, text As String, font As Font,
                                 bounds As Rectangle, align As ContentAlignment,
                                 fillColor As Color, outlineColor As Color,
                                 outlineWidth As Single)
        If String.IsNullOrEmpty(text) Then Return

        Using path As New GraphicsPath()
            Using sf As StringFormat = MakeStringFormat(align)
                Dim emSize As Single = font.SizeInPoints * g.DpiY / 72.0F
                path.AddString(text, font.FontFamily, CInt(font.Style), emSize, bounds, sf)
            End Using

            Using outlinePen As New Pen(outlineColor, outlineWidth)
                Using fillBrush As New SolidBrush(fillColor)
                    outlinePen.LineJoin = LineJoin.Round   ' smooth corners, no spikes

                    Dim oldMode As SmoothingMode = g.SmoothingMode
                    g.SmoothingMode = SmoothingMode.AntiAlias
                    g.DrawPath(outlinePen, path)   ' black outline first
                    g.FillPath(fillBrush, path)    ' colored fill on top
                    g.SmoothingMode = oldMode
                End Using
            End Using
        End Using
    End Sub

    ' ---------- Music ----------
    Private Sub PlayBgm()
        Dim file As String = System.IO.Path.Combine(Application.StartupPath, "assets", "c_bgm.wav")
        mciSendString("close bgm", Nothing, 0, IntPtr.Zero)
        mciSendString("open """ & file & """ type waveaudio alias bgm", Nothing, 0, IntPtr.Zero)
        mciSendString("play bgm from " & BgmStartMs, Nothing, 0, IntPtr.Zero)
    End Sub

    Private Sub StopBgm()
        mciSendString("stop bgm", Nothing, 0, IntPtr.Zero)
        mciSendString("close bgm", Nothing, 0, IntPtr.Zero)
    End Sub

    Private Sub level3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        For i As Integer = 0 To 3
            devilFrames(i) = LoadAsset("c_devil_" & (i + 1) & ".png")
        Next
        priestIdle = LoadAsset("c_priest.png")
        priestAttack1 = LoadAsset("c_priest_attack1.png")
        priestAttack2 = LoadAsset("c_priest_attack2.png")

        ' Remember where each Priest PictureBox sits, then hide it so we paint it ourselves
        Dim boxes() As PictureBox = {Priest1, Priest2, Priest3, Priest4}
        For i As Integer = 0 To 3
            priestRects(i) = boxes(i).Bounds
            priestImages(i) = priestIdle
            boxes(i).Visible = False
        Next

        ' Same idea for the five stat labels: keep their position/font/alignment, hide them,
        ' and paint "Name: count" with a black outline in OnPaint
        statLabels = {lbl_great, lbl_notbad, lbl_izzfine, lbl_hellnah, lbl_questionmark}
        For i As Integer = 0 To 4
            statRects(i) = statLabels(i).Bounds
            statFonts(i) = statLabels(i).Font
            statAligns(i) = statLabels(i).TextAlign
            statLabels(i).Visible = False
        Next

        ' lbl_rating too: just a position/font/alignment holder
        ratingRect = lbl_rating.Bounds
        ratingFont = lbl_rating.Font
        ratingAlign = lbl_rating.TextAlign
        lbl_rating.Visible = False

        ' score/combo "buttons" are display only
        btn_score.TabStop = False
        btn_combo.TabStop = False
        UpdateScoreDisplay()

        UpdateTitle()
        ' Nothing starts here anymore. The game starts after btn_start is clicked (see below).
    End Sub

    ' ---------- Start button ----------
    Private Async Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If startClicked Then Return
        startClicked = True
        My.Computer.Audio.Stop()

        btn_start.BackgroundImage = Image.FromFile("Assets\c_startbtn_clicked.png")
        My.Computer.Audio.Play("Assets\c_bgm.wav", AudioPlayMode.Background)
        Await Task.Delay(500)   ' show the clicked image for 0.5 seconds
        If Me.IsDisposed Then Return

        btn_start.Visible = False
        StartGame()
    End Sub

    Private Sub StartGame()
        gameStarted = True
        For Each entry As SpawnEntry In SpawnPattern
            entry.Done = False
        Next
        spawnClock.Restart()
        PlayBgm()
        spawnTimer.Start()
        moveTimer.Start()
        animTimer.Start()
    End Sub

    ' ---------- Custom painting ----------
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.InterpolationMode = InterpolationMode.NearestNeighbor
        g.PixelOffsetMode = PixelOffsetMode.Half

        ' Enemies
        Dim devilImg As Image = devilFrames(devilFrameIndex)
        If devilImg IsNot Nothing Then
            For Each en As Enemy In enemies
                DrawZoomed(g, devilImg, New Rectangle(CInt(en.Pos.X), CInt(en.Pos.Y),
                                                      EnemySize.Width, EnemySize.Height))
            Next
        End If

        ' Priests
        For i As Integer = 0 To 3
            If priestImages(i) IsNot Nothing Then
                DrawZoomed(g, priestImages(i), priestRects(i))
            End If
        Next

        ' Stat counters (outlined)
        For i As Integer = 0 To 4
            DrawOutlinedText(g, statNames(i) & ": " & statCounts(i), statFonts(i),
                             statRects(i), statAligns(i), statColors(i), Color.Black, 3.0F)
        Next

        ' Rating flash (outlined), drawn last so it's on top of everything
        DrawOutlinedText(g, ratingText, ratingFont, ratingRect, ratingAlign,
                         ratingColor, Color.Black, 3.0F)
    End Sub

    ' ---------- Spawning ----------
    ' Picks 'count' different random lanes (0..3). Count is clamped to 0..4.
    Private Function RandomLanes(count As Integer) As Integer()
        count = Math.Max(0, Math.Min(4, count))
        Dim available As New List(Of Integer) From {0, 1, 2, 3}
        Dim result(count - 1) As Integer      ' count = 0 gives an empty array
        For i As Integer = 0 To count - 1
            Dim pick As Integer = rnd.Next(available.Count)
            result(i) = available(pick)
            available.RemoveAt(pick)
        Next
        Return result
    End Function

    ' The latest spawn time (seconds) used in SpawnPattern
    Private Function LastSpawnTime() As Double
        Dim last As Double = 0
        For Each entry As SpawnEntry In SpawnPattern
            If entry.TimeSec > last Then last = entry.TimeSec
        Next
        Return last
    End Function

    ' Runs every SpawnCheckMs and spawns any entry whose time has come
    Private Sub spawnTimer_Tick(sender As Object, e As EventArgs) Handles spawnTimer.Tick
        Dim nowSec As Double = spawnClock.Elapsed.TotalSeconds
        Dim allDone As Boolean = True

        For Each entry As SpawnEntry In SpawnPattern
            If Not entry.Done Then
                If nowSec >= entry.TimeSec Then
                    entry.Done = True
                    For Each lane As Integer In RandomLanes(entry.HowMany)
                        Dim en As New Enemy()
                        en.Lane = lane
                        en.Pos = New PointF(SpawnPoint.X, SpawnPoint.Y)
                        enemies.Add(en)
                    Next
                Else
                    allDone = False
                End If
            End If
        Next

        ' Everything has spawned
        If allDone Then
            If LoopPattern Then
                If nowSec >= LastSpawnTime() + LoopGapSec Then
                    For Each entry As SpawnEntry In SpawnPattern
                        entry.Done = False
                    Next
                    spawnClock.Restart()
                End If
            Else
                spawnTimer.Stop()   ' no more devils
            End If
        End If
    End Sub

    ' ---------- Movement ----------
    Private Sub moveTimer_Tick(sender As Object, e As EventArgs) Handles moveTimer.Tick
        For i As Integer = enemies.Count - 1 To 0 Step -1
            Dim en As Enemy = enemies(i)
            Dim target As Point = LaneTargets(en.Lane)

            Dim dx As Single = target.X - en.Pos.X
            Dim dy As Single = target.Y - en.Pos.Y
            Dim dist As Single = CSng(Math.Sqrt(dx * dx + dy * dy))

            If dist <= EnemySpeed Then
                ' devil reached the line = missed
                enemies.RemoveAt(i)
                misses += 1
                Judge(Rating.HellNah)
                UpdateTitle()
                If misses >= MaxMisses Then
                    EndGame()
                    Return
                End If
            Else
                en.Pos = New PointF(en.Pos.X + dx / dist * EnemySpeed,
                                    en.Pos.Y + dy / dist * EnemySpeed)
            End If
        Next

        Me.Invalidate()
    End Sub

    ' ---------- Devil animation: 1,2,3,4,3,2,1,2,3,4... ----------
    Private Sub animTimer_Tick(sender As Object, e As EventArgs) Handles animTimer.Tick
        devilFrameIndex += devilDirection
        If devilFrameIndex >= 3 Then
            devilFrameIndex = 3
            devilDirection = -1
        ElseIf devilFrameIndex <= 0 Then
            devilFrameIndex = 0
            devilDirection = 1
        End If
        Me.Invalidate()
    End Sub

    ' ---------- Input ----------
    Private Sub level3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not gameStarted OrElse gameOver Then Return

        Select Case e.KeyCode
            Case Keys.A
                PlayerAttack(0, priestAttack1)
            Case Keys.S
                PlayerAttack(1, priestAttack1)
            Case Keys.K
                PlayerAttack(2, priestAttack2)
            Case Keys.L
                PlayerAttack(3, priestAttack2)
            Case Else
                Return
        End Select
        e.Handled = True
    End Sub

    ' How far the devil still has to travel to reach its line
    Private Function DistanceToLine(en As Enemy) As Single
        Dim target As Point = LaneTargets(en.Lane)
        Dim dx As Single = target.X - en.Pos.X
        Dim dy As Single = target.Y - en.Pos.Y
        Return CSng(Math.Sqrt(dx * dx + dy * dy))
    End Function

    Private Sub PlayerAttack(lane As Integer, attackImg As Image)
        ShowAttack(lane, attackImg)

        ' devil in this lane that's closest to the line
        Dim closest As Enemy = Nothing
        Dim closestDist As Single = Single.MaxValue
        For Each en As Enemy In enemies
            If en.Lane = lane Then
                Dim d As Single = DistanceToLine(en)
                If d < closestDist Then
                    closest = en
                    closestDist = d
                End If
            End If
        Next

        ' nothing in range = pressed too early / whiffed, nothing gets hit
        If closest Is Nothing OrElse closestDist > IzzFineWindow Then
            Judge(Rating.Unknown)
            Return
        End If

        If closestDist <= GreatWindow Then
            Judge(Rating.Great)
        ElseIf closestDist <= NotBadWindow Then
            Judge(Rating.NotBad)
        Else
            Judge(Rating.IzzFine)
        End If

        enemies.Remove(closest)
        UpdateTitle()
        Me.Invalidate()
    End Sub

    ' Lane index = priest index (0 = Priest1 ... 3 = Priest4)
    Private Async Sub ShowAttack(index As Integer, attackImg As Image)
        priestImages(index) = attackImg
        Me.Invalidate(priestRects(index))
        Await Task.Delay(150)
        If Not Me.IsDisposed Then
            priestImages(index) = priestIdle
            Me.Invalidate(priestRects(index))
        End If
    End Sub

    ' ---------- Rating ----------
    ' Counts the rating (updates the "Great: 0" style counters) and flashes it on lbl_rating
    Private Sub Judge(r As Rating)
        Dim i As Integer = CInt(r)
        statCounts(i) += 1

        If r = Rating.HellNah OrElse r = Rating.Unknown Then
            combo = 0                    ' a miss or a whiff breaks the combo
        Else
            combo += 1
            score += CInt(Math.Round(statPoints(i) * ScoreMultiplier()))
        End If

        UpdateScoreDisplay()
        ShowRating(statNames(i), statColors(i))
        Me.Invalidate()
    End Sub

    ' 1.0 at the start, +0.1 for every 10 combo (10 = x1.1, 20 = x1.2, ...)
    Private Function ScoreMultiplier() As Double
        Return 1.0 + (combo \ ComboPerBonus) * BonusPerStep
    End Function

    Private Sub UpdateScoreDisplay()
        btn_score.Text = score.ToString()
        btn_combo.Text = combo.ToString()
    End Sub

    Private Async Sub ShowRating(text As String, color As Color)
        ratingToken += 1
        Dim myToken As Integer = ratingToken

        ratingText = text
        ratingColor = color
        Me.Invalidate()

        Await Task.Delay(600)
        ' only clear it if a newer rating hasn't replaced this one
        If Not Me.IsDisposed AndAlso myToken = ratingToken Then
            ratingText = ""
            Me.Invalidate()
        End If
    End Sub

    ' ---------- Game state ----------
    Private Sub UpdateTitle()
        Me.Text = "Score: " & score & "   Misses: " & misses & "/" & MaxMisses
    End Sub

    Private Sub EndGame()
        gameOver = True
        spawnTimer.Stop()
        moveTimer.Stop()
        animTimer.Stop()
        StopBgm()
        MessageBox.Show("Game over! Score: " & score, "Level 3")
    End Sub

    Private Sub level3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        spawnTimer.Stop()
        moveTimer.Stop()
        animTimer.Stop()
        My.Computer.Audio.Stop()
        StopBgm()
        My.Computer.Audio.Play("Elements\ost.wav", AudioPlayMode.Background)
    End Sub
End Class