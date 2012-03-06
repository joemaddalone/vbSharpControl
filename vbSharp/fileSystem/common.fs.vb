﻿Option Strict On
Public Class fs
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="filepath"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  ''' 
  Public Shared Function read(ByVal filepath As String) As String
    Using sr As New System.IO.StreamReader(filepath) : Return sr.ReadToEnd() : End Using
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <remarks></remarks>
  Public Shared exists As Func(Of String, Boolean) = Function(path) New IO.FileInfo(path).Exists
  Public Shared delete As Action(Of String) = Sub(path) If fs.exists(path) Then IO.File.Delete(path)
  Public Shared move As Action(Of String, String) = Sub(src, dest) IO.File.Move(src, dest)
  Public Shared rename As Action(Of String, String) = Sub(src, dest) IO.File.Move(src, dest)


  Shared Sub create(path As String, content As String)
    fs.delete(path)
    Using x As New System.IO.StreamWriter(path, False) : x.WriteLine(content) : x.Close() : End Using
  End Sub

End Class