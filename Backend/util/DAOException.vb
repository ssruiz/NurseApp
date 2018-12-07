''' <summary>A exception class that is used in exceptions calls</summary>
Public Class DAOException
    Inherits System.ApplicationException

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class
