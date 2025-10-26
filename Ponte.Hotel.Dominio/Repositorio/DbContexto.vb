Imports System.Configuration
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports Ponte.Hotel.Dominio

Public Class DbContexto
    Inherits DbContext

    Public Sub New()
        MyBase.New("Data Source=localhost,1433;Initial Catalog=PousadaDaPonte;User ID=rafael;Password=260985Rt;")
        'MyBase.New("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=PousadaDaPonte;")

    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Private m_Cliente As DbSet(Of clsCliente)
    Private m_Empresa As DbSet(Of clsEmpresa)
    Private m_Apartamento As DbSet(Of clsApartamento)
    Private m_Produto As DbSet(Of clsProduto)
    Private m_TipoProduto As DbSet(Of clsTipoProduto)
    Private m_Hospedagem As DbSet(Of clsHospedagem)
    Private m_Consumacao As DbSet(Of clsConsumacao)
    Private m_Reserva As DbSet(Of clsReserva)
    Private m_Movimentacao As DbSet(Of clsMovimentacao)

    Public Property Cliente() As DbSet(Of clsCliente)
        Get
            Return m_Cliente
        End Get
        Set(value As DbSet(Of clsCliente))
            m_Cliente = value
        End Set
    End Property

    Public Property Empresa() As DbSet(Of clsEmpresa)
        Get
            Return m_Empresa
        End Get
        Set(value As DbSet(Of clsEmpresa))
            m_Empresa = value
        End Set
    End Property

    Public Property Apartamento() As DbSet(Of clsApartamento)
        Get
            Return m_Apartamento
        End Get
        Set(value As DbSet(Of clsApartamento))
            m_Apartamento = value
        End Set
    End Property

    Public Property Produto() As DbSet(Of clsProduto)
        Get
            Return m_Produto
        End Get
        Set(value As DbSet(Of clsProduto))
            m_Produto = value
        End Set
    End Property

    Public Property TipoProduto() As DbSet(Of clsTipoProduto)
        Get
            Return m_TipoProduto
        End Get
        Set(value As DbSet(Of clsTipoProduto))
            m_TipoProduto = value
        End Set
    End Property

    Public Property Hospedagem() As DbSet(Of clsHospedagem)
        Get
            Return m_hospedagem
        End Get
        Set(value As DbSet(Of clsHospedagem))
            m_hospedagem = value
        End Set
    End Property

    Public Property Consumacao() As DbSet(Of clsConsumacao)
        Get
            Return m_Consumacao
        End Get
        Set(value As DbSet(Of clsConsumacao))
            m_Consumacao = value
        End Set
    End Property

    Public Property Reserva() As DbSet(Of clsReserva)
        Get
            Return m_Reserva
        End Get
        Set(value As DbSet(Of clsReserva))
            m_Reserva = value
        End Set
    End Property

    Public Property Movimentacao() As DbSet(Of clsMovimentacao)
        Get
            Return m_Movimentacao
        End Get
        Set(value As DbSet(Of clsMovimentacao))
            m_Movimentacao = value
        End Set
    End Property

End Class
