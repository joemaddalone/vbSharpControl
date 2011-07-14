Imports System.Data.OleDb
Partial Public Class conn
  Public Class oledb
    Public Shared connection As OleDbConnection
    Public strConnect As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strConnect"></param>
    ''' <remarks></remarks>
    Sub New(ByVal strConnect As String)
      If connection Is Nothing Then
        connection = New OleDbConnection(strConnect)
      End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenDB()
      If connection.State = ConnectionState.Closed Then
        connection.Open()
      End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseDB()
      If Not connection Is Nothing Then
        If connection.State = ConnectionState.Open Then
          connection.Close()
        End If
        connection = Nothing
      End If
    End Sub
  End Class
End Class