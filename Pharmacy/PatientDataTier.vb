Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Web
Imports System.Configuration
Imports System.Collections
Imports System.Collections.Generic



'testo

Public Class PatientDataTier
    Dim connString As New SqlClient.SqlConnection("server=CNSA-SOPH20;initial catalog=XYZ;connect timeout=30;integrated security=SSPI")

    Dim cmdString As New SqlClient.SqlCommand

    Public Function GetPatient(ByVal lname As String) As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePatient"
                .Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = lname
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet, "PATIENT")

            Return aDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try

    End Function

    Public Function GetPatient2(ByVal patientID As Int32) As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePatient2"
                .Parameters.Add("@PATIENT_ID", SqlDbType.Int).Value = patientID
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet) ', "PATIENT")

            Return aDataSet

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try

    End Function

    Public Function GetPrescription(ByVal patientID As Int32) As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePrescription"
                .Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 25).Value = patientID
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try

    End Function

    Public Function GetPrescription2(ByVal prescriptionNO As Int32) As DataSet
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "RetrievePrescription2"
                .Parameters.Add("@PRESCRIPTION_NO", SqlDbType.Int).Value = prescriptionNO
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try

    End Function



    Public Function GetDocBox()
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "GetDocBox"
                '.Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = lname
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function

    Public Function GetMedBox()
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "GetMed"
                '.Parameters.Add("@LNAME", SqlDbType.VarChar, 25).Value = lname
            End With
            'command


            Dim aAdapter As New SqlClient.SqlDataAdapter

            aAdapter.SelectCommand = cmdString

            Dim aDataSet As New DataSet


            aAdapter.Fill(aDataSet)

            Return aDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Function

    Public Sub AddPrescription(ByVal patientID As Int32, ByVal physID As Int32, ByVal rxNo As String, ByVal dosage As String, ByVal intakeMethod As String, ByVal frequency As String, ByVal refill As Int32)
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "AddPrescription"
                .Parameters.Add("@PATIENT_ID", SqlDbType.Int).Value = patientID
                .Parameters.Add("@PHYS_ID", SqlDbType.Int).Value = physID
                .Parameters.Add("@RX_NO", SqlDbType.VarChar, 10).Value = rxNo
                .Parameters.Add("@DOSAGE", SqlDbType.VarChar, 6).Value = dosage
                .Parameters.Add("@INTAKE_METHOD", SqlDbType.VarChar, 11).Value = intakeMethod
                .Parameters.Add("@FREQUENCY", SqlDbType.VarChar, 25).Value = frequency
                .Parameters.Add("@REFILL", SqlDbType.Int).Value = refill


                'command


                Dim aAdapter As New SqlClient.SqlDataAdapter

                aAdapter.InsertCommand = cmdString

                'Dim aDataSet As New DataSet
                .ExecuteNonQuery()

                'aAdapter.Fill(aDataSet)

                'Return aDataSet
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Sub

    Public Sub ClearTextBox(ByVal parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty

        End If

        'Dim a As Control
        'For Each a In parent.Controls
        '    If TypeOf a Is TextBox Then
        '        a.Text = String.Empty
        '    End If
        'Next
    End Sub

    Public Sub UpdatePrescription(ByVal presNo As Int32, ByVal physid As Int32, ByVal rxno As String, ByVal dosage As String, ByVal intake As String, ByVal frequency As String, ByVal refill As Int32)
        Try
            'open connection
            connString.Open()
            With cmdString
                .Parameters.Clear()
                .Connection = connString
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1500
                .CommandText = "UpdatePrescription"
                .Parameters.Add("@PRES_NO", SqlDbType.Int).Value = presNo
                .Parameters.Add("@PHYS_ID", SqlDbType.Int).Value = physid
                .Parameters.Add("@RX_NO", SqlDbType.VarChar, 10).Value = rxno
                .Parameters.Add("@DOSAGE", SqlDbType.VarChar, 6).Value = dosage
                .Parameters.Add("@INTAKE_METHOD", SqlDbType.VarChar, 11).Value = intake
                .Parameters.Add("@FREQUENCY", SqlDbType.VarChar, 25).Value = frequency
                .Parameters.Add("@REFILL", SqlDbType.Int).Value = refill


                'command


                Dim aAdapter As New SqlClient.SqlDataAdapter

                aAdapter.UpdateCommand = cmdString

                'Dim aDataSet As New DataSet

                .ExecuteNonQuery()


                'Return aDataSet
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
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

                'Dim aDataSet As New DataSet

                .ExecuteNonQuery()


                'Return aDataSet
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Sub

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

                'Dim aDataSet As New DataSet

                .ExecuteNonQuery()


                'Return aDataSet
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Throw New ArgumentException(ex.Message)
            Exit Try
        Finally
            connString.Close()
        End Try
    End Sub

End Class
