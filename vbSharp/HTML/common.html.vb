Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices
Imports System.Web.UI.WebControls
Imports System.Web.UI
Imports System.IO



Public Module commonhtml

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="val"></param>
  ''' <param name="width"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function td(ByVal val As String, Optional ByVal width As String = "") As String
    If val <> "" Then
      If width = "" Then
        Return "<td>" & val & "</td>"
      Else
        Return "<td width=""" & width & """>" & val & "</td>"
      End If
    Else
      If width = "" Then
        Return "<td>&nbsp;</td>"
      Else
        Return "<td width=""" & width & """>&nbsp;</td>"
      End If
    End If

  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="val"></param>
  ''' <param name="width"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function th(ByVal val As String, Optional ByVal width As String = "") As String
    If val <> "" Then
      If width = "" Then
        Return "<th>" & val & "</th>"
      Else
        Return "<th width=""" & width & """>" & val & "</th>"
      End If
    Else
      If width = "" Then
        Return "<th>&nbsp;</th>"
      Else
        Return "<th width=""" & width & """>&nbsp;</th>"
      End If
    End If

  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="ulid"></param>
  ''' <param name="ulclass"></param>
  ''' <param name="liclass"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Public Function toUL(ByVal x As String(), ByVal ulid As String, Optional ByVal ulclass As String = "",
                           Optional ByVal liclass As String = "") As String
    Dim ret As New StringBuilder
    ret.Append(If(ulclass = "", "<ul id=""" & ulid & """>", "<ul id=""" & ulid & """ class=""" & ulclass & """>"))
    For i As Integer = 0 To x.Count - 1
      ret.Append(tag("li", x(i), liclass))
    Next
    ret.Append("</ul>")
    Return ret.ToString

  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="url"></param>
  ''' <param name="lbl"></param>
  ''' <param name="style"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function href(ByVal url As String, ByVal lbl As String, Optional ByVal style As String = "") As String
    If style = "" Then
      Return "<a href=""" & url & """>" & lbl & "</a>"
    Else
      Return "<a href=""" & url & """ class=""" & style & """>" & lbl & "</a>"
    End If
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="url"></param>
  ''' <param name="src"></param>
  ''' <param name="cls"></param>
  ''' <param name="title"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function imghref(ByVal url As String, ByVal src As String, ByVal cls As String, Optional ByVal title As String = "") As String
    Return "<a href=""" & url & """><img src=""" & src & """ class=""" & cls & """ title=""" & title & """></a>"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="url"></param>
  ''' <param name="src"></param>
  ''' <param name="imagecls"></param>
  ''' <param name="aclass"></param>
  ''' <param name="title"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function imghref(ByVal url As String, ByVal src As String, ByVal imagecls As String, ByVal aclass As String, ByVal title As String) As String
    Return "<a href=""" & url & """ class=""" & aclass & """><img src=""" & src & """ class=""" & imagecls & """ title=""" & title & """></a>"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="htag"></param>
  ''' <param name="content"></param>
  ''' <param name="style"></param>
  ''' <param name="id"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Function tag(ByVal htag As String, ByVal content As String, Optional ByVal style As String = "", Optional id As String = "") As String
    Return "<" & htag & If(style <> "", " class=""" & style & """", "") & If(id <> "", " id=""" & id & """", "") & ">" & content & "</" & htag & ">"
  End Function





  Public PresentContent As Func(Of String, String) = Function(str) If(str.IndexOf(">") > 0, AddBreaks(str), str)
  Public AddBreaks As Func(Of String, String) = Function(str) str.Replace(Chr(13) & Chr(10), "<br />")
  Public RemoveHTML As Func(Of String, String) = Function(str) Regex.Replace(__(str), "<(.|\n)*?>", "")
  Public truncateSummary As Func(Of String, Integer, String) = Function(str, l) If(str.Length > l, str.Substring(0, l) & "...", str)
  Public link As Func(Of String, String, String) = Function(url, lbl) href(url, lbl)






End Module


