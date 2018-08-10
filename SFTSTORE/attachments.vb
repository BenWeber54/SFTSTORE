Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class attachments
   Private Sub attachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(385)
      lblType.Text = Txt(612) + ":"
      lblDesc.Text = Txt(368) + ":"
      lblFile.Text = Txt(613) + ":"
      bselect.Text = Txt(614)
      bnew.Text = Txt(379)
      bopen.Text = Txt(380)
      bsave.Text = Txt(382)
      bdelete.Text = Txt(383)
      bclose.Text = Txt(390)

      SetCboItems(attachment, 450, 1)
      Label3.Text = Txt(424)
      Inits()
   End Sub
   Private Sub Inits()
      AttachmentsInits(dr)
      Display()
      subject.Text = Txt(449 + dr.at_iAttachment)
   End Sub
   Private Sub Display()
      filename.Text = dr.at_szFilename
      subject.Text = dr.at_szSubject
      SetCboIndex(attachment, dr.at_iAttachment)
   End Sub
   Private Sub ScreenToRecord()
      dr.at_szFilename = filename.Text
      dr.at_szSubject = subject.Text
      dr.at_iAttachment = CType(attachment.SelectedItem, ComboClass).Value
   End Sub
   Private Function Validation()
      Dim tl1&
      Validation = 0
      If dr.at_iid = 0 Then
         If dr.at_szSubject = "" Then
            MsgDsp(Txt(420))
            subject.Focus()
            Exit Function
         End If
         If filename.Text <> "" Then
            Dim info As New FileInfo(filename.Text)
            tl1 = 0
            tl1 = info.Length
            If tl1 = 0 Then
               MsgDsp(Txt(423))
               filename.Focus()
               Exit Function
            End If
         Else
            MsgDsp(Txt(423))
            filename.Focus()
            Exit Function
         End If
      End If
      Validation = 1
   End Function

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bselect.Click
      OpenFileDialog1.Title = "Please select a File"
      OpenFileDialog1.FileName = ""
      OpenFileDialog1.ShowDialog()
   End Sub

   Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
      Dim tl1&
      Dim strm As System.IO.Stream

      strm = OpenFileDialog1.OpenFile()

      filename.Text = OpenFileDialog1.FileName.ToString()

      If Not (strm Is Nothing) Then

         Dim info As New FileInfo(filename.Text)

         tl1 = 0
         tl1 = info.Length
         If tl1 > 5000000 Then
            MsgDsp(Txt(424), 20)
            filename.Text = ""
         End If
         'insert code to read the file data
         strm.Close()
      End If
   End Sub

   Private Sub bnew_Click(sender As Object, e As EventArgs) Handles bnew.Click
      Inits()
   End Sub

   Private Sub bopen_Click(sender As Object, e As EventArgs) Handles bopen.Click
      dr.LIST_CTRL = 4
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub

   Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
      If dr.at_iid = 0 Then
         ScreenToRecord()
         If Validation() = 0 Then Exit Sub
         UpdateAttachmentRecord(dr)
         Display()
         MsgDsp(Txt(359))
         bnew_Click(sender, e)
      Else
         System.Diagnostics.Process.Start(dr.full_filename)
      End If
   End Sub
   Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
      Dim tstr1$ = ""
      If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
         ExecuteScalar(dr.szConnection, "delete from ATT_ATTACHMENTS where at_iid = " + CStr(dr.at_iid), tstr1)
         Inits()
         MsgDsp(Txt(355))
      End If
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      Dim tstr1$

      If dr.at_iid <> 0 Then
         tstr1 = Txt(615)
         bv = False
      Else
         tstr1 = Txt(382)
         bv = True
      End If

      If bsave.Text <> tstr1 Then bsave.Text = tstr1
      If bv <> filename.Enabled Then filename.Enabled = bv
      If bv <> subject.Enabled Then subject.Enabled = bv
      If bv <> bselect.Enabled Then bselect.Enabled = bv
      If bv <> attachment.Enabled Then attachment.Enabled = bv

      If dr.at_iid <> 0 Then
         bv = True
      Else
         bv = False
      End If
      If bv <> bdelete.Enabled Then bdelete.Enabled = bv
   End Sub

   Private Sub attachment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles attachment.SelectedIndexChanged
      Dim tl1& = dr.at_iAttachment
      dr.at_iAttachment = CType(attachment.SelectedItem, ComboClass).Value
      If tl1 <> dr.at_iAttachment Then
         subject.Text = Txt(449 + dr.at_iAttachment)
      End If
   End Sub
End Class