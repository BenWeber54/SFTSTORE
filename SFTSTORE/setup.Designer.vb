<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setup
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
      Me.bclose = New System.Windows.Forms.Button()
      Me.bok = New System.Windows.Forms.Button()
      Me.parameters = New System.Windows.Forms.TextBox()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'bclose
      '
      Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bclose.ForeColor = System.Drawing.Color.White
      Me.bclose.Location = New System.Drawing.Point(595, 45)
      Me.bclose.Name = "bclose"
      Me.bclose.Size = New System.Drawing.Size(100, 27)
      Me.bclose.TabIndex = 114
      Me.bclose.Text = "&Close"
      Me.bclose.UseVisualStyleBackColor = False
      '
      'bok
      '
      Me.bok.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bok.ForeColor = System.Drawing.Color.White
      Me.bok.Location = New System.Drawing.Point(595, 12)
      Me.bok.Name = "bok"
      Me.bok.Size = New System.Drawing.Size(100, 27)
      Me.bok.TabIndex = 113
      Me.bok.Text = "&Ok"
      Me.bok.UseVisualStyleBackColor = False
      '
      'parameters
      '
      Me.parameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.parameters.Location = New System.Drawing.Point(112, 12)
      Me.parameters.Multiline = True
      Me.parameters.Name = "parameters"
      Me.parameters.Size = New System.Drawing.Size(477, 256)
      Me.parameters.TabIndex = 112
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(6, 15)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(106, 20)
      Me.Label12.TabIndex = 115
      Me.Label12.Text = "Parameters:"
      '
      'setup
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(712, 290)
      Me.ControlBox = False
      Me.Controls.Add(Me.bclose)
      Me.Controls.Add(Me.bok)
      Me.Controls.Add(Me.parameters)
      Me.Controls.Add(Me.Label12)
      Me.Name = "setup"
      Me.RightToLeftLayout = True
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Setup"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents bclose As System.Windows.Forms.Button
   Friend WithEvents bok As System.Windows.Forms.Button
   Friend WithEvents parameters As System.Windows.Forms.TextBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
