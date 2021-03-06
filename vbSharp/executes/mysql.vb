﻿Option Strict On
Imports System.Data.Odbc
Partial Public Class executes
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="strSQL"></param>
    ''' <param name="ExecuteScalar"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function mysql(
                       ByVal strSQL As String,
                       Optional ByVal ExecuteScalar As Boolean = False
                        ) As Object
        Using cmd As OdbcCommand = conn.mysql.connection.CreateCommand
            cmd.CommandText = strSQL
            Return If(ExecuteScalar, cmd.ExecuteScalar, cmd.ExecuteNonQuery)
        End Using

    End Function


End Class
