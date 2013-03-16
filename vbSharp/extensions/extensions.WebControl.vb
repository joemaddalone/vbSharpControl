Imports System.Runtime.CompilerServices
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.Control
Imports System.Text
Imports System.IO
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Public Module Extensions_WebControl

  ''' <summary>
  ''' Returns webcontrol as string
  ''' </summary>
  ''' <param name="ctrl"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function rc(ByVal ctrl As Control) As String
    Dim sb As New StringBuilder
    Dim tw As New StringWriter(sb)
    Dim hw As New HtmlTextWriter(tw)
    ctrl.RenderControl(hw)
    Return sb.ToString
    tw.Dispose()
    hw.Dispose()

  End Function

  ''' <summary>
  ''' appends one control to another
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="y"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub AppendControl(ByVal x As Control, ByVal y As Control)
    x.Controls.Add(y)
    End Sub

    <Extension()> _
    Public Sub AppendControls(ByVal x As Control, ByVal path As String, ByVal y As String())
        For Each c In y
            x.Controls.Add((CType(HttpContext.Current.Handler, Page)).LoadControl(path & c & ".ascx"))
        Next
    End Sub


  ''' <summary>
  ''' Adds literal and literal text to control
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="y"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub Addlit(ByVal x As Control, ByVal y As String)
    Using z As New LiteralControl : z.Text = y : x.AppendControl(z) : End Using
  End Sub

  ''' <summary>
  ''' adds CSS link to control
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="y"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub AddCSS(ByVal x As Control, ByVal y As String)
    x.Addlit("<link href=""" & y & """ rel=""stylesheet"" type=""text/css"" />")
  End Sub


  <Extension()> _
  Public Sub AddCSS(ByVal x As StringBuilder, ByVal y As String)
    x.Append("<link href=""" & y & """ rel=""stylesheet"" type=""text/css"" />")
  End Sub

  ''' <summary>
  ''' add javascript link to control
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="y"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub AddJS(ByVal x As Control, ByVal y As String)
    x.Addlit("<script type=""text/javascript"" src=""" & y & """></script>")
  End Sub

  <Extension()> _
  Public Sub AddJS(ByVal x As StringBuilder, ByVal y As String)
    x.Append("<script type=""text/javascript"" src=""" & y & """></script>")
  End Sub


  ''' <summary>
  ''' adds javascript to control
  ''' </summary>
  ''' <param name="x"></param>
  ''' <param name="y"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Sub jScript(ByVal x As Control, ByVal y As String)
    x.Addlit("<script type=""text/javascript"">" & y & "</script>")
  End Sub

  <Extension()> _
  Public Sub RecursiveTitleSelect(ByVal ddl As DropDownList, ByVal id As Integer, ByVal seq As Integer, ByVal table As String)
    Dim recs As New Data.DataTable
    Dim lVal As String = ""
    recs = read.sql("SELECT tbl.id, tbl.title,(SELECT COUNT(*) FROM " & table & _
        " WHERE parentid=tbl.id) countofchildren FROM " & table & " tbl " & _
        "WHERE parentID =" & id & " ORDER BY Title")
    If recs.Rows.Count > 0 Then
      For a As Integer = 0 To recs.Rows.Count - 1
        If id <> 0 Then
          For b As Integer = 1 To seq
            lVal &= ("--")
          Next
        End If
        ddl.Items.Add(New ListItem(lVal & __(recs.Rows(a)(1)), __(recs.Rows(a)(0))))
        If CInt(recs.Rows(a)("countofchildren")) > 0 Then
          ddl.RecursiveTitleSelect(CInt(recs.Rows(a)(0)), a + seq + 2, table)
        End If
        lVal = ""
      Next
    End If
  End Sub

End Module

