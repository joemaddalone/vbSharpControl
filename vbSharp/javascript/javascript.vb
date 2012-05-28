Imports System.Text

Public Class js
  Shared forLoop As Func(Of String, String, String, String) = Function(i, until, inner) " for (var " & i & "=0;" & i & until & ";" & i & "++) {" & inner & "}"
  Shared [function] As Func(Of String, String, String, String) = Function(name, params, inner) " function " & name & "(" & params & "){" & inner & "}"
  Shared func As Func(Of String, String, String) = Function(params, inner) "function(" & params & "){" & inner & "}"
  Shared var As Func(Of String, String, String) = Function(name, val) " var " & name & "=" & val & ";"
  Shared [if] As Func(Of String, String, String, String) =
    Function(trueStatement, trueaction, elseaction) If(elseaction <> "",
                                                       "if(" & trueStatement & "){" & trueaction & "} else {" & elseaction & "}",
                                                       "if(" & trueStatement & "){" & trueaction & "}")

  'Shared Function forLoop(i As String, until As String, inner As String) As String
  'Dim ret As New StringBuilder
  'With ret
  '.Append(" for (var " & i & "=0;" & i & until & ";" & i & "++)")
  '.Append("{" & inner & "}")
  'End With
  'Return ret.ToString()
  'End Function

  'Shared Function [function](name As String, params As String, inner As String) As String
  ' Return " function " & name & "(" & params & "){" & inner & "}"
  'End Function

  'Shared Function func(params As String, inner As String) As String
  ' Return " function(" & params & "){" & inner & "}"
  'End Function

  'Shared Function var(name As String, val As String) As String
  ' Return " var " & name & "=" & val & ";"
  'End Function

  'Shared Function [if](trueStatement As String, trueaction As String, Optional elseAction As String = "") As String
  ' If elseAction = "" Then
  '  Return "if(" & trueStatement & "){" & trueaction & "}"
  'Else
  'Return "if(" & trueStatement & "){" & trueaction & "} else {" & elseAction & "}"
  'End If
  'End Function
End Class
