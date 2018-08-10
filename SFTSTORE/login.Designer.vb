<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
      Me.bgpic = New System.Windows.Forms.PictureBox()
      Me.bSettings = New System.Windows.Forms.Button()
      Me.bcancel = New System.Windows.Forms.Button()
      Me.blogin = New System.Windows.Forms.Button()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.password = New System.Windows.Forms.TextBox()
      Me.userid = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.version = New System.Windows.Forms.Label()
      Me.tmr = New System.Windows.Forms.Timer(Me.components)
      Me.wb = New System.Windows.Forms.WebBrowser()
      CType(Me.bgpic, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'bgpic
      '
      Me.bgpic.BackColor = System.Drawing.Color.Transparent
      Me.bgpic.BackgroundImage = Global.SFTSTORE.My.Resources.Resources.sftdvlogo2015
      Me.bgpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.bgpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.bgpic.InitialImage = Nothing
      Me.bgpic.Location = New System.Drawing.Point(14, 12)
      Me.bgpic.Name = "bgpic"
      Me.bgpic.Size = New System.Drawing.Size(600, 150)
      Me.bgpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.bgpic.TabIndex = 16
      Me.bgpic.TabStop = False
      '
      'bSettings
      '
      Me.bSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.bSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bSettings.ForeColor = System.Drawing.Color.White
      Me.bSettings.Location = New System.Drawing.Point(255, 254)
      Me.bSettings.Name = "bSettings"
      Me.bSettings.Size = New System.Drawing.Size(101, 31)
      Me.bSettings.TabIndex = 101
      Me.bSettings.Text = "&Settings"
      Me.bSettings.UseVisualStyleBackColor = False
      '
      'bcancel
      '
      Me.bcancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
      Me.bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bcancel.ForeColor = System.Drawing.Color.White
      Me.bcancel.Location = New System.Drawing.Point(362, 254)
      Me.bcancel.Name = "bcancel"
      Me.bcancel.Size = New System.Drawing.Size(75, 31)
      Me.bcancel.TabIndex = 102
      Me.bcancel.Text = "&Exit"
      Me.bcancel.UseVisualStyleBackColor = False
      '
      'blogin
      '
      Me.blogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.blogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.blogin.ForeColor = System.Drawing.Color.White
      Me.blogin.Location = New System.Drawing.Point(174, 254)
      Me.blogin.Name = "blogin"
      Me.blogin.Size = New System.Drawing.Size(75, 31)
      Me.blogin.TabIndex = 100
      Me.blogin.Text = "&Login"
      Me.blogin.UseVisualStyleBackColor = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(172, 224)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(91, 20)
      Me.Label2.TabIndex = 21
      Me.Label2.Text = "Password:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(172, 192)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(114, 20)
      Me.Label1.TabIndex = 20
      Me.Label1.Text = "Associate Id:"
      '
      'password
      '
      Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.password.Location = New System.Drawing.Point(292, 221)
      Me.password.Name = "password"
      Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.password.Size = New System.Drawing.Size(102, 26)
      Me.password.TabIndex = 2
      '
      'userid
      '
      Me.userid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.userid.Location = New System.Drawing.Point(292, 189)
      Me.userid.Name = "userid"
      Me.userid.Size = New System.Drawing.Size(161, 26)
      Me.userid.TabIndex = 1
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(289, 163)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(0, 13)
      Me.Label3.TabIndex = 24
      '
      'version
      '
      Me.version.BackColor = System.Drawing.Color.Transparent
      Me.version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.version.Location = New System.Drawing.Point(63, 168)
      Me.version.Name = "version"
      Me.version.Size = New System.Drawing.Size(496, 18)
      Me.version.TabIndex = 25
      Me.version.Text = "Label1"
      Me.version.TextAlign = System.Drawing.ContentAlignment.TopCenter
      '
      'tmr
      '
      Me.tmr.Enabled = True
      '
      'wb
      '
      Me.wb.Location = New System.Drawing.Point(352, 163)
      Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
      Me.wb.Name = "wb"
      Me.wb.Size = New System.Drawing.Size(263, 100)
      Me.wb.TabIndex = 103
      Me.wb.Visible = False
      '
      'login
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(627, 297)
      Me.ControlBox = False
      Me.Controls.Add(Me.wb)
      Me.Controls.Add(Me.version)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.userid)
      Me.Controls.Add(Me.password)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.bSettings)
      Me.Controls.Add(Me.bcancel)
      Me.Controls.Add(Me.blogin)
      Me.Controls.Add(Me.bgpic)
      Me.Name = "login"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "login"
      CType(Me.bgpic, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents bgpic As System.Windows.Forms.PictureBox
   Friend WithEvents bSettings As System.Windows.Forms.Button
   Friend WithEvents bcancel As System.Windows.Forms.Button
   Friend WithEvents blogin As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents password As System.Windows.Forms.TextBox
   Friend WithEvents userid As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents version As System.Windows.Forms.Label
   Friend WithEvents tmr As System.Windows.Forms.Timer
   Friend WithEvents wb As System.Windows.Forms.WebBrowser
End Class
