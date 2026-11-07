Public Class week3

    Private currentSourcePic As PictureBox = Nothing
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Const SB_VERT As Integer = 1
    Private Const SB_HORZ As Integer = 0
    Private Const SB_BOTH As Integer = 3

    Private Sub week3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        backbtn.Parent = PictureBox3

        Dim screenLocation1 As Point = PictureBox4.Parent.PointToScreen(PictureBox4.Location)
        Dim screenLocation2 As Point = PictureBox5.Parent.PointToScreen(PictureBox5.Location)
        Dim screenLocation3 As Point = PictureBox6.Parent.PointToScreen(PictureBox6.Location)
        Dim screenLocation4 As Point = PictureBox7.Parent.PointToScreen(PictureBox7.Location)
        Dim screenLocation5 As Point = PictureBox8.Parent.PointToScreen(PictureBox8.Location)
        Dim screenLocation6 As Point = PictureBox9.Parent.PointToScreen(PictureBox9.Location)
        Dim screenLocation7 As Point = PictureBox10.Parent.PointToScreen(PictureBox10.Location)
        Dim screenLocation8 As Point = PictureBox11.Parent.PointToScreen(PictureBox11.Location)
        Dim screenLocation9 As Point = PictureBox12.Parent.PointToScreen(PictureBox12.Location)
        Dim screenLocation10 As Point = PictureBox13.Parent.PointToScreen(PictureBox13.Location)
        Dim screenLocation11 As Point = PictureBox14.Parent.PointToScreen(PictureBox14.Location)
        Dim screenLocation12 As Point = PictureBox15.Parent.PointToScreen(PictureBox15.Location)
        Dim screenLocation13 As Point = PictureBox16.Parent.PointToScreen(PictureBox16.Location)
        Dim screenLocation14 As Point = PictureBox17.Parent.PointToScreen(PictureBox17.Location)
        Dim screenLocation15 As Point = PictureBox18.Parent.PointToScreen(PictureBox18.Location)
        Dim screenLocation16 As Point = PictureBox19.Parent.PointToScreen(PictureBox19.Location)
        Dim screenLocation17 As Point = PictureBox20.Parent.PointToScreen(PictureBox20.Location)

        PictureBox4.Parent = inventory
        PictureBox5.Parent = inventory
        PictureBox6.Parent = inventory
        PictureBox7.Parent = inventory
        PictureBox8.Parent = inventory
        PictureBox9.Parent = inventory
        PictureBox10.Parent = inventory
        PictureBox11.Parent = inventory
        PictureBox12.Parent = inventory
        PictureBox13.Parent = inventory
        PictureBox14.Parent = inventory
        PictureBox15.Parent = inventory
        PictureBox16.Parent = inventory
        PictureBox17.Parent = inventory
        PictureBox18.Parent = inventory
        PictureBox19.Parent = inventory
        PictureBox20.Parent = inventory

        PictureBox4.Location = inventory.PointToClient(screenLocation1)
        PictureBox5.Location = inventory.PointToClient(screenLocation2)
        PictureBox6.Location = inventory.PointToClient(screenLocation3)
        PictureBox7.Location = inventory.PointToClient(screenLocation4)
        PictureBox8.Location = inventory.PointToClient(screenLocation5)
        PictureBox9.Location = inventory.PointToClient(screenLocation6)
        PictureBox10.Location = inventory.PointToClient(screenLocation7)
        PictureBox11.Location = inventory.PointToClient(screenLocation8)
        PictureBox12.Location = inventory.PointToClient(screenLocation9)
        PictureBox13.Location = inventory.PointToClient(screenLocation10)
        PictureBox14.Location = inventory.PointToClient(screenLocation11)
        PictureBox15.Location = inventory.PointToClient(screenLocation12)
        PictureBox16.Location = inventory.PointToClient(screenLocation13)
        PictureBox17.Location = inventory.PointToClient(screenLocation14)
        PictureBox18.Location = inventory.PointToClient(screenLocation15)
        PictureBox19.Location = inventory.PointToClient(screenLocation16)
        PictureBox20.Location = inventory.PointToClient(screenLocation17)

        RTB2.ScrollBars = RichTextBoxScrollBars.Vertical
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
        RTB2.BackColor = ColorTranslator.FromHtml("#fcd58a")
        storage.AllowDrop = True
        chestclosed.Image = My.Resources.chestclosed

        PictureBox4.Tag = "1"
        PictureBox5.Tag = "2"
        PictureBox6.Tag = "3"
        PictureBox7.Tag = "4"
        PictureBox8.Tag = "5"
        PictureBox9.Tag = "6"
        PictureBox10.Tag = "7"
        PictureBox11.Tag = "8"
        PictureBox12.Tag = "9"
        PictureBox13.Tag = "10"
        PictureBox14.Tag = "11"
        PictureBox15.Tag = "12"
        PictureBox16.Tag = "13"
        PictureBox17.Tag = "14"
        PictureBox18.Tag = "15"
        PictureBox19.Tag = "16"
        PictureBox20.Tag = "17"

        For Each ctrl As Control In inventory.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl IsNot storage AndAlso ctrl.Tag IsNot Nothing Then
                ctrl.AllowDrop = True
                AddHandler ctrl.DragEnter, AddressOf Slot_DragEnter
                AddHandler ctrl.DragDrop, AddressOf Slot_DragDrop
            End If
        Next

        TextBox1.BackColor = ColorTranslator.FromHtml("#fed488")

    End Sub
    Private Sub storage_MouseDown(sender As Object, e As MouseEventArgs) Handles storage.MouseDown
        If currentSourcePic IsNot Nothing Then
            storage.DoDragDrop(storage, DragDropEffects.Move)
        End If
    End Sub
    Private Sub Slot_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(GetType(PictureBox)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub Slot_DragDrop(sender As Object, e As DragEventArgs)
        Dim droppedPic As PictureBox = CType(e.Data.GetData(GetType(PictureBox)), PictureBox)

        If droppedPic Is storage AndAlso currentSourcePic IsNot Nothing Then
            currentSourcePic.Image = storage.Image
            storage.Image = Nothing
            currentSourcePic = Nothing
            RTB2.Text = ""
            chestclosed.Image = My.Resources.chestclosed
        End If
    End Sub
    Private Sub storage_DragEnter(sender As Object, e As DragEventArgs) Handles storage.DragEnter
        If e.Data.GetDataPresent(GetType(PictureBox)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub
    Private Sub storage_DragDrop(sender As Object, e As DragEventArgs) Handles storage.DragDrop
        Dim droppedPic As PictureBox = CType(e.Data.GetData(GetType(PictureBox)), PictureBox)
        If currentSourcePic IsNot Nothing Then
            currentSourcePic.Image = storage.Image
        End If

        storage.Image = droppedPic.Image
        droppedPic.Image = Nothing
        currentSourcePic = droppedPic

        chestclosed.Image = My.Resources.chestopen
        Select Case droppedPic.Tag.ToString()
            Case "1"
                RTB2.Text = "What is Computer Programming?" & vbCrLf & vbCrLf &
                            "Computers can only follow instructions." & vbCrLf & vbCrLf &
                            "A computer program is a set of instructions on how to solve a problem or perform a task." & vbCrLf & vbCrLf &
                            "Computer programming is the process of developing and implementing various sets of instructions to enable a computer to do a certain task. These instructions are considered computer programs and help the computer to operate smoothly."

            Case "2"
                RTB2.Text = "Programming Languages" & vbCrLf & vbCrLf &
                            " - The steps in an algorithm must be stated in a form the computer understands." & vbCrLf & vbCrLf &
                            " - The CPU processes a series of 1’s and 0’s called machine language instructions." & vbCrLf & vbCrLf &
                            " - This is a tedious and difficult format for people." & vbCrLf & vbCrLf &
                            " - Programming languages allow us to use words instead of numbers." & vbCrLf & vbCrLf &
                            " - Special software called a compiler converts the programming language statements to machine language instructions." & vbCrLf & vbCrLf & vbCrLf &
                            "Example" & vbCrLf &
                            " 1. Visual Basic, C# - Popular programming languages for building Windows and Web applications." & vbCrLf & vbCrLf &
                            " 2. C, C++	- Powerful advanced programming languages that emphasize flexibility and fast running times. C++ is also object-oriented." & vbCrLf & vbCrLf &
                            " 3. Java - Flexible and powerful programming language that runs on many different computer systems. Often used to teach object-oriented programming." & vbCrLf & vbCrLf &
                            " 4. Python - Simple, yet powerful programming language used for graphics and small applications." & vbCrLf & vbCrLf &
                            " 5. PHP - Programming language used for creating interactive Web sites." & vbCrLf & vbCrLf &
                            " 6. JavaScript - Scripting language used in Web applications that provides rich user interfaces for Web browsers."
            Case "3"
                RTB2.Text = "What is a Program Made of?" & vbCrLf & vbCrLf &
                            " 1. Keywords (Reserved Words) - Words with special meaning  that make up a high-level programming language, cannot be used for any other purpose." & vbCrLf & vbCrLf &
                            " 2. Operators - Special symbols that perform various operations on data." & vbCrLf & vbCrLf &
                            " 3. Variables - Used to store data in memory, named by the programmer." & vbCrLf & vbCrLf &
                            " 4. Syntax - Set of rules that is similar to the syntax (rules) of a spoken language, such as English, but must be strictly followed. If even a single syntax error appears in a program, it will not compile or execute." & vbCrLf & vbCrLf &
                            " 5. Statements - Instructions made up of keywords, variables, and operators. Called source code, or simply code." & vbCrLf & vbCrLf &
                            " 6. Procedures - Set of programming statements that perform a specific task." & vbCrLf & vbCrLf &
                            " 7. Comments (Remarks) - Ignored when the program runs, help human reader understand the purpose of programming statements. In Visual Basic, any statement that begins with an apostrophe (')."
            Case "4"
                RTB2.Text = "Translation of Programming Languages" & vbCrLf & vbCrLf &
                            "A translator or programming language processor is a computer program that performs the translation of a program written in a given programming language into a functionally equivalent program in another computer language (the target language), without losing the functional or logical structure of the original code (the ESSENCE of each program)."
            Case "5"
                RTB2.Text = "What is an IDE?" & vbCrLf & vbCrLf &
                            "An Integrated Development Environment (IDE) is a software application that provides comprehensive facilities to computer programmers for software development. An IDE normally consists of a source code editor, build automation tools, and a debugger."
            Case "6"
                RTB2.Text = "Startup Page - The initial page of Visual Studio where you can begin working with the development environment, such as starting a new project." & vbCrLf & vbCrLf &
                            "A. Create a New Project - Lets you create a new application/project." & vbCrLf &
                            "      You choose things such as:" & vbCrLf &
                            "                1. Project type/template" & vbCrLf &
                            "                2. Programming language" & vbCrLf &
                            "                3. Project name" & vbCrLf &
                            "                4. Location where the project will" & vbCrLf &
                            "                   be saved" & vbCrLf & vbCrLf &
                            "B. Open a Project or Solution - Lets you open an existing Visual Studio project. A solution can contain one or more projects." & vbCrLf & vbCrLf &
                            "C. Recent Projects / Recent Solutions - Shows projects or solutions you recently worked on. Useful because you don't have to search for the project's location every time."
            Case "7"
                RTB2.Text = "The Menu Bar" & vbCrLf & vbCrLf &
                            "The menu bar appears at the top of the Visual Studio window." & vbCrLf &
                            "      Provides menus such as:" & vbCrLf &
                            "                1. File" & vbCrLf &
                            "                2. Edit" & vbCrLf &
                            "                3. View" & vbCrLf &
                            "                4. Project"
            Case "8"
                RTB2.Text = "The Standard Tool Bar" & vbCrLf & vbCrLf &
                            "The standard toolbar contains buttons that execute frequently used commands. Provides quick access to commands that would otherwise be executed from a menu."
            Case "9"
                RTB2.Text = "The Toolbox" & vbCrLf & vbCrLf &
                            "The Toolbox is a window for selecting controls to use in an application’s user interface." & vbCrLf & vbCrLf &
                            "Divided into sections such as All Windows Forms and Common Controls." & vbCrLf & vbCrLf &
                            "To open a section, click on its name tab." & vbCrLf & vbCrLf &
                            "To close a section, click on its name tab again." & vbCrLf & vbCrLf &
                            "Move a section to the top by dragging its name with the mouse."
            Case "10"
                RTB2.Text = "Solution Explorer window" & vbCrLf & vbCrLf &
                            "This is a section that is used to view and modify the contents of the project. A Visual Studio Windows Application Project will generally have a form object with a code page, references to system components and possibly other modules with special code that is used by the application."
            Case "11"
                RTB2.Text = "Properties Window" & vbCrLf & vbCrLf &
                            "The properties windows shows all the control (like TextBox) properties to be changed at design time. Most of these properties can be also changed with code at run time, but basically most properties change the way the control is displayed on your application."
            Case "12"
                RTB2.Text = "Form Designer window" & vbCrLf & vbCrLf &
                            "The Form Designer allows you to design your application's user interface visually by dragging controls onto a design-time representation of your application. Once the controls are on the form, you can visually position the controls, set their properties through the Properties window, and create event handlers for the events."
            Case "13"
                RTB2.Text = "Output, Error List and Command window" & vbCrLf & vbCrLf &
                            "The Output window can display status messages for various features in the integrated development environment (IDE)." & vbCrLf & vbCrLf &
                            "To open the Output window, on the menu bar, choose View/Output (or click CTRL + ALT + O)." & vbCrLf & vbCrLf &
                            "The Error List displays information about a specific error message." & vbCrLf & vbCrLf &
                            "You can copy the error number or error string text from the Output window." & vbCrLf & vbCrLf &
                            "To display the Output window, press Ctrl+Alt+O." & vbCrLf & vbCrLf &
                            "The Command window is used to execute commands or aliases directly in the Visual Studio integrated development environment (IDE)." & vbCrLf & vbCrLf &
                            "You can execute both menu commands and commands that do not appear on any menu." & vbCrLf & vbCrLf &
                            "To display the Command window, choose other windows from the View menu, and select Command Window."
            Case "14"
                RTB2.Text = "Auto Hide" & vbCrLf & vbCrLf &
                            "Many windows have a feature known as Auto Hide." & vbCrLf & vbCrLf &
                            "Allows for more room to view an application’s forms and code." & vbCrLf & vbCrLf &
                            "Click on the pushpin icon to turn auto hide on or off."
            Case "15"
                RTB2.Text = "ToolTips" & vbCrLf & vbCrLf &
                            "A ToolTip is a small rectangular box that pops up when you hover the mouse pointer over a button on the toolbar or Toolbox for a few seconds." & vbCrLf & vbCrLf &
                            "Contains a short description of the button’s purpose" & vbCrLf & vbCrLf &
                            "Use a ToolTip whenever you cannot remember a particular button’s function"
            Case "16"
                RTB2.Text = "Docked and Floating Windows" & vbCrLf & vbCrLf &
                            "When a window is docked" & vbCrLf &
                            "    It is attached to one of the edges of the Visual Studio environment" & vbCrLf & vbCrLf &
                            "When a window is floating" & vbCrLf &
                            "    You can resize the window as well as click and drag it by its title bar." & vbCrLf &
                            "    Right-click a window’s title bar and select Float or Dock to change between floating or docked."
            Case "17"
                RTB2.Text = "Consoler Application" & vbCrLf & vbCrLf &
                            "Console Applications have recently been introduced in Visual Basic .NET, they are command-line based applications." & vbCrLf & vbCrLf &
                            "Console Applications allow us to write data to the console read data from the console, and run in within a DOS Shell." & vbCrLf & vbCrLf &
                            "They do not support Windows GUI's. Console Applications are supported by the system. Console namespace."
                Process.Start("cmd", "/k This is a Console Application!")
            Case Else
                RTB2.Text = "Unknown item."
        End Select
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

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        PictureBox4.DoDragDrop(PictureBox4, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        PictureBox5.DoDragDrop(PictureBox5, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        PictureBox6.DoDragDrop(PictureBox6, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        PictureBox7.DoDragDrop(PictureBox7, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        PictureBox8.DoDragDrop(PictureBox8, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        PictureBox9.DoDragDrop(PictureBox9, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        PictureBox10.DoDragDrop(PictureBox10, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        PictureBox11.DoDragDrop(PictureBox11, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseDown
        PictureBox12.DoDragDrop(PictureBox12, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox13_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox13.MouseDown
        PictureBox13.DoDragDrop(PictureBox13, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox14_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox14.MouseDown
        PictureBox14.DoDragDrop(PictureBox14, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox15_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox15.MouseDown
        PictureBox15.DoDragDrop(PictureBox15, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox16_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox16.MouseDown
        PictureBox16.DoDragDrop(PictureBox16, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox17_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox17.MouseDown
        PictureBox17.DoDragDrop(PictureBox17, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox18_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox18.MouseDown
        PictureBox18.DoDragDrop(PictureBox18, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox19_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox19.MouseDown
        PictureBox19.DoDragDrop(PictureBox19, DragDropEffects.Move)
    End Sub
    Private Sub PictureBox20_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox20.MouseDown
        PictureBox20.DoDragDrop(PictureBox20, DragDropEffects.Move)
    End Sub
    Private Sub week3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub RTB2_Resize(sender As Object, e As EventArgs) Handles RTB2.Resize
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
    End Sub


End Class