
Partial Class AddPhysician
    Inherits System.Web.UI.Page

    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        With Me


        End With
    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            With Me
                txtAddress.Text = ""
                txtCell.Text = ""
                txtCity.Text = ""
                txtDOB.Text = ""
                txtFname.Text = ""
                txtHmPn.Text = ""
                txtMidinit.Text = ""
                txtState.Text = ""
                txtLname.Text = ""
                txtZip.Text = ""
                dprGender.Text = "Gender"




            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
