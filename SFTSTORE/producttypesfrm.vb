Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class producttypesfrm
   Private Sub producttypesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(548)
      lblName.Text = Txt(573) + ":"
      lblSpecial.Text = Txt(574) + ":"
      lblSpecPrice.Text = Txt(575) + ":"
      lblSpecDesc.Text = Txt(576) + ":"
      lblStart.Text = Txt(826) + ":"
      lblEnd.Text = Txt(827) + ":"

      lblId.Text = Txt(232) + ":"
      lblSubName.Text = Txt(573) + ":"

      btnNew.Text = Txt(379)
      btnOpen.Text = Txt(380)
      btnSave.Text = Txt(382)
      btnDelete.Text = Txt(383)
      btnClose.Text = Txt(390)

      btnSubNew.Text = Txt(379)
      btnSubOpen.Text = Txt(380)
      btnSubSave.Text = Txt(382)
      btnSubDelete.Text = Txt(383)
      btnSubClose.Text = Txt(390)

      Inits()
   End Sub
   Private Sub Inits()
      InitProductType(dr)
      InitProductSubType(dr)
      Display()
   End Sub
   Private Sub Display()
      txtType.Text = dr.pt_szTypeName
      If dr.pt_iSpecial = 1 Then
         chkSpecial.Checked = False
      Else
         chkSpecial.Checked = True
      End If
      txtSpecPercent.Text = dr.pt_rSpecialPercent
      txtSpecDesc.Text = dr.pt_szSpecialDesc
      If dr.ps_iid > 0 Then
         txtId.Text = dr.ps_iid
      Else
         txtId.Text = "(New)"
      End If
      txtSubName.Text = dr.ps_szName
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.pt_szTypeName = "" Then
         txtType.Focus()
         MsgDsp(Txt(577))
         Exit Function
      End If
      If dr.pt_iSpecial = 2 Then
         If dr.pt_rSpecialPercent <= 0 Then
            txtSpecPercent.Focus()
            MsgDsp(Txt(578))
            Exit Function
         End If
      End If
      TestConnection()
      dr.ocmd.CommandText = "SELECT pt_iid FROM PRO_TYPE WHERE pt_szTypeName = '" + AStr(dr.pt_szTypeName) + "' AND pt_COM_COMPANY = " + CStr(dr.sr_iCompany)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.oread("pt_iid") <> dr.pt_iid Then
            MsgDsp(Txt(579))
            txtType.Focus()
            Exit Function
         End If
      End If
      dr.oread.Close()
      If dr.pt_iSpecial = 2 Then
         If dr.pt_dSpecialStart > dr.pt_dSpecialEnd Then
            dpStart.Focus()
            MsgDsp(Txt(828))
            Exit Function
         End If
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.pt_szTypeName = Trim(txtType.Text)
      If chkSpecial.Checked = True Then
         dr.pt_iSpecial = 2
         dr.pt_dSpecialStart = dpStart.Value
         dr.pt_dSpecialEnd = dpEnd.Value
      Else
         dr.pt_iSpecial = 1
      End If
      dr.pt_szSpecialDesc = Trim(txtSpecDesc.Text)
      dr.pt_rSpecialPercent = GetFloat(txtSpecPercent.Text)
   End Sub
