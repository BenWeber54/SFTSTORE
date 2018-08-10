Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class promocodesfrm
   Private Sub promocodesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(865)

      lblType.Text = Txt(612) + ":"
      lblDiscountType.Text = Txt(801) + ":"
      lblDiscount.Text = Txt(861) + ":"
      lblTotalNeeded.Text = Txt(870) + ":"
      lblReason.Text = Txt(862) + ":"
      lblStart.Text = Txt(863) + ":"
      lblEnd.Text = Txt(864) + ":"
      lblCode.Text = Txt(875) + ":"
      lblMinNeeded.Text = Txt(876) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)

      cmbType.Items.Add(New ComboClass(0, Txt(868)))
      cmbType.Items.Add(New ComboClass(1, Txt(869)))

      cmbDiscountType.Items.Add(New ComboClass(0, Txt(866)))
      cmbDiscountType.Items.Add(New ComboClass(1, Txt(867)))

      inits()
   End Sub
   Private Sub inits()
      InitPromoCodes(dr)
      Display()
   End Sub
   Private Sub Display()
      Dim tSWT& = 0
      SetCboIndex(cmbType, dr.po_iType)
      SetCboIndex(cmbDiscountType, dr.po_iDiscountType)
      txtDiscount.Text = dr.po_rDiscount
      txtTotalNeeded.Text = dr.po_rTotalNeeded
      txtReason.Text = dr.po_szDiscount
      dpStart.Value = dr.po_dStart
      dpEnd.Value = dr.po_dEnd
      txtCode.Text = dr.po_szCode
      If dr.po_iMinNeeded = 0 Then
         chkMinNeeded.Checked = False
      Else
         chkMinNeeded.Checked = True
      End If
      If dr.po_iid > 0 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT oo_iid FROM ORD_ORDERS WHERE oo_PRM_CODES = " + CStr(dr.po_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            cmbDiscountType.Enabled = False
            cmbType.Enabled = False
            txtDiscount.Enabled = False
            tSWT = 0
         Else
            tSWT = 1
            cmbDiscountType.Enabled = True
            cmbType.Enabled = True
            txtDiscount.Enabled = True
         End If
         dr.oread.Close()

         If tSWT = 1 Then
            TestConnection()
            dr.ocmd.CommandText = "SELECT iv_iid FROM INV_INVOICE WHERE iv_PRM_CODES = " + CStr(dr.po_iid)
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               cmbDiscountType.Enabled = False
               cmbType.Enabled = False
               txtDiscount.Enabled = False
            Else
               cmbDiscountType.Enabled = True
               cmbType.Enabled = True
               txtDiscount.Enabled = True
            End If
            dr.oread.Close()
         End If
      Else
         cmbDiscountType.Enabled = True
         cmbType.Enabled = True
         txtDiscount.Enabled = True
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.po_szCode = "" Then
         MsgDsp(Txt(871))
         txtCode.Focus()
         Exit Function
      End If

      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRM_CODES WHERE po_szCode = '" + CStr(dr.po_szCode) + "' AND po_COM_COMPANY = " + CStr(dr.sr_iCompany) + " AND po_iid <> " + CStr(dr.po_iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         MsgDsp(Txt(874))
         txtReason.Focus()
         dr.oread.Close()
         Exit Function
      End If
      dr.oread.Close()

      If dr.po_rDiscount <= 0 Then
         MsgDsp(Txt(871))
         txtDiscount.Focus()
         Exit Function
      End If

      If dr.po_rTotalNeeded < 0 Then
         MsgDsp(Txt(872))
         txtTotalNeeded.Focus()
         Exit Function
      End If

      If dr.po_szDiscount = "" Then
         MsgDsp(Txt(873))
         txtReason.Focus()
         Exit Function
      End If

      If dr.po_dStart > dr.po_dEnd Then
         MsgDsp(Txt(828))
         dpStart.Focus()
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.po_iType = CType(cmbType.SelectedItem, ComboClass).Value
      dr.po_iDiscountType = CType(cmbDiscountType.SelectedItem, ComboClass).Value
      dr.po_rDiscount = GetFloat(txtDiscount.Text)
      dr.po_rTotalNeeded = GetFloat(txtTotalNeeded.Text)
      dr.po_szDiscount = Trim(txtReason.Text)
      dr.po_dStart = dpStart.Value
      dr.po_dEnd = dpEnd.Value
      dr.po_szCode = Trim(txtCode.Text).ToUpper()
      If chkMinNeeded.Checked = True Then
         dr.po_iMinNeeded = 1
      Else
         dr.po_iMinNeeded = 0
      End If
   End Sub
   Private Sub bnew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      inits()
      cmbType.Focus()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub

   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.po_iid = 0 Then
         bv = True
         If btnDelete.Enabled <> False Then btnDelete.Enabled = False
      Else
         bv = False
         If btnDelete.Enabled <> True Then btnDelete.Enabled = True
      End If

      'If cmbType.Enabled <> bv Then cmbType.Enabled = bv
      'If cmbDiscountType.Enabled <> bv Then cmbDiscountType.Enabled = bv
      'If txtDiscount.Enabled <> bv Then txtDiscount.Enabled = bv
   End Sub

   Private Sub bopen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 29
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub

   Private Sub bsave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then Exit Sub
      tl1 = dr.po_iid
      UpdatePromoCodesRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
   End Sub

   Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT oo_iid FROM ORD_ORDERS WHERE oo_PRM_CODES = " + CStr(dr.po_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Close()
            MsgDsp(Txt(881))
            Exit Sub
         End If
         dr.oread.Close()

         TestConnection()
         dr.ocmd.CommandText = "SELECT iv_iid FROM INV_INVOICE WHERE iv_PRM_CODES = " + CStr(dr.po_iid)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Close()
            MsgDsp(Txt(882))
            Exit Sub
         End If
         dr.oread.Close()

         ExecuteScalar(dr.szConnection, "DELETE FROM PRM_CODES WHERE po_iid = " + CStr(dr.po_iid), tstr1)
         bnew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub

   Private Sub chkMinNeeded_CheckedChanged(sender As Object, e As EventArgs) Handles chkMinNeeded.CheckedChanged
      If chkMinNeeded.Checked = True Then
         txtTotalNeeded.Visible = True
         lblTotalNeeded.Visible = True
      Else
         txtTotalNeeded.Visible = False
         lblTotalNeeded.Visible = False
      End If
   End Sub

   Private Sub cmbDiscountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiscountType.SelectedIndexChanged
      If CType(cmbDiscountType.SelectedItem, ComboClass).Value = 0 Then
         lblMinNeeded.Visible = True
         chkMinNeeded.Visible = True
         If chkMinNeeded.Checked = True Then
            lblTotalNeeded.Visible = True
            txtTotalNeeded.Visible = True
         End If
      Else
         lblMinNeeded.Visible = False
         lblTotalNeeded.Visible = False
         chkMinNeeded.Visible = False
         txtTotalNeeded.Visible = False
         chkMinNeeded.Checked = False
      End If
   End Sub
End Class