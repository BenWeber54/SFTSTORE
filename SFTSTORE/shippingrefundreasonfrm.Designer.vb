<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shippingrefundreasonfrm
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
      Me.btnAccept = New System.Windows.Forms.Button()
      Me.txtReason = New System.Windows.Forms.TextBox()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'btnAccept
      '
      Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnAccept.ForeColor = System.Drawing.Color.White
      Me.btnAccept.Location = New System.Drawing.Point(107, 290)
      Me.btnAccept.Name = "btnAccept"
      Me.btnAccept.Size = New System.Drawing.Size(157, 30)
      Me.btnAccept.TabIndex = 100
      Me.btnAccept.Text = "&Accept"
      Me.btnAccept.UseVisualStyleBackColor = False
      '
      'txtReason
      '
      Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtReason.ForeColor = System.Drawing.Color.Black
      Me.txtReason.Location = New System.Drawing.Point(12, 12)
      Me.txtReason.MaxLength = 1024
      Me.txtReason.Multiline = True
      Me.txtReason.Name = "txtReason"
      Me.txtReason.Size = New System.Drawing.Size(511, 272)
      Me.txtReason.TabIndex = 1
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(270, 290)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(157, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Cancel"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'shippingrefundreasonfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(535, 327)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtReason)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnAccept)
      Me.Name = "shippingrefundreasonfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Refund Reason"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnAccept As System.Windows.Forms.Button
   Friend WithEvents txtReason As System.Windows.Forms.TextBox
   Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
