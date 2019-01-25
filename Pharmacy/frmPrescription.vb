Imports System.ComponentModel

Public Class frmPrescription
    Public patID
    Public patName
    Private counter As Int32 = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim prescriptionNO As Int32

            Dim aPatient As New PatientDataTier
            Dim ds As New DataSet
            Dim ds1 As New DataSet
            Dim ds2 As New DataSet


            ds1 = aPatient.GetDocBox()
            ds = aPatient.GetMedBox()



            With Me
                .lblPatientID.Text = patID.ToString()
                .lblPatientID.Visible = False
                .lblPatientNameOutput.Text = patName.ToString()
                .cboPhysician.DataSource = ds1.Tables(0)
                .cboPhysician.DisplayMember = "Physician Name"
                .cboPhysician.ValueMember = "PHYS_ID"
                .cboMedication.DataSource = ds.Tables(0)
                .cboMedication.DisplayMember = "Medication"
                .cboMedication.ValueMember = "RX_NO"


            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'initialize class
            Dim aForm As New PatientDataTier


            Dim strMessage As String = "Prescription added!"
            'declare variables for addPrescription sub
            Dim patientID As Int32 = Int32.Parse(lblPatientID.Text)
            Dim physID As Int32 = Int32.Parse(cboPhysician.SelectedValue)
            Dim rxNO As String = cboMedication.SelectedValue.ToString()
            Dim dosage As String = txtDosage.Text
            Dim intakeMethod As String = txtIntakeMethod.Text
            Dim frequency As String = txtFrequency.Text
            Dim refill As Int32 = Int32.Parse(txtRefill.Text)

            aForm.AddPrescription(patientID, physID, rxNO, dosage, intakeMethod, frequency, refill)

            Me.btnClearAll.PerformClick()

            MessageBox.Show(strMessage, "Add Prescription", MessageBoxButtons.OK, MessageBoxIcon.Information)

            counter += 1


            'frmViewPrescriptions.btnClose.PerformClick()

            'frmSelectRecord.btnViewPrescriptions.PerformClick()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim aForm As New PatientDataTier
        aForm.ClearTextBox(Me)
        With Me
            .cboMedication.SelectedIndex = 0
            .cboPhysician.SelectedIndex = 0
        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Private Sub frmPrescription_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    ' If counter > 0 Then
    '    Dim bForm As New frmViewPrescriptions
    '    'Pharmacy.frmViewPrescriptions.Close()

    '    'bForm.Hide()
    '    bForm.Show()
    '    bForm.BringToFront()
    '    bForm.StartPosition = FormStartPosition.CenterScreen


    '    'End If
    'End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnClearAll.MouseEnter, btnAdd.MouseEnter, btnClose.MouseEnter
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Dark_Gray_Background
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnClearAll.MouseLeave, btnAdd.MouseLeave, btnClose.MouseLeave
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Gray_Background
        Catch ex As Exception

        End Try
    End Sub
End Class