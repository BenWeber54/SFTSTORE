Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports SFTSTORE.ftn
Imports SFTSTORE.data

Public Class listfrm

   Dim tCNT&
   Dim LISTSORT%(10)

#Region "lst routines"
   Private Sub lst_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst.ColumnClick
      Dim tCOL%, tI%, tJ%, tK%, tstr1$, tSORT%, tSW%, tTEST$, tAGAINST$, tSORTED%

      tCOL = e.Column
      If LISTSORT(tCOL) = 1 Then
         LISTSORT(tCOL) = 0
      Else
         LISTSORT(tCOL) = 1
      End If
      tSORT = LISTSORT(tCOL)

      If lst.Items.Count < 2 Then Exit Sub

      tCNT = lst.Items.Count - 1

      tSORTED = 0

      For tI = 0 To tCNT - 1
         For tJ = tI + 1 To tCNT
            Dim lstI As ListViewItem = lst.Items(tI)
            Dim lstJ As ListViewItem = lst.Items(tJ)
            tTEST = lstJ.SubItems(tCOL).Text
            tAGAINST = lstI.SubItems(tCOL).Text
            If Len(tTEST) >= 6 And Len(tAGAINST) >= 6 Then
               If IsDate(tTEST) = True And IsDate(tAGAINST) = True Then
                  tTEST = Format(CDate(tTEST), "yyyyMMddhhmmss")
                  tAGAINST = Format(CDate(tAGAINST), "yyyyMMddhhmmss")
               End If
            End If
            tSW = 0
            If tSORT = 0 Then
               If tTEST < tAGAINST Then tSW = 1
            Else
               If tTEST > tAGAINST Then tSW = 1
            End If
            If tSW = 1 Then
               tSORTED = 1
               tstr1 = lstI.Tag
               lstI.Tag = lstJ.Tag
               lstJ.Tag = tstr1
               If lstI.SubItems.Count >= 0 Then
                  For tK = 0 To lstI.SubItems.Count - 1
                     tstr1 = lstI.SubItems(tK).Text
                     lstI.SubItems(tK).Text = lstJ.SubItems(tK).Text
                     lstJ.SubItems(tK).Text = tstr1
                  Next
               End If
            End If
         Next
      Next
      If tSORTED = 1 Then lst.Invalidate()
   End Sub

   Private Sub lst_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lst.DrawColumnHeader
      Dim strFormat As New StringFormat()
      strFormat.Alignment = HorizontalAlignment.Left
      If e.Header.TextAlign = HorizontalAlignment.Center Then
         strFormat.Alignment = StringAlignment.Center
      ElseIf e.Header.TextAlign = HorizontalAlignment.Right Then
         strFormat.Alignment = StringAlignment.Far
      End If
      e.DrawBackground()
      e.Graphics.FillRectangle(Brushes.SteelBlue, e.Bounds)
      Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
      e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.White, e.Bounds, strFormat)
   End Sub

   Private Sub lst_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles lst.DrawItem
      Dim strFormat As New StringFormat()
      Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
      If Not (e.State And ListViewItemStates.Selected) = 0 Then
         ' Draw the background for a selected item.
         e.Graphics.FillRectangle(Brushes.Blue, e.Bounds)
         e.DrawFocusRectangle()
      Else
         ' Draw the background for an unselected item. 
         Dim brush As New LinearGradientBrush(e.Bounds, Color.White, _
             Color.LightBlue, LinearGradientMode.Horizontal)
         Try
            e.Graphics.FillRectangle(brush, e.Bounds)
         Finally
            brush.Dispose()
         End Try
      End If
      ' Draw the item text for views other than the Details view. 
      If Not Me.lst.View = View.Details Then
         'e.Graphics.DrawString(e.Item.Text, headerFont, Brushes.White, e.Bounds, strFormat)
         e.DrawText()
      End If
   End Sub
   ' Selects and focuses an item when it is clicked anywhere along  
   ' its width. The click must normally be on the parent item text. 
   Private Sub lst_MouseUp(ByVal sender As Object, _
       ByVal e As MouseEventArgs) Handles lst.MouseUp

      If dr.LIST_RET = 1 Then
         Exit Sub
      End If
      Dim clickedItem As ListViewItem = Me.lst.GetItemAt(5, e.Y)
      If (clickedItem IsNot Nothing) Then
         clickedItem.Selected = True
         clickedItem.Focused = True
      End If
   End Sub
   Private Sub lst_MouseMove(ByVal sender As Object, _
       ByVal e As MouseEventArgs) Handles lst.MouseMove
      Dim item As ListViewItem = lst.GetItemAt(e.X, e.Y)
      If item IsNot Nothing AndAlso InStr(item.Tag, "tagged") = 0 Then
         lst.Invalidate(item.Bounds)
         item.Tag = item.Tag + "tagged"
      End If
   End Sub
   Private Sub lst_Invalidated(ByVal sender As Object, _
       ByVal e As InvalidateEventArgs) Handles lst.Invalidated
      For Each item As ListViewItem In lst.Items
         If item Is Nothing Then Return
         item.Tag = CStr(GetFloat(item.Tag))
      Next
   End Sub
   ' Forces the entire control to repaint if a column width is changed. 
   Private Sub lst_ColumnWidthChanged(ByVal sender As Object, _
       ByVal e As ColumnWidthChangedEventArgs) Handles lst.ColumnWidthChanged
      lst.Invalidate()
   End Sub
   Private Sub lst_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lst.DrawSubItem
      Dim flags As TextFormatFlags = TextFormatFlags.Left
      Dim fnt As New Font("Arial", 12)
      Dim sf As New StringFormat()
      Try
         ' Store the column text alignment, letting it default 
         ' to Left if it has not been set to Center or Right. 
         Select Case e.Header.TextAlign
            Case HorizontalAlignment.Center
               sf.Alignment = StringAlignment.Center
               flags = TextFormatFlags.HorizontalCenter
            Case HorizontalAlignment.Right
               sf.Alignment = StringAlignment.Far
               flags = TextFormatFlags.Right
         End Select

         ' Draw the text and background for a subitem with a  
         ' negative value.  
         Dim subItemValue As Double
         If e.ColumnIndex > 0 AndAlso _
             Double.TryParse(e.SubItem.Text, NumberStyles.Currency, _
             NumberFormatInfo.CurrentInfo, subItemValue) AndAlso _
             subItemValue < 0 Then

            ' Unless the item is selected, draw the standard  
            ' background to make it stand out from the gradient. 
            If (e.ItemState And ListViewItemStates.Selected) = 0 Then
               e.DrawBackground()
            End If

            ' Draw the subitem text in red to highlight it. 
            e.Graphics.DrawString(e.SubItem.Text, _
                fnt, Brushes.Red, e.Bounds, sf)
            'Me.lst.Font, Brushes.Red, e.Bounds, sf)
            Return
         End If
         ' Draw normal text for a subitem with a nonnegative  
         ' or nonnumerical value.
         'e.DrawText(flags)
         e.Graphics.DrawString(e.SubItem.Text, _
             fnt, Brushes.Black, e.Bounds, sf)
      Finally
         sf.Dispose()
      End Try
   End Sub
   Private Sub lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst.SelectedIndexChanged
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected Then
            'Me.Text = itm.Tag
         End If
      Next
   End Sub

   Private Sub listfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim tl1&
      Dim ft As New Font(lst.Font.Name, 12)
      dr.LIST_RET = 0
      lst.Font = ft
      ListRefresh(0)

      Me.AcceptButton = brefresh
      For tl1 = 0 To UBound(LISTSORT)
         LISTSORT(tl1) = 1
      Next
      LISTSORT(0) = 0
      'If dr.LIST_CTRL = 3 Then tb.TabPages.Remove(TabPage2) : TabPage1.Text = "Most Recent List"
   End Sub
