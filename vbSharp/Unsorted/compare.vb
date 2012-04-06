Public Class compare
  Shared Function files(f1 As String, f2 As String) As List(Of String)
    Dim lines1 As String() = System.IO.File.ReadAllLines(f1)
    Dim lines2 As String() = System.IO.File.ReadAllLines(f2)
    Dim diff = lines1.Except(lines2)
    Dim diffs As New List(Of String)
    For Each d As String In diff
      diffs.Add(d)
    Next
    Return diffs
  End Function
End Class
