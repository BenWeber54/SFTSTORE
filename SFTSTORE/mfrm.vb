Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Net.Mail
Imports SFTSTORE.data
Imports SFTSTORE.ftn

Public Class mfrm

   Dim tCNT&
   Dim LISTSORT%(10)
   Dim tSETTLED As Date
   Dim ir As DATA_RECORD

   Private Sub Button2_Click(sender As Object, e As EventArgs)
      End
   End Sub
   Public Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      Inits()
      tSETTLED = Now.AddMinutes(-120)
   End Sub
   Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
      Dim tstr1$

      tstr1 = e.ClickedItem.Name

      ToolbarClick(tstr1)
   End Sub
   Private Sub mfrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      bgpic.Location = New Point((Me.Width - bgpic.Width) / 2, (Me.Height - bgpic.Height) / 2)
      ltest.Location = New Point((Me.Width - ltest.Width) / 2, bgpic.Top + bgpic.Height + 2)
      lprod.Location = New Point((Me.Width - lprod.Width) / 2, bgpic.Top + bgpic.Height + 2)
      llocal.Location = New Point((Me.Width - llocal.Width) / 2, bgpic.Top + bgpic.Height + 2)
      lalpha.Location = New Point((Me.Width - lalpha.Width) / 2, bgpic.Top + bgpic.Height + 2)
      lsettled.Location = New Point((Me.Width - lsettled.Width) / 2, ltest.Top + ltest.Height + 5)
      lsettled.Text = " "
   End Sub
   Private Sub mfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      sbar.BackColor = Me.BackColor
      ltest.Visible = False
      lalpha.Visible = False
      llocal.Visible = False
      lprod.visible = True
      If dr.cr_test = 1 Then
         Me.BackgroundImage.Dispose()
         Me.BackgroundImage = Nothing
         ltest.Visible = True
         lprod.visible = False
         sbar.BackColor = ltest.ForeColor
         sbar.ForeColor = Color.Silver
      End If
      If dr.cr_test = 2 Then
         Me.BackgroundImage.Dispose()
         Me.BackgroundImage = Nothing
         llocal.Visible = True
         lprod.visible = False
         sbar.BackColor = llocal.ForeColor
      End If
      If dr.cr_test = 3 Then
         Me.BackgroundImage.Dispose()
         Me.BackgroundImage = Nothing
         lalpha.Visible = True
         lprod.visible = False
         sbar.BackColor = lalpha.ForeColor
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM COM_COMPANY "
      dr.ocmd.CommandText += " JOIN COM_IMAGES ON ci_COM_COMPANY = co_iid"
      dr.ocmd.CommandText += " WHERE co_iid = " + CStr(dr.sr_iCompany) + " AND ci_iType = 2"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
            Dim tstr5$ = ""
            Dim fileName As String
            Dim bytes() As Byte
         bytes = dr.oread("ci_bBinary")
         If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Images") Then
            MkDir(AppDomain.CurrentDomain.BaseDirectory + "Images")
         End If
         Dim objHeight@ = 0, objWidth@ = 0
         fileName = AppDomain.CurrentDomain.BaseDirectory + "Images\" + dr.oread("ci_szFilename")
         If File.Exists(fileName) Then
            If IsValidImage(fileName) = True Then
               Dim objImage As System.Drawing.Image = System.Drawing.Image.FromFile(fileName)
               objHeight = objImage.Height
               objWidth = objImage.Width
               bgpic.Image = objImage
            End If
         Else
            Dim wrt As FileStream
            wrt = File.OpenWrite(fileName)
            wrt.Write(bytes, 0, UBound(bytes) + 1)
            wrt.Close()

            If IsValidImage(fileName) = True Then
               Dim objImage As System.Drawing.Image = System.Drawing.Image.FromFile(fileName)
               objHeight = objImage.Height
               objWidth = objImage.Width
               bgpic.Image = objImage
            End If
         End If
         If objHeight > 250 Then
            objWidth = CLng((objWidth * 250) / objHeight)
            objHeight = 250
            'ElseIf objWidth > 800 Then
         End If
         bgpic.SizeMode = PictureBoxSizeMode.StretchImage
         bgpic.Size = New Size(objWidth, objHeight)
         mfrm_Resize(sender, e)

      End If
      dr.oread.Close()
   End Sub
   Private Sub MainTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
      Dim tstr1$
      Dim tl1&
      tstr1 = ""
      If dr.cr_test > 0 Then
         If dr.cr_test = 1 Then tstr1 += "*** TEST ***"
         If dr.cr_test = 2 Then tstr1 += "*** LOCAL ***"
         If dr.cr_test = 3 Then tstr1 += "*** ALPHA ***"
         tstr1 += "  "
      End If
      tstr1 += "Version: " + dr.cr_szVersion + "  "
      tstr1 += Format(Now, "dd/MMM/yyyy HH:mm:ss")
      If dr.sr_szDisplay <> "" Then
         tstr1 = tstr1 + " " + dr.sr_szDisplay
      End If
      If tstr1 <> sr.Text Then
         sr.Text = tstr1
      End If
      tstr1 = dr.sbarleft
      If tstr1 <> sl.Text Then
         sl.Text = tstr1
      End If
      tl1 = Now.Minute
      If tl1 - dr.MFRM_CNT < 0 Then
         tl1 += 60
      End If
      Application.DoEvents()
   End Sub
   Private Sub tbar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tbar.ItemClicked
      Dim tstr1$

      tstr1 = e.ClickedItem.Name

      ToolbarClick(tstr1)
   End Sub

   Private Sub CompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem.Click
      ToolbarClick("tb_company")
   End Sub
   Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
      ToolbarClick("tb_users")
   End Sub
   Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
      ToolbarClick("tb_products")
   End Sub
   Private Sub ProductTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductTypesToolStripMenuItem.Click
      ToolbarClick("tb_productTypes")
   End Sub
   Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
      ToolbarClick("tb_customers")
   End Sub
   Private Sub menulogoff_Click(sender As Object, e As EventArgs) Handles menulogoff.Click
      ToolbarClick("tb_logoff")
   End Sub
   Private Sub menuexit_Click(sender As Object, e As EventArgs) Handles menuexit.Click
      ToolbarClick("tb_exit")
   End Sub
   Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
      ToolbarClick("tb_orders")
   End Sub
   Private Sub ShippingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShippingToolStripMenuItem.Click
      ToolbarClick("tb_shipping")
   End Sub
   Private Sub ShippingBoxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShippingBoxesToolStripMenuItem.Click
      ToolbarClick("tb_shipping_boxes")
   End Sub
   Private Sub MiscDatabaseTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiscDatabaseTablesToolStripMenuItem.Click
      ToolbarClick("tb_misc")
   End Sub
   Private Sub InvoicingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicingToolStripMenuItem.Click
      ToolbarClick("tb_invoice")
   End Sub
   Private Sub PromoCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoCodesToolStripMenuItem.Click
      ToolbarClick("tb_promocodes")
   End Sub
End Class