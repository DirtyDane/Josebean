Imports System.Data
Partial Class AddPerscription
    Inherits System.Web.UI.Page


    Public Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patID As Int32
        Try
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
                    '.DataBind()
                    '.Items.Insert(0, New ListItem("Please Select", 0))

                End With

                With Me.ddlMedication
                    .DataSource = ds3.Tables(0)
                    .DataTextField = "Medication"
                    .DataValueField = "RX_NO"
                    '.DataBind()
                    '.Items.Insert(0, New ListItem("Please Select", 0))
                End With


                With Me.ddlFrequency
                    .Items.Add("1x Daily")
                    .Items.Add("2x Daily")
                    .Items.Add("Every 4 Hours")
                    .Items.Add("Every 8 Hours")

                End With

                With Me.ddlIntake
                    .Items.Add("Oral")
                    .Items.Add("Suppository")
                    .Items.Add("Injection")
                    .Items.Add("IV")

                End With

                With Me.ddlDosage
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

                If Not IsPostBack Then
                    ddlDosage.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlFrequency.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlIntake.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlMedication.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlPhysician.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlMedication.DataBind()
                    ddlPhysician.DataBind()
                Else
                    ddlMedication.Items.Insert(0, New ListItem("Please Select", 0))
                    ddlPhysician.Items.Insert(0, New ListItem("Please Select", 0))
                End If
            End If
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try




    End Sub

    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        Dim physID, patID As Int32
        Dim rxNo, dosage, intake, freq, refill As String

        Try
            patID = Int32.Parse(ViewState("PatID"))
            physID = Int32.Parse(ddlPhysician.SelectedValue)

            rxNo = ddlMedication.SelectedValue.ToString()
            dosage = ddlDosage.SelectedValue.ToString()
            intake = ddlIntake.SelectedValue.ToString()
            freq = ddlFrequency.SelectedValue.ToString()
            refill = Int32.Parse(txtRefill.Text.Trim)

            Dim aData As New AddDataTier

            aData.AddPrescription(patID, physID, rxNo, dosage, intake, freq, refill)


        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try
    End Sub
End Class
