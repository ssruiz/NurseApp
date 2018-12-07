Imports Backend

Public Class AddRecord
    Public patient As New Patient
    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = patient.name
        txtAge.Text = patient.age
        txtAge.Enabled = False
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress, txtHR.KeyPress, txtAge.KeyPress
        justNumbers(e)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If controlInputs() Then
                Dim newRecord As New Patient
                newRecord.id = Convert.ToDecimal(patient.id)
                newRecord.name = txtName.Text
                newRecord.age = Convert.ToDecimal(txtAge.Text)
                newRecord.bloodPressure = Convert.ToDecimal(txtBP.Text)
                newRecord.hearRate = Convert.ToDecimal(txtHR.Text)
                Dim daoP As New PatienteDAO
                daoP.newRecord(newRecord)
                MsgBox("Patient Record Added!", MsgBoxStyle.Information)
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Complete all the inputs", MsgBoxStyle.Critical)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function controlInputs() As Boolean
        If (txtAge.Text <> "" And txtBP.Text <> "" And txtHR.Text <> "" And txtName.Text <> "") Then
            Return True
        End If
        Return False
    End Function
End Class