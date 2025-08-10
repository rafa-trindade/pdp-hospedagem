Imports Ponte.Hotel.Dominio
Imports System.Diagnostics.Process
Imports System.Data.SqlClient
Imports System.IO

Public Class MDIPrincipal
    Private cliente As List(Of clsCliente)
    Private empresa As List(Of clsEmpresa)
    Private apartamento As List(Of clsApartamento)
    Private db As New DbContexto
    Dim countEmpresa As Integer
    Dim count As Integer = 0

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        '    Dim sqlConnection1 As New SqlConnection("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=PousadaDaPonte;")
        '    Dim cmd As New SqlCommand
        '    Dim reader As SqlDataReader

        '    File.Delete("C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak")
        '    cmd.CommandText = "BACKUP DATABASE [PousadaDaPonte] TO  DISK = N'C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak'"

        '    cmd.CommandType = CommandType.Text
        '    cmd.Connection = sqlConnection1

        '    sqlConnection1.Open()

        '    reader = cmd.ExecuteReader()
        '    ' Data is accessible through the DataReader object here.



        '    sqlConnection1.Close()
        'Catch ex As Exception
        '    MsgBox("Erro de Conexão.", MsgBoxStyle.Critical, "Erro de Conexão")
        'End Try


        Try
            empresa = (From u In db.Empresa Where u.CPF_CNPJ = "00.000.000/0000-00" Select u).ToList
            If empresa.Count = 1 Then
                empresa = Nothing
                Exit Sub
            Else
                Dim dadosE As New clsEmpresa
                dadosE.RazaoSocial = "PARTICULAR"
                dadosE.NomeFantasia = "PARTICULAR"
                dadosE.CPF_CNPJ = "00.000.000/0000-00"
                db.Empresa.Add(dadosE)
            End If
            db.SaveChanges()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Close()
            Me.Dispose()
        End Try

        Try
            cliente = (From u In db.Cliente Where u.CPF = "000.000.000-00" Select u).ToList
            If cliente.Count = 1 Then
                cliente = Nothing
                Exit Sub
            Else
                Dim dados As New clsCliente
                dados.Nome = "- CLIENTE SEM REGISTRO -"
                dados.CPF = "0000000"
                dados.Empresa = (From u In db.Empresa Where u.RazaoSocial = "PARTICULAR" Select u).First
                dados.DataCadastro = Now
                dados.Tipo = clsCliente.TipoCliente.Cadastrado
                dados.ValorBase = 50
                db.Cliente.Add(dados)
            End If
            db.SaveChanges()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Close()
            Me.Dispose()
        End Try

        Try
            apartamento = (From u In db.Apartamento Where u.Descricao = "001" Select u).ToList
            If apartamento.Count = 1 Then
                apartamento = Nothing
                Exit Sub
            Else
                Dim dadosA As New clsApartamento
                dadosA.Descricao = "001"
                dadosA.Status = clsApartamento.StatusApartamento.Disponivel
                dadosA.ValorDiaria = 50
                dadosA.Capacidade = 1
                db.Apartamento.Add(dadosA)
            End If
            db.SaveChanges()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Close()
            Me.Dispose()
        End Try

        cliente = Nothing
        empresa = Nothing
        apartamento = Nothing


    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        EditCliente.ShowDialog(Me)
    End Sub

    Private Sub EmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem1.Click
        EditEmpresa.ShowDialog(Me)
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub HospedagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HospedagemToolStripMenuItem.Click
        EditHospedagem.ShowDialog(Me)
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        EditProduto.ShowDialog(Me)
    End Sub

    Private Sub HospedagemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HospedagemToolStripMenuItem1.Click
        CadHospedagem.ShowDialog(Me)
    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem2.Click
        CadCliente.ShowDialog(Me)
    End Sub

    Private Sub EmpresaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem2.Click
        CadEmpresa.ShowDialog(Me)
    End Sub

    Private Sub ProdutoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem1.Click
        CadProduto.ShowDialog(Me)
    End Sub

    Private Sub HospedagemToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HospedagemToolStripMenuItem2.Click
        MostraRelHospedagens.ShowDialog(Me)
    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        CadReserva.ShowDialog(Me)
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        EditReserva.ShowDialog(Me)
    End Sub

    Private Sub ApartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartamentosToolStripMenuItem.Click
        cadApartamento.ShowDialog(Me)
    End Sub

    Private Sub TiposDeProdutoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TiposDeProdutoToolStripMenuItem.Click
        CadTipoProduto.ShowDialog(Me)
    End Sub

    Private Sub VendasAvulsasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VendasAvulsasToolStripMenuItem.Click
        CadVendaProduto.ShowDialog(Me)
    End Sub

    Private Sub ReservasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem1.Click
        MostraRelReservas.ShowDialog(Me)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        CadHospedagem.ShowDialog(Me)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        CadReserva.ShowDialog(Me)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        CadCliente.ShowDialog(Me)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        CadEmpresa.ShowDialog(Me)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        cadApartamento.ShowDialog(Me)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        CadVendaProduto.ShowDialog(Me)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        CadProduto.ShowDialog(Me)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        CadTipoProduto.ShowDialog(Me)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        EditHospedagem.ShowDialog(Me)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        EditReserva.ShowDialog(Me)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        EditCliente.ShowDialog(Me)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        EditEmpresa.ShowDialog(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        EditProduto.ShowDialog(Me)
    End Sub

    Private Sub EstoqueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem1.Click
        MostraRelEstoque.ShowDialog(Me)
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        MostraRelEmpresas.ShowDialog(Me)
    End Sub

    Private Sub VendaProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaProdutosToolStripMenuItem.Click
        MostraRelVendas.ShowDialog(Me)
    End Sub


    Private Sub MovimentaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoToolStripMenuItem.Click
        MostraRelMovimentacao.ShowDialog(Me)
    End Sub

    Private Sub ValesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValesToolStripMenuItem.Click
        CadVale.ShowDialog(Me)
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        CadFuncionario.ShowDialog(Me)
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        Movimentacao.ShowDialog(Me)
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Movimentacao.ShowDialog(Me)
    End Sub

    'Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click

    '    Try
    '        Dim sqlConnection1 As New SqlConnection("Data Source=(localdb)\v11.0;Initial Catalog=PousadaDoSimao;")
    '        Dim cmd As New SqlCommand
    '        Dim reader As SqlDataReader

    '        File.Delete("C:\Users\rafat\Google Drive\Dev\BACKUP\PousadaDaPonte.bak")
    '        cmd.CommandText = "BACKUP DATABASE [PousadaDaPonte] TO  DISK = N'C:\Users\rafat\Google Drive\Dev\BACKUP\PousadaDaPonte.bak'"
    '        cmd.CommandType = CommandType.Text
    '        cmd.Connection = sqlConnection1

    '        sqlConnection1.Open()

    '        reader = cmd.ExecuteReader()
    '        ' Data is accessible through the DataReader object here.

    '        sqlConnection1.Close()
    '    Catch ex As Exception
    '        MsgBox("Conecete o PenDrive.", MsgBoxStyle.Critical, "Erro de Conexão")
    '    End Try

    'End Sub

    'Private Sub MDIPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '    Try
    '        Dim sqlConnection1 As New SqlConnection("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=PousadaDaPonte;")
    '        Dim cmd As New SqlCommand
    '        Dim reader As SqlDataReader

    '        File.Delete("C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak")
    '        cmd.CommandText = "BACKUP DATABASE [PousadaDaPonte] TO  DISK = N'C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak'"

    '        cmd.CommandType = CommandType.Text
    '        cmd.Connection = sqlConnection1

    '        sqlConnection1.Open()

    '        reader = cmd.ExecuteReader()
    '        ' Data is accessible through the DataReader object here.

    '        sqlConnection1.Close()
    '    Catch ex As Exception
    '        MsgBox("Erro de Conexão.", MsgBoxStyle.Critical, "Erro de Conexão")
    '    End Try
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
    '    Try
    '        Dim sqlConnection1 As New SqlConnection("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=PousadaDaPonte;")
    '        Dim cmd As New SqlCommand
    '        Dim reader As SqlDataReader

    '        File.Delete("C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak")
    '        cmd.CommandText = "BACKUP DATABASE [PousadaDaPonte] TO  DISK = N'C:\Users\rafat\Meu Drive\DEV\BACKUP\PousadaDaPonte.bak'"

    '        cmd.CommandType = CommandType.Text
    '        cmd.Connection = sqlConnection1

    '        sqlConnection1.Open()

    '        reader = cmd.ExecuteReader()
    '        ' Data is accessible through the DataReader object here.

    '        sqlConnection1.Close()
    '    Catch ex As Exception
    '        MsgBox("Erro de Conexão.", MsgBoxStyle.Critical, "Erro de Conexão")
    '    End Try
    'End Sub
End Class
