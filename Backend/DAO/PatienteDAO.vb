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
            Dim query = "INSERT INTO `nurseappdb`.`patiente` ( `name_patiente`, `age_patiente`, `bloodp_patiente`, `heartrate_patiente`) VALUES (@name, @age, @bp, @hr); SELECT LAST_INSERT_ID();"

            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", patient.name)
            cmd.Parameters.AddWithValue("@age", patient.age)
            cmd.Parameters.AddWithValue("@bp", patient.bloodPressure)
            cmd.Parameters.AddWithValue("@hr", patient.hearRate)
            Dim patientID = CInt(cmd.ExecuteScalar)

            Dim query1 = "INSERT INTO `nurseappdb`.`patientrecord` (`id_patient`, `bloodp`, `heartrate`) VALUES (@id, @bp, @hr);"

            Dim cmd1 As New MySqlCommand(query1, con)
            cmd1.Parameters.AddWithValue("@id", patientID)
            cmd1.Parameters.AddWithValue("@bp", patient.bloodPressure)
            cmd1.Parameters.AddWithValue("@hr", patient.hearRate)

            cmd1.ExecuteNonQuery()
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
            Dim query1 = "DELETE FROM `nurseappdb`.`patientrecord` WHERE `id_patient` = @id ;"
            Dim query = "DELETE FROM `nurseappdb`.`patiente` WHERE `id_patiente` = @id;"

            Dim cmd As New MySqlCommand(query, con)
            Dim cmd1 As New MySqlCommand(query1, con)
            cmd.Parameters.AddWithValue("@id", patient)
            cmd1.Parameters.AddWithValue("@id", patient)
            cmd1.ExecuteNonQuery()
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Sub newRecord(ByVal patient As Patient)
        Dim id = 0
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "INSERT INTO `nurseappdb`.`patientrecord` (`id_patient`, `bloodp`, `heartrate`) VALUES (@id, @bp, @hr);"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", patient.id)
            cmd.Parameters.AddWithValue("@bp", patient.bloodPressure)
            cmd.Parameters.AddWithValue("@hr", patient.hearRate)

            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Public Function currentVitals(ByVal patient As Integer) As Patient
        Dim ds As New DataSet
        Dim adp
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD("nurse", "passnurse"))
            con.Open()
            Dim query = "SELECT * FROM `patientrecord`  where `id_patient` = @id ORDER BY `date` DESC LIMIT 1;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", patient)
            Dim reader = cmd.ExecuteReader()
            Dim data As New Patient
            While reader.Read
                data.id = SafeGetInt(reader, 0)
                data.bloodPressure = SafeGetInt(reader, 1)
                data.hearRate = SafeGetString(reader, 2)
            End While
            Return data
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function
End Class
