Public Class frmPersonalInfo
    Public patIDUpdate As Int32
    'Public 

    Private Sub ClearMe()
        With Me
            .txtPatientID.Clear()
            .txtFirstName.Clear()
            .txtMiddleInitial.Clear()
            .txtLastName.Clear()
            .masktxtDOB.Clear()
            .masktxtHPhone.Clear()
            .masktxtCPhone.Clear()
            .txtGender.Clear()
            .txtAddress.Clear()
            .txtCity.Clear()
            .txtState.Clear()
            .masktxtZip.Clear()
        End With
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim PatientID, FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP As String
        'Dim aInserRecord As New InsertRecords

        'Try
        '    PatientID = txtPatientID.Text.Trim
        '    FName = txtFName.Text.Trim
        '    MidInitial = txtMidInit.Text.Trim
        '    LName = txtLName.Text.Trim
        Try
            PatientID = txtPatientID.Text.Trim
            FName = txtFirstName.Text.Trim
            MidInitial = txtMiddleInitial.Text.Trim
            LName = txtLastName.Text.Trim
            DOB = masktxtDOB.Text.Trim
            HomePhone = masktxtHPhone.Text.Trim
            CellPhone = masktxtCPhone.Text.Trim
            Gender = txtGender.Text.Trim
            Address = txtAddress.Text.Trim
            City = txtCity.Text.Trim
            State = txtState.Text.Trim
            ZIP = masktxtZip.Text.Trim

            ' If one of the fields that allow nulls that has a Masked TextBox is empty, insert a blank instead of inserting a blank mask.
            ' A blank mask does not look nice in the DataBase. For example: A blank Home Phone will look like "(  )  -  "
            If masktxtHPhone.MaskCompleted = False Then
                HomePhone = ""
            End If
            If masktxtCPhone.MaskCompleted = False Then
                CellPhone = ""
            End If
            If masktxtZip.MaskCompleted = False Then
                ZIP = ""
            End If
            Try
                Dim aPatient As New PatientDataTier

                aPatient.UpdatePatient(PatientID, FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP)

                MessageBox.Show("Patient Info Updated", "Edit Patient Info", MessageBoxButtons.OK, MessageBoxIcon.None)

                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        '    If PatientID <> "" AndAlso FName <> "" AndAlso LName <> "" AndAlso DOB <> "" AndAlso Gender <> "" Then
        '        aInserRecord.AddPatient(PatientID, FName, MidInitial, LName, DOB, HomePhone, CellPhone, Gender, Address, City, State, ZIP)
        '    Else
        '        MessageBox.Show("One or more of the required fields are blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    MessageBox.Show(aInserRecord.strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub frmPersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patID As Int32

        patID = patIDUpdate

        Dim aPatient As New PatientDataTier
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        'Dim ds2 As New DataSet

        ds = aPatient.GetPatient2(patID)
        'ds1 = aPatient.GetDocBox()
        'reader = ds1.executereader()
        'lblPatientID.Visible = False
        'With Me

        With Me
            .txtPatientID.Text = ds.Tables(0).Rows(0)("PATIENT_ID").ToString
            .txtPatientID.Enabled = False
            .txtFirstName.Text = ds.Tables(0).Rows(0)("FNAME").ToString
            .txtMiddleInitial.Text = ds.Tables(0).Rows(0)("MI").ToString
            .txtLastName.Text = ds.Tables(0).Rows(0)("LNAME").ToString
            .txtAddress.Text = ds.Tables(0).Rows(0)("PAT_ADDRESS1").ToString
            .txtCity.Text = ds.Tables(0).Rows(0)("PAT_CITY").ToString
            .txtState.Text = ds.Tables(0).Rows(0)("PAT_STATE").ToString
            .masktxtZip.Text = ds.Tables(0).Rows(0)("PAT_ZIP").ToString
            .masktxtDOB.Text = ds.Tables(0).Rows(0)("DOB").ToString
            .masktxtHPhone.Text = ds.Tables(0).Rows(0)("HOME_PHONE").ToString
            .masktxtCPhone.Text = ds.Tables(0).Rows(0)("CELL_PHONE").ToString
            .txtGender.Text = ds.Tables(0).Rows(0)("GENDER").ToString
            '.cboPhysicianName.DataSource = ds.Tables(0)
            '.cboPhysicianName.DisplayMember = "Physician Name"
            '.cboPhysicianName.ValueMember = "Physician ID"
            '.cboMedication.DataSource = ds.Tables(0)
            '.cboMedication.DisplayMember = "Medication"
            '.cboMedication.ValueMember = "R.RX_NO"
            '.txtRefill.Text = ds.Tables(0).Rows(0)("Refills").ToString
            '.txtDosage.Text = ds.Tables(0).Rows(0)("Dosage").ToString
            '.cboIntakeMethod.DataSource = ds.Tables(0)
            '.cboIntakeMethod.DisplayMember = "Intake Method"
            '.cboIntakeMethod.ValueMember = "Intake Method"
            '.cboFrequency.DataSource = ds.Tables(0)
            '.cboFrequency.DisplayMember = "Frequency"
            '.cboFrequency.ValueMember = "Frequency"

        End With
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter, btnClear.MouseEnter, btnExit.MouseEnter
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Dark_Gray_Background
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave, btnClear.MouseLeave, btnExit.MouseLeave
        Dim button As Button = CType(sender, Button)

        Try
            sender.BackgroundImage = My.Resources.Gray_Background
        Catch ex As Exception

        End Try
    End Sub
End Class