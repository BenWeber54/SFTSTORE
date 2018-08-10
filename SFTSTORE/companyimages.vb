Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class companyimages
   Private Sub companyimages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(617)
      lblType.Text = Txt(612) + ":"
      lblFile.Text = Txt(613) + ":"
      bselect.Text = Txt(614)
      bnew.Text = Txt(379)
      bopen.Text = Txt(380)
      bsave.Text = Txt(382)
      bdelete.Text = Txt(383)
      bclose.Text = Txt(390)

      SetCboItems(attachment, 475, 3)
      Label3.Text = Txt(424)
      Inits()
   End Sub
   Private Sub Inits()
      CompanyImagesInits(dr)
      Display()
   End Sub
   Private Sub Display()
      filename.Text = dr.ci_szFilename
      SetCboIndex(attachment, dr.ci_iType)
   End Sub
   Private Sub ScreenToRecord()
      dr.ci_szFilename = filename.Text
      dr.ci_iType = CType(attachment.SelectedItem, ComboClass).Value
   End Sub
   Private Function Validation()
      Dim tl1&
      Validation = 0
      If dr.ci_iid = 0 Then
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

      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM COM_IMAGES WHERE ci_COM_COMPANY = " + CStr(dr.sr_iCompany) + " AND ci_iType = " + CStr(dr.ci_iType) + " AND ci_iid <> " + CStr(dr.ci_iid)
      dr.oread = dr.ocmd.ExecuteReader
      If dr.oread.HasRows = True Then
         dr.oread.Close()
         MsgDsp(Txt(883))
         attachment.Focus()
         Exit Function
      End If
      dr.oread.Close()

      If dr.ci_iType = 1 Then
         If Path.GetExtension(dr.ci_szFilename) <> ".ico" Then
            MsgDsp(Txt(884))
            bselect.Focus()
            Exit Function
         End If
      End If

      If dr.ci_iType <> 2 Or dr.ci_iType <> 3 Then
         Dim img As System.Drawing.Image
         Try
            img = System.Drawing.Image.FromFile(filename.Text)
            If dr.ci_iType = 3 Then
               If img.Width > 300 Or img.Height > 300 Then
                  MsgDsp(Txt(902))
                  Exit Function
               End If
            End If
            img.Dispose()
         Catch Exception As Exception
            MsgDsp(Txt(554))
            Exit Function
         End Try
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
      dr.LIST_CTRL = 5
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub

   Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
      If dr.ci_iid = 0 Then
         ScreenToRecord()
         If Validation() = 0 Then Exit Sub
         UpdateCompanyImagesRecord(dr)
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
         ExecuteScalar(dr.szConnection, "delete from COM_IMAGES where ci_iid = " + CStr(dr.ci_iid), tstr1)
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

      If dr.ci_iid <> 0 Then
         tstr1 = Txt(615)
         bv = False
      Else
         tstr1 = Txt(382)
         bv = True
      End If

      If bsave.Text <> tstr1 Then bsave.Text = tstr1
      If bv <> filename.Enabled Then filename.Enabled = bv
      If bv <> bselect.Enabled Then bselect.Enabled = bv
      If bv <> attachment.Enabled Then attachment.Enabled = bv

      If dr.ci_iid <> 0 Then
         bv = True
      Else
         bv = False
      End If
      If bv <> bdelete.Enabled Then bdelete.Enabled = bv
   End Sub
   Private Sub attachment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles attachment.SelectedIndexChanged
      Dim tl1& = dr.ci_iType, tl2& = 0
      dr.ci_iType = CType(attachment.SelectedItem, ComboClass).Value
      tl2 = CType(attachment.SelectedItem, ComboClass).Value
      If tl2 = 1 Then
         lblSize.Text = ""
      ElseIf tl2 = 2 Then
         lblSize.Text = ""
      ElseIf tl2 = 3 Then
         lblSize.Text = Txt(902)
      End If
   End Sub
End Class