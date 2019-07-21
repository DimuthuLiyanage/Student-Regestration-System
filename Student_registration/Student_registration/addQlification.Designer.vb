<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addQlification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addQlification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpCourse = New System.Windows.Forms.GroupBox()
        Me.RadioHNDEN = New System.Windows.Forms.RadioButton()
        Me.RadioHNDIT = New System.Windows.Forms.RadioButton()
        Me.RadioHNDA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CombCommerce = New System.Windows.Forms.ComboBox()
        Me.Commerce = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextZscroce = New System.Windows.Forms.TextBox()
        Me.Zscroce = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.sub3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.sub2 = New System.Windows.Forms.Label()
        Me.sub1 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioPartTime = New System.Windows.Forms.RadioButton()
        Me.RadioFullTime = New System.Windows.Forms.RadioButton()
        Me.GrpCourse.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "English"
        '
        'GrpCourse
        '
        Me.GrpCourse.Controls.Add(Me.RadioHNDEN)
        Me.GrpCourse.Controls.Add(Me.RadioHNDA)
        Me.GrpCourse.Controls.Add(Me.RadioHNDIT)
        Me.GrpCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCourse.Location = New System.Drawing.Point(13, 85)
        Me.GrpCourse.Name = "GrpCourse"
        Me.GrpCourse.Size = New System.Drawing.Size(775, 67)
        Me.GrpCourse.TabIndex = 1
        Me.GrpCourse.TabStop = False
        Me.GrpCourse.Text = "Course"
        '
        'RadioHNDEN
        '
        Me.RadioHNDEN.AutoSize = True
        Me.RadioHNDEN.Location = New System.Drawing.Point(560, 28)
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
        Me.RadioHNDIT.Location = New System.Drawing.Point(341, 28)
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
        Me.RadioHNDA.Location = New System.Drawing.Point(141, 28)
        Me.RadioHNDA.Name = "RadioHNDA"
        Me.RadioHNDA.Size = New System.Drawing.Size(82, 28)
        Me.RadioHNDA.TabIndex = 0
        Me.RadioHNDA.TabStop = True
        Me.RadioHNDA.Text = "HNDA"
        Me.RadioHNDA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CombCommerce)
        Me.GroupBox1.Controls.Add(Me.Commerce)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "O/L"
        '
        'CombCommerce
        '
        Me.CombCommerce.FormattingEnabled = True
        Me.CombCommerce.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.CombCommerce.Location = New System.Drawing.Point(649, 40)
        Me.CombCommerce.Name = "CombCommerce"
        Me.CombCommerce.Size = New System.Drawing.Size(121, 32)
        Me.CombCommerce.TabIndex = 5
        '
        'Commerce
        '
        Me.Commerce.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Commerce.Location = New System.Drawing.Point(453, 42)
        Me.Commerce.Name = "Commerce"
        Me.Commerce.Size = New System.Drawing.Size(150, 30)
        Me.Commerce.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.ComboBox2.Location = New System.Drawing.Point(326, 58)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.ComboBox1.Location = New System.Drawing.Point(326, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mathermatics"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextZscroce)
        Me.GroupBox2.Controls.Add(Me.Zscroce)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.sub3)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.sub2)
        Me.GroupBox2.Controls.Add(Me.sub1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 195)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "A/L"
        '
        'TextZscroce
        '
        Me.TextZscroce.Location = New System.Drawing.Point(609, 76)
        Me.TextZscroce.Name = "TextZscroce"
        Me.TextZscroce.Size = New System.Drawing.Size(152, 29)
        Me.TextZscroce.TabIndex = 7
        '
        'Zscroce
        '
        Me.Zscroce.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zscroce.Location = New System.Drawing.Point(453, 75)
        Me.Zscroce.Name = "Zscroce"
        Me.Zscroce.Size = New System.Drawing.Size(150, 30)
        Me.Zscroce.TabIndex = 6
        Me.Zscroce.Text = "Z-score"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.ComboBox5.Location = New System.Drawing.Point(326, 123)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox5.TabIndex = 5
        '
        'sub3
        '
        Me.sub3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub3.Location = New System.Drawing.Point(70, 125)
        Me.sub3.Name = "sub3"
        Me.sub3.Size = New System.Drawing.Size(150, 30)
        Me.sub3.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.ComboBox3.Location = New System.Drawing.Point(326, 73)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox3.TabIndex = 3
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"A", "B", "C", "S", "W"})
        Me.ComboBox4.Location = New System.Drawing.Point(326, 23)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox4.TabIndex = 2
        '
        'sub2
        '
        Me.sub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub2.Location = New System.Drawing.Point(70, 75)
        Me.sub2.Name = "sub2"
        Me.sub2.Size = New System.Drawing.Size(150, 30)
        Me.sub2.TabIndex = 1
        '
        'sub1
        '
        Me.sub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub1.Location = New System.Drawing.Point(70, 25)
        Me.sub1.Name = "sub1"
        Me.sub1.Size = New System.Drawing.Size(150, 35)
        Me.sub1.TabIndex = 0
        Me.sub1.Tag = ""
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(348, 465)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(111, 43)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioPartTime)
        Me.GroupBox3.Controls.Add(Me.RadioFullTime)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 67)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Course Type"
        '
        'RadioPartTime
        '
        Me.RadioPartTime.AutoSize = True
        Me.RadioPartTime.Location = New System.Drawing.Point(456, 28)
        Me.RadioPartTime.Name = "RadioPartTime"
        Me.RadioPartTime.Size = New System.Drawing.Size(108, 28)
        Me.RadioPartTime.TabIndex = 1
        Me.RadioPartTime.TabStop = True
        Me.RadioPartTime.Text = "Part Time"
        Me.RadioPartTime.UseVisualStyleBackColor = True
        '
        'RadioFullTime
        '
        Me.RadioFullTime.AutoSize = True
        Me.RadioFullTime.Location = New System.Drawing.Point(188, 28)
        Me.RadioFullTime.Name = "RadioFullTime"
        Me.RadioFullTime.Size = New System.Drawing.Size(102, 28)
        Me.RadioFullTime.TabIndex = 0
        Me.RadioFullTime.TabStop = True
        Me.RadioFullTime.Text = "FullTime"
        Me.RadioFullTime.UseVisualStyleBackColor = True
        '
        'addQlification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 531)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpCourse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addQlification"
        Me.Text = "Add Qulfication"
        Me.GrpCourse.ResumeLayout(False)
        Me.GrpCourse.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GrpCourse As GroupBox
    Friend WithEvents RadioHNDEN As RadioButton
    Friend WithEvents RadioHNDIT As RadioButton
    Friend WithEvents RadioHNDA As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents sub3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents sub2 As Label
    Friend WithEvents sub1 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Submit As Button
    Friend WithEvents TextZscroce As TextBox
    Friend WithEvents Zscroce As Label
    Friend WithEvents CombCommerce As ComboBox
    Friend WithEvents Commerce As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioPartTime As RadioButton
    Friend WithEvents RadioFullTime As RadioButton
End Class
