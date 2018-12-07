Imports MySql.Data.MySqlClient

''' <summary>Class that have some usefull functions</summary>
Module Funcitions


    ''' <summary>This method helps to read safety a String from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetString(ByRef reader As MySqlDataReader, ByVal Index As Integer) As String
        If Not reader.IsDBNull(Index) Then
            Return reader.GetString(Index)
        End If
        Return String.Empty
    End Function

    ''' <summary>This method helps to read safety a int from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetInt(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Integer
        If Not reader.IsDBNull(Index) Then
            Return reader.GetInt32(Index)
        End If
        Return 0
    End Function

    ''' <summary>This method helps to read safety a timespam from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetTimeSpam(ByRef reader As MySqlDataReader, ByVal Index As Integer) As TimeSpan
        If Not reader.IsDBNull(Index) Then
            Return reader.GetTimeSpan(Index)
        End If
        Return Nothing
    End Function
    ''' <summary>This method helps to read safety a Date from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetDate(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Date
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDateTime(Index)
        End If
        Return Nothing
    End Function

    ''' <summary>This method helps to read safety a Double from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetDouble(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Double
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDouble(Index)
        End If
        Return CDbl(0)
    End Function

    ''' <summary>This method helps to read safety a decimal from database</summary>
    ''' <param name="reader"></param>
    ''' <param name="Index"></param>
    Public Function SafeGetDecimal(ByRef reader As MySqlDataReader, ByVal Index As Integer) As Decimal
        If Not reader.IsDBNull(Index) Then
            Return reader.GetDecimal(Index)
        End If
        Return CDec(0)
    End Function


End Module