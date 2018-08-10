<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerfrm
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
      Me.txtFirst = New System.Windows.Forms.TextBox()
      Me.lblFirst = New System.Windows.Forms.Label()
      Me.cmbActive = New System.Windows.Forms.ComboBox()
      Me.lblActive = New System.Windows.Forms.Label()
      Me.cmbPassStatus = New System.Windows.Forms.ComboBox()
      Me.lblPassStatus = New System.Windows.Forms.Label()
      Me.cmbLanguage = New System.Windows.Forms.ComboBox()
      Me.lblLanguage = New System.Windows.Forms.Label()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.btnAudit = New System.Windows.Forms.Button()
      Me.btnAttach = New System.Windows.Forms.Button()
      Me.btnNotes = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.txtId = New System.Windows.Forms.TextBox()
      Me.lblId = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.lblVerified = New System.Windows.Forms.Label()
      Me.cmbVerified = New System.Windows.Forms.ComboBox()
      Me.btnAddress = New System.Windows.Forms.Button()
      Me.btnWish = New System.Windows.Forms.Button()
      Me.lblLast = New System.Windows.Forms.Label()
      Me.txtLast = New System.Windows.Forms.TextBox()
      Me.lblEmail = New System.Windows.Forms.Label()
      Me.txtEmail = New System.Windows.Forms.TextBox()
      Me.txtNotes = New System.Windows.Forms.TextBox()
      Me.lblNotes = New System.Windows.Forms.Label()
      Me.lblDisplay = New System.Windows.Forms.Label()
      Me.txtDisplay = New System.Windows.Forms.TextBox()
      Me.btnFeedback = New System.Windows.Forms.Button()
      Me.btnBilling = New System.Windows.Forms.Button()
      Me.lblActCode = New System.Windows.Forms.Label()
      Me.txtActCode = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'txtFirst
      '
      Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFirst.Location = New System.Drawing.Point(193, 83)
      Me.txtFirst.Name = "txtFirst"
      Me.txtFirst.Size = New System.Drawing.Size(383, 26)
      Me.txtFirst.TabIndex = 3
      '
      'lblFirst
      '
      Me.lblFirst.AutoSize = True
      Me.lblFirst.BackColor = System.Drawing.Color.Transparent
      Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFirst.Location = New System.Drawing.Point(11, 86)
      Me.lblFirst.Name = "lblFirst"
      Me.lblFirst.Size = New System.Drawing.Size(101, 20)
      Me.lblFirst.TabIndex = 552
      Me.lblFirst.Text = "First Name:"
      '
      'cmbActive
      '
      Me.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbActive.FormattingEnabled = True
      Me.cmbActive.Location = New System.Drawing.Point(193, 258)
      Me.cmbActive.Name = "cmbActive"
      Me.cmbActive.Size = New System.Drawing.Size(383, 28)
      Me.cmbActive.TabIndex = 8
      '
      'lblActive
      '
      Me.lblActive.AutoSize = True
      Me.lblActive.BackColor = System.Drawing.Color.Transparent
      Me.lblActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblActive.Location = New System.Drawing.Point(11, 261)
      Me.lblActive.Name = "lblActive"
      Me.lblActive.Size = New System.Drawing.Size(149, 20)
      Me.lblActive.TabIndex = 551
      Me.lblActive.Text = "Customer Status:"
      '
      'cmbPassStatus
      '
      Me.cmbPassStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbPassStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbPassStatus.FormattingEnabled = True
      Me.cmbPassStatus.Location = New System.Drawing.Point(193, 223)
      Me.cmbPassStatus.Name = "cmbPassStatus"
      Me.cmbPassStatus.Size = New System.Drawing.Size(383, 28)
      Me.cmbPassStatus.TabIndex = 7
      '
      'lblPassStatus
      '
      Me.lblPassStatus.AutoSize = True
      Me.lblPassStatus.BackColor = System.Drawing.Color.Transparent
      Me.lblPassStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPassStatus.Location = New System.Drawing.Point(11, 226)
      Me.lblPassStatus.Name = "lblPassStatus"
      Me.lblPassStatus.Size = New System.Drawing.Size(149, 20)
      Me.lblPassStatus.TabIndex = 549
      Me.lblPassStatus.Text = "Password Status:"
      '
      'cmbLanguage
      '
      Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbLanguage.FormattingEnabled = True
      Me.cmbLanguage.Location = New System.Drawing.Point(193, 188)
      Me.cmbLanguage.Name = "cmbLanguage"
      Me.cmbLanguage.Size = New System.Drawing.Size(383, 28)
      Me.cmbLanguage.TabIndex = 6
      '
      'lblLanguage
      '
      Me.lblLanguage.AutoSize = True
      Me.lblLanguage.BackColor = System.Drawing.Color.Transparent
      Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLanguage.Location = New System.Drawing.Point(11, 191)
      Me.lblLanguage.Name = "lblLanguage"
      Me.lblLanguage.Size = New System.Drawing.Size(141, 20)
      Me.lblLanguage.TabIndex = 544
      Me.lblLanguage.Text = "Input Language:"
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(582, 81)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(166, 30)
      Me.btnRecent.TabIndex = 102
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'btnAudit
      '
      Me.btnAudit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnAudit.ForeColor = System.Drawing.Color.White
      Me.btnAudit.Location = New System.Drawing.Point(582, 396)
      Me.btnAudit.Name = "btnAudit"
      Me.btnAudit.Size = New System.Drawing.Size(166, 30)
      Me.btnAudit.TabIndex = 109
      Me.btnAudit.Text = "Aud&it"
      Me.btnAudit.UseVisualStyleBackColor = False
      '
      'btnAttach
      '
      Me.btnAttach.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnAttach.ForeColor = System.Drawing.Color.White
      Me.btnAttach.Location = New System.Drawing.Point(582, 361)
      Me.btnAttach.Name = "btnAttach"
      Me.btnAttach.Size = New System.Drawing.Size(166, 30)
      Me.btnAttach.TabIndex = 108
      Me.btnAttach.Text = "Attac&hments"
      Me.btnAttach.UseVisualStyleBackColor = False
      '
      'btnNotes
      '
      Me.btnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnNotes.ForeColor = System.Drawing.Color.White
      Me.btnNotes.Location = New System.Drawing.Point(582, 326)
      Me.btnNotes.Name = "btnNotes"
      Me.btnNotes.Size = New System.Drawing.Size(166, 30)
      Me.btnNotes.TabIndex = 107
      Me.btnNotes.Text = "No&tes"
      Me.btnNotes.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(582, 151)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(166, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(582, 116)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(166, 30)
      Me.btnSave.TabIndex = 103
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(582, 46)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(166, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'txtId
      '
      Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtId.Location = New System.Drawing.Point(193, 13)
      Me.txtId.Name = "txtId"
      Me.txtId.Size = New System.Drawing.Size(383, 26)
      Me.txtId.TabIndex = 1
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(11, 16)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(112, 20)
      Me.lblId.TabIndex = 534
      Me.lblId.Text = "Customer Id:"
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(582, 431)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(166, 30)
      Me.btnClose.TabIndex = 110
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(582, 11)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(166, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'lblVerified
      '
      Me.lblVerified.AutoSize = True
      Me.lblVerified.BackColor = System.Drawing.Color.Transparent
      Me.lblVerified.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblVerified.Location = New System.Drawing.Point(11, 296)
      Me.lblVerified.Name = "lblVerified"
      Me.lblVerified.Size = New System.Drawing.Size(158, 20)
      Me.lblVerified.TabIndex = 551
      Me.lblVerified.Text = "Customer Verified:"
      '
      'cmbVerified
      '
      Me.cmbVerified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbVerified.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbVerified.FormattingEnabled = True
      Me.cmbVerified.Location = New System.Drawing.Point(193, 293)
      Me.cmbVerified.Name = "cmbVerified"
      Me.cmbVerified.Size = New System.Drawing.Size(383, 28)
      Me.cmbVerified.TabIndex = 9
      '
      'btnAddress
      '
      Me.btnAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnAddress.ForeColor = System.Drawing.Color.White
      Me.btnAddress.Location = New System.Drawing.Point(582, 221)
      Me.btnAddress.Name = "btnAddress"
      Me.btnAddress.Size = New System.Drawing.Size(166, 30)
      Me.btnAddress.TabIndex = 105
      Me.btnAddress.Text = "&Address"
      Me.btnAddress.UseVisualStyleBackColor = False
      '
      'btnWish
      '
      Me.btnWish.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnWish.ForeColor = System.Drawing.Color.White
      Me.btnWish.Location = New System.Drawing.Point(582, 256)
      Me.btnWish.Name = "btnWish"
      Me.btnWish.Size = New System.Drawing.Size(166, 30)
      Me.btnWish.TabIndex = 106
      Me.btnWish.Text = "&Wishlist"
      Me.btnWish.UseVisualStyleBackColor = False
      '
      'lblLast
      '
      Me.lblLast.AutoSize = True
      Me.lblLast.BackColor = System.Drawing.Color.Transparent
      Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLast.Location = New System.Drawing.Point(11, 121)
      Me.lblLast.Name = "lblLast"
      Me.lblLast.Size = New System.Drawing.Size(100, 20)
      Me.lblLast.TabIndex = 552
      Me.lblLast.Text = "Last Name:"
      '
      'txtLast
      '
      Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLast.Location = New System.Drawing.Point(193, 118)
      Me.txtLast.Name = "txtLast"
      Me.txtLast.Size = New System.Drawing.Size(383, 26)
      Me.txtLast.TabIndex = 4
      '
      'lblEmail
      '
      Me.lblEmail.AutoSize = True
      Me.lblEmail.BackColor = System.Drawing.Color.Transparent
      Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEmail.Location = New System.Drawing.Point(11, 156)
      Me.lblEmail.Name = "lblEmail"
      Me.lblEmail.Size = New System.Drawing.Size(58, 20)
      Me.lblEmail.TabIndex = 552
      Me.lblEmail.Text = "Email:"
      '
      'txtEmail
      '
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmail.Location = New System.Drawing.Point(193, 153)
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Size = New System.Drawing.Size(383, 26)
      Me.txtEmail.TabIndex = 5
      '
      'txtNotes
      '
      Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNotes.ForeColor = System.Drawing.Color.Black
      Me.txtNotes.Location = New System.Drawing.Point(15, 382)
      Me.txtNotes.Multiline = True
      Me.txtNotes.Name = "txtNotes"
      Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtNotes.Size = New System.Drawing.Size(561, 113)
      Me.txtNotes.TabIndex = 11
      '
      'lblNotes
      '
      Me.lblNotes.AutoSize = True
      Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNotes.ForeColor = System.Drawing.Color.Black
      Me.lblNotes.Location = New System.Drawing.Point(11, 359)
      Me.lblNotes.Name = "lblNotes"
      Me.lblNotes.Size = New System.Drawing.Size(61, 20)
      Me.lblNotes.TabIndex = 1022
      Me.lblNotes.Text = "Notes:"
      '
      'lblDisplay
      '
      Me.lblDisplay.AutoSize = True
      Me.lblDisplay.BackColor = System.Drawing.Color.Transparent
      Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDisplay.Location = New System.Drawing.Point(11, 51)
      Me.lblDisplay.Name = "lblDisplay"
      Me.lblDisplay.Size = New System.Drawing.Size(123, 20)
      Me.lblDisplay.TabIndex = 552
      Me.lblDisplay.Text = "Display Name:"
      '
      'txtDisplay
      '
      Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDisplay.Location = New System.Drawing.Point(193, 48)
      Me.txtDisplay.Name = "txtDisplay"
      Me.txtDisplay.Size = New System.Drawing.Size(383, 26)
      Me.txtDisplay.TabIndex = 2
      '
      'btnFeedback
      '
      Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnFeedback.ForeColor = System.Drawing.Color.White
      Me.btnFeedback.Location = New System.Drawing.Point(582, 291)
      Me.btnFeedback.Name = "btnFeedback"
      Me.btnFeedback.Size = New System.Drawing.Size(166, 30)
      Me.btnFeedback.TabIndex = 107
      Me.btnFeedback.Text = "Product &Feedback"
      Me.btnFeedback.UseVisualStyleBackColor = False
      '
      'btnBilling
      '
      Me.btnBilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnBilling.ForeColor = System.Drawing.Color.White
      Me.btnBilling.Location = New System.Drawing.Point(582, 186)
      Me.btnBilling.Name = "btnBilling"
      Me.btnBilling.Size = New System.Drawing.Size(166, 30)
      Me.btnBilling.TabIndex = 105
      Me.btnBilling.Text = "&Billing"
      Me.btnBilling.UseVisualStyleBackColor = False
      '
      'lblActCode
      '
      Me.lblActCode.AutoSize = True
      Me.lblActCode.BackColor = System.Drawing.Color.Transparent
      Me.lblActCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblActCode.Location = New System.Drawing.Point(11, 330)
      Me.lblActCode.Name = "lblActCode"
      Me.lblActCode.Size = New System.Drawing.Size(140, 20)
      Me.lblActCode.TabIndex = 552
      Me.lblActCode.Text = "Activation Code:"
      '
      'txtActCode
      '
      Me.txtActCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtActCode.Location = New System.Drawing.Point(193, 327)
      Me.txtActCode.Name = "txtActCode"
      Me.txtActCode.Size = New System.Drawing.Size(383, 26)
      Me.txtActCode.TabIndex = 10
      '
      'customerfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(760, 507)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtNotes)
      Me.Controls.Add(Me.lblNotes)
      Me.Controls.Add(Me.txtActCode)
      Me.Controls.Add(Me.lblActCode)
      Me.Controls.Add(Me.txtEmail)
      Me.Controls.Add(Me.lblEmail)
      Me.Controls.Add(Me.txtLast)
      Me.Controls.Add(Me.lblLast)
      Me.Controls.Add(Me.txtDisplay)
      Me.Controls.Add(Me.lblDisplay)
      Me.Controls.Add(Me.txtFirst)
      Me.Controls.Add(Me.lblFirst)
      Me.Controls.Add(Me.cmbVerified)
      Me.Controls.Add(Me.lblVerified)
      Me.Controls.Add(Me.cmbActive)
      Me.Controls.Add(Me.lblActive)
      Me.Controls.Add(Me.cmbPassStatus)
      Me.Controls.Add(Me.lblPassStatus)
      Me.Controls.Add(Me.cmbLanguage)
      Me.Controls.Add(Me.lblLanguage)
      Me.Controls.Add(Me.btnRecent)
      Me.Controls.Add(Me.btnAudit)
      Me.Controls.Add(Me.btnAttach)
      Me.Controls.Add(Me.btnWish)
      Me.Controls.Add(Me.btnBilling)
      Me.Controls.Add(Me.btnAddress)
      Me.Controls.Add(Me.btnFeedback)
      Me.Controls.Add(Me.btnNotes)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.txtId)
      Me.Controls.Add(Me.lblId)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnNew)
      Me.Name = "customerfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Customer Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents txtFirst As System.Windows.Forms.TextBox
   Friend WithEvents lblFirst As System.Windows.Forms.Label
   Friend WithEvents cmbActive As System.Windows.Forms.ComboBox
   Friend WithEvents lblActive As System.Windows.Forms.Label
   Friend WithEvents cmbPassStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblPassStatus As System.Windows.Forms.Label
   Friend WithEvents cmbLanguage As System.Windows.Forms.ComboBox
   Friend WithEvents lblLanguage As System.Windows.Forms.Label
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents btnAudit As System.Windows.Forms.Button
   Friend WithEvents btnAttach As System.Windows.Forms.Button
   Friend WithEvents btnNotes As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents lblVerified As System.Windows.Forms.Label
   Friend WithEvents cmbVerified As System.Windows.Forms.ComboBox
   Friend WithEvents btnAddress As System.Windows.Forms.Button
   Friend WithEvents btnWish As System.Windows.Forms.Button
   Friend WithEvents lblLast As System.Windows.Forms.Label
   Friend WithEvents txtLast As System.Windows.Forms.TextBox
   Friend WithEvents lblEmail As System.Windows.Forms.Label
   Friend WithEvents txtEmail As System.Windows.Forms.TextBox
   Friend WithEvents txtNotes As System.Windows.Forms.TextBox
   Friend WithEvents lblNotes As System.Windows.Forms.Label
   Friend WithEvents lblDisplay As System.Windows.Forms.Label
   Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
   Friend WithEvents btnFeedback As System.Windows.Forms.Button
   Friend WithEvents btnBilling As System.Windows.Forms.Button
   Friend WithEvents lblActCode As System.Windows.Forms.Label
   Friend WithEvents txtActCode As System.Windows.Forms.TextBox
End Class
