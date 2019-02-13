Imports System.Data
Partial Class AddPerscription
    Inherits System.Web.UI.Page


    Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patID As Int32
        Try
            If Not IsPostBack Then


                If Request("ID") IsNot Nothing And Request("ID") <> String.Empty Then


                    ViewState("PatID") = Request("ID")

                    patID = Int32.Parse(ViewState("PatID"))

                    Dim aData As New AddDataTier
                    Dim ds As New DataSet
                    Dim ds2 As New DataSet
                    Dim ds3 As New DataSet

                    ds = aData.GetPatient(patID)
                    ds2 = aData.GetDocBox()
                    ds3 = aData.GetMedBox()

                    lblPatient.Text = ds.Tables(0).Rows(0)("Patient Name").ToString()
                    With Me.ddlPhysician
                        .DataSource = ds2.Tables(0)
                        .DataTextField = "Physician_Name"
                        .DataValueField = "PHYS_ID"
                        .DataBind()
                    End With

                    With Me.ddlMedication
                        .DataSource = ds3.Tables(0)
                        .DataTextField = "MED_NAME"
                        .DataValueField = "RX_NO"
                        .DataBind()
                    End With


                    With Me.ddlFrequency
                        .Items.Clear()
                        .Items.Add("1x Daily")
                        .Items.Add("2x Daily")
                        .Items.Add("Every 4 Hours")
                        .Items.Add("Every 8 Hours")
                    End With

                    With Me.ddlIntake
                        .Items.Clear()
                        .Items.Add("Oral")
                        .Items.Add("Suppository")
                        .Items.Add("Injection")
                        .Items.Add("IV")
                    End With

                    With Me.ddlDosage
                        .Items.Clear()
                        .Items.Add("10mg")
                        .Items.Add("20mg")
                        .Items.Add("25mg")
                        .Items.Add("50mg")
                        .Items.Add("80mg")
                        .Items.Add("100mg")
                        .Items.Add("150mg")
                        .Items.Add("200mg")
                        .Items.Add("300mg")
                        .Items.Add("500mg")
                        .Items.Add("1000mg")
                    End With
                End If
            End If
        Catch ex As Exception
            Response.Redirect("ErrorPage.html")

        End Try




    End Sub
    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Response.Redirect("FindPatient.aspx")
    End Sub


    Protected Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        Dim patID, physID, refill As Int32
        Dim rx, dosage, freq, intake As String
        Dim result As Boolean
        Try
            patID = Int32.Parse(ViewState("PatID"))
            physID = Int32.Parse(ddlPhysician.SelectedValue)
            rx = ddlMedication.SelectedValue.ToString()
            dosage = ddlDosage.SelectedValue.ToString()
            intake = ddlIntake.SelectedValue.ToString()
            freq = ddlFrequency.SelectedValue.ToString()
            refill = Int32.Parse(txtRefill.Text.Trim)

            Dim aData As New AddDataTier

            result = aData.AddPrescription(patID, physID, rx, dosage, intake, freq, refill)

            If result Then
                lblResult.Text = "Prescription Added!"

            Else
                lblResult.Text = "There was an issue adding this prescription"

            End If

        Catch ex As Exception
            lblResult.text = "Error"
        End Try


    End Sub
End Class
