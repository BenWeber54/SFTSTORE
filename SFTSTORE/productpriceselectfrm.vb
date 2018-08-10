Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Data
Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class productpriceselectfrm
   Dim shippingNumber& = 0, firstLoad& = 0
   Private Sub productpriceselectfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(823)
      btnClose.Text = Txt(764)
      btnSelect.Text = Txt(614)

      Display()
   End Sub
   Private Sub Display()
      lst.Clear()
      lst.View = View.Details
      lst.Columns.Add(Txt(539), 120, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(568), lst.Width - 325, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(363), 200, HorizontalAlignment.Center)
      TestConnection()
      dr.ocmd.CommandText = "SELECT * FROM PRO_PRICE WHERE pr_PRO_PRODUCT = " + CStr(dr.pp_iid) + " AND pr_iStatus != 2 "
      dr.ocmd.CommandText += " ORDER BY pr_dDate"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            If dr.oread("pr_iStatus") = 3 Then
               If Now.Date >= dr.oread("pr_dSpecialStart") And Now.Date <= dr.oread("pr_dSpecialEnd") Then
                  Dim ListItem1 As New ListViewItem(CStr(dr.oread("pr_rPrice")))
                  ListItem1.Tag = CStr(dr.oread("pr_rPrice"))
                  If dr.oread("pr_iStatus") = 1 Then
                     ListItem1.SubItems.Add(Txt(36))
                  Else
                     ListItem1.SubItems.Add(Txt(559))
                  End If
                  ListItem1.SubItems.Add(Format(dr.oread("pr_dDate"), "dd/MMM/yyyy hh:mm tt"))
                  lst.Items.Add(ListItem1)
               End If
            Else
               Dim ListItem1 As New ListViewItem(CStr(dr.oread("pr_rPrice")))
               ListItem1.Tag = CStr(dr.oread("pr_rPrice"))
               If dr.oread("pr_iStatus") = 1 Then
                  ListItem1.SubItems.Add(Txt(36))
               Else
                  ListItem1.SubItems.Add(Txt(559))
               End If
               ListItem1.SubItems.Add(Format(dr.oread("pr_dDate"), "dd/MMM/yyyy hh:mm tt"))
               lst.Items.Add(ListItem1)
            End If
         Loop
      Else
         MsgDsp(Txt(825))
         Me.Close()
      End If
      dr.oread.Close()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
      Dim tDec1@ = 0, tl2& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tDec1 = GetFloat(itm.Tag)
            dr.productPrice = tDec1
            tl2 = 1
         End If
      Next
      If tl2 = 0 Then
         MsgDsp(Txt(558))
      Else
         Me.Close()
      End If
   End Sub

   Private Sub lst_DoubleClick(sender As Object, e As EventArgs) Handles lst.DoubleClick
      btnSelect.PerformClick()
   End Sub
End Class