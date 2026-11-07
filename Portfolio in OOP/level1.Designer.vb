<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level1))
        Priest1 = New PictureBox()
        Boat = New PictureBox()
        Priest2 = New PictureBox()
        Priest3 = New PictureBox()
        Devil2 = New PictureBox()
        Devil3 = New PictureBox()
        Devil1 = New PictureBox()
        gobtn = New PictureBox()
        timerlbl = New Label()
        restartbtn = New PictureBox()
        CType(Priest1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Boat, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Priest3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Devil1, ComponentModel.ISupportInitialize).BeginInit()
        CType(gobtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(restartbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Priest1
        ' 
        Priest1.BackColor = Color.Transparent
        Priest1.Image = CType(resources.GetObject("Priest1.Image"), Image)
        Priest1.Location = New Point(693, 177)
        Priest1.Name = "Priest1"
        Priest1.Size = New Size(90, 93)
        Priest1.SizeMode = PictureBoxSizeMode.Zoom
        Priest1.TabIndex = 0
        Priest1.TabStop = False
        ' 
        ' Boat
        ' 
        Boat.BackColor = Color.Transparent
        Boat.Image = CType(resources.GetObject("Boat.Image"), Image)
        Boat.Location = New Point(456, 397)
        Boat.Name = "Boat"
        Boat.Size = New Size(210, 76)
        Boat.SizeMode = PictureBoxSizeMode.Zoom
        Boat.TabIndex = 6
        Boat.TabStop = False
        ' 
        ' Priest2
        ' 
        Priest2.BackColor = Color.Transparent
        Priest2.Image = CType(resources.GetObject("Priest2.Image"), Image)
        Priest2.Location = New Point(693, 296)
        Priest2.Name = "Priest2"
        Priest2.Size = New Size(90, 93)
        Priest2.SizeMode = PictureBoxSizeMode.Zoom
        Priest2.TabIndex = 7
        Priest2.TabStop = False
        ' 
        ' Priest3
        ' 
        Priest3.BackColor = Color.Transparent
        Priest3.Image = CType(resources.GetObject("Priest3.Image"), Image)
        Priest3.Location = New Point(693, 426)
        Priest3.Name = "Priest3"
        Priest3.Size = New Size(90, 93)
        Priest3.SizeMode = PictureBoxSizeMode.Zoom
        Priest3.TabIndex = 8
        Priest3.TabStop = False
        ' 
        ' Devil2
        ' 
        Devil2.BackColor = Color.Transparent
        Devil2.Image = CType(resources.GetObject("Devil2.Image"), Image)
        Devil2.Location = New Point(835, 296)
        Devil2.Name = "Devil2"
        Devil2.Size = New Size(90, 93)
        Devil2.SizeMode = PictureBoxSizeMode.Zoom
        Devil2.TabIndex = 9
        Devil2.TabStop = False
        ' 
        ' Devil3
        ' 
        Devil3.BackColor = Color.Transparent
        Devil3.Image = CType(resources.GetObject("Devil3.Image"), Image)
        Devil3.Location = New Point(835, 426)
        Devil3.Name = "Devil3"
        Devil3.Size = New Size(90, 93)
        Devil3.SizeMode = PictureBoxSizeMode.Zoom
        Devil3.TabIndex = 10
        Devil3.TabStop = False
        ' 
        ' Devil1
        ' 
        Devil1.BackColor = Color.Transparent
        Devil1.Image = CType(resources.GetObject("Devil1.Image"), Image)
        Devil1.Location = New Point(835, 177)
        Devil1.Name = "Devil1"
        Devil1.Size = New Size(90, 93)
        Devil1.SizeMode = PictureBoxSizeMode.Zoom
        Devil1.TabIndex = 10
        Devil1.TabStop = False
        ' 
        ' gobtn
        ' 
        gobtn.BackColor = Color.Transparent
        gobtn.Cursor = Cursors.Hand
        gobtn.Image = CType(resources.GetObject("gobtn.Image"), Image)
        gobtn.Location = New Point(405, 45)
        gobtn.Name = "gobtn"
        gobtn.Size = New Size(160, 83)
        gobtn.SizeMode = PictureBoxSizeMode.Zoom
        gobtn.TabIndex = 11
        gobtn.TabStop = False
        ' 
        ' timerlbl
        ' 
        timerlbl.AutoSize = True
        timerlbl.BackColor = Color.Transparent
        timerlbl.Font = New Font("rainyhearts", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timerlbl.ForeColor = Color.Maroon
        timerlbl.Location = New Point(693, 45)
        timerlbl.Name = "timerlbl"
        timerlbl.Size = New Size(279, 45)
        timerlbl.TabIndex = 12
        timerlbl.Text = "Time Left: 60"
        ' 
        ' restartbtn
        ' 
        restartbtn.BackColor = Color.Transparent
        restartbtn.Cursor = Cursors.Hand
        restartbtn.Image = CType(resources.GetObject("restartbtn.Image"), Image)
        restartbtn.Location = New Point(30, 45)
        restartbtn.Name = "restartbtn"
        restartbtn.Size = New Size(177, 75)
        restartbtn.SizeMode = PictureBoxSizeMode.Zoom
        restartbtn.TabIndex = 13
        restartbtn.TabStop = False
        ' 
        ' level1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(984, 661)
        Controls.Add(restartbtn)
        Controls.Add(timerlbl)
        Controls.Add(gobtn)
        Controls.Add(Devil1)
        Controls.Add(Devil3)
        Controls.Add(Devil2)
        Controls.Add(Priest3)
        Controls.Add(Priest2)
        Controls.Add(Priest1)
        Controls.Add(Boat)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "level1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Level 1 - Priests -n- Devils"
        CType(Priest1, ComponentModel.ISupportInitialize).EndInit()
        CType(Boat, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest2, ComponentModel.ISupportInitialize).EndInit()
        CType(Priest3, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil2, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil3, ComponentModel.ISupportInitialize).EndInit()
        CType(Devil1, ComponentModel.ISupportInitialize).EndInit()
        CType(gobtn, ComponentModel.ISupportInitialize).EndInit()
        CType(restartbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Priest1 As PictureBox
    Friend WithEvents Boat As PictureBox
    Friend WithEvents Priest2 As PictureBox
    Friend WithEvents Priest3 As PictureBox
    Friend WithEvents Devil2 As PictureBox
    Friend WithEvents Devil3 As PictureBox
    Friend WithEvents Devil1 As PictureBox
    Friend WithEvents gobtn As PictureBox
    Friend WithEvents timerlbl As Label
    Friend WithEvents restartbtn As PictureBox
End Class
