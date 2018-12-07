Imports Backend

Public Class EditPatient
    Public patient As New Patient
    Private Sub EditPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadPatientDefault()
        Catch ex As Exception
            MsgBox("Error happens")
        End Try
    End Sub

    Private Sub loadPatientDefault()
        txtAge.Text = patient.age
        txtName.Text = patient.name
        txtBP.Text = patient.bloodPressure
        txtHR.Text = patient.hearRate
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        loadPatientDefault()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If controlInputs() Then
                Dim editedPatient As New Patient
                editedPatient.id = patient.id
                editedPatient.name = txtName.Text
                editedPatient.age = Convert.ToDecimal(txtAge.Text)
                editedPatient.bloodPressure = Convert.ToDecimal(txtBP.Text)
                editedPatient.hearRate = Convert.ToDecimal(txtHR.Text)
                Dim daoP As New PatienteDAO
                daoP.update(editedPatient)
                MsgBox("Patient Edited!", MsgBoxStyle.Information)
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Complete all the inputs", MsgBoxStyle.Critical)

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress, txtHR.KeyPress, txtAge.KeyPress
        justNumbers(e)
    End Sub

    Private Function controlInputs() As Boolean
        If (txtAge.Text <> "" And txtBP.Text <> "" And txtHR.Text <> "" And txtName.Text <> "") Then
            Return True
        End If
        Return False
    End Function
End Class