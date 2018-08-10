<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msgdspfrm
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
      Me.lbl = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'lbl
      '
      Me.lbl.AutoSize = True
      Me.lbl.BackColor = System.Drawing.Color.Transparent
      Me.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lbl.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbl.ForeColor = System.Drawing.Color.Blue
      Me.lbl.Location = New System.Drawing.Point(12, 9)
      Me.lbl.Name = "lbl"
      Me.lbl.Size = New System.Drawing.Size(0, 27)
      Me.lbl.TabIndex = 27
      Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'msgdspfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.White
      Me.ClientSize = New System.Drawing.Size(784, 51)
      Me.ControlBox = False
      Me.Controls.Add(Me.lbl)
      Me.Name = "msgdspfrm"
      Me.ShowInTaskbar = False
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents lbl As System.Windows.Forms.Label
End Class
