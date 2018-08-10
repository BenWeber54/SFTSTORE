Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class companyfrm
   Private Sub companyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(616)
      lblCompanyName.Text = Txt(375)
      lblEmail.Text = Txt(364) + ":"
      lblPhone.Text = Txt(503) + ":"
      lblFax.Text = Txt(504) + ":"
      lblAddr1.Text = Txt(505) + ":"
      lblAddr2.Text = Txt(506) + ":"
      lblCity.Text = Txt(507) + ":"
      lblPostal.Text = Txt(508) + ":"
      lblMarket.Text = Txt(509) + ":"
      lblProvince.Text = Txt(510) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblMaterial.Text = Txt(770) + ":"
      lblWebsite.Text = Txt(890) + ":"
      lblReplyEmail.Text = Txt(896) + ":"
      lblReplyPass.Text = Txt(897) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnNotes.Text = Txt(384)
      btnAttach.Text = Txt(385)
      btnImages.Text = Txt(386)
      btnProducts.Text = Txt(387)
      btnUsers.Text = Txt(388)
      btnAudit.Text = Txt(389)
      btnClose.Text = Txt(390)
      btnBoxes.Text = Txt(775)
      inits()
   End Sub
   Private Sub inits()
      cmbCountry.Items.Clear()
      cmbProvince.Items.Clear()
      SetCboItems(cmbCountry, 300, 2)
      SetCboItems(cmbProvince, 100, 13)
      InitCompany(dr)
      Display()
   End Sub
   Private Sub Display()
      Dim tNOTES$ = "", tAUDIT$ = "", tATTACHMENTS$ = "", tIMAGES$ = "", tPRODUCTS$ = "", tUSERS$ = "", tADDRESS$ = "", tBOXES$ = ""
      dr.ocmd.CommandText = "SELECT * FROM TXT_TEXT WHERE tx_iid = " + CStr(99 + dr.co_iProvince)
      txtCompanyName.Text = dr.co_szCompanyName
      txtEmail.Text = dr.co_szEmail
      txtPhone.Text = dr.co_szPhone
      txtFax.Text = dr.co_szFax
      txtAddr1.Text = dr.co_szAddr1
      txtAddr2.Text = dr.co_szAddr2
      txtCity.Text = dr.co_szCity
      txtPostal.Text = dr.co_szPostal
      txtMarket.Text = dr.co_szMarket
      SetCboIndex(cmbCountry, dr.co_iCountry)
      SetCboIndex(cmbProvince, dr.co_iProvince)
      txtMaterial.Text = CStr(dr.co_iDefaultMaterial)
      txtWebsite.Text = dr.co_szWebsite
      txtReplyEmail.Text = dr.co_szNoReplyEmail
      txtReplyPass.Text = dr.co_szReplyPass

      tNOTES = Txt(384)
      tAUDIT = Txt(389)
      tATTACHMENTS = Txt(385)
      tIMAGES = Txt(386)
      tPRODUCTS = Txt(387)
      tUSERS = Txt(388)
      tADDRESS = Txt(580)
      tBOXES = Txt(775)

      If dr.co_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "COMPANY_GET_INFO " + CStr(dr.co_iid) + ""
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread(1) <> 0 Then
               tNOTES += " (" + CStr(dr.oread(1)) + ")"
            End If
            If dr.oread(2) <> 0 Then
               tAUDIT += " (" + CStr(dr.oread(2)) + ")"
            End If
            If dr.oread(3) <> 0 Then
               tATTACHMENTS += " (" + CStr(dr.oread(3)) + ")"
            End If
            If dr.oread(4) <> 0 Then
               tIMAGES += " (" + CStr(dr.oread(4)) + ")"
            End If
            If dr.oread(5) <> 0 Then
               tPRODUCTS += " (" + CStr(dr.oread(5)) + ")"
            End If
            If dr.oread(6) <> 0 Then
               tUSERS += " (" + CStr(dr.oread(6)) + ")"
            End If
            If dr.oread(7) <> 0 Then
               tADDRESS += " (" + CStr(dr.oread(7)) + ")"
            End If
            If dr.oread(8) <> 0 Then
               tBOXES += " (" + CStr(dr.oread(8)) + ")"
            End If
         End If
         dr.oread.Close()
      End If

      If btnNotes.Text <> tNOTES Then btnNotes.Text = tNOTES
      If btnAudit.Text <> tAUDIT Then btnAudit.Text = tAUDIT
      If btnAttach.Text <> tATTACHMENTS Then btnAttach.Text = tATTACHMENTS
      If btnImages.Text <> tIMAGES Then btnImages.Text = tIMAGES
      If btnProducts.Text <> tPRODUCTS Then btnProducts.Text = tPRODUCTS
      If btnUsers.Text <> tUSERS Then btnUsers.Text = tUSERS
      If btnAddress.Text <> tADDRESS Then btnAddress.Text = tADDRESS
      If btnBoxes.Text <> tBOXES Then btnBoxes.Text = tBOXES
   End Sub
   Private Sub ScreenToRecord()
      dr.co_szCompanyName = Trim(txtCompanyName.Text)
      dr.co_szEmail = Trim(txtEmail.Text)
      dr.co_szPhone = Trim(txtPhone.Text)
      dr.co_szFax = Trim(txtFax.Text)
      dr.co_szAddr1 = Trim(txtAddr1.Text)
      dr.co_szAddr2 = Trim(txtAddr2.Text)
      dr.co_szCity = Trim(txtCity.Text)
      dr.co_szPostal = Trim(txtPostal.Text).ToUpper.Replace(" ", "")
      dr.co_szMarket = Trim(txtMarket.Text)
      dr.co_iCountry = CType(cmbCountry.SelectedItem, ComboClass).Value
      dr.co_iProvince = CType(cmbProvince.SelectedItem, ComboClass).Value
      dr.co_iDefaultMaterial = CLng(GetFloat(txtMaterial.Text))
      dr.co_szWebsite = Trim(txtWebsite.Text)
      dr.co_szNoReplyEmail = Trim(txtReplyEmail.Text)
      dr.co_szReplyPass = Trim(txtReplyPass.Text)
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.co_szCompanyName = "" Then
         txtCompanyName.Focus()
         MsgBox(Txt(357))
         Exit Function
      End If
      If dr.co_iDefaultMaterial < 0 Then
         txtMaterial.Focus()
         MsgDsp(Txt(772))
         Exit Function
      End If
      If dr.co_szPostal <> "" Then
         If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
            If isValidCode(dr.co_szPostal, CANADA) = False Then
               txtPostal.Focus()
               MsgDsp(Txt(749))
               Exit Function
            End If
         Else
            If isValidCode(dr.co_szPostal, USA) = False Then
               txtPostal.Focus()
               MsgDsp(Txt(750))
               Exit Function
            End If
         End If
      End If
      
      TestConnection()
      dr.ocmd.CommandText = "select co_szCompanyName, co_iid from COM_COMPANY where co_szCompanyName = '" + AStr(dr.co_szCompanyName) + "'"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("co_iid") <> dr.co_iid Then
            MsgBox(Txt(358))
            txtCompanyName.Focus()
            dr.oread.Close()
            Exit Function
         End If
      End If
      Validation = 1
   End Function
