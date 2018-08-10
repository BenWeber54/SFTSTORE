<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerwishlistaddfrm
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
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.lblName = New System.Windows.Forms.Label()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.lblQuantity = New System.Windows.Forms.Label()
      Me.txtQuantity = New System.Windows.Forms.TextBox()
      Me.lblOrdered = New System.Windows.Forms.Label()
      Me.chkOrdered = New System.Windows.Forms.CheckBox()
      Me.cmbProduct = New System.Windows.Forms.ComboBox()
      Me.SuspendLayout()
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(551, 77)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 104
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(551, 41)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 103
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'lblName
      '
      Me.lblName.AutoSize = True
      Me.lblName.BackColor = System.Drawing.Color.Transparent
      Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblName.Location = New System.Drawing.Point(12, 15)
      Me.lblName.Name = "lblName"
      Me.lblName.Size = New System.Drawing.Size(127, 20)
      Me.lblName.TabIndex = 556
      Me.lblName.Text = "Product Name:"
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(551, 5)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 101
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'lblQuantity
      '
      Me.lblQuantity.AutoSize = True
      Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
      Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblQuantity.Location = New System.Drawing.Point(12, 47)
      Me.lblQuantity.Name = "lblQuantity"
      Me.lblQuantity.Size = New System.Drawing.Size(81, 20)
      Me.lblQuantity.TabIndex = 556
      Me.lblQuantity.Text = "Quantity:"
      '
      'txtQuantity
      '
      Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtQuantity.Location = New System.Drawing.Point(184, 46)
      Me.txtQuantity.Name = "txtQuantity"
      Me.txtQuantity.Size = New System.Drawing.Size(329, 26)
      Me.txtQuantity.TabIndex = 2
      '
      'lblOrdered
      '
      Me.lblOrdered.AutoSize = True
      Me.lblOrdered.BackColor = System.Drawing.Color.Transparent
      Me.lblOrdered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblOrdered.Location = New System.Drawing.Point(12, 79)
      Me.lblOrdered.Name = "lblOrdered"
      Me.lblOrdered.Size = New System.Drawing.Size(79, 20)
      Me.lblOrdered.TabIndex = 556
      Me.lblOrdered.Text = "Ordered:"
      '
      'chkOrdered
      '
      Me.chkOrdered.AutoSize = True
      Me.chkOrdered.Location = New System.Drawing.Point(184, 83)
      Me.chkOrdered.Name = "chkOrdered"
      Me.chkOrdered.Size = New System.Drawing.Size(15, 14)
      Me.chkOrdered.TabIndex = 557
      Me.chkOrdered.UseVisualStyleBackColor = True
      '
      'cmbProduct
      '
      Me.cmbProduct.BackColor = System.Drawing.SystemColors.Window
      Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbProduct.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbProduct.FormattingEnabled = True
      Me.cmbProduct.Location = New System.Drawing.Point(184, 11)
      Me.cmbProduct.Name = "cmbProduct"
      Me.cmbProduct.Size = New System.Drawing.Size(329, 28)
      Me.cmbProduct.TabIndex = 558
      '
      'customerwishlistaddfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(717, 114)
      Me.ControlBox = False
      Me.Controls.Add(Me.cmbProduct)
      Me.Controls.Add(Me.chkOrdered)
      Me.Controls.Add(Me.lblOrdered)
      Me.Controls.Add(Me.txtQuantity)
      Me.Controls.Add(Me.lblQuantity)
      Me.Controls.Add(Me.lblName)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "customerwishlistaddfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Customer Wishlist"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents lblName As System.Windows.Forms.Label
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents lblQuantity As System.Windows.Forms.Label
   Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
   Friend WithEvents lblOrdered As System.Windows.Forms.Label
   Friend WithEvents chkOrdered As System.Windows.Forms.CheckBox
   Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
End Class
