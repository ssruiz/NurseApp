''' <summary>This class only is for simplify code</summary>
Public Class ConexionDB
    ''' <summary>Method that returns a string for the conection to the data base</summary>
    ''' <param name="user">name of the user</param>
    ''' <param name="passwd">password of the user</param>
    Public Shared Function cadenaConexionBD(ByVal user As String, ByVal passwd As String)
        Dim server As String = "localhost"
        Dim BD As String = "nurseappdb"
        Return String.Format("server={0};DataBase={1};User Id={2};Password={3}", server, BD, user, passwd)
    End Function
End Class
