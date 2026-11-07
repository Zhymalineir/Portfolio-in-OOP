<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week8))
        bg = New PictureBox()
        Panel2 = New Panel()
        dialog_print = New PictureBox()
        dialog_savefile = New PictureBox()
        dialog_font = New PictureBox()
        dialog_openfile = New PictureBox()
        dialog_color = New PictureBox()
        PictureBox1 = New PictureBox()
        RTB2 = New TextBox()
        pb1 = New PictureBox()
        backbtn = New PictureBox()
        picAvatar = New PictureBox()
        clock = New PictureBox()
        weapon1 = New PictureBox()
        weapon3 = New PictureBox()
        weapon5 = New PictureBox()
        weapon6 = New PictureBox()
        weapon4 = New PictureBox()
        weapon2 = New PictureBox()
        lvlname = New PictureBox()
        uibar = New PictureBox()
        pb2 = New PictureBox()
        lbl1 = New Label()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dialog_print, ComponentModel.ISupportInitialize).BeginInit()
        CType(dialog_savefile, ComponentModel.ISupportInitialize).BeginInit()
        CType(dialog_font, ComponentModel.ISupportInitialize).BeginInit()
        CType(dialog_openfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(dialog_color, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(clock, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon1, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon3, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon5, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon6, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon4, ComponentModel.ISupportInitialize).BeginInit()
        CType(weapon2, ComponentModel.ISupportInitialize).BeginInit()
        CType(lvlname, ComponentModel.ISupportInitialize).BeginInit()
        CType(uibar, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.BackColor = Color.Transparent
        bg.Dock = DockStyle.Fill
        bg.Image = My.Resources.Resources.newbg
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1184, 611)
        bg.SizeMode = PictureBoxSizeMode.StretchImage
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.Violet
        Panel2.Controls.Add(dialog_print)
        Panel2.Controls.Add(dialog_savefile)
        Panel2.Controls.Add(dialog_font)
        Panel2.Controls.Add(dialog_openfile)
        Panel2.Controls.Add(dialog_color)
        Panel2.Location = New Point(543, 203)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(609, 351)
        Panel2.TabIndex = 13
        ' 
        ' dialog_print
        ' 
        dialog_print.BackColor = Color.Transparent
        dialog_print.Cursor = Cursors.Hand
        dialog_print.Image = My.Resources.Resources.item_5
        dialog_print.Location = New Point(18, 302)
        dialog_print.Name = "dialog_print"
        dialog_print.Size = New Size(268, 112)
        dialog_print.SizeMode = PictureBoxSizeMode.StretchImage
        dialog_print.TabIndex = 7
        dialog_print.TabStop = False
        ' 
        ' dialog_savefile
        ' 
        dialog_savefile.BackColor = Color.Transparent
        dialog_savefile.Cursor = Cursors.Hand
        dialog_savefile.Image = My.Resources.Resources.item_4
        dialog_savefile.Location = New Point(316, 160)
        dialog_savefile.Name = "dialog_savefile"
        dialog_savefile.Size = New Size(268, 112)
        dialog_savefile.SizeMode = PictureBoxSizeMode.StretchImage
        dialog_savefile.TabIndex = 6
        dialog_savefile.TabStop = False
        ' 
        ' dialog_font
        ' 
        dialog_font.BackColor = Color.Transparent
        dialog_font.Cursor = Cursors.Hand
        dialog_font.Image = My.Resources.Resources.item_3
        dialog_font.Location = New Point(18, 160)
        dialog_font.Name = "dialog_font"
        dialog_font.Size = New Size(268, 112)
        dialog_font.SizeMode = PictureBoxSizeMode.StretchImage
        dialog_font.TabIndex = 5
        dialog_font.TabStop = False
        ' 
        ' dialog_openfile
        ' 
        dialog_openfile.BackColor = Color.Transparent
        dialog_openfile.Cursor = Cursors.Hand
        dialog_openfile.Image = My.Resources.Resources.item_2
        dialog_openfile.Location = New Point(316, 19)
        dialog_openfile.Name = "dialog_openfile"
        dialog_openfile.Size = New Size(268, 112)
        dialog_openfile.SizeMode = PictureBoxSizeMode.StretchImage
        dialog_openfile.TabIndex = 4
        dialog_openfile.TabStop = False
        ' 
        ' dialog_color
        ' 
        dialog_color.BackColor = Color.Transparent
        dialog_color.BackgroundImageLayout = ImageLayout.Stretch
        dialog_color.Cursor = Cursors.Hand
        dialog_color.Image = My.Resources.Resources.item_11
        dialog_color.Location = New Point(18, 19)
        dialog_color.Name = "dialog_color"
        dialog_color.Size = New Size(268, 112)
        dialog_color.SizeMode = PictureBoxSizeMode.StretchImage
        dialog_color.TabIndex = 3
        dialog_color.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(513, 117)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(656, 461)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' RTB2
        ' 
        RTB2.BorderStyle = BorderStyle.None
        RTB2.Font = New Font("rainyhearts", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB2.ForeColor = Color.SteelBlue
        RTB2.Location = New Point(543, 224)
        RTB2.Multiline = True
        RTB2.Name = "RTB2"
        RTB2.ReadOnly = True
        RTB2.Size = New Size(601, 351)
        RTB2.TabIndex = 6
        ' 
        ' pb1
        ' 
        pb1.BackColor = Color.Transparent
        pb1.BackgroundImage = My.Resources.Resources.transparent
        pb1.Cursor = Cursors.Hand
        pb1.Location = New Point(523, 127)
        pb1.Name = "pb1"
        pb1.Size = New Size(89, 50)
        pb1.TabIndex = 7
        pb1.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(12, 37)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(45, 46)
        backbtn.TabIndex = 37
        backbtn.TabStop = False
        ' 
        ' picAvatar
        ' 
        picAvatar.BackColor = Color.Transparent
        picAvatar.BackgroundImageLayout = ImageLayout.Zoom
        picAvatar.Cursor = Cursors.SizeWE
        picAvatar.Location = New Point(143, 148)
        picAvatar.Margin = New Padding(3, 2, 3, 2)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(238, 395)
        picAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picAvatar.TabIndex = 38
        picAvatar.TabStop = False
        ' 
        ' clock
        ' 
        clock.BackColor = Color.Transparent
        clock.BackgroundImageLayout = ImageLayout.Zoom
        clock.Image = My.Resources.Resources.Clock
        clock.Location = New Point(1041, 11)
        clock.Margin = New Padding(3, 2, 3, 2)
        clock.Name = "clock"
        clock.Size = New Size(131, 110)
        clock.SizeMode = PictureBoxSizeMode.StretchImage
        clock.TabIndex = 39
        clock.TabStop = False
        ' 
        ' weapon1
        ' 
        weapon1.BackColor = Color.Transparent
        weapon1.Image = My.Resources.Resources.weapon1
        weapon1.Location = New Point(24, 170)
        weapon1.Name = "weapon1"
        weapon1.Size = New Size(95, 95)
        weapon1.SizeMode = PictureBoxSizeMode.StretchImage
        weapon1.TabIndex = 40
        weapon1.TabStop = False
        ' 
        ' weapon3
        ' 
        weapon3.BackColor = Color.Transparent
        weapon3.Image = My.Resources.Resources.weapon2
        weapon3.Location = New Point(24, 301)
        weapon3.Name = "weapon3"
        weapon3.Size = New Size(95, 95)
        weapon3.SizeMode = PictureBoxSizeMode.StretchImage
        weapon3.TabIndex = 41
        weapon3.TabStop = False
        ' 
        ' weapon5
        ' 
        weapon5.BackColor = Color.Transparent
        weapon5.Image = My.Resources.Resources.weapon3
        weapon5.Location = New Point(24, 431)
        weapon5.Name = "weapon5"
        weapon5.Size = New Size(95, 95)
        weapon5.SizeMode = PictureBoxSizeMode.StretchImage
        weapon5.TabIndex = 42
        weapon5.TabStop = False
        ' 
        ' weapon6
        ' 
        weapon6.BackColor = Color.Transparent
        weapon6.Image = My.Resources.Resources.weapon6
        weapon6.Location = New Point(402, 431)
        weapon6.Name = "weapon6"
        weapon6.Size = New Size(95, 95)
        weapon6.SizeMode = PictureBoxSizeMode.StretchImage
        weapon6.TabIndex = 45
        weapon6.TabStop = False
        ' 
        ' weapon4
        ' 
        weapon4.BackColor = Color.Transparent
        weapon4.Image = My.Resources.Resources.weapon5
        weapon4.Location = New Point(402, 301)
        weapon4.Name = "weapon4"
        weapon4.Size = New Size(95, 95)
        weapon4.SizeMode = PictureBoxSizeMode.StretchImage
        weapon4.TabIndex = 44
        weapon4.TabStop = False
        ' 
        ' weapon2
        ' 
        weapon2.BackColor = Color.Transparent
        weapon2.Image = My.Resources.Resources.weapon4
        weapon2.Location = New Point(402, 170)
        weapon2.Name = "weapon2"
        weapon2.Size = New Size(95, 95)
        weapon2.SizeMode = PictureBoxSizeMode.StretchImage
        weapon2.TabIndex = 43
        weapon2.TabStop = False
        ' 
        ' lvlname
        ' 
        lvlname.BackColor = Color.Transparent
        lvlname.Image = My.Resources.Resources.lvlname
        lvlname.Location = New Point(79, 46)
        lvlname.Name = "lvlname"
        lvlname.Size = New Size(374, 87)
        lvlname.SizeMode = PictureBoxSizeMode.StretchImage
        lvlname.TabIndex = 46
        lvlname.TabStop = False
        ' 
        ' uibar
        ' 
        uibar.BackColor = Color.Transparent
        uibar.Image = My.Resources.Resources.uibar
        uibar.Location = New Point(481, 46)
        uibar.Name = "uibar"
        uibar.Size = New Size(538, 49)
        uibar.SizeMode = PictureBoxSizeMode.StretchImage
        uibar.TabIndex = 47
        uibar.TabStop = False
        ' 
        ' pb2
        ' 
        pb2.BackColor = Color.Transparent
        pb2.BackgroundImage = My.Resources.Resources.transparent
        pb2.Cursor = Cursors.Hand
        pb2.Location = New Point(627, 127)
        pb2.Name = "pb2"
        pb2.Size = New Size(89, 50)
        pb2.TabIndex = 49
        pb2.TabStop = False
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.Transparent
        lbl1.Font = New Font("rainyhearts", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl1.ForeColor = Color.Teal
        lbl1.Image = My.Resources.Resources.borderstill
        lbl1.Location = New Point(144, 560)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(235, 25)
        lbl1.TabIndex = 50
        lbl1.Text = "Rotate your avatar"
        ' 
        ' week8
        ' 
        AutoScaleDimensions = New SizeF(7F, 11F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 611)
        Controls.Add(lbl1)
        Controls.Add(pb2)
        Controls.Add(pb1)
        Controls.Add(Panel2)
        Controls.Add(RTB2)
        Controls.Add(PictureBox1)
        Controls.Add(uibar)
        Controls.Add(lvlname)
        Controls.Add(weapon6)
        Controls.Add(weapon4)
        Controls.Add(weapon2)
        Controls.Add(weapon5)
        Controls.Add(weapon3)
        Controls.Add(weapon1)
        Controls.Add(clock)
        Controls.Add(picAvatar)
        Controls.Add(backbtn)
        Controls.Add(bg)
        Font = New Font("rainyhearts", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "week8"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week 8 - Working with Controls and Properties"
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(dialog_print, ComponentModel.ISupportInitialize).EndInit()
        CType(dialog_savefile, ComponentModel.ISupportInitialize).EndInit()
        CType(dialog_font, ComponentModel.ISupportInitialize).EndInit()
        CType(dialog_openfile, ComponentModel.ISupportInitialize).EndInit()
        CType(dialog_color, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pb1, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(clock, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon1, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon3, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon5, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon6, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon4, ComponentModel.ISupportInitialize).EndInit()
        CType(weapon2, ComponentModel.ISupportInitialize).EndInit()
        CType(lvlname, ComponentModel.ISupportInitialize).EndInit()
        CType(uibar, ComponentModel.ISupportInitialize).EndInit()
        CType(pb2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RTB2 As TextBox
    Friend WithEvents dialog_print As PictureBox
    Friend WithEvents dialog_savefile As PictureBox
    Friend WithEvents dialog_font As PictureBox
    Friend WithEvents dialog_openfile As PictureBox
    Friend WithEvents dialog_color As PictureBox
    Friend WithEvents clock As PictureBox
    Friend WithEvents weapon1 As PictureBox
    Friend WithEvents weapon3 As PictureBox
    Friend WithEvents weapon5 As PictureBox
    Friend WithEvents weapon6 As PictureBox
    Friend WithEvents weapon4 As PictureBox
    Friend WithEvents weapon2 As PictureBox
    Friend WithEvents lvlname As PictureBox
    Friend WithEvents uibar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents lbl1 As Label
End Class
