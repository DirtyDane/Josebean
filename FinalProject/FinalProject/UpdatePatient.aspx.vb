﻿
Partial Class UpdatePatient
    Inherits System.Web.UI.Page
    Public patIDUpdate As Int32
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patID As Int32

        patID = patIDUpdate

        'Dim aPatient As New PatientDataTier
        'Dim ds As New DataSet
        'Dim ds1 As New DataSet

        'ds = aPatient.GetPatient2(patID)

        'With Me
        '    .txtPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
        '    .txtPatientID.Enabled = False
        '    .txtFName.Text = ds.Tables(0).Rows(0)("FNAME").ToString
        '    .txtMiddle.Text = ds.Tables(0).Rows(0)("MI").ToString
        '    .txtLName.Text = ds.Tables(0).Rows(0)("LNAME").ToString
        '    .txtAddress.Text = ds.Tables(0).Rows(0)("PAT_ADDRESS1").ToString
        '    .txtCity.Text = ds.Tables(0).Rows(0)("PAT_CITY").ToString
        '    .ddlState.Text = ds.Tables(0).Rows(0)("PAT_STATE").ToString
        '    .txtZip.Text = ds.Tables(0).Rows(0)("PAT_ZIP").ToString
        '    .txtDOB.Text = ds.Tables(0).Rows(0)("DOB").ToString
        '    .txtHPhone.Text = ds.Tables(0).Rows(0)("HOME_PHONE").ToString
        '    .txtCPhone.Text = ds.Tables(0).Rows(0)("CELL_PHONE").ToString
        '    .ddlGender.Text = ds.Tables(0).Rows(0)("GENDER").ToString
        'End With
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim PatientID, FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP As String

        'Try
        '    PatientID = txtPatientID.Text.Trim
        '    FName = txtFName.Text.Trim
        '    MidInitial = txtMiddle.Text.Trim
        '    LName = txtLName.Text.Trim
        '    DOB = txtDOB.Text.Trim
        '    HomePhone = txtHPhone.Text.Trim
        '    CellPhone = txtCPhone.Text.Trim
        '    Gender = ddlGender.Text.Trim
        '    Address = txtAddress.Text.Trim
        '    City = txtCity.Text.Trim
        '    State = ddlState.Text.Trim
        '    ZIP = txtZip.Text.Trim

        '    ' If one of the fields that allow nulls that has a Masked TextBox is empty, insert a blank instead of inserting a blank mask.
        '    ' A blank mask does not look nice in the DataBase. For example: A blank Home Phone will look like "(  )  -  "
        '    If txtHPhone.Text = False Then
        '        HomePhone = ""
        '    End If
        '    If txtCPhone.Text = False Then
        '        CellPhone = ""
        '    End If
        '    If txtZip.Text = False Then
        '        ZIP = ""
        '    End If
        '    Try
        '        '        Dim aPatient As New PatientDataTier

        '        '        aPatient.UpdatePatient(PatientID, FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP)

        '        '        MessageBox.Show("Patient Info Updated", "Edit Patient Info", MessageBoxButtons.OK, MessageBoxIcon.None)

        '        '        Me.Close()

        '        '    Catch ex As Exception
        '        '        MessageBox.Show(ex.Message)
        '        '    End Try
        '        'Catch ex As Exception
        '        '    MessageBox.Show(ex.Message)
        '    End Try
    End Sub


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'For Each ctrl As Control In Panel1.Controls
        '    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
        '        ctrl.Text = ""
        '    End If
        'Next
    End Sub

    Private Sub ClearMe()
        With Me
            '.txtPatientID.Clear()
            '.txtFName.Clear()
            '.txtMiddle.Clear()
            '.txtLName.Clear()
            '.txtDOB.Clear()
            '.txtHPhone.Clear()
            '.txtCPhone.Clear()
            '.ddlGender.Clear()
            '.txtAddress.Clear()
            '.txtCity.Clear()
            '.ddlState.Clear()
            '.txtZip.Clear()
        End With
    End Sub

    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class