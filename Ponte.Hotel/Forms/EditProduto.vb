Imports Ponte.Hotel.Dominio

Public Class EditProduto

    Private db As New DbContexto
    Private produto As clsProduto

    Private Sub btPesqProd_Click(sender As Object, e As EventArgs) Handles btPesqProd.Click

        Try
            Pesquisa.nome = txtNomeProd.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 3
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")

        End Try

    End Sub

    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs) Handles txtCodigo.Enter
        If txtCodigo.Text = "" Then Exit Sub

        LimparCampos(GroupBox2)
        txtCodigo.Text = ""

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        buscaPorCodigo()
    End Sub

    Public Sub buscaPorCodigo()

        If txtCodigo.Text = "" Then Exit Sub

        Try
            produto = (From u In db.Produto.Include("TipoProduto") Where u.Codigo = txtCodigo.Text Select u).First

            With produto

                Dim sts As Integer
                If .Status = clsProduto.StatusProd.Ativo Then
                    sts = 1
                Else
                    sts = 0
                End If

                txtNomeProd.Text = .Nome
                txtDescricao.Text = .Descricao
                txtEstoqueMinimo.Text = .EstoqueMinimo
                txtPrecoVenda.Text = Format(.PrecoVenda, "Standard")
                txtPrecoCompra.Text = Format(.PrecoCompra, "Standard")
                txtQtdEstoque.Text = .QuantidadeEstoque
                cbTipo.SelectedValue = IIf(IsNothing(.TipoProduto), -1, .TipoProduto.Id)
                cbStatus.SelectedValue = sts

                If txtQtdEstoque.Text < .EstoqueMinimo Then
                    lblQtdEstoque.Visible = True
                    lblQtdEstoque.Text = "*Produto com estoque abaixo do mínimo."
                Else
                    lblQtdEstoque.Visible = False
                End If

                txtNomeProd.Focus()
            End With

            GroupBox2.Enabled = True
            Label15.Enabled = True
            btnAcertoEstoque.Enabled = True
            btSalvar.Enabled = True

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try


    End Sub

    Public Sub setaValores(cod As String)
        txtCodigo.Text = cod
        buscaPorCodigo()
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click


        If txtPrecoVenda.Text <= 0 Then
            MsgBox("O preço do produto deve ser maior do que zero.", MsgBoxStyle.Information, "Atenção")
            txtPrecoVenda.Focus()
            Exit Sub
        End If

        If txtPrecoCompra.Text <= 0 Then
            MsgBox("O preço de Compra do Produto deve ser maior do que zero.", vbInformation, "Atenção")
            txtPrecoCompra.Focus()
            Exit Sub
        End If

        If (Convert.ToDouble(Replace(txtPrecoVenda.Text, ",", "."))) < (Convert.ToDouble(Replace(txtPrecoCompra.Text, ",", "."))) Then
            MsgBox("O Preço de Venda deve ser maior que o preço de compra.", vbInformation, "Atenção")
            txtPrecoCompra.Focus()
            Exit Sub
        End If

        If txtQtdEstoque.Text < 0 Then
            MsgBox("Quantidade em estoque inválida.", MsgBoxStyle.Information, "Atenção")
            txtQtdEstoque.Focus()
            Exit Sub
        End If

        If txtQtdEstoque.Text < 0 Then
            MsgBox("Valor de estoque mínimo inválido.", MsgBoxStyle.Information, "Atenção")
            txtEstoqueMinimo.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeProd.Text) Then
            MsgBox("O campo Nome é obrigatório.", MsgBoxStyle.Information, "Atualizar Produto")
            txtNomeProd.Focus()
            Exit Sub
        End If


        If String.IsNullOrEmpty(txtEstoqueMinimo.Text) Then
            MsgBox("O campo Estoque Mínimo é obrigatório para que o sistema possa controlar o estoque.", MsgBoxStyle.Information, "Atualizar Produto")
            txtEstoqueMinimo.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPrecoVenda.Text) Then
            MsgBox("O campo Preço de Venda é Obrigatório", MsgBoxStyle.Information, "Atualizar Produto")
            txtPrecoVenda.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(cbTipo.SelectedValue) Then
            MsgBox("O campo Tipo é Obrigatório", MsgBoxStyle.Information, "Atualizar Produto")
            cbTipo.Focus()
            Exit Sub
        End If
        Try

            If Not IsNothing(produto) AndAlso Not String.IsNullOrEmpty(produto.Nome) Then
                With produto
                    .Nome = txtNomeProd.Text
                    .Descricao = txtDescricao.Text
                    .EstoqueMinimo = txtEstoqueMinimo.Text
                    .PrecoVenda = txtPrecoVenda.Text
                    .PrecoCompra = txtPrecoCompra.Text
                    .Lucro = txtPrecoVenda.Text - txtPrecoCompra.Text
                    Dim i As Integer = cbTipo.SelectedValue
                    .TipoProduto = (From c In db.TipoProduto Where c.Id = i Select c).First
                    .Status = cbStatus.SelectedValue
                    .QuantidadeEstoque = txtQtdEstoque.Text

                End With
            Else
                Dim dados As New clsProduto

                dados.Codigo = txtCodigo.Text
                dados.Nome = txtNomeProd.Text
                dados.Descricao = txtDescricao.Text
                dados.EstoqueMinimo = txtEstoqueMinimo.Text
                dados.PrecoVenda = txtPrecoVenda.Text
                Dim i As Integer = cbTipo.SelectedValue
                dados.TipoProduto = (From c In db.TipoProduto Where c.Id = i Select c).First
                dados.Status = 1
                dados.QuantidadeEstoque = txtQtdEstoque.Text

                db.Produto.Add(dados)
            End If

            db.SaveChanges()

            MsgBox("Produto atualizado com sucesso!", MsgBoxStyle.Information, "Atualizar Produto")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        produto = Nothing

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CadTipoProduto.ShowDialog(Me)
    End Sub

    Private Sub txtDescricao_Click(sender As Object, e As EventArgs) Handles txtDescricao.Click
        If String.Equals(txtDescricao.Text, "Descrição do Produto") Then
            txtDescricao.Text = ""
        End If
    End Sub

    Private Sub txtDescricao_Leave(sender As Object, e As EventArgs) Handles txtDescricao.Leave

        If String.IsNullOrEmpty(txtDescricao.Text) Then
            txtDescricao.Text = "Descrição do Produto"
        End If

    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCodigo.Text = ""
        txtNomeProd.Text = ""
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnAcertoEstoque_Click(sender As Object, e As EventArgs) Handles btnAcertoEstoque.Click
        txtQtdEstoque.Enabled = True
        txtQtdEstoque.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCadNovoProd.Click
        CadProduto.ShowDialog(Me)
    End Sub

    Private Sub EditProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaStatus()

        GroupBox2.Enabled = False
        Label15.Enabled = False
        btnAcertoEstoque.Enabled = False
        btSalvar.Enabled = False

        Try

            cbTipo.DataSource = (From c In db.TipoProduto Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbTipo.SelectedIndex = -1

        cbTipo.DisplayMember = "Nome"
        cbTipo.ValueMember = "Id"
    End Sub

    Private Sub carregaStatus()
        cbStatus.DisplayMember = "getName"
        cbStatus.ValueMember = "getId"

        Dim vals As New ArrayList
        vals.Add(New SatausP("Ativo", 1))
        vals.Add(New SatausP("Inativo", 0))

        cbStatus.DataSource = vals

        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub txtPreco_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoVenda.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub txtPreco_Enter(sender As Object, e As KeyPressEventArgs) Handles txtPrecoVenda.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoqueMinimo_Enter(sender As Object, e As KeyPressEventArgs) Handles txtEstoqueMinimo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtdEstoque_Enter(sender As Object, e As KeyPressEventArgs) Handles txtQtdEstoque.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecoCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoCompra.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub txtPrecoCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoCompra.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub EditProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EditProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class

Public Structure SatausP
    Private Nome As String
    Private Id As Integer
    Public Sub New(ByVal nomep As String, ByVal idp As Integer)
        Nome = nomep
        Id = idp
    End Sub
    Public ReadOnly Property getName() As String
        Get
            Return Nome
        End Get
    End Property

    Public ReadOnly Property getId() As Integer
        Get
            Return Id
        End Get
    End Property
End Structure