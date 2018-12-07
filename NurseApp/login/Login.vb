Imports Backend

''' <summary>Class that controls the login window</summary>
Public Class Login
    ''' <summary>click event for nurse button. It opens the Nurse form</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNurse_Click(sender As Object, e As EventArgs) Handles btnNurse.Click
        conexionNurse("nurse", "passnurse")

    End Sub

    ''' <summary>Metho to simplify the acces for a nurse</summary>
    ''' <param name="user"></param>
    ''' <param name="passwd"></param>
    Private Sub conexionNurse(user As String, passwd As String)
        Try
            Dim conectar As New Acceso
            conectar.login(user, passwd)
            Me.Visible = False

            Dim mdi As New HomeNurse

            mdi.Show()

        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>Click event for patient button. It shows the form of patient</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPatiente_Click(sender As Object, e As EventArgs) Handles btnPatiente.Click
        conexionPatients("patient", "passpatient")

    End Sub
    ''' <summary>Metho to simplify the acces for a patient</summary>
    ''' <param name="user"></param>
    ''' <param name="passwd"></param>
    Private Sub conexionPatients(user As String, passwd As String)
        Try
            Dim conectar As New Acceso
            conectar.login(user, passwd)
            Me.Visible = False

            Dim mdi As New HomePatient

            mdi.Show()

        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>Click event for the exit button. It close the app</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class