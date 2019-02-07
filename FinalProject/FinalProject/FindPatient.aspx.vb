Imports System.Data

Partial Class FindPatient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load



    End Sub

    'Populate the datagrid and cache the results
    Private Sub LoadData()
        Dim aPatient As New PatientDataTier
        Dim ds As New DataSet


        ds = aPatient.GetPatient(CType(ViewState("Lname"), String))

        gdvPatients.DataSource = ds.Tables(0)
        gdvPatients.DataBind()

        If Cache("Patientdata") Is Nothing Then
            Cache.Add("Patientdata", New DataView(ds.Tables(0)), Nothing, Caching.Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(10), Caching.CacheItemPriority.Default, Nothing)
        End If
    End Sub

    'Search and Clear buttons

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim lname As String

            lname = txtLname.Text.Trim

            ClearChildViewState()

            ViewState("Lname") = txtLname.Text.Trim



            LoadData()

            gdvPatients.Visible = True







        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex.InnerException)
        End Try
    End Sub


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ViewState("Lname") = String.Empty

        gdvPatients.Visible = False
    End Sub

    'Handles all the paging operations
    Private Sub gdvPatients_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gdvPatients.PageIndexChanging
        Dim pageNum As Int32
        pageNum = e.NewPageIndex
        Paging(pageNum)
    End Sub

    Private Sub Paging(ByVal Page As Int32)
        gdvPatients.PageIndex = Page
        LoadData()
    End Sub


    Private Sub FindPatient_PreRenderComplete(sender As Object, e As EventArgs) Handles Me.PreRenderComplete
        If ViewState("Lname") Is Nothing Then
        Else
            Try
                txtLname.Text = ViewState("Lname").ToString()

            Catch ex As Exception
                Throw New ArgumentException(ex.Message, ex.InnerException)
            End Try
        End If
    End Sub

    'Handles the sorting for the datagrid

    Private Sub gdvPatients_Sorting(sender As Object, e As GridViewSortEventArgs) Handles gdvPatients.Sorting
        SortRecords(e.SortExpression)
    End Sub

    Private Sub SortRecords(ByVal sortExpress As String)
        Dim oldExpression As String = gdvPatients.SortExpression
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

                gdvPatients.DataSource = Source
                gdvPatients.DataBind()
            End With

        Catch ex As Exception

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

    'Sub procedures for buttons in datagrid

    Private Sub AddButton(ByVal sender As Object, ByVal e As CommandEventArgs)


    End Sub




End Class
