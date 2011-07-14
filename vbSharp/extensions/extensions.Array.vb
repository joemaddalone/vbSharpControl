Option Strict On
Imports System.Text
Imports System.Runtime.CompilerServices
Public Module Extensions_Array
  <Extension()> _
  Public Function Slice(Of T)(source As T(), start As Integer, finish As Integer) As T()
    If finish < 0 Then
      finish = source.Length + finish
    End If
    Dim ret As T() = New T((finish - start) - 1) {}
    For i As Integer = 0 To (finish - start) - 1
      ret(i) = source(i + start)
    Next
    Return ret
  End Function
End Module