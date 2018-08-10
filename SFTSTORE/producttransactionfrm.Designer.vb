<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class producttransactionfrm
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
      Me.btnAdd = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.lst = New System.Windows.Forms.ListView()
      Me.btnRemove = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnAdd
      '
      Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAdd.ForeColor = System.Drawing.Color.White
      Me.btnAdd.Location = New System.Drawing.Point(641, 12)
      Me.btnAdd.Name = "btnAdd"
      Me.btnAdd.Size = New System.Drawing.Size(156, 30)
      Me.btnAdd.TabIndex = 100
      Me.btnAdd.Text = "&Add"
      Me.btnAdd.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(641, 84)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.HideSelection = False
      Me.lst.Location = New System.Drawing.Point(12, 12)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(623, 509)
      Me.lst.TabIndex = 102
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'btnRemove
      '
      Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRemove.ForeColor = System.Drawing.Color.White
      Me.btnRemove.Location = New System.Drawing.Point(641, 48)
      Me.btnRemove.Name = "btnRemove"
      Me.btnRemove.Size = New System.Drawing.Size(156, 30)
      Me.btnRemove.TabIndex = 100
      Me.btnRemove.Text = "&Remove"
      Me.btnRemove.UseVisualStyleBackColor = False
      '
      'producttransactionfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(804, 527)
      Me.ControlBox = False
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnRemove)
      Me.Controls.Add(Me.btnAdd)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "producttransactionfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Quantity maintenance"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
