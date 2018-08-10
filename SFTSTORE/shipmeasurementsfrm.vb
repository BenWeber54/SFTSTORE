Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized
Imports System.ServiceModel
Imports RatingPortTypeClient
Imports getratesrequest
Imports getratesresponse
Imports System.ServiceModel.Channels

Public Class shipmeasurementsfrm
   Private Sub shipmeasurementsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(737)
      btnClose.Text = Txt(390)
      btnSave.Text = Txt(382)
      btnConvert.Text = Txt(763)

      lblWeight.Text = Txt(702) + ":"
      lblLength.Text = Txt(727) + ":"
      lblWidth.Text = Txt(728) + ":"
      lblHeight.Text = Txt(729) + ":"
      lblPackaged.Text = Txt(744) + ":"
      lblMaterial.Text = Txt(770) + ":"
      lblLength3.Text = Txt(730)
      lblWidth3.Text = Txt(731)
      lblHeight3.Text = Txt(732)

      cmbPackaged.Items.Add(New ComboClass(1, Txt(744)))
      cmbPackaged.Items.Add(New ComboClass(2, Txt(745)))
      inits()
   End Sub
   Private Sub inits()
      'InitOrderDetail(dr)
      Display()
   End Sub
   Private Sub Display()
      txtWeight.Text = dr.od_rWeight
      txtWidth.Text = dr.od_rWidth
      txtLength.Text = dr.od_rLength
      txtHeight.Text = dr.od_rHeight
      txtMaterial.Text = dr.od_iPackMaterial
      SetCboIndex(cmbPackaged, dr.od_iPackaged)
   End Sub
   Private Sub ScreenToRecord()
      dr.od_rWeight = GetFloat(txtWeight.Text)
      dr.od_rWidth = GetFloat(txtWidth.Text)
      dr.od_rLength = GetFloat(txtLength.Text)
      dr.od_rHeight = GetFloat(txtHeight.Text)
      dr.od_iPackMaterial = CLng(GetFloat(txtMaterial.Text))
      dr.od_iPackaged = CType(cmbPackaged.SelectedItem, ComboClass).Value
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.od_rWeight <= 0 Then
         txtWeight.Focus()
         MsgDsp(Txt(738))
         Exit Function
      End If
      If dr.od_rLength <= 0 Then
         txtLength.Focus()
         MsgDsp(Txt(739))
         Exit Function
      End If
      If dr.od_rWidth <= 0 Then
         txtWidth.Focus()
         MsgDsp(Txt(740))
         Exit Function
      End If
      If dr.od_rHeight <= 0 Then
         txtHeight.Focus()
         MsgDsp(Txt(741))
         Exit Function
      End If
      If dr.od_iPackMaterial < 0 Then
         txtMaterial.Focus()
         MsgDsp(Txt(772))
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      UpdateOrderDetailRecord(dr)
      'GetOrderDetailRecord(dr.od_iid, dr)
      'If getShippingRates() = 0 Then
      '   Exit Sub
      'End If
      MsgDsp(Txt(360))
      'Dim frm As shippingselectfrm
      'frm = New shippingselectfrm
      'frm.ShowDialog()
      Me.Close()
   End Sub
   Private Function getShippingRates()
      getShippingRates = 0
      Dim username = "8dc02f9d40183921"
      Dim password = "121ea3bb9a23dcb0b02090"
      Dim mailedBy = "0008424952"

      Dim server = New RatingPortTypeClient("RatingPort", "https://ct.soa-gw.canadapost.ca/rs/soap/rating/v3")
      server.ClientCredentials.UserName.UserName = username
      server.ClientCredentials.UserName.Password = password

      'Create Request
      Dim request = New getratesrequest()
      If dr.sr_iLanguage = ENGLISH Then
         request.locale = "EN"
      Else
         request.locale = "FR"
      End If

      'Dim request1 = New getservicerequest()
      'request1.locale = "EN"
      'request1.servicecode = "DOM.EP"

      request.mailingscenario = New getratesrequestMailingscenario()
      request.mailingscenario.parcelcharacteristics = New getratesrequestMailingscenarioParcelcharacteristics()
      request.mailingscenario.destination = New getratesrequestMailingscenarioDestination()
      Dim destDom = New getratesrequestMailingscenarioDestinationDomestic()
      request.mailingscenario.destination.Item = destDom
      request.mailingscenario.customernumber = mailedBy

      request.mailingscenario.parcelcharacteristics.weight = dr.od_rWeight
      request.mailingscenario.parcelcharacteristics.dimensions = New getratesrequestMailingscenarioParcelcharacteristicsDimensions
      request.mailingscenario.parcelcharacteristics.dimensions.length = dr.od_rLength
      request.mailingscenario.parcelcharacteristics.dimensions.width = dr.od_rWidth
      request.mailingscenario.parcelcharacteristics.dimensions.height = dr.od_rHeight

      If CType(cmbPackaged.SelectedItem, ComboClass).Value = 1 Then
         request.mailingscenario.parcelcharacteristics.unpackaged = False
      Else
         request.mailingscenario.parcelcharacteristics.unpackaged = True
      End If

      TestConnection()
      dr.ocmd.CommandText = "SELECT ch_szPostal FROM COM_ADDRESS JOIN PRO_PRODUCT ON pp_COM_ADDRESS = ch_iid WHERE pp_iid = " + CStr(dr.od_PRO_PRODUCT)
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
      dr.ocmd.CommandText = "SELECT * from ORD_DETAIL JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
      dr.ocmd.CommandText += " JOIN CUS_ADDRESS ON ca_iid = oo_CUS_ADDRESS WHERE od_iid = " + CStr(dr.od_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         destDom.postalcode = dr.oread("ca_szPostal")
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
         Dim response As getratesresponse
         response = server.GetRates(request)

         'Retrieve values from response object
         If response.Item.GetType() = GetType(getratesresponsePricequotes) Then
            Dim priceQuotes As getratesresponsePricequotes
            priceQuotes = response.Item
            For Each priceQuote In priceQuotes.pricequote
               dr.WEB_RESULT += CStr(priceQuote.servicename) + "|"
               dr.WEB_RESULT += CStr(priceQuote.pricedetails.due) + "|"
            Next
         Else
            'Dim msgs As messages
            'msgs = response.Item
            'For Each tl5 In msgs.message
            '   dr.WEB_ERRORS += "Error Code: " + tl5.code
            '   dr.WEB_ERRORS += "Error Msg: " + tl5.description
            'Next
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
         'show errors need to make french
         If dr.WEB_ERRORS.Contains("length") = True Then
            MsgDsp(Txt(752))
         ElseIf dr.WEB_ERRORS.Contains("width") = True Then
            MsgDsp(Txt(753))
         ElseIf dr.WEB_ERRORS.Contains("height") = True Then
            MsgDsp(Txt(754))
         ElseIf dr.WEB_ERRORS.Contains("weight") = True Then
            MsgDsp(Txt(751))
         ElseIf dr.WEB_ERRORS.Contains("origin-postal-code") = True Then
            MsgDsp(Txt(756))
         ElseIf dr.WEB_ERRORS.Contains("postal-code") = True Then
            MsgDsp(Txt(755))
         Else
            MsgDsp(Txt(758))
         End If
         getShippingRates = 0
      Else
         getShippingRates = 1
      End If
   End Function

   Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
      btnConvert.Enabled = False
      Dim tl1@ = 0

      tl1 = GetFloat(txtWeight.Text)
      tl1 = tl1 / 2.20462
      txtWeight.Text = StringFormatEnglish(24, tl1)
      btnConvert.Enabled = True
   End Sub
End Class