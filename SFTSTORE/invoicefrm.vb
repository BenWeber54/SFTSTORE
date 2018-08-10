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

Public Class invoicefrm
   Dim storedBoxesString$ = "", nextBoxStart& = 0, currentBox& = 0, shipNum& = 0
   Dim previousItems$ = ""
   Private Sub invoicefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(845)
      lblOrdNum.Text = Txt(760) + ":"
      lblEmail.Text = Txt(846) + ":"
      lblDate.Text = Txt(847) + ":"
      lblNotes.Text = Txt(830) + ":"
      lblDetails.Text = Txt(849) + ":"
      lblToBe.Text = Txt(850) + ":"
      lblInvoiced.Text = Txt(851) + ":"
      lblInvNotes.Text = Txt(848) + ":"

      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnClose.Text = Txt(390)
      btnMove.Text = Txt(852)
      btnEditDetail.Text = Txt(853)
      btnInvoice.Text = Txt(854)
      chkTaxFree.Text = Txt(836)
      btnPrint.Text = Txt(855)
      btnView.Text = Txt(615)
      btnEmail.Text = Txt(364)
      btnDelete.Text = Txt(383)
      btnClose2.Text = Txt(390)
      tb.TabPages(0).Text = Txt(856)
      tb.TabPages(1).Text = Txt(844)
      Inits()
   End Sub
   Private Sub Inits()
      InitOrder(dr)
      InitInvoice(dr)
      InitInvoiceShipping(dr)
      Display()
   End Sub
   Private Sub Display()
      txtOrdNum.Text = dr.oo_iid
      txtNotes.Text = dr.oo_szNotes
      txtInvNotes.Text = ""
      dpInvoiceDate.Value = Now
      If dr.oo_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT cu_szEmail FROM ORD_ORDERS "
         dr.ocmd.CommandText += " JOIN CUS_CUSTOMER ON oo_CUS_CUSTOMER = cu_iid "
         dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid)
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtEmail.Text = dr.oread("cu_szEmail")
         Else
            txtEmail.Text = ""
         End If
         dr.oread.Close()

         populateCodeText()
      Else
         txtCode.Text = ""
         txtEmail.Text = ""
      End If
      populateDetails()
      populateToBe()
      populateInvoices()
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
   Private Sub populateDetails()
      Dim total@ = 0, calculate@ = 0
      lstDetails.Clear()
      lstDetails.View = View.Details
      lstDetails.Columns.Add(Txt(643), 120, HorizontalAlignment.Left)
      lstDetails.Columns.Add(Txt(660), lstDetails.Width - 725, HorizontalAlignment.Left)
      lstDetails.Columns.Add(Txt(783), 150, HorizontalAlignment.Center)
      lstDetails.Columns.Add(Txt(611), 150, HorizontalAlignment.Center)
      lstDetails.Columns.Add(Txt(831), 150, HorizontalAlignment.Left)
      lstDetails.Columns.Add(Txt(832), 150, HorizontalAlignment.Left)

      TestConnection()
      dr.ocmd.CommandText = "SELECT od_iLineNumber, pp_szProductName, ot_iShipNum, Count(oa_ORD_DETAIL), ot_iid, oa_rPrice, oa_rTypeDiscount FROM ORD_DETAIL "
      dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
      dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
      dr.ocmd.CommandText += " JOIN ORD_TRACKING_DETAIL ON oa_ORD_DETAIL = od_iid"
      dr.ocmd.CommandText += " JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
      dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid) + " AND ot_iReturned = 0 AND ot_iInvoiced = 0 AND ot_iReturnRequested = 0"
      dr.ocmd.CommandText += " GROUP BY od_iLineNumber, pp_szProductName, ot_iShipNum, oa_ORD_DETAIL, oa_rPrice, oa_rTypeDiscount, ot_iid"
      dr.ocmd.CommandText += " ORDER BY od_iLineNumber"
      dr.oread = dr.ocmd.ExecuteReader
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read
            calculate = 0
            total = 0
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("od_iLineNumber")))
            ListItem1.Tag = CStr(dr.oread("ot_iid")) + "|" + CStr(dr.oread("od_iLineNumber"))
            ListItem1.SubItems.Add(dr.oread("pp_szProductName"))
            ListItem1.SubItems.Add(dr.oread("ot_iShipNum"))
            ListItem1.SubItems.Add(dr.oread(3))
            If dr.oread("oa_rTypeDiscount") > 0 Then
               calculate = (dr.oread("oa_rTypeDiscount") / 100) * dr.oread("oa_rPrice")
               total = (dr.oread("oa_rPrice") * dr.oread(3)) - (calculate * dr.oread(3))
               ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("oa_rPrice") - calculate))
               ListItem1.SubItems.Add(StringFormatCurrency(2, total))
            Else
               total = dr.oread("oa_rPrice") * dr.oread(3)
               ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("oa_rPrice")))
               ListItem1.SubItems.Add(StringFormatCurrency(2, total))
            End If
            lstDetails.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
   Private Sub populateToBe()
      lstToBe.Clear()
      lstToBe.View = View.Details
      lstToBe.Columns.Add(Txt(643), 120, HorizontalAlignment.Left)
      lstToBe.Columns.Add(Txt(660), lstToBe.Width - 725, HorizontalAlignment.Left)
      lstToBe.Columns.Add(Txt(783), 150, HorizontalAlignment.Center)
      lstToBe.Columns.Add(Txt(611), 150, HorizontalAlignment.Center)
      lstToBe.Columns.Add(Txt(831), 150, HorizontalAlignment.Left)
      lstToBe.Columns.Add(Txt(832), 150, HorizontalAlignment.Left)
   End Sub
   Private Sub populateInvoices()
      lstInvoiced.Clear()
      lstInvoiced.View = View.Details
      lstInvoiced.Columns.Add(Txt(841), 160, HorizontalAlignment.Left)
      lstInvoiced.Columns.Add(Txt(842), lstInvoiced.Width - 790, HorizontalAlignment.Right)
      lstInvoiced.Columns.Add(Txt(843), 150, HorizontalAlignment.Right)
      lstInvoiced.Columns.Add(Txt(767), 175, HorizontalAlignment.Right)
      lstInvoiced.Columns.Add(Txt(844), 150, HorizontalAlignment.Center)
      lstInvoiced.Columns.Add(Txt(847), 150, HorizontalAlignment.Center)

      TestConnection()
      dr.ocmd.CommandText = " SELECT * FROM INV_INVOICE"
      dr.ocmd.CommandText += " WHERE iv_ORD_ORDERS = " + CStr(dr.oo_iid)
      dr.ocmd.CommandText += " ORDER BY iv_iInvNum"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("iv_iInvNum")))
            ListItem1.Tag = CStr(dr.oread("iv_iid"))
            ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("iv_rInvoiceTotal")))
            ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("iv_rTaxAmount")))
            ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("iv_rShipping")))
            If dr.oread("iv_iInvoiced") = 1 Then
               ListItem1.SubItems.Add("YES")
            Else
               ListItem1.SubItems.Add("NO")
            End If
            ListItem1.SubItems.Add(Format(dr.oread("iv_dInvoiceDate"), "dd/MMMM/yyyy"))
            lstInvoiced.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnClose2.Click
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
   Private Sub btnEditDetail_Click(sender As Object, e As EventArgs) Handles btnEditDetail.Click
      Dim tl1& = 0, tl2& = 0, tl3& = 0, tl4& = 0
      Dim tagArray$()
      For Each itm As ListViewItem In lstDetails.SelectedItems
         If itm.Selected = True Then
            tagArray = Split(itm.Tag, "|")
            tl1 = CLng(GetFloat(tagArray(0)))
            tl2 = CLng(GetFloat(tagArray(1)))
            tl3 = 1
            TestConnection()
            dr.ocmd.CommandText = " SELECT * FROM ORD_TRACKING_DETAIL"
            dr.ocmd.CommandText += " JOIN ORD_TRACKING ON ot_iid = oa_ORD_TRACKING"
            dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
            dr.ocmd.CommandText += " WHERE od_iLineNumber = " + CStr(tl2) + " AND oa_ORD_TRACKING = " + CStr(tl1)
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               dr.oread.Read()
               tl4 = dr.oread("oa_iid")
            End If
            dr.oread.Close()
            If tl4 > 0 Then
               GetOrderTrackingDetailRecord(tl4, dr)
               Dim frm As invoiceeditlinefrm
               frm = New invoiceeditlinefrm
               frm.ShowDialog()
               Display()
            End If
         End If
      Next
      If tl3 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
      Dim saveLine$ = "", saveProduct$ = "", saveShipNum$ = "", saveQuantity$ = ""
      Dim savePrice$ = "", saveTotal$ = "", saveTag$ = ""
      For Each itm As ListViewItem In lstDetails.Items
         saveTag = CStr(itm.Tag())
         saveLine = itm.SubItems.Item(0).Text
         saveProduct = itm.SubItems.Item(1).Text
         saveShipNum = itm.SubItems.Item(2).Text
         saveQuantity = itm.SubItems.Item(3).Text
         savePrice = itm.SubItems.Item(4).Text
         saveTotal = itm.SubItems.Item(5).Text

         itm.Remove()
         lstToBe.View = View.Details
         Dim ListItem1 As New ListViewItem(saveLine)
         ListItem1.Tag = saveTag
         ListItem1.SubItems.Add(saveProduct)
         ListItem1.SubItems.Add(saveShipNum)
         ListItem1.SubItems.Add(saveQuantity)
         ListItem1.SubItems.Add(savePrice)
         ListItem1.SubItems.Add(saveTotal)
         lstToBe.Items.Insert(0, ListItem1)
      Next
   End Sub
   Private Sub lstDetails_DoubleClick(sender As Object, e As EventArgs) Handles lstDetails.DoubleClick
      Dim saveLine$ = "", saveProduct$ = "", saveShipNum$ = "", saveQuantity$ = ""
      Dim savePrice$ = "", saveTotal$ = "", saveTag$ = ""
      Dim tagArray$()
      Dim saveShipment& = 0
      For Each itm As ListViewItem In lstDetails.SelectedItems
         If itm.Selected = True Then
            tagArray = Split(CStr(itm.Tag), "|")
            GetOrderTrackingRecord(CLng(GetFloat(tagArray(0))), dr)
            saveShipment = dr.ot_iid
         End If
      Next

      For Each itm As ListViewItem In lstDetails.Items
         tagArray = Split(CStr(itm.Tag), "|")
         If CLng(GetFloat(tagArray(0))) = saveShipment Then
            saveTag = CStr(itm.Tag())
            saveLine = itm.SubItems.Item(0).Text
            saveProduct = itm.SubItems.Item(1).Text
            saveShipNum = itm.SubItems.Item(2).Text
            saveQuantity = itm.SubItems.Item(3).Text
            savePrice = itm.SubItems.Item(4).Text
            saveTotal = itm.SubItems.Item(5).Text
            itm.Remove()
            lstToBe.View = View.Details
            Dim ListItem1 As New ListViewItem(saveLine)
            ListItem1.Tag = saveTag
            ListItem1.SubItems.Add(saveProduct)
            ListItem1.SubItems.Add(saveShipNum)
            ListItem1.SubItems.Add(saveQuantity)
            ListItem1.SubItems.Add(savePrice)
            ListItem1.SubItems.Add(saveTotal)
            lstToBe.Items.Insert(0, ListItem1)
         End If
      Next
   End Sub
   Private Sub lstToBe_DoubleClick(sender As Object, e As EventArgs) Handles lstToBe.DoubleClick
      Dim saveLine$ = "", saveProduct$ = "", saveShipNum$ = "", saveQuantity$ = ""
      Dim savePrice$ = "", saveTotal$ = "", saveTag$ = ""
      Dim tagArray$()
      Dim saveShipment& = 0
      For Each itm As ListViewItem In lstToBe.SelectedItems
         If itm.Selected = True Then
            tagArray = Split(CStr(itm.Tag), "|")
            GetOrderTrackingRecord(CLng(GetFloat(tagArray(0))), dr)
            saveShipment = dr.ot_iid
         End If
      Next

      For Each itm As ListViewItem In lstToBe.Items
         tagArray = Split(CStr(itm.Tag), "|")
         If CLng(GetFloat(tagArray(0))) = saveShipment Then
            saveTag = CStr(itm.Tag())
            saveLine = itm.SubItems.Item(0).Text
            saveProduct = itm.SubItems.Item(1).Text
            saveShipNum = itm.SubItems.Item(2).Text
            saveQuantity = itm.SubItems.Item(3).Text
            savePrice = itm.SubItems.Item(4).Text
            saveTotal = itm.SubItems.Item(5).Text
            itm.Remove()
            lstDetails.View = View.Details
            Dim ListItem1 As New ListViewItem(saveLine)
            ListItem1.Tag = saveTag
            ListItem1.SubItems.Add(saveProduct)
            ListItem1.SubItems.Add(saveShipNum)
            ListItem1.SubItems.Add(saveQuantity)
            ListItem1.SubItems.Add(savePrice)
            ListItem1.SubItems.Add(saveTotal)
            lstDetails.Items.Insert(0, ListItem1)
         End If
      Next
   End Sub
   Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
      btnClose.Enabled = False
      btnClose2.Enabled = False
      btnInvoice.Enabled = False
      If dr.oo_iid = 0 Then
         btnClose.Enabled = True
         btnClose2.Enabled = True
         btnInvoice.Enabled = True
         Exit Sub
      End If
      If MsgBox(Txt(840), vbYesNo, Txt(839)) = MsgBoxResult.Yes Then
         Dim tagArray$(), shipArray$(), invoiceArray$()
         Dim firstSWT& = 0, tSWT& = 0, currentTrack& = 0, detailSWT& = 0, invoiceTaxFree& = 0, trackSWT& = 0
         Dim trackNumber$ = "", invoiceStr$ = ""
         Dim trackDetail& = 0, quantity& = 0, price@ = 0, detailTax@ = 0, currentPrice@ = 0, discountSWT& = 0
         Dim invoiceTax@ = 0, invoiceTotal@ = 0, taxFree& = 0, shippTotal@ = 0, promoDiscount@ = 0
         InitInvoiceDetail(dr)
         InitInvoice(dr)
         If chkTaxFree.Checked = True Then
            invoiceTaxFree = 1
         Else
            invoiceTaxFree = 0
         End If
         GetSystemRecord(1, dr)
         If lstToBe.Items.Count > 0 Then
            For Each itm As ListViewItem In lstToBe.Items
               tSWT = 0
               tagArray = Split(CStr(itm.Tag), "|")
               currentTrack = CLng(GetFloat(tagArray(0)))
               If firstSWT = 0 Then
                  tSWT = 0
                  trackNumber += CStr(CLng(GetFloat(tagArray(0)))) + "|"
                  shipArray = Split(trackNumber, "|")
                  firstSWT = 1
               Else
                  For tl1 = 0 To UBound(shipArray) - 1
                     If shipArray(tl1) = CStr(currentTrack) Then
                        tSWT = 1
                        Exit For
                     End If
                  Next
                  If tSWT = 0 Then
                     trackNumber += CStr(CLng(GetFloat(tagArray(0)))) + "|"
                     shipArray = Split(trackNumber, "|")
                  End If
               End If
               If tSWT = 0 Then
                  TestConnection()
                  dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING"
                  dr.ocmd.CommandText += " JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid"
                  dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
                  dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
                  dr.ocmd.CommandText += " WHERE ot_iid = " + CStr(CLng(GetFloat(tagArray(0)))) + " AND od_ORD_ORDERS = " + CStr(dr.oo_iid)
                  dr.ocmd.CommandText += " ORDER BY od_iid"
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     Do While dr.oread.Read()
                        invoiceStr += CStr(dr.oread("ot_iid")) + "|"
                        invoiceStr += CStr(dr.oread("oa_iid")) + "|"
                        If dr.oread("oa_rTypeDiscount") > 0 Then
                           invoiceStr += CStr(dr.oread("oa_rPrice") - ((dr.oread("oa_rTypeDiscount") / 100) * dr.oread("oa_rPrice"))) + "|"
                        Else
                           invoiceStr += CStr(dr.oread("oa_rPrice")) + "|"
                        End If

                        invoiceStr += CStr(dr.oread("pp_iTaxFree")) + "|"
                        invoiceStr += CStr(dr.oread("ot_rShipCost")) + "|"
                     Loop
                  End If
                  dr.oread.Close()
               End If
            Next
            firstSWT = 0
            If invoiceStr <> "" Then
               'If dr.oo_PRM_CODES > 0 Then
               '   GetPromoCodesRecord(dr.oo_PRM_CODES, dr)
               '   If dr.po_iDiscountType = 0 Then
               '      promoDiscount = dr.po_rDiscount
               '   Else
               '      promoDiscount = dr.po_rDiscount / 100
               '   End If
               'End If
               invoiceArray = Split(invoiceStr, "|")
               dr.iv_ORD_ORDERS = dr.oo_iid
               dr.iv_dInvoiceDate = dpInvoiceDate.Value
               dr.iv_iTaxFree = invoiceTaxFree
               dr.iv_szInvoiceNotes = Trim(txtInvNotes.Text)
               dr.iv_PRM_CODES = dr.oo_PRM_CODES
               UpdateInvoiceRecord(dr)

               'invoice notes
               For tl1 = 0 To UBound(invoiceArray) - 1 Step 5
                  GetOrderTrackingDetailRecord(CLng(invoiceArray(tl1 + 1)), dr)
                  If trackSWT <> CLng(invoiceArray(tl1)) Then
                     'creating a record to link a shipment to an invoice
                     InitInvoiceShipping(dr)
                     dr.is_INV_INVOICE = dr.iv_iid
                     dr.is_ORD_TRACKING = CLng(invoiceArray(tl1))
                     shippTotal += GetFloat(invoiceArray(tl1 + 4))
                     UpdateInvoiceShippingRecord(dr)

                     'setting a shipment to invoiced
                     GetOrderTrackingRecord(CLng(invoiceArray(tl1)), dr)
                     dr.ot_iInvoiced = 1
                     UpdateOrderTrackingRecord(dr)
                  End If
                  If firstSWT = 1 Then
                     If detailSWT <> CLng(invoiceArray(tl1 + 1)) Or trackSWT <> CLng(invoiceArray(tl1)) Then
                        'creating invoice detail records
                        InitInvoiceDetail(dr)
                        dr.id_iQuantity = quantity
                        dr.id_rInvAmount = price
                        dr.id_ORD_TRACKING_DETAIL = detailSWT
                        dr.id_rPrice = currentPrice
                        dr.id_iTaxFree = taxFree
                        dr.id_INV_INVOICE = dr.iv_iid
                        UpdateInvoiceDetailRecord(dr)
                        'adding totals to final invoice values
                        invoiceTax += detailTax
                        invoiceTotal += price

                        currentPrice = 0
                        taxFree = 0
                        price = 0
                        detailTax = 0
                        quantity = 0
                     End If
                  End If
                  'adding totals together for an invoice detail
                  discountSWT = 0
                  If dr.iv_PRM_CODES > 0 Then
                     GetPromoCodesRecord(dr.iv_PRM_CODES, dr)
                     If dr.po_iType = 0 Then
                        If dr.po_iDiscountType = 1 Then
                           discountSWT = 1
                        Else
                           discountSWT = 0
                        End If
                     Else
                        discountSWT = 0
                     End If
                  Else
                     discountSWT = 0
                  End If

                  If discountSWT = 0 Then
                     price += GetFloat(invoiceArray(tl1 + 2))
                     currentPrice = GetFloat(invoiceArray(tl1 + 2))
                  Else
                     price += RoundVar(GetFloat(invoiceArray(tl1 + 2)) - ((dr.po_rDiscount / 100) * GetFloat(invoiceArray(tl1 + 2))), 2)
                     currentPrice = RoundVar(GetFloat(invoiceArray(tl1 + 2)) - ((dr.po_rDiscount / 100) * GetFloat(invoiceArray(tl1 + 2))), 2)
                  End If
                  If CLng(GetFloat(invoiceArray(tl1 + 3))) = 0 And invoiceTaxFree = 0 Then
                     detailTax += currentPrice
                  End If
                  'price += GetFloat(invoiceArray(tl1 + 2))
                  'currentPrice = GetFloat(invoiceArray(tl1 + 1))
                  'If CLng(GetFloat(invoiceArray(tl1 + 3))) = 0 And invoiceTaxFree = 0 Then
                  '   detailTax += RoundVar(GetFloat(invoiceArray(tl1 + 2)) * dr.ss_rTax1, 2)
                  'End If
                  quantity += 1
                  taxFree = CLng(invoiceArray(tl1 + 3))

                  'getting the current rows to see if they have changed later
                  trackDetail = CLng(invoiceArray(tl1 + 1))
                  trackSWT = CLng(invoiceArray(tl1))
                  detailSWT = CLng(dr.oa_ORD_DETAIL)
                  firstSWT = 1
               Next
               'this updates the last record
               InitInvoiceDetail(dr)
               dr.id_iQuantity = quantity
               dr.id_rInvAmount = price
               dr.id_ORD_TRACKING_DETAIL = detailSWT
               dr.id_rPrice = currentPrice
               dr.id_iTaxFree = taxFree
               dr.id_INV_INVOICE = dr.iv_iid
               UpdateInvoiceDetailRecord(dr)

               invoiceTax += detailTax
               invoiceTotal += price

               'updates invoice totals
               If dr.oo_PRM_CODES > 0 Then
                  GetPromoCodesRecord(dr.oo_PRM_CODES, dr)
                  If dr.po_iType = 0 Then
                     If dr.po_iDiscountType = 0 Then
                        'take off promo amount and taxes
                        If dr.po_iMinNeeded = 1 Then
                           If dr.po_rTotalNeeded <= invoiceTotal Then
                              invoiceTax -= dr.po_rDiscount
                              invoiceTotal -= dr.po_rDiscount
                           End If
                        Else
                           invoiceTax -= dr.po_rDiscount
                           invoiceTotal -= dr.po_rDiscount
                        End If
                        If invoiceTax < 0 Then
                           invoiceTax = 0
                        End If
                        If invoiceTotal < 0 Then
                           invoiceTotal = 0
                        End If
                     End If
                  End If
               End If

               dr.iv_rTaxAmount = invoiceTax * dr.ss_rTax1
               dr.iv_rInvoiceTotal = invoiceTotal
               dr.iv_rShipping = shippTotal
               UpdateInvoiceRecord(dr)
               MsgDsp(Txt(838))
               chkTaxFree.Checked = False
               tb.SelectedIndex = 1
               dpInvoiceDate.Value = Now
               txtInvNotes.Text = ""
               Display()
            Else
               'the string with all the invoice values in it is empty for some reason
               MsgDsp(Txt(837))
            End If
         Else
            'no items to be invoiced
            MsgDsp(Txt(834))
         End If
      End If
      btnClose.Enabled = True
      btnClose2.Enabled = True
      btnInvoice.Enabled = True
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tl1& = 0, tl2& = 0, orderTrackingString$ = "", tstr1$ = "", invNumString$ = ""
      Dim orderTrackingArray$(), invNumArray$()
      For Each itm As ListViewItem In lstInvoiced.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            tl2 = 1
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               TestConnection()
               dr.ocmd.CommandText = "SELECT is_ORD_TRACKING FROM INV_INVOICE"
               dr.ocmd.CommandText += " JOIN INV_SHIPPING ON iv_iid = is_INV_INVOICE"
               dr.ocmd.CommandText += " WHERE iv_iid = " + CStr(tl1)
               dr.oread = dr.ocmd.ExecuteReader()
               If dr.oread.HasRows = True Then
                  Do While dr.oread.Read()
                     orderTrackingString += CStr(dr.oread("is_ORD_TRACKING")) + "|"
                  Loop
               End If
               dr.oread.Close()

               If orderTrackingString <> "" Then
                  orderTrackingArray = Split(orderTrackingString, "|")
                  For tl3 = 0 To UBound(orderTrackingArray) - 1
                     InitOrderTracking(dr)
                     GetOrderTrackingRecord(CLng(orderTrackingArray(tl3)), dr)
                     If dr.ot_iid > 0 Then
                        dr.ot_iInvoiced = 0
                        UpdateOrderTrackingRecord(dr)
                     End If
                  Next

                  GetInvoiceRecord(tl1, dr)
                  invNumString = ""
                  TestConnection()
                  dr.ocmd.CommandText = "SELECT iv_iid FROM INV_INVOICE WHERE iv_iInvNum > " + CStr(dr.iv_iInvnum) + " AND iv_ORD_ORDERS = " + CStr(dr.oo_iid)
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     Do While dr.oread.Read()
                        invNumString += CStr(dr.oread("iv_iid")) + "|"
                     Loop
                  End If
                  dr.oread.Close()
                  If invNumString <> "" Then
                     invNumArray = Split(invNumString, "|")
                     For tl3 = 0 To UBound(invNumArray) - 1
                        InitInvoice(dr)
                        GetInvoiceRecord(CLng(invNumArray(tl3)), dr)
                        If dr.iv_iid > 0 Then
                           dr.iv_iInvnum -= 1
                           UpdateInvoiceRecord(dr)
                        End If
                     Next
                  End If

                  ExecuteScalar(dr.szConnection, "DELETE FROM INV_SHIPPING WHERE is_INV_INVOICE = " + CStr(tl1), tstr1)
                  ExecuteScalar(dr.szConnection, "DELETE FROM INV_DETAIL WHERE id_INV_INVOICE = " + CStr(tl1), tstr1)
                  ExecuteScalar(dr.szConnection, "DELETE FROM INV_INVOICE WHERE iv_iid = " + CStr(tl1), tstr1)

                  MsgDsp(Txt(355))
                  Display()
               End If
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
   End Sub
   Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
      If dr.oo_iid > 0 Then
         dr.LIST_CTRL = 29
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            GetOrderRecord(dr.oo_iid, dr)
            dr.oo_PRM_CODES = dr.po_iid
            UpdateOrderRecord(dr)
            MsgDsp(Txt(360))
            populateCodeText()
         End If
      End If
   End Sub
   Private Sub btnRemovePromo_Click(sender As Object, e As EventArgs) Handles btnRemovePromo.Click
      If dr.oo_PRM_CODES > 0 Then
         If dr.oo_iid > 0 Then
            If MsgBox(Txt(878), vbYesNo, Txt(879)) = MsgBoxResult.Yes Then
               dr.oo_PRM_CODES = 0
               txtCode.Text = ""
               UpdateOrderRecord(dr)
            End If
         End If
      Else
         MsgDsp(Txt(877))
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
      If btnCode.Enabled <> bv Then btnCode.Enabled = bv
   End Sub

   Private Sub tb_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tb.DrawItem
      Dim g As Graphics = e.Graphics
      If e.Index = tb.SelectedIndex Then
         Dim b As New SolidBrush(Color.LightBlue)
         Dim f As Font = New Font(e.Font, FontStyle.Bold)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      Else
         Dim b As New SolidBrush(Me.tb.BackColor)
         Dim f As Font = New Font(e.Font, FontStyle.Regular)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      End If
   End Sub
End Class