#Region "Click events"
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      inits()
   End Sub
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.co_iid
      UpdateCompanyRecord(dr)
      AddMostrecent(MR_COMPANY, dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM COM_COMPANY WHERE co_iid = " + CStr(dr.co_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM NOT_NOTES WHERE no_iKey = " + CStr(dr.co_iid) + " and no_iType = " + CStr(NOTE_COMPANY), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM ATT_ATTACHMENTS WHERE at_iKey = " + CStr(dr.co_iid) + " and at_iType = " + CStr(ATTACHMENT_COMPANY), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 1
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtCompanyName.Focus()
         AddMostrecent(MR_COMPANY, dr)
      End If
   End Sub
   Private Sub btnRecent_Click(sender As Object, e As EventArgs) Handles btnRecent.Click
MostRecentRestart:
      dr.mr_iType = MR_COMPANY
      dr.LIST_CTRL = 2
      OpenMostRecent(dr)
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetCompanyRecord(dr.LIST_KEY, dr)
         If dr.LIST_KEY = dr.co_iid Then
            Display()
            txtCompanyName.Focus()
            AddMostrecent(MR_COMPANY, dr)
         Else
            RemoveMostRecent(MR_COMPANY, dr.LIST_KEY, dr)
            MsgDsp(Txt(366))
            GoTo MostRecentRestart
         End If
      End If
   End Sub
   Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
      If InStr(btnAudit.Text, "(") > 0 Then
         GenerateAudit(AUDIT_COMPANY, dr.co_iid)
      Else
         MsgDsp(Txt(361))
      End If
   End Sub
   Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
      If dr.co_iid > 0 Then
         dr.NOTES_TYPE = NOTE_COMPANY
         dr.NOTES_KEY = dr.co_iid
         ScreenToRecord()
         Dim frm As notes
         frm = New notes
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
      If dr.co_iid > 0 Then
         dr.ATTACHMENT_TYPE = ATTACHMENT_COMPANY
         dr.ATTACHMENT_KEY = dr.co_iid
         ScreenToRecord()
         Dim frm As attachments
         frm = New attachments
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnImages_Click(sender As Object, e As EventArgs) Handles btnImages.Click
      If dr.co_iid > 0 Then
         dr.IMAGE_KEY = dr.co_iid
         ScreenToRecord()
         Dim frm As companyimages
         frm = New companyimages
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
      If dr.co_iid > 0 Then
         ScreenToRecord()
         Dim frm As productsfrm
         frm = New productsfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
      If dr.co_iid > 0 Then
         ScreenToRecord()
         Dim frm As userfrm
         frm = New userfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
      If dr.co_iid > 0 Then
         ScreenToRecord()
         Dim frm As companyaddressfrm
         frm = New companyaddressfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
   Private Sub btnBoxes_Click(sender As Object, e As EventArgs) Handles btnBoxes.Click
      If dr.co_iid > 0 Then
         dr.FRMSWT = 2
         ScreenToRecord()
         Dim frm As companyboxesfrm
         frm = New companyboxesfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(520))
      End If
   End Sub
