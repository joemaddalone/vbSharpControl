Option Strict On
Partial Public Class read
  ''' <summary>
  ''' REturns Datatable from specified Text file
  ''' </summary>
  ''' <param name="path">The path to the Text File.</param>
  ''' <param name="rowDelimiter">The specified row delimiter.</param>
  ''' <param name="colDelimiter">The specified column delimiter.</param>
  ''' <param name="hasHeader">if set to <c>true</c> Datatable Columns will reflect this, otherwise datatable columns will default to Column0... </param>
  ''' <returns>Datatable</returns>
  Shared Function txt(ByVal path As String,
                       ByVal rowDelimiter As String,
                       ByVal colDelimiter As String,
                     Optional ByVal hasHeader As Boolean = False) As System.Data.DataTable
    Dim lines As String() = fs.read(path).Split(CChar(rowDelimiter))

    Using recs As New Data.DataTable
      Dim sArr As String() = lines(0).Split(CChar(colDelimiter))
      For Each s As String In sArr
        recs.Columns.Add(New Data.DataColumn(If(hasHeader, s, Nothing)))
      Next
      Dim row As Data.DataRow
      For i As Integer = If(hasHeader, 1, 0) To lines.Length - 1
        row = recs.NewRow()
        row.ItemArray = lines(i).Replace(ControlChars.Cr, "").Split(","c)
        recs.Rows.Add(row)
      Next
      Return recs
    End Using
  End Function
End Class
