Imports Ponte.Hotel.Dominio
Imports System.Globalization
Imports System.Threading

Public Class Movimentacao

    Private db As New DbContexto
    Private lst As New List(Of Integer)
    Private lst2 As New List(Of Integer)
    Private totalEntrada As Double = 0
    Private totalSaida As Double = 0
    Private listHospedagem As New List(Of clsHospedagem)
    Private sinal As Double = 0
    Private listEntradaAnterior As New List(Of clsMovimentacao)
    Private listSaidaAnterior As New List(Of clsMovimentacao)
    Private totalEntradaAnterior As Double = 0
    Private totalSaidaAnterior As Double = 0
    Private limit As DateTime
    Private caixaAnterior As Double

    Private Sub carregaGridEntrada()

        Try
            grdEntrada.DataSource = (From c In db.Movimentacao Order By c.DataMovimentacao Descending Where c.Tipo = clsMovimentacao.TipoMovimentacao.Entrada And (c.DataMovimentacao.Month.ToString = dtMes.Value.Month And c.DataMovimentacao.Year.ToString = dtMes.Value.Year) Select New With
            {Key .Id = c.Id, Key .DataMovimentacao = c.DataMovimentacao, Key .Descricao = c.Descricao, Key .Total = c.Valor}).ToList()

        Catch ex As Exception
        End Try

        grdEntrada.Columns("DataMovimentacao").HeaderText = "Data Entrada"
        grdEntrada.Columns("Descricao").HeaderText = "Descrição Movimentação"
        grdEntrada.Columns("Total").HeaderText = "Valor Entrada"


        grdEntrada.Columns("Descricao").Width = grdEntrada.Width - 237
        grdEntrada.Columns("DataMovimentacao").Width = 100
        grdEntrada.Columns("Total").Width = 94

        grdEntrada.Columns("Total").DefaultCellStyle.Format = "c"

        grdEntrada.Columns("Id").Visible = False

        preencheLstEntrada()

    End Sub

    Private Sub carregaGridSaida()
        Try
            grdSaida.DataSource = (From c In db.Movimentacao Order By c.DataMovimentacao Descending Where c.Tipo = clsMovimentacao.TipoMovimentacao.Saida And (c.DataMovimentacao.Month.ToString = dtMes.Value.Month And c.DataMovimentacao.Year.ToString = dtMes.Value.Year) Select New With
            {Key .Id = c.Id, Key .DataMovimentacao = c.DataMovimentacao, Key .Descricao = c.Descricao, Key .Total = c.Valor}).ToList()
        Catch ex As Exception
        End Try

        grdSaida.Columns("DataMovimentacao").HeaderText = "Data Saída"
        grdSaida.Columns("Descricao").HeaderText = "Descrição Movimentação"
        grdSaida.Columns("Total").HeaderText = "Valor Saída"


        grdSaida.Columns("Descricao").Width = grdEntrada.Width - 237
        grdSaida.Columns("DataMovimentacao").Width = 100
        grdSaida.Columns("Total").Width = 94

        grdSaida.Columns("Total").DefaultCellStyle.Format = "c"

        grdSaida.Columns("Id").Visible = False

        preencheLstSaida()

        txtLucro.Text = FormatCurrency((totalEntrada - totalSaida), 2)


        'txtFundoAnterior.Text = FormatCurrency(txtFundoAnterior.Text, 2)



        txtTotSinal.Text = FormatCurrency(sinal, 2)
        txtCaixa.Text = FormatCurrency(((totalEntrada - totalSaida) + sinal + txtFundoAnterior.Text), 2)

    End Sub


    Private Sub preencheLstEntrada()

        totalEntrada = 0
        lst.Clear()
        For Each i As DataGridViewRow In grdEntrada.Rows
            lst.Add(i.Cells("Id").Value)
            totalEntrada += i.Cells("Total").Value
        Next

        lblTotalEntrada.Text = "Total: " & FormatCurrency(totalEntrada.ToString, 2)
    End Sub

    Private Sub preencheLstSaida()
        totalSaida = 0
        lst2.Clear()
        For Each i As DataGridViewRow In grdSaida.Rows
            lst2.Add(i.Cells("Id").Value)
            totalSaida += i.Cells("Total").Value
        Next
        lblTotalSaida.Text = "Total: " & FormatCurrency(totalSaida.ToString, 2)
        txtLucro.Text = "R$"

    End Sub

    Private Sub Movimentacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        ''Label3.Text = "*movimentações do mês de " + Now.ToString("MMMM").ToUpper

        listHospedagem = (From i In db.Hospedagem Where i.Status = clsHospedagem.StatusCheckout.Aberto And i.Sinal > 0 Select i).ToList
        For Each cont As clsHospedagem In listHospedagem
            sinal += cont.Sinal
        Next

        dtMes.ShowUpDown = True
        dtMes.Format = DateTimePickerFormat.Custom
        dtMes.CustomFormat = "MMMMyyyy"

        ''carregaMesAnterior()
        carregaGridEntrada()
        carregaGridSaida()
    End Sub

    Private Sub txtPrecoVenda_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        Dim movimentacao As New clsMovimentacao
        Try

            With movimentacao
                .Tipo = clsMovimentacao.TipoMovimentacao.Saida
                .DataMovimentacao = dtMov.Text
                .Descricao = cbDescricao.Text & ". Saída no valor de " & FormatCurrency(txtValor.Text, 2)
                .Valor = txtValor.Text
            End With

            db.Movimentacao.Add(movimentacao)
            db.SaveChanges()

            MsgBox("Saída Cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastro de Saída")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        movimentacao = Nothing
        cbDescricao.selectedIndex = 0
        txtValor.Text = "0,00"

        'carregaMesAnterior()
        carregaGridSaida()


    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub grdSaida_DoubleClick(sender As Object, e As EventArgs) Handles grdSaida.DoubleClick

        If grdSaida.Rows.Count <= 0 Then Exit Sub

        If MsgBox("Deseja exclir esse registro?", MsgBoxStyle.YesNoCancel, "Movimentação") = MsgBoxResult.Yes Then

            Dim cod = grdSaida.SelectedRows(0).Cells(0).Value()

            Try

                Dim ret = (From c In db.Movimentacao Where c.Id.Equals(CType(cod.ToString, Integer)) Select c).FirstOrDefault
                db.Movimentacao.Remove(ret)
                db.SaveChanges()

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

        End If

        'carregaMesAnterior()
        carregaGridSaida()

    End Sub

    Private Sub btnRelatorios_Click(sender As Object, e As EventArgs) Handles btnRelatorios.Click
        MostraRelMovimentacao.ShowDialog(Me)
    End Sub

    Private Sub btVales_Click(sender As Object, e As EventArgs) Handles btVales.Click
        CadVale.ShowDialog(Me)
    End Sub

    Private Sub dtMes_ValueChanged(sender As Object, e As EventArgs) Handles dtMes.ValueChanged
        carregaGridEntrada()
        carregaGridSaida()


        listEntradaAnterior = (From i In db.Movimentacao Where i.DataMovimentacao.Month.ToString < dtMes.Value.Month And i.Tipo = clsMovimentacao.TipoMovimentacao.Entrada Select i).ToList
        listSaidaAnterior = (From i In db.Movimentacao Where i.DataMovimentacao.Month.ToString < dtMes.Value.Month And i.Tipo = clsMovimentacao.TipoMovimentacao.Saida Select i).ToList

        totalEntradaAnterior = 0
        For Each cont As clsMovimentacao In listEntradaAnterior
            totalEntradaAnterior += cont.Valor
        Next

        totalSaidaAnterior = 0
        For Each cont As clsMovimentacao In listSaidaAnterior
            totalSaidaAnterior += cont.Valor
        Next

        'txtFundoAnterior.Text = FormatCurrency(totalEntradaAnterior - totalSaidaAnterior, 2)

    End Sub

    Private Sub carregaMesAnterior()

        limit = Now.AddMonths(-1)

        listEntradaAnterior = (From i In db.Movimentacao Where i.DataMovimentacao.Month.ToString <= limit.Month.ToString And i.Tipo = clsMovimentacao.TipoMovimentacao.Entrada Select i).ToList
        listSaidaAnterior = (From i In db.Movimentacao Where i.DataMovimentacao.Month.ToString <= limit.Month.ToString And i.Tipo = clsMovimentacao.TipoMovimentacao.Saida Select i).ToList

        totalEntradaAnterior = 0
        For Each cont As clsMovimentacao In listEntradaAnterior
            totalEntradaAnterior += cont.Valor
        Next

        totalSaidaAnterior = 0
        For Each cont As clsMovimentacao In listSaidaAnterior
            totalSaidaAnterior += cont.Valor
        Next

        txtFundoAnterior.Text = FormatCurrency(totalEntradaAnterior - totalSaidaAnterior, 2)

    End Sub

    Private Sub Movimentacao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class