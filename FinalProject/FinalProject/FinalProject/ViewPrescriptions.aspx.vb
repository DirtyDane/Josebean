Imports System.Data
Partial Class ViewPrescriptions
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.PreRender
        ViewState("PatID") = Request("ID")

        'lblTest.Text = ViewState("PatID").ToString

        LoadData()




    End Sub

    Private Sub LoadData()
        Dim aPatient As New PatientDataTier
        Dim ds As New DataSet

        Try
            ds = aPatient.GetPrescription(CType(ViewState("PatID"), Int32))

            gdvPrescriptions.DataSource = ds.Tables(0)
            gdvPrescriptions.DataBind()

            lblNameOutput.Text = ds.Tables(0).Rows(0)("Patient Name")

            If Cache("Prescriptiondata") Is Nothing Then
                Cache.Add("Prescriptiondata", New DataView(ds.Tables(0)), Nothing, Caching.Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(10), Caching.CacheItemPriority.Default, Nothing)
            End If
        Catch ex As Exception
            Response.Redirect("ErrorPage.html")

        End Try

    End Sub

    Private Sub gdvPatients_Sorting(sender As Object, e As GridViewSortEventArgs) Handles gdvPrescriptions.Sorting
        SortRecords(e.SortExpression)
    End Sub

    Private Sub SortRecords(ByVal sortExpress As String)
        Dim oldExpression As String = gdvPrescriptions.SortExpression
        Dim newExpression As String = sortExpress
        Dim lastValue, theSortField As String
        Dim sortExpression As String
        Dim Source As DataView
        Dim theDirection As String
        Dim wildChar As String

        theDirection = " "
        wildChar = "%"

        Try
            lastValue = CType(ViewState("sortValue"), String)
            sortExpression = sortExpress
            theSortField = CType(ViewState("sortField"), String)

            With Me
                If .sortDir = "desc" Then
                    .sortDir = "asc"
                Else
                    .sortDir = "desc"
                End If

                Source = Cache("Patientdata")
                Source.Sort = (" " + sortExpression + " " + .sortDir)

                gdvPrescriptions.DataSource = Source
                gdvPrescriptions.DataBind()
            End With

        Catch ex As Exception
            Response.Redirect("ErrorPage.html")
        End Try

    End Sub

    Public Property sortDir() As String
        Get
            Return CStr(ViewState("sortDir"))
        End Get
        Set(value As String)
            ViewState("sortDir") = value
        End Set
    End Property

    'GridButtons

    Protected Sub ibtnRefill_Click(ByVal sender As Object, ByVal e As CommandEventArgs)
        Dim presNO As Int32
        Dim refill As Boolean
        Try
            presNO = Int32.Parse(Trim(e.CommandArgument))


            Dim aData As New PatientDataTier

            refill = aData.CheckRefill(presNO)

            If refill Then
                aData.FillPrescription(presNO)
                lblError.Text = ""
            Else
                lblError.Text = "There are no remaining refills for this prescription"
            End If


        Catch ex As Exception
            Response.Redirect("ErrorPage.html")
        End Try

    End Sub


    Protected Sub ibtnEdit_Click(ByVal sender As Object, ByVal e As CommandEventArgs)
        Dim recordToBeEdited As String

        recordToBeEdited = Trim(e.CommandArgument)



        Response.Redirect("UpdatePrescription.aspx?ID=" + recordToBeEdited.ToString, True)
    End Sub
End Class
