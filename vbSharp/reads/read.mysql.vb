Option Strict On
Imports System.Data.Odbc

Partial Public Class read
    ''' <summary>
    ''' Returns Datatable from MS-SQL Server based on specified T-SQL query.
    ''' </summary>
    ''' <param name="sqlString">The SQL query.</param>
    ''' <returns>Datatable</returns>
    Public Shared Function mysql(ByVal sqlString As String, Optional sanitize As Boolean = True) As System.Data.DataTable
        Dim runSQL As Boolean = True
        If sanitize Then
            Dim testString As String = sqlString.ToLower()
            If testString.mIndexOf({"declare", "exec"}) Then
                runSQL = False
            End If
        End If
        If runSQL Then
            Using recs As DataTable = New DataTable()
                Using sa As New OdbcDataAdapter(sqlString, conn.mysql.connection)
                    sa.Fill(recs)
                    Return recs
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
