<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productsfrm
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
      Me.tb = New System.Windows.Forms.TabControl()
      Me.tppartslist = New System.Windows.Forms.TabPage()
      Me.lstSubTypes = New System.Windows.Forms.ListView()
      Me.btnRemoveType = New System.Windows.Forms.Button()
      Me.btnAddType = New System.Windows.Forms.Button()
      Me.chkTaxFree = New System.Windows.Forms.CheckBox()
      Me.tb1 = New System.Windows.Forms.TabControl()
      Me.tpcurrentprices = New System.Windows.Forms.TabPage()
      Me.lstPrices = New System.Windows.Forms.ListView()
      Me.btnNewPrice = New System.Windows.Forms.Button()
      Me.btnDeletePrice = New System.Windows.Forms.Button()
      Me.btnEditPrice = New System.Windows.Forms.Button()
      Me.tphistory = New System.Windows.Forms.TabPage()
      Me.txtPriceChanges = New System.Windows.Forms.TextBox()
      Me.cmbType = New System.Windows.Forms.ComboBox()
      Me.lblProdType = New System.Windows.Forms.Label()
      Me.btnEditProduct = New System.Windows.Forms.Button()
      Me.cmbProdStatus = New System.Windows.Forms.ComboBox()
      Me.lblProdStatus = New System.Windows.Forms.Label()
      Me.cmbSpecStatus = New System.Windows.Forms.ComboBox()
      Me.txtRemain = New System.Windows.Forms.TextBox()
      Me.lblTaxFree = New System.Windows.Forms.Label()
      Me.lblRemain = New System.Windows.Forms.Label()
      Me.txtProdName = New System.Windows.Forms.TextBox()
      Me.lblProdName = New System.Windows.Forms.Label()
      Me.dpEntry = New System.Windows.Forms.DateTimePicker()
      Me.lblSpecStatus = New System.Windows.Forms.Label()
      Me.lblEntry = New System.Windows.Forms.Label()
      Me.txtProdNumber = New System.Windows.Forms.TextBox()
      Me.lblSKU = New System.Windows.Forms.Label()
      Me.txtSKU = New System.Windows.Forms.TextBox()
      Me.lblSubTypes = New System.Windows.Forms.Label()
      Me.lblProdNum = New System.Windows.Forms.Label()
      Me.tpdetails = New System.Windows.Forms.TabPage()
      Me.txtSpecDesc = New System.Windows.Forms.TextBox()
      Me.lblSpecDesc = New System.Windows.Forms.Label()
      Me.txtProdDesc = New System.Windows.Forms.TextBox()
      Me.lblProdDesc = New System.Windows.Forms.Label()
      Me.txtProdDetail = New System.Windows.Forms.TextBox()
      Me.txtProDesc2 = New System.Windows.Forms.TextBox()
      Me.lblProdDetail = New System.Windows.Forms.Label()
      Me.lblProdDesc2 = New System.Windows.Forms.Label()
      Me.tpShipping = New System.Windows.Forms.TabPage()
      Me.btnConvert = New System.Windows.Forms.Button()
      Me.cmbSolo = New System.Windows.Forms.ComboBox()
      Me.cmbPackaged = New System.Windows.Forms.ComboBox()
      Me.btnShipBox = New System.Windows.Forms.Button()
      Me.btnAddress = New System.Windows.Forms.Button()
      Me.txtShipBox = New System.Windows.Forms.TextBox()
      Me.txtAddress = New System.Windows.Forms.TextBox()
      Me.lblAddress = New System.Windows.Forms.Label()
      Me.txtMaterial = New System.Windows.Forms.TextBox()
      Me.txtHeight = New System.Windows.Forms.TextBox()
      Me.lblHeight2 = New System.Windows.Forms.Label()
      Me.txtWidth = New System.Windows.Forms.TextBox()
      Me.lblShipBox = New System.Windows.Forms.Label()
      Me.lblSolo = New System.Windows.Forms.Label()
      Me.lblWidth2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.lblMaterial = New System.Windows.Forms.Label()
      Me.txtLength = New System.Windows.Forms.TextBox()
      Me.lblHeight = New System.Windows.Forms.Label()
      Me.lblHeight3 = New System.Windows.Forms.Label()
      Me.lblWidth3 = New System.Windows.Forms.Label()
      Me.lblLength3 = New System.Windows.Forms.Label()
      Me.lblLength2 = New System.Windows.Forms.Label()
      Me.lblWidth = New System.Windows.Forms.Label()
      Me.txtWeight = New System.Windows.Forms.TextBox()
      Me.lblLength = New System.Windows.Forms.Label()
      Me.lblUnit = New System.Windows.Forms.Label()
      Me.lblWeight = New System.Windows.Forms.Label()
      Me.btnPanel = New System.Windows.Forms.Panel()
      Me.btnAudit = New System.Windows.Forms.Button()
      Me.btnFeedback = New System.Windows.Forms.Button()
      Me.btnImage = New System.Windows.Forms.Button()
      Me.btnQuantity = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.tb.SuspendLayout()
      Me.tppartslist.SuspendLayout()
      Me.tb1.SuspendLayout()
      Me.tpcurrentprices.SuspendLayout()
      Me.tphistory.SuspendLayout()
      Me.tpdetails.SuspendLayout()
      Me.tpShipping.SuspendLayout()
      Me.btnPanel.SuspendLayout()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'tb
      '
      Me.tb.Controls.Add(Me.tppartslist)
      Me.tb.Controls.Add(Me.tpdetails)
      Me.tb.Controls.Add(Me.tpShipping)
      Me.tb.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
      Me.tb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tb.HotTrack = True
      Me.tb.ItemSize = New System.Drawing.Size(98, 24)
      Me.tb.Location = New System.Drawing.Point(1, 6)
      Me.tb.Name = "tb"
      Me.tb.SelectedIndex = 0
      Me.tb.Size = New System.Drawing.Size(1085, 639)
      Me.tb.TabIndex = 1002
      '
      'tppartslist
      '
      Me.tppartslist.BackColor = System.Drawing.Color.Transparent
      Me.tppartslist.Controls.Add(Me.lstSubTypes)
      Me.tppartslist.Controls.Add(Me.btnRemoveType)
      Me.tppartslist.Controls.Add(Me.btnAddType)
      Me.tppartslist.Controls.Add(Me.chkTaxFree)
      Me.tppartslist.Controls.Add(Me.tb1)
      Me.tppartslist.Controls.Add(Me.cmbType)
      Me.tppartslist.Controls.Add(Me.lblProdType)
      Me.tppartslist.Controls.Add(Me.btnEditProduct)
      Me.tppartslist.Controls.Add(Me.cmbProdStatus)
      Me.tppartslist.Controls.Add(Me.lblProdStatus)
      Me.tppartslist.Controls.Add(Me.cmbSpecStatus)
      Me.tppartslist.Controls.Add(Me.txtRemain)
      Me.tppartslist.Controls.Add(Me.lblTaxFree)
      Me.tppartslist.Controls.Add(Me.lblRemain)
      Me.tppartslist.Controls.Add(Me.txtProdName)
      Me.tppartslist.Controls.Add(Me.lblProdName)
      Me.tppartslist.Controls.Add(Me.dpEntry)
      Me.tppartslist.Controls.Add(Me.lblSpecStatus)
      Me.tppartslist.Controls.Add(Me.lblEntry)
      Me.tppartslist.Controls.Add(Me.txtProdNumber)
      Me.tppartslist.Controls.Add(Me.lblSKU)
      Me.tppartslist.Controls.Add(Me.txtSKU)
      Me.tppartslist.Controls.Add(Me.lblSubTypes)
      Me.tppartslist.Controls.Add(Me.lblProdNum)
      Me.tppartslist.Cursor = System.Windows.Forms.Cursors.Default
      Me.tppartslist.ForeColor = System.Drawing.Color.Black
      Me.tppartslist.Location = New System.Drawing.Point(4, 28)
      Me.tppartslist.Name = "tppartslist"
      Me.tppartslist.Padding = New System.Windows.Forms.Padding(3)
      Me.tppartslist.Size = New System.Drawing.Size(1077, 607)
      Me.tppartslist.TabIndex = 0
      Me.tppartslist.Text = "Product Info"
      '
      'lstSubTypes
      '
      Me.lstSubTypes.FullRowSelect = True
      Me.lstSubTypes.GridLines = True
      Me.lstSubTypes.Location = New System.Drawing.Point(520, 74)
      Me.lstSubTypes.MultiSelect = False
      Me.lstSubTypes.Name = "lstSubTypes"
      Me.lstSubTypes.Size = New System.Drawing.Size(363, 326)
      Me.lstSubTypes.TabIndex = 1017
      Me.lstSubTypes.UseCompatibleStateImageBehavior = False
      '
      'btnRemoveType
      '
      Me.btnRemoveType.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRemoveType.Enabled = False
      Me.btnRemoveType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnRemoveType.ForeColor = System.Drawing.Color.White
      Me.btnRemoveType.Location = New System.Drawing.Point(389, 277)
      Me.btnRemoveType.Name = "btnRemoveType"
      Me.btnRemoveType.Size = New System.Drawing.Size(125, 30)
      Me.btnRemoveType.TabIndex = 10
      Me.btnRemoveType.Text = "Remove Type"
      Me.btnRemoveType.UseVisualStyleBackColor = False
      '
      'btnAddType
      '
      Me.btnAddType.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAddType.Enabled = False
      Me.btnAddType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnAddType.ForeColor = System.Drawing.Color.White
      Me.btnAddType.Location = New System.Drawing.Point(389, 241)
      Me.btnAddType.Name = "btnAddType"
      Me.btnAddType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.btnAddType.Size = New System.Drawing.Size(125, 30)
      Me.btnAddType.TabIndex = 10
      Me.btnAddType.Text = "Add Type"
      Me.btnAddType.UseVisualStyleBackColor = False
      '
      'chkTaxFree
      '
      Me.chkTaxFree.AutoSize = True
      Me.chkTaxFree.Location = New System.Drawing.Point(206, 250)
      Me.chkTaxFree.Name = "chkTaxFree"
      Me.chkTaxFree.Size = New System.Drawing.Size(15, 14)
      Me.chkTaxFree.TabIndex = 7
      Me.chkTaxFree.UseVisualStyleBackColor = True
      '
      'tb1
      '
      Me.tb1.Controls.Add(Me.tpcurrentprices)
      Me.tb1.Controls.Add(Me.tphistory)
      Me.tb1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
      Me.tb1.Location = New System.Drawing.Point(3, 406)
      Me.tb1.Name = "tb1"
      Me.tb1.SelectedIndex = 0
      Me.tb1.Size = New System.Drawing.Size(1071, 201)
      Me.tb1.TabIndex = 9
      '
      'tpcurrentprices
      '
      Me.tpcurrentprices.BackColor = System.Drawing.Color.Transparent
      Me.tpcurrentprices.Controls.Add(Me.lstPrices)
      Me.tpcurrentprices.Controls.Add(Me.btnNewPrice)
      Me.tpcurrentprices.Controls.Add(Me.btnDeletePrice)
      Me.tpcurrentprices.Controls.Add(Me.btnEditPrice)
      Me.tpcurrentprices.Location = New System.Drawing.Point(4, 25)
      Me.tpcurrentprices.Name = "tpcurrentprices"
      Me.tpcurrentprices.Padding = New System.Windows.Forms.Padding(3)
      Me.tpcurrentprices.Size = New System.Drawing.Size(1063, 172)
      Me.tpcurrentprices.TabIndex = 0
      Me.tpcurrentprices.Text = "Product Prices"
      '
      'lstPrices
      '
      Me.lstPrices.FullRowSelect = True
      Me.lstPrices.GridLines = True
      Me.lstPrices.Location = New System.Drawing.Point(2, 3)
      Me.lstPrices.MultiSelect = False
      Me.lstPrices.Name = "lstPrices"
      Me.lstPrices.Size = New System.Drawing.Size(902, 166)
      Me.lstPrices.TabIndex = 0
      Me.lstPrices.UseCompatibleStateImageBehavior = False
      '
      'btnNewPrice
      '
      Me.btnNewPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNewPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnNewPrice.ForeColor = System.Drawing.Color.White
      Me.btnNewPrice.Location = New System.Drawing.Point(928, 10)
      Me.btnNewPrice.Name = "btnNewPrice"
      Me.btnNewPrice.Size = New System.Drawing.Size(125, 30)
      Me.btnNewPrice.TabIndex = 10
      Me.btnNewPrice.Text = "Ne&w"
      Me.btnNewPrice.UseVisualStyleBackColor = False
      '
      'btnDeletePrice
      '
      Me.btnDeletePrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDeletePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnDeletePrice.ForeColor = System.Drawing.Color.White
      Me.btnDeletePrice.Location = New System.Drawing.Point(928, 80)
      Me.btnDeletePrice.Name = "btnDeletePrice"
      Me.btnDeletePrice.Size = New System.Drawing.Size(125, 30)
      Me.btnDeletePrice.TabIndex = 12
      Me.btnDeletePrice.Text = "Dele&te"
      Me.btnDeletePrice.UseVisualStyleBackColor = False
      '
      'btnEditPrice
      '
      Me.btnEditPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEditPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnEditPrice.ForeColor = System.Drawing.Color.White
      Me.btnEditPrice.Location = New System.Drawing.Point(928, 45)
      Me.btnEditPrice.Name = "btnEditPrice"
      Me.btnEditPrice.Size = New System.Drawing.Size(125, 30)
      Me.btnEditPrice.TabIndex = 11
      Me.btnEditPrice.Text = "&Edit"
      Me.btnEditPrice.UseVisualStyleBackColor = False
      '
      'tphistory
      '
      Me.tphistory.BackColor = System.Drawing.SystemColors.Control
      Me.tphistory.Controls.Add(Me.txtPriceChanges)
      Me.tphistory.Location = New System.Drawing.Point(4, 25)
      Me.tphistory.Name = "tphistory"
      Me.tphistory.Size = New System.Drawing.Size(1063, 172)
      Me.tphistory.TabIndex = 1
      Me.tphistory.Text = "Price History"
      '
      'txtPriceChanges
      '
      Me.txtPriceChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.txtPriceChanges.ForeColor = System.Drawing.Color.Black
      Me.txtPriceChanges.Location = New System.Drawing.Point(3, 0)
      Me.txtPriceChanges.Multiline = True
      Me.txtPriceChanges.Name = "txtPriceChanges"
      Me.txtPriceChanges.ReadOnly = True
      Me.txtPriceChanges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPriceChanges.Size = New System.Drawing.Size(1057, 169)
      Me.txtPriceChanges.TabIndex = 30
      '
      'cmbType
      '
      Me.cmbType.BackColor = System.Drawing.SystemColors.Window
      Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbType.FormattingEnabled = True
      Me.cmbType.Location = New System.Drawing.Point(206, 109)
      Me.cmbType.Name = "cmbType"
      Me.cmbType.Size = New System.Drawing.Size(308, 28)
      Me.cmbType.TabIndex = 4
      '
      'lblProdType
      '
      Me.lblProdType.AutoSize = True
      Me.lblProdType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdType.ForeColor = System.Drawing.Color.Black
      Me.lblProdType.Location = New System.Drawing.Point(14, 111)
      Me.lblProdType.Name = "lblProdType"
      Me.lblProdType.Size = New System.Drawing.Size(119, 20)
      Me.lblProdType.TabIndex = 1016
      Me.lblProdType.Text = "Product Type:"
      '
      'btnEditProduct
      '
      Me.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEditProduct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEditProduct.ForeColor = System.Drawing.Color.White
      Me.btnEditProduct.Location = New System.Drawing.Point(520, 10)
      Me.btnEditProduct.Name = "btnEditProduct"
      Me.btnEditProduct.Size = New System.Drawing.Size(111, 25)
      Me.btnEditProduct.TabIndex = 8
      Me.btnEditProduct.Text = "Edit Prod&uct #"
      Me.btnEditProduct.UseVisualStyleBackColor = False
      '
      'cmbProdStatus
      '
      Me.cmbProdStatus.BackColor = System.Drawing.SystemColors.Window
      Me.cmbProdStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProdStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbProdStatus.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbProdStatus.FormattingEnabled = True
      Me.cmbProdStatus.Location = New System.Drawing.Point(206, 179)
      Me.cmbProdStatus.Name = "cmbProdStatus"
      Me.cmbProdStatus.Size = New System.Drawing.Size(308, 28)
      Me.cmbProdStatus.TabIndex = 6
      '
      'lblProdStatus
      '
      Me.lblProdStatus.AutoSize = True
      Me.lblProdStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdStatus.ForeColor = System.Drawing.Color.Black
      Me.lblProdStatus.Location = New System.Drawing.Point(14, 181)
      Me.lblProdStatus.Name = "lblProdStatus"
      Me.lblProdStatus.Size = New System.Drawing.Size(134, 20)
      Me.lblProdStatus.TabIndex = 1010
      Me.lblProdStatus.Text = "Product Status:"
      '
      'cmbSpecStatus
      '
      Me.cmbSpecStatus.BackColor = System.Drawing.SystemColors.Window
      Me.cmbSpecStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbSpecStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbSpecStatus.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbSpecStatus.FormattingEnabled = True
      Me.cmbSpecStatus.Location = New System.Drawing.Point(206, 372)
      Me.cmbSpecStatus.Name = "cmbSpecStatus"
      Me.cmbSpecStatus.Size = New System.Drawing.Size(308, 28)
      Me.cmbSpecStatus.TabIndex = 7
      Me.cmbSpecStatus.Visible = False
      '
      'txtRemain
      '
      Me.txtRemain.Enabled = False
      Me.txtRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtRemain.ForeColor = System.Drawing.Color.Black
      Me.txtRemain.Location = New System.Drawing.Point(206, 213)
      Me.txtRemain.Name = "txtRemain"
      Me.txtRemain.ReadOnly = True
      Me.txtRemain.Size = New System.Drawing.Size(157, 26)
      Me.txtRemain.TabIndex = 4
      Me.txtRemain.TabStop = False
      '
      'lblTaxFree
      '
      Me.lblTaxFree.AutoSize = True
      Me.lblTaxFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblTaxFree.Location = New System.Drawing.Point(14, 245)
      Me.lblTaxFree.Name = "lblTaxFree"
      Me.lblTaxFree.Size = New System.Drawing.Size(84, 20)
      Me.lblTaxFree.TabIndex = 1007
      Me.lblTaxFree.Text = "Tax Free:"
      '
      'lblRemain
      '
      Me.lblRemain.AutoSize = True
      Me.lblRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblRemain.Location = New System.Drawing.Point(14, 215)
      Me.lblRemain.Name = "lblRemain"
      Me.lblRemain.Size = New System.Drawing.Size(166, 20)
      Me.lblRemain.TabIndex = 1007
      Me.lblRemain.Text = "Product Remaining:"
      '
      'txtProdName
      '
      Me.txtProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProdName.ForeColor = System.Drawing.Color.Black
      Me.txtProdName.Location = New System.Drawing.Point(206, 144)
      Me.txtProdName.Name = "txtProdName"
      Me.txtProdName.Size = New System.Drawing.Size(308, 26)
      Me.txtProdName.TabIndex = 5
      '
      'lblProdName
      '
      Me.lblProdName.AutoSize = True
      Me.lblProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdName.Location = New System.Drawing.Point(14, 146)
      Me.lblProdName.Name = "lblProdName"
      Me.lblProdName.Size = New System.Drawing.Size(127, 20)
      Me.lblProdName.TabIndex = 1007
      Me.lblProdName.Text = "Product Name:"
      '
      'dpEntry
      '
      Me.dpEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpEntry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpEntry.Location = New System.Drawing.Point(206, 74)
      Me.dpEntry.Name = "dpEntry"
      Me.dpEntry.Size = New System.Drawing.Size(132, 26)
      Me.dpEntry.TabIndex = 3
      Me.dpEntry.TabStop = False
      '
      'lblSpecStatus
      '
      Me.lblSpecStatus.AutoSize = True
      Me.lblSpecStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSpecStatus.Location = New System.Drawing.Point(14, 376)
      Me.lblSpecStatus.Name = "lblSpecStatus"
      Me.lblSpecStatus.Size = New System.Drawing.Size(131, 20)
      Me.lblSpecStatus.TabIndex = 1005
      Me.lblSpecStatus.Text = "Special Status:"
      Me.lblSpecStatus.Visible = False
      '
      'lblEntry
      '
      Me.lblEntry.AutoSize = True
      Me.lblEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEntry.Location = New System.Drawing.Point(14, 75)
      Me.lblEntry.Name = "lblEntry"
      Me.lblEntry.Size = New System.Drawing.Size(100, 20)
      Me.lblEntry.TabIndex = 1000
      Me.lblEntry.Text = "Entry Date:"
      '
      'txtProdNumber
      '
      Me.txtProdNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProdNumber.ForeColor = System.Drawing.Color.Black
      Me.txtProdNumber.Location = New System.Drawing.Point(206, 42)
      Me.txtProdNumber.Name = "txtProdNumber"
      Me.txtProdNumber.Size = New System.Drawing.Size(308, 26)
      Me.txtProdNumber.TabIndex = 2
      '
      'lblSKU
      '
      Me.lblSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSKU.Location = New System.Drawing.Point(14, 12)
      Me.lblSKU.Name = "lblSKU"
      Me.lblSKU.Size = New System.Drawing.Size(143, 20)
      Me.lblSKU.TabIndex = 989
      Me.lblSKU.Text = "Product SKU:"
      '
      'txtSKU
      '
      Me.txtSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtSKU.ForeColor = System.Drawing.Color.Black
      Me.txtSKU.Location = New System.Drawing.Point(206, 10)
      Me.txtSKU.Name = "txtSKU"
      Me.txtSKU.Size = New System.Drawing.Size(308, 26)
      Me.txtSKU.TabIndex = 1
      '
      'lblSubTypes
      '
      Me.lblSubTypes.AutoSize = True
      Me.lblSubTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSubTypes.Location = New System.Drawing.Point(520, 51)
      Me.lblSubTypes.Name = "lblSubTypes"
      Me.lblSubTypes.Size = New System.Drawing.Size(165, 20)
      Me.lblSubTypes.TabIndex = 989
      Me.lblSubTypes.Text = "Product Sub Types:"
      '
      'lblProdNum
      '
      Me.lblProdNum.AutoSize = True
      Me.lblProdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdNum.Location = New System.Drawing.Point(14, 44)
      Me.lblProdNum.Name = "lblProdNum"
      Me.lblProdNum.Size = New System.Drawing.Size(143, 20)
      Me.lblProdNum.TabIndex = 989
      Me.lblProdNum.Text = "Product Number:"
      '
      'tpdetails
      '
      Me.tpdetails.BackColor = System.Drawing.Color.Transparent
      Me.tpdetails.Controls.Add(Me.txtSpecDesc)
      Me.tpdetails.Controls.Add(Me.lblSpecDesc)
      Me.tpdetails.Controls.Add(Me.txtProdDesc)
      Me.tpdetails.Controls.Add(Me.lblProdDesc)
      Me.tpdetails.Controls.Add(Me.txtProdDetail)
      Me.tpdetails.Controls.Add(Me.txtProDesc2)
      Me.tpdetails.Controls.Add(Me.lblProdDetail)
      Me.tpdetails.Controls.Add(Me.lblProdDesc2)
      Me.tpdetails.ForeColor = System.Drawing.Color.Black
      Me.tpdetails.Location = New System.Drawing.Point(4, 28)
      Me.tpdetails.Name = "tpdetails"
      Me.tpdetails.Padding = New System.Windows.Forms.Padding(3)
      Me.tpdetails.Size = New System.Drawing.Size(1077, 607)
      Me.tpdetails.TabIndex = 1
      Me.tpdetails.Text = "Product Descriptions"
      '
      'txtSpecDesc
      '
      Me.txtSpecDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtSpecDesc.ForeColor = System.Drawing.Color.Black
      Me.txtSpecDesc.Location = New System.Drawing.Point(211, 436)
      Me.txtSpecDesc.Multiline = True
      Me.txtSpecDesc.Name = "txtSpecDesc"
      Me.txtSpecDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtSpecDesc.Size = New System.Drawing.Size(672, 161)
      Me.txtSpecDesc.TabIndex = 4
      '
      'lblSpecDesc
      '
      Me.lblSpecDesc.AutoSize = True
      Me.lblSpecDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSpecDesc.ForeColor = System.Drawing.Color.Black
      Me.lblSpecDesc.Location = New System.Drawing.Point(16, 436)
      Me.lblSpecDesc.Name = "lblSpecDesc"
      Me.lblSpecDesc.Size = New System.Drawing.Size(186, 20)
      Me.lblSpecDesc.TabIndex = 1020
      Me.lblSpecDesc.Text = "Product Special Desc:"
      '
      'txtProdDesc
      '
      Me.txtProdDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProdDesc.ForeColor = System.Drawing.Color.Black
      Me.txtProdDesc.Location = New System.Drawing.Point(211, 27)
      Me.txtProdDesc.Multiline = True
      Me.txtProdDesc.Name = "txtProdDesc"
      Me.txtProdDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtProdDesc.Size = New System.Drawing.Size(672, 123)
      Me.txtProdDesc.TabIndex = 1
      '
      'lblProdDesc
      '
      Me.lblProdDesc.AutoSize = True
      Me.lblProdDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdDesc.ForeColor = System.Drawing.Color.Black
      Me.lblProdDesc.Location = New System.Drawing.Point(16, 27)
      Me.lblProdDesc.Name = "lblProdDesc"
      Me.lblProdDesc.Size = New System.Drawing.Size(172, 20)
      Me.lblProdDesc.TabIndex = 997
      Me.lblProdDesc.Text = "Product Description:"
      '
      'txtProdDetail
      '
      Me.txtProdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProdDetail.ForeColor = System.Drawing.Color.Black
      Me.txtProdDetail.Location = New System.Drawing.Point(211, 285)
      Me.txtProdDetail.Multiline = True
      Me.txtProdDetail.Name = "txtProdDetail"
      Me.txtProdDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtProdDetail.Size = New System.Drawing.Size(672, 145)
      Me.txtProdDetail.TabIndex = 3
      '
      'txtProDesc2
      '
      Me.txtProDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtProDesc2.ForeColor = System.Drawing.Color.Black
      Me.txtProDesc2.Location = New System.Drawing.Point(211, 156)
      Me.txtProDesc2.Multiline = True
      Me.txtProDesc2.Name = "txtProDesc2"
      Me.txtProDesc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtProDesc2.Size = New System.Drawing.Size(672, 123)
      Me.txtProDesc2.TabIndex = 2
      '
      'lblProdDetail
      '
      Me.lblProdDetail.AutoSize = True
      Me.lblProdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdDetail.ForeColor = System.Drawing.Color.Black
      Me.lblProdDetail.Location = New System.Drawing.Point(16, 285)
      Me.lblProdDetail.Name = "lblProdDetail"
      Me.lblProdDetail.Size = New System.Drawing.Size(137, 20)
      Me.lblProdDetail.TabIndex = 995
      Me.lblProdDetail.Text = "Product Details:"
      '
      'lblProdDesc2
      '
      Me.lblProdDesc2.AutoSize = True
      Me.lblProdDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblProdDesc2.ForeColor = System.Drawing.Color.Black
      Me.lblProdDesc2.Location = New System.Drawing.Point(16, 156)
      Me.lblProdDesc2.Name = "lblProdDesc2"
      Me.lblProdDesc2.Size = New System.Drawing.Size(137, 20)
      Me.lblProdDesc2.TabIndex = 994
      Me.lblProdDesc2.Text = "Product Desc 2:"
      '
      'tpShipping
      '
      Me.tpShipping.BackColor = System.Drawing.Color.Transparent
      Me.tpShipping.Controls.Add(Me.btnConvert)
      Me.tpShipping.Controls.Add(Me.cmbSolo)
      Me.tpShipping.Controls.Add(Me.cmbPackaged)
      Me.tpShipping.Controls.Add(Me.btnShipBox)
      Me.tpShipping.Controls.Add(Me.btnAddress)
      Me.tpShipping.Controls.Add(Me.txtShipBox)
      Me.tpShipping.Controls.Add(Me.txtAddress)
      Me.tpShipping.Controls.Add(Me.lblAddress)
      Me.tpShipping.Controls.Add(Me.txtMaterial)
      Me.tpShipping.Controls.Add(Me.txtHeight)
      Me.tpShipping.Controls.Add(Me.lblHeight2)
      Me.tpShipping.Controls.Add(Me.txtWidth)
      Me.tpShipping.Controls.Add(Me.lblShipBox)
      Me.tpShipping.Controls.Add(Me.lblSolo)
      Me.tpShipping.Controls.Add(Me.lblWidth2)
      Me.tpShipping.Controls.Add(Me.Label1)
      Me.tpShipping.Controls.Add(Me.Label2)
      Me.tpShipping.Controls.Add(Me.lblMaterial)
      Me.tpShipping.Controls.Add(Me.txtLength)
      Me.tpShipping.Controls.Add(Me.lblHeight)
      Me.tpShipping.Controls.Add(Me.lblHeight3)
      Me.tpShipping.Controls.Add(Me.lblWidth3)
      Me.tpShipping.Controls.Add(Me.lblLength3)
      Me.tpShipping.Controls.Add(Me.lblLength2)
      Me.tpShipping.Controls.Add(Me.lblWidth)
      Me.tpShipping.Controls.Add(Me.txtWeight)
      Me.tpShipping.Controls.Add(Me.lblLength)
      Me.tpShipping.Controls.Add(Me.lblUnit)
      Me.tpShipping.Controls.Add(Me.lblWeight)
      Me.tpShipping.ForeColor = System.Drawing.Color.Black
      Me.tpShipping.Location = New System.Drawing.Point(4, 28)
      Me.tpShipping.Name = "tpShipping"
      Me.tpShipping.Size = New System.Drawing.Size(1077, 607)
      Me.tpShipping.TabIndex = 2
      Me.tpShipping.Text = "Shipping Details"
      '
      'btnConvert
      '
      Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnConvert.ForeColor = System.Drawing.Color.White
      Me.btnConvert.Location = New System.Drawing.Point(400, 22)
      Me.btnConvert.Name = "btnConvert"
      Me.btnConvert.Size = New System.Drawing.Size(156, 30)
      Me.btnConvert.TabIndex = 2
      Me.btnConvert.Text = "Convert lb &to Kg"
      Me.btnConvert.UseVisualStyleBackColor = False
      '
      'cmbSolo
      '
      Me.cmbSolo.BackColor = System.Drawing.SystemColors.Window
      Me.cmbSolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbSolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbSolo.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbSolo.FormattingEnabled = True
      Me.cmbSolo.Location = New System.Drawing.Point(201, 181)
      Me.cmbSolo.Name = "cmbSolo"
      Me.cmbSolo.Size = New System.Drawing.Size(135, 28)
      Me.cmbSolo.TabIndex = 6
      '
      'cmbPackaged
      '
      Me.cmbPackaged.BackColor = System.Drawing.SystemColors.Window
      Me.cmbPackaged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbPackaged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbPackaged.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbPackaged.FormattingEnabled = True
      Me.cmbPackaged.Location = New System.Drawing.Point(201, 147)
      Me.cmbPackaged.Name = "cmbPackaged"
      Me.cmbPackaged.Size = New System.Drawing.Size(227, 28)
      Me.cmbPackaged.TabIndex = 6
      '
      'btnShipBox
      '
      Me.btnShipBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShipBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnShipBox.ForeColor = System.Drawing.Color.White
      Me.btnShipBox.Location = New System.Drawing.Point(679, 183)
      Me.btnShipBox.Name = "btnShipBox"
      Me.btnShipBox.Size = New System.Drawing.Size(38, 25)
      Me.btnShipBox.TabIndex = 8
      Me.btnShipBox.Text = "..."
      Me.btnShipBox.UseVisualStyleBackColor = False
      Me.btnShipBox.Visible = False
      '
      'btnAddress
      '
      Me.btnAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddress.ForeColor = System.Drawing.Color.White
      Me.btnAddress.Location = New System.Drawing.Point(479, 247)
      Me.btnAddress.Name = "btnAddress"
      Me.btnAddress.Size = New System.Drawing.Size(38, 25)
      Me.btnAddress.TabIndex = 11
      Me.btnAddress.Text = "..."
      Me.btnAddress.UseVisualStyleBackColor = False
      Me.btnAddress.Visible = False
      '
      'txtShipBox
      '
      Me.txtShipBox.Enabled = False
      Me.txtShipBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtShipBox.ForeColor = System.Drawing.Color.Black
      Me.txtShipBox.Location = New System.Drawing.Point(485, 183)
      Me.txtShipBox.Name = "txtShipBox"
      Me.txtShipBox.Size = New System.Drawing.Size(188, 26)
      Me.txtShipBox.TabIndex = 7
      Me.txtShipBox.Visible = False
      '
      'txtAddress
      '
      Me.txtAddress.Enabled = False
      Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtAddress.ForeColor = System.Drawing.Color.Black
      Me.txtAddress.Location = New System.Drawing.Point(201, 247)
      Me.txtAddress.Name = "txtAddress"
      Me.txtAddress.Size = New System.Drawing.Size(273, 26)
      Me.txtAddress.TabIndex = 10
      Me.txtAddress.Visible = False
      '
      'lblAddress
      '
      Me.lblAddress.AutoSize = True
      Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblAddress.Location = New System.Drawing.Point(9, 249)
      Me.lblAddress.Name = "lblAddress"
      Me.lblAddress.Size = New System.Drawing.Size(159, 20)
      Me.lblAddress.TabIndex = 1022
      Me.lblAddress.Text = "Company Address:"
      Me.lblAddress.Visible = False
      '
      'txtMaterial
      '
      Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtMaterial.ForeColor = System.Drawing.Color.Black
      Me.txtMaterial.Location = New System.Drawing.Point(201, 215)
      Me.txtMaterial.Name = "txtMaterial"
      Me.txtMaterial.Size = New System.Drawing.Size(157, 26)
      Me.txtMaterial.TabIndex = 9
      '
      'txtHeight
      '
      Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtHeight.ForeColor = System.Drawing.Color.Black
      Me.txtHeight.Location = New System.Drawing.Point(201, 116)
      Me.txtHeight.Name = "txtHeight"
      Me.txtHeight.Size = New System.Drawing.Size(157, 26)
      Me.txtHeight.TabIndex = 5
      '
      'lblHeight2
      '
      Me.lblHeight2.AutoSize = True
      Me.lblHeight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight2.Location = New System.Drawing.Point(364, 119)
      Me.lblHeight2.Name = "lblHeight2"
      Me.lblHeight2.Size = New System.Drawing.Size(32, 20)
      Me.lblHeight2.TabIndex = 1012
      Me.lblHeight2.Text = "cm"
      '
      'txtWidth
      '
      Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtWidth.ForeColor = System.Drawing.Color.Black
      Me.txtWidth.Location = New System.Drawing.Point(201, 84)
      Me.txtWidth.Name = "txtWidth"
      Me.txtWidth.Size = New System.Drawing.Size(157, 26)
      Me.txtWidth.TabIndex = 4
      '
      'lblShipBox
      '
      Me.lblShipBox.AutoSize = True
      Me.lblShipBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblShipBox.Location = New System.Drawing.Point(345, 185)
      Me.lblShipBox.Name = "lblShipBox"
      Me.lblShipBox.Size = New System.Drawing.Size(119, 20)
      Me.lblShipBox.TabIndex = 1014
      Me.lblShipBox.Text = "Shipping Box:"
      Me.lblShipBox.Visible = False
      '
      'lblSolo
      '
      Me.lblSolo.AutoSize = True
      Me.lblSolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSolo.Location = New System.Drawing.Point(9, 185)
      Me.lblSolo.Name = "lblSolo"
      Me.lblSolo.Size = New System.Drawing.Size(144, 20)
      Me.lblSolo.TabIndex = 1014
      Me.lblSolo.Text = "Packaged Alone:"
      '
      'lblWidth2
      '
      Me.lblWidth2.AutoSize = True
      Me.lblWidth2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth2.Location = New System.Drawing.Point(364, 87)
      Me.lblWidth2.Name = "lblWidth2"
      Me.lblWidth2.Size = New System.Drawing.Size(32, 20)
      Me.lblWidth2.TabIndex = 1013
      Me.lblWidth2.Text = "cm"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label1.Location = New System.Drawing.Point(9, 151)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(93, 20)
      Me.Label1.TabIndex = 1014
      Me.Label1.Text = "Packaged:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label2.Location = New System.Drawing.Point(364, 218)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(24, 20)
      Me.Label2.TabIndex = 1014
      Me.Label2.Text = "%"
      '
      'lblMaterial
      '
      Me.lblMaterial.AutoSize = True
      Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblMaterial.Location = New System.Drawing.Point(9, 217)
      Me.lblMaterial.Name = "lblMaterial"
      Me.lblMaterial.Size = New System.Drawing.Size(146, 20)
      Me.lblMaterial.TabIndex = 1014
      Me.lblMaterial.Text = "Packing Material:"
      '
      'txtLength
      '
      Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtLength.ForeColor = System.Drawing.Color.Black
      Me.txtLength.Location = New System.Drawing.Point(201, 52)
      Me.txtLength.Name = "txtLength"
      Me.txtLength.Size = New System.Drawing.Size(157, 26)
      Me.txtLength.TabIndex = 3
      '
      'lblHeight
      '
      Me.lblHeight.AutoSize = True
      Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight.Location = New System.Drawing.Point(9, 118)
      Me.lblHeight.Name = "lblHeight"
      Me.lblHeight.Size = New System.Drawing.Size(67, 20)
      Me.lblHeight.TabIndex = 1014
      Me.lblHeight.Text = "Height:"
      '
      'lblHeight3
      '
      Me.lblHeight3.AutoSize = True
      Me.lblHeight3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight3.Location = New System.Drawing.Point(402, 119)
      Me.lblHeight3.Name = "lblHeight3"
      Me.lblHeight3.Size = New System.Drawing.Size(192, 20)
      Me.lblHeight3.TabIndex = 1015
      Me.lblHeight3.Text = "Shortest Measurement"
      '
      'lblWidth3
      '
      Me.lblWidth3.AutoSize = True
      Me.lblWidth3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth3.Location = New System.Drawing.Point(402, 87)
      Me.lblWidth3.Name = "lblWidth3"
      Me.lblWidth3.Size = New System.Drawing.Size(254, 20)
      Me.lblWidth3.TabIndex = 1015
      Me.lblWidth3.Text = "Second Longest Measurement"
      '
      'lblLength3
      '
      Me.lblLength3.AutoSize = True
      Me.lblLength3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength3.Location = New System.Drawing.Point(402, 55)
      Me.lblLength3.Name = "lblLength3"
      Me.lblLength3.Size = New System.Drawing.Size(188, 20)
      Me.lblLength3.TabIndex = 1015
      Me.lblLength3.Text = "Longest Measurement"
      '
      'lblLength2
      '
      Me.lblLength2.AutoSize = True
      Me.lblLength2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength2.Location = New System.Drawing.Point(364, 55)
      Me.lblLength2.Name = "lblLength2"
      Me.lblLength2.Size = New System.Drawing.Size(32, 20)
      Me.lblLength2.TabIndex = 1015
      Me.lblLength2.Text = "cm"
      '
      'lblWidth
      '
      Me.lblWidth.AutoSize = True
      Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth.Location = New System.Drawing.Point(9, 86)
      Me.lblWidth.Name = "lblWidth"
      Me.lblWidth.Size = New System.Drawing.Size(60, 20)
      Me.lblWidth.TabIndex = 1016
      Me.lblWidth.Text = "Width:"
      '
      'txtWeight
      '
      Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtWeight.ForeColor = System.Drawing.Color.Black
      Me.txtWeight.Location = New System.Drawing.Point(201, 20)
      Me.txtWeight.Name = "txtWeight"
      Me.txtWeight.Size = New System.Drawing.Size(157, 26)
      Me.txtWeight.TabIndex = 1
      '
      'lblLength
      '
      Me.lblLength.AutoSize = True
      Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength.Location = New System.Drawing.Point(9, 54)
      Me.lblLength.Name = "lblLength"
      Me.lblLength.Size = New System.Drawing.Size(70, 20)
      Me.lblLength.TabIndex = 1017
      Me.lblLength.Text = "Length:"
      '
      'lblUnit
      '
      Me.lblUnit.AutoSize = True
      Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblUnit.Location = New System.Drawing.Point(364, 23)
      Me.lblUnit.Name = "lblUnit"
      Me.lblUnit.Size = New System.Drawing.Size(30, 20)
      Me.lblUnit.TabIndex = 1018
      Me.lblUnit.Text = "Kg"
      '
      'lblWeight
      '
      Me.lblWeight.AutoSize = True
      Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWeight.Location = New System.Drawing.Point(9, 22)
      Me.lblWeight.Name = "lblWeight"
      Me.lblWeight.Size = New System.Drawing.Size(137, 20)
      Me.lblWeight.TabIndex = 1019
      Me.lblWeight.Text = "Product Weight:"
      '
      'btnPanel
      '
      Me.btnPanel.Controls.Add(Me.btnAudit)
      Me.btnPanel.Controls.Add(Me.btnFeedback)
      Me.btnPanel.Controls.Add(Me.btnImage)
      Me.btnPanel.Controls.Add(Me.btnQuantity)
      Me.btnPanel.Controls.Add(Me.btnClose)
      Me.btnPanel.Controls.Add(Me.btnDelete)
      Me.btnPanel.Controls.Add(Me.btnSave)
      Me.btnPanel.Controls.Add(Me.btnOpen)
      Me.btnPanel.Controls.Add(Me.btnNew)
      Me.btnPanel.Controls.Add(Me.btnRecent)
      Me.btnPanel.Location = New System.Drawing.Point(894, 54)
      Me.btnPanel.Name = "btnPanel"
      Me.btnPanel.Size = New System.Drawing.Size(181, 355)
      Me.btnPanel.TabIndex = 1003
      '
      'btnAudit
      '
      Me.btnAudit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnAudit.ForeColor = System.Drawing.Color.White
      Me.btnAudit.Location = New System.Drawing.Point(6, 285)
      Me.btnAudit.Name = "btnAudit"
      Me.btnAudit.Size = New System.Drawing.Size(172, 30)
      Me.btnAudit.TabIndex = 107
      Me.btnAudit.Text = "&Audit"
      Me.btnAudit.UseVisualStyleBackColor = False
      '
      'btnFeedback
      '
      Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnFeedback.ForeColor = System.Drawing.Color.White
      Me.btnFeedback.Location = New System.Drawing.Point(6, 180)
      Me.btnFeedback.Name = "btnFeedback"
      Me.btnFeedback.Size = New System.Drawing.Size(172, 30)
      Me.btnFeedback.TabIndex = 105
      Me.btnFeedback.Text = "Product &Reviews"
      Me.btnFeedback.UseVisualStyleBackColor = False
      '
      'btnImage
      '
      Me.btnImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnImage.ForeColor = System.Drawing.Color.White
      Me.btnImage.Location = New System.Drawing.Point(6, 215)
      Me.btnImage.Name = "btnImage"
      Me.btnImage.Size = New System.Drawing.Size(172, 30)
      Me.btnImage.TabIndex = 105
      Me.btnImage.Text = "&Product Images"
      Me.btnImage.UseVisualStyleBackColor = False
      '
      'btnQuantity
      '
      Me.btnQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnQuantity.ForeColor = System.Drawing.Color.White
      Me.btnQuantity.Location = New System.Drawing.Point(6, 250)
      Me.btnQuantity.Name = "btnQuantity"
      Me.btnQuantity.Size = New System.Drawing.Size(172, 30)
      Me.btnQuantity.TabIndex = 106
      Me.btnQuantity.Text = "&Quantity"
      Me.btnQuantity.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(6, 320)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(172, 30)
      Me.btnClose.TabIndex = 108
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(6, 145)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(172, 30)
      Me.btnDelete.TabIndex = 104
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(6, 110)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(172, 30)
      Me.btnSave.TabIndex = 103
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(6, 40)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(172, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(6, 5)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(172, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(6, 75)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(172, 30)
      Me.btnRecent.TabIndex = 102
      Me.btnRecent.Text = "&Most Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'productsfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1086, 643)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnPanel)
      Me.Controls.Add(Me.tb)
      Me.Name = "productsfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Maintenance"
      Me.tb.ResumeLayout(False)
      Me.tppartslist.ResumeLayout(False)
      Me.tppartslist.PerformLayout()
      Me.tb1.ResumeLayout(False)
      Me.tpcurrentprices.ResumeLayout(False)
      Me.tphistory.ResumeLayout(False)
      Me.tphistory.PerformLayout()
      Me.tpdetails.ResumeLayout(False)
      Me.tpdetails.PerformLayout()
      Me.tpShipping.ResumeLayout(False)
      Me.tpShipping.PerformLayout()
      Me.btnPanel.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents tb As System.Windows.Forms.TabControl
   Friend WithEvents tppartslist As System.Windows.Forms.TabPage
   Friend WithEvents lblProdType As System.Windows.Forms.Label
   Friend WithEvents btnEditProduct As System.Windows.Forms.Button
   Friend WithEvents cmbProdStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblProdStatus As System.Windows.Forms.Label
   Friend WithEvents cmbSpecStatus As System.Windows.Forms.ComboBox
   Friend WithEvents txtProdName As System.Windows.Forms.TextBox
   Friend WithEvents lblProdName As System.Windows.Forms.Label
   Friend WithEvents dpEntry As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblSpecStatus As System.Windows.Forms.Label
   Friend WithEvents lblEntry As System.Windows.Forms.Label
   Friend WithEvents txtSKU As System.Windows.Forms.TextBox
   Friend WithEvents lblProdNum As System.Windows.Forms.Label
   Friend WithEvents tpdetails As System.Windows.Forms.TabPage
   Friend WithEvents txtProdDesc As System.Windows.Forms.TextBox
   Friend WithEvents lblProdDesc As System.Windows.Forms.Label
   Friend WithEvents txtProdDetail As System.Windows.Forms.TextBox
   Friend WithEvents txtProDesc2 As System.Windows.Forms.TextBox
   Friend WithEvents lblProdDetail As System.Windows.Forms.Label
   Friend WithEvents lblProdDesc2 As System.Windows.Forms.Label
   Friend WithEvents btnPanel As System.Windows.Forms.Panel
   Friend WithEvents btnAudit As System.Windows.Forms.Button
   Friend WithEvents btnImage As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents tb1 As System.Windows.Forms.TabControl
   Friend WithEvents tpcurrentprices As System.Windows.Forms.TabPage
   Friend WithEvents lstPrices As System.Windows.Forms.ListView
   Friend WithEvents btnNewPrice As System.Windows.Forms.Button
   Friend WithEvents btnDeletePrice As System.Windows.Forms.Button
   Friend WithEvents btnEditPrice As System.Windows.Forms.Button
   Friend WithEvents tphistory As System.Windows.Forms.TabPage
   Friend WithEvents txtPriceChanges As System.Windows.Forms.TextBox
   Friend WithEvents cmbType As System.Windows.Forms.ComboBox
   Friend WithEvents btnFeedback As System.Windows.Forms.Button
   Friend WithEvents btnQuantity As System.Windows.Forms.Button
   Friend WithEvents txtSpecDesc As System.Windows.Forms.TextBox
   Friend WithEvents lblSpecDesc As System.Windows.Forms.Label
   Friend WithEvents txtRemain As System.Windows.Forms.TextBox
   Friend WithEvents lblRemain As System.Windows.Forms.Label
   Friend WithEvents tpShipping As System.Windows.Forms.TabPage
   Friend WithEvents txtHeight As System.Windows.Forms.TextBox
   Friend WithEvents lblHeight2 As System.Windows.Forms.Label
   Friend WithEvents txtWidth As System.Windows.Forms.TextBox
   Friend WithEvents lblWidth2 As System.Windows.Forms.Label
   Friend WithEvents txtLength As System.Windows.Forms.TextBox
   Friend WithEvents lblHeight As System.Windows.Forms.Label
   Friend WithEvents lblLength2 As System.Windows.Forms.Label
   Friend WithEvents lblWidth As System.Windows.Forms.Label
   Friend WithEvents txtWeight As System.Windows.Forms.TextBox
   Friend WithEvents lblLength As System.Windows.Forms.Label
   Friend WithEvents lblUnit As System.Windows.Forms.Label
   Friend WithEvents lblWeight As System.Windows.Forms.Label
   Friend WithEvents lblHeight3 As System.Windows.Forms.Label
   Friend WithEvents lblWidth3 As System.Windows.Forms.Label
   Friend WithEvents lblLength3 As System.Windows.Forms.Label
   Friend WithEvents btnAddress As System.Windows.Forms.Button
   Friend WithEvents txtAddress As System.Windows.Forms.TextBox
   Friend WithEvents lblAddress As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmbPackaged As System.Windows.Forms.ComboBox
   Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
   Friend WithEvents lblMaterial As System.Windows.Forms.Label
   Friend WithEvents btnConvert As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmbSolo As System.Windows.Forms.ComboBox
   Friend WithEvents lblSolo As System.Windows.Forms.Label
   Friend WithEvents btnShipBox As System.Windows.Forms.Button
   Friend WithEvents txtShipBox As System.Windows.Forms.TextBox
   Friend WithEvents lblShipBox As System.Windows.Forms.Label
   Friend WithEvents txtProdNumber As System.Windows.Forms.TextBox
   Friend WithEvents lblSKU As System.Windows.Forms.Label
   Friend WithEvents chkTaxFree As System.Windows.Forms.CheckBox
   Friend WithEvents lblTaxFree As System.Windows.Forms.Label
   Friend WithEvents lstSubTypes As System.Windows.Forms.ListView
   Friend WithEvents lblSubTypes As System.Windows.Forms.Label
   Friend WithEvents btnRemoveType As System.Windows.Forms.Button
   Friend WithEvents btnAddType As System.Windows.Forms.Button
End Class
