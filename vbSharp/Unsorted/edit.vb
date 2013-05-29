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


    Shared Sub RankChange(ByVal direction As Integer, ByVal tbl As String, ByVal ID As Integer, Optional strWhere As String = "", Optional rankColumn As String = "rank")
        Dim p As String = "id"
        Dim pid As String = ""
        Dim SQL As String = _
            "select ROW_NUMBER() over (order by " & rankColumn & ") row," & _
            "id,ISNULL(" & rankColumn & ",0) " & rankColumn & _
            " from " & tbl & " " & strWhere
        Dim x As Integer
        Dim recs As Data.DataTable = read.sql(SQL)
        Dim pos As Integer
        'first we need to make sure we have it in the proper order, and one that makes sense.
        'regardless of click happy users.

        For x = 0 To recs.Rows.Count - 1
            Execute("update " & tbl & " set " & rankcolumn & " = " & recs.Rows(x)("row").ToString & " WHERE ID=" & recs.Rows(x)("id").ToString)
            If recs.Rows(x)("id").ToString = ID.ToString() Then
                pos = x
            End If
        Next

        If pos = (recs.Rows.Count - 1) AndAlso direction = 1 Then
            'do nothing
            'it is already last... the user is just an asshole
            Exit Sub
        End If


        If pos = 0 AndAlso direction = -1 Then
            'do nothing
            'it is already first... the user is just an asshole
            Exit Sub
        End If


        If hasrecs(recs) Then
            'row = current rank when selected
            Select Case direction
                Case Is < 0
                    'we are ranking one less
                    'since it is 0 based the pos var already equals one less than our current rank
                    'First: move the rank below it +1
                    Execute("update " & tbl & " set " & rankcolumn & " = " & rankcolumn & "+1 WHERE " & rankcolumn & " = " & pos)
                    'now move ours into place
                    Execute("update " & tbl & " set " & rankcolumn & " = " & pos & " WHERE ID = " & ID)
                Case 1
                    'We are ranking it one more
                    'since it is 0 based the pos var already equals one less than our current rank
                    'First: move the rank below it -1
                    Execute("update " & tbl & " set " & rankcolumn & " = " & rankcolumn & "-1 WHERE " & rankcolumn & " = " & pos + 2)
                    'now move ours into place
                    Execute("update " & tbl & " set " & rankcolumn & " = " & pos + 2 & " WHERE ID = " & ID)
            End Select
        End If



    End Sub

End Class
