Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class customeraddressfrm
   Private Sub customeraddressfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(597)
      lblTitle.Text = Txt(598) + ":"
      lblName.Text = Txt(599) + ":"
      lblAdd1.Text = Txt(505) + ":"
      lblAdd2.Text = Txt(506) + ":"
      lblCountry.Text = Txt(511) + ":"
      lblProvince.Text = Txt(510) + ":"
      lblCity.Text = Txt(507) + ":"
      lblPostal.Text = Txt(508) + ":"
      lblMain.Text = Txt(600) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)
      SetCboItems(cmbCountry, 300, 2)

      Inits()
   End Sub
   Private Sub Inits()
      InitCustomerAddress(dr)
      Display()
   End Sub
   Private Sub Display()
      cmbProvince.Items.Clear()
      If dr.ca_iCountry = 1 Then
         lblPostal.Text = Txt(508) + ":"
         lblProvince.Text = Txt(510) + ":"
         SetCboItems(cmbProvince, 100, 13)
      Else
         lblPostal.Text = Txt(513) + ":"
         lblProvince.Text = Txt(512) + ":"
         SetCboItems(cmbProvince, 150, 50)
      End If
      SetCboIndex(cmbCountry, dr.ca_iCountry)
      SetCboIndex(cmbProvince, dr.ca_iProvince)

      txtTitle.Text = dr.ca_szTitle
      txtName.Text = dr.ca_szName
      txtAddr1.Text = dr.ca_szAddr1
      txtAddr2.Text = dr.ca_szAddr2
      txtCity.Text = dr.ca_szCity
      txtPostal.Text = dr.ca_szPostal
      If dr.ca_iMain = 1 Then
         chkMain.Checked = False
      Else
         chkMain.Checked = True
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.ca_szTitle = "" Then
         txtTitle.Focus()
         MsgDsp(Txt(592))
         Exit Function
      End If
      If dr.ca_szName = "" Then
         txtName.Focus()
         MsgDsp(Txt(596))
         Exit Function
      End If
      If dr.ca_szAddr1 = "" Then
         txtAddr1.Focus()
         MsgDsp(Txt(593))
         Exit Function
      End If
      If dr.ca_szCity = "" Then
         txtCity.Focus()
         MsgDsp(Txt(594))
         Exit Function
      End If
      If dr.ca_szPostal = "" Then
         txtPostal.Focus()
         MsgDsp(Txt(595))
         Exit Function
      End If
      If CType(cmbCountry.SelectedItem, ComboClass).Value = 1 Then
         If isValidCode(dr.ca_szPostal, CANADA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(749))
            Exit Function
         End If
      Else
         If isValidCode(dr.ca_szPostal, USA) = False Then
            txtPostal.Focus()
            MsgDsp(Txt(750))
            Exit Function
         End If
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT ca_iid FROM CUS_ADDRESS WHERE ca_szTitle = '" + AStr(dr.ca_szTitle) + "' AND ca_CUS_CUSTOMER = " + CStr(dr.cu_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.ca_iid <> dr.oread("ca_iid") Then
            MsgDsp(Txt(591))
            txtTitle.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()

      If dr.ca_iMain = 2 Then
         Dim strSQL$ = "", RStr$ = ""
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM CUS_ADDRESS WHERE ca_iMain = 2 AND ca_CUS_CUSTOMER = " + CStr(dr.cu_iid) + " AND ca_iid <> " + CStr(dr.ca_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If MsgBox(Txt(601), vbYesNo, Txt(563)) = MsgBoxResult.Yes Then
               strSQL = "CUSTOMER_ADDRESS_UPDATE "
               strSQL += CStr(dr.oread("ca_iid")) + ", "
               strSQL += "'" + Format(dr.oread("ca_dDate"), "dd/MMM/yyyy HH:mm:ss") + "', "
               strSQL += "'" + Format(Now, "dd/MMM/yyyy HH:mm:ss") + "', "
               strSQL += CStr(dr.oread("ca_CUS_CUSTOMER")) + ", "
               strSQL += "'" + AStr(dr.oread("ca_szName")) + "',"
               strSQL += CStr(1) + ", "
               strSQL += "'" + AStr(dr.oread("ca_szAddr1")) + "',"
               strSQL += "'" + AStr(dr.oread("ca_szAddr2")) + "',"
               strSQL += CStr(dr.oread("ca_iCountry")) + ","
               strSQL += CStr(dr.oread("ca_iProvince")) + ","
               strSQL += "'" + AStr(dr.oread("ca_szCity")) + "',"
               strSQL += "'" + AStr(dr.oread("ca_szPostal")) + "',"
               strSQL += "'" + AStr(dr.oread("ca_szTitle")) + "'"

               ExecuteScalar(dr.szConnection, strSQL, RStr)
            Else
               MsgDsp(Txt(564))
               dr.oread.Close()
               Exit Function
            End If
         End If
         dr.oread.Close()
      End If
     
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.ca_szTitle = Trim(txtTitle.Text)
      dr.ca_szName = Trim(txtName.Text)
      dr.ca_szAddr1 = Trim(txtAddr1.Text)
      dr.ca_szAddr2 = Trim(txtAddr2.Text)
      dr.ca_iCountry = CType(cmbCountry.SelectedItem, ComboClass).Value
      dr.ca_iProvince = CType(cmbProvince.SelectedItem, ComboClass).Value
      dr.ca_szCity = Trim(txtCity.Text)
      dr.ca_szPostal = Trim(txtPostal.Text).ToUpper.Replace(" ", "")
      If chkMain.Checked = True Then
         dr.ca_iMain = 2
      Else
         dr.ca_iMain = 1
      End If
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
         ExecuteScalar(dr.szConnection, "DELETE FROM CUS_ADDRESS WHERE ca_iid = " + CStr(dr.ca_iid), tstr1)
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
      tl1 = dr.ca_iid
      UpdateCustomerAddressRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 12
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
      If dr.ca_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv
   End Sub
End Class