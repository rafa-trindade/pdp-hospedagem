Public Class clsCliente

    Public Enum TipoCliente
        Cadastrado = 1
        Precadastrado = 0
    End Enum

    Private _id As Integer
    Private _nome As String
    Private _cpf As String
    Private _telefone As String
    Private _celular As String
    Private _email As String
    Private _dataCadastro As DateTime?
    Private _empresa As clsEmpresa
    Private _tipo As TipoCliente
    Private _placaCarro As String
    Private _ValorBase As Double

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Public Property PlacaCarro() As String
        Get
            Return _placaCarro
        End Get
        Set(ByVal value As String)
            _placaCarro = value
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

    Public Property Celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
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

    Public Property CPF() As String
        Get
            Return _cpf
        End Get
        Set(ByVal value As String)
            _cpf = value
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

    Public Property Empresa() As clsEmpresa
        Get
            Return _empresa
        End Get
        Set(ByVal value As clsEmpresa)
            _empresa = value
        End Set
    End Property

    Public Property Tipo() As TipoCliente
        Get
            Return _tipo
        End Get
        Set(ByVal value As TipoCliente)
            _tipo = value
        End Set
    End Property

    Public Property ValorBase() As Double
        Get
            Return _ValorBase
        End Get
        Set(ByVal value As Double)
            _ValorBase = value
        End Set
    End Property

End Class
