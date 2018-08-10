Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class companyaddressfrm
   Private Sub companyaddressfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(726)
      lblTitle.Text = Txt(598) + ":"
      lblName.Text = Txt(599) + ":"
      lblAdd1.Text = Txt(505) + ":"
      lblAdd2.Text = Txt(506) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblProvince.Text = Txt(510) + ":"
      lblCity.Text = Txt(507) + ":"
      lblPostal.Text = Txt(508) + ":"
      lblShip.Text = Txt(761) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)
      SetCboItems(cmbCountry, 300, 2)

      Inits()
   End Sub
   Private Sub Inits()
      InitCompanyAddress(dr)
      Display()
   End Sub
   Private Sub Display()
      cmbProvince.Items.Clear()
      If dr.ch_iCountry = 1 Then
         lblPostal.Text = Txt(508) + ":"
         lblProvince.Text = Txt(510) + ":"
         SetCboItems(cmbProvince, 100, 13)
      Else
         lblPostal.Text = Txt(513) + ":"
         lblProvince.Text = Txt(512) + ":"
         SetCboItems(cmbProvince, 150, 50)
      End If
      SetCboIndex(cmbCountry, dr.ch_iCountry)
      SetCboIndex(cmbProvince, dr.ch_iProvince)

      If dr.ch_iShipping = 1 Then
         chkShip.Checked = False
      Else
         chkShip.Checked = True
      End If

      txtTitle.Text = dr.ch_szTitle
      txtName.Text = dr.ch_szName
      txtAddr1.Text = dr.ch_szAddr1
      txtAddr2.Text = dr.ch_szAddr2
      txtCity.Text = dr.ch_szCity
      txtPostal.Text = dr.ch_szPostal
      txtTelephone.Text = dr.ch_szTelephone


      If dr.ch_szHours <> "" Then
         Dim hours() As String = dr.ch_szHours.Split("|")
         txtMonday.Text = hours(0)
         txtTuesday.Text = hours(1)
         txtWednesday.Text = hours(2)
         txtThursday.Text = hours(3)
         txtFriday.Text = hours(4)
         txtSaturday.Text = hours(5)
         txtSunday.Text = hours(6)
      Else
         txtMonday.Text = ""
         txtTuesday.Text = ""
         txtWednesday.Text = ""
         txtThursday.Text = ""
         txtFriday.Text = ""
         txtSaturday.Text = ""
         txtSunday.Text = ""
      End If

   End Sub
   Private Function Validation()
      Validation = 0
      If dr.ch_szTitle = "" Then
         txtTitle.Focus()
         MsgDsp(Txt(592))
         Exit Function
      End If
      If dr.ch_szName = "" Then
         txtName.Focus()
         MsgDsp(Txt(596))
         Exit Function
      End If
      If dr.ch_szAddr1 = "" Then
         txtAddr1.Focus()
         MsgDsp(Txt(593))
         Exit Function
      End If
      If dr.ch_szCity = "" Then
         txtCity.Focus()
         MsgDsp(Txt(594))
         Exit Function
      End If
      If dr.ch_szPostal = "" Then
         txtPostal.Focus()
         MsgDsp(Txt(595))
         Exit Function
      End If
      If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
         If isValidCode(dr.ch_szPostal, CANADA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(749))
            Exit Function
         End If
      Else
         If isValidCode(dr.ch_szPostal, USA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(750))
            Exit Function
         End If
      End If

      If txtMonday.Text = "" Or
         txtTuesday.Text = "" Or
         txtWednesday.Text = "" Or
         txtThursday.Text = "" Or
         txtFriday.Text = "" Or
         txtSaturday.Text = "" Or
         txtSunday.Text = "" Then
         txtMonday.Focus()
         MsgDsp("Store needs hours")
         Exit Function
      End If

      TestConnection()
      dr.ocmd.CommandText = "SELECT ch_iid FROM COM_ADDRESS WHERE ch_szTitle = '" + AStr(dr.ch_szTitle) + "' AND ch_COM_COMPANY = " + CStr(dr.co_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.ch_iid <> dr.oread("ch_iid") Then
            MsgDsp(Txt(591))
            txtTitle.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()

      If dr.ch_iShipping = 2 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT ch_iid FROM COM_ADDRESS WHERE ch_iShipping = 2 AND ch_COM_COMPANY = " + CStr(dr.co_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.ch_iid <> dr.oread("ch_iid") Then
               MsgDsp(Txt(788))
               chkShip.Focus()
               Exit Function
            End If
         End If
         dr.oread.Close()
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()

      dr.ch_szTitle = Trim(txtTitle.Text)
      dr.ch_szName = Trim(txtName.Text)
      dr.ch_szAddr1 = Trim(txtAddr1.Text)
      dr.ch_szAddr2 = Trim(txtAddr2.Text)
      dr.ch_iCountry = CType(cmbCountry.SelectedItem, ComboClass).Value
      dr.ch_iProvince = CType(cmbProvince.SelectedItem, ComboClass).Value
      dr.ch_szCity = Trim(txtCity.Text)
      dr.ch_szPostal = Trim(txtPostal.Text).ToUpper().Replace(" ", "")
      dr.ch_szTelephone = Trim(txtTelephone.Text)
      If chkShip.Checked = True Then
         dr.ch_iShipping = 2
      Else
         dr.ch_iShipping = 1
      End If
      dr.ch_szHours = txtMonday.Text + "|" +
      txtTuesday.Text + "|" +
      txtWednesday.Text + "|" +
      txtThursday.Text + "|" +
      txtFriday.Text + "|" +
      txtSaturday.Text + "|" +
      txtSunday.Text + "|"
   End Sub
#Region "Click events"
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Inits()
   End Sub
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM COM_ADDRESS WHERE ch_iid = " + CStr(dr.ch_iid), tstr1)
         btnNew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1&
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.ch_iid
      UpdateCompanyAddressRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 22
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtTitle.Focus()
      End If
   End Sub
#End Region
#Region "Got Focus"
   Private Sub txtTitle_GotFocus(sender As Object, e As EventArgs) Handles txtTitle.GotFocus
      SetText(txtTitle)
   End Sub
   Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
      SetText(txtName)
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
#Region "Lost Focus"
   'Private Sub txtPostal_LostFocus(sender As Object, e As EventArgs) Handles txtPostal.LostFocus
   '   If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
   '      txtPostal.Text = FormatPostal(txtPostal.Text)
   '   End If
   'End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.ch_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
   End Sub
End Class