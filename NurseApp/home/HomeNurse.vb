Imports Backend

''' <summary>Class that controls the form that a nurse can see</summary>
Public Class HomeNurse
    ''' <summary>This method allows to show the login window once this form is closed</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>Charge the list of patients</summary>
    ''' <param name="sender">the call</param>
    ''' <param name="e">event</param>
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
            btnRecord.Visible = True
            gbVitals.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>Method for new patient button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddP_Click(sender As Object, e As EventArgs) Handles btnAddP.Click
        Try
            Dim addP As New NewPatient
            addP.ShowDialog()

            loadPatients()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>Click method for edit button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>this method load all patients registered</summary>
    Private Sub loadPatients()
        Dim daoP As New PatienteDAO
        Dim list = daoP.loadPatients()
        dgvPatients.DataSource = list.Tables("tabla")
        dgvPatients.Columns("ID").Visible = False
    End Sub

    ''' <summary>Click event for delete button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteP_Click(sender As Object, e As EventArgs) Handles btnDeleteP.Click
        Try
            If dgvPatients.SelectedRows.Count > 0 Then
                Dim patient As New Patient
                Dim row = dgvPatients.CurrentRow.Index
                patient.id = dgvPatients.Item(0, row).Value
                patient.name = dgvPatients.Item(1, row).Value
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete the patient " + patient.name + "? All records from this patient will be delete too. This action cannot be undone", "Deleting Patient", MessageBoxButtons.YesNo)
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

    ''' <summary>Metho for click event of new record button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Try
            If dgvPatients.SelectedRows.Count > 0 Then
                Dim patient As New Patient
                Dim row = dgvPatients.CurrentRow.Index
                patient.id = dgvPatients.Item(0, row).Value
                patient.name = dgvPatients.Item(1, row).Value
                patient.age = dgvPatients.Item(2, row).Value
                patient.bloodPressure = dgvPatients.Item(3, row).Value
                patient.hearRate = dgvPatients.Item(4, row).Value

                Dim addR As New AddRecord
                addR.patient = patient
                addR.ShowDialog()
                loadPatients()
            Else
                MsgBox("Select a patient to edit", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ''' <summary>This method controls when de datagrid has changed the index of the row selected</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvPatients_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPatients.SelectionChanged
        Try
            If dgvPatients.SelectedRows.Count > 0 Then
                Dim row = dgvPatients.CurrentRow.Index
                Dim patient As New Patient
                Dim daoP As New PatienteDAO
                patient = daoP.currentVitals(dgvPatients.Item(0, row).Value)
                checkBloodPressure(patient)
                checkHeartRate(patient)
                checkVitals()
            Else
                lblBP.BackColor = Color.Transparent
                lblHR.BackColor = Color.Transparent
                lblVitals.BackColor = Color.Transparent
                lblBP.Text = ""
                lblHR.Text = ""
                lblVitals.Text = ""
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>Show the current blood pressure of the patient and display in colors depending of the values</summary>
    ''' <param name="patient">Patient's data</param>
    Private Sub checkBloodPressure(ByVal patient As Patient)
        If patient.bloodPressure <= 50 Then
            lblBP.BackColor = Color.ForestGreen
            lblBP.Text = patient.bloodPressure.ToString + ". Blood Pressure is good"
        ElseIf patient.bloodPressure < 100 Then
            lblBP.BackColor = Color.DarkOrange
            lblBP.Text = patient.bloodPressure.ToString + ". Blood Pressure is a bit high"
        Else
            lblBP.BackColor = Color.Red
            lblBP.Text = patient.bloodPressure.ToString + ". Blood Pressure is very high!"
        End If
    End Sub

    ''' <summary>Show the current hear rate of the patient and display in colors depending of the values</summary>
    ''' <param name="patient">patient's data</param>
    Private Sub checkHeartRate(ByVal patient As Patient)
        If patient.hearRate <= 50 Then
            lblHR.BackColor = Color.ForestGreen
            lblHR.Text = patient.hearRate.ToString + ". Blood Pressure is good"
        ElseIf patient.hearRate < 100 Then
            lblHR.BackColor = Color.DarkOrange
            lblHR.Text = patient.hearRate.ToString + ". Blood Pressure is a bit high"
        Else
            lblHR.BackColor = Color.Red
            lblHR.Text = patient.hearRate.ToString + ". Blood Pressure is very high!"
        End If
    End Sub

    ''' <summary>Show the current vitals of the patient and display in colors depending of the values</summary>
    Private Sub checkVitals()
        If lblBP.BackColor = Color.ForestGreen And lblHR.BackColor = Color.ForestGreen Then
            lblVitals.BackColor = Color.ForestGreen
            lblVitals.Text = "Vitals are ok"
        ElseIf lblBP.BackColor = Color.Red And lblHR.BackColor = Color.Red Then
            lblVitals.BackColor = Color.Red
            lblVitals.Text = "Vitals are very bad"
        Else
            lblVitals.BackColor = Color.DarkOrange
            lblVitals.Text = "Vitals are regular"
        End If
    End Sub

    ''' <summary>Click event for the exit menustripItem</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub
End Class