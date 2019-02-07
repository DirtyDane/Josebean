Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Web
Imports System.Collections
Imports System.Collections.Generic
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.PreRender
        If Session("PatID") IsNot Nothing Then
            lblTest.Text = CType(Session("Role"), String)
            pnlSignIn.Visible = False
        End If
    End Sub

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Dim aData As New BusinessDataTier
        Dim patID As DataSet
        Dim userLoggedIn As Boolean
        Try
            userLoggedIn = ValidateUser(Login1.UserName.Trim, Login1.Password)



            If userLoggedIn Then
                patID = aData.Logon(Login1.UserName.Trim, Login1.Password)
                Session("PatID") = patID.Tables(0).Rows(0)("PATIENT_ID")
                Session("Role") = patID.Tables(0).Rows(0)("AUTH_ROLE")
                e.Authenticated = True

            Else
                e.Authenticated = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Function ValidateUser(ByVal uName As String, ByVal pwd As String) As Boolean
        Dim patID As New DataSet
        Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
        Dim cmdString As New SqlClient.SqlCommand
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "LOGON2"
                .Parameters.Add("@LOGIN_NAME", SqlDbType.VarChar, 25).Value = uName
                .Parameters.Add("@AUTH_PASS", SqlDbType.VarChar, 20).Value = pwd
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            aAdapter.Fill(patID)

            If patID IsNot Nothing Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function


    Protected Sub Login1_LoginError(sender As Object, e As EventArgs) Handles Login1.LoginError

    End Sub
End Class

