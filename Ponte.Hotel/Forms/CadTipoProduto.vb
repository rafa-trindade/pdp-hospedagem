Imports Ponte.Hotel.Dominio

Public Class CadTipoProduto

    Private db As New DbContexto
    Private id As Integer = 0
    Private anterior As String

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        carregaTipo()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadTipoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            grdTipos.DataSource = (From c In db.TipoProduto Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdTipos.Columns("Codigo").HeaderText = "Código"
        grdTipos.Columns("Descricao").HeaderText = "Nome"

        grdTipos.Columns("Codigo").Width = 50
        grdTipos.Columns("Descricao").Width = grdTipos.Width - 60

    End Sub

    Public Sub carregaTipo()
        'Dim db As New EstoqueContexto

        Try
            CadProduto.cbTipo.DataSource = (From c In db.TipoProduto Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        CadProduto.cbTipo.SelectedIndex = -1

        CadProduto.cbTipo.DisplayMember = "Nome"
        CadProduto.cbTipo.ValueMember = "Id"

        Try
            EditProduto.cbTipo.DataSource = (From c In db.TipoProduto Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()


        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        EditProduto.cbTipo.SelectedIndex = -1

        EditProduto.cbTipo.DisplayMember = "Nome"
        EditProduto.cbTipo.ValueMember = "Id"

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim dados As clsTipoProduto

        If String.IsNullOrWhiteSpace(txtTipo.Text) Then
            MsgBox("Digite o nome do tipo.", MsgBoxStyle.Information, "Atenção")
            Exit Sub
        End If

        Try

            If id > 0 Then
                If MsgBox("Deseja atualizar o tipo '" & txtTipo.Text & "'?", MsgBoxStyle.YesNoCancel, "Atenção") = MsgBoxResult.Yes Then
                    dados = (From c In db.TipoProduto Where c.Id = id Select c).First
                    dados.Descricao = txtTipo.Text
                End If
            Else
                dados = New clsTipoProduto
                dados.Descricao = txtTipo.Text
                db.TipoProduto.Add(dados)
            End If

            db.SaveChanges()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        id = 0
        txtTipo.Text = ""

        Try
            grdTipos.DataSource = (From c In db.TipoProduto Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
    End Sub

    Private Sub grdTipos_DoubleClick(sender As Object, e As EventArgs) Handles grdTipos.DoubleClick
        id = grdTipos.SelectedRows(0).Cells(0).Value()
        txtTipo.Text = grdTipos.SelectedRows(0).Cells(1).Value()
        anterior = txtTipo.Text
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        id = 0
        txtTipo.Text = ""
    End Sub

    Private Sub CadTipoProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CadTipoProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub
End Class