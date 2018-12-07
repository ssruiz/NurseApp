Imports MySql.Data.MySqlClient

Public Class PatienteDAO
    Public Function loadPatients() As DataSet
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "SELECT * FROM listpatients"
            adp = New MySqlDataAdapter(query, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
            Return ds

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return adp
    End Function
    Public Sub save(ByVal patient As Patient)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "INSERT INTO `nurseappdb`.`patiente` ( `name_patiente`, `age_patiente`, `bloodp_patiente`, `heartrate_patiente`) VALUES (@name, @age, @bp, @hr);"

            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", patient.name)
            cmd.Parameters.AddWithValue("@age", patient.age)
            cmd.Parameters.AddWithValue("@bp", patient.bloodPressure)
            cmd.Parameters.AddWithValue("@hr", patient.hearRate)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub update(ByVal patient As Patient)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "UPDATE `nurseappdb`.`patiente` SET `name_patiente` = @name , `age_patiente` = @age, `bloodp_patiente` = @bp, `heartrate_patiente` = @hr WHERE `id_patiente` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", patient.id)
            cmd.Parameters.AddWithValue("@name", patient.name)
            cmd.Parameters.AddWithValue("@age", patient.age)
            cmd.Parameters.AddWithValue("@bp", patient.bloodPressure)
            cmd.Parameters.AddWithValue("@hr", patient.hearRate)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub delete(ByVal patient As Integer)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "DELETE FROM `nurseappdb`.`patiente` WHERE `id_patiente` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", patient)
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub
End Class
