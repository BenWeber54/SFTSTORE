Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class shippingselectfrm
   Private Sub shippingselectfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(766)
      btnSave.Text = Txt(762)
      btnClose.Text = Txt(764)

      lblShipType.Text = Txt(766) + ":"
      lblShipCost.Text = Txt(767) + ":"
      chkPrice.Text = Txt(765)

      Dim selectionArray$()
      selectionArray = Split(dr.WEB_RESULT, "|")
      cmbShipping.Items.Clear()
      For tl1 = 0 To UBound(selectionArray) - 1 Step 3
         cmbShipping.Items.Add(New ComboClass(CStr(GetFloat(selectionArray(tl1 + 1))) + "|" + selectionArray(tl1 + 2) + "|", selectionArray(tl1) + " " + selectionArray(tl1 + 1)))
      Next
      cmbShipping.SelectedIndex = 0
   End Sub
   Private Sub screenToRecord()
      Dim shippingCode$ = ""
      Dim keyArray$()
      keyArray = Split(CStr(CType(cmbShipping.SelectedItem, ComboClass).Value), "|")
      shippingCode = keyArray(1)
      For tl1 = 0 To UBound(dr.SHIPPING_ARRAY) - 1 Step 8
         If CStr(dr.shipNum) = dr.SHIPPING_ARRAY(tl1 + 2) Then
            dr.SHIPPING_ARRAY(tl1 + 4) = CStr(GetFloat(txtPrice.Text))
            dr.SHIPPING_ARRAY(tl1 + 3) = CStr(shippingCode)
         End If
      Next
   End Sub
#Region "Click events"
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      screenToRecord()
      Me.Close()
   End Sub
#End Region

   Private Sub cmbShipping_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShipping.SelectedIndexChanged
      Dim keyArray$()
      keyArray = Split(CStr(CType(cmbShipping.SelectedItem, ComboClass).Value), "|")
      txtPrice.Text = CStr(GetFloat(keyArray(0)))
   End Sub
   Private Sub chkPrice_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrice.CheckedChanged
      If chkPrice.Checked = True Then
         txtPrice.Enabled = True
      Else
         txtPrice.Enabled = False
      End If
   End Sub
End Class