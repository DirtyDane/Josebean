Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Web
Imports System.Collections
Imports System.Collections.Generic
Public Class AddDataTier
    Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
    Dim cmdString As New SqlClient.SqlCommand
    Public Function AddPhysician(ByVal Fname As String, ByVal Midinit As String, ByVal Lname As String, ByVal DOB As String, ByVal HmPn As String, ByVal Cell As String, ByVal Gender As String, ByVal Address As String, ByVal City As String, ByVal State As String, ByVal Zip As String) As DataSet
        Try
            'i JUST REMOVED and added back in a line to see what happens and if this fixes everything now
            'open connection
            connString.Open()
            'command
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "ADD_PHYSICIAN"
                'define input parameter
                .Parameters.Add("@FNAME", SqlDbType.VarChar, 25).Value = Fname
                .Parameters.Add("@MI", SqlDbType.VarChar, 25).Value = Midinit
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = Lname
                .Parameters.Add("@Gender", SqlDbType.Char, 1).Value = Gender
                .Parameters.Add("@DOB", SqlDbType.Date).Value = DOB
                .Parameters.Add("@HOME_PHONE", SqlDbType.VarChar, 14).Value = HmPn
                .Parameters.Add("@CELL_PHONE", SqlDbType.VarChar, 14).Value = Cell
                .Parameters.Add("@PHY_ADDR", SqlDbType.VarChar, 60).Value = Address
                .Parameters.Add("@PHY_CITY", SqlDbType.VarChar, 30).Value = City
                .Parameters.Add("@PHY_STATE", SqlDbType.Char, 2).Value = State
                .Parameters.Add("@PHY_ZIP", SqlDbType.VarChar, 10).Value = Zip



                'executec command
                .ExecuteNonQuery()
            End With


        Catch ex As Exception

            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function

    Public Function AddPatient(ByVal Fname As String, ByVal Midinit As String, ByVal Lname As String, ByVal DOB As String, ByVal HmPn As String, ByVal Cell As String, ByVal Gender As String, ByVal Address As String, ByVal City As String, ByVal State As String, ByVal Zip As String) As DataSet
        Try

            connString.Open()

            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 900
                .CommandText = "ADD_PATIENT2"
                'input parameters
                .Parameters.Add("@FNAME", SqlDbType.VarChar, 25).Value = Fname
                .Parameters.Add("@MI", SqlDbType.VarChar, 25).Value = Midinit
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = Lname
                .Parameters.Add("@Gender", SqlDbType.Char, 1).Value = Gender
                .Parameters.Add("@DOB", SqlDbType.Date).Value = DOB
                .Parameters.Add("@HOME_PHONE", SqlDbType.VarChar, 14).Value = HmPn
                .Parameters.Add("@CELL_PHONE", SqlDbType.VarChar, 14).Value = Cell
                .Parameters.Add("@PAT_ADDRESS", SqlDbType.VarChar, 60).Value = Address
                .Parameters.Add("@PAT_CITY", SqlDbType.VarChar, 30).Value = City
                .Parameters.Add("@PAT_STATE", SqlDbType.Char, 2).Value = State
                .Parameters.Add("@PAT_ZIP", SqlDbType.VarChar, 10).Value = Zip

                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        Finally
            connString.Close()
        End Try
    End Function

    Public Function GetPatient(ByVal patID As Int32) As DataSet
        Try
            connString.Open()
            With cmdString
                .Parameters.Clear()

                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "GetPatientName"
                .Parameters.Add("@PATIENT_ID", SqlDbType.Int).Value = patID

            End With


            Dim aAdapter As New SqlClient.SqlDataAdapter
            aAdapter.SelectCommand = cmdString
            Dim aDataset As New DataSet
            aAdapter.Fill(aDataset)

            Return aDataset
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        Finally
            connString.Close()
        End Try
    End Function

    Public Function GetDocBox() As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "GetDocBox"
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function

    Public Function GetMedBox() As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "GetMed"
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        Finally
            connString.Close()
        End Try
    End Function
End Class


