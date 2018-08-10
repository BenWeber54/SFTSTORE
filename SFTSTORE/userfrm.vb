Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class userfrm
   Private Sub userfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(388)
      lblId.Text = Txt(516) + ":"
      lblCompany.Text = Txt(365) + ":"
      lblFirst.Text = Txt(514) + ":"
      lblLast.Text = Txt(515) + ":"
      lblAddr1.Text = Txt(505) + ":"
      lblAddr2.Text = Txt(506) + ":"
      lblCity.Text = Txt(507) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblProvince.Text = Txt(510) + ":"
      lblPostal.Text = Txt(508) + ":"
      lblPhone.Text = Txt(503) + ":"
      lblCell.Text = Txt(526) + ":"
      lblEmail.Text = Txt(364) + ":"
      lblInpLanguage.Text = Txt(527) + ":"
      lblRepLanguage.Text = Txt(528) + ":"
      lblPassStatus.Text = Txt(529) + ":"
      lblActive.Text = Txt(530) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnCopyAdd.Text = Txt(531)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnNotes.Text = Txt(384)
      btnAttach.Text = Txt(385)
      btnAccess.Text = Txt(532)
      btnAudit.Text = Txt(389)
      btnClearmr.Text = Txt(533)
      btnClose.Text = Txt(390)

      SetCboItems(cmbInpLanguage, 50, 2)
      SetCboItems(cmbRepLanguage, 50, 2)
      SetCboItems(cmbPassStatus, 38, 2)
      SetCboItems(cmbActive, 36, 2)

      If dr.USER_CTRL = 1 Then
         Display()
         txtId.Focus()
         btnCompany.Enabled = False
         btnOpen.Enabled = False
         btnRecent.Enabled = False
      Else
         Inits()
      End If
   End Sub
   Private Sub Inits()
      cmbCountry.Items.Clear()
      SetCboItems(cmbCountry, 300, 2)
      InitUser(dr)
      If dr.USER_CTRL = 1 Then
         dr.uu_COM_COMPANY = dr.co_iid
      Else
         InitCompany(dr)
      End If
      Display()
      txtId.Focus()
   End Sub
   Private Sub Display()
      Dim tstr1$, tNOTES$, tAUDIT$, tATTACHMENTS$
      cmbProvince.Items.Clear()
      If dr.uu_iCountry = 1 Then
         lblPostal.Text = Txt(508) + ":"
         lblProvince.Text = Txt(510) + ":"
         SetCboItems(cmbProvince, 100, 13)
      Else
         lblPostal.Text = Txt(513) + ":"
         lblProvince.Text = Txt(512) + ":"
         SetCboItems(cmbProvince, 150, 50)
      End If
      SetCboIndex(cmbCountry, dr.uu_iCountry)
      SetCboIndex(cmbProvince, dr.uu_iProvince)
      SetCboIndex(cmbInpLanguage, dr.uu_iLanguage)
      SetCboIndex(cmbRepLanguage, dr.uu_iRlanguage)
      SetCboIndex(cmbPassStatus, dr.uu_iPasswordFlag)
      SetCboIndex(cmbActive, dr.uu_iActive)

      txtId.Text = dr.uu_szId
      txtFirst.Text = dr.uu_szFirst
      txtLast.Text = dr.uu_szLast
      txtAddr1.Text = dr.uu_szAddr1
      txtAddr2.Text = dr.uu_szAddr2
      txtCity.Text = dr.uu_szCity
      txtPostal.Text = dr.uu_szPostal
      txtPhone.Text = dr.uu_szPhone
      txtCell.Text = dr.uu_szCell
      txtEmail.Text = dr.uu_szEmail
      txtCompany.Text = dr.uu_szCompany

      tstr1 = Txt(388)
      If dr.uu_iid = 0 Then
         tstr1 += " (New)"
      Else
         tstr1 += " (Key: " + CStr(dr.uu_iid) + ")"
      End If

      If tstr1 <> Me.Text Then Me.Text = tstr1

      tNOTES = Txt(384)
      tAUDIT = Txt(389)
      tATTACHMENTS = Txt(385)

      If dr.uu_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "USER_GET_INFO " + CStr(dr.uu_iid) + ""
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
         End If
         dr.oread.Close()
      End If

      If btnNotes.Text <> tNOTES Then btnNotes.Text = tNOTES
      If btnAudit.Text <> tAUDIT Then btnAudit.Text = tAUDIT
      If btnAttach.Text <> tATTACHMENTS Then btnAttach.Text = tATTACHMENTS
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.uu_szId = "" Then
         txtId.Focus()
         MsgDsp(Txt(521))
         Exit Function
      End If
      If Len(dr.uu_szId) < 4 Then
         txtId.Focus()
         MsgDsp(Txt(522))
         Exit Function
      End If
      If dr.uu_szFirst = "" Then
         txtFirst.Focus()
         MsgDsp(Txt(523))
         Exit Function
      End If
      If dr.uu_szLast = "" Then
         txtLast.Focus()
         MsgDsp(Txt(524))
         Exit Function
      End If
      If dr.uu_szPostal <> "" Then
         If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
            If isValidCode(dr.uu_szPostal, CANADA) = False Then
               txtPostal.Focus()
               MsgDsp(Txt(749))
               Exit Function
            End If
         Else
            If isValidCode(dr.uu_szPostal, USA) = False Then
               txtPostal.Focus()
               MsgDsp(Txt(750))
               Exit Function
            End If
         End If
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT uu_iid FROM USR_USER WHERE uu_szId = '" + AStr(dr.uu_szId) + "'"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("uu_iid") <> dr.uu_iid Then
            MsgDsp(Txt(525))
            txtId.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.uu_szId = Trim(txtId.Text)
      dr.uu_szFirst = Trim(txtFirst.Text)
      dr.uu_szLast = Trim(txtLast.Text)
      dr.uu_szAddr1 = Trim(txtAddr1.Text)
      dr.uu_szAddr2 = Trim(txtAddr2.Text)
      dr.uu_szCity = Trim(txtCity.Text)
      dr.uu_szPostal = Trim(txtPostal.Text).ToUpper.Replace(" ", "")
      dr.uu_szPhone = Trim(txtPhone.Text)
      dr.uu_szCell = Trim(txtCell.Text)
      dr.uu_szEmail = Trim(txtEmail.Text)
      dr.uu_iLanguage = CType(cmbInpLanguage.SelectedItem, ComboClass).Value
      dr.uu_iRlanguage = CType(cmbRepLanguage.SelectedItem, ComboClass).Value
      dr.uu_iPasswordFlag = CType(cmbPassStatus.SelectedItem, ComboClass).Value
      dr.uu_iProvince = CType(cmbProvince.SelectedItem, ComboClass).Value
      dr.uu_iCountry = CType(cmbCountry.SelectedItem, ComboClass).Value
      dr.uu_iActive = CType(cmbActive.SelectedItem, ComboClass).Value
   End Sub
