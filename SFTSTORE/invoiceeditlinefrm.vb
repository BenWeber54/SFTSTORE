Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class invoiceeditlinefrm
   Dim newPrice@ = 0, newDiscount@ = 0
   Private Sub invoiceeditlinefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Display()
   End Sub
   Private Sub Display()
      TestConnection()
      dr.ocmd.CommandText = "SELECT pp_szProductName FROM ORD_DETAIL JOIN PRO_PRODUCT ON od_PRO_PRODUCT = pp_iid WHERE od_iid = " + CStr(dr.oa_ORD_DETAIL)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         txtProduct.Text = dr.oread("pp_szProductName")
      End If
      dr.oread.Close()
      txtPrice.Text = dr.oa_rPrice
      txtDiscount.Text = dr.oa_rTypeDiscount
   End Sub
   Private Sub ScreenToRecord()
      newPrice = GetFloat(txtPrice.Text)
      newDiscount = GetFloat(txtDiscount.Text)
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If newPrice < 0 Then
         txtPrice.Focus()
         MsgDsp(Txt(560))
         Exit Function
      End If
      If newDiscount < 0 Then
         txtDiscount.Focus()
         MsgDsp(Txt(833))
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      ScreenToRecord()
      If Validation() = 0 Then Exit Sub
      Dim detailArray$()
      Dim detailString$ = ""
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM ORD_TRACKING_DETAIL WHERE oa_ORD_TRACKING = " + CStr(dr.oa_ORD_TRACKING) + " AND oa_ORD_DETAIL = " + CStr(dr.oa_ORD_DETAIL)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            detailString += CStr(dr.oread("oa_iid")) + "|"
         Loop
      End If
      If detailString <> "" Then
         detailArray = Split(detailString, "|")
         For tl1& = 0 To UBound(detailArray) - 1
            GetOrderTrackingDetailRecord(CLng(detailArray(tl1)), dr)
            dr.oa_rPrice = newPrice
            dr.oa_rTypeDiscount = newDiscount
            UpdateOrderTrackingDetailRecord(dr)
         Next
      End If
      MsgDsp(Txt(360))
      Me.Close()
   End Sub
End Class