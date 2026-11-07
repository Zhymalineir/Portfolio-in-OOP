Imports System.Runtime.InteropServices

Public Class finals

    Private Landing_PageHandlerAttached As Boolean = False

    <DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(hWnd As IntPtr, wBar As Integer, bShow As Boolean) As Boolean
    End Function

    Private Sub FitChild(child As Form)
        Dim mdi As MdiClient = Me.Controls.OfType(Of MdiClient)().FirstOrDefault()
        If mdi Is Nothing Then Return

        child.Bounds = New Rectangle(0, 0, mdi.ClientSize.Width, mdi.ClientSize.Height)
        ShowScrollBar(mdi.Handle, 3, False)
    End Sub

    Private Sub Finals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True

        ReparentKeepPosition(woodboard, bg)
        ReparentKeepPosition(banner, bg)
        ReparentKeepPosition(backbtn, bg)

        ReparentKeepPosition(wk10, woodboard)
        ReparentKeepPosition(wk11, woodboard)
        ReparentKeepPosition(arrow1, woodboard)
        ReparentKeepPosition(arrow2, woodboard)
        ReparentKeepPosition(arrow3, woodboard)

        wk10.Visible = True
        wk11.Visible = True
        arrow1.Visible = True
        arrow2.Visible = False
        arrow3.Visible = False
    End Sub

    Private Sub ReparentKeepPosition(ctrl As Control, newParent As Control)
        Dim screenPos As Point = ctrl.Parent.PointToScreen(ctrl.Location)
        ctrl.Parent = newParent
        ctrl.Location = newParent.PointToClient(screenPos)
        ctrl.BackColor = Color.Transparent
        ctrl.BringToFront()
    End Sub

    Private Sub arrow1_Click(sender As Object, e As EventArgs) Handles arrow1.Click
        wk10.Visible = False
        wk11.Visible = False
        arrow1.Visible = False
        arrow2.Visible = True
        arrow3.Visible = True
    End Sub

    Private Sub arrow2_Click(sender As Object, e As EventArgs) Handles arrow2.Click
        wk10.Visible = True
        wk11.Visible = True
        arrow1.Visible = True
        arrow2.Visible = False
        arrow3.Visible = False
    End Sub

    Public Sub ShowMainScreen()
        bg.Visible = True
        bg.BringToFront()
    End Sub

    Private Sub OpenWeek(child As Form)
        child.MdiParent = Me
        child.FormBorderStyle = FormBorderStyle.None
        child.StartPosition = FormStartPosition.Manual
        AddHandler child.FormClosed, Sub(s, ev) ShowMainScreen()
        AddHandler child.Shown, Sub(s, ev) FitChild(child)

        bg.Visible = False
        child.Show()
        child.WindowState = FormWindowState.Normal
        FitChild(child)
    End Sub

    Private Sub wk10_Click(sender As Object, e As EventArgs) Handles wk10.Click
        OpenWeek(New week10())
    End Sub

    Private Sub wk11_Click(sender As Object, e As EventArgs) Handles wk11.Click
        OpenWeek(New week11())
    End Sub

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

    Private Sub finals_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

End Class