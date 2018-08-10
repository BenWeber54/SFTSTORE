<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users_rights
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
      Me.components = New System.ComponentModel.Container()
      Me.tmr = New System.Windows.Forms.Timer(Me.components)
      Me.bclose = New System.Windows.Forms.Button()
      Me.cb = New System.Windows.Forms.CheckedListBox()
      Me.buncheckall = New System.Windows.Forms.Button()
      Me.bcheckall = New System.Windows.Forms.Button()
      Me.bsamerights = New System.Windows.Forms.Button()
      Me.bok = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(386, 144)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 30)
      Me.bclose.TabIndex = 910
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'cb
      '
      Me.cb.CheckOnClick = True
      Me.cb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cb.FormattingEnabled = True
      Me.cb.Location = New System.Drawing.Point(12, 12)
      Me.cb.Name = "cb"
      Me.cb.Size = New System.Drawing.Size(368, 327)
      Me.cb.TabIndex = 905
      '
      'buncheckall
      '
      Me.buncheckall.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.buncheckall.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.buncheckall.ForeColor = System.Drawing.Color.White
      Me.buncheckall.Location = New System.Drawing.Point(386, 78)
      Me.buncheckall.Name = "buncheckall"
      Me.buncheckall.Size = New System.Drawing.Size(156, 30)
      Me.buncheckall.TabIndex = 908
      Me.buncheckall.Text = "&Uncheck All"
      Me.buncheckall.UseVisualStyleBackColor = False
      '
      'bcheckall
      '
      Me.bcheckall.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bcheckall.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bcheckall.ForeColor = System.Drawing.Color.White
      Me.bcheckall.Location = New System.Drawing.Point(386, 45)
      Me.bcheckall.Name = "bcheckall"
      Me.bcheckall.Size = New System.Drawing.Size(156, 30)
      Me.bcheckall.TabIndex = 907
      Me.bcheckall.Text = "Check &All"
      Me.bcheckall.UseVisualStyleBackColor = False
      '
      'bsamerights
      '
      Me.bsamerights.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bsamerights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bsamerights.ForeColor = System.Drawing.Color.White
      Me.bsamerights.Location = New System.Drawing.Point(386, 111)
      Me.bsamerights.Name = "bsamerights"
      Me.bsamerights.Size = New System.Drawing.Size(156, 30)
      Me.bsamerights.TabIndex = 909
      Me.bsamerights.Text = "&Select Same Rights"
      Me.bsamerights.UseVisualStyleBackColor = False
      '
      'bok
      '
      Me.bok.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bok.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bok.ForeColor = System.Drawing.Color.White
      Me.bok.Location = New System.Drawing.Point(386, 12)
      Me.bok.Name = "bok"
      Me.bok.Size = New System.Drawing.Size(156, 30)
      Me.bok.TabIndex = 906
      Me.bok.Text = "&OK"
      Me.bok.UseVisualStyleBackColor = False
      '
      'users_rights
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(553, 357)
      Me.ControlBox = False
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.cb)
      Me.Controls.Add(Me.buncheckall)
      Me.Controls.Add(Me.bcheckall)
      Me.Controls.Add(Me.bsamerights)
      Me.Controls.Add(Me.bok)
      Me.Name = "users_rights"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "User Rights"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents cb As System.Windows.Forms.CheckedListBox
   Friend WithEvents buncheckall As System.Windows.Forms.Button
   Friend WithEvents bcheckall As System.Windows.Forms.Button
   Friend WithEvents bsamerights As System.Windows.Forms.Button
   Friend WithEvents bok As System.Windows.Forms.Button
End Class
