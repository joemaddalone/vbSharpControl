Public Class dObject
    Public Property [Property] As Dictionary(Of String, String)
    Sub New(query As String)
        Dim recs As Data.DataTable = read.sql(query)
        Dim cols As New List(Of String)
        For Each column As Data.DataColumn In recs.Columns
            cols.Add(column.ColumnName)
        Next
        Me.Property = recs.dim(cols.ToArray)
        recs.Dispose()
    End Sub
End Class
