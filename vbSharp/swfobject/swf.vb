Option Strict On
Option Explicit On

Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class swf
  Shared Function addStatic(ByVal path As String, ByVal width As String, ByVal height As String, id As String) As String
    Return "<object style=""z-index:-100"" classid=""clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"" width=""" & width & """ height=""" & height & """ id=""" & id & """> " & _
          "<param name=""movie"" value=""" & path & """ /> " & _
          "<param name=""wmode"" value=""transparent"" />" & _
          "<!--[if !IE]>--> " & _
          "<object style=""z-index:-100"" type=""application/x-shockwave-flash"" data=""" & path & """ width=""" & width & """ height=""" & height & """> " & _
          "<!--<![endif]--> " & _
          "<a href=""http://www.adobe.com/go/getflashplayer""> " & _
          "<img src=""http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"" alt=""Get Adobe Flash player"" /> " & _
          "</a> " & _
          "<!--[if !IE]>--> " & _
          "</object> " & _
          "<!--<![endif]--> " & _
          "</object> "
  End Function

  Shared Function addDynamic(ByVal path As String, ByVal width As String, ByVal height As String, id As String) As String
    Dim ret As New StringBuilder
    ret.Append("var flashvars = {};")
    ret.Append("var params = {};")
    ret.Append("var attributes = {wmode:'transparent'};")
    ret.Append("swfobject.embedSWF('" & path & "','" & id & "','" & width & "','" & height & "', '9.0.0',flashvars, params, attributes);")
    Return ret.ToString
  End Function

  Shared Function register(id As String) As String
    Return "swfobject.registerObject('flashContent', '9.0.0');"
  End Function



End Class
