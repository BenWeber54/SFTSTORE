<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notes
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
      Me.bdelete = New System.Windows.Forms.Button()
      Me.bsave = New System.Windows.Forms.Button()
      Me.bopen = New System.Windows.Forms.Button()
      Me.detail = New System.Windows.Forms.TextBox()
      Me.lblDesc = New System.Windows.Forms.Label()
      Me.subject = New System.Windows.Forms.TextBox()
      Me.lblSubject = New System.Windows.Forms.Label()
      Me.bclose = New System.Windows.Forms.Button()
      Me.bnew = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'bdelete
      '
      Me.bdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bdelete.ForeColor = System.Drawing.Color.White
      Me.bdelete.Location = New System.Drawing.Point(595, 108)
      Me.bdelete.Name = "bdelete"
      Me.bdelete.Size = New System.Drawing.Size(156, 27)
      Me.bdelete.TabIndex = 41
      Me.bdelete.Text = "&Delete"
      Me.bdelete.UseVisualStyleBackColor = False
      '
      'bsave
      '
      Me.bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bsave.ForeColor = System.Drawing.Color.White
      Me.bsave.Location = New System.Drawing.Point(595, 74)
      Me.bsave.Name = "bsave"
      Me.bsave.Size = New System.Drawing.Size(156, 27)
      Me.bsave.TabIndex = 40
      Me.bsave.Text = "&Save"
      Me.bsave.UseVisualStyleBackColor = False
      '
      'bopen
      '
      Me.bopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bopen.ForeColor = System.Drawing.Color.White
      Me.bopen.Location = New System.Drawing.Point(595, 40)
      Me.bopen.Name = "bopen"
      Me.bopen.Size = New System.Drawing.Size(156, 27)
      Me.bopen.TabIndex = 39
      Me.bopen.Text = "&Open"
      Me.bopen.UseVisualStyleBackColor = False
      '
      'detail
      '
      Me.detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.detail.Location = New System.Drawing.Point(124, 36)
      Me.detail.Multiline = True
      Me.detail.Name = "detail"
      Me.detail.Size = New System.Drawing.Size(465, 249)
      Me.detail.TabIndex = 37
      '
      'lblDesc
      '
      Me.lblDesc.AutoSize = True
      Me.lblDesc.BackColor = System.Drawing.Color.Transparent
      Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDesc.Location = New System.Drawing.Point(10, 39)
      Me.lblDesc.Name = "lblDesc"
      Me.lblDesc.Size = New System.Drawing.Size(105, 20)
      Me.lblDesc.TabIndex = 44
      Me.lblDesc.Text = "Description:"
      '
      'subject
      '
      Me.subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.subject.Location = New System.Drawing.Point(124, 7)
      Me.subject.Name = "subject"
      Me.subject.Size = New System.Drawing.Size(465, 26)
      Me.subject.TabIndex = 36
      '
      'lblSubject
      '
      Me.lblSubject.AutoSize = True
      Me.lblSubject.BackColor = System.Drawing.Color.Transparent
      Me.lblSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSubject.Location = New System.Drawing.Point(10, 10)
      Me.lblSubject.Name = "lblSubject"
      Me.lblSubject.Size = New System.Drawing.Size(75, 20)
      Me.lblSubject.TabIndex = 43
      Me.lblSubject.Text = "Subject:"
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(595, 142)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 27)
      Me.bclose.TabIndex = 42
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'bnew
      '
      Me.bnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bnew.ForeColor = System.Drawing.Color.White
      Me.bnew.Location = New System.Drawing.Point(595, 6)
      Me.bnew.Name = "bnew"
      Me.bnew.Size = New System.Drawing.Size(156, 27)
      Me.bnew.TabIndex = 38
      Me.bnew.Text = "&New"
      Me.bnew.UseVisualStyleBackColor = False
      '
      'notes
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(761, 302)
      Me.ControlBox = False
      Me.Controls.Add(Me.bdelete)
      Me.Controls.Add(Me.bsave)
      Me.Controls.Add(Me.bopen)
      Me.Controls.Add(Me.detail)
      Me.Controls.Add(Me.lblDesc)
      Me.Controls.Add(Me.subject)
      Me.Controls.Add(Me.lblSubject)
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.bnew)
      Me.Name = "notes"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Notes"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents bdelete As System.Windows.Forms.Button
   Friend WithEvents bsave As System.Windows.Forms.Button
   Friend WithEvents bopen As System.Windows.Forms.Button
   Friend WithEvents detail As System.Windows.Forms.TextBox
   Friend WithEvents lblDesc As System.Windows.Forms.Label
   Friend WithEvents subject As System.Windows.Forms.TextBox
   Friend WithEvents lblSubject As System.Windows.Forms.Label
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents bnew As System.Windows.Forms.Button
End Class
