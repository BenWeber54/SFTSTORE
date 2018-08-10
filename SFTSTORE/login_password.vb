Imports SFTSTORE.data
Imports SFTSTORE.ftn
Public Class login_password

   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      MsgDsp("Password change is required before continuing.  Exiting system ...", 20)
      End
   End Sub

   Private Sub login_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
      Dim tstr1$, tstr2$
      tstr1 = Trim(UCase(ipassword.Text))
      tstr2 = Trim(UCase(cpassword.Text))
      If Len(tstr1) < 4 Then
         MsgDsp("Password must be at least 4 characters")
         Exit Sub
      End If
      If tstr1 <> tstr2 Then
         MsgDsp("Password and confirm password do not match")
         ipassword.Text = ""
         cpassword.Text = ""
         Exit Sub
      End If

      dr.szPassword = tstr1
      UserSetPassword(dr)
      MsgDsp("Password has been set")
      Me.Close()
   End Sub
End Class