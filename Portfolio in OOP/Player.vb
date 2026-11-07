Public Class Player
    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim screenLocation1 As Point = PictureBox2.Parent.PointToScreen(PictureBox2.Location)
        PictureBox2.Parent = PictureBox1
        PictureBox2.Location = PictureBox1.PointToClient(screenLocation1)

        Dim screenLocation2 As Point = backbtn.Parent.PointToScreen(backbtn.Location)
        backbtn.Parent = PictureBox1
        backbtn.Location = PictureBox1.PointToClient(screenLocation2)

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

    Private Sub week5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If e.CloseReason = CloseReason.UserClosing Then Application.Exit()
    End Sub

    Private Sub week5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

   
End Class