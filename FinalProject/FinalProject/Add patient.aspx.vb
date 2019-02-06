
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
                txtState.Text = ""
                txtZip.Text = ""
            End With
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Response.Redirect("FindPatient.aspx")
    End Sub
End Class
