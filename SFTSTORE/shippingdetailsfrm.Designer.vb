<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shippingdetailsfrm
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
      Me.lst = New System.Windows.Forms.ListView()
      Me.SuspendLayout
      '
      'tmr
      '
      Me.tmr.Enabled = true
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(102,Byte),Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(452, 420)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 27)
      Me.btnClose.TabIndex = 1
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.Location = New System.Drawing.Point(12, 12)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(997, 402)
      Me.lst.TabIndex = 143
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'shippingdetailsfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1021, 455)
      Me.ControlBox = False
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "shippingdetailsfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shipping Details"
      Me.ResumeLayout(false)

End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
End Class
