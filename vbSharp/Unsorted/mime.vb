Public Class mime
  Shared Sub attach(type As String, filename As String, content As String)
    With PG.Response
      .ContentType = type
      .AddHeader("content-disposition", "attachment; filename=""" & filename & """")
      .Write(content)
      .End()
    End With
  End Sub
End Class
