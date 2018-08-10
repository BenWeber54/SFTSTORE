<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shippingfrm
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
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.lst = New System.Windows.Forms.ListView()
      Me.txtOrdNum = New System.Windows.Forms.TextBox()
      Me.lblOrdNum = New System.Windows.Forms.Label()
      Me.btnShipAddr = New System.Windows.Forms.Button()
      Me.lblShip = New System.Windows.Forms.Label()
      Me.lblNotes = New System.Windows.Forms.Label()
      Me.btnMeasurement = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.txtShipAddress = New System.Windows.Forms.TextBox()
      Me.txtNotes = New System.Windows.Forms.TextBox()
      Me.btnRecent = New System.Windows.Forms.Button()
      Me.btnUnship = New System.Windows.Forms.Button()
      Me.btnShip = New System.Windows.Forms.Button()
      Me.btnPrint = New System.Windows.Forms.Button()
      Me.btnShipDetails = New System.Windows.Forms.Button()
      Me.btnRefund = New System.Windows.Forms.Button()
      Me.txtEmail = New System.Windows.Forms.TextBox()
      Me.lblEmail = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(939, 17)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(172, 30)
      Me.btnOpen.TabIndex = 100
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.Location = New System.Drawing.Point(14, 188)
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(919, 394)
      Me.lst.TabIndex = 2
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'txtOrdNum
      '
      Me.txtOrdNum.Enabled = False
      Me.txtOrdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtOrdNum.ForeColor = System.Drawing.Color.Black
      Me.txtOrdNum.Location = New System.Drawing.Point(156, 12)
      Me.txtOrdNum.Name = "txtOrdNum"
      Me.txtOrdNum.ReadOnly = True
      Me.txtOrdNum.Size = New System.Drawing.Size(193, 26)
      Me.txtOrdNum.TabIndex = 990
      '
      'lblOrdNum
      '
      Me.lblOrdNum.AutoSize = True
      Me.lblOrdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblOrdNum.Location = New System.Drawing.Point(8, 15)
      Me.lblOrdNum.Name = "lblOrdNum"
      Me.lblOrdNum.Size = New System.Drawing.Size(74, 20)
      Me.lblOrdNum.TabIndex = 991
      Me.lblOrdNum.Text = "Order #:"
      '
      'btnShipAddr
      '
      Me.btnShipAddr.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShipAddr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnShipAddr.ForeColor = System.Drawing.Color.White
      Me.btnShipAddr.Location = New System.Drawing.Point(470, 49)
      Me.btnShipAddr.Name = "btnShipAddr"
      Me.btnShipAddr.Size = New System.Drawing.Size(42, 25)
      Me.btnShipAddr.TabIndex = 1
      Me.btnShipAddr.Text = "...."
      Me.btnShipAddr.UseVisualStyleBackColor = False
      '
      'lblShip
      '
      Me.lblShip.AutoSize = True
      Me.lblShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblShip.Location = New System.Drawing.Point(8, 50)
      Me.lblShip.Name = "lblShip"
      Me.lblShip.Size = New System.Drawing.Size(121, 20)
      Me.lblShip.TabIndex = 994
      Me.lblShip.Text = "Ship Address:"
      '
      'lblNotes
      '
      Me.lblNotes.AutoSize = True
      Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblNotes.Location = New System.Drawing.Point(530, 5)
      Me.lblNotes.Name = "lblNotes"
      Me.lblNotes.Size = New System.Drawing.Size(111, 20)
      Me.lblNotes.TabIndex = 994
      Me.lblNotes.Text = "Order Notes:"
      '
      'btnMeasurement
      '
      Me.btnMeasurement.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnMeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnMeasurement.ForeColor = System.Drawing.Color.White
      Me.btnMeasurement.Location = New System.Drawing.Point(939, 89)
      Me.btnMeasurement.Name = "btnMeasurement"
      Me.btnMeasurement.Size = New System.Drawing.Size(172, 44)
      Me.btnMeasurement.TabIndex = 102
      Me.btnMeasurement.Text = "&Modify Measurements"
      Me.btnMeasurement.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(939, 320)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(172, 30)
      Me.btnClose.TabIndex = 108
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'txtShipAddress
      '
      Me.txtShipAddress.Enabled = False
      Me.txtShipAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtShipAddress.ForeColor = System.Drawing.Color.Black
      Me.txtShipAddress.Location = New System.Drawing.Point(156, 49)
      Me.txtShipAddress.Multiline = True
      Me.txtShipAddress.Name = "txtShipAddress"
      Me.txtShipAddress.ReadOnly = True
      Me.txtShipAddress.Size = New System.Drawing.Size(308, 123)
      Me.txtShipAddress.TabIndex = 1008
      Me.txtShipAddress.TabStop = False
      '
      'txtNotes
      '
      Me.txtNotes.Enabled = False
      Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtNotes.ForeColor = System.Drawing.Color.Black
      Me.txtNotes.Location = New System.Drawing.Point(534, 30)
      Me.txtNotes.Multiline = True
      Me.txtNotes.Name = "txtNotes"
      Me.txtNotes.ReadOnly = True
      Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtNotes.Size = New System.Drawing.Size(308, 100)
      Me.txtNotes.TabIndex = 1008
      Me.txtNotes.TabStop = False
      '
      'btnRecent
      '
      Me.btnRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnRecent.ForeColor = System.Drawing.Color.White
      Me.btnRecent.Location = New System.Drawing.Point(939, 53)
      Me.btnRecent.Name = "btnRecent"
      Me.btnRecent.Size = New System.Drawing.Size(172, 30)
      Me.btnRecent.TabIndex = 101
      Me.btnRecent.Text = "Most &Recent"
      Me.btnRecent.UseVisualStyleBackColor = False
      '
      'btnUnship
      '
      Me.btnUnship.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnUnship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnUnship.ForeColor = System.Drawing.Color.White
      Me.btnUnship.Location = New System.Drawing.Point(939, 211)
      Me.btnUnship.Name = "btnUnship"
      Me.btnUnship.Size = New System.Drawing.Size(172, 30)
      Me.btnUnship.TabIndex = 105
      Me.btnUnship.Text = "&Unship"
      Me.btnUnship.UseVisualStyleBackColor = False
      '
      'btnShip
      '
      Me.btnShip.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnShip.ForeColor = System.Drawing.Color.White
      Me.btnShip.Location = New System.Drawing.Point(939, 139)
      Me.btnShip.Name = "btnShip"
      Me.btnShip.Size = New System.Drawing.Size(172, 30)
      Me.btnShip.TabIndex = 103
      Me.btnShip.Text = "&Ship"
      Me.btnShip.UseVisualStyleBackColor = False
      '
      'btnPrint
      '
      Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnPrint.ForeColor = System.Drawing.Color.White
      Me.btnPrint.Location = New System.Drawing.Point(939, 175)
      Me.btnPrint.Name = "btnPrint"
      Me.btnPrint.Size = New System.Drawing.Size(172, 30)
      Me.btnPrint.TabIndex = 104
      Me.btnPrint.Text = "&Print Shipping Label"
      Me.btnPrint.UseVisualStyleBackColor = False
      '
      'btnShipDetails
      '
      Me.btnShipDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShipDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnShipDetails.ForeColor = System.Drawing.Color.White
      Me.btnShipDetails.Location = New System.Drawing.Point(939, 283)
      Me.btnShipDetails.Name = "btnShipDetails"
      Me.btnShipDetails.Size = New System.Drawing.Size(172, 30)
      Me.btnShipDetails.TabIndex = 107
      Me.btnShipDetails.Text = "&Shipping Details"
      Me.btnShipDetails.UseVisualStyleBackColor = False
      '
      'btnRefund
      '
      Me.btnRefund.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnRefund.ForeColor = System.Drawing.Color.White
      Me.btnRefund.Location = New System.Drawing.Point(939, 247)
      Me.btnRefund.Name = "btnRefund"
      Me.btnRefund.Size = New System.Drawing.Size(172, 30)
      Me.btnRefund.TabIndex = 106
      Me.btnRefund.Text = "Request Refund"
      Me.btnRefund.UseVisualStyleBackColor = False
      '
      'txtEmail
      '
      Me.txtEmail.Enabled = False
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtEmail.ForeColor = System.Drawing.Color.Black
      Me.txtEmail.Location = New System.Drawing.Point(534, 157)
      Me.txtEmail.Multiline = True
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.ReadOnly = True
      Me.txtEmail.Size = New System.Drawing.Size(308, 25)
      Me.txtEmail.TabIndex = 1010
      Me.txtEmail.TabStop = False
      '
      'lblEmail
      '
      Me.lblEmail.AutoSize = True
      Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEmail.Location = New System.Drawing.Point(530, 134)
      Me.lblEmail.Name = "lblEmail"
      Me.lblEmail.Size = New System.Drawing.Size(58, 20)
      Me.lblEmail.TabIndex = 1009
      Me.lblEmail.Text = "Email:"
      '
      'shippingfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1119, 594)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtEmail)
      Me.Controls.Add(Me.lblEmail)
      Me.Controls.Add(Me.txtNotes)
      Me.Controls.Add(Me.txtShipAddress)
      Me.Controls.Add(Me.btnShipAddr)
      Me.Controls.Add(Me.lblNotes)
      Me.Controls.Add(Me.lblShip)
      Me.Controls.Add(Me.txtOrdNum)
      Me.Controls.Add(Me.lblOrdNum)
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnRefund)
      Me.Controls.Add(Me.btnUnship)
      Me.Controls.Add(Me.btnPrint)
      Me.Controls.Add(Me.btnShipDetails)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.btnShip)
      Me.Controls.Add(Me.btnMeasurement)
      Me.Controls.Add(Me.btnRecent)
      Me.Controls.Add(Me.btnOpen)
      Me.Name = "shippingfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shipping"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents txtOrdNum As System.Windows.Forms.TextBox
   Friend WithEvents lblOrdNum As System.Windows.Forms.Label
   Friend WithEvents btnShipAddr As System.Windows.Forms.Button
   Friend WithEvents lblShip As System.Windows.Forms.Label
   Friend WithEvents lblNotes As System.Windows.Forms.Label
   Friend WithEvents btnMeasurement As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents txtShipAddress As System.Windows.Forms.TextBox
   Friend WithEvents txtNotes As System.Windows.Forms.TextBox
   Friend WithEvents btnRecent As System.Windows.Forms.Button
   Friend WithEvents btnUnship As System.Windows.Forms.Button
   Friend WithEvents btnShip As System.Windows.Forms.Button
   Friend WithEvents btnPrint As System.Windows.Forms.Button
   Friend WithEvents btnShipDetails As System.Windows.Forms.Button
   Friend WithEvents btnRefund As System.Windows.Forms.Button
   Friend WithEvents txtEmail As System.Windows.Forms.TextBox
   Friend WithEvents lblEmail As System.Windows.Forms.Label
End Class
