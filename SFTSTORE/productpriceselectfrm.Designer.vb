<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productpriceselectfrm
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
      Me.btnSelect = New System.Windows.Forms.Button()
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
      Me.btnClose.Location = New System.Drawing.Point(265, 269)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 27)
      Me.btnClose.TabIndex = 102
      Me.btnClose.Text = "&Cancel"
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
      Me.lst.Size = New System.Drawing.Size(484, 251)
      Me.lst.TabIndex = 1
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'btnSelect
      '
      Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSelect.ForeColor = System.Drawing.Color.White
      Me.btnSelect.Location = New System.Drawing.Point(81, 269)
      Me.btnSelect.Name = "btnSelect"
      Me.btnSelect.Size = New System.Drawing.Size(156, 27)
      Me.btnSelect.TabIndex = 102
      Me.btnSelect.Text = "&Select"
      Me.btnSelect.UseVisualStyleBackColor = False
      '
      'productpriceselectfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(507, 301)
      Me.ControlBox = False
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnSelect)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "productpriceselectfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Price Select"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents btnSelect As System.Windows.Forms.Button
End Class
