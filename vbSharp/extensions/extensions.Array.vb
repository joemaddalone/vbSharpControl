Option Strict On
Imports System.Text
Imports System.Runtime.CompilerServices
Public Module Extensions_Array
  ''' <summary>
  ''' A lot of cheating here applying List functionality to old school arrays
  ''' </summary>
  

  <Extension()> _
  Public Function slice(Of T)(source As T(), start As Integer, finish As Integer) As T()
    If finish < 0 Then
      finish = source.Length + finish
    End If
    Dim ret As T() = New T((finish - start) - 1) {}
    For i As Integer = 0 To (finish - start) - 1
      ret(i) = source(i + start)
    Next
    Return ret
  End Function


  <Extension()> _
  Public Function StartsWith(source As String(), str As String) As String()
    Dim ret As New List(Of String)
    For Each word As String In source.Where(Function(w) w.StartsWith(str))
      ret.Add(word)
    Next
    Return ret.ToArray
  End Function


  <Extension()> _
  Public Function EndsWith(source As String(), str As String) As String()
    Dim ret As New List(Of String)
    For Each word As String In source.Where(Function(w) w.EndsWith(str))
      ret.Add(word)
    Next
    Return ret.ToArray
  End Function

  <Extension()> _
  Public Function Contains(source As String(), str As String) As String()
    Dim ret As New List(Of String)
    For Each word As String In source.Where(Function(w) w.Contains(str))
      ret.Add(word)
    Next
    Return ret.ToArray
  End Function



  <Extension()> _
  Public Sub Incr(ByRef str() As String)
    ReDim Preserve str(UBound(str) + 1)
  End Sub

  <Extension()> _
  Public Function First(ByRef str() As String) As String
    Return str(0)
  End Function

  <Extension()> _
  Public Sub First(ByRef str() As String, ByVal val As String)
    str(0) = val
  End Sub

  <Extension()> _
  Public Function Last(ByRef str() As String) As String
    Return str(UBound(str))
  End Function

  <Extension()> _
  Public Sub Last(ByRef str() As String, ByVal val As String)
    str(UBound(str)) = val
  End Sub


  <Extension()> _
  Public Sub Insert(ByRef str() As String, ByVal val As String, Optional pos As Integer = Nothing)
    Dim x As New List(Of String)
    For i As Integer = 0 To UBound(str)
      x.Add(str(i))
    Next
    If __(pos) <> "" Then
      x.Insert(pos, val)
    Else
      x.Add(val)
    End If
    str = x.ToArray
  End Sub

  <Extension()> _
  Public Sub Insert(ByRef str() As String, ByVal pos As Integer, ByVal vals() As String)
    Dim x As New List(Of String)
    Dim i As Integer
    For i = 0 To UBound(str)
      x.Add(str(i))
    Next

    For i = pos To UBound(vals)
      If i <= x.Count Then
        x.Insert(i, vals(i - pos))
      Else
        x.Add(vals(i - pos))
      End If
    Next
    str = x.ToArray
  End Sub



  <Extension()> _
  Public Sub Remove(ByRef str() As String, ByVal pos As Integer)
    Dim x As New List(Of String)
    For i As Integer = 0 To UBound(str)
      x.Add(str(i))
    Next
    x.RemoveAt(pos)
    str = x.ToArray
  End Sub

  <Extension()> _
  Public Sub RemoveAll(ByRef str() As String)
    ReDim str(-1)
  End Sub
End Module