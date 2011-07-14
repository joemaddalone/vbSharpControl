Imports System.Runtime.CompilerServices
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.Control
Imports System.Text
Imports System.IO
Imports System.Web.UI.HtmlControls
''' <summary>
''' Extends data.datatable
''' </summary>
''' <remarks></remarks>
Public Module Extensions_DataTable
  ''' <summary>
  ''' forEach for data.datatable, Replace for... next
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="del"></param>
  ''' <param name="alt"></param>
  ''' <param name="callback"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub forEach(ByVal recs As Data.DataTable,
            ByVal del As System.Delegate,
            Optional ByVal alt As System.Delegate = Nothing,
            Optional ByVal callback As System.Delegate = Nothing)
    If hasrecs(recs) Then
      Dim q As System.Delegate
      If alt Is Nothing Then alt = del
      Dim iterations As Integer = recs.Rows.Count
      Dim i As Integer = 0
      Dim x As Integer = 0
      If iterations > 8 Then
        Dim n As Integer = iterations Mod 8
        If n > 0 Then
          For i = 0 To n - 1
            q = If(i Mod 2 = 1, alt, del)
            q.DynamicInvoke(recs.Rows(i), x)
            x += 1
          Next
        End If
        n = CInt((iterations - x) / 8)
        For i = n To 1 Step -1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
          q = If(x Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(x), x) : x += 1
        Next
      Else
        For i = 0 To recs.Rows.Count - 1
          q = If(i Mod 2 = 1, alt, del)
          q.DynamicInvoke(recs.Rows(i), i + 1)
        Next
      End If
    End If
    If Not callback Is Nothing Then callback.DynamicInvoke()
  End Sub

  ''' <summary>
  ''' forEach for data.row
  ''' </summary>
  ''' <param name="row"></param>
  ''' <param name="del"></param>
  ''' <param name="alt"></param>
  ''' <param name="callback"></param>
  ''' <remarks></remarks>
  <Extension()> _
  Public Sub forEach(ByVal row As Data.DataRow,
            ByVal del As System.Delegate,
            Optional ByVal alt As System.Delegate = Nothing,
            Optional ByVal callback As System.Delegate = Nothing)
    Dim q As System.Delegate
    If alt Is Nothing Then alt = del
    Dim cols As Integer = row.ItemArray.Count - 1
    Dim i As Integer = 0
    For i = 0 To cols
      q = If(i Mod 2 = 1, alt, del)
      q.DynamicInvoke(__(row(i)), i)
    Next
    If Not callback Is Nothing Then callback.DynamicInvoke()
  End Sub

  ''' <summary>
  ''' This is cheating for the end user who absolutely cant use ROW_NUMBER
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="first"></param>
  ''' <param name="last"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Public Function range(ByVal recs As Data.DataTable,
            ByVal first As Integer, ByVal last As Integer
            ) As DataTable
    recs = recs.DefaultView.ToTable
    For i As Integer = first - 2 To 0 Step -1
      recs.Rows(i).Delete()
    Next
    For i As Integer = recs.Rows.Count - 1 To last + 1 - first Step -1
      recs.Rows(i).Delete()
    Next
    Return recs
  End Function



  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="fields"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function toTable(ByVal recs As Data.DataTable,
                     Optional ByVal cssclass As String = "",
                     Optional ByVal fields As String() = Nothing) As String
    Dim ret As New StringBuilder
    If Not recs Is Nothing AndAlso hasrecs(recs) Then
      With ret
        .Append(If(cssclass = "", "<table>", "<table class=""" & cssclass & """>"))
        .Append("<thead>")
        .Append("<tr>")
        If fields Is Nothing Then
          For hcol As Integer = 0 To recs.Columns.Count - 1
            .Append(th(recs.Columns(hcol).ColumnName))
          Next
        Else
          For Each col In fields
            .Append(th(recs.Columns(col).ColumnName))
          Next
        End If
        .Append("</tr>")
        .Append("</thead>")
        .Append("<tbody>")
        If fields Is Nothing Then
          recs.forEach(
            Sub(row As Data.DataRow, i As Integer)
              .Append("<tr>")
              row.forEach(Sub(dat As String, col As Integer)
                            .Append(td(CStr(dat)))
                          End Sub, callback:=Sub() .Append("</tr>"))
            End Sub)
        Else
          recs.forEach(
            Sub(row As Data.DataRow, i As Integer)
              .Append("<tr>")
              For Each col In fields
                .Append(td(CStr(row(col))))
              Next
            End Sub)
        End If

        .Append("</tbody>")
        .Append("</table>")
      End With

    End If
    Return ret.ToString
  End Function

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="field"></param>
  ''' <param name="cssclass"></param>
  ''' <param name="ordered"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Function toList(ByVal recs As Data.DataTable,
                  ByVal field As String,
                  Optional ByVal cssclass As String = "",
                  Optional ByVal ordered As Boolean = False) As String
    Dim ret As New StringBuilder
    If Not recs Is Nothing AndAlso hasrecs(recs) Then
      With ret
        If Not ordered Then
          .Append(If(cssclass = "", "<ul>", "<ul class=""" & cssclass & """>"))
        Else
          .Append(If(cssclass = "", "<ol>", "<ol class=""" & cssclass & """>"))
        End If
        recs.forEach(
          Sub(row As Data.DataRow, i As Integer)
            .Append(tag("li", (__(row(field)))))
          End Sub, callback:=Sub() .Append(If(Not ordered, "</ul>", "</ol>")))
      End With
    End If
    Return ret.ToString
  End Function

  ''' <summary>
  ''' converts a datatable to javascript array
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="id"></param>
  ''' <returns>String</returns>
  ''' <remarks></remarks>
  <Extension()> _
  Public Function toJS(ByVal recs As Data.DataTable, ByVal id As String) As String
    Dim ret As New StringBuilder
    Dim rows As Integer = recs.Rows.Count - 1
    Dim cols As Integer = recs.Columns.Count - 1
    With ret
      .Append("var " & id & " = new Array(" & rows & ");")
      .Append("for (i=0; i <=" & rows & "; i++){ " &
              id & "[i] = new Array(" & cols & ");}")
      recs.forEach(Sub(row As Data.DataRow, i As Integer)
                     row.forEach(Sub(dat As String, col As Integer)
                                   .Append(id & "[" & i & "][" & col & "] = """ &
                                   PG.Server.HtmlEncode(dat.Replace(Chr(10), " ").Replace(Chr(13), " ").Replace(Chr(10) & Chr(13), " ")) & """;")
                                 End Sub)
                   End Sub)
    End With
    Return "<script type=""text/javascript"">" & ret.ToString & "</script>"
  End Function

  ''' <summary>
  ''' convets datatable to JSON
  ''' </summary>
  ''' <param name="recs"></param>
  ''' <param name="id"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  <Extension()> _
  Public Function toJSON(ByVal recs As Data.DataTable, ByVal id As String) As String
    Dim ret As New StringBuilder
    Dim rows As Integer = recs.Rows.Count - 1
    Dim cols As Integer = recs.Columns.Count - 1
    Dim colString As New List(Of String)

    For i As Integer = 0 To recs.Columns.Count - 1
      colString.Add(recs.Columns(i).ColumnName)
    Next

    Dim retString As String = ""
    For i As Integer = 0 To recs.Columns.Count - 1
      retString &= colString.Item(i) & ":arguments[" & i & "]" & ","
    Next
    retString = retString.TrimEnd(","c)
    With ret
      .Append("var " & id & ";")
      .Append("var " & id & "RowDat = function(" & Join(colString.ToArray(), ",") & "){")
      .Append("return {" & retString & "}")
      .Append("};")
      .Append("var " & id & " = {rows:[")
      recs.forEach(Sub(row As Data.DataRow, i As Integer)
                     .Append("new " & id & "RowDat(")
                     row.forEach(Sub(dat As String, x As Integer)
                                   .Append("""" & PG.Server.HtmlEncode(dat.Replace(Chr(10), " ").Replace(Chr(13), " ").Replace(Chr(10) & Chr(13), " ")) & """")
                                   If x < cols Then .Append(",")
                                 End Sub)
                     .Append(If(i < rows + 1, "),", ")"))
                   End Sub)
      .Append("]};")
    End With
    Return "<script type=""text/javascript"">" & ret.ToString & "</script>"
  End Function





End Module

