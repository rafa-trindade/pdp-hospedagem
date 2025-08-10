Imports Ponte.Hotel.Dominio

Public Class MostraRelEstoque

    Private db As New DbContexto
    Private produto As clsProduto
    Private listProdutos As New List(Of clsProduto)


    Private Sub btPesqProd_Click(sender As Object, e As EventArgs) Handles btPesqProd.Click
        Try
            Pesquisa.nome = txtNomeProd.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 10
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    ''MONTA ITENS"""""""""""""""""""""""""
    Private Function montaItens(strItens As String, strRel As String) As String
        Dim count As Integer = 1
        Dim linha As Double = 1
        Dim stsEstoque As String
        Dim ret As String = ""
        Try
            For Each d In listProdutos

                If d.QuantidadeEstoque < 1 Then
                    stsEstoque = "<font color='red'>Sem Estoque</font>"
                ElseIf d.QuantidadeEstoque < d.EstoqueMinimo Then
                    stsEstoque = "<font color='blue'>Abaixo do Mínimo</font>"
                Else
                    stsEstoque = "<font color='green'>Disponível</font>"
                End If

                linha = count / 2
                If linha.ToString.Contains(",5") Then

                    ret += strItens.Replace("{{codigoproduto}}", d.Codigo) _
                        .Replace("{{nomeproduto}}", d.Nome) _
                        .Replace("{{tipoproduto}}", d.TipoProduto.Descricao) _
                        .Replace("{{estoqueminimo}}", d.EstoqueMinimo) _
                        .Replace("{{qtdestoque}}", d.QuantidadeEstoque) _
                        .Replace("{{precocompra}}", FormatCurrency(d.PrecoCompra, 2)) _
                        .Replace("{{statusestoque}}", stsEstoque) _
                        .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                Else

                    ret += strItens.Replace("{{codigoproduto}}", d.Codigo) _
                        .Replace("{{nomeproduto}}", d.Nome) _
                        .Replace("{{tipoproduto}}", d.TipoProduto.Descricao) _
                        .Replace("{{estoqueminimo}}", d.EstoqueMinimo) _
                        .Replace("{{qtdestoque}}", d.QuantidadeEstoque) _
                        .Replace("{{precocompra}}", FormatCurrency(d.PrecoCompra, 2)) _
                        .Replace("{{statusestoque}}", stsEstoque) _
                    .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                End If
                count += 1
            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        ret = strRel.Replace("<dados></dados>", ret)

        Return ret

    End Function


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

    Public Sub setaValores(cod As String)
        txtCodigo.Text = cod
        buscaPorCodigo()
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

    Private Sub btLimpar_Click(sender As Object, e As EventArgs)
        wbRels.DocumentText = ""
        txtCodigo.Text = ""
        txtNomeProd.Text = ""
    End Sub

    Private Sub MostraRelEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Enabled = False
        cbStatusProduto.SelectedIndex = 0
    End Sub

    Private Sub btGerar_Click(sender As Object, e As EventArgs) Handles btGerar.Click
        lblNumRegistros.Text = "Número de Registros: "

        If Not ckProdutos.Checked Then

            If cbStatusProduto.SelectedIndex = 1 Then
                Try
                    listProdutos = (From c In db.Produto.Include("TipoProduto") Order By c.Nome Where c.Status = clsProduto.StatusProd.Ativo And (c.QuantidadeEstoque < c.EstoqueMinimo AndAlso Not c.QuantidadeEstoque < 1) Select c).ToList
                    If listProdutos.Count < 1 Then
                        MsgBox("Nenhum produto com estoque abaixo do mínimo.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            ElseIf cbStatusProduto.SelectedIndex = 2 Then
                Try
                    listProdutos = (From c In db.Produto.Include("TipoProduto") Order By c.Nome Where c.Status = clsProduto.StatusProd.Ativo And c.QuantidadeEstoque < 1 Select c).ToList
                    If listProdutos.Count < 1 Then
                        MsgBox("Nenhum produto sem estoque.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try

            Else
                Try
                    listProdutos = (From c In db.Produto.Include("TipoProduto") Order By c.Nome Where c.Status = clsProduto.StatusProd.Ativo Select c).ToList
                    If listProdutos.Count < 1 Then
                        MsgBox("Nenhum produto não encontrado.", MsgBoxStyle.Information, "Relatório")
                    End If
                Catch ex As Exception
                    MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
                End Try
            End If

        Else

            Try
                listProdutos = (From c In db.Produto.Include("TipoProduto") Order By c.Nome Where c.Codigo = txtCodigo.Text And c.Status = clsProduto.StatusProd.Ativo Select c).ToList
                If listProdutos.Count < 1 Then
                    MsgBox("Produto não encontrado.", MsgBoxStyle.Information, "Relatório")
                    btPesqProd.PerformClick()
                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

        End If

        lblNumRegistros.Text += listProdutos.Count.ToString
        lblNumRegistros.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelEstoqueItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelEstoque.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        listProdutos = Nothing
        produto = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ckProdutos_CheckedChanged(sender As Object, e As EventArgs) Handles ckProdutos.CheckedChanged
        txtNomeProd.Enabled = ckProdutos.Checked
        btPesqProd.Enabled = ckProdutos.Checked
        btLimpar.Enabled = ckProdutos.Checked

        cbStatusProduto.Enabled = Not ckProdutos.Checked
        Label1.Enabled = Not ckProdutos.Checked
        cbStatusProduto.SelectedIndex = 0

        wbRels.DocumentText = ""

    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs)
        wbRels.ShowPrintPreviewDialog()
    End Sub

    Private Sub btLimpar_Click_1(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCodigo.Text = ""
        txtNomeProd.Text = ""
    End Sub

    Private Sub MostraRelEstoque_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelEstoque_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class