Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Math
Imports System.IO.File
Imports Microsoft.VisualBasic
#If SFTSTORE Then
Imports SFTSTORE.ComboClass
Imports SFTSTORE.data
#ElseIf SFTSTOREWEB Then
Imports SFTSTOREWEB.data
#End If

Imports System.Text.RegularExpressions

Public Class ftn

   '------------------------------------------------------------------------------------------------
   ' executes the sql and returns the value of the first row first column of the result set
   '------------------------------------------------------------------------------------------------
   Public Shared Function FileInUse(ByVal sFile As String) As Boolean
      On Error Resume Next

      Dim thisFileInUse As Boolean = False

      Err.Clear()
      Using f As New IO.FileStream(sFile, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
         ' thisFileInUse = False
      End Using
      If Err.Number > 0 Then
         thisFileInUse = True
      End If
      Return thisFileInUse
   End Function
   Public Shared Function ExecuteScalar(ByVal inConn As String, ByVal inSQL As String, ByRef retVal As String) As Long
      Dim oConn As New OleDb.OleDbConnection(inConn)
      Dim oCommand As New OleDb.OleDbCommand(inSQL, oConn)

      Try
         oConn.Open()
         retVal = oCommand.ExecuteScalar()
      Catch e As Exception
         retVal = e.Message
         System.Diagnostics.Debug.Print(inSQL)
         System.Diagnostics.Debug.Print(e.Message)
         Return False
      Finally
         oConn.Close()
      End Try

      Return True
   End Function

   Public Shared Function StringFormatCurrency(ByVal ctrl%, ByVal ival As Decimal, Optional replang% = 0) As String
      Dim fstr1$, tl1&, tDOLLAR%, ilang%

      ilang = dr.sr_iLanguage
      If replang > 0 Then
         ilang = replang
      End If
      fstr1 = ""
      tDOLLAR = 0
      Select Case ctrl
         Case 1
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0")
         Case 2
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 3
            fstr1 = Format(ival, "###,###,##0")
         Case 4
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 5
            fstr1 = Format(ival, "###,###,##0") + "%"
         Case 6
            fstr1 = Format(ival, "###,###,##0.00") + "%"
         Case 7
            fstr1 = Format(ival, "##########0")
         Case 8
            fstr1 = Format(ival, "###,###,##0.000")
         Case 9
            fstr1 = Format(ival, "###,###,##0.0000")
         Case 10
            fstr1 = Format(ival, "###,###,##0.00000")
         Case 11
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.000")
         Case 12
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.0000")
         Case 13
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00000")
         Case 14
            fstr1 = Format(ival, "##########0.00")
         Case 15
            fstr1 = Format(ival, "##########0.00000")
         Case 16
            fstr1 = Format(ival, "##########0.000")
         Case 18
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 19
            fstr1 = Format(ival, "##########0.0")
         Case 20
            fstr1 = Format(ival, "0000000000000")
         Case 21
            fstr1 = Format(ival, "########000")
            fstr1 = Mid(fstr1, 1, Len(fstr1) - 2) + ":" + Mid(fstr1, Len(fstr1) - 1, 2)
         Case 22
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.000")
      End Select
      If ilang = FRENCH Then
         For tl1 = 1 To Len(fstr1)
            If Mid(fstr1, tl1, 1) = "," Then Mid(fstr1, tl1, 1) = " "
            If Mid(fstr1, tl1, 1) = "." Then Mid(fstr1, tl1, 1) = ","
         Next tl1
      End If
      If tDOLLAR = 1 Then
         If ilang = FRENCH Then
            fstr1 = fstr1 + " $"
         Else
            fstr1 = "$" + fstr1
         End If
      End If
      StringFormatCurrency = fstr1
   End Function
   Public Shared Function StringFormatEnglish(ByVal ctrl%, ByVal ival As Decimal) As String
      Dim fstr1$, tDOLLAR%, ilang%
      ilang = ENGLISH
      fstr1 = ""
      tDOLLAR = 0
      Select Case ctrl
         Case 1
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0")
         Case 2
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 3
            fstr1 = Format(ival, "###,###,##0")
         Case 4
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 5
            fstr1 = Format(ival, "###,###,##0") + "%"
         Case 6
            fstr1 = Format(ival, "###,###,##0.00") + "%"
         Case 7
            fstr1 = Format(ival, "##########0")
         Case 8
            fstr1 = Format(ival, "###,###,##0.000")
         Case 9
            fstr1 = Format(ival, "###,###,##0.0000")
         Case 10
            fstr1 = Format(ival, "###,###,##0.00000")
         Case 11
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.000")
         Case 12
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.0000")
         Case 13
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00000")
         Case 14
            fstr1 = Format(ival, "##########0.00")
         Case 15
            fstr1 = Format(ival, "##########0.00000")
         Case 16
            fstr1 = Format(ival, "##########0.000")
         Case 18
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.00")
         Case 19
            fstr1 = Format(ival, "##########0.0")
         Case 20
            fstr1 = Format(ival, "0000000000000")
         Case 21
            fstr1 = Format(ival, "########000")
            fstr1 = Mid(fstr1, 1, Len(fstr1) - 2) + ":" + Mid(fstr1, Len(fstr1) - 1, 2)
         Case 22
            tDOLLAR = 1
            fstr1 = Format(ival, "###,###,##0.000")
         Case 23
            fstr1 = Format(ival, "##0.0")
         Case 24
            fstr1 = Format(ival, "#0.000")
      End Select
      StringFormatEnglish = fstr1
   End Function
   Public Shared Function FormatPhone(ByVal istr$) As String
      Dim tstr1$
      tstr1 = istr
      If IsNumeric(istr) = True Then
         If Len(istr) = 7 Then
            tstr1 = Mid(istr, 1, 3) + "-" + Mid(istr, 4, 4)
         End If
         If Len(istr) = 10 Then
            tstr1 = "(" + Mid(istr, 1, 3) + ") " + Mid(istr, 4, 3) + "-" + Mid(istr, 7, 4)
         End If
         If Len(istr) = 11 Then
            tstr1 = Mid(istr, 1, 1) + " (" + Mid(istr, 2, 3) + ") " + Mid(istr, 5, 3) + "-" + Mid(istr, 8, 4)
         End If
      End If
      FormatPhone = tstr1$
   End Function
   Public Shared Function FormatPostal(ByVal istr$) As String
      Dim tstr1$, tI&
      tstr1 = istr
      If Len(istr) >= 6 Then
         tstr1 = ""
         For tI = 1 To Len(istr)
            If Mid(istr, tI, 1) <> " " Then
               tstr1 += Mid(istr, tI, 1)
            End If
         Next
         If Len(tstr1) = 6 Then
            tI = 0
            If IsNumeric(Mid(tstr1, 1, 1)) = False Then tI += 1
            If IsNumeric(Mid(tstr1, 2, 1)) = True Then tI += 1
            If IsNumeric(Mid(tstr1, 3, 1)) = False Then tI += 1
            If IsNumeric(Mid(tstr1, 4, 1)) = True Then tI += 1
            If IsNumeric(Mid(tstr1, 5, 1)) = False Then tI += 1
            If IsNumeric(Mid(tstr1, 6, 1)) = True Then tI += 1
            If tI = 6 Then
               tstr1 = UCase(Mid(tstr1, 1, 3) + " " + Mid(tstr1, 4, 3))
            Else
               tstr1 = istr
            End If
         Else
            tstr1 = istr
         End If
      End If
      FormatPostal = tstr1$
   End Function
   Public Shared Function GetFloat(ByVal istr1$) As Decimal
      Dim gI%, gJ%, tLANG%
      Dim tstr2$, tNEGATIVE%, tPERIOD%, tNUMBER%

      tstr2 = istr1
      tNEGATIVE = 0
      tPERIOD = 0
      tNUMBER = 0
      tLANG = dr.sr_iLanguage
      If tLANG = FRENCH Then
         For gI = 1 To Len(istr1)
            If Mid(istr1, gI, 1) = "," Then Mid(istr1, gI, 1) = "."
         Next gI
      End If
      gJ = Len(Trim(istr1))
      If gJ < 1 Then
         GetFloat = 0
         Exit Function
      End If
      For gI = 1 To gJ
         If (Mid(istr1, gI, 1) < "0" Or Mid(istr1, gI, 1) > "9") And Mid(istr1, gI, 1) <> "." And Mid(istr1, gI, 1) <> "-" And gI <= gJ Then
            Mid(istr1, gI) = Mid(istr1, gI + 1)
            Mid(istr1, gJ, 1) = " "
            gI = gI - 1
         End If
         gJ = Len(RTrim(istr1))
      Next

      gJ = Len(Trim(istr1))
      If gJ >= 1 Then
         For gI = 1 To gJ
            If Mid(istr1, gI, 1) = "-" Then tNEGATIVE += 1
            If Mid(istr1, gI, 1) = "." Then tPERIOD += 1
            If Mid(istr1, gI, 1) >= "0" And Mid(istr1, gI, 1) <= "9" Then tNUMBER += 1
         Next
      End If

      If tNUMBER = 0 Or tPERIOD > 1 Or tNEGATIVE > 1 Then
         GetFloat = 0
         Exit Function
      End If

      If Trim(istr1) = "" Then
         GetFloat = 0
         Exit Function
      End If
      GetFloat = CDec(Trim(istr1))
   End Function
   Public Shared Function GetFloat3Decimals(ByVal istr1$) As Decimal
      Dim gI%, gJ%
      gJ = Len(istr1)
      For gI = 1 To gJ
         If (Mid(istr1, gI, 1) < "0" Or Mid(istr1, gI, 1) > "9") And Mid(istr1, gI, 1) <> "." And gI <= gJ Then
            Mid(istr1, gI) = Mid(istr1, gI + 1)
            Mid(istr1, gJ, 1) = " "
            gI = gI - 1
         End If
         gJ = Len(RTrim(istr1))
      Next
      GetFloat3Decimals = CDec(Trim(istr1))
   End Function
#If SFTSTORE Then
   Public Shared Sub SetCboIndex(ByVal fld As ComboBox, ByVal iValue&)
      For Each o As Object In fld.Items
         If CType(o, ComboClass).Value = iValue Then
            fld.SelectedItem = o
            Exit For
         End If
      Next
   End Sub
   Public Shared Sub SetCboItems(ByVal fld As ComboBox, ByVal iStart&, ByVal iDurations&, Optional ByVal iSort% = 0)
      Dim tI%, tJ%, tstr1$, tdta$()
      Dim tstr2$

      fld.Items.Clear()

      tstr1 = ""
      For tI = iStart To iStart + iDurations - 1
         tstr2 = ""
         tstr2 = Txt(tI)
         If tstr2 <> "" Then
            tstr1 = tstr1 + tstr2 + "^"
            tstr1 = tstr1 + CStr(tI - iStart + 1) + "^"
         End If
      Next
      tstr2 = ""
      tdta = Split(tstr1, "^")
      If iSort = 1 Then
         If UBound(tdta) > 2 Then
            For tI = 0 To UBound(tdta) - 3 Step 2
               For tJ = tI + 2 To UBound(tdta) - 1 Step 2
                  If tdta(tJ) < tdta(tI) Then
                     tstr1 = tdta(tI)
                     tdta(tI) = tdta(tJ)
                     tdta(tJ) = tstr1
                     tstr1 = tdta(tI + 1)
                     tdta(tI + 1) = tdta(tJ + 1)
                     tdta(tJ + 1) = tstr1
                  End If
               Next
            Next
         End If
      End If
      tJ = 0
      For tI = 0 To UBound(tdta) - 1 Step 2
         fld.Items.Add(New ComboClass(CInt(tdta(tI + 1)), tdta(tI)))
         'fld.Items.Add(tdta(tI))
         'fld.Items.Item(tJ).Itemdata = 
         ''fld.Items(tJ) = CInt(tdta(tI + 1)) * 100
         'tJ += 1
      Next
   End Sub
   Public Shared Sub SetCboItemsGeneric(ByVal fld As ComboBox, ByVal iGENERIC&, Optional ByVal iSort% = 0)
      Dim tI%, tJ%, tK%, tstr1$, tdta$(), tdta2$(), tSW%
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM GEN_GENERIC_DETAIL where gd_GEN_GENERIC = " + CStr(iGENERIC) + " order by gd_iValue"
      Dim ocn As New OleDb.OleDbConnection(dr.szConnection)
      Dim ocmd As New OleDb.OleDbCommand(strSQL, ocn)
      tstr1 = ""

      Try
         ocn.Open()
         Dim oread As OleDb.OleDbDataReader = ocmd.ExecuteReader
         If oread.HasRows = True Then
            Do While (oread.Read())
               If dr.sr_iLanguage = ENGLISH Then
                  tstr1 += oread("gd_szDesc") + "^"
               Else
                  tstr1 += oread("gd_szFrnDesc") + "^"
               End If
               tstr1 += CStr(oread("gd_ivalue")) + "^"
            Loop
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         ocn.Close()
      End Try
      tdta = Split(tstr1, "^")
      If iSort = 1 Then
         If UBound(tdta) > 2 Then
            For tI = 0 To UBound(tdta) - 3 Step 2
               For tJ = tI + 2 To UBound(tdta) - 1 Step 2
                  If tdta(tJ) < tdta(tI) Then
                     tstr1 = tdta(tI)
                     tdta(tI) = tdta(tJ)
                     tdta(tJ) = tstr1
                     tstr1 = tdta(tI + 1)
                     tdta(tI + 1) = tdta(tJ + 1)
                     tdta(tJ + 1) = tstr1
                  End If
               Next
            Next
         End If
      End If
      tJ = 0
      If iGENERIC = 40 Then
         'set order
         tstr1 = "0|1|4|2|5|9|3"
         tdta2 = Split(tstr1, "|")
         tstr1 = ""
         For tK = 0 To UBound(tdta2)
            For tI = 0 To UBound(tdta) Step 2
               If tdta(tI + 1) = tdta2(tK) Then
                  tstr1 += tdta(tI) + "^"
                  tstr1 += tdta(tI + 1) + "^"
                  Exit For
               End If
            Next tI
         Next (tK)
         tdta = Split(tstr1, "^")
      End If

      For tI = 0 To UBound(tdta) - 1 Step 2
         tSW = 1
         If tSW = 1 Then
            fld.Items.Add(tdta(tI))
            fld.Items(tJ).Value = CInt(tdta(tI + 1))
            tJ += 1
         End If
      Next
   End Sub
   Public Shared Sub SetCbo(ByVal fld As ComboBox, ByVal iValue&)
      Dim tI%, tJ%
      If fld.Items.Count > 0 Then
         tJ = -1
         For tI = 0 To fld.Items.Count - 1
            fld.Items(tI).Selected = False
         Next
         For tI = 0 To fld.Items.Count - 1
            If fld.Items(tI).Value = iValue Then
               fld.Items(tI).Selected = True
               tJ = tI
               Exit For
            End If
         Next
         If tJ = -1 Then fld.Items(0).Selected = True
      End If
   End Sub
   Public Shared Sub RemoveItem(ByVal fld As ComboBox, ByVal iValue&)
      Dim tI%
      If fld.Items.Count > 0 Then
         For tI = fld.Items.Count - 1 To 0 Step -1
            If fld.Items(tI).Value = iValue Then
               fld.Items.RemoveAt(tI)
            End If
         Next
      End If
   End Sub
   Public Shared Sub SetText(txt As TextBox)
      txt.SelectAll()
   End Sub
   Public Shared Sub MsgDsp(istr$, Optional timedelay% = 15)
      dr.MSG_CNT = timedelay
      dr.MSG_STR = istr
      Dim frm As msgdspfrm
      frm = New msgdspfrm
      frm.ShowDialog()
   End Sub
#ElseIf SFTSTOREWEB Then
   Public Shared Sub SetCboItems(ByVal fld As System.Web.UI.WebControls.DropDownList, ByVal iStart&, ByVal iDurations&, Optional ByVal iSort% = 0)
      Dim tI%, tJ%, tstr1$, tdta$()
      Dim tstr2$

      fld.Items.Clear()

      tstr1 = ""
      tJ = 0
      For tI = iStart To iStart + iDurations - 1
         tJ += 1
         tstr1 = tstr1 + Txt(tI) + "^"
         tstr1 = tstr1 + CStr(tJ) + "^"
      Next
      tstr2 = ""
      If iStart = 241 Then
         tJ = 0
         tstr2 = GV("dd_szNotes", 1)
         If InStr(1, tstr2, "ACCIDENTAL=Y") > 0 Then
            tJ += 1
            tstr1 = tstr1 + Txt(245) + "^"
            tstr1 = tstr1 + CStr(tJ) + "^"
         End If
      End If
      tdta = Split(tstr1, "^")
      If iSort = 1 Then
         If UBound(tdta) > 2 Then
            For tI = 0 To UBound(tdta) - 3 Step 2
               For tJ = tI + 2 To UBound(tdta) - 1 Step 2
                  If tdta(tJ) < tdta(tI) Then
                     tstr1 = tdta(tI)
                     tdta(tI) = tdta(tJ)
                     tdta(tJ) = tstr1
                     tstr1 = tdta(tI + 1)
                     tdta(tI + 1) = tdta(tJ + 1)
                     tdta(tJ + 1) = tstr1
                  End If
               Next
            Next
         End If
      End If
      tJ = 0
      For tI = 0 To UBound(tdta) - 1 Step 2
         fld.Items.Add(tdta(tI))
         fld.Items(tJ).Value = CInt(tdta(tI + 1))
         tJ += 1
      Next
   End Sub
   Public Shared Sub SetCboItemsGeneric(ByVal fld As System.Web.UI.WebControls.DropDownList, ByVal iGENERIC&, Optional ByVal iSort% = 0)
      Dim tI%, tJ%, tK%, tstr1$, tdta$(), tdta2$(), tSW%
      Dim rspString As String = ""
      Dim strSQL As String = "SELECT * FROM GEN_GENERIC_DETAIL where gd_GEN_GENERIC = " + CStr(iGENERIC) + " order by gd_iValue"
      Dim ocn As New OleDb.OleDbConnection(dr.szConnection)
      Dim ocmd As New OleDb.OleDbCommand(strSQL, ocn)
      tstr1 = ""

      Try
         ocn.Open()
         Dim oread As OleDb.OleDbDataReader = ocmd.ExecuteReader
         If oread.HasRows = True Then
            Do While (oread.Read())
               If CLng(GV("sr_iLanguage", 0)) = 0 Then
                  tstr1 += oread("gd_szDesc") + "^"
               Else
                  tstr1 += oread("gd_szFrnDesc") + "^"
               End If
               tstr1 += CStr(oread("gd_ivalue")) + "^"
            Loop
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         ocn.Close()
      End Try
      tdta = Split(tstr1, "^")
      If iSort = 1 Then
         If UBound(tdta) > 2 Then
            For tI = 0 To UBound(tdta) - 3 Step 2
               For tJ = tI + 2 To UBound(tdta) - 1 Step 2
                  If tdta(tJ) < tdta(tI) Then
                     tstr1 = tdta(tI)
                     tdta(tI) = tdta(tJ)
                     tdta(tJ) = tstr1
                     tstr1 = tdta(tI + 1)
                     tdta(tI + 1) = tdta(tJ + 1)
                     tdta(tJ + 1) = tstr1
                  End If
               Next
            Next
         End If
      End If
      tJ = 0
      If iGENERIC = 40 Then
         'set order
         tstr1 = "0|1|4|2|5|9|3"
         tdta2 = Split(tstr1, "|")
         tstr1 = ""
         For tK = 0 To UBound(tdta2)
            For tI = 0 To UBound(tdta) Step 2
               If tdta(tI + 1) = tdta2(tK) Then
                  tstr1 += tdta(tI) + "^"
                  tstr1 += tdta(tI + 1) + "^"
                  Exit For
               End If
            Next tI
         Next (tK)
         tdta = Split(tstr1, "^")
      End If

      For tI = 0 To UBound(tdta) - 1 Step 2
         tSW = 1
         If tSW = 1 Then
            fld.Items.Add(tdta(tI))
            fld.Items(tJ).Value = CInt(tdta(tI + 1))
            tJ += 1
         End If
      Next
   End Sub
   Public Shared Sub SetCbo(ByVal fld As System.Web.UI.WebControls.DropDownList, ByVal iValue&)
      Dim tI%, tJ%
      If fld.Items.Count > 0 Then
         tJ = -1
         For tI = 0 To fld.Items.Count - 1
            fld.Items(tI).Selected = False
         Next
         For tI = 0 To fld.Items.Count - 1
            If fld.Items(tI).Value = iValue Then
               fld.Items(tI).Selected = True
               tJ = tI
               Exit For
            End If
         Next
         If tJ = -1 Then fld.Items(0).Selected = True
      End If
   End Sub
   Public Shared Sub RemoveItem(ByVal fld As System.Web.UI.WebControls.DropDownList, ByVal iValue&)
      Dim tI%
      If fld.Items.Count > 0 Then
         For tI = fld.Items.Count - 1 To 0 Step -1
            If fld.Items(tI).Value = iValue Then
               fld.Items.RemoveAt(tI)
            End If
         Next
      End If
   End Sub
   Public Shared Sub SV(ByVal fld$, ByVal val$)
      Dim tbv(), tbf(), tl1&, tl2&, tSW%
      tbf = HttpContext.Current.Session("FLD")
      tbv = HttpContext.Current.Session("VAR")
      If tbf IsNot Nothing Then
         tSW = 0
         For tl2 = 0 To UBound(tbv)
            If tbf(tl2) = fld Then
               tl1 = tl2
               tSW = 1
               Exit For
            End If
         Next
         If tSW = 0 Then
            ReDim Preserve tbv(UBound(tbv) + 1)
            ReDim Preserve tbf(UBound(tbf) + 1)
            tl1 = UBound(tbf)
         End If
      Else
         ReDim Preserve tbv(0)
         ReDim Preserve tbf(0)
         tl1 = 0
      End If

      tbv(tl1) = val
      tbf(tl1) = fld

      HttpContext.Current.Session("FLD") = tbf
      HttpContext.Current.Session("VAR") = tbv

   End Sub

   Public Shared Function GV(ByVal fld$, ByVal typ%) As String
      'typ - 0 - numeric
      '    - 1 - string
      '    - 2 - date
      '    - 3 - date with time
      Dim tbv(), tbf(), tl2&, tSW%, tstr1$
      tbf = HttpContext.Current.Session("FLD")
      tbv = HttpContext.Current.Session("VAR")
      tstr1 = ""
      If tbf IsNot Nothing Then
         tSW = 0
         For tl2 = 0 To UBound(tbv)
            If tbf(tl2) = fld Then
               tstr1 = tbv(tl2)
               tSW = 1
               Exit For
            End If
         Next
      Else
         tSW = 0
      End If
      If tSW = 0 Then
         If typ = 0 Then tstr1 = "0"
         If typ = 1 Then tstr1 = ""
         If typ = 2 Then tstr1 = Format(Now.Date, "dd/MMM/yyyy")
         If typ = 3 Then tstr1 = Format(Now.Date, "dd/MMM/yyyy HH:mm:ss")
      End If
      GV = tstr1
   End Function
   Public Shared Sub TextSetFocus(ByVal iPage As Page, ByVal iText As TextBox)
      Dim tType As Type
      tType = iPage.GetType()
      iPage.ClientScript.RegisterClientScriptBlock(tType, "onload", "window.onload = function() { document.getElementById('" & iText.ClientID & "').select(); }", True)
      iText.Focus()
   End Sub

   Public Shared Sub GetTextWidth(istr$, fontname$, fontsize%, fontbold%, fontitalic%, fontunderline%, ByRef FW%, ByRef FH%)
      Dim FS As System.Drawing.FontStyle
      If fontbold = 1 Then
         FS = FontStyle.Bold
      Else
         FS = FontStyle.Regular
      End If
      Dim fnt As New Font(fontname, fontsize, FS, GraphicsUnit.Point)
      Dim SF As New System.Drawing.SizeF
      Dim g As Graphics = Graphics.FromImage(New Bitmap(1, 1))
      SF = g.MeasureString(istr, fnt)
      FW = SF.Width
      FH = SF.Height
   End Sub
#End If
   Public Shared Function GetDate(ByVal istr1$) As Date
      Dim tdta$(), tdta2$(), tSEP$, tENG$, tFRN$, tDAY%, tYEAR%, tMONTH$, tMTH%
      Dim d1 As Date
      d1 = Now.Date
      tENG = ""
      tFRN = ""
      tSEP = "/"
      If InStr(1, istr1, "-") > 0 Then tSEP = "-"
      If InStr(1, istr1, ".") > 0 Then tSEP = "."
      tdta = Split(UCase(istr1 + tSEP + tSEP), tSEP)
      tENG = "JAN/FEB/MAR/APR/MAY/JUN/JUL/AUG/SEP/OCT/NOV/DEC"
      tFRN = "Janv/Févr/Mars/Avr/Mai/Juin/Juil/Août/Sept/Oct/Nov/Déc"
      tMTH = 0
      tDAY = 0
      tYEAR = 0
      tDAY = CInt(tdta(0))
      tMONTH = tdta(1)
      tYEAR = CInt(tdta(2))
      tdta2 = Split(tENG, "/")

      If tMONTH = "JAN" Or tMONTH = "JANV" Then tMTH = 1
      If tMONTH = "FEB" Or tMONTH = "FÉVR" Or tMONTH = "FEVR" Or tMONTH = "FéVR" Then tMTH = 2
      If tMONTH = "MAR" Or tMONTH = "MARS" Then tMTH = 3
      If tMONTH = "APR" Or tMONTH = "AVR" Then tMTH = 4
      If tMONTH = "MAY" Or tMONTH = "MAI" Then tMTH = 5
      If tMONTH = "JUN" Or tMONTH = "JUIN" Then tMTH = 6
      If tMONTH = "JUL" Or tMONTH = "JUIL" Then tMTH = 7
      If tMONTH = "AUG" Or tMONTH = "AOUT" Or tMONTH = "AOûT" Or tMONTH = "AOÛT" Then tMTH = 8
      If tMONTH = "SEP" Or tMONTH = "SEPT" Then tMTH = 9
      If tMONTH = "OCT" Or tMONTH = "OCT" Then tMTH = 10
      If tMONTH = "NOV" Or tMONTH = "NOV" Then tMTH = 11
      If tMONTH = "DEC" Or tMONTH = "DÉC" Or tMONTH = "DéC" Then tMTH = 12

      If tMTH = 0 Then
         If IsNumeric(tMONTH) = True Then
            tMTH = CInt(tMONTH)
         End If
      End If

      d1 = Now.Date
      If tDAY > 0 And tMTH > 0 And tYEAR > 0 Then
         d1 = DateSerial(CInt(tYEAR), tMTH, CInt(tDAY))
      End If
      If d1.Year < 1900 Then
         d1 = Now.Date
      End If
      GetDate = d1
   End Function

   Public Shared Function MonthsToAge(ByVal bdate As Date, ByVal atdate As Date, ByVal ToAge%, Optional ByVal AGELASTALWAYS% = 1) As Integer
      Dim tl1&, tSW%
      Dim tDATE As Date
      tSW = 0
      tl1 = 0
      Do While tSW = 0
         tl1 += 1
         tDATE = atdate.AddMonths(tl1)
         If CalculateAge(bdate, tDATE, AGELASTALWAYS) >= ToAge Then
            tl1 -= 1
            tSW = 1
         End If
      Loop
      MonthsToAge = tl1
   End Function

   Public Shared Function CalculateAge(ByVal bdate As Date, ByVal atdate As Date, Optional ByVal AGELASTALWAYS% = 1) As Integer
      Dim nd%, nm%, nyr%, tstr1$, tstr2$
      Dim bd%, bm%, byr%
      Dim tI%, tSW%
      Dim tl1&, tMONTH%, tDAY%
      Dim tDATE As Date
      Dim PROD_ALB As Long

      tstr1 = Format(atdate.Date, "dd/MM/yyyy")
      tstr2 = Format(bdate.Date, "dd/MM/yyyy")

      'MsgBox "Calculate Age: " + tstr1 + ", tstr2: " + tstr2

      nd = CInt(Mid(tstr1, 1, 2))
      nm = CInt(Mid(tstr1, 4, 2))
      nyr = CInt(Mid(tstr1, 7, 4))

      bd = CLng(Mid(tstr2, 1, 2))
      bm = CInt(Mid(tstr2, 4, 2))
      byr = CInt(Mid(tstr2, 7, 4))

      If AGELASTALWAYS = 1 Then
      Else
         If PROD_ALB = 0 Then
            nm = nm + 6
            If nm > 12 Then
               nyr = nyr + 1
               nm = nm - 12
            End If
         End If
      End If

      tI = 0
      If nm = bm Then
         tI = nyr - byr
         If nd < bd Then
            tI = tI - 1
         End If
      End If
      If nm > bm Then
         tI = nyr - byr
      End If
      If nm < bm Then
         tI = nyr - byr - 1
      End If

      If tI < 0 Then tI = 0

      If AGELASTALWAYS = 1 Then
      Else
         If PROD_ALB = 0 Then
            tSW = 0
            tDATE = atdate
            tSW = 0
            For tl1 = 1 To 183
               tDATE = tDATE.AddDays(1)
               tMONTH = Month(tDATE)
               tDAY = Day(tDATE)
               If bm = tMONTH And bd = tDAY Then
                  tSW = 1
               End If
            Next tl1
            If tSW = 1 Then
               'I have a birthday in the next 183 days.
               'Add 1 to my age
               tI = tI + 1
            End If
         End If
      End If

      CalculateAge = tI
   End Function

   Public Shared Function CalculateAgeFromDate(ByVal bdate As Date, ByVal FromDate As Date) As Integer
      Dim nd%, nm%, nyr%, tstr1$, tstr2$
      Dim bd%, bm%, byr%, tI%
      Dim td1 As Date
      If bdate >= Now.Date Or bdate = CDate("31/dec/1899") Then
         CalculateAgeFromDate = 0
         Exit Function
      End If
      td1 = FromDate

      tstr1 = Format(td1, "dd/MM/yyyy")
      tstr2 = Format(bdate.Date, "dd/MM/yyyy")

      nd = Day(td1)
      nm = Month(td1)
      nyr = Year(td1)
      bd = Day(bdate)
      bm = Month(bdate)
      byr = Year(bdate)
      tI = 0
      If nm = bm Then
         tI = nyr - byr
         If nd < bd Then
            tI = tI - 1
         End If
      End If
      If nm > bm Then
         tI = nyr - byr
      End If
      If nm < bm Then
         tI = nyr - byr - 1
      End If

      If tI < 0 Then tI = 0
      CalculateAgeFromDate = tI
   End Function
   Public Shared Function AStr(ByVal istr$) As String
      Dim aI%, ostr$, aSW%
      If istr = Nothing Then
         istr = ""
      End If
      aSW = 0
      If InStr(1, istr, """") > 0 Then aSW = 1
      If InStr(1, istr, "^") > 0 Then aSW = 1
      If InStr(1, istr, "'") > 0 Then aSW = 1
      If aSW = 0 Then
         AStr = istr
         Exit Function
      End If
      ostr = ""
      For aI = 1 To Len(istr)
         aSW = 0
         If Mid(istr, aI, 1) = "^" Then
            ostr = ostr + " "
            aSW = 1
         End If
         If Mid(istr, aI, 1) = """" Then
            ostr = ostr + "''"
            aSW = 1
         End If
         If Mid(istr, aI, 1) = "'" Then
            ostr = ostr + "''"
            aSW = 1
         End If
         If aSW = 0 Then
            ostr = ostr + Mid(istr, aI, 1)
         End If
      Next aI
      AStr = Trim(ostr)
   End Function
   Public Shared Function RStr(ByVal istr) As String
      Dim tI&
      Dim tstr1$, tstr2$, tdta$()
      tstr1 = istr
      tI = InStr(1, tstr1, vbCrLf)
      If tI = 0 Then
         tI = InStr(1, tstr1, "''")
         If tI = 0 Then
            RStr = istr
            Exit Function
         End If
      End If

      tI = InStr(1, tstr1, "''")
      If tI > 0 Then
         tdta = Split(tstr1, "''")
         tstr1 = ""
         For tI = 0 To UBound(tdta)
            tstr2 = Trim(tdta(tI))
            If tstr2 <> "" Then
               If tstr1 <> "" Then tstr1 = tstr1 + "'"
               tstr1 = tstr1 + tstr2
            End If
         Next tI
      End If

      RStr = tstr1
   End Function
   Public Shared Function RemoveHardReturn(ByVal istr) As String
      Dim tI&
      Dim tstr1$, tstr2$, tdta$()
      tstr1 = istr
      tI = InStr(1, tstr1, vbCrLf)
      If tI = 0 Then
         tI = InStr(1, tstr1, "{CR/LF}")
         If tI = 0 Then
            RemoveHardReturn = istr
            Exit Function
         End If
      End If

      tI = InStr(1, tstr1, vbCrLf)
      If tI > 0 Then
         tdta = Split(tstr1, vbCrLf)
         tstr1 = ""
         For tI = 0 To UBound(tdta)
            tstr2 = Trim(tdta(tI))
            If tstr2 <> "" Then
               If tstr1 <> "" Then tstr1 = tstr1 + " / "
               tstr1 = tstr1 + tstr2
            End If
         Next tI
      End If

      tI = InStr(1, tstr1, "{CR/LF}")
      If tI > 0 Then
         tdta = Split(tstr1, "{CR/LF}")
         tstr1 = ""
         For tI = 0 To UBound(tdta)
            tstr2 = Trim(tdta(tI))
            If tstr2 <> "" Then
               If tstr1 <> "" Then tstr1 = tstr1 + " / "
               tstr1 = tstr1 + tstr2
            End If
         Next tI
      End If
      RemoveHardReturn = tstr1
   End Function
   Public Shared Function RemoveHardReturn2(ByVal istr) As String
      Dim tI&
      Dim tstr1$, tstr2$, tdta$()
      tstr1 = istr
      tI = InStr(1, tstr1, vbCrLf)
      If tI = 0 Then
         RemoveHardReturn2 = istr
         Exit Function
      End If

      tdta = Split(tstr1, vbCrLf)
      tstr1 = ""
      For tI = 0 To UBound(tdta)
         tstr2 = Trim(tdta(tI))
         If tstr2 <> "" Then
            If tstr1 <> "" Then tstr1 = tstr1 + "|"
            tstr1 = tstr1 + tstr2
         End If
      Next tI
      RemoveHardReturn2 = tstr1
   End Function
   Public Shared Function DateFormat(ByVal iDate As DateTime, ByVal iLang%, Optional ctrl% = 0, Optional longformat% = 0) As String
      Dim tENG$, tdta$()
      Dim tFRN$
      Dim tstr1$

      tstr1 = ""
      If longformat = 1 Then
         tstr1 = CStr(Day(iDate)) + " "
         If iLang = FRENCH Then
            tstr1 += FrnTxt(399 + iDate.Month) + " "
         Else
            tstr1 += EngTxt(399 + iDate.Month) + ", "
         End If
         tstr1 += CStr(Year(iDate))
      ElseIf longformat = 2 Then
         If iLang = FRENCH Then
            tstr1 += FrnTxt(399 + iDate.Month) + " "
         Else
            tstr1 += EngTxt(399 + iDate.Month) + " "
         End If
         tstr1 += CStr(Day(iDate))
         If iLang = FRENCH Then
            tstr1 += " "
         Else
            tstr1 += ", "
         End If
         tstr1 += CStr(Year(iDate))
      Else
         tENG = "JAN/FEB/MAR/APR/MAY/JUN/JUL/AUG/SEP/OCT/NOV/DEC"
         tFRN = "Janv/Févr/Mars/Avr/Mai/Juin/Juil/Août/Sept/Oct/Nov/Déc"
         If iLang = FRENCH Then
            tdta = Split(tFRN, "/")
         Else
            tdta = Split(tENG, "/")
         End If
         tstr1 = CStr(Day(iDate)) + "/" + tdta(Month(iDate) - 1) + "/" + CStr(Year(iDate))
      End If
      If ctrl = 1 Then
         If iLang = FRENCH Then
            tstr1 += " " + Format(iDate, " hh:mm:ss")
         Else
            tstr1 += " " + Format(iDate, " h:mm:ss ")
            If iDate.Hour >= 12 Then
               tstr1 += Txt(392)
            Else
               tstr1 += Txt(391)
            End If
         End If
      End If
      DateFormat = tstr1
   End Function
   Public Shared Function FeetAndInches(ByVal iStr$) As String
      Dim tl1&, ostr$, tstr$
      tl1 = 0
      tstr = iStr
      tl1 = InStr(1, tstr, "'")
      If tl1 > 0 Then
         ostr = Trim(Mid(tstr, 1, tl1 - 1)) + "ft " + Mid(tstr, tl1 + 1)
         tstr = ostr
      End If
      tl1 = 0
      tl1 = InStr(1, tstr, """")
      If tl1 > 0 Then
         ostr = Trim(Mid(tstr, 1, tl1 - 1)) + "in " + Mid(tstr, tl1 + 1)
         tstr = ostr
      End If
      FeetAndInches = tstr
   End Function
   Public Shared Function GetKeyValue(ByVal iNotes$, ByVal iKey$) As String
      Dim tl1&, tdta$(), tdta2$()
      GetKeyValue = ""
      tdta = Split(iNotes + vbCrLf, vbCrLf)
      For tl1 = 0 To UBound(tdta)
         tdta2 = Split(tdta(tl1) + "=", "=")
         If UCase(tdta2(0)) = UCase(iKey) Then
            GetKeyValue = Trim(tdta2(1))
            Exit For
         End If
      Next tl1
   End Function


#If SFTSTOREWEB Then
   Public Shared Function Txt(ByVal iCode&) As String
      Dim ocn2 As System.Data.OleDb.OleDbConnection
      Dim ocmd2 As OleDb.OleDbCommand
      Dim oread2 As OleDb.OleDbDataReader
      ocn2 = New OleDb.OleDbConnection
      ocn2.ConnectionString = dr.szConnection
      ocn2.Open()
      ocmd2 = New OleDb.OleDbCommand
      ocmd2.Connection = ocn2

      ocmd2.CommandText = "SELECT * FROM TXT_TEXT WHERE tx_iid = " + CStr(iCode)
      oread2 = ocmd2.ExecuteReader()
      If oread2.HasRows = True Then
         oread2.Read()
         If dr.sr_iLanguage = ENGLISH Then
            Txt = oread2("tx_szEnglish")
         Else
            Txt = oread2("tx_szFrench")
         End If
      Else
         Txt = "TXT NF(" + CStr(iCode) + ")"
      End If
      oread2.Close()
      ocn2.Close()
   End Function
   Public Shared Function EngTxt(ByVal iCode&) As String
      Dim ocn2 As System.Data.OleDb.OleDbConnection
      Dim ocmd2 As OleDb.OleDbCommand
      Dim oread2 As OleDb.OleDbDataReader
      ocn2 = New OleDb.OleDbConnection
      ocn2.ConnectionString = dr.szConnection
      ocn2.Open()
      ocmd2 = New OleDb.OleDbCommand
      ocmd2.Connection = ocn2

      ocmd2.CommandText = "SELECT * FROM TXT_TEXT WHERE tx_iid = " + CStr(iCode)
      oread2 = ocmd2.ExecuteReader()
      If oread2.HasRows = True Then
         oread2.Read()
         EngTxt = oread2("tx_szEnglish")
      Else
         EngTxt = "TXT NF(" + CStr(iCode) + ")"
      End If
      oread2.Close()
      ocn2.Close()
      Exit Function
   End Function
   Public Shared Function FrnTxt(ByVal iCode&) As String
      Dim ocn2 As System.Data.OleDb.OleDbConnection
      Dim ocmd2 As OleDb.OleDbCommand
      Dim oread2 As OleDb.OleDbDataReader
      ocn2 = New OleDb.OleDbConnection
      ocn2.ConnectionString = dr.szConnection
      ocn2.Open()
      ocmd2 = New OleDb.OleDbCommand
      ocmd2.Connection = ocn2

      ocmd2.CommandText = "SELECT * FROM TXT_TEXT WHERE tx_iid = " + CStr(iCode)
      oread2 = ocmd2.ExecuteReader()
      If oread2.HasRows = True Then
         oread2.Read()
         FrnTxt = oread2("tx_szFrench")
      Else
         FrnTxt = "TXT NF(" + CStr(iCode) + ")"
      End If
      oread2.Close()
      ocn2.Close()
      Exit Function
   End Function
#ElseIf SFTSTORE Then
   Public Shared Function Txt(ByVal iCode&) As String
      Dim tl1&, tl2&, tl3&, tl4&, tCNT%, tSW%
      Dim tLANG%

      tLANG = dr.sr_iLanguage
      tl1 = 0
      tl2 = (UBound(dr.tx_txt) - 3) / 3
      tSW = 0
      tCNT = 0
      tl3 = (tl2 + tl1) / 2
      Txt = "TXT NF(" + CStr(iCode) + ")"
      Do While (tSW = 0)
         tCNT += 1
         tl4 = CLng(dr.tx_txt(tl3 * 3))
         If tCNT > 100 Then tSW = 1
         If tl4 = iCode Then
            tSW = 1
            If tLANG = ENGLISH Or tLANG = 0 Then
               Txt = dr.tx_txt(tl3 * 3 + 1)
            Else
               Txt = dr.tx_txt(tl3 * 3 + 2)
            End If
         Else
            If tl2 - tl1 <= 3 Then
               tl3 = tl1
               tl1 += 1
               If tl1 > tl2 + 1 Then
                  tSW = 1
               End If
            Else
               If tl4 > iCode Then
                  tl2 = tl3
               Else
                  tl1 = tl3
               End If
               tl3 = (tl2 + tl1) / 2
               If tl1 >= tl2 Then
                  tSW = 1
               End If
            End If
         End If
      Loop
      Exit Function
   End Function
   Public Shared Function EngTxt(ByVal iCode&) As String
      Dim tl1&, tl2&, tl3&, tl4&, tCNT%, tSW%
      Dim tLANG%

      tLANG = ENGLISH
      tl1 = 0
      tl2 = (UBound(dr.tx_txt) - 3) / 3
      tSW = 0
      tCNT = 0
      EngTxt = "TXT NF(" + CStr(iCode) + ")"
      Do While (tSW = 0)
         tCNT += 1
         tl4 = CLng(dr.tx_txt(tl3 * 3))
         If tCNT > 100 Then tSW = 1
         If tl4 = iCode Then
            tSW = 1
            If tLANG = ENGLISH Then
               EngTxt = dr.tx_txt(tl3 * 3 + 1)
            Else
               EngTxt = dr.tx_txt(tl3 * 3 + 2)
            End If
         Else
            If tl2 - tl1 <= 3 Then
               tl3 = tl1
               tl1 += 1
               If tl1 > tl2 + 1 Then
                  tSW = 1
               End If
            Else
               If tl4 > iCode Then
                  tl2 = tl3
               Else
                  tl1 = tl3
               End If
               tl3 = (tl2 + tl1) / 2
               If tl1 >= tl2 Then
                  tSW = 1
               End If
            End If
         End If
      Loop
      Exit Function
   End Function
   Public Shared Function FrnTxt(ByVal iCode&) As String
      Dim tl1&, tl2&, tl3&, tl4&, tCNT%, tSW%
      Dim tLANG%

      '      spath = Application.StartupPath + "\TEXT.TXT"
      tLANG = ENGLISH
      tl1 = 0
      tl2 = (UBound(dr.tx_txt) - 3) / 3
      tSW = 0
      tCNT = 0
      FrnTxt = "TXT NF(" + CStr(iCode) + ")"
      Do While (tSW = 0)
         tCNT += 1
         tl4 = CLng(dr.tx_txt(tl3 * 3))
         If tCNT > 100 Then tSW = 1
         If tl4 = iCode Then
            tSW = 1
            If tLANG = ENGLISH Or tLANG = 0 Then
               FrnTxt = dr.tx_txt(tl3 * 3 + 1)
            Else
               FrnTxt = dr.tx_txt(tl3 * 3 + 2)
            End If
         Else
            If tl2 - tl1 <= 3 Then
               tl3 = tl1
               tl1 += 1
               If tl1 > tl2 + 1 Then
                  tSW = 1
               End If
            Else
               If tl4 > iCode Then
                  tl2 = tl3
               Else
                  tl1 = tl3
               End If
               tl3 = (tl2 + tl1) / 2
               If tl1 >= tl2 Then
                  tSW = 1
               End If
            End If
         End If
      Loop
      Exit Function
   End Function
#End If

   Public Shared Function MakeAscii(ByVal istr As String) As String
      Dim rstr$, tl1&, tstr2$, HV%, LV%, AV%
      If istr = "" Then
         rstr = istr
         Return rstr
      End If
      tstr2 = "0123456789ABCDEF"
      HV = 0
      LV = 0
      rstr = ""
      For tl1 = 1 To Len(istr)
         AV = Asc(Mid(istr, tl1, 1))
         HV = Fix(AV / 16)
         LV = AV - HV * 16
         HV += 1
         LV += 1
         rstr += Mid(tstr2, HV, 1)
         rstr += Mid(tstr2, LV, 1)
      Next
      MakeAscii = rstr
   End Function
   Public Shared Function HexToString(ByVal istr) As String
      Dim HV%, LV%, rstr$, tstr2$, tl1&
      If Len(istr) < 2 Then
         HexToString = istr
         Exit Function
      End If
      tstr2 = "0123456789ABCDEF"
      HV = 0
      LV = 0
      rstr = ""
      For tl1 = 1 To Len(istr) Step 2
         HV = 0
         LV = 0
         HV = InStr(1, tstr2, Mid(istr, tl1, 1))
         If HV > 0 Then HV = HV - 1
         LV = InStr(1, tstr2, Mid(istr, tl1 + 1, 1))
         If LV > 0 Then LV = LV - 1
         rstr = rstr + Chr(HV * 16 + LV)
      Next
      HexToString = rstr
   End Function

   Public Shared Sub TimeDelay(tl1 As Long)
      Dim tSW%
      Dim tNOW As Long
      Dim tCUR As Long
      Dim tSEC As Long
      Dim tMIL As Long

      tSEC = Now.Second
      tMIL = Now.Millisecond
      tNOW = tSEC * 1000 + tMIL
      tSW = 0
      Do While (tSW = 0)
         tSEC = Now.Second
         tMIL = Now.Millisecond
         tCUR = tSEC * 1000 + tMIL
         If tMIL <> 0 Then
            If tCUR >= tNOW Then
               If tCUR - tNOW > tl1 Then
                  tSW = 1
               End If
            Else
               If tCUR + 60000 - tNOW > tl1 Then
                  tSW = 1
               End If
            End If
         End If
      Loop

   End Sub

   Public Shared Function RoundUpWhole(ByVal iVar)
      '
      'Different from RoundVar
      'Takes the amount and determines if there are any cents and up to the next dollar
      '
      Dim tRESULT, tTEST
      tTEST = Format(iVar, "0000000000.0000")
      tRESULT = CObj(Fix(iVar))
      If Mid(tTEST, 12, 4) <> "0000" Then
         If iVar < 0 Then
            tRESULT = tRESULT - 1
         Else
            tRESULT = tRESULT + 1
         End If
      End If
      RoundUpWhole = CDec(tRESULT)
   End Function

   Public Shared Function RoundDn0(ByVal iVar)
      'Different from RoundVar
      'Takes the amount and determines if there are any partial cents and adds a penny if need be.

      Dim tRESULT, tTEST
      tTEST = Format(iVar, "0000000000.00000")
      tRESULT = Mid(tTEST, 1, 10)
      RoundDn0 = CDec(tRESULT)
   End Function
   Public Shared Function RoundDn3(ByVal iVar)
      'Different from RoundVar
      'Takes the amount and determines if there are any partial cents and adds a penny if need be.

      Dim tRESULT, tTEST
      tTEST = Format(iVar, "0000000000.00000")
      tRESULT = Mid(tTEST, 1, 14)
      RoundDn3 = CDec(tRESULT)
   End Function
   Public Shared Function RoundUp(ByVal iVar)
      'Different from RoundVar
      'Takes the amount and determines if there are any partial cents and adds a penny if need be.

      Dim tRESULT, tTEST
      tTEST = Format(iVar, "0000000000.000000")
      'tRESULT = Format(iVar, "############0.00")
      tRESULT = CObj(Fix(iVar * 100) / 100)
      If Mid(tTEST, 12, 6) <> "000000" Then
         If Mid(tTEST, 14, 4) <> "0000" Then
            tRESULT = tRESULT + 0.01
         Else
            tTEST = tTEST
         End If
      End If
      RoundUp = CDec(tRESULT)
   End Function
   Public Shared Function LongToDate(ByVal ival As Long) As Date
      Dim tstr1$ = Format(ival, "00000000")
      LongToDate = DateSerial(CInt(Mid(tstr1, 1, 4)), CInt(Mid(tstr1, 5, 2)), CInt(Mid(tstr1, 7, 2)))
   End Function
   Public Shared Function Round2Decimals(ByVal ival!) As Decimal
      'Dim rval#, lval#
      'rval = CDec(Format(ival, "#########0.00"))
      Dim tdbl As Double
      tdbl = Fix(CDbl(ival * (10 ^ 2)) + (0.5 * Sign(ival))) / (10 ^ 2)
      Round2Decimals = tdbl
   End Function
   Public Shared Function Round5Decimals(ByVal ival!) As Decimal
      Dim rval#
      rval = CDec(Format(ival, "#########0.00000"))
      Round5Decimals = rval
   End Function


   Public Shared Function ValidEmail(ByVal szEmail$) As Boolean
      Dim bv As Boolean
      bv = False
      If UCase(szEmail) = "MAIL" Or UCase(szEmail) = "NOEMAIL" Or UCase(szEmail) = "NO EMAIL" Then
      ElseIf InStr(1, szEmail, "@") > 1 Then
         bv = True
      End If
      ValidEmail = bv
   End Function
   Public Shared Function RoundVar(iVar As Decimal, iPrecision As Integer) As Decimal
      If iPrecision = -1 Then
         RoundVar = iVar
         Exit Function
      End If
      Dim tRESULT As String
      tRESULT = Format(iVar, "############0")
      If iPrecision = 1 Then tRESULT = Format(iVar, "############0.0")
      If iPrecision = 2 Then tRESULT = Format(iVar, "############0.00")
      If iPrecision = 3 Then tRESULT = Format(iVar, "############0.000")
      If iPrecision = 4 Then tRESULT = Format(iVar, "############0.0000")
      If iPrecision = 5 Then tRESULT = Format(iVar, "############0.00000")
      If iPrecision = 6 Then tRESULT = Format(iVar, "############0.000000")
      If iPrecision = 7 Then tRESULT = Format(iVar, "############0.0000000")
      If iPrecision = 8 Then tRESULT = Format(iVar, "############0.00000000")
      RoundVar = CDec(tRESULT)
   End Function
   Public Shared Function validateCreditCard(card As String, type As Long)
      validateCreditCard = 0
      If type = VISA Then
         If card.Length <> 16 Then
            Exit Function
         End If
         If card.Substring(0, 1) <> "4" Then
            Exit Function
         End If
      ElseIf type = MASTERCARD Then
         If card.Length <> 16 Then
            Exit Function
         End If
         If card.Substring(0, 1) <> "5" Then
            Exit Function
         End If
      ElseIf type = AMEX Then
         If card.Length <> 15 Then
            Exit Function
         End If
         If card.Substring(0, 1) <> "3" Then
            Exit Function
         End If
      End If
      Dim cardArray$()
      Dim cardString$ = ""
      For tl1 = card.Length - 1 To 0 Step -1
         cardString += card.Substring(tl1, 1) + "|"
      Next
      cardArray = Split(cardString, "|")
      cardString = ""
      Dim digit& = 0, total& = 0
      For tl1 = 1 To UBound(cardArray) - 1 Step 2
         digit = CLng(cardArray(tl1)) * 2
         If digit > 9 Then
            digit = CLng(CStr(digit).Substring(0, 1)) + CLng(CStr(digit).Substring(1, 1))
            total += digit
         Else
            total += digit
         End If
      Next
      For tl1 = 0 To UBound(cardArray) - 1 Step 2
         total += CLng(cardArray(tl1))
      Next
      If isDivisible(total, 10) = False Then
         Exit Function
      End If
      validateCreditCard = 1
   End Function
   Public Shared Function isDivisible(x As Integer, d As Integer) As Boolean
      Return (x Mod d) = 0
   End Function
   Public Shared Function isValidCode(code As String, country As String) As Boolean
      If country = 1 Then
         If code.Length <> 6 Then
            Return False
         End If
         Dim postalString As Regex = New Regex("^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$")
         Dim match As Match = postalString.Match(code)
         If match.Success Then
            Return True
         Else
            Return False
         End If
      Else
         If code.Length <> 5 Then
            Return False
         End If
         Dim postalString As Regex = New Regex("^\d{5}(-\d{4})?$")
         Dim match As Match = postalString.Match(code)
         If match.Success Then
            Return True
         Else
            Return False
         End If
      End If
   End Function
   Public Shared Function detailShipped(ByVal detail As Long) As Boolean
      TestConnection()
      dr.ocmd.CommandText = "SELECT ot_iid FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE ot_iReturned = 0 AND oa_ORD_DETAIL = " + CStr(detail)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.oread.Close()
         Return False
      End If
      dr.oread.Close()
      Return True
   End Function
   Public Shared Function detailShippedWithReturn(ByVal detail As Long) As Boolean
      TestConnection()
      dr.ocmd.CommandText = "SELECT ot_iid FROM ORD_TRACKING JOIN ORD_TRACKING_DETAIL ON oa_ORD_TRACKING = ot_iid WHERE ot_iReturned = 0 AND oa_ORD_DETAIL = " + CStr(detail) + " AND ot_iReturnRequested = 1"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         dr.oread.Close()
         Return False
      End If
      dr.oread.Close()
      Return True
   End Function
   Public Shared Function GetWidthOfString(ByVal str As String) As Long
      Dim objBitmap As Bitmap
      Dim objGraphics As Graphics

      objBitmap = New Bitmap(500, 200)
      objGraphics = Graphics.FromImage(objBitmap)

      Dim stringSize As SizeF
      stringSize = objGraphics.MeasureString(str, New Font("Arial", 12))

      objBitmap.Dispose()
      objGraphics.Dispose()
      Return stringSize.Width
   End Function
#If SFTSTOREWEB Then
   Public Shared Function getActivationCode() As String
      Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
      Dim r As New Random
      Dim sb As New StringBuilder
      For i As Integer = 1 To 50
         Dim idx As Integer = r.Next(0, 61)
         sb.Append(s.Substring(idx, 1))
      Next
      Return sb.ToString()
   End Function
#End If
   Public Shared Function GetProvince(ByVal iid As Long, ByVal country As Long, ByRef dr As DATA_RECORD) As String
      Dim province As String = ""
      Dim tl1 As Long
      Dim rspString As String

      If country = CANADA Then
         tl1 = 99
      Else
         tl1 = 149
      End If

      Dim strSQL As String = "SELECT * FROM TXT_TEXT where tx_iid = " + CStr(tl1 + iid)
      TestConnection()
      Try
         dr.ocmd.CommandText = strSQL
         dr.oread = dr.ocmd.ExecuteReader
         If dr.oread.HasRows = True Then
            dr.oread.Read()
            If dr.sr_iLanguage = ENGLISH Then
               province = dr.oread("tx_szEnglish")
            Else
               province = dr.oread("tx_szFrench")
            End If
         End If
      Catch ex As Exception
         rspString = ex.Message
      Finally
         dr.oread.Close()
      End Try
      Return province
   End Function
End Class
