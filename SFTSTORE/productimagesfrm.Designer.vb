<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productimagesfrm
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
      Me.cmbStatus = New System.Windows.Forms.ComboBox()
      Me.lblStatus = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.bselect = New System.Windows.Forms.Button()
      Me.filename = New System.Windows.Forms.TextBox()
      Me.lblFile = New System.Windows.Forms.Label()
      Me.bdelete = New System.Windows.Forms.Button()
      Me.bsave = New System.Windows.Forms.Button()
      Me.bopen = New System.Windows.Forms.Button()
      Me.txtTooltip = New System.Windows.Forms.TextBox()
      Me.lblTooltip = New System.Windows.Forms.Label()
      Me.bclose = New System.Windows.Forms.Button()
      Me.bnew = New System.Windows.Forms.Button()
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.lblOrder = New System.Windows.Forms.Label()
      Me.txtOrder = New System.Windows.Forms.TextBox()
      Me.btnOrder = New System.Windows.Forms.Button()
      Me.btnView = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'cmbStatus
      '
      Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbStatus.FormattingEnabled = True
      Me.cmbStatus.Location = New System.Drawing.Point(178, 9)
      Me.cmbStatus.Name = "cmbStatus"
      Me.cmbStatus.Size = New System.Drawing.Size(298, 28)
      Me.cmbStatus.TabIndex = 1
      '
      'lblStatus
      '
      Me.lblStatus.AutoSize = True
      Me.lblStatus.BackColor = System.Drawing.Color.Transparent
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblStatus.Location = New System.Drawing.Point(10, 12)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(67, 20)
      Me.lblStatus.TabIndex = 146
      Me.lblStatus.Text = "Status:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DimGray
      Me.Label3.Location = New System.Drawing.Point(56, 189)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(543, 26)
      Me.Label3.TabIndex = 145
      Me.Label3.Text = "Maximum size of any attachment is 10 megabytes"
      '
      'bselect
      '
      Me.bselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bselect.Location = New System.Drawing.Point(565, 113)
      Me.bselect.Name = "bselect"
      Me.bselect.Size = New System.Drawing.Size(72, 26)
      Me.bselect.TabIndex = 137
      Me.bselect.Text = "Select"
      Me.bselect.UseVisualStyleBackColor = True
      '
      'filename
      '
      Me.filename.Enabled = False
      Me.filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.filename.Location = New System.Drawing.Point(178, 113)
      Me.filename.Name = "filename"
      Me.filename.Size = New System.Drawing.Size(457, 26)
      Me.filename.TabIndex = 136
      '
      'lblFile
      '
      Me.lblFile.AutoSize = True
      Me.lblFile.BackColor = System.Drawing.Color.Transparent
      Me.lblFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFile.Location = New System.Drawing.Point(10, 116)
      Me.lblFile.Name = "lblFile"
      Me.lblFile.Size = New System.Drawing.Size(43, 20)
      Me.lblFile.TabIndex = 144
      Me.lblFile.Text = "File:"
      '
      'bdelete
      '
      Me.bdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bdelete.ForeColor = System.Drawing.Color.White
      Me.bdelete.Location = New System.Drawing.Point(641, 113)
      Me.bdelete.Name = "bdelete"
      Me.bdelete.Size = New System.Drawing.Size(156, 30)
      Me.bdelete.TabIndex = 103
      Me.bdelete.Text = "&Delete"
      Me.bdelete.UseVisualStyleBackColor = False
      '
      'bsave
      '
      Me.bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bsave.ForeColor = System.Drawing.Color.White
      Me.bsave.Location = New System.Drawing.Point(641, 79)
      Me.bsave.Name = "bsave"
      Me.bsave.Size = New System.Drawing.Size(156, 30)
      Me.bsave.TabIndex = 102
      Me.bsave.Text = "&Save"
      Me.bsave.UseVisualStyleBackColor = False
      '
      'bopen
      '
      Me.bopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bopen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bopen.ForeColor = System.Drawing.Color.White
      Me.bopen.Location = New System.Drawing.Point(641, 45)
      Me.bopen.Name = "bopen"
      Me.bopen.Size = New System.Drawing.Size(156, 30)
      Me.bopen.TabIndex = 101
      Me.bopen.Text = "&Open"
      Me.bopen.UseVisualStyleBackColor = False
      '
      'txtTooltip
      '
      Me.txtTooltip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTooltip.Location = New System.Drawing.Point(178, 81)
      Me.txtTooltip.Name = "txtTooltip"
      Me.txtTooltip.Size = New System.Drawing.Size(457, 26)
      Me.txtTooltip.TabIndex = 2
      '
      'lblTooltip
      '
      Me.lblTooltip.AutoSize = True
      Me.lblTooltip.BackColor = System.Drawing.Color.Transparent
      Me.lblTooltip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblTooltip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTooltip.Location = New System.Drawing.Point(10, 84)
      Me.lblTooltip.Name = "lblTooltip"
      Me.lblTooltip.Size = New System.Drawing.Size(68, 20)
      Me.lblTooltip.TabIndex = 143
      Me.lblTooltip.Text = "Tooltip:"
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(641, 221)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 30)
      Me.bclose.TabIndex = 106
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'bnew
      '
      Me.bnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bnew.ForeColor = System.Drawing.Color.White
      Me.bnew.Location = New System.Drawing.Point(641, 11)
      Me.bnew.Name = "bnew"
      Me.bnew.Size = New System.Drawing.Size(156, 30)
      Me.bnew.TabIndex = 100
      Me.bnew.Text = "&New"
      Me.bnew.UseVisualStyleBackColor = False
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'lblOrder
      '
      Me.lblOrder.AutoSize = True
      Me.lblOrder.BackColor = System.Drawing.Color.Transparent
      Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblOrder.Location = New System.Drawing.Point(10, 46)
      Me.lblOrder.Name = "lblOrder"
      Me.lblOrder.Size = New System.Drawing.Size(109, 20)
      Me.lblOrder.TabIndex = 146
      Me.lblOrder.Text = "Image Order"
      '
      'txtOrder
      '
      Me.txtOrder.Enabled = False
      Me.txtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtOrder.Location = New System.Drawing.Point(178, 45)
      Me.txtOrder.Name = "txtOrder"
      Me.txtOrder.ReadOnly = True
      Me.txtOrder.Size = New System.Drawing.Size(154, 26)
      Me.txtOrder.TabIndex = 135
      '
      'btnOrder
      '
      Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOrder.ForeColor = System.Drawing.Color.White
      Me.btnOrder.Location = New System.Drawing.Point(641, 149)
      Me.btnOrder.Name = "btnOrder"
      Me.btnOrder.Size = New System.Drawing.Size(156, 30)
      Me.btnOrder.TabIndex = 104
      Me.btnOrder.Text = "&Edit Order"
      Me.btnOrder.UseVisualStyleBackColor = False
      '
      'btnView
      '
      Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnView.ForeColor = System.Drawing.Color.White
      Me.btnView.Location = New System.Drawing.Point(641, 185)
      Me.btnView.Name = "btnView"
      Me.btnView.Size = New System.Drawing.Size(156, 30)
      Me.btnView.TabIndex = 105
      Me.btnView.Text = "&View"
      Me.btnView.UseVisualStyleBackColor = False
      '
      'productimagesfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(804, 262)
      Me.ControlBox = False
      Me.Controls.Add(Me.lblOrder)
      Me.Controls.Add(Me.cmbStatus)
      Me.Controls.Add(Me.lblStatus)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.bselect)
      Me.Controls.Add(Me.filename)
      Me.Controls.Add(Me.lblFile)
      Me.Controls.Add(Me.btnView)
      Me.Controls.Add(Me.btnOrder)
      Me.Controls.Add(Me.bdelete)
      Me.Controls.Add(Me.bsave)
      Me.Controls.Add(Me.bopen)
      Me.Controls.Add(Me.txtOrder)
      Me.Controls.Add(Me.txtTooltip)
      Me.Controls.Add(Me.lblTooltip)
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.bnew)
      Me.Name = "productimagesfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Images"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
   Friend WithEvents lblStatus As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents bselect As System.Windows.Forms.Button
   Friend WithEvents filename As System.Windows.Forms.TextBox
   Friend WithEvents lblFile As System.Windows.Forms.Label
   Friend WithEvents bdelete As System.Windows.Forms.Button
   Friend WithEvents bsave As System.Windows.Forms.Button
   Friend WithEvents bopen As System.Windows.Forms.Button
   Friend WithEvents txtTooltip As System.Windows.Forms.TextBox
   Friend WithEvents lblTooltip As System.Windows.Forms.Label
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents bnew As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents lblOrder As System.Windows.Forms.Label
   Friend WithEvents txtOrder As System.Windows.Forms.TextBox
   Friend WithEvents btnOrder As System.Windows.Forms.Button
   Friend WithEvents btnView As System.Windows.Forms.Button
End Class
