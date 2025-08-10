Imports Ponte.Hotel.Dominio

Public Class EditApartamento

    Private db As New DbContexto
    Private apartamento As New clsApartamento
    Private id As Integer

    Private Sub EditApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Application.OpenForms().OfType(Of CadHospedagem).Any Then
            id = CadHospedagem.cbApartamento.SelectedValue
        ElseIf Application.OpenForms().OfType(Of EditHospedagem).Any Then
            id = EditHospedagem.cbApartamento.SelectedValue
        ElseIf Application.OpenForms().OfType(Of EditReserva).Any Then
            id = EditReserva.cbApartamentoHos.SelectedValue
        End If

        Try
            apartamento = (From c In db.Apartamento Where c.Id = id Select c).First

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        txtApartamento.Text = apartamento.Descricao
        txtCapacidade.Text = apartamento.Capacidade
        txtDescrição.Text = apartamento.Descricao
        txtValor.Text = Format(apartamento.ValorDiaria, "0.00")
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

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
        Dim dados As New clsApartamento
        Try
            dados = (From c In db.Apartamento Where c.Id = id Select c).First
            dados.Descricao = txtDescrição.Text
            dados.Capacidade = txtCapacidade.Text
            dados.ValorDiaria = txtValor.Text

            db.SaveChanges()


            MsgBox("Apartamento configurado com sucesso", MsgBoxStyle.Information, "Atenção")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        If Application.OpenForms().OfType(Of EditHospedagem).Any Then
            EditHospedagem.lblValorDiaria.Text = Format(dados.ValorDiaria, "0.00")
            EditHospedagem.txtTotalDiarias.Text = Format(dados.ValorDiaria * EditHospedagem.lblNumDiarias.Text, "0.00")
            EditHospedagem.txtTotal.Text = (dados.ValorDiaria * EditHospedagem.lblNumDiarias.Text) + EditHospedagem.txtCons.Text
            EditHospedagem.txtTotal.Text = Format(EditHospedagem.txtTotal.Text * 1, "0.00")
            EditHospedagem.txtTotalAPagar.Text = ((EditHospedagem.txtTotal.Text - EditHospedagem.txtMostraSinal.Text) - EditHospedagem.txtDesconto.Text)
            EditHospedagem.txtTotalAPagar.Text = Format(((EditHospedagem.txtTotal.Text - EditHospedagem.txtMostraSinal.Text) - EditHospedagem.txtDesconto.Text), "0.00")

            Dim hospedagem As New clsHospedagem
            Try

                hospedagem = (From c In db.Hospedagem Where c.Codigo = EditHospedagem.txtCodHospedagem.Text Select c).FirstOrDefault
                With hospedagem
                    .ValorDiaria = txtValor.Text
                    .QuantidadePessoas = txtCapacidade.Text
                End With
                db.SaveChanges()

                EditHospedagem.lblNumPessoas.Text = hospedagem.Apartamento.Capacidade & " Pessoa(s)"


            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try
        End If

        apartamento = Nothing

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EditApartamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCapacidade.Text = ""
        txtDescrição.Text = ""
        txtValor.Text = ""
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

    Private Sub EditApartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class