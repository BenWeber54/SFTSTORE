<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_password
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
      Me.cpassword = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.ipassword = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.bclose = New System.Windows.Forms.Button()
      Me.bok = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'cpassword
      '
      Me.cpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cpassword.Location = New System.Drawing.Point(185, 41)
      Me.cpassword.Name = "cpassword"
      Me.cpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.cpassword.Size = New System.Drawing.Size(168, 26)
      Me.cpassword.TabIndex = 112
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(7, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(158, 20)
      Me.Label2.TabIndex = 116
      Me.Label2.Text = "Confirm Password:"
      '
      'ipassword
      '
      Me.ipassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ipassword.Location = New System.Drawing.Point(185, 12)
      Me.ipassword.Name = "ipassword"
      Me.ipassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.ipassword.Size = New System.Drawing.Size(168, 26)
      Me.ipassword.TabIndex = 111
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(7, 15)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(179, 20)
      Me.Label1.TabIndex = 115
      Me.Label1.Text = "Enter New Password:"
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(370, 42)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(100, 27)
      Me.bclose.TabIndex = 114
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'bok
      '
      Me.bok.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bok.ForeColor = System.Drawing.Color.White
      Me.bok.Location = New System.Drawing.Point(370, 9)
      Me.bok.Name = "bok"
      Me.bok.Size = New System.Drawing.Size(100, 27)
      Me.bok.TabIndex = 113
      Me.bok.Text = "&Ok"
      Me.bok.UseVisualStyleBackColor = False
      '
      'login_password
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(492, 77)
      Me.ControlBox = False
      Me.Controls.Add(Me.cpassword)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.ipassword)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.bok)
      Me.Name = "login_password"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Password Reset"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cpassword As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents ipassword As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents bok As System.Windows.Forms.Button
End Class
