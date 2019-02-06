
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Role") Is Nothing Then

        End If
    End Sub
End Class

