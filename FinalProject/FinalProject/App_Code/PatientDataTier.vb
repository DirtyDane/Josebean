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
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function
End Class
