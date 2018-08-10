Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class shippingdetailsfrm
   Private Sub shippingdetailsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(794)
      btnClose.Text = Txt(390)

      Display()
   End Sub
   Private Sub Display()
      lst.Clear()
      Dim trackNum$ = ""
      TestConnection()
      dr.ocmd.CommandText = "SELECT ot_szShipId FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE oa_ORD_DETAIL = " + CStr(dr.od_iid) + " AND ot_iShipNum = " + CStr(dr.shipNum)
      dr.oread = dr.ocmd.ExecuteReader
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         trackNum = dr.oread("ot_szShipId")
      End If
      dr.oread.Close()
      If trackNum <> "" Then
         lst.View = View.Details
         lst.Columns.Add(Txt(547), lst.Width - 625, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(746), 200, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(787), 120, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(637), 150, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(813), 150, HorizontalAlignment.Center)
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid"
         dr.ocmd.CommandText += " JOIN ORD_DETAIL ON oa_ORD_DETAIL = od_iid"
         dr.ocmd.CommandText += " JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid"
         dr.ocmd.CommandText += " WHERE ot_szShipId = '" + CStr(trackNum) + "'"
         dr.ocmd.CommandText += " ORDER BY pp_szProductName"
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            Do While dr.oread.Read()
               'put the right fields in here
               Dim ListItem1 As New ListViewItem(CStr(dr.oread("pp_szProductName")))
               ListItem1.Tag = CStr(dr.oread("ot_iid"))
               ListItem1.SubItems.Add(getShipType(dr.oread("ot_szShipCode")))
               ListItem1.SubItems.Add(StringFormatCurrency(2, dr.oread("ot_rShipCost")))
               ListItem1.SubItems.Add(CStr(dr.oread("ot_szTracking")))
               If dr.oread("ot_iReturnRequested") = 0 Then
                  ListItem1.SubItems.Add("NO")
               Else
                  ListItem1.SubItems.Add("YES")
               End If
               lst.Items.Add(ListItem1)
            Loop
         End If
         dr.oread.Close()
      End If
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Function getShipType(shipCode As String) As String
      Dim shipType$ = ""
      If shipCode = "DOM.RP" Then
         shipType = "Regular Parcel"
      ElseIf shipCode = "DOM.EP" Then
         shipType = "Expedited Parcel"
      ElseIf shipCode = "DOM.XP" Then
         shipType = "Xpresspost"
      ElseIf shipCode = "DOM.PC" Then
         shipType = "Priority"
      ElseIf shipCode = "USA.PW.ENV" Then
         shipType = "Priority Worldwide Envelope USA"
      ElseIf shipCode = "USA.PW.PAK" Then
         shipType = "Priority Worldwide pas USA"
      ElseIf shipCode = "USA.PW.PARCEL" Then
         shipType = "Priority Worldwide Parcel USA"
      ElseIf shipCode = "USA.XP" Then
         shipType = "Xpresspost USA"
      ElseIf shipCode = "USA.EP" Then
         shipType = "Expedited Parcel USA"
      ElseIf shipCode = "USA.SP.AIR" Then
         shipType = "Small Packet USA Air"
      ElseIf shipCode = "USA.TP" Then
         shipType = "Tracked Packet - USA"
      Else
         shipType = "N/A"
      End If
      Return shipType
   End Function
End Class