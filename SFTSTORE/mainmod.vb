Imports SFTSTORE.data
Imports SFTSTORE.ftn
'Imports SFTSTORE.reportxcl
Imports System.Drawing.Printing

Module mainmod
   Public frm As Form
   <STAThread()> _
   Public Sub Main()
      dr.tx_txt = Split("|", "|")

      Inits()
      LoggingOn()
   End Sub

   Public Sub LoggingOn()
      Dim lfrm As login
      lfrm = New login
      lfrm.Text = DEF_TITLE
      lfrm.ShowDialog()

      If dr.szLogin = "END" Then
         End
         Exit Sub
      End If
      If dr.szLogin = "OK" Then
         MainForm()
      End If
   End Sub
   Public Sub MainForm()
      dr.MFRM_INTERVAL = 15
      If CLng(GetFloat(GetKeyValue(dr.sr_szSettings, "INTERVAL"))) > 0 Then
         dr.MFRM_INTERVAL = CLng(GetFloat(GetKeyValue(dr.sr_szSettings, "INTERVAL")))
      End If
      dr.MFRM_CNT = Now.Minute - dr.MFRM_INTERVAL

      frm = New mfrm
      frm.Text = DEF_TITLE
      frm.ShowDialog()
      dr.frm = frm
   End Sub
   Public Sub ToolbarClick(istr$)
      If istr = "tb_exit" Then
         End
      End If
      If istr = "tb_logoff" Then
         frm.Close()
         frm.Dispose()
         LoggingOn()
      End If
      If istr = "tb_company" Then
         Dim frm As companyfrm
         frm = New companyfrm
         frm.ShowDialog()
      End If
      If istr = "tb_users" Then
         Dim frm As userfrm
         frm = New userfrm
         frm.ShowDialog()
      End If
      If istr = "tb_products" Then
         dr.FRMSWT = 1
         Dim frm As productsfrm
         frm = New productsfrm
         frm.ShowDialog()
      End If
      If istr = "tb_productTypes" Then
         Dim frm As producttypesfrm
         frm = New producttypesfrm
         frm.ShowDialog()
      End If
      If istr = "tb_customers" Then
         Dim frm As customerfrm
         frm = New customerfrm
         frm.ShowDialog()
      End If
      If istr = "tb_orders" Then
         Dim frm As ordersfrm
         frm = New ordersfrm
         frm.ShowDialog()
      End If
      If istr = "tb_shipping" Then
         Dim frm As shippingfrm
         frm = New shippingfrm
         frm.ShowDialog()
      End If
      If istr = "tb_shipping_boxes" Then
         dr.FRMSWT = 1
         Dim frm As companyboxesfrm
         frm = New companyboxesfrm
         frm.ShowDialog()
      End If
      If istr = "tb_misc" Then
         Dim frm As maintenancefrm
         frm = New maintenancefrm
         frm.ShowDialog()
      End If
      If istr = "tb_invoice" Then
         Dim frm As invoicefrm
         frm = New invoicefrm
         frm.ShowDialog()
      End If
      If istr = "tb_promocodes" Then
         Dim frm As promocodesfrm
         frm = New promocodesfrm
         frm.ShowDialog()
      End If
   End Sub
End Module
