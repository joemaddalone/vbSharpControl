Imports System.Data.Odbc
Imports System.Data

Partial Public Class conn
    Public Class mysql
        Public Shared Property connection() As OdbcConnection
            Get
                Dim strConnect As String = AP("mysqlConnectionString")
                Try
                    If PG.Session("oconn") Is Nothing OrElse (Not TypeOf PG.Session("oconn") Is OdbcConnection) Then
                        PG.Session("oconn") = New OdbcConnection(strConnect)
                    End If
                Catch ex As Exception
                    Dim ocn As OdbcConnection = New OdbcConnection(strConnect)
                    PG.Session("oconn") = ocn
                End Try
                Return CType(PG.Session("oconn"), OdbcConnection)
            End Get
            Set(ByVal value As OdbcConnection)
                PG.Session("oconn") = value
            End Set
        End Property
        Public Sub OpenDB()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        End Sub

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