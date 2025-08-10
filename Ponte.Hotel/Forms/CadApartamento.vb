Imports Ponte.Hotel.Dominio

Public Class cadApartamento

    Private db As New DbContexto
    Private id As Integer = 0
    Private anterior As String

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        carregaApartamentos()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            grdApartamentos.DataSource = (From c In db.Apartamento Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao, Key .Capacidade = c.Capacidade, Key .Valor = c.ValorDiaria}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdApartamentos.Columns("Descricao").HeaderText = "Descrição"
        grdApartamentos.Columns("Valor").HeaderText = "Valor Diária"
        grdApartamentos.Columns("Capacidade").HeaderText = "Núm. de Pessoas"
        grdApartamentos.Columns("Codigo").HeaderText = "Código"

        grdApartamentos.Columns("Codigo").Width = 50
        grdApartamentos.Columns("Descricao").Width = 130
        grdApartamentos.Columns("Valor").Width = grdApartamentos.Width - 100
        grdApartamentos.Columns("Capacidade").Width = grdApartamentos.Width - 300

        grdApartamentos.Columns("Valor").DefaultCellStyle.Format = "c"

        grdApartamentos.Columns("Codigo").Visible = False

    End Sub

    Public Sub carregaApartamentos()
        Try
            CadHospedagem.cbApartamento.DataSource = (From c In db.Apartamento Where c.Status = clsApartamento.StatusApartamento.Disponivel Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        CadHospedagem.cbApartamento.SelectedIndex = -1
        CadHospedagem.cbApartamento.DisplayMember = "Nome"
        CadHospedagem.cbApartamento.ValueMember = "Id"

        EditReserva.cbApartamentoHos.DataSource = (From c In db.Apartamento Where c.Status = clsApartamento.StatusApartamento.Disponivel Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        EditReserva.cbApartamentoHos.SelectedIndex = -1
        EditReserva.cbApartamentoHos.DisplayMember = "Nome"
        EditReserva.cbApartamentoHos.ValueMember = "Id"

    End Sub

    Private Sub grdApartmentos_DoubleClick(sender As Object, e As EventArgs) Handles grdApartamentos.DoubleClick
        id = grdApartamentos.SelectedRows(0).Cells(0).Value()
        txtDescrição.Text = grdApartamentos.SelectedRows(0).Cells(1).Value()
        txtCapacidade.Text = grdApartamentos.SelectedRows(0).Cells(2).Value()
        txtValor.Text = Format(grdApartamentos.SelectedRows(0).Cells(3).Value(), "Standard")
        anterior = txtDescrição.Text
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click


        Dim dados As clsApartamento

        If String.IsNullOrWhiteSpace(txtDescrição.Text) Then
            MsgBox("Digite a Descrição do apartamento.", MsgBoxStyle.Information, "Atenção")
            txtDescrição.Focus()
            Exit Sub
        End If

        If txtValor.Text <= 0 Then
            MsgBox("O preço do produto deve ser maior do que zero.", MsgBoxStyle.Information, "Atenção")
            txtValor.Focus()
            Exit Sub
        End If

        If txtValor.Text <= 0 Then
            MsgBox("Capacidade inválida", MsgBoxStyle.Information, "Atenção")
            txtCapacidade.Focus()
            Exit Sub
        End If
        Try
            If id > 0 Then
                If MsgBox("Deseja atualizar o tipo '" & txtDescrição.Text & "'?", MsgBoxStyle.YesNoCancel, "Atenção") = MsgBoxResult.Yes Then
                    dados = (From c In db.Apartamento Where c.Id = id Select c).First
                    dados.Descricao = txtDescrição.Text
                    If String.IsNullOrEmpty(dados.Status) Then
                        dados.Status = 0
                    End If
                    dados.Capacidade = txtCapacidade.Text
                    dados.ValorDiaria = txtValor.Text
                End If
            Else
                dados = New clsApartamento
                dados.Descricao = txtDescrição.Text
                If String.IsNullOrEmpty(dados.Status) Then
                    dados.Status = 0
                End If
                dados.Capacidade = txtCapacidade.Text
                dados.ValorDiaria = txtValor.Text
                db.Apartamento.Add(dados)
            End If

            db.SaveChanges()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        id = 0
        txtDescrição.Text = ""
        txtValor.Text = "0,00"
        txtCapacidade.Text = ""

        Try
            grdApartamentos.DataSource = (From c In db.Apartamento Select New With {Key .Codigo = c.Id, Key .Descricao = c.Descricao, Key .Capacidade = c.Capacidade, Key .Valor = c.ValorDiaria}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try


    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        id = 0
        txtDescrição.Text = ""
        txtValor.Text = "0,00"
        txtCapacidade.Text = ""
    End Sub

    Private Sub CadTipoProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCapacidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacidade.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cadApartamento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub
End Class