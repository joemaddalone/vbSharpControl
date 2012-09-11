Imports System.Collections
Imports System.Collections.Generic
Imports System.Reflection

Namespace Utility

  ''' <summary>
  ''' Sort order enumeration
  ''' </summary>
  Public Enum SortOrder
    Ascending
    Descending
  End Enum

  ''' <summary>
  '''
  ''' </summary>
  Public Class Sorter(Of T)
    Implements IComparer(Of T)

    Private _Sort As String

    Public Sub New()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub New(ByVal SortString As String)
      _Sort = SortString
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Property SortString() As String
      Get
        If _Sort IsNot Nothing Then
          Return _Sort.Trim()
        End If

        Return Nothing
      End Get
      Set(ByVal value As String)
        _Sort = value
      End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    Public Function Compare(ByVal x As T, ByVal y As T) As Integer Implements IComparer(Of T).Compare
      If Not String.IsNullOrEmpty(Me.SortString) Then
        Const ERR As String = "The property ""{0}"" does not exist in type ""{1}"""
        Dim Type As Type = GetType(T)
        Dim Comp As Comparer = Comparer.DefaultInvariant
        Dim Info As PropertyInfo

        For Each Expr As String In Me.SortString.Split(","c)
          Dim Dir As SortOrder = SortOrder.Ascending
          Dim Field As String

          Expr = Expr.Trim()

          If Expr.EndsWith(" DESC") Then
            Field = Expr.Replace(" DESC", String.Empty).Trim()
            Dir = SortOrder.Descending
          Else
            Field = Expr.Replace(" ASC", String.Empty).Trim()
          End If

          Info = Type.GetProperty(Field)

          If Info Is Nothing Then
            Throw New MissingFieldException(String.Format(ERR, Field, Type.ToString()))
          Else
            Dim Result As Integer = Comp.Compare(Info.GetValue(x, Nothing), Info.GetValue(y, Nothing))

            If Result <> 0 Then
              If Dir = SortOrder.Descending Then
                Return Result * -1
              Else
                Return Result
              End If
            End If
          End If
        Next
      End If

      Return 0
    End Function
  End Class
End Namespace