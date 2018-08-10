Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class notes
   Private Sub notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(384)
      lblSubject.Text = Txt(422) + ":"
      lblDesc.Text = Txt(368) + ":"

      bnew.Text = Txt(379)
      bopen.Text = Txt(380)
      bsave.Text = Txt(382)
      bdelete.Text = Txt(383)
      bclose.Text = Txt(390)
      'If dr.NOTES_TYPE = NOTE_COMPANY Then Me.Text += " - " + dr.uw_szDesc
      bnew_Click(sender, e)
   End Sub
   Private Sub Display()
      subject.Text = dr.no_szSubject
      detail.Text = dr.no_szDetail
   End Sub
   Private Function Validation()
      Validation = 0
      If dr.no_szSubject = "" Then
         MsgDsp(Txt(420))
         subject.Focus()
         Exit Function
      End If
      If dr.no_szDetail = "" Then
         MsgDsp(Txt(421))
         detail.Focus()
         Exit Function
      End If
      Validation = 1
   End Function
   Private Sub ScreenToRecord()
      dr.no_szSubject = Trim(subject.Text)
      dr.no_szDetail = Trim(detail.Text)
   End Sub

   Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
      NotesInits(dr)
      Display()
      subject.Focus()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub

   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      If dr.no_iid = 0 Then
         bv = False
      Else
         bv = True
      End If
      If bdelete.Enabled <> bv Then bdelete.Enabled = bv
   End Sub

   Private Sub bopen_Click(sender As Object, e As EventArgs) Handles bopen.Click
      dr.LIST_CTRL = 3
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub

   Private Sub subject_GotFocus(sender As Object, e As EventArgs) Handles subject.GotFocus
      SetText(subject)
   End Sub
   Private Sub detail_GotFocus(sender As Object, e As EventArgs) Handles detail.GotFocus
      SetText(detail)
   End Sub

   Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
      ScreenToRecord()
      If Validation() = 0 Then Exit Sub
      dr.no_dUpdate = Now
      dr.no_uUSR_USER = dr.sr_iid
      UpdateNotesRecord(dr)
      If dr.no_iid = 0 Then
         dr.no_iid = CLng(dr.szRstr)
         MsgDsp(Txt(359))
      Else
         MsgDsp(Txt(360))
      End If
   End Sub

   Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "DELETE FROM NOT_NOTES WHERE no_iid = " + CStr(dr.no_iid), tstr1)
         bnew_Click(sender, e)
         MsgDsp(Txt(355))
      End If
   End Sub
End Class