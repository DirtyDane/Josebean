﻿Imports System.Data
Partial Class UpdatePatient
    Inherits System.Web.UI.Page
    'Public patIDUpdate As Int32
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim patID As Int32
            ViewState("PatID") = Int32.Parse(Request("ID"))

            patID = ViewState("PatID")

            Dim aPatient As New PatientDataTier
            Dim ds As New Dataset
            Dim ds1 As New DataSet

            ds = aPatient.GetPatient2(patID)

            With Me
                .txtFName.Text = ds.Tables(0).Rows(0)("FNAME").ToString
                .txtMiddle.Text = ds.Tables(0).Rows(0)("MI").ToString
                .txtLName.Text = ds.Tables(0).Rows(0)("LNAME").ToString
                .txtAddress.Text = ds.Tables(0).Rows(0)("PAT_ADDRESS1").ToString
                .txtCity.Text = ds.Tables(0).Rows(0)("PAT_CITY").ToString
                .ddlState.SelectedValue = ds.Tables(0).Rows(0)("PAT_STATE")
                .txtZip.Text = ds.Tables(0).Rows(0)("PAT_ZIP").ToString
                .txtDOB.Text = ds.Tables(0).Rows(0)("DOB").ToString
                .txtHPhone.Text = ds.Tables(0).Rows(0)("HOME_PHONE").ToString
                .txtCPhone.Text = ds.Tables(0).Rows(0)("CELL_PHONE").ToString
                .ddlGender.SelectedValue = ds.Tables(0).Rows(0)("GENDER")
            End With
        End If
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim FName, MidInitial, LName, HomePhone, CellPhone, Gender, Address, City, State, ZIP As String
        Dim DOB As Date
        Dim result As Boolean
        Try
            FName = txtFName.Text.Trim
            MidInitial = txtMiddle.Text.Trim
            LName = txtLName.Text.Trim
            DOB = txtDOB.Text.Trim
            HomePhone = txtHPhone.Text.Trim
            CellPhone = txtCPhone.Text.Trim
            Gender = ddlGender.SelectedValue.ToString
            Address = txtAddress.Text.Trim
            City = txtCity.Text.Trim
            State = ddlState.SelectedValue.ToString
            ZIP = txtZip.Text.Trim

            ' If one of the fields that allow nulls that has a Masked TextBox is empty, insert a blank instead of inserting a blank mask.
            ' A blank mask does not look nice in the DataBase. For example: A blank Home Phone will look like "(  )  -  "
            'If txtHPhone.Text = String.Empty Then
            '    HomePhone = ""
            'End If
            'If txtCPhone.Text = String.Empty Then
            '    CellPhone = ""
            'End If
            'If txtZip.Text = String.Empty Then
            '    ZIP = ""
            'End If
            Try
                Dim aPatient As New PatientDataTier

                result = aPatient.UpdatePatient(ViewState("PatID"), FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP)

                'MessageBox.Show("Patient Info Updated", "Edit Patient Info", MessageBoxButtons.OK, MessageBoxIcon.None)

                'Me.Close()
                If result Then
                    lblResult.Text = "Success"
                Else
                    lblResult.Text = "Failure"
                End If

            Catch ex As Exception
                Throw New ArgumentException(ex.Message, ex.InnerException)
            End Try
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try
    End Sub


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        With Me
            .txtFName.Text = ""
            .txtMiddle.Text = ""
            .txtLName.Text = ""
            .txtDOB.Text = ""
            .txtHPhone.Text = ""
            .txtCPhone.Text = ""
            .ddlGender.SelectedValue = "Select Gender"
            .txtAddress.Text = ""
            .txtCity.Text = ""
            .ddlState.SelectedValue = "Select State"
            .txtZip.Text = ""
        End With
    End Sub

    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Response.Redirect("FindPatient.aspx")
    End Sub
End Class
