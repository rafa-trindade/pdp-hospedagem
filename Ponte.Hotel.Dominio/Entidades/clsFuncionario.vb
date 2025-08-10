Public Class clsFuncionario

    Public Enum StatusFunc
        Ativo = 1
        Inativo = 0
    End Enum

    Private _id As Integer
    Private _nome As String
    Private _telefone As String
    Private _email As String
    Private _dataAdmissao As DateTime?
    Private _funcao As String
    Private _salarioBase As Double
    Private _status As StatusFunc

    Public Property Status() As StatusFunc
        Get
            Return _status
        End Get
        Set(ByVal value As StatusFunc)
            _status = value
        End Set
    End Property

    Public Property SalarioBase() As Double
        Get
            Return _salarioBase
        End Get
        Set(ByVal value As Double)
            _salarioBase = value
        End Set
    End Property

    Public Property Funcao() As String
        Get
            Return _funcao
        End Get
        Set(ByVal value As String)
            _funcao = value
        End Set
    End Property

    Public Property DataAdmissao() As DateTime?
        Get
            Return _dataAdmissao
        End Get
        Set(ByVal value As DateTime?)
            _dataAdmissao = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
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

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
