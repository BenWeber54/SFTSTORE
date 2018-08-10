<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shipmentinfofrm
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
      Me.lst = New System.Windows.Forms.ListView()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.btnShipType = New System.Windows.Forms.Button()
      Me.btnShip = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'lst
      '
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      Me.lst.Location = New System.Drawing.Point(12, 12)
      Me.lst.MultiSelect = False
      Me.lst.Name = "lst"
      Me.lst.Size = New System.Drawing.Size(894, 336)
      Me.lst.TabIndex = 1
      Me.lst.UseCompatibleStateImageBehavior = False
      '
      'btnClose
      '
      Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnClose.ForeColor = System.Drawing.Color.White
      Me.btnClose.Location = New System.Drawing.Point(922, 107)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(172, 30)
      Me.btnClose.TabIndex = 102
      Me.btnClose.Text = "&Cancel"
      Me.btnClose.UseVisualStyleBackColor = False
      '
      'btnShipType
      '
      Me.btnShipType.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShipType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnShipType.ForeColor = System.Drawing.Color.White
      Me.btnShipType.Location = New System.Drawing.Point(922, 71)
      Me.btnShipType.Name = "btnShipType"
      Me.btnShipType.Size = New System.Drawing.Size(172, 30)
      Me.btnShipType.TabIndex = 101
      Me.btnShipType.Text = "&Select Ship Type"
      Me.btnShipType.UseVisualStyleBackColor = False
      '
      'btnShip
      '
      Me.btnShip.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.btnShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
      Me.btnShip.ForeColor = System.Drawing.Color.White
      Me.btnShip.Location = New System.Drawing.Point(922, 13)
      Me.btnShip.Name = "btnShip"
      Me.btnShip.Size = New System.Drawing.Size(172, 52)
      Me.btnShip.TabIndex = 100
      Me.btnShip.Text = "&Complete all shipments"
      Me.btnShip.UseVisualStyleBackColor = False
      '
      'shipmentinfofrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1106, 359)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnShip)
      Me.Controls.Add(Me.btnShipType)
      Me.Controls.Add(Me.btnClose)
      Me.Controls.Add(Me.lst)
      Me.Name = "shipmentinfofrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Shipments"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents btnClose As System.Windows.Forms.Button
   Friend WithEvents btnShipType As System.Windows.Forms.Button
   Friend WithEvents btnShip As System.Windows.Forms.Button
End Class
