<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week11))
        bg = New PictureBox()
        Shop_Vendor = New PictureBox()
        Shop_Panel = New Panel()
        sample_MDI = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        b4 = New PictureBox()
        b3 = New PictureBox()
        b2 = New PictureBox()
        b1 = New PictureBox()
        RTB2 = New RichTextBox()
        RTB1 = New RichTextBox()
        btn1 = New PictureBox()
        btn3 = New PictureBox()
        btn2 = New PictureBox()
        btn5 = New PictureBox()
        btn4 = New PictureBox()
        box = New PictureBox()
        Vendor_Gif = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        backbtn = New PictureBox()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(Shop_Vendor, ComponentModel.ISupportInitialize).BeginInit()
        Shop_Panel.SuspendLayout()
        sample_MDI.SuspendLayout()
        Panel2.SuspendLayout()
        CType(b4, ComponentModel.ISupportInitialize).BeginInit()
        CType(b3, ComponentModel.ISupportInitialize).BeginInit()
        CType(b2, ComponentModel.ISupportInitialize).BeginInit()
        CType(b1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn3, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn5, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn4, ComponentModel.ISupportInitialize).BeginInit()
        CType(box, ComponentModel.ISupportInitialize).BeginInit()
        CType(Vendor_Gif, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.Dock = DockStyle.Fill
        bg.Image = My.Resources.Resources.wk11bg
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1184, 611)
        bg.SizeMode = PictureBoxSizeMode.StretchImage
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' Shop_Vendor
        ' 
        Shop_Vendor.BackColor = Color.Transparent
        Shop_Vendor.Cursor = Cursors.Hand
        Shop_Vendor.Location = New Point(456, 359)
        Shop_Vendor.Name = "Shop_Vendor"
        Shop_Vendor.Size = New Size(68, 68)
        Shop_Vendor.TabIndex = 1
        Shop_Vendor.TabStop = False
        ' 
        ' Shop_Panel
        ' 
        Shop_Panel.BackColor = Color.Transparent
        Shop_Panel.BackgroundImage = My.Resources.Resources.wk11con
        Shop_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Shop_Panel.Controls.Add(sample_MDI)
        Shop_Panel.Controls.Add(b4)
        Shop_Panel.Controls.Add(b3)
        Shop_Panel.Controls.Add(b2)
        Shop_Panel.Controls.Add(b1)
        Shop_Panel.Controls.Add(RTB2)
        Shop_Panel.Controls.Add(RTB1)
        Shop_Panel.Controls.Add(btn1)
        Shop_Panel.Controls.Add(btn3)
        Shop_Panel.Controls.Add(btn2)
        Shop_Panel.Controls.Add(btn5)
        Shop_Panel.Controls.Add(btn4)
        Shop_Panel.Controls.Add(box)
        Shop_Panel.Location = New Point(142, 23)
        Shop_Panel.Name = "Shop_Panel"
        Shop_Panel.Size = New Size(919, 561)
        Shop_Panel.TabIndex = 7
        ' 
        ' sample_MDI
        ' 
        sample_MDI.BackColor = Color.Coral
        sample_MDI.Controls.Add(Panel2)
        sample_MDI.Controls.Add(Label1)
        sample_MDI.Location = New Point(334, 232)
        sample_MDI.Name = "sample_MDI"
        sample_MDI.Size = New Size(482, 240)
        sample_MDI.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSalmon
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(129, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(218, 107)
        Panel2.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("rainyhearts", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Brown
        Label2.Location = New Point(28, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 30)
        Label2.TabIndex = 0
        Label2.Text = "Child Form"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("rainyhearts", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(111, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 45)
        Label1.TabIndex = 0
        Label1.Text = "Parent Form"
        ' 
        ' b4
        ' 
        b4.Image = My.Resources.Resources.b15
        b4.Location = New Point(236, 425)
        b4.Name = "b4"
        b4.Size = New Size(55, 64)
        b4.SizeMode = PictureBoxSizeMode.StretchImage
        b4.TabIndex = 19
        b4.TabStop = False
        ' 
        ' b3
        ' 
        b3.Image = My.Resources.Resources.b18
        b3.Location = New Point(236, 355)
        b3.Name = "b3"
        b3.Size = New Size(55, 64)
        b3.SizeMode = PictureBoxSizeMode.StretchImage
        b3.TabIndex = 18
        b3.TabStop = False
        ' 
        ' b2
        ' 
        b2.Image = My.Resources.Resources.b19
        b2.Location = New Point(236, 285)
        b2.Name = "b2"
        b2.Size = New Size(55, 64)
        b2.SizeMode = PictureBoxSizeMode.StretchImage
        b2.TabIndex = 17
        b2.TabStop = False
        ' 
        ' b1
        ' 
        b1.Image = My.Resources.Resources.b12
        b1.Location = New Point(236, 215)
        b1.Name = "b1"
        b1.Size = New Size(55, 64)
        b1.SizeMode = PictureBoxSizeMode.StretchImage
        b1.TabIndex = 16
        b1.TabStop = False
        ' 
        ' RTB2
        ' 
        RTB2.BackColor = Color.White
        RTB2.BorderStyle = BorderStyle.None
        RTB2.Font = New Font("rainyhearts", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB2.ForeColor = Color.Maroon
        RTB2.Location = New Point(230, 143)
        RTB2.Name = "RTB2"
        RTB2.ReadOnly = True
        RTB2.ScrollBars = RichTextBoxScrollBars.None
        RTB2.Size = New Size(608, 46)
        RTB2.TabIndex = 15
        RTB2.Text = ""
        ' 
        ' RTB1
        ' 
        RTB1.BorderStyle = BorderStyle.None
        RTB1.Font = New Font("rainyhearts", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB1.ForeColor = Color.Maroon
        RTB1.Location = New Point(303, 208)
        RTB1.Name = "RTB1"
        RTB1.ReadOnly = True
        RTB1.ScrollBars = RichTextBoxScrollBars.Vertical
        RTB1.Size = New Size(538, 287)
        RTB1.TabIndex = 14
        RTB1.Text = ""
        ' 
        ' btn1
        ' 
        btn1.Image = My.Resources.Resources.btn1
        btn1.Location = New Point(53, 186)
        btn1.Name = "btn1"
        btn1.Size = New Size(145, 40)
        btn1.SizeMode = PictureBoxSizeMode.StretchImage
        btn1.TabIndex = 13
        btn1.TabStop = False
        ' 
        ' btn3
        ' 
        btn3.Image = My.Resources.Resources.btn3
        btn3.Location = New Point(53, 291)
        btn3.Name = "btn3"
        btn3.Size = New Size(145, 40)
        btn3.SizeMode = PictureBoxSizeMode.StretchImage
        btn3.TabIndex = 11
        btn3.TabStop = False
        ' 
        ' btn2
        ' 
        btn2.Image = My.Resources.Resources.btn2
        btn2.Location = New Point(53, 238)
        btn2.Name = "btn2"
        btn2.Size = New Size(145, 40)
        btn2.SizeMode = PictureBoxSizeMode.StretchImage
        btn2.TabIndex = 10
        btn2.TabStop = False
        ' 
        ' btn5
        ' 
        btn5.Image = My.Resources.Resources.btn5
        btn5.Location = New Point(53, 393)
        btn5.Name = "btn5"
        btn5.Size = New Size(145, 40)
        btn5.SizeMode = PictureBoxSizeMode.StretchImage
        btn5.TabIndex = 9
        btn5.TabStop = False
        ' 
        ' btn4
        ' 
        btn4.Image = My.Resources.Resources.btn4
        btn4.Location = New Point(53, 340)
        btn4.Name = "btn4"
        btn4.Size = New Size(145, 40)
        btn4.SizeMode = PictureBoxSizeMode.StretchImage
        btn4.TabIndex = 8
        btn4.TabStop = False
        ' 
        ' box
        ' 
        box.Image = My.Resources.Resources.menu1
        box.Location = New Point(209, 119)
        box.Name = "box"
        box.Size = New Size(655, 395)
        box.SizeMode = PictureBoxSizeMode.StretchImage
        box.TabIndex = 0
        box.TabStop = False
        ' 
        ' Vendor_Gif
        ' 
        Vendor_Gif.BackColor = Color.Transparent
        Vendor_Gif.Image = My.Resources.Resources.wk11_animation
        Vendor_Gif.Location = New Point(-28, 2)
        Vendor_Gif.Name = "Vendor_Gif"
        Vendor_Gif.Size = New Size(1233, 606)
        Vendor_Gif.SizeMode = PictureBoxSizeMode.StretchImage
        Vendor_Gif.TabIndex = 6
        Vendor_Gif.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Location = New Point(80, 39)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(37, 40)
        backbtn.TabIndex = 39
        backbtn.TabStop = False
        ' 
        ' week11
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 611)
        Controls.Add(backbtn)
        Controls.Add(Shop_Panel)
        Controls.Add(Vendor_Gif)
        Controls.Add(Shop_Vendor)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "week11"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week 11: Working with .NET Framework and Multi Document Interface"
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(Shop_Vendor, ComponentModel.ISupportInitialize).EndInit()
        Shop_Panel.ResumeLayout(False)
        sample_MDI.ResumeLayout(False)
        sample_MDI.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(b4, ComponentModel.ISupportInitialize).EndInit()
        CType(b3, ComponentModel.ISupportInitialize).EndInit()
        CType(b2, ComponentModel.ISupportInitialize).EndInit()
        CType(b1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn3, ComponentModel.ISupportInitialize).EndInit()
        CType(btn2, ComponentModel.ISupportInitialize).EndInit()
        CType(btn5, ComponentModel.ISupportInitialize).EndInit()
        CType(btn4, ComponentModel.ISupportInitialize).EndInit()
        CType(box, ComponentModel.ISupportInitialize).EndInit()
        CType(Vendor_Gif, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents Shop_Vendor As PictureBox
    Friend WithEvents Shop_Panel As Panel
    Friend WithEvents Vendor_Gif As PictureBox
    Friend WithEvents box As PictureBox
    Friend WithEvents btn1 As PictureBox
    Friend WithEvents btn3 As PictureBox
    Friend WithEvents btn2 As PictureBox
    Friend WithEvents btn5 As PictureBox
    Friend WithEvents btn4 As PictureBox
    Friend WithEvents RTB1 As RichTextBox
    Friend WithEvents RTB2 As RichTextBox
    Friend WithEvents b1 As PictureBox
    Friend WithEvents b4 As PictureBox
    Friend WithEvents b3 As PictureBox
    Friend WithEvents b2 As PictureBox
    Friend WithEvents sample_MDI As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents backbtn As PictureBox
End Class
