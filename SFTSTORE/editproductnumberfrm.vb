Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class editproductnumberfrm
   Private Sub editproductnumberfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = Txt(565)
      lblCurrent.Text = Txt(620) + ":"
      lblNew.Text = Txt(621) + ":"

      btnSave.Text = Txt(382)
      btnClose.Text = Txt(390)
      txtCurrent.Text = dr.pp_szSKU
   End Sub
   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
   Private Sub screenToRecord()
      dr.pp_szSKU = Trim(txtNew.Text)
   End Sub
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      screenToRecord()
      TestConnection()
      dr.ocmd.CommandText = "SELECT pp_szSKU, pp_iid FROM PRO_PRODUCT WHERE pp_szSKU = '" + AStr(dr.pp_szSKU) + "'"
      dr.ocmd.CommandText += " AND pp_COM_COMPANY = " + CStr(dr.pp_COM_COMPANY)
      dr.oread = dr.ocmd.ExecuteReader()
      If dr.oread.HasRows = True Then
         dr.oread.Read()
         If dr.pp_iid = dr.oread("pp_iid") Then
            MsgDsp(Txt(551))
         Else
            MsgDsp(Txt(538))
         End If
         Exit Sub
      End If
      dr.oread.Close()
      UpdateProductRecord(dr)
      Me.Close()
   End Sub
End Class