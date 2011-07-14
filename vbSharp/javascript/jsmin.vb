Imports System
Imports System.IO


Public Class JSMin
  Const EOF As Integer = -1

  Public Shared sr As StringReader
  Public Shared sw As TextWriter
  Public Shared theA As Integer
  Public Shared theB As Integer
  Public Shared theLookahead As Integer = EOF

  Public Sub Minify(src As String, dst As String)
    Using sr = New StringReader(src)
      Using sw = New StreamWriter(dst)
        jsmin()
      End Using
    End Using
  End Sub

  Public Function MinifyToString(src As String) As String
    sr = New StringReader(src)
    sw = New StringWriter()
    'try
    '{
    jsmin()
    '}
    'catch { }
    Return sw.ToString()


  End Function


  Public Sub jsmin()
    theA = AscW(ControlChars.Lf)
    action(3)
    While theA <> EOF
      Select Case theA
        Case AscW(" ")
          If True Then
            If isAlphanum(theB) Then
              action(1)
            Else
              action(2)
            End If
            Exit Select
          End If
        Case AscW(ControlChars.Lf)
          If True Then
            Select Case theB
              Case AscW("{"), AscW("["), AscW("("), AscW("+"), AscW("-")
                If True Then
                  action(1)
                  Exit Select
                End If
              Case AscW(" ")
                If True Then
                  action(3)
                  Exit Select
                End If
              Case Else
                If True Then
                  If isAlphanum(theB) Then
                    action(1)
                  Else
                    action(2)
                  End If
                  Exit Select
                End If
            End Select
            Exit Select
          End If
        Case Else
          If True Then
            Select Case theB
              Case AscW(" ")
                If True Then
                  If isAlphanum(theA) Then
                    action(1)
                    Exit Select
                  End If
                  action(3)
                  Exit Select
                End If
              Case AscW(ControlChars.Lf)
                If True Then
                  Select Case theA
                    Case AscW("}"), AscW("]"), AscW(")"), AscW("+"), AscW("-"), AscW(""""), _
                     AscW("'")
                      If True Then
                        action(1)
                        Exit Select
                      End If
                    Case Else
                      If True Then
                        If isAlphanum(theA) Then
                          action(1)
                        Else
                          action(3)
                        End If
                        Exit Select
                      End If
                  End Select
                  Exit Select
                End If
              Case Else
                If True Then
                  action(1)
                  Exit Select
                End If
            End Select
            Exit Select
          End If
      End Select
    End While
  End Sub

  Public Sub action(d As Integer)
    If d <= 1 Then
      put(theA)
    End If
    If d <= 2 Then
      theA = theB
      If theA = AscW("'") OrElse theA = AscW("""") Then
        While True
          put(theA)
          theA = [get]()
          If theA = theB Then
            Exit While
          End If
          If theA <= AscW(ControlChars.Lf) Then
            Throw New Exception(String.Format("Error: JSMIN unterminated string literal: {0}" & vbLf, theA))
          End If
          If theA = AscW("\") Then
            put(theA)
            theA = [get]()
          End If
        End While
      End If
    End If
    If d <= 3 Then
      theB = [next]()
      If theB = AscW("/") AndAlso (theA = AscW("(") OrElse theA = AscW(",") OrElse theA = AscW("=")) Then
        put(theA)
        put(theB)
        While True
          theA = [get]()
          If theA = AscW("/") Then
            Exit While
          ElseIf theA = AscW("\") Then
            put(theA)
            theA = [get]()
          ElseIf theA <= AscW(ControlChars.Lf) Then
            Throw New Exception(String.Format("Error: JSMIN unterminated Regular Expression literal : {0}." & vbLf, theA))
          End If
          put(theA)
        End While
        theB = [next]()
      End If
    End If
  End Sub

  Public Function [next]() As Integer
    Dim c As Integer = [get]()
    If c = AscW("/") Then
      Select Case peek()
        Case AscW("/")
          If True Then
            While True
              c = [get]()
              If c <= AscW(ControlChars.Lf) Then
                Return c
              End If
            End While
          End If
        Case AscW("*")
          If True Then
            [get]()
            While True
              Select Case [get]()
                Case AscW("*")
                  If True Then
                    If peek() = AscW("/") Then
                      [get]()
                      Return AscW(" ")
                    End If
                    Exit Select
                  End If
                Case EOF
                  If True Then
                    Throw New Exception("Error: JSMIN Unterminated comment." & vbLf)
                  End If
              End Select
            End While
          End If
        Case Else
          If True Then
            Return c
          End If
      End Select
    End If
    Return c
  End Function

  Public Function peek() As Integer
    theLookahead = [get]()
    Return theLookahead
  End Function

  Public Function [get]() As Integer
    Dim c As Integer = theLookahead
    theLookahead = EOF
    If c = EOF Then
      c = sr.Read()
    End If
    If c >= AscW(" ") OrElse c = AscW(ControlChars.Lf) OrElse c = EOF Then
      Return c
    End If
    If c = AscW(ControlChars.Cr) Then
      Return AscW(ControlChars.Lf)
    End If
    Return AscW(" ")
  End Function
  Private Sub put(c As Integer)
    sw.Write(ChrW(c))
  End Sub


  Public Function isAlphanum(c As Integer) As Boolean
    Return ((c >= AscW("a") AndAlso c <= AscW("z")) OrElse (c >= AscW("0") AndAlso c <= AscW("9")) OrElse (c >= AscW("A") AndAlso c <= AscW("Z")) OrElse c = AscW("_") OrElse c = AscW("$") OrElse c = AscW("\") OrElse c > 126)
  End Function
End Class
