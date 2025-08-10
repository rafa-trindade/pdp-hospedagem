Imports Ponte.Hotel.Dominio


Public Class CadVendaProduto

    Private db As New DbContexto
    Private lst As New List(Of Integer)
    Private id As Integer = 0

    ''CARREGA A GRID DE CONSUMACAO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub carregaGrid()

        Try
            grdItens.DataSource = (From c In db.Consumacao.Include("Produto") Order By c.DataConsumacao Descending Where c.Tipo = clsConsumacao.TipoConsumacao.Avulsa And c.DataConsumacao.Value.Month.ToString = dtAtual.Value.Month.ToString Select New With
            {Key .Id = c.Id, Key .Nome = c.Produto.Nome, Key .Quantidade = c.QtdProduto, Key .Preco = c.ValorProduto, Key .Total = c.QtdProduto * c.ValorProduto, Key .DataVenda = c.DataConsumacao, Key .ProdId = c.Produto.Id}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

        grdItens.Columns("Nome").HeaderText = "Produto"
        grdItens.Columns("Preco").HeaderText = "Preço"
        grdItens.Columns("Quantidade").HeaderText = "Qtd."
        grdItens.Columns("Total").HeaderText = "Total"
        grdItens.Columns("DataVenda").HeaderText = "Data da Venda"

        grdItens.Columns("Id").Visible = False

        grdItens.Columns("Nome").Width = grdItens.Width - 313
        grdItens.Columns("Preco").Width = 50
        grdItens.Columns("Quantidade").Width = 50
        grdItens.Columns("Total").Width = 50
        grdItens.Columns("DataVenda").Width = 150

        grdItens.Columns("Total").DefaultCellStyle.Format = "c"
        grdItens.Columns("Preco").DefaultCellStyle.Format = "c"

        preencheLst()

    End Sub

    Private Sub preencheLst()
        Dim total As Double = 0
        lst.Clear()
        For Each i As DataGridViewRow In grdItens.Rows
            lst.Add(i.Cells("Id").Value)
            total += i.Cells("Total").Value
        Next
        lblTotal.Text = "Total: " & FormatCurrency(total, 2)
    End Sub

    Private Sub CadVendaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAtual.CustomFormat = "MMMM"
        dtAtual.Visible = False
        Label1.Text = "*Vendas Avulsas do mês de " & Char.ToUpper(dtAtual.Text(0)) + dtAtual.Text.Substring(1)
        carregaTipo()
        carregaGrid()
        txtValorProd.Text = "0,00"
    End Sub

    Public Sub carregaTipo()
        cbTipoProd.DisplayMember = "Descricao"
        cbTipoProd.ValueMember = "Id"

        Try
            cbTipoProd.DataSource = (From c In db.TipoProduto Order By c.Descricao Select New With {Key .Id = c.Id, Key .Descricao = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbTipoProd.SelectedIndex = -1
    End Sub

    Private Sub cbTipoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoProd.SelectedIndexChanged
        If cbTipoProd.SelectedIndex = -1 Then Exit Sub
        carregaProduto(cbTipoProd.SelectedValue)
    End Sub

    Public Sub carregaProduto(id As Integer)
        cbProduto.DisplayMember = "Nome"
        cbProduto.ValueMember = "Id"

        Try
            cbProduto.DataSource = (From c In db.Produto Where c.TipoProduto.Id = id And c.Status = clsProduto.StatusProd.Ativo Order By c.Nome Select New With {Key .Id = c.Id, Key .Nome = c.Nome}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbProduto.SelectedIndex = -1
    End Sub


    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim dados As New clsConsumacao
        Dim movimentacao As New clsMovimentacao

        If cbTipoProd.SelectedIndex = -1 Then
            MsgBox("Selecione um Tipo de Produto.", MsgBoxStyle.Information, "Gerenciar Consumo")
            Exit Sub
        End If

        If cbProduto.SelectedIndex = -1 Then
            MsgBox("Selecione um Produto.", MsgBoxStyle.Information, "Gerenciar Consumo")
            Exit Sub
        End If

        If String.IsNullOrEmpty(numQtd.Text) Then
            MsgBox("Digite uma Quantidade", MsgBoxStyle.Information, "Gerenciar Consumo")
            numQtd.Focus()
            Exit Sub
        End If

        If (numQtd.Text <= 0) Then
            MsgBox("Quantidade Inválida. Digite um número maior que 0.", MsgBoxStyle.Exclamation, "Gerenciar Consumo")
            numQtd.Focus()
            Exit Sub
        End If

        If MsgBox("Confirma: " & vbCrLf & vbCrLf & "Produto: " & cbProduto.Text & vbCrLf & "Quantidade: " & numQtd.Text, MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then

            Dim pro As New clsProduto
            Dim pr As Integer = cbProduto.SelectedValue
            pro = (From c In db.Produto Where c.Id = pr Select c).FirstOrDefault
            If (pro.QuantidadeEstoque < numQtd.Text) Then
                MsgBox("Quantidade do Produto Indisponível em Estoque.", MsgBoxStyle.Information, "Gerenciar Consumo")
                numQtd.Focus()
                Exit Sub
            End If

            Try
                Dim produto As New clsProduto
                Dim p As Integer = cbProduto.SelectedValue

                dados.Produto = (From c In db.Produto Where c.Id = p Select c).FirstOrDefault
                dados.QtdProduto = numQtd.Text
                dados.ValorTotalConsumo = txtValorProd.Text * numQtd.Text
                dados.Tipo = clsConsumacao.TipoConsumacao.Avulsa
                dados.DataConsumacao = Now.ToShortDateString
                dados.ValorProduto = txtValorProd.Text
                dados.PrecoCompraProduto = dados.Produto.PrecoCompra

                dados.Produto.QuantidadeEstoque -= numQtd.Text

                dados.Movimentacao = movimentacao

                db.Consumacao.Add(dados)


                cbTipoProd.SelectedIndex = -1
                cbProduto.SelectedIndex = -1

                movimentacao.DataMovimentacao = Now
                movimentacao.Descricao = "Venda avulsa de " & numQtd.Text & " " & dados.Produto.Nome & " no total de R$ " & Format(dados.ValorProduto * numQtd.Text, "0.00") & "."
                movimentacao.Tipo = clsMovimentacao.TipoMovimentacao.Entrada
                movimentacao.Valor = txtValorProd.Text * numQtd.Text

                db.Movimentacao.Add(movimentacao)

                db.SaveChanges()

                carregaGrid()


            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try
        End If

        numQtd.Text = 1

    End Sub

    Private Sub grdItens_DoubleClick(sender As Object, e As EventArgs) Handles grdItens.DoubleClick
        If grdItens.Rows.Count <= 0 Then Exit Sub

        If MsgBox("Deseja exclir esse Produto?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then

            Dim cod = grdItens.SelectedRows(0).Cells(0).Value()

            Try
                Dim ret = (From c In db.Consumacao.Include("Movimentacao") Where c.Id.Equals(CType(cod.ToString, Integer)) Select c).FirstOrDefault

                Dim retMov As New clsMovimentacao
                retMov = (From c In db.Movimentacao Where ret.Movimentacao.Id = c.Id Select c).FirstOrDefault

                db.Consumacao.Remove(ret)
                db.Movimentacao.Remove(retMov)

                db.SaveChanges()

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

            If MsgBox("Deseja retornar item ao estoque?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then
                Dim dados As New clsConsumacao
                Try
                    Dim produto As New clsProduto
                    Dim p As Integer = grdItens.SelectedRows(0).Cells(6).Value()
                    Dim qtd = grdItens.SelectedRows(0).Cells(2).Value()

                    produto = (From c In db.Produto Where c.Id.Equals(CType(p.ToString, Integer)) Select c).FirstOrDefault
                    produto.QuantidadeEstoque += qtd

                    db.SaveChanges()

                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try
            End If

            carregaGrid()
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadVendaProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        If cbProduto.SelectedIndex = -1 Then Exit Sub
        carregaPrecoProduto(cbProduto.SelectedValue)
    End Sub


    Private Sub carregaPrecoProduto(id As Integer)
        Try
            txtValorProd.Text = Format((From c In db.Produto Where c.Id = id Select c.PrecoVenda).FirstOrDefault, "0.00")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

    End Sub

    Private Sub txtSinal_TextChanged(sender As Object, e As EventArgs) Handles txtValorProd.TextChanged
        TextBoxMoeda(sender)

    End Sub

    Private Sub txtSinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorProd.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRelatorios_Click(sender As Object, e As EventArgs) Handles btnRelatorios.Click
        MostraRelVendas.ShowDialog(Me)
    End Sub

    Private Sub CadVendaProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class