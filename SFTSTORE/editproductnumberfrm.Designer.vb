<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editproductnumberfrm
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
      Me.btnSave = New System.Windows.Forms.Button()
      Me.txtCurrent = New System.Windows.Forms.TextBox()
      Me.lblCurrent = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.lblNew = New System.Windows.Forms.Label()
      Me.txtNew = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(85, 71)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 100
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'txtCurrent
      '
      Me.txtCurrent.Enabled = False
      Me.txtCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCurrent.Location = New System.Drawing.Point(249, 7)
      Me.txtCurrent.Name = "txtCurrent"
      Me.txtCurrent.ReadOnly = True
      Me.txtCurrent.Size = New System.Drawing.Size(435, 26)
      Me.txtCurrent.TabIndex = 36
      '
      'lblCurrent
      '
      Me.lblCurrent.AutoSize = True
      Me.lblCurrent.BackColor = System.Drawing.Color.Transparent
      Me.lblCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCurrent.Location = New System.Drawing.Point(10, 10)
      Me.lblCurrent.Name = "lblCurrent"
      Me.lblCurrent.Size = New System.Drawing.Size(208, 20)
      Me.lblCurrent.TabIndex = 43
      Me.lblCurrent.Text = "Current Product Number:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(430, 71)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblNew
      '
      Me.lblNew.AutoSize = True
      Me.lblNew.BackColor = System.Drawing.Color.Transparent
      Me.lblNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNew.Location = New System.Drawing.Point(10, 42)
      Me.lblNew.Name = "lblNew"
      Me.lblNew.Size = New System.Drawing.Size(182, 20)
      Me.lblNew.TabIndex = 43
      Me.lblNew.Text = "New Product Number:"
      '
      'txtNew
      '
      Me.txtNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNew.Location = New System.Drawing.Point(249, 39)
      Me.txtNew.Name = "txtNew"
      Me.txtNew.Size = New System.Drawing.Size(435, 26)
      Me.txtNew.TabIndex = 1
      '
      'editproductnumberfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(691, 115)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.txtNew)
      Me.Controls.Add(Me.lblNew)
      Me.Controls.Add(Me.txtCurrent)
      Me.Controls.Add(Me.lblCurrent)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "editproductnumberfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Edit Product Number "
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
   Friend WithEvents lblCurrent As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblNew As System.Windows.Forms.Label
   Friend WithEvents txtNew As System.Windows.Forms.TextBox
End Class
