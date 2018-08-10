Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports System.Collections.Specialized

Public Class login
   Dim tSOFTWARE%
   Dim tCNT%, BETA%, ALPHA%, WEB_SERVER$, SFTDEVFN$, str10$, CANCEL_SW%
   Dim td1 As Date, td2 As Date


   Private Sub bcancel_Click(sender As Object, e As EventArgs) Handles bcancel.Click
      dr.szLogin = "END"
      Me.Close()
      Me.Dispose()
   End Sub

   Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
      Dim tstr1$, tstr2$
      dr.testConnectionSWT = 0
      dr.uu_szId = Trim(userid.Text)
      Dim tl1& = UserCheckId(dr)

      If tl1 = 0 Then
         MsgDsp("User not found")
         Exit Sub
      End If

      GetUserRecord(dr.iid, dr)

      If dr.uu_iPasswordFlag = PASSWORD_RESET Then
         MsgDsp("Password has been reset.  A new password is required before continuing", 20)
         Dim frm As login_password
         frm = New login_password
         frm.ShowDialog()
         password.Text = dr.szPassword
      Else
         dr.sr_iid = dr.uu_iid
         dr.szPassword = Trim(UCase(password.Text))
         If UserCheckPassword(dr) = 0 Then
            MsgDsp("User Id/Password is not matched")
            Exit Sub
         End If
      End If

      If GetKeyValue(dr.sr_szSettings, "SAVEUSERID") = "1" Then
         WriteIni("LOGIN", "USERID", Trim(userid.Text))
      End If
      If GetKeyValue(dr.sr_szSettings, "SAVEPASSWORD") = "1" Then
         WriteIni("LOGIN", "PASSWORD", Trim(password.Text))
      End If

      UserToSystem(dr)
      GetAccessSystemRecord(dr.sr_iid, dr)
      dr.szLogin = "OK"

      If GetKeyValue(dr.sr_szSettings, "NOSOFTWAREUPDATE") = "2" Then
         Me.Close()
      ElseIf GetKeyValue(dr.sr_szSettings, "NOSOFTWAREUPDATE") = "1" Then
         MsgDsp("NOSOFTWAREUPDATE=1 has been set no software update test ... starting application")
         Me.Close()
      Else
         tSOFTWARE = 1
      End If

      If GetKeyValue(dr.sr_szSettings, "MAILUSER") <> "" Then
         dr.MAILUSER = GetKeyValue(dr.sr_szSettings, "MAILUSER")
      End If

      If GetKeyValue(dr.sr_szSettings, "MAILPASSWORD") <> "" Then
         dr.MAILPASSWORD = GetKeyValue(dr.sr_szSettings, "MAILPASSWORD")
      End If

      If GetKeyValue(dr.sr_szSettings, "MAILCUSNUMBER") <> "" Then
         dr.MAILCUSNUMBER = GetKeyValue(dr.sr_szSettings, "MAILCUSNUMBER")
      End If

      MsgDsp("Loading data ... One moment", 10)

      Me.Cursor = Cursors.WaitCursor
      TestConnection()
      dr.ocmd.CommandText = "select * from txt_text order by tx_iid"
      dr.oread = dr.ocmd.ExecuteReader()
      Err.Clear()
      tstr1 = ""
      tstr2 = ""
      Do While dr.oread.Read()
         If Err.Number > 0 Then Exit Do
         tstr1 += CStr(dr.oread("tx_iid")) + Chr(254)
         tstr1 += dr.oread("tx_szEnglish") + Chr(254)
         tstr1 += dr.oread("tx_szFrench") + Chr(254)
         If tstr1.Length > 1000 Then
            tstr2 += tstr1
            tstr1 = ""
         End If
      Loop
      tstr2 += tstr1
      dr.oread.Close()

      'puts the filtered text into an array
      getFilteredText()

      dr.tx_txt = Split(tstr2, Chr(254))
      Me.Cursor = Cursors.Arrow
      Me.Close()
   End Sub

   Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.AcceptButton = blogin
      tSOFTWARE = 0
      If GetKeyValue(dr.sr_szSettings, "SAVEUSERID") = "1" Then
         userid.Text = ReadIni("LOGIN", "USERID")
      End If
      If GetKeyValue(dr.sr_szSettings, "SAVEPASSWORD") = "1" Then
         password.Text = ReadIni("LOGIN", "PASSWORD")
      End If
      DisplayVersion()
   End Sub

   Sub DisplayVersion()
      'version.ForeColor = Color.Silver
      version.Text = "Version: " + dr.cr_szVersion
      If GetKeyValue(dr.sr_szSettings, "BETA") = "1" Then
         version.Text += " *** TEST SITE ***"
         version.ForeColor = Color.DarkRed
      End If
      If GetKeyValue(dr.sr_szSettings, "LOCAL") = "1" Then
         version.Text += " *** (LOCAL SITE) ***"
         version.ForeColor = Color.DarkGreen
      End If
      If GetKeyValue(dr.sr_szSettings, "ALPHA") = "1" Then
         version.Text += " *** ALPHA SITE ***"
         version.ForeColor = Color.DarkCyan
      End If

   End Sub
   Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
      Dim tl1&, tl2&, tl3&, tdta$(), tdta2$(), tSW%, tFILEPATH$, tFILE$, tstr1$, tLEN&, tDOWNTOTAL&
      Dim tTOTALDOWNLOAD&, tASMDSKUP%
      Dim tASMDSKUP_DATE As Date

      tmr.Enabled = False
      If tSOFTWARE > 0 Then
         If tSOFTWARE = 1 Then
            MsgDsp("Checking for software updates ... ")
            WEB_SERVER = "http://www.sftdv.com"
            BETA = 0
            ALPHA = 0
            If GetKeyValue(dr.sr_szSettings, "BETA") = "1" Then
               BETA = 1
            End If
            If GetKeyValue(dr.sr_szSettings, "ALPHA") = "1" Then
               ALPHA = 1
               BETA = 2
            End If
            SFTDEVFN = "CMD=SFTSTORE&PARAM1=" + CStr(BETA)
            tstr1 = WEB_SERVER + "/SFTDEVFN/FTN.ASPX?" + SFTDEVFN
            wb.Navigate(tstr1)
            str10 = ""
         End If
         If tSOFTWARE = 10 Or tSOFTWARE = 20 Or tSOFTWARE = 30 Or tSOFTWARE = 40 Or tSOFTWARE = 50 Then
            If str10 = "" Then
               'str10 = wb.Document.Body.InnerHtml
               If InStr(1, str10, "COMPLETED!!!") = 0 Then
                  str10 = ""
               Else
                  tdta = Split(str10, "<BR>")
                  tDOWNTOTAL = 0
                  tASMDSKUP = 0
                  'get total count
                  For tl1 = 0 To UBound(tdta)
                     If InStr(1, Trim(tdta(tl1)), "<!---") = 1 And InStr(1, tdta(tl1), "|") > 0 Then
                        tdta2 = Split(tdta(tl1), "|")
                        tFILE = ""
                        For tl2 = 0 To UBound(tdta2)
                           If tl2 = 2 Then
                              td1 = DateSerial(CInt(Mid(tdta2(tl2), 7, 4)), CInt(Mid(tdta2(tl2), 1, 2)), CInt(Mid(tdta2(tl2), 4, 2)))
                              td1 = td1.AddHours(CInt(Mid(tdta2(tl2), 12, 2)))
                              td1 = td1.AddMinutes(CInt(Mid(tdta2(tl2), 15, 2)))
                              td1 = td1.AddSeconds(CInt(Mid(tdta2(tl2), 18, 2)))
                              'TimeSerial(CInt(Mid(tdta2(tl2), 12, 2)), CInt(Mid(tdta2(tl2), 15, 2)), CInt(Mid(tdta2(tl2), 18, 2)))
                              tFILE = Trim(tdta2(1))
                           End If
                        Next tl2
                        tSW = 0
                        tl2 = 0
                        tFILEPATH = AppDomain.CurrentDomain.BaseDirectory + tFILE
                        If System.IO.File.Exists(tFILEPATH) = True Then
                           td2 = FileDateTime(tFILEPATH)
                           tl3 = DateDiff("n", td1, td2)
                           If tl3 < 0 Then tl3 = tl3 * -1
                           If tl3 > 5 Then
                              tSW = 1
                           End If
                        Else
                           tSW = 1 'file not here
                        End If
                        If tSW = 1 Then
                           Dim URI As String
                           URI = WEB_SERVER
                           'If ALPHA = 1 Then
                           '   URI += "/ASMUpdatesAlpha/"
                           'ElseIf BETA = 1 Then
                           '   URI += "/ASMUpdatesBeta/"
                           'Else
                           '   URI += "/ASMUpdates/"
                           'End If
                           URI += tFILE
                           Dim wr As HttpWebRequest = CType(WebRequest.Create(URI.ToString), HttpWebRequest)
                           Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
                           tstr1 = ws.Headers("content-length")
                           tDOWNTOTAL += 1
                           TimeDelay(100)
                           Dim wstr As Stream = ws.GetResponseStream()
                           wstr.Close()
                           If UCase(tFILE) = "SFTSTORE.EXE" Then
                              tASMDSKUP = 1
                              tASMDSKUP_DATE = td1
                           End If
                        End If
                     End If
                  Next tl1
                  If tDOWNTOTAL > 0 Then
                     If tASMDSKUP = 1 Then
                        Dim URI As String
                        URI = WEB_SERVER
                        'If ALPHA = 1 Then
                        '   URI += "/ASMUpdatesAlpha/"
                        'ElseIf BETA = 1 Then
                        '   URI += "/ASMUpdatesBeta/"
                        'Else
                        '   URI += "/ASMUpdates/"
                        'End If
                        MsgDsp("Getting update module (STFSTORE.EXE) from server.", 15)
                        tFILE = "SFTSTORE.EXE"
                        tFILEPATH = AppDomain.CurrentDomain.BaseDirectory + tFILE
                        URI += tFILE
                        Dim wr As HttpWebRequest = CType(WebRequest.Create(URI.ToString), HttpWebRequest)
                        Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
                        tLEN = 0
                        tstr1 = ws.Headers("content-length")
                        tLEN = CLng(tstr1)
                        Dim wstr As Stream = ws.GetResponseStream()
                        Dim inBuf(tLEN) As Byte
                        Dim bytesToRead As Integer = CInt(tLEN)
                        Dim bytesRead As Integer = 0
                        While bytesToRead > 0
                           Dim n As Integer = wstr.Read(inBuf, bytesRead, bytesToRead)
                           If n = 0 Then
                              Exit While
                           End If
                           tTOTALDOWNLOAD += n
                           bytesRead += n
                           bytesToRead -= n
                        End While
                        Dim fstr As New FileStream(tFILEPATH, FileMode.OpenOrCreate, FileAccess.Write)
                        fstr.Write(inBuf, 0, bytesRead)
                        wstr.Close()
                        fstr.Close()
                        td1 = tASMDSKUP_DATE
                        File.SetCreationTime(tFILEPATH, td1)
                        File.SetLastWriteTime(tFILEPATH, td1)
                        File.SetLastAccessTime(tFILEPATH, td1)
                     End If
                     tDOWNTOTAL -= tASMDSKUP
                     If tDOWNTOTAL > 0 Then
                        If tDOWNTOTAL = 1 Then
                           MsgDsp(CStr(tDOWNTOTAL) + " update available.  Starting update process ...", 20)
                        Else
                           MsgDsp(CStr(tDOWNTOTAL) + " updates available.  Starting update process ...", 20)
                        End If
                        tstr1 = AppDomain.CurrentDomain.BaseDirectory + "SFTSTORE.EXE"
                        If File.Exists(tstr1) = True Then
                           System.Diagnostics.Process.Start(tstr1)
                           End
                        Else
                           MsgDsp("Update module missing (SFTSTORE.EXE) ...  Update aborted ... opening application ...", 20)
                        End If
                     Else
                        MsgDsp("No other updates available ... opening application ...")
                     End If
                  Else
                     MsgDsp("Your system is up to date ... opening application ...")
                  End If
                  tSOFTWARE = 0
                  Me.Close()
               End If
            End If
         End If
         If tSOFTWARE = 60 Then
            MsgDsp("Error hitting at webservice, software update cancelled")
            tSOFTWARE = 0
            Me.Close()
         End If
         If tSOFTWARE <> 0 Then tSOFTWARE += 1
      End If
      tmr.Enabled = True
   End Sub

   Private Sub login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
   End Sub

   Private Sub bSettings_Click(sender As Object, e As EventArgs) Handles bSettings.Click
      Dim frm As setup
      frm = New setup
      frm.ShowDialog()
      DisplayVersion()
   End Sub
End Class