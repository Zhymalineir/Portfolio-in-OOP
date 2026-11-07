<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class animation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(animation))
        gamemenu_bg = New PictureBox()
        backbtn = New PictureBox()
        title = New PictureBox()
        btn_level1 = New Button()
        btn_level2 = New Button()
        btn_level3 = New Button()
        gamemenu_holder = New Panel()
        CType(gamemenu_bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(title, ComponentModel.ISupportInitialize).BeginInit()
        gamemenu_holder.SuspendLayout()
        SuspendLayout()
        ' 
        ' gamemenu_bg
        ' 
        gamemenu_bg.Image = CType(resources.GetObject("gamemenu_bg.Image"), Image)
        gamemenu_bg.Location = New Point(149, 444)
        gamemenu_bg.Name = "gamemenu_bg"
        gamemenu_bg.Size = New Size(83, 57)
        gamemenu_bg.SizeMode = PictureBoxSizeMode.StretchImage
        gamemenu_bg.TabIndex = 0
        gamemenu_bg.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(32, 42)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(59, 60)
        backbtn.TabIndex = 7
        backbtn.TabStop = False
        ' 
        ' title
        ' 
        title.BackColor = Color.Transparent
        title.Image = CType(resources.GetObject("title.Image"), Image)
        title.Location = New Point(57, 111)
        title.Name = "title"
        title.Size = New Size(299, 136)
        title.SizeMode = PictureBoxSizeMode.Zoom
        title.TabIndex = 1
        title.TabStop = False
        ' 
        ' btn_level1
        ' 
        btn_level1.BackColor = Color.Transparent
        btn_level1.BackgroundImage = CType(resources.GetObject("btn_level1.BackgroundImage"), Image)
        btn_level1.BackgroundImageLayout = ImageLayout.Stretch
        btn_level1.FlatAppearance.BorderSize = 0
        btn_level1.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_level1.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_level1.FlatStyle = FlatStyle.Flat
        btn_level1.Font = New Font("rainyhearts", 30F)
        btn_level1.ForeColor = Color.White
        btn_level1.Location = New Point(97, 253)
        btn_level1.Name = "btn_level1"
        btn_level1.Size = New Size(229, 81)
        btn_level1.TabIndex = 3
        btn_level1.Text = "Level 1"
        btn_level1.UseVisualStyleBackColor = False
        ' 
        ' btn_level2
        ' 
        btn_level2.BackColor = Color.Transparent
        btn_level2.BackgroundImage = CType(resources.GetObject("btn_level2.BackgroundImage"), Image)
        btn_level2.BackgroundImageLayout = ImageLayout.Stretch
        btn_level2.FlatAppearance.BorderSize = 0
        btn_level2.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_level2.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_level2.FlatStyle = FlatStyle.Flat
        btn_level2.Font = New Font("rainyhearts", 30F)
        btn_level2.ForeColor = Color.White
        btn_level2.Location = New Point(97, 340)
        btn_level2.Name = "btn_level2"
        btn_level2.Size = New Size(229, 81)
        btn_level2.TabIndex = 4
        btn_level2.Text = "Level 2"
        btn_level2.UseVisualStyleBackColor = False
        ' 
        ' btn_level3
        ' 
        btn_level3.BackColor = Color.Transparent
        btn_level3.BackgroundImage = CType(resources.GetObject("btn_level3.BackgroundImage"), Image)
        btn_level3.BackgroundImageLayout = ImageLayout.Stretch
        btn_level3.FlatAppearance.BorderSize = 0
        btn_level3.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_level3.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_level3.FlatStyle = FlatStyle.Flat
        btn_level3.Font = New Font("rainyhearts", 30F)
        btn_level3.ForeColor = Color.White
        btn_level3.Location = New Point(97, 427)
        btn_level3.Name = "btn_level3"
        btn_level3.Size = New Size(229, 81)
        btn_level3.TabIndex = 5
        btn_level3.Text = "Level 3"
        btn_level3.UseVisualStyleBackColor = False
        ' 
        ' gamemenu_holder
        ' 
        gamemenu_holder.BackColor = Color.Transparent
        gamemenu_holder.BackgroundImage = CType(resources.GetObject("gamemenu_holder.BackgroundImage"), Image)
        gamemenu_holder.BackgroundImageLayout = ImageLayout.Zoom
        gamemenu_holder.Controls.Add(btn_level3)
        gamemenu_holder.Controls.Add(btn_level2)
        gamemenu_holder.Controls.Add(btn_level1)
        gamemenu_holder.Controls.Add(title)
        gamemenu_holder.Location = New Point(737, -2)
        gamemenu_holder.Name = "gamemenu_holder"
        gamemenu_holder.Size = New Size(412, 567)
        gamemenu_holder.TabIndex = 2
        ' 
        ' gamemenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 611)
        Controls.Add(backbtn)
        Controls.Add(gamemenu_holder)
        Controls.Add(gamemenu_bg)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "gamemenu"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game Menu"
        CType(gamemenu_bg, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(title, ComponentModel.ISupportInitialize).EndInit()
        gamemenu_holder.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents gamemenu_bg As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents title As PictureBox
    Friend WithEvents btn_level1 As Button
    Friend WithEvents btn_level2 As Button
    Friend WithEvents btn_level3 As Button
    Friend WithEvents gamemenu_holder As Panel
End Class
