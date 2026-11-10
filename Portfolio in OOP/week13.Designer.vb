<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class week13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(week13))
        pb1 = New PictureBox()
        pb2 = New PictureBox()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl6 = New Label()
        lbl7 = New Label()
        lbl8 = New Label()
        txtCropId = New TextBox()
        txtType = New TextBox()
        txtCropName = New TextBox()
        txtSeedCost = New TextBox()
        txtGrowth = New TextBox()
        txtSellCost = New TextBox()
        btnCreate = New PictureBox()
        btnRead = New PictureBox()
        btnUpdate = New PictureBox()
        btnDelete = New PictureBox()
        DataGridView1 = New DataGridView()
        backbtn = New PictureBox()
        CType(pb1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pb2, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnCreate, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnRead, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnUpdate, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb2 (Left Board: Crop Details)
        ' 
        pb2.Image = My.Resources.Resources.menu1
        pb2.Location = New Point(29, 166)
        pb2.Name = "pb2"
        pb2.Size = New Size(506, 424)
        pb2.SizeMode = PictureBoxSizeMode.StretchImage
        pb2.TabIndex = 1
        pb2.TabStop = False
        ' 
        ' lbl1 (Crop Details)
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.Transparent
        lbl1.Font = New Font("rainyhearts", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl1.ForeColor = Color.Brown
        lbl1.Location = New Point(148, 20)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(211, 35)
        lbl1.TabIndex = 0
        lbl1.Text = "Crop Details"
        ' 
        ' lbl2 (Crop ID)
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.Transparent
        lbl2.Font = New Font("rainyhearts", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl2.ForeColor = Color.Brown
        lbl2.Location = New Point(45, 62)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(94, 22)
        lbl2.TabIndex = 1
        lbl2.Text = "Crop ID"
        ' 
        ' txtCropId
        ' 
        txtCropId.BackColor = Color.BlanchedAlmond
        txtCropId.BorderStyle = BorderStyle.None
        txtCropId.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCropId.ForeColor = Color.Brown
        txtCropId.Location = New Point(195, 60)
        txtCropId.Multiline = True
        txtCropId.Name = "txtCropId"
        txtCropId.Size = New Size(255, 26)
        txtCropId.TabIndex = 2
        ' 
        ' lbl3 (Type)
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.Transparent
        lbl3.Font = New Font("rainyhearts", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl3.ForeColor = Color.Brown
        lbl3.Location = New Point(45, 96)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(58, 22)
        lbl3.TabIndex = 3
        lbl3.Text = "Type"
        ' 
        ' txtType
        ' 
        txtType.BackColor = Color.BlanchedAlmond
        txtType.BorderStyle = BorderStyle.None
        txtType.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtType.ForeColor = Color.Brown
        txtType.Location = New Point(195, 94)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.Size = New Size(255, 26)
        txtType.TabIndex = 4
        ' 
        ' lbl4 (Crop Name)
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.Transparent
        lbl4.Font = New Font("rainyhearts", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl4.ForeColor = Color.Brown
        lbl4.Location = New Point(45, 130)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(122, 22)
        lbl4.TabIndex = 5
        lbl4.Text = "Crop Name"
        ' 
        ' txtCropName
        ' 
        txtCropName.BackColor = Color.BlanchedAlmond
        txtCropName.BorderStyle = BorderStyle.None
        txtCropName.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCropName.ForeColor = Color.Brown
        txtCropName.Location = New Point(195, 128)
        txtCropName.Multiline = True
        txtCropName.Name = "txtCropName"
        txtCropName.Size = New Size(255, 26)
        txtCropName.TabIndex = 6
        ' 
        ' lbl5 (Seed Cost)
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = Color.Transparent
        lbl5.Font = New Font("rainyhearts", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl5.ForeColor = Color.Brown
        lbl5.Location = New Point(45, 164)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(111, 22)
        lbl5.TabIndex = 7
        lbl5.Text = "Seed Cost"
        ' 
        ' txtSeedCost
        ' 
        txtSeedCost.BackColor = Color.BlanchedAlmond
        txtSeedCost.BorderStyle = BorderStyle.None
        txtSeedCost.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSeedCost.ForeColor = Color.Brown
        txtSeedCost.Location = New Point(195, 162)
        txtSeedCost.Multiline = True
        txtSeedCost.Name = "txtSeedCost"
        txtSeedCost.Size = New Size(255, 26)
        txtSeedCost.TabIndex = 8
        ' 
        ' lbl6 (Days of Growth)
        ' 
        lbl6.AutoSize = True
        lbl6.BackColor = Color.Transparent
        lbl6.Font = New Font("rainyhearts", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl6.ForeColor = Color.Brown
        lbl6.Location = New Point(45, 198)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(147, 19)
        lbl6.TabIndex = 9
        lbl6.Text = "Days of Growth"
        ' 
        ' txtGrowth
        ' 
        txtGrowth.BackColor = Color.BlanchedAlmond
        txtGrowth.BorderStyle = BorderStyle.None
        txtGrowth.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGrowth.ForeColor = Color.Brown
        txtGrowth.Location = New Point(195, 196)
        txtGrowth.Multiline = True
        txtGrowth.Name = "txtGrowth"
        txtGrowth.Size = New Size(255, 26)
        txtGrowth.TabIndex = 10
        ' 
        ' lbl7 (Sell Cost)
        ' 
        lbl7.AutoSize = True
        lbl7.BackColor = Color.Transparent
        lbl7.Font = New Font("rainyhearts", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl7.ForeColor = Color.Brown
        lbl7.Location = New Point(45, 232)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(106, 22)
        lbl7.TabIndex = 11
        lbl7.Text = "Sell Cost"
        ' 
        ' txtSellCost
        ' 
        txtSellCost.BackColor = Color.BlanchedAlmond
        txtSellCost.BorderStyle = BorderStyle.None
        txtSellCost.Font = New Font("rainyhearts", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSellCost.ForeColor = Color.Brown
        txtSellCost.Location = New Point(195, 230)
        txtSellCost.Multiline = True
        txtSellCost.Name = "txtSellCost"
        txtSellCost.Size = New Size(255, 26)
        txtSellCost.TabIndex = 12
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.Transparent
        btnCreate.Cursor = Cursors.Hand
        btnCreate.Image = My.Resources.Resources.create
        btnCreate.Location = New Point(55, 276)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(175, 48)
        btnCreate.SizeMode = PictureBoxSizeMode.StretchImage
        btnCreate.TabIndex = 13
        btnCreate.TabStop = False
        ' 
        ' btnRead
        ' 
        btnRead.BackColor = Color.Transparent
        btnRead.Cursor = Cursors.Hand
        btnRead.Image = My.Resources.Resources.read
        btnRead.Location = New Point(275, 276)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(175, 48)
        btnRead.SizeMode = PictureBoxSizeMode.StretchImage
        btnRead.TabIndex = 14
        btnRead.TabStop = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Transparent
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Image = My.Resources.Resources.update
        btnUpdate.Location = New Point(55, 336)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(175, 48)
        btnUpdate.SizeMode = PictureBoxSizeMode.StretchImage
        btnUpdate.TabIndex = 15
        btnUpdate.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Transparent
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(275, 336)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(175, 48)
        btnDelete.SizeMode = PictureBoxSizeMode.StretchImage
        btnDelete.TabIndex = 16
        btnDelete.TabStop = False
        ' 
        ' pb1 (Right Board: Farm)
        ' 
        pb1.Image = My.Resources.Resources.menu1
        pb1.Location = New Point(552, 166)
        pb1.Name = "pb1"
        pb1.Size = New Size(607, 424)
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.TabIndex = 0
        pb1.TabStop = False
        ' 
        ' lbl8 (Farm)
        ' 
        lbl8.AutoSize = True
        lbl8.BackColor = Color.Transparent
        lbl8.Font = New Font("rainyhearts", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl8.ForeColor = Color.Brown
        lbl8.Location = New Point(35, 20)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(94, 35)
        lbl8.TabIndex = 0
        lbl8.Text = "Farm"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = Color.NavajoWhite
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(35, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(537, 320)
        DataGridView1.TabIndex = 1
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.Transparent
        backbtn.BackgroundImage = My.Resources.Resources.backbtn
        backbtn.BackgroundImageLayout = ImageLayout.Zoom
        backbtn.Cursor = Cursors.Hand
        backbtn.Location = New Point(38, 58)
        backbtn.Margin = New Padding(3, 2, 3, 2)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(55, 53)
        backbtn.TabIndex = 40
        backbtn.TabStop = False
        ' 
        ' week13
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg4
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 611)
        Controls.Add(backbtn)
        Controls.Add(pb2)
        Controls.Add(pb1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "week13"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "wk13"
        CType(pb1, ComponentModel.ISupportInitialize).EndInit()
        CType(pb2, ComponentModel.ISupportInitialize).EndInit()
        CType(btnCreate, ComponentModel.ISupportInitialize).EndInit()
        CType(btnRead, ComponentModel.ISupportInitialize).EndInit()
        CType(btnUpdate, ComponentModel.ISupportInitialize).EndInit()
        CType(btnDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(backbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents backbtn As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents btnCreate As PictureBox
    Friend WithEvents btnRead As PictureBox
    Friend WithEvents btnUpdate As PictureBox
    Friend WithEvents btnDelete As PictureBox
    Friend WithEvents txtCropId As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtCropName As TextBox
    Friend WithEvents txtSeedCost As TextBox
    Friend WithEvents txtGrowth As TextBox
    Friend WithEvents txtSellCost As TextBox
    Friend WithEvents DataGridView1 As DataGridView

    Friend Property PictureBox1 As PictureBox
        Get
            Return pb1
        End Get
        Set(value As PictureBox)
            pb1 = value
        End Set
    End Property

    Friend Property PictureBox2 As PictureBox
        Get
            Return pb2
        End Get
        Set(value As PictureBox)
            pb2 = value
        End Set
    End Property

    Friend Property PictureBox3 As PictureBox
        Get
            Return btnCreate
        End Get
        Set(value As PictureBox)
            btnCreate = value
        End Set
    End Property

    Friend Property PictureBox4 As PictureBox
        Get
            Return btnUpdate
        End Get
        Set(value As PictureBox)
            btnUpdate = value
        End Set
    End Property

    Friend Property PictureBox5 As PictureBox
        Get
            Return btnRead
        End Get
        Set(value As PictureBox)
            btnRead = value
        End Set
    End Property

    Friend Property PictureBox6 As PictureBox
        Get
            Return btnDelete
        End Get
        Set(value As PictureBox)
            btnDelete = value
        End Set
    End Property

    Friend Property PictureBox7 As PictureBox
        Get
            Return backbtn
        End Get
        Set(value As PictureBox)
            backbtn = value
        End Set
    End Property

    Friend Property Label1 As Label
        Get
            Return lbl1
        End Get
        Set(value As Label)
            lbl1 = value
        End Set
    End Property

    Friend Property Label2 As Label
        Get
            Return lbl8
        End Get
        Set(value As Label)
            lbl8 = value
        End Set
    End Property

    Friend Property TextBox1 As TextBox
        Get
            Return txtCropName
        End Get
        Set(value As TextBox)
            txtCropName = value
        End Set
    End Property

    Friend Property TextBox2 As TextBox
        Get
            Return txtType
        End Get
        Set(value As TextBox)
            txtType = value
        End Set
    End Property
End Class