Option Strict On
Option Explicit On

Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class jq
  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="markup"></param>
  ''' <param name="src"></param>
  ''' <param name="destination"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function tmpl(ByVal markup As String, ByVal src As String, ByVal destination As String) As String
    Return "<script type=""text/javascript"">$.tmpl(""" & markup & """, " & src & ").appendTo(""" & destination & """);</script>"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="ajaxCall"></param>
  ''' <param name="url"></param>
  ''' <param name="vals"></param>
  ''' <param name="pars"></param>
  ''' <param name="redirect"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function ajax(ByVal ajaxCall As String, ByVal url As String, ByVal vals As String(), ByVal pars As String(), Optional redirect As String = "") As String
    Dim ret As New StringBuilder
    With ret
      .Append(ajaxCall & "(")
      .Append("'")
      For i As Integer = 0 To pars.Count - 1
        .Append("&")
        .Append(pars(i))
        .Append("=' + " & vals(i) & " + '")
      Next
      .Append("'")
      .Append(",'" & url & "','" & redirect & "');")
    End With

    Return ret.ToString
  End Function

  
  Shared Function val(selector As String) As String
    Return "$('" & selector & "').val()"
  End Function

  Shared Function val(selector As String, value As String) As String
    Return "$('" & selector & "').val(" & value & ")"
  End Function

  Shared Function html(selector As String) As String
    Return "$('" & selector & "').html()"
  End Function

  Shared Function html(selector As String, value As String) As String
    Return "$('" & selector & "').html(" & value & ")"
  End Function


  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="selector"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function isChecked(selector As String) As String
    '$('#status').is(':checked')
    Return "$('" & selector & "').is(':checked')"
  End Function

  Shared Function checkVals(title As String) As String
    Return "$('input[name=""" & title & """]:checked').map(function(){ return $(this).val(); }).get().join("","")"
  End Function

  Shared Function load(selector As String, src As String) As String
    Return "$('" & selector & "').load('" & src & "');"
  End Function

  Shared Function click(selector As String, action As String) As String
    Return "$('" & selector & "').click(function(){" & action & "});"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="code"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function ready(code As String) As String
    Return "$(document).ready(function () {" & code & "});"
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="src"></param>
  ''' <param name="destination"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Shared Function matchContent(src As String, destination As String) As String
    Return "$('" & src & "').keyup(function(){$('" & destination & "').html($('" & src & "').val());"
  End Function

  Shared Function MakeTabs(ByVal title As String, Optional ByVal css As String = "") As String
    Dim ret As New StringBuilder
    Dim tabArr As String()
    tabArr = title.Split(","c)
    With ret
      .Append("<ul class=""ui-tabs-nav"" style=""font-size:11px"">")
      For i As Integer = 0 To tabArr.Length - 1
        If tabArr(i).ToString.IndexOf("#") = -1 Then
          .Append("<li><a style=""" & css & """ href=""#tabs-" & i + 1 & """>" & tabArr(i).ToString & "</a></li>")
        Else
          .Append("<li><a style=""" & css & """ href=""#tabs-" & tabArr(i).ToString.Split(CChar("#"))(1) & """>" & tabArr(i).ToString.Split(CChar("#"))(0) & "</a></li>")
        End If
      Next
      .Append("</ul>")
    End With
    Return ret.ToString
  End Function


  Shared Function AjaxTabs(ByVal title As String, ByVal href As String) As String
    Dim ret As New StringBuilder
    Dim tabArr As String()
    Dim hArr As String()
    If title <> "" AndAlso href <> "" Then
      tabArr = title.Split(","c)
      hArr = href.Split(","c)
      With ret
        .Append("<ul class=""ui-tabs-nav"" style=""font-size:11px"">")
        For i As Integer = 0 To tabArr.Length - 2
          .Append("<li><a href=""" & hArr(i).ToString() & """>" & tabArr(i).ToString & "</a></li>")
        Next
        .Append("</ul>")
      End With
    End If

    Return ret.ToString
  End Function




  Public Class Accordion
    Implements ITemplate
    Dim TemplateType As ListItemType
    Sub New(ByVal type As ListItemType)
      TemplateType = type
    End Sub

    Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
      Dim lc As New Literal()
      AddHandler lc.DataBinding, AddressOf Accordion_DataBinding
      container.Controls.Add(lc)
    End Sub

    Private Sub Accordion_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs)
      Dim lc As Literal = CType(sender, Literal)
      Dim tbl As New StringBuilder()
      Dim container As RepeaterItem
      container = CType(lc.NamingContainer, RepeaterItem)
      With tbl
        .Append(tag("h3", href("#", CStr(DirectCast(container.DataItem, System.Data.DataRowView)("title")))))
        .Append("<div>")
        .Append(PresentContent(CStr(DirectCast(container.DataItem, System.Data.DataRowView)("content"))))
        .Append("</div>")

      End With
      lc.Text = tbl.ToString()
    End Sub
  End Class

End Class
