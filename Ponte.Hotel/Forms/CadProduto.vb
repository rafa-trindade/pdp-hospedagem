Imports Ponte.Hotel.Dominio

Public Class CadProduto

    Private db As New DbContexto
    Private produto As clsProduto

    Private Sub CadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = novoCodigo()

        txtQtdEstoque.Text = 0

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

    Public Function novoCodigo() As String
        Dim db As New DbContexto
        Dim ret As clsProduto

        Try

            ret = (From u In db.Produto Select u Order By u.Id Descending).First
            Return "P00" & CType(ret.Id, Long) + 1

        Catch ex As Exception
            Return "P001"
        End Try

    End Function

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If txtPrecoVenda.Text <= 0 Then
            MsgBox("O preço de venda do Produto deve ser maior do que zero.", vbInformation, "Atenção")
            txtPrecoVenda.Focus()
            Exit Sub
        End If

        If txtPrecoCompra.Text <= 0 Then
            MsgBox("O preço de Compra do Produto deve ser maior do que zero.", vbInformation, "Atenção")
            txtPrecoCompra.Focus()
            Exit Sub
        End If

        If (Convert.ToDouble(Replace(txtPrecoCompra.Text, ",", "."))) > (Convert.ToDouble(Replace(txtPrecoVenda.Text, ",", "."))) Then
            MsgBox("O Preço de Venda deve ser maior que o preçco de compra.", vbInformation, "Atenção")
            txtPrecoCompra.Focus()
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

        If txtEstoqueMinimo.Text < 0 Then
            MsgBox("Valor de estoque mínimo inválido.", vbInformation, "Atenção")
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

        If String.IsNullOrEmpty(txtQtdEstoque.Text) Then
            MsgBox("O campo Tipo é Obrigatório", MsgBoxStyle.Information, "Atualizar Produto")
            txtQtdEstoque.Focus()
            Exit Sub
        End If

        If txtQtdEstoque.Text < 0 Then
            MsgBox("Quantidade em estoque inválida.", vbInformation, "Atenção")
            txtQtdEstoque.Focus()
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
                    .Status = 1
                    .QuantidadeEstoque = txtQtdEstoque.Text

                End With
            Else
                Dim dados As New clsProduto

                dados.Codigo = txtCodigo.Text
                dados.Nome = txtNomeProd.Text
                dados.Descricao = txtDescricao.Text
                dados.EstoqueMinimo = txtEstoqueMinimo.Text
                dados.PrecoVenda = txtPrecoVenda.Text
                dados.PrecoCompra = txtPrecoCompra.Text
                dados.Lucro = txtPrecoVenda.Text - txtPrecoCompra.Text
                Dim i As Integer = cbTipo.SelectedValue
                dados.TipoProduto = (From c In db.TipoProduto Where c.Id = i Select c).First
                dados.Status = 1
                dados.QuantidadeEstoque = txtQtdEstoque.Text

                db.Produto.Add(dados)
            End If

            db.SaveChanges()


            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastro de Cliente")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        produto = Nothing

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtDescricao.Text = ""
        txtEstoqueMinimo.Text = ""
        txtNomeProd.Text = ""
        txtPrecoVenda.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CadTipoProduto.ShowDialog(Me)
    End Sub

    Private Sub btnAcertoEstoque_Click(sender As Object, e As EventArgs) Handles btnAcertoEstoque.Click
        txtQtdEstoque.Enabled = True
        txtQtdEstoque.Focus()
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

    Private Sub CadProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub
End Class
