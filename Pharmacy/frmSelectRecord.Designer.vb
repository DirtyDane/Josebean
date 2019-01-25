<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectRecord))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.dgvPatient = New System.Windows.Forms.DataGridView()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnViewPrescriptions = New System.Windows.Forms.Button()
        Me.btnEditPatientInfo = New System.Windows.Forms.Button()
        Me.btnAddPrescription = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuView
        '
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'mnuAbout
        '
        Me.mnuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(44, 20)
        Me.mnuAbout.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.dgvPatient)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.btnViewPrescriptions)
        Me.Panel1.Controls.Add(Me.btnEditPatientInfo)
        Me.Panel1.Controls.Add(Me.btnAddPrescription)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 476)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Display Patient Information"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(96, 45)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(138, 16)
        Me.lblPatientName.TabIndex = 17
        Me.lblPatientName.Text = "Patient Last Name:"
        '
        'dgvPatient
        '
        Me.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvPatient.Location = New System.Drawing.Point(16, 120)
        Me.dgvPatient.Name = "dgvPatient"
        Me.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatient.Size = New System.Drawing.Size(788, 335)
        Me.dgvPatient.TabIndex = 24
        Me.dgvPatient.VirtualMode = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(240, 41)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 18
        '
        'btnViewPrescriptions
        '
        Me.btnViewPrescriptions.BackgroundImage = CType(resources.GetObject("btnViewPrescriptions.BackgroundImage"), System.Drawing.Image)
        Me.btnViewPrescriptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPrescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPrescriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPrescriptions.Location = New System.Drawing.Point(829, 183)
        Me.btnViewPrescriptions.Name = "btnViewPrescriptions"
        Me.btnViewPrescriptions.Size = New System.Drawing.Size(141, 28)
        Me.btnViewPrescriptions.TabIndex = 23
        Me.btnViewPrescriptions.Text = "View Prescriptions"
        Me.btnViewPrescriptions.UseVisualStyleBackColor = True
        '
        'btnEditPatientInfo
        '
        Me.btnEditPatientInfo.BackgroundImage = CType(resources.GetObject("btnEditPatientInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnEditPatientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPatientInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPatientInfo.Location = New System.Drawing.Point(829, 120)
        Me.btnEditPatientInfo.Name = "btnEditPatientInfo"
        Me.btnEditPatientInfo.Size = New System.Drawing.Size(141, 28)
        Me.btnEditPatientInfo.TabIndex = 19
        Me.btnEditPatientInfo.Text = "Edit Patient Info"
        Me.btnEditPatientInfo.UseVisualStyleBackColor = True
        '
        'btnAddPrescription
        '
        Me.btnAddPrescription.BackgroundImage = CType(resources.GetObject("btnAddPrescription.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPrescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPrescription.Location = New System.Drawing.Point(829, 246)
        Me.btnAddPrescription.Name = "btnAddPrescription"
        Me.btnAddPrescription.Size = New System.Drawing.Size(141, 28)
        Me.btnAddPrescription.TabIndex = 22
        Me.btnAddPrescription.Text = "Add Prescription"
        Me.btnAddPrescription.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(829, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 28)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(240, 76)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 28)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1020, 526)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmSelectRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 526)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSelectRecord"
        Me.Text = "Display Patient Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents dgvPatient As DataGridView
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnViewPrescriptions As Button
    Friend WithEvents btnEditPatientInfo As Button
    Friend WithEvents btnAddPrescription As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
