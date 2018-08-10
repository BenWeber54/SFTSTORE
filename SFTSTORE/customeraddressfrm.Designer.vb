<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customeraddressfrm
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
      Me.lblMain = New System.Windows.Forms.Label()
      Me.chkMain = New System.Windows.Forms.CheckBox()
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
      'lblMain
      '
      Me.lblMain.AutoSize = True
      Me.lblMain.BackColor = System.Drawing.Color.Transparent
      Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMain.Location = New System.Drawing.Point(11, 295)
      Me.lblMain.Name = "lblMain"
      Me.lblMain.Size = New System.Drawing.Size(123, 20)
      Me.lblMain.TabIndex = 551
      Me.lblMain.Text = "Main Address:"
      '
      'chkMain
      '
      Me.chkMain.AutoSize = True
      Me.chkMain.Location = New System.Drawing.Point(193, 297)
      Me.chkMain.Name = "chkMain"
      Me.chkMain.Size = New System.Drawing.Size(15, 14)
      Me.chkMain.TabIndex = 553
      Me.chkMain.UseVisualStyleBackColor = True
      '
      'customeraddressfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(698, 332)
      Me.ControlBox = False
      Me.Controls.Add(Me.chkMain)
      Me.Controls.Add(Me.txtPostal)
      Me.Controls.Add(Me.txtCity)
      Me.Controls.Add(Me.txtAddr2)
      Me.Controls.Add(Me.lblAdd2)
      Me.Controls.Add(Me.txtAddr1)
      Me.Controls.Add(Me.lblAdd1)
      Me.Controls.Add(Me.txtName)
      Me.Controls.Add(Me.lblName)
      Me.Controls.Add(Me.lblMain)
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
      Me.Name = "customeraddressfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = " Customer Address Maintenance"
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
   Friend WithEvents lblMain As System.Windows.Forms.Label
   Friend WithEvents chkMain As System.Windows.Forms.CheckBox
End Class
