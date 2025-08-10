Imports Ponte.Hotel.Dominio

Public Class EditReserva

    Private db As New DbContexto
    Private cliente As clsCliente
    Private reserva As clsReserva
    Private hospedagem As clsHospedagem

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeClienteRes.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 8
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Public Sub setaValores(cod As String)
        txtCodRes.Text = cod
        buscaPorCodigo()
    End Sub

    Private Sub buscaPorCodigo()
        If txtCodRes.Text = "" Then Exit Sub

        If cbPesStatusRes.SelectedValue = 2 Then
            lblStatus.Text = "Reserva Solicitada"
            lblStatus.ForeColor = Color.SteelBlue
            lblStatus.Visible = True
        Else
            lblStatus.Text = "Reserva Cancelada"
            lblStatus.ForeColor = Color.Tomato
            lblStatus.Visible = True
        End If

        carregaApartamento()

        Try
            reserva = (From u In db.Reserva.Include("Cliente") Where u.Codigo = txtCodRes.Text Select u).First


            With reserva

                Dim sts As Integer
                If .StatusReserva = clsReserva.StatusRes.Solcitada Then
                    sts = 2
                ElseIf .StatusReserva = clsReserva.StatusRes.Confirmada Then
                    sts = 1
                Else
                    sts = 0
                End If

                Dim stsSinal As Integer
                If .StatusSinal = clsReserva.SinalPagamento.Pago Then
                    stsSinal = 1
                Else
                    stsSinal = 0
                End If

                txtCpfClienteRes.Text = .Cliente.CPF
                txtNomeClienteRes.Text = .Cliente.Nome
                txtValorSinalRes.Text = Format(.ValorSinal, "0.00")
                numQtdPessoasRes.Value = .QtdPessoas
                dtEntradaRes.Text = .DataEntrada
                dtHoraEntradaRes.Text = .DataEntrada

                cbStatusRes.SelectedValue = sts
                cbStatusSinalRes.SelectedValue = stsSinal

                lblDtCadastro.Text = "Reserva efetuada dia: " & .DataCadastro.Date
                lblDtCadastro.Visible = True

            End With

            ''mudar enableds


        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

    End Sub

    Private Sub btAtualizarRes_Click(sender As Object, e As EventArgs) Handles btAtualizarRes.Click
        If String.IsNullOrEmpty(txtCpfClienteRes.Text) Then
            MsgBox("Digite o CPF do cliente.", MsgBoxStyle.Information, "Gerenciar Reserva")
            txtCpfClienteRes.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeClienteRes.Text) Then
            MsgBox("Digite o nome do cliente.", MsgBoxStyle.Information, "Gerenciar Reserva")
            txtNomeClienteRes.Focus()
            Exit Sub
        End If

        If Convert.ToDouble(txtValorSinalRes.Text) < 0 Then
            MsgBox("O sinal deve ser maior do que zero.", vbInformation, "Gerenciar Reserva")
            txtValorSinalRes.Focus()
            Exit Sub
        End If

        If numQtdPessoasRes.Value <= 0 Then
            MsgBox("A quantidade de pessoas deve ser maior ou igual a 1..", vbInformation, "Gerenciar Reserva")
            numQtdPessoasRes.Focus()
            Exit Sub
        End If

        Try
            With reserva

                .Cliente.CPF = txtCpfClienteRes.Text
                .Cliente.Nome = txtNomeClienteRes.Text
                .ValorSinal = txtValorSinalRes.Text
                .QtdPessoas = numQtdPessoasRes.Value
                .DataEntrada = dtEntradaRes.Value.Date + dtHoraEntradaRes.Value.TimeOfDay

                .StatusReserva = cbStatusRes.SelectedValue
                .StatusSinal = cbStatusSinalRes.SelectedValue

            End With

            'Adicionar mensagem de conf
            db.SaveChanges()

            MsgBox("Reserva atualizada com sucesso!", MsgBoxStyle.Information, "Atualizar Produto")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        reserva = Nothing

        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub carregaStatusReserva()
        cbStatusRes.DisplayMember = "getName"
        cbStatusRes.ValueMember = "getId"

        Dim vals1 As New ArrayList
        vals1.Add(New SatausP("Solicitada", 2))
        vals1.Add(New SatausP("Confirmada", 1))
        vals1.Add(New SatausP("Cancelada", 0))

        cbStatusRes.DataSource = vals1
        cbStatusRes.SelectedIndex = -1
    End Sub

    Private Sub carregaStatusSinal()
        cbStatusSinalRes.DisplayMember = "getName"
        cbStatusSinalRes.ValueMember = "getId"

        Dim vals2 As New ArrayList
        vals2.Add(New SatausP("Pago", 1))
        vals2.Add(New SatausP("Pendente", 0))

        cbStatusSinalRes.DataSource = vals2
        cbStatusSinalRes.SelectedIndex = -1
    End Sub

    Public Sub carregaApartamento()
        Try
            cbApartamentoHos.DataSource = (From c In db.Apartamento Where c.Status = clsApartamento.StatusApartamento.Disponivel Select New With {Key .Id = c.Id, Key .Nome = c.Descricao}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbApartamentoHos.SelectedIndex = -1

        cbApartamentoHos.DisplayMember = "Nome"
        cbApartamentoHos.ValueMember = "Id"
    End Sub

    Private Sub carregaPesStatusReserva()
        cbPesStatusRes.DisplayMember = "getName"
        cbPesStatusRes.ValueMember = "getId"

        Dim vals2 As New ArrayList
        vals2.Add(New SatausP("Reservas Solicitadas", 2))
        vals2.Add(New SatausP("Reservas Canceladas", 0))

        cbPesStatusRes.DataSource = vals2
        cbPesStatusRes.SelectedIndex = 0
    End Sub


    Private Sub ckConfHos_CheckedChanged(sender As Object, e As EventArgs) Handles ckConfHos.CheckedChanged
        gbResCliente.Enabled = Not ckConfHos.Checked
        gbResDataEntrada.Enabled = Not ckConfHos.Checked
        gbResSinal.Enabled = Not ckConfHos.Checked
        numQtdPessoasRes.Enabled = Not ckConfHos.Checked
        cbStatusRes.Enabled = Not ckConfHos.Checked
        btAtualizarRes.Enabled = Not ckConfHos.Checked
        Label2.Enabled = Not ckConfHos.Checked
        Label7.Enabled = Not ckConfHos.Checked


        gbHosApartamento.Enabled = ckConfHos.Checked
        gbHosCliente.Enabled = ckConfHos.Checked
        gbHosDataEntrada.Enabled = ckConfHos.Checked
        gbHosSinal.Enabled = ckConfHos.Checked
        'txtValorSinalHos.Enabled = ckConfHos.Checked
        btCadApartamentoHos.Enabled = ckConfHos.Checked
        Label12.Enabled = ckConfHos.Checked
        btConfHos.Enabled = ckConfHos.Checked
        Label10.Enabled = ckConfHos.Checked

        If ckConfHos.Enabled = True Then
            txtNomeClienteHos.Text = txtNomeClienteRes.Text
            txtCPFClienteHos.Text = txtCpfClienteRes.Text
            If cbStatusSinalRes.Text = "Pendente" Then
                txtValorSinalHos.Text = "0,00"
            Else
                txtValorSinalHos.Text = txtValorSinalRes.Text
            End If
            dtDataHos.Text = dtEntradaRes.Text
            dtHoraHos.Text = dtHoraEntradaRes.Text
        End If


    End Sub

    Private Sub EditReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaApartamento()
        carregaStatusReserva()
        carregaPesStatusReserva()
        carregaStatusSinal()
        txtCodHos.Text = novoCodigo()
        txtCpfClienteRes.Enabled = False

        lblStatus.Visible = False

        ckConfHos.Checked = False

        gbHosApartamento.Enabled = False
        gbHosCliente.Enabled = False
        gbHosDataEntrada.Enabled = False
        gbHosSinal.Enabled = False
        txtValorSinalHos.Enabled = False
        btCadApartamentoHos.Enabled = False
        Label12.Enabled = False
        btConfHos.Enabled = False
        Label10.Enabled = False
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

    Private Sub btCadApartamentoHos_Click(sender As Object, e As EventArgs) Handles btCadApartamentoHos.Click
        If cbApartamentoHos.Text = "" Then
            MsgBox("Selcione um apartamento.", MsgBoxStyle.Information, "Atualizar Apartamento")
            cbApartamentoHos.Focus()
            Exit Sub
        End If
        EditApartamento.ShowDialog(Me)
    End Sub

    Private Sub txtValorSinalRes_TextChanged(sender As Object, e As EventArgs) Handles txtValorSinalRes.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub txtValorSinalRes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorSinalRes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click

        reserva = Nothing

        txtCodRes.Text = ""
        txtValorSinalRes.Text = ""
        cbStatusRes.SelectedIndex = -1
        cbStatusSinalRes.SelectedIndex = -1
        numQtdPessoasRes.Value = 1


        lblStatus.Visible = False

        ckConfHos.Checked = False

        gbHosApartamento.Enabled = False
        gbHosCliente.Enabled = False
        gbHosDataEntrada.Enabled = False
        gbHosSinal.Enabled = False
        txtValorSinalHos.Enabled = False
        btCadApartamentoHos.Enabled = False
        Label12.Enabled = False
        btConfHos.Enabled = False
        Label10.Enabled = False


        txtCpfClienteRes.Text = ""
        txtNomeClienteRes.Text = ""
        lblStatus.Visible = False
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub EditReserva_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnCadNovoRes_Click(sender As Object, e As EventArgs) Handles btnCadNovoRes.Click
        CadReserva.ShowDialog(Me)
    End Sub

    Private Sub btConfHos_Click(sender As Object, e As EventArgs) Handles btConfHos.Click
        If String.IsNullOrEmpty(txtCPFClienteHos.Text) Then
            MsgBox("Digite o CPF do cliente.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            txtCPFClienteHos.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeClienteHos.Text) Then
            MsgBox("Digite o nome do cliente.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            txtNomeClienteHos.Focus()
            Exit Sub
        End If

        If cbApartamentoHos.Text = "" Then
            MsgBox("Selcione um apartamento.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            cbApartamentoHos.Focus()
            Exit Sub
        End If

        If dtDataHos.Value.Date + dtHoraHos.Value.TimeOfDay > Now Then
            MsgBox("A data e hora de entrada não pode ser maior que a data e o horário atual.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            dtDataHos.Focus()
            Exit Sub
        End If

        Dim apartamento As clsApartamento
        apartamento = (From i In db.Apartamento Where i.Id.ToString = cbApartamentoHos.SelectedValue.ToString Select i).First
        If Convert.ToDouble(txtValorSinalHos.Text) > apartamento.ValorDiaria Then
            MsgBox("O sinal deve ser menor ou igual ao valor da díaria do apartamento selecionado.", MsgBoxStyle.Information, "Cadastro de Hospedagem")
            txtValorSinalHos.Focus()
            Exit Sub
        End If

        If Convert.ToDouble(txtValorSinalHos.Text) < 0 Then
            MsgBox("O sinal deve ser maior do que zero.", vbInformation, "Gerenciar Reserva")
            txtValorSinalHos.Focus()
            Exit Sub
        End If
        Try
            If Not IsNothing(hospedagem) AndAlso Not String.IsNullOrEmpty(cliente.Nome) Then
                With hospedagem
                    .Cliente = reserva.Cliente
                    Dim i As Integer = cbApartamentoHos.SelectedValue
                    .Apartamento = (From c In db.Apartamento Where c.Id = i Select c).First
                    .DataEntrada = dtDataHos.Value.Date + dtHoraEntradaRes.Value.TimeOfDay
                    ''.DataSaida = dtSaida.Value
                    .QuantidadeDiaria = 1
                    .Codigo = txtCodHos.Text
                    .Status = Dominio.clsHospedagem.StatusCheckout.Aberto
                    .Apartamento.Status = clsApartamento.StatusApartamento.Indisponivel
                    .Tipo = clsHospedagem.TipoHospedagem.Normal
                    .Sinal = txtValorSinalHos.Text
                    .QuantidadePessoas = (From c In db.Apartamento Where c.Id.ToString = cbApartamentoHos.SelectedValue.ToString Select c.Capacidade).FirstOrDefault

                    .Cliente.Tipo = clsCliente.TipoCliente.Cadastrado
                    .Reserva = reserva

                    .ValorDiaria = (From c In db.Apartamento Where c.Id.ToString = cbApartamentoHos.SelectedValue.ToString Select c.ValorDiaria).FirstOrDefault
                End With

                With reserva
                    .StatusReserva = clsReserva.StatusRes.Confirmada
                    .DataEntrada = dtDataHos.Value.Date + dtHoraEntradaRes.Value.TimeOfDay
                    .QtdPessoas = numQtdPessoasRes.Value
                    .StatusSinal = cbStatusSinalRes.SelectedValue
                    .ValorSinal = txtValorSinalHos.Text
                    .Cliente.Tipo = clsCliente.TipoCliente.Cadastrado
                End With

            Else
                Dim dados As New clsHospedagem

                dados.Cliente = reserva.Cliente
                Dim i As Integer = cbApartamentoHos.SelectedValue
                dados.Apartamento = (From c In db.Apartamento Where c.Id = i Select c).First
                dados.DataEntrada = dtDataHos.Value.Date + dtHoraEntradaRes.Value.TimeOfDay
                ''.DataSaida = dtSaida.Value
                dados.QuantidadeDiaria = 1
                dados.Codigo = txtCodHos.Text
                dados.Status = Dominio.clsHospedagem.StatusCheckout.Aberto
                dados.Apartamento.Status = clsApartamento.StatusApartamento.Indisponivel
                dados.Tipo = clsHospedagem.TipoHospedagem.Normal
                dados.Sinal = txtValorSinalHos.Text
                dados.Sinal = txtValorSinalHos.Text
                dados.Reserva = reserva
                dados.ValorDiaria = (From c In db.Apartamento Where c.Id.ToString = cbApartamentoHos.SelectedValue.ToString Select c.ValorDiaria).FirstOrDefault
                dados.QuantidadePessoas = (From c In db.Apartamento Where c.Id.ToString = cbApartamentoHos.SelectedValue.ToString Select c.Capacidade).FirstOrDefault


                db.Hospedagem.Add(dados)

                With reserva
                    .StatusReserva = clsReserva.StatusRes.Confirmada
                    .DataEntrada = dtDataHos.Value.Date + dtHoraEntradaRes.Value.TimeOfDay
                    .QtdPessoas = numQtdPessoasRes.Value
                    .StatusSinal = cbStatusSinalRes.SelectedValue
                    .ValorSinal = txtValorSinalHos.Text
                    .Cliente.Tipo = clsCliente.TipoCliente.Cadastrado
                End With
            End If

            db.SaveChanges()

            MsgBox("Hospedagem Cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastro de Hospedagem")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        hospedagem = Nothing
        reserva = Nothing
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub ckConfHos_MouseClick(sender As Object, e As MouseEventArgs) Handles ckConfHos.MouseClick
        If IsNothing(reserva) Then
            ckConfHos.CheckState = False
            MsgBox("Selcione uma Reserva.", MsgBoxStyle.Information, "Atualizar Apartamento")
            btPesqCliente.PerformClick()
            Exit Sub
        End If
    End Sub

    Private Sub EditReserva_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class