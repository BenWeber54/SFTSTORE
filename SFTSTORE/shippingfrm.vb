Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf
Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Web
Imports ArtifactPortTypeClient
Imports getartifactrequest
Imports getartifactresponse
Imports getartifactresponseArtifactdata
Imports System.Data

Imports System.ServiceModel.Channels
Imports System.ServiceModel
'Imports System.Configuration

Public Class shippingfrm
   Dim storedBoxesString$ = "", nextBoxStart& = 0, currentBox& = 0, shipNum& = 0
   Dim previousItems$ = ""
   Private Sub shippingfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(645)
      lblOrdNum.Text = Txt(760) + ":"
      lblShip.Text = Txt(760) + ":"
      lblNotes.Text = Txt(830) + ":"
      lblEmail.Text = Txt(364) + ":"

      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnMeasurement.Text = Txt(781)
      btnClose.Text = Txt(390)
      btnUnship.Text = Txt(768)
      btnShipDetails.Text = Txt(794)
      btnRefund.Text = Txt(809)
      Inits()
   End Sub
   Private Sub Inits()
      InitOrder(dr)
      InitOrderDetail(dr)
      InitCustomer(dr)
      InitCustomerAddress(dr)
      Display()
   End Sub
   Private Sub Display()
      Dim tSWT& = 0
      txtOrdNum.Text = dr.oo_iid
      If dr.oo_iid > 0 Then
         txtNotes.Text = dr.oo_szNotes
         TestConnection()
         dr.ocmd.CommandText = "SELECT cu_szEmail FROM ORD_ORDERS JOIN CUS_CUSTOMER ON oo_CUS_CUSTOMER = cu_iid WHERE oo_iid = " + CStr(dr.oo_iid)
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtEmail.Text = dr.oread("cu_szEmail")
         Else
            txtEmail.Text = ""
         End If
         dr.oread.Close()
         If dr.oo_CUS_ADDRESS = 0 Then
            TestConnection()
            dr.ocmd.CommandText = "SELECT COUNT(*) FROM CUS_ADDRESS ca_CUS_CUSTOMER = " + CStr(dr.oo_CUS_CUSTOMER)
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               If dr.oread(0) > 1 Then
                  btnShipAddr.Enabled = True
                  txtShipAddress.Text = ""
                  tSWT = 1
               Else
                  btnShipAddr.Enabled = False
                  tSWT = 2
               End If
            End If
            dr.oread.Close()
            If tSWT = 2 Then
               TestConnection()
               dr.ocmd.CommandText = "SELECT ca_iid FROM CUS_ADDRESS WHERE ca_CUS_CUSTOMER = " + CStr(dr.oo_CUS_CUSTOMER)
               dr.oread = dr.ocmd.ExecuteReader()
               If dr.oread.HasRows = True Then
                  dr.oread.Read()
                  dr.oo_CUS_ADDRESS = dr.oread("ca_iid")
               End If
               dr.oread.Close()
               If dr.oo_iid > 0 Then
                  UpdateOrderRecord(dr)
               End If
               populateAddress()
            End If
         Else
            btnShipAddr.Enabled = True
            populateAddress()
         End If
         loadLst()
      Else
         txtEmail.Text = ""
         txtNotes.Text = ""
         btnShipAddr.Enabled = False
         txtOrdNum.Text = ""
         txtShipAddress.Text = ""
         lst.Clear()
      End If
   End Sub
   Private Sub populateAddress()
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM CUS_ADDRESS JOIN CUS_CUSTOMER ON ca_CUS_CUSTOMER = cu_iid WHERE ca_iid = " + CStr(dr.oo_CUS_ADDRESS)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         txtShipAddress.Text = dr.oread("cu_szDisplay") + vbCrLf
         txtShipAddress.Text += dr.oread("ca_szAddr1") + vbCrLf
         'If dr.oread("ca_szAddr2") <> "" Then
         '   txtShipAddress.Text += dr.oread("ca_szAddr2") + vbCrLf
         'End If
         txtShipAddress.Text += dr.oread("ca_szCity") + " "
         If dr.oread("ca_iCountry") = 1 Then
            txtShipAddress.Text += Txt(119 + dr.oread("ca_iProvince"))
         ElseIf dr.oread("ca_iCountry") = 2 Then
            txtShipAddress.Text += Txt(219 + dr.oread("ca_iProvince"))
         End If
         txtShipAddress.Text += " " + dr.oread("ca_szPostal") + vbCrLf
      Else
         txtShipAddress.Text = ""
      End If
      dr.oread.Close()
   End Sub
   'Private Function Validation()
   '   Validation = 0
   '   'If dr.cu_szId = "" Then
   '   '   txtId.Focus()
   '   '   MsgDsp(Txt(582))
   '   '   Exit Function
   '   'End If
   '   Validation = 1
   'End Function
   'Private Sub ScreenToRecord()

   'End Sub
   Private Sub loadLst()
      Dim quantityShipped& = 0
      Dim shipNumbers$ = ""
      Dim ocn2 As New OleDb.OleDbConnection(dr.szConnection)
      Dim ocmd2 As New OleDb.OleDbCommand("", ocn2)
      Dim oread2 As OleDb.OleDbDataReader
      lst.Clear()
      lst.View = View.Details
      lst.Columns.Add(Txt(643), 120, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(660), lst.Width - 575, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(611), 150, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(815), 150, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(796), 150, HorizontalAlignment.Left)
      'lst.Columns.Add(Txt(736), 150, HorizontalAlignment.Left)
      dr.ocmd.CommandText = "SELECT * FROM ORD_DETAIL JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
      dr.ocmd.CommandText += " WHERE od_ORD_ORDERS > 0 And od_ORD_ORDERS = " + CStr(dr.oo_iid)
      dr.ocmd.CommandText += " AND (od_iStatus = 1 OR od_iStatus = 2 OR od_iStatus = 5)"
      dr.ocmd.CommandText += " ORDER BY od_iLineNumber"
      dr.oread = dr.ocmd.ExecuteReader
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read
            quantityShipped = 0
            shipNumbers = ""
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("od_iLineNumber")))
            ListItem1.Tag = CStr(dr.oread("od_iid"))
            ListItem1.SubItems.Add(dr.oread("pp_szProductName"))
            ListItem1.SubItems.Add(dr.oread("od_iQuantity"))

            ocn2.Open()
            ocmd2.CommandText = "SELECT * FROM ORD_TRACKING_DETAIL JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
            ocmd2.CommandText += " WHERE oa_ORD_DETAIL = " + CStr(dr.oread("od_iid"))
            ocmd2.CommandText += " AND ot_iReturned = 0"
            ocmd2.CommandText += " ORDER BY ot_iShipNum"
            oread2 = ocmd2.ExecuteReader()
            If oread2.HasRows = True Then
               Do While oread2.Read()
                  quantityShipped += 1
                  If shipNumbers.Contains(CStr(oread2("ot_iShipNum"))) = False Then
                     shipNumbers += CStr(oread2("ot_iShipNum")) + ", "
                  End If
               Loop
            End If
            oread2.Close()
            ocn2.Close()
            ListItem1.SubItems.Add(quantityShipped)
            If shipNumbers.Length > 1 Then
               shipNumbers = shipNumbers.Substring(0, shipNumbers.Length - 2)
            End If
            If shipNumbers.Length > 0 Then
               ListItem1.SubItems.Add(shipNumbers)
               'ListItem1.SubItems.Add(Format(dr.oread("od_dShipped"), "dd/MMM/yyyy"))
            Else
               ListItem1.SubItems.Add("")
            End If
            lst.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 24
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
   Private Sub btnShip1_Click(sender As Object, e As EventArgs) Handles btnMeasurement.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            GetOrderDetailRecord(tl1, dr)
            If detailShipped(dr.od_iid) = True Then
               Dim frm As shipmeasurementsfrm
               frm = New shipmeasurementsfrm
               frm.ShowDialog()
            Else
               MsgDsp(Txt(743))
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(742))
      End If
   End Sub
   Private Sub btnShipAddr_Click(sender As Object, e As EventArgs) Handles btnShipAddr.Click
      If dr.oo_iid > 0 Then
         dr.LIST_CTRL = 25
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            UpdateOrderRecord(dr)
            Display()
         End If
      Else
         MsgDsp(Txt(642))
      End If
   End Sub
   Private Sub btnShip_Click(sender As Object, e As EventArgs)

      Dim tl1& = 0, tl2& = 0

      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl2 = 1
            tl1 = CLng(GetFloat(itm.Tag))
            GetOrderDetailRecord(tl1, dr)
            If detailShipped(dr.od_iid) = True Then
               tl2 = 1
               Dim frm As shipmeasurementsfrm
               frm = New shipmeasurementsfrm
               frm.ShowDialog()
               Display()
               Exit Sub
            Else
               MsgDsp(Txt(743))
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnUnship_Click(sender As Object, e As EventArgs) Handles btnUnship.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            GetOrderDetailRecord(tl1, dr)
            If detailShippedWithReturn(dr.od_iid) = False Then
               dr.FRMSWT = 3
               Dim frm As shipnumselectfrm
               frm = New shipnumselectfrm
               frm.ShowDialog()
               Display()
               Exit Sub
            Else
               MsgDsp(Txt(805))
               Exit Sub
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnShip_Click_1(sender As Object, e As EventArgs) Handles btnShip.Click
      Dim orderShipped& = 0
      Cursor = Cursors.WaitCursor
      btnShip.Enabled = False
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            orderShipped = 0
            GetOrderDetailRecord(CLng(GetFloat(itm.Tag)), dr)
            TestConnection()
            dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid) + " AND ot_iReturned = 0"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read()
                  orderShipped += 1
               Loop
            End If
            dr.oread.Close()
            If orderShipped >= dr.od_iQuantity Then
               MsgDsp(Txt(791))
               Cursor = Cursors.Arrow
               Exit Sub
            End If
         End If
      Next
      Dim tl1& = 0, tl2& = 0, start& = 0, checkFirstRect& = 0, start1& = 0, checkNextBox& = 0, newContainer& = 0, baseShipNum& = 0
      Dim containerHeight@ = 0, containerWeight@ = 0
      Dim demensionsString$ = "", boxesString$ = "", savedItems$ = "", previousBoxString$ = "", finalBoxString$ = ""
      Dim packagedOrSoloString$ = ""
      Dim demensionsArray$(), boxesArray$(), returnedRectangles$(), savedItemsArray$(), finalBoxArray$(), soloPacked$()
      storedBoxesString = ""
      previousItems = ""
      nextBoxStart = 1
      currentBox = 0
      shipNum = 0

      Dim quantityUsed& = 0, quantity& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            quantity = 0
            tl2 = 1
            tl1 = CLng(GetFloat(itm.Tag))
            GetOrderDetailRecord(tl1, dr)
            GetProductRecord(dr.od_PRO_PRODUCT, dr)
            GetOrderRecord(dr.od_ORD_ORDERS, dr)
            'NEED TO GET THE CURRENT SHIPPING NUMBER FOR THE ORDER
            TestConnection()
            dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING_DETAIL"
            dr.ocmd.CommandText += " JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
            dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
            dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
            dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND ot_iReturned = 0"
            dr.ocmd.CommandText += " ORDER BY ot_iShipNum Desc"
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               shipNum = dr.oread("ot_iShipNum") + 1
            Else
               shipNum = 1
            End If
            dr.oread.Close()
            baseShipNum = shipNum

            TestConnection()
            dr.ocmd.CommandText = "SELECT ot_iid FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE ot_iReturned = 0 AND oa_ORD_DETAIL = " + CStr(dr.od_iid)
            dr.oread = dr.ocmd.ExecuteReader
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read()
                  quantityUsed += 1
               Loop
            End If
            dr.oread.Close()
            quantity = dr.od_iQuantity - quantityUsed
            For tl5 = 1 To quantity
               If dr.od_iPackaged <> 2 And dr.pp_iPackedSolo <> 2 Then
                  demensionsString += CStr(dr.od_iid) + "|"
                  demensionsString += CStr(dr.od_rWeight) + "|"
                  demensionsString += CStr(dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr(dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr(dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr((dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100)))) + "|"
               ElseIf dr.od_iPackaged = 2 Or dr.pp_iPackedSolo = 2 Then
                  packagedOrSoloString += CStr(dr.od_iid) + "|"
                  If dr.od_iPackaged = 2 Then
                     packagedOrSoloString += "0" + "|"
                  ElseIf dr.pp_iPackedSolo = 2 Then
                     packagedOrSoloString += CStr(dr.pp_COM_BOXES) + "|"
                  End If
                  packagedOrSoloString += "" + "|"
                  packagedOrSoloString += "" + "|"
                  packagedOrSoloString += "" + "|"
                  packagedOrSoloString += "" + "|"
                  packagedOrSoloString += "" + "|"
                  packagedOrSoloString += "" + "|"
               End If
            Next
         End If
      Next

      If tl2 = 0 Then
         MsgDsp(Txt(558))
      Else
         demensionsArray = Split(demensionsString, "|")

         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM COM_BOXES WHERE cx_COM_COMPANY = " + CStr(dr.sr_iCompany) + " ORDER BY cx_rMaxWeight Desc"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            Do While dr.oread.Read()
               boxesString += CStr(dr.oread("cx_iid")) + "|"
               boxesString += CStr(dr.oread("cx_rMaxWeight")) + "|"
               boxesString += CStr(dr.oread("cx_rLength")) + "|"
               boxesString += CStr(dr.oread("cx_rWidth")) + "|"
               boxesString += CStr(dr.oread("cx_rHeight")) + "|"
               boxesString += CStr(dr.oread("cx_rLength") * dr.oread("cx_rWidth") * dr.oread("cx_rHeight")) + "|"
            Loop
         Else
            MsgDsp(Txt(777))
            dr.oread.Close()
            Cursor = Cursors.Arrow
            Exit Sub
         End If
         dr.oread.Close()
         Dim tstr1$ = ""
         'sorting items list
         If UBound(demensionsArray) > 7 Then
            For tl5 = 0 To UBound(demensionsArray) - 7 Step 6
               For tl6 = tl5 + 6 To UBound(demensionsArray) - 1 Step 6
                  If GetFloat(demensionsArray(tl6 + 5)) >= GetFloat(demensionsArray(tl5 + 5)) Then
                     If GetFloat(demensionsArray(tl6 + 5)) = GetFloat(demensionsArray(tl5 + 5)) Then
                        If GetFloat(demensionsArray(tl6 + 4)) < GetFloat(demensionsArray(tl5 + 4)) Then
                           For tl7 = 0 To 5
                              tstr1 = demensionsArray(tl6 + tl7)
                              demensionsArray(tl6 + tl7) = demensionsArray(tl5 + tl7)
                              demensionsArray(tl5 + tl7) = tstr1
                           Next
                        End If
                     Else
                        For tl7 = 0 To 5
                           tstr1 = demensionsArray(tl6 + tl7)
                           demensionsArray(tl6 + tl7) = demensionsArray(tl5 + tl7)
                           demensionsArray(tl5 + tl7) = tstr1
                        Next
                     End If
                  End If
               Next
            Next
         End If

         boxesArray = Split(boxesString, "|")
         tstr1 = ""
         'sorting boxes list
         If UBound(boxesArray) > 7 Then
            For tl5 = 0 To UBound(boxesArray) - 7 Step 6
               For tl6 = tl5 + 6 To UBound(boxesArray) - 1 Step 6
                  If GetFloat(boxesArray(tl6 + 5)) >= GetFloat(boxesArray(tl5 + 5)) Then
                     If GetFloat(boxesArray(tl6 + 5)) = GetFloat(boxesArray(tl5 + 5)) Then
                        If GetFloat(boxesArray(tl6 + 4)) < GetFloat(boxesArray(tl5 + 4)) Then
                           For tl7 = 0 To 5
                              tstr1 = boxesArray(tl6 + tl7)
                              boxesArray(tl6 + tl7) = boxesArray(tl5 + tl7)
                              boxesArray(tl5 + tl7) = tstr1
                           Next
                        End If
                     Else
                        For tl7 = 0 To 5
                           tstr1 = boxesArray(tl6 + tl7)
                           boxesArray(tl6 + tl7) = boxesArray(tl5 + tl7)
                           boxesArray(tl5 + tl7) = tstr1
                        Next
                     End If
                  End If
               Next
            Next
         End If

         tstr1 = ""
         demensionsString = ""
         finalBoxString = ""
         If UBound(demensionsArray) > 2 Then
            For tl5 = 0 To UBound(boxesArray) - 1 Step 6
               currentBox = boxesArray(tl5)
               containerHeight = GetFloat(boxesArray(tl5 + 4))
               containerWeight = GetFloat(boxesArray(tl5 + 1))
               start1 = 0
               start = 0
               If checkNextBox = 1 And shipNum = baseShipNum Then
                  'this means all the items fit in the first box, we are now reducing box size and seeing if the items fit
                  demensionsArray = getItemsArray()
               ElseIf checkNextBox = 1 And shipNum > baseShipNum Then
                  'need to get the previous set of items left to fit into a box
                  If previousItems.Length > 0 Then
                     demensionsArray = Split(previousItems, "|")
                     previousItems = ""
                  End If
               End If
               For tl6 = 0 To UBound(demensionsArray) - 1 Step 6
                  If start = 0 Then
                     'inserts the items that were greater in height then the first item on the next run through
                     If savedItems.Length > 1 Then
                        demensionsString = ""
                        savedItemsArray = Split(savedItems, "|")
                        For tl7 = 0 To UBound(savedItemsArray) - 1
                           demensionsString += savedItemsArray(tl7) + "|"
                        Next
                        For tl7 = 0 To UBound(demensionsArray) - 1
                           demensionsString += demensionsArray(tl7) + "|"
                        Next
                        demensionsArray = Split(demensionsString, "|")
                        savedItems = ""
                     End If

                     'checks to see if the item will fit in the box
                     If (containerHeight - GetFloat(demensionsArray(tl6 + 4))) < 0 Or GetFloat(boxesArray(tl5 + 2)) < GetFloat(demensionsArray(tl6 + 2)) Or GetFloat(boxesArray(tl5 + 3)) < GetFloat(demensionsArray(tl6 + 3)) Or (containerWeight - GetFloat(demensionsArray(tl6 + 1))) < 0 Then
                        'if item deosnt fit, checks to see if its on the next level of the container or not
                        'if on second level this will iterate through the items to see if any will fit
                        If start1 = 1 And tl6 <> UBound(demensionsArray) - 6 Then
                           Continue For
                        Else
                           'if this is hit that means its on the last item and none fit
                           If checkNextBox = 1 Then
                              finalBoxString += previousBoxString
                              tl5 = UBound(boxesArray) - 1
                              Exit For
                           End If
                           If start1 = 1 Then
                              'this will open a new container to fit the remaining items into
                              newContainer = 1
                              shipNum += 1
                              tl5 = -6
                              finalBoxString += storedBoxesString
                              storedBoxesString = ""
                              previousItems = ""
                              Exit For
                           Else
                              'this means the first item wont fit in the largest box
                              If tl5 = 0 Then
                                 MsgBox("custom order")
                                 Cursor = Cursors.Arrow
                                 Exit Sub
                              End If
                           End If
                        End If
                     Else
                        'removes height and weight of current item
                        containerHeight -= GetFloat(demensionsArray(tl6 + 4))
                        containerWeight -= GetFloat(demensionsArray(tl6 + 1))
                        'gets the two rectangles left over
                        returnedRectangles = getRectangles(boxesArray(tl5 + 2), boxesArray(tl5 + 3), demensionsArray(tl6 + 2), demensionsArray(tl6 + 3), demensionsArray(tl6 + 4))
                        tstr1 = ""

                        'stores box in stored array that is placed
                        storedBoxesString += demensionsArray(tl6) + "|"
                        storedBoxesString += boxesArray(tl5) + "|"
                        storedBoxesString += CStr(shipNum) + "|"
                        storedBoxesString += "" + "|"
                        storedBoxesString += "" + "|"
                        storedBoxesString += "" + "|"
                        storedBoxesString += "" + "|"
                        storedBoxesString += "" + "|"

                        For tl7 = tl6 To tl6 + 5
                           previousItems += demensionsArray(tl7) + "|"
                        Next
                        'checks to see which items have a height less than the placed box
                        demensionsString = ""
                        For tl7 = 0 To UBound(demensionsArray) - 1 Step 6
                           If tl7 <> tl6 Then
                              For tl8 = tl7 To tl7 + 5
                                 If GetFloat(demensionsArray(tl7 + 4)) <= GetFloat(demensionsArray(tl6 + 4)) Then
                                    demensionsString += demensionsArray(tl8) + "|"
                                 Else
                                    savedItems += demensionsArray(tl8) + "|"
                                 End If
                              Next
                           End If
                        Next

                        demensionsArray = Split(demensionsString, "|")

                        If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                           tl6 = -6
                        Else
                           'everything fits now check next box
                           previousBoxString = storedBoxesString
                           storedBoxesString = ""
                           checkNextBox = 1
                           Exit For
                        End If
                     End If
                     start = 1
                  Else
                     'checking to see if new boxes fit inside of rectangles
                     If checkFirstRect = 0 Then
                        For tl8 = 0 To UBound(returnedRectangles) - 4 Step 3
                           'checking both sides of new box to fit in space
                           'this one checks to see if the length will fit
                           If tl6 = UBound(demensionsArray) Then
                              checkFirstRect = 1
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 = -6
                              End If
                              Exit For
                           End If
                           If GetFloat(demensionsArray(tl6 + 2)) <= GetFloat(returnedRectangles(tl8)) And GetFloat(demensionsArray(tl6 + 3)) <= GetFloat(returnedRectangles(tl8 + 1)) And GetFloat(demensionsArray(tl6 + 1)) <= containerWeight Then
                              'remove size from container and remove item from the list
                              returnedRectangles(tl8 + 1) = CStr(GetFloat(returnedRectangles(tl8 + 1)) - GetFloat(demensionsArray(tl6 + 3)))
                              demensionsArray = removeItem(demensionsArray, tl6)
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 -= 6
                              Else
                                 'tl6 = UBound(demensionsArray)
                              End If
                              Exit For
                           ElseIf GetFloat(demensionsArray(tl6 + 2)) <= GetFloat(returnedRectangles(tl8 + 1)) And GetFloat(demensionsArray(tl6 + 3)) <= GetFloat(returnedRectangles(tl8)) And GetFloat(demensionsArray(tl6 + 1)) <= containerWeight Then
                              returnedRectangles(tl8 + 1) = CStr(GetFloat(returnedRectangles(tl8 + 1)) - GetFloat(demensionsArray(tl6 + 3)))
                              demensionsArray = removeItem(demensionsArray, tl6)
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 -= 6
                              End If
                              Exit For
                           End If
                        Next
                     Else
                        For tl8 = 3 To UBound(returnedRectangles) - 1 Step 3
                           'checking both sides of new box to fit in space
                           'this one checks to see if the length will fit
                           If tl6 = UBound(demensionsArray) Then
                              checkFirstRect = 0
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 = -6
                                 start = 0
                              End If
                              Exit For
                           End If
                           If GetFloat(demensionsArray(tl6 + 3)) <= GetFloat(returnedRectangles(tl8)) And GetFloat(demensionsArray(tl6 + 2)) <= GetFloat(returnedRectangles(tl8 + 1)) And GetFloat(demensionsArray(tl6 + 1)) <= containerWeight Then
                              'remove size from container and remove item from the list
                              returnedRectangles(tl8) = CStr(GetFloat(returnedRectangles(tl8)) - GetFloat(demensionsArray(tl6 + 3)))
                              demensionsArray = removeItem(demensionsArray, tl6)
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 -= 6
                              End If
                              Exit For
                           ElseIf GetFloat(demensionsArray(tl6 + 3)) <= GetFloat(returnedRectangles(tl8 + 1)) And GetFloat(demensionsArray(tl6 + 2)) <= GetFloat(returnedRectangles(tl8)) And GetFloat(demensionsArray(tl6 + 1)) <= containerWeight Then
                              returnedRectangles(tl8) = CStr(GetFloat(returnedRectangles(tl8)) - GetFloat(demensionsArray(tl6 + 2)))
                              demensionsArray = removeItem(demensionsArray, tl6)
                              If UBound(demensionsArray) > 2 Or savedItems.Length > 0 Then
                                 tl6 -= 6
                              End If
                              Exit For
                           End If
                        Next
                     End If
                  End If
                  start1 = 1
                  If UBound(demensionsArray) < 2 And savedItems.Length = 0 Then
                     previousBoxString = storedBoxesString
                     storedBoxesString = ""
                     checkNextBox = 1
                     Exit For
                  End If
               Next
            Next
         End If
      End If
      If packagedOrSoloString.Length > 0 Then
         soloPacked = Split(packagedOrSoloString, "|")
         For tl1 = 0 To UBound(soloPacked) - 1 Step 8
            If shipNum <> baseShipNum Or finalBoxString.Length > 0 Then
               shipNum += 1
            End If
            soloPacked(tl1 + 2) = CStr(shipNum)
         Next
         For tl1 = 0 To UBound(soloPacked) - 1
            finalBoxString += soloPacked(tl1) + "|"
         Next
      End If
      btnShip.Enabled = True
      If finalBoxString.Length > 1 Then
         finalBoxArray = Split(finalBoxString, "|")
         dr.SHIPPING_ARRAY = finalBoxArray
         Cursor = Cursors.Arrow
         Dim frm As shipmentinfofrm
         frm = New shipmentinfofrm
         frm.ShowDialog()
         Display()
      End If
      Cursor = Cursors.Arrow
   End Sub
   Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
      Cursor = Cursors.WaitCursor
      Dim testShipNumCount& = 0, testShipNum& = 0
      dr.shipNumber = 1
      Dim tl1& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetOrderDetailRecord(tl1, dr)
            testShipNumCount = 0
            testShipNum = 0
            If dr.od_iQuantity > 0 Then
               TestConnection()
               dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid) + " AND ot_iReturned = 0 ORDER BY ot_iShipNum Desc"
               dr.oread = dr.ocmd.ExecuteReader()
               If dr.oread.HasRows = True Then
                  Do While dr.oread.Read()
                     If dr.oread("ot_iShipNum") <> testShipNum Then
                        testShipNum = dr.oread("ot_iShipNum")
                        testShipNumCount += 1
                     End If
                  Loop
               End If
               dr.oread.Close()
               Exit For
            End If
            Exit For
         End If
      Next
      If testShipNumCount > 1 Then
         dr.shipNumber = 0
         dr.FRMSWT = 1
         dr.oread.Close()
         Dim frm As shipnumselectfrm
         frm = New shipnumselectfrm
         frm.ShowDialog()
      Else
         dr.shipNumber = testShipNum
      End If
      If dr.shipNumber = 0 Then
         Cursor = Cursors.Arrow
         Exit Sub
      End If

      Dim server = New ArtifactPortTypeClient("ArtifactPort", "https://ct.soa-gw.canadapost.ca/rs/soap/artifact")
      server.ClientCredentials.UserName.UserName = dr.MAILUSER
      server.ClientCredentials.UserName.Password = dr.MAILPASSWORD

      'Create Request
      Dim request = New getartifactrequest()
      If dr.sr_iLanguage = ENGLISH Then
         request.locale = "EN"
      Else
         request.locale = "FR"
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid) + " AND ot_iShipNum = " + CStr(dr.shipNumber)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         request.artifactid = dr.oread("ot_szArtifact")
      Else
         Cursor = Cursors.Arrow
         dr.oread.Close()
         Exit Sub
      End If
      dr.oread.Close()


      'Disable timestamp on request
      Dim elements = server.Endpoint.Binding.CreateBindingElements()
      elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
      server.Endpoint.Binding = New CustomBinding(elements)

      Dim responseAsString$ = ""

      Try
         'Execute Request
         Dim response = server.GetArtifact(request)

         'Retrieve values from response object
         If response.Item.GetType() = GetType(getartifactresponseArtifactdata) Then
            Dim artifact As getartifactresponseArtifactdata
            artifact = response.Item
            Dim fileName$ = "shipLabel " + Format(Now, "MMM-dd-yyyy-hh-mm-ss-fff-tt") + ".PDF"
            Dim encodedImage As Byte()
            encodedImage = Convert.FromBase64String(artifact.image)

            If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
               MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
            End If
            dr.full_filename = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(fileName)
            If File.Exists(dr.full_filename) Then
               Try
                  Kill(dr.full_filename)
               Catch ex As Exception
               End Try
            End If
            Dim wrt As FileStream = File.OpenWrite(dr.full_filename)
            wrt.Write(encodedImage, 0, UBound(encodedImage) + 1)
            wrt.Close()
            System.Diagnostics.Process.Start(dr.full_filename)
         Else
            Dim msgs As artifactMessages
            msgs = response.Item
            For Each tl5 In msgs.message
               responseAsString += "Error Code: " + tl5.code
               responseAsString += "Error Msg: " + tl5.description
            Next
         End If
      Catch faultEx As FaultException
         'SOAP Fault
         responseAsString += "Fault Code: " + faultEx.Code.Name
         responseAsString += "Fault String: " + faultEx.Message
      Catch ex As Exception
         'Misc Exception
         responseAsString += "ERROR: " + ex.Message
      End Try
      If responseAsString <> "" Then
         MsgDsp(Txt(816))
      End If
      Cursor = Cursors.Arrow
   End Sub
   Private Sub btnShipDetails_Click(sender As Object, e As EventArgs) Handles btnShipDetails.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            GetOrderDetailRecord(tl1, dr)
            If detailShipped(dr.od_iid) = False Then
               dr.FRMSWT = 2
               Dim frm As shipnumselectfrm
               frm = New shipnumselectfrm
               frm.ShowDialog()
               Exit Sub
            Else
               MsgDsp(Txt(795))
            End If
            Exit Sub
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            GetOrderDetailRecord(tl1, dr)
            If detailShipped(dr.od_iid) = False Then
               dr.FRMSWT = 4
               Dim frm As shipnumselectfrm
               frm = New shipnumselectfrm
               frm.ShowDialog()
               Display()
               Exit Sub
            Else
               MsgDsp(Txt(808))
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.oo_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnMeasurement.Enabled <> bv Then btnMeasurement.Enabled = bv
      If btnUnship.Enabled <> bv Then btnUnship.Enabled = bv
      If btnShip.Enabled <> bv Then btnShip.Enabled = bv
      If btnRefund.Enabled <> bv Then btnRefund.Enabled = bv
      If btnPrint.Enabled <> bv Then btnPrint.Enabled = bv
      If btnShipDetails.Enabled <> bv Then btnShipDetails.Enabled = bv
   End Sub
   Private Function getRectangles(containerLength As Decimal, containerWidth As Decimal, itemLength As Decimal, itemWidth As Decimal, itemHeight As Decimal) As Array
      Dim returnRectangles$()
      Dim tstr1$ = ""
      If containerWidth - itemLength < 0 Then
         tstr1 += CStr(itemWidth) + "|"
         tstr1 += CStr(containerLength - itemLength) + "|"
         tstr1 += CStr(itemHeight) + "|"
         tstr1 += CStr(containerLength) + "|"
         tstr1 += CStr(containerWidth - itemWidth) + "|"
         tstr1 += CStr(itemHeight) + "|"
      Else
         tstr1 += CStr(itemWidth) + "|"
         tstr1 += CStr(containerWidth - itemLength) + "|"
         tstr1 += CStr(itemHeight) + "|"
         tstr1 += CStr(containerWidth) + "|"
         tstr1 += CStr(containerLength - itemWidth) + "|"
         tstr1 += CStr(itemHeight) + "|"
      End If
      
      returnRectangles = Split(tstr1, "|")
      Return returnRectangles
   End Function
   Private Function removeItem(array As Array, index As Long) As Array
      Dim arrayString$ = ""
      'removing the box that was just placed into the container
      For tl1 = 0 To UBound(array) - 1
         If tl1 < index Or tl1 > index + 5 Then
            arrayString += array(tl1) + "|"
         Else
            previousItems += array(tl1) + "|"
         End If
      Next
      storedBoxesString += array(index) + "|"
      storedBoxesString += CStr(currentBox) + "|"
      storedBoxesString += CStr(shipNum) + "|"
      storedBoxesString += "" + "|"
      storedBoxesString += "" + "|"
      storedBoxesString += "" + "|"
      storedBoxesString += "" + "|"
      storedBoxesString += "" + "|"

      array = Split(arrayString, "|")
      Return array
   End Function
   Private Function getItemsArray() As Array
      Dim demensionsString$ = "", tstr1$ = ""
      Dim tl2& = 0, tl1& = 0
      Dim demensionsArray$()

      'For Each itm As ListViewItem In lst.SelectedItems
      '   If itm.Selected = True Then
      '      tl2 = 1
      '      tl1 = CLng(GetFloat(itm.Tag))
      '      GetOrderDetailRecord(tl1, dr)
      '      For tl5 = 1 To dr.od_iQuantity
      '         If dr.od_iPackaged <> 1 Then
      '            demensionsString += CStr(dr.od_iid) + "|"
      '            demensionsString += CStr(dr.od_rWeight) + "|"
      '            demensionsString += CStr(dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
      '            demensionsString += CStr(dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
      '            demensionsString += CStr(dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
      '            demensionsString += CStr((dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100)))) + "|"
      '         End If
      '      Next
      '   End If
      'Next

      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl2 = 1
            tl1 = CLng(GetFloat(itm.Tag))
            GetOrderDetailRecord(tl1, dr)
            GetProductRecord(dr.od_PRO_PRODUCT, dr)
            For tl5 = 1 To dr.od_iQuantity
               If dr.od_iPackaged <> 2 And dr.pp_iPackedSolo <> 2 Then
                  demensionsString += CStr(dr.od_iid) + "|"
                  demensionsString += CStr(dr.od_rWeight) + "|"
                  demensionsString += CStr(dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr(dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr(dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) + "|"
                  demensionsString += CStr((dr.od_rHeight * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rWidth * (1 + ((dr.od_iPackMaterial * 2) / 100))) * (dr.od_rLength * (1 + ((dr.od_iPackMaterial * 2) / 100)))) + "|"
               End If
            Next
         End If
      Next

      demensionsArray = Split(demensionsString, "|")

      If UBound(demensionsArray) > 7 Then
         For tl5 = 0 To UBound(demensionsArray) - 7 Step 6
            For tl6 = tl5 + 6 To UBound(demensionsArray) - 1 Step 6
               If GetFloat(demensionsArray(tl6 + 5)) >= GetFloat(demensionsArray(tl5 + 5)) Then
                  If GetFloat(demensionsArray(tl6 + 5)) = GetFloat(demensionsArray(tl5 + 5)) Then
                     If GetFloat(demensionsArray(tl6 + 4)) < GetFloat(demensionsArray(tl5 + 4)) Then
                        For tl7 = 0 To 5
                           tstr1 = demensionsArray(tl6 + tl7)
                           demensionsArray(tl6 + tl7) = demensionsArray(tl5 + tl7)
                           demensionsArray(tl5 + tl7) = tstr1
                        Next
                     End If
                  Else
                     For tl7 = 0 To 5
                        tstr1 = demensionsArray(tl6 + tl7)
                        demensionsArray(tl6 + tl7) = demensionsArray(tl5 + tl7)
                        demensionsArray(tl5 + tl7) = tstr1
                     Next
                  End If
               End If
            Next
         Next
      End If
      Return demensionsArray
   End Function
End Class