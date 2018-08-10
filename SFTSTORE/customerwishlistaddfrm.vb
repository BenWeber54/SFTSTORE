Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class customerwishlistaddfrm
   Dim startSWT& = 0
   Private Sub customerwishlistaddfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      loadProducts()
      If dr.FRMSWT = 1 Then
         Me.Text = Txt(605)
         Inits()
      Else
         Me.Text = Txt(606)
         cmbProduct.Enabled = False
         Display()
      End If
      lblName.Text = Txt(547) + ":"
      lblQuantity.Text = Txt(611) + ":"
      lblOrdered.Text = Txt(604) + ":"

      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)
   End Sub
   Private Sub Inits()
      InitCustomerWishlist(dr)
      Display()
   End Sub
   Private Sub Display()
      SetCboIndex(cmbProduct, dr.cw_PRO_PRODUCT)
      txtQuantity.Text = dr.cw_iQuantity
      If dr.cw_iOrdered = 1 Then
         chkOrdered.Checked = False
      Else
         chkOrdered.Checked = True
      End If
   End Sub
   Private Sub ScreenToRecord()
      dr.cw_PRO_PRODUCT = CType(cmbProduct.SelectedItem, ComboClass).Value
      dr.cw_iQuantity = CLng(GetFloat(txtQuantity.Text))
      dr.cw_CUS_CUSTOMER = dr.cu_iid
      If chkOrdered.Checked = True Then
         dr.cw_iOrdered = 2
      Else
         dr.cw_iOrdered = 1
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.cw_PRO_PRODUCT = 0 Then
         cmbProduct.Focus()
         MsgDsp(Txt(549))
         Exit Function
      End If
      If dr.cw_iQuantity <= 0 Then
         txtQuantity.Focus()
         MsgDsp(Txt(608))
         Exit Function
      End If
      If dr.FRMSWT = 1 Then
         Dim tl1& = dr.cw_iQuantity
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM CUS_WISHLIST WHERE cw_PRO_PRODUCT = " + CStr(dr.cw_PRO_PRODUCT) + " AND cw_CUS_CUSTOMER = " + CStr(dr.cu_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If MsgBox(Txt(609), vbYesNo, Txt(563)) = MsgBoxResult.Yes Then
               GetCustomerWishlistRecord(dr.oread("cw_iid"), dr)
               dr.cw_iQuantity += tl1
               UpdateCustomerWishlistRecord(dr)
               MsgDsp(Txt(610))
               Me.Close()
               Exit Function
            Else
               MsgDsp(Txt(564))
               Exit Function
            End If
         End If
         dr.oread.Close()
      End If
      Validation = 1
   End Function
   Private Sub loadProducts()
      cmbProduct.Items.Clear()
      cmbProduct.Items.Add(New ComboClass(0, "NOT DEFINED"))
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_PRODUCT WHERE pp_COM_COMPANY = " + CStr(dr.sr_iCompany) + " ORDER BY pp_szProductName"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            cmbProduct.Items.Add(New ComboClass(dr.oread("pp_iid"), dr.oread("pp_szProductName")))
         Loop
      Else
         dr.oread.Close()
         MsgDsp(Txt(607))
         Me.Close()
      End If
      dr.oread.Close()
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_WISHLIST WHERE cw_iid = " + CStr(dr.cw_iid), tstr1)
         MsgDsp(Txt(355))
         Me.Close()
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.cw_iid
      UpdateCustomerWishlistRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Me.Close()
   End Sub
#End Region
   Private Sub customerwishlistfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      dr.FRMSWT = 1
   End Sub
End Class