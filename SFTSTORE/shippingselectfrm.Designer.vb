<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shippingselectfrm
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
      Me.lblShipType = New System.Windows.Forms.Label()
      Me.cmbShipping = New System.Windows.Forms.ComboBox()
      Me.chkPrice = New System.Windows.Forms.CheckBox()
      Me.txtPrice = New System.Windows.Forms.TextBox()
      Me.lblShipCost = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(101, 83)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(157, 30)
      Me.btnSave.TabIndex = 100
      Me.btnSave.Text = "&Ship"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(264, 83)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(157, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Cancel"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblShipType
      '
      Me.lblShipType.AutoSize = True
      Me.lblShipType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblShipType.ForeColor = System.Drawing.Color.Black
      Me.lblShipType.Location = New System.Drawing.Point(9, 14)
      Me.lblShipType.Name = "lblShipType"
      Me.lblShipType.Size = New System.Drawing.Size(183, 20)
      Me.lblShipType.TabIndex = 1020
      Me.lblShipType.Text = "Select Shipping Type:"
      '
      'cmbShipping
      '
      Me.cmbShipping.BackColor = System.Drawing.SystemColors.Window
      Me.cmbShipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbShipping.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbShipping.FormattingEnabled = True
      Me.cmbShipping.Location = New System.Drawing.Point(212, 10)
      Me.cmbShipping.Name = "cmbShipping"
      Me.cmbShipping.Size = New System.Drawing.Size(308, 28)
      Me.cmbShipping.TabIndex = 1
      '
      'chkPrice
      '
      Me.chkPrice.AutoSize = True
      Me.chkPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPrice.Location = New System.Drawing.Point(375, 55)
      Me.chkPrice.Name = "chkPrice"
      Me.chkPrice.Size = New System.Drawing.Size(155, 20)
      Me.chkPrice.TabIndex = 3
      Me.chkPrice.Text = "Change Ship Price"
      Me.chkPrice.UseVisualStyleBackColor = True
      '
      'txtPrice
      '
      Me.txtPrice.Enabled = False
      Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtPrice.ForeColor = System.Drawing.Color.Black
      Me.txtPrice.Location = New System.Drawing.Point(212, 51)
      Me.txtPrice.Name = "txtPrice"
      Me.txtPrice.Size = New System.Drawing.Size(157, 26)
      Me.txtPrice.TabIndex = 2
      '
      'lblShipCost
      '
      Me.lblShipCost.AutoSize = True
      Me.lblShipCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblShipCost.ForeColor = System.Drawing.Color.Black
      Me.lblShipCost.Location = New System.Drawing.Point(9, 51)
      Me.lblShipCost.Name = "lblShipCost"
      Me.lblShipCost.Size = New System.Drawing.Size(171, 20)
      Me.lblShipCost.TabIndex = 1020
      Me.lblShipCost.Text = "Total Shipping Cost:"
      '
      'shippingselectfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(535, 122)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtPrice)
      Me.Controls.Add(Me.chkPrice)
      Me.Controls.Add(Me.cmbShipping)
      Me.Controls.Add(Me.lblShipCost)
      Me.Controls.Add(Me.lblShipType)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnSave)
      Me.Name = "shippingselectfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shipping Selection"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblShipType As System.Windows.Forms.Label
   Friend WithEvents cmbShipping As System.Windows.Forms.ComboBox
   Friend WithEvents chkPrice As System.Windows.Forms.CheckBox
   Friend WithEvents txtPrice As System.Windows.Forms.TextBox
   Friend WithEvents lblShipCost As System.Windows.Forms.Label
End Class
