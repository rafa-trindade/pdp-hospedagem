Public Class clsVale

    Private _id As Integer
    Private _funcionario As clsFuncionario
    Private _dataVale As DateTime
    Private _valorVale As Double

    Public Property ValorVale() As Double
        Get
            Return _valorVale
        End Get
        Set(ByVal value As Double)
            _valorVale = value
        End Set
    End Property

    Public Property DataVale() As DateTime
        Get
            Return _dataVale
        End Get
        Set(ByVal value As DateTime)
            _dataVale = value
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

    Public Property Funcionario() As clsFuncionario
        Get
            Return _funcionario
        End Get
        Set(ByVal value As clsFuncionario)
            _funcionario = value
        End Set
    End Property

End Class
