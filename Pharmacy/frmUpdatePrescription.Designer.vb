<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePrescription
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdatePrescription))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPrescriptionNo = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPrescriptionNoOutput = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.txtRefill = New System.Windows.Forms.TextBox()
        Me.lblPatientNameOutput = New System.Windows.Forms.Label()
        Me.lblRefill = New System.Windows.Forms.Label()
        Me.lblPhysicianName = New System.Windows.Forms.Label()
        Me.cboFrequency = New System.Windows.Forms.ComboBox()
        Me.cboPhysicianName = New System.Windows.Forms.ComboBox()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.cboIntakeMethod = New System.Windows.Forms.ComboBox()
        Me.cboMedication = New System.Windows.Forms.ComboBox()
        Me.lblIntakeMethod = New System.Windows.Forms.Label()
        Me.lblDosage = New System.Windows.Forms.Label()
        Me.txtDosage = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblPrescriptionNo)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblPrescriptionNoOutput)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.txtRefill)
        Me.Panel1.Controls.Add(Me.lblPatientNameOutput)
        Me.Panel1.Controls.Add(Me.lblRefill)
        Me.Panel1.Controls.Add(Me.lblPhysicianName)
        Me.Panel1.Controls.Add(Me.cboFrequency)
        Me.Panel1.Controls.Add(Me.cboPhysicianName)
        Me.Panel1.Controls.Add(Me.lblFrequency)
        Me.Panel1.Controls.Add(Me.lblMedication)
        Me.Panel1.Controls.Add(Me.cboIntakeMethod)
        Me.Panel1.Controls.Add(Me.cboMedication)
        Me.Panel1.Controls.Add(Me.lblIntakeMethod)
        Me.Panel1.Controls.Add(Me.lblDosage)
        Me.Panel1.Controls.Add(Me.txtDosage)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 359)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Update Prescription information"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(384, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 28)
        Me.btnClose.TabIndex = 39
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPrescriptionNo
        '
        Me.lblPrescriptionNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrescriptionNo.AutoSize = True
        Me.lblPrescriptionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionNo.Location = New System.Drawing.Point(27, 56)
        Me.lblPrescriptionNo.Name = "lblPrescriptionNo"
        Me.lblPrescriptionNo.Size = New System.Drawing.Size(119, 16)
        Me.lblPrescriptionNo.TabIndex = 21
        Me.lblPrescriptionNo.Text = "Prescription No."
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(102, 307)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 28)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPrescriptionNoOutput
        '
        Me.lblPrescriptionNoOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrescriptionNoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrescriptionNoOutput.Location = New System.Drawing.Point(152, 55)
        Me.lblPrescriptionNoOutput.Name = "lblPrescriptionNoOutput"
        Me.lblPrescriptionNoOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblPrescriptionNoOutput.TabIndex = 22
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(243, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 28)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "Update Prescription"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblPatientName
        '
        Me.lblPatientName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(27, 107)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(101, 16)
        Me.lblPatientName.TabIndex = 23
        Me.lblPatientName.Text = "Patient Name"
        '
        'txtRefill
        '
        Me.txtRefill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRefill.Location = New System.Drawing.Point(152, 257)
        Me.txtRefill.Name = "txtRefill"
        Me.txtRefill.Size = New System.Drawing.Size(100, 22)
        Me.txtRefill.TabIndex = 36
        '
        'lblPatientNameOutput
        '
        Me.lblPatientNameOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientNameOutput.Location = New System.Drawing.Point(152, 106)
        Me.lblPatientNameOutput.Name = "lblPatientNameOutput"
        Me.lblPatientNameOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblPatientNameOutput.TabIndex = 24
        '
        'lblRefill
        '
        Me.lblRefill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRefill.AutoSize = True
        Me.lblRefill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefill.Location = New System.Drawing.Point(27, 260)
        Me.lblRefill.Name = "lblRefill"
        Me.lblRefill.Size = New System.Drawing.Size(66, 16)
        Me.lblRefill.TabIndex = 35
        Me.lblRefill.Text = "Refill(s):"
        '
        'lblPhysicianName
        '
        Me.lblPhysicianName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhysicianName.AutoSize = True
        Me.lblPhysicianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicianName.Location = New System.Drawing.Point(27, 158)
        Me.lblPhysicianName.Name = "lblPhysicianName"
        Me.lblPhysicianName.Size = New System.Drawing.Size(120, 16)
        Me.lblPhysicianName.TabIndex = 25
        Me.lblPhysicianName.Text = "Physician Name"
        '
        'cboFrequency
        '
        Me.cboFrequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboFrequency.FormattingEnabled = True
        Me.cboFrequency.Location = New System.Drawing.Point(430, 206)
        Me.cboFrequency.Name = "cboFrequency"
        Me.cboFrequency.Size = New System.Drawing.Size(121, 24)
        Me.cboFrequency.TabIndex = 34
        '
        'cboPhysicianName
        '
        Me.cboPhysicianName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPhysicianName.FormattingEnabled = True
        Me.cboPhysicianName.Location = New System.Drawing.Point(152, 155)
        Me.cboPhysicianName.Name = "cboPhysicianName"
        Me.cboPhysicianName.Size = New System.Drawing.Size(121, 24)
        Me.cboPhysicianName.TabIndex = 26
        '
        'lblFrequency
        '
        Me.lblFrequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequency.Location = New System.Drawing.Point(315, 209)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(85, 16)
        Me.lblFrequency.TabIndex = 33
        Me.lblFrequency.Text = "Frequency:"
        '
        'lblMedication
        '
        Me.lblMedication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.Location = New System.Drawing.Point(27, 209)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(84, 16)
        Me.lblMedication.TabIndex = 27
        Me.lblMedication.Text = "Medication"
        '
        'cboIntakeMethod
        '
        Me.cboIntakeMethod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboIntakeMethod.FormattingEnabled = True
        Me.cboIntakeMethod.Location = New System.Drawing.Point(430, 155)
        Me.cboIntakeMethod.Name = "cboIntakeMethod"
        Me.cboIntakeMethod.Size = New System.Drawing.Size(121, 24)
        Me.cboIntakeMethod.TabIndex = 32
        '
        'cboMedication
        '
        Me.cboMedication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMedication.FormattingEnabled = True
        Me.cboMedication.Location = New System.Drawing.Point(152, 206)
        Me.cboMedication.Name = "cboMedication"
        Me.cboMedication.Size = New System.Drawing.Size(121, 24)
        Me.cboMedication.TabIndex = 28
        '
        'lblIntakeMethod
        '
        Me.lblIntakeMethod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIntakeMethod.AutoSize = True
        Me.lblIntakeMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeMethod.Location = New System.Drawing.Point(315, 158)
        Me.lblIntakeMethod.Name = "lblIntakeMethod"
        Me.lblIntakeMethod.Size = New System.Drawing.Size(109, 16)
        Me.lblIntakeMethod.TabIndex = 31
        Me.lblIntakeMethod.Text = "Intake Method:"
        '
        'lblDosage
        '
        Me.lblDosage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDosage.AutoSize = True
        Me.lblDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosage.Location = New System.Drawing.Point(315, 107)
        Me.lblDosage.Name = "lblDosage"
        Me.lblDosage.Size = New System.Drawing.Size(98, 16)
        Me.lblDosage.TabIndex = 29
        Me.lblDosage.Text = "Dosage(mg):"
        '
        'txtDosage
        '
        Me.txtDosage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDosage.Location = New System.Drawing.Point(430, 104)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.Size = New System.Drawing.Size(100, 22)
        Me.txtDosage.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 382)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'frmUpdatePrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 382)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdatePrescription"
        Me.Text = "Update Prescriptions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblPrescriptionNo As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPrescriptionNoOutput As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblPatientName As Label
    Friend WithEvents txtRefill As TextBox
    Friend WithEvents lblPatientNameOutput As Label
    Friend WithEvents lblRefill As Label
    Friend WithEvents lblPhysicianName As Label
    Friend WithEvents cboFrequency As ComboBox
    Friend WithEvents cboPhysicianName As ComboBox
    Friend WithEvents lblFrequency As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents cboIntakeMethod As ComboBox
    Friend WithEvents cboMedication As ComboBox
    Friend WithEvents lblIntakeMethod As Label
    Friend WithEvents lblDosage As Label
    Friend WithEvents txtDosage As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
