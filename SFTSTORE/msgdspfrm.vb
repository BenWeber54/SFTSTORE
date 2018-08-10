Imports SFTSTORE.data

Public Class msgdspfrm

   Dim tCNT%

   Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click

   End Sub

   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      tCNT += 1

      If tCNT > dr.MSG_CNT Then
         Me.Close()
      End If
   End Sub

   Private Sub msgdspfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Dim tl1&, tl2&
      tl2 = Me.Width
      lbl.Text = dr.MSG_STR
      Me.Width = lbl.Width + lbl.Left * 3
      tl1 = Me.Width
      Me.Left = Me.Left + (tl2 - tl1) / 2
   End Sub
End Class