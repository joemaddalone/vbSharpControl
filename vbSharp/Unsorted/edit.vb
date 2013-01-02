Option Explicit On
Imports System.Text

Public Class edit

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="id"></param>
  ''' <param name="tbl"></param>
  ''' <remarks></remarks>
  Shared Sub Delete(ByVal id As Integer, ByVal tbl As String)
    execute("delete from " & tbl & " where id=" & id)
    NavBack()
  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="tbl"></param>
  ''' <param name="tblFields"></param>
  ''' <param name="updateVals"></param>
  ''' <param name="strWhere"></param>
  ''' <param name="insert"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
    Shared Function sqlWriter(ByVal tbl As String, ByVal tblFields() As String, ByVal updateVals() As String,
                       ByVal strWhere As String, ByVal insert As Boolean, Optional returnVal As String = "") As String
        Dim ret As New StringBuilder
        With ret
            If insert Then
                ret.Append("insert into " & tbl & "(" & String.Join(",", tblFields) & ")")
                ret.Append(" VALUES ")
                ret.Append("(" & String.Join(",", updateVals) & ")")
            Else
                ret.Append("update " & tbl & " set " & tblFields(0) & "=" & updateVals(0))
                If tblFields.Length > 1 Then
                    For i As Integer = 1 To tblFields.Length - 1
                        ret.Append("," & tblFields(i) & "=" & updateVals(i))
                    Next
                End If
                ret.Append(" " & strWhere)
            End If
        End With
        If returnVal <> "" Then
            Return "Set Nocount on " & ret.ToString & " select " & returnVal & "=@@identity Set Nocount off"
        Else
            Return ret.ToString
        End If
    End Function
End Class
