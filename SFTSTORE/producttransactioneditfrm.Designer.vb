<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class producttransactioneditfrm
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
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.txtDesc = New System.Windows.Forms.TextBox()
      Me.lblDesc = New System.Windows.Forms.Label()
      Me.cmbType = New System.Windows.Forms.ComboBox()
      Me.lblType = New System.Windows.Forms.Label()
      Me.txtChanged = New System.Windows.Forms.TextBox()
      Me.lblChanged = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(304, 273)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(57, 273)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 101
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'txtDesc
      '
      Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtDesc.ForeColor = System.Drawing.Color.Black
      Me.txtDesc.Location = New System.Drawing.Point(200, 84)
      Me.txtDesc.Multiline = True
      Me.txtDesc.Name = "txtDesc"
      Me.txtDesc.Size = New System.Drawing.Size(308, 180)
      Me.txtDesc.TabIndex = 1019
      '
      'lblDesc
      '
      Me.lblDesc.AutoSize = True
      Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblDesc.ForeColor = System.Drawing.Color.Black
      Me.lblDesc.Location = New System.Drawing.Point(8, 84)
      Me.lblDesc.Name = "lblDesc"
      Me.lblDesc.Size = New System.Drawing.Size(105, 20)
      Me.lblDesc.TabIndex = 1020
      Me.lblDesc.Text = "Description:"
      '
      'cmbType
      '
      Me.cmbType.BackColor = System.Drawing.SystemColors.Window
      Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbType.FormattingEnabled = True
      Me.cmbType.Location = New System.Drawing.Point(200, 12)
      Me.cmbType.Name = "cmbType"
      Me.cmbType.Size = New System.Drawing.Size(308, 28)
      Me.cmbType.TabIndex = 1021
      '
      'lblType
      '
      Me.lblType.AutoSize = True
      Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblType.ForeColor = System.Drawing.Color.Black
      Me.lblType.Location = New System.Drawing.Point(8, 14)
      Me.lblType.Name = "lblType"
      Me.lblType.Size = New System.Drawing.Size(119, 20)
      Me.lblType.TabIndex = 1022
      Me.lblType.Text = "Change Type:"
      '
      'txtChanged
      '
      Me.txtChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtChanged.ForeColor = System.Drawing.Color.Black
      Me.txtChanged.Location = New System.Drawing.Point(200, 49)
      Me.txtChanged.Name = "txtChanged"
      Me.txtChanged.Size = New System.Drawing.Size(308, 26)
      Me.txtChanged.TabIndex = 1023
      '
      'lblChanged
      '
      Me.lblChanged.AutoSize = True
      Me.lblChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblChanged.Location = New System.Drawing.Point(8, 51)
      Me.lblChanged.Name = "lblChanged"
      Me.lblChanged.Size = New System.Drawing.Size(153, 20)
      Me.lblChanged.TabIndex = 1024
      Me.lblChanged.Text = "Amount Changed:"
      '
      'producttransactioneditfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(520, 309)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtChanged)
      Me.Controls.Add(Me.lblChanged)
      Me.Controls.Add(Me.cmbType)
      Me.Controls.Add(Me.lblType)
      Me.Controls.Add(Me.txtDesc)
      Me.Controls.Add(Me.lblDesc)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "producttransactioneditfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Quantity Change"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents txtDesc As System.Windows.Forms.TextBox
   Friend WithEvents lblDesc As System.Windows.Forms.Label
   Friend WithEvents cmbType As System.Windows.Forms.ComboBox
   Friend WithEvents lblType As System.Windows.Forms.Label
   Friend WithEvents txtChanged As System.Windows.Forms.TextBox
   Friend WithEvents lblChanged As System.Windows.Forms.Label
End Class
