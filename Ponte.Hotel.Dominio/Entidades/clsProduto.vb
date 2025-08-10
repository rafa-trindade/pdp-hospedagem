Public Class clsProduto

    Public Enum StatusProd
        Ativo = 1
        Inativo = 0
    End Enum

    Private _id As Integer
    Private _codigo As String
    Private _nome As String
    Private _descricao As String
    Private _precoVenda As Double
    Private _precoCompra As Double
    Private _lucro As Double
    Private _quantidadeEstoque As Integer
    Private _estoqueMinimo As Integer
    Private _status As StatusProd
    Private _tipoProduto As clsTipoProduto

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

    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
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

    Public Property PrecoVenda() As Double
        Get
            Return _precoVenda
        End Get
        Set(ByVal value As Double)
            _precoVenda = value
        End Set
    End Property

    Public Property PrecoCompra() As Double
        Get
            Return _precoCompra
        End Get
        Set(ByVal value As Double)
            _precoCompra = value
        End Set
    End Property

    Public Property Lucro() As Double
        Get
            Return _lucro
        End Get
        Set(ByVal value As Double)
            _lucro = value
        End Set
    End Property

    Public Property QuantidadeEstoque() As Integer
        Get
            Return _quantidadeEstoque
        End Get
        Set(ByVal value As Integer)
            _quantidadeEstoque = value
        End Set
    End Property

    Public Property EstoqueMinimo() As Integer
        Get
            Return _estoqueMinimo
        End Get
        Set(ByVal value As Integer)
            _estoqueMinimo = value
        End Set
    End Property

    Public Property Status() As StatusProd
        Get
            Return _status
        End Get
        Set(ByVal value As StatusProd)
            _status = value
        End Set
    End Property

    Public Property TipoProduto() As clsTipoProduto
        Get
            Return _tipoProduto
        End Get
        Set(ByVal value As clsTipoProduto)
            _tipoProduto = value
        End Set
    End Property

End Class
