Imports Ponte.Hotel.Dominio

Public Class MostraRelVendas

    Private db As New DbContexto
    Private listVendas As New List(Of clsConsumacao)
    Private produto As New clsProduto

    Private Sub btPesqProd_Click(sender As Object, e As EventArgs) Handles btPesqProd.Click
        Try
            Pesquisa.nome = txtNomeProd.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 11
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub





    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text = "" Then Exit Sub
        buscaPorCodigo()
    End Sub

    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs) Handles txtCodigo.Enter
        If txtCodigo.Text = "" Then Exit Sub
        txtNomeProd.Text = ""
        txtCodigo.Text = ""
    End Sub

    Public Sub setaValores(cod As String)
        txtCodigo.Text = cod
        buscaPorCodigo()
    End Sub

    Public Sub buscaPorCodigo()

        If txtCodigo.Text = "" Then Exit Sub

        Try
            produto = (From u In db.Produto.Include("TipoProduto") Where u.Codigo = txtCodigo.Text Select u).First

            txtNomeProd.Text = produto.Nome

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

    End Sub

    Private Sub ckProdutos_CheckedChanged(sender As Object, e As EventArgs) Handles ckProdutos.CheckedChanged
        txtCodigo.Enabled = ckProdutos.Checked
        txtNomeProd.Enabled = ckProdutos.Checked
        btPesqProd.Enabled = ckProdutos.Checked
        btLimpar.Enabled = ckProdutos.Checked

        wbRels.DocumentText = ""
    End Sub


    Private Sub btImprimir_Click(sender As Object, e As EventArgs)
        wbRels.ShowPrintPreviewDialog()
    End Sub

    Private Sub btLimpar_Click_1(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCodigo.Text = ""
        txtNomeProd.Text = ""
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        listVendas = Nothing
        produto = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelVendas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btGerar_Click(sender As Object, e As EventArgs) Handles btGerar.Click

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


        If ckProdutos.Checked = True Then

            If cbTipoVenda.SelectedIndex = 1 Then
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.Produto.Codigo = txtCodigo.Text And c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim And c.Tipo = clsConsumacao.TipoConsumacao.Avulsa Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            ElseIf cbTipoVenda.SelectedIndex = 2 Then
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.Produto.Codigo = txtCodigo.Text And c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim And c.Tipo = clsConsumacao.TipoConsumacao.Hospedagem Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            Else
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.Produto.Codigo = txtCodigo.Text And c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            End If


        Else

            If cbTipoVenda.SelectedIndex = 1 Then
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim And c.Tipo = clsConsumacao.TipoConsumacao.Avulsa Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            ElseIf cbTipoVenda.SelectedIndex = 2 Then
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim And c.Tipo = clsConsumacao.TipoConsumacao.Hospedagem Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            Else
                Try
                    listVendas = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Where c.DataConsumacao >= dataIni And c.DataConsumacao <= dataFim Select c).ToList
                    If listVendas.Count < 1 Then
                        MsgBox("Nenhum venda de produto foi realizado no período selecionado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            End If


        End If

        lblNumRegistros.Text += listVendas.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelVendasItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelVendas.html"

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
        Dim count As Integer = 1
        Dim linha As Double = 1
        Dim tipoVenda As String
        Dim ret As String = ""
        Dim totallucro As Double
        Dim totalvenda As Double


        Try
            For Each d In listVendas

                If d.Tipo = 1 Then
                    tipoVenda = "<font color='blue'>Consumação</font>"
                Else
                    tipoVenda = "<font color='green'>Venda Avulsa</font>"
                End If

                linha = count / 2
                If linha.ToString.Contains(",5") Then

                    ret += strItens.Replace("{{datavenda}}", d.DataConsumacao) _
                        .Replace("{{nomeproduto}}", d.Produto.Nome) _
                        .Replace("{{valorproduto}}", FormatCurrency(d.ValorProduto, 2)) _
                        .Replace("{{qtdproduto}}", d.QtdProduto) _
                        .Replace("{{valortotalvenda}}", FormatCurrency(d.ValorTotalConsumo, 2)) _
                        .Replace("{{lucrovenda}}", FormatCurrency((d.ValorProduto - d.PrecoCompraProduto) * d.QtdProduto, 2)) _
                        .Replace("{{tipovenda}}", tipoVenda) _
                        .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                Else

                    ret += strItens.Replace("{{datavenda}}", d.DataConsumacao) _
                        .Replace("{{nomeproduto}}", d.Produto.Nome) _
                        .Replace("{{valorproduto}}", FormatCurrency(d.ValorProduto, 2)) _
                        .Replace("{{qtdproduto}}", d.QtdProduto) _
                        .Replace("{{valortotalvenda}}", FormatCurrency(d.ValorTotalConsumo, 2)) _
                        .Replace("{{lucrovenda}}", FormatCurrency((d.ValorProduto - d.PrecoCompraProduto) * d.QtdProduto, 2)) _
                        .Replace("{{tipovenda}}", tipoVenda) _
                        .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                End If
                count += 1
                totallucro += (d.ValorProduto - d.PrecoCompraProduto) * d.QtdProduto
                totalvenda += d.ValorProduto * d.QtdProduto

            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        ret = strRel.Replace("<dados></dados>", ret)

        lblTotalLucro.Text = FormatCurrency(totallucro, 2).ToString
        lblTotalLucro.Visible = True
        Label1.Visible = True

        lblTotalVenda.Text = FormatCurrency(totalvenda, 2).ToString
        lblTotalVenda.Visible = True
        Label2.Visible = True

        gbResumo.Visible = True


        Return ret

    End Function

    Private Sub MostraRelVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTipoVenda.SelectedIndex = 0
    End Sub

    Private Sub MostraRelVendas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class