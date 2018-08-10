Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized
Imports System.ServiceModel
Imports RatingPortTypeClient
Imports getratesrequest
Imports getratesresponse

Imports NCShipmentPortTypeClient
Imports CreateNCShipmentRequest
Imports CreateNCShipmentResponse
Imports System.ServiceModel.Channels
Public Class shipmentinfofrm
   Dim publicShipNum& = 0
   Private Sub shipmentinfofrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Inits()
   End Sub
   Private Sub Inits()
      InitOrderDetail(dr)
      InitProduct(dr)
      InitCompanyBoxes(dr)
      Display()
   End Sub
   Private Sub Display()
      lstLoad()
   End Sub
   Private Sub lstLoad()
      lst.Clear()
      lst.View = View.Details
      lst.Columns.Add(Txt(643), 110, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(547), lst.Width - 745, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(782), 160, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(784), 140, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(783), 120, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(746), 110, HorizontalAlignment.Center)
      lst.Columns.Add(Txt(787), 100, HorizontalAlignment.Left)
      For tl1 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         GetOrderDetailRecord(CLng(dr.SHIPPING_ARRAY(tl1)), dr)
         GetCompanyBoxesRecord(CLng(dr.SHIPPING_ARRAY(tl1 + 1)), dr)
         GetProductRecord(dr.od_PRO_PRODUCT, dr)
         Dim ListItem1 As New ListViewItem(CStr(dr.od_iLineNumber))
         ListItem1.Tag = CStr(dr.SHIPPING_ARRAY(tl1))
         ListItem1.SubItems.Add(dr.pp_szProductName)
         ListItem1.SubItems.Add(CStr(dr.cx_rLength) + " x " + CStr(dr.cx_rWidth) + " x " + CStr(dr.cx_rHeight))
         If dr.od_iPackaged = 2 Then
            ListItem1.SubItems.Add(Txt(745))
         ElseIf dr.pp_iPackedSolo = 2 Then
            ListItem1.SubItems.Add(Txt(786))
         Else
            ListItem1.SubItems.Add(Txt(785))
         End If
         ListItem1.SubItems.Add(dr.SHIPPING_ARRAY(tl1 + 2))
         ListItem1.SubItems.Add(dr.SHIPPING_ARRAY(tl1 + 3))
         ListItem1.SubItems.Add(dr.SHIPPING_ARRAY(tl1 + 4))
         lst.Items.Add(ListItem1)
      Next
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnShipType_Click(sender As Object, e As EventArgs) Handles btnShipType.Click
      Me.Cursor = Cursors.WaitCursor
      If getShippingRates() = 0 Then
         Me.Cursor = Cursors.Arrow
         Exit Sub
      End If
      Me.Cursor = Cursors.Arrow
      Dim frm As shippingselectfrm
      frm = New shippingselectfrm
      frm.ShowDialog()
      Display()
   End Sub
   Private Sub enableButtons()
      btnShip.Enabled = True
      btnClose.Enabled = True
      btnShipType.Enabled = True
   End Sub
   Private Sub disableButtons()
      btnShip.Enabled = False
      btnClose.Enabled = False
      btnShipType.Enabled = False
   End Sub
   Private Sub btnShip_Click(sender As Object, e As EventArgs) Handles btnShip.Click
      Cursor = Cursors.WaitCursor
      disableButtons()
      Dim shipSWT& = 0
      Dim resultArray$()
      For tl1 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         If dr.SHIPPING_ARRAY(tl1 + 2) = "" Or dr.SHIPPING_ARRAY(tl1 + 3) = "" Then
            'dr.SHIPPING_ARRAY(tl1 + 3) = "COM.EP"
            'dr.SHIPPING_ARRAY(tl1 + 4) = "1"
            MsgDsp(Txt(789))
            Cursor = Cursors.Arrow
            enableButtons()
            Exit Sub
         End If
      Next
      If MsgBox(Txt(790), vbYesNo, Txt(645)) = MsgBoxResult.Yes Then
         Dim shipNum$ = ""
         Dim shipWeight& = 0
         Dim unPackaged& = 0
         For tl1 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
            If UBound(dr.SHIPPING_ARRAY) > 2 Then
               'ship num change
               If shipNum <> dr.SHIPPING_ARRAY(tl1 + 2) Then
                  shipNum = dr.SHIPPING_ARRAY(tl1 + 2)
                  publicShipNum = CLng(dr.SHIPPING_ARRAY(tl1 + 2))
                  shipWeight = 0
                  Dim server = New NCShipmentPortTypeClient("NCShipmentPort", "https://ct.soa-gw.canadapost.ca/rs/soap/ncshipment/v4")
                  server.ClientCredentials.UserName.UserName = dr.MAILUSER
                  server.ClientCredentials.UserName.Password = dr.MAILPASSWORD

                  For tl2 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
                     If dr.SHIPPING_ARRAY(tl1) = dr.SHIPPING_ARRAY(tl2) Then
                        GetOrderDetailRecord(CLng(dr.SHIPPING_ARRAY(tl1)), dr)
                        shipWeight += dr.od_rWeight
                     End If
                  Next

                  'Create Request
                  Dim request = New createnoncontractshipmentrequest()
                  If dr.sr_iLanguage = ENGLISH Then
                     request.locale = "EN"
                  Else
                     request.locale = "FR"
                  End If
                  'If dr.sr_iLanguage = ENGLISH Then
                  '   request.locale = "FR"
                  'Else
                  '   request.locale = "FR"
                  'End If

                  request.mailedby = dr.MAILCUSNUMBER

                  'Create shipment object to contain xml request
                  request.noncontractshipment = New NonContractShipmentType()
                  Dim shipment = New NonContractShipmentType()
                  request.noncontractshipment = shipment

                  TestConnection()
                  dr.ocmd.CommandText = "SELECT ch_szPostal FROM COM_ADDRESS WHERE ch_iShipping = 2 and ch_COM_COMPANY = " + CStr(dr.sr_iCompany)
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     dr.oread.Read()
                     shipment.requestedshippingpoint = dr.oread("ch_szPostal")
                  Else
                     MsgDsp(Txt(747))
                     Cursor = Cursors.Arrow
                     enableButtons()
                     Exit Sub
                  End If
                  dr.oread.Close()

                  'shipment.requestedshippingpoint = "H2B1A0"
                  shipment.deliveryspec = New DeliverySpecType()
                  shipment.deliveryspec.sender = New SenderType()
                  shipment.deliveryspec.sender.addressdetails = New DomesticAddressDetailsType()
                  shipment.deliveryspec.destination = New DestinationType()
                  shipment.deliveryspec.destination.addressdetails = New DestinationAddressDetailsType()
                  'shipment.deliveryspec.options = new OptionType[1]
                  'shipment.deliveryspec.options[0] = new OptionType()
                  shipment.deliveryspec.parcelcharacteristics = New ParcelCharacteristicsType()
                  shipment.deliveryspec.parcelcharacteristics.dimensions = New ParcelCharacteristicsTypeDimensions()
                  shipment.deliveryspec.notification = New NotificationType()
                  shipment.deliveryspec.preferences = New PreferencesType()
                  shipment.deliveryspec.references = New ReferencesType()

                  TestConnection()
                  dr.ocmd.CommandText = "SELECT * FROM ORD_DETAIL JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
                  dr.ocmd.CommandText += " JOIN CUS_CUSTOMER ON oo_CUS_CUSTOMER = cu_iid"
                  dr.ocmd.CommandText += " JOIN CUS_ADDRESS ON oo_CUS_ADDRESS = ca_iid"
                  dr.ocmd.CommandText += " JOIN COM_COMPANY ON cu_COM_COMPANY = co_iid"
                  dr.ocmd.CommandText += " JOIN COM_ADDRESS ON co_iid = ch_COM_COMPANY"
                  dr.ocmd.CommandText += " WHERE ch_iShipping = 2 AND od_iid = " + CStr(dr.SHIPPING_ARRAY(tl1))
                  dr.oread = dr.ocmd.ExecuteReader()
                  If dr.oread.HasRows = True Then
                     dr.oread.Read()
                     'Populate shipment object
                     'sending address
                     If dr.oread("od_iPackaged") = 1 Then
                        shipment.deliveryspec.parcelcharacteristics.unpackaged = False
                     Else
                        shipment.deliveryspec.parcelcharacteristics.unpackaged = True
                     End If


                     shipment.deliveryspec.sender.addressdetails.addressline1 = CStr(dr.oread("ch_szAddr1"))
                     shipment.deliveryspec.sender.addressdetails.city = CStr(dr.oread("ch_szCity"))
                     shipment.deliveryspec.sender.addressdetails.provstate = Txt(119 + CLng(dr.oread("ch_iProvince")))
                     shipment.deliveryspec.sender.addressdetails.postalzipcode = dr.oread("ch_szPostal")
                     shipment.deliveryspec.sender.name = "Ben Weber"
                     shipment.deliveryspec.sender.company = dr.oread("co_szCompanyName")
                     shipment.deliveryspec.sender.contactphone = dr.oread("co_szPhone")

                     'recieving address
                     shipment.deliveryspec.destination.addressdetails.addressline1 = dr.oread("ca_szAddr1")
                     shipment.deliveryspec.destination.addressdetails.city = dr.oread("ca_szCity")
                     If dr.oread("ca_iCountry") = CANADA Then
                        shipment.deliveryspec.destination.addressdetails.provstate = Txt(119 + CLng(dr.oread("ca_iProvince")))
                        shipment.deliveryspec.destination.addressdetails.countrycode = "CA"
                     Else
                        shipment.deliveryspec.destination.addressdetails.provstate = Txt(219 + CLng(dr.oread("ca_iProvince")))
                        shipment.deliveryspec.destination.addressdetails.countrycode = "US"
                     End If
                     shipment.deliveryspec.destination.addressdetails.postalzipcode = dr.oread("ca_szPostal")
                     shipment.deliveryspec.destination.name = dr.oread("cu_szFirst") + " " + dr.oread("cu_szLast")
                     'shipment.deliveryspec.destination.company = "ACME Corp."
                     shipment.deliveryspec.notification.email = dr.oread("cu_szEmail")
                  Else
                     MsgDsp(Txt(748))
                     Cursor = Cursors.Arrow
                     enableButtons()
                     Exit Sub
                  End If
                  dr.oread.Close()

                  GetCompanyBoxesRecord(CLng(dr.SHIPPING_ARRAY(tl1 + 1)), dr)
                  'shipment.deliveryspec.options[0].optioncode = "DC"
                  shipment.deliveryspec.parcelcharacteristics.dimensions.height = dr.cx_rHeight
                  shipment.deliveryspec.parcelcharacteristics.dimensions.length = dr.cx_rLength
                  shipment.deliveryspec.parcelcharacteristics.dimensions.width = dr.cx_rWidth
                  shipment.deliveryspec.parcelcharacteristics.weight = shipWeight
                  shipment.deliveryspec.notification.ondelivery = True
                  shipment.deliveryspec.notification.onexception = False
                  shipment.deliveryspec.notification.onshipment = True
                  'shipment.deliveryspec.preferences.showinsuredvalue = True
                  'shipment.deliveryspec.preferences.showpackinginstructions = True
                  shipment.deliveryspec.preferences.showpostagerate = True
                  'shipment.deliveryspec.references.costcentre = "costcentre"
                  'shipment.deliveryspec.references.customerref1 = "customerref1"
                  'shipment.deliveryspec.references.customerref2 = "customerref2"
                  shipment.deliveryspec.servicecode = dr.SHIPPING_ARRAY(tl1 + 3)

                  'Disable timestamp on request
                  Dim elements = server.Endpoint.Binding.CreateBindingElements()
                  elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
                  server.Endpoint.Binding = New CustomBinding(elements)

                  'Dim responseAsString$ = ""
                  dr.WEB_ERRORS = ""
                  dr.WEB_RESULT = ""
                  Try
                     'Execute Request
                     Dim response = server.CreateNCShipment(request)

                     'Retrieve values from response object
                     If response.Item.GetType() = GetType(NonContractShipmentInfoType) Then
                        Dim shipmentInfo As NonContractShipmentInfoType
                        shipmentInfo = response.Item
                        dr.WEB_RESULT += shipmentInfo.shipmentid + "|"
                        dr.WEB_RESULT += shipmentInfo.trackingpin + "|"
                        For Each artifact In shipmentInfo.artifacts
                           dr.WEB_RESULT += artifact.artifactid + "|"
                           If artifact.artifactid <> "" Then
                              Exit For
                           End If
                           'dr.WEB_RESULT += artifact.pageindex + "|"
                        Next
                     Else
                        Dim msgs As messagesShipment
                        msgs = response.Item
                        For Each tl5 In msgs.message
                           dr.WEB_ERRORS += tl5.code + "|"
                           dr.WEB_ERRORS += tl5.description + "|"
                        Next
                     End If
                  Catch faultEx As FaultException
                     'SOAP Fault
                     dr.WEB_ERRORS += faultEx.Code.Name + "|"
                     dr.WEB_ERRORS += faultEx.Message + "|"

                  Catch ex As Exception
                     ' Misc Exception
                     dr.WEB_ERRORS += ex.Message + "|"
                  End Try

                  If dr.WEB_RESULT <> "" Then
                     resultArray = Split(dr.WEB_RESULT, "|")
                     For tl2 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
                        If dr.SHIPPING_ARRAY(tl2 + 2) = shipNum Then
                           dr.SHIPPING_ARRAY(tl2 + 5) = resultArray(0) 'shipment id
                           dr.SHIPPING_ARRAY(tl2 + 6) = resultArray(1) 'tracking pin
                           dr.SHIPPING_ARRAY(tl2 + 7) = resultArray(2) 'artifact id
                        End If
                     Next
                  End If

                  If dr.WEB_ERRORS.Length > 0 Then
                     TestConnection()
                     dr.ocmd.CommandText = "SELECT * FROM ERR_MESSAGES"
                     dr.oread = dr.ocmd.ExecuteReader()
                     If dr.oread.HasRows = True Then
                        Do While dr.oread.Read()
                           If dr.sr_iLanguage = ENGLISH Then
                              If dr.WEB_ERRORS.Contains(dr.oread("er_szEnglish")) = True Then
                                 MsgDsp(dr.oread("er_szEngReal"))
                                 Exit Do
                              End If
                           Else
                              If dr.WEB_ERRORS.Contains(dr.oread("er_szFrench")) = True Then
                                 MsgDsp(dr.oread("er_szFrnReal"))
                                 Exit Do
                              End If
                           End If
                        Loop
                     Else
                        MsgDsp(Txt(758))
                        Cursor = Cursors.Arrow
                        enableButtons()
                        Exit Sub
                     End If
                     dr.oread.Close()
                     For tl2 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
                        If dr.SHIPPING_ARRAY(tl2 + 5) <> "" Or dr.SHIPPING_ARRAY(tl2 + 6) <> "" Or dr.SHIPPING_ARRAY(tl2 + 7) <> "" Then
                           shipSWT = 1
                           updateTrackingOrder()
                           tl1 -= 8
                        End If
                     Next
                     If shipSWT = 0 Then
                        Cursor = Cursors.Arrow
                        enableButtons()
                        Exit Sub
                     End If
                  Else
                     updateTrackingOrder()
                     tl1 -= 8
                  End If
               End If
            End If
         Next
         Cursor = Cursors.Arrow
         MsgDsp(Txt(759))
      Me.Close()
      End If
   End Sub
