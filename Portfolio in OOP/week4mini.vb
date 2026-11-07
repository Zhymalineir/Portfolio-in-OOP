Public Class week4mini


    Public LessonNumber As Integer

    Private Sub week4mini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLesson()
    End Sub

    Private Sub SetLesson()

        form.Visible = False

        lbl2.Visible = False
        TextBox.Visible = False

        lbl3.Visible = False
        border.Visible = False
        Label.Visible = False

        lbl4.Visible = False
        Button.Visible = False

        lbl5.Visible = False
        ListBox.Visible = False

        lbl6.Visible = False
        ComboBox.Visible = False

        lbl7.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False

        lbl8.Visible = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False

        lbl9.Visible = False
        PictureBox1.Visible = False

        lbl10.Visible = False
        ProgressBar1.Visible = False

        lbl11.Visible = False
        VScrollBar1.Visible = False
        HScrollBar1.Visible = False

        lbl12.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False

        PictureBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False


        Select Case LessonNumber

            Case 1

                form.Visible = True
                lbl2.Visible = True
                TextBox.Visible = True

                lbl3.Visible = True
                border.Visible = True
                label.Visible = True

                lbl4.Visible = True
                Button.Visible = True

                lbl5.Visible = True
                ListBox.Visible = True

                lbl6.Visible = True
                ComboBox.Visible = True

                lbl7.Visible = True
                RadioButton1.Visible = True
                RadioButton2.Visible = True
                RadioButton3.Visible = True

                lbl8.Visible = True
                CheckBox1.Visible = True
                CheckBox2.Visible = True
                CheckBox3.Visible = True

                lbl9.Visible = True
                PictureBox1.Visible = True

                lbl10.Visible = True
                ProgressBar1.Visible = True

                lbl11.Visible = True
                VScrollBar1.Visible = True
                HScrollBar1.Visible = True

                lbl12.Visible = True
                DateTimePicker1.Visible = True
                DateTimePicker2.Visible = True
                backbtn.Visible = False
                exitbtn.Visible = True

            Case 2
                PictureBox2.Visible = True
                Button1.Visible = True
                Button2.Visible = True
                backbtn.Visible = True
                exitbtn.Visible = False
        End Select

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
        Else
            ProgressBar1.Value = 0
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, MMMM dd, yyyy"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Dim week4Form As week4 = Application.OpenForms.OfType(Of week4)().FirstOrDefault()

        If week4Form Is Nothing Then
            week4Form = New week4()
        End If

        week4Form.Show()
        week4Form.BringToFront()
        Me.Close()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim week4Form As week4 = Application.OpenForms.OfType(Of week4)().FirstOrDefault()

        If week4Form Is Nothing Then
            week4Form = New week4()
        End If

        week4Form.Show()
        week4Form.BringToFront()
        Me.Close()
    End Sub
End Class