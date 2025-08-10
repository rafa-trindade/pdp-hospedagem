Public Class clsMovimentacao

    Public Enum TipoMovimentacao
        Entrada = 1
        Saida = 0
    End Enum

    Private _id As Integer
    Private _dataMovimentacao As DateTime
    Private _descricao As String
    Private _valor As Double
    Private _tipo As TipoMovimentacao

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property DataMovimentacao() As DateTime
        Get
            Return _dataMovimentacao
        End Get
        Set(ByVal value As DateTime)
            _dataMovimentacao = value
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

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property Tipo() As TipoMovimentacao
        Get
            Return _tipo
        End Get
        Set(ByVal value As TipoMovimentacao)
            _tipo = value
        End Set
    End Property

End Class
