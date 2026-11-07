Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class Lesson

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer,
                                          <MarshalAs(UnmanagedType.Bool)> bShow As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Const SB_BOTH As Integer = 3
    Private hidingScrollBars As Boolean = False

    Private Sub HidePanel1ScrollBars()
        If hidingScrollBars OrElse Not Panel1.IsHandleCreated Then Return
        hidingScrollBars = True
        ShowScrollBar(Panel1.Handle, SB_BOTH, False)
        hidingScrollBars = False
    End Sub

    Private Sub Panel1_ScrollBarEvents(sender As Object, e As EventArgs) Handles Panel1.Layout, Panel1.Resize, Panel1.HandleCreated
        HidePanel1ScrollBars()
    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        HidePanel1ScrollBars()
    End Sub

    Private Sub FocusPanel1(sender As Object, e As EventArgs)
        If Not Panel1.Focused Then Panel1.Focus()
    End Sub

    Private Sub HookWheelFocus(root As Control)
        AddHandler root.MouseEnter, AddressOf FocusPanel1
        For Each child As Control In root.Controls
            HookWheelFocus(child)
        Next
    End Sub

    Private Sub Lesson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loc_backbtn As Point = backbtn.Parent.PointToScreen(backbtn.Location)


        Dim loc_Label14 As Point = Label14.Parent.PointToScreen(Label14.Location)
        Label14.Parent = PictureBox19
        Label14.Location = PictureBox19.PointToClient(loc_Label14)

        ' Group 2
        Dim loc_wk2 As Point = wk2.Parent.PointToScreen(wk2.Location)
        wk2.Parent = btn2
        wk2.Location = btn2.PointToClient(loc_wk2)

        Dim loc_c2 As Point = c2.Parent.PointToScreen(c2.Location)
        c2.Parent = btn2
        c2.Location = btn2.PointToClient(loc_c2)

        Dim loc_con2 As Point = con2.Parent.PointToScreen(con2.Location)
        con2.Parent = btn2
        con2.Location = btn2.PointToClient(loc_con2)

        Dim loc_trash2 As Point = trash2.Parent.PointToScreen(trash2.Location)
        trash2.Parent = btn2
        trash2.Location = btn2.PointToClient(loc_trash2)

        ' Group 3
        Dim loc_wk3 As Point = wk3.Parent.PointToScreen(wk3.Location)
        wk3.Parent = btn3
        wk3.Location = btn3.PointToClient(loc_wk3)

        Dim loc_c3 As Point = c3.Parent.PointToScreen(c3.Location)
        c3.Parent = btn3
        c3.Location = btn3.PointToClient(loc_c3)

        Dim loc_con3 As Point = con3.Parent.PointToScreen(con3.Location)
        con3.Parent = btn3
        con3.Location = btn3.PointToClient(loc_con3)

        Dim loc_trash3 As Point = trash3.Parent.PointToScreen(trash3.Location)
        trash3.Parent = btn3
        trash3.Location = btn3.PointToClient(loc_trash3)

        ' Group 4
        Dim loc_wk4 As Point = wk4.Parent.PointToScreen(wk4.Location)
        wk4.Parent = btn4
        wk4.Location = btn4.PointToClient(loc_wk4)

        Dim loc_c4 As Point = c4.Parent.PointToScreen(c4.Location)
        c4.Parent = btn4
        c4.Location = btn4.PointToClient(loc_c4)

        Dim loc_con4 As Point = con4.Parent.PointToScreen(con4.Location)
        con4.Parent = btn4
        con4.Location = btn4.PointToClient(loc_con4)

        Dim loc_trash4 As Point = trash4.Parent.PointToScreen(trash4.Location)
        trash4.Parent = btn4
        trash4.Location = btn4.PointToClient(loc_trash4)

        ' Group 5
        Dim loc_wk5 As Point = wk5.Parent.PointToScreen(wk5.Location)
        wk5.Parent = btn5
        wk5.Location = btn5.PointToClient(loc_wk5)

        Dim loc_c5 As Point = c5.Parent.PointToScreen(c5.Location)
        c5.Parent = btn5
        c5.Location = btn5.PointToClient(loc_c5)

        Dim loc_con5 As Point = con5.Parent.PointToScreen(con5.Location)
        con5.Parent = btn5
        con5.Location = btn5.PointToClient(loc_con5)

        Dim loc_trash5 As Point = trash5.Parent.PointToScreen(trash5.Location)
        trash5.Parent = btn5
        trash5.Location = btn5.PointToClient(loc_trash5)

        ' Group 6
        Dim loc_wk6 As Point = wk6.Parent.PointToScreen(wk6.Location)
        wk6.Parent = btn6
        wk6.Location = btn6.PointToClient(loc_wk6)

        Dim loc_c6 As Point = c6.Parent.PointToScreen(c6.Location)
        c6.Parent = btn6
        c6.Location = btn6.PointToClient(loc_c6)

        Dim loc_con6 As Point = con6.Parent.PointToScreen(con6.Location)
        con6.Parent = btn6
        con6.Location = btn6.PointToClient(loc_con6)

        Dim loc_trash6 As Point = trash6.Parent.PointToScreen(trash6.Location)
        trash6.Parent = btn6
        trash6.Location = btn6.PointToClient(loc_trash6)

        ' Group 7
        Dim loc_wk7 As Point = wk7.Parent.PointToScreen(wk7.Location)
        wk7.Parent = btn7
        wk7.Location = btn7.PointToClient(loc_wk7)

        Dim loc_c7 As Point = c7.Parent.PointToScreen(c7.Location)
        c7.Parent = btn7
        c7.Location = btn7.PointToClient(loc_c7)

        Dim loc_con7 As Point = con7.Parent.PointToScreen(con7.Location)
        con7.Parent = btn7
        con7.Location = btn7.PointToClient(loc_con7)

        Dim loc_trash7 As Point = trash7.Parent.PointToScreen(trash7.Location)
        trash7.Parent = btn7
        trash7.Location = btn7.PointToClient(loc_trash7)

        ' Group 8
        Dim loc_wk8 As Point = wk8.Parent.PointToScreen(wk8.Location)
        wk8.Parent = btn8
        wk8.Location = btn8.PointToClient(loc_wk8)

        Dim loc_c8 As Point = c8.Parent.PointToScreen(c8.Location)
        c8.Parent = btn8
        c8.Location = btn8.PointToClient(loc_c8)

        Dim loc_con8 As Point = con8.Parent.PointToScreen(con8.Location)
        con8.Parent = btn8
        con8.Location = btn8.PointToClient(loc_con8)

        Dim loc_trash8 As Point = trash8.Parent.PointToScreen(trash8.Location)
        trash8.Parent = btn8
        trash8.Location = btn8.PointToClient(loc_trash8)

        ' Group 9
        Dim loc_wk9 As Point = wk9.Parent.PointToScreen(wk9.Location)
        wk9.Parent = btn9
        wk9.Location = btn9.PointToClient(loc_wk9)

        Dim loc_c9 As Point = c9.Parent.PointToScreen(c9.Location)
        c9.Parent = btn9
        c9.Location = btn9.PointToClient(loc_c9)

        Dim loc_con9 As Point = con9.Parent.PointToScreen(con9.Location)
        con9.Parent = btn9
        con9.Location = btn9.PointToClient(loc_con9)

        Dim loc_trash9 As Point = trash9.Parent.PointToScreen(trash9.Location)
        trash9.Parent = btn9
        trash9.Location = btn9.PointToClient(loc_trash9)

        HookWheelFocus(Panel1)
        HidePanel1ScrollBars()


    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click, wk2.Click, c2.Click, con2.Click
        Dim week2 As New week2()
        Me.Hide()
        AddHandler week2.FormClosed, Sub(s, ev) Me.Show()
        week2.Show()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click, wk3.Click, c3.Click, con3.Click
        Dim week3 As New week3()
        Me.Hide()
        AddHandler week3.FormClosed, Sub(s, ev) Me.Show()
        week3.Show()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click, wk4.Click, c4.Click, con4.Click
        Dim week4 As New week4()
        Me.Hide()
        AddHandler week4.FormClosed, Sub(s, ev) Me.Show()
        week4.Show()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click, wk5.Click, c5.Click, con5.Click
        Dim week5 As New week5()
        Me.Hide()
        AddHandler week5.FormClosed, Sub(s, ev) Me.Show()
        week5.Show()
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click, wk6.Click, c6.Click, con6.Click
        Dim week6 As New week6
        Hide()
        AddHandler week6.FormClosed, Sub(s, ev) Show()
        week6.Show()
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click, wk7.Click, c7.Click, con7.Click
        Dim week7 As New week7
        Hide()
        AddHandler week7.FormClosed, Sub(s, ev) Show()
        week7.Show()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click, wk8.Click, c8.Click, con8.Click
        Dim week8 As New week8
        Hide()
        AddHandler week8.FormClosed, Sub(s, ev) Show()
        week8.Show()
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Dim week9 As New Week_9
        Hide()
        AddHandler week9.FormClosed, Sub(s, ev) Show()
        week9.Show()
    End Sub

    Private Landing_PageHandlerAttached As Boolean = False

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim Landing_Page As Landing_Page = Application.OpenForms.OfType(Of Landing_Page)().FirstOrDefault()
        If Landing_Page Is Nothing Then
            Landing_Page = New Landing_Page()
            Landing_PageHandlerAttached = False
        End If
        If Not Landing_PageHandlerAttached Then
            AddHandler Landing_Page.FormClosed, Sub(s, ev) Me.Show()
            Landing_PageHandlerAttached = True
        End If
        Me.Hide()
        Landing_Page.Show()
    End Sub

    Private Sub Lesson_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub Lesson_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class