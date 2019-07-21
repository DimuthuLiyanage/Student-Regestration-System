<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintAdmmition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintAdmmition))
        Me.GroupCourse = New System.Windows.Forms.GroupBox()
        Me.RadioHNDA = New System.Windows.Forms.RadioButton()
        Me.RadioHNDIT = New System.Windows.Forms.RadioButton()
        Me.RadioHNDEN = New System.Windows.Forms.RadioButton()
        Me.GroupSelectPrint = New System.Windows.Forms.GroupBox()
        Me.printSingleAdmition = New System.Windows.Forms.RadioButton()
        Me.AllAdmition = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.TextStudentNumber = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GroupCourse.SuspendLayout()
        Me.GroupSelectPrint.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupCourse
        '
        Me.GroupCourse.Controls.Add(Me.RadioHNDEN)
        Me.GroupCourse.Controls.Add(Me.RadioHNDIT)
        Me.GroupCourse.Controls.Add(Me.RadioHNDA)
        Me.GroupCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCourse.Location = New System.Drawing.Point(12, 12)
        Me.GroupCourse.Name = "GroupCourse"
        Me.GroupCourse.Size = New System.Drawing.Size(776, 100)
        Me.GroupCourse.TabIndex = 0
        Me.GroupCourse.TabStop = False
        Me.GroupCourse.Text = "Select Course"
        '
        'RadioHNDA
        '
        Me.RadioHNDA.AutoSize = True
        Me.RadioHNDA.Location = New System.Drawing.Point(112, 41)
        Me.RadioHNDA.Name = "RadioHNDA"
        Me.RadioHNDA.Size = New System.Drawing.Size(82, 28)
        Me.RadioHNDA.TabIndex = 0
        Me.RadioHNDA.TabStop = True
        Me.RadioHNDA.Text = "HNDA"
        Me.RadioHNDA.UseVisualStyleBackColor = True
        '
        'RadioHNDIT
        '
        Me.RadioHNDIT.AutoSize = True
        Me.RadioHNDIT.Location = New System.Drawing.Point(352, 41)
        Me.RadioHNDIT.Name = "RadioHNDIT"
        Me.RadioHNDIT.Size = New System.Drawing.Size(85, 28)
        Me.RadioHNDIT.TabIndex = 1
        Me.RadioHNDIT.TabStop = True
        Me.RadioHNDIT.Text = "HNDIT"
        Me.RadioHNDIT.UseVisualStyleBackColor = True
        '
        'RadioHNDEN
        '
        Me.RadioHNDEN.AutoSize = True
        Me.RadioHNDEN.Location = New System.Drawing.Point(597, 41)
        Me.RadioHNDEN.Name = "RadioHNDEN"
        Me.RadioHNDEN.Size = New System.Drawing.Size(96, 28)
        Me.RadioHNDEN.TabIndex = 2
        Me.RadioHNDEN.TabStop = True
        Me.RadioHNDEN.Text = "HNDEN"
        Me.RadioHNDEN.UseVisualStyleBackColor = True
        '
        'GroupSelectPrint
        '
        Me.GroupSelectPrint.Controls.Add(Me.TextStudentNumber)
        Me.GroupSelectPrint.Controls.Add(Me.lblEnter)
        Me.GroupSelectPrint.Controls.Add(Me.AllAdmition)
        Me.GroupSelectPrint.Controls.Add(Me.printSingleAdmition)
        Me.GroupSelectPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupSelectPrint.Location = New System.Drawing.Point(13, 131)
        Me.GroupSelectPrint.Name = "GroupSelectPrint"
        Me.GroupSelectPrint.Size = New System.Drawing.Size(775, 142)
        Me.GroupSelectPrint.TabIndex = 1
        Me.GroupSelectPrint.TabStop = False
        Me.GroupSelectPrint.Text = "Print Select"
        '
        'printSingleAdmition
        '
        Me.printSingleAdmition.AutoSize = True
        Me.printSingleAdmition.Location = New System.Drawing.Point(120, 40)
        Me.printSingleAdmition.Name = "printSingleAdmition"
        Me.printSingleAdmition.Size = New System.Drawing.Size(202, 28)
        Me.printSingleAdmition.TabIndex = 1
        Me.printSingleAdmition.TabStop = True
        Me.printSingleAdmition.Text = "Print Single Admition"
        Me.printSingleAdmition.UseVisualStyleBackColor = True
        '
        'AllAdmition
        '
        Me.AllAdmition.AutoSize = True
        Me.AllAdmition.Location = New System.Drawing.Point(414, 40)
        Me.AllAdmition.Name = "AllAdmition"
        Me.AllAdmition.Size = New System.Drawing.Size(179, 28)
        Me.AllAdmition.TabIndex = 2
        Me.AllAdmition.TabStop = True
        Me.AllAdmition.Text = "Print All Admitions"
        Me.AllAdmition.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentName, Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(277, 414)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 45)
        Me.DataGridView1.TabIndex = 2
        '
        'StudentName
        '
        Me.StudentName.HeaderText = "Student Name"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Index Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(154, 89)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(198, 24)
        Me.lblEnter.TabIndex = 3
        Me.lblEnter.Text = "Enter Student Number"
        '
        'TextStudentNumber
        '
        Me.TextStudentNumber.Location = New System.Drawing.Point(398, 86)
        Me.TextStudentNumber.Name = "TextStudentNumber"
        Me.TextStudentNumber.Size = New System.Drawing.Size(182, 29)
        Me.TextStudentNumber.TabIndex = 4
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(292, 303)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(211, 62)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PrintAdmmition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 547)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupSelectPrint)
        Me.Controls.Add(Me.GroupCourse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrintAdmmition"
        Me.Text = "Print Admition"
        Me.GroupCourse.ResumeLayout(False)
        Me.GroupCourse.PerformLayout()
        Me.GroupSelectPrint.ResumeLayout(False)
        Me.GroupSelectPrint.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupCourse As GroupBox
    Friend WithEvents RadioHNDEN As RadioButton
    Friend WithEvents RadioHNDIT As RadioButton
    Friend WithEvents RadioHNDA As RadioButton
    Friend WithEvents GroupSelectPrint As GroupBox
    Friend WithEvents AllAdmition As RadioButton
    Friend WithEvents printSingleAdmition As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentName As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TextStudentNumber As TextBox
    Friend WithEvents lblEnter As Label
    Friend WithEvents BtnPrint As Button
End Class
