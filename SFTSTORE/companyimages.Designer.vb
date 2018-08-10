<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companyimages
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
      Me.attachment = New System.Windows.Forms.ComboBox()
      Me.lblType = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.bselect = New System.Windows.Forms.Button()
      Me.filename = New System.Windows.Forms.TextBox()
      Me.lblFile = New System.Windows.Forms.Label()
      Me.bdelete = New System.Windows.Forms.Button()
      Me.bsave = New System.Windows.Forms.Button()
      Me.bopen = New System.Windows.Forms.Button()
      Me.bclose = New System.Windows.Forms.Button()
      Me.bnew = New System.Windows.Forms.Button()
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.lblSize = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'attachment
      '
      Me.attachment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.attachment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.attachment.FormattingEnabled = True
      Me.attachment.Location = New System.Drawing.Point(112, 9)
      Me.attachment.Name = "attachment"
      Me.attachment.Size = New System.Drawing.Size(298, 28)
      Me.attachment.TabIndex = 134
      '
      'lblType
      '
      Me.lblType.AutoSize = True
      Me.lblType.BackColor = System.Drawing.Color.Transparent
      Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblType.Location = New System.Drawing.Point(10, 12)
      Me.lblType.Name = "lblType"
      Me.lblType.Size = New System.Drawing.Size(52, 20)
      Me.lblType.TabIndex = 146
      Me.lblType.Text = "Type:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DimGray
      Me.Label3.Location = New System.Drawing.Point(58, 128)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(543, 26)
      Me.Label3.TabIndex = 145
      Me.Label3.Text = "Maximum size of any attachment is 10 megabytes"
      '
      'bselect
      '
      Me.bselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bselect.Location = New System.Drawing.Point(565, 46)
      Me.bselect.Name = "bselect"
      Me.bselect.Size = New System.Drawing.Size(72, 26)
      Me.bselect.TabIndex = 137
      Me.bselect.Text = "Select"
      Me.bselect.UseVisualStyleBackColor = True
      '
      'filename
      '
      Me.filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.filename.Location = New System.Drawing.Point(112, 46)
      Me.filename.Name = "filename"
      Me.filename.Size = New System.Drawing.Size(523, 26)
      Me.filename.TabIndex = 136
      '
      'lblFile
      '
      Me.lblFile.AutoSize = True
      Me.lblFile.BackColor = System.Drawing.Color.Transparent
      Me.lblFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFile.Location = New System.Drawing.Point(10, 49)
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
      Me.bdelete.Size = New System.Drawing.Size(156, 27)
      Me.bdelete.TabIndex = 141
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
      Me.bsave.Size = New System.Drawing.Size(156, 27)
      Me.bsave.TabIndex = 140
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
      Me.bopen.Size = New System.Drawing.Size(156, 27)
      Me.bopen.TabIndex = 139
      Me.bopen.Text = "&Open"
      Me.bopen.UseVisualStyleBackColor = False
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(641, 147)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 27)
      Me.bclose.TabIndex = 142
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
      Me.bnew.Size = New System.Drawing.Size(156, 27)
      Me.bnew.TabIndex = 138
      Me.bnew.Text = "&New"
      Me.bnew.UseVisualStyleBackColor = False
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'lblSize
      '
      Me.lblSize.AutoSize = True
      Me.lblSize.BackColor = System.Drawing.Color.Transparent
      Me.lblSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSize.ForeColor = System.Drawing.Color.DimGray
      Me.lblSize.Location = New System.Drawing.Point(58, 91)
      Me.lblSize.Name = "lblSize"
      Me.lblSize.Size = New System.Drawing.Size(0, 26)
      Me.lblSize.TabIndex = 145
      '
      'companyimages
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(804, 187)
      Me.ControlBox = False
      Me.Controls.Add(Me.attachment)
      Me.Controls.Add(Me.lblType)
      Me.Controls.Add(Me.lblSize)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.bselect)
      Me.Controls.Add(Me.filename)
      Me.Controls.Add(Me.lblFile)
      Me.Controls.Add(Me.bdelete)
      Me.Controls.Add(Me.bsave)
      Me.Controls.Add(Me.bopen)
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.bnew)
      Me.Name = "companyimages"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Program Images"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents attachment As System.Windows.Forms.ComboBox
   Friend WithEvents lblType As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents bselect As System.Windows.Forms.Button
   Friend WithEvents filename As System.Windows.Forms.TextBox
   Friend WithEvents lblFile As System.Windows.Forms.Label
   Friend WithEvents bdelete As System.Windows.Forms.Button
   Friend WithEvents bsave As System.Windows.Forms.Button
   Friend WithEvents bopen As System.Windows.Forms.Button
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents bnew As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents lblSize As System.Windows.Forms.Label
End Class
