Imports Ponte.Hotel.Dominio

Public Class Pesquisa

    Public nome As String
    Public pai As Object
    Public tipo As Integer


    Public Sub carregaGridClientes()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Cliente.Include("Empresa") Order By c.Nome Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome, Key .Empresa = c.Empresa.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150

        Else
            Try
                grdPesquisa.DataSource = (From c In db.Cliente Order By c.Nome Where c.Nome.Contains(nome) Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome, Key .Empresa = c.Empresa.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try

            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150

        End If

    End Sub

    Public Sub carregaGridClientesCadastrados()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Cliente Order By c.Nome Where c.Tipo = clsCliente.TipoCliente.Cadastrado Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome, Key .Empresa = c.Empresa.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150

        Else
            Try
                grdPesquisa.DataSource = (From c In db.Cliente Order By c.Nome Where c.Nome.Contains(nome) And c.Tipo = clsCliente.TipoCliente.Cadastrado Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome, Key .Empresa = c.Empresa.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150
        End If

    End Sub

    Public Sub carregaGridClientesPreCadastrados()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Cliente Order By c.Nome Where c.Tipo = clsCliente.TipoCliente.Precadastrado Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150
        Else
            Try
                grdPesquisa.DataSource = (From c In db.Cliente Order By c.Nome Where c.Nome.Contains(nome) And c.Tipo = clsCliente.TipoCliente.Precadastrado Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CPF").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 260
            grdPesquisa.Columns("CPF").HeaderText = "RG"
            grdPesquisa.Columns("Empresa").Width = 150
        End If

    End Sub

    Public Sub carregaGridEmpresas()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Empresa Order By c.RazaoSocial Select New With {Key .CNPJ = c.CPF_CNPJ, Key .Nome = c.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CNPJ").Width = 120
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 130
        Else
            Try
                grdPesquisa.DataSource = (From c In db.Empresa Order By c.RazaoSocial Where c.RazaoSocial.Contains(nome) Select New With {Key .CNPJ = c.CPF_CNPJ, Key .Nome = c.RazaoSocial}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("CNPJ").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 110
        End If

    End Sub

    Public Sub carregaGridProdutos()
        Dim db As New DbContexto

        If String.IsNullOrWhiteSpace(nome) Then
            Try
                grdPesquisa.DataSource = (From c In db.Produto Order By c.Nome Select New With {Key .Codigo = c.Codigo, Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("Codigo").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 110
        Else
            Try
                grdPesquisa.DataSource = (From c In db.Produto Order By c.Nome Where c.Nome.Contains(nome) Select New With {Key .Codigo = c.Codigo, Key .Nome = c.Nome}).ToList()
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
            grdPesquisa.Columns("Codigo").Width = 100
            grdPesquisa.Columns("Nome").Width = grdPesquisa.Width - 110
        End If

    End Sub

    Public Sub carregaGridHospedagens()
        Dim db As New DbContexto


        If EditHospedagem.cbStatusPesq.Checked = True Then

            If String.IsNullOrWhiteSpace(nome) Then
                Try
                    grdPesquisa.DataSource = (From c In db.Hospedagem Where c.Status = 1 Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .Apartamento = c.Apartamento.Descricao, Key .DataEntrada = c.DataEntrada}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Apartamento").HeaderText = "Apartamento"


                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("Apartamento").Width = 80
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420

            Else
                Try
                    grdPesquisa.DataSource = (From c In db.Hospedagem Where c.Status = 1 And c.Cliente.Nome.Contains(nome) Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .Apartamento = c.Apartamento.Descricao, Key .DataEntrada = c.DataEntrada}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Apartamento").HeaderText = "Apartamento"

                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("Apartamento").Width = 80
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
            End If

        Else

            If String.IsNullOrWhiteSpace(nome) Then
                Try
                    grdPesquisa.DataSource = (From c In db.Hospedagem Where c.Status = 0 Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .Apartamento = c.Apartamento.Descricao, Key .DataEntrada = c.DataEntrada}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Apartamento").HeaderText = "Apartamento"

                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("Apartamento").Width = 80
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420

            Else
                Try
                    grdPesquisa.DataSource = (From c In db.Hospedagem Where c.Status = 0 And c.Cliente.Nome.Contains(nome) Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .DataEntrada = c.DataEntrada}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Apartamento").HeaderText = "Apartamento"

                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("Apartamento").Width = 80
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
            End If

        End If

    End Sub

    Public Sub carregaGridReserva()
        Dim db As New DbContexto


        If EditReserva.cbPesStatusRes.SelectedValue = 2 Then

            If String.IsNullOrWhiteSpace(nome) Then
                Try
                    grdPesquisa.DataSource = (From c In db.Reserva Where c.StatusReserva = clsReserva.StatusRes.Solcitada And c.Origem = clsReserva.OrigemReseva.Sistema Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .DataEntrada = c.DataEntrada, Key .Status = c.StatusReserva}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Status").HeaderText = "Status"


                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
                grdPesquisa.Columns("Status").Width = 80

            Else
                Try
                    grdPesquisa.DataSource = (From c In db.Reserva Where c.Cliente.Nome.Contains(nome) And c.StatusReserva = clsReserva.StatusRes.Solcitada And c.Origem = clsReserva.OrigemReseva.Sistema Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .DataEntrada = c.DataEntrada, Key .Status = c.StatusReserva}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Status").HeaderText = "Status"

                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
                grdPesquisa.Columns("Status").Width = 80
            End If

        Else

            If String.IsNullOrWhiteSpace(nome) Then
                Try
                    grdPesquisa.DataSource = (From c In db.Reserva Where c.StatusReserva = clsReserva.StatusRes.Cancelada And c.Origem = clsReserva.OrigemReseva.Sistema Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .DataEntrada = c.DataEntrada, Key .Status = c.StatusReserva}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Status").HeaderText = "Status"


                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
                grdPesquisa.Columns("Status").Width = 80

            Else
                Try
                    grdPesquisa.DataSource = (From c In db.Reserva Where c.Cliente.Nome.Contains(nome) And c.StatusReserva = clsReserva.StatusRes.Cancelada And c.Origem = clsReserva.OrigemReseva.Sistema Select New With {Key .Codigo = c.Codigo, Key .NomeCliente = c.Cliente.Nome, Key .DataEntrada = c.DataEntrada, Key .Status = c.StatusReserva}).ToList()
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Me.Dispose()
                    Me.Close()
                End Try

                grdPesquisa.Columns("Codigo").HeaderText = "Código"
                grdPesquisa.Columns("NomeCliente").HeaderText = "Cliente"
                grdPesquisa.Columns("DataEntrada").HeaderText = "Data de Entrada"
                grdPesquisa.Columns("Status").HeaderText = "Status"

                grdPesquisa.Columns("Codigo").Width = 60
                grdPesquisa.Columns("NomeCliente").Width = 270
                grdPesquisa.Columns("DataEntrada").Width = grdPesquisa.Width - 420
                grdPesquisa.Columns("Status").Width = 80
            End If

        End If

    End Sub

    Private Sub PesquisaProdNome_Load(sender As Object, e As EventArgs) Handles Me.Load
        If tipo = 1 Or tipo = 7 Or tipo = 9 Then
            carregaGridClientes()
        ElseIf tipo = 2 Then
            carregaGridEmpresas()
        ElseIf tipo = 3 Or tipo = 10 Or tipo = 11 Then
            carregaGridProdutos()
        ElseIf tipo = 4 Or tipo = 6 Then
            carregaGridClientesCadastrados()
        ElseIf tipo = 5 Then
            carregaGridHospedagens()
        ElseIf tipo = 8 Then
            carregaGridReserva()
        End If
    End Sub

    Private Sub grdProdutos_DoubleClick(sender As Object, e As EventArgs) Handles grdPesquisa.DoubleClick
        If tipo = 1 Then
            CType(pai, EditCliente).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            Me.Close()
        ElseIf tipo = 2 Then
            CType(pai, EditEmpresa).setaValores(grdPesquisa.SelectedRows(0).Cells("CNPJ").Value)
            Me.Close()
        ElseIf tipo = 3 Then
            CType(pai, EditProduto).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            Me.Close()
        ElseIf tipo = 4 Then
            CType(pai, CadHospedagem).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            Me.Close()
        ElseIf tipo = 5 Then
            CType(pai, EditHospedagem).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            Me.Close()
        ElseIf tipo = 6 Then
            CType(pai, MostraRelHospedagens).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            Me.Close()
        ElseIf tipo = 7 Then
            CType(pai, CadReserva).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            Me.Close()
        ElseIf tipo = 8 Then
            CType(pai, EditReserva).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            Me.Close()
        ElseIf tipo = 9 Then
            CType(pai, MostraRelReservas).setaValores(grdPesquisa.SelectedRows(0).Cells("CPF").Value)
            Me.Close()
        ElseIf tipo = 10 Then
            CType(pai, MostraRelEstoque).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            Me.Close()
        ElseIf tipo = 11 Then
            CType(pai, MostraRelVendas).setaValores(grdPesquisa.SelectedRows(0).Cells("Codigo").Value)
            Me.Close()
        End If
    End Sub

    Private Sub Pesquisa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class