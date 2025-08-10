Imports Ponte.Hotel.Dominio

Public Class FinalizarHospedagem
    Private db As New DbContexto
    Private hospedagem As clsHospedagem


    Private Sub btFinalizar_Click(sender As Object, e As EventArgs) Handles btFinalizar.Click
        Dim movimentacao As New clsMovimentacao
        Dim nota As New clsNotaFiscal
        Try
            With hospedagem
                .Desconto = EditHospedagem.txtDesconto.Text
                ''.QuantidadeDiaria =
                .Status = clsHospedagem.StatusCheckout.Fechado
                .ValorPago = Convert.ToDouble(txtTotalAPagar.Text) + Convert.ToDouble(EditHospedagem.txtMostraSinal.Text)
                .ValorTotal = (hospedagem.Apartamento.ValorDiaria * lblNumDiarias.Text) + txtCons.Text
                .Apartamento.Status = clsApartamento.StatusApartamento.Disponivel
                .QuantidadeDiaria = ((dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay).AddHours(-12) - .DataEntrada.AddHours(-12).Date).Days + 1
                .Movimentacao = movimentacao
                .NotaFiscal = nota
                .ValorDiaria = (From c In db.Apartamento Where c.Id.ToString = EditHospedagem.cbApartamento.SelectedValue.ToString Select c.ValorDiaria).FirstOrDefault
                .DataSaida = dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay


                nota.Codigo = "000" + dtEntrada.Value.Date.ToString + "-" + dtSaida.Value.Date.ToString + "-" + .Codigo
                nota.DataNota = (dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay)
                nota.ValorTotalNota = Convert.ToDouble(txtTotalAPagar.Text) + Convert.ToDouble(EditHospedagem.txtMostraSinal.Text)
                db.NotaFiscal.Add(nota)
            End With

            movimentacao.DataMovimentacao = (dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay)
            movimentacao.Descricao = "Hospedagem " & EditHospedagem.txtCodHospedagem.Text & " finalizada. Valor pago: R$ " & Format(Convert.ToDouble(txtTotalAPagar.Text) + Convert.ToDouble(EditHospedagem.txtMostraSinal.Text), "0.00") & "."
            movimentacao.Tipo = clsMovimentacao.TipoMovimentacao.Entrada
            movimentacao.Valor = Convert.ToDouble(txtTotalAPagar.Text) + Convert.ToDouble(EditHospedagem.txtMostraSinal.Text)
            db.Movimentacao.Add(movimentacao)

            db.SaveChanges()

            MsgBox("Hospedagem finalizada com sucesso!", MsgBoxStyle.Information, "Checkout")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")

        End Try

        hospedagem = Nothing
        EditHospedagem.hospedagem = Nothing
        EditHospedagem.Dispose()
        EditHospedagem.Close()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FinalizarHospedagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            hospedagem = (From u In db.Hospedagem.Include("Cliente").Include("Apartamento").Include("NotaFiscal").Include("Movimentacao") Where u.Codigo = EditHospedagem.txtCodHospedagem.Text Select u).First

            dtEntrada.Text = hospedagem.DataEntrada
            dtHoraEntrada.Text = hospedagem.DataEntrada
            dtSaida.Text = EditHospedagem.dtSaida.Text
            dtHoraSaida.Text = EditHospedagem.dtHoraSaida.Text
            lblValorDiaria.Text = EditHospedagem.lblValorDiaria.Text
            lblNumDiarias.Text = EditHospedagem.lblNumDiarias.Text
            txtTotalDiarias.Text = EditHospedagem.txtTotalDiarias.Text
            txtCons.Text = EditHospedagem.txtCons.Text
            txtTotalAPagar.Text = EditHospedagem.txtTotalAPagar.Text
            lblSinal.Text = "Sinal Pago: R$ " & EditHospedagem.txtSinal.Text
            lblDesconto.Text = "Desconto: R$ " & EditHospedagem.txtDesconto.Text
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        hospedagem = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay < dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay Then
            MsgBox("A data e hora de saída não pode ser maior que a data e o horário de entrada.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            dtHoraSaida.Focus()
            Exit Sub
        End If

        lblNumDiarias.Text = ((dtSaida.Value.Date + dtHoraSaida.Value.TimeOfDay).AddHours(-12) - hospedagem.DataEntrada.AddHours(-12).Date).Days + 1
        txtTotalDiarias.Text = Format(hospedagem.Apartamento.ValorDiaria * lblNumDiarias.Text, "0.00")
        txtTotalAPagar.Text = Format(((((hospedagem.Apartamento.ValorDiaria * lblNumDiarias.Text) + txtCons.Text) - EditHospedagem.txtMostraSinal.Text) - EditHospedagem.txtDesconto.Text), "0.00")
    End Sub

    Private Sub FinalizarHospedagem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FinalizarHospedagem_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class