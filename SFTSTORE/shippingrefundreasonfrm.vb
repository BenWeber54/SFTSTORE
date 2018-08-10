Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf

Public Class shippingrefundreasonfrm
   Private Sub shippingrefundreasonfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnAccept.Text = Txt(819)
      Me.Text = Txt(820)
      btnClose.Text = Txt(764)
   End Sub
   Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
      dr.ot_szRefundReason = Trim(txtReason.Text)
      Me.Close()
   End Sub
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
End Class