<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productimageorderfrm
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
      Me.bclose = New System.Windows.Forms.Button()
      Me.btnUp = New System.Windows.Forms.Button()
      Me.btnDown = New System.Windows.Forms.Button()
      Me.lst = New System.Windows.Forms.ListView()
      Me.SuspendLayout()
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(641, 82)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 30)
      Me.bclose.TabIndex = 142
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'btnUp
      '
      Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnUp.ForeColor = System.Drawing.Color.White
      Me.btnUp.Location = New System.Drawing.Point(641, 10)
      Me.btnUp.Name = "btnUp"
      Me.btnUp.Size = New System.Drawing.Size(156, 30)
      Me.btnUp.TabIndex = 141
      Me.btnUp.Text = "Shift &Up"
      Me.btnUp.UseVisualStyleBackColor = False
      '
      'btnDown
      '
      Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDown.ForeColor = System.Drawing.Color.White
      Me.btnDown.Location = New System.Drawing.Point(641, 46)
      Me.btnDown.Name = "btnDown"
      Me.btnDown.Size = New System.Drawing.Size(156, 30)
      Me.btnDown.TabIndex = 141
      Me.btnDown.Text = "Shift &Down"
      Me.btnDown.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.HideSelection = False
      Me.lst.Location = New System.Drawing.Point(12, 10)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(623, 509)
      Me.lst.TabIndex = 1
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'productimageorderfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(804, 531)
      Me.ControlBox = False
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnDown)
      Me.Controls.Add(Me.btnUp)
      Me.Controls.Add(Me.bclose)
      Me.Name = "productimageorderfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Images Order"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents btnUp As System.Windows.Forms.Button
   Friend WithEvents btnDown As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
End Class
