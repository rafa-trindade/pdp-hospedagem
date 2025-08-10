Imports Ponte.Hotel.Dominio

Public Class CadHospedagem
    Private db As New DbContexto
    Private cliente As clsCliente
    Private hospedagem As clsHospedagem

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click

        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 4
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try

    End Sub

    Private Sub buscaPorCPF()
        If txtCpfCliente.Text = "" Then Exit Sub

        Try
            cliente = (From u In db.Cliente Where u.CPF = txtCpfCliente.Text And u.Tipo = clsCliente.TipoCliente.Cadastrado Select u).First

            With cliente
                txtNomeCliente.Text = .Nome
                txtValorBase.Text = Format(.ValorBase, "0.00")
            End With

            txtNomeCliente.Enabled = False
            txtValorBase.Enabled = False

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
    End Sub

    Private Sub txtCpfCliente_Enter(sender As Object, e As EventArgs) Handles txtCpfCliente.Enter
        If txtCpfCliente.Text = "" Then Exit Sub
        txtNomeCliente.Text = ""

    End Sub

    Private Sub txtCpfCliente_Leave(sender As Object, e As EventArgs) Handles txtCpfCliente.Leave
        If txtCpfCliente.Text = "" Then Exit Sub
        buscaPorCPF()
    End Sub

    Public Sub setaValores(cod As String)
        txtCpfCliente.Text = cod
        buscaPorCPF()
    End Sub


    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If IsNothing(cliente) Then
            MsgBox("Selecione um cliente.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            btPesqCliente.PerformClick()
            Exit Sub
        End If

        If cbApartamento.Text = "" Then
            MsgBox("Selcione um apartamento.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            cbApartamento.Focus()
            Exit Sub
        End If

        If dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay > Now Then
            MsgBox("A data e hora de entrada não pode ser maior que a data e o horário atual.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            dtEntrada.Focus()
            Exit Sub
        End If

        Dim apartamento As clsApartamento
        apartamento = (From i In db.Apartamento Where i.Id.ToString = cbApartamento.SelectedValue.ToString Select i).First
        If Convert.ToDouble(txtSinal.Text) > apartamento.ValorDiaria Then
            MsgBox("O sinal deve ser menor ou igual ao valor da díaria do apartamento selecionado.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            Exit Sub
        End If

        Try

            If Not IsNothing(hospedagem) AndAlso Not String.IsNullOrEmpty(cliente.Nome) Then
                With hospedagem
                    .Cliente = cliente
                    Dim i As Integer = cbApartamento.SelectedValue
                    .Apartamento = (From c In db.Apartamento Where c.Id = i Select c).First
                    .DataEntrada = dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay
                    ''.DataSaida = dtSaida.Value
                    .QuantidadeDiaria = 1
                    .Codigo = txtCodHospedagem.Text
                    .Status = Dominio.clsHospedagem.StatusCheckout.Aberto
                    .Apartamento.Status = clsApartamento.StatusApartamento.Indisponivel
                    .Tipo = clsHospedagem.TipoHospedagem.Normal
                    .Sinal = txtSinal.Text
                    .ValorDiaria = (From c In db.Apartamento Where c.Id.ToString = cbApartamento.SelectedValue.ToString Select c.ValorDiaria).FirstOrDefault
                    .QuantidadePessoas = (From c In db.Apartamento Where c.Id.ToString = cbApartamento.SelectedValue.ToString Select c.Capacidade).FirstOrDefault
                    .Obeservacao = txtObs.Text

                End With
            Else
                Dim dados As New clsHospedagem

                dados.Cliente = cliente
                Dim i As Integer = cbApartamento.SelectedValue
                dados.Apartamento = (From c In db.Apartamento Where c.Id = i Select c).First
                dados.DataEntrada = dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay
                ''dados.DataSaida = dtSaida.Value
                dados.QuantidadeDiaria = 1
                dados.Codigo = txtCodHospedagem.Text
                dados.Status = Dominio.clsHospedagem.StatusCheckout.Aberto
                dados.Apartamento.Status = clsApartamento.StatusApartamento.Indisponivel
                dados.Tipo = clsHospedagem.TipoHospedagem.Normal
                dados.Sinal = txtSinal.Text
                dados.ValorDiaria = (From c In db.Apartamento Where c.Id.ToString = cbApartamento.SelectedValue.ToString Select c.ValorDiaria).FirstOrDefault
                dados.QuantidadePessoas = (From c In db.Apartamento Where c.Id.ToString = cbApartamento.SelectedValue.ToString Select c.Capacidade).FirstOrDefault
                dados.Obeservacao = txtObs.Text

                db.Hospedagem.Add(dados)
            End If

            db.SaveChanges()


            MsgBox("Hospedagem Cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastro de Hospedagem")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        hospedagem = Nothing

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub CadCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCpfCliente.Text = ""
        txtNomeCliente.Text = ""
    End Sub

    Private Sub CadHospedagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodHospedagem.Text = novoCodigo()

        txtCpfCliente.Enabled = False

        Try
            cbApartamento.DataSource = (From c In db.Apartamento Where c.Status = clsApartamento.StatusApartamento.Disponivel Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbApartamento.SelectedIndex = -1

        cbApartamento.DisplayMember = "Nome"
        cbApartamento.ValueMember = "Id"
    End Sub

    Public Function novoCodigo() As String
        Dim db As New DbContexto
        Dim ret As clsHospedagem
        Try
            ret = (From u In db.Hospedagem Select u Order By u.Id Descending).First
            Return "H00" & CType(ret.Id, Long) + 1
        Catch ex As Exception
            Return "H001"
        End Try
    End Function

    Private Sub btCadApartamento_Click(sender As Object, e As EventArgs) Handles btCadApartamento.Click
        EditApartamento.ShowDialog(Me)
    End Sub

    Private Sub btnCadNovoCliente_Click(sender As Object, e As EventArgs) Handles btnCadNovoCliente.Click
        CadCliente.ShowDialog(Me)
    End Sub

    Private Sub txtSinal_TextChanged(sender As Object, e As EventArgs) Handles txtSinal.TextChanged
        TextBoxMoeda(sender)

    End Sub

    Private Sub txtSinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSinal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CadHospedagem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

End Class