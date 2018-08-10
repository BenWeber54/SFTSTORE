Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports SFTSTORE.ftn
Imports SFTSTORE.data

Public Class setup

   Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
      Me.Close()
   End Sub

   Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click

      Dim tFILE$ = AppDomain.CurrentDomain.BaseDirectory + "SFTSTORE.DAT"
      If System.IO.File.Exists(tFILE) = True Then
         Kill(tFILE)
      End If
      Dim objWriter As New System.IO.StreamWriter(tFILE, True)
      objWriter.Write(parameters.Text)
      objWriter.Close()
      dr.sr_szSettings = parameters.Text
      Me.Close()

   End Sub

   Private Sub setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      parameters.Text = dr.sr_szSettings
      parameters.Select(0, 0)
   End Sub
End Class