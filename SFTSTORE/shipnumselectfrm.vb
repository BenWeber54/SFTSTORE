Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Data
Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class shipnumselectfrm
   Dim shippingNumber& = 0, firstLoad& = 0
   Private Sub shipnumselectfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(793)
      btnRefund.Text = Txt(809)
      bclose.Text = Txt(764)
      If dr.FRMSWT = 1 Then
         btnSelect.Text = Txt(614)
         btnSelect.Visible = True
      ElseIf dr.FRMSWT = 2 Then
         btnSelect.Visible = False
      ElseIf dr.FRMSWT = 3 Then
         'btnShowDetails.Visible = False
         btnSelect.Visible = False
         btnUnship.Visible = True
      ElseIf dr.FRMSWT = 4 Then
         'btnShowDetails.Visible = False
         btnSelect.Visible = False
         btnRefund.Visible = True
      End If
      btnUnship.Text = Txt(768)
      btnShowDetails.Text = Txt(794)
      Display()
   End Sub
   Private Sub Display()
      lst.Clear()
      lst.View = View.Details
      lst.Columns.Add(Txt(783), 120, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(636), 120, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(660), lst.Width - 345, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(611), 100, HorizontalAlignment.Left)
      Dim shipNum& = 0
      TestConnection()
      dr.ocmd.CommandText = "SELECT count(*), ot_iShipNum, oo_iid, pp_szProductName FROM ORD_TRACKING_DETAIL "
      dr.ocmd.CommandText += " JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
      dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
      dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
      dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
      dr.ocmd.CommandText += " WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid)
      If dr.FRMSWT = 3 Then
         dr.ocmd.CommandText += " AND ot_iReturnRequested = 1 AND ot_iReturned = 0 AND ot_iInvoiced = 0"
      ElseIf dr.FRMSWT = 4 Then
         dr.ocmd.CommandText += " AND ot_iReturnRequested = 0 AND ot_iInvoiced = 0"
      ElseIf dr.FRMSWT = 2 Then
         dr.ocmd.CommandText += " AND ot_iReturned = 0"
      End If
      dr.ocmd.CommandText += " GROUP BY oa_ORD_DETAIL, ot_iShipNum, oo_iid, pp_szProductName"
      dr.ocmd.CommandText += " ORDER BY ot_iShipNum"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            If dr.oread("ot_iShipNum") <> shipNum Then
               shipNum = dr.oread("ot_iShipNum")
               Dim ListItem1 As New ListViewItem(CStr(dr.oread("ot_iShipNum")))
               ListItem1.Tag = CStr(dr.oread("ot_iShipNum"))
               ListItem1.SubItems.Add(CStr(dr.oread("oo_iid")))
               ListItem1.SubItems.Add(CStr(dr.oread("pp_szProductName")))
               ListItem1.SubItems.Add(CStr(dr.oread(0)))
               lst.Items.Add(ListItem1)
            End If
         Loop
      Else
         If dr.FRMSWT = 3 Then
            MsgDsp(Txt(806))
         ElseIf dr.FRMSWT = 4 Then
            MsgDsp(Txt(812))
         End If
         dr.oread.Close()
         Me.Close()
      End If
      dr.oread.Close()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub

   Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            dr.shipNumber = tl1
            tl2 = 1
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      Else
         Me.Close()
      End If
   End Sub

   Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl2 = 1
            tl1 = CLng(GetFloat(itm.Tag))
            dr.shipNum = tl1
            Dim frm As shippingdetailsfrm
            frm = New shippingdetailsfrm
            frm.ShowDialog()
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      End If
      Display()
   End Sub

   Private Sub btnUnship_Click(sender As Object, e As EventArgs) Handles btnUnship.Click
      Dim tl1& = 0, tl2& = 0, tstr1$ = ""
      Dim unshipArray$()
      If MsgBox(Txt(807), vbYesNo, Txt(768)) = MsgBoxResult.Yes Then
         For Each itm As ListViewItem In lst.SelectedItems
            If itm.Selected = True Then
               tl1 = CLng(GetFloat(itm.Tag))
               tl2 = 1
               GetOrderRecord(dr.od_ORD_ORDERS, dr)
               TestConnection()
               dr.ocmd.CommandText = "SELECT ot_iid FROM ORD_TRACKING_DETAIL"
               dr.ocmd.CommandText += " JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
               dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
               dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
               dr.ocmd.CommandText += " WHERE ot_iShipNum = " + CStr(tl1)
               dr.ocmd.CommandText += " AND oo_iid = " + CStr(dr.oo_iid) + " AND ot_iReturned = 0"
               dr.ocmd.CommandText += " "
               dr.oread = dr.ocmd.ExecuteReader()
               If dr.oread.HasRows = True Then
                  Do While dr.oread.Read()
                     tstr1 += CStr(dr.oread("ot_iid")) + "|"
                  Loop
               End If
               dr.oread.Close()
            End If
         Next
         If tstr1 <> "" Then
            unshipArray = Split(tstr1, "|")
            For tl3 = 0 To UBound(unshipArray) - 1
               GetOrderTrackingRecord(CLng(unshipArray(tl3)), dr)
               dr.ot_iReturned = 1
               dr.ot_dReturned = Now
               dr.ot_uUSR_USER = dr.sr_iid
               UpdateOrderTrackingRecord(dr)
            Next
            MsgDsp(Txt(769))
         End If
         If tl2 = 0 Then
            MsgDsp(Txt(558))
         Else
            Me.Close()
         End If
      End If
   End Sub

   Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl2 = 1
            shippingNumber = CLng(GetFloat(itm.Tag))
            If shippingNumber > 0 Then
               If MsgBox(Txt(814), vbYesNo, Txt(809)) = MsgBoxResult.Yes Then
                  refundShipment()
               End If
            End If
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      Else
         Me.Close()
      End If
   End Sub
   Private Sub refundShipment()
      Dim userEmail$ = "", ticketId$ = ""
      Dim ticketDate As Date
      ticketDate = Now
      Dim reason$ = ""
      dr.ot_szRefundReason = ""
      Dim frm As shippingrefundreasonfrm
      frm = New shippingrefundreasonfrm
      frm.ShowDialog()
      If dr.ot_szRefundReason = "" Then
         MsgDsp(Txt(821))
         Exit Sub
      Else
         reason = dr.ot_szRefundReason
      End If

      Dim server = New NCShipmentPortTypeClient("NCShipmentPort", "https://ct.soa-gw.canadapost.ca/rs/soap/ncshipment/v4")
      server.ClientCredentials.UserName.UserName = dr.MAILUSER
      server.ClientCredentials.UserName.Password = dr.MAILPASSWORD

      Dim request = New requestnoncontractshipmentrefundrequest()
      If dr.sr_iLanguage = ENGLISH Then
         request.locale = "EN"
      Else
         request.locale = "FR"
      End If
      request.mailedby = dr.MAILCUSNUMBER

      TestConnection()
      dr.ocmd.CommandText = "SELECT ot_szShipId, ot_iid FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid) + " AND ot_iShipNum = " + CStr(shippingNumber) + " AND ot_iReturned = 0"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         request.shipmentid = dr.oread("ot_szShipId")
         dr.ot_iid = dr.oread("ot_iid")
      Else
         dr.oread.Close()
         Exit Sub
      End If
      dr.oread.Close()
      request.noncontractshipmentrefundrequest = New NonContractShipmentRefundRequestType()

      TestConnection()
      dr.ocmd.CommandText = "SELECT uu_szEmail FROM USR_USER WHERE uu_iid = " + CStr(dr.sr_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("uu_szEmail") = "" Then
            MsgDsp(Txt(810))
            dr.oread.Close()
            Exit Sub
         Else
            request.noncontractshipmentrefundrequest.email = dr.oread("uu_szEmail")
            userEmail = dr.oread("uu_szEmail")
         End If
      Else
         dr.oread.Close()
         Exit Sub
      End If
      dr.oread.Close()

      Dim elements = server.Endpoint.Binding.CreateBindingElements()
      elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
      server.Endpoint.Binding = New CustomBinding(elements)

      dr.WEB_RESULT = ""
      dr.WEB_ERRORS = ""
      Try
         Dim response As requestnoncontractshipmentrefundresponse
         response = server.RequestNCShipmentRefund(request)

         If response.Item.GetType() = GetType(NonContractShipmentRefundRequestInfoType) Then
            Dim refund As NonContractShipmentRefundRequestInfoType
            refund = response.Item
            'dr.WEB_RESULT += CStr(refund.serviceticketdate) + "|"
            'dr.WEB_RESULT += CStr(refund.serviceticketid) + "|"
            ticketDate = CDate(refund.serviceticketdate)
            ticketId = CStr(refund.serviceticketid)
         Else
            Dim msgs As messagesShipment
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
      Dim trackingStrings$ = ""
      Dim trackingArray$()
      GetOrderRecord(dr.od_ORD_ORDERS, dr)
      If dr.WEB_ERRORS <> "" Then
         MsgDsp(Txt(817))
      Else
         TestConnection()
         dr.ocmd.CommandText = "SELECT ot_iid FROM ORD_TRACKING_DETAIL"
         dr.ocmd.CommandText += " JOIN ORD_TRACKING ON oa_ORD_TRACKING = ot_iid"
         dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
         dr.ocmd.CommandText += " JOIN ORD_ORDERS ON od_ORD_ORDERS = oo_iid"
         dr.ocmd.CommandText += " WHERE oo_iid = " + CStr(dr.oo_iid)
         dr.ocmd.CommandText += " AND ot_iShipNum = " + CStr(shippingNumber) + " AND ot_iReturned = 0"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            Do While dr.oread.Read()
               trackingStrings += CStr(dr.oread("ot_iid")) + "|"
            Loop
         End If
         dr.oread.Close()

         If trackingStrings <> "" Then
            trackingArray = Split(trackingStrings, "|")
            For tl1 = 0 To UBound(trackingArray) - 1
               GetOrderTrackingRecord(CLng(trackingArray(tl1)), dr)
               dr.ot_szTicketId = ticketId
               dr.ot_dTicketDate = ticketDate
               dr.ot_szTicketEmail = userEmail
               dr.ot_iReturnRequested = 1
               dr.ot_szRefundReason = reason
               UpdateOrderTrackingRecord(dr)
            Next
         End If
         MsgDsp(Txt(811))
      End If
   End Sub
End Class