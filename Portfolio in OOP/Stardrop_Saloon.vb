Public Class Stardrop_Saloon

    Private selectedTag As String = ""

    Private Sub Stardrop_Saloon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kiosk_Body.Visible = False
    End Sub
    Private Sub Kiosk_Starter_Click(sender As Object, e As EventArgs) Handles Kiosk_Starter.Click
        Kiosk_Body.Visible = True
        Menu.Visible = False
        Checkout_btn.Visible = False

        kiosk_label.Image = My.Resources.Resources.selectordertype
    End Sub
    Private Sub dine_in_Click(sender As Object, e As EventArgs) Handles dine_in.Click
        Menu.Visible = True
        Checkout_btn.Visible = True

        kiosk_label.Image = My.Resources.ssmenu
    End Sub
    Private Sub takeout_Click(sender As Object, e As EventArgs) Handles takeout.Click
        Menu.Visible = True
        Checkout_btn.Visible = True

        kiosk_label.Image = My.Resources.ssmenu
    End Sub

    Private Sub mains_Click(sender As Object, e As EventArgs) Handles mains.Click
        Menu.BackgroundImage = My.Resources.kiosk1

        Checkout_btn.Visible = True

        f1.Visible = "True"
        f1.Image = My.Resources.f20

        f2.Visible = "True"
        f2.Image = My.Resources.f8

        f3.Visible = "True"
        f3.Image = My.Resources.f19

        f4.Visible = "True"
        f4.Image = My.Resources.f14

        f5.Visible = "True"
        f5.Image = My.Resources.f13

        f6.Visible = "True"
        f6.Image = My.Resources.f1

        f7.Visible = "True"
        f7.Image = My.Resources.f7

        f8.Visible = "True"
        f8.Image = My.Resources.f2

    End Sub

    Private Sub snacks_Click(sender As Object, e As EventArgs) Handles snacks.Click
        Menu.BackgroundImage = My.Resources.kiosk2

        Checkout_btn.Visible = True

        f1.Visible = "True"
        f1.Image = My.Resources.f23

        f2.Visible = "True"
        f2.Image = My.Resources.f6

        f3.Visible = "True"
        f3.Image = My.Resources.f12

        f4.Visible = "True"
        f4.Image = My.Resources.f17

        f5.Visible = "false"
        f6.Visible = "false"
        f7.Visible = "false"
        f8.Visible = "false"
    End Sub

    Private Sub drinks_Click(sender As Object, e As EventArgs) Handles drinks.Click
        Menu.BackgroundImage = My.Resources.kiosk3

        Checkout_btn.Visible = True

        f1.Visible = "True"
        f1.Image = My.Resources.f16

        f2.Visible = "True"
        f2.Image = My.Resources.f11

        f3.Visible = "True"
        f3.Image = My.Resources.f5

        f4.Visible = "True"
        f4.Image = My.Resources.f24

        f5.Visible = "True"
        f5.Image = My.Resources.f22

        f6.Visible = "false"
        f7.Visible = "false"
        f8.Visible = "false"
    End Sub

    Private Sub dessert_Click(sender As Object, e As EventArgs) Handles dessert.Click
        Menu.BackgroundImage = My.Resources.kiosk3

        Checkout_btn.Visible = True

        f1.Visible = "True"
        f1.Image = My.Resources.f18

        f2.Visible = "True"
        f2.Image = My.Resources.f15

        f3.Visible = "True"
        f3.Image = My.Resources.f10

        f4.Visible = "True"
        f4.Image = My.Resources.f9

        f5.Visible = "True"
        f5.Image = My.Resources.f4

        f6.Visible = "True"
        f6.Image = My.Resources.f3

        f7.Visible = "True"
        f7.Image = My.Resources.f21

        f8.Visible = "false"
    End Sub
End Class
