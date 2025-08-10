Public Class clsEmpresa

    Private _id As Integer
    Private _codigo As String
    Private _nomeFantasia As String
    Private _razaoSocial As String
    Private _cpfcnpj As String
    Private _telefone As String
    Private _celular As String
    Private _email As String
    Private _responsavel As String


    Public Property Celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Public Property Responsavel() As String
        Get
            Return _responsavel
        End Get
        Set(ByVal value As String)
            _responsavel = value
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

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property RazaoSocial() As String
        Get
            Return _razaoSocial
        End Get
        Set(ByVal value As String)
            _razaoSocial = value
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


    Public Property CPF_CNPJ() As String
        Get
            Return _cpfcnpj
        End Get
        Set(ByVal value As String)
            _cpfcnpj = value
        End Set
    End Property

    Public Property NomeFantasia() As String
        Get
            Return _nomeFantasia
        End Get
        Set(ByVal value As String)
            _nomeFantasia = value
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
