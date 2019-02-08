Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Web
Imports System.Collections
Imports System.Collections.Generic

Public Class PatientDataTier
    Dim connString As New SqlClient.SqlConnection(ConnectionStrings("connString").ConnectionString)
    Dim cmdString As New SqlClient.SqlCommand

    Public Function GetPatient(ByVal lname As String) As DataSet
        Try
            connString.Open()
            With cmdString
                .Parameters.Clear()

                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePatient"
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = lname

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

    Public Function GetPrescription(ByVal PatID As Int32) As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePrescription"
                .Parameters.Add("@PATIENT_ID", SqlDbType.Int).Value = PatID
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

    Public Sub FillPrescription(ByVal presno As Int32, ByVal refill As Int32)
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "FillPrescription"
                .Parameters.Add("@PRESNO", SqlDbType.Int).Value = presno
                .Parameters.Add("@REFILL", SqlDbType.Int).Value = refill
                'command


                Dim aAdapter As New SqlClient.SqlDataAdapter

                aAdapter.UpdateCommand = cmdString

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)

        Finally
            connString.Close()
        End Try
    End Sub

    Public Sub UpdatePatient(ByVal patientid As Int32, ByVal fname As String, ByVal mi As String, ByVal lname As String, ByVal dob As String, ByVal homephone As String, ByVal cellphone As String,
                            ByVal gender As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zip As String)
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "UpdatePatient"
                .Parameters.Add("@PATIENT_ID", SqlDbType.Int).Value = patientid
                .Parameters.Add("@FNAME", SqlDbType.VarChar, 25).Value = fname
                .Parameters.Add("@MI", SqlDbType.Char, 1).Value = mi
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = lname
                .Parameters.Add("@DOB", SqlDbType.Date).Value = dob
                .Parameters.Add("@HOME_PHONE", SqlDbType.VarChar, 14).Value = homephone
                .Parameters.Add("@CELL_PHONE", SqlDbType.VarChar, 14).Value = cellphone
                .Parameters.Add("@GENDER", SqlDbType.Char, 1).Value = gender
                .Parameters.Add("@PAT_ADDRESS1", SqlDbType.VarChar, 60).Value = address
                .Parameters.Add("@PAT_CITY", SqlDbType.VarChar, 30).Value = city
                .Parameters.Add("@PAT_STATE", SqlDbType.Char, 2).Value = state
                .Parameters.Add("@PAT_ZIP", SqlDbType.VarChar, 9).Value = zip
                'command

                Dim aAdapter As New SqlClient.SqlDataAdapter

                aAdapter.UpdateCommand = cmdString

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)

        Finally
            connString.Close()
        End Try
    End Sub
End Class
