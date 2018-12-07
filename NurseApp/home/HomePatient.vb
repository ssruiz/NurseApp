Imports Backend

''' <summary>Class that controls the form wich patient can see</summary>
Public Class HomePatient
    ''' <summary>Click event for save button</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim patient = txtName.Text
            Dim daoP As New PatienteDAO
            Dim list = daoP.loadPatient(patient)
            If list.Tables("tabla").Rows.Count > 0 Then
                msPatient.Visible = True
                dgvRecords.Visible = True
                dgvRecords.DataSource = list.Tables("tabla")
                dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvRecords.Columns("ID").Visible = False
                lblName.Text = "Your records"
            Else
                MsgBox("That name does not exists in the database", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>Allows to show the login window when this window is closed</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub

    ''' <summary>To exit the form</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    ''' <summary>Click event of cancel button. It closes the form</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class