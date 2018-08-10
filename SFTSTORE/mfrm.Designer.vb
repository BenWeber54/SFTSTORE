<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mfrm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mfrm))
      Me.MainTimer = New System.Windows.Forms.Timer(Me.components)
      Me.sbar = New System.Windows.Forms.StatusStrip()
      Me.sl = New System.Windows.Forms.ToolStripStatusLabel()
      Me.sr = New System.Windows.Forms.ToolStripStatusLabel()
      Me.tbar = New System.Windows.Forms.ToolStrip()
      Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_company = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_users = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_products = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_productTypes = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_customers = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_orders = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_shipping = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_invoice = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_logoff = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
      Me.tb_exit = New System.Windows.Forms.ToolStripButton()
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menulogoff = New System.Windows.Forms.ToolStripMenuItem()
      Me.menureloadsettings = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuexit = New System.Windows.Forms.ToolStripMenuItem()
      Me.MaintainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ProductTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ShippingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ShippingBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.MiscDatabaseTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.InvoicingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.PromoCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.lprod = New System.Windows.Forms.Label()
      Me.lsettled = New System.Windows.Forms.Label()
      Me.lalpha = New System.Windows.Forms.Label()
      Me.ltest = New System.Windows.Forms.Label()
      Me.llocal = New System.Windows.Forms.Label()
      Me.bgpic = New System.Windows.Forms.PictureBox()
      Me.sbar.SuspendLayout()
      Me.tbar.SuspendLayout()
      Me.MenuStrip1.SuspendLayout()
      CType(Me.bgpic, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'MainTimer
      '
      Me.MainTimer.Enabled = True
      Me.MainTimer.Interval = 1000
      '
      'sbar
      '
      Me.sbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sl, Me.sr})
      Me.sbar.Location = New System.Drawing.Point(0, 579)
      Me.sbar.Name = "sbar"
      Me.sbar.Size = New System.Drawing.Size(1016, 22)
      Me.sbar.TabIndex = 113
      Me.sbar.Text = "sbar"
      '
      'sl
      '
      Me.sl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.sl.Name = "sl"
      Me.sl.Size = New System.Drawing.Size(0, 17)
      Me.sl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'sr
      '
      Me.sr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.sr.Name = "sr"
      Me.sr.Size = New System.Drawing.Size(1001, 17)
      Me.sr.Spring = True
      Me.sr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'tbar
      '
      Me.tbar.BackColor = System.Drawing.Color.WhiteSmoke
      Me.tbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.tbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
      Me.tbar.ImageScalingSize = New System.Drawing.Size(38, 38)
      Me.tbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel8, Me.tb_company, Me.ToolStripLabel3, Me.tb_users, Me.ToolStripLabel4, Me.tb_products, Me.ToolStripLabel5, Me.tb_productTypes, Me.ToolStripLabel2, Me.tb_customers, Me.ToolStripLabel1, Me.tb_orders, Me.ToolStripLabel9, Me.tb_shipping, Me.ToolStripLabel6, Me.tb_invoice, Me.ToolStripLabel10, Me.tb_logoff, Me.ToolStripLabel7, Me.tb_exit})
      Me.tbar.Location = New System.Drawing.Point(0, 24)
      Me.tbar.Name = "tbar"
      Me.tbar.Padding = New System.Windows.Forms.Padding(0)
      Me.tbar.Size = New System.Drawing.Size(1016, 45)
      Me.tbar.Stretch = True
      Me.tbar.TabIndex = 112
      Me.tbar.Text = "ToolStrip1"
      '
      'ToolStripLabel8
      '
      Me.ToolStripLabel8.AutoSize = False
      Me.ToolStripLabel8.Name = "ToolStripLabel8"
      Me.ToolStripLabel8.Size = New System.Drawing.Size(16, 37)
      '
      'tb_company
      '
      Me.tb_company.AutoSize = False
      Me.tb_company.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.tb_company.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_company.Image = Global.SFTSTORE.My.Resources.Resources.Company
      Me.tb_company.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_company.Name = "tb_company"
      Me.tb_company.Size = New System.Drawing.Size(40, 40)
      Me.tb_company.Text = "tb_users"
      Me.tb_company.ToolTipText = "Company"
      '
      'ToolStripLabel3
      '
      Me.ToolStripLabel3.AutoSize = False
      Me.ToolStripLabel3.Name = "ToolStripLabel3"
      Me.ToolStripLabel3.Size = New System.Drawing.Size(16, 37)
      '
      'tb_users
      '
      Me.tb_users.AutoSize = False
      Me.tb_users.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_users.Image = Global.SFTSTORE.My.Resources.Resources.Users
      Me.tb_users.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_users.Name = "tb_users"
      Me.tb_users.Size = New System.Drawing.Size(40, 40)
      Me.tb_users.Text = "tb_users"
      Me.tb_users.ToolTipText = "Users"
      '
      'ToolStripLabel4
      '
      Me.ToolStripLabel4.AutoSize = False
      Me.ToolStripLabel4.Name = "ToolStripLabel4"
      Me.ToolStripLabel4.Size = New System.Drawing.Size(16, 37)
      '
      'tb_products
      '
      Me.tb_products.AutoSize = False
      Me.tb_products.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_products.Image = Global.SFTSTORE.My.Resources.Resources.Products4
      Me.tb_products.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_products.Name = "tb_products"
      Me.tb_products.Size = New System.Drawing.Size(40, 40)
      Me.tb_products.Text = "tb_products"
      Me.tb_products.ToolTipText = "Products"
      '
      'ToolStripLabel5
      '
      Me.ToolStripLabel5.AutoSize = False
      Me.ToolStripLabel5.Name = "ToolStripLabel5"
      Me.ToolStripLabel5.Size = New System.Drawing.Size(16, 37)
      '
      'tb_productTypes
      '
      Me.tb_productTypes.AutoSize = False
      Me.tb_productTypes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_productTypes.Image = Global.SFTSTORE.My.Resources.Resources.Categories2
      Me.tb_productTypes.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_productTypes.Name = "tb_productTypes"
      Me.tb_productTypes.Size = New System.Drawing.Size(40, 40)
      Me.tb_productTypes.Text = "tb_productTypes"
      Me.tb_productTypes.ToolTipText = "Product Types"
      '
      'ToolStripLabel2
      '
      Me.ToolStripLabel2.AutoSize = False
      Me.ToolStripLabel2.Name = "ToolStripLabel2"
      Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 37)
      Me.ToolStripLabel2.Text = "      "
      '
      'tb_customers
      '
      Me.tb_customers.AutoSize = False
      Me.tb_customers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_customers.Image = Global.SFTSTORE.My.Resources.Resources.Customers
      Me.tb_customers.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_customers.Name = "tb_customers"
      Me.tb_customers.Size = New System.Drawing.Size(40, 40)
      Me.tb_customers.Text = "tb_customers"
      Me.tb_customers.ToolTipText = "Customers"
      '
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.AutoSize = False
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
      Me.ToolStripLabel1.Text = "      "
      '
      'tb_orders
      '
      Me.tb_orders.AutoSize = False
      Me.tb_orders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_orders.Image = Global.SFTSTORE.My.Resources.Resources.Order
      Me.tb_orders.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_orders.Name = "tb_orders"
      Me.tb_orders.Size = New System.Drawing.Size(40, 40)
      Me.tb_orders.Text = "tb_orders"
      Me.tb_orders.ToolTipText = "Orders"
      '
      'ToolStripLabel9
      '
      Me.ToolStripLabel9.AutoSize = False
      Me.ToolStripLabel9.Name = "ToolStripLabel9"
      Me.ToolStripLabel9.Size = New System.Drawing.Size(16, 37)
      '
      'tb_shipping
      '
      Me.tb_shipping.AutoSize = False
      Me.tb_shipping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_shipping.Image = Global.SFTSTORE.My.Resources.Resources.Shipping
      Me.tb_shipping.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_shipping.Name = "tb_shipping"
      Me.tb_shipping.Size = New System.Drawing.Size(40, 40)
      Me.tb_shipping.Text = "Shipping"
      '
      'ToolStripLabel6
      '
      Me.ToolStripLabel6.AutoSize = False
      Me.ToolStripLabel6.Name = "ToolStripLabel6"
      Me.ToolStripLabel6.Size = New System.Drawing.Size(16, 37)
      '
      'tb_invoice
      '
      Me.tb_invoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_invoice.Image = Global.SFTSTORE.My.Resources.Resources.Invoice
      Me.tb_invoice.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_invoice.Name = "tb_invoice"
      Me.tb_invoice.Size = New System.Drawing.Size(42, 42)
      '
      'ToolStripLabel10
      '
      Me.ToolStripLabel10.AutoSize = False
      Me.ToolStripLabel10.Name = "ToolStripLabel10"
      Me.ToolStripLabel10.Size = New System.Drawing.Size(16, 37)
      '
      'tb_logoff
      '
      Me.tb_logoff.AutoSize = False
      Me.tb_logoff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_logoff.Image = Global.SFTSTORE.My.Resources.Resources.Logoff2
      Me.tb_logoff.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_logoff.Name = "tb_logoff"
      Me.tb_logoff.Size = New System.Drawing.Size(40, 40)
      Me.tb_logoff.Text = "tb_logoff"
      Me.tb_logoff.ToolTipText = "Logoff"
      '
      'ToolStripLabel7
      '
      Me.ToolStripLabel7.AutoSize = False
      Me.ToolStripLabel7.Name = "ToolStripLabel7"
      Me.ToolStripLabel7.Size = New System.Drawing.Size(16, 37)
      '
      'tb_exit
      '
      Me.tb_exit.AutoSize = False
      Me.tb_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.tb_exit.Image = Global.SFTSTORE.My.Resources.Resources._Exit
      Me.tb_exit.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tb_exit.Name = "tb_exit"
      Me.tb_exit.Size = New System.Drawing.Size(40, 40)
      Me.tb_exit.Text = "tb_users"
      Me.tb_exit.ToolTipText = "Exit"
      '
      'MenuStrip1
      '
      Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MaintainToolStripMenuItem})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
      Me.MenuStrip1.TabIndex = 111
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'ToolStripMenuItem1
      '
      Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menulogoff, Me.menureloadsettings, Me.ToolStripSeparator2, Me.menuexit})
      Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
      Me.ToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
      Me.ToolStripMenuItem1.Tag = "exit"
      Me.ToolStripMenuItem1.Text = "Option"
      '
      'menulogoff
      '
      Me.menulogoff.Name = "menulogoff"
      Me.menulogoff.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
      Me.menulogoff.Size = New System.Drawing.Size(196, 22)
      Me.menulogoff.Text = "Logoff"
      '
      'menureloadsettings
      '
      Me.menureloadsettings.Name = "menureloadsettings"
      Me.menureloadsettings.Size = New System.Drawing.Size(196, 22)
      Me.menureloadsettings.Text = "Reload Startup Settings"
      Me.menureloadsettings.Visible = False
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
      '
      'menuexit
      '
      Me.menuexit.Name = "menuexit"
      Me.menuexit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
      Me.menuexit.Size = New System.Drawing.Size(196, 22)
      Me.menuexit.Tag = "exit"
      Me.menuexit.Text = "Exit"
      '
      'MaintainToolStripMenuItem
      '
      Me.MaintainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ProductTypesToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.ShippingToolStripMenuItem, Me.ShippingBoxesToolStripMenuItem, Me.MiscDatabaseTablesToolStripMenuItem, Me.InvoicingToolStripMenuItem, Me.PromoCodesToolStripMenuItem})
      Me.MaintainToolStripMenuItem.Name = "MaintainToolStripMenuItem"
      Me.MaintainToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
      Me.MaintainToolStripMenuItem.Text = "Maintain"
      '
      'CompanyToolStripMenuItem
      '
      Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
      Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.CompanyToolStripMenuItem.Text = "Company"
      '
      'UsersToolStripMenuItem
      '
      Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
      Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.UsersToolStripMenuItem.Text = "Users"
      '
      'ProductsToolStripMenuItem
      '
      Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
      Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.ProductsToolStripMenuItem.Text = "Products"
      '
      'ProductTypesToolStripMenuItem
      '
      Me.ProductTypesToolStripMenuItem.Name = "ProductTypesToolStripMenuItem"
      Me.ProductTypesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.ProductTypesToolStripMenuItem.Text = "Product Types"
      '
      'CustomersToolStripMenuItem
      '
      Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
      Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.CustomersToolStripMenuItem.Text = "Customers"
      '
      'OrdersToolStripMenuItem
      '
      Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
      Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.OrdersToolStripMenuItem.Text = "Orders"
      '
      'ShippingToolStripMenuItem
      '
      Me.ShippingToolStripMenuItem.Name = "ShippingToolStripMenuItem"
      Me.ShippingToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.ShippingToolStripMenuItem.Text = "Shipping"
      '
      'ShippingBoxesToolStripMenuItem
      '
      Me.ShippingBoxesToolStripMenuItem.Name = "ShippingBoxesToolStripMenuItem"
      Me.ShippingBoxesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.ShippingBoxesToolStripMenuItem.Text = "Shipping Boxes"
      '
      'MiscDatabaseTablesToolStripMenuItem
      '
      Me.MiscDatabaseTablesToolStripMenuItem.Name = "MiscDatabaseTablesToolStripMenuItem"
      Me.MiscDatabaseTablesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.MiscDatabaseTablesToolStripMenuItem.Text = "Misc Database Tables"
      '
      'InvoicingToolStripMenuItem
      '
      Me.InvoicingToolStripMenuItem.Name = "InvoicingToolStripMenuItem"
      Me.InvoicingToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.InvoicingToolStripMenuItem.Text = "Invoicing"
      '
      'PromoCodesToolStripMenuItem
      '
      Me.PromoCodesToolStripMenuItem.Name = "PromoCodesToolStripMenuItem"
      Me.PromoCodesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
      Me.PromoCodesToolStripMenuItem.Text = "Promo Codes"
      '
      'lprod
      '
      Me.lprod.AutoSize = True
      Me.lprod.BackColor = System.Drawing.Color.Transparent
      Me.lprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lprod.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lprod.ForeColor = System.Drawing.Color.Black
      Me.lprod.Location = New System.Drawing.Point(234, 132)
      Me.lprod.Name = "lprod"
      Me.lprod.Size = New System.Drawing.Size(454, 37)
      Me.lprod.TabIndex = 121
      Me.lprod.Text = "*** PRODUCTION SYSTEM ***"
      '
      'lsettled
      '
      Me.lsettled.AutoSize = True
      Me.lsettled.BackColor = System.Drawing.Color.Transparent
      Me.lsettled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lsettled.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lsettled.ForeColor = System.Drawing.Color.Blue
      Me.lsettled.Location = New System.Drawing.Point(294, 132)
      Me.lsettled.Name = "lsettled"
      Me.lsettled.Size = New System.Drawing.Size(352, 37)
      Me.lsettled.TabIndex = 120
      Me.lsettled.Text = "*** ALPHA SYSTEM ***"
      '
      'lalpha
      '
      Me.lalpha.AutoSize = True
      Me.lalpha.BackColor = System.Drawing.Color.Transparent
      Me.lalpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lalpha.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lalpha.ForeColor = System.Drawing.Color.DarkCyan
      Me.lalpha.Location = New System.Drawing.Point(294, 132)
      Me.lalpha.Name = "lalpha"
      Me.lalpha.Size = New System.Drawing.Size(352, 37)
      Me.lalpha.TabIndex = 119
      Me.lalpha.Text = "*** ALPHA SYSTEM ***"
      '
      'ltest
      '
      Me.ltest.AutoSize = True
      Me.ltest.BackColor = System.Drawing.Color.Transparent
      Me.ltest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ltest.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ltest.ForeColor = System.Drawing.Color.DarkRed
      Me.ltest.Location = New System.Drawing.Point(318, 132)
      Me.ltest.Name = "ltest"
      Me.ltest.Size = New System.Drawing.Size(328, 37)
      Me.ltest.TabIndex = 117
      Me.ltest.Text = "*** TEST SYSTEM ***"
      '
      'llocal
      '
      Me.llocal.AutoSize = True
      Me.llocal.BackColor = System.Drawing.Color.Transparent
      Me.llocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.llocal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.llocal.ForeColor = System.Drawing.Color.DarkGreen
      Me.llocal.Location = New System.Drawing.Point(291, 132)
      Me.llocal.Name = "llocal"
      Me.llocal.Size = New System.Drawing.Size(355, 37)
      Me.llocal.TabIndex = 118
      Me.llocal.Text = "*** LOCAL SYSTEM ***"
      '
      'bgpic
      '
      Me.bgpic.BackColor = System.Drawing.Color.Transparent
      Me.bgpic.BackgroundImage = Global.SFTSTORE.My.Resources.Resources.sftdvlogo2015
      Me.bgpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.bgpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.bgpic.Location = New System.Drawing.Point(94, 229)
      Me.bgpic.Name = "bgpic"
      Me.bgpic.Size = New System.Drawing.Size(800, 200)
      Me.bgpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.bgpic.TabIndex = 116
      Me.bgpic.TabStop = False
      '
      'mfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1016, 601)
      Me.Controls.Add(Me.lprod)
      Me.Controls.Add(Me.lsettled)
      Me.Controls.Add(Me.bgpic)
      Me.Controls.Add(Me.lalpha)
      Me.Controls.Add(Me.ltest)
      Me.Controls.Add(Me.llocal)
      Me.Controls.Add(Me.sbar)
      Me.Controls.Add(Me.tbar)
      Me.Controls.Add(Me.MenuStrip1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "mfrm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "SFTSTORE"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.sbar.ResumeLayout(False)
      Me.sbar.PerformLayout()
      Me.tbar.ResumeLayout(False)
      Me.tbar.PerformLayout()
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      CType(Me.bgpic, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MainTimer As System.Windows.Forms.Timer
   Friend WithEvents sbar As System.Windows.Forms.StatusStrip
   Friend WithEvents sl As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents sr As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents tbar As System.Windows.Forms.ToolStrip
   Friend WithEvents tb_company As System.Windows.Forms.ToolStripButton
   Friend WithEvents tb_users As System.Windows.Forms.ToolStripButton
   Friend WithEvents tb_products As System.Windows.Forms.ToolStripButton
   Friend WithEvents tb_productTypes As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents tb_customers As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents tb_orders As System.Windows.Forms.ToolStripButton
   Friend WithEvents tb_logoff As System.Windows.Forms.ToolStripButton
   Friend WithEvents tb_exit As System.Windows.Forms.ToolStripButton
   Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
   Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents menulogoff As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents menureloadsettings As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents menuexit As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents lprod As System.Windows.Forms.Label
   Friend WithEvents lsettled As System.Windows.Forms.Label
   Friend WithEvents lalpha As System.Windows.Forms.Label
   Friend WithEvents ltest As System.Windows.Forms.Label
   Friend WithEvents llocal As System.Windows.Forms.Label
   Friend WithEvents MaintainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents bgpic As System.Windows.Forms.PictureBox
   Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ProductTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents OrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ShippingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents tb_shipping As System.Windows.Forms.ToolStripButton
   Friend WithEvents ShippingBoxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents MiscDatabaseTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents tb_invoice As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripLabel10 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents InvoicingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents PromoCodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
