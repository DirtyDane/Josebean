<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPrescriptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewPrescriptions))
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFillPrescription = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPatientLastName = New System.Windows.Forms.Label()
        Me.btnAddPrescription = New System.Windows.Forms.Button()
        Me.dgvPrescriptions = New System.Windows.Forms.DataGridView()
        Me.btnEditPrescription = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatientID
        '
        Me.lblPatientID.Location = New System.Drawing.Point(439, 45)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(100, 23)
        Me.lblPatientID.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPatientID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnFillPrescription)
        Me.Panel1.Controls.Add(Me.lblFullName)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblPatientLastName)
        Me.Panel1.Controls.Add(Me.btnAddPrescription)
        Me.Panel1.Controls.Add(Me.dgvPrescriptions)
        Me.Panel1.Controls.Add(Me.btnEditPrescription)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 392)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "View Patient Prescriptions"
        '
        'btnFillPrescription
        '
        Me.btnFillPrescription.BackgroundImage = CType(resources.GetObject("btnFillPrescription.BackgroundImage"), System.Drawing.Image)
        Me.btnFillPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFillPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFillPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillPrescription.Location = New System.Drawing.Point(804, 225)
        Me.btnFillPrescription.Name = "btnFillPrescription"
        Me.btnFillPrescription.Size = New System.Drawing.Size(128, 28)
        Me.btnFillPrescription.TabIndex = 15
        Me.btnFillPrescription.Text = "Fill Prescription"
        Me.btnFillPrescription.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Location = New System.Drawing.Point(439, 80)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(183, 23)
        Me.lblFullName.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(804, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 28)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPatientLastName
        '
        Me.lblPatientLastName.AutoSize = True
        Me.lblPatientLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientLastName.Location = New System.Drawing.Point(328, 83)
        Me.lblPatientLastName.Name = "lblPatientLastName"
        Me.lblPatientLastName.Size = New System.Drawing.Size(105, 16)
        Me.lblPatientLastName.TabIndex = 10
        Me.lblPatientLastName.Text = "Patient Name:"
        '
        'btnAddPrescription
        '
        Me.btnAddPrescription.BackgroundImage = CType(resources.GetObject("btnAddPrescription.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPrescription.Location = New System.Drawing.Point(804, 173)
        Me.btnAddPrescription.Name = "btnAddPrescription"
        Me.btnAddPrescription.Size = New System.Drawing.Size(128, 28)
        Me.btnAddPrescription.TabIndex = 13
        Me.btnAddPrescription.Text = "Add Prescription"
        Me.btnAddPrescription.UseVisualStyleBackColor = True
        '
        'dgvPrescriptions
        '
        Me.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescriptions.Location = New System.Drawing.Point(20, 121)
        Me.dgvPrescriptions.Name = "dgvPrescriptions"
        Me.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrescriptions.Size = New System.Drawing.Size(764, 250)
        Me.dgvPrescriptions.TabIndex = 11
        '
        'btnEditPrescription
        '
        Me.btnEditPrescription.BackgroundImage = CType(resources.GetObject("btnEditPrescription.BackgroundImage"), System.Drawing.Image)
        Me.btnEditPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPrescription.Location = New System.Drawing.Point(804, 121)
        Me.btnEditPrescription.Name = "btnEditPrescription"
        Me.btnEditPrescription.Size = New System.Drawing.Size(128, 28)
        Me.btnEditPrescription.TabIndex = 12
        Me.btnEditPrescription.Text = "Edit Prescription"
        Me.btnEditPrescription.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(973, 417)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmViewPrescriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewPrescriptions"
        Me.Text = "View Prescriptions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFillPrescription As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblPatientLastName As Label
    Friend WithEvents btnAddPrescription As Button
    Friend WithEvents dgvPrescriptions As DataGridView
    Friend WithEvents btnEditPrescription As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
