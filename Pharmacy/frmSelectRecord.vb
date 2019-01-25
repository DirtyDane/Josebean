Public Class frmSelectRecord
    Public myid As String
    'Make exit button close form
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    'Diasable buttons on load
    Private Sub frmSelectRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .btnEditPatientInfo.Visible = False
            .btnViewPrescriptions.Visible = False
            .btnAddPrescription.Visible = False
            .btnSearch.Enabled = False
            .dgvPatient.Visible = False

            If txtLastName.Text.Trim.Length > 0 Then
                .btnSearch.Enabled = True
            Else
                .btnSearch.Enabled = False
            End If
        End With
    End Sub

    'Enable search button if last name has text
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If txtLastName.Text.Trim.Length > 0 Then
            btnSearch.Enabled = True
        Else
            btnSearch.Enabled = False
        End If
    End Sub
    'Search button takes last name text box and searches by contents
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim lname As String

        Dim aPatient As New PatientDataTier


        Dim ds As New DataSet
        Try
            lname = txtLastName.Text.Trim

            ds = aPatient.GetPatient(lname)

            If ds.Tables(0).Rows.Count > 0 Then
                With Me.dgvPatient
                    .DataSource = ds.Tables(0)
                    .Visible = True
                    '.RowHeadersVisible = False
                    .Columns("PATIENT_ID").Visible = False
                End With

                With Me
                    .btnAddPrescription.Visible = True
                    .btnEditPatientInfo.Visible = True
                    .btnViewPrescriptions.Visible = True
                End With
            Else
                With Me.dgvPatient
                    .DataSource = ds.Tables(0)
                    .Visible = False
                    MessageBox.Show("No Matching Records", "View Patients", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '.RowHeadersVisible = False
                    .Columns("PATIENT_ID").Visible = False
                End With

                With Me
                    .btnAddPrescription.Visible = False
                    .btnEditPatientInfo.Visible = False
                    .btnViewPrescriptions.Visible = False
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Try
        End Try
    End Sub




    Private Sub btnViewPrescriptions_Click(sender As Object, e As EventArgs) Handles btnViewPrescriptions.Click
        Dim patientID As String
        Dim aForm As New frmViewPrescriptions
        Dim row As DataGridViewRow = dgvPatient.SelectedRows(0)
        'Me.SendToBack()
        Try
            If dgvPatient.Rows.Count > 0 Then
                patientID = CStr(row.Cells(1).Value)

                myid = patientID

                aForm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEditPatientInfo_Click(sender As Object, e As EventArgs) Handles btnEditPatientInfo.Click
        Dim aForm As New frmPersonalInfo
        Dim row As DataGridViewRow = dgvPatient.SelectedRows(0)
        'Dim prescriptionNO As Int32
        'Dim aForm As New frmUpdatePrescription
        'Dim row As DataGridViewRow = dgvPrescriptions.SelectedRows(0)
        Try


            If dgvPatient.Rows.Count > 0 Then
                aForm.patIDUpdate = CStr(row.Cells(0).Value)

                ' presNO = Int32.Parse(prescriptionNO)

                aForm.ShowDialog()
                btnSearch_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        Dim aForm As New frmPrescription
        Dim row As DataGridViewRow = dgvPatient.SelectedRows(0)
        Try


            'If dgvPrescriptions.Rows.Count > 0 Then
            aForm.patID = CStr(row.Cells(0).Value)
            aForm.patName = CStr(row.Cells(2).Value)
            aForm.patName &= " "
            aForm.patName &= CStr(row.Cells(1).Value)

            ' presNO = Int32.Parse(prescriptionNO)

            aForm.ShowDialog()
            'trying to show updated frmViewPrescriptions
            'Me.Close()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter, btnEditPatientInfo.MouseEnter, btnViewPrescriptions.MouseEnter, btnAddPrescription.MouseEnter, btnExit.MouseEnter
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Dark_Gray_Background
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave, btnEditPatientInfo.MouseLeave, btnViewPrescriptions.MouseLeave, btnAddPrescription.MouseLeave, btnExit.MouseLeave
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Gray_Background
        Catch ex As Exception

        End Try
    End Sub


End Class