Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productpricefrm
   Dim oldPrice@
   Dim oldPriceId& = 0

   Private Sub editproductnumberfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(539)
      lblPrice.Text = Txt(629) + ":"
      lblStatus.Text = Txt(630) + ":"
      lblReason.Text = Txt(545) + ":"
      lblStart.Text = Txt(826) + ":"
      lblEnd.Text = Txt(827) + ":"

      btnSave.Text = Txt(382)
      btnClose.Text = Txt(390)

      If dr.FRMSWT = 1 Then
         txtReason.Visible = True
         lblReason.Visible = True
         oldPrice = dr.pr_rPrice
      Else
         lblReason.Visible = False
         txtReason.Text = False
      End If
      cmbStatus.Items.Clear()
      cmbStatus.Items.Add(New ComboClass(1, Txt(36)))
      cmbStatus.Items.Add(New ComboClass(2, Txt(37)))
      cmbStatus.Items.Add(New ComboClass(3, Txt(559)))
      inits()
   End Sub
   Private Sub inits()
      If dr.FRMSWT = 2 Then
         InitProductPrice(dr)
      Else
         InitProductPriceChanges(dr)
      End If
      Display()
   End Sub
   Private Sub Display()
      txtPrice.Text = dr.pr_rPrice
      SetCboIndex(cmbStatus, dr.pr_iStatus)
      txtReason.Text = ""
      dpStart.Value = dr.pr_dSpecialStart
      dpEnd.Value = dr.pr_dSpecialEnd
   End Sub
   Private Sub ScreenToRecord()
      dr.pr_rPrice = GetFloat(txtPrice.Text)
      dr.pr_iStatus = CType(cmbStatus.SelectedItem, ComboClass).Value
      dr.pr_PRO_PRODUCT = dr.pp_iid
      If dr.FRMSWT = 1 Then
         dr.pc_szReason = Trim(txtReason.Text)
         dr.pc_rOldPrice = oldPrice
         dr.pc_rNewPrice = GetFloat(txtPrice.Text)
         dr.pc_PRO_PRODUCT = dr.pp_iid
      End If
      If dr.pr_iStatus = 3 Then
         dr.pr_dSpecialStart = dpStart.Value
         dr.pr_dSpecialEnd = dpEnd.Value
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.pr_rPrice <= 0 Then
         txtPrice.Focus()
         MsgDsp(Txt(560))
         Exit Function
      End If
      If dr.pr_iStatus = 3 Then
         If dr.pr_dSpecialStart >= dr.pr_dSpecialEnd Then
            dpStart.Focus()
            MsgDsp(Txt(828))
            Exit Function
         End If
      End If
      If dr.pr_iStatus <> 2 Then
         TestConnection()
         dr.ocmd.CommandText = "SELECT * FROM PRO_PRICE WHERE pr_PRO_PRODUCT = " + CStr(dr.pr_PRO_PRODUCT) + " AND pr_iStatus = " + CStr(dr.pr_iStatus)
         dr.oread = dr.ocmd.ExecuteReader()
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.oread("pr_iid") <> dr.pr_iid Then
               If dr.pr_iStatus = 1 Then
                  If MsgBox(Txt(562), vbYesNo, Txt(563)) = MsgBoxResult.No Then
                     MsgDsp(Txt(564))
                     oldPriceId = 0
                     Exit Function
                  Else
                     oldPriceId = dr.oread("pr_iid")
                  End If
               ElseIf dr.pr_iStatus = 3 Then
                  If dr.pr_dSpecialStart <= dr.oread("pr_dSpecialStart") And dr.pr_dSpecialEnd <= dr.oread("pr_dSpecialStart") Then
                  ElseIf dr.pr_dSpecialStart >= dr.oread("pr_dSpecialEnd") And dr.pr_dSpecialEnd >= dr.oread("pr_dSpecialEnd") Then
                  Else
                     dpStart.Focus()
                     MsgDsp(Txt(561))
                     Exit Function
                  End If
                  'If MsgBox(Txt(561), vbYesNo, Txt(563)) = MsgBoxResult.No Then
                  '   MsgDsp(Txt(564))
                  '   oldPriceId = 0
                  '   Exit Function
                  'Else
                  '   oldPriceId = dr.oread("pr_iid")
                  'End If
               End If
            End If
         End If
         dr.oread.Close()
      End If
      Validation = 1
   End Function
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      If dr.FRMSWT = 1 Then
         UpdateProductPriceRecord(dr)
         If oldPrice <> dr.pr_rPrice Then
            UpdateProductPriceChangesRecord(dr)
         End If

         If oldPriceId <> 0 Then
            GetProductPriceRecord(oldPriceId, dr)
            If dr.pr_iid > 0 Then
               dr.pr_iStatus = 2
               UpdateProductPriceRecord(dr)
            End If
         End If
      Else
         UpdateProductPriceRecord(dr)

         If oldPriceId <> 0 Then
            GetProductPriceRecord(oldPriceId, dr)
            If dr.pr_iid > 0 Then
               dr.pr_iStatus = 2
               UpdateProductPriceRecord(dr)
            End If
         End If
      End If
      Me.Close()
   End Sub

   Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
      If CType(cmbStatus.SelectedItem, ComboClass).Value = 3 Then
         dpStart.Visible = True
         dpEnd.Visible = True
         lblStart.Visible = True
         lblEnd.Visible = True
      Else
         dpStart.Visible = False
         dpEnd.Visible = False
         lblStart.Visible = False
         lblEnd.Visible = False
      End If
   End Sub
End Class