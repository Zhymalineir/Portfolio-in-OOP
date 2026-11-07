Public Class week6

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Const SB_VERT As Integer = 1

    Private lessonHandlerAttached As Boolean = False


    Private Sub week6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RTB2.ReadOnly = True
        RTB2.BackColor = ColorTranslator.FromHtml("#e7a35c")
        RTB2.ScrollBars = RichTextBoxScrollBars.Vertical

        Reparent(exitbtn, PictureBox7)
        Reparent(truthtablebtn, PictureBox7)
        Reparent(sidebar, PictureBox7)
        Reparent(PictureBox8, PictureBox7)

        For Each pb As PictureBox In {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
            Reparent(pb, sidebar)
        Next

        Reparent(Label1, PictureBox8)
        Reparent(Label2, truthtablebtn)


        PictureBox1_Click(PictureBox1, EventArgs.Empty)
    End Sub

    Private Sub Reparent(ctrl As Control, newParent As Control)
        Dim screenPos As Point = ctrl.Parent.PointToScreen(ctrl.Location)
        ctrl.Parent = newParent
        ctrl.Location = newParent.PointToClient(screenPos)
    End Sub

    Private Sub ShowTopic(img As Image, text As String, Optional showTruthTable As Boolean = False)
        Dim oldImage As Image = dialoguebox.Image
        dialoguebox.Image = img
        If oldImage IsNot Nothing Then oldImage.Dispose()

        RTB2.Text = text
        truthtablebtn.Visible = showTruthTable
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
    End Sub

    Private Shared Function Lines(ParamArray parts() As String) As String
        Return String.Join(vbCrLf, parts)
    End Function

    Private Sub RTB2_Resize(sender As Object, e As EventArgs) Handles RTB2.Resize
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ShowTopic(My.Resources.d1, Lines(
            "DECISION STATEMENTS",
            "",
            "What is a Decision Statement?",
            "A decision statement allows a program to make a decision based on a testable condition.",
            "",
            "   a. If...Then...Else Statement - If the expression is True, the statements between If...Then and Else are executed. If the expression is False, the statements between Else and End If are executed.",
            "",
            "   b. If...Then...ElseIf Statement - The If...Then...ElseIf statement allows for an entire series of possible choices.",
            "",
            "Block If Statement",
            "",
            "   Rules:",
            "",
            "       1. A block If statement must always end with End If.",
            "       2. Then must appear on the same line as If.",
            "       3. Else and End If must appear on lines by themselves.",
            "       4. Else is optional.",
            "       5. Use Else only if there is a False branch.",
            "       6. Visual Basic automatically indents four spaces inside the True and False branches."))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ShowTopic(My.Resources.d2, Lines(
            "RELATIONAL OPERATORS",
            "",
            "A relational operator determines if a specific relationship exists between two values.",
            "    Operator > means Greater than.",
            "    Operator < means Less than.",
            "    Operator = means Equal to.",
            "    Operator <> means Not equal to.",
            "    Operator >= means Greater than or equal to.",
            "    Operator <= means Less than or equal to.",
            "",
            "a. Boolean Expressions - Relational operators are binary, meaning they use two operands.",
            "       - They are used in Boolean expressions, which yield a True or False result.",
            "",
            "b. Relational Operators + Math Operators - Math operators are evaluated before relational operators.",
            "       - Function Calls with Relational Operators - Either or both operands of a relational operator may be function calls.",
            "       - The return value of the function call is compared using the relational operator.",
            "",
            "c. Boolean Variables as Flags - A flag is a Boolean variable that signals when some condition exists in a program.",
            "       - Since a Boolean variable is either True or False, it can be used as the condition of an If...Then statement.",
            "       - An = operator is not required."))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ShowTopic(My.Resources.d3, Lines(
            "VISUAL BASIC LOGICAL OPERATORS",
            "",
            "   - Logical operators combine multiple Boolean expressions into a compound expression.",
            "   - Operator And means both must be True.",
            "   - Operator Or means one or both must be True.",
            "   - Operator Xor means one, but not both, must be True.",
            "   - Operator Not reverses True/False.",
            "",
            "a. And - The And operator combines two expressions into one.",
            "       - Both expressions must be True for the overall expression to be True.",
            "",
            "b. AndAlso - AndAlso provides short-circuit evaluation.",
            "       - If the first expression is False, the entire expression is already False, so the second expression can be skipped.",
            "",
            "c. Or - The Or operator combines two expressions.",
            "       - One or both expressions must be True for the overall expression to be True.",
            "",
            "d. OrElse - OrElse provides short-circuit evaluation.",
            "       - If the first expression is True, the entire expression is already True, so the second expression can be skipped.",
            "",
            "e. Xor - Xor stands for exclusive or.",
            "       - One expression, but not both, must be True for the overall expression to be True.",
            "",
            "f. Not - The Not operator reverses the logical value of an expression.",
            "       - True becomes False, and False becomes True.",
            "",
            "Logical Operator Precedence - from highest to lowest:",
            "   1. Not",
            "   2. And, AndAlso",
            "   3. Or, OrElse, Xor (same level, evaluated left to right)"),
            True)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ShowTopic(My.Resources.d4, Lines(
            "NESTED IF AND SELECT CASE",
            "",
            "Nested If - A Nested If is an If statement inside another If statement.",
            "       - Any type of statement may be used inside the Then, Else, or ElseIf sections, including another If statement.",
            "",
            "Select Case - Select Case is similar to If...Then...ElseIf.",
            "   It:",
            "",
            "       a. Performs a series of tests.",
            "       b. Conditionally executes the first true condition.",
            "       c. Uses a single test expression.",
            "       d. Lists the test expression once.",
            "       e. Lists possible values of the expression.",
            "       f. Can use Case Else when none of the values match."))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ShowTopic(My.Resources.d5, Lines(
            "COMPARING, TESTING, AND WORKING WITH STRINGS",
            "",
            "Relational operators can be used to compare strings and string literals.",
            "",
            "1. How Strings Are Compared:",
            "       a. Characters are stored as numeric values.",
            "       b. Visual Basic uses Unicode.",
            "       c. Unicode represents letters, printable digits, punctuation, and special characters.",
            "       d. Letters are arranged alphabetically.",
            "       e. The numeric value of A is less than B.",
            "       f. Characters are compared one by one until a difference is found.",
            "",
            "2. Testing for No Input - String.Empty represents an empty string, meaning a string that contains no characters.",
            "       - It is useful for determining whether the user has provided input for a required field before performing an operation.",
            "",
            "3. ToUpper() and ToLower():",
            "      - ToUpper() - Converts lowercase letters to uppercase.",
            "      - ToLower() - Converts uppercase letters to lowercase.",
            "",
            "4. IsNumeric() - IsNumeric accepts a string as an argument and returns True if the string contains a number.",
            "",
            "5. Length Property - The Length property returns the number of characters in a string.",
            "",
            "6. Trimming Spaces - There are three methods for removing spaces from strings:",
            "      - TrimStart() - Removes leading spaces.",
            "      - TrimEnd() - Removes trailing spaces.",
            "      - Trim() - Removes leading and trailing spaces."))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ShowTopic(My.Resources.d6, Lines(
            "LOOPING STATEMENTS",
            "",
            "   - A repetition structure, or loop, causes one or more statements to repeat.",
            "   - Each repetition is called an iteration.",
            "",
            "There are three types of loops:",
            "   1. Do While",
            "   2. Do Until",
            "   3. For...Next",
            "",
            "Do While Loop:",
            "   1. A Boolean expression is tested for True or False.",
            "   2. A statement or group of statements is repeated as long as the Boolean expression is True.",
            "   These are called conditionally executed statements.",
            "",
            "Do Until Loop:",
            "   1. A Boolean expression is tested for True or False.",
            "   2. The statements are repeated until the Boolean expression becomes True (that is, while it is False).",
            "",
            "For...Next Loop:",
            "   1. Set the counter to the starting value.",
            "   2. Compare the counter to the ending value.",
            "   3. If the condition is satisfied, execute the loop body.",
            "   4. Increment the counter.",
            "   5. Return to the comparison.",
            "   6. Continue until the loop is exited.",
            "",
            "Nested Loop - A nested loop is a loop inside another loop.",
            "   Clock analogy:",
            "   Hour hand - 1 revolution for every 12 revolutions of the minute hand.",
            "   Minute hand - 1 revolution for every 60 revolutions of the second hand.",
            "   For every revolution of the hour hand, the second hand makes 720 revolutions."))
    End Sub


    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
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

    Private Sub week6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

    Private Sub truthtablebtn_Click(sender As Object, e As EventArgs) Handles truthtablebtn.Click, Label2.Click
        If TruthTable.Visible Then
            TruthTable.BringToFront()
        Else
            TruthTable.Show()
        End If
    End Sub

End Class