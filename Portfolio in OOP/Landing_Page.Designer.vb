<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landing_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Landing_Page))
        banner = New PictureBox()
        midtermsbtn = New PictureBox()
        playerbtn = New PictureBox()
        watermark = New PictureBox()
        bg = New PictureBox()
        finalsbtn = New PictureBox()
        CType(banner, ComponentModel.ISupportInitialize).BeginInit()
        CType(midtermsbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(playerbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(watermark, ComponentModel.ISupportInitialize).BeginInit()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(finalsbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' banner
        ' 
        banner.Image = My.Resources.Resources.BANNER
        banner.Location = New Point(241, 32)
        banner.Name = "banner"
        banner.Size = New Size(712, 371)
        banner.SizeMode = PictureBoxSizeMode.StretchImage
        banner.TabIndex = 0
        banner.TabStop = False
        ' 
        ' midtermsbtn
        ' 
        midtermsbtn.BackColor = Color.Transparent
        midtermsbtn.Cursor = Cursors.Hand
        midtermsbtn.Image = My.Resources.Resources.btnMIDTERMS
        midtermsbtn.Location = New Point(329, 421)
        midtermsbtn.Name = "midtermsbtn"
        midtermsbtn.Size = New Size(253, 130)
        midtermsbtn.SizeMode = PictureBoxSizeMode.StretchImage
        midtermsbtn.TabIndex = 1
        midtermsbtn.TabStop = False
        ' 
        ' playerbtn
        ' 
        playerbtn.BackColor = Color.Transparent
        playerbtn.Cursor = Cursors.Hand
        playerbtn.Image = My.Resources.Resources.btnPLAYER
        playerbtn.Location = New Point(1085, 432)
        playerbtn.Name = "playerbtn"
        playerbtn.Size = New Size(74, 64)
        playerbtn.SizeMode = PictureBoxSizeMode.StretchImage
        playerbtn.TabIndex = 3
        playerbtn.TabStop = False
        ' 
        ' watermark
        ' 
        watermark.Image = My.Resources.Resources.watermark
        watermark.Location = New Point(905, 503)
        watermark.Name = "watermark"
        watermark.Size = New Size(265, 96)
        watermark.SizeMode = PictureBoxSizeMode.StretchImage
        watermark.TabIndex = 5
        watermark.TabStop = False
        ' 
        ' bg
        ' 
        bg.Dock = DockStyle.Fill
        bg.Image = My.Resources.Resources.openingbg
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1184, 611)
        bg.SizeMode = PictureBoxSizeMode.StretchImage
        bg.TabIndex = 6
        bg.TabStop = False
        ' 
        ' finalsbtn
        ' 
        finalsbtn.BackColor = Color.Transparent
        finalsbtn.Cursor = Cursors.Hand
        finalsbtn.Image = My.Resources.Resources.btnFINALS
        finalsbtn.Location = New Point(626, 421)
        finalsbtn.Name = "finalsbtn"
        finalsbtn.Size = New Size(253, 130)
        finalsbtn.SizeMode = PictureBoxSizeMode.StretchImage
        finalsbtn.TabIndex = 7
        finalsbtn.TabStop = False
        ' 
        ' Landing_Page
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 611)
        Controls.Add(finalsbtn)
        Controls.Add(playerbtn)
        Controls.Add(midtermsbtn)
        Controls.Add(banner)
        Controls.Add(watermark)
        Controls.Add(bg)
        Font = New Font("Stardew Valley", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Landing_Page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Portfolio in Object-Oriented Programming - Landing Page"
        CType(banner, ComponentModel.ISupportInitialize).EndInit()
        CType(midtermsbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(playerbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(watermark, ComponentModel.ISupportInitialize).EndInit()
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(finalsbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents banner As PictureBox
    Friend WithEvents midtermsbtn As PictureBox
    Friend WithEvents playerbtn As PictureBox
    Friend WithEvents watermark As PictureBox
    Friend WithEvents bg As PictureBox
    Friend WithEvents finalsbtn As PictureBox

End Class
