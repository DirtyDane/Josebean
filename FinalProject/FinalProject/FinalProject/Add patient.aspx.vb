
Partial Class Add_patient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

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
                drpGender.SelectedValue = "Gender"
                txtAddress.Text = ""
                txtCity.Text = ""
                drpState.SelectedValue = "Select State"
                txtZip.Text = ""
            End With
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Response.Redirect("FindPatient.aspx")
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
            Gender = drpGender.Text.Substring(0, 1)
            Address = txtAddress.Text.Trim
            City = txtCity.Text.Trim
            State = drpState.Text.Trim
            Zip = txtZip.Text.Trim

            AddDataTier.AddPatient(Fname, Midinit, Lname, DOB, HmPn, Cell, Gender, Address, City, State, Zip)

            lblTest.Visible = True

        Catch ex As Exception

        End Try
    End Sub
End Class
