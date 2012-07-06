Imports System.Text

Public Class StringWalker
  Private _s As String
  Public Property Index() As Integer
    Get
      Return m_Index
    End Get
    Set(value As Integer)
      m_Index = value
    End Set
  End Property
  Private m_Index As Integer

  Public Sub New(s As String)
    _s = s
    Index = -1
  End Sub

  Public Function MoveNext() As Boolean
    If Index = _s.Length - 1 Then
      Return False
    End If
    Index += 1
    Return True
  End Function

  Public Function CharAtIndex() As Char
    Return _s(Index)
  End Function
End Class

Public Class IndentWriter
  Private _sb As New StringBuilder()
  Private _indent As Integer

  Public Sub Indent()
    _indent += 1
  End Sub

  Public Sub UnIndent()
    If _indent > 0 Then
      _indent -= 1
    End If
  End Sub

  Public Sub WriteLine(line As String)
    _sb.AppendLine(CreateIndent() & line)
  End Sub

  Private Function CreateIndent() As String
    Dim indentString As New StringBuilder()
    For i As Integer = 0 To _indent - 1
      indentString.Append("    ")
    Next
    Return indentString.ToString()
  End Function

  Public Overrides Function ToString() As String
    Return _sb.ToString()
  End Function
End Class
Public Class JsonFormatter
  Private _walker As StringWalker
  Private _writer As New IndentWriter()
  Private _currentLine As New StringBuilder()
  Private _quoted As Boolean

  Public Sub New(json As String)
    _walker = New StringWalker(json)
    ResetLine()
  End Sub

  Public Sub ResetLine()
    _currentLine.Length = 0
  End Sub

  Public Function Format() As String
    While MoveNextChar()
      If Me._quoted = False AndAlso Me.IsOpenBracket() Then
        Me.WriteCurrentLine()
        Me.AddCharToLine()
        Me.WriteCurrentLine()
        _writer.Indent()
      ElseIf Me._quoted = False AndAlso Me.IsCloseBracket() Then
        Me.WriteCurrentLine()
        _writer.UnIndent()
        Me.AddCharToLine()
      ElseIf Me._quoted = False AndAlso Me.IsColon() Then
        Me.AddCharToLine()
        Me.WriteCurrentLine()
      Else
        AddCharToLine()
      End If
    End While
    Me.WriteCurrentLine()
    Return _writer.ToString()
  End Function

  Private Function MoveNextChar() As Boolean
    Dim success As Boolean = _walker.MoveNext()
    If Me.IsApostrophe() Then
      Me._quoted = Not _quoted
    End If
    Return success
  End Function

  Public Function IsApostrophe() As Boolean
    Return Me._walker.CharAtIndex() = """"c
  End Function

  Public Function IsOpenBracket() As Boolean
    Return Me._walker.CharAtIndex() = "{"c OrElse Me._walker.CharAtIndex() = "["c
  End Function

  Public Function IsCloseBracket() As Boolean
    Return Me._walker.CharAtIndex() = "}"c OrElse Me._walker.CharAtIndex() = "]"c
  End Function

  Public Function IsColon() As Boolean
    Return Me._walker.CharAtIndex() = ","c
  End Function

  Private Sub AddCharToLine()
    Me._currentLine.Append(_walker.CharAtIndex())
  End Sub

  Private Sub WriteCurrentLine()
    Dim line As String = Me._currentLine.ToString().Trim()
    If line.Length > 0 Then
      _writer.WriteLine(line)
    End If
    Me.ResetLine()
  End Sub
End Class
