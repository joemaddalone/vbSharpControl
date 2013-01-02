Imports System.Data.SqlClient
Partial Public Class conn
    Public Class sql
        Public Shared Property connection() As SqlConnection
            Get
                Dim strConnect As String = AP("sqlConnectionString")
                Try
                    If PG.Session("conn") Is Nothing OrElse (Not TypeOf PG.Session("conn") Is SqlConnection) Then
                        PG.Session("conn") = New SqlConnection(strConnect)
                    End If
                Catch ex As Exception
                    Dim cn As SqlConnection = New SqlConnection(strConnect)
                    PG.Session("conn") = cn
                End Try
                Return CType(PG.Session("conn"), SqlConnection)
            End Get
            Set(ByVal value As SqlConnection)
                PG.Session("conn") = value
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