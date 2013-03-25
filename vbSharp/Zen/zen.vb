Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Text.StringBuilder

Public Class zen
    Public Property output As String = ""
    Public Property selfClose As List(Of String)

    Sub New(x As String)
        Dim ret As New StringBuilder
        Dim openElements As New List(Of String)
        selfClose = New List(Of String)
        With selfClose
            .Add("br")
            .Add("input")
            .Add("hr")
        End With

        Dim Elements As New List(Of element)
        'el,class,id,attr,inner,connector
        Dim items As String() = Regex.Split(x, "(>|\+)")
        For i As Integer = 0 To items.Length - 1 Step 2
            'Console.WriteLine(Regex.Split(items(i), "(\$\{|\.|\#|\{|\[)")(0))
            Dim item As String = items(i)
            Dim attributes As String = checkForPair(item, New Char() {"["c, "]"c})
            If attributes <> "" Then item = item.Replace(attributes, "")
            Dim innerHTML As String = checkForPair(item, New Char() {"{"c, "}"c})
            If innerHTML <> "" Then item = item.Replace(innerHTML, "")
            Dim cssClass As String = checkForSegment(item, CChar("."))
            Dim id As String = checkForSegment(item, CChar("#"))

            If Not i = items.Length - 1 Then
                Elements.Add(New element With {.el = Regex.Split(items(i), "(\$\{|\.|\#|\{|\[)")(0), .cssClass = cssClass, .attributes = attributes, .innerHTML = innerHTML, .id = id, .connector = items(i + 1)})
            Else
                Elements.Add(New element With {.el = Regex.Split(items(i), "(\$\{|\.|\#|\{|\[)")(0), .cssClass = cssClass, .attributes = attributes, .innerHTML = innerHTML, .id = id, .connector = ""})
            End If
        Next

        Dim tmp As String = ""
        For Each item In Elements
            Dim attr As New StringBuilder
            If item.attributes <> "" Then
                Dim itemArr As String() = item.attributes.Split(" "c)
                item.attributes = ""
                For q As Integer = 0 To itemArr.Length - 1
                    Dim eq As Integer = itemArr(q).IndexOf("="c) + 1
                    item.attributes &= itemArr(q).Substring(0, eq) & """" & itemArr(q).Substring(eq) & """ "
                Next
            End If

            ret.Append("<" & item.el & If(item.cssClass <> "", " class=""" & item.cssClass & """", "") & If(item.id <> "", " id=""" & item.id & """", "") & If(item.attributes <> "", " " & Trim(item.attributes), ""))
            If item.connector = "+" Or item.connector = "" Then
                If selfClose.Contains(item.el) Then
                    ret.Append(" />")
                Else
                    ret.Append(">")
                    If item.innerHTML <> "" Then ret.Append(item.innerHTML)
                    ret.Append("</" & item.el & ">")
                End If
            Else
                ret.Append(">")
                openElements.Add("</" & item.el & ">")
            End If
        Next
        openElements.Reverse()
        For Each item In openElements
            ret.Append(item)
        Next
        Me.output = ret.ToString()
    End Sub

    Function checkForPair(v As String, y As Char()) As String
        Dim pos1 As Integer = v.IndexOf(y(0))
        Dim pos2 As Integer
        If pos1 > -1 Then
            pos2 = v.Substring(pos1).IndexOf(y(1))
            Return v.Substring(pos1 + 1, pos2 - 1)
        Else
            Return ""
        End If
    End Function


    Function checkForSegment(x As String, y As Char) As String
        Dim attrs As String() = Regex.Split(x, "(\$\{|\.|\#|\{|\[)")
        Dim retString As New StringBuilder
        For i As Integer = 1 To attrs.Length - 1 Step 2
            If attrs(i) = y Then
                retString.Append(attrs(i + 1) & " ")
            End If
        Next
        Return Trim(retString.ToString)
    End Function


    Function closer(type As String) As String
        If Me.selfClose.Contains(type) Then
            Return (" />")
        Else
            Return ("</" & type & ">")
        End If

    End Function



    Class element
        Public Property el As String = ""
        Public Property cssClass As String = ""
        Public Property id As String = ""
        Public Property attributes As String = ""
        Public Property innerHTML As String = ""
        Public Property connector As String = ""
    End Class

End Class
