<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promocodesfrm
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
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.txtReason = New System.Windows.Forms.TextBox()
      Me.lblReason = New System.Windows.Forms.Label()
      Me.txtDiscount = New System.Windows.Forms.TextBox()
      Me.lblDiscount = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.cmbType = New System.Windows.Forms.ComboBox()
      Me.lblType = New System.Windows.Forms.Label()
      Me.cmbDiscountType = New System.Windows.Forms.ComboBox()
      Me.lblDiscountType = New System.Windows.Forms.Label()
      Me.dpStart = New System.Windows.Forms.DateTimePicker()
      Me.lblStart = New System.Windows.Forms.Label()
      Me.lblEnd = New System.Windows.Forms.Label()
      Me.dpEnd = New System.Windows.Forms.DateTimePicker()
      Me.lblTotalNeeded = New System.Windows.Forms.Label()
      Me.txtTotalNeeded = New System.Windows.Forms.TextBox()
      Me.txtCode = New System.Windows.Forms.TextBox()
      Me.lblCode = New System.Windows.Forms.Label()
      Me.lblMinNeeded = New System.Windows.Forms.Label()
      Me.chkMinNeeded = New System.Windows.Forms.CheckBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(546, 112)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 27)
      Me.btnDelete.TabIndex = 103
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(546, 78)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 27)
      Me.btnSave.TabIndex = 102
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(546, 44)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 27)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'txtReason
      '
      Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtReason.Location = New System.Drawing.Point(228, 200)
      Me.txtReason.Multiline = True
      Me.txtReason.Name = "txtReason"
      Me.txtReason.Size = New System.Drawing.Size(308, 101)
      Me.txtReason.TabIndex = 7
      '
      'lblReason
      '
      Me.lblReason.AutoSize = True
      Me.lblReason.BackColor = System.Drawing.Color.Transparent
      Me.lblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReason.Location = New System.Drawing.Point(8, 200)
      Me.lblReason.Name = "lblReason"
      Me.lblReason.Size = New System.Drawing.Size(181, 20)
      Me.lblReason.TabIndex = 44
      Me.lblReason.Text = "Discount Description:"
      '
      'txtDiscount
      '
      Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDiscount.Location = New System.Drawing.Point(228, 110)
      Me.txtDiscount.Name = "txtDiscount"
      Me.txtDiscount.Size = New System.Drawing.Size(308, 26)
      Me.txtDiscount.TabIndex = 4
      '
      'lblDiscount
      '
      Me.lblDiscount.AutoSize = True
      Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
      Me.lblDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDiscount.Location = New System.Drawing.Point(8, 111)
      Me.lblDiscount.Name = "lblDiscount"
      Me.lblDiscount.Size = New System.Drawing.Size(85, 20)
      Me.lblDiscount.TabIndex = 43
      Me.lblDiscount.Text = "Discount:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(546, 145)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 27)
      Me.btnClose.TabIndex = 104
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(546, 10)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 27)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'cmbType
      '
      Me.cmbType.BackColor = System.Drawing.SystemColors.Window
      Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbType.FormattingEnabled = True
      Me.cmbType.Location = New System.Drawing.Point(228, 41)
      Me.cmbType.Name = "cmbType"
      Me.cmbType.Size = New System.Drawing.Size(308, 28)
      Me.cmbType.TabIndex = 2
      '
      'lblType
      '
      Me.lblType.AutoSize = True
      Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblType.ForeColor = System.Drawing.Color.Black
      Me.lblType.Location = New System.Drawing.Point(8, 43)
      Me.lblType.Name = "lblType"
      Me.lblType.Size = New System.Drawing.Size(52, 20)
      Me.lblType.TabIndex = 1020
      Me.lblType.Text = "Type:"
      '
      'cmbDiscountType
      '
      Me.cmbDiscountType.BackColor = System.Drawing.SystemColors.Window
      Me.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbDiscountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbDiscountType.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbDiscountType.FormattingEnabled = True
      Me.cmbDiscountType.Location = New System.Drawing.Point(228, 75)
      Me.cmbDiscountType.Name = "cmbDiscountType"
      Me.cmbDiscountType.Size = New System.Drawing.Size(308, 28)
      Me.cmbDiscountType.TabIndex = 3
      '
      'lblDiscountType
      '
      Me.lblDiscountType.AutoSize = True
      Me.lblDiscountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblDiscountType.ForeColor = System.Drawing.Color.Black
      Me.lblDiscountType.Location = New System.Drawing.Point(8, 77)
      Me.lblDiscountType.Name = "lblDiscountType"
      Me.lblDiscountType.Size = New System.Drawing.Size(128, 20)
      Me.lblDiscountType.TabIndex = 1022
      Me.lblDiscountType.Text = "Discount Type:"
      '
      'dpStart
      '
      Me.dpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpStart.Location = New System.Drawing.Point(228, 307)
      Me.dpStart.Name = "dpStart"
      Me.dpStart.Size = New System.Drawing.Size(132, 26)
      Me.dpStart.TabIndex = 8
      '
      'lblStart
      '
      Me.lblStart.AutoSize = True
      Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblStart.Location = New System.Drawing.Point(8, 312)
      Me.lblStart.Name = "lblStart"
      Me.lblStart.Size = New System.Drawing.Size(98, 20)
      Me.lblStart.TabIndex = 1024
      Me.lblStart.Text = "Start Date:"
      '
      'lblEnd
      '
      Me.lblEnd.AutoSize = True
      Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEnd.Location = New System.Drawing.Point(8, 344)
      Me.lblEnd.Name = "lblEnd"
      Me.lblEnd.Size = New System.Drawing.Size(90, 20)
      Me.lblEnd.TabIndex = 1024
      Me.lblEnd.Text = "End Date:"
      '
      'dpEnd
      '
      Me.dpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpEnd.Location = New System.Drawing.Point(228, 339)
      Me.dpEnd.Name = "dpEnd"
      Me.dpEnd.Size = New System.Drawing.Size(132, 26)
      Me.dpEnd.TabIndex = 9
      '
      'lblTotalNeeded
      '
      Me.lblTotalNeeded.AutoSize = True
      Me.lblTotalNeeded.BackColor = System.Drawing.Color.Transparent
      Me.lblTotalNeeded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblTotalNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTotalNeeded.Location = New System.Drawing.Point(8, 170)
      Me.lblTotalNeeded.Name = "lblTotalNeeded"
      Me.lblTotalNeeded.Size = New System.Drawing.Size(121, 20)
      Me.lblTotalNeeded.TabIndex = 43
      Me.lblTotalNeeded.Text = "Total Needed:"
      Me.lblTotalNeeded.Visible = False
      '
      'txtTotalNeeded
      '
      Me.txtTotalNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotalNeeded.Location = New System.Drawing.Point(228, 166)
      Me.txtTotalNeeded.Name = "txtTotalNeeded"
      Me.txtTotalNeeded.Size = New System.Drawing.Size(308, 26)
      Me.txtTotalNeeded.TabIndex = 6
      Me.txtTotalNeeded.Visible = False
      '
      'txtCode
      '
      Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCode.Location = New System.Drawing.Point(228, 9)
      Me.txtCode.Name = "txtCode"
      Me.txtCode.Size = New System.Drawing.Size(308, 26)
      Me.txtCode.TabIndex = 1
      '
      'lblCode
      '
      Me.lblCode.AutoSize = True
      Me.lblCode.BackColor = System.Drawing.Color.Transparent
      Me.lblCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCode.Location = New System.Drawing.Point(8, 10)
      Me.lblCode.Name = "lblCode"
      Me.lblCode.Size = New System.Drawing.Size(112, 20)
      Me.lblCode.TabIndex = 1026
      Me.lblCode.Text = "Promo Code:"
      '
      'lblMinNeeded
      '
      Me.lblMinNeeded.AutoSize = True
      Me.lblMinNeeded.BackColor = System.Drawing.Color.Transparent
      Me.lblMinNeeded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblMinNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMinNeeded.Location = New System.Drawing.Point(8, 140)
      Me.lblMinNeeded.Name = "lblMinNeeded"
      Me.lblMinNeeded.Size = New System.Drawing.Size(109, 20)
      Me.lblMinNeeded.TabIndex = 43
      Me.lblMinNeeded.Text = "Min Needed:"
      '
      'chkMinNeeded
      '
      Me.chkMinNeeded.AutoSize = True
      Me.chkMinNeeded.Location = New System.Drawing.Point(228, 145)
      Me.chkMinNeeded.Name = "chkMinNeeded"
      Me.chkMinNeeded.Size = New System.Drawing.Size(15, 14)
      Me.chkMinNeeded.TabIndex = 5
      Me.chkMinNeeded.UseVisualStyleBackColor = True
      '
      'promocodesfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(711, 372)
      Me.ControlBox = False
      Me.Controls.Add(Me.chkMinNeeded)
      Me.Controls.Add(Me.txtCode)
      Me.Controls.Add(Me.lblCode)
      Me.Controls.Add(Me.dpEnd)
      Me.Controls.Add(Me.lblEnd)
      Me.Controls.Add(Me.dpStart)
      Me.Controls.Add(Me.lblStart)
      Me.Controls.Add(Me.cmbDiscountType)
      Me.Controls.Add(Me.lblDiscountType)
      Me.Controls.Add(Me.cmbType)
      Me.Controls.Add(Me.lblType)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.txtReason)
      Me.Controls.Add(Me.lblReason)
      Me.Controls.Add(Me.txtTotalNeeded)
      Me.Controls.Add(Me.lblMinNeeded)
      Me.Controls.Add(Me.lblTotalNeeded)
      Me.Controls.Add(Me.txtDiscount)
      Me.Controls.Add(Me.lblDiscount)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnNew)
      Me.Name = "promocodesfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Promo Codes"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents txtReason As System.Windows.Forms.TextBox
   Friend WithEvents lblReason As System.Windows.Forms.Label
   Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
   Friend WithEvents lblDiscount As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents cmbType As System.Windows.Forms.ComboBox
   Friend WithEvents lblType As System.Windows.Forms.Label
   Friend WithEvents cmbDiscountType As System.Windows.Forms.ComboBox
   Friend WithEvents lblDiscountType As System.Windows.Forms.Label
   Friend WithEvents dpStart As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblStart As System.Windows.Forms.Label
   Friend WithEvents lblEnd As System.Windows.Forms.Label
   Friend WithEvents dpEnd As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblTotalNeeded As System.Windows.Forms.Label
   Friend WithEvents txtTotalNeeded As System.Windows.Forms.TextBox
   Friend WithEvents txtCode As System.Windows.Forms.TextBox
   Friend WithEvents lblCode As System.Windows.Forms.Label
   Friend WithEvents lblMinNeeded As System.Windows.Forms.Label
   Friend WithEvents chkMinNeeded As System.Windows.Forms.CheckBox
End Class
