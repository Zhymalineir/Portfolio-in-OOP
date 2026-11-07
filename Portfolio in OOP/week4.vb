Public Class week4

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Const SB_VERT As Integer = 1

    Private lessonHandlerAttached As Boolean = False

    Private Sub week4_Load(sender As Object, e As EventArgs) Handles Me.Load

        Reparent(RTB3, PictureBox11)
        Reparent(RTB2, PictureBox10)
        Reparent(PictureBox8, borderstill)

        PictureBox9.Parent = borderstill
        PictureBox9.Location = PictureBox8.Location

        RTB3.BackColor = ColorTranslator.FromHtml("#fed589")
        RTB2.BackColor = ColorTranslator.FromHtml("#fed589")
        RTB3.ScrollBars = RichTextBoxScrollBars.Vertical

        ResetView()
    End Sub

    Private Sub Reparent(ctrl As Control, newParent As Control)
        Dim screenPos As Point = ctrl.Parent.PointToScreen(ctrl.Location)
        ctrl.Parent = newParent
        ctrl.Location = newParent.PointToClient(screenPos)
    End Sub

    Private Shared Function Lines(ParamArray parts() As String) As String
        Return String.Join(vbCrLf, parts)
    End Function

    Private Sub ShowTopic(title As String, body As String,
                          Optional showMini2 As Boolean = False,
                          Optional showMini1 As Boolean = False)

        borderstill.Visible = True
        exitbtn.Visible = False
        backbtn.Visible = True

        RTB2.Text = title
        RTB2.SelectAll()
        RTB2.SelectionAlignment = HorizontalAlignment.Center
        RTB2.Select(0, 0)

        RTB3.Text = body

        RTB2.Visible = True
        RTB3.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox8.Visible = showMini2
        PictureBox9.Visible = showMini1

        ShowScrollBar(RTB2.Handle, SB_VERT, False)
        ShowScrollBar(RTB3.Handle, SB_VERT, False)
    End Sub

    Private Sub ResetView()
        borderstill.Visible = False
        RTB2.Visible = False
        RTB3.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        backbtn.Visible = False
        exitbtn.Visible = True
    End Sub

    Private Sub RTB2_Resize(sender As Object, e As EventArgs) Handles RTB2.Resize
        ShowScrollBar(RTB2.Handle, SB_VERT, False)
    End Sub

    Private Sub RTB3_Resize(sender As Object, e As EventArgs) Handles RTB3.Resize
        ShowScrollBar(RTB3.Handle, SB_VERT, False)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ShowTopic("VB.NET Basic Controls", Lines(
            "An object is a type of user interface element you create on a Visual Basic form by using a toolbox control.",
            "",
            "In fact, in Visual Basic, the form itself is an object.",
            "",
            "Every Visual Basic control consists of three important elements:",
            "   - PROPERTIES describe the object,",
            "   - METHODS cause an object to do something,",
            "   - EVENTS are what happens when an object does something."))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ShowTopic("Control Properties", Lines(
            "All Visual Basic objects can be moved, resized or customized by setting their properties.",
            "",
            "A property is a value or characteristic held by a Visual Basic object, such as Caption or ForeColor.",
            "",
            "PROPERTIES can be set at design time by using the Properties window or at run time by using statements in the program code.",
            "",
            "OBJECT is the name of the object you're customizing.",
            "",
            "PROPERTY is the characteristic you want to change.",
            "",
            "VALUE is the new property setting."))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ShowTopic("Control Methods", Lines(
            "A method is a procedure created as a member of a class, and it causes an object to do something.",
            "",
            "Methods are used to access or manipulate the characteristics of an object or a variable.",
            "",
            "There are mainly two categories of methods you will use in your classes:",
            "",
            "If you are using a control such as one of those provided by the Toolbox, you can call any of its public methods.",
            "",
            "The requirements of such a method depend on the class being used.",
            "",
            "If none of the existing methods can perform your desired task, you can add a method to a class."))
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ShowTopic("Control Events", Lines(
            "An event is a signal that informs an application that something important has occurred.",
            "",
            "For example, when a user clicks a control on a form, the form can raise a Click event and call a procedure that handles the event.",
            "",
            "There are various types of events associated with a Form like click, double click, close, load, resize, etc."))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ShowTopic("Basic Controls", Lines(
            "VB.NET provides a huge variety of controls that help you to create a rich user interface.",
            "",
            "Functionalities of all these controls are defined in the respective control classes.",
            "",
            "The control classes are defined in the System.Windows.Forms namespace.",
            "",
            "The following table lists some of the commonly used controls:",
            "",
            "       1. Forms - The container for all the controls that make up the user interface.",
            "",
            "       2. TextBox - It represents a Windows text box control.",
            "",
            "       3. Label - It represents a standard Windows label.",
            "",
            "       4. Button - It represents a Windows button control.",
            "",
            "       5. ListBox - It represents a Windows control to display a list of items.",
            "",
            "       6. ComboBox - It represents a Windows combo box control.",
            "",
            "       7. RadioButton - It enables the user to select a single option from a group of choices when paired with other RadioButton controls.",
            "",
            "       8. CheckBox - It represents a Windows CheckBox.",
            "",
            "       9. PictureBox - It represents a Windows picture box control for displaying an image.",
            "",
            "       10. ProgressBar - It represents a Windows progress bar control.",
            "",
            "       11. ScrollBar - It implements the basic functionality of a scroll bar control.",
            "",
            "       12. DateTimePicker - It represents a Windows control that allows the user to select a date and a time and to display the date and time with a specified format."),
            showMini1:=True)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ShowTopic("Setting the Tab Index Property", Lines(
            "A tab index can consist of any valid integer greater than or equal to zero, lower numbers being earlier in the tab order.",
            "",
            "If more than one control on the same parent control has the same tab index, the z-order of the controls determines the order to cycle through the controls.",
            "",
            "For a control to be included in the tab order, its TabStop property must be set to True."))
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        ShowTopic("Anchoring and Docking", Lines(
            "The Anchor and Dock properties of a control are two separate properties.",
            "",
            "Anchor refers to the position a control has relative to the edges of the form. A textbox, for example, that is anchored to the left edge of a form will stay in the same position as the form is resized.",
            "",
            "Docking refers to how much space you want the control to take up on the form. If you dock a control to the left of the form, it will stretch itself to the height of the form, but its width will stay the same."),
            showMini2:=True)
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim mini As New week4mini()
        mini.LessonNumber = 2
        mini.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim mini As New week4mini()
        mini.LessonNumber = 1
        mini.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        ResetView()
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

    Private Sub week4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub
End Class