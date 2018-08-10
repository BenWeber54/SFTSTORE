Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class ordersfrm
   Dim tCNT&
   Dim LISTSORT%(10)
   Private Sub ordersfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      lblOrder.Text = Txt(636) + ":"
      lblDate.Text = Txt(638) + ":"
      lblCustomer.Text = Txt(585) + ":"
      lblShipping.Text = Txt(645)
      lblAddress.Text = Txt(580) + ":"
      lblNotes.Text = Txt(384) + ":"
      lblDetail.Text = Txt(647)
      lblCusNotes.Text = Txt(646) + ":"
      lblStatus.Text = Txt(644) + ":"

      lblActive.Text = Txt(36)
      lblCompleted.Text = Txt(697)
      lblOnHold.Text = Txt(695)
      lblCancelled.Text = Txt(696)

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(648)
      btnClose.Text = Txt(390)
      btnAdd.Text = Txt(603)
      btnEdit.Text = Txt(566)
      btnDeleteDetail.Text = Txt(649)

      cmbStatus.Items.Add(New ComboClass(1, Txt(653)))
      cmbStatus.Items.Add(New ComboClass(2, Txt(650)))
      cmbStatus.Items.Add(New ComboClass(3, Txt(651)))
      cmbStatus.Items.Add(New ComboClass(4, Txt(652)))
      cmbStatus.Items.Add(New ComboClass(5, Txt(696)))
      Inits()
   End Sub
   Private Sub Inits()
      InitOrder(dr)
      Display()
   End Sub
   Private Sub Display()
      dpOrderDate.Value = dr.oo_dOrderDate
      SetCboIndex(cmbStatus, dr.oo_iStatus)
      If dr.oo_CUS_CUSTOMER > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT cu_szFirst, cu_szLast, cu_szNotes FROM CUS_CUSTOMER WHERE cu_iid = " + CStr(dr.oo_CUS_CUSTOMER)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtCustomer.Text = dr.oread("cu_szLast") + ", " + dr.oread("cu_szFirst")
            txtCusNotes.Text = dr.oread("cu_szNotes")
         End If
         dr.oread.Close()
      Else
         txtCustomer.Text = ""
         txtCusNotes.Text = ""
      End If

      If dr.oo_CUS_ADDRESS > 0 Then
         dr.ocmd.CommandText = "SELECT ca_szAddr1, ca_szAddr2, ca_szCity, ca_iProvince, ca_szPostal, ca_iCountry FROM CUS_ADDRESS WHERE ca_iid = " + CStr(dr.oo_CUS_ADDRESS)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtAddress.Text = ""
            txtAddress.Text += dr.oread("ca_szAddr1") + vbCrLf
            If dr.oread("ca_szAddr2") <> "" Then
               txtAddress.Text += dr.oread("ca_szAddr2") + vbCrLf
            End If
            Dim tl1& = 0
            If dr.oread("ca_iCountry") = CANADA Then
               tl1 = 119
            Else
               tl1 = 219
            End If
            txtAddress.Text += dr.oread("ca_szCity") + ", " + Txt(tl1 + dr.oread("ca_iProvince")) + vbCrLf
            txtAddress.Text += dr.oread("ca_szPostal")
         End If
         dr.oread.Close()
      Else
         txtAddress.Text = ""
      End If
      If dr.oo_iid > 0 Then
         txtOrder.Text = CStr(dr.oo_iid)
         detailListLoad()
      Else
         lstDetails.Clear()
         txtOrder.Text = "New"
      End If
      txtNotes.Text = dr.oo_szNotes
      If dr.oo_iid > 0 Then
         populateCodeText()
      Else
         txtCode.Text = ""
      End If
   End Sub
   Private Sub populateCodeText()
      Dim tstr1$ = ""
      If dr.oo_PRM_CODES > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM PRM_CODES WHERE po_iid = " + CStr(dr.oo_PRM_CODES)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            tstr1 = CStr(dr.oread("po_szCode")) + "  /  "
            If dr.oread("po_iDiscountType") = 0 Then
               tstr1 += "$" + StringFormatEnglish(2, dr.oread("po_rDiscount"))
            Else
               tstr1 += StringFormatEnglish(2, dr.oread("po_rDiscount")) + "%"
            End If
            txtCode.Text = CStr(tstr1)
         Else
            txtCode.Text = ""
         End If
         dr.oread.Close()
      Else
         txtCode.Text = ""
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.oo_CUS_CUSTOMER = 0 Then
         MsgDsp(Txt(586))
         Exit Function
      End If
      If dr.oo_CUS_ADDRESS = 0 Then
         MsgDsp(Txt(639))
         Exit Function
      End If
      If dr.oo_iid > 0 Then
         If CType(cmbStatus.SelectedItem, ComboClass).Value = 2 Then
            If dr.oo_iStatus <> 2 Then
               'asking if they want to send processing email
               'If MsgBox(Txt(1), vbYesNo, Txt(1)) = MsgBoxResult.Yes Then

               'End If
            End If
         ElseIf CType(cmbStatus.SelectedItem, ComboClass).Value = 4 Then
            If dr.oo_iStatus <> 4 Then
               'asking if they want to send out email to get a review
               'If MsgBox(Txt(1), vbYesNo, Txt(1)) = MsgBoxResult.Yes Then

               'End If
            End If
         ElseIf CType(cmbStatus.SelectedItem, ComboClass).Value = 5 Then
            'check if any of the details have been shipped or not then remove items from quantity
            If MsgBox(Txt(1), vbYesNo, Txt(1)) = MsgBoxResult.Yes Then
               If dr.oo_iStatus <> 5 Then
                  TestConnection()
                  dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
                  dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
                  dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND ot_iReturned = 0"
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     'Do While dr.oread.Read()
                     '   'check if any order details have been completed

                     'Loop
                     cmbStatus.Focus()
                     MsgBox(Txt(818))
                     dr.oread.Close()
                     Exit Function
                  Else
                     Dim tstr1$ = ""
                     Dim transactionArray$()
                     dr.oread.Close()
                     TestConnection()
                     dr.ocmd.CommandText = "SELECT od_iid, od_PRO_PRODUCT, od_iQuantity FROM ORD_ORDERS JOIN ORD_DETAIL ON od_ORD_ORDERS = oo_iid"
                     dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND (od_iStatus = 1 OR od_iStatus = 2)"
                     dr.ocmd.CommandText += " "
                     dr.oread = dr.ocmd.ExecuteReader()
                     If dr.oread.HasRows = True Then
                        Do While dr.oread.Read()
                           tstr1 += CStr(dr.oread("od_PRO_PRODUCT")) + "|"
                           tstr1 += CStr(dr.oread("od_iid")) + "|"
                           tstr1 += CStr(dr.oread("od_iQuantity")) + "|"
                        Loop
                     End If
                     dr.oread.Close()
                     If tstr1 <> "" Then
                        transactionArray = Split(tstr1, "|")
                        For tl1 = 0 To UBound(transactionArray) - 1 Step 3
                           InitProductTransaction(dr)
                           GetOrderDetailRecord(CLng(transactionArray(tl1 + 1)), dr)
                           dr.od_iStatus = 4
                           UpdateOrderDetailRecord(dr)

                           TestConnection()
                           dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(transactionArray(tl1)) + " ORDER BY pn_dDate Desc"
                           dr.oread = dr.ocmd.ExecuteReader()
                           If dr.oread.HasRows = True Then
                              dr.oread.Read()
                              dr.pn_iRemaining = dr.oread("pn_iRemaining")
                           Else
                              dr.pn_iRemaining = 0
                           End If
                           dr.oread.Close()

                           dr.pn_PRO_PRODUCT = CLng(transactionArray(tl1))
                           dr.pn_iType = 3
                           dr.pn_iKey = CLng(transactionArray(tl1 + 1))
                           dr.pn_iChanged = CLng(transactionArray(tl1 + 2))
                           dr.pn_szDescription = "Order Cancelled"
                           dr.pn_iRemaining = dr.pn_iRemaining - CLng(transactionArray(tl1 + 2))
                           UpdateProductTransactionRecord(dr)
                        Next
                     End If
                  End If
               End If
            End If
         End If
      Else
         cmbStatus.SelectedIndex = 0
      End If
      If dr.oo_iStatus = 5 Then
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.oo_dOrderDate = dpOrderDate.Value
      dr.oo_szNotes = Trim(txtNotes.Text)
   End Sub
   Private Sub detailListLoad()
      TestConnection()
      lstDetails.Clear()
      lstDetails.View = View.Details
      lstDetails.Columns.Add(Txt(643), 120, HorizontalAlignment.Center)
      lstDetails.Columns.Add(Txt(547), lstDetails.Width - 395, HorizontalAlignment.Left)
      lstDetails.Columns.Add(Txt(611), 120, HorizontalAlignment.Center)
      'lstDetails.Columns.Add(Txt(637), 200, HorizontalAlignment.Left)
      lstDetails.Columns.Add(Txt(625), 150, HorizontalAlignment.Center)
      dr.ocmd.CommandText = "SELECT * FROM ORD_DETAIL "
      dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
      dr.ocmd.CommandText += " WHERE od_ORD_ORDERS = " + CStr(dr.oo_iid) + " ORDER BY od_iLineNumber"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("od_iLineNumber")))
            ListItem1.Tag = CStr(dr.oread("od_iid"))
            ListItem1.SubItems.Add(dr.oread("pp_szProductName"))
            ListItem1.SubItems.Add(dr.oread("od_iQuantity"))
            'ListItem1.SubItems.Add(dr.oread("od_szShipTracking"))
            If dr.oread("od_iStatus") = 1 Then
               ListItem1.SubItems.Add(Txt(36))
               ListItem1.BackColor = Color.White
            ElseIf dr.oread("od_iStatus") = 2 Then
               ListItem1.SubItems.Add(Txt(697))
               ListItem1.BackColor = Color.Lime
            ElseIf dr.oread("od_iStatus") = 3 Then
               ListItem1.SubItems.Add(Txt(695))
               ListItem1.BackColor = Color.Orange
            ElseIf dr.oread("od_iStatus") = 4 Then
               ListItem1.SubItems.Add(Txt(696))
               ListItem1.BackColor = Color.Red
               'ElseIf dr.oread("od_iStatus") = 5 Then
               '   ListItem1.SubItems.Add(Txt(645))
               '   ListItem1.BackColor = Color.White
            End If
            lstDetails.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