#Region "Click events"
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1&
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.uu_iid
      UpdateUserRecord(dr)
      AddMostrecent(MR_USER, dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
      dr.LIST_CTRL = 1
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         ScreenToRecord()
         dr.uu_COM_COMPANY = dr.co_iid
         dr.uu_szCompany = dr.co_szCompanyName
         Display()
         AddMostrecent(MR_COMPANY, dr)
      End If
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Inits()
   End Sub
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 6
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtFirst.Focus()
         AddMostrecent(MR_USER, dr)
      End If
   End Sub
   Private Sub btnRecent_Click(sender As Object, e As EventArgs) Handles btnRecent.Click
MostRecentRestart:
      dr.mr_iType = MR_USER
      dr.LIST_CTRL = 2
      OpenMostRecent(dr)
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetUserRecord(dr.LIST_KEY, dr)
         If dr.LIST_KEY = dr.uu_iid Then
            Display()
            txtFirst.Focus()
            AddMostrecent(MR_USER, dr)
         Else
            RemoveMostRecent(MR_USER, dr.LIST_KEY, dr)
            MsgDsp(Txt(366))
            GoTo MostRecentRestart
         End If
      End If
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM USR_USER WHERE uu_iid = " + CStr(dr.uu_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM NOT_NOTES WHERE no_iKey = " + CStr(dr.uu_iid) + " and no_iType = " + CStr(NOTE_USER), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
      If InStr(btnAudit.Text, "(") > 0 Then
         GenerateAudit(AUDIT_USER, dr.uu_iid)
      Else
         MsgDsp(Txt(361))
      End If
   End Sub
   Private Sub btnClearmr_Click(sender As Object, e As EventArgs) Handles btnClearmr.Click
      Dim tstr1$
      If MsgBox(Txt(517), vbYesNo) = vbYes Then
         tstr1 = ""
         ExecuteScalar(dr.szConnection, "DELETE FROM USR_MOSTRECENT WHERE um_USR_USER = " + CStr(dr.uu_iid), tstr1)
         MsgDsp(Txt(518))
      End If
   End Sub
   Private Sub btnCopyAdd_Click(sender As Object, e As EventArgs) Handles btnCopyAdd.Click
      ScreenToRecord()
      GetCompanyRecord(dr.uu_COM_COMPANY, dr)
      dr.uu_szAddr1 = dr.co_szAddr1
      dr.uu_szAddr2 = dr.co_szAddr2
      dr.uu_szCity = dr.co_szCity
      dr.uu_iProvince = dr.co_iProvince
      dr.uu_szPostal = dr.co_szPostal
      dr.uu_szPhone = dr.co_szPhone
      dr.uu_iCountry = dr.co_iCountry
      Display()
   End Sub
   Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
      If dr.uu_iid > 0 Then
         dr.NOTES_TYPE = NOTE_USER
         dr.NOTES_KEY = dr.uu_iid
         ScreenToRecord()
         Dim frm As notes
         frm = New notes
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(519))
      End If
   End Sub
   Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
      If dr.uu_iid > 0 Then
         dr.ATTACHMENT_TYPE = ATTACHMENT_USER
         dr.ATTACHMENT_KEY = dr.uu_iid
         ScreenToRecord()
         Dim frm As attachments
         frm = New attachments
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(519))
      End If
   End Sub
   Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click
      If dr.uu_iid > 0 Then
         ScreenToRecord()
         Dim frm As users_rights
         frm = New users_rights
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(519))
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
   Private Sub txtId_GotFocus(sender As Object, e As EventArgs) Handles txtId.GotFocus
      SetText(txtId)
   End Sub
   Private Sub txtFirst_GotFocus(sender As Object, e As EventArgs) Handles txtFirst.GotFocus
      SetText(txtFirst)
   End Sub
   Private Sub txtLast_GotFocus(sender As Object, e As EventArgs) Handles txtLast.GotFocus
      SetText(txtLast)
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
   Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
      SetText(txtPhone)
   End Sub
   Private Sub txtCell_GotFocus(sender As Object, e As EventArgs) Handles txtCell.GotFocus
      SetText(txtCell)
   End Sub
   Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
      SetText(txtEmail)
   End Sub
#End Region
#Region "Lost Focus"
   Private Sub txtPhone_LostFocus(sender As Object, e As EventArgs) Handles txtPhone.LostFocus
      txtPhone.Text = FormatPhone(txtPhone.Text)
   End Sub
   Private Sub txtCell_LostFocus(sender As Object, e As EventArgs) Handles txtCell.LostFocus
      txtCell.Text = FormatPhone(txtCell.Text)
   End Sub
   'Private Sub txtPostal_LostFocus(sender As Object, e As EventArgs) Handles txtPostal.LostFocus
   '   If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
   '      txtPostal.Text = FormatPostal(txtPostal.Text)
   '   End If
   'End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.uu_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnCopyAdd.Enabled <> bv Then btnCopyAdd.Enabled = bv
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
      If btnNotes.Enabled <> bv Then btnNotes.Enabled = bv
      If btnAttach.Enabled <> bv Then btnAttach.Enabled = bv
      If btnAccess.Enabled <> bv Then btnAccess.Enabled = bv
      If btnAudit.Enabled <> bv Then btnAudit.Enabled = bv
      If btnClearmr.Enabled <> bv Then btnClearmr.Enabled = bv
   End Sub
End Class