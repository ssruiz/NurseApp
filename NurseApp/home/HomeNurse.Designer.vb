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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPatients.Location = New System.Drawing.Point(68, 103)
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.RowHeadersVisible = False
        Me.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatients.Size = New System.Drawing.Size(564, 256)
        Me.dgvPatients.TabIndex = 1
        Me.dgvPatients.Visible = False
        '
        'btnAddP
        '
        Me.btnAddP.Location = New System.Drawing.Point(68, 68)
        Me.btnAddP.Name = "btnAddP"
        Me.btnAddP.Size = New System.Drawing.Size(75, 23)
        Me.btnAddP.TabIndex = 2
        Me.btnAddP.Text = "New Patient"
        Me.btnAddP.UseVisualStyleBackColor = True
        Me.btnAddP.Visible = False
        '
        'btnEditP
        '
        Me.btnEditP.Location = New System.Drawing.Point(160, 68)
        Me.btnEditP.Name = "btnEditP"
        Me.btnEditP.Size = New System.Drawing.Size(75, 23)
        Me.btnEditP.TabIndex = 2
        Me.btnEditP.Text = "Edit Patient"
        Me.btnEditP.UseVisualStyleBackColor = True
        Me.btnEditP.Visible = False
        '
        'btnDeleteP
        '
        Me.btnDeleteP.Location = New System.Drawing.Point(254, 68)
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
        Me.lblPatients.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatients.Location = New System.Drawing.Point(250, 24)
        Me.lblPatients.Name = "lblPatients"
        Me.lblPatients.Size = New System.Drawing.Size(184, 22)
        Me.lblPatients.TabIndex = 3
        Me.lblPatients.Text = "LIST OF PATIENTS"
        Me.lblPatients.Visible = False
        '
        'HomeNurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 401)
        Me.Controls.Add(Me.lblPatients)
        Me.Controls.Add(Me.btnDeleteP)
        Me.Controls.Add(Me.btnEditP)
        Me.Controls.Add(Me.btnAddP)
        Me.Controls.Add(Me.dgvPatients)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeNurse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeNurse"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
