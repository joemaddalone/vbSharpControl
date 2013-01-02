Option Strict On
Partial Public Class read
    ''' <summary>
    ''' Reads Directory of files into Datatable
    ''' </summary>
    ''' <param name="path">The directory to read.</param>
    ''' <param name="fileExt">Limits results to specified file extension</param>
    ''' <returns>Datatable</returns>
    Shared Function dir(ByVal path As String,
                         Optional ByVal fileExt As String = "") As System.Data.DataTable
        Dim folder As New IO.DirectoryInfo(path)
        Dim files As IO.FileInfo() =
          If(fileExt = "", folder.GetFiles("*"), folder.GetFiles("*." & fileExt))
        Dim f As IO.FileInfo
        Using recs As New DataTable()
            With recs.Columns
                .Add("Filename")
                .Add("FileExtension")
                .Add("FileSize")
                .Add("LastAccess")
                .Add("CreationTime")
            End With

            Dim row As DataRow
            For Each f In files
                row = recs.NewRow()
                row.ItemArray =
                  {f.Name, f.Extension, f.Length & " bytes", f.LastAccessTime, f.CreationTime}
                recs.Rows.Add(row)
            Next
            Return recs
        End Using
    End Function


    Shared Function findInDir(ByVal path As String,
                          Optional ByVal find As String = "") As System.Data.DataTable
        Dim folder As New IO.DirectoryInfo(path)
        Dim files As IO.FileInfo() =
          folder.GetFiles(find)
        Dim f As IO.FileInfo
        Using recs As New DataTable()
            With recs.Columns
                .Add("Filename")
                .Add("FileExtension")
                .Add("FileSize")
                .Add("LastAccess")
                .Add("CreationTime")
            End With
            Dim row As DataRow
            For Each f In files
                row = recs.NewRow()
                row.ItemArray =
                  {f.Name, f.Extension, f.Length & " bytes", f.LastAccessTime, f.CreationTime}
                recs.Rows.Add(row)
            Next
            Return recs
        End Using
    End Function


End Class
