Imports System.Runtime.Intrinsics
Imports System.Diagnostics

Public Class week2
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Const SB_VERT As Integer = 1
    Private Const SB_HORZ As Integer = 0
    Private Const SB_BOTH As Integer = 3

    Private currentTopic As String = ""

    Private encBalance As Decimal = 1000D
    Private Sub week2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenLocation1 As Point = PictureBox15.Parent.PointToScreen(PictureBox4.Location)
        Dim screenLocation2 As Point = PictureBox16.Parent.PointToScreen(PictureBox5.Location)
        Dim screenLocation3 As Point = PictureBox17.Parent.PointToScreen(PictureBox6.Location)
        Dim screenLocation4 As Point = PictureBox18.Parent.PointToScreen(PictureBox7.Location)
        Dim screenLocation5 As Point = PictureBox19.Parent.PointToScreen(PictureBox8.Location)
        Dim screenLocation6 As Point = backbtn.Parent.PointToScreen(backbtn.Location)

        PictureBox15.Parent = PictureBox5
        PictureBox16.Parent = PictureBox6
        PictureBox17.Parent = PictureBox7
        PictureBox18.Parent = PictureBox8
        PictureBox19.Parent = PictureBox9
        backbtn.Parent = PictureBox22

        backbtn.Location = PictureBox22.PointToClient(screenLocation6)
        PictureBox15.Location = PictureBox5.PointToClient(screenLocation1)
        PictureBox16.Location = PictureBox6.PointToClient(screenLocation2)
        PictureBox17.Location = PictureBox7.PointToClient(screenLocation3)
        PictureBox18.Location = PictureBox8.PointToClient(screenLocation4)
        PictureBox19.Location = PictureBox9.PointToClient(screenLocation5)

        richtextbox.ScrollBars = RichTextBoxScrollBars.Vertical
        ShowScrollBar(richtextbox.Handle, SB_VERT, False)
        richtextbox.BackColor = ColorTranslator.FromHtml("#fdc676")
        RTB2.BackColor = ColorTranslator.FromHtml("#fcd58a")
        outputbox.Visible = False
        output.Visible = False

        TextBox1.BackColor = ColorTranslator.FromHtml("#fdc170")


        Dim loc_class_and_objects As Point = class_and_objects.Parent.PointToScreen(class_and_objects.Location)
        class_and_objects.Parent = PictureBox5
        class_and_objects.Location = PictureBox5.PointToClient(loc_class_and_objects)

        Dim loc_encapsulation As Point = encapsulation.Parent.PointToScreen(encapsulation.Location)
        encapsulation.Parent = PictureBox6
        encapsulation.Location = PictureBox6.PointToClient(loc_encapsulation)

        Dim loc_polymorphism As Point = polymorphism.Parent.PointToScreen(polymorphism.Location)
        polymorphism.Parent = PictureBox7
        polymorphism.Location = PictureBox7.PointToClient(loc_polymorphism)

        Dim loc_inheritance As Point = inheritance.Parent.PointToScreen(inheritance.Location)
        inheritance.Parent = PictureBox8
        inheritance.Location = PictureBox8.PointToClient(loc_inheritance)

        Dim loc_interfaces As Point = interfaces.Parent.PointToScreen(interfaces.Location)
        interfaces.Parent = PictureBox9
        interfaces.Location = PictureBox9.PointToClient(loc_interfaces)

        Dim loc_output As Point = output.Parent.PointToScreen(output.Location)
        output.Parent = outputbox
        output.Location = outputbox.PointToClient(loc_output)
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click, class_and_objects.Click
        PictureBox5.Image = My.Resources.select1
        PictureBox6.Image = My.Resources.unselect
        PictureBox7.Image = My.Resources.unselect
        PictureBox8.Image = My.Resources.unselect
        PictureBox9.Image = My.Resources.unselect
        RTB2.Text = "Class and Object"
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        richtextbox.Text = "What is the difference between a CLASS and an OBJECT?" & vbCrLf & vbCrLf &
                           "The terms CLASS and OBJECT are sometimes used interchangeably, but in fact, CLASSES describe the type of OBJECTS, while OBJECTS are usable instances of CLASSES." & vbCrLf & vbCrLf &
                           "So, the act of creating an OBJECTS Is called INSTANTIATION. Using the blueprint analogy, a CLASS Is a blueprint, and an OBJECTS Is a building made from that blueprint." & vbCrLf & vbCrLf &
                           "In simplier terms:" & vbCrLf &
                           "CLASS - A blueprint or template that defines what an object has and can do." & vbCrLf &
                           "OBJECT - A specific thing created from the class that you can actually use." & vbCrLf &
                           "INSTANTIATION - The process of creating an object from a class."

        currentTopic = "ClassObject"
        outputbox.Visible = True
        output.Visible = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, encapsulation.Click
        PictureBox5.Image = My.Resources.unselect
        PictureBox6.Image = My.Resources.select1
        PictureBox7.Image = My.Resources.unselect
        PictureBox8.Image = My.Resources.unselect
        PictureBox9.Image = My.Resources.unselect
        RTB2.Text = "Encapsulation"
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        richtextbox.Text = "ENCAPSULATION means putting data and the methods that work with that data together inside a class." & vbCrLf & vbCrLf &
                            "It also means protecting the data from being directly accessed or changed by other parts of the program." & vbCrLf & vbCrLf &
                            "Instead, the data can be accessed or changed through specific methods, such as getters and setters." & vbCrLf & vbCrLf &
                            "In simple terms, encapsulation means keeping data safe and controlling how it can be accessed or changed. This makes the program more organized, secure, and easier to maintain."

        currentTopic = "Encapsulation"
        outputbox.Visible = True
        output.Visible = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox5.Image = My.Resources.unselect
        PictureBox6.Image = My.Resources.unselect
        PictureBox7.Image = My.Resources.select1
        PictureBox8.Image = My.Resources.unselect
        PictureBox9.Image = My.Resources.unselect
        RTB2.Text = "Polymorphism"
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        richtextbox.Text = "POLYMORPHISM is a fundamental concept in object-oriented programming that allows objects of different classes to be treated as instances of a common superclass." & vbCrLf & vbCrLf &
                           "It enables a single interface to represent different underlying data types or behaviors, facilitating flexibility and extensibility in code." & vbCrLf & vbCrLf &
                           "POLYMORPHISM can be achieved through method overriding, where a subclass provides a specific implementation of a method defined in its superclass, or through method overloading, where multiple methods share the same name but differ in parameters." & vbCrLf & vbCrLf &
                           "This concept is essential for designing systems that are modular, maintainable, and scalable."

        currentTopic = "Polymorphism"
        outputbox.Visible = True
        output.Visible = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox5.Image = My.Resources.unselect
        PictureBox6.Image = My.Resources.unselect
        PictureBox7.Image = My.Resources.unselect
        PictureBox8.Image = My.Resources.select1
        PictureBox9.Image = My.Resources.unselect
        RTB2.Text = "Inheritance"
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        richtextbox.Text = "INHERITANCE is where a class can get the properties and methods of another class. The class that gives the properties and methods is called the superclass (parent class), while the class that receives them is called the subclass (child class)." & vbCrLf & vbCrLf &
                           "INHERITANCE allows us to reuse existing code instead of writing the same code again. The child class can also add new properties or methods or change existing ones." & vbCrLf & vbCrLf &
                               "For example, an Animal class can have methods like Eat() and Sleep(). A Dog class can inherit these methods from Animal and also have its own method, such as Bark()." & vbCrLf & vbCrLf &
                                    "In simple terms:" & vbCrLf & vbCrLf &
                                    "Inheritance = A child class gets features and behaviors from a parent class."

        currentTopic = "Inheritance"
        outputbox.Visible = True
        output.Visible = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox5.Image = My.Resources.unselect
        PictureBox6.Image = My.Resources.unselect
        PictureBox7.Image = My.Resources.unselect
        PictureBox8.Image = My.Resources.unselect
        PictureBox9.Image = My.Resources.select1
        RTB2.Text = "Interfaces"
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        richtextbox.Text = "INTERFACES are used To define a contract that classes can implement." & vbCrLf & vbCrLf &
                           "INTERFACE specifies a Set Of methods, properties, Events, Or indexers that implementing classes must provide, without providing the actual implementation itself." & vbCrLf & vbCrLf &
                           "This allows for a form of abstraction And promotes loose coupling in your code."

        currentTopic = "Interfaces"
        outputbox.Visible = True
        output.Visible = True
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

    Private Sub week2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub week2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub richtextbox_Resize(sender As Object, e As EventArgs) Handles richtextbox.Resize
        ShowScrollBar(richtextbox.Handle, SB_VERT, False)
    End Sub

    Private Sub output_Click(sender As Object, e As EventArgs) Handles output.Click, outputbox.Click
        If currentTopic = "Encapsulation" Then
            Dim encapsulation As New Encapsulation
            encapsulation.Show()


        End If
        Dim cmdText = ""

        Select Case currentTopic
            Case "ClassObject"
                cmdText = "echo Example: Dim myDog As New Dog() ^& myDog.Name = ""Bantay"" & echo. & echo Output: Bantay"

            Case "Polymorphism"
                cmdText = "echo Example: Dim a As Animal = New Dog() ^& a.Speak() & echo. & echo Output: Woof!"

            Case "Inheritance"
                cmdText = "echo Example: Dim d As New Dog() ^& d.Eat() ^& d.Bark() & echo. & echo Output: Eating... ^& Woof!"

            Case "Interfaces"
                cmdText = "echo Example: Dim c As IMovable = New Car() ^& c.Move() & echo. & echo Output: Car is moving"

            Case "Encapsulation"
                Exit Sub

            Case Else
                Exit Sub
        End Select

        Process.Start("cmd.exe", "/k " & cmdText)
    End Sub

End Class