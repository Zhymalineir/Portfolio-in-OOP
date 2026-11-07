Imports System.Runtime.InteropServices

Public Class week10

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const SB_VERT As Integer = 1
    Private Const SB_BOTH As Integer = 3
    Private Const EM_LINESCROLL As Integer = &HB6

    Private hiding As Boolean = False

    Private Sub HideBars()
        If hiding Then Return
        hiding = True
        Try
            If RTB2.IsHandleCreated Then ShowScrollBar(RTB2.Handle, SB_BOTH, False)
            If RTB3.IsHandleCreated Then ShowScrollBar(RTB3.Handle, SB_VERT, False)
            If parentpanel.IsHandleCreated Then ShowScrollBar(parentpanel.Handle, SB_BOTH, False)
        Finally
            hiding = False
        End Try
    End Sub

    Private Sub RTB2_Refresh_Handler(sender As Object, e As EventArgs) _
        Handles RTB2.Resize, RTB2.HandleCreated, RTB2.MouseEnter
        HideBars()
    End Sub

    Private Sub RTB3_Refresh_Handler(sender As Object, e As EventArgs) _
        Handles RTB3.TextChanged, RTB3.Resize, RTB3.HandleCreated
        HideBars()
    End Sub

    Private Sub parentpanel_Refresh_Handler(sender As Object, e As EventArgs) _
        Handles parentpanel.Resize, parentpanel.HandleCreated
        HideBars()
    End Sub

    Private Sub RTB2_MouseEnter(sender As Object, e As EventArgs) Handles RTB2.MouseEnter
        If Not RTB2.Focused Then RTB2.Focus()
    End Sub

    Private Sub RTB3_MouseEnter(sender As Object, e As EventArgs) Handles RTB3.MouseEnter
        If Not RTB3.Focused Then RTB3.Focus()
    End Sub

    Private Sub RTB2_MouseWheel(sender As Object, e As MouseEventArgs) Handles RTB2.MouseWheel
        Dim lines As Integer = If(e.Delta > 0, -3, 3)
        SendMessage(RTB2.Handle, EM_LINESCROLL, 0, lines)
        Dim h = TryCast(e, HandledMouseEventArgs)
        If h IsNot Nothing Then h.Handled = True
    End Sub

    Private Sub RTB3_MouseWheel(sender As Object, e As MouseEventArgs) Handles RTB3.MouseWheel
        Dim lines As Integer = If(e.Delta > 0, -3, 3)
        SendMessage(RTB3.Handle, EM_LINESCROLL, 0, lines)
        Dim h = TryCast(e, HandledMouseEventArgs)
        If h IsNot Nothing Then h.Handled = True
    End Sub

    Private Sub week10_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim pos As Point = parentpanel.PointToClient(RTB2.PointToScreen(Point.Empty))
        Dim pos1 As Point = bg.PointToClient(backbtn.PointToScreen(Point.Empty))

        RTB2.Parent = parentpanel
        backbtn.Parent = bg
        RTB2.Location = pos
        backbtn.Location = pos1
        RTB2.BackColor = Color.Transparent

        ui1.Parent = bg
        ui2.Parent = bg
        backbtn.BringToFront()

        HideBars()
    End Sub

    Private Sub classesandobjects_Click(sender As Object, e As EventArgs) Handles classesandobjects.Click
        RTB3.Text = "Class - A class groups different functions, methods, variables, and properties, which are called its members. It encapsulates these members, which can be accessed by an instance of the class called an object. Classes are the building blocks of object-oriented programming languages." & vbCrLf & vbCrLf &
                    "Abstract Class - A base class used to group common functionality shared by classes. Abstract classes can contain partial or no implementation and allow the derived type to override the base implementation." & vbCrLf & vbCrLf &
                    "Object - A self-contained component that contains properties and methods needed to make a certain type of data useful." & vbCrLf & vbCrLf &
                    "Class Blueprint - A class is a blueprint, template, or set of instructions used to build a specific type of object. Every object is built from a class, and each class should be designed and programmed to accomplish one thing." & vbCrLf & vbCrLf &
                    "Inheritance - The process in which a subtype inherits the declared types of a base class. The subtype can access inherited members based on the underlying access modifier." & vbCrLf & vbCrLf &
                    "Instance - An object created from a class. In the example provided, a new `Car` instance is created, and its `DisplayWheelCount()` method calls the base class `Vehicles` implementation."
    End Sub

    Private Sub creatingclasses_Click(sender As Object, e As EventArgs) Handles creatingclasses.Click
        RTB3.Text = "Fields - Variables declared within a class to store data." & vbCrLf & vbCrLf &
                    "Properties - Members of a class that expose or provide access to data." & vbCrLf & vbCrLf &
                    "Methods - Functions or procedures defined within a class to perform operations." & vbCrLf & vbCrLf &
                    "Constructors - Class members used when creating an instance of a class." & vbCrLf & vbCrLf &
                    "Events - Class members that represent occurrences or actions that other parts of a program can respond to." & vbCrLf & vbCrLf &
                    "Class Definition - A definition that allows you to create your own types within the .NET framework." & vbCrLf & vbCrLf &
                    "Access Modifier - A modifier that determines which members of a class can be accessed by other code."
    End Sub

    Private Sub erroranddebugging_Click(sender As Object, e As EventArgs) Handles erroranddebugging.Click
        RTB3.Text = "Error - A mistake in a program, often referred to as a bug. Errors are classified into syntax errors, run-time errors, and logic errors." & vbCrLf & vbCrLf &
                    "Bug - A mistake or error in a program." & vbCrLf & vbCrLf &
                    "Debugging - The process of finding and eliminating errors in a program." & vbCrLf & vbCrLf &
                    "Syntax Error - A mistake that violates Visual Basic programming rules, such as misspelling a property or keyword. The program cannot run until the syntax error is fixed." & vbCrLf & vbCrLf &
                    "Compiler Error - Another term for a syntax error caused by violating programming language rules." & vbCrLf & vbCrLf &
                    "Run-time Error - A mistake that causes a program to stop unexpectedly during execution. It may occur when a particular line is executed or when an outside event causes the program to stop." & vbCrLf & vbCrLf &
                    "Logic Error - A mistake caused by faulty reasoning or planning that makes a program produce incorrect results. It is not caused by a misunderstanding of Visual Basic syntax." & vbCrLf & vbCrLf &
                    "Program Crash - A situation in which a program halts unexpectedly because of a run-time error."
    End Sub

    Private Sub errorhandling_Click(sender As Object, e As EventArgs) Handles errorhandling.Click
        RTB3.Text = "Error Handling - The process of managing errors that occur during program execution." & vbCrLf & vbCrLf &
                    "Try Statement - The part of a `Try...Catch...Finally` structure where code that may produce an error is executed." & vbCrLf & vbCrLf &
                    "Catch Statement - The part of a `Try...Catch...Finally` structure used to handle an error that occurs in the `Try` block." & vbCrLf & vbCrLf &
                    "Finally Statement - The part of a `Try...Catch...Finally` structure used for code that executes after the `Try` and `Catch` sections."
    End Sub

    Private Sub debuggingmode_Click(sender As Object, e As EventArgs) Handles debuggingmode.Click
        RTB3.Text = "Debugging Mode - A mode, also called break mode, that allows you to examine a program while it is running." & vbCrLf & vbCrLf &
                    "Break Mode - Another name for debugging mode, where you can inspect your code during execution." & vbCrLf & vbCrLf &
                    "Step-by-Step Execution - Executing program code one line at a time to identify logic errors." & vbCrLf & vbCrLf &
                    "Variable Inspection - Examining the contents of variables or properties as they change during program execution." & vbCrLf & vbCrLf &
                    "Code Editor - The editor where you view and examine your program code while debugging."
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim f As finals = Application.OpenForms.OfType(Of finals)().FirstOrDefault()
        If f Is Nothing Then f = New finals()

        f.Show()
        f.ShowMainScreen()
        Hide()
    End Sub

End Class