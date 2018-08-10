<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shipmeasurementsfrm
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
      Me.lblHeight2 = New System.Windows.Forms.Label()
      Me.txtWidth = New System.Windows.Forms.TextBox()
      Me.lblWidth2 = New System.Windows.Forms.Label()
      Me.txtLength = New System.Windows.Forms.TextBox()
      Me.lblHeight = New System.Windows.Forms.Label()
      Me.lblHeight3 = New System.Windows.Forms.Label()
      Me.lblWidth3 = New System.Windows.Forms.Label()
      Me.lblLength3 = New System.Windows.Forms.Label()
      Me.lblLength2 = New System.Windows.Forms.Label()
      Me.lblWidth = New System.Windows.Forms.Label()
      Me.txtWeight = New System.Windows.Forms.TextBox()
      Me.lblLength = New System.Windows.Forms.Label()
      Me.lblUnit = New System.Windows.Forms.Label()
      Me.lblWeight = New System.Windows.Forms.Label()
      Me.lblPackaged = New System.Windows.Forms.Label()
      Me.cmbPackaged = New System.Windows.Forms.ComboBox()
      Me.btnConvert = New System.Windows.Forms.Button()
      Me.lblMaterial = New System.Windows.Forms.Label()
      Me.txtMaterial = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
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
      Me.btnSave.Location = New System.Drawing.Point(153, 203)
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
      Me.btnClose.Location = New System.Drawing.Point(352, 203)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(156, 30)
      Me.btnClose.TabIndex = 101
      Me.btnClose.Text = "&Close"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'txtHeight
      '
      Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtHeight.ForeColor = System.Drawing.Color.Black
      Me.txtHeight.Location = New System.Drawing.Point(201, 104)
      Me.txtHeight.Name = "txtHeight"
      Me.txtHeight.Size = New System.Drawing.Size(157, 26)
      Me.txtHeight.TabIndex = 5
      '
      'lblHeight2
      '
      Me.lblHeight2.AutoSize = True
      Me.lblHeight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight2.Location = New System.Drawing.Point(364, 107)
      Me.lblHeight2.Name = "lblHeight2"
      Me.lblHeight2.Size = New System.Drawing.Size(32, 20)
      Me.lblHeight2.TabIndex = 1024
      Me.lblHeight2.Text = "cm"
      '
      'txtWidth
      '
      Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtWidth.ForeColor = System.Drawing.Color.Black
      Me.txtWidth.Location = New System.Drawing.Point(201, 72)
      Me.txtWidth.Name = "txtWidth"
      Me.txtWidth.Size = New System.Drawing.Size(157, 26)
      Me.txtWidth.TabIndex = 4
      '
      'lblWidth2
      '
      Me.lblWidth2.AutoSize = True
      Me.lblWidth2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth2.Location = New System.Drawing.Point(364, 75)
      Me.lblWidth2.Name = "lblWidth2"
      Me.lblWidth2.Size = New System.Drawing.Size(32, 20)
      Me.lblWidth2.TabIndex = 1025
      Me.lblWidth2.Text = "cm"
      '
      'txtLength
      '
      Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtLength.ForeColor = System.Drawing.Color.Black
      Me.txtLength.Location = New System.Drawing.Point(201, 40)
      Me.txtLength.Name = "txtLength"
      Me.txtLength.Size = New System.Drawing.Size(157, 26)
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
      'lblHeight3
      '
      Me.lblHeight3.AutoSize = True
      Me.lblHeight3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblHeight3.Location = New System.Drawing.Point(402, 107)
      Me.lblHeight3.Name = "lblHeight3"
      Me.lblHeight3.Size = New System.Drawing.Size(192, 20)
      Me.lblHeight3.TabIndex = 1027
      Me.lblHeight3.Text = "Shortest Measurement"
      '
      'lblWidth3
      '
      Me.lblWidth3.AutoSize = True
      Me.lblWidth3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWidth3.Location = New System.Drawing.Point(402, 75)
      Me.lblWidth3.Name = "lblWidth3"
      Me.lblWidth3.Size = New System.Drawing.Size(254, 20)
      Me.lblWidth3.TabIndex = 1028
      Me.lblWidth3.Text = "Second Longest Measurement"
      '
      'lblLength3
      '
      Me.lblLength3.AutoSize = True
      Me.lblLength3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength3.Location = New System.Drawing.Point(402, 43)
      Me.lblLength3.Name = "lblLength3"
      Me.lblLength3.Size = New System.Drawing.Size(188, 20)
      Me.lblLength3.TabIndex = 1029
      Me.lblLength3.Text = "Longest Measurement"
      '
      'lblLength2
      '
      Me.lblLength2.AutoSize = True
      Me.lblLength2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblLength2.Location = New System.Drawing.Point(364, 43)
      Me.lblLength2.Name = "lblLength2"
      Me.lblLength2.Size = New System.Drawing.Size(32, 20)
      Me.lblLength2.TabIndex = 1030
      Me.lblLength2.Text = "cm"
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
      Me.txtWeight.Location = New System.Drawing.Point(201, 8)
      Me.txtWeight.Name = "txtWeight"
      Me.txtWeight.Size = New System.Drawing.Size(157, 26)
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
      'lblUnit
      '
      Me.lblUnit.AutoSize = True
      Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblUnit.Location = New System.Drawing.Point(364, 11)
      Me.lblUnit.Name = "lblUnit"
      Me.lblUnit.Size = New System.Drawing.Size(30, 20)
      Me.lblUnit.TabIndex = 1033
      Me.lblUnit.Text = "Kg"
      '
      'lblWeight
      '
      Me.lblWeight.AutoSize = True
      Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblWeight.Location = New System.Drawing.Point(9, 10)
      Me.lblWeight.Name = "lblWeight"
      Me.lblWeight.Size = New System.Drawing.Size(137, 20)
      Me.lblWeight.TabIndex = 1034
      Me.lblWeight.Text = "Product Weight:"
      '
      'lblPackaged
      '
      Me.lblPackaged.AutoSize = True
      Me.lblPackaged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblPackaged.Location = New System.Drawing.Point(9, 174)
      Me.lblPackaged.Name = "lblPackaged"
      Me.lblPackaged.Size = New System.Drawing.Size(93, 20)
      Me.lblPackaged.TabIndex = 1026
      Me.lblPackaged.Text = "Packaged:"
      '
      'cmbPackaged
      '
      Me.cmbPackaged.BackColor = System.Drawing.SystemColors.Window
      Me.cmbPackaged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbPackaged.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.cmbPackaged.ForeColor = System.Drawing.SystemColors.WindowText
      Me.cmbPackaged.FormattingEnabled = True
      Me.cmbPackaged.Location = New System.Drawing.Point(201, 168)
      Me.cmbPackaged.Name = "cmbPackaged"
      Me.cmbPackaged.Size = New System.Drawing.Size(227, 28)
      Me.cmbPackaged.TabIndex = 7
      '
      'btnConvert
      '
      Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnConvert.ForeColor = System.Drawing.Color.White
      Me.btnConvert.Location = New System.Drawing.Point(400, 8)
      Me.btnConvert.Name = "btnConvert"
      Me.btnConvert.Size = New System.Drawing.Size(156, 30)
      Me.btnConvert.TabIndex = 2
      Me.btnConvert.Text = "Convert lb &to Kg"
      Me.btnConvert.UseVisualStyleBackColor = False
      '
      'lblMaterial
      '
      Me.lblMaterial.AutoSize = True
      Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.lblMaterial.Location = New System.Drawing.Point(9, 138)
      Me.lblMaterial.Name = "lblMaterial"
      Me.lblMaterial.Size = New System.Drawing.Size(146, 20)
      Me.lblMaterial.TabIndex = 1026
      Me.lblMaterial.Text = "Packing Material:"
      '
      'txtMaterial
      '
      Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
      Me.txtMaterial.ForeColor = System.Drawing.Color.Black
      Me.txtMaterial.Location = New System.Drawing.Point(201, 136)
      Me.txtMaterial.Name = "txtMaterial"
      Me.txtMaterial.Size = New System.Drawing.Size(157, 26)
      Me.txtMaterial.TabIndex = 6
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
      Me.Label2.Location = New System.Drawing.Point(364, 138)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(24, 20)
      Me.Label2.TabIndex = 1035
      Me.Label2.Text = "%"
      '
      'shipmeasurementsfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(662, 241)
      Me.ControlBox = False
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.cmbPackaged)
      Me.Controls.Add(Me.txtMaterial)
      Me.Controls.Add(Me.txtHeight)
      Me.Controls.Add(Me.lblHeight2)
      Me.Controls.Add(Me.txtWidth)
      Me.Controls.Add(Me.lblWidth2)
      Me.Controls.Add(Me.txtLength)
      Me.Controls.Add(Me.lblMaterial)
      Me.Controls.Add(Me.lblPackaged)
      Me.Controls.Add(Me.lblHeight)
      Me.Controls.Add(Me.lblHeight3)
      Me.Controls.Add(Me.lblWidth3)
      Me.Controls.Add(Me.lblLength3)
      Me.Controls.Add(Me.lblLength2)
      Me.Controls.Add(Me.lblWidth)
      Me.Controls.Add(Me.txtWeight)
      Me.Controls.Add(Me.lblLength)
      Me.Controls.Add(Me.lblUnit)
      Me.Controls.Add(Me.lblWeight)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnConvert)
      Me.Controls.Add(Me.btnClose)
      Me.Name = "shipmeasurementsfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Product Measurements"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents btnSave As System.Windows.Forms.Button
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents txtHeight As System.Windows.Forms.TextBox
   Friend WithEvents lblHeight2 As System.Windows.Forms.Label
   Friend WithEvents txtWidth As System.Windows.Forms.TextBox
   Friend WithEvents lblWidth2 As System.Windows.Forms.Label
   Friend WithEvents txtLength As System.Windows.Forms.TextBox
   Friend WithEvents lblHeight As System.Windows.Forms.Label
   Friend WithEvents lblHeight3 As System.Windows.Forms.Label
   Friend WithEvents lblWidth3 As System.Windows.Forms.Label
   Friend WithEvents lblLength3 As System.Windows.Forms.Label
   Friend WithEvents lblLength2 As System.Windows.Forms.Label
   Friend WithEvents lblWidth As System.Windows.Forms.Label
   Friend WithEvents txtWeight As System.Windows.Forms.TextBox
   Friend WithEvents lblLength As System.Windows.Forms.Label
   Friend WithEvents lblUnit As System.Windows.Forms.Label
   Friend WithEvents lblWeight As System.Windows.Forms.Label
   Friend WithEvents lblPackaged As System.Windows.Forms.Label
   Friend WithEvents cmbPackaged As System.Windows.Forms.ComboBox
   Friend WithEvents btnConvert As System.Windows.Forms.Button
   Friend WithEvents lblMaterial As System.Windows.Forms.Label
   Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
