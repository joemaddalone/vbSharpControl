Option Strict On
Imports System.Data.OleDb
Partial Public Class read
  
  ''' <summary>
  ''' Returns Datatable from Excel File based on jetSQL query
  ''' </summary>
  ''' <param name="sqlString">The SQL query.</param>
  ''' <param name="path">The path to the excel file.</param>
  ''' <returns>Datatable</returns>
  Shared Function excel(ByVal sqlString As String, ByVal path As String) As System.Data.DataTable
    Dim strConn As String = _
    "Provider=Microsoft.Jet.OLEDB.4.0;" & _
    "Data Source=" & path & ";" & _
    "Extended Properties=""Excel 8.0;"""
    Using recs As New Data.DataTable()
      Using sql As New OleDbDataAdapter(sqlString, strConn)
        sql.Fill(recs)
      End Using
      Return recs
    End Using
  End Function
End Class
