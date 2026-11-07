<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level3))
        Priest1 = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        Priest4 = New PictureBox()
        lbl_great = New Label()
        lbl_notbad = New Label()
        lbl_izzfine = New Label()
        lbl_hellnah = New Label()
        lbl_questionmark = New Label()
        btn_score = New Button()
        btn_combo = New Button()
        lbl_rating = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        btn_start = New Button()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Priest1
        ' 
        Priest1.BackColor = Color.Transparent
        Priest1.Image = CType(resources.GetObject("Priest1.Image"), Image)
        Priest1.Location = New Point(430, 414)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(79, 89)
        Priest1.SizeMode = PictureBoxSizeMode.Zoom
        Priest1.TabIndex = 0
        Priest1.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Transparent
        Priest2.Image = CType(resources.GetObject("Priest2.Image"), Image)
        Priest2.Location = New Point(510, 414)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(79, 89)
        Priest2.SizeMode = PictureBoxSizeMode.Zoom
        Priest2.TabIndex = 1
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.Transparent
        Priest3.Image = CType(resources.GetObject("Priest3.Image"), Image)
        Priest3.Location = New Point(592, 414)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(79, 89)
        Priest3.SizeMode = PictureBoxSizeMode.Zoom
        Priest3.TabIndex = 2
        Priest3.TabStop = False
        ' 
        ' Priest4
        ' 
        Priest4.BackColor = Color.Transparent
        Priest4.Image = CType(resources.GetObject("Priest4.Image"), Image)
        Priest4.Location = New Point(674, 414)
        Priest4.Name = "Priest4"
        Priest4.Size = New Size(79, 89)
        Priest4.SizeMode = PictureBoxSizeMode.Zoom
        Priest4.TabIndex = 3
        Priest4.TabStop = False
        ' 
        ' lbl_great
        ' 
        lbl_great.AutoSize = True
        lbl_great.BackColor = Color.Transparent
        lbl_great.Font = New Font("rainyhearts", 23F)
        lbl_great.ForeColor = Color.Cyan
        lbl_great.Location = New Point(797, 399)
        lbl_great.Name = "lbl_great"
        lbl_great.Size = New Size(110, 29)
        lbl_great.TabIndex = 5
        lbl_great.Text = "Great: 0"
        ' 
        ' lbl_notbad
        ' 
        lbl_notbad.AutoSize = True
        lbl_notbad.BackColor = Color.Transparent
        lbl_notbad.Font = New Font("rainyhearts", 23F)
        lbl_notbad.ForeColor = Color.Lime
        lbl_notbad.Location = New Point(798, 370)
        lbl_notbad.Name = "lbl_notbad"
        lbl_notbad.Size = New Size(138, 29)
        lbl_notbad.TabIndex = 6
        lbl_notbad.Text = "Not Bad: 0"
        ' 
        ' lbl_izzfine
        ' 
        lbl_izzfine.AutoSize = True
        lbl_izzfine.BackColor = Color.Transparent
        lbl_izzfine.Font = New Font("rainyhearts", 23F)
        lbl_izzfine.ForeColor = Color.Yellow
        lbl_izzfine.Location = New Point(797, 342)
        lbl_izzfine.Name = "lbl_izzfine"
        lbl_izzfine.Size = New Size(139, 29)
        lbl_izzfine.TabIndex = 7
        lbl_izzfine.Text = "Izz Fine: 0"
        ' 
        ' lbl_hellnah
        ' 
        lbl_hellnah.AutoSize = True
        lbl_hellnah.BackColor = Color.Transparent
        lbl_hellnah.Font = New Font("rainyhearts", 23F, FontStyle.Bold)
        lbl_hellnah.ForeColor = Color.Red
        lbl_hellnah.Location = New Point(797, 313)
        lbl_hellnah.Name = "lbl_hellnah"
        lbl_hellnah.Size = New Size(160, 29)
        lbl_hellnah.TabIndex = 8
        lbl_hellnah.Text = "Hell Nah: 0"
        ' 
        ' lbl_questionmark
        ' 
        lbl_questionmark.AutoSize = True
        lbl_questionmark.BackColor = Color.Transparent
        lbl_questionmark.Font = New Font("rainyhearts", 23F)
        lbl_questionmark.ForeColor = Color.White
        lbl_questionmark.Location = New Point(798, 284)
        lbl_questionmark.Name = "lbl_questionmark"
        lbl_questionmark.Size = New Size(77, 29)
        lbl_questionmark.TabIndex = 9
        lbl_questionmark.Text = "???: 0"
        ' 
        ' btn_score
        ' 
        btn_score.BackColor = Color.Transparent
        btn_score.FlatAppearance.BorderSize = 0
        btn_score.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_score.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_score.FlatStyle = FlatStyle.Flat
        btn_score.Font = New Font("rainyhearts", 30F)
        btn_score.ForeColor = Color.White
        btn_score.Location = New Point(495, 12)
        btn_score.Name = "btn_score"
        btn_score.Size = New Size(189, 46)
        btn_score.TabIndex = 10
        btn_score.Text = "0"
        btn_score.UseVisualStyleBackColor = False
        ' 
        ' btn_combo
        ' 
        btn_combo.BackColor = Color.Transparent
        btn_combo.FlatAppearance.BorderSize = 0
        btn_combo.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_combo.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_combo.FlatStyle = FlatStyle.Flat
        btn_combo.Font = New Font("rainyhearts", 23F)
        btn_combo.ForeColor = Color.White
        btn_combo.Location = New Point(498, 282)
        btn_combo.Name = "btn_combo"
        btn_combo.Size = New Size(189, 46)
        btn_combo.TabIndex = 11
        btn_combo.Text = "0"
        btn_combo.UseVisualStyleBackColor = False
        ' 
        ' lbl_rating
        ' 
        lbl_rating.BackColor = Color.Transparent
        lbl_rating.FlatAppearance.BorderSize = 0
        lbl_rating.FlatAppearance.MouseDownBackColor = Color.Transparent
        lbl_rating.FlatAppearance.MouseOverBackColor = Color.Transparent
        lbl_rating.FlatStyle = FlatStyle.Flat
        lbl_rating.Font = New Font("rainyhearts", 35F)
        lbl_rating.ForeColor = Color.White
        lbl_rating.Location = New Point(498, 325)
        lbl_rating.Name = "lbl_rating"
        lbl_rating.Size = New Size(189, 46)
        lbl_rating.TabIndex = 12
        lbl_rating.Text = "izz fine"
        lbl_rating.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("rainyhearts", 35F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(440, 499)
        Button1.Name = "Button1"
        Button1.Size = New Size(64, 46)
        Button1.TabIndex = 13
        Button1.Text = "A"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("rainyhearts", 35F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(522, 499)
        Button2.Name = "Button2"
        Button2.Size = New Size(64, 46)
        Button2.TabIndex = 14
        Button2.Text = "S"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("rainyhearts", 35F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(604, 499)
        Button3.Name = "Button3"
        Button3.Size = New Size(64, 46)
        Button3.TabIndex = 15
        Button3.Text = "K"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("rainyhearts", 35F)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(686, 499)
        Button4.Name = "Button4"
        Button4.Size = New Size(64, 46)
        Button4.TabIndex = 16
        Button4.Text = "L"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btn_start
        ' 
        btn_start.BackColor = Color.Transparent
        btn_start.BackgroundImage = CType(resources.GetObject("btn_start.BackgroundImage"), Image)
        btn_start.BackgroundImageLayout = ImageLayout.Stretch
        btn_start.Cursor = Cursors.Hand
        btn_start.FlatAppearance.BorderSize = 0
        btn_start.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_start.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_start.FlatStyle = FlatStyle.Flat
        btn_start.Font = New Font("rainyhearts", 23F)
        btn_start.ForeColor = Color.White
        btn_start.Location = New Point(498, 261)
        btn_start.Name = "btn_start"
        btn_start.Size = New Size(189, 74)
        btn_start.TabIndex = 17
        btn_start.UseVisualStyleBackColor = False
        ' 
        ' level3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 611)
        Controls.Add(btn_start)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lbl_rating)
        Controls.Add(btn_combo)
        Controls.Add(btn_score)
        Controls.Add(lbl_questionmark)
        Controls.Add(lbl_hellnah)
        Controls.Add(lbl_izzfine)
        Controls.Add(lbl_notbad)
        Controls.Add(lbl_great)
        Controls.Add(Priest4)
        Controls.Add(Priest3)
        Controls.Add(Priest2)
        Controls.Add(Priest1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "level3"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level 3 - Concerto"
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
    Friend WithEvents Priest As PictureBox
    Friend WithEvents Priest4 As PictureBox
    Friend WithEvents lbl_great As Label
    Friend WithEvents lbl_notbad As Label
    Friend WithEvents lbl_izzfine As Label
    Friend WithEvents lbl_hellnah As Label
    Friend WithEvents lbl_questionmark As Label
    Friend WithEvents btn_score As Button
    Friend WithEvents btn_combo As Button
    Friend WithEvents lbl_rating As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_start As Button
End Class
