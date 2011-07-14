Option Strict On
Imports System.Data.SqlClient
Partial Public Class read
  ''' <summary>
  ''' REturns Datatable from MS-SQL Server based on specified T-SQL query.
  ''' </summary>
  ''' <param name="sqlString">The SQL query.</param>
  ''' <returns>Datatable</returns>
  Public Shared Function sql(ByVal sqlString As String) As System.Data.DataTable
    Using recs As DataTable = New DataTable()
      Using sa As New SqlDataAdapter(sqlString, conn.sql.connection)
        sa.Fill(recs)
        Return recs
      End Using
    End Using
  End Function

End Class
