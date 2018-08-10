<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class companyboxesfrm
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
      Me.txtHeight = New System.Windows.Forms.TextBox()
      Me.txtWidth = New System.Windows.Forms.TextBox()
      Me.txtLength = New System.Windows.Forms.TextBox()
      Me.lblHeight = New System.Windows.Forms.Label()
      Me.lblWidth = New System.Windows.Forms.Label()
      Me.txtWeight = New System.Windows.Forms.TextBox()
      Me.lblLength = New System.Windows.Forms.Label()
      Me.lblWeight = New System.Windows.Forms.Label()
      Me.btnOpen = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnDelete = New System.Windows.Forms.Button()
      Me.btnConvert = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
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
      Me.btnSave.Location = New System.Drawing.Point(419, 118)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(156, 30)
      Me.btnSave.TabIndex = 102
      Me.btnSave.Text = " &Save"
      Me.btnSave.UseVisualStyleBackColor = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(419, 190)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 104
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'txtHeight
      '
      Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtHeight.ForeColor = System.Drawing.Color.Black
      Me.txtHeight.Location = New System.Drawing.Point(169, 106)
      Me.txtHeight.Name = "txtHeight"
      Me.txtHeight.Size = New System.Drawing.Size(200, 26)
      Me.txtHeight.TabIndex = 5
      '
      'txtWidth
      '
      Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtWidth.ForeColor = System.Drawing.Color.Black
      Me.txtWidth.Location = New System.Drawing.Point(169, 74)
      Me.txtWidth.Name = "txtWidth"
      Me.txtWidth.Size = New System.Drawing.Size(200, 26)
      Me.txtWidth.TabIndex = 4
      '
      'txtLength
      '
      Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtLength.ForeColor = System.Drawing.Color.Black
      Me.txtLength.Location = New System.Drawing.Point(169, 42)
      Me.txtLength.Name = "txtLength"
      Me.txtLength.Size = New System.Drawing.Size(200, 26)
      Me.txtLength.TabIndex = 3
      '
      'lblHeight
      '
      Me.lblHeight.AutoSize = True
      Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight.Location = New System.Drawing.Point(9, 106)
      Me.lblHeight.Name = "lblHeight"
      Me.lblHeight.Size = New System.Drawing.Size(67, 20)
      Me.lblHeight.TabIndex = 1026
      Me.lblHeight.Text = "Height:"
      '
      'lblWidth
      '
      Me.lblWidth.AutoSize = True
      Me.lblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth.Location = New System.Drawing.Point(9, 74)
      Me.lblWidth.Name = "lblWidth"
      Me.lblWidth.Size = New System.Drawing.Size(60, 20)
      Me.lblWidth.TabIndex = 1031
      Me.lblWidth.Text = "Width:"
      '
      'txtWeight
      '
      Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtWeight.ForeColor = System.Drawing.Color.Black
      Me.txtWeight.Location = New System.Drawing.Point(169, 10)
      Me.txtWeight.Name = "txtWeight"
      Me.txtWeight.Size = New System.Drawing.Size(200, 26)
      Me.txtWeight.TabIndex = 1
      '
      'lblLength
      '
      Me.lblLength.AutoSize = True
      Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength.Location = New System.Drawing.Point(9, 42)
      Me.lblLength.Name = "lblLength"
      Me.lblLength.Size = New System.Drawing.Size(70, 20)
      Me.lblLength.TabIndex = 1032
      Me.lblLength.Text = "Length:"
      '
      'lblWeight
      '
      Me.lblWeight.AutoSize = True
      Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWeight.Location = New System.Drawing.Point(9, 10)
      Me.lblWeight.Name = "lblWeight"
      Me.lblWeight.Size = New System.Drawing.Size(136, 20)
      Me.lblWeight.TabIndex = 1034
      Me.lblWeight.Text = "Max box weight:"
      '
      'btnOpen
      '
      Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOpen.ForeColor = System.Drawing.Color.White
      Me.btnOpen.Location = New System.Drawing.Point(419, 82)
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
      Me.btnNew.Location = New System.Drawing.Point(419, 46)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(156, 30)
      Me.btnNew.TabIndex = 100
      Me.btnNew.Text = "&New"
      Me.btnNew.UseVisualStyleBackColor = False
      '
      'btnDelete
      '
      Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnDelete.ForeColor = System.Drawing.Color.White
      Me.btnDelete.Location = New System.Drawing.Point(419, 154)
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(156, 30)
      Me.btnDelete.TabIndex = 103
      Me.btnDelete.Text = "&Delete"
      Me.btnDelete.UseVisualStyleBackColor = False
      '
      'btnConvert
      '
      Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnConvert.ForeColor = System.Drawing.Color.White
      Me.btnConvert.Location = New System.Drawing.Point(419, 10)
      Me.btnConvert.Name = "btnConvert"
      Me.btnConvert.Size = New System.Drawing.Size(156, 30)
      Me.btnConvert.TabIndex = 2
      Me.btnConvert.Text = "Convert lb &to Kg"
      Me.btnConvert.UseVisualStyleBackColor = False
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label1.Location = New System.Drawing.Point(375, 45)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(32, 20)
      Me.Label1.TabIndex = 1031
      Me.Label1.Text = "cm"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label2.Location = New System.Drawing.Point(375, 77)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(32, 20)
      Me.Label2.TabIndex = 1031
      Me.Label2.Text = "cm"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label3.Location = New System.Drawing.Point(375, 109)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(32, 20)
      Me.Label3.TabIndex = 1031
      Me.Label3.Text = "cm"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label4.Location = New System.Drawing.Point(375, 13)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(28, 20)
      Me.Label4.TabIndex = 1031
      Me.Label4.Text = "kg"
      '
      'companyboxesfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(587, 230)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnConvert)
      Me.Controls.Add(Me.txtHeight)
      Me.Controls.Add(Me.txtWidth)
      Me.Controls.Add(Me.txtLength)
      Me.Controls.Add(Me.lblHeight)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.lblWidth)
      Me.Controls.Add(Me.txtWeight)
      Me.Controls.Add(Me.lblLength)
      Me.Controls.Add(Me.lblWeight)
      Me.Controls.Add(Me.btnDelete)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.btnOpen)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "companyboxesfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Company Shipping Boxes"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents txtHeight As System.Windows.Forms.TextBox
   Friend WithEvents txtWidth As System.Windows.Forms.TextBox
   Friend WithEvents txtLength As System.Windows.Forms.TextBox
   Friend WithEvents lblHeight As System.Windows.Forms.Label
   Friend WithEvents lblWidth As System.Windows.Forms.Label
   Friend WithEvents txtWeight As System.Windows.Forms.TextBox
   Friend WithEvents lblLength As System.Windows.Forms.Label
   Friend WithEvents lblWeight As System.Windows.Forms.Label
   Friend WithEvents btnOpen As System.Windows.Forms.Button
   Friend WithEvents btnNew As System.Windows.Forms.Button
   Friend WithEvents btnDelete As System.Windows.Forms.Button
   Friend WithEvents btnConvert As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