#End Region
   Private Sub brefresh_Click(sender As Object, e As EventArgs) Handles brefresh.Click
      ListRefresh(1)
      'If InStr(1, Me.Text, "(") > 0 Then
      '   tb.SelectedTab = TabPage1
      'End If
   End Sub
   Private Sub ListRefresh(ctrl%)
      lst.Clear()
      lst.View = View.Details
      Dim tdta$(), tl1&
      '1 = select company
      '2 = Most recent
      '3 = select notes
      TestConnection()
      Select Case dr.LIST_CTRL
         Case 1
            lbl1.Visible = True
            lbl2.Visible = True
            txt1.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(362) + ":"
            lbl2.Text = Txt(364) + ":"
            lst.Columns.Add(Txt(362), lst.Width - 205, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(363), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM COM_COMPANY WHERE co_iid > 0"
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and co_szCompanyName like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and co_szEmail like '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by co_szCompanyName"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("co_szCompanyName")))
                  ListItem1.Tag = CStr(dr.oread("co_iid"))
                  ListItem1.SubItems.Add(Format(dr.oread("co_dDate"), "MMM-dd-yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 2
            brefresh.Visible = False
            tl1 = lst.Top - brefresh.Top
            lst.Top = brefresh.Top
            lst.Height += tl1
            lst.Columns.Add(Txt(367), lst.Width - 405, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(368), 200, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(369), 200, HorizontalAlignment.Left)
            If InStr(1, dr.mr_szData, "|") > 0 Then
               tdta = Split(dr.mr_szData, "|")
               For tl1 = 0 To UBound(tdta) - 1 Step 4
                  Dim ListItem1 As New ListViewItem(tdta(tl1 + 1))
                  ListItem1.Tag = CStr(tdta(tl1 + 0))
                  ListItem1.SubItems.Add(tdta(tl1 + 2))
                  ListItem1.SubItems.Add(tdta(tl1 + 3))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Next
            End If
         Case 3
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(422) + ":"
            lbl2.Text = Txt(377) + ":"
            lst.Columns.Add(Txt(378), lst.Width - 405, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(422), 200, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(377), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "select * from NOT_NOTES where no_iid > 0 and no_iType = " + CStr(dr.NOTES_TYPE) + " and no_iKey = " + CStr(dr.NOTES_KEY)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and no_szSubject like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and no_szDetail like '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by no_dDate desc"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(Format(dr.oread("no_dDate"), "dd/MMM/yyyy h:mm tt"))
                  ListItem1.Tag = CStr(dr.oread("no_iid"))
                  ListItem1.SubItems.Add(dr.oread("no_szSubject"))
                  ListItem1.SubItems.Add(RemoveHardReturn(dr.oread("no_szDetail")))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 4
            lbl1.Visible = True
            txt1.Visible = True
            lst.Columns.Add(Txt(368), lst.Width - 255, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 250, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "select * from ATT_ATTACHMENTS where at_iid > 0 and at_iType = " + CStr(dr.ATTACHMENT_TYPE) + " and at_iKey = " + CStr(dr.ATTACHMENT_KEY)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and at_szSubject like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by at_dDate desc"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("at_szSubject")))
                  ListItem1.SubItems.Add(Format(dr.oread("at_dDate"), "dd/MMM/yyyy hh:mm:ss tt"))
                  ListItem1.Tag = CStr(dr.oread("at_iid"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 5
            lst.Columns.Add(Txt(368), lst.Width - 455, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(500), 250, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM COM_IMAGES WHERE ci_iid > 0 and ci_COM_COMPANY = " + CStr(dr.IMAGE_KEY)
            dr.ocmd.CommandText += " ORDER by ci_dDate desc"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(Txt(474 + dr.oread("ci_iType")))
                  ListItem1.SubItems.Add(dr.oread("ci_szFilename"))
                  ListItem1.SubItems.Add(Format(dr.oread("ci_dDate"), "dd/MMM/yyyy hh:mm:ss tt"))
                  ListItem1.Tag = CStr(dr.oread("ci_iid"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 6, 7
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl3.Visible = True
            txt3.Visible = True
            lbl1.Text = Txt(515) + ":"
            lbl2.Text = Txt(514) + ":"
            lbl3.Text = Txt(516) + ":"
            lst.Columns.Add(Txt(515), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(514), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(365), lst.Width - 455, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(503), 150, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "select * from USR_USER where uu_iid > 0 AND uu_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and uu_szLast like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and uu_szFirst like '%" + AStr(txt2.Text) + "%'"
            End If
            If txt3.Text <> "" Then
               If IsNumeric(txt3.Text) = True Then
                  dr.ocmd.CommandText += " and uu_iid = " + txt3.Text + ""
               Else
                  txt3.Text = ""
               End If
            End If
            dr.ocmd.CommandText += " order by uu_szLast, uu_szFirst"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("uu_szLast")) + "(" + CStr(dr.oread("uu_iid")) + ")")
                  ListItem1.Tag = CStr(dr.oread("uu_iid"))
                  ListItem1.SubItems.Add(dr.oread("uu_szFirst"))
                  If dr.oread("uu_szCompany") <> "" Then
                     ListItem1.SubItems.Add(dr.oread("uu_szCompany"))
                  Else
                     ListItem1.SubItems.Add("*** NO COMPANY ***")
                  End If
                  ListItem1.SubItems.Add(RemoveHardReturn(dr.oread("uu_szPhone")))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 8, 16, 19
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl3.Visible = True
            txt3.Visible = True
            lbl1.Text = Txt(546) + ":"
            lbl2.Text = Txt(547) + ":"
            lbl3.Text = Txt(548) + ":"
            lst.Columns.Add(Txt(546), lst.Width - 505, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(547), 200, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(548), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(363), 150, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRO_PRODUCT JOIN PRO_TYPE ON pt_iid = pp_PRO_TYPE WHERE pp_iid > 0 AND pp_COM_COMPANY = " + CStr(dr.sr_iCompany)
            dr.ocmd.CommandText += " AND pt_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and pp_szProductNumber like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and pp_szProductName like '%" + AStr(txt2.Text) + "%'"
            End If
            If txt3.Text <> "" Then
               dr.ocmd.CommandText += " and pt_szTypeName LIKE '%" + AStr(txt3.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by pp_szProductNumber, pp_szProductName"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("pp_szProductNumber")))
                  ListItem1.Tag = CStr(dr.oread("pp_iid"))
                  ListItem1.SubItems.Add(dr.oread("pp_szProductName"))
                  ListItem1.SubItems.Add(dr.oread("pt_szTypeName"))
                  ListItem1.SubItems.Add(Format(dr.oread("pp_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 9
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(552) + ":"
            lst.Columns.Add(Txt(552), lst.Width - 305, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(553), 100, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRO_IMAGE WHERE pi_iid > 0 AND pi_PRO_PRODUCT = " + CStr(dr.pp_iid)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and pi_szImage like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by pi_iOrder"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("pi_szImage")))
                  ListItem1.Tag = CStr(dr.oread("pi_iid"))
                  ListItem1.SubItems.Add(dr.oread("pi_iOrder"))
                  ListItem1.SubItems.Add(Format(dr.oread("pi_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 10
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(573) + ":"
            lst.Columns.Add(Txt(573), lst.Width - 205, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRO_TYPE WHERE pt_iid > 0 AND pt_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and pt_szTypeName like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by pt_szTypeName"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("pt_szTypeName")))
                  ListItem1.Tag = CStr(dr.oread("pt_iid"))
                  ListItem1.SubItems.Add(Format(dr.oread("pt_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 11, 14, 18
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(514) + ":"
            lbl2.Text = Txt(515) + ":"
            lst.Columns.Add(Txt(514), lst.Width - 355, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(515), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM CUS_CUSTOMER WHERE cu_iid > 0 AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and cu_szFirst like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and cu_szLast like '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by cu_szLast, cu_szFirst"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("cu_szLast")))
                  ListItem1.Tag = CStr(dr.oread("cu_iid"))
                  ListItem1.SubItems.Add(dr.oread("cu_szFirst"))
                  ListItem1.SubItems.Add(Format(dr.oread("cu_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 12, 15, 21, 25
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(598) + ":"
            lbl2.Text = Txt(599) + ":"
            lst.Columns.Add(Txt(598), lst.Width - 355, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(599), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            If dr.LIST_CTRL = 12 Or dr.LIST_CTRL = 21 Then
               dr.ocmd.CommandText = "SELECT * FROM CUS_ADDRESS WHERE ca_iid > 0 AND ca_CUS_CUSTOMER = " + CStr(dr.cu_iid)
            ElseIf dr.LIST_CTRL = 15 Or dr.LIST_CTRL = 25 Then
               dr.ocmd.CommandText = "SELECT * FROM CUS_ADDRESS WHERE ca_iid > 0 AND ca_CUS_CUSTOMER = " + CStr(dr.oo_CUS_CUSTOMER)
            End If
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and ca_szTitle like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and ca_szName like '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by ca_szTitle"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("ca_szTitle")))
                  ListItem1.Tag = CStr(dr.oread("ca_iid"))
                  ListItem1.SubItems.Add(dr.oread("ca_szName"))
                  ListItem1.SubItems.Add(Format(dr.oread("ca_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 13, 24
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(636) + ":"
            lbl2.Text = Txt(585) + ":"
            lst.Columns.Add(Txt(636), 150, HorizontalAlignment.Left)
            'lst.Columns.Add(Txt(637), , HorizontalAlignment.Left)
            lst.Columns.Add(Txt(585), lst.Width - 275, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(638), 120, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM ORD_ORDERS JOIN CUS_CUSTOMER ON cu_iid = oo_CUS_CUSTOMER WHERE oo_iid > 0 AND cu_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and oo_iid like '%" + CStr(GetFloat(txt1.Text)) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and (cu_szFirst like '%" + AStr(txt2.Text) + "%'"
               dr.ocmd.CommandText += " OR cu_szLast like '%" + AStr(txt2.Text) + "%')"
            End If
            dr.ocmd.CommandText += " order by oo_dOrderDate Desc"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("oo_iid")))
                  ListItem1.Tag = CStr(dr.oread("oo_iid"))
                  'ListItem1.SubItems.Add(dr.oread("oo_szTracking"))
                  ListItem1.SubItems.Add(dr.oread("cu_szLast") + ", " + dr.oread("cu_szFirst"))
                  ListItem1.SubItems.Add(Format(dr.oread("oo_dOrderDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 17
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(660) + ":"
            lbl2.Text = Txt(585) + ":"
            lst.Columns.Add(Txt(660), 200, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(585), lst.Width - 305, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(671), 100, HorizontalAlignment.Center)
            dr.ocmd.CommandText = "SELECT * FROM PRO_FEEDBACK JOIN PRO_PRODUCT ON pp_iid = pf_PRO_PRODUCT"
            dr.ocmd.CommandText += " JOIN CUS_CUSTOMER ON pf_CUS_CUSTOMER = cu_iid"
            dr.ocmd.CommandText += " WHERE pf_PRO_PRODUCT = " + CStr(dr.pp_iid)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and pp_szProductName LIKE '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and cu_szDisplay LIKE '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by pp_szProductName, pf_iRating"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("pp_szProductName")))
                  ListItem1.Tag = CStr(dr.oread("pf_iid"))
                  ListItem1.SubItems.Add(dr.oread("cu_szDisplay"))
                  ListItem1.SubItems.Add(dr.oread("pf_iRating"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 20
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(704) + ":"
            lst.Columns.Add(Txt(704), lst.Width - 305, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(706), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(708), 150, HorizontalAlignment.Center)
            dr.ocmd.CommandText = "SELECT * FROM CUS_BILLING WHERE cb_CUS_CUSTOMER = " + CStr(dr.cu_iid)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and cb_szTitle LIKE '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by cb_szTitle"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("cb_szTitle")))
                  ListItem1.Tag = CStr(dr.oread("cb_iid"))
                  If dr.oread("cb_iCardType") = 1 Then
                     ListItem1.SubItems.Add(Txt(710))
                  ElseIf dr.oread("cb_iCardType") = 2 Then
                     ListItem1.SubItems.Add(Txt(711))
                  Else
                     ListItem1.SubItems.Add(Txt(712))
                  End If
                  Dim expiry$()
                  Dim month& = 0, year& = 0
                  expiry = Split(dr.oread("cb_szExpiry"), "|")
                  ListItem1.SubItems.Add(Txt(399 + CLng(expiry(0))) + ", " + expiry(1))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 22, 23
            lbl1.Visible = True
            txt1.Visible = True
            lbl2.Visible = True
            txt2.Visible = True
            lbl1.Text = Txt(598) + ":"
            lbl2.Text = Txt(599) + ":"
            lst.Columns.Add(Txt(598), lst.Width - 355, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(599), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
            If dr.LIST_CTRL = 22 Then
               dr.ocmd.CommandText = "SELECT * FROM COM_ADDRESS WHERE ch_iid > 0 AND ch_COM_COMPANY = " + CStr(dr.co_iid)
            Else
               dr.ocmd.CommandText = "SELECT * FROM COM_ADDRESS WHERE ch_iid > 0 AND ch_COM_COMPANY = " + CStr(dr.sr_iCompany)
            End If
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and ch_szTitle like '%" + AStr(txt1.Text) + "%'"
            End If
            If txt2.Text <> "" Then
               dr.ocmd.CommandText += " and ch_szName like '%" + AStr(txt2.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by ch_szTitle"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("ch_szTitle")))
                  ListItem1.Tag = CStr(dr.oread("ch_iid"))
                  ListItem1.SubItems.Add(dr.oread("ch_szName"))
                  ListItem1.SubItems.Add(Format(dr.oread("ch_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 26, 27
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(773) + ":"
            lst.Columns.Add(Txt(773), lst.Width - 455, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(727), 100, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(728), 100, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(729), 100, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(378), 150, HorizontalAlignment.Left)
            If dr.FRMSWT = 1 Then
               dr.ocmd.CommandText = "SELECT * FROM COM_BOXES WHERE cx_iid > 0 AND cx_COM_COMPANY = " + CStr(dr.sr_iCompany)
            Else
               dr.ocmd.CommandText = "SELECT * FROM COM_BOXES WHERE cx_iid > 0 AND cx_COM_COMPANY = " + CStr(dr.co_iid)
            End If

            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and cx_rMaxWeight like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by cx_rMaxWeight"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("cx_rMaxWeight")))
                  ListItem1.Tag = CStr(dr.oread("cx_iid"))
                  ListItem1.SubItems.Add(dr.oread("cx_rLength"))
                  ListItem1.SubItems.Add(dr.oread("cx_rWidth"))
                  ListItem1.SubItems.Add(dr.oread("cx_rHeight"))
                  ListItem1.SubItems.Add(Format(dr.oread("cx_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 28
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(798) + ":"
            lst.Columns.Add(Txt(798), lst.Width - 105, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(363), 100, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM LAN_FILTER WHERE lf_iid > 0 "
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and lf_szFilter like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by lf_szFilter"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("lf_szFilter")))
                  ListItem1.Tag = CStr(dr.oread("lf_iid"))
                  ListItem1.SubItems.Add(Format(dr.oread("lf_dDate"), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 29
            Dim tstr1$ = ""
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(875) + ":"
            lst.Columns.Add(Txt(861), 150, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(875), lst.Width - 395, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(863), 120, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(864), 120, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRM_CODES WHERE po_iid > 0 AND po_COM_COMPANY = " + CStr(dr.sr_iCompany)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and po_szCode like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by po_dStart"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  tstr1 = ""
                  If dr.oread("po_iDiscountType") = 0 Then
                     tstr1 = "$" + StringFormatEnglish(2, dr.oread("po_rDiscount"))
                  Else
                     tstr1 = StringFormatEnglish(2, dr.oread("po_rDiscount")) + "%"
                  End If
                  Dim ListItem1 As New ListViewItem(CStr(tstr1))
                  ListItem1.Tag = CStr(dr.oread("po_iid"))
                  ListItem1.SubItems.Add(dr.oread("po_szCode"))
                  ListItem1.SubItems.Add(Format(CDate(dr.oread("po_dStart")), "dd/MMM/yyyy"))
                  ListItem1.SubItems.Add(Format(CDate(dr.oread("po_dEnd")), "dd/MMM/yyyy"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 30
            Dim tstr1$ = ""
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(573) + ":"
            lst.Columns.Add(Txt(232), 120, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(573), lst.Width - 275, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(363), 150, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRO_SUB_TYPE WHERE ps_iid > 0 AND ps_PRO_TYPE = " + CStr(dr.pt_iid)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and ps_szName like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by ps_szName"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("ps_iid")))
                  ListItem1.Tag = CStr(dr.oread("ps_iid"))
                  ListItem1.SubItems.Add(dr.oread("ps_szName"))
                  ListItem1.SubItems.Add(Format(CDate(dr.oread("ps_dDate")), "dd/MMM/yyyy hh:mm:ss"))
                  lst.Items.Add(ListItem1)
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
         Case 31
            Dim tstr1$ = "", tstr2$ = "", tl2& = 0
            Dim tdta1$()

            dr.ocmd.CommandText = "SELECT py_PRO_SUB_TYPE FROM PRO_PRODUCT_TYPES WHERE py_PRO_PRODUCT = " + CStr(dr.pp_iid)
            dr.oread = dr.ocmd.ExecuteReader()
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read()
                  tstr2 += CStr(dr.oread("py_PRO_SUB_TYPE")) + "|"
               Loop
            Else
               tstr2 = "" + "|"
            End If
            dr.oread.Close()
            tdta1 = Split(tstr2, "|")

            TestConnection()
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = Txt(573) + ":"
            lst.Columns.Add(Txt(232), 120, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(573), lst.Width - 275, HorizontalAlignment.Left)
            lst.Columns.Add(Txt(363), 150, HorizontalAlignment.Left)
            dr.ocmd.CommandText = "SELECT * FROM PRO_SUB_TYPE WHERE ps_iid > 0 AND ps_PRO_TYPE = " + CStr(dr.pp_PRO_TYPE)
            If txt1.Text <> "" Then
               dr.ocmd.CommandText += " and ps_szName like '%" + AStr(txt1.Text) + "%'"
            End If
            dr.ocmd.CommandText += " order by ps_szName"
            dr.oread = dr.ocmd.ExecuteReader
            tCNT = 0
            If dr.oread.HasRows = True Then
               Do While dr.oread.Read
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("ps_iid")))
                  ListItem1.Tag = CStr(dr.oread("ps_iid"))
                  ListItem1.SubItems.Add(dr.oread("ps_szName"))
                  ListItem1.SubItems.Add(Format(CDate(dr.oread("ps_dDate")), "dd/MMM/yyyy hh:mm:ss"))
                  tl2 = 0
                  For tl1 = 0 To UBound(tdta1) - 1
                     If CStr(dr.oread("ps_iid")) = tdta1(tl1) Then
                        tl2 = 1
                     End If
                  Next
                  If tl2 = 0 Then
                     lst.Items.Add(ListItem1)
                  End If
                  tCNT += 1
               Loop
            End If
            dr.oread.Close()
            If lst.Items.Count = 0 Then
               MsgDsp(Txt(361))
               Me.Close()
            End If
      End Select

      'Me.Text = ""
      Select Case dr.LIST_CTRL
         Case 1
            Me.Text = Txt(365)
         Case 2
            Me.Text = Txt(370)
         Case 4
            Me.Text = Txt(385)
         Case 5
            Me.Text = Txt(501)
         Case 6, 7
            Me.Text = Txt(388)
         Case 8, 13, 16, 19, 24
            Me.Text = Txt(387)
         Case 9
            Me.Text = Txt(550)
         Case 10
            Me.Text = Txt(548)
         Case 11, 14, 18
            Me.Text = Txt(585)
         Case 12, 15, 25
            Me.Text = Txt(597)
         Case 13
            Me.Text = Txt(635)
         Case 17
            Me.Text = Txt(669)
         Case 20
            Me.Text = Txt(725)
         Case 21
            Me.Text = Txt(721)
         Case 22, 23
            Me.Text = Txt(726)
         Case 26, 27
            Me.Text = Txt(775)
         Case 28
            Me.Text = Txt(800)
         Case 29
            Me.Text = Txt(865)
         Case 30, 31
            Me.Text = Txt(886)
      End Select

      If tCNT > 0 Then
         If tCNT = 1 Then
            Me.Text += " (" + CStr(tCNT) + ") Record"
         Else
            Me.Text += " (" + CStr(tCNT) + ") Records"
         End If
      Else
         If ctrl = 0 Then
            Me.Height = 0
            Me.Width = 0
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Text = ""
            Me.Close()
         End If
         MsgDsp(Txt(361))
      End If
   End Sub
   Private Sub lst_DoubleClick(sender As Object, e As EventArgs) Handles lst.DoubleClick
      Dim tl1&
      tl1 = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected Then
            tl1 = GetFloat(itm.Tag)
         End If
      Next

      If tl1 > 0 Then
         dr.LIST_RET = 1
         dr.LIST_KEY = tl1
         If dr.LIST_CTRL = 1 Then GetCompanyRecord(tl1, dr)
         If dr.LIST_CTRL = 3 Then GetNotesRecord(tl1, dr)
         If dr.LIST_CTRL = 4 Then
            GetAttachmentsRecord(tl1, dr)
            GetAttachmentsBinary(dr.at_iid, dr)
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
         End If
         If dr.LIST_CTRL = 5 Then
            GetCompanyImagesRecord(tl1, dr)
            GetCompanyImagesBinary(dr.ci_iid, dr)
            If UBound(dr.bytes) < 10 Then
               MsgDsp(Txt(502))
               Exit Sub
            End If
            If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
               MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
            End If
            dr.full_filename = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(dr.ci_szFilename)
            If File.Exists(dr.full_filename) Then
               Kill(dr.full_filename)
            End If

            Dim wrt As FileStream = File.OpenWrite(dr.full_filename)
            wrt.Write(dr.bytes, 0, UBound(dr.bytes) + 1)
            wrt.Close()
         End If
         If dr.LIST_CTRL = 6 Then GetUserRecord(tl1, dr)
         If dr.LIST_CTRL = 7 Then GetAccessRecord(tl1, dr)
         If dr.LIST_CTRL = 8 Then GetProductRecord(tl1, dr)
         If dr.LIST_CTRL = 9 Then
            GetProductImageRecord(tl1, dr)
            GetProductImageBinary(dr.pi_iid, dr)
            If UBound(dr.bytes) < 10 Then
               MsgDsp(Txt(502))
               Exit Sub
            End If
            If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Files") Then
               MkDir(AppDomain.CurrentDomain.BaseDirectory + "Files")
            End If
            dr.full_filename = AppDomain.CurrentDomain.BaseDirectory + "Files\" + CStr(dr.pi_szImage)
            If File.Exists(dr.full_filename) Then
               Kill(dr.full_filename)
            End If

            Dim wrt As FileStream = File.OpenWrite(dr.full_filename)
            wrt.Write(dr.bytes, 0, UBound(dr.bytes) + 1)
            wrt.Close()
         End If
         If dr.LIST_CTRL = 10 Then GetProductTypeRecord(tl1, dr)
         If dr.LIST_CTRL = 11 Then GetCustomerRecord(tl1, dr)
         If dr.LIST_CTRL = 12 Then GetCustomerAddressRecord(tl1, dr)
         If dr.LIST_CTRL = 13 Then GetOrderRecord(tl1, dr)
         If dr.LIST_CTRL = 14 Then dr.oo_CUS_CUSTOMER = tl1
         If dr.LIST_CTRL = 15 Then dr.oo_CUS_ADDRESS = tl1
         If dr.LIST_CTRL = 16 Then dr.od_PRO_PRODUCT = tl1
         If dr.LIST_CTRL = 17 Then GetProductFeedback(tl1, dr)
         If dr.LIST_CTRL = 18 Then dr.pf_CUS_CUSTOMER = tl1
         If dr.LIST_CTRL = 19 Then dr.pf_PRO_PRODUCT = tl1
         If dr.LIST_CTRL = 20 Then GetCustomerBillingRecord(tl1, dr)
         If dr.LIST_CTRL = 21 Then GetCustomerAddressRecord(tl1, dr)
         If dr.LIST_CTRL = 22 Then GetCompanyAddressRecord(tl1, dr)
         If dr.LIST_CTRL = 23 Then dr.pp_COM_ADDRESS = tl1
         If dr.LIST_CTRL = 24 Then GetOrderRecord(tl1, dr)
         If dr.LIST_CTRL = 25 Then dr.oo_CUS_ADDRESS = tl1
         If dr.LIST_CTRL = 26 Then GetCompanyBoxesRecord(tl1, dr)
         If dr.LIST_CTRL = 27 Then dr.pp_COM_BOXES = tl1
         If dr.LIST_CTRL = 28 Then GetLanguageFilterRecord(tl1, dr)
         If dr.LIST_CTRL = 29 Then GetPromoCodesRecord(tl1, dr)
         If dr.LIST_CTRL = 30 Then GetProductSubTypeRecord(tl1, dr)
         If dr.LIST_CTRL = 31 Then dr.py_PRO_SUB_TYPE = tl1
         Me.Close()
      End If
   End Sub
   Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
      Me.Close()
   End Sub
End Class