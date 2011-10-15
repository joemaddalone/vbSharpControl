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
  Public Function mReplace(src As String, find As String()) As String
    Dim ret As String = src
    Array.ForEach(find, New Action(Of String)(Sub(str) ret = ret.Replace(str, "")))
    Return ret
  End Function
End Module

