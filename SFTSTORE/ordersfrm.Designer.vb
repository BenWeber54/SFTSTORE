<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordersfrm
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
      Me.dpOrderDate = New System.Windows.Forms.DateTimePicker()
      Me.lblDate = New System.Windows.Forms.Label()
      Me.btnCustomer = New System.Windows.Forms.Button()
      Me.txtAddress = New System.Windows.Forms.TextBox()
      Me.lblCustomer = New System.Windows.Forms.Label()
      Me.txtCustomer = New System.Windows.Forms.TextBox()
      Me.lblShipping = New System.Windows.Forms.Label()
      Me.btnAddress = New System.Windows.Forms.Button()
      Me.cmbStatus = New System.Windows.Forms.ComboBox()
      Me.lblStatus = New System.Windows.Forms.Label()
      Me.txtNotes = New System.Windows.Forms.TextBox()
      Me.lblNotes = New System.Windows.Forms.Label()
      Me.lblOrder = New System.Windows.Forms.Label()
      Me.txtOrder = New System.Windows.Forms.TextBox()
      Me.lblAddress = New System.Windows.Forms.Label()
      Me.lstDetails = New System.Windows.Forms.ListView()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnAdd = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.btnDeleteDetail = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.lblDetail = New System.Windows.Forms.Label()
      Me.lblCusNotes = New System.Windows.Forms.Label()
      Me.txtCusNotes = New System.Windows.Forms.TextBox()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.lblActive = New System.Windows.Forms.Label()
      Me.lblCompleted = New System.Windows.Forms.Label()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.lblOnHold = New System.Windows.Forms.Label()
      Me.TextBox3 = New System.Windows.Forms.TextBox()
      Me.lblCancelled = New System.Windows.Forms.Label()
      Me.TextBox4 = New System.Windows.Forms.TextBox()
      Me.btnCode = New System.Windows.Forms.Button()
      Me.txtCode = New System.Windows.Forms.TextBox()
      Me.lblCode = New System.Windows.Forms.Label()
      Me.btnRemovePromo = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'dpOrderDate
      '
      Me.dpOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpOrderDate.Location = New System.Drawing.Point(198, 43)
      Me.dpOrderDate.Name = "dpOrderDate"
      Me.dpOrderDate.Size = New System.Drawing.Size(132, 26)
      Me.dpOrderDate.TabIndex = 3
      '
      'lblDate
      '
      Me.lblDate.AutoSize = True
      Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblDate.Location = New System.Drawing.Point(6, 44)
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Size = New System.Drawing.Size(103, 20)
      Me.lblDate.TabIndex = 1004
      Me.lblDate.Text = "Order Date:"
      '
      'btnCustomer
      '
      Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCustomer.ForeColor = System.Drawing.Color.White
      Me.btnCustomer.Location = New System.Drawing.Point(148, 143)
      Me.btnCustomer.Name = "btnCustomer"
      Me.btnCustomer.Size = New System.Drawing.Size(44, 25)
      Me.btnCustomer.TabIndex = 6
      Me.btnCustomer.Text = "..."
      Me.btnCustomer.UseVisualStyleBackColor = False
      '
      'txtAddress
      '
      Me.txtAddress.Enabled = False
      Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtAddress.ForeColor = System.Drawing.Color.Black
      Me.txtAddress.Location = New System.Drawing.Point(198, 177)
      Me.txtAddress.Multiline = True
      Me.txtAddress.Name = "txtAddress"
      Me.txtAddress.ReadOnly = True
      Me.txtAddress.Size = New System.Drawing.Size(308, 123)
      Me.txtAddress.TabIndex = 1007
      Me.txtAddress.TabStop = False
      '
      'lblCustomer
      '
      Me.lblCustomer.AutoSize = True
      Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCustomer.Location = New System.Drawing.Point(6, 143)
      Me.lblCustomer.Name = "lblCustomer"
      Me.lblCustomer.Size = New System.Drawing.Size(91, 20)
      Me.lblCustomer.TabIndex = 1003
      Me.lblCustomer.Text = "Customer:"
      '
      'txtCustomer
      '
      Me.txtCustomer.Enabled = False
      Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCustomer.ForeColor = System.Drawing.Color.Black
      Me.txtCustomer.Location = New System.Drawing.Point(198, 143)
      Me.txtCustomer.Name = "txtCustomer"
      Me.txtCustomer.ReadOnly = True
      Me.txtCustomer.Size = New System.Drawing.Size(308, 26)
      Me.txtCustomer.TabIndex = 1001
      Me.txtCustomer.TabStop = False
      '
      'lblShipping
      '
      Me.lblShipping.AutoSize = True
      Me.lblShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblShipping.Location = New System.Drawing.Point(6, 177)
      Me.lblShipping.Name = "lblShipping"
      Me.lblShipping.Size = New System.Drawing.Size(79, 20)
      Me.lblShipping.TabIndex = 1004
      Me.lblShipping.Text = "Shipping"
      '
      'btnAddress
      '
      Me.btnAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddress.ForeColor = System.Drawing.Color.White
      Me.btnAddress.Location = New System.Drawing.Point(148, 176)
      Me.btnAddress.Name = "btnAddress"
      Me.btnAddress.Size = New System.Drawing.Size(44, 25)
      Me.btnAddress.TabIndex = 7
      Me.btnAddress.Text = "..."
      Me.btnAddress.UseVisualStyleBackColor = False
      '
      'cmbStatus
      '
      Me.cmbStatus.BackColor = System.Drawing.SystemColors.Window
      Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbStatus.FormattingEnabled = True
      Me.cmbStatus.Location = New System.Drawing.Point(198, 75)
      Me.cmbStatus.Name = "cmbStatus"
      Me.cmbStatus.Size = New System.Drawing.Size(308, 28)
      Me.cmbStatus.TabIndex = 4
      '
      'lblStatus
      '
      Me.lblStatus.AutoSize = True
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblStatus.ForeColor = System.Drawing.Color.Black
      Me.lblStatus.Location = New System.Drawing.Point(6, 77)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(117, 20)
      Me.lblStatus.TabIndex = 1018
      Me.lblStatus.Text = "Order Status:"
      '
      'txtNotes
      '
      Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNotes.ForeColor = System.Drawing.Color.Black
      Me.txtNotes.Location = New System.Drawing.Point(512, 32)
      Me.txtNotes.Multiline = True
      Me.txtNotes.Name = "txtNotes"
      Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtNotes.Size = New System.Drawing.Size(392, 137)
      Me.txtNotes.TabIndex = 8
      '
      'lblNotes
      '
      Me.lblNotes.AutoSize = True
      Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNotes.ForeColor = System.Drawing.Color.Black
      Me.lblNotes.Location = New System.Drawing.Point(512, 9)
      Me.lblNotes.Name = "lblNotes"
      Me.lblNotes.Size = New System.Drawing.Size(61, 20)
      Me.lblNotes.TabIndex = 1020
      Me.lblNotes.Text = "Notes:"
      '
      'lblOrder
      '
      Me.lblOrder.AutoSize = True
      Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblOrder.Location = New System.Drawing.Point(6, 11)
      Me.lblOrder.Name = "lblOrder"
      Me.lblOrder.Size = New System.Drawing.Size(126, 20)
      Me.lblOrder.TabIndex = 1003
      Me.lblOrder.Text = "Order Number:"
      '
      'txtOrder
      '
      Me.txtOrder.Enabled = False
      Me.txtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtOrder.ForeColor = System.Drawing.Color.Black
      Me.txtOrder.Location = New System.Drawing.Point(198, 11)
      Me.txtOrder.Name = "txtOrder"
      Me.txtOrder.ReadOnly = True
      Me.txtOrder.Size = New System.Drawing.Size(308, 26)
      Me.txtOrder.TabIndex = 1
      Me.txtOrder.TabStop = False
      '
      'lblAddress
      '
      Me.lblAddress.AutoSize = True
      Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblAddress.Location = New System.Drawing.Point(6, 202)
      Me.lblAddress.Name = "lblAddress"
      Me.lblAddress.Size = New System.Drawing.Size(80, 20)
      Me.lblAddress.TabIndex = 1004
      Me.lblAddress.Text = "Address:"
      '
      'lstDetails
      '
      Me.lstDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstDetails.FullRowSelect = True
      Me.lstDetails.GridLines = True
      Me.lstDetails.Location = New System.Drawing.Point(10, 325)
      Me.lstDetails.MultiSelect = False
      Me.lstDetails.Name = "lstDetails"
      Me.lstDetails.Size = New System.Drawing.Size(894, 311)
      Me.lstDetails.TabIndex = 9
      Me.lstDetails.UseCompatibleStateImageBehavior = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(918, 30)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(157, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(918, 66)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(157, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(918, 102)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(157, 30)
      Me.btnRecent.TabIndex = 102
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(918, 138)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(157, 30)
      Me.btnSave.TabIndex = 103
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(918, 174)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(157, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete Order"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnAdd
      '
      Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnAdd.ForeColor = System.Drawing.Color.White
      Me.btnAdd.Location = New System.Drawing.Point(918, 325)
      Me.btnAdd.Name = "btnAdd"
      Me.btnAdd.Size = New System.Drawing.Size(157, 30)
      Me.btnAdd.TabIndex = 107
      Me.btnAdd.Text = "&Add"
      Me.btnAdd.UseVisualStyleBackColor = False
      '
      'btnEdit
      '
      Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnEdit.ForeColor = System.Drawing.Color.White
      Me.btnEdit.Location = New System.Drawing.Point(918, 361)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(157, 30)
      Me.btnEdit.TabIndex = 108
      Me.btnEdit.Text = "&Edit"
      Me.btnEdit.UseVisualStyleBackColor = False
      '
      'btnDeleteDetail
      '
      Me.btnDeleteDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDeleteDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnDeleteDetail.ForeColor = System.Drawing.Color.White
      Me.btnDeleteDetail.Location = New System.Drawing.Point(918, 397)
      Me.btnDeleteDetail.Name = "btnDeleteDetail"
      Me.btnDeleteDetail.Size = New System.Drawing.Size(157, 30)
      Me.btnDeleteDetail.TabIndex = 109
      Me.btnDeleteDetail.Text = "Dele&te Detail"
      Me.btnDeleteDetail.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(918, 210)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(157, 30)
      Me.btnClose.TabIndex = 105
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblDetail
      '
      Me.lblDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblDetail.ForeColor = System.Drawing.Color.Black
      Me.lblDetail.Location = New System.Drawing.Point(7, 302)
      Me.lblDetail.Name = "lblDetail"
      Me.lblDetail.Size = New System.Drawing.Size(900, 20)
      Me.lblDetail.TabIndex = 1018
      Me.lblDetail.Text = "ORDER DETAILS"
      Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'lblCusNotes
      '
      Me.lblCusNotes.AutoSize = True
      Me.lblCusNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCusNotes.ForeColor = System.Drawing.Color.Black
      Me.lblCusNotes.Location = New System.Drawing.Point(512, 171)
      Me.lblCusNotes.Name = "lblCusNotes"
      Me.lblCusNotes.Size = New System.Drawing.Size(143, 20)
      Me.lblCusNotes.TabIndex = 1020
      Me.lblCusNotes.Text = "Customer Notes:"
      '
      'txtCusNotes
      '
      Me.txtCusNotes.Enabled = False
      Me.txtCusNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCusNotes.ForeColor = System.Drawing.Color.Black
      Me.txtCusNotes.Location = New System.Drawing.Point(512, 192)
      Me.txtCusNotes.Multiline = True
      Me.txtCusNotes.Name = "txtCusNotes"
      Me.txtCusNotes.ReadOnly = True
      Me.txtCusNotes.Size = New System.Drawing.Size(392, 108)
      Me.txtCusNotes.TabIndex = 7
      '
      'TextBox1
      '
      Me.TextBox1.BackColor = System.Drawing.Color.White
      Me.TextBox1.Enabled = False
      Me.TextBox1.Location = New System.Drawing.Point(918, 454)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(22, 20)
      Me.TextBox1.TabIndex = 1021
      '
      'lblActive
      '
      Me.lblActive.AutoSize = True
      Me.lblActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblActive.Location = New System.Drawing.Point(946, 454)
      Me.lblActive.Name = "lblActive"
      Me.lblActive.Size = New System.Drawing.Size(58, 20)
      Me.lblActive.TabIndex = 1004
      Me.lblActive.Text = "Active"
      '
      'lblCompleted
      '
      Me.lblCompleted.AutoSize = True
      Me.lblCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCompleted.Location = New System.Drawing.Point(946, 488)
      Me.lblCompleted.Name = "lblCompleted"
      Me.lblCompleted.Size = New System.Drawing.Size(95, 20)
      Me.lblCompleted.TabIndex = 1004
      Me.lblCompleted.Text = "Completed"
      '
      'TextBox2
      '
      Me.TextBox2.BackColor = System.Drawing.Color.Lime
      Me.TextBox2.Enabled = False
      Me.TextBox2.Location = New System.Drawing.Point(918, 488)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Size = New System.Drawing.Size(22, 20)
      Me.TextBox2.TabIndex = 1021
      '
      'lblOnHold
      '
      Me.lblOnHold.AutoSize = True
      Me.lblOnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblOnHold.Location = New System.Drawing.Point(946, 523)
      Me.lblOnHold.Name = "lblOnHold"
      Me.lblOnHold.Size = New System.Drawing.Size(74, 20)
      Me.lblOnHold.TabIndex = 1004
      Me.lblOnHold.Text = "On Hold"
      '
      'TextBox3
      '
      Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.TextBox3.Enabled = False
      Me.TextBox3.Location = New System.Drawing.Point(918, 523)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(22, 20)
      Me.TextBox3.TabIndex = 1021
      '
      'lblCancelled
      '
      Me.lblCancelled.AutoSize = True
      Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCancelled.Location = New System.Drawing.Point(946, 557)
      Me.lblCancelled.Name = "lblCancelled"
      Me.lblCancelled.Size = New System.Drawing.Size(88, 20)
      Me.lblCancelled.TabIndex = 1004
      Me.lblCancelled.Text = "Cancelled"
      '
      'TextBox4
      '
      Me.TextBox4.BackColor = System.Drawing.Color.Red
      Me.TextBox4.Enabled = False
      Me.TextBox4.Location = New System.Drawing.Point(918, 557)
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Size = New System.Drawing.Size(22, 20)
      Me.TextBox4.TabIndex = 1021
      '
      'btnCode
      '
      Me.btnCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCode.ForeColor = System.Drawing.Color.White
      Me.btnCode.Location = New System.Drawing.Point(148, 111)
      Me.btnCode.Name = "btnCode"
      Me.btnCode.Size = New System.Drawing.Size(44, 25)
      Me.btnCode.TabIndex = 5
      Me.btnCode.Text = "..."
      Me.btnCode.UseVisualStyleBackColor = False
      '
      'txtCode
      '
      Me.txtCode.Enabled = False
      Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCode.ForeColor = System.Drawing.Color.Black
      Me.txtCode.Location = New System.Drawing.Point(198, 111)
      Me.txtCode.Name = "txtCode"
      Me.txtCode.ReadOnly = True
      Me.txtCode.Size = New System.Drawing.Size(308, 26)
      Me.txtCode.TabIndex = 1023
      Me.txtCode.TabStop = False
      '
      'lblCode
      '
      Me.lblCode.AutoSize = True
      Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCode.Location = New System.Drawing.Point(6, 111)
      Me.lblCode.Name = "lblCode"
      Me.lblCode.Size = New System.Drawing.Size(112, 20)
      Me.lblCode.TabIndex = 1024
      Me.lblCode.Text = "Promo Code:"
      '
      'btnRemovePromo
      '
      Me.btnRemovePromo.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRemovePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnRemovePromo.ForeColor = System.Drawing.Color.White
      Me.btnRemovePromo.Location = New System.Drawing.Point(919, 260)
      Me.btnRemovePromo.Name = "btnRemovePromo"
      Me.btnRemovePromo.Size = New System.Drawing.Size(157, 30)
      Me.btnRemovePromo.TabIndex = 106
      Me.btnRemovePromo.Text = "&Remove Promo"
      Me.btnRemovePromo.UseVisualStyleBackColor = False
      '
      'ordersfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1088, 639)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnCode)
      Me.Controls.Add(Me.txtCode)
      Me.Controls.Add(Me.lblCode)
      Me.Controls.Add(Me.TextBox4)
      Me.Controls.Add(Me.TextBox3)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.btnDeleteDetail)
      Me.Controls.Add(Me.btnEdit)
      Me.Controls.Add(Me.btnRemovePromo)
      Me.Controls.Add(Me.btnAdd)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnRecent)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.lstDetails)
      Me.Controls.Add(Me.txtCusNotes)
      Me.Controls.Add(Me.lblCusNotes)
      Me.Controls.Add(Me.txtNotes)
      Me.Controls.Add(Me.lblNotes)
      Me.Controls.Add(Me.cmbStatus)
      Me.Controls.Add(Me.lblDetail)
      Me.Controls.Add(Me.lblStatus)
      Me.Controls.Add(Me.txtAddress)
      Me.Controls.Add(Me.btnAddress)
      Me.Controls.Add(Me.btnCustomer)
      Me.Controls.Add(Me.dpOrderDate)
      Me.Controls.Add(Me.lblCancelled)
      Me.Controls.Add(Me.lblOnHold)
      Me.Controls.Add(Me.lblCompleted)
      Me.Controls.Add(Me.lblActive)
      Me.Controls.Add(Me.lblAddress)
      Me.Controls.Add(Me.lblShipping)
      Me.Controls.Add(Me.lblDate)
      Me.Controls.Add(Me.txtCustomer)
      Me.Controls.Add(Me.lblCustomer)
      Me.Controls.Add(Me.txtOrder)
      Me.Controls.Add(Me.lblOrder)
      Me.Name = "ordersfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Order Maintenance"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents dpOrderDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblDate As System.Windows.Forms.Label
   Friend WithEvents btnCustomer As System.Windows.Forms.Button
   Friend WithEvents txtAddress As System.Windows.Forms.TextBox
   Friend WithEvents lblCustomer As System.Windows.Forms.Label
   Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
   Friend WithEvents lblShipping As System.Windows.Forms.Label
   Friend WithEvents btnAddress As System.Windows.Forms.Button
   Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblStatus As System.Windows.Forms.Label
   Friend WithEvents txtNotes As System.Windows.Forms.TextBox
   Friend WithEvents lblNotes As System.Windows.Forms.Label
   Friend WithEvents lblOrder As System.Windows.Forms.Label
   Friend WithEvents txtOrder As System.Windows.Forms.TextBox
   Friend WithEvents lblAddress As System.Windows.Forms.Label
   Friend WithEvents lstDetails As System.Windows.Forms.ListView
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents btnEdit As System.Windows.Forms.Button
   Friend WithEvents btnDeleteDetail As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblDetail As System.Windows.Forms.Label
   Friend WithEvents lblCusNotes As System.Windows.Forms.Label
   Friend WithEvents txtCusNotes As System.Windows.Forms.TextBox
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents lblActive As System.Windows.Forms.Label
   Friend WithEvents lblCompleted As System.Windows.Forms.Label
   Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
   Friend WithEvents lblOnHold As System.Windows.Forms.Label
   Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
   Friend WithEvents lblCancelled As System.Windows.Forms.Label
   Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
   Friend WithEvents btnCode As System.Windows.Forms.Button
   Friend WithEvents txtCode As System.Windows.Forms.TextBox
   Friend WithEvents lblCode As System.Windows.Forms.Label
   Friend WithEvents btnRemovePromo As System.Windows.Forms.Button
End Class
