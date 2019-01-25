Public Class frmUpdatePrescription
    Public presNO As Int32
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmUpdatePrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim prescriptionNO As Int32
            'Dim reader As SqlClient.SqlDataReader

            ' Dim aForm As New frmViewPrescriptions
            'Dim patientID
            'Dim gender As String
            prescriptionNO = presNO

            Dim aPatient As New PatientDataTier
            Dim ds As New DataSet
            Dim ds1 As New DataSet
            'Dim ds2 As New DataSet

            ds = aPatient.GetPrescription2(prescriptionNO)
            ds1 = aPatient.GetDocBox()
            'reader = ds1.executereader()
            'lblPatientID.Visible = False
            With Me

                With Me
                    .lblPrescriptionNoOutput.Text = ds.Tables(0).Rows(0)("Prescription No.").ToString
                    '.lblStudentIDOutput.Enabled = False
                    .lblPatientNameOutput.Text = ds.Tables(0).Rows(0)("Patient Name").ToString
                    .cboPhysicianName.DataSource = ds.Tables(0)
                    .cboPhysicianName.DisplayMember = "Physician Name"
                    .cboPhysicianName.ValueMember = "Physician ID"
                    .cboMedication.DataSource = ds.Tables(0)
                    .cboMedication.DisplayMember = "Medication"
                    .cboMedication.ValueMember = "R.RX_NO"
                    .txtRefill.Text = ds.Tables(0).Rows(0)("Refills").ToString
                    .txtDosage.Text = ds.Tables(0).Rows(0)("Dosage").ToString
                    .cboIntakeMethod.DataSource = ds.Tables(0)
                    .cboIntakeMethod.DisplayMember = "Intake Method"
                    .cboIntakeMethod.ValueMember = "Intake Method"
                    .cboFrequency.DataSource = ds.Tables(0)
                    .cboFrequency.DisplayMember = "Frequency"
                    .cboFrequency.ValueMember = "Frequency"

                End With

                'With Me.cboPhysicianName
                '    .DataSource = ds1.Tables(0)
                '    .DisplayMember = "Physician Name"
                '    .ValueMember = "PHYS_ID"
                '    '.SelectedValue = ds.Tables(0).Rows(0)("PHYS_ID").ToString
                'End With

                'If reader.HasRows Then
                '    While reader.Read()
                '        cboPhysicianName.Items.Add(reader("Physician Name"))
                '    End While
                'End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cboPhysicianName_Click(sender As Object, e As EventArgs)
        Dim aPatient As New PatientDataTier
        Dim ds1 As New DataSet
        ds1 = aPatient.GetDocBox()
        Try
            With Me.cboPhysicianName
                .DataSource = ds1.Tables(0)
                .DisplayMember = "Physician Name"
                .ValueMember = "PHYS_ID"
                '.SelectedValue = ds.Tables(0).Rows(0)("PHYS_ID").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboMedication_Click(sender As Object, e As EventArgs)
        Dim aPatient As New PatientDataTier
        Dim ds1 As New DataSet
        ds1 = aPatient.GetMedBox()
        Try
            With Me.cboMedication
                .DataSource = ds1.Tables(0)
                .DisplayMember = "Medication"
                .ValueMember = "RX_NO"
                '.SelectedValue = ds.Tables(0).Rows(0)("PHYS_ID").ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim presNo, physid, refill As Int32
        Dim rxNo, dosage, intake, frequency As String

        presNo = Int32.Parse(lblPrescriptionNoOutput.Text.Trim)
        physid = Int32.Parse(cboPhysicianName.SelectedValue)
        rxNo = cboMedication.SelectedValue
        dosage = txtDosage.Text.Trim
        intake = cboIntakeMethod.Text.Trim
        frequency = cboFrequency.Text.Trim
        refill = Int32.Parse(txtRefill.Text.Trim)

        Dim aPatient As New PatientDataTier

        aPatient.UpdatePrescription(presNo, physid, rxNo, dosage, intake, frequency, refill)
        Me.Close()
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter, btnClear.MouseEnter, btnClose.MouseEnter
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Dark_Gray_Background
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave, btnClear.MouseLeave, btnClose.MouseLeave
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Gray_Background
        Catch ex As Exception

        End Try
    End Sub
End Class