#Region "Click Events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      InitProductType(dr)
      Display()
   End Sub
   Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM PRO_TYPE WHERE pt_iid = " + CStr(dr.pt_iid), tstr1)
         InitProductType(dr)
         Display()
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.pt_iid
      UpdateProductTypeRecord(dr)

      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Display()
   End Sub
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      dr.LIST_CTRL = 10
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
         txtType.Focus()
      End If
   End Sub
   Private Sub btnSubClose_Click(sender As Object, e As EventArgs) Handles btnSubClose.Click
      Me.Close()
   End Sub
   Private Sub btnSubDelete_Click(sender As Object, e As EventArgs) Handles btnSubDelete.Click
      If dr.pt_iid > 0 Then
         If dr.ps_iid > 0 Then
            Dim tstr1$ = ""
            If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
               ExecuteScalar(dr.szConnection, "DELETE FROM PRO_SUB_TYPE WHERE ps_iid = " + CStr(dr.ps_iid), tstr1)
               ExecuteScalar(dr.szConnection, "DELETE FROM PRO_PRODUCT_TYPES WHERE py_PRO_SUB_TYPE = " + CStr(dr.ps_iid), tstr1)
               InitProductSubType(dr)
               Display()
               MsgDsp(Txt(355))
            End If
         Else
            MsgDsp(Txt(885))
         End If
      Else
         MsgDsp(Txt(536))
      End If
   End Sub

   Private Sub btnSubSave_Click(sender As Object, e As EventArgs) Handles btnSubSave.Click
      If dr.pt_iid > 0 Then
         dr.ps_szName = Trim(txtSubName.Text)
         dr.ps_PRO_TYPE = dr.pt_iid
         If dr.ps_szName = "" Then
            MsgDsp(Txt(577))
            txtSubName.Focus()
            Exit Sub
         Else
            TestConnection()
            dr.ocmd.CommandText = "SELECT ps_iid FROM PRO_SUB_TYPE WHERE ps_PRO_TYPE = " + CStr(dr.pt_iid) + " AND ps_szName = '" + AStr(dr.ps_szName) + "' AND ps_iid <> " + CStr(dr.ps_iid)
            dr.oread = dr.ocmd.ExecuteReader
            If dr.oread.HasRows = True Then
               MsgDsp(Txt(887))
               txtSubName.Focus()
               dr.oread.Close()
               Exit Sub
            End If
            dr.oread.Close()
         End If
         Dim tl1& = dr.ps_iid
         UpdateProductSubTypeRecord(dr)
         If tl1 = 0 Then
            MsgDsp(Txt(359))
         Else
            MsgDsp(Txt(360))
         End If
         Display()
      Else
         MsgDsp(Txt(536))
      End If
   End Sub

   Private Sub btnSubOpen_Click(sender As Object, e As EventArgs) Handles btnSubOpen.Click
      If dr.pt_iid > 0 Then
         dr.LIST_CTRL = 30
         Dim frm As listfrm
         frm = New listfrm
         frm.ShowDialog()
         If dr.LIST_RET = 1 Then
            Display()
            txtSubName.Focus()
         End If
      Else
         MsgDsp(Txt(536))
      End If
   End Sub

   Private Sub btnSubNew_Click(sender As Object, e As EventArgs) Handles btnSubNew.Click
      InitProductSubType(dr)
      Display()
   End Sub
#End Region
#Region "Got Focus"
   Private Sub txtId_GotFocus(sender As Object, e As EventArgs)
      SetText(txtType)
   End Sub
   Private Sub txtSpecPercent_GotFocus(sender As Object, e As EventArgs)
      SetText(txtSpecPercent)
   End Sub
#End Region
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.pt_iid > 0 Then
         bv = True
      Else
         bv = False
      End If
      If btnDelete.Enabled <> bv Then btnDelete.Enabled = bv

      If btnSubOpen.Enabled <> bv Then btnSubOpen.Enabled = bv
      If btnSubNew.Enabled <> bv Then btnSubNew.Enabled = bv
      If btnSubSave.Enabled <> bv Then btnSubSave.Enabled = bv
      If btnSubDelete.Enabled <> bv Then btnSubDelete.Enabled = bv
   End Sub

   Private Sub chkSpecial_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecial.CheckedChanged
      If chkSpecial.Checked = True Then
         lblSpecPrice.Visible = True
         lblSpecDesc.Visible = True
         txtSpecPercent.Visible = True
         txtSpecDesc.Visible = True
         lblStart.Visible = True
         lblEnd.Visible = True
         dpStart.Visible = True
         dpEnd.Visible = True
      Else
         lblSpecPrice.Visible = False
         lblSpecDesc.Visible = False
         txtSpecPercent.Visible = False
         txtSpecDesc.Visible = False
         lblStart.Visible = False
         lblEnd.Visible = False
         dpStart.Visible = False
         dpEnd.Visible = False
      End If
   End Sub

   Private Sub tb1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tb1.DrawItem
      Dim g As Graphics = e.Graphics
      If e.Index = tb1.SelectedIndex Then
         Dim b As New SolidBrush(Color.LightBlue)
         Dim f As Font = New Font(e.Font, FontStyle.Bold)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb1.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      Else
         Dim b As New SolidBrush(Me.tb1.BackColor)
         Dim f As Font = New Font(e.Font, FontStyle.Regular)
         g.FillRectangle(b, e.Bounds)
         b.Color = Color.Black
         g.DrawString(Me.tb1.TabPages(e.Index).Text, f, b, e.Bounds.X + 2, e.Bounds.Y + 2)
      End If
   End Sub
End Class