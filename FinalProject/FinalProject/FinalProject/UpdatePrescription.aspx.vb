Imports System.Data
Partial Class UpdatePrescription
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Response.Redirect(".aspx")
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim PrescriptNO, PatientName, PhysName, Refills, Medication, Dosage, Intake, Freq As String

        Try
            PrescriptNO = txtPrescriptNo.Text.Trim
            PatientName = txtPatient.Text.Trim
            PhysName = txtPhysician.Text.Trim
            Medication = ddlMedication.Text.Trim
            Refills = txtRefills.Text.Trim
            Dosage = ddlDosage.Text.Trim
            Intake = ddlIntakeMethod.Text.Trim
            Freq = ddlFrequency.Text.Trim
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try
    End Sub
End Class
