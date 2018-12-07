﻿Imports MySql.Data.MySqlClient


Public Class Acceso
    Public Sub login(ByVal user As String, ByVal passwd As String)

        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(user, passwd))
            con.Open()

            con.Close()


        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 1042
                    Throw New DAOException("No se puede acceder al servidor." & vbCrLf & "Contacte al administrator.")
                Case 1045
                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "intente de nuevo.")
                Case 0

                    Throw New DAOException("Usuario o contraseña incorrectos." & vbCrLf & "intente de nuevo.")
            End Select
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

End Class