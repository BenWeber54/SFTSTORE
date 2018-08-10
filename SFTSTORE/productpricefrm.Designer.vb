<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productpricefrm
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
      Me.btnClose = New System.Windows.Forms.Button()
      Me.lblPrice = New System.Windows.Forms.Label()
      Me.txtPrice = New System.Windows.Forms.TextBox()
      Me.lblReason = New System.Windows.Forms.Label()
      Me.txtReason = New System.Windows.Forms.TextBox()
      Me.lblStatus = New System.Windows.Forms.Label()
      Me.cmbStatus = New System.Windows.Forms.ComboBox()
      Me.dpStart = New System.Windows.Forms.DateTimePicker()
      Me.lblStart = New System.Windows.Forms.Label()
      Me.lblEnd = New System.Windows.Forms.Label()
      Me.dpEnd = New System.Windows.Forms.DateTimePicker()
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
      Me.btnSave.Location = New System.Drawing.Point(169, 174)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 100
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(331, 174)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblPrice
      '
      Me.lblPrice.AutoSize = True
      Me.lblPrice.BackColor = System.Drawing.Color.Transparent
      Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPrice.Location = New System.Drawing.Point(5, 15)
      Me.lblPrice.Name = "lblPrice"
      Me.lblPrice.Size = New System.Drawing.Size(49, 20)
      Me.lblPrice.TabIndex = 43
      Me.lblPrice.Text = "Price"
      '
      'txtPrice
      '
      Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPrice.Location = New System.Drawing.Point(201, 12)
      Me.txtPrice.Name = "txtPrice"
      Me.txtPrice.Size = New System.Drawing.Size(435, 26)
      Me.txtPrice.TabIndex = 1
      '
      'lblReason
      '
      Me.lblReason.AutoSize = True
      Me.lblReason.BackColor = System.Drawing.Color.Transparent
      Me.lblReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReason.Location = New System.Drawing.Point(5, 81)
      Me.lblReason.Name = "lblReason"
      Me.lblReason.Size = New System.Drawing.Size(76, 20)
      Me.lblReason.TabIndex = 43
      Me.lblReason.Text = "Reason:"
      Me.lblReason.Visible = False
      '
      'txtReason
      '
      Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtReason.Location = New System.Drawing.Point(201, 78)
      Me.txtReason.Name = "txtReason"
      Me.txtReason.Size = New System.Drawing.Size(435, 26)
      Me.txtReason.TabIndex = 3
      Me.txtReason.Visible = False
      '
      'lblStatus
      '
      Me.lblStatus.AutoSize = True
      Me.lblStatus.BackColor = System.Drawing.Color.Transparent
      Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblStatus.Location = New System.Drawing.Point(5, 47)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(112, 20)
      Me.lblStatus.TabIndex = 43
      Me.lblStatus.Text = "Price Status:"
      '
      'cmbStatus
      '
      Me.cmbStatus.BackColor = System.Drawing.SystemColors.Window
      Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbStatus.FormattingEnabled = True
      Me.cmbStatus.Location = New System.Drawing.Point(201, 44)
      Me.cmbStatus.Name = "cmbStatus"
      Me.cmbStatus.Size = New System.Drawing.Size(308, 28)
      Me.cmbStatus.TabIndex = 2
      '
      'dpStart
      '
      Me.dpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpStart.Location = New System.Drawing.Point(201, 110)
      Me.dpStart.Name = "dpStart"
      Me.dpStart.Size = New System.Drawing.Size(132, 26)
      Me.dpStart.TabIndex = 4
      Me.dpStart.Visible = False
      '
      'lblStart
      '
      Me.lblStart.AutoSize = True
      Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblStart.Location = New System.Drawing.Point(5, 116)
      Me.lblStart.Name = "lblStart"
      Me.lblStart.Size = New System.Drawing.Size(118, 20)
      Me.lblStart.TabIndex = 1006
      Me.lblStart.Text = "Special Start:"
      Me.lblStart.Visible = False
      '
      'lblEnd
      '
      Me.lblEnd.AutoSize = True
      Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEnd.Location = New System.Drawing.Point(5, 148)
      Me.lblEnd.Name = "lblEnd"
      Me.lblEnd.Size = New System.Drawing.Size(110, 20)
      Me.lblEnd.TabIndex = 1006
      Me.lblEnd.Text = "Special End:"
      Me.lblEnd.Visible = False
      '
      'dpEnd
      '
      Me.dpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpEnd.Location = New System.Drawing.Point(201, 142)
      Me.dpEnd.Name = "dpEnd"
      Me.dpEnd.Size = New System.Drawing.Size(132, 26)
      Me.dpEnd.TabIndex = 5
      Me.dpEnd.Visible = False
      '
      'productpricefrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(647, 208)
      Me.ControlBox = False
      Me.Controls.Add(Me.dpEnd)
      Me.Controls.Add(Me.lblEnd)
      Me.Controls.Add(Me.dpStart)
      Me.Controls.Add(Me.lblStart)
      Me.Controls.Add(Me.cmbStatus)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.txtReason)
      Me.Controls.Add(Me.lblReason)
      Me.Controls.Add(Me.txtPrice)
      Me.Controls.Add(Me.lblStatus)
      Me.Controls.Add(Me.lblPrice)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "productpricefrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product price maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblPrice As System.Windows.Forms.Label
   Friend WithEvents txtPrice As System.Windows.Forms.TextBox
   Friend WithEvents lblReason As System.Windows.Forms.Label
   Friend WithEvents txtReason As System.Windows.Forms.TextBox
   Friend WithEvents lblStatus As System.Windows.Forms.Label
   Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
   Friend WithEvents dpStart As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblStart As System.Windows.Forms.Label
   Friend WithEvents lblEnd As System.Windows.Forms.Label
   Friend WithEvents dpEnd As System.Windows.Forms.DateTimePicker
End Class
