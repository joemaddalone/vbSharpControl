Public Class web
  Class post
    Shared Function xml(url As String, content As String, contenttype As String) As System.Xml.XmlTextReader
      Using wc As New Net.WebClient
        wc.Headers.Add("Content-Type", contenttype)
        Dim byt() As Byte = wc.UploadData( _
            url, "POST", _
            System.Text.UTF8Encoding.ASCII.GetBytes(content))
        Dim ret As New System.Xml.XmlTextReader(New System.IO.StringReader(System.Text.ASCIIEncoding.ASCII.GetString(byt).ToString()))
        Return ret
      End Using
    End Function
  End Class

  Class request
    Shared Function xml(url As String, content As String, contenttype As String) As System.Xml.XmlTextReader
      Dim xd As New System.Xml.XmlDocument()
      Dim ret As System.Xml.XmlTextReader
      If isResponsive(url, 5000) Then
        xd.Load(System.Net.WebRequest.Create(url).GetResponse.GetResponseStream())
        ret = New System.Xml.XmlTextReader(xd.ToString)
      Else
        ret = New System.Xml.XmlTextReader(xd.ToString)
      End If
      Return ret
    End Function
  End Class


End Class
