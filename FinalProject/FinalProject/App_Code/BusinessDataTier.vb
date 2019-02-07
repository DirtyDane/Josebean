Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Web
Imports System.Collections
Imports System.Collections.Generic
Public Class BusinessDataTier
    Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
    Dim cmdString As New SqlClient.SqlCommand

    Public Function Logon(ByVal uname As String, ByVal pwd As String) As DataSet
        Dim patID As New DataSet

        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "LOGON2"
                .Parameters.Add("@LOGIN_NAME", SqlDbType.VarChar, 25).Value = uname
                .Parameters.Add("@AUTH_PASS", SqlDbType.VarChar, 20).Value = pwd
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            aAdapter.Fill(patID)

            Return patID

        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function
End Class
