Imports Backend

Public Class Login
    Private Sub btnNurse_Click(sender As Object, e As EventArgs) Handles btnNurse.Click
        conexionNurse("nurse", "passnurse")

    End Sub

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

    Private Sub btnPatiente_Click(sender As Object, e As EventArgs) Handles btnPatiente.Click
        conexionPatients("patiente", "passwclients")
    End Sub
    Private Sub conexionPatients(user As String, passwd As String)
        Try
            Dim conectar As New Acceso
            conectar.login(user, passwd)
            Me.Visible = False

            Dim mdi As New HomeNurse

            mdi.Show()

        Catch ex As Exception

        End Try
    End Sub
End Class