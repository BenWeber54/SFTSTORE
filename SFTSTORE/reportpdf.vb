Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.IO.FileStream
Imports System.Net
Imports System.Data.SqlClient
Imports System.Xml
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports All_In_The_Box

Public Class reportpdf

   Public Shared IMAGES As String, PDF_FILE$, PDF_FULL_FILE$
   Public Shared X%, Y%, LM%, RM%, fS%, fB%, fU%, fI%, gY%, X1%, X2%, X3%, X4%, X5%, X6%, Y1%
   Public Shared TERM_PAGES%, TERM_CNT%, LT%, RT%, TERM_TOP%, TERM_TYPE%
   Public Shared XSMIDGE As Decimal
   Public Shared YSMIDGE As Decimal
   Public Shared rcols(20) As Long
   Public Shared PAGE_CNT As Long
   Public Shared PAGE_TOTAL As Long
   Public Shared emailprint%, tEMAIL$
   Public Shared CALC_X As Long
   Public Shared CALC_Y As Long
   Public Shared TEMP_MAX_X As Long
   Public Shared MAX_X As Long
   Public Shared MAX_Y As Long
   Public Shared POS_X As Long
   Public Shared POS_Y As Long
   Public Shared ORIENTATION As Long
   Public Shared tPAGE As String

   Public Shared Sub CleanFiles()

      Dim tFILE$, tDIR$, tstr1$
      Dim d1 As Date
      Dim d2 As Date

      tDIR = AppDomain.CurrentDomain.BaseDirectory + "FILES"
      If Not Directory.Exists(tDIR) Then
         MkDir(tDIR)
      End If

      tstr1 = ""
      tstr1 = Dir(tDIR + "\*.*")
      d1 = Now.AddDays(1)

      Do While tstr1 <> ""
         tFILE = tDIR + "\" + tstr1
         d2 = FileDateTime(tFILE)
         If d2 < d1 Then
            Try
               If FileInUse(tFILE) = False Then
                  Kill(tFILE)
               End If
            Catch ex As Exception

            End Try
         End If
         tstr1 = Dir()
      Loop
   End Sub


   Public Shared Sub InitializePDF(ByRef abox As AllBox, Optional iOrientation% = 0)
      CleanFiles()

      Err.Clear()
      PDF_FILE = "PDF-" + CStr(dr.sr_iid) + "-" + Format(Now, "yyyy-MM-dd-HH-mm-ss") + ".PDF"
      PDF_FULL_FILE = AppDomain.CurrentDomain.BaseDirectory + "FILES\" + PDF_FILE


      abox.FileName = PDF_FULL_FILE

      abox.Channel = chPDF
      abox.FileName = PDF_FULL_FILE
      abox.Title = "Print Preview"
      If iOrientation = 1 Then
         abox.Orientation = TxPrinterOrientation.poLandscape
      Else
         abox.Orientation = TxPrinterOrientation.poPortrait
      End If
      abox.WantPageCount = True
      abox.BeginDoc()

      MAX_X = abox.PageWidth
      MAX_Y = abox.PageHeight
      LM = 5
      RM = 295

      IMAGES = AppDomain.CurrentDomain.BaseDirectory + "\"

      PAGE_CNT = 0
   End Sub
   Public Shared Sub FinalizePDF(ByRef Abox As AllBox)
      ''On Error Resume Next
      Dim file As New System.IO.FileInfo(PDF_FULL_FILE)
      Abox.EndDoc()

      TimeDelay(100)

      'you need to show the output ...

      System.Diagnostics.Process.Start(PDF_FULL_FILE)

      Exit Sub

      System.Diagnostics.Process.Start(PDF_FULL_FILE)

   End Sub

   Public Shared Sub WriteText(ByRef Abox As AllBox, ByVal ictrl%, ByVal istr$)
      ''On Error Resume Next

      '0 - left
      '1 - right
      '2 - center

      Dim tx%, tY%, tI%, tF%, tX2&, tY2&, tMAX_X&
      If TEMP_MAX_X > 0 Then
         tMAX_X = TEMP_MAX_X
         TEMP_MAX_X = 0
      Else
         tMAX_X = MAX_X
      End If
      tF = 0
      tI = 0
      If ictrl = 1 Then tF = 1
      If ictrl = 2 Then tF = 2
      tx = CLng(CSng(X / 300 * MAX_X))
      tY = CLng(CSng(Y / 300 * MAX_Y))
      If ictrl = 0 Then
         tX2 = MAX_X
      End If
      If ictrl = 1 Then
         tX2 = tx
         tx = 1
      End If
      If ictrl = 2 Then
         tI = MAX_X - 1 - tx
         tX2 = tx + tI
         tx = tx - tI
         If tx < 0 Then
            tX2 = CLng(CSng(X / 300 * MAX_X)) * 2
            tx = 1
         End If
      End If
      If tx < 1 Then tx = 1
      If tY < 1 Then tY = 1
      CALC_X = tx
      CALC_Y = tY
      POS_X = tx
      POS_Y = tY
      Abox.DrawText(tx, tY, tX2, tY2, tF, 0, istr)
   End Sub
   Public Shared Sub WriteTextAbs(ByRef Abox As AllBox, ByVal ictrl%, ByVal iAbs%, ByVal iX&, ByVal iY&, ByVal istr$)
      ''On Error Resume Next
      'iAbs - 1 - PDF X is known
      '       2 - PDF Y is known
      '       3 - PDF X & Y are known

      Dim tx%, tY%, tI%, tF%, tX2&, tY2&
      tF = 0
      tI = 0
      If ictrl = 1 Then tF = 1
      If ictrl = 2 Then tF = 2
      If iAbs = 2 Then
         tx = CLng(CSng(iX / 300 * MAX_X))
      Else
         tx = iX
      End If
      If iAbs = 1 Then
         tY = CLng(CSng(iY / 300 * MAX_Y))
      Else
         tY = iY
      End If
      If ictrl = 0 Then
         tX2 = MAX_X
      End If
      If ictrl = 1 Then
         tX2 = tx
         tx = 1
      End If
      If ictrl = 2 Then
         tI = MAX_X - 1 - tx
         tX2 = tx + tI
         tx = tx - tI
      End If
      If tx < 1 Then tx = 1
      If tX2 > 2160 Then tX2 = MAX_X
      If tY < 1 Then tY = 1
      If tY2 > 2780 Then tY2 = MAX_Y
      CALC_X = tx
      CALC_Y = tY
      POS_X = tx
      POS_Y = tY

      Abox.DrawText(tx, tY, tX2, tY2, tF, 0, istr)
   End Sub
   Public Shared Sub WriteParagraph(ByRef Abox As AllBox, ByVal ictrl%, ByVal istr$, ByVal LX%, ByVal RX%)
      'On Error Resume Next

      '0 - left
      '1 - right
      '2 - center

      Dim tx%, tX2&
      tx = CLng(CSng(LX / 300 * MAX_X))
      tX2 = CLng(CSng((300 - RX) / 300 * MAX_X))
      '      tX2 = MAX_X - tX2
      Abox.DefineStyle("Normal", "LeftMargin", CStr(tx))
      Abox.DefineStyle("Normal", "RightMargin", CStr(tX2))
      If ictrl = 0 Then Abox.DefineStyle("Normal", "Alignment", "Left")
      If ictrl = 1 Then Abox.DefineStyle("Normal", "Alignment", "Right")
      If ictrl = 2 Then Abox.DefineStyle("Normal", "Alignment", "Center")
      Abox.WritePara(istr, "Normal")

   End Sub
   Public Shared Sub BeginParagraph(ByRef Abox As AllBox, ByVal ictrl%, ByVal istr$, ByVal LX%, ByVal RX%)
      'On Error Resume Next

      '0 - left
      '1 - right
      '2 - center

      Dim tx%, tX2&
      tx = CLng(CSng(LX / 300 * MAX_X))
      tX2 = CLng(CSng((300 - RX) / 300 * MAX_X))
      '      tX2 = MAX_X - tX2
      If ictrl = 0 Then Abox.DefineStyle("Normal", "Alignment", "Left")
      If ictrl = 1 Then Abox.DefineStyle("Normal", "Alignment", "Right")
      If ictrl = 2 Then Abox.DefineStyle("Normal", "Alignment", "Center")
      Abox.DefineStyle("Normal", "LeftMargin", CStr(tx))
      Abox.DefineStyle("Normal", "RightMargin", CStr(tX2))
      Abox.BeginPara(istr, "Normal")

   End Sub
   Public Shared Sub AppendParagraph(ByRef Abox As AllBox, ByVal istr$, Optional ByVal LX% = -1, Optional ByVal RX% = -1, Optional ByVal ictrl% = 0)
      'On Error Resume Next

      '0 - left
      '1 - right
      '2 - center

      Dim tx%, tX2&
      If LX = -1 And RX = -1 Then
         Abox.AppendPara(istr, "Normal")
      Else
         tx = CLng(CSng(LX / 300 * MAX_X))
         tX2 = CLng(CSng((300 - RX) / 300 * MAX_X))
         '      tX2 = MAX_X - tX2
         Abox.DefineStyle("Normal", "LeftMargin", CStr(tx))
         Abox.DefineStyle("Normal", "RightMargin", CStr(tX2))
         If ictrl = 0 Then Abox.DefineStyle("Normal", "Alignment", "Left")
         If ictrl = 1 Then Abox.DefineStyle("Normal", "Alignment", "Right")
         If ictrl = 2 Then Abox.DefineStyle("Normal", "Alignment", "Center")
         Abox.AppendPara(istr, "Normal")
      End If
   End Sub

   Public Shared Sub EndParagraph(ByRef Abox As AllBox, ByVal istr$, Optional ByVal LX% = -1, Optional ByVal RX% = -1, Optional ByVal ictrl% = 0)
      'On Error Resume Next

      '0 - left
      '1 - right
      '2 - center

      Dim tx%, tX2&
      If LX = -1 And RX = -1 Then
         Abox.EndPara(istr, "Normal")
      Else
         tx = CLng(CSng(LX / 300 * MAX_X))
         tX2 = CLng(CSng((300 - RX) / 300 * MAX_X))
         '      tX2 = MAX_X - tX2
         Abox.DefineStyle("Normal", "LeftMargin", CStr(tx))
         Abox.DefineStyle("Normal", "RightMargin", CStr(tX2))
         If ictrl = 0 Then Abox.DefineStyle("Normal", "Alignment", "Left")
         If ictrl = 1 Then Abox.DefineStyle("Normal", "Alignment", "Right")
         If ictrl = 2 Then Abox.DefineStyle("Normal", "Alignment", "Center")
         Abox.WritePara(istr, "Normal")
      End If

   End Sub
   Public Shared Sub SetFont(ByRef Abox As AllBox, ByVal fname$, ByVal iSize&, ByVal bBold As Boolean, ByVal bUnderline As Boolean, ByVal bItalic As Boolean)
      'On Error Resume Next

      Abox.FontName = fname
      Abox.FontSize = iSize
      If bBold = True Then
         Abox.FontBold = True
      Else
         Abox.FontBold = False
      End If
      If bUnderline = True Then
         Abox.FontUnderline = True
      Else
         Abox.FontUnderline = False
      End If
      If bItalic = True Then
         Abox.FontItalic = True
      Else
         Abox.FontItalic = False
      End If
   End Sub
   Public Shared Sub SetFontAttr(ByRef Abox As AllBox, ByVal fType$, ByVal bAttr As Boolean, Optional ByVal iSize% = 0)
      'On Error Resume Next
      'B - Bold
      'U - Underline
      'I - Italic
      'S - Size is used
      If fType = "B" Then
         If bAttr = True Then
            Abox.FontBold = True
            Abox.DefineStyle("Normal", "FontBold", 1)
         Else
            Abox.FontBold = False
            Abox.DefineStyle("Normal", "FontBold", 0)
         End If
      End If
      If fType = "U" Then
         If bAttr = True Then
            Abox.FontUnderline = True
            Abox.DefineStyle("Normal", "FontUnderline", 1)
         Else
            Abox.FontUnderline = False
            Abox.DefineStyle("Normal", "FontUnderline", 0)
         End If
      End If
      If fType = "I" Then
         If bAttr = True Then
            Abox.FontItalic = True
            Abox.DefineStyle("Normal", "FontItalic", 1)
         Else
            Abox.FontItalic = False
            Abox.DefineStyle("Normal", "FontItalic", 0)
         End If
      End If
      If fType = "S" Then
         Abox.FontSize = iSize
         Abox.DefineStyle("Normal", "FontSize", CStr(iSize))
      End If
   End Sub
   Public Shared Sub TextColour(ByRef Abox As AllBox, ByVal iRED%, ByVal iGREEN%, ByVal iBLUE%)
      Abox.FontColor = RGB(iRED, iGREEN, iBLUE)
   End Sub
   Public Shared Sub SetThickness(ByRef Abox As AllBox, ByVal iThickness%)
      Abox.PenWidth = iThickness
   End Sub
   Public Shared Sub DrawLine(ByRef Abox As AllBox, ByVal iX1%, ByVal iY1%, ByVal iX2%, ByVal iY2%)
      Dim tx%, tY%

      tx = CLng(CSng(iX1 / 300 * MAX_X))
      tY = CLng(CSng(iY1 / 300 * MAX_Y))
      Abox.MoveTo(tx, tY)
      tx = CLng(CSng(iX2 / 300 * MAX_X))
      tY = CLng(CSng(iY2 / 300 * MAX_Y))
      Abox.LineTo(tx, tY)
   End Sub
   Public Shared Sub DrawGrid(ByRef Abox As AllBox, ByVal iLeft&, ByVal iRight&, ByVal iGrids&, ByVal iHeight&, ByVal iBackground&, ByVal iBorder&, ByVal iAlignment&, ByVal iMargin&, ByVal iColAlignment&, Optional ByVal iVerAlignment% = 0)
      Dim tx%, cX%, tLX%, tRX%, tW%, tI%, tF%

      If iBorder = 1 Then
         Abox.BrushStyle = 1
      End If
      If iBorder = 0 Then
         Abox.BrushStyle = 0
      End If

      If iBackground = 0 Then 'White
         Abox.BrushColor = RGB(255, 255, 255)
      End If
      If iBackground = 1 Then 'Silver
         Abox.BrushColor = RGB(229, 229, 229)
      End If
      If iBackground = 2 Then 'black
         Abox.BrushColor = RGB(0, 0, 0)
      End If

      tF = 0
      tI = 0
      tLX = CLng(CSng((iLeft + XSMIDGE) / 300 * MAX_X))
      tRX = CLng(CSng(iRight / 300 * MAX_X))
      tW = (tRX - tLX) / iGrids
      Abox.DefineGrid("GridBody", iAlignment, iMargin)
      cX = tLX
      For tI = 1 To iGrids
         tx = tW
         If tI = iGrids Then
            tx = tRX - cX
         End If
         cX = cX + tx
         Abox.DefineCol("GridBody", tx, iColAlignment, iVerAlignment, True)
      Next
      POS_X = tx
      POS_Y = gY
      Abox.DefineCol("GridBody", 0, iColAlignment, iVerAlignment, True) 'close the grid right
      Abox.DrawGrid("GridBody", tLX, gY)
      gY = gY + iHeight
      Abox.DrawRow("GridBody", iHeight)
      Abox.DrawRow("GridBody", 0)
   End Sub
   Public Shared Sub DrawGridVariable(ByRef Abox As AllBox, ByVal iLeft&, ByVal iRight&, ByVal szGrid$, ByVal iHeight&, ByVal iBackground&, ByVal iBorder&, ByVal iAlignment&, ByVal iMargin&, ByVal iColAlignment&, Optional ByVal iVerAlignment% = 0)
      Dim tx%, cX%, tLX%, tRX%, tW%, tI%, tF%, iGrids&, tdta$()

      tdta = Split(szGrid, "^")
      iGrids = CLng(tdta(0))
      If iBorder = 1 Then
         Abox.BrushStyle = 1
      End If
      If iBorder = 0 Then
         Abox.BrushStyle = 0
      End If

      If iBackground = 0 Then 'White
         Abox.BrushColor = RGB(255, 255, 255)
      End If
      If iBackground = 1 Then 'Silver
         Abox.BrushColor = RGB(229, 229, 229)
      End If
      If iBackground = 2 Then 'black
         Abox.BrushColor = RGB(0, 0, 0)
      End If

      tF = 0
      tI = 0
      tLX = CLng(CSng((iLeft + XSMIDGE) / 300 * MAX_X))
      tRX = CLng(CSng(iRight / 300 * MAX_X))
      tW = (tRX - tLX) / iGrids
      Abox.DefineGrid("GridBody", iAlignment, iMargin)
      cX = tLX
      For tI = 1 To iGrids
         tW = CLng(CSng(tdta(tI) / 300) * MAX_X)
         tx = tW
         If tI = iGrids Then
            tx = tRX - cX
         End If
         cX = cX + tx
         Abox.DefineCol("GridBody", tx, iColAlignment, iVerAlignment, True)
      Next
      POS_X = tx
      POS_Y = gY
      Abox.DefineCol("GridBody", 0, iColAlignment, iVerAlignment, True)
      Abox.DrawGrid("GridBody", tLX, gY)
      gY = gY + iHeight
      Abox.DrawRow("GridBody", iHeight)
      Abox.DrawRow("GridBody", 0) 'close the grid on the bottom
   End Sub
   Public Shared Sub WriteCellValue(ByRef Abox As AllBox, ByVal iCell&, ByVal iTEXT$)
      Abox.TextToCell("GridBody", iCell, 0, Chr(13) + " " + iTEXT)
   End Sub
   Public Shared Sub WriteCell(ByRef Abox As AllBox, ByVal iCell&, ByVal iTEXT$)
      Abox.TextToCell("GridBody", iCell, 0, " " + iTEXT)
   End Sub
   Public Shared Sub WriteCellValueNSP(ByRef Abox As AllBox, ByVal iCell&, ByVal iTEXT$)
      Abox.TextToCell("GridBody", iCell, 0, Chr(13) + iTEXT)
   End Sub
   Public Shared Sub WriteCellNSP(ByRef Abox As AllBox, ByVal iCell&, ByVal iTEXT$)
      Abox.TextToCell("GridBody", iCell, 0, iTEXT)
   End Sub
   Public Shared Sub DrawImage(ByRef Abox As AllBox, ByVal iX&, ByVal iY&, ByVal iWidth&, ByVal iFile$)
      Dim tx%, tY%, tW%

      If Not File.Exists(iFile) Then Exit Sub

      tx = CLng(CSng(iX / 300 * MAX_X))
      tY = CLng(CSng(iY / 300 * MAX_Y))
      tW = CLng(CSng(iWidth / 300 * MAX_X))
      POS_X = tx
      POS_Y = tY

      Abox.SmartStretchDraw = True
      Abox.SmartHorzAlignment = 0
      Abox.SmartVertAlignment = 0
      Abox.StretchDrawFromFile(tx, tY, tW + tx, tY + 1000, iFile)

   End Sub
   Public Shared Sub HeaderFooter(Abox As AllBox, iHeader%, iFooter%, iPage%)
      Dim tstr1$

      If iPage > 1 Then
         Abox.NewPage()
      End If

      DrawImage(Abox, LM, 4, 45, IMAGES + "logo.png")

      Y = 290
      DrawLine(Abox, LM, Y, RM, Y)
      SetFontAttr(Abox, "S", True, 8)
      SetFontAttr(Abox, "B", False, 7)
      Y += 1

      X = LM
      tstr1 = DateFormat(Now, dr.sr_iRlanguage, 1, 1)
      WriteText(Abox, 0, tstr1)

      X = 150
      tstr1 = Txt(372) + ": " + CStr(iPage)
      WriteText(Abox, 2, tstr1)

      X = RM
      tstr1 = Txt(371) + " " + dr.cr_szVersion
      WriteText(Abox, 1, tstr1)

   End Sub
   Public Shared Sub GenerateAudit(AUD_TYPE&, AUD_KEY&)
      Dim tstr1$, tstr2$, tSW%, hLANG%
      Dim Abox As New All_In_The_Box.AllBox

      hLANG = dr.sr_iRlanguage

      InitializePDF(Abox, 1)

      LM = 10
      RM = 290

      rcols(0) = LM   'date
      rcols(1) = 75   'user
      rcols(2) = 140  'detail

      GenerateAuditHeader(Abox, PAGE_CNT, AUD_TYPE, dr)
      TestConnection()
      Dim strsql$ = "select  * from AUD_AUDIT left join USR_USER on au_USR_USER = uu_iid where au_iType = " + CStr(AUD_TYPE) + " and au_iKey = " + CStr(AUD_KEY) + " order by au_iid "
      Err.Clear()
      tstr1 = ""
      dr.ocmd.CommandText = strsql
      dr.oread = dr.ocmd.ExecuteReader()

      If dr.oread.HasRows = True Then
         While dr.oread.Read() = True
            If Err.Number <> 0 Then Exit While
            tSW = 0
            If Y >= 285 Then
               GenerateAuditHeader(Abox, PAGE_CNT, AUD_TYPE, dr)
               tSW = 1
            End If
            If dr.oread("au_iCount") = 0 Then tSW = 1
            If dr.sr_iRlanguage = FRENCH Then
               tstr2 = dr.oread("au_szFrnstr")
            Else
               tstr2 = dr.oread("au_szEngstr")
            End If
            If tstr2 <> "" Then
               If tSW = 1 Then
                  Y += 1
                  X = rcols(0)
                  tstr1 = DateFormat(dr.oread("au_dDate"), dr.sr_iRlanguage, 1, 1)
                  WriteText(Abox, 0, tstr1)
                  X = rcols(1)
                  tstr1 = dr.oread("uu_szFirst") + " " + dr.oread("uu_szLast")
                  WriteText(Abox, 0, tstr1)
               End If
               X = rcols(2)
               WriteText(Abox, 0, tstr2)
               Y += 5
            End If
         End While
      End If
      dr.oread.Close()

      FinalizePDF(Abox)

      dr.sr_iRlanguage = hLANG
   End Sub
   Public Shared Sub GenerateAuditHeader(Abox As AllBox, ByRef iPage%, AUD_TYPE%, ByRef dr As DATA_RECORD)
      Dim tstr1$

      iPage += 1

      HeaderFooter(Abox, 1, 1, iPage)

      SetFont(Abox, "Arial", 18, True, False, False)
      X = RM
      Y = 9
      tstr1 = ""
      If AUD_TYPE = AUDIT_COMPANY Then tstr1 = Txt(373)
      WriteText(Abox, 1, tstr1)
      Y += 10
      SetFontAttr(Abox, "S", True, 9)
      SetFontAttr(Abox, "B", True, 0)
      tstr1 = ""
      If AUD_TYPE = AUDIT_COMPANY Then
         tstr1 = Txt(374) + " " + CStr(dr.co_iid)
         If dr.co_szCompanyName <> "" Then
            tstr1 += ", " + Txt(375) + " " + CStr(dr.co_szCompanyName)
         End If
      End If
      WriteText(Abox, 1, tstr1)

      Y += 17
      SetFontAttr(Abox, "S", True, 9)
      SetFontAttr(Abox, "B", True, 0)
      SetFontAttr(Abox, "U", True, 0)
      X = rcols(0)
      WriteText(Abox, 0, Txt(378))
      X = rcols(1)
      WriteText(Abox, 0, Txt(376))
      X = rcols(2)
      WriteText(Abox, 0, Txt(377))
      Y += 7

      SetFontAttr(Abox, "S", True, 9)
      SetFontAttr(Abox, "B", False, 0)
      SetFontAttr(Abox, "U", False, 0)
   End Sub
End Class
