Imports Ponte.Hotel.Dominio

Public Class EditHospedagem
    Private db As New DbContexto
    Public hospedagem As clsHospedagem
    Private cliente As clsCliente
    Private lst As New List(Of Integer)
    Private id As Integer = 0
    Private tipoProd As New clsTipoProduto

    Dim StsAp As New clsApartamento

    ''PESQUISA CLIENTES NA GRID PESQUISA'''''''''''''''''''''''''''''''''''''
    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 5
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    ''SETA VALORES DA PESQUISA''''''''''''''''''''''''''''''''
    Public Sub setaValores(cod As String)
        txtCodHospedagem.Text = cod
        buscaPorCodigo()
    End Sub

    ''BUSCA HOSPEDAGEM PELO CODIGO''''''''''''''''''''''''''''
    Private Sub buscaPorCodigo()
        If txtCodHospedagem.Text = "" Then Exit Sub
        carregaApartamento()
        Try
            hospedagem = (From u In db.Hospedagem.Include("Cliente").Include("Apartamento").Include("NotaFiscal").Include("Movimentacao") Where u.Codigo = txtCodHospedagem.Text Select u).First

            If cbStatusPesq.Checked = False Then

                With hospedagem
                    carregaGrid()

                    Dim sts As String
                    If .Status = clsHospedagem.StatusCheckout.Aberto Then
                        sts = "Hospedagem Ativa"
                    Else
                        sts = "Hospedagem Finalizada"
                    End If

                    txtCpfCliente.Text = .Cliente.CPF
                    txtDesconto.Text = Format(.Desconto, "0.00")
                    txtNomeCliente.Text = .Cliente.Nome
                    txtTotal.Text = Format(.ValorTotal, "0.00")
                    Label7.Text = "Total Pago: R$"
                    txtTotalAPagar.Text = Format(.ValorPago, "0.00")
                    txtTotalDiarias.Text = .QuantidadeDiaria
                    dtEntrada.Text = .DataEntrada
                    dtHoraEntrada.Text = .DataEntrada
                    dtSaida.Text = .DataSaida
                    dtHoraSaida.Text = .DataSaida
                    cbApartamento.SelectedValue = IIf(IsNothing(.Apartamento), -1, .Apartamento.Id)
                    lblNumDiarias.Text = .QuantidadeDiaria
                    lbl01.Text = "(Apartamento " + .Apartamento.Descricao + ")"
                    lbl01.Visible = True
                    lblValorDiaria.Text = Format(.Apartamento.ValorDiaria, "0.00")
                    lblStatus.Text = sts
                    lblStatus.ForeColor = Color.Tomato
                    txtSinal.Text = Format(.Sinal, "0.00")
                    txtMostraSinal.Text = Format(.Sinal, "0.00")
                    lblNumPessoas.Text = .Apartamento.Capacidade & " Pessoa(s)"
                    txtObs.Text = .Obeservacao

                End With

                ExcluirToolStripMenuItem.Enabled = True
                gbDadosHospedagem.Enabled = True
                btFinalizar.Enabled = False
                btApDesc.Visible = False
                txtDesconto.Enabled = False
                btTrocarAp.Enabled = False
                lblStatus.Visible = False
                btAtualizarSinal.Enabled = False
                txtSinal.Enabled = False
                cbApartamento.Enabled = False
                cbTipoProd.Enabled = False
                cbProduto.Enabled = False
                numQtd.Enabled = False
                btAdd.Enabled = False
                grdItens.Enabled = False
                btConfAp.Enabled = False

            Else

                With hospedagem
                    carregaGrid()

                    Dim sts As String
                    If .Status = clsHospedagem.StatusCheckout.Aberto Then
                        sts = "Hospedagem Ativa"
                    Else
                        sts = "Hospedagem Finalizada"
                    End If
                    lblStatus.Text = sts
                    lblStatus.ForeColor = Color.SteelBlue
                    txtCpfCliente.Text = .Cliente.CPF
                    txtNomeCliente.Text = .Cliente.Nome
                    dtEntrada.Text = .DataEntrada
                    dtHoraEntrada.Text = .DataEntrada
                    cbApartamento.SelectedValue = IIf(IsNothing(.Apartamento), -1, .Apartamento.Id)

                    lblNumDiarias.Text = ((dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay).AddHours(-12) - .DataEntrada.AddHours(-12).Date).Days + 1


                    lbl01.Text = "(Apartamento " + .Apartamento.Descricao + ")"
                    lbl01.Visible = True

                    lblValorDiaria.Text = Format(.Apartamento.ValorDiaria, "0.00")

                    txtTotalDiarias.Text = Format(.Apartamento.ValorDiaria * lblNumDiarias.Text, "0.00")

                    txtTotal.Text = (.Apartamento.ValorDiaria * lblNumDiarias.Text) + txtCons.Text
                    txtTotal.Text = Format(txtTotal.Text * 1, "0.00")

                    txtSinal.Text = Format(.Sinal, "0.00")
                    txtMostraSinal.Text = Format(.Sinal, "0.00")
                    txtTotalAPagar.Text = ((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text)
                    txtTotalAPagar.Text = Format(((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text), "0.00")

                    txtDesconto.Text = "0,00"

                    lblNumPessoas.Text = .Apartamento.Capacidade & " Pessoa(s)"
                    txtObs.Text = .Obeservacao

                End With

                ExcluirToolStripMenuItem.Enabled = True
                btFinalizar.Enabled = True
                Label7.Text = "Total a Pagar: R$"
                gbDadosHospedagem.Enabled = True
                txtDesconto.Enabled = True
                btApDesc.Visible = True
                btApDesc.Enabled = True
                btTrocarAp.Enabled = False
                lblStatus.Visible = True
                cbApartamento.Enabled = True
                cbTipoProd.Enabled = True
                cbProduto.Enabled = True
                numQtd.Enabled = True
                btAdd.Enabled = True
                grdItens.Enabled = True

            End If

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")

        End Try
    End Sub

    'CONSUMAÇÃO
    ''DUPLO CLIQUE NO ITEM DA GRID. DELETAR CONSUMAÇÃO''''''''''''''''''''''''''''''''''''''''
    Private Sub grdItens_DoubleClick(sender As Object, e As EventArgs) Handles grdItens.DoubleClick
        If grdItens.Rows.Count <= 0 Then Exit Sub

        If MsgBox("Deseja exclir esse Produto?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then

            Dim cod = grdItens.SelectedRows(0).Cells(0).Value()
            Try

                Dim ret = (From c In db.Consumacao Where c.Id.Equals(CType(cod.ToString, Integer)) Select c).FirstOrDefault
                db.Consumacao.Remove(ret)
                db.SaveChanges()

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try
            If MsgBox("Deseja retornar item ao estoque?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then
                Dim dados As New clsConsumacao
                Try
                    Dim produto As New clsProduto
                    Dim p As Integer = grdItens.SelectedRows(0).Cells(5).Value()
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

    ''CARREGA A GRID DE CONSUMACAO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub carregaGrid()

        txtCons.Text = "0,00"

        Try
            grdItens.DataSource = (From c In db.Consumacao.Include("Produto").Include("Hospedagem") Where c.Hospedagem.Id = hospedagem.Id Select New With
            {Key .Id = c.Id, Key .Nome = c.Produto.Nome, Key .Quantidade = c.QtdProduto, Key .Preco = c.ValorProduto, Key .Total = c.QtdProduto * c.ValorProduto, Key .ProdId = c.Produto.Id}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try

        grdItens.Columns("Nome").HeaderText = "Produto"
        grdItens.Columns("Preco").HeaderText = "Preço"
        grdItens.Columns("Quantidade").HeaderText = "Qtd."
        grdItens.Columns("Total").HeaderText = "Total"

        grdItens.Columns("Id").Visible = False
        grdItens.Columns("ProdId").Visible = False

        grdItens.Columns("Nome").Width = grdItens.Width - 253
        grdItens.Columns("Preco").Width = 80
        grdItens.Columns("Quantidade").Width = 50
        grdItens.Columns("Total").Width = 80

        grdItens.Columns("Total").DefaultCellStyle.Format = "c"
        grdItens.Columns("Preco").DefaultCellStyle.Format = "c"

        preencheLst()

        With hospedagem
            txtTotal.Text = (.Apartamento.ValorDiaria * lblNumDiarias.Text) + txtCons.Text
        End With

        txtTotal.Text = Format(txtTotal.Text * 1, "0.00")

        txtTotalAPagar.Text = ((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text)
        txtTotalAPagar.Text = Format(((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text), "0.00")
    End Sub

    ''PREENCHE A LISTA DA GRID DE CONSUMAÇÃO''''''''''''''''''''''''''''''''''''''''''''
    Private Sub preencheLst()
        lst.Clear()
        For Each i As DataGridViewRow In grdItens.Rows
            lst.Add(i.Cells("Id").Value)
            txtCons.Text += i.Cells("Total").Value
        Next

        txtCons.Text = Format(txtCons.Text * 1, "0.00")
    End Sub

    ''BOTAO ADICIONAR NOVA CONSUMAÇÃO''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim dados As New clsConsumacao

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
                dados.Hospedagem = hospedagem
                dados.ValorTotalConsumo = dados.Produto.PrecoVenda * numQtd.Text
                dados.ValorProduto = dados.Produto.PrecoVenda
                dados.PrecoCompraProduto = dados.Produto.PrecoCompra

                dados.Produto.QuantidadeEstoque -= numQtd.Text

                dados.DataConsumacao = Now
                dados.Tipo = clsConsumacao.TipoConsumacao.Hospedagem

                db.Consumacao.Add(dados)
                db.SaveChanges()
                carregaGrid()

                cbTipoProd.SelectedIndex = -1
                cbProduto.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                Me.Dispose()
                Me.Close()
            End Try
        End If

        numQtd.Text = 1

    End Sub

    ''TXTBOX DESCONTO. TEXTO MOEDA''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        TextBoxMoeda(sender)
    End Sub

    ''TXTBOXDESCONTO. SO LE NUMEROS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub txtDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    ''TXTBOX QUNTINDADE. SO LE NUMEROS'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub txtQtd_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    ''BOTAO CADASTRAR NOVO APARTAMENTO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btCadApartamento_Click(sender As Object, e As EventArgs)
        cadApartamento.ShowDialog(Me)
    End Sub

    Private Sub cbTipoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoProd.SelectedIndexChanged
        If cbTipoProd.SelectedIndex = -1 Then Exit Sub

        carregaProduto(cbTipoProd.SelectedValue)
    End Sub

    Private Sub numQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numQtd.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    ''BOTAO APLICAR DESCONTO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btApDesc.Click
        ''If (Convert.ToDouble(Replace(txtTotalAPagar.Text, ",", "."))) < (Convert.ToDouble(Replace(txtDesconto.Text, ",", "."))) Then
        ''MsgBox("O valor do desconto não pode ser maior que o valor total a pagar.", vbInformation, "Atenção")
        ''txtDesconto.Focus()
        ''Exit Sub
        ''End If

        txtTotalAPagar.Text = ((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text)
        txtTotalAPagar.Text = Format(((txtTotal.Text - txtMostraSinal.Text) - txtDesconto.Text), "0.00")
    End Sub

    ''SETA VALORES AO ABRIR O FORMULÁRIO'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub EditHospedagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDadosHospedagem.Enabled = False
        btFinalizar.Enabled = False
        txtDesconto.Enabled = False
        btApDesc.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        txtCpfCliente.Enabled = False

        carregaApartamento()
        carregaTipo()
    End Sub

    ''CARREGA Apartamento'''''''''''''''''''''''''''''''
    Public Sub carregaApartamento()
        Try

            cbApartamento.DataSource = (From c In db.Apartamento Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbApartamento.SelectedIndex = 0

        cbApartamento.DisplayMember = "Nome"
        cbApartamento.ValueMember = "Id"
    End Sub

    ''CARREGA O TIPO DE PRODUTO'''''''''''''''''''''''''''''''
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

    ''CARREGA O PRODUTO'''''''''''''''''''''''''''''''''''''''''''''
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

    ''BOTAO CADASTRAR NOVA HOSPEDAGEM''''''''''''''''''''''''''''''''''''''''
    Private Sub btnCadNovoHosp_Click(sender As Object, e As EventArgs) Handles btnCadNovoHosp.Click
        CadHospedagem.ShowDialog(Me)
    End Sub

    ''BOTAO LIMPAR DADOS DA PESQUISA'''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        gbDadosHospedagem.Enabled = False
        btFinalizar.Enabled = False
        txtDesconto.Enabled = False
        btApDesc.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        txtCpfCliente.Enabled = False
   
        txtTotal.Text = "0,00"
        txtCpfCliente.Text = ""
        txtNomeCliente.Text = ""
        txtCodHospedagem.Text = ""
        lblStatus.Visible = False
    End Sub

    ''BOTAO SAIR DO FORMULARIO
    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        hospedagem = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    ''BOTÃO FINALIZAR HOSPEDAGEM
    Private Sub btFinalizar_Click(sender As Object, e As EventArgs) Handles btFinalizar.Click
        If IsNothing(hospedagem) Then
            MsgBox("Selcione uma Hospedagem.", MsgBoxStyle.Information, "Finalizar Hospedagem")
        End If
        FinalizarHospedagem.ShowDialog(Me)
    End Sub

    ''BOTÃO ATUALIZAR APARTAMENTO
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btTrocarAp.Click

        If cbApartamento.Text = "" Then
            MsgBox("Selcione um apartamento.", MsgBoxStyle.Information, "Atualizar Apartamento")
            cbApartamento.Focus()
            Exit Sub
        End If
        Try

            With hospedagem
                Dim apID As Integer = .Apartamento.Id
                Dim Ap1 As New clsApartamento
                Ap1 = (From b In db.Apartamento Where b.Id = apID Select b).First
                Ap1.Status = clsApartamento.StatusApartamento.Disponivel

                Dim d As Integer = cbApartamento.SelectedValue
                .Apartamento = (From c In db.Apartamento Where c.Id = d Select c).First

                Dim ap2 As New clsApartamento
                ap2 = (From f In db.Apartamento Where f.Id = d Select f).First
                ap2.Status = clsApartamento.StatusApartamento.Indisponivel

                db.SaveChanges()

                .ValorDiaria = .Apartamento.ValorDiaria
                db.SaveChanges()
            End With


            MsgBox("Apartamento da hospedagem atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Apartamento")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        hospedagem = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cbApartamento_Click(sender As Object, e As EventArgs) Handles cbApartamento.Click
        btTrocarAp.Enabled = True
        btConfAp.Enabled = False

        cbApartamento.DataSource = (From c In db.Apartamento Where c.Status = clsApartamento.StatusApartamento.Disponivel Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        cbApartamento.SelectedIndex = -1

        cbApartamento.DisplayMember = "Nome"
        cbApartamento.ValueMember = "Id"
    End Sub

    ''EXCLUIR HOSPEDAGEM
    Private Sub cmsExcluirHospInativa_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click

        If hospedagem.Status = clsHospedagem.StatusCheckout.Aberto Then

            If MsgBox("Deseja realmente excluir todos os registros da hospedagem " & txtCodHospedagem.Text & "?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then

                hospedagem.Apartamento.Status = clsApartamento.StatusApartamento.Disponivel
                Try
                    Dim cons = (From c In db.Consumacao.Include("Produto") Where c.Hospedagem.Id = hospedagem.Id Select c).ToList
                    Dim hosp = (From c In db.Hospedagem Where c.Codigo = txtCodHospedagem.Text Select c).FirstOrDefault

                    If MsgBox("Deseja retornar os itens da consumação ao estoque?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then
                        For Each h In cons
                            Dim produto As New clsProduto
                            produto = (From c In db.Produto Where c.Id = h.Produto.Id Select c).FirstOrDefault
                            produto.QuantidadeEstoque += h.QtdProduto
                        Next
                    End If

                    For Each h In cons
                        db.Consumacao.Remove(h)
                    Next

                    db.Hospedagem.Remove(hosp)

                    db.SaveChanges()

                    MsgBox("Registros de Hospedagem excluídos com sucesso.", MsgBoxStyle.Information, "Exclusão de Registro")

                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try
                hospedagem = Nothing

                Me.Dispose()
                Me.Close()
            End If

        Else

            If MsgBox("Deseja realmente excluir todos os registros da hospedagem " & txtCodHospedagem.Text & "?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then

                Try
                    Dim cons = (From c In db.Consumacao.Include("Produto") Where c.Hospedagem.Id = hospedagem.Id Select c).ToList
                    Dim nf = (From c In db.NotaFiscal Where c.Id = hospedagem.NotaFiscal.Id Select c).FirstOrDefault
                    Dim mov = (From c In db.Movimentacao Where c.Id = hospedagem.Movimentacao.Id Select c).FirstOrDefault
                    Dim hosp = (From c In db.Hospedagem Where c.Codigo = txtCodHospedagem.Text Select c).FirstOrDefault

                    If MsgBox("Deseja retornar os itens da consumação ao estoque?", MsgBoxStyle.YesNoCancel, "Gerenciar Consumo") = MsgBoxResult.Yes Then
                        For Each h In cons
                            Dim produto As New clsProduto
                            produto = (From c In db.Produto Where c.Id = h.Produto.Id Select c).FirstOrDefault
                            produto.QuantidadeEstoque += h.QtdProduto
                        Next
                    End If

                    For Each h In cons
                        db.Consumacao.Remove(h)
                    Next

                    db.NotaFiscal.Remove(nf)
                    db.Movimentacao.Remove(mov)
                    db.Hospedagem.Remove(hosp)

                    db.SaveChanges()

                    MsgBox("Registros de Hospedagem excluídos com sucesso.", MsgBoxStyle.Information, "Exclusão de Registro")

                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try
                hospedagem = Nothing

                Me.Dispose()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        hospedagem = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cbStatusPesq_CheckedChanged(sender As Object, e As EventArgs) Handles cbStatusPesq.CheckedChanged
        lblStatus.Text = ""
    End Sub

    Private Sub btAtualizarSinal_Click(sender As Object, e As EventArgs) Handles btAtualizarSinal.Click
        ''If (Convert.ToDouble(Replace(txtTotal.Text, ",", "."))) < (Convert.ToDouble(Replace(txtSinal.Text, ",", "."))) Then
        ''MsgBox("O valor do Sinal não pode ser maior que o valor Total da hospedagem!", MsgBoxStyle.Information, "Atualizar Apartamento")
        ''Exit Sub
        ''End If

        Try
            With hospedagem
                .Sinal = txtSinal.Text
                db.SaveChanges()
            End With

            db.SaveChanges()

            MsgBox("Valor do Sinal atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Apartamento")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        hospedagem = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtSinal_TextChanged(sender As Object, e As EventArgs) Handles txtSinal.TextChanged
        TextBoxMoeda(sender)
        btAtualizarSinal.Enabled = True
    End Sub

    Private Sub txtSinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSinal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMostraSinal_TextChanged(sender As Object, e As EventArgs) Handles txtMostraSinal.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub EditHospedagem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        hospedagem = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btConfAp.Click
        EditApartamento.ShowDialog(Me)
    End Sub

    Private Sub EditHospedagem_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub


End Class