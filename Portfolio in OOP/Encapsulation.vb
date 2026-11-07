Imports System.Threading.Tasks

Public Class Encapsulation

    Private Class Account
        Private ReadOnly pin As String
        Private balance As Decimal

        Public ReadOnly Property Name As String

        Public Sub New(name As String, pin As String, openingBalance As Decimal)
            Me.Name = name
            Me.pin = pin
            Me.balance = openingBalance
        End Sub

        Public Function VerifyPin(input As String) As Boolean
            Return input = pin
        End Function

        Public Sub Deposit(amount As Decimal)
            If amount > 0 Then balance += amount
        End Sub

        Public Function Withdraw(amount As Decimal) As Boolean
            If amount > 0 AndAlso amount <= balance Then
                balance -= amount
                Return True
            End If
            Return False
        End Function

        Public Function GetBalance() As Decimal
            Return balance
        End Function
    End Class

    Private Enum AtmState
        Welcome
        PinEntry
        Menu
        AmountEntry
        Result
        Busy
    End Enum

    Private ReadOnly student As New Account("Student", "123456", 0D)
    Private state As AtmState = AtmState.Welcome
    Private selectedOperation As String = ""
    Private buffer As String = ""
    Private pinAttempts As Integer = 0
    Private idleImage As Image

    Private Const MaxPinLength As Integer = 6
    Private Const MaxAmountLength As Integer = 7
    Private Const MaxAttempts As Integer = 3

    Private Sub Encapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.BackColor = ColorTranslator.FromHtml("#0c0b1d")
        TextBox3.BackColor = ColorTranslator.FromHtml("#0c0b1d")
        TextBox1.ReadOnly = True

        SetParentKeepPos(Label1, PictureBox2)
        SetParentKeepPos(Label2, PictureBox5)
        SetParentKeepPos(Label3, PictureBox5)
        SetParentKeepPos(Label4, PictureBox5)

        SetParentKeepPos(insertcard, PictureBox2)

        For Each c As Control In {back, enter, num0, num1, num2, num3, num4,
                          num5, num6, num7, num8, num9}
            SetParentKeepPos(c, PictureBox1)
        Next

        AlignMenuLabels()

        For Each c As Control In {checkbalancebtn, deposit, withdraw, enter, back, insertcard}
            c.Visible = True
        Next

        For i As Integer = 0 To 9
            Dim found() As Control = Me.Controls.Find("num" & i, True)
            If found.Length > 0 Then
                Dim pb As Control = found(0)
                pb.Tag = i.ToString()
                pb.Cursor = Cursors.Hand
                AddHandler pb.Click, AddressOf NumPad_Click
            End If
        Next

        GoToWelcome()

        idleImage = gifbox.Image
    End Sub

    Private Sub SetParentKeepPos(c As Control, newParent As Control)
        Dim screenPos As Point = c.Parent.PointToScreen(c.Location)
        c.Parent = newParent
        c.Location = newParent.PointToClient(screenPos)
    End Sub

    Private Sub AlignMenuLabels()
        PlaceLabel(Label2, checkbalancebtn)
        PlaceLabel(Label3, deposit)
        PlaceLabel(Label4, withdraw)
    End Sub

    Private Sub PlaceLabel(lbl As Label, btn As Control)
        Dim btnScreen As Point = btn.Parent.PointToScreen(btn.Location)
        Dim btnInScreenPic As Point = PictureBox5.PointToClient(btnScreen)

        lbl.Left = 32
        lbl.Top = btnInScreenPic.Y + (btn.Height - lbl.Height) \ 2
        lbl.BringToFront()
    End Sub

    Private Sub GoToWelcome()
        state = AtmState.Welcome
        selectedOperation = ""
        buffer = ""
        pinAttempts = 0

        TextBox1.Visible = False
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox2.Text = "WELCOME"
        TextBox3.Text = "- Insert your card - "

        SetMenuLabels(False)
    End Sub

    Private Sub GoToPinEntry()
        state = AtmState.PinEntry
        buffer = ""

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = False
        TextBox2.Text = "Insert Pin"

        SetMenuLabels(False)
        RenderInput()
    End Sub

    Private Sub ShowMenu()
        state = AtmState.Menu
        selectedOperation = ""
        buffer = ""

        TextBox1.Visible = False
        TextBox2.Visible = False

        SetMenuLabels(True)
    End Sub

    Private Sub ShowAmountEntry(operation As String, prompt As String)
        state = AtmState.AmountEntry
        selectedOperation = operation
        buffer = ""

        TextBox2.Visible = True
        TextBox2.Text = prompt
        TextBox1.Visible = True

        SetMenuLabels(False)
        RenderInput()
    End Sub

    Private Sub ShowResult(message As String)
        state = AtmState.Result
        buffer = ""
        TextBox2.Visible = True
        TextBox1.Visible = True
        TextBox1.Text = message

        SetMenuLabels(False)
    End Sub

    Private Sub SetMenuLabels(show As Boolean)
        Label2.Visible = show
        Label3.Visible = show
        Label4.Visible = show
    End Sub

    Private Async Function FlashMessage(message As String, nextAction As Action) As Task
        state = AtmState.Busy
        TextBox1.Visible = True
        TextBox1.Text = message
        Await Task.Delay(1500)
        nextAction()
    End Function

    Private Sub RenderInput()
        Select Case state
            Case AtmState.PinEntry
                TextBox1.Text = New String("*"c, buffer.Length)
            Case AtmState.AmountEntry
                If buffer = "" Then
                    TextBox1.Text = ""
                Else
                    TextBox1.Text = "₱" & Decimal.Parse(buffer).ToString("N0")
                End If
        End Select
    End Sub

    Private Sub NumPad_Click(sender As Object, e As EventArgs)
        PressDigit(CStr(CType(sender, Control).Tag))
    End Sub

    Private Sub PressDigit(digit As String)
        Select Case state
            Case AtmState.PinEntry
                If buffer.Length < MaxPinLength Then buffer &= digit
            Case AtmState.AmountEntry
                If buffer.Length < MaxAmountLength Then
                    If buffer = "" AndAlso digit = "0" Then Exit Sub
                    buffer &= digit
                End If
            Case Else
                Exit Sub
        End Select
        RenderInput()
    End Sub

    Private Async Sub insertcard_Click(sender As Object, e As EventArgs) Handles insertcard.Click
        If state <> AtmState.Welcome Then Exit Sub
        state = AtmState.Busy

        TextBox2.Visible = False
        TextBox3.Visible = False

        Await PlayGif(My.Resources._in, My.Resources.ATMACTIVE)
        GoToPinEntry()
    End Sub

    Private Async Sub enter_Click(sender As Object, e As EventArgs) Handles enter.Click
        Select Case state

            Case AtmState.PinEntry
                If buffer = "" Then Exit Sub

                If student.VerifyPin(buffer) Then
                    pinAttempts = 0
                    ShowMenu()
                Else
                    pinAttempts += 1
                    If pinAttempts >= MaxAttempts Then
                        Await FlashMessage("Card Blocked", Sub() LogOut())
                    Else
                        Await FlashMessage("Wrong password", AddressOf GoToPinEntry)
                    End If
                End If

            Case AtmState.AmountEntry
                If buffer = "" Then Exit Sub
                Dim amount As Decimal = Decimal.Parse(buffer)

                If selectedOperation = "Deposit" Then
                    student.Deposit(amount)
                    TextBox2.Text = "Deposit"
                    ShowResult("Successful!")
                ElseIf selectedOperation = "Withdraw" Then
                    TextBox2.Text = "Withdrawal"
                    If student.Withdraw(amount) Then
                        ShowResult("Withdrawal Successful!")
                    Else
                        ShowResult("Insufficient Balance")
                    End If
                End If

            Case AtmState.Result
                ShowMenu()
        End Select
    End Sub

    Private Async Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Select Case state
            Case AtmState.PinEntry
                If buffer.Length > 0 Then
                    buffer = buffer.Substring(0, buffer.Length - 1)
                    RenderInput()
                Else
                    Await LogOut()
                End If

            Case AtmState.AmountEntry
                If buffer.Length > 0 Then
                    buffer = buffer.Substring(0, buffer.Length - 1)
                    RenderInput()
                Else
                    ShowMenu()
                End If

            Case AtmState.Result
                ShowMenu()

            Case AtmState.Menu
                Await LogOut()
        End Select
    End Sub

    Private Sub checkbalance_Click(sender As Object, e As EventArgs) Handles checkbalancebtn.Click
        If state <> AtmState.Menu Then Exit Sub
        TextBox2.Visible = True
        TextBox2.Text = "Balance Inquiry"
        ShowResult("₱" & student.GetBalance().ToString("N2"))
    End Sub

    Private Sub deposit_Click(sender As Object, e As EventArgs) Handles deposit.Click
        If state = AtmState.Menu Then ShowAmountEntry("Deposit", "Enter Deposit Amount")
    End Sub

    Private Sub withdraw_Click(sender As Object, e As EventArgs) Handles withdraw.Click
        If state = AtmState.Menu Then ShowAmountEntry("Withdraw", "Enter Withdraw Amount")
    End Sub

    Private Function GetGifDuration(img As Image) As Integer
        Try
            Dim fd As New Imaging.FrameDimension(img.FrameDimensionsList(0))
            Dim frames As Integer = img.GetFrameCount(fd)
            Dim item = img.GetPropertyItem(&H5100)
            Dim total As Integer = 0
            For i As Integer = 0 To frames - 1
                total += BitConverter.ToInt32(item.Value, i * 4) * 10
            Next
            Return Math.Max(total, 100)
        Catch
            Return 1500
        End Try
    End Function

    Private Async Function LogOut() As Task
        state = AtmState.Busy
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        SetMenuLabels(False)

        Await PlayGif(My.Resources.out, idleImage)
        GoToWelcome()
    End Function

    Private Async Function PlayGif(gif As Image, finalImage As Image) As Task
        Dim duration As Integer = GetGifDuration(gif)

        gifbox.Image = gif
        gifbox.BringToFront()
        Await Task.Delay(duration)

        gifbox.Image = finalImage
    End Function
End Class