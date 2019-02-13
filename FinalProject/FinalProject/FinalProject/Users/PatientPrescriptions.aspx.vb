Imports System.Data
Partial Class Users_PatientPrescriptions
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.PreRender


        LoadData()
    End Sub

    Private Sub LoadData()
        Dim aPatient As New PatientDataTier
        Dim ds As New DataSet


        ds = aPatient.GetPrescription(CType(Session("PatID"), Int32))

        gdvPrescriptions.DataSource = ds.Tables(0)
        gdvPrescriptions.DataBind()

        lblNameOutput.Text = ds.Tables(0).Rows(0)("Patient Name")

        If Cache("Prescriptiondata") Is Nothing Then
            Cache.Add("Prescriptiondata", New DataView(ds.Tables(0)), Nothing, Caching.Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(10), Caching.CacheItemPriority.Default, Nothing)
        End If
    End Sub

End Class
