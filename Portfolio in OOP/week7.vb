Imports System.Runtime.InteropServices

Public Class week7

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer,
                                          <MarshalAs(UnmanagedType.Bool)> bShow As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Const SB_BOTH As Integer = 3
    Private hidingRtb3Bars As Boolean = False

    Private Sub HideRTB3ScrollBars()
        If hidingRtb3Bars OrElse Not RTB3.IsHandleCreated Then Return
        hidingRtb3Bars = True
        ShowScrollBar(RTB3.Handle, SB_BOTH, False)
        hidingRtb3Bars = False
    End Sub

    Private Sub RTB3_HideBars(sender As Object, e As EventArgs) Handles RTB3.TextChanged, RTB3.Resize, RTB3.HandleCreated, RTB3.MouseWheel
        HideRTB3ScrollBars()
        If RTB3.IsHandleCreated Then RTB3.BeginInvoke(New Action(AddressOf HideRTB3ScrollBars))
    End Sub

    Private Sub FocusRTB3(sender As Object, e As EventArgs)
        If Not RTB3.Focused Then
            RTB3.Focus()
            RTB3.Select(0, 0)
        End If
    End Sub

    Private Sub week7_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim locRTB2 As Point = RTB2.Parent.PointToScreen(RTB2.Location)
        RTB2.Parent = PictureBox6
        RTB2.Location = PictureBox6.PointToClient(locRTB2)
        RTB2.BringToFront()

        RTB2.BackColor = ColorTranslator.FromHtml("#fdd488")
        RTB3.BackColor = ColorTranslator.FromHtml("#fdd488")
        AddHandler RTB3.MouseEnter, AddressOf FocusRTB3
        HideRTB3ScrollBars()

        SetupBookHover()
    End Sub

    '++++++++++++++++++++++ARRAY+++++++++++++++++++++++++++++'
    Private Sub Array_Click(sender As Object, e As EventArgs) Handles Array.Click
        RTB2.Text = "Array"
        RTB3.Text = "An array is like a group of variables that allows you to store a set of similar data." & vbCrLf & vbCrLf &
          "Characteristics:" & vbCrLf &
          "   - Stores multiple values of the same data type." & vbCrLf &
          "   - Like a group of variables with a single name." & vbCrLf &
          "   - Each variable/value in an array is called an element." & vbCrLf &
          "   - Elements are accessed using a subscript/index." & vbCrLf & vbCrLf &
          "Element - An element is an individual part or value stored in an array." & vbCrLf &
          "Example: AmountDecimal(3)" & vbCrLf & vbCrLf &
          "Subscript / Index - A subscript or index is the number used to identify an array element. Array numbering starts at 0." & vbCrLf &
          "Example: 0, 1, 2, 3, ..." & vbCrLf &
          "General format: ArrayName(ElementNumber)"
    End Sub

    '++++++++++++++++++++++TYPES ARRAY+++++++++++++++++++++++++++++'
    Private Sub Types_Click(sender As Object, e As EventArgs) Handles Types.Click
        RTB2.Text = "Types of Array"
        RTB3.Text = "One-Dimensional Array - A one-dimensional array is an array with one subscript, useful for storing and working with a single set of data." & vbCrLf & vbCrLf &
            "Two-Dimensional Array - A two-dimensional array is like an array of arrays and is used to hold multiple sets of values. It can be thought of as having rows and columns." & vbCrLf & vbCrLf &
            "Multidimensional Array - A multidimensional array stores and works with multiple sets of data using more than one dimension. Visual Basic can create arrays with up to 32 dimensions."
    End Sub

    '++++++++++++++++++++++DECLARATION+++++++++++++++++++++++++++++'

    Private Sub declaration_Click(sender As Object, e As EventArgs) Handles declaration.Click
        RTB2.Text = "Declaration & Initialization"
        RTB3.Text = "1. Array Declaration - Array declaration is the process of defining an array's name, highest subscript, and data type." & vbCrLf &
            "  - Syntax: Dim ArrayName(UpperSubscript) As DataType" & vbCrLf & vbCrLf &
            "2. Default Initialization - Default initialization means array elements are automatically initialized according to their data type." & vbCrLf & vbCrLf &
            "  - Data Type and Their Default Value" & vbCrLf &
            "       a. Integer - 0" & vbCrLf &
            "       b. Decimal - 0.0" & vbCrLf &
            "       c. String - Nothing" & vbCrLf & vbCrLf &
            "3. Implicit Array Sizing and Initialization - An array can be initialized when it is declared, with the number of elements determined from the values provided." & vbCrLf &
            "    Example: Dim intNumbers() As Integer = {2, 4, 6, 8, 10, 12}" & vbCrLf & vbCrLf &
            "        - Upper subscript is left blank." & vbCrLf &
            "        - Six values are provided." & vbCrLf &
            "        - Therefore, there are 6 elements." & vbCrLf &
            "        - Subscripts are 0 through 5." & vbCrLf & vbCrLf &
            "4. Named Constants as Subscripts - A named constant can be used as an array's highest subscript instead of directly using a number." & vbCrLf &
            "    Example: Const intMAX_SUBSCRIPT As Integer = 100" & vbCrLf &
            "        - Dim intArray(intMAX_SUBSCRIPT) As Integer" & vbCrLf & vbCrLf &
            "Advantage: If the highest subscript changes, you only need to change the constant in one place."
    End Sub

    '++++++++++++++++++++++FUNCTION+++++++++++++++++++++++++++++'
    Private Sub func_Click(sender As Object, e As EventArgs) Handles func.Click
        RTB2.Text = "Functions of an Array"
        RTB3.Text = "A function is a procedure that returns a value. Its return data type is specified using As DataType, and the value is returned using a Return expression." & vbCrLf &
            "Basic syntax:" & vbCrLf &
            "   Function FunctionName(ParameterList) As DataType" & vbCrLf &
            "   Statements" & vbCrLf &
            "   End Function" & vbCrLf & vbCrLf &
            "1. Return Value - A return value is the value that a function sends back using a Return expression." & vbCrLf &
            "Example:" & vbCrLf &
            "   Function Sum(ByVal dblNum1 As Double, ByVal dblNum2 As Double) As Double" & vbCrLf &
            "   Return dblNum1 + dblNum2" & vbCrLf &
            "   End Function" & vbCrLf & vbCrLf &
            "2. Returning Nonnumeric Values - Functions can return nonnumeric values, such as String and Boolean." & vbCrLf &
            "Example:" & vbCrLf &
            "   Function FullName(ByVal strFirst As String," & vbCrLf &
            "   ByVal strLast As String) As String" & vbCrLf &
            "   Return strFirst & "" "" & strLast" & vbCrLf &
            "   End Function"


    End Sub

    '++++++++++++++++++++++ARRAY AND FUNCTION+++++++++++++++++++++++++++++'
    Private Sub arrnfunc_Click(sender As Object, e As EventArgs) Handles arrnfunc.Click
        RTB2.Text = "Functions with Arrays"
        RTB3.Text = "Passing Arrays as Arguments - An array can be passed as an argument to a procedure or function so that the procedure/function can process the array's data." & vbCrLf &
            "    Example: Sub DisplaySum(ByVal intArray() As Integer)" & vbCrLf & vbCrLf &
            "        - The procedure can then process the elements of the array." & vbCrLf & vbCrLf &
            "Returning an Array from a Function - A function can return an entire array as its return value." & vbCrLf &
            "    Example: Function GetNames() As String()" & vbCrLf & vbCrLf &
            "        - The String() indicates that the function returns an array of strings."
    End Sub




    'ONE_DIMENSIONAL'
    Private ReadOnly bookValues() As String = {"Sea Corals", "The Pine in Pine Tree", "Is Star Made out of Candy?", "Pearly Whites", "Gldn Crrt"}

    Private books() As PictureBox
    Private popup As Label
    Private Sub SetupBookHover()
        books = {b1, b2, b3, b4, b5}

        popup = New Label()
        popup.AutoSize = True
        popup.Size = New Size(200, 20)
        popup.Padding = New Padding(6)
        popup.TextAlign = ContentAlignment.MiddleLeft
        popup.BackColor = ColorTranslator.FromHtml("#fdd48a")
        popup.ForeColor = ColorTranslator.FromHtml("#5b2a0c")
        popup.BorderStyle = BorderStyle.FixedSingle
        popup.Font = New Font("rainyhearts", 10, FontStyle.Bold)
        popup.Visible = False
        popup.Parent = books(0).Parent

        For Each pb As PictureBox In books
            AddHandler pb.MouseEnter, AddressOf Book_MouseEnter
            AddHandler pb.MouseLeave, AddressOf Book_MouseLeave
        Next
    End Sub

    Private Sub Book_MouseEnter(sender As Object, e As EventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)
        Dim idx As Integer = System.Array.IndexOf(books, pb)

        popup.Text = "Index: " & idx & vbCrLf & "Value: " & bookValues(idx)

        popup.Left = pb.Left + (pb.Width - popup.Width) \ 2
        popup.Top = pb.Bottom + 6
        popup.Visible = True
        popup.BringToFront()
    End Sub

    Private Sub Book_MouseLeave(sender As Object, e As EventArgs)
        popup.Visible = False
    End Sub

    Private lessonHandlerAttached As Boolean = False

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

    Private Sub week7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub week7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class