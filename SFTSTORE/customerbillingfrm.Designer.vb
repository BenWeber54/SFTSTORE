<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerbillingfrm
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
      Me.btnNew = New System.Windows.Forms.Button()
      Me.cmbCountry = New System.Windows.Forms.ComboBox()
      Me.lblCountry = New System.Windows.Forms.Label()
      Me.txtTitle = New System.Windows.Forms.TextBox()
      Me.lbltitle = New System.Windows.Forms.Label()
      Me.lblHolderName = New System.Windows.Forms.Label()
      Me.txtCardHolder = New System.Windows.Forms.TextBox()
      Me.lblAddr1 = New System.Windows.Forms.Label()
      Me.txtAddr1 = New System.Windows.Forms.TextBox()
      Me.lblAddr2 = New System.Windows.Forms.Label()
      Me.txtAddr2 = New System.Windows.Forms.TextBox()
      Me.lblCity = New System.Windows.Forms.Label()
      Me.txtCity = New System.Windows.Forms.TextBox()
      Me.lblProvince = New System.Windows.Forms.Label()
      Me.cmbProvince = New System.Windows.Forms.ComboBox()
      Me.lblPostal = New System.Windows.Forms.Label()
      Me.txtPostal = New System.Windows.Forms.TextBox()
      Me.lblCardType = New System.Windows.Forms.Label()
      Me.cmbCardType = New System.Windows.Forms.ComboBox()
      Me.lblNumber = New System.Windows.Forms.Label()
      Me.txtNumber = New System.Windows.Forms.TextBox()
      Me.lblExpiry = New System.Windows.Forms.Label()
      Me.cmbMonth = New System.Windows.Forms.ComboBox()
      Me.cmbYear = New System.Windows.Forms.ComboBox()
      Me.lblPhone = New System.Windows.Forms.Label()
      Me.txtPhone = New System.Windows.Forms.TextBox()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnCopy = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
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
      Me.btnClose.Location = New System.Drawing.Point(518, 185)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 105
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(518, 10)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'cmbCountry
      '
      Me.cmbCountry.BackColor = System.Drawing.SystemColors.Window
      Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbCountry.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbCountry.FormattingEnabled = True
      Me.cmbCountry.Location = New System.Drawing.Point(204, 169)
      Me.cmbCountry.Name = "cmbCountry"
      Me.cmbCountry.Size = New System.Drawing.Size(308, 28)
      Me.cmbCountry.TabIndex = 6
      '
      'lblCountry
      '
      Me.lblCountry.AutoSize = True
      Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCountry.ForeColor = System.Drawing.Color.Black
      Me.lblCountry.Location = New System.Drawing.Point(12, 171)
      Me.lblCountry.Name = "lblCountry"
      Me.lblCountry.Size = New System.Drawing.Size(76, 20)
      Me.lblCountry.TabIndex = 1022
      Me.lblCountry.Text = "Country:"
      '
      'txtTitle
      '
      Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtTitle.ForeColor = System.Drawing.Color.Black
      Me.txtTitle.Location = New System.Drawing.Point(204, 10)
      Me.txtTitle.Name = "txtTitle"
      Me.txtTitle.Size = New System.Drawing.Size(308, 26)
      Me.txtTitle.TabIndex = 1
      '
      'lbltitle
      '
      Me.lbltitle.AutoSize = True
      Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lbltitle.Location = New System.Drawing.Point(12, 12)
      Me.lbltitle.Name = "lbltitle"
      Me.lbltitle.Size = New System.Drawing.Size(48, 20)
      Me.lbltitle.TabIndex = 1024
      Me.lbltitle.Text = "Title:"
      '
      'lblHolderName
      '
      Me.lblHolderName.AutoSize = True
      Me.lblHolderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHolderName.Location = New System.Drawing.Point(12, 43)
      Me.lblHolderName.Name = "lblHolderName"
      Me.lblHolderName.Size = New System.Drawing.Size(161, 20)
      Me.lblHolderName.TabIndex = 1024
      Me.lblHolderName.Text = "Card Holder Name:"
      '
      'txtCardHolder
      '
      Me.txtCardHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCardHolder.ForeColor = System.Drawing.Color.Black
      Me.txtCardHolder.Location = New System.Drawing.Point(204, 41)
      Me.txtCardHolder.Name = "txtCardHolder"
      Me.txtCardHolder.Size = New System.Drawing.Size(308, 26)
      Me.txtCardHolder.TabIndex = 2
      '
      'lblAddr1
      '
      Me.lblAddr1.AutoSize = True
      Me.lblAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblAddr1.Location = New System.Drawing.Point(12, 75)
      Me.lblAddr1.Name = "lblAddr1"
      Me.lblAddr1.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr1.TabIndex = 1024
      Me.lblAddr1.Text = "Address Line 1:"
      '
      'txtAddr1
      '
      Me.txtAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtAddr1.ForeColor = System.Drawing.Color.Black
      Me.txtAddr1.Location = New System.Drawing.Point(204, 73)
      Me.txtAddr1.Name = "txtAddr1"
      Me.txtAddr1.Size = New System.Drawing.Size(308, 26)
      Me.txtAddr1.TabIndex = 3
      '
      'lblAddr2
      '
      Me.lblAddr2.AutoSize = True
      Me.lblAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblAddr2.Location = New System.Drawing.Point(12, 107)
      Me.lblAddr2.Name = "lblAddr2"
      Me.lblAddr2.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr2.TabIndex = 1024
      Me.lblAddr2.Text = "Address Line 2:"
      '
      'txtAddr2
      '
      Me.txtAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtAddr2.ForeColor = System.Drawing.Color.Black
      Me.txtAddr2.Location = New System.Drawing.Point(204, 105)
      Me.txtAddr2.Name = "txtAddr2"
      Me.txtAddr2.Size = New System.Drawing.Size(308, 26)
      Me.txtAddr2.TabIndex = 4
      '
      'lblCity
      '
      Me.lblCity.AutoSize = True
      Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCity.Location = New System.Drawing.Point(12, 139)
      Me.lblCity.Name = "lblCity"
      Me.lblCity.Size = New System.Drawing.Size(44, 20)
      Me.lblCity.TabIndex = 1024
      Me.lblCity.Text = "City:"
      '
      'txtCity
      '
      Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCity.ForeColor = System.Drawing.Color.Black
      Me.txtCity.Location = New System.Drawing.Point(204, 137)
      Me.txtCity.Name = "txtCity"
      Me.txtCity.Size = New System.Drawing.Size(308, 26)
      Me.txtCity.TabIndex = 5
      '
      'lblProvince
      '
      Me.lblProvince.AutoSize = True
      Me.lblProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProvince.ForeColor = System.Drawing.Color.Black
      Me.lblProvince.Location = New System.Drawing.Point(12, 205)
      Me.lblProvince.Name = "lblProvince"
      Me.lblProvince.Size = New System.Drawing.Size(82, 20)
      Me.lblProvince.TabIndex = 1022
      Me.lblProvince.Text = "Province:"
      '
      'cmbProvince
      '
      Me.cmbProvince.BackColor = System.Drawing.SystemColors.Window
      Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbProvince.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbProvince.FormattingEnabled = True
      Me.cmbProvince.Location = New System.Drawing.Point(204, 203)
      Me.cmbProvince.Name = "cmbProvince"
      Me.cmbProvince.Size = New System.Drawing.Size(308, 28)
      Me.cmbProvince.TabIndex = 7
      '
      'lblPostal
      '
      Me.lblPostal.AutoSize = True
      Me.lblPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblPostal.Location = New System.Drawing.Point(12, 239)
      Me.lblPostal.Name = "lblPostal"
      Me.lblPostal.Size = New System.Drawing.Size(111, 20)
      Me.lblPostal.TabIndex = 1024
      Me.lblPostal.Text = "Postal Code:"
      '
      'txtPostal
      '
      Me.txtPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtPostal.ForeColor = System.Drawing.Color.Black
      Me.txtPostal.Location = New System.Drawing.Point(204, 237)
      Me.txtPostal.Name = "txtPostal"
      Me.txtPostal.Size = New System.Drawing.Size(308, 26)
      Me.txtPostal.TabIndex = 8
      '
      'lblCardType
      '
      Me.lblCardType.AutoSize = True
      Me.lblCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCardType.ForeColor = System.Drawing.Color.Black
      Me.lblCardType.Location = New System.Drawing.Point(12, 271)
      Me.lblCardType.Name = "lblCardType"
      Me.lblCardType.Size = New System.Drawing.Size(95, 20)
      Me.lblCardType.TabIndex = 1022
      Me.lblCardType.Text = "Card Type:"
      '
      'cmbCardType
      '
      Me.cmbCardType.BackColor = System.Drawing.SystemColors.Window
      Me.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbCardType.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbCardType.FormattingEnabled = True
      Me.cmbCardType.Location = New System.Drawing.Point(204, 269)
      Me.cmbCardType.Name = "cmbCardType"
      Me.cmbCardType.Size = New System.Drawing.Size(308, 28)
      Me.cmbCardType.TabIndex = 9
      '
      'lblNumber
      '
      Me.lblNumber.AutoSize = True
      Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNumber.Location = New System.Drawing.Point(12, 305)
      Me.lblNumber.Name = "lblNumber"
      Me.lblNumber.Size = New System.Drawing.Size(119, 20)
      Me.lblNumber.TabIndex = 1024
      Me.lblNumber.Text = "Card Number:"
      '
      'txtNumber
      '
      Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNumber.ForeColor = System.Drawing.Color.Black
      Me.txtNumber.Location = New System.Drawing.Point(204, 303)
      Me.txtNumber.Name = "txtNumber"
      Me.txtNumber.Size = New System.Drawing.Size(308, 26)
      Me.txtNumber.TabIndex = 10
      '
      'lblExpiry
      '
      Me.lblExpiry.AutoSize = True
      Me.lblExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblExpiry.ForeColor = System.Drawing.Color.Black
      Me.lblExpiry.Location = New System.Drawing.Point(12, 337)
      Me.lblExpiry.Name = "lblExpiry"
      Me.lblExpiry.Size = New System.Drawing.Size(106, 20)
      Me.lblExpiry.TabIndex = 1022
      Me.lblExpiry.Text = "Expiry Date:"
      '
      'cmbMonth
      '
      Me.cmbMonth.BackColor = System.Drawing.SystemColors.Window
      Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbMonth.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbMonth.FormattingEnabled = True
      Me.cmbMonth.Location = New System.Drawing.Point(204, 335)
      Me.cmbMonth.Name = "cmbMonth"
      Me.cmbMonth.Size = New System.Drawing.Size(139, 28)
      Me.cmbMonth.TabIndex = 11
      '
      'cmbYear
      '
      Me.cmbYear.BackColor = System.Drawing.SystemColors.Window
      Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbYear.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbYear.FormattingEnabled = True
      Me.cmbYear.Location = New System.Drawing.Point(349, 335)
      Me.cmbYear.Name = "cmbYear"
      Me.cmbYear.Size = New System.Drawing.Size(78, 28)
      Me.cmbYear.TabIndex = 12
      '
      'lblPhone
      '
      Me.lblPhone.AutoSize = True
      Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblPhone.Location = New System.Drawing.Point(12, 371)
      Me.lblPhone.Name = "lblPhone"
      Me.lblPhone.Size = New System.Drawing.Size(132, 20)
      Me.lblPhone.TabIndex = 1024
      Me.lblPhone.Text = "Phone Number:"
      '
      'txtPhone
      '
      Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtPhone.ForeColor = System.Drawing.Color.Black
      Me.txtPhone.Location = New System.Drawing.Point(204, 369)
      Me.txtPhone.Name = "txtPhone"
      Me.txtPhone.Size = New System.Drawing.Size(308, 26)
      Me.txtPhone.TabIndex = 13
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(518, 45)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(518, 80)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 102
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnCopy
      '
      Me.btnCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCopy.ForeColor = System.Drawing.Color.White
      Me.btnCopy.Location = New System.Drawing.Point(518, 115)
      Me.btnCopy.Name = "btnCopy"
      Me.btnCopy.Size = New System.Drawing.Size(156, 30)
      Me.btnCopy.TabIndex = 103
      Me.btnCopy.Text = "&Copy Address"
      Me.btnCopy.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(518, 150)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'customerbillingfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(682, 403)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtPhone)
      Me.Controls.Add(Me.lblPhone)
      Me.Controls.Add(Me.txtNumber)
      Me.Controls.Add(Me.lblNumber)
      Me.Controls.Add(Me.txtPostal)
      Me.Controls.Add(Me.lblPostal)
      Me.Controls.Add(Me.txtCity)
      Me.Controls.Add(Me.lblCity)
      Me.Controls.Add(Me.txtAddr2)
      Me.Controls.Add(Me.lblAddr2)
      Me.Controls.Add(Me.txtAddr1)
      Me.Controls.Add(Me.lblAddr1)
      Me.Controls.Add(Me.txtCardHolder)
      Me.Controls.Add(Me.lblHolderName)
      Me.Controls.Add(Me.txtTitle)
      Me.Controls.Add(Me.lbltitle)
      Me.Controls.Add(Me.cmbYear)
      Me.Controls.Add(Me.cmbMonth)
      Me.Controls.Add(Me.lblExpiry)
      Me.Controls.Add(Me.cmbCardType)
      Me.Controls.Add(Me.lblCardType)
      Me.Controls.Add(Me.cmbProvince)
      Me.Controls.Add(Me.lblProvince)
      Me.Controls.Add(Me.cmbCountry)
      Me.Controls.Add(Me.lblCountry)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnCopy)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "customerbillingfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Customer Billing"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
   Friend WithEvents lblCountry As System.Windows.Forms.Label
   Friend WithEvents txtTitle As System.Windows.Forms.TextBox
   Friend WithEvents lbltitle As System.Windows.Forms.Label
   Friend WithEvents lblHolderName As System.Windows.Forms.Label
   Friend WithEvents txtCardHolder As System.Windows.Forms.TextBox
   Friend WithEvents lblAddr1 As System.Windows.Forms.Label
   Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
   Friend WithEvents lblAddr2 As System.Windows.Forms.Label
   Friend WithEvents txtAddr2 As System.Windows.Forms.TextBox
   Friend WithEvents lblCity As System.Windows.Forms.Label
   Friend WithEvents txtCity As System.Windows.Forms.TextBox
   Friend WithEvents lblProvince As System.Windows.Forms.Label
   Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
   Friend WithEvents lblPostal As System.Windows.Forms.Label
   Friend WithEvents txtPostal As System.Windows.Forms.TextBox
   Friend WithEvents lblCardType As System.Windows.Forms.Label
   Friend WithEvents cmbCardType As System.Windows.Forms.ComboBox
   Friend WithEvents lblNumber As System.Windows.Forms.Label
   Friend WithEvents txtNumber As System.Windows.Forms.TextBox
   Friend WithEvents lblExpiry As System.Windows.Forms.Label
   Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
   Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
   Friend WithEvents lblPhone As System.Windows.Forms.Label
   Friend WithEvents txtPhone As System.Windows.Forms.TextBox
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnCopy As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
