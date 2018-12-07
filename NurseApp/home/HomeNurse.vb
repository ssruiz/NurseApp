Imports Backend

Public Class HomeNurse
    Private Sub PatientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientesToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Try
            loadPatients()
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPatients.Columns("ID").Visible = False
            btnAddP.Visible = True
            btnDeleteP.Visible = True
            btnEditP.Visible = True
            lblPatients.Visible = True
            dgvPatients.Visible = True
            lblPatients.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddP_Click(sender As Object, e As EventArgs) Handles btnAddP.Click
        Try
            Dim addP As New NewPatient
            addP.ShowDialog()

            loadPatients()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditP_Click(sender As Object, e As EventArgs) Handles btnEditP.Click
        Try
            If dgvPatients.SelectedRows.Count > 0 Then
                Dim patient As New Patient
                Dim row = dgvPatients.CurrentRow.Index
                patient.id = dgvPatients.Item(0, row).Value
                patient.name = dgvPatients.Item(1, row).Value
                patient.age = dgvPatients.Item(2, row).Value
                patient.bloodPressure = dgvPatients.Item(3, row).Value
                patient.hearRate = dgvPatients.Item(4, row).Value

                Dim editP As New EditPatient
                editP.patient = patient
                editP.ShowDialog()
                loadPatients()
            Else
                MsgBox("Select a patient to edit", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub loadPatients()
        Dim daoP As New PatienteDAO
        Dim list = daoP.loadPatients()
        dgvPatients.DataSource = list.Tables("tabla")
        dgvPatients.Columns("ID").Visible = False
    End Sub

    Private Sub btnDeleteP_Click(sender As Object, e As EventArgs) Handles btnDeleteP.Click
        Try
            If dgvPatients.SelectedRows.Count > 0 Then
                Dim patient As New Patient
                Dim row = dgvPatients.CurrentRow.Index
                patient.id = dgvPatients.Item(0, row).Value
                patient.name = dgvPatients.Item(1, row).Value
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete the patient " + patient.name + "? This action cannot be undone", "Deleting Patient", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim daoP As New PatienteDAO
                    daoP.delete(patient.id)
                    MsgBox("Patient deleted from data base", MsgBoxStyle.Information)
                    loadPatients()
                End If
            Else
                MsgBox("Select a patient to delete", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class