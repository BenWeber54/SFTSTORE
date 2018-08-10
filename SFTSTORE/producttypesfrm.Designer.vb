<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class producttypesfrm
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
      Me.tb1 = New System.Windows.Forms.TabControl()
      Me.tpproducttypes = New System.Windows.Forms.TabPage()
      Me.tpsubtypes = New System.Windows.Forms.TabPage()
      Me.dpEnd = New System.Windows.Forms.DateTimePicker()
      Me.lblEnd = New System.Windows.Forms.Label()
      Me.dpStart = New System.Windows.Forms.DateTimePicker()
      Me.lblStart = New System.Windows.Forms.Label()
      Me.txtSpecDesc = New System.Windows.Forms.TextBox()
      Me.lblSpecDesc = New System.Windows.Forms.Label()
      Me.chkSpecial = New System.Windows.Forms.CheckBox()
      Me.txtSpecPercent = New System.Windows.Forms.TextBox()
      Me.lblSpecPrice = New System.Windows.Forms.Label()
      Me.txtType = New System.Windows.Forms.TextBox()
      Me.lblSpecial = New System.Windows.Forms.Label()
      Me.lblName = New System.Windows.Forms.Label()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnSubDelete = New System.Windows.Forms.Button()
      Me.btnSubSave = New System.Windows.Forms.Button()
      Me.btnSubOpen = New System.Windows.Forms.Button()
      Me.btnSubClose = New System.Windows.Forms.Button()
      Me.txtId = New System.Windows.Forms.TextBox()
      Me.lblId = New System.Windows.Forms.Label()
      Me.lblSubName = New System.Windows.Forms.Label()
      Me.txtSubName = New System.Windows.Forms.TextBox()
      Me.btnSubNew = New System.Windows.Forms.Button()
      Me.tb1.SuspendLayout()
      Me.tpproducttypes.SuspendLayout()
      Me.tpsubtypes.SuspendLayout()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'tb1
      '
      Me.tb1.Controls.Add(Me.tpproducttypes)
      Me.tb1.Controls.Add(Me.tpsubtypes)
      Me.tb1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
      Me.tb1.Location = New System.Drawing.Point(0, 1)
      Me.tb1.Name = "tb1"
      Me.tb1.SelectedIndex = 0
      Me.tb1.Size = New System.Drawing.Size(694, 505)
      Me.tb1.TabIndex = 1025
      '
      'tpproducttypes
      '
      Me.tpproducttypes.BackColor = System.Drawing.Color.Transparent
      Me.tpproducttypes.Controls.Add(Me.dpEnd)
      Me.tpproducttypes.Controls.Add(Me.lblEnd)
      Me.tpproducttypes.Controls.Add(Me.dpStart)
      Me.tpproducttypes.Controls.Add(Me.lblStart)
      Me.tpproducttypes.Controls.Add(Me.txtSpecDesc)
      Me.tpproducttypes.Controls.Add(Me.lblSpecDesc)
      Me.tpproducttypes.Controls.Add(Me.chkSpecial)
      Me.tpproducttypes.Controls.Add(Me.txtSpecPercent)
      Me.tpproducttypes.Controls.Add(Me.lblSpecPrice)
      Me.tpproducttypes.Controls.Add(Me.txtType)
      Me.tpproducttypes.Controls.Add(Me.lblSpecial)
      Me.tpproducttypes.Controls.Add(Me.lblName)
      Me.tpproducttypes.Controls.Add(Me.btnDelete)
      Me.tpproducttypes.Controls.Add(Me.btnSave)
      Me.tpproducttypes.Controls.Add(Me.btnOpen)
      Me.tpproducttypes.Controls.Add(Me.btnClose)
      Me.tpproducttypes.Controls.Add(Me.btnNew)
      Me.tpproducttypes.Location = New System.Drawing.Point(4, 22)
      Me.tpproducttypes.Name = "tpproducttypes"
      Me.tpproducttypes.Padding = New System.Windows.Forms.Padding(3)
      Me.tpproducttypes.Size = New System.Drawing.Size(686, 479)
      Me.tpproducttypes.TabIndex = 0
      Me.tpproducttypes.Text = "Product Types"
      '
      'tpsubtypes
      '
      Me.tpsubtypes.BackColor = System.Drawing.SystemColors.Control
      Me.tpsubtypes.Controls.Add(Me.btnSubNew)
      Me.tpsubtypes.Controls.Add(Me.txtSubName)
      Me.tpsubtypes.Controls.Add(Me.lblSubName)
      Me.tpsubtypes.Controls.Add(Me.txtId)
      Me.tpsubtypes.Controls.Add(Me.lblId)
      Me.tpsubtypes.Controls.Add(Me.btnSubDelete)
      Me.tpsubtypes.Controls.Add(Me.btnSubSave)
      Me.tpsubtypes.Controls.Add(Me.btnSubOpen)
      Me.tpsubtypes.Controls.Add(Me.btnSubClose)
      Me.tpsubtypes.Location = New System.Drawing.Point(4, 22)
      Me.tpsubtypes.Name = "tpsubtypes"
      Me.tpsubtypes.Size = New System.Drawing.Size(686, 479)
      Me.tpsubtypes.TabIndex = 1
      Me.tpsubtypes.Text = "Sub Types"
      '
      'dpEnd
      '
      Me.dpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpEnd.Location = New System.Drawing.Point(188, 145)
      Me.dpEnd.Name = "dpEnd"
      Me.dpEnd.Size = New System.Drawing.Size(132, 26)
      Me.dpEnd.TabIndex = 1029
      Me.dpEnd.Visible = False
      '
      'lblEnd
      '
      Me.lblEnd.AutoSize = True
      Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblEnd.Location = New System.Drawing.Point(6, 148)
      Me.lblEnd.Name = "lblEnd"
      Me.lblEnd.Size = New System.Drawing.Size(110, 20)
      Me.lblEnd.TabIndex = 1040
      Me.lblEnd.Text = "Special End:"
      Me.lblEnd.Visible = False
      '
      'dpStart
      '
      Me.dpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dpStart.Location = New System.Drawing.Point(188, 113)
      Me.dpStart.Name = "dpStart"
      Me.dpStart.Size = New System.Drawing.Size(132, 26)
      Me.dpStart.TabIndex = 1028
      Me.dpStart.Visible = False
      '
      'lblStart
      '
      Me.lblStart.AutoSize = True
      Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblStart.Location = New System.Drawing.Point(6, 117)
      Me.lblStart.Name = "lblStart"
      Me.lblStart.Size = New System.Drawing.Size(118, 20)
      Me.lblStart.TabIndex = 1041
      Me.lblStart.Text = "Special Start:"
      Me.lblStart.Visible = False
      '
      'txtSpecDesc
      '
      Me.txtSpecDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtSpecDesc.ForeColor = System.Drawing.Color.Black
      Me.txtSpecDesc.Location = New System.Drawing.Point(10, 200)
      Me.txtSpecDesc.Multiline = True
      Me.txtSpecDesc.Name = "txtSpecDesc"
      Me.txtSpecDesc.Size = New System.Drawing.Size(507, 274)
      Me.txtSpecDesc.TabIndex = 1030
      Me.txtSpecDesc.Visible = False
      '
      'lblSpecDesc
      '
      Me.lblSpecDesc.AutoSize = True
      Me.lblSpecDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblSpecDesc.ForeColor = System.Drawing.Color.Black
      Me.lblSpecDesc.Location = New System.Drawing.Point(6, 177)
      Me.lblSpecDesc.Name = "lblSpecDesc"
      Me.lblSpecDesc.Size = New System.Drawing.Size(162, 20)
      Me.lblSpecDesc.TabIndex = 1039
      Me.lblSpecDesc.Text = "Special Type Desc:"
      Me.lblSpecDesc.Visible = False
      '
      'chkSpecial
      '
      Me.chkSpecial.AutoSize = True
      Me.chkSpecial.Location = New System.Drawing.Point(188, 51)
      Me.chkSpecial.Name = "chkSpecial"
      Me.chkSpecial.Size = New System.Drawing.Size(15, 14)
      Me.chkSpecial.TabIndex = 1026
      Me.chkSpecial.UseVisualStyleBackColor = True
      '
      'txtSpecPercent
      '
      Me.txtSpecPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSpecPercent.Location = New System.Drawing.Point(188, 79)
      Me.txtSpecPercent.Name = "txtSpecPercent"
      Me.txtSpecPercent.Size = New System.Drawing.Size(329, 26)
      Me.txtSpecPercent.TabIndex = 1027
      Me.txtSpecPercent.Visible = False
      '
      'lblSpecPrice
      '
      Me.lblSpecPrice.AutoSize = True
      Me.lblSpecPrice.BackColor = System.Drawing.Color.Transparent
      Me.lblSpecPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSpecPrice.Location = New System.Drawing.Point(6, 81)
      Me.lblSpecPrice.Name = "lblSpecPrice"
      Me.lblSpecPrice.Size = New System.Drawing.Size(138, 20)
      Me.lblSpecPrice.TabIndex = 1038
      Me.lblSpecPrice.Text = "Special Price %:"
      Me.lblSpecPrice.Visible = False
      '
      'txtType
      '
      Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtType.Location = New System.Drawing.Point(188, 9)
      Me.txtType.Name = "txtType"
      Me.txtType.Size = New System.Drawing.Size(329, 26)
      Me.txtType.TabIndex = 1025
      '
      'lblSpecial
      '
      Me.lblSpecial.AutoSize = True
      Me.lblSpecial.BackColor = System.Drawing.Color.Transparent
      Me.lblSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSpecial.Location = New System.Drawing.Point(6, 47)
      Me.lblSpecial.Name = "lblSpecial"
      Me.lblSpecial.Size = New System.Drawing.Size(101, 20)
      Me.lblSpecial.TabIndex = 1036
      Me.lblSpecial.Text = "On Special:"
      '
      'lblName
      '
      Me.lblName.AutoSize = True
      Me.lblName.BackColor = System.Drawing.Color.Transparent
      Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblName.Location = New System.Drawing.Point(6, 10)
      Me.lblName.Name = "lblName"
      Me.lblName.Size = New System.Drawing.Size(103, 20)
      Me.lblName.TabIndex = 1037
      Me.lblName.Text = "Type Name:"
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(523, 113)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 1034
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnSave
      '
      Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSave.ForeColor = System.Drawing.Color.White
      Me.btnSave.Location = New System.Drawing.Point(523, 77)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 1033
      Me.btnSave.Text = "&Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(523, 41)
      Me.btnOpen.Name = "btnOpen"
      Me.btnOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnOpen.TabIndex = 1032
      Me.btnOpen.Text = "&Open"
      Me.btnOpen.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(523, 149)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 1035
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnNew
      '
      Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnNew.ForeColor = System.Drawing.Color.White
      Me.btnNew.Location = New System.Drawing.Point(523, 6)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 1031
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnSubDelete
      '
      Me.btnSubDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSubDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSubDelete.ForeColor = System.Drawing.Color.White
      Me.btnSubDelete.Location = New System.Drawing.Point(523, 118)
      Me.btnSubDelete.Name = "btnSubDelete"
      Me.btnSubDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnSubDelete.TabIndex = 103
      Me.btnSubDelete.Text = "&Delete"
      Me.btnSubDelete.UseVisualStyleBackColor = False
      '
      'btnSubSave
      '
      Me.btnSubSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSubSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSubSave.ForeColor = System.Drawing.Color.White
      Me.btnSubSave.Location = New System.Drawing.Point(523, 82)
      Me.btnSubSave.Name = "btnSubSave"
      Me.btnSubSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSubSave.TabIndex = 102
      Me.btnSubSave.Text = "&Save"
      Me.btnSubSave.UseVisualStyleBackColor = False
      '
      'btnSubOpen
      '
      Me.btnSubOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSubOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSubOpen.ForeColor = System.Drawing.Color.White
      Me.btnSubOpen.Location = New System.Drawing.Point(523, 46)
      Me.btnSubOpen.Name = "btnSubOpen"
      Me.btnSubOpen.Size = New System.Drawing.Size(156, 30)
      Me.btnSubOpen.TabIndex = 101
      Me.btnSubOpen.Text = "&Open"
      Me.btnSubOpen.UseVisualStyleBackColor = False
      '
      'btnSubClose
      '
      Me.btnSubClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSubClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSubClose.ForeColor = System.Drawing.Color.White
      Me.btnSubClose.Location = New System.Drawing.Point(523, 154)
      Me.btnSubClose.Name = "btnSubClose"
      Me.btnSubClose.Size = New System.Drawing.Size(156, 30)
      Me.btnSubClose.TabIndex = 104
      Me.btnSubClose.Text = "&Close"
      Me.btnSubClose.UseVisualStyleBackColor = False
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtId.Location = New System.Drawing.Point(192, 10)
      Me.txtId.Name = "txtId"
      Me.txtId.ReadOnly = True
      Me.txtId.Size = New System.Drawing.Size(145, 26)
      Me.txtId.TabIndex = 1041
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(10, 11)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(33, 20)
      Me.lblId.TabIndex = 1042
      Me.lblId.Text = "ID:"
      '
      'lblSubName
      '
      Me.lblSubName.AutoSize = True
      Me.lblSubName.BackColor = System.Drawing.Color.Transparent
      Me.lblSubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSubName.Location = New System.Drawing.Point(10, 43)
      Me.lblSubName.Name = "lblSubName"
      Me.lblSubName.Size = New System.Drawing.Size(103, 20)
      Me.lblSubName.TabIndex = 1042
      Me.lblSubName.Text = "Type Name:"
      '
      'txtSubName
      '
      Me.txtSubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSubName.Location = New System.Drawing.Point(192, 42)
      Me.txtSubName.MaxLength = 100
      Me.txtSubName.Name = "txtSubName"
      Me.txtSubName.Size = New System.Drawing.Size(325, 26)
      Me.txtSubName.TabIndex = 1
      '
      'btnSubNew
      '
      Me.btnSubNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnSubNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSubNew.ForeColor = System.Drawing.Color.White
      Me.btnSubNew.Location = New System.Drawing.Point(523, 10)
      Me.btnSubNew.Name = "btnSubNew"
      Me.btnSubNew.Size = New System.Drawing.Size(156, 30)
      Me.btnSubNew.TabIndex = 100
      Me.btnSubNew.Text = "&New"
      Me.btnSubNew.UseVisualStyleBackColor = False
      '
      'producttypesfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(695, 507)
      Me.ControlBox = False
      Me.Controls.Add(Me.tb1)
      Me.Name = "producttypesfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Type Maintenance"
      Me.tb1.ResumeLayout(False)
      Me.tpproducttypes.ResumeLayout(False)
      Me.tpproducttypes.PerformLayout()
      Me.tpsubtypes.ResumeLayout(False)
      Me.tpsubtypes.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents tb1 As System.Windows.Forms.TabControl
   Friend WithEvents tpproducttypes As System.Windows.Forms.TabPage
   Friend WithEvents dpEnd As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblEnd As System.Windows.Forms.Label
   Friend WithEvents dpStart As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblStart As System.Windows.Forms.Label
   Friend WithEvents txtSpecDesc As System.Windows.Forms.TextBox
   Friend WithEvents lblSpecDesc As System.Windows.Forms.Label
   Friend WithEvents chkSpecial As System.Windows.Forms.CheckBox
   Friend WithEvents txtSpecPercent As System.Windows.Forms.TextBox
   Friend WithEvents lblSpecPrice As System.Windows.Forms.Label
   Friend WithEvents txtType As System.Windows.Forms.TextBox
   Friend WithEvents lblSpecial As System.Windows.Forms.Label
   Friend WithEvents lblName As System.Windows.Forms.Label
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents tpsubtypes As System.Windows.Forms.TabPage
   Friend WithEvents btnSubDelete As System.Windows.Forms.Button
   Friend WithEvents btnSubSave As System.Windows.Forms.Button
   Friend WithEvents btnSubOpen As System.Windows.Forms.Button
   Friend WithEvents btnSubClose As System.Windows.Forms.Button
   Friend WithEvents txtSubName As System.Windows.Forms.TextBox
   Friend WithEvents lblSubName As System.Windows.Forms.Label
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents btnSubNew As System.Windows.Forms.Button
End Class
