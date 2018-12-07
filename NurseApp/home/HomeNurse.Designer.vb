<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeNurse
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPatients = New System.Windows.Forms.DataGridView()
        Me.btnAddP = New System.Windows.Forms.Button()
        Me.btnEditP = New System.Windows.Forms.Button()
        Me.btnDeleteP = New System.Windows.Forms.Button()
        Me.lblPatients = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.gbVitals = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHR = New System.Windows.Forms.Label()
        Me.lblVitals = New System.Windows.Forms.Label()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVitals.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SesionToolStripMenuItem, Me.PatientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SesionToolStripMenuItem.Text = "Sesion"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PatientesToolStripMenuItem
        '
        Me.PatientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem})
        Me.PatientesToolStripMenuItem.Name = "PatientesToolStripMenuItem"
        Me.PatientesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PatientesToolStripMenuItem.Text = "Patients"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPatients.Location = New System.Drawing.Point(26, 115)
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.RowHeadersVisible = False
        Me.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatients.Size = New System.Drawing.Size(487, 256)
        Me.dgvPatients.TabIndex = 1
        Me.dgvPatients.Visible = False
        '
        'btnAddP
        '
        Me.btnAddP.Location = New System.Drawing.Point(26, 80)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(75, 23)
        Me.btnAddP.TabIndex = 2
        Me.btnAddP.Text = "New Patient"
        Me.btnAddP.UseVisualStyleBackColor = True
        Me.btnAddP.Visible = False
        '
        'btnEditP
        '
        Me.btnEditP.Location = New System.Drawing.Point(118, 80)
        Me.btnEditP.Name = "btnEditP"
        Me.btnEditP.Size = New System.Drawing.Size(75, 23)
        Me.btnEditP.TabIndex = 2
        Me.btnEditP.Text = "Edit Patient"
        Me.btnEditP.UseVisualStyleBackColor = True
        Me.btnEditP.Visible = False
        '
        'btnDeleteP
        '
        Me.btnDeleteP.Location = New System.Drawing.Point(438, 80)
        Me.btnDeleteP.Name = "btnDeleteP"
        Me.btnDeleteP.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteP.TabIndex = 2
        Me.btnDeleteP.Text = "Delete Patient"
        Me.btnDeleteP.UseVisualStyleBackColor = True
        Me.btnDeleteP.Visible = False
        '
        'lblPatients
        '
        Me.lblPatients.AutoSize = True
        Me.lblPatients.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPatients.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPatients.Location = New System.Drawing.Point(170, 35)
        Me.lblPatients.Name = "lblPatients"
        Me.lblPatients.Padding = New System.Windows.Forms.Padding(200, 5, 200, 5)
        Me.lblPatients.Size = New System.Drawing.Size(584, 32)
        Me.lblPatients.TabIndex = 3
        Me.lblPatients.Text = "LIST OF PATIENTS"
        Me.lblPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPatients.Visible = False
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(212, 80)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Add record"
        Me.btnRecord.UseVisualStyleBackColor = True
        Me.btnRecord.Visible = False
        '
        'gbVitals
        '
        Me.gbVitals.Controls.Add(Me.Label3)
        Me.gbVitals.Controls.Add(Me.Label2)
        Me.gbVitals.Controls.Add(Me.lblHR)
        Me.gbVitals.Controls.Add(Me.lblVitals)
        Me.gbVitals.Controls.Add(Me.lblBP)
        Me.gbVitals.Controls.Add(Me.Label1)
        Me.gbVitals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVitals.Location = New System.Drawing.Point(540, 80)
        Me.gbVitals.Name = "gbVitals"
        Me.gbVitals.Size = New System.Drawing.Size(365, 291)
        Me.gbVitals.TabIndex = 5
        Me.gbVitals.TabStop = False
        Me.gbVitals.Text = "Current Vitals "
        Me.gbVitals.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Heart Rate:"
        '
        'lblHR
        '
        Me.lblHR.AutoSize = True
        Me.lblHR.BackColor = System.Drawing.Color.Transparent
        Me.lblHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHR.Location = New System.Drawing.Point(14, 158)
        Me.lblHR.Name = "lblHR"
        Me.lblHR.Padding = New System.Windows.Forms.Padding(5)
        Me.lblHR.Size = New System.Drawing.Size(10, 30)
        Me.lblHR.TabIndex = 0
        Me.lblHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVitals
        '
        Me.lblVitals.AutoSize = True
        Me.lblVitals.BackColor = System.Drawing.Color.Transparent
        Me.lblVitals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVitals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVitals.Location = New System.Drawing.Point(14, 243)
        Me.lblVitals.Name = "lblVitals"
        Me.lblVitals.Padding = New System.Windows.Forms.Padding(5)
        Me.lblVitals.Size = New System.Drawing.Size(10, 34)
        Me.lblVitals.TabIndex = 0
        Me.lblVitals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBP
        '
        Me.lblBP.AutoSize = True
        Me.lblBP.BackColor = System.Drawing.Color.Transparent
        Me.lblBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBP.Location = New System.Drawing.Point(14, 74)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Padding = New System.Windows.Forms.Padding(5)
        Me.lblBP.Size = New System.Drawing.Size(10, 30)
        Me.lblBP.TabIndex = 0
        Me.lblBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blood Pressure:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vitals"
        '
        'HomeNurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPatients)
        Me.Controls.Add(Me.gbVitals)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.btnDeleteP)
        Me.Controls.Add(Me.btnEditP)
        Me.Controls.Add(Me.btnAddP)
        Me.Controls.Add(Me.dgvPatients)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeNurse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeNurse"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVitals.ResumeLayout(False)
        Me.gbVitals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents btnAddP As Button
    Friend WithEvents btnEditP As Button
    Friend WithEvents btnDeleteP As Button
    Friend WithEvents lblPatients As Label
    Friend WithEvents btnRecord As Button
    Friend WithEvents gbVitals As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHR As Label
    Friend WithEvents lblVitals As Label
    Friend WithEvents lblBP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
