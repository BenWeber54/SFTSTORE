<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerwishlistfrm
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
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.lst = New System.Windows.Forms.ListView()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnRefresh = New System.Windows.Forms.Button()
      Me.txtName = New System.Windows.Forms.TextBox()
      Me.lblName = New System.Windows.Forms.Label()
      Me.txtNumber = New System.Windows.Forms.TextBox()
      Me.lblNumber = New System.Windows.Forms.Label()
      Me.btnAdd = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(780, 187)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 104
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(780, 152)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 103
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.HideSelection = False
      Me.lst.Location = New System.Drawing.Point(12, 73)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(762, 455)
      Me.lst.TabIndex = 3
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(780, 117)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 102
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnRefresh
      '
      Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRefresh.ForeColor = System.Drawing.Color.White
      Me.btnRefresh.Location = New System.Drawing.Point(780, 12)
      Me.btnRefresh.Name = "btnRefresh"
      Me.btnRefresh.Size = New System.Drawing.Size(156, 30)
      Me.btnRefresh.TabIndex = 100
      Me.btnRefresh.Text = "&Refresh"
      Me.btnRefresh.UseVisualStyleBackColor = False
      '
      'txtName
      '
      Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtName.Location = New System.Drawing.Point(194, 41)
      Me.txtName.Name = "txtName"
      Me.txtName.Size = New System.Drawing.Size(329, 26)
      Me.txtName.TabIndex = 2
      '
      'lblName
      '
      Me.lblName.AutoSize = True
      Me.lblName.BackColor = System.Drawing.Color.Transparent
      Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblName.Location = New System.Drawing.Point(12, 43)
      Me.lblName.Name = "lblName"
      Me.lblName.Size = New System.Drawing.Size(127, 20)
      Me.lblName.TabIndex = 556
      Me.lblName.Text = "Product Name:"
      '
      'txtNumber
      '
      Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumber.Location = New System.Drawing.Point(194, 6)
      Me.txtNumber.Name = "txtNumber"
      Me.txtNumber.Size = New System.Drawing.Size(329, 26)
      Me.txtNumber.TabIndex = 1
      '
      'lblNumber
      '
      Me.lblNumber.AutoSize = True
      Me.lblNumber.BackColor = System.Drawing.Color.Transparent
      Me.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNumber.Location = New System.Drawing.Point(12, 8)
      Me.lblNumber.Name = "lblNumber"
      Me.lblNumber.Size = New System.Drawing.Size(143, 20)
      Me.lblNumber.TabIndex = 555
      Me.lblNumber.Text = "Product Number:"
      '
      'btnAdd
      '
      Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAdd.ForeColor = System.Drawing.Color.White
      Me.btnAdd.Location = New System.Drawing.Point(780, 47)
      Me.btnAdd.Name = "btnAdd"
      Me.btnAdd.Size = New System.Drawing.Size(156, 30)
      Me.btnAdd.TabIndex = 101
      Me.btnAdd.Text = "&Add"
      Me.btnAdd.UseVisualStyleBackColor = False
      '
      'btnEdit
      '
      Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnEdit.ForeColor = System.Drawing.Color.White
      Me.btnEdit.Location = New System.Drawing.Point(780, 82)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(156, 30)
      Me.btnEdit.TabIndex = 101
      Me.btnEdit.Text = "&Edit"
      Me.btnEdit.UseVisualStyleBackColor = False
      '
      'customerwishlistfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(948, 531)
      Me.ControlBox = False
      Me.Controls.Add(Me.txtName)
      Me.Controls.Add(Me.lblName)
      Me.Controls.Add(Me.txtNumber)
      Me.Controls.Add(Me.lblNumber)
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.btnRefresh)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnEdit)
      Me.Controls.Add(Me.btnAdd)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "customerwishlistfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Customer Wishlist"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnRefresh As System.Windows.Forms.Button
   Friend WithEvents txtName As System.Windows.Forms.TextBox
   Friend WithEvents lblName As System.Windows.Forms.Label
   Friend WithEvents txtNumber As System.Windows.Forms.TextBox
   Friend WithEvents lblNumber As System.Windows.Forms.Label
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
