<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level2))
        Player = New PictureBox()
        item_holywater = New PictureBox()
        item_holycross = New PictureBox()
        lbl_score = New Label()
        CType(Player, ComponentModel.ISupportInitialize).BeginInit()
        CType(item_holywater, ComponentModel.ISupportInitialize).BeginInit()
        CType(item_holycross, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Player
        ' 
        Player.BackColor = Color.Transparent
        Player.Image = CType(resources.GetObject("Player.Image"), Image)
        Player.Location = New Point(656, 56)
        Player.Name = "Player"
        Player.Size = New Size(104, 96)
        Player.SizeMode = PictureBoxSizeMode.Zoom
        Player.TabIndex = 0
        Player.TabStop = False
        ' 
        ' item_holywater
        ' 
        item_holywater.BackColor = Color.Transparent
        item_holywater.Image = CType(resources.GetObject("item_holywater.Image"), Image)
        item_holywater.Location = New Point(948, 498)
        item_holywater.Name = "item_holywater"
        item_holywater.Size = New Size(100, 100)
        item_holywater.SizeMode = PictureBoxSizeMode.Zoom
        item_holywater.TabIndex = 1
        item_holywater.TabStop = False
        ' 
        ' item_holycross
        ' 
        item_holycross.BackColor = Color.Transparent
        item_holycross.Image = CType(resources.GetObject("item_holycross.Image"), Image)
        item_holycross.Location = New Point(1054, 498)
        item_holycross.Name = "item_holycross"
        item_holycross.Size = New Size(100, 100)
        item_holycross.SizeMode = PictureBoxSizeMode.Zoom
        item_holycross.TabIndex = 2
        item_holycross.TabStop = False
        ' 
        ' lbl_score
        ' 
        lbl_score.AutoSize = True
        lbl_score.BackColor = Color.Transparent
        lbl_score.Font = New Font("rainyhearts", 30F)
        lbl_score.ForeColor = Color.White
        lbl_score.Location = New Point(511, 15)
        lbl_score.Name = "lbl_score"
        lbl_score.Size = New Size(169, 38)
        lbl_score.TabIndex = 3
        lbl_score.Text = "SCORE: 0"
        ' 
        ' level2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 611)
        Controls.Add(lbl_score)
        Controls.Add(item_holycross)
        Controls.Add(item_holywater)
        Controls.Add(Player)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "level2"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level 2- Exorcise The Devils"
        CType(Player, ComponentModel.ISupportInitialize).EndInit()
        CType(item_holywater, ComponentModel.ISupportInitialize).EndInit()
        CType(item_holycross, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents item_holywater As PictureBox
    Friend WithEvents item_holycross As PictureBox
    Friend WithEvents lbl_score As Label
End Class
