Imports System.Text

Public Class javascript

  Shared Function forLoop(i As String, until As String, inner As String) As String
    Dim ret As New StringBuilder
    With ret
      .Append(" for (var " & i & "=0;" & i & until & ";" & i & "++)")
      .Append("{" & inner & "}")
    End With
    Return ret.ToString()
  End Function

  Shared Function func(name As String, params As String, inner As String) As String
    Return " function " & name & "(" & params & "){" & inner & "}"
  End Function

  Shared Function var(name As String, val As String) As String
    Return " var " & name & "=" & val & ";"
  End Function

End Class
