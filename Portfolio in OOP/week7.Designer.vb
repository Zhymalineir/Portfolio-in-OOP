<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week7
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week7))
        PictureBox4 = New PictureBox()
        storage = New PictureBox()
        backbtn = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        arrnfunc = New PictureBox()
        func = New PictureBox()
        declaration = New PictureBox()
        Types = New PictureBox()
        Array = New PictureBox()
        RTB2 = New TextBox()
        PictureBox6 = New PictureBox()
        RTB3 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label12 = New Label()
        Panel2 = New Panel()
        b5 = New PictureBox()
        b4 = New PictureBox()
        b3 = New PictureBox()
        b2 = New PictureBox()
        b1 = New PictureBox()
        Label1 = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(storage, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(arrnfunc, ComponentModel.ISupportInitialize).BeginInit()
        CType(func, ComponentModel.ISupportInitialize).BeginInit()
        CType(declaration, ComponentModel.ISupportInitialize).BeginInit()
        CType(Types, ComponentModel.ISupportInitialize).BeginInit()
        CType(Array, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(b5, ComponentModel.ISupportInitialize).BeginInit()
        CType(b4, ComponentModel.ISupportInitialize).BeginInit()
        CType(b3, ComponentModel.ISupportInitialize).BeginInit()
        CType(b2, ComponentModel.ISupportInitialize).BeginInit()
        CType(b1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.array_title
        PictureBox4.Location = New Point(83, 78)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(397, 72)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' storage
        ' 
        storage.BackColor = Color.Transparent
        storage.Image = My.Resources.Resources.one_dim_array
        storage.Location = New Point(33, 171)
        storage.Name = "storage"
        storage.Size = New Size(354, 84)
        storage.SizeMode = PictureBoxSizeMode.StretchImage
        storage.TabIndex = 4
        storage.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(12, 535)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(60, 60)
        backbtn.TabIndex = 37
        backbtn.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(132, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 29)
        Label2.TabIndex = 38
        Label2.Text = "1" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.containerrec
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(arrnfunc)
        Panel1.Controls.Add(func)
        Panel1.Controls.Add(declaration)
        Panel1.Controls.Add(Types)
        Panel1.Controls.Add(Array)
        Panel1.Controls.Add(RTB2)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(RTB3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(497, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(660, 558)
        Panel1.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Pixellari", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Orange
        Label6.Location = New Point(68, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(280, 35)
        Label6.TabIndex = 55
        Label6.Text = "Choose a button"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' arrnfunc
        ' 
        arrnfunc.BackColor = Color.Transparent
        arrnfunc.Cursor = Cursors.Hand
        arrnfunc.Image = My.Resources.Resources.opbtnred
        arrnfunc.Location = New Point(490, 65)
        arrnfunc.Name = "arrnfunc"
        arrnfunc.Size = New Size(25, 25)
        arrnfunc.SizeMode = PictureBoxSizeMode.StretchImage
        arrnfunc.TabIndex = 57
        arrnfunc.TabStop = False
        ' 
        ' func
        ' 
        func.BackColor = Color.Transparent
        func.Cursor = Cursors.Hand
        func.Image = My.Resources.Resources.opbtnred
        func.Location = New Point(459, 66)
        func.Name = "func"
        func.Size = New Size(25, 25)
        func.SizeMode = PictureBoxSizeMode.StretchImage
        func.TabIndex = 56
        func.TabStop = False
        ' 
        ' declaration
        ' 
        declaration.BackColor = Color.Transparent
        declaration.Cursor = Cursors.Hand
        declaration.Image = My.Resources.Resources.opbtnred
        declaration.Location = New Point(428, 65)
        declaration.Name = "declaration"
        declaration.Size = New Size(25, 25)
        declaration.SizeMode = PictureBoxSizeMode.StretchImage
        declaration.TabIndex = 55
        declaration.TabStop = False
        ' 
        ' Types
        ' 
        Types.BackColor = Color.Transparent
        Types.Cursor = Cursors.Hand
        Types.Image = My.Resources.Resources.opbtnred
        Types.Location = New Point(397, 65)
        Types.Name = "Types"
        Types.Size = New Size(25, 25)
        Types.SizeMode = PictureBoxSizeMode.StretchImage
        Types.TabIndex = 54
        Types.TabStop = False
        ' 
        ' Array
        ' 
        Array.BackColor = Color.Transparent
        Array.Cursor = Cursors.Hand
        Array.Image = My.Resources.Resources.opbtnred
        Array.Location = New Point(366, 65)
        Array.Name = "Array"
        Array.Size = New Size(25, 25)
        Array.SizeMode = PictureBoxSizeMode.StretchImage
        Array.TabIndex = 53
        Array.TabStop = False
        ' 
        ' RTB2
        ' 
        RTB2.BorderStyle = BorderStyle.None
        RTB2.Font = New Font("rainyhearts", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB2.ForeColor = Color.Maroon
        RTB2.Location = New Point(91, 139)
        RTB2.Name = "RTB2"
        RTB2.ReadOnly = True
        RTB2.ScrollBars = ScrollBars.Horizontal
        RTB2.Size = New Size(497, 36)
        RTB2.TabIndex = 52
        RTB2.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources.menu
        PictureBox6.Location = New Point(68, 120)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(546, 74)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 51
        PictureBox6.TabStop = False
        ' 
        ' RTB3
        ' 
        RTB3.BorderStyle = BorderStyle.None
        RTB3.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RTB3.ForeColor = Color.Maroon
        RTB3.Location = New Point(91, 241)
        RTB3.Multiline = True
        RTB3.Name = "RTB3"
        RTB3.ReadOnly = True
        RTB3.ScrollBars = ScrollBars.Vertical
        RTB3.Size = New Size(497, 256)
        RTB3.TabIndex = 49
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.menu
        PictureBox1.Location = New Point(68, 208)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(546, 316)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(197, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 29)
        Label3.TabIndex = 39
        Label3.Text = "2"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(263, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 29)
        Label4.TabIndex = 40
        Label4.Text = "3"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(331, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 29)
        Label5.TabIndex = 41
        Label5.Text = "4"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Gold
        Label12.Location = New Point(65, 142)
        Label12.Name = "Label12"
        Label12.Size = New Size(27, 29)
        Label12.TabIndex = 48
        Label12.Text = "0"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = My.Resources.Resources.containerrec
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(b5)
        Panel2.Controls.Add(b4)
        Panel2.Controls.Add(b3)
        Panel2.Controls.Add(b2)
        Panel2.Controls.Add(b1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(storage)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(83, 156)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(412, 405)
        Panel2.TabIndex = 53
        ' 
        ' b5
        ' 
        b5.BackColor = Color.Transparent
        b5.Cursor = Cursors.Hand
        b5.Image = My.Resources.Resources.b24
        b5.Location = New Point(322, 196)
        b5.Name = "b5"
        b5.Size = New Size(39, 44)
        b5.SizeMode = PictureBoxSizeMode.StretchImage
        b5.TabIndex = 54
        b5.TabStop = False
        ' 
        ' b4
        ' 
        b4.BackColor = Color.Transparent
        b4.Cursor = Cursors.Hand
        b4.Image = My.Resources.Resources.b19
        b4.Location = New Point(254, 196)
        b4.Name = "b4"
        b4.Size = New Size(39, 44)
        b4.SizeMode = PictureBoxSizeMode.StretchImage
        b4.TabIndex = 53
        b4.TabStop = False
        ' 
        ' b3
        ' 
        b3.BackColor = Color.Transparent
        b3.Cursor = Cursors.Hand
        b3.Image = My.Resources.Resources.b21
        b3.Location = New Point(189, 196)
        b3.Name = "b3"
        b3.Size = New Size(39, 44)
        b3.SizeMode = PictureBoxSizeMode.StretchImage
        b3.TabIndex = 52
        b3.TabStop = False
        ' 
        ' b2
        ' 
        b2.BackColor = Color.Transparent
        b2.Cursor = Cursors.Hand
        b2.Image = My.Resources.Resources.b25
        b2.Location = New Point(125, 196)
        b2.Name = "b2"
        b2.Size = New Size(39, 44)
        b2.SizeMode = PictureBoxSizeMode.StretchImage
        b2.TabIndex = 51
        b2.TabStop = False
        ' 
        ' b1
        ' 
        b1.BackColor = Color.Transparent
        b1.Cursor = Cursors.Hand
        b1.Image = My.Resources.Resources.b26
        b1.Location = New Point(58, 196)
        b1.Name = "b1"
        b1.Size = New Size(39, 44)
        b1.SizeMode = PictureBoxSizeMode.StretchImage
        b1.TabIndex = 50
        b1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixellari", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Orange
        Label1.Location = New Point(54, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 70)
        Label1.TabIndex = 49
        Label1.Text = " One-Dimensional " & vbCrLf & "Array"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' week7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Landscape
        ClientSize = New Size(1184, 611)
        Controls.Add(backbtn)
        Controls.Add(PictureBox4)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "week7"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Week 7 - Arrays"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(storage, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(arrnfunc, ComponentModel.ISupportInitialize).EndInit()
        CType(func, ComponentModel.ISupportInitialize).EndInit()
        CType(declaration, ComponentModel.ISupportInitialize).EndInit()
        CType(Types, ComponentModel.ISupportInitialize).EndInit()
        CType(Array, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(b5, ComponentModel.ISupportInitialize).EndInit()
        CType(b4, ComponentModel.ISupportInitialize).EndInit()
        CType(b3, ComponentModel.ISupportInitialize).EndInit()
        CType(b2, ComponentModel.ISupportInitialize).EndInit()
        CType(b1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents storage As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RTB2 As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RTB3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Array As PictureBox
    Friend WithEvents declaration As PictureBox
    Friend WithEvents Types As PictureBox
    Friend WithEvents arrnfunc As PictureBox
    Friend WithEvents func As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents b1 As PictureBox
    Friend WithEvents b3 As PictureBox
    Friend WithEvents b2 As PictureBox
    Friend WithEvents b5 As PictureBox
    Friend WithEvents b4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
