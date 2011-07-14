Option Strict On
Imports System.Data.OleDb
Partial Public Class executes
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="strSQL"></param>
  ''' <param name="ExecuteScalar"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function oledb(ByVal strSQL As String,
                          Optional ByVal ExecuteScalar As Boolean = False) As Object
    Dim cmd As OleDbCommand = conn.oledb.connection.CreateCommand
    cmd.CommandText = strSQL
    Return If(ExecuteScalar, cmd.ExecuteScalar, cmd.ExecuteNonQuery)
  End Function


End Class
