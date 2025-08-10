Public Class clsNotaFiscal

    Private _id As Integer
    Private _codigo As String
    Private _dataNota As Date?
    Private _valorTotalNota As Double

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

    Public Property DataNota() As Date?
        Get
            Return _dataNota
        End Get
        Set(ByVal value As Date?)
            _dataNota = value
        End Set
    End Property

    Public Property ValorTotalNota() As Double
        Get
            Return _valorTotalNota
        End Get
        Set(ByVal value As Double)
            _valorTotalNota = value
        End Set
    End Property

End Class
