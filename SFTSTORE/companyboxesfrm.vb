Imports System.IO
Imports System.Net
Imports System.Text
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf

Public Class companyboxesfrm
   Private Sub companyboxesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(774)

      btnNew.Text = Txt(379)
      btnConvert.Text = Txt(763)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)

      lblWeight.Text = Txt(773) + ":"
      lblLength.Text = Txt(727) + ":"
      lblWidth.Text = Txt(728) + ":"
      lblHeight.Text = Txt(729) + ":"
      inits()
   End Sub
   Private Sub inits()
      InitCompanyBoxes(dr)
      Display()
   End Sub
   Private Sub Display()
      txtWeight.Text = CStr(dr.cx_rMaxWeight)
      txtLength.Text = CStr(dr.cx_rLength)
      txtWidth.Text = CStr(dr.cx_rWidth)
      txtHeight.Text = CStr(dr.cx_rHeight)
   End Sub
   Private Sub ScreenToRecord()
      dr.cx_rMaxWeight = GetFloat(txtWeight.Text)
      dr.cx_rLength = GetFloat(txtLength.Text)
      dr.cx_rWidth = GetFloat(txtWidth.Text)
      dr.cx_rHeight = GetFloat(txtHeight.Text)
      If dr.FRMSWT = 1 Then
         dr.cx_COM_COMPANY = dr.sr_iCompany
      Else
         dr.cx_COM_COMPANY = dr.co_iid
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.cx_rMaxWeight <= 0 Then
         txtWeight.Focus()
         MsgDsp(Txt(738))
         Exit Function
      ElseIf dr.cx_rMaxWeight > 30 Then
         txtWeight.Focus()
         MsgDsp(Txt(903))
         Exit Function
      End If
      If dr.cx_rLength <= 0 Then
         txtLength.Focus()
         MsgDsp(Txt(739))
         Exit Function
      End If
      If dr.cx_rWidth <= 0 Then
         txtWidth.Focus()
         MsgDsp(Txt(740))
         Exit Function
      End If
      If dr.cx_rHeight <= 0 Then
         txtHeight.Focus()
         MsgDsp(Txt(741))
         Exit Function
      End If
      If dr.cx_rHeight > 200 Or dr.cx_rWidth > 200 Or dr.cx_rLength > 200 Then
         txtLength.Focus()
         MsgDsp(Txt(904))
         Exit Function
      End If
      If dr.cx_rLength < 10 Then
         txtLength.Focus()
         MsgDsp(Txt(905))
         Exit Function
      End If
      If dr.cx_rWidth < 2.3 Then
         txtWidth.Focus()
         MsgDsp(Txt(906))
         Exit Function
      End If
      If dr.cx_rHeight < 2.3 Then
         txtHeight.Focus()
         MsgDsp(Txt(907))
         Exit Function
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
      tl1 = dr.cx_iid
      UpdateCompanyBoxesRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      inits()
   End Sub

   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM COM_BOXES WHERE cx_iid = " + CStr(dr.cx_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub

   Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
      btnConvert.Enabled = False
      Dim tl1@ = 0
      tl1 = GetFloat(txtWeight.Text)
      tl1 = tl1 / 2.20462
      txtWeight.Text = StringFormatEnglish(24, tl1)
      btnConvert.Enabled = True
   End Sub

   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 26
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub
End Class