#End Region
#Region "Index Changes"
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
#End Region
#Region "Got Focus"
   Private Sub txtCompanyName_GotFocus(sender As Object, e As EventArgs) Handles txtCompanyName.GotFocus
      SetText(txtCompanyName)
   End Sub
   Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
      SetText(txtEmail)
   End Sub
   Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
      SetText(txtPhone)
   End Sub
   Private Sub txtFax_GotFocus(sender As Object, e As EventArgs) Handles txtFax.GotFocus
      SetText(txtFax)
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
   Private Sub txtPostal_GotFocus(sender As Object, e As EventArgs) Handles txtPostal.GotFocus, txtMaterial.GotFocus, txtWebsite.GotFocus, txtReplyEmail.GotFocus, txtReplyPass.GotFocus
      SetText(txtPostal)
   End Sub
   Private Sub txtMarket_GotFocus(sender As Object, e As EventArgs) Handles txtMarket.GotFocus
      SetText(txtMarket)
   End Sub
#End Region
#Region "Lost Focus"
   Private Sub txtPhone_LostFocus(sender As Object, e As EventArgs) Handles txtPhone.LostFocus
      txtPhone.Text = FormatPhone(txtPhone.Text)
   End Sub
   Private Sub txtFax_LostFocus(sender As Object, e As EventArgs) Handles txtFax.LostFocus
      txtFax.Text = FormatPhone(txtFax.Text)
   End Sub
   'Private Sub txtPostal_LostFocus(sender As Object, e As EventArgs) Handles txtPostal.LostFocus
   '   If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
   '      txtPostal.Text = FormatPostal(txtPostal.Text)
   '   End If
   'End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.co_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
      If btnNotes.Enabled <> bv Then btnNotes.Enabled = bv
      If btnAttach.Enabled <> bv Then btnAttach.Enabled = bv
      If btnImages.Enabled <> bv Then btnImages.Enabled = bv
      If btnProducts.Enabled <> bv Then btnProducts.Enabled = bv
      If btnUsers.Enabled <> bv Then btnUsers.Enabled = bv
      If btnAudit.Enabled <> bv Then btnAudit.Enabled = bv
      If btnAddress.Enabled <> bv Then btnAddress.Enabled = bv
      If btnBoxes.Enabled <> bv Then btnBoxes.Enabled = bv
   End Sub
End Class