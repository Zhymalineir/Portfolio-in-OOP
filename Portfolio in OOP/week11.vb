Imports System.Runtime.InteropServices

Public Class week11

    Private WithEvents gifTimer As New Timer()
    Private playing As Boolean = False

    Private selectedBtn As Integer = 0

    Private ReadOnly content As New Dictionary(Of String, String())()

    Private Const MaxSlots As Integer = 4

    Private Sub week11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shop_Vendor.Parent = bg
        Shop_Panel.Parent = bg
        backbtn.Parent = bg

        Vendor_Gif.BackColor = Color.Transparent
        Vendor_Gif.Visible = False
        Shop_Panel.Visible = False
        sample_MDI.Visible = False
        backbtn.Visible = False
        RTB2.BackColor = ColorTranslator.FromHtml("#fdbe6f")
        RTB1.BackColor = ColorTranslator.FromHtml("#fdbe6f")
        BuildContent()
    End Sub
    Private Sub week11_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReparentKeepPosition(b1, box)
        ReparentKeepPosition(b2, box)
        ReparentKeepPosition(b3, box)
        ReparentKeepPosition(b4, box)
    End Sub
    Private Sub ReparentKeepPosition(ctrl As Control, newParent As Control)
        Dim screenPos As Point = ctrl.Parent.PointToScreen(ctrl.Location)
        ctrl.Parent = newParent
        ctrl.Location = newParent.PointToClient(screenPos)
        ctrl.BringToFront()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const SB_BOTH As Integer = 3
    Private Const EM_LINESCROLL As Integer = &HB6

    Private Sub HideBars()
        If RTB1.IsHandleCreated Then ShowScrollBar(RTB1.Handle, SB_BOTH, False)
        If RTB2.IsHandleCreated Then ShowScrollBar(RTB2.Handle, SB_BOTH, False)
    End Sub

    Private Sub RTB_Refresh_Handler(sender As Object, e As EventArgs) _
    Handles RTB1.TextChanged, RTB1.Resize, RTB1.HandleCreated, RTB1.VisibleChanged,
            RTB2.TextChanged, RTB2.Resize, RTB2.HandleCreated, RTB2.VisibleChanged,
            Shop_Panel.VisibleChanged
        HideBars()
    End Sub

    Private Sub RTB_MouseEnter(sender As Object, e As EventArgs) Handles RTB1.MouseEnter, RTB2.MouseEnter
        DirectCast(sender, Control).Focus()
    End Sub

    Private Sub RTB_MouseWheel(sender As Object, e As MouseEventArgs) Handles RTB1.MouseWheel, RTB2.MouseWheel
        Dim lines As Integer = If(e.Delta > 0, -3, 3)
        SendMessage(DirectCast(sender, Control).Handle, EM_LINESCROLL, 0, lines)
        Dim h = TryCast(e, HandledMouseEventArgs)
        If h IsNot Nothing Then h.Handled = True
    End Sub
    Private Sub Shop_Vendor_Click(sender As Object, e As EventArgs) Handles Shop_Vendor.Click
        If playing Then Return
        playing = True

        Dim gif As Image = My.Resources.wk11_animation

        Vendor_Gif.Image = Nothing
        Vendor_Gif.Image = gif
        Vendor_Gif.Visible = True
        Vendor_Gif.BringToFront()

        gifTimer.Interval = Math.Max(GetGifDuration(gif), 100)
        gifTimer.Start()
    End Sub

    Private Sub gifTimer_Tick(sender As Object, e As EventArgs) Handles gifTimer.Tick
        gifTimer.Stop()
        playing = False

        Vendor_Gif.Visible = False
        Vendor_Gif.Image = Nothing

        Shop_Panel.Visible = True
        Shop_Panel.BringToFront()
        backbtn.Visible = True
        backbtn.BringToFront()

        SelectBtn(1)
    End Sub

    Private Function GetGifDuration(img As Image) As Integer
        Try
            Dim fd As New Imaging.FrameDimension(img.FrameDimensionsList(0))
            Dim frames As Integer = img.GetFrameCount(fd)
            Dim delays As Byte() = img.GetPropertyItem(&H5100).Value
            Dim total As Integer = 0
            For i As Integer = 0 To frames - 1
                total += BitConverter.ToInt32(delays, i * 4) * 10
            Next
            Return total
        Catch
            Return 2000
        End Try
    End Function

    Private Sub btn_Click(sender As Object, e As EventArgs) _
        Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click

        SelectBtn(CInt(DirectCast(sender, Control).Name.Substring(3)))
    End Sub

    Private Sub SelectBtn(number As Integer)
        selectedBtn = number

        Dim bButtons As Control() = {b1, b2, b3, b4}
        For slot As Integer = 1 To MaxSlots
            bButtons(slot - 1).Visible = content.ContainsKey(Key(selectedBtn, slot))
        Next

        ShowSlot(1)
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click
        ShowSlot(CInt(DirectCast(sender, Control).Name.Substring(1)))
    End Sub

    Private Sub ShowSlot(slot As Integer)
        Dim item As String() = Nothing
        If Not content.TryGetValue(Key(selectedBtn, slot), item) Then Return

        RTB2.Text = item(0)

        If item(1) Is Nothing Then
            RTB1.Visible = False
            sample_MDI.Visible = True
        Else
            sample_MDI.Visible = False
            RTB1.Visible = True
            RTB1.Text = item(1)
        End If
    End Sub

    Private Function Key(btn As Integer, slot As Integer) As String
        Return btn & "-" & slot
    End Function

    Private Sub Add(btn As Integer, slot As Integer, title As String, body As String)
        content(Key(btn, slot)) = {title, body}
    End Sub

    Private Function Para(ParamArray lines As String()) As String
        Return String.Join(vbCrLf, lines)
    End Function

    Private Sub BuildContent()

        Add(1, 1, ".NET Framework", Para(
            "The .NET Framework is a software development framework from Microsoft that provides a controlled programming environment for developing, installing, and executing software on Windows-based operating systems.",
            "",
            "Main Features:",
            "   a. Language Independence - Allows data types to be exchanged between programs developed in different programming languages through Common Language Infrastructure (CLI) specifications.",
            "   b. Base Class Library (BCL) - A collection of reusable code for common programming functions, reducing the need to rewrite code.",
            "   c. Ease of Deployment - Provides tools that help install programs without interfering with previously installed applications.",
            "   d. Security - Uses a common security model for programs developed in .NET."))

        Add(1, 2, "Components of the .NET Framework", Para(
            "A. Common Language Runtime (CLR) - The runtime component of .NET that provides the environment in which managed programs execute.",
            "B. .NET Framework Class Library - A library of reusable classes and code that provides common functions for developing applications."))

        Add(1, 3, "Classes in the .NET Framework", Para(
            "A class is a blueprint that defines the data and behavior of objects. In the .NET Framework, classes provide reusable functionality that programmers can use in their applications.",
            "",
            "   a. System.String - Handles text.",
            "   b. System.Char - Represents a character.",
            "   c. System.Text.StringBuilder - Supports repeated text modifications.",
            "   d. System.Drawing.Graphics - Provides drawing methods.",
            "   e. System.Drawing.Printing.PrintDocument - Represents a document to be printed."))

        Add(1, 4, "Code Snippets and My Components", Para(
            "a. Code Snippets - Reusable pieces of code that can be inserted into a program to help write code more efficiently.",
            "",
            "b. My Components - The lesson lists this as a topic, but the provided slide text does not contain a detailed definition or explanation."))

        Add(2, 1, "Multi-Document Interface", Para(
            "MDI is an interface designed to simplify the exchange of information among multiple documents or windows within a single application.",
            "",
            "An MDI application allows multiple windows to remain open under one main application, rather than opening multiple copies of the application."))

        Add(2, 2, "Parent Form and Child Forms", Para(
            "A. Parent Form - The main form that contains and manages the child forms. An MDI application has only one parent form.",
            "",
            "B. Child Forms - The forms contained within the parent form. An MDI application must have at least one child form and can contain many."))

        Add(2, 3, "Example", Nothing)

        Add(3, 1, "Drawing in VB.NET", Para(
            "Drawing involves using graphical methods to display text, images, or other visual elements in an application.",
            "",
            "The following Graphics methods are used for drawing:",
            "   a. Graphics.DrawString() - Draws text on a page.",
            "   b. Graphics.DrawImage() - Draws an image on a page."))

        Add(4, 1, "Printing Controls", Para(
            "Printing Controls - Printing controls allow an application to prepare documents, select printing options, and preview the output.",
            "",
            "PrintDocument - A non-visual component representing the document to be printed. It raises BeginPrint, PrintPage, and EndPrint events.",
            "",
            "PrintDialog - Displays a dialog for selecting a printer, page range, and number of copies.",
            "",
            "PrintPreviewDialog - Displays a preview window showing how a document will look before printing.",
            "",
            "PrintPreviewControl - An embeddable preview control that can be placed directly on a form.",
            "",
            "PageSetupDialog - Allows users to configure margins, paper size, and page orientation."))

        Add(4, 2, "Important Printing Members", Para(
            "Print() - Starts the printing process and raises the PrintPage event.",
            "",
            "PrintPage - An event that handles the drawing of each page to be printed.",
            "",
            "HasMorePages - Indicates whether another page should be printed. True means continue; False means finish.",
            "",
            "MarginBounds - Represents the printable area inside the page margins.",
            "",
            "ShowDialog() - Displays a dialog and returns a DialogResult.",
            "",
            "PrinterSettings - Contains information about the selected printer, copies, and page range.",
            "",
            "Graphics.DrawString() - Draws text on the printed page.",
            "",
            "Graphics.DrawImage() - Draws an image on the printed page."))

        Add(4, 3, "How Printing Works", Para(
            "1. Create PrintDocument - Create the component by dragging it from the Toolbox or declaring it in code.",
            "",
            "2. Call Print() - Start the printing process through a button, menu, or dialog result.",
            "",
            "3. Handle PrintPage - The event runs for each page that needs to be printed.",
            "",
            "4. Draw with Graphics - Use e.Graphics.DrawString() or e.Graphics.DrawImage() to draw the page content."))

        Add(5, 1, "String and Char", Para(
            "a. A String is an immutable sequence of characters. Any modification creates a new string.",
            "",
            "b. A Char represents a single 16-bit Unicode character. In VB.NET, character literals use the c suffix (e.g., ""A""c)."))

        Add(5, 2, "String Properties and Methods", Para(
            "Length - Returns the number of characters.",
            "",
            "ToUpper() / ToLower() - Changes the letter case.",
            "",
            "Substring() - Extracts part of a string.",
            "",
            "IndexOf() - Finds the position of a value; returns -1 if not found.",
            "",
            "Replace() - Replaces specified text.",
            "",
            "Trim() - Removes leading and trailing spaces.",
            "",
            "Split() - Divides a string into an array.",
            "",
            "Contains() - Checks if a string contains specified text.",
            "",
            "StartsWith() - Checks if a string begins with specified text."))

        Add(5, 3, "Character Methods", Para(
            "Char.IsLetter() - Checks if a character is a letter.",
            "",
            "Char.IsDigit() - Checks if a character is a digit.",
            "",
            "Char.IsUpper() - Checks if a character is uppercase.",
            "",
            "Char.IsWhiteSpace() - Checks if a character is whitespace.",
            "",
            "Char.IsPunctuation() - Checks if a character is punctuation.",
            "",
            "Char.ToUpper() - Converts a character to uppercase.",
            "",
            "Asc() / AscW() - Converts a character into its character code.",
            "",
            "Chr() / ChrW() - Converts a character code into a character."))

        Add(5, 4, "StringBuilder", Para(
            "StringBuilder is a mutable text buffer used for efficient repeated text modifications.",
            "",
            "Append() - Adds text at the end.",
            "",
            "Insert() - Inserts text at a specified position.",
            "",
            "Remove() - Deletes a range of characters.",
            "",
            "Replace() - Replaces specified text.",
            "",
            "ToString() - Converts the buffer into a regular string."))

    End Sub
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim f As finals = Application.OpenForms.OfType(Of finals)().FirstOrDefault()
        If f Is Nothing Then f = New finals()

        f.Show()
        f.ShowMainScreen()
        Hide()
    End Sub

End Class