<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterviewLatter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterviewLatter))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrpCourse = New System.Windows.Forms.GroupBox()
        Me.RadioHNDEN = New System.Windows.Forms.RadioButton()
        Me.RadioHNDIT = New System.Windows.Forms.RadioButton()
        Me.RadioHNDA = New System.Windows.Forms.RadioButton()
        Me.BtnPrintLatter = New System.Windows.Forms.Button()
        Me.GrpResult = New System.Windows.Forms.GroupBox()
        Me.RadioAllLatters = New System.Windows.Forms.RadioButton()
        Me.RadioSingleLatter = New System.Windows.Forms.RadioButton()
        Me.GroupStudent = New System.Windows.Forms.GroupBox()
        Me.IndexNumberTxt = New System.Windows.Forms.TextBox()
        Me.StudentNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IndexNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdderssLine1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdderssLine2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterwiewDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCourse.SuspendLayout()
        Me.GrpResult.SuspendLayout()
        Me.GroupStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexNum, Me.StuName, Me.AdderssLine1, Me.AdderssLine2, Me.City, Me.Course, Me.InterwiewDate})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 394)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 44)
        Me.DataGridView1.TabIndex = 16
        '
        'GrpCourse
        '
        Me.GrpCourse.Controls.Add(Me.RadioHNDEN)
        Me.GrpCourse.Controls.Add(Me.RadioHNDIT)
        Me.GrpCourse.Controls.Add(Me.RadioHNDA)
        Me.GrpCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCourse.Location = New System.Drawing.Point(13, 7)
        Me.GrpCourse.Name = "GrpCourse"
        Me.GrpCourse.Size = New System.Drawing.Size(775, 81)
        Me.GrpCourse.TabIndex = 15
        Me.GrpCourse.TabStop = False
        Me.GrpCourse.Text = "Course"
        '
        'RadioHNDEN
        '
        Me.RadioHNDEN.AutoSize = True
        Me.RadioHNDEN.Location = New System.Drawing.Point(579, 28)
        Me.RadioHNDEN.Name = "RadioHNDEN"
        Me.RadioHNDEN.Size = New System.Drawing.Size(96, 28)
        Me.RadioHNDEN.TabIndex = 2
        Me.RadioHNDEN.TabStop = True
        Me.RadioHNDEN.Text = "HNDEN"
        Me.RadioHNDEN.UseVisualStyleBackColor = True
        '
        'RadioHNDIT
        '
        Me.RadioHNDIT.AutoSize = True
        Me.RadioHNDIT.Location = New System.Drawing.Point(342, 29)
        Me.RadioHNDIT.Name = "RadioHNDIT"
        Me.RadioHNDIT.Size = New System.Drawing.Size(85, 28)
        Me.RadioHNDIT.TabIndex = 1
        Me.RadioHNDIT.TabStop = True
        Me.RadioHNDIT.Text = "HNDIT"
        Me.RadioHNDIT.UseVisualStyleBackColor = True
        '
        'RadioHNDA
        '
        Me.RadioHNDA.AutoSize = True
        Me.RadioHNDA.Location = New System.Drawing.Point(87, 29)
        Me.RadioHNDA.Name = "RadioHNDA"
        Me.RadioHNDA.Size = New System.Drawing.Size(82, 28)
        Me.RadioHNDA.TabIndex = 0
        Me.RadioHNDA.TabStop = True
        Me.RadioHNDA.Text = "HNDA"
        Me.RadioHNDA.UseVisualStyleBackColor = True
        '
        'BtnPrintLatter
        '
        Me.BtnPrintLatter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintLatter.Location = New System.Drawing.Point(320, 289)
        Me.BtnPrintLatter.Name = "BtnPrintLatter"
        Me.BtnPrintLatter.Size = New System.Drawing.Size(162, 68)
        Me.BtnPrintLatter.TabIndex = 14
        Me.BtnPrintLatter.Text = "Print Latter"
        Me.BtnPrintLatter.UseVisualStyleBackColor = True
        '
        'GrpResult
        '
        Me.GrpResult.Controls.Add(Me.RadioAllLatters)
        Me.GrpResult.Controls.Add(Me.RadioSingleLatter)
        Me.GrpResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpResult.Location = New System.Drawing.Point(12, 94)
        Me.GrpResult.Name = "GrpResult"
        Me.GrpResult.Size = New System.Drawing.Size(776, 83)
        Me.GrpResult.TabIndex = 13
        Me.GrpResult.TabStop = False
        Me.GrpResult.Text = "Results"
        '
        'RadioAllLatters
        '
        Me.RadioAllLatters.AutoSize = True
        Me.RadioAllLatters.Location = New System.Drawing.Point(451, 35)
        Me.RadioAllLatters.Name = "RadioAllLatters"
        Me.RadioAllLatters.Size = New System.Drawing.Size(108, 28)
        Me.RadioAllLatters.TabIndex = 5
        Me.RadioAllLatters.TabStop = True
        Me.RadioAllLatters.Text = "All Latters"
        Me.RadioAllLatters.UseVisualStyleBackColor = True
        '
        'RadioSingleLatter
        '
        Me.RadioSingleLatter.AutoSize = True
        Me.RadioSingleLatter.Location = New System.Drawing.Point(132, 35)
        Me.RadioSingleLatter.Name = "RadioSingleLatter"
        Me.RadioSingleLatter.Size = New System.Drawing.Size(131, 28)
        Me.RadioSingleLatter.TabIndex = 4
        Me.RadioSingleLatter.TabStop = True
        Me.RadioSingleLatter.Text = "Single Latter"
        Me.RadioSingleLatter.UseVisualStyleBackColor = True
        '
        'GroupStudent
        '
        Me.GroupStudent.Controls.Add(Me.IndexNumberTxt)
        Me.GroupStudent.Controls.Add(Me.StudentNameTxt)
        Me.GroupStudent.Controls.Add(Me.Label2)
        Me.GroupStudent.Controls.Add(Me.Label1)
        Me.GroupStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStudent.Location = New System.Drawing.Point(13, 183)
        Me.GroupStudent.Name = "GroupStudent"
        Me.GroupStudent.Size = New System.Drawing.Size(776, 100)
        Me.GroupStudent.TabIndex = 12
        Me.GroupStudent.TabStop = False
        Me.GroupStudent.Text = "Student"
        '
        'IndexNumberTxt
        '
        Me.IndexNumberTxt.Location = New System.Drawing.Point(536, 34)
        Me.IndexNumberTxt.Name = "IndexNumberTxt"
        Me.IndexNumberTxt.Size = New System.Drawing.Size(172, 29)
        Me.IndexNumberTxt.TabIndex = 4
        '
        'StudentNameTxt
        '
        Me.StudentNameTxt.Location = New System.Drawing.Point(201, 34)
        Me.StudentNameTxt.Name = "StudentNameTxt"
        Me.StudentNameTxt.Size = New System.Drawing.Size(172, 29)
        Me.StudentNameTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IndexNumber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name"
        '
        'IndexNum
        '
        Me.IndexNum.HeaderText = "Index Number"
        Me.IndexNum.Name = "IndexNum"
        Me.IndexNum.ReadOnly = True
        '
        'StuName
        '
        Me.StuName.HeaderText = "Student Name"
        Me.StuName.Name = "StuName"
        Me.StuName.ReadOnly = True
        '
        'AdderssLine1
        '
        Me.AdderssLine1.HeaderText = "Adderss line 1"
        Me.AdderssLine1.Name = "AdderssLine1"
        Me.AdderssLine1.ReadOnly = True
        '
        'AdderssLine2
        '
        Me.AdderssLine2.HeaderText = "adderss Line 2"
        Me.AdderssLine2.Name = "AdderssLine2"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'Course
        '
        Me.Course.HeaderText = "course"
        Me.Course.Name = "Course"
        Me.Course.ReadOnly = True
        '
        'InterwiewDate
        '
        Me.InterwiewDate.HeaderText = "Interview Date"
        Me.InterwiewDate.Name = "InterwiewDate"
        Me.InterwiewDate.ReadOnly = True
        '
        'InterviewLatter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrpCourse)
        Me.Controls.Add(Me.BtnPrintLatter)
        Me.Controls.Add(Me.GrpResult)
        Me.Controls.Add(Me.GroupStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InterviewLatter"
        Me.Text = "Interview Latter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCourse.ResumeLayout(False)
        Me.GrpCourse.PerformLayout()
        Me.GrpResult.ResumeLayout(False)
        Me.GrpResult.PerformLayout()
        Me.GroupStudent.ResumeLayout(False)
        Me.GroupStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GrpCourse As GroupBox
    Friend WithEvents RadioHNDEN As RadioButton
    Friend WithEvents RadioHNDIT As RadioButton
    Friend WithEvents RadioHNDA As RadioButton
    Friend WithEvents BtnPrintLatter As Button
    Friend WithEvents GrpResult As GroupBox
    Friend WithEvents RadioAllLatters As RadioButton
    Friend WithEvents RadioSingleLatter As RadioButton
    Friend WithEvents GroupStudent As GroupBox
    Friend WithEvents IndexNumberTxt As TextBox
    Friend WithEvents StudentNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IndexNum As DataGridViewTextBoxColumn
    Friend WithEvents StuName As DataGridViewTextBoxColumn
    Friend WithEvents AdderssLine1 As DataGridViewTextBoxColumn
    Friend WithEvents AdderssLine2 As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents InterwiewDate As DataGridViewTextBoxColumn
End Class
