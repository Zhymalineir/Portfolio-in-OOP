<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week10))
        debuggingmode = New PictureBox()
        errorhandling = New PictureBox()
        erroranddebugging = New PictureBox()
        creatingclasses = New PictureBox()
        classesandobjects = New PictureBox()
        bg = New PictureBox()
        PictureBox2 = New PictureBox()
        RTB3 = New TextBox()
        backbtn = New PictureBox()
        RTB2 = New Panel()
        ui1 = New PictureBox()
        ui2 = New PictureBox()
        parentpanel = New PictureBox()
        CType(debuggingmode, ComponentModel.ISupportInitialize).BeginInit()
        CType(errorhandling, ComponentModel.ISupportInitialize).BeginInit()
        CType(erroranddebugging, ComponentModel.ISupportInitialize).BeginInit()
        CType(creatingclasses, ComponentModel.ISupportInitialize).BeginInit()
        CType(classesandobjects, ComponentModel.ISupportInitialize).BeginInit()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        RTB2.SuspendLayout()
        CType(ui1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ui2, ComponentModel.ISupportInitialize).BeginInit()
        CType(parentpanel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' debuggingmode
        ' 
        debuggingmode.Image = My.Resources.Resources.debuggingbtn
        debuggingmode.Location = New Point(4, 227)
        debuggingmode.Name = "debuggingmode"
        debuggingmode.Size = New Size(318, 50)
        debuggingmode.SizeMode = PictureBoxSizeMode.StretchImage
        debuggingmode.TabIndex = 9
        debuggingmode.TabStop = False
        ' 
        ' errorhandling
        ' 
        errorhandling.Image = My.Resources.Resources.errorhandlingbtn
        errorhandling.Location = New Point(4, 171)
        errorhandling.Name = "errorhandling"
        errorhandling.Size = New Size(318, 50)
        errorhandling.SizeMode = PictureBoxSizeMode.StretchImage
        errorhandling.TabIndex = 8
        errorhandling.TabStop = False
        ' 
        ' erroranddebugging
        ' 
        erroranddebugging.Image = My.Resources.Resources.erroranddebuggingbtn
        erroranddebugging.Location = New Point(4, 115)
        erroranddebugging.Name = "erroranddebugging"
        erroranddebugging.Size = New Size(318, 50)
        erroranddebugging.SizeMode = PictureBoxSizeMode.StretchImage
        erroranddebugging.TabIndex = 7
        erroranddebugging.TabStop = False
        ' 
        ' creatingclasses
        ' 
        creatingclasses.Image = My.Resources.Resources.creatingclassesbtn
        creatingclasses.Location = New Point(4, 59)
        creatingclasses.Name = "creatingclasses"
        creatingclasses.Size = New Size(318, 50)
        creatingclasses.SizeMode = PictureBoxSizeMode.StretchImage
        creatingclasses.TabIndex = 6
        creatingclasses.TabStop = False
        ' 
        ' classesandobjects
        ' 
        classesandobjects.Image = My.Resources.Resources.classandobjectbtn
        classesandobjects.Location = New Point(4, 3)
        classesandobjects.Name = "classesandobjects"
        classesandobjects.Size = New Size(318, 50)
        classesandobjects.SizeMode = PictureBoxSizeMode.StretchImage
        classesandobjects.TabIndex = 5
        classesandobjects.TabStop = False
        ' 
        ' bg
        ' 
        bg.Dock = DockStyle.Fill
        bg.Image = My.Resources.Resources.wk10bg
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1184, 611)
        bg.SizeMode = PictureBoxSizeMode.StretchImage
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.blckscreen
        PictureBox2.Location = New Point(52, 291)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(655, 292)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' RTB3
        ' 
        RTB3.BackColor = SystemColors.ActiveCaptionText
        RTB3.BorderStyle = BorderStyle.None
        RTB3.Font = New Font("rainyhearts", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB3.ForeColor = Color.LimeGreen
        RTB3.Location = New Point(99, 321)
        RTB3.Multiline = True
        RTB3.Name = "RTB3"
        RTB3.ReadOnly = True
        RTB3.ScrollBars = ScrollBars.Vertical
        RTB3.Size = New Size(564, 236)
        RTB3.TabIndex = 3
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Location = New Point(12, 31)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(55, 53)
        backbtn.TabIndex = 38
        backbtn.TabStop = False
        ' 
        ' RTB2
        ' 
        RTB2.AutoScroll = True
        RTB2.Controls.Add(debuggingmode)
        RTB2.Controls.Add(classesandobjects)
        RTB2.Controls.Add(errorhandling)
        RTB2.Controls.Add(creatingclasses)
        RTB2.Controls.Add(erroranddebugging)
        RTB2.Location = New Point(405, 82)
        RTB2.Name = "RTB2"
        RTB2.Size = New Size(356, 164)
        RTB2.TabIndex = 39
        ' 
        ' ui1
        ' 
        ui1.BackColor = Color.Transparent
        ui1.Image = My.Resources.Resources.lvlname
        ui1.Location = New Point(99, 12)
        ui1.Name = "ui1"
        ui1.Size = New Size(267, 63)
        ui1.SizeMode = PictureBoxSizeMode.StretchImage
        ui1.TabIndex = 41
        ui1.TabStop = False
        ' 
        ' ui2
        ' 
        ui2.BackColor = Color.Transparent
        ui2.Image = My.Resources.Resources.uibar
        ui2.Location = New Point(382, 9)
        ui2.Name = "ui2"
        ui2.Size = New Size(503, 47)
        ui2.SizeMode = PictureBoxSizeMode.StretchImage
        ui2.TabIndex = 42
        ui2.TabStop = False
        ' 
        ' parentpanel
        ' 
        parentpanel.Image = My.Resources.Resources.blckscreen
        parentpanel.Location = New Point(382, 62)
        parentpanel.Name = "parentpanel"
        parentpanel.Size = New Size(379, 200)
        parentpanel.SizeMode = PictureBoxSizeMode.StretchImage
        parentpanel.TabIndex = 43
        parentpanel.TabStop = False
        ' 
        ' week10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 611)
        Controls.Add(RTB2)
        Controls.Add(parentpanel)
        Controls.Add(ui2)
        Controls.Add(ui1)
        Controls.Add(backbtn)
        Controls.Add(RTB3)
        Controls.Add(PictureBox2)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "week10"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week 10 – Debugging and Tracing"
        CType(debuggingmode, ComponentModel.ISupportInitialize).EndInit()
        CType(errorhandling, ComponentModel.ISupportInitialize).EndInit()
        CType(erroranddebugging, ComponentModel.ISupportInitialize).EndInit()
        CType(creatingclasses, ComponentModel.ISupportInitialize).EndInit()
        CType(classesandobjects, ComponentModel.ISupportInitialize).EndInit()
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        RTB2.ResumeLayout(False)
        CType(ui1, ComponentModel.ISupportInitialize).EndInit()
        CType(ui2, ComponentModel.ISupportInitialize).EndInit()
        CType(parentpanel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RTB3 As TextBox
    Friend WithEvents debuggingmode As PictureBox
    Friend WithEvents errorhandling As PictureBox
    Friend WithEvents erroranddebugging As PictureBox
    Friend WithEvents creatingclasses As PictureBox
    Friend WithEvents classesandobjects As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents RTB2 As Panel
    Friend WithEvents ui1 As PictureBox
    Friend WithEvents ui2 As PictureBox
    Friend WithEvents parentpanel As PictureBox
End Class
