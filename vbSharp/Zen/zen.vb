Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Text.StringBuilder

Public Class zen
    Public output As String = ""
    Public Shared selfClose() As String = {"img", "br", "input", "hr"}
    Sub New(x As String)
        x = x.Replace("=#", "=|||").Replace("=${", "=!!!")
        Dim items As String() = Regex.Split(x, "(>|\+)")
        Dim ret As New StringBuilder
        Dim isSelfClose As Boolean = False
        Dim element As String = ""
        Dim op As String = ""
        Dim val As String = ""
        Dim openElements As New List(Of String)
        With ret
            For i As Integer = 0 To items.Length - 1
                Dim funcs As String() = Regex.Split(items(i), "(#|\.|\*|{|\[|\$)")
                For f As Integer = 0 To funcs.Length - 1 Step 2
                    If f = 0 Then
                        'Console.WriteLine("f=" & funcs(f))
                        If funcs(f) = ">" Then .Append(">") : Exit For
                        If funcs(f) = "+" Then .Append(zen.closer(openElements(openElements.Count - 1))) : openElements.Remove(openElements(openElements.Count - 1)) : Exit For
                        element = funcs(f)
                        openElements.Add(element)
                        .Append("<" & element)
                    Else
                        op = funcs(f - 1)
                        val = funcs(f)
                        Select Case op
                            Case ">"
                                .Append(op)
                                'child
                            Case "."
                                'class
                                .Append(" class=""" & val & """")
                            Case "#"
                                'id
                                .Append(" id=""" & val & """")
                            Case "{"
                                'innerHTML
                                .Append(">" & val.Substring(0, val.Length - 1))
                            Case "["
                                Dim attrs As String() = val.Replace("|||", "#").Replace("=!!!", "=${").Split("="c)

                                .Append(" " & attrs(0) & "=""" & attrs(1).TrimEnd("]"c) & """")
                                'attribute
                            Case "*"
                                'multiplier
                            Case "$"
                                'dynamic content
                                f += 2
                                val = funcs(f)

                                .Append(">${" & val)
                            Case Else
                                element = funcs(f)
                                openElements.Add(element)
                                .Append("<" & element)
                        End Select
                    End If
                Next

            Next
            If ret(ret.Length - 1) <> ">" AndAlso ret(ret.Length - 1) <> "}" AndAlso op <> "{" AndAlso op <> "[" Then
                .Append(">")
            End If
            openElements.Reverse()
            For Each item In openElements
                .Append(zen.closer(item))
            Next
        End With

        Me.output = ret.ToString()
    End Sub
    Public Shared Function closer(type As String) As String
        If zen.selfClose.Contains(type).Length > 0 Then
            Return (" />")
        Else
            Return ("</" & type & ">")
        End If

    End Function
End Class