#Region "Click events"
   Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Inits()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr2$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
         dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
         dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND ot_iReturned = 0"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            cmbStatus.Focus()
            MsgBox(Txt(818))
            dr.oread.Close()
            Exit Sub
         Else
            Dim tstr1$ = ""
            Dim transactionArray$()
            dr.oread.Close()
            TestConnection()
            dr.ocmd.CommandText = "SELECT od_iid, od_PRO_PRODUCT, od_iQuantity FROM ORD_ORDERS JOIN ORD_DETAIL ON od_ORD_ORDERS = oo_iid"
            dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND (od_iStatus = 1 OR od_iStatus = 2)"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read()
                  tstr1 += CStr(dr.oread("od_PRO_PRODUCT")) + "|"
                  tstr1 += CStr(dr.oread("od_iid")) + "|"
                  tstr1 += CStr(dr.oread("od_iQuantity")) + "|"
               Loop
            End If
            dr.oread.Close()
            If tstr1 <> "" Then
               transactionArray = Split(tstr1, "|")
               For tl1 = 0 To UBound(transactionArray) - 1 Step 3
                  InitProductTransaction(dr)
                  GetOrderDetailRecord(CLng(transactionArray(tl1 + 1)), dr)
                  dr.od_iStatus = 4
                  UpdateOrderDetailRecord(dr)

                  TestConnection()
                  dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(transactionArray(tl1)) + " ORDER BY pn_dDate Desc"
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     dr.oread.Read()
                     dr.pn_iRemaining = dr.oread("pn_iRemaining")
                  Else
                     dr.pn_iRemaining = 0
                  End If
                  dr.oread.Close()

                  dr.pn_PRO_PRODUCT = CLng(transactionArray(tl1))
                  dr.pn_iType = 3
                  dr.pn_iKey = 0 'CLng(transactionArray(tl1 + 1))
                  dr.pn_iChanged = CLng(transactionArray(tl1 + 2))
                  dr.pn_szDescription = "Order Deleted"
                  dr.pn_iRemaining = dr.pn_iRemaining - CLng(transactionArray(tl1 + 2))
                  UpdateProductTransactionRecord(dr)
               Next
            End If
            ExecuteScalar(dr.szConnection, "DELETE FROM ORD_ORDERS WHERE oo_iid = " + CStr(dr.oo_iid), tstr2)
            ExecuteScalar(dr.szConnection, "DELETE FROM ORD_DETAIL WHERE od_ORD_ORDERS = " + CStr(dr.oo_iid), tstr2)
            btnNew_Click(sender, e)
            MsgDsp(Txt(355))
         End If
      End If
   End Sub
   Private Sub btnDeleteDetail_Click(sender As Object, e As EventArgs) Handles btnDeleteDetail.Click
      Dim tl2& = 0, tl1& = 0
      Dim tstr1$ = ""
      For Each itm As ListViewItem In lstDetails.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ScreenToRecord()
               GetOrderDetailRecord(tl1, dr)
               If detailShipped(dr.od_iid) = False Then
                  MsgDsp(Txt(792))
               Else
                  If dr.od_iStatus = 1 Then
                     InitProductTransaction(dr)

                     TestConnection()
                     dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.od_PRO_PRODUCT) + " ORDER BY pn_dDate Desc"
                     dr.oread = dr.ocmd.ExecuteReader()
                     If dr.oread.HasRows = True Then
                        dr.oread.Read()
                        dr.pn_iRemaining = dr.oread("pn_iRemaining")
                     Else
                        dr.pn_iRemaining = 0
                     End If
                     dr.oread.Close()
                     dr.pn_iChanged = dr.od_iQuantity
                     dr.pn_iRemaining += dr.pn_iChanged
                     dr.pn_szDescription = Txt(700)
                     dr.pn_iType = 4
                     dr.pn_iKey = dr.od_iid
                     dr.pn_PRO_PRODUCT = dr.od_PRO_PRODUCT
                     UpdateProductTransactionRecord(dr)
                  End If
                  ExecuteScalar(dr.szConnection, "DELETE FROM ORD_DETAIL WHERE od_iid = " + CStr(tl1), tstr1)
                  UpdateOrderDetailLineNumber(dr)
                  Display()
                  MsgDsp(Txt(355))
               End If
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 13
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         AddMostrecent(MR_ORDERS, dr)
      End If
   End Sub
   Private Sub btnRecent_Click(sender As Object, e As EventArgs) Handles btnRecent.Click
