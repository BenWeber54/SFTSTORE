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

Public Class customerwishlistfrm
   Dim startSWT& = 0
   Private Sub customerwishlistfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(619)
      lblName.Text = Txt(547) + ":"
      lblNumber.Text = Txt(546) + ":"

      btnRefresh.Text = Txt(602)
      btnAdd.Text = Txt(603)
      btnEdit.Text = Txt(566)
      btnOpen.Text = Txt(380)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)
      lstLoad()
   End Sub
   Private Sub lstLoad()
      TestConnection()
      lst.Clear()
      dr.ocmd.CommandText = "SELECT * FROM CUS_WISHLIST JOIN PRO_PRODUCT ON cw_PRO_PRODUCT = pp_iid WHERE cw_CUS_CUSTOMER = " + CStr(dr.cu_iid)
      If Trim(txtNumber.Text) <> "" Then
         dr.ocmd.CommandText += " AND pp_szProductNumber LIKE '%" + AStr(Trim(txtNumber.Text)) + "%'"
      End If
      If Trim(txtName.Text) <> "" Then
         dr.ocmd.CommandText += " AND pp_szProductName LIKE '%" + AStr(Trim(txtName.Text)) + "%'"
      End If
      dr.ocmd.CommandText += " ORDER BY pp_szProductName"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         lst.View = View.Details
         lst.Columns.Add(Txt(547), lst.Width - 480, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(546), 200, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(604), 70, HorizontalAlignment.Center)
         lst.Columns.Add(Txt(611), 80, HorizontalAlignment.Center)
         lst.Columns.Add(Txt(378), 125, HorizontalAlignment.Left)
         Do While dr.oread.Read()
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("pp_szProductName")))
            ListItem1.Tag = CStr(dr.oread("cw_iid"))
            ListItem1.SubItems.Add(dr.oread("pp_szProductNumber"))
            If dr.oread("cw_iOrdered") = 1 Then
               ListItem1.SubItems.Add(Txt(354))
            Else
               ListItem1.SubItems.Add(Txt(353))
            End If
            ListItem1.SubItems.Add(dr.oread("cw_iQuantity"))
            ListItem1.SubItems.Add(Format(dr.oread("cw_dDate"), "dd/MMM/yyyy"))
            lst.Items.Add(ListItem1)
         Loop
      Else
         dr.oread.Close()
         MsgDsp(Txt(361))
         If startSWT = 0 Then
            Me.Close()
         End If
      End If
      dr.oread.Close()
      startSWT = 1
   End Sub
#Region "Click events"
   Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
      lstLoad()
   End Sub
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      Dim tl1& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ExecuteScalar(dr.szConnection, "DELETE FROM CUS_WISHLIST WHERE cw_iid = " + CStr(tl1), tstr1)
               lstLoad()
               MsgDsp(Txt(355))
            End If
         End If
      Next
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      Dim tstr1$ = ""
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetCustomerWishlistRecord(tl1, dr)
            GetProductRecord(dr.cw_PRO_PRODUCT, dr)
            dr.FRMSWT = 2
            Dim frm As productsfrm
            frm = New productsfrm
            frm.ShowDialog()
            tl1 = 1
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub lst_DoubleClick(sender As Object, e As EventArgs) Handles lst.DoubleClick
      Dim tstr1$ = ""
      Dim tl1& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetCustomerWishlistRecord(tl1, dr)
            GetProductRecord(dr.cw_PRO_PRODUCT, dr)
            dr.FRMSWT = 2
            Dim frm As productsfrm
            frm = New productsfrm
            frm.ShowDialog()
         End If
      Next
   End Sub
   Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
      dr.FRMSWT = 1
      Dim frm As customerwishlistaddfrm
      frm = New customerwishlistaddfrm
      frm.ShowDialog()
      lstLoad()
      'dr.LIST_CTRL = 13
      'Dim frm As listfrm
      'frm = New listfrm
      'frm.ShowDialog()
      'If dr.LIST_RET = 1 Then
      '   InitCustomerWishlist(dr)
      '   dr.cw_CUS_CUSTOMER = dr.cu_iid
      '   dr.cw_PRO_PRODUCT = dr.pp_iid
      '   UpdateCustomerWishlistRecord(dr)
      '   lstLoad()
      'End If
   End Sub
   Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetCustomerWishlistRecord(tl1, dr)
            dr.FRMSWT = 2
            Dim frm As customerwishlistaddfrm
            frm = New customerwishlistaddfrm
            frm.ShowDialog()
            lstLoad()
            tl2 = 1
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
#End Region

   Private Sub customerwishlistfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      dr.FRMSWT = 1
   End Sub
End Class