Public Class level2

    ' ---- Settings you can tweak ----
    ' ONE range for everything: the Left (X location) of the player AND of every spawned enemy
    ' can be anywhere from MIN_X to MAX_X. Nothing is subtracted from it anywhere.
    Private Const MIN_X As Integer = 420
    Private Const MAX_X As Integer = 656

    Private Const ENEMY_WIDTH As Integer = 104
    Private Const ENEMY_HEIGHT As Integer = 96
    Private Const ENEMY_SPEED As Double = 170.0        ' starting speed (pixels per SECOND)
    Private Const ENEMY_SPEED_GAIN As Double = 3.0     ' extra pixels per second added every second
    Private Const ENEMY_SPEED_MAX As Double = 500.0
    Private Const LOSE_Y As Integer = 68           ' an enemy reaching this Y = you lose
    Private Const PLAYER_SPEED As Double = 350.0   ' top speed in pixels per SECOND
    Private Const PLAYER_EASE As Double = 0.25     ' 0 to 1: higher = snappier, lower = floatier

    Private Const ATTACK_COOLDOWN As Double = 0.5  ' seconds between auto-attacks
    Private Const THROW_POSE_TIME As Double = 0.25 ' seconds the throwing pose stays on screen
    Private Const BULLET_SPEED As Double = 500.0   ' pixels per SECOND an attack travels down

    Private Const WATER_SCALE As Double = 1.0      ' holy water size (1.0 = the image's own size)
    Private Const CROSS_SCALE As Double = 0.1     ' holy cross size (smaller than the water)
    Private Const WATER_MAX_USES As Integer = 5    ' how many times the holy water can be thrown
    Private Const WATER_RECHARGE_TIME As Double = 30.0   ' seconds after the last throw until the water is usable again

    Private score As Integer = 0
    ' Enemies and attacks are plain data, not controls. They are drawn in Canvas_Paint.
    Private Class Enemy
        Public X As Double
        Public Y As Double
    End Class

    Private Class Bullet
        Public X As Double
        Public Y As Double
        Public Img As Image
        Public W As Integer
        Public H As Integer
    End Class

    Private Enum AttackType
        Cross       ' default, unlimited
        Water       ' limited uses
    End Enum

    Private ReadOnly rnd As New Random()
    Private ReadOnly enemies As New List(Of Enemy)
    Private ReadOnly bullets As New List(Of Bullet)
    Private ReadOnly gameTimer As New System.Windows.Forms.Timer() With {.Interval = 16}      ' moves + redraws
    Private ReadOnly spawnTimer As New System.Windows.Forms.Timer() With {.Interval = 650}   ' creates a new enemy
    Private ReadOnly animTimer As New System.Windows.Forms.Timer() With {.Interval = 250}     ' swaps enemy frames
    Private ReadOnly clock As New Stopwatch()
    Private lastSeconds As Double = 0

    ' Images (all loaded once from the Assets folder)
    Private enemyFrames(1) As Image
    Private frameIndex As Integer = 0
    Private playerIdle As Image
    Private playerThrow As Image
    Private playerGameOver As Image
    Private waterImage As Image
    Private crossImage As Image
    Private waterW As Integer
    Private waterH As Integer
    Private crossW As Integer
    Private crossH As Integer

    ' Player state (the designer's Player is only used to read its size and position)
    Private playerSize As Size
    Private playerY As Integer
    Private movingLeft As Boolean = False
    Private movingRight As Boolean = False
    Private playerX As Double          ' exact position (decimals, so slow movement stays smooth)
    Private playerVelocity As Double   ' pixels per second

    ' Attack and game state
    Private selectedAttack As AttackType = AttackType.Cross
    Private waterUsesLeft As Integer = WATER_MAX_USES
    Private waterReadyAt As Double = 0     ' clock time when the used-up water comes back
    Private nextAttackAt As Double = 0     ' clock time when the next attack is allowed
    Private throwUntil As Double = 0       ' clock time until which the throwing pose is shown
    Private isGameOver As Boolean = False

    ' The surface everything is drawn on
    Private canvas As Control
    Private canvasOffset As Point

    ' ------------------------------------------------------------------
    ' Setup
    ' ------------------------------------------------------------------
    Private Sub level2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DoubleBuffered = True
        Me.KeyPreview = True               ' lets the form see A and D even if a button has focus

        ' "Copy always" puts the Assets folder next to the .exe, so StartupPath finds it
        enemyFrames(0) = LoadAsset("r_devil_climb_1.png")
        enemyFrames(1) = LoadAsset("r_devil_climb_2.png")
        playerIdle = LoadAsset("r_priest.png")
        playerThrow = LoadAsset("r_priest_throw.png")
        playerGameOver = LoadAsset("r_gameover.png")
        waterImage = LoadAsset("r_holywater_atk.png")
        crossImage = LoadAsset("r_holycross_atk.png")

        If enemyFrames(0) Is Nothing OrElse enemyFrames(1) Is Nothing OrElse playerIdle Is Nothing OrElse
           playerThrow Is Nothing OrElse playerGameOver Is Nothing OrElse
           waterImage Is Nothing OrElse crossImage Is Nothing Then Return

        waterW = CInt(waterImage.Width * WATER_SCALE)
        waterH = CInt(waterImage.Height * WATER_SCALE)
        crossW = CInt(crossImage.Width * CROSS_SCALE)
        crossH = CInt(crossImage.Height * CROSS_SCALE)

        ' Read what we need from the designer's Player, then hide it (we draw the player ourselves)
        playerSize = Player.Size
        playerY = Player.Top
        playerX = Math.Max(MIN_X, Math.Min(MAX_X, Player.Left))
        Player.Visible = False

        canvas = FindCanvas()
        canvasOffset = If(canvas Is Me, Point.Empty, canvas.Location)
        AddHandler canvas.Paint, AddressOf Canvas_Paint

        AddHandler gameTimer.Tick, AddressOf GameTimer_Tick
        AddHandler spawnTimer.Tick, AddressOf SpawnTimer_Tick
        AddHandler animTimer.Tick, AddressOf AnimTimer_Tick

        clock.Start()
        gameTimer.Start()
        spawnTimer.Start()
        animTimer.Start()
    End Sub

    ' Draws on the big background PictureBox if there is one, otherwise on the form itself.
    ' To force one, replace the body with:  Return YourBackgroundPictureBox
    Private Function FindCanvas() As Control
        Dim best As PictureBox = Nothing
        For Each pb As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If pb.Width >= Me.ClientSize.Width * 0.9 AndAlso pb.Height >= Me.ClientSize.Height * 0.9 Then
                If best Is Nothing OrElse pb.Width * pb.Height > best.Width * best.Height Then best = pb
            End If
        Next
        If best IsNot Nothing Then Return best
        Return Me
    End Function

    Private Function LoadAsset(fileName As String) As Image
        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", fileName)
        If Not System.IO.File.Exists(path) Then
            MessageBox.Show("Can't find: " & path)
            Return Nothing
        End If
        Return Image.FromFile(path)        ' loaded once and reused
    End Function

    Private Sub level2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        gameTimer.Dispose()
        spawnTimer.Dispose()
        animTimer.Dispose()
        For Each img As Image In {enemyFrames(0), enemyFrames(1), playerIdle, playerThrow, playerGameOver, waterImage, crossImage}
            If img IsNot Nothing Then img.Dispose()
        Next
    End Sub

    ' ------------------------------------------------------------------
    ' Keyboard (A = left, D = right)
    ' ------------------------------------------------------------------
    Private Sub level2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then movingLeft = True
        If e.KeyCode = Keys.D Then movingRight = True
    End Sub

    Private Sub level2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then movingLeft = False
        If e.KeyCode = Keys.D Then movingRight = False
    End Sub

    ' If the window loses focus while a key is held, the KeyUp never arrives, so reset
    Private Sub level2_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        movingLeft = False
        movingRight = False
    End Sub

    ' ------------------------------------------------------------------
    ' Choosing the attack
    ' ------------------------------------------------------------------
    Private Sub item_holycross_Click(sender As Object, e As EventArgs) Handles item_holycross.Click
        selectedAttack = AttackType.Cross
    End Sub

    Private Sub item_holywater_Click(sender As Object, e As EventArgs) Handles item_holywater.Click
        If waterUsesLeft > 0 Then selectedAttack = AttackType.Water    ' used up = ignored
    End Sub

    ' ------------------------------------------------------------------
    ' Spawning and animation
    ' ------------------------------------------------------------------
    Private Sub SpawnTimer_Tick(sender As Object, e As EventArgs)
        Dim en As New Enemy()
        ' Anywhere from MIN_X to MAX_X (+ 1 because Random.Next's upper limit is exclusive)
        en.X = rnd.Next(MIN_X, MAX_X + 1)
        en.Y = Me.ClientSize.Height               ' just below the bottom edge
        enemies.Add(en)
    End Sub

    ' Alternates between the two frames for every enemy at once
    Private Sub AnimTimer_Tick(sender As Object, e As EventArgs)
        frameIndex = 1 - frameIndex
    End Sub

    ' ------------------------------------------------------------------
    ' Game loop
    ' ------------------------------------------------------------------
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs)
        ' Movement uses real elapsed time, so speed stays the same even if a tick comes late
        Dim now As Double = clock.Elapsed.TotalSeconds
        Dim dt As Double = Math.Min(now - lastSeconds, 0.1)
        lastSeconds = now

        MovePlayer(dt)
        RechargeWater(now)
        AutoAttack(now)

        ' 1. Enemies climb
        Dim enemySpeed As Double = Math.Min(ENEMY_SPEED + ENEMY_SPEED_GAIN * now, ENEMY_SPEED_MAX)
        For Each en As Enemy In enemies
            en.Y -= enemySpeed * dt
        Next

        ' 2. Attacks fall and kill the first enemy they touch
        MoveBullets(dt)

        ' 3. Any enemy that reached the line disappears, and the game ends
        For i As Integer = enemies.Count - 1 To 0 Step -1
            If enemies(i).Y <= LOSE_Y Then
                enemies.RemoveAt(i)
                GameOver()
                Return
            End If
        Next

        canvas.Invalidate()
    End Sub

    ' Smooth movement: speed eases toward the target instead of jumping to it
    Private Sub MovePlayer(dt As Double)
        Dim direction As Integer = 0
        If movingLeft Then direction -= 1
        If movingRight Then direction += 1       ' both keys held cancel out

        Dim targetVelocity As Double = direction * PLAYER_SPEED
        Dim k As Double = 1 - Math.Pow(1 - PLAYER_EASE, dt / 0.02)   ' same feel at any frame rate
        playerVelocity += (targetVelocity - playerVelocity) * k
        If Math.Abs(playerVelocity) < 2 Then playerVelocity = 0

        playerX += playerVelocity * dt

        ' Same limits as the enemy spawn range
        If playerX < MIN_X Then
            playerX = MIN_X
            playerVelocity = 0
        End If
        If playerX > MAX_X Then
            playerX = MAX_X
            playerVelocity = 0
        End If
    End Sub

    ' ------------------------------------------------------------------
    ' Auto attack
    ' ------------------------------------------------------------------
    Private Sub AutoAttack(now As Double)
        If now < nextAttackAt Then Return           ' still on cooldown

        nextAttackAt = now + ATTACK_COOLDOWN
        throwUntil = now + THROW_POSE_TIME          ' show the throwing pose for a moment

        Dim b As New Bullet()

        If selectedAttack = AttackType.Water AndAlso waterUsesLeft > 0 Then
            b.Img = waterImage
            b.W = waterW
            b.H = waterH

            waterUsesLeft -= 1
            If waterUsesLeft = 0 Then
                ' That was the last one: switch back to the default and hide the item until it recharges
                selectedAttack = AttackType.Cross
                item_holywater.Visible = False
                waterReadyAt = now + WATER_RECHARGE_TIME
            End If
        Else
            b.Img = crossImage
            b.W = crossW
            b.H = crossH
        End If

        b.X = playerX + (playerSize.Width - b.W) / 2      ' centered on the player's current position
        b.Y = playerY + playerSize.Height - b.H           ' starts at the player's feet and goes down
        bullets.Add(b)
    End Sub

    ' Once the recharge time has passed, the holy water gets all its charges back
    Private Sub RechargeWater(now As Double)
        If waterUsesLeft = 0 AndAlso now >= waterReadyAt Then
            waterUsesLeft = WATER_MAX_USES
            item_holywater.Visible = True
        End If
    End Sub

    Private Sub MoveBullets(dt As Double)
        For i As Integer = bullets.Count - 1 To 0 Step -1
            Dim b As Bullet = bullets(i)
            b.Y += BULLET_SPEED * dt

            ' Off the bottom of the screen: gone
            If b.Y > Me.ClientSize.Height Then
                bullets.RemoveAt(i)
                Continue For
            End If

            ' Hit test: if several enemies overlap, the one nearest the top (the first one reached) is hit
            Dim bulletRect As New Rectangle(CInt(b.X), CInt(b.Y), b.W, b.H)
            Dim target As Enemy = Nothing
            For Each en As Enemy In enemies
                Dim enemyRect As New Rectangle(CInt(en.X), CInt(en.Y), ENEMY_WIDTH, ENEMY_HEIGHT)
                If bulletRect.IntersectsWith(enemyRect) Then
                    If target Is Nothing OrElse en.Y < target.Y Then target = en
                End If
            Next

            If target IsNot Nothing Then
                enemies.Remove(target)      ' bam, enemy bye bye
                bullets.RemoveAt(i)         ' the attack is used up
                score += 1
                lbl_score.Text = "SCORE: " & score
            End If
        Next
    End Sub

    ' ------------------------------------------------------------------
    ' Game over
    ' ------------------------------------------------------------------
    Private Sub GameOver()
        isGameOver = True
        gameTimer.Stop()
        spawnTimer.Stop()
        animTimer.Stop()

        canvas.Invalidate()
        canvas.Update()             ' draw the game over image NOW, before the message box blocks
        MessageBox.Show("An enemy reached the top. Game over!")
    End Sub

    ' ------------------------------------------------------------------
    ' Drawing: everything is painted onto one surface, so there are no
    ' invisible rectangles, no transparency tricks, and no flicker.
    ' ------------------------------------------------------------------
    Private Sub Canvas_Paint(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor   ' crisp pixel art
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half
        g.TranslateTransform(-canvasOffset.X, -canvasOffset.Y)    ' sprites use form coordinates

        For Each en As Enemy In enemies
            DrawFitted(g, enemyFrames(frameIndex),
                       New Rectangle(CInt(Math.Round(en.X)), CInt(Math.Round(en.Y)), ENEMY_WIDTH, ENEMY_HEIGHT))
        Next

        For Each b As Bullet In bullets
            g.DrawImage(b.Img, CInt(Math.Round(b.X)), CInt(Math.Round(b.Y)), b.W, b.H)
        Next

        DrawFitted(g, CurrentPlayerImage(),
                   New Rectangle(CInt(Math.Round(playerX)), playerY, playerSize.Width, playerSize.Height))
    End Sub

    ' Game over image > throwing pose (briefly after each attack) > standing
    Private Function CurrentPlayerImage() As Image
        If isGameOver Then Return playerGameOver
        If lastSeconds < throwUntil Then Return playerThrow
        Return playerIdle
    End Function

    ' Same result as SizeMode = Zoom: keeps the image's proportions inside the box
    Private Sub DrawFitted(g As Graphics, img As Image, box As Rectangle)
        If img Is Nothing Then Return
        Dim scale As Double = Math.Min(box.Width / img.Width, box.Height / img.Height)
        Dim w As Integer = CInt(img.Width * scale)
        Dim h As Integer = CInt(img.Height * scale)
        g.DrawImage(img, box.X + (box.Width - w) \ 2, box.Y + (box.Height - h) \ 2, w, h)
    End Sub

End Class