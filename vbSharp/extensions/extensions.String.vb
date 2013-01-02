Imports System.Runtime.CompilerServices
Imports System.Text
''' <summary>
''' Extends string
''' </summary>
''' <remarks></remarks>
Public Module Extensions_String

  <Extension()> _
  Public Function strIn(src As String, find As String()) As Boolean
    Dim ret As Boolean = False
    Array.ForEach(find, New Action(Of String)(Sub(str) If str = src Then ret = True))
    Return ret
  End Function

  <Extension()> _
  Public Function mIndexOf(src As String, find As String()) As Boolean
    Dim ret As Boolean = False
        Array.ForEach(find, New Action(Of String)(Sub(str As String) If str.IndexOf(src) <> -1 Then ret = True))
    Return ret
  End Function

  <Extension()> _
  Public Function strNull(src As String()) As Boolean
    Dim ret As Boolean = False
    Array.ForEach(src, New Action(Of String)(Sub(str) If __(str) = "" Then ret = True))
    Return ret
  End Function

  <Extension()> _
  Public Function mReplace(src As String, find As String()) As String
    Dim ret As String = src
    Array.ForEach(find, New Action(Of String)(Sub(str) ret = ret.Replace(str, "")))
    Return ret
  End Function

  <Extension()> _
  Public Function mReplace(src As String, find As String(), replacement As String()) As String
    Dim ret As String = src
    For i As Integer = 0 To find.Length
      ret = ret.Replace(find(i), replacement(i))
    Next
    Return ret
  End Function

  <Extension()> _
  Public Function truncate(src As String, limit As Integer, Optional following As String = "") As String
    If src.Length > limit Then
      Return src.Substring(0, limit) & following
    Else
      Return src
    End If
  End Function

  <Extension()> _
  Public Function plural(src As String, count As Integer) As String
    If count = 1 Then
      Return count & " " & src
    Else
      Return count & " " & src & "s"
    End If
  End Function


  <Extension()> _
  Function capitalize(ByVal x As String) As String
    Return StrConv(x, vbProperCase)
  End Function


  <Extension()> _
  Sub jScript(ByVal x As StringBuilder, ByVal y As String)
    x.Append("<script type=""text/javascript"">" & y & "</script>")
  End Sub


End Module

