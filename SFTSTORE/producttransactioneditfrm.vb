Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class producttransactioneditfrm
   Private Sub producttransactioneditfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(694)
      lblType.Text = Txt(685)
      lblChanged.Text = Txt(686)
      lblDesc.Text = Txt(368)

      btnSave.Text = Txt(382)
      btnClose.Text = Txt(390)

      cmbType.Items.Add(New ComboClass(1, Txt(610)))
      cmbType.Items.Add(New ComboClass(2, Txt(688)))
      'cmbType.Items.Add(New ComboClass(3, Txt(41)))
      'cmbType.Items.Add(New ComboClass(4, Txt(689)))
      inits()
   End Sub
   Private Sub inits()
      InitProductTransaction(dr)
      Display()
   End Sub
   Private Sub Display()
      SetCboIndex(cmbType, dr.pn_iType)
      cmbType.Enabled = False
   End Sub
   Private Sub ScreenToRecord()
      dr.pn_iChanged = CLng(GetFloat(txtChanged.Text))
      dr.pn_szDescription = Trim(txtDesc.Text)

      TestConnection()
      dr.ocmd.CommandText = "SELECT TOP 1 pn_iRemaining FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pn_dDate Desc"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.pn_iRemaining = dr.oread("pn_iRemaining")
      Else
         dr.pn_iRemaining = 0
      End If
      dr.oread.Close()

      If dr.pn_iType = 1 Then
         dr.pn_iRemaining += dr.pn_iChanged
      Else
         dr.pn_iRemaining -= dr.pn_iChanged
      End If
   End Sub
   Private Function Validation()
      Validation = 0
      Dim tstr1$ = ""
      If dr.pn_iChanged <= 0 Then
         txtChanged.Focus()
         MsgDsp(Txt(690))
         Exit Function
      End If
      If dr.pn_iRemaining < 0 Then
         txtChanged.Focus()
         MsgDsp(Txt(691))
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim tl1& = 0
      ScreenToRecord()
      If Validation() = 0 Then
         Exit Sub
      End If
      tl1 = dr.pn_iid
      UpdateProductTransactionRecord(dr)
      If tl1 = 0 Then
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
      Me.Close()
   End Sub
End Class