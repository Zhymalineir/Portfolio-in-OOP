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

    ' ===== Machine state =====
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

    Private Const MaxPinLength As Integer = 6
    Private Const MaxAmountLength As Integer = 7
    Private Const MaxAttempts As Integer = 3

    ' ===== Load =====
    Private Sub Encapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.BackColor = ColorTranslator.FromHtml("#0c0b1d")
        TextBox3.BackColor = ColorTranslator.FromHtml("#0c0b1d")
        TextBox1.ReadOnly = True

        Label2.Parent = PictureBox5
        Label3.Parent = PictureBox5
        Label4.Parent = PictureBox5

        Label2.Parent = PictureBox5
        Label3.Parent = PictureBox5
        Label4.Parent = PictureBox5
        AlignMenuLabels()

        ' Buttons are always visible
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
    End Sub

    ' Puts each label on the left edge of the screen, level with its button
    Private Sub AlignMenuLabels()
        PlaceLabel(Label2, checkbalancebtn)   ' orange: Balance Inquiry
        PlaceLabel(Label3, deposit)           ' blue: Deposit
        PlaceLabel(Label4, withdraw)          ' green: Withdraw
    End Sub

    Private Sub PlaceLabel(lbl As Label, btn As Control)
        Dim btnScreen As Point = btn.Parent.PointToScreen(btn.Location)
        Dim btnInScreenPic As Point = PictureBox5.PointToClient(btnScreen)

        lbl.Left = 32                                             ' distance from the screen's left edge
        lbl.Top = btnInScreenPic.Y + (btn.Height - lbl.Height) \ 2  ' vertically centered on the button
        lbl.BringToFront()
    End Sub

    ' ===== Screens =====
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

    ' Label2-4 only show on the menu page
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

    ' ===== Display =====
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

    ' ===== Keypad =====
    Private Sub NumPad_Click(sender As Object, e As EventArgs)
        PressDigit(CStr(CType(sender, Control).Tag))
    End Sub

    Private Sub PressDigit(digit As String)
        Select Case state
            Case AtmState.PinEntry
                If buffer.Length < MaxPinLength Then buffer &= digit
            Case AtmState.AmountEntry
                If buffer.Length < MaxAmountLength Then
                    If buffer = "" AndAlso digit = "0" Then Exit Sub ' no leading zeros
                    buffer &= digit
                End If
            Case Else
                Exit Sub
        End Select
        RenderInput()
    End Sub

    ' ===== Buttons =====
    Private Sub insertcard_Click(sender As Object, e As EventArgs) Handles insertcard.Click
        If state = AtmState.Welcome Then GoToPinEntry()
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
                        Await FlashMessage("Card Blocked", AddressOf GoToWelcome)
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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Select Case state
            Case AtmState.PinEntry
                If buffer.Length > 0 Then
                    buffer = buffer.Substring(0, buffer.Length - 1)
                    RenderInput()
                Else
                    GoToWelcome()
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
                GoToWelcome()
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

End Class