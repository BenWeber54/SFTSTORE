<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceeditlinefrm
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
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.lblPrice = New System.Windows.Forms.Label()
      Me.txtPrice = New System.Windows.Forms.TextBox()
      Me.lblReason = New System.Windows.Forms.Label()
      Me.txtDiscount = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtProduct = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(136, 108)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 100
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(298, 108)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblPrice
      '
      Me.lblPrice.AutoSize = True
      Me.lblPrice.BackColor = System.Drawing.Color.Transparent
      Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPrice.Location = New System.Drawing.Point(10, 47)
      Me.lblPrice.Name = "lblPrice"
      Me.lblPrice.Size = New System.Drawing.Size(103, 20)
      Me.lblPrice.TabIndex = 43
      Me.lblPrice.Text = "Piece Price:"
      '
      'txtPrice
      '
      Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPrice.Location = New System.Drawing.Point(277, 41)
      Me.txtPrice.Name = "txtPrice"
      Me.txtPrice.Size = New System.Drawing.Size(153, 26)
      Me.txtPrice.TabIndex = 1
      '
      'lblReason
      '
      Me.lblReason.AutoSize = True
      Me.lblReason.BackColor = System.Drawing.Color.Transparent
      Me.lblReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblReason.Location = New System.Drawing.Point(10, 79)
      Me.lblReason.Name = "lblReason"
      Me.lblReason.Size = New System.Drawing.Size(195, 20)
      Me.lblReason.TabIndex = 43
      Me.lblReason.Text = "Product Type Discount:"
      '
      'txtDiscount
      '
      Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDiscount.Location = New System.Drawing.Point(277, 73)
      Me.txtDiscount.Name = "txtDiscount"
      Me.txtDiscount.Size = New System.Drawing.Size(153, 26)
      Me.txtDiscount.TabIndex = 3
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(436, 76)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(24, 20)
      Me.Label1.TabIndex = 102
      Me.Label1.Text = "%"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(10, 15)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(76, 20)
      Me.Label2.TabIndex = 43
      Me.Label2.Text = "Product:"
      '
      'txtProduct
      '
      Me.txtProduct.Enabled = False
      Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProduct.Location = New System.Drawing.Point(277, 9)
      Me.txtProduct.Name = "txtProduct"
      Me.txtProduct.ReadOnly = True
      Me.txtProduct.Size = New System.Drawing.Size(306, 26)
      Me.txtProduct.TabIndex = 1
      '
      'invoiceeditlinefrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(595, 145)
      Me.ControlBox = False
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.txtDiscount)
      Me.Controls.Add(Me.lblReason)
      Me.Controls.Add(Me.txtProduct)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtPrice)
      Me.Controls.Add(Me.lblPrice)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "invoiceeditlinefrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Edit Detail"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblPrice As System.Windows.Forms.Label
   Friend WithEvents txtPrice As System.Windows.Forms.TextBox
   Friend WithEvents lblReason As System.Windows.Forms.Label
   Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtProduct As System.Windows.Forms.TextBox
End Class
