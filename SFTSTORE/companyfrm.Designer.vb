<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companyfrm
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
      Me.btnUsers = New System.Windows.Forms.Button()
      Me.cmbCountry = New System.Windows.Forms.ComboBox()
      Me.lblCountry = New System.Windows.Forms.Label()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.cmbProvince = New System.Windows.Forms.ComboBox()
      Me.txtPostal = New System.Windows.Forms.TextBox()
      Me.lblPostal = New System.Windows.Forms.Label()
      Me.lblProvince = New System.Windows.Forms.Label()
      Me.txtCity = New System.Windows.Forms.TextBox()
      Me.lblCity = New System.Windows.Forms.Label()
      Me.txtAddr2 = New System.Windows.Forms.TextBox()
      Me.lblAddr2 = New System.Windows.Forms.Label()
      Me.txtAddr1 = New System.Windows.Forms.TextBox()
      Me.lblAddr1 = New System.Windows.Forms.Label()
      Me.txtPhone = New System.Windows.Forms.TextBox()
      Me.lblPhone = New System.Windows.Forms.Label()
      Me.btnAudit = New System.Windows.Forms.Button()
      Me.btnProducts = New System.Windows.Forms.Button()
      Me.btnAttach = New System.Windows.Forms.Button()
      Me.btnNotes = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.txtEmail = New System.Windows.Forms.TextBox()
      Me.lblEmail = New System.Windows.Forms.Label()
      Me.txtCompanyName = New System.Windows.Forms.TextBox()
      Me.lblCompanyName = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnImages = New System.Windows.Forms.Button()
      Me.lblFax = New System.Windows.Forms.Label()
      Me.txtFax = New System.Windows.Forms.TextBox()
      Me.lblMarket = New System.Windows.Forms.Label()
      Me.txtMarket = New System.Windows.Forms.TextBox()
      Me.btnAddress = New System.Windows.Forms.Button()
      Me.lblMaterial = New System.Windows.Forms.Label()
      Me.txtMaterial = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.btnBoxes = New System.Windows.Forms.Button()
      Me.lblWebsite = New System.Windows.Forms.Label()
      Me.txtWebsite = New System.Windows.Forms.TextBox()
      Me.lblReplyEmail = New System.Windows.Forms.Label()
      Me.txtReplyEmail = New System.Windows.Forms.TextBox()
      Me.lblReplyPass = New System.Windows.Forms.Label()
      Me.txtReplyPass = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnUsers
      '
      Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnUsers.ForeColor = System.Drawing.Color.White
      Me.btnUsers.Location = New System.Drawing.Point(539, 397)
      Me.btnUsers.Name = "btnUsers"
      Me.btnUsers.Size = New System.Drawing.Size(156, 30)
      Me.btnUsers.TabIndex = 109
      Me.btnUsers.Text = "&Users"
      Me.btnUsers.UseVisualStyleBackColor = False
      '
      'cmbCountry
      '
      Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbCountry.FormattingEnabled = True
      Me.cmbCountry.Location = New System.Drawing.Point(199, 290)
      Me.cmbCountry.Name = "cmbCountry"
      Me.cmbCountry.Size = New System.Drawing.Size(329, 28)
      Me.cmbCountry.TabIndex = 9
      '
      'lblCountry
      '
      Me.lblCountry.AutoSize = True
      Me.lblCountry.BackColor = System.Drawing.Color.Transparent
      Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCountry.Location = New System.Drawing.Point(6, 293)
      Me.lblCountry.Name = "lblCountry"
      Me.lblCountry.Size = New System.Drawing.Size(76, 20)
      Me.lblCountry.TabIndex = 180
      Me.lblCountry.Text = "Country:"
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(539, 80)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(156, 30)
      Me.btnRecent.TabIndex = 102
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'cmbProvince
      '
      Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbProvince.FormattingEnabled = True
      Me.cmbProvince.Location = New System.Drawing.Point(199, 325)
      Me.cmbProvince.Name = "cmbProvince"
      Me.cmbProvince.Size = New System.Drawing.Size(329, 28)
      Me.cmbProvince.TabIndex = 10
      '
      'txtPostal
      '
      Me.txtPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPostal.Location = New System.Drawing.Point(199, 360)
      Me.txtPostal.Name = "txtPostal"
      Me.txtPostal.Size = New System.Drawing.Size(329, 26)
      Me.txtPostal.TabIndex = 11
      '
      'lblPostal
      '
      Me.lblPostal.AutoSize = True
      Me.lblPostal.BackColor = System.Drawing.Color.Transparent
      Me.lblPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPostal.Location = New System.Drawing.Point(6, 363)
      Me.lblPostal.Name = "lblPostal"
      Me.lblPostal.Size = New System.Drawing.Size(111, 20)
      Me.lblPostal.TabIndex = 174
      Me.lblPostal.Text = "Postal Code:"
      '
      'lblProvince
      '
      Me.lblProvince.AutoSize = True
      Me.lblProvince.BackColor = System.Drawing.Color.Transparent
      Me.lblProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblProvince.Location = New System.Drawing.Point(6, 328)
      Me.lblProvince.Name = "lblProvince"
      Me.lblProvince.Size = New System.Drawing.Size(82, 20)
      Me.lblProvince.TabIndex = 173
      Me.lblProvince.Text = "Province:"
      '
      'txtCity
      '
      Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCity.Location = New System.Drawing.Point(199, 220)
      Me.txtCity.Name = "txtCity"
      Me.txtCity.Size = New System.Drawing.Size(329, 26)
      Me.txtCity.TabIndex = 7
      '
      'lblCity
      '
      Me.lblCity.AutoSize = True
      Me.lblCity.BackColor = System.Drawing.Color.Transparent
      Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCity.Location = New System.Drawing.Point(6, 223)
      Me.lblCity.Name = "lblCity"
      Me.lblCity.Size = New System.Drawing.Size(44, 20)
      Me.lblCity.TabIndex = 171
      Me.lblCity.Text = "City:"
      '
      'txtAddr2
      '
      Me.txtAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr2.Location = New System.Drawing.Point(199, 185)
      Me.txtAddr2.Name = "txtAddr2"
      Me.txtAddr2.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr2.TabIndex = 6
      '
      'lblAddr2
      '
      Me.lblAddr2.AutoSize = True
      Me.lblAddr2.BackColor = System.Drawing.Color.Transparent
      Me.lblAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAddr2.Location = New System.Drawing.Point(6, 188)
      Me.lblAddr2.Name = "lblAddr2"
      Me.lblAddr2.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr2.TabIndex = 170
      Me.lblAddr2.Text = "Address Line 2:"
      '
      'txtAddr1
      '
      Me.txtAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr1.Location = New System.Drawing.Point(199, 150)
      Me.txtAddr1.Name = "txtAddr1"
      Me.txtAddr1.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr1.TabIndex = 5
      '
      'lblAddr1
      '
      Me.lblAddr1.AutoSize = True
      Me.lblAddr1.BackColor = System.Drawing.Color.Transparent
      Me.lblAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAddr1.Location = New System.Drawing.Point(6, 153)
      Me.lblAddr1.Name = "lblAddr1"
      Me.lblAddr1.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr1.TabIndex = 168
      Me.lblAddr1.Text = "Address Line 1:"
      '
      'txtPhone
      '
      Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPhone.Location = New System.Drawing.Point(199, 80)
      Me.txtPhone.Name = "txtPhone"
      Me.txtPhone.Size = New System.Drawing.Size(329, 26)
      Me.txtPhone.TabIndex = 3
      '
      'lblPhone
      '
      Me.lblPhone.AutoSize = True
      Me.lblPhone.BackColor = System.Drawing.Color.Transparent
      Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPhone.Location = New System.Drawing.Point(6, 83)
      Me.lblPhone.Name = "lblPhone"
      Me.lblPhone.Size = New System.Drawing.Size(65, 20)
      Me.lblPhone.TabIndex = 167
      Me.lblPhone.Text = "Phone:"
      '
      'btnAudit
      '
      Me.btnAudit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAudit.ForeColor = System.Drawing.Color.White
      Me.btnAudit.Location = New System.Drawing.Point(539, 432)
      Me.btnAudit.Name = "btnAudit"
      Me.btnAudit.Size = New System.Drawing.Size(156, 30)
      Me.btnAudit.TabIndex = 110
      Me.btnAudit.Text = "Aud&it"
      Me.btnAudit.UseVisualStyleBackColor = False
      '
      'btnProducts
      '
      Me.btnProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnProducts.ForeColor = System.Drawing.Color.White
      Me.btnProducts.Location = New System.Drawing.Point(539, 325)
      Me.btnProducts.Name = "btnProducts"
      Me.btnProducts.Size = New System.Drawing.Size(156, 30)
      Me.btnProducts.TabIndex = 108
      Me.btnProducts.Text = "&Products"
      Me.btnProducts.UseVisualStyleBackColor = False
      '
      'btnAttach
      '
      Me.btnAttach.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAttach.ForeColor = System.Drawing.Color.White
      Me.btnAttach.Location = New System.Drawing.Point(539, 255)
      Me.btnAttach.Name = "btnAttach"
      Me.btnAttach.Size = New System.Drawing.Size(156, 30)
      Me.btnAttach.TabIndex = 106
      Me.btnAttach.Text = "&Attachments"
      Me.btnAttach.UseVisualStyleBackColor = False
      '
      'btnNotes
      '
      Me.btnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNotes.ForeColor = System.Drawing.Color.White
      Me.btnNotes.Location = New System.Drawing.Point(539, 220)
      Me.btnNotes.Name = "btnNotes"
      Me.btnNotes.Size = New System.Drawing.Size(156, 30)
      Me.btnNotes.TabIndex = 105
      Me.btnNotes.Text = "No&tes"
      Me.btnNotes.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(539, 150)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(539, 115)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 103
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(539, 45)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'txtEmail
      '
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmail.Location = New System.Drawing.Point(199, 45)
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Size = New System.Drawing.Size(329, 26)
      Me.txtEmail.TabIndex = 2
      '
      'lblEmail
      '
      Me.lblEmail.AutoSize = True
      Me.lblEmail.BackColor = System.Drawing.Color.Transparent
      Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEmail.Location = New System.Drawing.Point(6, 48)
      Me.lblEmail.Name = "lblEmail"
      Me.lblEmail.Size = New System.Drawing.Size(58, 20)
      Me.lblEmail.TabIndex = 166
      Me.lblEmail.Text = "Email:"
      '
      'txtCompanyName
      '
      Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCompanyName.Location = New System.Drawing.Point(199, 10)
      Me.txtCompanyName.Name = "txtCompanyName"
      Me.txtCompanyName.Size = New System.Drawing.Size(329, 26)
      Me.txtCompanyName.TabIndex = 1
      '
      'lblCompanyName
      '
      Me.lblCompanyName.AutoSize = True
      Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
      Me.lblCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCompanyName.Location = New System.Drawing.Point(6, 13)
      Me.lblCompanyName.Name = "lblCompanyName"
      Me.lblCompanyName.Size = New System.Drawing.Size(139, 20)
      Me.lblCompanyName.TabIndex = 165
      Me.lblCompanyName.Text = "Company Name:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(539, 467)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 111
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(539, 10)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnImages
      '
      Me.btnImages.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnImages.ForeColor = System.Drawing.Color.White
      Me.btnImages.Location = New System.Drawing.Point(539, 290)
      Me.btnImages.Name = "btnImages"
      Me.btnImages.Size = New System.Drawing.Size(156, 30)
      Me.btnImages.TabIndex = 107
      Me.btnImages.Text = "&Logos"
      Me.btnImages.UseVisualStyleBackColor = False
      '
      'lblFax
      '
      Me.lblFax.AutoSize = True
      Me.lblFax.BackColor = System.Drawing.Color.Transparent
      Me.lblFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFax.Location = New System.Drawing.Point(6, 118)
      Me.lblFax.Name = "lblFax"
      Me.lblFax.Size = New System.Drawing.Size(43, 20)
      Me.lblFax.TabIndex = 167
      Me.lblFax.Text = "Fax:"
      '
      'txtFax
      '
      Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFax.Location = New System.Drawing.Point(199, 115)
      Me.txtFax.Name = "txtFax"
      Me.txtFax.Size = New System.Drawing.Size(329, 26)
      Me.txtFax.TabIndex = 4
      '
      'lblMarket
      '
      Me.lblMarket.AutoSize = True
      Me.lblMarket.BackColor = System.Drawing.Color.Transparent
      Me.lblMarket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMarket.Location = New System.Drawing.Point(6, 258)
      Me.lblMarket.Name = "lblMarket"
      Me.lblMarket.Size = New System.Drawing.Size(69, 20)
      Me.lblMarket.TabIndex = 174
      Me.lblMarket.Text = "Market:"
      '
      'txtMarket
      '
      Me.txtMarket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMarket.Location = New System.Drawing.Point(199, 255)
      Me.txtMarket.Name = "txtMarket"
      Me.txtMarket.Size = New System.Drawing.Size(329, 26)
      Me.txtMarket.TabIndex = 8
      '
      'btnAddress
      '
      Me.btnAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddress.ForeColor = System.Drawing.Color.White
      Me.btnAddress.Location = New System.Drawing.Point(539, 185)
      Me.btnAddress.Name = "btnAddress"
      Me.btnAddress.Size = New System.Drawing.Size(156, 30)
      Me.btnAddress.TabIndex = 105
      Me.btnAddress.Text = "Addr&ess"
      Me.btnAddress.UseVisualStyleBackColor = False
      '
      'lblMaterial
      '
      Me.lblMaterial.AutoSize = True
      Me.lblMaterial.BackColor = System.Drawing.Color.Transparent
      Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMaterial.Location = New System.Drawing.Point(6, 395)
      Me.lblMaterial.Name = "lblMaterial"
      Me.lblMaterial.Size = New System.Drawing.Size(146, 20)
      Me.lblMaterial.TabIndex = 174
      Me.lblMaterial.Text = "Packing Material:"
      '
      'txtMaterial
      '
      Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMaterial.Location = New System.Drawing.Point(199, 392)
      Me.txtMaterial.Name = "txtMaterial"
      Me.txtMaterial.Size = New System.Drawing.Size(137, 26)
      Me.txtMaterial.TabIndex = 12
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(342, 395)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(24, 20)
      Me.Label1.TabIndex = 174
      Me.Label1.Text = "%"
      '
      'btnBoxes
      '
      Me.btnBoxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBoxes.ForeColor = System.Drawing.Color.White
      Me.btnBoxes.Location = New System.Drawing.Point(539, 361)
      Me.btnBoxes.Name = "btnBoxes"
      Me.btnBoxes.Size = New System.Drawing.Size(156, 30)
      Me.btnBoxes.TabIndex = 108
      Me.btnBoxes.Text = "&Boxes"
      Me.btnBoxes.UseVisualStyleBackColor = False
      '
      'lblWebsite
      '
      Me.lblWebsite.AutoSize = True
      Me.lblWebsite.BackColor = System.Drawing.Color.Transparent
      Me.lblWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblWebsite.Location = New System.Drawing.Point(6, 427)
      Me.lblWebsite.Name = "lblWebsite"
      Me.lblWebsite.Size = New System.Drawing.Size(79, 20)
      Me.lblWebsite.TabIndex = 174
      Me.lblWebsite.Text = "Website:"
      '
      'txtWebsite
      '
      Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtWebsite.Location = New System.Drawing.Point(199, 424)
      Me.txtWebsite.Name = "txtWebsite"
      Me.txtWebsite.Size = New System.Drawing.Size(329, 26)
      Me.txtWebsite.TabIndex = 13
      '
      'lblReplyEmail
      '
      Me.lblReplyEmail.AutoSize = True
      Me.lblReplyEmail.BackColor = System.Drawing.Color.Transparent
      Me.lblReplyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReplyEmail.Location = New System.Drawing.Point(6, 459)
      Me.lblReplyEmail.Name = "lblReplyEmail"
      Me.lblReplyEmail.Size = New System.Drawing.Size(135, 20)
      Me.lblReplyEmail.TabIndex = 174
      Me.lblReplyEmail.Text = "No Reply Email:"
      '
      'txtReplyEmail
      '
      Me.txtReplyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtReplyEmail.Location = New System.Drawing.Point(199, 456)
      Me.txtReplyEmail.Name = "txtReplyEmail"
      Me.txtReplyEmail.Size = New System.Drawing.Size(329, 26)
      Me.txtReplyEmail.TabIndex = 14
      '
      'lblReplyPass
      '
      Me.lblReplyPass.AutoSize = True
      Me.lblReplyPass.BackColor = System.Drawing.Color.Transparent
      Me.lblReplyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReplyPass.Location = New System.Drawing.Point(6, 491)
      Me.lblReplyPass.Name = "lblReplyPass"
      Me.lblReplyPass.Size = New System.Drawing.Size(190, 20)
      Me.lblReplyPass.TabIndex = 174
      Me.lblReplyPass.Text = "Reply Email Password:"
      '
      'txtReplyPass
      '
      Me.txtReplyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtReplyPass.Location = New System.Drawing.Point(199, 488)
      Me.txtReplyPass.Name = "txtReplyPass"
      Me.txtReplyPass.Size = New System.Drawing.Size(329, 26)
      Me.txtReplyPass.TabIndex = 14
      '
      'companyfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(702, 526)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnUsers)
      Me.Controls.Add(Me.cmbCountry)
      Me.Controls.Add(Me.lblCountry)
      Me.Controls.Add(Me.btnRecent)
      Me.Controls.Add(Me.cmbProvince)
      Me.Controls.Add(Me.txtMarket)
      Me.Controls.Add(Me.lblMarket)
      Me.Controls.Add(Me.txtMaterial)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.lblMaterial)
      Me.Controls.Add(Me.txtReplyPass)
      Me.Controls.Add(Me.lblReplyPass)
      Me.Controls.Add(Me.txtReplyEmail)
      Me.Controls.Add(Me.lblReplyEmail)
      Me.Controls.Add(Me.txtWebsite)
      Me.Controls.Add(Me.lblWebsite)
      Me.Controls.Add(Me.txtPostal)
      Me.Controls.Add(Me.lblPostal)
      Me.Controls.Add(Me.lblProvince)
      Me.Controls.Add(Me.txtCity)
      Me.Controls.Add(Me.lblCity)
      Me.Controls.Add(Me.txtAddr2)
      Me.Controls.Add(Me.lblAddr2)
      Me.Controls.Add(Me.txtAddr1)
      Me.Controls.Add(Me.lblAddr1)
      Me.Controls.Add(Me.txtFax)
      Me.Controls.Add(Me.lblFax)
      Me.Controls.Add(Me.txtPhone)
      Me.Controls.Add(Me.lblPhone)
      Me.Controls.Add(Me.btnAudit)
      Me.Controls.Add(Me.btnBoxes)
      Me.Controls.Add(Me.btnProducts)
      Me.Controls.Add(Me.btnAttach)
      Me.Controls.Add(Me.btnAddress)
      Me.Controls.Add(Me.btnNotes)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.txtEmail)
      Me.Controls.Add(Me.lblEmail)
      Me.Controls.Add(Me.txtCompanyName)
      Me.Controls.Add(Me.lblCompanyName)
      Me.Controls.Add(Me.btnImages)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnNew)
      Me.Name = "companyfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Company Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnUsers As System.Windows.Forms.Button
   Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
   Friend WithEvents lblCountry As System.Windows.Forms.Label
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
   Friend WithEvents txtPostal As System.Windows.Forms.TextBox
   Friend WithEvents lblPostal As System.Windows.Forms.Label
   Friend WithEvents lblProvince As System.Windows.Forms.Label
   Friend WithEvents txtCity As System.Windows.Forms.TextBox
   Friend WithEvents lblCity As System.Windows.Forms.Label
   Friend WithEvents txtAddr2 As System.Windows.Forms.TextBox
   Friend WithEvents lblAddr2 As System.Windows.Forms.Label
   Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
   Friend WithEvents lblAddr1 As System.Windows.Forms.Label
   Friend WithEvents txtPhone As System.Windows.Forms.TextBox
   Friend WithEvents lblPhone As System.Windows.Forms.Label
   Friend WithEvents btnAudit As System.Windows.Forms.Button
   Friend WithEvents btnProducts As System.Windows.Forms.Button
   Friend WithEvents btnAttach As System.Windows.Forms.Button
   Friend WithEvents btnNotes As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents txtEmail As System.Windows.Forms.TextBox
   Friend WithEvents lblEmail As System.Windows.Forms.Label
   Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
   Friend WithEvents lblCompanyName As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnImages As System.Windows.Forms.Button
   Friend WithEvents lblFax As System.Windows.Forms.Label
   Friend WithEvents txtFax As System.Windows.Forms.TextBox
   Friend WithEvents lblMarket As System.Windows.Forms.Label
   Friend WithEvents txtMarket As System.Windows.Forms.TextBox
   Friend WithEvents btnAddress As System.Windows.Forms.Button
   Friend WithEvents lblMaterial As System.Windows.Forms.Label
   Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents btnBoxes As System.Windows.Forms.Button
   Friend WithEvents lblWebsite As System.Windows.Forms.Label
   Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
   Friend WithEvents lblReplyEmail As System.Windows.Forms.Label
   Friend WithEvents txtReplyEmail As System.Windows.Forms.TextBox
   Friend WithEvents lblReplyPass As System.Windows.Forms.Label
   Friend WithEvents txtReplyPass As System.Windows.Forms.TextBox
End Class
