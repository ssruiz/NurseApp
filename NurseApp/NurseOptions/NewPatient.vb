Imports Backend

''' <summary>Controls the NewPatiente form.</summary>
Public Class NewPatient
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBP.KeyPress, txtHR.KeyPress, txtAge.KeyPress
        justNumbers(e)
    End Sub

    ''' <summary>The click event for the button save</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If controlInputs() Then
            Dim patient As New Patient
            patient.name = txtName.Text
            patient.age = Convert.ToDecimal(txtAge.Text)
            patient.bloodPressure = Convert.ToDecimal(txtBP.Text)
            patient.hearRate = Convert.ToDecimal(txtHR.Text)

            Dim daoPatient As New PatienteDAO
            daoPatient.save(patient)
            MsgBox("Patient added")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    ''' <summary>Validate the inputs. Not allows empty entrys</summary>
    Private Function controlInputs() As Boolean
        If (txtAge.Text <> "" And txtBP.Text <> "" And txtHR.Text <> "" And txtName.Text <> "") Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>Click event for cancel button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub
End Class