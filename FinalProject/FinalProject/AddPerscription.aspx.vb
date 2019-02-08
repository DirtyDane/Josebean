Imports System.Data
Partial Class AddPerscription
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patID As Int32
        Try
            If Request("ID") IsNot Nothing And Request("ID") <> String.Empty Then


                ViewState("PatID") = Request("ID")

                patID = Int32.Parse(ViewState("PatID"))

                Dim aData As New AddDataTier
                Dim ds As New DataSet

                ds = aData.GetPatient(patID)

                lblPatient.Text = ds.Tables(0).Rows(0)("Patient Name").ToString()
            End If
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try




    End Sub
End Class
