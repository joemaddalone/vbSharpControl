Option Strict On
Imports System.Xml
Imports System.Net
Partial Public Class read
  Public Shared Function url(ByVal uri As String) As String
    Dim web As New Net.WebClient
    Dim byt() As Byte
    byt = web.DownloadData(uri)
    Return System.Text.ASCIIEncoding.ASCII.GetString(byt).ToString
  End Function
End Class