MostRecentRestart:
      dr.mr_iType = MR_ORDERS
      dr.LIST_CTRL = 2
      OpenMostRecent(dr)
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetOrderRecord(dr.LIST_KEY, dr)
         If dr.LIST_KEY = dr.oo_iid Then
            Display()
            AddMostrecent(MR_ORDERS, dr)
         Else
            RemoveMostRecent(MR_ORDERS, dr.LIST_KEY, dr)
            MsgDsp(Txt(366))
            GoTo MostRecentRestart
         End If
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      dr.oo_iStatus = CType(cmbStatus.SelectedItem, ComboClass).Value
      tl1 = dr.oo_iid
      UpdateOrderRecord(dr)
      AddMostrecent(MR_ORDERS, dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
      dr.LIST_CTRL = 14
      ScreenToRecord()
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub
   Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
      If dr.oo_CUS_CUSTOMER > 0 Then
         dr.LIST_CTRL = 15
         ScreenToRecord()
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            Display()
         End If
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
      If dr.oo_iid > 0 Then
         dr.FRMSWT = 1
         ScreenToRecord()
         Dim frm As orderdetailfrm
         frm = New orderdetailfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(642))
      End If
   End Sub
   Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
      If dr.oo_iid > 0 Then
         Dim tl2& = 0, tl1& = 0
         Dim tstr1$ = ""
         For Each itm As ListViewItem In lstDetails.SelectedItems
            If itm.Selected = True Then
               ScreenToRecord()
               tl1 = CLng(GetFloat(itm.Tag))
               tl2 = 1
               GetOrderDetailRecord(tl1, dr)
               If detailShipped(dr.od_iid) = False Then
                  MsgDsp(Txt(792))
               Else
                  dr.FRMSWT = 2
                  Dim frm As orderdetailfrm
                  frm = New orderdetailfrm
                  frm.ShowDialog()
                  Display()
               End If
            End If
         Next
         If tl2 = 0 Then
            MsgDsp(Txt(558))
         End If
      Else
         MsgDsp(Txt(642))
      End If
   End Sub
   Private Sub lstDetails_DoubleClick(sender As Object, e As EventArgs) Handles lstDetails.DoubleClick
      If dr.oo_iid > 0 Then
         Dim tl2& = 0, tl1& = 0
         Dim tstr1$ = ""
         For Each itm As ListViewItem In lstDetails.SelectedItems
            If itm.Selected = True Then
               tl1 = CLng(GetFloat(itm.Tag))
               GetOrderDetailRecord(tl1, dr)
               tl2 = 1
               If dr.od_szNotes <> "" Then
                  MsgBox(dr.od_szNotes, MsgBoxStyle.OkOnly, Txt(384))
               End If
               'ScreenToRecord()
               'tl1 = CLng(GetFloat(itm.Tag))
               'tl2 = 1
               'GetOrderDetailRecord(tl1, dr)
               'dr.FRMSWT = 2
               'Dim frm As orderdetailfrm
               'frm = New orderdetailfrm
               'frm.ShowDialog()
               'Display()
            End If
         Next
         If tl2 = 0 Then
            MsgDsp(Txt(558))
         End If
      Else
         MsgDsp(Txt(642))
      End If
   End Sub
   Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
      dr.LIST_CTRL = 29
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         dr.oo_PRM_CODES = dr.po_iid
         populateCodeText()
      End If
   End Sub
   Private Sub btnRemovePromo_Click(sender As Object, e As EventArgs) Handles btnRemovePromo.Click
      If dr.oo_PRM_CODES > 0 Then
         If MsgBox(Txt(878), vbYesNo, Txt(879)) = MsgBoxResult.Yes Then
            dr.oo_PRM_CODES = 0
            txtCode.Text = ""
            MsgDsp(Txt(880))
         End If
      Else
         MsgDsp(Txt(877))
      End If
   End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      Dim bv1 As Boolean
      If dr.oo_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If dr.oo_PRM_CODES > 0 Then
         If btnRemovePromo.Enabled <> True Then btnRemovePromo.Enabled = True
      Else
         If btnRemovePromo.Enabled <> False Then btnRemovePromo.Enabled = False
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
      If btnAdd.Enabled <> bv Then btnAdd.Enabled = bv
      If btnDeleteDetail.Enabled <> bv Then btnDeleteDetail.Enabled = bv
      If btnEdit.Enabled <> bv Then btnEdit.Enabled = bv
      If dr.oo_CUS_CUSTOMER = 0 Then
         bv1 = False
      Else
         bv1 = True
      End If
      If btnAddress.Enabled <> bv1 Then btnAddress.Enabled = bv1
   End Sub

   Private Sub lstDetails_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstDetails.ColumnClick
      Dim tCOL%, tI%, tJ%, tK%, tstr1$, tSORT%, tSW%, tTEST$, tAGAINST$, tSORTED%

      tCOL = e.Column
      If LISTSORT(tCOL) = 1 Then
         LISTSORT(tCOL) = 0
      Else
         LISTSORT(tCOL) = 1
      End If
      tSORT = LISTSORT(tCOL)

      If lstDetails.Items.Count < 2 Then Exit Sub

      tCNT = lstDetails.Items.Count - 1

      tSORTED = 0

      For tI = 0 To tCNT - 1
         For tJ = tI + 1 To tCNT
            Dim lstI As ListViewItem = lstDetails.Items(tI)
            Dim lstJ As ListViewItem = lstDetails.Items(tJ)
            tTEST = lstJ.SubItems(tCOL).Text
            tAGAINST = lstI.SubItems(tCOL).Text
            If Len(tTEST) >= 6 And Len(tAGAINST) >= 6 Then
               If IsDate(tTEST) = True And IsDate(tAGAINST) = True Then
                  tTEST = Format(CDate(tTEST), "yyyyMMddhhmmss")
                  tAGAINST = Format(CDate(tAGAINST), "yyyyMMddhhmmss")
               End If
            End If
            tSW = 0
            If tSORT = 0 Then
               If tTEST < tAGAINST Then tSW = 1
            Else
               If tTEST > tAGAINST Then tSW = 1
            End If
            If tSW = 1 Then
               tSORTED = 1
               tstr1 = lstI.Tag
               lstI.Tag = lstJ.Tag
               lstJ.Tag = tstr1
               If lstI.SubItems.Count >= 0 Then
                  For tK = 0 To lstI.SubItems.Count - 1
                     tstr1 = lstI.SubItems(tK).Text
                     lstI.SubItems(tK).Text = lstJ.SubItems(tK).Text
                     lstJ.SubItems(tK).Text = tstr1
                  Next
               End If
            End If
         Next
      Next
      If tSORTED = 1 Then lstDetails.Invalidate()
   End Sub

   Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
      'NEED TO ASK THE USER IF THEY WANT TO SEND OUT AN ORDER PROCESSING EMAIL WHEN ORDER IS SET TO PROCESSING
      If dr.oo_iid > 0 Then
         If CType(cmbStatus.SelectedItem, ComboClass).Value = 2 Then
            If dr.oo_iStatus <> 2 Then

            End If
            'asking if they want to send processing email
            'If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then

            'End If
         ElseIf CType(cmbStatus.SelectedItem, ComboClass).Value = 4 Then
            'asking if they want to send out email to get a review
            'If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then

            'End If
         ElseIf CType(cmbStatus.SelectedItem, ComboClass).Value = 5 Then
            'check if any of the details have been shipped or not
            If dr.oo_iStatus <> 5 Then
               'TestConnection()
               'dr.ocmd.CommandText = ""
               'dr.oread = dr.ocmd.ExecuteReader()
               'If dr.oread.HasRows = True Then

               'End If
            End If
         End If
      Else
         cmbStatus.SelectedIndex = 0
      End If
   End Sub
End Class