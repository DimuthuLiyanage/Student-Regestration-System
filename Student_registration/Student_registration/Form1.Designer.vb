<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboChangeUser = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboCurrentUserType = New System.Windows.Forms.ComboBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Privilage"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Change User "
        '
        'ComboChangeUser
        '
        Me.ComboChangeUser.FormattingEnabled = True
        Me.ComboChangeUser.Items.AddRange(New Object() {"Admin", "User"})
        Me.ComboChangeUser.Location = New System.Drawing.Point(244, 49)
        Me.ComboChangeUser.Name = "ComboChangeUser"
        Me.ComboChangeUser.Size = New System.Drawing.Size(162, 21)
        Me.ComboChangeUser.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Current User Type"
        '
        'ComboCurrentUserType
        '
        Me.ComboCurrentUserType.FormattingEnabled = True
        Me.ComboCurrentUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.ComboCurrentUserType.Location = New System.Drawing.Point(244, 187)
        Me.ComboCurrentUserType.Name = "ComboCurrentUserType"
        Me.ComboCurrentUserType.Size = New System.Drawing.Size(162, 21)
        Me.ComboCurrentUserType.TabIndex = 5
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(244, 119)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(162, 20)
        Me.TxtUserName.TabIndex = 6
        '
        'BtnChange
        '
        Me.BtnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChange.Location = New System.Drawing.Point(43, 267)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(98, 33)
        Me.BtnChange.TabIndex = 7
        Me.BtnChange.Text = "Change"
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(308, 267)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(98, 33)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 320)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.ComboCurrentUserType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboChangeUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboChangeUser As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboCurrentUserType As ComboBox
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents BtnChange As Button
    Friend WithEvents BtnClear As Button
End Class
