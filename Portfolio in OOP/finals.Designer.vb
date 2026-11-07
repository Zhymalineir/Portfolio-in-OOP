<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(finals))
        bg = New PictureBox()
        woodboard = New PictureBox()
        backbtn = New PictureBox()
        wk10 = New PictureBox()
        wk11 = New PictureBox()
        banner = New PictureBox()
        arrow1 = New PictureBox()
        arrow2 = New PictureBox()
        arrow3 = New PictureBox()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(woodboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(wk10, ComponentModel.ISupportInitialize).BeginInit()
        CType(wk11, ComponentModel.ISupportInitialize).BeginInit()
        CType(banner, ComponentModel.ISupportInitialize).BeginInit()
        CType(arrow1, ComponentModel.ISupportInitialize).BeginInit()
        CType(arrow2, ComponentModel.ISupportInitialize).BeginInit()
        CType(arrow3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.Dock = DockStyle.Fill
        bg.Image = My.Resources.Resources.Landscape
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1184, 611)
        bg.SizeMode = PictureBoxSizeMode.StretchImage
        bg.TabIndex = 1
        bg.TabStop = False
        ' 
        ' woodboard
        ' 
        woodboard.BackColor = Color.Transparent
        woodboard.Image = My.Resources.Resources.bulletin_board1
        woodboard.Location = New Point(354, 38)
        woodboard.Name = "woodboard"
        woodboard.Size = New Size(798, 541)
        woodboard.SizeMode = PictureBoxSizeMode.StretchImage
        woodboard.TabIndex = 2
        woodboard.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(27, 38)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(60, 60)
        backbtn.TabIndex = 11
        backbtn.TabStop = False
        ' 
        ' wk10
        ' 
        wk10.BackColor = Color.Transparent
        wk10.Cursor = Cursors.Hand
        wk10.Image = My.Resources.Resources.wk10
        wk10.Location = New Point(422, 140)
        wk10.Name = "wk10"
        wk10.Size = New Size(318, 323)
        wk10.SizeMode = PictureBoxSizeMode.StretchImage
        wk10.TabIndex = 12
        wk10.TabStop = False
        ' 
        ' wk11
        ' 
        wk11.BackColor = Color.Transparent
        wk11.Cursor = Cursors.Hand
        wk11.Image = My.Resources.Resources.wk11
        wk11.Location = New Point(768, 140)
        wk11.Name = "wk11"
        wk11.Size = New Size(318, 323)
        wk11.SizeMode = PictureBoxSizeMode.StretchImage
        wk11.TabIndex = 13
        wk11.TabStop = False
        ' 
        ' banner
        ' 
        banner.BackColor = Color.Transparent
        banner.Image = My.Resources.Resources.FINALS_BANNEr
        banner.Location = New Point(18, 212)
        banner.Name = "banner"
        banner.Size = New Size(318, 232)
        banner.SizeMode = PictureBoxSizeMode.StretchImage
        banner.TabIndex = 16
        banner.TabStop = False
        ' 
        ' arrow1
        ' 
        arrow1.BackColor = Color.Transparent
        arrow1.Cursor = Cursors.Hand
        arrow1.Image = My.Resources.Resources.arrow
        arrow1.Location = New Point(1006, 473)
        arrow1.Name = "arrow1"
        arrow1.Size = New Size(98, 46)
        arrow1.SizeMode = PictureBoxSizeMode.StretchImage
        arrow1.TabIndex = 17
        arrow1.TabStop = False
        ' 
        ' arrow2
        ' 
        arrow2.BackColor = Color.Transparent
        arrow2.Cursor = Cursors.Hand
        arrow2.Image = My.Resources.Resources.arrowflip
        arrow2.Location = New Point(402, 473)
        arrow2.Name = "arrow2"
        arrow2.Size = New Size(98, 46)
        arrow2.SizeMode = PictureBoxSizeMode.StretchImage
        arrow2.TabIndex = 19
        arrow2.TabStop = False
        ' 
        ' arrow3
        ' 
        arrow3.BackColor = Color.Transparent
        arrow3.Cursor = Cursors.Hand
        arrow3.Image = My.Resources.Resources.arrow
        arrow3.Location = New Point(1006, 473)
        arrow3.Name = "arrow3"
        arrow3.Size = New Size(98, 46)
        arrow3.SizeMode = PictureBoxSizeMode.StretchImage
        arrow3.TabIndex = 24
        arrow3.TabStop = False
        ' 
        ' finals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 611)
        Controls.Add(arrow3)
        Controls.Add(arrow2)
        Controls.Add(arrow1)
        Controls.Add(banner)
        Controls.Add(wk11)
        Controls.Add(wk10)
        Controls.Add(backbtn)
        Controls.Add(woodboard)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MaximizeBox = False
        Name = "finals"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Portfolio in Object-Oriented Programming - Finals Lessons"
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(woodboard, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(wk10, ComponentModel.ISupportInitialize).EndInit()
        CType(wk11, ComponentModel.ISupportInitialize).EndInit()
        CType(banner, ComponentModel.ISupportInitialize).EndInit()
        CType(arrow1, ComponentModel.ISupportInitialize).EndInit()
        CType(arrow2, ComponentModel.ISupportInitialize).EndInit()
        CType(arrow3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents woodboard As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents wk10 As PictureBox
    Friend WithEvents wk11 As PictureBox
    Friend WithEvents banner As PictureBox
    Friend WithEvents arrow1 As PictureBox
    Friend WithEvents arrow2 As PictureBox
    Friend WithEvents arrow3 As PictureBox
End Class
