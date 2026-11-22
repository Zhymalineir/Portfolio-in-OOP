<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stardrop_Saloon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        backbtn = New PictureBox()
        Kiosk_Starter = New PictureBox()
        Kiosk_Body = New Panel()
        Checkout_btn = New PictureBox()
        Menu = New Panel()
        f8 = New PictureBox()
        f4 = New PictureBox()
        f7 = New PictureBox()
        f3 = New PictureBox()
        f6 = New PictureBox()
        f2 = New PictureBox()
        f5 = New PictureBox()
        f1 = New PictureBox()
        dessert = New PictureBox()
        drinks = New PictureBox()
        snacks = New PictureBox()
        mains = New PictureBox()
        takeout = New PictureBox()
        dine_in = New PictureBox()
        kiosk_label = New PictureBox()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(Kiosk_Starter, ComponentModel.ISupportInitialize).BeginInit()
        Kiosk_Body.SuspendLayout()
        CType(Checkout_btn, ComponentModel.ISupportInitialize).BeginInit()
        Menu.SuspendLayout()
        CType(f8, ComponentModel.ISupportInitialize).BeginInit()
        CType(f4, ComponentModel.ISupportInitialize).BeginInit()
        CType(f7, ComponentModel.ISupportInitialize).BeginInit()
        CType(f3, ComponentModel.ISupportInitialize).BeginInit()
        CType(f6, ComponentModel.ISupportInitialize).BeginInit()
        CType(f2, ComponentModel.ISupportInitialize).BeginInit()
        CType(f5, ComponentModel.ISupportInitialize).BeginInit()
        CType(f1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dessert, ComponentModel.ISupportInitialize).BeginInit()
        CType(drinks, ComponentModel.ISupportInitialize).BeginInit()
        CType(snacks, ComponentModel.ISupportInitialize).BeginInit()
        CType(mains, ComponentModel.ISupportInitialize).BeginInit()
        CType(takeout, ComponentModel.ISupportInitialize).BeginInit()
        CType(dine_in, ComponentModel.ISupportInitialize).BeginInit()
        CType(kiosk_label, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(24, 25)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(55, 53)
        backbtn.TabIndex = 39
        backbtn.TabStop = False
        ' 
        ' Kiosk_Starter
        ' 
        Kiosk_Starter.BackColor = Color.Transparent
        Kiosk_Starter.Cursor = Cursors.Hand
        Kiosk_Starter.Image = My.Resources.Resources.Stardust_Saloon_Pixel_Sign
        Kiosk_Starter.Location = New Point(241, 49)
        Kiosk_Starter.Name = "Kiosk_Starter"
        Kiosk_Starter.Size = New Size(688, 258)
        Kiosk_Starter.SizeMode = PictureBoxSizeMode.StretchImage
        Kiosk_Starter.TabIndex = 41
        Kiosk_Starter.TabStop = False
        ' 
        ' Kiosk_Body
        ' 
        Kiosk_Body.BackColor = Color.Transparent
        Kiosk_Body.BackgroundImage = My.Resources.Resources.bulletin_board1
        Kiosk_Body.BackgroundImageLayout = ImageLayout.Stretch
        Kiosk_Body.Controls.Add(Checkout_btn)
        Kiosk_Body.Controls.Add(Menu)
        Kiosk_Body.Controls.Add(takeout)
        Kiosk_Body.Controls.Add(dine_in)
        Kiosk_Body.Controls.Add(kiosk_label)
        Kiosk_Body.Location = New Point(165, 39)
        Kiosk_Body.Name = "Kiosk_Body"
        Kiosk_Body.Size = New Size(854, 532)
        Kiosk_Body.TabIndex = 43
        ' 
        ' Checkout_btn
        ' 
        Checkout_btn.Image = My.Resources.Resources.proceed_to_checkout_btn
        Checkout_btn.Location = New Point(725, 473)
        Checkout_btn.Name = "Checkout_btn"
        Checkout_btn.Size = New Size(110, 56)
        Checkout_btn.SizeMode = PictureBoxSizeMode.StretchImage
        Checkout_btn.TabIndex = 12
        Checkout_btn.TabStop = False
        ' 
        ' Menu
        ' 
        Menu.BackgroundImage = My.Resources.Resources.kiosk1
        Menu.BackgroundImageLayout = ImageLayout.Stretch
        Menu.Controls.Add(f8)
        Menu.Controls.Add(f4)
        Menu.Controls.Add(f7)
        Menu.Controls.Add(f3)
        Menu.Controls.Add(f6)
        Menu.Controls.Add(f2)
        Menu.Controls.Add(f5)
        Menu.Controls.Add(f1)
        Menu.Controls.Add(dessert)
        Menu.Controls.Add(drinks)
        Menu.Controls.Add(snacks)
        Menu.Controls.Add(mains)
        Menu.Location = New Point(70, 98)
        Menu.Name = "Menu"
        Menu.Size = New Size(708, 372)
        Menu.TabIndex = 46
        ' 
        ' f8
        ' 
        f8.Image = My.Resources.Resources.f2
        f8.Location = New Point(525, 216)
        f8.Name = "f8"
        f8.Size = New Size(163, 131)
        f8.SizeMode = PictureBoxSizeMode.StretchImage
        f8.TabIndex = 11
        f8.TabStop = False
        ' 
        ' f4
        ' 
        f4.Image = My.Resources.Resources.f14
        f4.Location = New Point(525, 74)
        f4.Name = "f4"
        f4.Size = New Size(163, 131)
        f4.SizeMode = PictureBoxSizeMode.StretchImage
        f4.TabIndex = 10
        f4.TabStop = False
        ' 
        ' f7
        ' 
        f7.Image = My.Resources.Resources.f7
        f7.Location = New Point(356, 216)
        f7.Name = "f7"
        f7.Size = New Size(163, 131)
        f7.SizeMode = PictureBoxSizeMode.StretchImage
        f7.TabIndex = 9
        f7.TabStop = False
        ' 
        ' f3
        ' 
        f3.Image = My.Resources.Resources.f19
        f3.Location = New Point(356, 74)
        f3.Name = "f3"
        f3.Size = New Size(163, 131)
        f3.SizeMode = PictureBoxSizeMode.StretchImage
        f3.TabIndex = 8
        f3.TabStop = False
        ' 
        ' f6
        ' 
        f6.Image = My.Resources.Resources.f1
        f6.Location = New Point(187, 216)
        f6.Name = "f6"
        f6.Size = New Size(163, 131)
        f6.SizeMode = PictureBoxSizeMode.StretchImage
        f6.TabIndex = 7
        f6.TabStop = False
        ' 
        ' f2
        ' 
        f2.Image = My.Resources.Resources.f8
        f2.Location = New Point(187, 74)
        f2.Name = "f2"
        f2.Size = New Size(163, 131)
        f2.SizeMode = PictureBoxSizeMode.StretchImage
        f2.TabIndex = 6
        f2.TabStop = False
        ' 
        ' f5
        ' 
        f5.Image = My.Resources.Resources.f13
        f5.Location = New Point(18, 216)
        f5.Name = "f5"
        f5.Size = New Size(163, 131)
        f5.SizeMode = PictureBoxSizeMode.StretchImage
        f5.TabIndex = 5
        f5.TabStop = False
        ' 
        ' f1
        ' 
        f1.Image = My.Resources.Resources.f20
        f1.Location = New Point(18, 74)
        f1.Name = "f1"
        f1.Size = New Size(163, 131)
        f1.SizeMode = PictureBoxSizeMode.StretchImage
        f1.TabIndex = 4
        f1.TabStop = False
        ' 
        ' dessert
        ' 
        dessert.Image = My.Resources.Resources.transparent
        dessert.Location = New Point(545, 6)
        dessert.Name = "dessert"
        dessert.Size = New Size(152, 30)
        dessert.TabIndex = 3
        dessert.TabStop = False
        ' 
        ' drinks
        ' 
        drinks.Image = My.Resources.Resources.transparent
        drinks.Location = New Point(366, 7)
        drinks.Name = "drinks"
        drinks.Size = New Size(152, 30)
        drinks.TabIndex = 2
        drinks.TabStop = False
        ' 
        ' snacks
        ' 
        snacks.Image = My.Resources.Resources.transparent
        snacks.Location = New Point(190, 7)
        snacks.Name = "snacks"
        snacks.Size = New Size(152, 30)
        snacks.TabIndex = 1
        snacks.TabStop = False
        ' 
        ' mains
        ' 
        mains.Image = My.Resources.Resources.transparent
        mains.Location = New Point(14, 7)
        mains.Name = "mains"
        mains.Size = New Size(152, 30)
        mains.TabIndex = 0
        mains.TabStop = False
        ' 
        ' takeout
        ' 
        takeout.BackColor = Color.Transparent
        takeout.Image = My.Resources.Resources.take_out
        takeout.Location = New Point(455, 176)
        takeout.Name = "takeout"
        takeout.Size = New Size(293, 226)
        takeout.SizeMode = PictureBoxSizeMode.StretchImage
        takeout.TabIndex = 45
        takeout.TabStop = False
        ' 
        ' dine_in
        ' 
        dine_in.BackColor = Color.Transparent
        dine_in.Image = My.Resources.Resources.dine_in
        dine_in.Location = New Point(98, 176)
        dine_in.Name = "dine_in"
        dine_in.Size = New Size(293, 226)
        dine_in.SizeMode = PictureBoxSizeMode.StretchImage
        dine_in.TabIndex = 44
        dine_in.TabStop = False
        ' 
        ' kiosk_label
        ' 
        kiosk_label.BackColor = Color.Transparent
        kiosk_label.Image = My.Resources.Resources.selectordertype
        kiosk_label.Location = New Point(154, 11)
        kiosk_label.Name = "kiosk_label"
        kiosk_label.Size = New Size(530, 67)
        kiosk_label.SizeMode = PictureBoxSizeMode.StretchImage
        kiosk_label.TabIndex = 43
        kiosk_label.TabStop = False
        ' 
        ' Stardrop_Saloon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.stardrop_saloon
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 611)
        Controls.Add(Kiosk_Body)
        Controls.Add(Kiosk_Starter)
        Controls.Add(backbtn)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Stardrop_Saloon"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Stardrop_Saloon"
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(Kiosk_Starter, ComponentModel.ISupportInitialize).EndInit()
        Kiosk_Body.ResumeLayout(False)
        CType(Checkout_btn, ComponentModel.ISupportInitialize).EndInit()
        Menu.ResumeLayout(False)
        CType(f8, ComponentModel.ISupportInitialize).EndInit()
        CType(f4, ComponentModel.ISupportInitialize).EndInit()
        CType(f7, ComponentModel.ISupportInitialize).EndInit()
        CType(f3, ComponentModel.ISupportInitialize).EndInit()
        CType(f6, ComponentModel.ISupportInitialize).EndInit()
        CType(f2, ComponentModel.ISupportInitialize).EndInit()
        CType(f5, ComponentModel.ISupportInitialize).EndInit()
        CType(f1, ComponentModel.ISupportInitialize).EndInit()
        CType(dessert, ComponentModel.ISupportInitialize).EndInit()
        CType(drinks, ComponentModel.ISupportInitialize).EndInit()
        CType(snacks, ComponentModel.ISupportInitialize).EndInit()
        CType(mains, ComponentModel.ISupportInitialize).EndInit()
        CType(takeout, ComponentModel.ISupportInitialize).EndInit()
        CType(dine_in, ComponentModel.ISupportInitialize).EndInit()
        CType(kiosk_label, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents Kiosk_Starter As PictureBox
    Friend WithEvents Kiosk_Body As Panel
    Friend WithEvents Checkout_btn As PictureBox
    Friend WithEvents Menu As Panel
    Friend WithEvents f8 As PictureBox
    Friend WithEvents f4 As PictureBox
    Friend WithEvents f7 As PictureBox
    Friend WithEvents f3 As PictureBox
    Friend WithEvents f6 As PictureBox
    Friend WithEvents f2 As PictureBox
    Friend WithEvents f5 As PictureBox
    Friend WithEvents f1 As PictureBox
    Friend WithEvents dessert As PictureBox
    Friend WithEvents drinks As PictureBox
    Friend WithEvents snacks As PictureBox
    Friend WithEvents mains As PictureBox
    Friend WithEvents takeout As PictureBox
    Friend WithEvents dine_in As PictureBox
    Friend WithEvents kiosk_label As PictureBox
End Class
