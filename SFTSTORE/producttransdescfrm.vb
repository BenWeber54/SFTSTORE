Imports System.IO
Imports System.Net
Imports System.Text

Imports SFTSTORE.data
Imports SFTSTORE.ftn
Imports SFTSTORE.reportpdf
Imports System.Collections.Specialized

Public Class producttransdescfrm
   Private Sub producttransdescfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnClose.Text = Txt(390)
      txtDesc.Text = dr.pn_szDescription
   End Sub

   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      Me.Close()
   End Sub
End Class