#End Region
   Private Sub updateTrackingOrder()
      Dim tStr1$ = "", firstThrough& = 0
      For tl1 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         If UBound(dr.SHIPPING_ARRAY) > 2 And tl1 < (UBound(dr.SHIPPING_ARRAY)) Then
            If publicShipNum = CLng(dr.SHIPPING_ARRAY(tl1 + 2)) Then
               If dr.SHIPPING_ARRAY(tl1 + 5) <> "" Or dr.SHIPPING_ARRAY(tl1 + 6) <> "" Or dr.SHIPPING_ARRAY(tl1 + 7) <> "" Then
                  tStr1 = ""
                  If firstThrough = 0 Then
                     InitOrderTracking(dr)
                     dr.ot_COM_BOXES = CLng(dr.SHIPPING_ARRAY(tl1 + 1))
                     dr.ot_iShipNum = CLng(dr.SHIPPING_ARRAY(tl1 + 2))
                     dr.ot_szTracking = dr.SHIPPING_ARRAY(tl1 + 6)
                     dr.ot_szShipCode = dr.SHIPPING_ARRAY(tl1 + 3)
                     dr.ot_rShipCost = GetFloat(dr.SHIPPING_ARRAY(tl1 + 4))
                     dr.ot_szArtifact = dr.SHIPPING_ARRAY(tl1 + 7)
                     dr.ot_szShipId = dr.SHIPPING_ARRAY(tl1 + 5)
                     UpdateOrderTrackingRecord(dr)

                     firstThrough = 1
                  End If
                  InitOrderTrackingDetail(dr)
                  dr.oa_ORD_DETAIL = CLng(dr.SHIPPING_ARRAY(tl1))
                  GetOrderDetailRecord(dr.oa_ORD_DETAIL, dr)
                  'finish this
                  'If dr.oo_PRM_CODES > 0 And dr.od_rTypeDiscount = 0 Then
                  '   GetPromoCodesRecord(dr.oo_PRM_CODES, dr)
                  '   If dr.po_iType = 0 Then
                  '      If dr.po_iDiscountType = 0 Then
                  '         dr.oa_rPrice = dr.od_rPiecePrice
                  '      Else
                  '         dr.oa_rPrice = dr.od_rPiecePrice - ((dr.po_rDiscount / 100) * dr.od_rPiecePrice)
                  '      End If
                  '      If dr.oa_rPrice <= 0 Then
                  '         dr.oa_rPrice = 0
                  '      End If
                  '   Else
                  '      dr.oa_rPrice = dr.od_rPiecePrice
                  '   End If
                  'Else
                  '   dr.oa_rPrice = dr.od_rPiecePrice
                  'End If

                  'comment out this for that ^ if you use it
                  dr.oa_rPrice = dr.od_rPiecePrice
                  dr.oa_ORD_TRACKING = dr.ot_iid
                  dr.oa_rTypeDiscount = dr.od_rTypeDiscount
                  UpdateOrderTrackingDetailRecord(dr)

                  For tl2 = 0 To UBound(dr.SHIPPING_ARRAY) - 1
                     If tl2 > tl1 + 7 Or tl2 < tl1 Then
                        tStr1 += dr.SHIPPING_ARRAY(tl2) + "|"
                     End If
                  Next
                  dr.SHIPPING_ARRAY = Split(tStr1, "|")
                  If UBound(dr.SHIPPING_ARRAY) > 1 Then
                     tl1 -= 8
                  End If
               End If
            End If
         End If
      Next
   End Sub
   'Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick

   'End Sub
   Private Function getShippingRates()
      getShippingRates = 0
      InitCompanyBoxes(dr)
      Dim tl1& = 0, tl2& = 0, shipNum& = 0, packaged& = 0
      Dim totalWeight@ = 0
      Dim selectedIndex As Integer
      selectedIndex = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            selectedIndex = itm.Index
            GetOrderDetailRecord(tl1, dr)
            tl2 = 1
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
         Exit Function
      End If

      For tl3 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         If lst.Items(selectedIndex).SubItems(4).Text = dr.SHIPPING_ARRAY(tl3 + 2) Then
            shipNum = dr.SHIPPING_ARRAY(tl3 + 2)
            dr.shipNum = shipNum
            GetCompanyBoxesRecord(CLng(dr.SHIPPING_ARRAY(tl3 + 1)), dr)
         End If
      Next
      For tl3 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         If CStr(shipNum) = dr.SHIPPING_ARRAY(tl3 + 2) Then
            GetOrderDetailRecord(CLng(dr.SHIPPING_ARRAY(tl3)), dr)
            packaged = CLng(GetFloat(dr.od_iPackaged))
            totalWeight += dr.od_rWeight
         End If
      Next
      If dr.cx_iid = 0 Then
         Exit Function
      End If
      Dim server = New RatingPortTypeClient("RatingPort", "https://ct.soa-gw.canadapost.ca/rs/soap/rating/v3")
      server.ClientCredentials.UserName.UserName = dr.MAILUSER
      server.ClientCredentials.UserName.Password = dr.MAILPASSWORD

      Dim request = New getratesrequest()
      If dr.sr_iLanguage = ENGLISH Then
         request.locale = "EN"
      Else
         request.locale = "FR"
      End If

      request.mailingscenario = New getratesrequestMailingscenario()
      request.mailingscenario.parcelcharacteristics = New getratesrequestMailingscenarioParcelcharacteristics()
      request.mailingscenario.destination = New getratesrequestMailingscenarioDestination()
      request.mailingscenario.customernumber = dr.MAILCUSNUMBER

      request.mailingscenario.parcelcharacteristics.dimensions = New getratesrequestMailingscenarioParcelcharacteristicsDimensions
      request.mailingscenario.parcelcharacteristics.weight = totalWeight
      request.mailingscenario.parcelcharacteristics.dimensions.length = dr.cx_rLength
      request.mailingscenario.parcelcharacteristics.dimensions.width = dr.cx_rWidth
      request.mailingscenario.parcelcharacteristics.dimensions.height = dr.cx_rHeight

      If packaged = 1 Then
         request.mailingscenario.parcelcharacteristics.unpackaged = False
      Else
         request.mailingscenario.parcelcharacteristics.unpackaged = True
      End If
      

      TestConnection()
      dr.ocmd.CommandText = "SELECT ch_szPostal FROM COM_ADDRESS WHERE ch_iShipping = 2 and ch_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         request.mailingscenario.originpostalcode = dr.oread("ch_szPostal")
      Else
         MsgDsp(Txt(747))
         Exit Function
      End If
      dr.oread.Close()

      TestConnection()
      dr.ocmd.CommandText = "SELECT ca_szPostal, ca_iCountry from CUS_ADDRESS"
      dr.ocmd.CommandText += " WHERE ca_iid = " + CStr(dr.oo_CUS_ADDRESS)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("ca_iCountry") = 1 Then
            Dim destDom = New getratesrequestMailingscenarioDestinationDomestic()
            destDom.postalcode = dr.oread("ca_szPostal")
            request.mailingscenario.destination.Item = destDom
         Else
            Dim destDom = New getratesrequestMailingscenarioDestinationUnitedstates()
            destDom.zipcode = dr.oread("ca_szPostal")
            request.mailingscenario.destination.Item = destDom
         End If

      Else
         MsgDsp(Txt(748))
         Exit Function
      End If
      dr.oread.Close()

      'Disable timestamp on request
      Dim elements = server.Endpoint.Binding.CreateBindingElements()
      elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
      server.Endpoint.Binding = New CustomBinding(elements)

      'Dim responseAsString$ = ""
      dr.WEB_RESULT = ""
      dr.WEB_ERRORS = ""
      Try
         'Execute Request
         Dim response As New getratesresponse
         response = server.GetRates(request)

         'Retrieve values from response object
         If response.Item.GetType() = GetType(getratesresponsePricequotes) Then
            Dim priceQuotes As getratesresponsePricequotes
            priceQuotes = response.Item
            For Each priceQuote In priceQuotes.pricequote
               dr.WEB_RESULT += CStr(priceQuote.servicename) + "|"
               dr.WEB_RESULT += CStr(priceQuote.pricedetails.due) + "|"
               dr.WEB_RESULT += CStr(priceQuote.servicecode) + "|"
            Next
         Else
            'Dim test As 
            Dim msgs As messagesRating
            msgs = response.Item
            For Each tl5 In msgs.message
               dr.WEB_ERRORS += "Error Code: " + tl5.code
               dr.WEB_ERRORS += "Error Msg: " + tl5.description
            Next
         End If
      Catch faultEx As FaultException
         'SOAP Fault
         dr.WEB_ERRORS += "Fault Code: " + faultEx.Code.Name
         dr.WEB_ERRORS += "Fault String: " + faultEx.Message
      Catch ex As Exception
         'Misc Exception
         dr.WEB_ERRORS += "ERROR: " + ex.Message
      End Try
      'if errors exit function
      If dr.WEB_ERRORS <> "" Then
         Dim tl10& = 0
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM ERR_MESSAGES"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            Do While dr.oread.Read()
               If dr.sr_iLanguage = ENGLISH Then
                  If dr.WEB_ERRORS.Contains(dr.oread("er_szEnglish")) = True Then
                     MsgDsp(dr.oread("er_szEngReal"))
                     tl10 = 1
                     Exit Do
                  End If
               Else
                  If dr.WEB_ERRORS.Contains(dr.oread("er_szFrench")) = True Then
                     MsgDsp(dr.oread("er_szFrnReal"))
                     tl10 = 1
                     Exit Do
                  End If
               End If
            Loop
         End If
         If tl10 = 0 Then
            MsgDsp(Txt(758))
            Exit Function
         End If
         dr.oread.Close()
         getShippingRates = 0
      Else
         getShippingRates = 1
      End If
   End Function
   'Private Sub lstDetails_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst.ColumnClick
   '   Dim tCOL%, tI%, tJ%, tK%, tstr1$, tSORT%, tSW%, tTEST$, tAGAINST$, tSORTED%

   '   tCOL = e.Column
   '   If LISTSORT(tCOL) = 1 Then
   '      LISTSORT(tCOL) = 0
   '   Else
   '      LISTSORT(tCOL) = 1
   '   End If
   '   tSORT = LISTSORT(tCOL)

   '   If lst.Items.Count < 2 Then Exit Sub

   '   tCNT = lstDetails.Items.Count - 1

   '   tSORTED = 0

   '   For tI = 0 To tCNT - 1
   '      For tJ = tI + 1 To tCNT
   '         Dim lstI As ListViewItem = lst.Items(tI)
   '         Dim lstJ As ListViewItem = lst.Items(tJ)
   '         tTEST = lstJ.SubItems(tCOL).Text
   '         tAGAINST = lstI.SubItems(tCOL).Text
   '         If Len(tTEST) >= 6 And Len(tAGAINST) >= 6 Then
   '            If IsDate(tTEST) = True And IsDate(tAGAINST) = True Then
   '               tTEST = Format(CDate(tTEST), "yyyyMMddhhmmss")
   '               tAGAINST = Format(CDate(tAGAINST), "yyyyMMddhhmmss")
   '            End If
   '         End If
   '         tSW = 0
   '         If tSORT = 0 Then
   '            If tTEST < tAGAINST Then tSW = 1
   '         Else
   '            If tTEST > tAGAINST Then tSW = 1
   '         End If
   '         If tSW = 1 Then
   '            tSORTED = 1
   '            tstr1 = lstI.Tag
   '            lstI.Tag = lstJ.Tag
   '            lstJ.Tag = tstr1
   '            If lstI.SubItems.Count >= 0 Then
   '               For tK = 0 To lstI.SubItems.Count - 1
   '                  tstr1 = lstI.SubItems(tK).Text
   '                  lstI.SubItems(tK).Text = lstJ.SubItems(tK).Text
   '                  lstJ.SubItems(tK).Text = tstr1
   '               Next
   '            End If
   '         End If
   '      Next
   '   Next
   '   If tSORTED = 1 Then lst.Invalidate()
   'End Sub

End Class