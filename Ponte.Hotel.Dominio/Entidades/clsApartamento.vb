Public Class clsApartamento

    Public Enum StatusApartamento
        Indisponivel = 1
        Disponivel = 0
    End Enum

    Private _id As Integer
    Private _capacidade As Integer
    Private _descricao As String
    Private _precoDiaria As Double
    Private _status As StatusApartamento

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Capacidade() As Integer
        Get
            Return _capacidade
        End Get
        Set(ByVal value As Integer)
            _capacidade = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property ValorDiaria() As Double
        Get
            Return _precoDiaria
        End Get
        Set(ByVal value As Double)
            _precoDiaria = value
        End Set
    End Property

    Public Property Status() As StatusApartamento
        Get
            Return _status
        End Get
        Set(ByVal value As StatusApartamento)
            _status = value
        End Set
    End Property

End Class
