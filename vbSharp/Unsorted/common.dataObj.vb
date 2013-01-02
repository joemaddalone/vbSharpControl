Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Module dataObj

  'Handles Null or Nothing or DBNull data 
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function __(ByVal x As Object) As String
    Dim returnValue As String
    If (x Is DBNull.Value) OrElse (x Is Nothing) OrElse (x Is String.Empty) Then
      returnValue = ""
    Else
      Try
        returnValue = CStr(x).Trim
      Catch
        returnValue = ""
      End Try
    End If
    Return returnValue
  End Function

  '00.2 - RECORDSETS & SQL
  '-----------------------------------------------------------------------

  'EXECUTE SQL Scalar or NonQuery
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="strSQL"></param>
  ''' <param name="ExecuteScalar"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function Execute(ByVal strSQL As String,
                          Optional ByVal ExecuteScalar As Boolean = False, Optional ByVal sanitize As Boolean = True) As Object
    Dim cmd As SqlCommand = conn.sql.connection.CreateCommand
    Dim runSQL As Boolean = True
    If sanitize Then
      Dim testString As String = strSQL.ToLower()
      If testString.mIndexOf({"declare", "exec"}) Then
        runSQL = False
      End If
    End If
    If runSQL Then
      cmd.CommandText = strSQL
      If ExecuteScalar Then
        Return cmd.ExecuteScalar
      Else
        Return cmd.ExecuteNonQuery
      End If
    Else
      Return Nothing
    End If
    End Function



  'Returns Recordset as Datatable
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="sqlString"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function FillRecs(ByVal sqlString As String) As System.Data.DataTable
    Using recs As DataTable = New DataTable()
      Using sql As New SqlDataAdapter(sqlString, conn.sql.connection)
        sql.Fill(recs)
        Return recs
      End Using
    End Using
  End Function



  'EXECUTE SQL Scalar or NonQuery
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="strSQL"></param>
  ''' <param name="ExecuteScalar"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function oExecute(ByVal strSQL As String,
                          Optional ByVal ExecuteScalar As Boolean = False) As Object
    Dim cmd As OleDbCommand = conn.oledb.connection.CreateCommand
    cmd.CommandText = strSQL
    If ExecuteScalar Then
      Return cmd.ExecuteScalar
    Else
      Return cmd.ExecuteNonQuery
    End If
  End Function

  'Returns Recordset as Datatable
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="sqlString"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function oFillRecs(ByVal sqlString As String) As System.Data.DataTable
    Using recs As DataTable = New DataTable()
      Using sql As New OleDbDataAdapter(sqlString, conn.oledb.connection)
        sql.Fill(recs)
        Return recs
      End Using
    End Using
  End Function



  Public hasrecs As Func(Of Data.DataTable, Boolean) = Function(r) (r.Rows.Count > 0)


  'SQL STATEMENT MANIPULATION
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function CleanSQL(ByVal x As String) As String
    Return __(x).Replace("'", "''")
  End Function

  

  'Does a column exist?
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="ColumnName"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function ColumnExists(ByVal recs As DataTable, ByVal ColumnName As String) As Boolean
    Dim ret As Boolean = False
    For Each col As DataColumn In recs.Columns
      If col.ColumnName = ColumnName Then
        ret = True
        Exit For
      End If
    Next
    Return ret
  End Function
End Module
