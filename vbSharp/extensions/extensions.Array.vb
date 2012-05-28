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
  Public Function Incr(Of T)(ByRef arr As T()) As T()
    ReDim Preserve arr(UBound(arr) + 1)
    Return arr
  End Function

  <Extension()> _
  Public Function First(Of T)(ByRef str As T()) As T
    Return str(0)
  End Function

  <Extension()> _
  Public Function First(Of T)(ByRef str As T(), ByVal val As T) As T()
    str(0) = val
    Return str
  End Function

  <Extension()> _
  Public Function Last(Of T)(ByRef str As T()) As T
    Return str(UBound(str))
  End Function

  <Extension()> _
  Public Function Last(Of T)(ByRef arr As T(), ByVal val As T) As T()

    arr(UBound(arr)) = val
    Return arr
  End Function


  <Extension()> _
  Public Function Insert(Of T)(ByRef arr As T(), val As T, Optional pos As Integer = -1) As T()
    Dim l As New List(Of T)
    l = arr.ToList()
    If pos = -1 Then
      l.Add(val)
    Else
      l.Insert(pos, val)
    End If
    arr.RemoveAll()
    arr = l.ToArray
    Insert = l.ToArray
  End Function



  <Extension()> _
  Public Function Remove(Of T)(ByRef arr As T(), ByVal pos As Integer) As T()
    Dim x As New List(Of T)
    Dim mytype As Type = GetType(T())
    Array.ForEach(arr, New Action(Of T)(Sub(str As T) x.Add(DirectCast(Convert.ChangeType(str, GetType(T)), T))))
    x.RemoveAt(pos)
    arr.RemoveAll()
    arr = x.ToArray()
    Return arr
  End Function


  <Extension()> _
  Public Function Remove(ByRef arr As String(), ByVal str As String) As String()
    Dim ret As New List(Of String)
    For Each word As String In arr.Where(Function(w) w <> str)
      ret.Add(word)
    Next
    arr.RemoveAll()
    arr = ret.ToArray()
    Return arr
  End Function



  <Extension()> _
  Public Function RemoveAll(Of T)(ByRef arr As T()) As T()
    ReDim arr(-1)
    Return arr
  End Function

  <Extension()> _
  Public Function aCleanSQL(ByRef arr() As String) As String()
    Dim newarr As String() = {}
    Array.ForEach(arr, New Action(Of String)(Sub(str As String) newarr.Insert("'" & CleanSQL(str) & "'")))
    arr = newarr
    Return newarr
  End Function

End Module