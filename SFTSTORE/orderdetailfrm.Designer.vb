<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderdetailfrm
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
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.txtProduct = New System.Windows.Forms.TextBox()
      Me.lblProduct = New System.Windows.Forms.Label()
      Me.cmbStatus = New System.Windows.Forms.ComboBox()
      Me.lblStatus = New System.Windows.Forms.Label()
      Me.lblQuantity = New System.Windows.Forms.Label()
      Me.txtQuantity = New System.Windows.Forms.TextBox()
      Me.txtNotes = New System.Windows.Forms.TextBox()
      Me.lblNotes = New System.Windows.Forms.Label()
      Me.btnProduct = New System.Windows.Forms.Button()
      Me.lblremain = New System.Windows.Forms.Label()
      Me.txtRemain = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(128, 325)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(157, 30)
      Me.btnSave.TabIndex = 100
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(291, 325)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(157, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'txtProduct
      '
      Me.txtProduct.Enabled = False
      Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProduct.ForeColor = System.Drawing.Color.Black
      Me.txtProduct.Location = New System.Drawing.Point(206, 12)
      Me.txtProduct.Name = "txtProduct"
      Me.txtProduct.ReadOnly = True
      Me.txtProduct.Size = New System.Drawing.Size(308, 26)
      Me.txtProduct.TabIndex = 1004
      '
      'lblProduct
      '
      Me.lblProduct.AutoSize = True
      Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProduct.Location = New System.Drawing.Point(3, 13)
      Me.lblProduct.Name = "lblProduct"
      Me.lblProduct.Size = New System.Drawing.Size(76, 20)
      Me.lblProduct.TabIndex = 1005
      Me.lblProduct.Text = "Product:"
      '
      'cmbStatus
      '
      Me.cmbStatus.BackColor = System.Drawing.SystemColors.Window
      Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbStatus.FormattingEnabled = True
      Me.cmbStatus.Location = New System.Drawing.Point(206, 76)
      Me.cmbStatus.Name = "cmbStatus"
      Me.cmbStatus.Size = New System.Drawing.Size(308, 28)
      Me.cmbStatus.TabIndex = 2
      '
      'lblStatus
      '
      Me.lblStatus.AutoSize = True
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblStatus.ForeColor = System.Drawing.Color.Black
      Me.lblStatus.Location = New System.Drawing.Point(3, 80)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(67, 20)
      Me.lblStatus.TabIndex = 1020
      Me.lblStatus.Text = "Status:"
      '
      'lblQuantity
      '
      Me.lblQuantity.AutoSize = True
      Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblQuantity.Location = New System.Drawing.Point(3, 112)
      Me.lblQuantity.Name = "lblQuantity"
      Me.lblQuantity.Size = New System.Drawing.Size(81, 20)
      Me.lblQuantity.TabIndex = 1005
      Me.lblQuantity.Text = "Quantity:"
      '
      'txtQuantity
      '
      Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtQuantity.ForeColor = System.Drawing.Color.Black
      Me.txtQuantity.Location = New System.Drawing.Point(206, 110)
      Me.txtQuantity.Name = "txtQuantity"
      Me.txtQuantity.Size = New System.Drawing.Size(308, 26)
      Me.txtQuantity.TabIndex = 3
      '
      'txtNotes
      '
      Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNotes.ForeColor = System.Drawing.Color.Black
      Me.txtNotes.Location = New System.Drawing.Point(7, 168)
      Me.txtNotes.Multiline = True
      Me.txtNotes.Name = "txtNotes"
      Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtNotes.Size = New System.Drawing.Size(552, 151)
      Me.txtNotes.TabIndex = 5
      '
      'lblNotes
      '
      Me.lblNotes.AutoSize = True
      Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNotes.ForeColor = System.Drawing.Color.Black
      Me.lblNotes.Location = New System.Drawing.Point(3, 145)
      Me.lblNotes.Name = "lblNotes"
      Me.lblNotes.Size = New System.Drawing.Size(61, 20)
      Me.lblNotes.TabIndex = 1022
      Me.lblNotes.Text = "Notes:"
      '
      'btnProduct
      '
      Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnProduct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnProduct.ForeColor = System.Drawing.Color.White
      Me.btnProduct.Location = New System.Drawing.Point(515, 11)
      Me.btnProduct.Name = "btnProduct"
      Me.btnProduct.Size = New System.Drawing.Size(44, 25)
      Me.btnProduct.TabIndex = 1
      Me.btnProduct.Text = "..."
      Me.btnProduct.UseVisualStyleBackColor = False
      '
      'lblremain
      '
      Me.lblremain.AutoSize = True
      Me.lblremain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblremain.Location = New System.Drawing.Point(3, 45)
      Me.lblremain.Name = "lblremain"
      Me.lblremain.Size = New System.Drawing.Size(131, 20)
      Me.lblremain.TabIndex = 1005
      Me.lblremain.Text = "Qty Remaining:"
      '
      'txtRemain
      '
      Me.txtRemain.Enabled = False
      Me.txtRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtRemain.ForeColor = System.Drawing.Color.Black
      Me.txtRemain.Location = New System.Drawing.Point(206, 44)
      Me.txtRemain.Name = "txtRemain"
      Me.txtRemain.ReadOnly = True
      Me.txtRemain.Size = New System.Drawing.Size(308, 26)
      Me.txtRemain.TabIndex = 1004
      '
      'orderdetailfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(566, 362)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnProduct)
      Me.Controls.Add(Me.txtNotes)
      Me.Controls.Add(Me.lblNotes)
      Me.Controls.Add(Me.cmbStatus)
      Me.Controls.Add(Me.lblStatus)
      Me.Controls.Add(Me.txtQuantity)
      Me.Controls.Add(Me.lblQuantity)
      Me.Controls.Add(Me.txtRemain)
      Me.Controls.Add(Me.lblremain)
      Me.Controls.Add(Me.txtProduct)
      Me.Controls.Add(Me.lblProduct)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnSave)
      Me.Name = "orderdetailfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Order Detail Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents txtProduct As System.Windows.Forms.TextBox
   Friend WithEvents lblProduct As System.Windows.Forms.Label
   Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblStatus As System.Windows.Forms.Label
   Friend WithEvents lblQuantity As System.Windows.Forms.Label
   Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
   Friend WithEvents txtNotes As System.Windows.Forms.TextBox
   Friend WithEvents lblNotes As System.Windows.Forms.Label
   Friend WithEvents btnProduct As System.Windows.Forms.Button
   Friend WithEvents lblremain As System.Windows.Forms.Label
   Friend WithEvents txtRemain As System.Windows.Forms.TextBox
End Class
