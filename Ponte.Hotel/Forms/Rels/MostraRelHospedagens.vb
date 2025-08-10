Imports Ponte.Hotel.Dominio

Public Class MostraRelHospedagens

    Private listHospedagem As New List(Of clsHospedagem)
    Private listConsumacao As List(Of clsConsumacao)
    Private cliente As clsCliente
    Private db As New DbContexto
    Dim totalConsumacao As Double


    'BUSCA POR CÓDIGO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btGerarCodigo_Click(sender As Object, e As EventArgs) Handles btGerarCodigo.Click

        lblNumRegistros.Text = "Número de Registros: "

        If txtCodigo.Text = "" Then
            MsgBox("Digite o código da Hospedagem.", MsgBoxStyle.Information, "Relatório")
            txtCodigo.Focus()
            Exit Sub
        End If

        Try
            listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento")
                              Where i.Codigo = txtCodigo.Text Select i).ToList
            If listHospedagem.Count < 1 Then
                MsgBox("Hospedagem não encontrada.", MsgBoxStyle.Information, "Relatório")

            End If
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Exit Sub
        End Try

        lblNumRegistros.Text += listHospedagem.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelHospedagemItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelHospedagem.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    'BUSCA POR NOME'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.Status = clsHospedagem.StatusCheckout.Aberto And
                                i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagens ativas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 2 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.Status = clsHospedagem.StatusCheckout.Fechado And
                                i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagens finalizadas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.DataEntrada >= dataIniCliente And i.DataEntrada <= dataFimCliente Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagem Registrada no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        Else
            If cbStatusCliente.SelectedIndex = 1 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.Status = clsHospedagem.StatusCheckout.Aberto Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagens ativas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusCliente.SelectedIndex = 2 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text And i.Status = clsHospedagem.StatusCheckout.Fechado Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagens finalizadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Nome = txtNomeCliente.Text Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Cliente sem hospedagem Registrada.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        End If

        lblNumRegistros.Text += listHospedagem.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelHospedagemItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelHospedagem.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub

    'BUSCA POR EMPRESA'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.Status = clsHospedagem.StatusCheckout.Aberto And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagens ativas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusEmpresa.SelectedIndex = 2 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.Status = clsHospedagem.StatusCheckout.Fechado And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagens finalizadas no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And
                                i.DataEntrada >= dataIniEmpresa And i.DataEntrada <= dataFimEmpresa Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagem Registrada no período selecionado.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        Else

            If cbStatusEmpresa.SelectedIndex = 1 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.Status = clsHospedagem.StatusCheckout.Aberto Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagens ativas", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            ElseIf cbStatusEmpresa.SelectedIndex = 2 Then
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString And i.Status = clsHospedagem.StatusCheckout.Fechado Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagens finalizadas.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            Else
                Try
                    listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataEntrada Descending
                               Where i.Cliente.Empresa.Id.ToString = cbEmpresa.SelectedValue.ToString Select i).ToList
                    If listHospedagem.Count < 1 Then
                        MsgBox("Empresa sem hospedagem Registrada.", MsgBoxStyle.Information, "Relatório")

                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                    Exit Sub
                End Try
            End If

        End If

        lblNumRegistros.Text += listHospedagem.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelHospedagemItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelHospedagem.html"

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
                listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataSaida Descending
                                  Where i.DataSaida >= dataIni And i.DataSaida <= dataFim And i.Status = clsHospedagem.StatusCheckout.Aberto Select i).ToList
                If listHospedagem.Count < 1 Then
                    MsgBox("Nenuma hospedagem ativa durante o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        ElseIf cbStatusPeriodo.SelectedIndex = 2 Then
            Try
                listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataSaida Descending
                                  Where i.DataSaida >= dataIni And i.DataSaida <= dataFim And i.Status = clsHospedagem.StatusCheckout.Fechado Select i).ToList
                If listHospedagem.Count < 1 Then
                    MsgBox("Nenuma hospedagem finalizada durante o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        Else
            Try
                listHospedagem = (From i In db.Hospedagem.Include("Cliente").Include("Apartamento") Order By i.DataSaida Descending
                                  Where i.DataSaida >= dataIni And i.DataSaida <= dataFim Select i).ToList
                If listHospedagem.Count < 1 Then
                    MsgBox("Nenuma hospedagem encontrada durante o período selecionado.", MsgBoxStyle.Information, "Relatório")

                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Exit Sub
            End Try
        End If

        lblNumRegistros.Text += listHospedagem.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelHospedagemItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelHospedagem.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados
    End Sub



    Private Function montaItens(strItens As String, strRel As String) As String
        Dim contador As Integer = 0
        Dim totalbruto As Double
        Dim totalpessoas As Integer
        lblTotalBruto.Text = ""
        lblTotalPessoas.Text = ""

        Dim ret(listHospedagem.Count - 1) As String

        Try
            For Each d In listHospedagem

                totalConsumacao = 0
                ''Consumação------------------------------------------
                listConsumacao = (From c In db.Consumacao.Include("Produto") Where c.Hospedagem.Id = d.Id Select c).ToList

                If listConsumacao.Count = 0 Then

                    ret(contador) = strItens.Replace(strItens, "<tr><td colspan=4 valign=top style='color:red;border:none;padding:0cm 5.4pt 0cm 5.4pt'>*hospedagem sem consumação</td></tr>")
                    ret(contador) = strRel.Replace("<dados></dados>", ret(contador))

                Else

                    Dim linha As Double = 1
                    Dim num As Integer = 1

                    For Each a In listConsumacao
                        linha = num / 2
                        If linha.ToString.Contains(",5") Then

                            ret(contador) += strItens.Replace("{{nomeproduto}}", a.Produto.Nome) _
                                .Replace("{{qtdproduto}}", a.QtdProduto) _
                                .Replace("{{valorproduto}}", FormatCurrency(a.ValorTotalConsumo / a.QtdProduto)) _
                                .Replace("{{valorconsumacao}}", FormatCurrency(a.ValorTotalConsumo)) _
                                .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                            totalConsumacao += a.ValorTotalConsumo

                        Else
                            ret(contador) += strItens.Replace("{{nomeproduto}}", a.Produto.Nome) _
                                .Replace("{{qtdproduto}}", a.QtdProduto) _
                                .Replace("{{valorproduto}}", FormatCurrency(a.ValorTotalConsumo / a.QtdProduto)) _
                                .Replace("{{valorconsumacao}}", FormatCurrency(a.ValorTotalConsumo)) _
                                .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                            totalConsumacao += a.ValorTotalConsumo
                        End If
                        num += 1
                    Next
                    ret(contador) = strRel.Replace("<dados></dados>", ret(contador))

                End If


                cliente = (From i In db.Cliente.Include("Empresa") Where d.Cliente.Id = i.Id Select i).First
                ''Cabeçalho-------------------------------------------
                ret(contador) = ret(contador).Replace("{{codigo}}", d.Codigo) _
                .Replace("{{nomecliente}}", d.Cliente.Nome) _
                .Replace("{{empresa}}", cliente.Empresa.NomeFantasia) _
                .Replace("{{dataentrada}}", d.DataEntrada) _
                .Replace("{{apartamento}}", d.Apartamento.Descricao) _
                .Replace("{{valordesconto}}", FormatCurrency(d.Desconto, 2)) _
                .Replace("{{totalconsumacao}}", FormatCurrency(totalConsumacao, 2)) _
                .Replace("{{qtdpessoas}}", d.QuantidadePessoas)

                If d.Status = clsHospedagem.StatusCheckout.Aberto Then
                    ret(contador) = ret(contador).Replace("{{datasaida}}", "<font color='red'>*hospedagem ativa</font>") _
                        .Replace("{{qtddiarias}}", (Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) _
                        .Replace("{{valortotaldiarias}}", FormatCurrency(((Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) * d.Apartamento.ValorDiaria, 2)) _
                        .Replace("{{valorapartamento}}", FormatCurrency(d.Apartamento.ValorDiaria)) _
                        .Replace("{{total}}", FormatCurrency((totalConsumacao + (((Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) * d.Apartamento.ValorDiaria)), 2)) _
                        .Replace("VALOR PAGO:", "VALOR A PAGAR:") _
                        .Replace("{{valorpago}}", FormatCurrency((((Now.AddHours(-12) - d.DataEntrada.AddHours(-12).Date).Days + 1) * d.ValorDiaria) + totalConsumacao, 2))

                Else
                    ret(contador) = ret(contador).Replace("{{datasaida}}", d.DataSaida) _
                        .Replace("{{qtddiarias}}", d.QuantidadeDiaria) _
                        .Replace("{{valortotaldiarias}}", FormatCurrency(d.QuantidadeDiaria * d.ValorDiaria, 2)) _
                        .Replace("{{valorapartamento}}", FormatCurrency(d.ValorDiaria)) _
                        .Replace("{{total}}", FormatCurrency(d.ValorTotal)) _
                        .Replace("{{valorpago}}", FormatCurrency(d.ValorPago, 2))
                End If
                contador += 1

                totalbruto += d.ValorPago
                totalpessoas += d.QuantidadePessoas

            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        lblTotalBruto.Text = FormatCurrency(totalbruto, 2).ToString
        lblTotalBruto.Visible = True
        lbltotbruto.Visible = True

        lblTotalPessoas.Text = "Num. Pessoas Hospedadas: " & totalpessoas.ToString
        lblTotalPessoas.Visible = True

        gbResumo.Visible = True


        Return String.Join("<hr>", ret)

    End Function

    'CONFIGURAÇÃO DOS RADIOBUTTONS
    Private Sub MostraRelHospedagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        gbResumo.Visible = False


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
        lblTotalBruto.Visible = False
        lbltotbruto.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = False
        gbPeriodo.Visible = True
        gbEmpresa.Visible = False
        gbResumo.Visible = False


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

        lblTotalBruto.Visible = False
        lbltotbruto.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = True
        gbPeriodo.Visible = False
        gbEmpresa.Visible = False
        gbResumo.Visible = False


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
        lblTotalBruto.Visible = False
        lbltotbruto.Visible = False

        wbRels.DocumentText = ""
    End Sub

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpresa.CheckedChanged
        gbCliente.Visible = False
        gbCodigo.Visible = False
        gbPeriodo.Visible = False
        gbEmpresa.Visible = True
        gbResumo.Visible = False


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
        lblTotalBruto.Visible = False
        lbltotbruto.Visible = False

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

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 6
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

        txtNomeCliente.Text = ""
    End Sub


    Private Sub txtCpfCliente_Leave(sender As Object, e As EventArgs) Handles txtCpfCliente.Leave
        If txtCpfCliente.Text = "" Then Exit Sub

        buscaPorCPF()
    End Sub


    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        wbRels.DocumentText = ""
        txtCpfCliente.Text = ""
        txtNomeCliente.Text = ""
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

    Private Sub MostraRelHospedagens_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelHospedagens_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class