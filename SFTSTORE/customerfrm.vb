Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class customerfrm
   Private Sub customerfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(618)
      lblId.Text = Txt(589) + ":"
      lblFirst.Text = Txt(514) + ":"
      lblLast.Text = Txt(515) + ":"
      lblEmail.Text = Txt(364) + ":"
      lblLanguage.Text = Txt(527) + ":"
      lblPassStatus.Text = Txt(529) + ":"
      lblActive.Text = Txt(587) + ":"
      lblVerified.Text = Txt(588) + ":"
      lblNotes.Text = Txt(384) + ":"
      lblDisplay.Text = Txt(663) + ":"
      lblActCode.Text = Txt(891) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnRecent.Text = Txt(370)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnAddress.Text = Txt(580)
      btnWish.Text = Txt(581)
      btnNotes.Text = Txt(384)
      btnAttach.Text = Txt(385)
      btnAudit.Text = Txt(389)
      btnClose.Text = Txt(390)
      btnFeedback.Text = Txt(669)
      btnBilling.Text = Txt(703)

      SetCboItems(cmbActive, 36, 2)
      SetCboItems(cmbLanguage, 50, 2)
      SetCboItems(cmbPassStatus, 38, 2)
      SetCboItems(cmbVerified, 34, 2)

      Inits()
   End Sub
   Private Sub Inits()
      InitCustomer(dr)
      Display()
   End Sub
   Private Sub Display()
      Dim tNOTES$ = "", tAUDIT$ = "", tATTACHMENTS$ = "", tADDRESS$ = "", tWISHLIST$ = "", tFEEDBACK$ = "", tBILLING$ = ""
      txtId.Text = dr.cu_szId
      txtFirst.Text = dr.cu_szFirst
      txtLast.Text = dr.cu_szLast
      txtEmail.Text = dr.cu_szEmail
      txtNotes.Text = dr.cu_szNotes
      txtDisplay.Text = dr.cu_szDisplay
      txtActCode.Text = dr.cu_szActivationCode

      SetCboIndex(cmbLanguage, dr.cu_iLanguage)
      SetCboIndex(cmbPassStatus, dr.cu_iPasswordFlag)
      SetCboIndex(cmbActive, dr.cu_iActive)
      SetCboIndex(cmbVerified, dr.cu_iVerified)

      tNOTES = Txt(384)
      tAUDIT = Txt(389)
      tATTACHMENTS = Txt(385)
      tADDRESS = Txt(580)
      tWISHLIST = Txt(581)
      tFEEDBACK = Txt(669)
      tBILLING = Txt(703)

      If dr.cu_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "CUSTOMER_GET_INFO " + CStr(dr.cu_iid) + ""
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
               tADDRESS += " (" + CStr(dr.oread(4)) + ")"
            End If
            If dr.oread(5) <> 0 Then
               tWISHLIST += " (" + CStr(dr.oread(5)) + ")"
            End If
            If dr.oread(6) <> 0 Then
               tFEEDBACK += " (" + CStr(dr.oread(6)) + ")"
            End If
            If dr.oread(7) <> 0 Then
               tBILLING += " (" + CStr(dr.oread(7)) + ")"
            End If
         End If
         dr.oread.Close()
      End If

      If btnNotes.Text <> tNOTES Then btnNotes.Text = tNOTES
      If btnAudit.Text <> tAUDIT Then btnAudit.Text = tAUDIT
      If btnAttach.Text <> tATTACHMENTS Then btnAttach.Text = tATTACHMENTS
      If btnAddress.Text <> tADDRESS Then btnAddress.Text = tADDRESS
      If btnWish.Text <> tWISHLIST Then btnWish.Text = tWISHLIST
      If btnFeedback.Text <> tFEEDBACK Then btnFeedback.Text = tFEEDBACK
      If btnBilling.Text <> tBILLING Then btnBilling.Text = tBILLING
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.cu_szId = "" Then
         txtId.Focus()
         MsgDsp(Txt(582))
         Exit Function
      End If
      If Len(dr.cu_szId) < 4 Then
         txtId.Focus()
         MsgDsp(Txt(522))
         Exit Function
      End If
      If dr.cu_szDisplay = "" Then
         txtDisplay.Focus()
         MsgDsp(Txt(664))
         Exit Function
      End If
      If Len(dr.cu_szDisplay) < 4 Then
         txtDisplay.Focus()
         MsgDsp(Txt(665))
         Exit Function
      End If
      If dr.cu_szFirst = "" Then
         txtFirst.Focus()
         MsgDsp(Txt(523))
         Exit Function
      End If
      If dr.cu_szLast = "" Then
         txtLast.Focus()
         MsgDsp(Txt(524))
         Exit Function
      End If
      If dr.cu_szEmail = "" Then
         txtEmail.Focus()
         MsgDsp(Txt(590))
         Exit Function
      End If
      If dr.cu_szEmail.Contains("@") = False Or dr.cu_szEmail.Contains(".") = False Then
         txtEmail.Focus()
         MsgDsp(Txt(668))
         Exit Function
      End If

      TestConnection()
      dr.ocmd.CommandText = "SELECT cu_iid FROM CUS_CUSTOMER WHERE cu_szId = '" + AStr(dr.cu_szId) + "' AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("cu_iid") <> dr.cu_iid Then
            MsgDsp(Txt(584))
            txtId.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()

      TestConnection()
      dr.ocmd.CommandText = "SELECT cu_iid FROM CUS_CUSTOMER WHERE cu_szDisplay = '" + AStr(dr.cu_szDisplay) + "' AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("cu_iid") <> dr.cu_iid Then
            MsgDsp(Txt(666))
            txtDisplay.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()

      TestConnection()
      dr.ocmd.CommandText = "SELECT cu_iid FROM CUS_CUSTOMER WHERE cu_szEmail = '" + AStr(dr.cu_szEmail) + "' AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("cu_iid") <> dr.cu_iid Then
            MsgDsp(Txt(667))
            txtEmail.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.cu_szId = Trim(txtId.Text)
      dr.cu_szFirst = Trim(txtFirst.Text)
      dr.cu_szLast = Trim(txtLast.Text)
      dr.cu_szEmail = Trim(txtEmail.Text)
      dr.cu_iLanguage = CType(cmbLanguage.SelectedItem, ComboClass).Value
      dr.cu_iPasswordFlag = CType(cmbPassStatus.SelectedItem, ComboClass).Value
      dr.cu_iActive = CType(cmbActive.SelectedItem, ComboClass).Value
      dr.cu_iVerified = CType(cmbVerified.SelectedItem, ComboClass).Value
      dr.cu_szNotes = Trim(txtNotes.Text)
      dr.cu_szDisplay = Trim(txtDisplay.Text)
      dr.cu_szActivationCode = Trim(txtActCode.Text)
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Inits()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_CUSTOMER WHERE cu_iid = " + CStr(dr.cu_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM NOT_NOTES WHERE no_iKey = " + CStr(dr.cu_iid) + " and no_iType = " + CStr(NOTE_CUSTOMER), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_ADDRESS WHERE ca_CUS_CUSTOMER = " + CStr(dr.cu_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_WISHLIST WHERE cw_CUS_CUSTOMER = " + CStr(dr.cu_iid), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM ATT_ATTACHMENTS WHERE at_iKey = " + CStr(dr.cu_iid) + " AND at_iType = " + CStr(ATTACHMENT_CUSTOMER), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM AUD_AUDIT WHERE aa_iKey = " + CStr(dr.cu_iid) + " AND aa_iType = " + CStr(AUDIT_CUSTOMER), tstr1)
         ExecuteScalar(dr.szConnection, "DELETE FROM PRO_FEEDBACK WHERE pf_CUS_CUSTOMER = " + CStr(dr.cu_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnRecent_Click(sender As Object, e As EventArgs) Handles btnRecent.Click
MostRecentRestart:
      dr.mr_iType = MR_CUSTOMER
      dr.LIST_CTRL = 2
      OpenMostRecent(dr)
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         GetCustomerRecord(dr.LIST_KEY, dr)
         If dr.LIST_KEY = dr.cu_iid Then
            Display()
            txtId.Focus()
            AddMostrecent(MR_CUSTOMER, dr)
         Else
            RemoveMostRecent(MR_CUSTOMER, dr.LIST_KEY, dr)
            MsgDsp(Txt(366))
            GoTo MostRecentRestart
         End If
      End If
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 11
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtId.Focus()
         AddMostrecent(MR_CUSTOMER, dr)
      End If
   End Sub
   Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
      If InStr(btnAudit.Text, "(") > 0 Then
         GenerateAudit(AUDIT_CUSTOMER, dr.cu_iid)
      Else
         MsgDsp(Txt(361))
      End If
   End Sub
   Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
      If dr.cu_iid > 0 Then
         dr.ATTACHMENT_TYPE = ATTACHMENT_CUSTOMER
         dr.ATTACHMENT_KEY = dr.cu_iid
         ScreenToRecord()
         Dim frm As attachments
         frm = New attachments
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
      If dr.cu_iid > 0 Then
         dr.NOTES_TYPE = NOTE_CUSTOMER
         dr.NOTES_KEY = dr.cu_iid
         ScreenToRecord()
         Dim frm As notes
         frm = New notes
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1&
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.cu_iid
      UpdateCustomerRecord(dr)
      AddMostrecent(MR_CUSTOMER, dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
      If dr.cu_iid > 0 Then
         ScreenToRecord()
         Dim frm As customeraddressfrm
         frm = New customeraddressfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnWish_Click(sender As Object, e As EventArgs) Handles btnWish.Click
      If dr.cu_iid > 0 Then
         ScreenToRecord()
         Dim frm As customerwishlistfrm
         frm = New customerwishlistfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
      If dr.cu_iid > 0 Then
         ScreenToRecord()
         dr.FRMSWT = 2
         Dim frm As productfeedbackfrm
         frm = New productfeedbackfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
   Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
      If dr.cu_iid > 0 Then
         ScreenToRecord()
         Dim frm As customerbillingfrm
         frm = New customerbillingfrm
         frm.ShowDialog()
         Display()
      Else
         MsgDsp(Txt(586))
      End If
   End Sub
#End Region
#Region "Got Focus"
   Private Sub txtId_GotFocus(sender As Object, e As EventArgs) Handles txtId.GotFocus
      SetText(txtId)
   End Sub
   Private Sub txtFirst_GotFocus(sender As Object, e As EventArgs) Handles txtFirst.GotFocus, txtDisplay.GotFocus
      SetText(txtFirst)
   End Sub
   Private Sub txtLast_GotFocus(sender As Object, e As EventArgs) Handles txtLast.GotFocus
      SetText(txtLast)
   End Sub
   Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus, txtActCode.GotFocus
      SetText(txtEmail)
   End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.cu_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
      If btnAddress.Enabled <> bv Then btnAddress.Enabled = bv
      If btnWish.Enabled <> bv Then btnWish.Enabled = bv
      If btnNotes.Enabled <> bv Then btnNotes.Enabled = bv
      If btnAttach.Enabled <> bv Then btnAttach.Enabled = bv
      If btnAudit.Enabled <> bv Then btnAudit.Enabled = bv
      If btnFeedback.Enabled <> bv Then btnFeedback.Enabled = bv
      If btnBilling.Enabled <> bv Then btnBilling.Enabled = bv
   End Sub

   Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave, txtActCode.Leave
      If txtId.Text = "" Then
         txtId.Text = txtEmail.Text
      End If
   End Sub
End Class