Public Class Patient
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _age As Integer
    Public Property age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property

    Private _bloodPressure As Integer
    Public Property bloodPressure() As Integer
        Get
            Return _bloodPressure
        End Get
        Set(ByVal value As Integer)
            _bloodPressure = value
        End Set
    End Property

    Private _hearRate As Integer
    Public Property hearRate() As Integer
        Get
            Return _hearRate
        End Get
        Set(ByVal value As Integer)
            _hearRate = value
        End Set
    End Property
End Class