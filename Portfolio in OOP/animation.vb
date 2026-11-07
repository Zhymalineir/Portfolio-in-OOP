Public Class animation
    Private Sub gamemenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gamemenu_bg.Dock = DockStyle.Fill

        gamemenu_holder.Parent = gamemenu_bg
        backbtn.Parent = gamemenu_bg
    End Sub

    Private Sub btn_level1_Click(sender As Object, e As EventArgs) Handles btn_level1.Click
        level1.Show()
    End Sub
    Private Sub btn_level2_Click(sender As Object, e As EventArgs) Handles btn_level2.Click
        level2.Show()
    End Sub
    Private Sub btn_level3_Click(sender As Object, e As EventArgs) Handles btn_level3.Click
        level3.Show()
    End Sub

    Private Sub btn_level1_MouseEnter(sender As Object, e As EventArgs) Handles btn_level1.MouseEnter
        btn_level1.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_hover.png")
    End Sub
    Private Sub btn_level1_MouseLeave(sender As Object, e As EventArgs) Handles btn_level1.MouseLeave
        btn_level1.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_normal.png")
    End Sub
    Private Sub btn_level2_MouseEnter(sender As Object, e As EventArgs) Handles btn_level2.MouseEnter
        btn_level2.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_hover.png")
    End Sub
    Private Sub btn_level2_MouseLeave(sender As Object, e As EventArgs) Handles btn_level2.MouseLeave
        btn_level2.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_normal.png")
    End Sub
    Private Sub btn_level3_MouseEnter(sender As Object, e As EventArgs) Handles btn_level3.MouseEnter
        btn_level3.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_hover.png")
    End Sub
    Private Sub btn_level3_MouseLeave(sender As Object, e As EventArgs) Handles btn_level3.MouseLeave
        btn_level3.BackgroundImage = Image.FromFile("Assets\gamemenu_btn_normal.png")
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

    Private Sub gamemenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub gamemenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class