Imports System.Runtime.CompilerServices
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.Control
Imports System.Text
Imports System.IO
Imports System.Web.UI.HtmlControls
Imports System.Data


''' <summary>
''' Extends data.datatable
''' </summary>
''' <remarks></remarks>
Public Module Extensions_DataTable
   
    <Extension()> _
    Public Sub forEach(ByVal recs As Data.DataTable,
            ByVal del As System.Delegate,
            Optional ByVal callback As System.Delegate = Nothing,
            Optional ByVal empty As System.Delegate = Nothing)
        If hasrecs(recs) Then
            Dim iterations As Integer = recs.Rows.Count
            Dim i As Integer = 0
            Dim x As Integer = 0
            If iterations > 8 Then
                Dim n As Integer = iterations Mod 8
                If n > 0 Then
                    For i = 0 To n - 1
                        del.DynamicInvoke(recs.Rows(i), x)
                        x += 1
                    Next
                End If
                n = CInt((iterations - x) / 8)
                For i = n To 1 Step -1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                    del.DynamicInvoke(recs.Rows(x), x) : x += 1
                Next
            Else
                For i = 0 To recs.Rows.Count - 1
                    del.DynamicInvoke(recs.Rows(i), i)
                Next
            End If
        Else
            If Not empty Is Nothing Then empty.DynamicInvoke()
        End If
        If Not callback Is Nothing Then callback.DynamicInvoke()
    End Sub

    ''' <summary>
    ''' isLast for data.row
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    <Extension()> _
    Public Function isLast(ByVal row As Data.DataRow, index As Integer) As Boolean
        Return index = (row.Table.Rows.Count - 1)
    End Function

    ''' <summary>
    ''' isFirst for data.row
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    <Extension()> _
    Public Function isFirst(ByVal row As Data.DataRow, index As Integer) As Boolean
        Return index = 0
    End Function

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



    <Extension()> _
    Public Function mFields(ByVal row As Data.DataRow, fields As String(), Optional sep As String = " ") As String
        Dim ret As New StringBuilder
        Array.ForEach(fields, New Action(Of String)(Sub(str) ret.Append(__(row(str)) & sep)))
        Return ret.ToString
    End Function



    <Extension()> _
    Public Function toArray(ByVal col As Data.DataColumn) As String()
        Dim ret As New List(Of String)
        Dim recs As Data.DataTable = col.Table
        recs.forEach(Sub(r As Data.DataRow, i As Integer)
                         ret.Add(__(r(col.ColumnName)))
                     End Sub)
        Return ret.ToArray()
    End Function


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
    ''' <param name="caption"></param>
    ''' <param name="fields"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Extension()> _
    Function toTable(ByVal recs As Data.DataTable,
                     Optional ByVal cssclass As String = "",
                     Optional ByVal id As String = "",
                     Optional ByVal caption As String = "",
                     Optional ByVal fields As String() = Nothing) As String
        Dim ret As New StringBuilder
        If Not recs Is Nothing AndAlso hasrecs(recs) Then
            With ret
                .Append("<table class=""" & cssclass & """ id=""" & id & """>")
                If caption <> "" Then
                    .Append(html.caption(caption))
                End If
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

    <Extension()> _
    Function template(ByVal recs As Data.DataTable,
                     pattern As String, Optional header As String = "",
                     Optional footer As String = "") As String
        Dim ret As New StringBuilder
        Dim tmp As String = pattern
        If Not recs Is Nothing AndAlso hasrecs(recs) Then
            recs.forEach(Sub(r As Data.DataRow, x As Integer)
                             tmp = pattern
                             r.forEach(Sub(dat As String, i As Integer)
                                           tmp = tmp.Replace("__" & recs.Columns(i).ColumnName & "__", dat)
                                           tmp = tmp.Replace("${" & recs.Columns(i).ColumnName & "}", dat)
                                       End Sub, callback:=Sub() ret.Append(tmp))
                         End Sub)
        End If
        Return header & ret.ToString & footer
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
        If cols > 0 Then
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
        Else
            With ret
                .Append("var " & id & " = [")
                recs.forEach(Sub(r As Data.DataRow, i As Integer)
                                 .Append("""" & __(r(0)) & """")
                                 If i < recs.Rows.Count - 1 Then
                                     .Append(",")
                                 End If
                             End Sub)
                .Append("];")
            End With
        End If
        Return ret.ToString
    End Function

    ''' <summary>
    ''' converts datatable to JSON
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
                             .Append(If(i < rows, "),", ")"))
                         End Sub)
            .Append("]};")
        End With
        Return ret.ToString
    End Function
   
    <Extension()> _
    Public Function toCSV(ByVal recs As Data.DataTable) As String
        Dim ret As New StringBuilder
        If (recs.Columns.Count <> 0) Then
            For Each col As Data.DataColumn In recs.Columns
                ret.Append("[" & col.ColumnName & "],")
            Next
            ret.Append(vbCrLf)
            For Each row As Data.DataRow In recs.Rows
                For Each col As Data.DataColumn In recs.Columns
                    If col.DataType Is GetType(String) Then
                        ret.Append("""" & row(col).ToString() & """,")
                    Else
                        ret.Append(row(col).ToString() & ",")
                    End If
                Next
                ret.Append(vbCrLf)
            Next
        End If
        Return ret.ToString().Replace("," & vbCrLf, vbCrLf)
    End Function

    <Extension()> _
    Public Function contains(recs As Data.DataTable, val As String, field As String) As Boolean
        Dim ret As Boolean = False
        recs.forEach(Sub(r As Data.DataRow, x As Integer)
                         If __(r(field)) = val Then
                             ret = True
                         End If
                     End Sub)
        Return ret
    End Function


    <Extension()> _
    Function [dim](ByVal recs As Data.DataTable,
                 fields As String()) As Dictionary(Of String, String)
        Dim ret As New Dictionary(Of String, String)
        Dim has As Boolean = hasrecs(recs)
        For Each field In fields
            ret.Add(field, If(has, __(recs.Rows(0)(field)), ""))
        Next
        Return ret
    End Function

End Module

