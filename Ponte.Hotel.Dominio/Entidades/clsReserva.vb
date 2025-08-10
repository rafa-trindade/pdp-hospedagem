Public Class clsReserva

    Public Enum StatusRes
        Solcitada = 2 'Em Aberto
        Confirmada = 1
        Cancelada = 0
    End Enum

    Public Enum SinalPagamento
        Pago = 1
        Pendente = 0
    End Enum

    Public Enum OrigemReseva
        Sistema = 1
        Site = 0
    End Enum

    Private _id As Integer
    Private _codigo As String
    Private _dataCadastro As DateTime
    Private _dataEntrada As DateTime
    Private _qtdPessoas As Integer
    Private _valorSinal As Double
    Private _statusSinal As SinalPagamento
    Private _statusReserva As StatusRes
    Private _cliente As clsCliente
    Private _origem As OrigemReseva

    Public Property Origem() As OrigemReseva
        Get
            Return _origem
        End Get
        Set(ByVal value As OrigemReseva)
            _origem = value
        End Set
    End Property

    Public Property Cliente() As clsCliente
        Get
            Return _cliente
        End Get
        Set(ByVal value As clsCliente)
            _cliente = value
        End Set
    End Property

    Public Property StatusReserva() As StatusRes
        Get
            Return _statusReserva
        End Get
        Set(ByVal value As StatusRes)
            _statusReserva = value
        End Set
    End Property

    Public Property StatusSinal() As SinalPagamento
        Get
            Return _statusSinal
        End Get
        Set(ByVal value As SinalPagamento)
            _statusSinal = value
        End Set
    End Property

    Public Property ValorSinal() As Double
        Get
            Return _valorSinal
        End Get
        Set(ByVal value As Double)
            _valorSinal = value
        End Set
    End Property

    Public Property QtdPessoas() As Integer
        Get
            Return _qtdPessoas
        End Get
        Set(ByVal value As Integer)
            _qtdPessoas = value
        End Set
    End Property

    Public Property DataEntrada() As DateTime
        Get
            Return _dataEntrada
        End Get
        Set(ByVal value As DateTime)
            _dataEntrada = value
        End Set
    End Property

    Public Property DataCadastro() As DateTime
        Get
            Return _dataCadastro
        End Get
        Set(ByVal value As DateTime)
            _dataCadastro = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
