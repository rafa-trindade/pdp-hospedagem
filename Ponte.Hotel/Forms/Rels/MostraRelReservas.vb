Imports Ponte.Hotel.Dominio

Public Class MostraRelReservas

    Private listReserva As New List(Of clsReserva)
    Private listhospedagem As New List(Of clsHospedagem)
    Private cliente As clsCliente
    Private db As New DbContexto

    'BUSCA POR CODIGO
    Private Sub btGerarCodigo_Click(sender As Object, e As EventArgs) Handles btGerarCodigo.Click

        lblNumRegistros.Text = "Número de Registros: "

        If txtCodigo.Text = "" Then
            MsgBox("Digite o código da Hospedagem.", MsgBoxStyle.Information, "Relatório")
            txtCodigo.Focus()
            Exit Sub
        End If

        Try
            listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataCadastro Descending Where i.Codigo = txtCodigo.Text Select i).ToList

            If listReserva.Count < 1 Then
                MsgBox("Reserva não encontrada.", MsgBoxStyle.Information, "Relatório")

            End If
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblNumRegistros.Text += listReserva.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelReservaItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelReserva.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    'BUSCA POR EMPRESA-----------------------------------------
    Private Sub btGerarEmpresa_Click(sender As Object, e As EventArgs) Handles btGerarEmpresa.Click

        lblNumRegistros.Text = "Número de Registros: "

        If Not ckPeriodoEmpresa.Checked Then
            Dim dataIniEmpresa As DateTime = dtInicioEmpresa.Value.ToShortDateString
            Dim dataFimEmpresa As DateTime = dtFimEmpresa.Value.ToShortDateString
            dataIniEmpresa = dataIniEmpresa & " 00:00:00"
            dataFimEmpresa = dataFimEmpresa & " 23:59:59"

            If dataIniEmpresa > dataFimEmpresa Then
                MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
                dtFim.Focus()
                Exit Sub
            End If

            If cbStatusEmpresa.SelectedIndex = 1 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Solcitada And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas solicitadas para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusEmpresa.SelectedIndex = 2 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Confirmada And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas confimadas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try

            ElseIf cbStatusEmpresa.SelectedIndex = 3 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Cancelada And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas canceladas para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas Registrada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        Else

            If cbStatusEmpresa.SelectedIndex = 1 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Solcitada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas solicitadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusEmpresa.SelectedIndex = 2 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Confirmada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas confirmadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try

            ElseIf cbStatusEmpresa.SelectedIndex = 3 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.StatusReserva = clsReserva.StatusRes.Cancelada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas canceladas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Empresa sem reservas Registradas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        End If

        lblNumRegistros.Text += listReserva.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelReservaItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelReserva.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    'BUSCA POR CLIENTE''''''''''''''''''''''''
    Private Sub btGerarCliente_Click(sender As Object, e As EventArgs) Handles btGerarCliente.Click
        lblNumRegistros.Text = "Número de Registros: "

        If txtNomeCliente.Text = "" Then
            MsgBox("Digite o nome do Cliente.", MsgBoxStyle.Information, "Relatório")
            txtCodigo.Focus()
            Exit Sub
        End If

        If Not ckPeriodoCliente.Checked Then
            Dim dataIniCliente As DateTime = dtInicioCliente.Value.ToShortDateString
            Dim dataFimCliente As DateTime = dtFimCliente.Value.ToShortDateString
            dataIniCliente = dataIniCliente & " 00:00:00"
            dataFimCliente = dataFimCliente & " 23:59:59"

            If dataIniCliente > dataFimCliente Then
                MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
                dtFim.Focus()
                Exit Sub
            End If

            If cbStatusCliente.SelectedIndex = 1 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Solcitada And
                                i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas solicitadas para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 2 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Confirmada And
                                i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas confirmadas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 3 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Cancelada And
                                i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas canceladas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas Registrada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        Else
            If cbStatusCliente.SelectedIndex = 1 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Solcitada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas solicitadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 2 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Confirmada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas confirmadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 3 Then
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.StatusReserva = clsReserva.StatusRes.Cancelada Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reservas canceladas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text Select i).ToList
                    If listReserva.Count < 1 Then
                        MsgBox("Cliente sem reserva Registrada.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        End If

        lblNumRegistros.Text += listReserva.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelReservaItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelReserva.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub

    'BUSCA POR PERÍODO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btGerarPeriodo_Click(sender As Object, e As EventArgs) Handles btGerarPeriodo.Click
        lblNumRegistros.Text = "Número de Registros: "


        Dim dataIni As DateTime = dtInicio.Value.ToShortDateString
        Dim dataFim As DateTime = dtFim.Value.ToShortDateString
        dataIni = dataIni & " 00:00:00"
        dataFim = dataFim & " 23:59:59"

        If dataIni > dataFim Then
            MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
            dtFim.Focus()
            Exit Sub
        End If

        If cbStatusPeriodo.SelectedIndex = 1 Then
            Try
                listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                           Where i.DataEntrada >= dataIni And i.DataEntrada <= dataFim And i.StatusReserva = clsReserva.StatusRes.Solcitada Select i).ToList
                If listReserva.Count < 1 Then
                    MsgBox("Nenuma reserva solicitada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        ElseIf cbStatusPeriodo.SelectedIndex = 2 Then
            Try
                listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                           Where i.DataEntrada >= dataIni And i.DataEntrada <= dataFim And i.StatusReserva = clsReserva.StatusRes.Confirmada Select i).ToList
                If listReserva.Count < 1 Then
                    MsgBox("Nenuma reserva confirmada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        ElseIf cbStatusPeriodo.SelectedIndex = 3 Then
            Try
                listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                           Where i.DataEntrada >= dataIni And i.DataEntrada <= dataFim And i.StatusReserva = clsReserva.StatusRes.Cancelada Select i).ToList
                If listReserva.Count < 1 Then
                    MsgBox("Nenuma reserva cancelada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        Else
            Try
                listReserva = (From i In db.Reserva.Include("Cliente") Order By i.DataEntrada Descending
                           Where i.DataEntrada >= dataIni And i.DataEntrada <= dataFim Select i).ToList
                If listReserva.Count < 1 Then
                    MsgBox("Nenuma reserva encontrada para o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        End If

        lblNumRegistros.Text += listReserva.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelReservaItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelReserva.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub


    ''MONTA ITENS"""""""""""""""""""""""""
    Private Function montaItens(strItens As String, strRel As String) As String
        Dim contador As Integer = 0

        Dim ret(listReserva.Count - 1) As String
        Try
            For Each d In listReserva

                ''Hospedagem------------------------------------------
                listhospedagem = (From c In db.Hospedagem.Include("Apartamento") Where c.Reserva.Id = d.Id Select c).ToList

                For Each a In listhospedagem

                    If a.Status = clsHospedagem.StatusCheckout.Aberto Then
                        ret(contador) += strItens.Replace("{{codigohospedagem}}", a.Codigo) _
                        .Replace("{{dataentradahospedagem}}", a.DataEntrada) _
                        .Replace("{{apartamentohospedagem}}", a.Apartamento.Descricao) _
                        .Replace("{{valordiariahospedagem}}", FormatCurrency(a.ValorDiaria, 2)) _
                        .Replace("{{qtddiariashospedagem}}", (Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) _
                        .Replace("{{datasaidahospedagem}}", "<font color='red'>*hospedagem ativa</font>")
                    Else
                        ret(contador) += strItens.Replace("{{codigohospedagem}}", a.Codigo) _
                        .Replace("{{dataentradahospedagem}}", a.DataEntrada) _
                        .Replace("{{apartamentohospedagem}}", a.Apartamento.Descricao) _
                        .Replace("{{valordiariahospedagem}}", FormatCurrency(a.ValorDiaria, 2)) _
                        .Replace("{{qtddiariashospedagem}}", (Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) _
                        .Replace("{{datasaidahospedagem}}", a.DataSaida)
                    End If

                Next
                ret(contador) = strRel.Replace("<dados></dados>", ret(contador))

                ''Reserva-------------------------------------------

                Dim stsReserva As String
                If d.StatusReserva = clsReserva.StatusRes.Confirmada Then
                    stsReserva = "Confirmada"
                ElseIf d.StatusReserva = clsReserva.StatusRes.Solcitada Then
                    stsReserva = "Solicitada"
                Else
                    stsReserva = "Cancelada"
                End If

                Dim stsSinal As String
                If d.StatusSinal = clsReserva.SinalPagamento.Pago Then
                    stsSinal = "(Pago)"
                Else
                    stsSinal = "(Pendente)"
                End If

                Dim vlrSinal As String
                If d.ValorSinal = 0 Then
                    vlrSinal = "Nenhum"
                    stsSinal = ""
                Else
                    vlrSinal = FormatCurrency(Convert.ToDouble(d.ValorSinal), 2)
                End If

                cliente = (From i In db.Cliente.Include("Empresa") Where d.Cliente.Id = i.Id Select i).First

                ret(contador) = ret(contador).Replace("{{codigoreserva}}", d.Codigo) _
                .Replace("{{statusreserva}}", stsReserva) _
                .Replace("{{datacadastroreserva}}", d.DataCadastro) _
                .Replace("{{valorsinalreserva}}", vlrSinal) _
                .Replace("({{statussinalreserva}})", stsSinal) _
                .Replace("{{dataentradareserva}}", d.DataEntrada) _
                .Replace("{{qtdpessoasreserva}}", d.QtdPessoas) _
                .Replace("{{nomeclientereserva}}", d.Cliente.Nome) _
                .Replace("{{empresareserva}}", cliente.Empresa.NomeFantasia)

                contador += 1

            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        Return String.Join("<hr>", ret)

    End Function

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 9
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Private Sub buscaPorCPF()
        If txtCpfCliente.Text = "" Then Exit Sub

        Try
            cliente = (From u In db.Cliente.Include("Empresa") Where u.CPF = txtCpfCliente.Text Select u).First

            With cliente
                txtNomeCliente.Text = .Nome
            End With

        Catch ex As Exception

        End Try
    End Sub

    Public Sub setaValores(cod As String)
        txtCpfCliente.Text = cod
        buscaPorCPF()
    End Sub

    Private Sub txtCpfCliente_Enter(sender As Object, e As EventArgs) Handles txtCpfCliente.Enter
        If txtCpfCliente.Text = "" Then Exit Sub

        txtCpfCliente.Text = LeNumero(txtCpfCliente.Text)

        txtNomeCliente.Text = ""
    End Sub


    Private Sub txtCpfCliente_Leave(sender As Object, e As EventArgs) Handles txtCpfCliente.Leave
        If txtCpfCliente.Text = "" Then Exit Sub

        If Not TextBoxCpfCnpj(sender) Then Exit Sub

        buscaPorCPF()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        wbRels.DocumentText = ""
        txtCpfCliente.Text = ""
        txtNomeCliente.Text = ""
    End Sub

    Private Sub MostraRelReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCpfCliente.Enabled = False
        rbCliente.Checked = True
        cbStatusCliente.SelectedIndex = 0
        cbStatusPeriodo.SelectedIndex = 0
        cbStatusEmpresa.SelectedIndex = 0
    End Sub

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        gbCliente.Visible = True
        gbCodigo.Visible = False
        gbPeriodo.Visible = False
        gbEmpresa.Visible = False

        txtNomeCliente.Text = ""
        txtCpfCliente.Text = ""
        ckPeriodoCliente.Checked = True
        ckPeriodoEmpresa.Checked = True
        txtCodigo.Text = ""
        dtInicio.Text = Now
        dtFim.Text = Now
        dtInicioCliente.Text = Now
        dtFimCliente.Text = Now
        dtInicioEmpresa.Text = Now
        dtFimEmpresa.Text = Now

        lblNumRegistros.Text = "Número de Registros: "
        lblNumRegistros.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = False
        gbPeriodo.Visible = True
        gbEmpresa.Visible = False

        txtNomeCliente.Text = ""
        txtCpfCliente.Text = ""
        ckPeriodoCliente.Checked = True
        ckPeriodoEmpresa.Checked = True
        txtCodigo.Text = ""
        dtInicio.Text = Now
        dtFim.Text = Now
        dtInicioCliente.Text = Now
        dtFimCliente.Text = Now
        dtInicioEmpresa.Text = Now
        dtFimEmpresa.Text = Now

        lblNumRegistros.Text = "Número de Registros: "
        lblNumRegistros.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = True
        gbPeriodo.Visible = False
        gbEmpresa.Visible = False

        txtNomeCliente.Text = ""
        txtCpfCliente.Text = ""
        ckPeriodoCliente.Checked = True
        ckPeriodoEmpresa.Checked = True
        txtCodigo.Text = ""
        dtInicio.Text = Now
        dtFim.Text = Now
        dtInicioCliente.Text = Now
        dtFimCliente.Text = Now
        dtInicioEmpresa.Text = Now
        dtFimEmpresa.Text = Now

        lblNumRegistros.Text = "Número de Registros: "
        lblNumRegistros.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpresa.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = False
        gbPeriodo.Visible = False
        gbEmpresa.Visible = True

        txtNomeCliente.Text = ""
        txtCpfCliente.Text = ""
        ckPeriodoCliente.Checked = True
        ckPeriodoEmpresa.Checked = True
        txtCodigo.Text = ""
        dtInicio.Text = Now
        dtFim.Text = Now
        dtInicioCliente.Text = Now
        dtFimCliente.Text = Now
        dtInicioEmpresa.Text = Now
        dtFimEmpresa.Text = Now

        lblNumRegistros.Text = "Número de Registros: "
        lblNumRegistros.Visible = False

        cbEmpresa.DataSource = (From c In db.Empresa Select New With {Key .Id = c.Id, Key .Nome = c.NomeFantasia}).ToList()
        cbEmpresa.SelectedIndex = 0

        cbEmpresa.DisplayMember = "Nome"
        cbEmpresa.ValueMember = "Id"

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbPeriodo_MouseClick(sender As Object, e As MouseEventArgs) Handles rbPeriodo.MouseClick
        rbPeriodo.Checked = True
    End Sub

    Private Sub rbCliente_MouseClick(sender As Object, e As MouseEventArgs) Handles rbCliente.MouseClick
        rbCliente.Checked = True
    End Sub

    Private Sub rbCodigo_MouseClick(sender As Object, e As MouseEventArgs) Handles rbCodigo.MouseClick
        rbCodigo.Checked = True
    End Sub

    Private Sub rbEmpresa_MouseClick(sender As Object, e As MouseEventArgs) Handles rbEmpresa.MouseClick
        rbEmpresa.Checked = True
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cbPeriodoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ckPeriodoCliente.CheckedChanged
        gbDataInicioCliente.Enabled = Not ckPeriodoCliente.Checked
        gbDataFimCliente.Enabled = Not ckPeriodoCliente.Checked
    End Sub

    Private Sub ckPeriodoEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles ckPeriodoEmpresa.CheckedChanged
        gbDataInicioEmpresa.Enabled = Not ckPeriodoEmpresa.Checked
        gbDataFimEmpresa.Enabled = Not ckPeriodoEmpresa.Checked
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs)
        wbRels.ShowPrintPreviewDialog()
    End Sub

    Private Sub MostraRelReservas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelReservas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class