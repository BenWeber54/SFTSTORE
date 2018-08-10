Imports SFTSTORE.ftn
Imports SFTSTORE.data
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class users_rights
   Dim markStatus As New NameValueCollection
   Dim checkSort$
   Private Sub users_rights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(631)
      bok.Text = Txt(255)
      bcheckall.Text = Txt(632)
      buncheckall.Text = Txt(633)
      bsamerights.Text = Txt(634)
      bclose.Text = Txt(390)
      Display()
   End Sub
   Private Sub Display()
      Dim tCNT%
      checkSort = ""
      'populates the checked list
      TestConnection()
      cb.Items.Clear()
      dr.ocmd.CommandText = "SELECT * FROM TXT_TEXT WHERE tx_iid >= 1000 AND tx_iid <= 1200"
      dr.ocmd.CommandText += " order by tx_szEnglish"
      dr.oread = dr.ocmd.ExecuteReader()

      If dr.oread.HasRows = True Then
         tCNT = 0
         Do While dr.oread.Read
            cb.Items.Add(CStr(dr.oread("tx_szEnglish")), False)
            markStatus.Add(CStr(dr.oread("tx_szEnglish")), CStr(dr.oread("tx_iid")))
            checkSort += CStr(tCNT) + "|" + CStr(dr.oread("tx_iid")) + "|"
            tCNT += 1
         Loop
      End If
      dr.oread.Close()
      CheckList(dr.uu_iid)
   End Sub
   Private Sub CheckList(ByVal iid As Long)
      Dim values$()
      values = Split(checkSort, "|")
      TestConnection()
      dr.ocmd.CommandText = "select * from USR_ACCESS where ua_USR_USER = " + CStr(iid)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         For tI = 2 To cb.Items.Count() + 1
            If dr.oread(tI) = 1 Then
               For tl1 = 0 To UBound(values) - 1 Step 2
                  If CStr(CLng(GetFloat(values(tl1 + 1))) - 999) = CStr(tI - 1) Then
                     cb.SetItemCheckState(values(tl1), CheckState.Checked)
                     Exit For
                  End If
               Next
            End If
         Next
      Else
         For ti& = 0 To cb.Items.Count - 1
            cb.SetItemCheckState(ti, CheckState.Unchecked)
         Next
      End If
      dr.oread.Close()
   End Sub
#Region "Click Events"
   Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
      Dim tI%, tstr1$, rstr$, key$, values$()
      dr.au_szAccess = ""
      For tI = 1 To ACC_TOTAL
         dr.au_szAccess += "0"
      Next
      rstr = ""
      If cb.CheckedItems.Count > 0 Then
         For tI = 0 To cb.CheckedItems.Count - 1
            tstr1 = cb.CheckedItems(tI)
            For Each key In markStatus.Keys
               values = markStatus.GetValues(key)
               For Each value As String In values
                  If key = tstr1 Then
                     Mid(dr.au_szAccess, value - 999, 1) = "1"
                     Exit For
                  End If
               Next value
            Next key
         Next tI
      End If
      UpdateUserAccessRecord(dr)
      MsgDsp("User Access Updated")
      Me.Close()
   End Sub
   Private Sub bcheckall_Click(sender As Object, e As EventArgs) Handles bcheckall.Click
      For ti& = 0 To cb.Items.Count - 1
         cb.SetItemCheckState(ti, CheckState.Checked)
      Next
   End Sub
   Private Sub buncheckall_Click(sender As Object, e As EventArgs) Handles buncheckall.Click
      For ti& = 0 To cb.Items.Count - 1
         cb.SetItemCheckState(ti, CheckState.Unchecked)
      Next
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub
   Private Sub bsamerights_Click(sender As Object, e As EventArgs) Handles bsamerights.Click
      dr.LIST_CTRL = 7
      Dim frm As listfrm
      frm = New listfrm
      frm.ShowDialog()
      If dr.LIST_RET = 1 Then
         CheckList(dr.LIST_KEY)
      End If
   End Sub
#End Region
End Class