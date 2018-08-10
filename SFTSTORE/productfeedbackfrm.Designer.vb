<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productfeedbackfrm
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
      Me.lblCustomer = New System.Windows.Forms.Label()
      Me.txtCustomer = New System.Windows.Forms.TextBox()
      Me.lblProduct = New System.Windows.Forms.Label()
      Me.txtProduct = New System.Windows.Forms.TextBox()
      Me.lblRating = New System.Windows.Forms.Label()
      Me.txtFeedback = New System.Windows.Forms.TextBox()
      Me.lblFeedback = New System.Windows.Forms.Label()
      Me.rad1 = New System.Windows.Forms.RadioButton()
      Me.rad2 = New System.Windows.Forms.RadioButton()
      Me.rad3 = New System.Windows.Forms.RadioButton()
      Me.rad4 = New System.Windows.Forms.RadioButton()
      Me.rad5 = New System.Windows.Forms.RadioButton()
      Me.grpRating = New System.Windows.Forms.GroupBox()
      Me.btnCustomer = New System.Windows.Forms.Button()
      Me.btnProduct = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.grpRating.SuspendLayout()
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
      Me.btnSave.Location = New System.Drawing.Point(604, 75)
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
      Me.btnClose.Location = New System.Drawing.Point(604, 145)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'lblCustomer
      '
      Me.lblCustomer.AutoSize = True
      Me.lblCustomer.BackColor = System.Drawing.Color.Transparent
      Me.lblCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCustomer.Location = New System.Drawing.Point(5, 11)
      Me.lblCustomer.Name = "lblCustomer"
      Me.lblCustomer.Size = New System.Drawing.Size(91, 20)
      Me.lblCustomer.TabIndex = 43
      Me.lblCustomer.Text = "Customer:"
      '
      'txtCustomer
      '
      Me.txtCustomer.Enabled = False
      Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCustomer.Location = New System.Drawing.Point(193, 8)
      Me.txtCustomer.Name = "txtCustomer"
      Me.txtCustomer.ReadOnly = True
      Me.txtCustomer.Size = New System.Drawing.Size(395, 26)
      Me.txtCustomer.TabIndex = 1
      '
      'lblProduct
      '
      Me.lblProduct.AutoSize = True
      Me.lblProduct.BackColor = System.Drawing.Color.Transparent
      Me.lblProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblProduct.Location = New System.Drawing.Point(5, 43)
      Me.lblProduct.Name = "lblProduct"
      Me.lblProduct.Size = New System.Drawing.Size(76, 20)
      Me.lblProduct.TabIndex = 43
      Me.lblProduct.Text = "Product:"
      '
      'txtProduct
      '
      Me.txtProduct.Enabled = False
      Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProduct.Location = New System.Drawing.Point(193, 40)
      Me.txtProduct.Name = "txtProduct"
      Me.txtProduct.ReadOnly = True
      Me.txtProduct.Size = New System.Drawing.Size(395, 26)
      Me.txtProduct.TabIndex = 1
      '
      'lblRating
      '
      Me.lblRating.AutoSize = True
      Me.lblRating.BackColor = System.Drawing.Color.Transparent
      Me.lblRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblRating.Location = New System.Drawing.Point(5, 72)
      Me.lblRating.Name = "lblRating"
      Me.lblRating.Size = New System.Drawing.Size(67, 20)
      Me.lblRating.TabIndex = 43
      Me.lblRating.Text = "Rating:"
      '
      'txtFeedback
      '
      Me.txtFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtFeedback.ForeColor = System.Drawing.Color.Black
      Me.txtFeedback.Location = New System.Drawing.Point(143, 205)
      Me.txtFeedback.MaxLength = 1024
      Me.txtFeedback.Multiline = True
      Me.txtFeedback.Name = "txtFeedback"
      Me.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtFeedback.Size = New System.Drawing.Size(617, 214)
      Me.txtFeedback.TabIndex = 4
      '
      'lblFeedback
      '
      Me.lblFeedback.AutoSize = True
      Me.lblFeedback.BackColor = System.Drawing.Color.Transparent
      Me.lblFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFeedback.Location = New System.Drawing.Point(5, 205)
      Me.lblFeedback.Name = "lblFeedback"
      Me.lblFeedback.Size = New System.Drawing.Size(71, 20)
      Me.lblFeedback.TabIndex = 43
      Me.lblFeedback.Text = "Review:"
      '
      'rad1
      '
      Me.rad1.AutoSize = True
      Me.rad1.Location = New System.Drawing.Point(8, 15)
      Me.rad1.Name = "rad1"
      Me.rad1.Size = New System.Drawing.Size(53, 17)
      Me.rad1.TabIndex = 104
      Me.rad1.TabStop = True
      Me.rad1.Text = "1 Star"
      Me.rad1.UseVisualStyleBackColor = True
      '
      'rad2
      '
      Me.rad2.AutoSize = True
      Me.rad2.Location = New System.Drawing.Point(8, 38)
      Me.rad2.Name = "rad2"
      Me.rad2.Size = New System.Drawing.Size(53, 17)
      Me.rad2.TabIndex = 104
      Me.rad2.TabStop = True
      Me.rad2.Text = "2 Star"
      Me.rad2.UseVisualStyleBackColor = True
      '
      'rad3
      '
      Me.rad3.AutoSize = True
      Me.rad3.Location = New System.Drawing.Point(8, 61)
      Me.rad3.Name = "rad3"
      Me.rad3.Size = New System.Drawing.Size(53, 17)
      Me.rad3.TabIndex = 104
      Me.rad3.TabStop = True
      Me.rad3.Text = "3 Star"
      Me.rad3.UseVisualStyleBackColor = True
      '
      'rad4
      '
      Me.rad4.AutoSize = True
      Me.rad4.Location = New System.Drawing.Point(8, 84)
      Me.rad4.Name = "rad4"
      Me.rad4.Size = New System.Drawing.Size(53, 17)
      Me.rad4.TabIndex = 104
      Me.rad4.TabStop = True
      Me.rad4.Text = "4 Star"
      Me.rad4.UseVisualStyleBackColor = True
      '
      'rad5
      '
      Me.rad5.AutoSize = True
      Me.rad5.Location = New System.Drawing.Point(8, 107)
      Me.rad5.Name = "rad5"
      Me.rad5.Size = New System.Drawing.Size(53, 17)
      Me.rad5.TabIndex = 104
      Me.rad5.TabStop = True
      Me.rad5.Text = "5 Star"
      Me.rad5.UseVisualStyleBackColor = True
      '
      'grpRating
      '
      Me.grpRating.Controls.Add(Me.rad5)
      Me.grpRating.Controls.Add(Me.rad1)
      Me.grpRating.Controls.Add(Me.rad4)
      Me.grpRating.Controls.Add(Me.rad2)
      Me.grpRating.Controls.Add(Me.rad3)
      Me.grpRating.Location = New System.Drawing.Point(143, 69)
      Me.grpRating.Name = "grpRating"
      Me.grpRating.Size = New System.Drawing.Size(74, 130)
      Me.grpRating.TabIndex = 3
      Me.grpRating.TabStop = False
      Me.grpRating.Text = "Rating"
      '
      'btnCustomer
      '
      Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCustomer.ForeColor = System.Drawing.Color.White
      Me.btnCustomer.Location = New System.Drawing.Point(143, 8)
      Me.btnCustomer.Name = "btnCustomer"
      Me.btnCustomer.Size = New System.Drawing.Size(44, 25)
      Me.btnCustomer.TabIndex = 1
      Me.btnCustomer.Text = "..."
      Me.btnCustomer.UseVisualStyleBackColor = False
      '
      'btnProduct
      '
      Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnProduct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnProduct.ForeColor = System.Drawing.Color.White
      Me.btnProduct.Location = New System.Drawing.Point(143, 40)
      Me.btnProduct.Name = "btnProduct"
      Me.btnProduct.Size = New System.Drawing.Size(44, 25)
      Me.btnProduct.TabIndex = 2
      Me.btnProduct.Text = "..."
      Me.btnProduct.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(604, 40)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 101
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(604, 5)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 101
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(604, 110)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 101
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'productfeedbackfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(772, 425)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnProduct)
      Me.Controls.Add(Me.btnCustomer)
      Me.Controls.Add(Me.grpRating)
      Me.Controls.Add(Me.txtFeedback)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.txtProduct)
      Me.Controls.Add(Me.lblFeedback)
      Me.Controls.Add(Me.lblRating)
      Me.Controls.Add(Me.lblProduct)
      Me.Controls.Add(Me.txtCustomer)
      Me.Controls.Add(Me.lblCustomer)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "productfeedbackfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Review"
      Me.grpRating.ResumeLayout(False)
      Me.grpRating.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents lblCustomer As System.Windows.Forms.Label
   Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
   Friend WithEvents lblProduct As System.Windows.Forms.Label
   Friend WithEvents txtProduct As System.Windows.Forms.TextBox
   Friend WithEvents lblRating As System.Windows.Forms.Label
   Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
   Friend WithEvents lblFeedback As System.Windows.Forms.Label
   Friend WithEvents rad1 As System.Windows.Forms.RadioButton
   Friend WithEvents rad2 As System.Windows.Forms.RadioButton
   Friend WithEvents rad3 As System.Windows.Forms.RadioButton
   Friend WithEvents rad4 As System.Windows.Forms.RadioButton
   Friend WithEvents rad5 As System.Windows.Forms.RadioButton
   Friend WithEvents grpRating As System.Windows.Forms.GroupBox
   Friend WithEvents btnCustomer As System.Windows.Forms.Button
   Friend WithEvents btnProduct As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Private WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
