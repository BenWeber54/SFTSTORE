Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productfeedbackfrm
   Dim oldPrice@
   Dim oldPriceId& = 0
   Private Sub productfeedbackfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(669)
      lblCustomer.Text = Txt(585) + ":"
      lblProduct.Text = Txt(660) + ":"
      lblRating.Text = Txt(671) + ":"
      lblFeedback.Text = Txt(673) + ":"

      rad1.Text = Txt(674)
      rad2.Text = Txt(675)
      rad3.Text = Txt(676)
      rad4.Text = Txt(677)
      rad5.Text = Txt(678)

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)
      inits()
   End Sub
   Private Sub inits()
      InitProductFeedback(dr)
      If dr.FRMSWT = 1 Then
         dr.pf_PRO_PRODUCT = dr.pp_iid
         btnProduct.Visible = False
         btnCustomer.Visible = True
      Else
         dr.pf_CUS_CUSTOMER = dr.cu_iid
         btnCustomer.Visible = False
         btnCustomer.Visible = False
         btnProduct.Visible = True
      End If
      Display()
   End Sub
   Private Sub Display()
      setRadio()
      txtFeedback.Text = dr.pf_szFeedback

      If dr.pf_CUS_CUSTOMER > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT cu_szDisplay FROM CUS_CUSTOMER WHERE cu_iid = " + CStr(dr.pf_CUS_CUSTOMER)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtCustomer.Text = dr.oread("cu_szDisplay")
         Else
            txtCustomer.Text = ""
         End If
         dr.oread.Close()
      Else
         txtCustomer.Text = ""
      End If

      If dr.pf_PRO_PRODUCT > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT pp_szProductName FROM PRO_PRODUCT WHERE pp_iid = " + CStr(dr.pf_PRO_PRODUCT)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            txtProduct.Text = dr.oread("pp_szProductName")
         Else
            txtProduct.Text = ""
         End If
         dr.oread.Close()
      Else
         txtProduct.Text = ""
      End If
   End Sub
   Private Sub ScreenToRecord()
      getRadio()
      dr.pf_szFeedback = Trim(txtFeedback.Text)
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.pf_CUS_CUSTOMER <= 0 Then
         btnCustomer.Focus()
         MsgDsp(Txt(586))
         Exit Function
      End If
      If dr.pf_PRO_PRODUCT <= 0 Then
         btnProduct.Focus()
         MsgDsp(Txt(549))
         Exit Function
      End If

      If dr.pf_CUS_CUSTOMER > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT pf_iid FROM PRO_FEEDBACK JOIN PRO_PRODUCT ON pp_iid = pf_PRO_PRODUCT"
         dr.ocmd.CommandText += " WHERE pf_CUS_CUSTOMER = " + CStr(dr.pf_CUS_CUSTOMER) + " AND pp_iid = " + CStr(dr.pp_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("pf_iid") <> dr.pf_iid Then
               MsgDsp(Txt(670))
               btnCustomer.Focus()
               Exit Function
            End If
         End If
         dr.oread.Close()
      End If
      If dr.pf_szFeedback = "" Then
         txtFeedback.Focus()
         MsgDsp(Txt(672))
         Exit Function
      Else
         If ContainsProfanity(dr.filteredText, dr.pf_szFeedback) = False Then
            txtFeedback.Focus()
            MsgDsp(Txt(804))
            Exit Function
         End If
      End If

      Validation = 1
   End Function
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.pf_iid
      UpdateProductFeedbackRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      inits()
   End Sub
   Private Sub setRadio()
      If dr.pf_iRating = 1 Then
         rad1.Checked = True
      ElseIf dr.pf_iRating = 2 Then
         rad2.Checked = True
      ElseIf dr.pf_iRating = 3 Then
         rad3.Checked = True
      ElseIf dr.pf_iRating = 4 Then
         rad4.Checked = True
      ElseIf dr.pf_iRating = 5 Then
         rad5.Checked = True
      End If
   End Sub
   Private Sub getRadio()
      If rad1.Checked = True Then
         dr.pf_iRating = 1
      ElseIf rad2.Checked = True Then
         dr.pf_iRating = 2
      ElseIf rad3.Checked = True Then
         dr.pf_iRating = 3
      ElseIf rad4.Checked = True Then
         dr.pf_iRating = 4
      ElseIf rad5.Checked = True Then
         dr.pf_iRating = 5
      End If
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM PRO_FEEDBACK WHERE pf_iid = " + CStr(dr.pf_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 17
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         If dr.FRMSWT = 1 Then
            btnCustomer.Focus()
         Else
            btnProduct.Focus()
         End If
      End If
   End Sub
   Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
      ScreenToRecord()
      dr.LIST_CTRL = 18
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub
   Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
      ScreenToRecord()
      dr.LIST_CTRL = 19
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.pf_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
   End Sub
   Private Function ContainsProfanity(ByVal filter$(), ByVal inputString As String) As Boolean
      Dim inputArray$()
      inputArray = Split(inputString, " ")
      For tl1 = 0 To UBound(filter) - 1
         For tl2 = 0 To UBound(inputArray)
            If filter(tl1) = inputArray(tl2) Or filter(tl1) = CStr("""" + inputArray(tl2) + """") Or filter(tl1) = CStr("'" + inputArray(tl2) + "'") Then
               Return False
            End If
         Next
      Next
      Return True
   End Function
End Class