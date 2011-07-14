Option Strict On
Imports System.Text.RegularExpressions
'Not oringally written by Joe Maddalone -- no idea where it came from
Public Class JSONObject
  Private Shared ReadOnly reProp As New Regex("(?<=(^|\,)\s*)([^\:]+)\s*\:\s*([^\,]+)", RegexOptions.Compiled)
  Private Shared ReadOnly reReplaced As New Regex("^\$\[\d+\]$", RegexOptions.Compiled)

  Private Shared Function TokenizeJSON(ByVal json As String, ByVal l As List(Of String)) As String
    Dim r As String = String.Empty,
        nestable As String = "()[]{}",
        stringable As String = """'",
        nested As New Stack(Of Char),
        stringing As Char? = Nothing,
        start As Integer = -1
    l.Clear()

    For i As Integer = 0 To json.Length - 1
      Dim c As Char = json(i)
      If stringing IsNot Nothing Then
        If stringing = c Then
          stringing = Nothing
          If nested.Count = 0 Then
            r &= "$[" & l.Count.ToString() & "]"
            l.Add(json.Substring(start, i - start + 1))
          End If
        End If
      ElseIf stringable.IndexOf(c) > -1 Then
        stringing = c
        If nested.Count = 0 Then start = i
      ElseIf nestable.IndexOf(c) Mod 2 = 0 Then
        If nested.Count = 0 Then start = i
        nested.Push(c)
      ElseIf nested.Count > 0 Then
        If nestable.IndexOf(nested.Peek()) + 1 = nestable.IndexOf(c) Then
          nested.Pop()
          If nested.Count = 0 Then
            r &= "$[" & l.Count.ToString() & "]"
            l.Add(json.Substring(start, i - start + 1))
          End If
        End If
      Else
        r &= If(c = "\" OrElse c = "$", "\" & c, c)
      End If
    Next

    Return r
  End Function

  Private Shared Function ParseJSONObject(ByVal json As String) As Dictionary(Of String, String)
    Dim r As New Dictionary(Of String, String),
        l As New List(Of String)

    'Trim any leading or trailing object delimiters found in JSON objects.
    json = json.TrimStart("{"c, "("c, " "c).TrimEnd("}"c, ")"c, " "c)

    'Tokenize the JSON object.
    json = TokenizeJSON(json, l)

    'Parse the JSON object.
    For Each m As Match In reProp.Matches(json)
      Dim name As String = m.Groups(2).Value.TrimStart()
      Dim value As String = m.Groups(3).Value
      If reReplaced.IsMatch(name) Then name = l(Integer.Parse(name.Substring(2, name.Length - 3)))
      If reReplaced.IsMatch(value) Then value = l(Integer.Parse(value.Substring(2, value.Length - 3)))
      name = name.Trim("'"c, """"c)
      r.Add(name, value)
    Next

    'Return the result.
    Return r
  End Function

  Private Shared Function ParseJSONArray(ByVal json As String) As String()
    Dim l As New List(Of String),
        r As New List(Of String)

    'Trim any leading or trailing array delimiters found in JSON objects, but only one on each side.
    json = json.Trim()
    json = json.Substring(1, json.Length - 2)

    'Tokenize the JSON array.
    json = TokenizeJSON(json, l)

    'Parse and return the JSON array.
    For Each y As String In (From x As String In json.Split(","c) Select x.Trim())
      If reReplaced.IsMatch(y) Then
        r.Add(l(Integer.Parse(y.Substring(2, y.Length - 3))))
      Else
        r.Add(y)
      End If
    Next

    Return r.ToArray()
  End Function




  Private ReadOnly _properties As Dictionary(Of String, String)



  Public Sub New(ByVal json As String)
    _properties = JSONObject.ParseJSONObject(json)
  End Sub



  Public Function GetProperty(ByVal name As String) As JSONValue
    If _properties.ContainsKey(name) Then Return Evaluate(_properties(name))
    Return New JSONValue(JSONType.undefined, Nothing)
  End Function

  Public Function GetProperties() As Dictionary(Of String, String)
    Return _properties
  End Function


  Private Function Evaluate(ByVal json As String) As JSONValue
    Dim intValue As Integer,
        floatValue As Double
    json = json.TrimStart("("c).TrimEnd(")"c)

    If json <> String.Empty Then
      If json(0) = "{"c Then
        Return New JSONValue(JSONType.object, New JSONObject(json))
      ElseIf json(0) = "["c Then
        Return New JSONValue(JSONType.array, (From x As String In JSONObject.ParseJSONArray(json) Select Evaluate(x)).ToArray())
      ElseIf json(0) = "'"c OrElse json(0) = """"c Then
        Return New JSONValue(JSONType.string, json.Substring(1, json.Length - 2))
      ElseIf Integer.TryParse(json, intValue) Then
        Return New JSONValue(JSONType.int, intValue)
      ElseIf Double.TryParse(json, floatValue) Then
        Return New JSONValue(JSONType.double, floatValue)
      ElseIf json = "true" Then
        Return New JSONValue(JSONType.bool, True)
      ElseIf json = "false" Then
        Return New JSONValue(JSONType.bool, False)
      ElseIf json = "null" Then
        Return New JSONValue(JSONType.string, "")
      End If
    End If

    Return New JSONValue(JSONType.undefined, Nothing)
  End Function

End Class

Public Class JSONValue
  Private _type As JSONType,
          _value As Object

  Public Sub New(ByVal type As JSONType, ByVal value As Object)
    _type = type
    _value = value
  End Sub

  Public ReadOnly Property Type() As JSONType
    Get
      Return _type
    End Get
  End Property

  Public ReadOnly Property Value() As Object
    Get
      Return _value
    End Get
  End Property
End Class

Public Enum JSONType
  bool
  int
  [double]
  [string]
  [object]
  array
  null
  undefined
End Enum