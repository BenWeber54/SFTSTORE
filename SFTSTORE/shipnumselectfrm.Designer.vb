<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shipnumselectfrm
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
      Me.bclose = New System.Windows.Forms.Button()
      Me.btnSelect = New System.Windows.Forms.Button()
      Me.lst = New System.Windows.Forms.ListView()
      Me.btnShowDetails = New System.Windows.Forms.Button()
      Me.btnUnship = New System.Windows.Forms.Button()
      Me.btnRefund = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(769, 129)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(156, 27)
      Me.bclose.TabIndex = 102
      Me.bclose.Text = "&Cancel"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'btnSelect
      '
      Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSelect.ForeColor = System.Drawing.Color.White
      Me.btnSelect.Location = New System.Drawing.Point(769, 12)
      Me.btnSelect.Name = "btnSelect"
      Me.btnSelect.Size = New System.Drawing.Size(156, 27)
      Me.btnSelect.TabIndex = 100
      Me.btnSelect.Text = "&Select"
      Me.btnSelect.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.Location = New System.Drawing.Point(12, 12)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(751, 453)
      Me.lst.TabIndex = 1
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'btnShowDetails
      '
      Me.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShowDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnShowDetails.ForeColor = System.Drawing.Color.White
      Me.btnShowDetails.Location = New System.Drawing.Point(769, 45)
      Me.btnShowDetails.Name = "btnShowDetails"
      Me.btnShowDetails.Size = New System.Drawing.Size(156, 36)
      Me.btnShowDetails.TabIndex = 101
      Me.btnShowDetails.Text = "&Shipping Details"
      Me.btnShowDetails.UseVisualStyleBackColor = False
      '
      'btnUnship
      '
      Me.btnUnship.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnUnship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnUnship.ForeColor = System.Drawing.Color.White
      Me.btnUnship.Location = New System.Drawing.Point(769, 87)
      Me.btnUnship.Name = "btnUnship"
      Me.btnUnship.Size = New System.Drawing.Size(156, 36)
      Me.btnUnship.TabIndex = 101
      Me.btnUnship.Text = "&Unship"
      Me.btnUnship.UseVisualStyleBackColor = False
      Me.btnUnship.Visible = False
      '
      'btnRefund
      '
      Me.btnRefund.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRefund.ForeColor = System.Drawing.Color.White
      Me.btnRefund.Location = New System.Drawing.Point(769, 87)
      Me.btnRefund.Name = "btnRefund"
      Me.btnRefund.Size = New System.Drawing.Size(156, 36)
      Me.btnRefund.TabIndex = 101
      Me.btnRefund.Text = "Request Refund"
      Me.btnRefund.UseVisualStyleBackColor = False
      Me.btnRefund.Visible = False
      '
      'shipnumselectfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(929, 475)
      Me.ControlBox = False
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnRefund)
      Me.Controls.Add(Me.btnUnship)
      Me.Controls.Add(Me.btnShowDetails)
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.btnSelect)
      Me.Name = "shipnumselectfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shipping Number Select"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents btnSelect As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents btnShowDetails As System.Windows.Forms.Button
   Friend WithEvents btnUnship As System.Windows.Forms.Button
   Friend WithEvents btnRefund As System.Windows.Forms.Button
End Class
