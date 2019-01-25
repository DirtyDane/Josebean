<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalInfo))
        Me.lblUpdatePatientInfo = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleInitital = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateofBirth = New System.Windows.Forms.Label()
        Me.lblHomePhone = New System.Windows.Forms.Label()
        Me.lblCellPhone = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.masktxtDOB = New System.Windows.Forms.MaskedTextBox()
        Me.masktxtHPhone = New System.Windows.Forms.MaskedTextBox()
        Me.masktxtCPhone = New System.Windows.Forms.MaskedTextBox()
        Me.masktxtZip = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUpdatePatientInfo
        '
        Me.lblUpdatePatientInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUpdatePatientInfo.AutoSize = True
        Me.lblUpdatePatientInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdatePatientInfo.Location = New System.Drawing.Point(248, 20)
        Me.lblUpdatePatientInfo.Name = "lblUpdatePatientInfo"
        Me.lblUpdatePatientInfo.Size = New System.Drawing.Size(208, 18)
        Me.lblUpdatePatientInfo.TabIndex = 0
        Me.lblUpdatePatientInfo.Text = "Update Patient Information"
        '
        'lblPatientID
        '
        Me.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(32, 66)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(75, 16)
        Me.lblPatientID.TabIndex = 1
        Me.lblPatientID.Text = "Patient ID"
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(32, 110)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(83, 16)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'lblMiddleInitital
        '
        Me.lblMiddleInitital.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMiddleInitital.AutoSize = True
        Me.lblMiddleInitital.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleInitital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleInitital.Location = New System.Drawing.Point(32, 154)
        Me.lblMiddleInitital.Name = "lblMiddleInitital"
        Me.lblMiddleInitital.Size = New System.Drawing.Size(96, 16)
        Me.lblMiddleInitital.TabIndex = 5
        Me.lblMiddleInitital.Text = "Middle Initial"
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(32, 198)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(82, 16)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'lblDateofBirth
        '
        Me.lblDateofBirth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDateofBirth.AutoSize = True
        Me.lblDateofBirth.BackColor = System.Drawing.Color.Transparent
        Me.lblDateofBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateofBirth.Location = New System.Drawing.Point(32, 242)
        Me.lblDateofBirth.Name = "lblDateofBirth"
        Me.lblDateofBirth.Size = New System.Drawing.Size(93, 16)
        Me.lblDateofBirth.TabIndex = 9
        Me.lblDateofBirth.Text = "Date of Birth"
        '
        'lblHomePhone
        '
        Me.lblHomePhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHomePhone.AutoSize = True
        Me.lblHomePhone.BackColor = System.Drawing.Color.Transparent
        Me.lblHomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePhone.Location = New System.Drawing.Point(32, 286)
        Me.lblHomePhone.Name = "lblHomePhone"
        Me.lblHomePhone.Size = New System.Drawing.Size(97, 16)
        Me.lblHomePhone.TabIndex = 11
        Me.lblHomePhone.Text = "Home Phone"
        '
        'lblCellPhone
        '
        Me.lblCellPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCellPhone.AutoSize = True
        Me.lblCellPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblCellPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCellPhone.Location = New System.Drawing.Point(385, 66)
        Me.lblCellPhone.Name = "lblCellPhone"
        Me.lblCellPhone.Size = New System.Drawing.Size(83, 16)
        Me.lblCellPhone.TabIndex = 13
        Me.lblCellPhone.Text = "Cell Phone"
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(385, 110)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 16)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender"
        '
        'Address
        '
        Me.Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address.AutoSize = True
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(385, 154)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(66, 16)
        Me.Address.TabIndex = 17
        Me.Address.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(385, 198)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(34, 16)
        Me.lblCity.TabIndex = 19
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(385, 242)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(44, 16)
        Me.lblState.TabIndex = 21
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblZip.AutoSize = True
        Me.lblZip.BackColor = System.Drawing.Color.Transparent
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(385, 286)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(30, 16)
        Me.lblZip.TabIndex = 23
        Me.lblZip.Text = "Zip"
        '
        'txtPatientID
        '
        Me.txtPatientID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPatientID.Location = New System.Drawing.Point(133, 63)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(174, 22)
        Me.txtPatientID.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Location = New System.Drawing.Point(133, 107)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(174, 22)
        Me.txtFirstName.TabIndex = 4
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMiddleInitial.Location = New System.Drawing.Point(133, 151)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(174, 22)
        Me.txtMiddleInitial.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Location = New System.Drawing.Point(133, 195)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(174, 22)
        Me.txtLastName.TabIndex = 8
        '
        'txtGender
        '
        Me.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGender.Location = New System.Drawing.Point(473, 107)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(199, 22)
        Me.txtGender.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Location = New System.Drawing.Point(473, 151)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(199, 22)
        Me.txtAddress.TabIndex = 18
        '
        'txtCity
        '
        Me.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCity.Location = New System.Drawing.Point(473, 195)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(199, 22)
        Me.txtCity.TabIndex = 20
        '
        'txtState
        '
        Me.txtState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtState.Location = New System.Drawing.Point(473, 239)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(199, 22)
        Me.txtState.TabIndex = 22
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(171, 332)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 28)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(302, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 28)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(441, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 28)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'masktxtDOB
        '
        Me.masktxtDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.masktxtDOB.Location = New System.Drawing.Point(134, 239)
        Me.masktxtDOB.Mask = "00/00/0000"
        Me.masktxtDOB.Name = "masktxtDOB"
        Me.masktxtDOB.Size = New System.Drawing.Size(174, 22)
        Me.masktxtDOB.TabIndex = 10
        '
        'masktxtHPhone
        '
        Me.masktxtHPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.masktxtHPhone.Location = New System.Drawing.Point(133, 283)
        Me.masktxtHPhone.Mask = "(999) 000-0000"
        Me.masktxtHPhone.Name = "masktxtHPhone"
        Me.masktxtHPhone.Size = New System.Drawing.Size(174, 22)
        Me.masktxtHPhone.TabIndex = 12
        '
        'masktxtCPhone
        '
        Me.masktxtCPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.masktxtCPhone.Location = New System.Drawing.Point(473, 63)
        Me.masktxtCPhone.Mask = "(999) 000-0000"
        Me.masktxtCPhone.Name = "masktxtCPhone"
        Me.masktxtCPhone.Size = New System.Drawing.Size(199, 22)
        Me.masktxtCPhone.TabIndex = 14
        '
        'masktxtZip
        '
        Me.masktxtZip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.masktxtZip.Location = New System.Drawing.Point(473, 283)
        Me.masktxtZip.Mask = "00000"
        Me.masktxtZip.Name = "masktxtZip"
        Me.masktxtZip.Size = New System.Drawing.Size(100, 22)
        Me.masktxtZip.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lblUpdatePatientInfo)
        Me.Panel1.Controls.Add(Me.masktxtZip)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.masktxtCPhone)
        Me.Panel1.Controls.Add(Me.lblPatientID)
        Me.Panel1.Controls.Add(Me.masktxtHPhone)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.masktxtDOB)
        Me.Panel1.Controls.Add(Me.lblMiddleInitital)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblDateofBirth)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.lblHomePhone)
        Me.Panel1.Controls.Add(Me.txtState)
        Me.Panel1.Controls.Add(Me.lblCellPhone)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Address)
        Me.Panel1.Controls.Add(Me.txtGender)
        Me.Panel1.Controls.Add(Me.lblCity)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.txtMiddleInitial)
        Me.Panel1.Controls.Add(Me.lblZip)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.txtPatientID)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 383)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(730, 409)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmPersonalInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 409)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPersonalInfo"
        Me.Text = "Update Patient Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpdatePatientInfo As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleInitital As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblDateofBirth As Label
    Friend WithEvents lblHomePhone As Label
    Friend WithEvents lblCellPhone As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Address As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents masktxtDOB As MaskedTextBox
    Friend WithEvents masktxtHPhone As MaskedTextBox
    Friend WithEvents masktxtCPhone As MaskedTextBox
    Friend WithEvents masktxtZip As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
