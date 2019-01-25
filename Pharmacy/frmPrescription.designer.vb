<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrescription))
        Me.lblAddPrescription = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientNameOutput = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.txtRefill = New System.Windows.Forms.TextBox()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.txtIntakeMethod = New System.Windows.Forms.TextBox()
        Me.lblRefill = New System.Windows.Forms.Label()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDosage = New System.Windows.Forms.TextBox()
        Me.lblDosage = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblPhysicianID = New System.Windows.Forms.Label()
        Me.cboMedication = New System.Windows.Forms.ComboBox()
        Me.cboPhysician = New System.Windows.Forms.ComboBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddPrescription
        '
        Me.lblAddPrescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddPrescription.AutoSize = True
        Me.lblAddPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPrescription.Location = New System.Drawing.Point(236, 19)
        Me.lblAddPrescription.Name = "lblAddPrescription"
        Me.lblAddPrescription.Size = New System.Drawing.Size(132, 18)
        Me.lblAddPrescription.TabIndex = 0
        Me.lblAddPrescription.Text = "Add Prescription"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblPatientNameOutput)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.txtRefill)
        Me.Panel1.Controls.Add(Me.txtFrequency)
        Me.Panel1.Controls.Add(Me.txtIntakeMethod)
        Me.Panel1.Controls.Add(Me.lblRefill)
        Me.Panel1.Controls.Add(Me.lblFrequency)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDosage)
        Me.Panel1.Controls.Add(Me.lblDosage)
        Me.Panel1.Controls.Add(Me.lblMedication)
        Me.Panel1.Controls.Add(Me.lblPhysicianID)
        Me.Panel1.Controls.Add(Me.cboMedication)
        Me.Panel1.Controls.Add(Me.cboPhysician)
        Me.Panel1.Controls.Add(Me.lblPatientID)
        Me.Panel1.Controls.Add(Me.lblAddPrescription)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 387)
        Me.Panel1.TabIndex = 1
        '
        'lblPatientNameOutput
        '
        Me.lblPatientNameOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientNameOutput.Location = New System.Drawing.Point(135, 120)
        Me.lblPatientNameOutput.Name = "lblPatientNameOutput"
        Me.lblPatientNameOutput.Size = New System.Drawing.Size(146, 23)
        Me.lblPatientNameOutput.TabIndex = 19
        '
        'lblPatientName
        '
        Me.lblPatientName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(24, 121)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(105, 16)
        Me.lblPatientName.TabIndex = 18
        Me.lblPatientName.Text = "Patient Name:"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(384, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 28)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(256, 323)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 28)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearAll.BackgroundImage = CType(resources.GetObject("btnClearAll.BackgroundImage"), System.Drawing.Image)
        Me.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(128, 324)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(93, 28)
        Me.btnClearAll.TabIndex = 15
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'txtRefill
        '
        Me.txtRefill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRefill.Location = New System.Drawing.Point(435, 218)
        Me.txtRefill.Name = "txtRefill"
        Me.txtRefill.Size = New System.Drawing.Size(146, 22)
        Me.txtRefill.TabIndex = 14
        '
        'txtFrequency
        '
        Me.txtFrequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFrequency.Location = New System.Drawing.Point(435, 168)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(146, 22)
        Me.txtFrequency.TabIndex = 13
        '
        'txtIntakeMethod
        '
        Me.txtIntakeMethod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIntakeMethod.Location = New System.Drawing.Point(435, 118)
        Me.txtIntakeMethod.Name = "txtIntakeMethod"
        Me.txtIntakeMethod.Size = New System.Drawing.Size(146, 22)
        Me.txtIntakeMethod.TabIndex = 12
        '
        'lblRefill
        '
        Me.lblRefill.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRefill.AutoSize = True
        Me.lblRefill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefill.Location = New System.Drawing.Point(320, 218)
        Me.lblRefill.Name = "lblRefill"
        Me.lblRefill.Size = New System.Drawing.Size(48, 16)
        Me.lblRefill.TabIndex = 11
        Me.lblRefill.Text = "Refill:"
        '
        'lblFrequency
        '
        Me.lblFrequency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequency.Location = New System.Drawing.Point(320, 171)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(85, 16)
        Me.lblFrequency.TabIndex = 10
        Me.lblFrequency.Text = "Frequency:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Intake Method:"
        '
        'txtDosage
        '
        Me.txtDosage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDosage.Location = New System.Drawing.Point(135, 268)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.Size = New System.Drawing.Size(146, 22)
        Me.txtDosage.TabIndex = 8
        '
        'lblDosage
        '
        Me.lblDosage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDosage.AutoSize = True
        Me.lblDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosage.Location = New System.Drawing.Point(24, 271)
        Me.lblDosage.Name = "lblDosage"
        Me.lblDosage.Size = New System.Drawing.Size(67, 16)
        Me.lblDosage.TabIndex = 7
        Me.lblDosage.Text = "Dosage:"
        '
        'lblMedication
        '
        Me.lblMedication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.Location = New System.Drawing.Point(24, 221)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(88, 16)
        Me.lblMedication.TabIndex = 6
        Me.lblMedication.Text = "Medication:"
        '
        'lblPhysicianID
        '
        Me.lblPhysicianID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhysicianID.AutoSize = True
        Me.lblPhysicianID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicianID.Location = New System.Drawing.Point(24, 171)
        Me.lblPhysicianID.Name = "lblPhysicianID"
        Me.lblPhysicianID.Size = New System.Drawing.Size(98, 16)
        Me.lblPhysicianID.TabIndex = 5
        Me.lblPhysicianID.Text = "Physician ID:"
        '
        'cboMedication
        '
        Me.cboMedication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMedication.FormattingEnabled = True
        Me.cboMedication.Location = New System.Drawing.Point(135, 218)
        Me.cboMedication.Name = "cboMedication"
        Me.cboMedication.Size = New System.Drawing.Size(146, 24)
        Me.cboMedication.TabIndex = 4
        '
        'cboPhysician
        '
        Me.cboPhysician.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPhysician.FormattingEnabled = True
        Me.cboPhysician.Location = New System.Drawing.Point(135, 168)
        Me.cboPhysician.Name = "cboPhysician"
        Me.cboPhysician.Size = New System.Drawing.Size(146, 24)
        Me.cboPhysician.TabIndex = 3
        '
        'lblPatientID
        '
        Me.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(24, 71)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(79, 16)
        Me.lblPatientID.TabIndex = 1
        Me.lblPatientID.Text = "Patient ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(629, 412)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrescription"
        Me.Text = "Add Patient Prescription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAddPrescription As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtRefill As TextBox
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents txtIntakeMethod As TextBox
    Friend WithEvents lblRefill As Label
    Friend WithEvents lblFrequency As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDosage As TextBox
    Friend WithEvents lblDosage As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblPhysicianID As Label
    Friend WithEvents cboMedication As ComboBox
    Friend WithEvents cboPhysician As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lblPatientNameOutput As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
