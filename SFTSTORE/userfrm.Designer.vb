<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userfrm
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
      Me.btnClearmr = New System.Windows.Forms.Button()
      Me.txtEmail = New System.Windows.Forms.TextBox()
      Me.lblEmail = New System.Windows.Forms.Label()
      Me.cmbActive = New System.Windows.Forms.ComboBox()
      Me.lblActive = New System.Windows.Forms.Label()
      Me.cmbPassStatus = New System.Windows.Forms.ComboBox()
      Me.lblPassStatus = New System.Windows.Forms.Label()
      Me.cmbRepLanguage = New System.Windows.Forms.ComboBox()
      Me.lblRepLanguage = New System.Windows.Forms.Label()
      Me.txtLast = New System.Windows.Forms.TextBox()
      Me.lblLast = New System.Windows.Forms.Label()
      Me.txtFirst = New System.Windows.Forms.TextBox()
      Me.lblFirst = New System.Windows.Forms.Label()
      Me.cmbInpLanguage = New System.Windows.Forms.ComboBox()
      Me.lblInpLanguage = New System.Windows.Forms.Label()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.cmbProvince = New System.Windows.Forms.ComboBox()
      Me.txtCell = New System.Windows.Forms.TextBox()
      Me.lblCell = New System.Windows.Forms.Label()
      Me.txtPhone = New System.Windows.Forms.TextBox()
      Me.lblPhone = New System.Windows.Forms.Label()
      Me.lblProvince = New System.Windows.Forms.Label()
      Me.txtPostal = New System.Windows.Forms.TextBox()
      Me.lblPostal = New System.Windows.Forms.Label()
      Me.txtAddr2 = New System.Windows.Forms.TextBox()
      Me.txtCity = New System.Windows.Forms.TextBox()
      Me.lblCity = New System.Windows.Forms.Label()
      Me.lblAddr2 = New System.Windows.Forms.Label()
      Me.txtAddr1 = New System.Windows.Forms.TextBox()
      Me.lblAddr1 = New System.Windows.Forms.Label()
      Me.btnAudit = New System.Windows.Forms.Button()
      Me.btnAccess = New System.Windows.Forms.Button()
      Me.btnAttach = New System.Windows.Forms.Button()
      Me.btnNotes = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.txtId = New System.Windows.Forms.TextBox()
      Me.lblId = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnCopyAdd = New System.Windows.Forms.Button()
      Me.btnCompany = New System.Windows.Forms.Button()
      Me.txtCompany = New System.Windows.Forms.TextBox()
      Me.lblCompany = New System.Windows.Forms.Label()
      Me.lblCountry = New System.Windows.Forms.Label()
      Me.cmbCountry = New System.Windows.Forms.ComboBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnClearmr
      '
      Me.btnClearmr.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClearmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClearmr.ForeColor = System.Drawing.Color.White
      Me.btnClearmr.Location = New System.Drawing.Point(533, 390)
      Me.btnClearmr.Name = "btnClearmr"
      Me.btnClearmr.Size = New System.Drawing.Size(156, 30)
      Me.btnClearmr.TabIndex = 110
      Me.btnClearmr.Text = "Clear M&R Data"
      Me.btnClearmr.UseVisualStyleBackColor = False
      '
      'txtEmail
      '
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmail.Location = New System.Drawing.Point(193, 430)
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Size = New System.Drawing.Size(329, 26)
      Me.txtEmail.TabIndex = 14
      '
      'lblEmail
      '
      Me.lblEmail.AutoSize = True
      Me.lblEmail.BackColor = System.Drawing.Color.Transparent
      Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEmail.Location = New System.Drawing.Point(11, 433)
      Me.lblEmail.Name = "lblEmail"
      Me.lblEmail.Size = New System.Drawing.Size(64, 20)
      Me.lblEmail.TabIndex = 552
      Me.lblEmail.Text = "E-Mail:"
      '
      'cmbActive
      '
      Me.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbActive.FormattingEnabled = True
      Me.cmbActive.Location = New System.Drawing.Point(193, 570)
      Me.cmbActive.Name = "cmbActive"
      Me.cmbActive.Size = New System.Drawing.Size(329, 28)
      Me.cmbActive.TabIndex = 18
      '
      'lblActive
      '
      Me.lblActive.AutoSize = True
      Me.lblActive.BackColor = System.Drawing.Color.Transparent
      Me.lblActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblActive.Location = New System.Drawing.Point(11, 573)
      Me.lblActive.Name = "lblActive"
      Me.lblActive.Size = New System.Drawing.Size(151, 20)
      Me.lblActive.TabIndex = 551
      Me.lblActive.Text = "Associate Status:"
      '
      'cmbPassStatus
      '
      Me.cmbPassStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbPassStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbPassStatus.FormattingEnabled = True
      Me.cmbPassStatus.Location = New System.Drawing.Point(193, 535)
      Me.cmbPassStatus.Name = "cmbPassStatus"
      Me.cmbPassStatus.Size = New System.Drawing.Size(329, 28)
      Me.cmbPassStatus.TabIndex = 17
      '
      'lblPassStatus
      '
      Me.lblPassStatus.AutoSize = True
      Me.lblPassStatus.BackColor = System.Drawing.Color.Transparent
      Me.lblPassStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPassStatus.Location = New System.Drawing.Point(11, 538)
      Me.lblPassStatus.Name = "lblPassStatus"
      Me.lblPassStatus.Size = New System.Drawing.Size(149, 20)
      Me.lblPassStatus.TabIndex = 549
      Me.lblPassStatus.Text = "Password Status:"
      '
      'cmbRepLanguage
      '
      Me.cmbRepLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbRepLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbRepLanguage.FormattingEnabled = True
      Me.cmbRepLanguage.Location = New System.Drawing.Point(193, 500)
      Me.cmbRepLanguage.Name = "cmbRepLanguage"
      Me.cmbRepLanguage.Size = New System.Drawing.Size(329, 28)
      Me.cmbRepLanguage.TabIndex = 16
      '
      'lblRepLanguage
      '
      Me.lblRepLanguage.AutoSize = True
      Me.lblRepLanguage.BackColor = System.Drawing.Color.Transparent
      Me.lblRepLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblRepLanguage.Location = New System.Drawing.Point(11, 503)
      Me.lblRepLanguage.Name = "lblRepLanguage"
      Me.lblRepLanguage.Size = New System.Drawing.Size(154, 20)
      Me.lblRepLanguage.TabIndex = 548
      Me.lblRepLanguage.Text = "Report Language:"
      '
      'txtLast
      '
      Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLast.Location = New System.Drawing.Point(193, 115)
      Me.txtLast.Name = "txtLast"
      Me.txtLast.Size = New System.Drawing.Size(329, 26)
      Me.txtLast.TabIndex = 5
      '
      'lblLast
      '
      Me.lblLast.AutoSize = True
      Me.lblLast.BackColor = System.Drawing.Color.Transparent
      Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLast.Location = New System.Drawing.Point(11, 118)
      Me.lblLast.Name = "lblLast"
      Me.lblLast.Size = New System.Drawing.Size(100, 20)
      Me.lblLast.TabIndex = 547
      Me.lblLast.Text = "Last Name:"
      '
      'txtFirst
      '
      Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFirst.Location = New System.Drawing.Point(193, 80)
      Me.txtFirst.Name = "txtFirst"
      Me.txtFirst.Size = New System.Drawing.Size(329, 26)
      Me.txtFirst.TabIndex = 4
      '
      'lblFirst
      '
      Me.lblFirst.AutoSize = True
      Me.lblFirst.BackColor = System.Drawing.Color.Transparent
      Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFirst.Location = New System.Drawing.Point(11, 83)
      Me.lblFirst.Name = "lblFirst"
      Me.lblFirst.Size = New System.Drawing.Size(101, 20)
      Me.lblFirst.TabIndex = 546
      Me.lblFirst.Text = "First Name:"
      '
      'cmbInpLanguage
      '
      Me.cmbInpLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbInpLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbInpLanguage.FormattingEnabled = True
      Me.cmbInpLanguage.Location = New System.Drawing.Point(193, 465)
      Me.cmbInpLanguage.Name = "cmbInpLanguage"
      Me.cmbInpLanguage.Size = New System.Drawing.Size(329, 28)
      Me.cmbInpLanguage.TabIndex = 15
      '
      'lblInpLanguage
      '
      Me.lblInpLanguage.AutoSize = True
      Me.lblInpLanguage.BackColor = System.Drawing.Color.Transparent
      Me.lblInpLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInpLanguage.Location = New System.Drawing.Point(11, 468)
      Me.lblInpLanguage.Name = "lblInpLanguage"
      Me.lblInpLanguage.Size = New System.Drawing.Size(141, 20)
      Me.lblInpLanguage.TabIndex = 544
      Me.lblInpLanguage.Text = "Input Language:"
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(533, 80)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(156, 30)
      Me.btnRecent.TabIndex = 102
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'cmbProvince
      '
      Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbProvince.FormattingEnabled = True
      Me.cmbProvince.Location = New System.Drawing.Point(193, 290)
      Me.cmbProvince.Name = "cmbProvince"
      Me.cmbProvince.Size = New System.Drawing.Size(329, 28)
      Me.cmbProvince.TabIndex = 10
      '
      'txtCell
      '
      Me.txtCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCell.Location = New System.Drawing.Point(193, 395)
      Me.txtCell.Name = "txtCell"
      Me.txtCell.Size = New System.Drawing.Size(329, 26)
      Me.txtCell.TabIndex = 13
      '
      'lblCell
      '
      Me.lblCell.AutoSize = True
      Me.lblCell.BackColor = System.Drawing.Color.Transparent
      Me.lblCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCell.Location = New System.Drawing.Point(11, 398)
      Me.lblCell.Name = "lblCell"
      Me.lblCell.Size = New System.Drawing.Size(44, 20)
      Me.lblCell.TabIndex = 542
      Me.lblCell.Text = "Cell:"
      '
      'txtPhone
      '
      Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPhone.Location = New System.Drawing.Point(193, 360)
      Me.txtPhone.Name = "txtPhone"
      Me.txtPhone.Size = New System.Drawing.Size(329, 26)
      Me.txtPhone.TabIndex = 12
      '
      'lblPhone
      '
      Me.lblPhone.AutoSize = True
      Me.lblPhone.BackColor = System.Drawing.Color.Transparent
      Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPhone.Location = New System.Drawing.Point(11, 363)
      Me.lblPhone.Name = "lblPhone"
      Me.lblPhone.Size = New System.Drawing.Size(65, 20)
      Me.lblPhone.TabIndex = 541
      Me.lblPhone.Text = "Phone:"
      '
      'lblProvince
      '
      Me.lblProvince.AutoSize = True
      Me.lblProvince.BackColor = System.Drawing.Color.Transparent
      Me.lblProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblProvince.Location = New System.Drawing.Point(11, 293)
      Me.lblProvince.Name = "lblProvince"
      Me.lblProvince.Size = New System.Drawing.Size(82, 20)
      Me.lblProvince.TabIndex = 540
      Me.lblProvince.Text = "Province:"
      '
      'txtPostal
      '
      Me.txtPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPostal.Location = New System.Drawing.Point(193, 325)
      Me.txtPostal.Name = "txtPostal"
      Me.txtPostal.Size = New System.Drawing.Size(329, 26)
      Me.txtPostal.TabIndex = 11
      '
      'lblPostal
      '
      Me.lblPostal.AutoSize = True
      Me.lblPostal.BackColor = System.Drawing.Color.Transparent
      Me.lblPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPostal.Location = New System.Drawing.Point(11, 328)
      Me.lblPostal.Name = "lblPostal"
      Me.lblPostal.Size = New System.Drawing.Size(111, 20)
      Me.lblPostal.TabIndex = 539
      Me.lblPostal.Text = "Postal Code:"
      '
      'txtAddr2
      '
      Me.txtAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr2.Location = New System.Drawing.Point(193, 185)
      Me.txtAddr2.Name = "txtAddr2"
      Me.txtAddr2.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr2.TabIndex = 7
      '
      'txtCity
      '
      Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCity.Location = New System.Drawing.Point(193, 220)
      Me.txtCity.Name = "txtCity"
      Me.txtCity.Size = New System.Drawing.Size(329, 26)
      Me.txtCity.TabIndex = 8
      '
      'lblCity
      '
      Me.lblCity.AutoSize = True
      Me.lblCity.BackColor = System.Drawing.Color.Transparent
      Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCity.Location = New System.Drawing.Point(12, 223)
      Me.lblCity.Name = "lblCity"
      Me.lblCity.Size = New System.Drawing.Size(44, 20)
      Me.lblCity.TabIndex = 538
      Me.lblCity.Text = "City:"
      '
      'lblAddr2
      '
      Me.lblAddr2.AutoSize = True
      Me.lblAddr2.BackColor = System.Drawing.Color.Transparent
      Me.lblAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAddr2.Location = New System.Drawing.Point(11, 188)
      Me.lblAddr2.Name = "lblAddr2"
      Me.lblAddr2.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr2.TabIndex = 537
      Me.lblAddr2.Text = "Address Line 2:"
      '
      'txtAddr1
      '
      Me.txtAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAddr1.Location = New System.Drawing.Point(193, 150)
      Me.txtAddr1.Name = "txtAddr1"
      Me.txtAddr1.Size = New System.Drawing.Size(329, 26)
      Me.txtAddr1.TabIndex = 6
      '
      'lblAddr1
      '
      Me.lblAddr1.AutoSize = True
      Me.lblAddr1.BackColor = System.Drawing.Color.Transparent
      Me.lblAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAddr1.Location = New System.Drawing.Point(11, 153)
      Me.lblAddr1.Name = "lblAddr1"
      Me.lblAddr1.Size = New System.Drawing.Size(134, 20)
      Me.lblAddr1.TabIndex = 536
      Me.lblAddr1.Text = "Address Line 1:"
      '
      'btnAudit
      '
      Me.btnAudit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAudit.ForeColor = System.Drawing.Color.White
      Me.btnAudit.Location = New System.Drawing.Point(533, 355)
      Me.btnAudit.Name = "btnAudit"
      Me.btnAudit.Size = New System.Drawing.Size(156, 30)
      Me.btnAudit.TabIndex = 109
      Me.btnAudit.Text = "A&udit"
      Me.btnAudit.UseVisualStyleBackColor = False
      '
      'btnAccess
      '
      Me.btnAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAccess.ForeColor = System.Drawing.Color.White
      Me.btnAccess.Location = New System.Drawing.Point(533, 320)
      Me.btnAccess.Name = "btnAccess"
      Me.btnAccess.Size = New System.Drawing.Size(156, 30)
      Me.btnAccess.TabIndex = 108
      Me.btnAccess.Text = "Acc&ess Rights"
      Me.btnAccess.UseVisualStyleBackColor = False
      '
      'btnAttach
      '
      Me.btnAttach.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAttach.ForeColor = System.Drawing.Color.White
      Me.btnAttach.Location = New System.Drawing.Point(533, 285)
      Me.btnAttach.Name = "btnAttach"
      Me.btnAttach.Size = New System.Drawing.Size(156, 30)
      Me.btnAttach.TabIndex = 107
      Me.btnAttach.Text = "&Attachments"
      Me.btnAttach.UseVisualStyleBackColor = False
      '
      'btnNotes
      '
      Me.btnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNotes.ForeColor = System.Drawing.Color.White
      Me.btnNotes.Location = New System.Drawing.Point(533, 250)
      Me.btnNotes.Name = "btnNotes"
      Me.btnNotes.Size = New System.Drawing.Size(156, 30)
      Me.btnNotes.TabIndex = 106
      Me.btnNotes.Text = "No&tes"
      Me.btnNotes.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(533, 215)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 105
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(533, 180)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 104
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(533, 45)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'txtId
      '
      Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtId.Location = New System.Drawing.Point(193, 10)
      Me.txtId.Name = "txtId"
      Me.txtId.Size = New System.Drawing.Size(329, 26)
      Me.txtId.TabIndex = 1
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(12, 13)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(114, 20)
      Me.lblId.TabIndex = 534
      Me.lblId.Text = "Associate Id:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(533, 425)
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
      Me.btnNew.Location = New System.Drawing.Point(533, 10)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnCopyAdd
      '
      Me.btnCopyAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCopyAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCopyAdd.ForeColor = System.Drawing.Color.White
      Me.btnCopyAdd.Location = New System.Drawing.Point(533, 115)
      Me.btnCopyAdd.Name = "btnCopyAdd"
      Me.btnCopyAdd.Size = New System.Drawing.Size(156, 60)
      Me.btnCopyAdd.TabIndex = 103
      Me.btnCopyAdd.Text = "Cop&y Company Address"
      Me.btnCopyAdd.UseVisualStyleBackColor = False
      '
      'btnCompany
      '
      Me.btnCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCompany.Location = New System.Drawing.Point(487, 45)
      Me.btnCompany.Name = "btnCompany"
      Me.btnCompany.Size = New System.Drawing.Size(35, 26)
      Me.btnCompany.TabIndex = 3
      Me.btnCompany.Text = "..."
      Me.btnCompany.UseVisualStyleBackColor = True
      '
      'txtCompany
      '
      Me.txtCompany.BackColor = System.Drawing.Color.White
      Me.txtCompany.Enabled = False
      Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCompany.Location = New System.Drawing.Point(193, 45)
      Me.txtCompany.Name = "txtCompany"
      Me.txtCompany.Size = New System.Drawing.Size(329, 26)
      Me.txtCompany.TabIndex = 2
      '
      'lblCompany
      '
      Me.lblCompany.AutoSize = True
      Me.lblCompany.BackColor = System.Drawing.Color.Transparent
      Me.lblCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCompany.Location = New System.Drawing.Point(11, 48)
      Me.lblCompany.Name = "lblCompany"
      Me.lblCompany.Size = New System.Drawing.Size(88, 20)
      Me.lblCompany.TabIndex = 570
      Me.lblCompany.Text = "Company:"
      '
      'lblCountry
      '
      Me.lblCountry.AutoSize = True
      Me.lblCountry.BackColor = System.Drawing.Color.Transparent
      Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCountry.Location = New System.Drawing.Point(11, 258)
      Me.lblCountry.Name = "lblCountry"
      Me.lblCountry.Size = New System.Drawing.Size(71, 20)
      Me.lblCountry.TabIndex = 540
      Me.lblCountry.Text = "Country"
      '
      'cmbCountry
      '
      Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbCountry.FormattingEnabled = True
      Me.cmbCountry.Location = New System.Drawing.Point(193, 255)
      Me.cmbCountry.Name = "cmbCountry"
      Me.cmbCountry.Size = New System.Drawing.Size(329, 28)
      Me.cmbCountry.TabIndex = 9
      '
      'userfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(698, 607)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnCompany)
      Me.Controls.Add(Me.txtCompany)
      Me.Controls.Add(Me.lblCompany)
      Me.Controls.Add(Me.btnCopyAdd)
      Me.Controls.Add(Me.btnClearmr)
      Me.Controls.Add(Me.txtEmail)
      Me.Controls.Add(Me.lblEmail)
      Me.Controls.Add(Me.cmbActive)
      Me.Controls.Add(Me.lblActive)
      Me.Controls.Add(Me.cmbPassStatus)
      Me.Controls.Add(Me.lblPassStatus)
      Me.Controls.Add(Me.cmbRepLanguage)
      Me.Controls.Add(Me.lblRepLanguage)
      Me.Controls.Add(Me.txtLast)
      Me.Controls.Add(Me.lblLast)
      Me.Controls.Add(Me.txtFirst)
      Me.Controls.Add(Me.lblFirst)
      Me.Controls.Add(Me.cmbInpLanguage)
      Me.Controls.Add(Me.lblInpLanguage)
      Me.Controls.Add(Me.btnRecent)
      Me.Controls.Add(Me.cmbCountry)
      Me.Controls.Add(Me.cmbProvince)
      Me.Controls.Add(Me.txtCell)
      Me.Controls.Add(Me.lblCell)
      Me.Controls.Add(Me.txtPhone)
      Me.Controls.Add(Me.lblCountry)
      Me.Controls.Add(Me.lblPhone)
      Me.Controls.Add(Me.lblProvince)
      Me.Controls.Add(Me.txtPostal)
      Me.Controls.Add(Me.lblPostal)
      Me.Controls.Add(Me.txtAddr2)
      Me.Controls.Add(Me.txtCity)
      Me.Controls.Add(Me.lblCity)
      Me.Controls.Add(Me.lblAddr2)
      Me.Controls.Add(Me.txtAddr1)
      Me.Controls.Add(Me.lblAddr1)
      Me.Controls.Add(Me.btnAudit)
      Me.Controls.Add(Me.btnAccess)
      Me.Controls.Add(Me.btnAttach)
      Me.Controls.Add(Me.btnNotes)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.txtId)
      Me.Controls.Add(Me.lblId)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnNew)
      Me.Name = "userfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "User Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClearmr As System.Windows.Forms.Button
   Friend WithEvents txtEmail As System.Windows.Forms.TextBox
   Friend WithEvents lblEmail As System.Windows.Forms.Label
   Friend WithEvents cmbActive As System.Windows.Forms.ComboBox
   Friend WithEvents lblActive As System.Windows.Forms.Label
   Friend WithEvents cmbPassStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblPassStatus As System.Windows.Forms.Label
   Friend WithEvents cmbRepLanguage As System.Windows.Forms.ComboBox
   Friend WithEvents lblRepLanguage As System.Windows.Forms.Label
   Friend WithEvents txtLast As System.Windows.Forms.TextBox
   Friend WithEvents lblLast As System.Windows.Forms.Label
   Friend WithEvents txtFirst As System.Windows.Forms.TextBox
   Friend WithEvents lblFirst As System.Windows.Forms.Label
   Friend WithEvents cmbInpLanguage As System.Windows.Forms.ComboBox
   Friend WithEvents lblInpLanguage As System.Windows.Forms.Label
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
   Friend WithEvents txtCell As System.Windows.Forms.TextBox
   Friend WithEvents lblCell As System.Windows.Forms.Label
   Friend WithEvents txtPhone As System.Windows.Forms.TextBox
   Friend WithEvents lblPhone As System.Windows.Forms.Label
   Friend WithEvents lblProvince As System.Windows.Forms.Label
   Friend WithEvents txtPostal As System.Windows.Forms.TextBox
   Friend WithEvents lblPostal As System.Windows.Forms.Label
   Friend WithEvents txtAddr2 As System.Windows.Forms.TextBox
   Friend WithEvents txtCity As System.Windows.Forms.TextBox
   Friend WithEvents lblCity As System.Windows.Forms.Label
   Friend WithEvents lblAddr2 As System.Windows.Forms.Label
   Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
   Friend WithEvents lblAddr1 As System.Windows.Forms.Label
   Friend WithEvents btnAudit As System.Windows.Forms.Button
   Friend WithEvents btnAccess As System.Windows.Forms.Button
   Friend WithEvents btnAttach As System.Windows.Forms.Button
   Friend WithEvents btnNotes As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnCopyAdd As System.Windows.Forms.Button
   Friend WithEvents btnCompany As System.Windows.Forms.Button
   Friend WithEvents txtCompany As System.Windows.Forms.TextBox
   Friend WithEvents lblCompany As System.Windows.Forms.Label
   Friend WithEvents lblCountry As System.Windows.Forms.Label
   Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
End Class
