Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productimageorderfrm
   Private Sub productimageorderfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(622)
      btnUp.Text = Txt(623)
      btnDown.Text = Txt(624)
      bclose.Text = Txt(390)
      lstLoad()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub
   Private Sub lstLoad()
      TestConnection()
      lst.Clear()
      dr.ocmd.CommandText = "SELECT * FROM PRO_IMAGE WHERE pi_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pi_iOrder"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         lst.View = View.Details
         lst.Columns.Add(Txt(552), lst.Width - 305, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(553), 100, HorizontalAlignment.Left)
         lst.Columns.Add(Txt(378), 200, HorizontalAlignment.Left)
         Do While dr.oread.Read()
            Dim ListItem1 As New ListViewItem(CStr(dr.oread("pi_szImage")))
            ListItem1.Tag = CStr(dr.oread("pi_iid"))
            ListItem1.SubItems.Add(dr.oread("pi_iOrder"))
            ListItem1.SubItems.Add(Format(dr.oread("pi_dDate"), "dd/MMM/yyyy"))
            lst.Items.Add(ListItem1)
         Loop
      Else
         dr.oread.Close()
         MsgDsp(Txt(361))
         Me.Close()
      End If
      dr.oread.Close()
   End Sub
   Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnUp.Click
      Dim tl1& = 0, tl2& = 0
      For Each itm As ListViewItem In lst.Items
         If itm.Selected Then
            tl1 = GetFloat(itm.Tag)
            GetProductImageRecord(tl1, dr)
            If dr.pi_iOrder = 1 Then
               MsgDsp(Txt(556))
               Exit Sub
            Else
               dr.pi_iOrder -= 1
               UpdateProductImageShiftRecord(dr)

               GetProductImageRecord(tl2, dr)
               dr.pi_iOrder += 1
               UpdateProductImageShiftRecord(dr)
            End If
            lstLoad()
            For Each itm1 As ListViewItem In lst.Items
               If itm1.Tag = tl1 Then
                  lst.Focus()
                  itm1.Selected = True
               End If
            Next
         Else
            tl2 = CLng(GetFloat(itm.Tag))
         End If
      Next
   End Sub
   Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnDown.Click
      Dim tl1& = 0, tl2& = 0
      Dim tl3 As Integer
      tl3 = -1
      For Each itm As ListViewItem In lst.Items
         tl3 += 1
         If itm.Selected Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetProductImageRecord(tl1, dr)
            If dr.pi_iOrder = lst.Items.Count Then
               MsgDsp(Txt(557))
               Exit Sub
            Else
               dr.pi_iOrder += 1
               UpdateProductImageShiftRecord(dr)

               tl2 = CLng(GetFloat(lst.Items(tl3 + 1).Tag))
               GetProductImageRecord(tl2, dr)
               dr.pi_iOrder -= 1
               UpdateProductImageShiftRecord(dr)
               'tl3 = -1
               lstLoad()
               For Each itm1 As ListViewItem In lst.Items
                  'tl3 += 1
                  If itm1.Tag = tl1 Then
                     lst.Focus()
                     itm1.Selected = True
                     'lst.RedrawItems(0, lst.Items.Count - 1, )
                     'lst.Items(tl3).Selected = True
                  End If
               Next
            End If
         End If
      Next
   End Sub
End Class