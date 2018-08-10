<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoicefrm
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
      Me.txtOrdNum = New System.Windows.Forms.TextBox()
      Me.lblOrdNum = New System.Windows.Forms.Label()
      Me.lblEmail = New System.Windows.Forms.Label()
      Me.txtEmail = New System.Windows.Forms.TextBox()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.lblDetails = New System.Windows.Forms.Label()
      Me.lstDetails = New System.Windows.Forms.ListView()
      Me.lstToBe = New System.Windows.Forms.ListView()
      Me.lblToBe = New System.Windows.Forms.Label()
      Me.lstInvoiced = New System.Windows.Forms.ListView()
      Me.lblInvoiced = New System.Windows.Forms.Label()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnMove = New System.Windows.Forms.Button()
      Me.btnEditDetail = New System.Windows.Forms.Button()
      Me.btnInvoice = New System.Windows.Forms.Button()
      Me.btnPrint = New System.Windows.Forms.Button()
      Me.btnView = New System.Windows.Forms.Button()
      Me.btnEmail = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.dpInvoiceDate = New System.Windows.Forms.DateTimePicker()
      Me.lblDate = New System.Windows.Forms.Label()
      Me.txtNotes = New System.Windows.Forms.TextBox()
      Me.lblNotes = New System.Windows.Forms.Label()
      Me.chkTaxFree = New System.Windows.Forms.CheckBox()
      Me.tpinvoices = New System.Windows.Forms.TabPage()
      Me.btnClose2 = New System.Windows.Forms.Button()
      Me.tpdetails = New System.Windows.Forms.TabPage()
      Me.txtInvNotes = New System.Windows.Forms.TextBox()
      Me.lblInvNotes = New System.Windows.Forms.Label()
      Me.tb = New System.Windows.Forms.TabControl()
      Me.btnCode = New System.Windows.Forms.Button()
      Me.txtCode = New System.Windows.Forms.TextBox()
      Me.lblCode = New System.Windows.Forms.Label()
      Me.btnRemovePromo = New System.Windows.Forms.Button()
      Me.tpinvoices.SuspendLayout()
      Me.tpdetails.SuspendLayout()
      Me.tb.SuspendLayout()
      Me.SuspendLayout()
      '
      'tmr
      '
      '
      'txtOrdNum
      '
      Me.txtOrdNum.Enabled = False
      Me.txtOrdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtOrdNum.ForeColor = System.Drawing.Color.Black
      Me.txtOrdNum.Location = New System.Drawing.Point(162, 18)
      Me.txtOrdNum.Name = "txtOrdNum"
      Me.txtOrdNum.ReadOnly = True
      Me.txtOrdNum.Size = New System.Drawing.Size(193, 26)
      Me.txtOrdNum.TabIndex = 990
      '
      'lblOrdNum
      '
      Me.lblOrdNum.AutoSize = True
      Me.lblOrdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblOrdNum.Location = New System.Drawing.Point(14, 21)
      Me.lblOrdNum.Name = "lblOrdNum"
      Me.lblOrdNum.Size = New System.Drawing.Size(74, 20)
      Me.lblOrdNum.TabIndex = 991
      Me.lblOrdNum.Text = "Order #:"
      '
      'lblEmail
      '
      Me.lblEmail.AutoSize = True
      Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEmail.Location = New System.Drawing.Point(14, 54)
      Me.lblEmail.Name = "lblEmail"
      Me.lblEmail.Size = New System.Drawing.Size(120, 20)
      Me.lblEmail.TabIndex = 994
      Me.lblEmail.Text = "Invoice Email:"
      '
      'txtEmail
      '
      Me.txtEmail.Enabled = False
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtEmail.ForeColor = System.Drawing.Color.Black
      Me.txtEmail.Location = New System.Drawing.Point(162, 53)
      Me.txtEmail.Multiline = True
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.ReadOnly = True
      Me.txtEmail.Size = New System.Drawing.Size(352, 25)
      Me.txtEmail.TabIndex = 1008
      Me.txtEmail.TabStop = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(952, 28)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 100
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'lblDetails
      '
      Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDetails.Location = New System.Drawing.Point(15, 263)
      Me.lblDetails.Name = "lblDetails"
      Me.lblDetails.Size = New System.Drawing.Size(922, 14)
      Me.lblDetails.TabIndex = 1044
      Me.lblDetails.Text = "AVAILABLE SHIPPED ITEMS"
      Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'lstDetails
      '
      Me.lstDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
      Me.lstDetails.FullRowSelect = True
      Me.lstDetails.GridLines = True
      Me.lstDetails.Location = New System.Drawing.Point(18, 280)
      Me.lstDetails.MultiSelect = False
      Me.lstDetails.Name = "lstDetails"
      Me.lstDetails.Size = New System.Drawing.Size(919, 198)
      Me.lstDetails.TabIndex = 5
      Me.lstDetails.UseCompatibleStateImageBehavior = False
      '
      'lstToBe
      '
      Me.lstToBe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
      Me.lstToBe.FullRowSelect = True
      Me.lstToBe.GridLines = True
      Me.lstToBe.Location = New System.Drawing.Point(18, 497)
      Me.lstToBe.MultiSelect = False
      Me.lstToBe.Name = "lstToBe"
      Me.lstToBe.Size = New System.Drawing.Size(919, 198)
      Me.lstToBe.TabIndex = 6
      Me.lstToBe.UseCompatibleStateImageBehavior = False
      '
      'lblToBe
      '
      Me.lblToBe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblToBe.Location = New System.Drawing.Point(15, 480)
      Me.lblToBe.Name = "lblToBe"
      Me.lblToBe.Size = New System.Drawing.Size(922, 14)
      Me.lblToBe.TabIndex = 1044
      Me.lblToBe.Text = "ITEMS TO BE INVOICED"
      Me.lblToBe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'lstInvoiced
      '
      Me.lstInvoiced.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
      Me.lstInvoiced.FullRowSelect = True
      Me.lstInvoiced.GridLines = True
      Me.lstInvoiced.Location = New System.Drawing.Point(11, 22)
      Me.lstInvoiced.MultiSelect = False
      Me.lstInvoiced.Name = "lstInvoiced"
      Me.lstInvoiced.Size = New System.Drawing.Size(929, 673)
      Me.lstInvoiced.TabIndex = 107
      Me.lstInvoiced.UseCompatibleStateImageBehavior = False
      '
      'lblInvoiced
      '
      Me.lblInvoiced.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInvoiced.Location = New System.Drawing.Point(8, 3)
      Me.lblInvoiced.Name = "lblInvoiced"
      Me.lblInvoiced.Size = New System.Drawing.Size(932, 14)
      Me.lblInvoiced.TabIndex = 1044
      Me.lblInvoiced.Text = "INVOICES"
      Me.lblInvoiced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(952, 64)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(156, 30)
      Me.btnRecent.TabIndex = 101
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(952, 100)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 102
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnMove
      '
      Me.btnMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnMove.ForeColor = System.Drawing.Color.White
      Me.btnMove.Location = New System.Drawing.Point(952, 278)
      Me.btnMove.Name = "btnMove"
      Me.btnMove.Size = New System.Drawing.Size(156, 30)
      Me.btnMove.TabIndex = 103
      Me.btnMove.Text = "&Move All"
      Me.btnMove.UseVisualStyleBackColor = False
      '
      'btnEditDetail
      '
      Me.btnEditDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEditDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEditDetail.ForeColor = System.Drawing.Color.White
      Me.btnEditDetail.Location = New System.Drawing.Point(952, 314)
      Me.btnEditDetail.Name = "btnEditDetail"
      Me.btnEditDetail.Size = New System.Drawing.Size(156, 30)
      Me.btnEditDetail.TabIndex = 104
      Me.btnEditDetail.Text = "&Edit Line"
      Me.btnEditDetail.UseVisualStyleBackColor = False
      '
      'btnInvoice
      '
      Me.btnInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnInvoice.ForeColor = System.Drawing.Color.White
      Me.btnInvoice.Location = New System.Drawing.Point(952, 497)
      Me.btnInvoice.Name = "btnInvoice"
      Me.btnInvoice.Size = New System.Drawing.Size(156, 30)
      Me.btnInvoice.TabIndex = 105
      Me.btnInvoice.Text = "&Invoice Items"
      Me.btnInvoice.UseVisualStyleBackColor = False
      '
      'btnPrint
      '
      Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnPrint.ForeColor = System.Drawing.Color.White
      Me.btnPrint.Location = New System.Drawing.Point(954, 22)
      Me.btnPrint.Name = "btnPrint"
      Me.btnPrint.Size = New System.Drawing.Size(156, 30)
      Me.btnPrint.TabIndex = 108
      Me.btnPrint.Text = "&Print"
      Me.btnPrint.UseVisualStyleBackColor = False
      '
      'btnView
      '
      Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnView.ForeColor = System.Drawing.Color.White
      Me.btnView.Location = New System.Drawing.Point(954, 58)
      Me.btnView.Name = "btnView"
      Me.btnView.Size = New System.Drawing.Size(156, 30)
      Me.btnView.TabIndex = 109
      Me.btnView.Text = "&View"
      Me.btnView.UseVisualStyleBackColor = False
      '
      'btnEmail
      '
      Me.btnEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEmail.ForeColor = System.Drawing.Color.White
      Me.btnEmail.Location = New System.Drawing.Point(954, 94)
      Me.btnEmail.Name = "btnEmail"
      Me.btnEmail.Size = New System.Drawing.Size(156, 30)
      Me.btnEmail.TabIndex = 110
      Me.btnEmail.Text = "&Email"
      Me.btnEmail.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(954, 130)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 111
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'dpInvoiceDate
      '
      Me.dpInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpInvoiceDate.Location = New System.Drawing.Point(162, 86)
      Me.dpInvoiceDate.Name = "dpInvoiceDate"
      Me.dpInvoiceDate.Size = New System.Drawing.Size(132, 26)
      Me.dpInvoiceDate.TabIndex = 1
      '
      'lblDate
      '
      Me.lblDate.AutoSize = True
      Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblDate.Location = New System.Drawing.Point(14, 86)
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Size = New System.Drawing.Size(115, 20)
      Me.lblDate.TabIndex = 1046
      Me.lblDate.Text = "Invoice Date:"
      '
      'txtNotes
      '
      Me.txtNotes.Enabled = False
      Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNotes.ForeColor = System.Drawing.Color.Black
      Me.txtNotes.Location = New System.Drawing.Point(528, 30)
      Me.txtNotes.Multiline = True
      Me.txtNotes.Name = "txtNotes"
      Me.txtNotes.ReadOnly = True
      Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtNotes.Size = New System.Drawing.Size(409, 86)
      Me.txtNotes.TabIndex = 1048
      Me.txtNotes.TabStop = False
      '
      'lblNotes
      '
      Me.lblNotes.AutoSize = True
      Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNotes.Location = New System.Drawing.Point(524, 10)
      Me.lblNotes.Name = "lblNotes"
      Me.lblNotes.Size = New System.Drawing.Size(111, 20)
      Me.lblNotes.TabIndex = 1047
      Me.lblNotes.Text = "Order Notes:"
      '
      'chkTaxFree
      '
      Me.chkTaxFree.AutoSize = True
      Me.chkTaxFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.chkTaxFree.Location = New System.Drawing.Point(952, 579)
      Me.chkTaxFree.Name = "chkTaxFree"
      Me.chkTaxFree.Size = New System.Drawing.Size(89, 20)
      Me.chkTaxFree.TabIndex = 106
      Me.chkTaxFree.Text = "Tax Free"
      Me.chkTaxFree.UseVisualStyleBackColor = True
      '
      'tpinvoices
      '
      Me.tpinvoices.BackColor = System.Drawing.Color.Transparent
      Me.tpinvoices.Controls.Add(Me.btnClose2)
      Me.tpinvoices.Controls.Add(Me.lstInvoiced)
      Me.tpinvoices.Controls.Add(Me.lblInvoiced)
      Me.tpinvoices.Controls.Add(Me.btnPrint)
      Me.tpinvoices.Controls.Add(Me.btnDelete)
      Me.tpinvoices.Controls.Add(Me.btnView)
      Me.tpinvoices.Controls.Add(Me.btnEmail)
      Me.tpinvoices.ForeColor = System.Drawing.Color.Black
      Me.tpinvoices.Location = New System.Drawing.Point(4, 28)
      Me.tpinvoices.Name = "tpinvoices"
      Me.tpinvoices.Padding = New System.Windows.Forms.Padding(3)
      Me.tpinvoices.Size = New System.Drawing.Size(1122, 701)
      Me.tpinvoices.TabIndex = 1
      Me.tpinvoices.Text = "Invoices"
      '
      'btnClose2
      '
      Me.btnClose2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose2.ForeColor = System.Drawing.Color.White
      Me.btnClose2.Location = New System.Drawing.Point(954, 166)
      Me.btnClose2.Name = "btnClose2"
      Me.btnClose2.Size = New System.Drawing.Size(156, 30)
      Me.btnClose2.TabIndex = 112
      Me.btnClose2.Text = "&Close"
      Me.btnClose2.UseVisualStyleBackColor = False
      '
      'tpdetails
      '
      Me.tpdetails.BackColor = System.Drawing.Color.Transparent
      Me.tpdetails.Controls.Add(Me.btnRemovePromo)
      Me.tpdetails.Controls.Add(Me.btnCode)
      Me.tpdetails.Controls.Add(Me.txtCode)
      Me.tpdetails.Controls.Add(Me.lblCode)
      Me.tpdetails.Controls.Add(Me.txtInvNotes)
      Me.tpdetails.Controls.Add(Me.lblInvNotes)
      Me.tpdetails.Controls.Add(Me.lstDetails)
      Me.tpdetails.Controls.Add(Me.chkTaxFree)
      Me.tpdetails.Controls.Add(Me.lstToBe)
      Me.tpdetails.Controls.Add(Me.txtNotes)
      Me.tpdetails.Controls.Add(Me.lblOrdNum)
      Me.tpdetails.Controls.Add(Me.lblNotes)
      Me.tpdetails.Controls.Add(Me.txtOrdNum)
      Me.tpdetails.Controls.Add(Me.dpInvoiceDate)
      Me.tpdetails.Controls.Add(Me.lblEmail)
      Me.tpdetails.Controls.Add(Me.lblDate)
      Me.tpdetails.Controls.Add(Me.txtEmail)
      Me.tpdetails.Controls.Add(Me.btnOpen)
      Me.tpdetails.Controls.Add(Me.lblToBe)
      Me.tpdetails.Controls.Add(Me.btnRecent)
      Me.tpdetails.Controls.Add(Me.lblDetails)
      Me.tpdetails.Controls.Add(Me.btnClose)
      Me.tpdetails.Controls.Add(Me.btnMove)
      Me.tpdetails.Controls.Add(Me.btnEditDetail)
      Me.tpdetails.Controls.Add(Me.btnInvoice)
      Me.tpdetails.Cursor = System.Windows.Forms.Cursors.Default
      Me.tpdetails.ForeColor = System.Drawing.Color.Black
      Me.tpdetails.Location = New System.Drawing.Point(4, 28)
      Me.tpdetails.Name = "tpdetails"
      Me.tpdetails.Padding = New System.Windows.Forms.Padding(3)
      Me.tpdetails.Size = New System.Drawing.Size(1122, 701)
      Me.tpdetails.TabIndex = 0
      Me.tpdetails.Text = "Available Details"
      '
      'txtInvNotes
      '
      Me.txtInvNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtInvNotes.ForeColor = System.Drawing.Color.Black
      Me.txtInvNotes.Location = New System.Drawing.Point(18, 172)
      Me.txtInvNotes.Multiline = True
      Me.txtInvNotes.Name = "txtInvNotes"
      Me.txtInvNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtInvNotes.Size = New System.Drawing.Size(919, 86)
      Me.txtInvNotes.TabIndex = 4
      Me.txtInvNotes.TabStop = False
      '
      'lblInvNotes
      '
      Me.lblInvNotes.AutoSize = True
      Me.lblInvNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblInvNotes.Location = New System.Drawing.Point(14, 149)
      Me.lblInvNotes.Name = "lblInvNotes"
      Me.lblInvNotes.Size = New System.Drawing.Size(123, 20)
      Me.lblInvNotes.TabIndex = 1049
      Me.lblInvNotes.Text = "Invoice Notes:"
      '
      'tb
      '
      Me.tb.Controls.Add(Me.tpdetails)
      Me.tb.Controls.Add(Me.tpinvoices)
      Me.tb.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
      Me.tb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tb.HotTrack = True
      Me.tb.ItemSize = New System.Drawing.Size(98, 24)
      Me.tb.Location = New System.Drawing.Point(2, 1)
      Me.tb.Name = "tb"
      Me.tb.SelectedIndex = 0
      Me.tb.Size = New System.Drawing.Size(1130, 733)
      Me.tb.TabIndex = 1050
      '
      'btnCode
      '
      Me.btnCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCode.ForeColor = System.Drawing.Color.White
      Me.btnCode.Location = New System.Drawing.Point(162, 121)
      Me.btnCode.Name = "btnCode"
      Me.btnCode.Size = New System.Drawing.Size(44, 25)
      Me.btnCode.TabIndex = 2
      Me.btnCode.Text = "..."
      Me.btnCode.UseVisualStyleBackColor = False
      '
      'txtCode
      '
      Me.txtCode.Enabled = False
      Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtCode.ForeColor = System.Drawing.Color.Black
      Me.txtCode.Location = New System.Drawing.Point(206, 121)
      Me.txtCode.Name = "txtCode"
      Me.txtCode.ReadOnly = True
      Me.txtCode.Size = New System.Drawing.Size(308, 26)
      Me.txtCode.TabIndex = 1051
      Me.txtCode.TabStop = False
      '
      'lblCode
      '
      Me.lblCode.AutoSize = True
      Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblCode.Location = New System.Drawing.Point(14, 121)
      Me.lblCode.Name = "lblCode"
      Me.lblCode.Size = New System.Drawing.Size(112, 20)
      Me.lblCode.TabIndex = 1052
      Me.lblCode.Text = "Promo Code:"
      '
      'btnRemovePromo
      '
      Me.btnRemovePromo.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRemovePromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
      Me.btnRemovePromo.ForeColor = System.Drawing.Color.White
      Me.btnRemovePromo.Location = New System.Drawing.Point(528, 117)
      Me.btnRemovePromo.Name = "btnRemovePromo"
      Me.btnRemovePromo.Size = New System.Drawing.Size(157, 30)
      Me.btnRemovePromo.TabIndex = 3
      Me.btnRemovePromo.Text = "&Remove Promo"
      Me.btnRemovePromo.UseVisualStyleBackColor = False
      '
      'invoicefrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1133, 733)
      Me.ControlBox = False
      Me.Controls.Add(Me.tb)
      Me.Name = "invoicefrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Invoicing"
      Me.tpinvoices.ResumeLayout(False)
      Me.tpdetails.ResumeLayout(False)
      Me.tpdetails.PerformLayout()
      Me.tb.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents txtOrdNum As System.Windows.Forms.TextBox
   Friend WithEvents lblOrdNum As System.Windows.Forms.Label
   Friend WithEvents lblEmail As System.Windows.Forms.Label
   Friend WithEvents txtEmail As System.Windows.Forms.TextBox
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents lblDetails As System.Windows.Forms.Label
   Friend WithEvents lstDetails As System.Windows.Forms.ListView
   Friend WithEvents lstToBe As System.Windows.Forms.ListView
   Friend WithEvents lblToBe As System.Windows.Forms.Label
   Friend WithEvents lstInvoiced As System.Windows.Forms.ListView
   Friend WithEvents lblInvoiced As System.Windows.Forms.Label
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnMove As System.Windows.Forms.Button
   Friend WithEvents btnEditDetail As System.Windows.Forms.Button
   Friend WithEvents btnInvoice As System.Windows.Forms.Button
   Friend WithEvents btnPrint As System.Windows.Forms.Button
   Friend WithEvents btnView As System.Windows.Forms.Button
   Friend WithEvents btnEmail As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents dpInvoiceDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblDate As System.Windows.Forms.Label
   Friend WithEvents txtNotes As System.Windows.Forms.TextBox
   Friend WithEvents lblNotes As System.Windows.Forms.Label
   Friend WithEvents chkTaxFree As System.Windows.Forms.CheckBox
   Friend WithEvents tpinvoices As System.Windows.Forms.TabPage
   Friend WithEvents tpdetails As System.Windows.Forms.TabPage
   Friend WithEvents tb As System.Windows.Forms.TabControl
   Friend WithEvents btnClose2 As System.Windows.Forms.Button
   Friend WithEvents txtInvNotes As System.Windows.Forms.TextBox
   Friend WithEvents lblInvNotes As System.Windows.Forms.Label
   Friend WithEvents btnCode As System.Windows.Forms.Button
   Friend WithEvents txtCode As System.Windows.Forms.TextBox
   Friend WithEvents lblCode As System.Windows.Forms.Label
   Friend WithEvents btnRemovePromo As System.Windows.Forms.Button
End Class
