Imports System.Drawing
Imports System.Drawing.Text
Imports System.Reflection

Public Class Landing_Page

    Private privateFonts As New PrivateFontCollection()

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Private Sub EnableDoubleBuffer(ctrl As Control)
        GetType(Control).GetProperty("DoubleBuffered",
            BindingFlags.Instance Or BindingFlags.NonPublic).SetValue(ctrl, True, Nothing)
    End Sub

    ' Re-parents a control to bg and keeps it in the same visual spot
    Private Sub InheritBackground(ctrl As Control)
        Dim screenPos As Point = ctrl.PointToScreen(Point.Empty)
        ctrl.Parent = bg
        ctrl.Location = bg.PointToClient(screenPos)
        ctrl.BackColor = Color.Transparent
        EnableDoubleBuffer(ctrl)
    End Sub

    Private Sub Landing_Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.DoubleBuffered = True
        EnableDoubleBuffer(bg)

        For Each c As Control In {banner, watermark, midtermsbtn, finalsbtn, playerbtn}
            InheritBackground(c)
        Next

        banner.Top = 50

    End Sub

    Private Sub midtermsbtn_Click(sender As Object, e As EventArgs) Handles midtermsbtn.Click
        Dim lessonForm As New Lesson
        Hide()
        AddHandler lessonForm.FormClosed, Sub(s, ev) Show()
        lessonForm.Show()
    End Sub

    Private Sub Landing_Page_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        Dim playerForm As New Player
        Hide()
        AddHandler playerForm.FormClosed, Sub(s, ev) Show()
        playerForm.Show()
    End Sub

    Private Sub finalsbtn_Click(sender As Object, e As EventArgs) Handles finalsbtn.Click
        Dim finalsForm As New finals
        Hide()
        AddHandler finalsForm.FormClosed, Sub(s, ev) Show()
        finalsForm.Show()
    End Sub
End Class