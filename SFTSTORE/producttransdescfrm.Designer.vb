<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class producttransdescfrm
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
      Me.btnClose = New System.Windows.Forms.Button()
      Me.txtDesc = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(188, 324)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'txtDesc
      '
      Me.txtDesc.Enabled = False
      Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtDesc.ForeColor = System.Drawing.Color.Black
      Me.txtDesc.Location = New System.Drawing.Point(12, 5)
      Me.txtDesc.Multiline = True
      Me.txtDesc.Name = "txtDesc"
      Me.txtDesc.ReadOnly = True
      Me.txtDesc.Size = New System.Drawing.Size(501, 315)
      Me.txtDesc.TabIndex = 1020
      '
      'producttransdescfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(524, 358)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtDesc)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "producttransdescfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents txtDesc As System.Windows.Forms.TextBox
End Class
