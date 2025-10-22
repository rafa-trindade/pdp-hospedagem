Imports Ponte.Hotel.Dominio

Public Class clsHospedagem

    Public Enum StatusCheckout
        Aberto = 1
        Fechado = 0
    End Enum

    Public Enum TipoHospedagem
        Avulsa = 1
        Normal = 0
    End Enum

    Private _id As Integer
    Private _codigo As String
    Private _dataEntrada As DateTime
    Private _dataSaida As DateTime?
    Private _qtdDiarias As Integer
    Private _cliente As clsCliente
    Private _apartamento As clsApartamento
    Private _desconto As Double
    Private _valorTotal As Double
    Private _sinal As Double
    Private _valorPago As Double
    Private _status As StatusCheckout
    Private _tipoHospedagem As TipoHospedagem
    Private _reserva As clsReserva
    Private _movimentacao As clsMovimentacao
    Private _valorDiaria As Double
    Private _qtdPessoas As Integer
    Private _observacao As String

    Public Property Obeservacao() As String
        Get
            Return _observacao
        End Get
        Set(ByVal value As String)
            _observacao = value
        End Set
    End Property

    Public Property QuantidadePessoas() As Integer
        Get
            Return _qtdPessoas
        End Get
        Set(ByVal value As Integer)
            _qtdPessoas = value
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

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

    Public Property DataSaida() As DateTime?
        Get
            Return _dataSaida
        End Get
        Set(ByVal value As DateTime?)
            _dataSaida = value
        End Set
    End Property

    Public Property QuantidadeDiaria() As Integer
        Get
            Return _qtdDiarias
        End Get
        Set(ByVal value As Integer)
            _qtdDiarias = value
        End Set
    End Property

    Public Property Apartamento() As clsApartamento
        Get
            Return _apartamento
        End Get
        Set(ByVal value As clsApartamento)
            _apartamento = value
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

    Public Property Desconto() As Double
        Get
            Return _desconto
        End Get
        Set(ByVal value As Double)
            _desconto = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return _valorTotal
        End Get
        Set(ByVal value As Double)
            _valorTotal = value
        End Set
    End Property

    Public Property Sinal() As Double
        Get
            Return _sinal
        End Get
        Set(ByVal value As Double)
            _sinal = value
        End Set
    End Property

    Public Property ValorPago() As Double
        Get
            Return _valorPago
        End Get
        Set(ByVal value As Double)
            _valorPago = value
        End Set
    End Property

    Public Property Status() As StatusCheckout
        Get
            Return _status
        End Get
        Set(ByVal value As StatusCheckout)
            _status = value
        End Set
    End Property

    Public Property Tipo() As TipoHospedagem
        Get
            Return _tipoHospedagem
        End Get
        Set(ByVal value As TipoHospedagem)
            _tipoHospedagem = value
        End Set
    End Property

    Public Property Reserva() As clsReserva
        Get
            Return _reserva
        End Get
        Set(ByVal value As clsReserva)
            _reserva = value
        End Set
    End Property

    Public Property Movimentacao() As clsMovimentacao
        Get
            Return _movimentacao
        End Get
        Set(ByVal value As clsMovimentacao)
            _movimentacao = value
        End Set
    End Property

    Public Property ValorDiaria() As Double
        Get
            Return _valorDiaria
        End Get
        Set(ByVal value As Double)
            _valorDiaria = value
        End Set
    End Property

End Class
