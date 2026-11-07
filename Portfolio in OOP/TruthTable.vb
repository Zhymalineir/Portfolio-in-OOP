Public Class TruthTable

    Private Sub ShowBinaryLayout()
        p1.Visible = True
        p2.Visible = True
        p3.Visible = True
        p4.Visible = True
        q1.Visible = True
        q2.Visible = True
        q3.Visible = True
        q4.Visible = True
        pq2.Visible = True
        pq4.Visible = True
    End Sub

    Private Sub ShowUnaryLayout()
        p1.Visible = True
        p2.Visible = False
        p3.Visible = True
        p4.Visible = False
        q1.Visible = False
        q2.Visible = False
        q3.Visible = False
        q4.Visible = False
        pq2.Visible = False
        pq4.Visible = False
    End Sub

    Private Sub SetResult(lbl As Label, value As Boolean)
        lbl.Text = value.ToString()
        lbl.ForeColor = If(value, Color.Gold, Color.Red)
    End Sub

    ' And
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowBinaryLayout()

        SetResult(pq1, True)
        SetResult(pq2, False)
        SetResult(pq3, False)
        SetResult(pq4, False)
    End Sub

    ' Or
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowBinaryLayout()

        SetResult(pq1, True)
        SetResult(pq2, True)
        SetResult(pq3, True)
        SetResult(pq4, False)
    End Sub

    ' Xor
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowBinaryLayout()

        SetResult(pq1, False)
        SetResult(pq2, True)
        SetResult(pq3, True)
        SetResult(pq4, False)
    End Sub

    ' Not
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowUnaryLayout()

        SetResult(pq1, False)
        SetResult(pq3, True)
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim week6Form As week6 = Application.OpenForms.OfType(Of week6)().FirstOrDefault()

        If week6Form Is Nothing Then
            week6Form = New week6()
        End If

        week6Form.Show()
        week6Form.BringToFront()
        Me.Close()
    End Sub

End Class