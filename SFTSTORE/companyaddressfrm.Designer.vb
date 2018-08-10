<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companyaddressfrm
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
      Me.txtName = New System.Windows.Forms.TextBox()
      Me.lblName = New System.Windows.Forms.Label()
      Me.lblCity = New System.Windows.Forms.Label()
      Me.cmbProvince = New System.Windows.Forms.ComboBox()
      Me.lblProvince = New System.Windows.Forms.Label()
      Me.cmbCountry = New System.Windows.Forms.ComboBox()
      Me.lblCountry = New System.Windows.Forms.Label()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.txtTitle = New System.Windows.Forms.TextBox()
      Me.lblTitle = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.lblPostal = New System.Windows.Forms.Label()
      Me.lblAdd1 = New System.Windows.Forms.Label()
      Me.txtAddr1 = New System.Windows.Forms.TextBox()
      Me.lblAdd2 = New System.Windows.Forms.Label()
      Me.txtAddr2 = New System.Windows.Forms.TextBox()
      Me.txtCity = New System.Windows.Forms.TextBox()
      Me.txtPostal = New System.Windows.Forms.TextBox()
      Me.lblShip = New System.Windows.Forms.Label()
      Me.chkShip = New System.Windows.Forms.CheckBox()
      Me.txtSunday = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtSaturday = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.txtFriday = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtThursday = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.txtWednesday = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtTuesday = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtMonday = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtTelephone = New System.Windows.Forms.TextBox()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'txtName
      '
      Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtName.Location = New System.Drawing.Point(193, 48)
      Me.txtName.Name = "txtName"
      Me.txtName.Size = New System.Drawing.Size(329, 26)
      Me.txtName.TabIndex = 2
      '
      'lblName
      '
      Me.lblName.AutoSize = True
      Me.lblName.BackColor = System.Drawing.Color.Transparent
      Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblName.Location = New System.Drawing.Point(11, 51)
      Me.lblName.Name = "lblName"
      Me.lblName.Size = New System.Drawing.Size(135, 20)
      Me.lblName.TabIndex = 552
      Me.lblName.Text = "Shipping Name:"
      '
      'lblCity
      '
      Me.lblCity.AutoSize = True
      Me.lblCity.BackColor = System.Drawing.Color.Transparent
      Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCity.Location = New System.Drawing.Point(11, 226)
      Me.lblCity.Name = "lblCity"
      Me.lblCity.Size = New System.Drawing.Size(44, 20)
      Me.lblCity.TabIndex = 551
      Me.lblCity.Text = "City:"
      '
      'cmbProvince
      '
      Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbProvince.FormattingEnabled = True
      Me.cmbProvince.Location = New System.Drawing.Point(193, 188)
      Me.cmbProvince.Name = "cmbProvince"
      Me.cmbProvince.Size = New System.Drawing.Size(329, 28)
      Me.cmbProvince.TabIndex = 6
      '
      'lblProvince
      '
      Me.lblProvince.AutoSize = True
      Me.lblProvince.BackColor = System.Drawing.Color.Transparent
      Me.lblProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblProvince.Location = New System.Drawing.Point(11, 191)
      Me.lblProvince.Name = "lblProvince"
      Me.lblProvince.Size = New System.Drawing.Size(82, 20)
      Me.lblProvince.TabIndex = 549
      Me.lblProvince.Text = "Province:"
      '
      'cmbCountry
      '
      Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbCountry.FormattingEnabled = True
      Me.cmbCountry.Location = New System.Drawing.Point(193, 153)
      Me.cmbCountry.Name = "cmbCountry"
      Me.cmbCountry.Size = New System.Drawing.Size(329, 28)
      Me.cmbCountry.TabIndex = 5
      '
      'lblCountry
      '
      Me.lblCountry.AutoSize = True
      Me.lblCountry.BackColor = System.Drawing.Color.Transparent
      Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCountry.Location = New System.Drawing.Point(11, 156)
      Me.lblCountry.Name = "lblCountry"
      Me.lblCountry.Size = New System.Drawing.Size(76, 20)
      Me.lblCountry.TabIndex = 544
      Me.lblCountry.Text = "Country:"
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(533, 115)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(533, 80)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 103
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(533, 45)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'txtTitle
      '
      Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTitle.Location = New System.Drawing.Point(193, 13)
      Me.txtTitle.Name = "txtTitle"
      Me.txtTitle.Size = New System.Drawing.Size(329, 26)
      Me.txtTitle.TabIndex = 1
      '
      'lblTitle
      '
      Me.lblTitle.AutoSize = True
      Me.lblTitle.BackColor = System.Drawing.Color.Transparent
      Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle.Location = New System.Drawing.Point(11, 16)
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Size = New System.Drawing.Size(119, 20)
      Me.lblTitle.TabIndex = 534
      Me.lblTitle.Text = "Address Title:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(533, 150)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 110
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(533, 10)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'lblPostal
      '
      Me.lblPostal.AutoSize = True
      Me.lblPostal.BackColor = System.Drawing.Color.Transparent
      Me.lblPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPostal.Location = New System.Drawing.Point(11, 261)
      Me.lblPostal.Name = "lblPostal"
      Me.lblPostal.Size = New System.Drawing.Size(64, 20)
      Me.lblPostal.TabIndex = 551
      Me.lblPostal.Text = "Postal:"
      '
      'lblAdd1
      '
      Me.lblAdd1.AutoSize = True
      Me.lblAdd1.BackColor = System.Drawing.Color.Transparent
      Me.lblAdd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAdd1.Location = New System.Drawing.Point(11, 86)
      Me.lblAdd1.Name = "lblAdd1"
      Me.lblAdd1.Size = New System.Drawing.Size(134, 20)
      Me.lblAdd1.TabIndex = 552
      Me.lblAdd1.Text = "Address Line 1:"
      '
      'txtAddr1
      '
      Me.txtAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr1.Location = New System.Drawing.Point(193, 83)
      Me.txtAddr1.Name = "txtAddr1"
      Me.txtAddr1.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr1.TabIndex = 3
      '
      'lblAdd2
      '
      Me.lblAdd2.AutoSize = True
      Me.lblAdd2.BackColor = System.Drawing.Color.Transparent
      Me.lblAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAdd2.Location = New System.Drawing.Point(11, 121)
      Me.lblAdd2.Name = "lblAdd2"
      Me.lblAdd2.Size = New System.Drawing.Size(134, 20)
      Me.lblAdd2.TabIndex = 552
      Me.lblAdd2.Text = "Address Line 2:"
      '
      'txtAddr2
      '
      Me.txtAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr2.Location = New System.Drawing.Point(193, 118)
      Me.txtAddr2.Name = "txtAddr2"
      Me.txtAddr2.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr2.TabIndex = 4
      '
      'txtCity
      '
      Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCity.Location = New System.Drawing.Point(193, 223)
      Me.txtCity.Name = "txtCity"
      Me.txtCity.Size = New System.Drawing.Size(329, 26)
      Me.txtCity.TabIndex = 7
      '
      'txtPostal
      '
      Me.txtPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPostal.Location = New System.Drawing.Point(193, 258)
      Me.txtPostal.Name = "txtPostal"
      Me.txtPostal.Size = New System.Drawing.Size(329, 26)
      Me.txtPostal.TabIndex = 8
      '
      'lblShip
      '
      Me.lblShip.AutoSize = True
      Me.lblShip.BackColor = System.Drawing.Color.Transparent
      Me.lblShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblShip.Location = New System.Drawing.Point(11, 330)
      Me.lblShip.Name = "lblShip"
      Me.lblShip.Size = New System.Drawing.Size(121, 20)
      Me.lblShip.TabIndex = 551
      Me.lblShip.Text = "Ship Address:"
      '
      'chkShip
      '
      Me.chkShip.AutoSize = True
      Me.chkShip.Location = New System.Drawing.Point(194, 335)
      Me.chkShip.Name = "chkShip"
      Me.chkShip.Size = New System.Drawing.Size(15, 14)
      Me.chkShip.TabIndex = 554
      Me.chkShip.UseVisualStyleBackColor = True
      '
      'txtSunday
      '
      Me.txtSunday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSunday.Location = New System.Drawing.Point(193, 589)
      Me.txtSunday.Name = "txtSunday"
      Me.txtSunday.Size = New System.Drawing.Size(329, 26)
      Me.txtSunday.TabIndex = 582
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(113, 589)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(74, 20)
      Me.Label8.TabIndex = 583
      Me.Label8.Text = "Sunday:"
      '
      'txtSaturday
      '
      Me.txtSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSaturday.Location = New System.Drawing.Point(193, 557)
      Me.txtSaturday.Name = "txtSaturday"
      Me.txtSaturday.Size = New System.Drawing.Size(329, 26)
      Me.txtSaturday.TabIndex = 580
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(101, 557)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(86, 20)
      Me.Label7.TabIndex = 581
      Me.Label7.Text = "Saturday:"
      '
      'txtFriday
      '
      Me.txtFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFriday.Location = New System.Drawing.Point(193, 525)
      Me.txtFriday.Name = "txtFriday"
      Me.txtFriday.Size = New System.Drawing.Size(329, 26)
      Me.txtFriday.TabIndex = 578
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(124, 528)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(63, 20)
      Me.Label6.TabIndex = 579
      Me.Label6.Text = "Friday:"
      '
      'txtThursday
      '
      Me.txtThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtThursday.Location = New System.Drawing.Point(193, 493)
      Me.txtThursday.Name = "txtThursday"
      Me.txtThursday.Size = New System.Drawing.Size(329, 26)
      Me.txtThursday.TabIndex = 576
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(100, 493)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(87, 20)
      Me.Label5.TabIndex = 577
      Me.Label5.Text = "Thursday:"
      '
      'txtWednesday
      '
      Me.txtWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtWednesday.Location = New System.Drawing.Point(193, 461)
      Me.txtWednesday.Name = "txtWednesday"
      Me.txtWednesday.Size = New System.Drawing.Size(329, 26)
      Me.txtWednesday.TabIndex = 574
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(80, 461)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(107, 20)
      Me.Label4.TabIndex = 575
      Me.Label4.Text = "Wednesday:"
      '
      'txtTuesday
      '
      Me.txtTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTuesday.Location = New System.Drawing.Point(193, 429)
      Me.txtTuesday.Name = "txtTuesday"
      Me.txtTuesday.Size = New System.Drawing.Size(329, 26)
      Me.txtTuesday.TabIndex = 572
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(106, 432)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(81, 20)
      Me.Label3.TabIndex = 573
      Me.Label3.Text = "Tuesday:"
      '
      'txtMonday
      '
      Me.txtMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMonday.Location = New System.Drawing.Point(193, 397)
      Me.txtMonday.Name = "txtMonday"
      Me.txtMonday.Size = New System.Drawing.Size(329, 26)
      Me.txtMonday.TabIndex = 570
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(111, 400)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(76, 20)
      Me.Label2.TabIndex = 571
      Me.Label2.Text = "Monday:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(12, 366)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(62, 20)
      Me.Label1.TabIndex = 569
      Me.Label1.Text = "Hours:"
      '
      'txtTelephone
      '
      Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTelephone.Location = New System.Drawing.Point(193, 290)
      Me.txtTelephone.Name = "txtTelephone"
      Me.txtTelephone.Size = New System.Drawing.Size(329, 26)
      Me.txtTelephone.TabIndex = 584
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(11, 293)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(98, 20)
      Me.Label9.TabIndex = 585
      Me.Label9.Text = "Telephone:"
      '
      'companyaddressfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(700, 643)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtTelephone)
      Me.Controls.Add(Me.Label9)
      Me.Controls.Add(Me.txtSunday)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.txtSaturday)
      Me.Controls.Add(Me.Label7)
      Me.Controls.Add(Me.txtFriday)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.txtThursday)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.txtWednesday)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.txtTuesday)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtMonday)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.chkShip)
      Me.Controls.Add(Me.txtPostal)
      Me.Controls.Add(Me.txtCity)
      Me.Controls.Add(Me.txtAddr2)
      Me.Controls.Add(Me.lblAdd2)
      Me.Controls.Add(Me.txtAddr1)
      Me.Controls.Add(Me.lblAdd1)
      Me.Controls.Add(Me.txtName)
      Me.Controls.Add(Me.lblName)
      Me.Controls.Add(Me.lblShip)
      Me.Controls.Add(Me.lblPostal)
      Me.Controls.Add(Me.lblCity)
      Me.Controls.Add(Me.cmbProvince)
      Me.Controls.Add(Me.lblProvince)
      Me.Controls.Add(Me.cmbCountry)
      Me.Controls.Add(Me.lblCountry)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.txtTitle)
      Me.Controls.Add(Me.lblTitle)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnNew)
      Me.Name = "companyaddressfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Company Address Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents txtName As System.Windows.Forms.TextBox
   Friend WithEvents lblName As System.Windows.Forms.Label
   Friend WithEvents lblCity As System.Windows.Forms.Label
   Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
   Friend WithEvents lblProvince As System.Windows.Forms.Label
   Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
   Friend WithEvents lblCountry As System.Windows.Forms.Label
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents txtTitle As System.Windows.Forms.TextBox
   Friend WithEvents lblTitle As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents lblPostal As System.Windows.Forms.Label
   Friend WithEvents lblAdd1 As System.Windows.Forms.Label
   Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
   Friend WithEvents lblAdd2 As System.Windows.Forms.Label
   Friend WithEvents txtAddr2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCity As System.Windows.Forms.TextBox
   Friend WithEvents txtPostal As System.Windows.Forms.TextBox
   Friend WithEvents lblShip As System.Windows.Forms.Label
   Friend WithEvents chkShip As System.Windows.Forms.CheckBox
   Friend WithEvents txtSunday As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtSaturday As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtFriday As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtThursday As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtWednesday As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtTuesday As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtMonday As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
