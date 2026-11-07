Public Class Week_9
    Private Sub Week_9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim loc_PictureBox2 As Point = PictureBox2.Parent.PointToScreen(PictureBox2.Location)
        PictureBox2.Parent = PictureBox1
        PictureBox2.Location = PictureBox1.PointToClient(loc_PictureBox2)

        Dim loc_PictureBox3 As Point = PictureBox3.Parent.PointToScreen(PictureBox3.Location)
        PictureBox3.Parent = PictureBox1
        PictureBox3.Location = PictureBox1.PointToClient(loc_PictureBox3)

        Dim loc_PictureBox4 As Point = PictureBox4.Parent.PointToScreen(PictureBox4.Location)
        PictureBox4.Parent = PictureBox1
        PictureBox4.Location = PictureBox1.PointToClient(loc_PictureBox4)

        Dim loc_PictureBox5 As Point = PictureBox5.Parent.PointToScreen(PictureBox5.Location)
        PictureBox5.Parent = PictureBox1
        PictureBox5.Location = PictureBox1.PointToClient(loc_PictureBox5)

        Dim loc_backbtn As Point = backbtn.Parent.PointToScreen(backbtn.Location)
        backbtn.Parent = PictureBox1
        backbtn.Location = PictureBox1.PointToClient(loc_backbtn)
    End Sub

    Private LessonHandlerAttached As Boolean = False

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim Lesson As Lesson = Application.OpenForms.OfType(Of Lesson)().FirstOrDefault()
        If Lesson Is Nothing Then
            Lesson = New Lesson()
            LessonHandlerAttached = False
        End If
        If Not LessonHandlerAttached Then
            AddHandler Lesson.FormClosed, Sub(s, ev) Me.Show()
            LessonHandlerAttached = True
        End If
        Me.Hide()
        Lesson.Show()
    End Sub

    Private Sub week9_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub week9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class