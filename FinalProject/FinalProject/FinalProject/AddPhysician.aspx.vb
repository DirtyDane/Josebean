
Partial Class AddPhysician
    Inherits System.Web.UI.Page

    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Response.Redirect("FindPatient.aspx")
    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            With Me
                txtFname.Text = ""
                txtMidinit.Text = ""
                txtLname.Text = ""
                txtDOB.Text = ""
                txtHmPn.Text = ""
                txtCell.Text = ""
                dprGender.SelectedValue = "Gender"
                txtAddress.Text = ""
                txtCity.Text = ""
                drpState.SelectedValue = "Select State"
                txtZip.Text = ""
            End With
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub btnAddPhysician_Click(sender As Object, e As EventArgs) Handles btnAddPhysician.Click

        Try
            Dim AddDataTier As New AddDataTier
            Dim Fname, Midinit, Lname, HmPn, Cell, Gender, Address, City, State, Zip As String
            Dim DOB As Date

            Fname = txtFname.Text.Trim
            Midinit = txtMidinit.Text.Trim
            Lname = txtLname.Text.Trim
            DOB = txtDOB.Text.Trim
            HmPn = txtHmPn.Text.Trim
            Cell = txtCell.Text.Trim
            Gender = dprGender.Text.Substring(0, 1)
            Address = txtAddress.Text.Trim
            City = txtCity.Text.Trim
            State = drpState.Text.Trim
            Zip = txtZip.Text.Trim

            AddDataTier.AddPhysician(Fname, Midinit, Lname, DOB, HmPn, Cell, Gender, Address, City, State, Zip)

            lblSuccess.Visible = True

        Catch ex As Exception

        End Try

        'Try

        '    Dim StudentDataTier As New StudentDataTier
        '    Dim Stu_id As String
        '    Dim fname As String
        '    Dim lname As String
        '    Dim DOB As Date
        '    Dim gender As String
        '    Dim state As String


        '    Stu_id = lblStudIDout.Text.Trim
        '    fname = txtFname.Text.Trim
        '    lname = txtLname.Text.Trim
        '    DOB = Date.Parse(txtDOB.Text.Trim)
        '    gender = ddlGender.SelectedValue.ToString
        '    state = ddlState.SelectedValue.ToString


        '    StudentDataTier.UpdateStudent(Stu_id, fname, lname, DOB, gender, state)

        '    lblHurray.Visible = True

        'Catch ex As Exception

        'End Try
    End Sub
End Class
