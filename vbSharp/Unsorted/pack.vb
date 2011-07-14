Imports System.Text
Imports System.Text.RegularExpressions

Public Class pack

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="str"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared Function css(str As String) As String
    str = StripCSSComments(str)
    str = str.Replace("  ", [String].Empty)
    str = str.Replace(Environment.NewLine + Environment.NewLine + Environment.NewLine, [String].Empty)
    str = str.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine)
    str = str.Replace(Environment.NewLine, [String].Empty)
    str = str.Replace(vbTab, String.Empty)
    str = str.Replace(" {", "{")
    str = str.Replace(" :", ":")
    str = str.Replace(": ", ":")
    str = str.Replace(", ", ",")
    str = str.Replace("; ", ";")
    str = str.Replace(";}", "}")
    str = Regex.Replace(str, "/\*[^\*]*\*+([^/\*]*\*+)*/", "$1")
    str = Regex.Replace(str, "(?<=[>])\s{2,}(?=[<])|(?<=[>])\s{2,}(?=&nbsp;)|(?<=&ndsp;)\s{2,}(?=[<])", [String].Empty)
    Return str
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="str"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Private Shared Function StripCSSComments(str As String) As String
    str = Regex.Replace(str, "/\*.+?\*/", "", RegexOptions.Singleline)
    Return str
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="files"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared Function mergeCSS(files As String()) As String
    Dim ret As New StringBuilder
    For Each file In files
      ret.Append(pack.css(fs.read(file)))
    Next
    Return ret.ToString
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="files"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared Function mergeJS(files As String()) As String
    Dim ret As New StringBuilder
    For Each file In files
      ret.Append(fs.read(file))
    Next
    Return ret.ToString
  End Function

End Class

