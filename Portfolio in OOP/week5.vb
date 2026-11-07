
Public Class week5

    Private calcFirst As Decimal = 0D
    Private calcOp As String = ""
    Private calcNewEntry As Boolean = True
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Const SB_VERT As Integer = 1
    Private Const SB_HORZ As Integer = 0
    Private Const SB_BOTH As Integer = 3

    Private selectedTag As String = ""
    Private Sub week5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RTB2.BackColor = ColorTranslator.FromHtml("#fdd587")
        Me.BackgroundImage = My.Resources.wk5a
        selectedTag = "1"

        RTB2.Text = "HANDLING DATA" & vbCrLf & vbCrLf &
                    "Values are stored To memory locations." & vbCrLf & vbCrLf &
                    "The stored values can vary over time." & vbCrLf & vbCrLf &
                    "Each memory location Is assigned a unique variable name that Is used To reference the location When you write a program."

        RTB2.ScrollBars = RichTextBoxScrollBars.Vertical
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
        RTB3.ScrollBars = RichTextBoxScrollBars.Vertical
        ShowScrollBar(RTB3.Handle, SB_VERT, False)
        RTB4.ScrollBars = RichTextBoxScrollBars.Vertical
        ShowScrollBar(RTB4.Handle, SB_VERT, False)

        PictureBox9.Tag = "1"
        PictureBox1.Tag = "2"
        PictureBox2.Tag = "3"
        PictureBox3.Tag = "4"
        PictureBox4.Tag = "5"
        PictureBox5.Tag = "6"
        PictureBox6.Tag = "7"
        PictureBox7.Tag = "8"
        PictureBox8.Tag = "9"

        calculator.Visible = False
    End Sub

    Private Sub enterbtn_Click(sender As Object, e As EventArgs) Handles enterbtn.Click
        Select Case selectedTag
            Case "1"
                RTB4.Text = "Notebook" & vbCrLf & vbCrLf &
                            "5" & vbCrLf & vbCrLf &
                            "45.75D" & vbCrLf & vbCrLf &
                            "0.12D"
            Case "2"
                RTB4.Text = ""
            Case "3"
                RTB4.Text = "Maria" & vbCrLf & vbCrLf &
                            "95" & vbCrLf & vbCrLf &
                            "A" & vbCrLf & vbCrLf &
                            "3"
            Case "4"
                RTB4.Text = "StudentNameString = Nothing (no value assigned)" & vbCrLf & vbCrLf &
                             "CountStudentsInteger = 0 (default value)" & vbCrLf & vbCrLf &
                             "AccountBalanceDecimal = 100" & vbCrLf & vbCrLf &
                             "FirstNameString = Nothing, MajorString = Nothing (no values assigned)" & vbCrLf & vbCrLf &
                             "SubtotalDecimal = 0, TotalDecimal = 0, TaxAmountDueDecimal = 0 (default values)"
            Case "5"
                RTB4.Text = "0.0725" & vbCrLf & vbCrLf &
                            "Alaska" & vbCrLf & vbCrLf &
                            "Data Entry Error" & vbCrLf & vbCrLf &
                            "4000"
            Case "6"
                RTB4.Text = "1234.50" & vbCrLf & vbCrLf &
                            "$89.50" & vbCrLf & vbCrLf &
                            "150"
            Case "7"
                RTB4.Text = ""

            Case "8"
                RTB4.Text = "20" & vbCrLf & vbCrLf &
                            "16" & vbCrLf & vbCrLf &
                            "12" & vbCrLf & vbCrLf &
                            "8" & vbCrLf & vbCrLf &
                            "4"
            Case "9"
                RTB4.Text = "50.00" & vbCrLf & vbCrLf &
                            "575" & vbCrLf & vbCrLf &
                            "9"

            Case Else
                RTB4.Text = "Unknown item."
        End Select
    End Sub



    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.BackgroundImage = My.Resources.wk5a
        selectedTag = PictureBox9.Tag.ToString()

        RTB2.Size = New Size(640, 416)
        RTB2.Text = "HANDLING DATA" & vbCrLf & vbCrLf &
                    "Values are stored To memory locations." & vbCrLf & vbCrLf &
                    "The stored values can vary over time." & vbCrLf & vbCrLf &
                    "Each memory location Is assigned a unique variable name that Is used To reference the location When you write a program."
        RTB3.Text = "Dim ItemNameString As String = 'Notebook'" & vbCrLf & vbCrLf &
                    "Dim QuantityInteger As Integer = 5" & vbCrLf & vbCrLf &
                    "Dim PriceDecimal As Decimal = 45.75D" & vbCrLf & vbCrLf &
                    "Dim TaxRateDecimal As Decimal = 0.12D" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ItemNameString)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(QuantityInteger)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(PriceDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(TaxRateDecimal)"

        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BackgroundImage = My.Resources.wk5b
        selectedTag = PictureBox1.Tag.ToString()

        RTB2.Size = New Size(1118, 416)
        RTB2.Text = "TYPES OF DATA" & vbCrLf & vbCrLf &
                    "VB provides numerous data types to allow programmers to optimize the use of computer memory." & vbCrLf & vbCrLf &
                    "Each data type is described by its Data type name, Description of data stored, and Memory storage requirement in bytes." & vbCrLf & vbCrLf &
                    "1. Text Data Storage:" & vbCrLf &
                    "       a. String - Alphanumeric data such as letters of the alphabet, digits that are not treated as numbers, and other special characters. (Size varies)" & vbCrLf &
                    "       b. Char - Stores single Unicode characters (supports any international language). (2 bytes)" & vbCrLf & vbCrLf &
                    "       c. Numeric Data Storage - Fixed Point:" & vbCrLf &
                    "       d. Decimal - Decimal numeric values, often used to store dollars/cents. (16 bytes)" & vbCrLf & vbCrLf &
                    "2. Numeric Data Storage - Floating Point:" & vbCrLf &
                    "       a. Double - Double-precision numeric values with 14 digits of accuracy. (8 bytes)" & vbCrLf &
                    "       b. Single - Single-precision numeric values with 6 digits of accuracy. (4 bytes)" & vbCrLf & vbCrLf &
                    "3. Numeric Data Storage - Whole Numbers (no decimal point):" & vbCrLf &
                    "       a. Short - Whole numeric values in the range -32,768 to 32,767. (2 bytes)" & vbCrLf &
                    "       b. Integer - Whole numeric values in the range -2,147,483,648 to +2,147,483,647. (4 bytes)" & vbCrLf &
                    "       c. Long - Whole numeric values that are very, very large. (8 bytes)" & vbCrLf & vbCrLf &
                    "4. Special Data Types:" & vbCrLf &
                    "       a. Boolean - True or False. (2 bytes)" & vbCrLf &
                    "       b. Byte - Stores binary data of values 0 to 255, can be used to store ASCII character code values. (1 byte)" & vbCrLf &
                    "       c. Date - Stores dates in the form 1/1/0001 to 12/31/9999. (8 bytes)" & vbCrLf &
                    "       d. Object - Stores data of any type. (4 bytes)"
        RTB3.Visible = False
        RTB4.Visible = False
        enterbtn.Visible = False
        RTB3.Text = ""
        RTB4.Text = ""

        calculator.Visible = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.BackgroundImage = My.Resources.wk5c
        selectedTag = PictureBox2.Tag.ToString()

        RTB2.Size = New Size(640, 416)
        RTB2.Text = "NAMING RULES FOR VARIABLES AND CONSTANTS" & vbCrLf & vbCrLf &
                    "There are technical rules you must follow when creating variable and constant names:" & vbCrLf &
                    "       1. Names can include letters, digits, and the underscore, but must begin with a letter." & vbCrLf &
                    "       2. Names cannot contain spaces or periods." & vbCrLf &
                    "       3. Names cannot be VB reserved words such as LET, PRINT, DIM, or CONST." & vbCrLf &
                    "       4. Names are not case sensitive. This means that TotalInteger, TOTALINTEGER, and totalinteger are all equivalent names." & vbCrLf &
                    "       5. For all intensive purposes, a Name can be as long as you want (the actual limit is 16,383 characters in length)." & vbCrLf & vbCrLf &
                    "Scope of Variables and Constants - Each variable (Or constant) has a finite lifetime And visibility, termed the Scope." & vbCrLf & vbCrLf &
                    "The variable lifetime Is how long the variable exists before the computer operating system garbage-collects the memory allocated to the stored value." & vbCrLf & vbCrLf &
                    "There are four levels of scope." & vbCrLf & vbCrLf &
                    "   a. Namespace (use a Public Shared declaration instead of Dim) - the variable Is visible within the entire project (applicable to a project with multiple forms)." & vbCrLf &
                    "          - The variable Is project-wide And can be used in any procedure in any form in the project." & vbCrLf &
                    "          - The variable memory allocation Is garbage-collected when application execution terminates." & vbCrLf & vbCrLf &
                    "   b. Module level (usually use Private to declare the variable; use Const to declare the constant) - a variable/constant can be used in any procedure on a specific form, it Is Not visible to other Forms." & vbCrLf &
                    "          - Use module-level variables when the values that are stored in their memory locations are used in more than one procedure (click event Or other type of procedure)." & vbCrLf &
                    "          - A module-level variable Or constant Is created (allocated memory) when a form loads into memory And the variable Or constant remains in memory until the form Is unloaded." & vbCrLf & vbCrLf &
                    "   c. Local (use Dim to declare the variable; use Const to declare the constant) - a variable/constant Is declared And used only within a single procedure." & vbCrLf & vbCrLf &
                    "   d. Variable lifetime Is the period for which a variable exists." & vbCrLf &
                    "          - When a procedure executes, such as when you click on a button control, each variable And constant declared as local within the procedure executes, 'uncreated' when the procedure executes the End Sub statement." & vbCrLf &
                    "          - Each time you click the button, a new set of variables and constants are created." & vbCrLf & vbCrLf &
                    "   e. Block (use Dim to declare the variable; use Const to declare the constant) - the variable/constant is only visible within a small portion of a procedure, these variables/constants are rarely created."
        RTB3.Text = "Dim StudentNameString As String = 'Maria'" & vbCrLf & vbCrLf &
                    "Dim Total_ScoreInteger As Integer = 95" & vbCrLf & vbCrLf &
                    "Dim Grade2Char As Char = 'A'c" & vbCrLf & vbCrLf &
                    "Const MAX_ATTEMPTS As Integer = 3" & vbCrLf & vbCrLf &
                    "Console.WriteLine(StudentNameString)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(Total_ScoreInteger)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(Grade2Char)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(MAX_ATTEMPTS)"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.BackgroundImage = My.Resources.wk5d

        RTB2.Size = New Size(640, 416)
        selectedTag = PictureBox3.Tag.ToString()
        RTB2.Text = "DECLARING VARIABLES" & vbCrLf & vbCrLf &
                    "Declare variables that are local with the Dim statement. Declare variables that are module-level with the Private statement." & vbCrLf & vbCrLf &
                    "Dim statement - use this to declare variables and constants inside a procedure, these are local variables." & vbCrLf & vbCrLf &
                    "The Dim statement needs to specify a variable/constant name and data type." & vbCrLf & vbCrLf &
                    "Specifying an initial value for a variable is optional." & vbCrLf & vbCrLf &
                    "Constants must have an initial value specified."
        RTB3.Text = "Dim StudentNameString As String" & vbCrLf & vbCrLf &
                    "Dim CountStudentsInteger As Integer" & vbCrLf & vbCrLf &
                    "Dim AccountBalanceDecimal As Decimal = 100D" & vbCrLf & vbCrLf &
                    "Dim FirstNameString, MajorString As String" & vbCrLf & vbCrLf &
                    "Dim SubtotalDecimal, TotalDecimal, TaxAmountDueDecimal As Decimal"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        BackgroundImage = My.Resources.wk5e

        RTB2.Size = New Size(640, 416)
        selectedTag = PictureBox4.Tag.ToString()
        RTB2.Text = "DECLARING CONSTANTS" & vbCrLf & vbCrLf &
                    "Declare constants with the Const statement." & vbCrLf & vbCrLf &
                    "Constants are similar to variables; constants are values that are stored to memory locations; however, a constant cannot have its value change during program execution; constant values are generally fixed over time." & vbCrLf & vbCrLf &
                    "VB has two different types of constants:" & vbCrLf &
                    "     a. Intrinsic Constants - these are defined as enumerations such as Color.Red and Color.Blue. These are called intrinsic because they are predefined in VB and always exist for your use." & vbCrLf &
                    "     b. Named Constants - these are constants you define with a Const statement. These constants are specific to your programming application."
        RTB3.Text = "Const SALES_TAX_RATE_SINGLE As Single = 0.0725F" & vbCrLf & vbCrLf &
                    "Const BIG_STATE_NAME_STRING As String = 'Alaska'" & vbCrLf & vbCrLf &
                    "Const TITLE_STRING As String = 'Data Entry Error'" & vbCrLf & vbCrLf &
                    "Const MAX_SIZE_INTEGER As Integer = 4000" & vbCrLf & vbCrLf &
                    "Console.WriteLine(SALES_TAX_RATE_SINGLE)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(BIG_STATE_NAME_STRING)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(TITLE_STRING)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(MAX_SIZE_INTEGER)"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.BackgroundImage = My.Resources.wk5f

        RTB2.Size = New Size(640, 416)
        selectedTag = PictureBox5.Tag.ToString()
        RTB2.Text = "CONVERTING OUTPUT DATA TYPES" & vbCrLf & vbCrLf &
                    "In order to display numeric variable values as output, the values must be converted from numeric data types to string in order to store the data to the Text property of a TextBox control." & vbCrLf & vbCrLf &
                    "a. Implicit Conversion - this is conversion by VB from a narrower to wider data type (less memory to more memory), this is done automatically as there is no danger of losing any precision." & vbCrLf &
                    "       - BiggerNumberDouble = SmallerNumberInteger" & vbCrLf & vbCrLf &
                    "b. Explicit Conversion - this is also called Casting and is used to convert between numeric data types that do not support implicit conversion." & vbCrLf &
                    "       - This table shows use of the Convert method to convert one numeric data type to another numeric data type. Note that fractional values are rounded when converting to integer."
        RTB3.Text = "SubtotalTextBox.Text = SubtotalDecimal.ToString('N2')" & vbCrLf & vbCrLf &
                    "SalesTaxTextBox.Text = SalesTaxDecimal.ToString('C2')" & vbCrLf & vbCrLf &
                    "QuantityTextBox.Text = QuantityInteger.ToString('N0')" & vbCrLf & vbCrLf &
                    "Console.WriteLine(SubtotalTextBox.Text)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(SalesTaxTextBox.Text)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(QuantityTextBox.Text)"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.BackgroundImage = My.Resources.wk5g

        RTB2.Size = New Size(640, 416)
        selectedTag = PictureBox6.Tag.ToString()
        RTB2.Text = "ARITHMENTIC OPERATORS" & vbCrLf & vbCrLf &
                    "The arithmetic operators are the same as in many other programming languages. They are:" & vbCrLf &
                    "+ Addition" & vbCrLf &
                    "- Subtraction" & vbCrLf &
                    "* Multiplication" & vbCrLf &
                    "/ Division" & vbCrLf &
                    "^ Exponentiation" & vbCrLf &
                    "\ Integer Division" & vbCrLf &
                    "Mod Modulus Division" & vbCrLf & vbCrLf &
                    "a. Exponentiation - This raises a number to the specified power, the result produced is data type Double. Example:" & vbCrLf &
                    "       - ValueSquaredDouble = NumberDecimal ^ 2" & vbCrLf &
                    "       - ValueCubedDouble = NumberDecimal ^ 3" & vbCrLf & vbCrLf &
                    "b. Integer Division - Divide one integer by another leaving an integer result and discarding the remainder, if any. Example:" & vbCrLf &
                    "       - If the variable MinutesInteger = 130, then this expression returns the value of 2 hours." & vbCrLf &
                    "       - HoursInteger = MinutesInteger \ 60" & vbCrLf & vbCrLf &
                    "c. Modulus Division - This returns the remainder of a division operation. Using the same value for MinutesInteger = 500, this expression returns the value 20 minutes and can be used to calculate the amount of overtime worked for an 8-hour work day." & vbCrLf &
                    "       - MinutesInteger = MinutesInteger Mod 60"
        RTB3.Text = ""
        RTB3.Visible = False
        RTB4.Visible = False
        enterbtn.Visible = False
        RTB4.Text = ""

        calculator.Visible = True

    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.BackgroundImage = My.Resources.wk5h
        selectedTag = PictureBox7.Tag.ToString()

        RTB2.Size = New Size(640, 416)
        RTB2.Text = "ORDER OF PRECENDENCE" & vbCrLf & vbCrLf &
                    "The order of precedence for expressions that have more than one operation is the same as for other programming languages." & vbCrLf & vbCrLf &
                    "Evaluate values and calculation symbols in this order:" & vbCrLf & vbCrLf &
                    "       (1) Values enclosed inside parentheses" & vbCrLf & vbCrLf &
                    "       (2) Exponentiation" & vbCrLf & vbCrLf &
                    "       (3) Multiplication and Division" & vbCrLf & vbCrLf &
                    "       (4) Integer Division" & vbCrLf & vbCrLf &
                    "       (5) Modulus Division" & vbCrLf & vbCrLf &
                    "       (6) Addition and Subtraction"
        RTB3.Text = "Dim ResultDecimal As Decimal" & vbCrLf & vbCrLf &
                    "ResultDecimal = (4 + 6) * 2" & vbCrLf & vbCrLf &
                    "ResultDecimal = 4 + 6 * 2" & vbCrLf & vbCrLf &
                    "ResultDecimal = 2 ^ 3 + 4" & vbCrLf & vbCrLf &
                    "ResultDecimal = 20 \ 3 + 2" & vbCrLf & vbCrLf &
                    "ResultDecimal = 20 Mod 3 + 2" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ResultDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ResultDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ResultDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ResultDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ResultDecimal)"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.BackgroundImage = My.Resources.wk5i
        selectedTag = PictureBox8.Tag.ToString()

        RTB2.Size = New Size(640, 416)
        RTB2.Text = "ASSIGNMENT OPERATORS AND FORMULAS" & vbCrLf & vbCrLf &
                    "The equal sign is the assignment operator. It means store the value of the expression on the right side of the equal sign to the memory variable named on the left side of the equal sign. Examples:" & vbCrLf &
                    "     - ItemValueDecimal = QuantityInteger * PriceDecimal" & vbCrLf &
                    "     - HoursWorkedSingle = MinutesWorkedSingle / 60F" & vbCrLf &
                    "     - NetProfitDecimal = GrossSalesDecimal - CostGoodsSoldDecimal" & vbCrLf & vbCrLf &
                    "The plus symbol combined with the equal sign allows you to accumulate a value in a memory variable." & vbCrLf & vbCrLf &
                    "     - Is equivalent to the following, it means take the current value of TotalSalesDecimal and add to it the value of SaleAmountDecimal and store it back to TotalSalesDecimal (it gets bigger and BIGGER)." & vbCrLf & vbCrLf &
                    "     - TotalSalesDecimal = TotalSalesDecimal + SaleAmountDecimal" & vbCrLf & vbCrLf &
                    "The minus symbol combined with the equal sign allows you to decrement or count backwards. Examples:" & vbCrLf & vbCrLf &
                    "     - CountInteger -= 1" & vbCrLf & vbCrLf &
                    "     - Is equivalent to: CountInteger = CountInteger - 1"
        RTB3.Text = "Dim ItemValueDecimal As Decimal" & vbCrLf & vbCrLf &
                    "ItemValueDecimal = QuantityInteger * PriceDecimal" & vbCrLf & vbCrLf &
                    "Dim TotalSalesDecimal As Decimal = 500D" & vbCrLf & vbCrLf &
                    "TotalSalesDecimal += SaleAmountDecimal" & vbCrLf & vbCrLf &
                    "Dim CountInteger As Integer = 10" & vbCrLf & vbCrLf &
                    "CountInteger -= 1" & vbCrLf & vbCrLf &
                    "Console.WriteLine(ItemValueDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(TotalSalesDecimal)" & vbCrLf & vbCrLf &
                    "Console.WriteLine(CountInteger)"
        RTB3.Visible = True
        RTB4.Visible = True
        enterbtn.Visible = True
        RTB4.Text = ""

        calculator.Visible = False

    End Sub


    Private lessonHandlerAttached As Boolean = False
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
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

    Private Sub week5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub week5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub richtextbox_Resize(sender As Object, e As EventArgs) Handles RTB2.Resize
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
    End Sub
    Private Sub richtextbox1_Resize(sender As Object, e As EventArgs) Handles RTB3.Resize
        ShowScrollBar(RTB3.Handle, SB_VERT, False)
    End Sub
    Private Sub richtextbox2_Resize(sender As Object, e As EventArgs) Handles RTB4.Resize
        ShowScrollBar(RTB4.Handle, SB_VERT, False)
    End Sub

    Private justEvaluated As Boolean = False

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click,
        num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click

        Dim digit As String = DirectCast(sender, PictureBox).Name.Substring(3)

        If justEvaluated Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            justEvaluated = False
        End If

        TextBox1.Text &= digit
    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        If justEvaluated Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            justEvaluated = False
        End If

        Dim parts() As String = TextBox1.Text.Split(" "c)
        Dim current As String = parts(parts.Length - 1)

        If current.Contains(".") Then Exit Sub

        If current = "" Then
            TextBox1.Text &= "0."
        Else
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub AddOperator(op As String)
        If justEvaluated Then
            TextBox1.Text = TextBox2.Text
            TextBox2.Text = ""
            justEvaluated = False
        End If

        Dim text As String = TextBox1.Text
        If text = "" Then Exit Sub

        Dim parts() As String = text.Split(" "c)

        If parts.Length = 1 Then

            If text.EndsWith(".") Then text &= "0"
            TextBox1.Text = text & " " & op & " "
        ElseIf parts.Length = 3 AndAlso parts(2) = "" Then

            TextBox1.Text = parts(0) & " " & op & " "
        End If
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        AddOperator("+")
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        AddOperator("-")
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        AddOperator("x")
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        AddOperator("/")
    End Sub

    Private Sub exponential_Click(sender As Object, e As EventArgs) Handles exponential.Click
        AddOperator("^")
    End Sub

    Private Sub modulus_Click(sender As Object, e As EventArgs) Handles modulus.Click
        AddOperator("Mod")
    End Sub

    Private Sub integerdivision_Click(sender As Object, e As EventArgs) Handles integerdivision.Click
        AddOperator("\")
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Dim parts() As String = TextBox1.Text.Split(" "c)


        If parts.Length <> 3 OrElse parts(2) = "" Then Exit Sub

        Dim a, b, result As Double
        If Not Double.TryParse(parts(0), a) OrElse Not Double.TryParse(parts(2), b) Then Exit Sub

        Try
            Select Case parts(1)
                Case "+"
                    result = a + b
                Case "-"
                    result = a - b
                Case "x"
                    result = a * b
                Case "/"
                    If b = 0 Then Throw New DivideByZeroException()
                    result = a / b
                Case "^"
                    result = Math.Pow(a, b)
                Case "Mod"
                    If b = 0 Then Throw New DivideByZeroException()
                    result = a Mod b
                Case "\"
                    If b = 0 Then Throw New DivideByZeroException()
                    result = Math.Truncate(a / b)
            End Select

            TextBox2.Text = result.ToString()
        Catch ex As Exception
            TextBox2.Text = "Error"
        End Try

        justEvaluated = True
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        justEvaluated = False
    End Sub

End Class