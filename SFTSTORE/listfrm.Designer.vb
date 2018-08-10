<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listfrm
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
      Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
      Me.txt3 = New System.Windows.Forms.TextBox()
      Me.lbl3 = New System.Windows.Forms.Label()
      Me.bClose = New System.Windows.Forms.Button()
      Me.txt1 = New System.Windows.Forms.TextBox()
      Me.txt2 = New System.Windows.Forms.TextBox()
      Me.lbl1 = New System.Windows.Forms.Label()
      Me.lst = New System.Windows.Forms.ListView()
      Me.brefresh = New System.Windows.Forms.Button()
      Me.lbl2 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'txt3
      '
      Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txt3.Location = New System.Drawing.Point(183, 70)
      Me.txt3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.txt3.Name = "txt3"
      Me.txt3.Size = New System.Drawing.Size(408, 26)
      Me.txt3.TabIndex = 40
      Me.txt3.Visible = False
      '
      'lbl3
      '
      Me.lbl3.AutoSize = True
      Me.lbl3.BackColor = System.Drawing.Color.Transparent
      Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbl3.Location = New System.Drawing.Point(7, 73)
      Me.lbl3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
      Me.lbl3.Name = "lbl3"
      Me.lbl3.Size = New System.Drawing.Size(105, 20)
      Me.lbl3.TabIndex = 41
      Me.lbl3.Text = "Description:"
      Me.lbl3.Visible = False
      '
      'bClose
      '
      Me.bClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.bClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.bClose.ForeColor = System.Drawing.Color.White
      Me.bClose.Location = New System.Drawing.Point(619, 567)
      Me.bClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.bClose.Name = "bClose"
      Me.bClose.Size = New System.Drawing.Size(91, 33)
      Me.bClose.TabIndex = 39
      Me.bClose.Text = "&Close"
      Me.bClose.UseVisualStyleBackColor = False
      '
      'txt1
      '
      Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txt1.Location = New System.Drawing.Point(183, 8)
      Me.txt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.txt1.Name = "txt1"
      Me.txt1.Size = New System.Drawing.Size(408, 26)
      Me.txt1.TabIndex = 35
      Me.txt1.Visible = False
      '
      'txt2
      '
      Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txt2.Location = New System.Drawing.Point(183, 39)
      Me.txt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.txt2.Name = "txt2"
      Me.txt2.Size = New System.Drawing.Size(408, 26)
      Me.txt2.TabIndex = 37
      Me.txt2.Visible = False
      '
      'lbl1
      '
      Me.lbl1.AutoSize = True
      Me.lbl1.BackColor = System.Drawing.Color.Transparent
      Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbl1.Location = New System.Drawing.Point(7, 11)
      Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
      Me.lbl1.Name = "lbl1"
      Me.lbl1.Size = New System.Drawing.Size(105, 20)
      Me.lbl1.TabIndex = 36
      Me.lbl1.Text = "Description:"
      Me.lbl1.Visible = False
      '
      'lst
      '
      Me.lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      Me.lst.CheckBoxes = True
      Me.lst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lst.ForeColor = System.Drawing.Color.Black
      Me.lst.FullRowSelect = True
      Me.lst.GridLines = True
      ListViewGroup1.Header = "ListViewGroup"
      ListViewGroup1.Name = "ListViewGroup1"
      ListViewGroup2.Header = "ListViewGroup"
      ListViewGroup2.Name = "ListViewGroup2"
      ListViewGroup3.Header = "ListViewGroup"
      ListViewGroup3.Name = "ListViewGroup3"
      ListViewGroup4.Header = "ListViewGroup"
      ListViewGroup4.Name = "ListViewGroup4"
      ListViewGroup5.Header = "ListViewGroup"
      ListViewGroup5.Name = "ListViewGroup5"
      ListViewGroup6.Header = "ListViewGroup"
      ListViewGroup6.Name = "ListViewGroup6"
      Me.lst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4, ListViewGroup5, ListViewGroup6})
      Me.lst.Location = New System.Drawing.Point(11, 102)
      Me.lst.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.lst.Name = "lst"
      Me.lst.OwnerDraw = True
      Me.lst.Size = New System.Drawing.Size(699, 459)
      Me.lst.TabIndex = 33
      Me.lst.UseCompatibleStateImageBehavior = False
      Me.lst.View = System.Windows.Forms.View.Details
      '
      'brefresh
      '
      Me.brefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
      Me.brefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.brefresh.ForeColor = System.Drawing.Color.White
      Me.brefresh.Location = New System.Drawing.Point(619, 8)
      Me.brefresh.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
      Me.brefresh.Name = "brefresh"
      Me.brefresh.Size = New System.Drawing.Size(91, 33)
      Me.brefresh.TabIndex = 34
      Me.brefresh.Text = "&Refresh"
      Me.brefresh.UseVisualStyleBackColor = False
      '
      'lbl2
      '
      Me.lbl2.AutoSize = True
      Me.lbl2.BackColor = System.Drawing.Color.Transparent
      Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbl2.Location = New System.Drawing.Point(7, 42)
      Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
      Me.lbl2.Name = "lbl2"
      Me.lbl2.Size = New System.Drawing.Size(105, 20)
      Me.lbl2.TabIndex = 38
      Me.lbl2.Text = "Description:"
      Me.lbl2.Visible = False
      '
      'listfrm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(721, 612)
      Me.ControlBox = False
      Me.Controls.Add(Me.txt3)
      Me.Controls.Add(Me.lbl3)
      Me.Controls.Add(Me.bClose)
      Me.Controls.Add(Me.txt1)
      Me.Controls.Add(Me.txt2)
      Me.Controls.Add(Me.lbl1)
      Me.Controls.Add(Me.lst)
      Me.Controls.Add(Me.brefresh)
      Me.Controls.Add(Me.lbl2)
      Me.Name = "listfrm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "List"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txt3 As System.Windows.Forms.TextBox
   Friend WithEvents lbl3 As System.Windows.Forms.Label
   Friend WithEvents bClose As System.Windows.Forms.Button
   Friend WithEvents txt1 As System.Windows.Forms.TextBox
   Friend WithEvents txt2 As System.Windows.Forms.TextBox
   Friend WithEvents lbl1 As System.Windows.Forms.Label
   Friend WithEvents lst As System.Windows.Forms.ListView
   Friend WithEvents brefresh As System.Windows.Forms.Button
   Friend WithEvents lbl2 As System.Windows.Forms.Label
End Class
