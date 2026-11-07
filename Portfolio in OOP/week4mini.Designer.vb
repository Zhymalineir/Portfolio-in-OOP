<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week4mini
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week4mini))
        form = New Button()
        TextBox = New TextBox()
        lbl3 = New Label()
        Button = New Button()
        border = New PictureBox()
        label = New Label()
        lbl4 = New Label()
        lbl2 = New Label()
        ListBox = New ListBox()
        lbl5 = New Label()
        ComboBox = New ComboBox()
        lbl6 = New Label()
        RadioButton1 = New RadioButton()
        lbl7 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        CheckBox1 = New CheckBox()
        lbl8 = New Label()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        PictureBox1 = New PictureBox()
        lbl9 = New Label()
        ProgressBar1 = New ProgressBar()
        lbl10 = New Label()
        Timer1 = New Timer(components)
        lbl11 = New Label()
        lbl12 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Timer2 = New Timer(components)
        VScrollBar1 = New VScrollBar()
        HScrollBar1 = New HScrollBar()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        HelpProvider1 = New HelpProvider()
        backbtn = New PictureBox()
        exitbtn = New PictureBox()
        CType(border, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(exitbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' form
        ' 
        form.BackColor = Color.Transparent
        form.FlatAppearance.BorderSize = 0
        form.FlatStyle = FlatStyle.Flat
        form.ImageAlign = ContentAlignment.MiddleLeft
        form.Location = New Point(30, 42)
        form.Name = "form"
        form.Size = New Size(186, 115)
        form.TabIndex = 0
        form.Text = "1. Form - The container for all controls that make up the user interface"
        form.TextAlign = ContentAlignment.MiddleLeft
        form.UseVisualStyleBackColor = False
        ' 
        ' TextBox
        ' 
        TextBox.ForeColor = Color.Maroon
        TextBox.Location = New Point(30, 195)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(262, 30)
        TextBox.TabIndex = 1
        TextBox.Text = "Write something"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.Transparent
        lbl3.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl3.Location = New Point(30, 243)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(86, 21)
        lbl3.TabIndex = 2
        lbl3.Text = "3. Label"
        ' 
        ' Button
        ' 
        Button.BackgroundImage = My.Resources.Resources.button1
        Button.BackgroundImageLayout = ImageLayout.Stretch
        Button.FlatAppearance.BorderSize = 0
        Button.FlatStyle = FlatStyle.Flat
        Button.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button.Location = New Point(31, 377)
        Button.Name = "Button"
        Button.Size = New Size(141, 94)
        Button.TabIndex = 3
        Button.Text = "Press Me!"
        Button.UseVisualStyleBackColor = True
        ' 
        ' border
        ' 
        border.Image = My.Resources.Resources.borderstill
        border.Location = New Point(31, 268)
        border.Name = "border"
        border.Size = New Size(262, 60)
        border.SizeMode = PictureBoxSizeMode.StretchImage
        border.TabIndex = 5
        border.TabStop = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.BackColor = Color.FromArgb(CByte(254), CByte(224), CByte(178))
        label.Font = New Font("rainyhearts", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(52, 285)
        label.Name = "label"
        label.Size = New Size(224, 29)
        label.TabIndex = 6
        label.Text = "Hello, everyone!!"
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.Transparent
        lbl4.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl4.Location = New Point(31, 345)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(92, 21)
        lbl4.TabIndex = 7
        lbl4.Text = "4. Button"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.Transparent
        lbl2.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl2.Location = New Point(30, 171)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(118, 21)
        lbl2.TabIndex = 8
        lbl2.Text = "2. Text Box"
        ' 
        ' ListBox
        ' 
        ListBox.ForeColor = Color.Maroon
        ListBox.FormattingEnabled = True
        ListBox.ItemHeight = 21
        ListBox.Items.AddRange(New Object() {"Star", "Diamond", "Circle", "Heart"})
        ListBox.Location = New Point(31, 514)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(142, 109)
        ListBox.TabIndex = 9
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.Transparent
        lbl5.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl5.Location = New Point(31, 490)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(104, 21)
        lbl5.TabIndex = 10
        lbl5.Text = "5. ListBox"
        ' 
        ' ComboBox
        ' 
        ComboBox.DisplayMember = "Spring"
        ComboBox.ForeColor = Color.Maroon
        ComboBox.FormattingEnabled = True
        ComboBox.Items.AddRange(New Object() {"Spring", "Summer", "Winter", "Fall"})
        ComboBox.Location = New Point(321, 66)
        ComboBox.Name = "ComboBox"
        ComboBox.Size = New Size(159, 29)
        ComboBox.TabIndex = 11
        ComboBox.ValueMember = "1"
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.Transparent
        lbl6.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl6.Location = New Point(321, 42)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(128, 21)
        lbl6.TabIndex = 12
        lbl6.Text = "6. ComboBox"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackgroundImage = My.Resources.Resources.borderstill
        RadioButton1.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton1.ForeColor = Color.MediumOrchid
        RadioButton1.Location = New Point(330, 145)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(69, 25)
        RadioButton1.TabIndex = 13
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pink"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.Transparent
        lbl7.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl7.Location = New Point(321, 121)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(149, 21)
        lbl7.TabIndex = 14
        lbl7.Text = "7. Radiobutton"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackgroundImage = My.Resources.Resources.borderstill
        RadioButton2.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton2.ForeColor = Color.Blue
        RadioButton2.Location = New Point(330, 176)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(70, 25)
        RadioButton2.TabIndex = 15
        RadioButton2.TabStop = True
        RadioButton2.Text = "Blue"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackgroundImage = My.Resources.Resources.borderstill
        RadioButton3.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton3.ForeColor = Color.Green
        RadioButton3.Location = New Point(329, 207)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(83, 25)
        RadioButton3.TabIndex = 16
        RadioButton3.TabStop = True
        RadioButton3.Text = "Green"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(329, 285)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(172, 25)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Standard Farm"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.Transparent
        lbl8.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl8.Location = New Point(321, 261)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(124, 21)
        lbl8.TabIndex = 18
        lbl8.Text = "8. CheckBox"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(329, 316)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(147, 25)
        CheckBox2.TabIndex = 19
        CheckBox2.Text = "Forest Farm"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(329, 347)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(164, 25)
        CheckBox3.TabIndex = 20
        CheckBox3.Text = "Hill-Top Farm"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._17
        PictureBox1.Location = New Point(599, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.BackColor = Color.Transparent
        lbl9.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl9.Location = New Point(571, 42)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(136, 21)
        lbl9.TabIndex = 22
        lbl9.Text = "9. PictureBox"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(596, 207)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(163, 36)
        ProgressBar1.TabIndex = 23
        ' 
        ' lbl10
        ' 
        lbl10.AutoSize = True
        lbl10.BackColor = Color.Transparent
        lbl10.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl10.Location = New Point(571, 181)
        lbl10.Name = "lbl10"
        lbl10.Size = New Size(159, 21)
        lbl10.TabIndex = 24
        lbl10.Text = "10. ProgressBar"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' lbl11
        ' 
        lbl11.AutoSize = True
        lbl11.BackColor = Color.Transparent
        lbl11.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl11.Location = New Point(571, 261)
        lbl11.Name = "lbl11"
        lbl11.Size = New Size(131, 21)
        lbl11.TabIndex = 25
        lbl11.Text = "11. ScrollBar"
        ' 
        ' lbl12
        ' 
        lbl12.AutoSize = True
        lbl12.BackColor = Color.Transparent
        lbl12.Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl12.Location = New Point(278, 405)
        lbl12.Name = "lbl12"
        lbl12.Size = New Size(192, 21)
        lbl12.TabIndex = 27
        lbl12.Text = "12. DateTimePicker"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("rainyhearts", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.CalendarForeColor = Color.Maroon
        DateTimePicker1.CalendarTitleForeColor = Color.Maroon
        DateTimePicker1.Location = New Point(309, 441)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(336, 30)
        DateTimePicker1.TabIndex = 28
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("rainyhearts", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.CalendarForeColor = Color.Maroon
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(309, 483)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(231, 30)
        DateTimePicker2.TabIndex = 29
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(623, 292)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(22, 117)
        VScrollBar1.TabIndex = 30
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(661, 316)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(151, 25)
        HScrollBar1.TabIndex = 32
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(861, 661)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 33
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources._0btnhover
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Goldenrod
        Button1.Location = New Point(587, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(262, 96)
        Button1.TabIndex = 34
        Button1.Text = "This button is anchored on the top-right corner"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.borderstill
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Dock = DockStyle.Bottom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("rainyhearts", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(0, 563)
        Button2.Name = "Button2"
        Button2.Size = New Size(861, 98)
        Button2.TabIndex = 35
        Button2.Text = "This button is docked on the form"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Location = New Point(30, 21)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(60, 60)
        backbtn.TabIndex = 36
        backbtn.TabStop = False
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = Color.Transparent
        exitbtn.BackgroundImage = My.Resources.Resources.backbtn
        exitbtn.BackgroundImageLayout = ImageLayout.Zoom
        exitbtn.Cursor = Cursors.Hand
        exitbtn.Image = My.Resources.Resources.exitbtn
        exitbtn.Location = New Point(767, 42)
        exitbtn.Margin = New Padding(3, 2, 3, 2)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(60, 60)
        exitbtn.SizeMode = PictureBoxSizeMode.StretchImage
        exitbtn.TabIndex = 37
        exitbtn.TabStop = False
        ' 
        ' week4mini
        ' 
        AutoScaleDimensions = New SizeF(12F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.menu1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(861, 661)
        Controls.Add(Button2)
        Controls.Add(backbtn)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(exitbtn)
        Controls.Add(HScrollBar1)
        Controls.Add(VScrollBar1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(lbl12)
        Controls.Add(lbl11)
        Controls.Add(lbl10)
        Controls.Add(ProgressBar1)
        Controls.Add(lbl9)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(lbl8)
        Controls.Add(CheckBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(lbl7)
        Controls.Add(RadioButton1)
        Controls.Add(lbl6)
        Controls.Add(ComboBox)
        Controls.Add(lbl5)
        Controls.Add(ListBox)
        Controls.Add(lbl2)
        Controls.Add(lbl4)
        Controls.Add(label)
        Controls.Add(Button)
        Controls.Add(lbl3)
        Controls.Add(TextBox)
        Controls.Add(form)
        Controls.Add(border)
        DoubleBuffered = True
        Font = New Font("rainyhearts", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Maroon
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        Name = "week4mini"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Output"
        CType(border, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(exitbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents form As Button
    Friend WithEvents TextBox As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents Button As Button
    Friend WithEvents border As PictureBox
    Friend WithEvents label As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents ListBox As ListBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lbl7 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Timer2 As Timer
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents exitbtn As PictureBox
End Class
