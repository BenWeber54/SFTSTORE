Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productimagesfrm
   Private Sub attachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(550)
      lblStatus.Text = Txt(625) + ":"
      lblOrder.Text = Txt(626) + ":"
      lblTooltip.Text = Txt(627) + ":"
      lblFile.Text = Txt(613) + ":"

      bnew.Text = Txt(379)
      bopen.Text = Txt(380)
      bsave.Text = Txt(382)
      bdelete.Text = Txt(383)
      btnOrder.Text = Txt(628)
      btnView.Text = Txt(615)
      bclose.Text = Txt(390)
      bselect.Text = Txt(614)

      SetCboItems(cmbStatus, 36, 2)
      Label3.Text = Txt(424)
      Inits()
   End Sub
   Private Sub Inits()
      InitProductImage(dr)
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_IMAGE WHERE pi_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pi_iOrder Desc"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         txtOrder.Text = CStr(CLng(dr.oread("pi_iOrder")) + 1)
      Else
         txtOrder.Text = CStr(dr.pi_iOrder)
      End If
      Display()
   End Sub
   Private Sub Display()
      SetCboIndex(cmbStatus, dr.pi_iActive)
      filename.Text = dr.pi_szImage
      txtTooltip.Text = dr.pi_szTooltip
      SetCboIndex(cmbStatus, dr.pi_iActive)
      If dr.pi_iid > 0 Then
         txtOrder.Text = CStr(dr.pi_iOrder)
      End If
   End Sub
   Private Sub ScreenToRecord()
      dr.pi_szImage = Trim(filename.Text)
      dr.pi_szTooltip = Trim(txtTooltip.Text)
      dr.pi_iActive = CType(cmbStatus.SelectedItem, ComboClass).Value
      dr.pi_iOrder = CLng(GetFloat(txtOrder.Text))
      dr.pi_PRO_PRODUCT = dr.pp_iid
   End Sub
   Private Function Validation()
      Dim tl1&
      Validation = 0
      If dr.pi_szTooltip = "" Then
         MsgDsp(Txt(420))
         txtTooltip.Focus()
         Exit Function
      End If
      If dr.pi_iid = 0 Then
         If filename.Text <> "" Then
            Try
               Dim info As New FileInfo(filename.Text)
               tl1 = 0
               tl1 = info.Length
               If tl1 = 0 Then
                  MsgDsp(Txt(423))
                  filename.Focus()
                  Exit Function
               End If
            Catch ex As Exception
               MsgDsp(Txt(555))
               filename.Focus()
               Exit Function
            End Try
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
      dr.LIST_CTRL = 9
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         Display()
      End If
   End Sub

   Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
      Dim tl1& = dr.pi_iid
      ScreenToRecord()
      If Validation() = 0 Then Exit Sub
      If dr.pi_iid > 0 Then
         If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
            MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
         End If
         dr.pi_szImage = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(dr.pi_szImage)
      End If
      If UpdateProductImageRecord(dr) = True Then
         Display()
         If tl1 = 0 Then
            MsgDsp(Txt(359))
         Else
            MsgDsp(Txt(360))
         End If
      End If
   End Sub
   Private Sub bdelete_Click(sender As Object, e As EventArgs) Handles bdelete.Click
      Dim tstr1$ = ""
      If dr.pi_iid > 0 Then
         If MsgBox(Txt(352), vbYesNo, Txt(356)) = MsgBoxResult.Yes Then
            ExecuteScalar(dr.szConnection, "DELETE FROM PRO_IMAGE WHERE pi_iid = " + CStr(dr.pi_iid), tstr1)
            UpdateProductImageOrder(dr)
            Inits()
            MsgDsp(Txt(355))
         End If
      End If
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim bv As Boolean
      Dim bv1 As Boolean
      If dr.pi_iid > 0 Then
         bv = True
      Else
         bv = False
      End If
      If bv <> bdelete.Enabled Then bdelete.Enabled = bv
      If bv <> btnView.Enabled Then btnView.Enabled = bv
      If dr.pi_iid > 0 Then
         bv1 = False
      Else
         bv1 = True
      End If
      If bv1 <> bselect.Enabled Then bselect.Enabled = bv1
   End Sub

   Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
      If dr.pi_iid > 0 Then
         If File.Exists(dr.full_filename) = True Then
            System.Diagnostics.Process.Start(dr.full_filename)
         Else
            MsgDsp(Txt(555))
         End If
      End If
   End Sub

   Private Sub createFile()
      If UBound(dr.bytes) < 10 Then
         MsgDsp(Txt(502))
         Exit Sub
      End If
      If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
         MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
      End If
      dr.full_filename = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(dr.at_szFilename)
      If File.Exists(dr.full_filename) Then
         Kill(dr.full_filename)
      End If

      Dim wrt As FileStream = File.OpenWrite(dr.full_filename)
      wrt.Write(dr.bytes, 0, UBound(dr.bytes) + 1)
      wrt.Close()
   End Sub

   Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
      Dim tl1& = dr.pi_iid
      Dim frm As productimageorderfrm
      frm = New productimageorderfrm
      frm.ShowDialog()
      If tl1 = 0 Then
         Inits()
      Else
         GetProductImageRecord(tl1, dr)
      End If

      Display()
   End Sub
End Class