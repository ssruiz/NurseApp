Imports Backend

''' <summary>Class that controls de form for Edit Patient</summary>
Public Class EditPatient
    Public patient As New Patient
    ''' <summary>This method is executed when the form is loaded</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadPatientDefault()
        Catch ex As Exception
            MsgBox("Error happens")
        End Try
    End Sub

    ''' <summary>Method that load the unediting values of patient</summary>
    Private Sub loadPatientDefault()
        txtAge.Text = patient.age
        txtName.Text = patient.name
        txtBP.Text = patient.bloodPressure
        txtHR.Text = patient.hearRate
    End Sub

    ''' <summary>Click event for reset button. It resets the defaults values of the patient</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        loadPatientDefault()
    End Sub

    ''' <summary>Click event for cancel button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    ''' <summary>Click event for save button. It updates the information of the patient</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>Method that controls only number are typing on Heart rate and Blood pressure fields</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress, txtHR.KeyPress, txtAge.KeyPress
        justNumbers(e)
    End Sub

    ''' <summary>This validated the inputs</summary>
    Private Function controlInputs() As Boolean
        If (txtAge.Text <> "" And txtBP.Text <> "" And txtHR.Text <> "" And txtName.Text <> "") Then
            Return True
        End If
        Return False
    End Function
End Class