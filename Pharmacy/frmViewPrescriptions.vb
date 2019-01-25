Public Class frmViewPrescriptions
    Public intID As Int32 = 0


    Private Sub frmViewPrescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim PATID As String
            Dim patientID
            'Dim gender As String

            PATID = frmSelectRecord.myID

            Dim aPatient As New PatientDataTier
            Dim ds As New DataSet
            Dim ds2 As New DataSet

            ds = aPatient.GetPatient(PATID)

            lblPatientID.Visible = False
            With Me
                .lblFullName.Text = ds.Tables(0).Rows(0)("Last Name").ToString
                .lblPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString

            End With

            'Dim lname As String





            Try
                patientID = lblPatientID.Text.Trim

                ds2 = aPatient.GetPrescription(patientID)

                If ds.Tables(0).Rows.Count > 0 Then
                    With Me.dgvPrescriptions
                        .DataSource = ds2.Tables(0)
                        .Visible = True
                        '.RowHeadersVisible = False
                        .Columns(0).Visible = False
                        .Columns(1).Visible = False
                        .Columns(3).Visible = False
                        .Columns(5).Visible = False
                    End With
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Try
            End Try

            'With Me.cboState
            '    .DataSource = StateManager.getStates()
            '    .DisplayMember = "FullAndAbbrev"
            '    .ValueMember = "abbreviation"
            '    .SelectedValue = "PA"
            'End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Try
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnEditPrescription_Click(sender As Object, e As EventArgs)
        'Dim prescriptionNO As Int32
        Dim aForm As New frmUpdatePrescription
        Dim row As DataGridViewRow = dgvPrescriptions.SelectedRows(0)
        Try


            If dgvPrescriptions.Rows.Count > 0 Then
                aForm.presNO = CStr(row.Cells(0).Value)

                ' presNO = Int32.Parse(prescriptionNO)

                aForm.ShowDialog()
                frmViewPrescriptions_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs)
        Dim aForm As New frmPrescription
        'Dim row As DataGridViewRow = dgvPrescriptions.SelectedRows(0)
        Try


            'If dgvPrescriptions.Rows.Count > 0 Then
            aForm.patID = lblPatientID.Text
            aForm.patName = lblFullName.Text

            ' presNO = Int32.Parse(prescriptionNO)
            'Me.Close()
            aForm.ShowDialog()
            frmViewPrescriptions_Load(sender, e)
            'trying to show updated frmViewPrescriptions
            'Me.Close()

            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFillPrescription_Click(sender As Object, e As EventArgs)
        Dim presNO As Int32
        Dim refill As Int32
        Try
            Dim aPatient As New PatientDataTier

            refill = dgvPrescriptions.SelectedRows(0).Cells(10).Value - 1

            presNO = dgvPrescriptions.SelectedRows(0).Cells(0).Value
            If refill >= 0 And presNO > 0 Then
                aPatient.FillPrescription(presNO, refill)
                MessageBox.Show("Prescription Filled", "Fill Prescription", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frmViewPrescriptions_Load(sender, e)

            ElseIf presNO < 1 Then
                MessageBox.Show("Please Select a Valid Prescription!", "Fill Prescription", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("No Refills Remaining!", "Fill Prescription", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnEditPrescription.MouseEnter, btnAddPrescription.MouseEnter, btnFillPrescription.MouseEnter, btnClose.MouseEnter
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Dark_Gray_Background
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnEditPrescription.MouseLeave, btnAddPrescription.MouseLeave, btnFillPrescription.MouseLeave, btnClose.MouseLeave
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Gray_Background
        Catch ex As Exception

        End Try
    End Sub
End Class