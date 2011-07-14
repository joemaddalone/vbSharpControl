Option Strict On
Imports System.Text
Imports System.Runtime.CompilerServices
Public Module Extensions_HTML


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="str"></param>
  ''' <param name="href"></param>
  ''' <param name="cssClass"></param>
  ''' <param name="id"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Public Function toLink(ByVal str As String, Optional ByVal href As String = "",
                           Optional ByVal cssClass As String = "",
                           Optional ByVal id As String = "") As String
    Return "<a href=""" & href & """ id=""" & id & """ class=""" & cssClass & """>" & str & "</a>"
  End Function




End Module