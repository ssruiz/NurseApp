Imports Backend

''' <summary>Class that controls the form for adding records of patients</summary>
Public Class AddRecord
    Public patient As New Patient
    ''' <summary>Method that is executed when the form is loaded</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = patient.name
        txtAge.Text = patient.age
        txtAge.Enabled = False
    End Sub

    ''' <summary>Method that controls only number are typing on Heart rate and Blood pressure fields</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress, txtHR.KeyPress, txtAge.KeyPress
        justNumbers(e)
    End Sub

    ''' <summary>Click event for cancel button. It closes the add record form</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    ''' <summary>Method that save the record</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>Method that validates the inputs</summary>
    Private Function controlInputs() As Boolean
        If (txtAge.Text <> "" And txtBP.Text <> "" And txtHR.Text <> "" And txtName.Text <> "") Then
            Return True
        End If
        Return False
    End Function
End Class