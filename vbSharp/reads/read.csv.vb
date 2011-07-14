Option Strict On
Partial Public Class read
  ''' <summary>
  ''' Returns CSV as Datatable
  ''' </summary>
  ''' <param name="path">The path to the CSV.</param>
  ''' <param name="hasHeader">if set to <c>true</c> [has header].</param><returns></returns>

  Shared Function csv(ByVal path As String,
                   Optional ByVal hasHeader As Boolean = False) As System.Data.DataTable
    Return read.txt(path, ControlChars.Lf, ",", hasHeader)

  End Function
End Class
