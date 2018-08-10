Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class producttransactionfrm
   Private Sub producttransactionfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnAdd.Text = Txt(603)
      btnRemove.Text = Txt(692)
      btnClose.Text = Txt(390)

      Me.Text = Txt(693)
      inits()
   End Sub
   Private Sub inits()
      InitProductTransaction(dr)
      Display()
   End Sub
   Private Sub Display()
      lstLoad()
   End Sub
   Private Sub lstLoad()
      Dim tstr1$ = ""
      TestConnection()
      lst.Clear()
      lst.View = View.Details
      lst.Columns.Add(Txt(685), lst.Width - 425, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(686), 130, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(687), 110, HorizontalAlignment.Left)
      lst.Columns.Add(Txt(363), 180, HorizontalAlignment.Left)
      dr.ocmd.CommandText = "SELECT * FROM PRO_TRANSACTION WHERE pn_PRO_PRODUCT = " + CStr(dr.pp_iid) + " ORDER BY pn_dDate Desc"
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         Do While dr.oread.Read()
            If dr.oread("pn_iType") = 1 Then
               tstr1 = Txt(610)
            ElseIf dr.oread("pn_iType") = 2 Then
               tstr1 = Txt(688)
            ElseIf dr.oread("pn_iType") = 3 Then
               tstr1 = Txt(41)
            ElseIf dr.oread("pn_iType") = 4 Then
               tstr1 = Txt(689)
            End If
            Dim ListItem1 As New ListViewItem(CStr(tstr1))
            ListItem1.Tag = CStr(dr.oread("pn_iid"))
            If dr.oread("pn_iType") = 1 Or dr.oread("pn_iType") = 4 Then
               ListItem1.SubItems.Add(dr.oread("pn_iChanged"))
            Else
               ListItem1.SubItems.Add("- " + CStr(dr.oread("pn_iChanged")))
            End If
            ListItem1.SubItems.Add(dr.oread("pn_iRemaining"))
            ListItem1.SubItems.Add(Format(dr.oread("pn_dDate"), "dd/MMM/yyyy hh:mm:ss"))
            lst.Items.Add(ListItem1)
         Loop
      End If
      dr.oread.Close()
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub

   Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
      dr.FRMSWT = 1
      dr.pn_iType = 1
      dr.pn_iKey = dr.uu_iid
      dr.pn_PRO_PRODUCT = dr.pp_iid
      Dim frm As producttransactioneditfrm
      frm = New producttransactioneditfrm
      frm.ShowDialog()
      Display()
   End Sub
   Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
      dr.FRMSWT = 2
      dr.pn_iType = 2
      dr.pn_iKey = dr.uu_iid
      dr.pn_PRO_PRODUCT = dr.pp_iid
      Dim frm As producttransactioneditfrm
      frm = New producttransactioneditfrm
      frm.ShowDialog()
      Display()
   End Sub
   Private Sub lst_DoubleClick(sender As Object, e As EventArgs) Handles lst.DoubleClick
      Dim tl1& = 0
      For Each itm As ListViewItem In lst.SelectedItems
         If itm.Selected = True Then
            tl1 = CLng(GetFloat(itm.Tag))
            GetProductTransactionRecord(tl1, dr)
            Dim frm As producttransdescfrm
            frm = New producttransdescfrm
            frm.ShowDialog()
         End If
      Next
   End Sub
End Class