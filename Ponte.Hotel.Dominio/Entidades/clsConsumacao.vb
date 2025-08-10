Public Class clsConsumacao

    Public Enum TipoConsumacao
        Hospedagem = 1
        Avulsa = 0
    End Enum

    Private _id As Integer
    Private _produto As clsProduto
    Private _hospedagem As clsHospedagem
    Private _qtdProduto As Integer
    Private _valorTotalConsumo As Double
    Private _movimentacao As clsMovimentacao
    Private _valorProduto As Double
    Private _precoCompra As Double
    Private _tipoConsumacao As TipoConsumacao
    Private _dataConsumacao As Date?

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Produto() As clsProduto
        Get
            Return _produto
        End Get
        Set(ByVal value As clsProduto)
            _produto = value
        End Set
    End Property

    Public Property Hospedagem() As clsHospedagem
        Get
            Return _hospedagem
        End Get
        Set(ByVal value As clsHospedagem)
            _hospedagem = value
        End Set
    End Property

    Public Property QtdProduto() As Integer
        Get
            Return _qtdProduto
        End Get
        Set(ByVal value As Integer)
            _qtdProduto = value
        End Set
    End Property

    Public Property ValorTotalConsumo() As Double
        Get
            Return _valorTotalConsumo
        End Get
        Set(ByVal value As Double)
            _valorTotalConsumo = value
        End Set
    End Property

    Public Property ValorProduto() As Double
        Get
            Return _valorProduto
        End Get
        Set(ByVal value As Double)
            _valorProduto = value
        End Set
    End Property

    Public Property PrecoCompraProduto() As Double
        Get
            Return _precoCompra
        End Get
        Set(ByVal value As Double)
            _precoCompra = value
        End Set
    End Property


    Public Property Tipo() As TipoConsumacao
        Get
            Return _tipoConsumacao
        End Get
        Set(ByVal value As TipoConsumacao)
            _tipoConsumacao = value
        End Set
    End Property


    Public Property DataConsumacao() As Date?
        Get
            Return _dataConsumacao
        End Get
        Set(ByVal value As Date?)
            _dataConsumacao = value
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

End Class
