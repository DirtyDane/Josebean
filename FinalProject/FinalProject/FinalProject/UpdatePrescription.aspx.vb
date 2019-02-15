Imports System.Data
Partial Class UpdatePrescription
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim aData As New PatientDataTier
            Dim bData As New AddDataTier
            Dim ds As New DataSet
            Dim ds2 As New DataSet
            Dim ds3 As New DataSet
            ViewState("Pres_No") = Int32.Parse(Request("ID"))

            ds = aData.GetPrescription2(ViewState("Pres_No"))
            ds2 = bData.GetDocBox()
            ds3 = bData.GetMedBox()

            ViewState("PatID") = Int32.Parse(ds.Tables(0).Rows(0)("Patient ID"))

            lblPatientName.Text = ds.Tables(0).Rows(0)("Patient Name").ToString()
            With Me.ddlPhysician
                .DataSource = ds2.Tables(0)
                .DataTextField = "Physician_Name"
                .DataValueField = "PHYS_ID"
                .DataBind()
                .SelectedValue = ds.Tables(0).Rows(0)("Physician ID")
            End With

            With Me.ddlMedication
                .DataSource = ds3.Tables(0)
                .DataTextField = "MED_NAME"
                .DataValueField = "RX_NO"
                .DataBind()
                .SelectedValue = ds.Tables(0).Rows(0)("RX_NO")
            End With

            ddlDosage.SelectedValue = ds.Tables(0).Rows(0)("Dosage")
            ddlFrequency.SelectedValue = ds.Tables(0).Rows(0)("Frequency")
            ddlIntakeMethod.SelectedValue = ds.Tables(0).Rows(0)("Intake Method")
            txtRefills.Text = ds.Tables(0).Rows(0)("Refills")
        End If
    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("FindPatient.aspx")
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim PrescriptNO, PatientName, PhysName, Refills, Medication, Dosage, Intake, Freq As String
        Dim aData As New AddDataTier
        Dim result As Boolean
        Try
            PrescriptNO = ViewState("Pres_No")
            PatientName = ViewState("PatID")
            PhysName = Int32.Parse(ddlPhysician.SelectedValue)
            Medication = ddlMedication.SelectedValue.ToString()
            Refills = Int32.Parse(txtRefills.Text.Trim)
            Dosage = ddlDosage.SelectedValue.ToString()
            Intake = ddlIntakeMethod.SelectedValue.ToString()
            Freq = ddlFrequency.SelectedValue.ToString()

            result = aData.UpdatePrescription(PrescriptNO, PhysName, Medication, Dosage, Intake, Freq, Refills)

            If result Then
                lblResult.Text = "Record Updated!"
            Else
                lblResult.Text = "Unable to Update Record!"
            End If
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try
    End Sub
End Class
