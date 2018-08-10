Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class customerbillingfrm
   Private Sub customerbillingfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(725)
      lbltitle.Text = Txt(704) + ":"
      lblHolderName.Text = Txt(705) + ":"
      lblAddr1.Text = Txt(505) + ":"
      lblAddr2.Text = Txt(506) + ":"
      lblCity.Text = Txt(507) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblCardType.Text = Txt(706) + ":"
      lblNumber.Text = Txt(707) + ":"
      lblExpiry.Text = Txt(708) + ":"
      lblPhone.Text = Txt(503) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblProvince.Text = Txt(510) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnCopy.Text = Txt(709)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)

      SetCboItems(cmbCountry, 300, 2)
      SetCboItems(cmbMonth, 400, 12)
      Dim currentYear As Date
      currentYear = Now.Date
      For tl1 = 1 To 22
         cmbYear.Items.Add(New ComboClass(CLng(Format(currentYear, "yyyy")), Format(currentYear, "yyyy")))
         currentYear = currentYear.AddYears(1)
      Next
      SetCboItems(cmbCardType, 710, 3)
      inits()
   End Sub
   Private Sub inits()
      InitCustomerBilling(dr)
      Display()
   End Sub
   Private Sub Display()
      Dim expiry$()
      txtTitle.Text = dr.cb_szTitle
      txtCardHolder.Text = dr.cb_szCardHolder
      txtAddr1.Text = dr.cb_szAddr1
      txtAddr2.Text = dr.cb_szAddr2
      txtCity.Text = dr.cb_szCity
      SetCboIndex(cmbCountry, dr.cb_iCountry)
      SetCboIndex(cmbProvince, dr.cb_iProvince)
      txtPostal.Text = dr.cb_szPostal
      SetCboIndex(cmbCardType, dr.cb_iCardType)
      txtNumber.Text = dr.cb_szCardNumber
      expiry = Split(dr.cb_szExpiry, "|")
      SetCboIndex(cmbMonth, CLng(expiry(0)))
      SetCboIndex(cmbYear, CLng(expiry(1)))
      txtPhone.Text = dr.cb_szPhone
   End Sub
   Private Sub ScreenToRecord()
      dr.cb_szTitle = Trim(txtTitle.Text)
      dr.cb_szCardHolder = Trim(txtCardHolder.Text)
      dr.cb_szAddr1 = Trim(txtAddr1.Text)
      dr.cb_szAddr2 = Trim(txtAddr2.Text)
      dr.cb_szCity = Trim(txtCity.Text)
      dr.cb_iCountry = CType(cmbCountry.SelectedItem, ComboClass).Value
      dr.cb_iProvince = CType(cmbProvince.SelectedItem, ComboClass).Value
      dr.cb_szPostal = Trim(txtPostal.Text)
      dr.cb_iCardType = CType(cmbCardType.SelectedItem, ComboClass).Value
      dr.cb_szCardNumber = Trim(txtNumber.Text).Replace("|", "")
      dr.cb_szExpiry = CStr(CType(cmbMonth.SelectedItem, ComboClass).Value) + "|" + CStr(CType(cmbYear.SelectedItem, ComboClass).Value)
      dr.cb_szPostal = Trim(txtPostal.Text).ToUpper().Replace(" ", "")
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.cb_szTitle = "" Then
         txtTitle.Focus()
         MsgDsp(Txt(720))
         Exit Function
      End If
      If dr.cb_szAddr1 = "" Then
         txtAddr1.Focus()
         MsgDsp(Txt(593))
         Exit Function
      End If
      If dr.cb_szCity = "" Then
         txtCity.Focus()
         MsgDsp(Txt(594))
         Exit Function
      End If
      If dr.cb_iCountry <= 0 Then
         cmbCountry.Focus()
         MsgDsp(Txt(721))
         Exit Function
      End If
      If dr.cb_iProvince <= 0 Then
         cmbProvince.Focus()
         MsgDsp(Txt(722))
         Exit Function
      End If
      If dr.cb_szPostal = "" Then
         txtPostal.Focus()
         MsgDsp(Txt(595))
         Exit Function
      End If
      If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
         If isValidCode(dr.cb_szPostal, CANADA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(749))
            Exit Function
         End If
      Else
         If isValidCode(dr.cb_szPostal, USA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(750))
            Exit Function
         End If
      End If
      If dr.cb_szCardNumber = "" Then
         txtNumber.Focus()
         MsgDsp(Txt(723))
         Exit Function
      End If
      If validateCreditCard(dr.cb_szCardNumber, dr.cb_iCardType) = 0 Then
         txtNumber.Focus()
         MsgDsp(Txt(724))
         Exit Function
      End If
      Validation = 1
   End Function
#Region "Click events"
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.cb_iid
      UpdateCustomerBillingRecord(dr)
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
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_BILLING WHERE cb_iid = " + CStr(dr.cb_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 20
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtTitle.Focus()
      End If
   End Sub
   Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
      dr.LIST_CTRL = 21
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         txtAddr1.Text = dr.ca_szAddr1
         txtAddr2.Text = dr.ca_szAddr2
         txtCity.Text = dr.ca_szCity
         txtPostal.Text = dr.ca_szPostal
         SetCboIndex(cmbCountry, dr.ca_iCountry)
         SetCboIndex(cmbProvince, dr.ca_iProvince)
         txtTitle.Focus()
      End If
   End Sub
#End Region
#Region "Got Focus"
   Private Sub txtTitle_GotFocus(sender As Object, e As EventArgs) Handles txtTitle.GotFocus
      SetText(txtTitle)
   End Sub
   Private Sub txtCardHolder_GotFocus(sender As Object, e As EventArgs) Handles txtCardHolder.GotFocus
      SetText(txtCardHolder)
   End Sub
   Private Sub txtAddr1_GotFocus(sender As Object, e As EventArgs) Handles txtAddr1.GotFocus
      SetText(txtAddr1)
   End Sub
   Private Sub txtAddr2_GotFocus(sender As Object, e As EventArgs) Handles txtAddr2.GotFocus
      SetText(txtAddr2)
   End Sub
   Private Sub txtCity_GotFocus(sender As Object, e As EventArgs) Handles txtCity.GotFocus
      SetText(txtCity)
   End Sub
   Private Sub txtPostal_GotFocus(sender As Object, e As EventArgs) Handles txtPostal.GotFocus
      SetText(txtPostal)
   End Sub
   Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtNumber.GotFocus
      SetText(txtNumber)
   End Sub
   Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
      SetText(txtPhone)
   End Sub
#End Region
#Region "Lost Focus"
   'Private Sub txtPostal_LostFocus(sender As Object, e As EventArgs) Handles txtPostal.LostFocus
   '   If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
   '      txtPostal.Text = FormatPostal(txtPostal.Text)
   '   End If
   'End Sub
   Private Sub txtPhone_LostFocus(sender As Object, e As EventArgs) Handles txtPhone.LostFocus
      txtPhone.Text = FormatPhone(txtPhone.Text)
   End Sub
#End Region
   Private Sub cmbCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCountry.SelectedIndexChanged
      cmbProvince.Items.Clear()
      If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
         lblPostal.Text = Txt(508) + ":"
         lblProvince.Text = Txt(510) + ":"
         SetCboItems(cmbProvince, 100, 13)
         SetCboIndex(cmbProvince, dr.co_iProvince)
      Else
         lblPostal.Text = Txt(513) + ":"
         lblProvince.Text = Txt(512) + ":"
         SetCboItems(cmbProvince, 150, 50)
         SetCboIndex(cmbProvince, dr.co_iProvince)
      End If
   End Sub
End Class