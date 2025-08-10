Imports Ponte.Hotel.Dominio

Public Class CadReserva

    Private db As New DbContexto
    Private cliente As clsCliente
    Private reserva As clsReserva

    Private Sub btnCadNovoCliente_Click(sender As Object, e As EventArgs) Handles btnCadNovoCliente.Click

        CadCliente.cbTipoCliente2.DisplayMember = "getName"
        CadCliente.cbTipoCliente2.ValueMember = "getId"
        Dim vals As New ArrayList
        vals.Add(New SatausP("Pré-Cadastro", 0))
        CadCliente.cbTipoCliente2.DataSource = vals
        CadCliente.cbTipoCliente2.SelectedIndex = 0
        CadCliente.cbTipoCliente2.Visible = True
        CadCliente.ShowDialog(Me)
        CadCliente.cbTipoCliente2.Visible = False
    End Sub

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 7
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Public Sub setaValores(cod As String)
        txtCpfCliente.Text = cod
        buscaPorCPF()
    End Sub

    Private Sub buscaPorCPF()
        If txtCpfCliente.Text = "" Then Exit Sub

        Try
            cliente = (From u In db.Cliente.Include("Empresa") Where u.CPF = txtCpfCliente.Text Select u).First

            With cliente
                Dim tip As Integer
                If .Tipo = clsProduto.StatusProd.Ativo Then
                    tip = 1
                Else
                    tip = 0
                End If
                txtNomeCliente.Text = .Nome

            End With

            txtNomeCliente.Enabled = False

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
    End Sub

    Private Sub txtCpfCliente_Leave(sender As Object, e As EventArgs) Handles txtCpfCliente.Leave
        If txtCpfCliente.Text = "" Then Exit Sub
        If Not TextBoxCpfCnpj(sender) Then Exit Sub
        buscaPorCPF()
    End Sub

    Private Sub CadReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCpfCliente.Enabled = False
        txtCodHospedagem.Text = novoCodigo()
    End Sub

    Public Function novoCodigo() As String
        Dim db As New DbContexto
        Dim ret As clsReserva
        Try
            ret = (From u In db.Reserva Select u Order By u.Id Descending).First

            Return "R00" & CType(ret.Id, Long) + 1
        Catch ex As Exception
            Return "R001"
        End Try
    End Function

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCpfCliente.Text = ""
        'txtVlPagamento.Text = "0,00"
        txtNomeCliente.Text = ""
        numQtdPessoas.Value = 1
        dtEntrada.Text = Now
        dtHoraEntrada.Text = Now
    End Sub

    Private Sub txtVlPagamento_TextChanged(sender As Object, e As EventArgs)
        TextBoxMoeda(sender)
    End Sub

    Private Sub numQtdPessoas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numQtdPessoas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click


        If IsNothing(cliente) Then
            MsgBox("Selecione um cliente.", MsgBoxStyle.Information, "Cadastro de Reserva")
            btPesqCliente.PerformClick()
            Exit Sub
        End If

        Try

            If Not IsNothing(reserva) AndAlso Not String.IsNullOrEmpty(cliente.Nome) Then
                With reserva
                    .Cliente = cliente
                    .DataCadastro = Now
                    .DataEntrada = dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay
                    .Codigo = txtCodHospedagem.Text
                    .QtdPessoas = numQtdPessoas.Value
                    .StatusReserva = clsReserva.StatusRes.Solcitada
                    .Origem = clsReserva.OrigemReseva.Sistema
                End With
            Else
                Dim dados As New clsReserva

                dados.Cliente = cliente
                dados.DataCadastro = Now
                dados.DataEntrada = dtEntrada.Value.Date + dtHoraEntrada.Value.TimeOfDay
                dados.Codigo = txtCodHospedagem.Text
                dados.QtdPessoas = numQtdPessoas.Value
                dados.StatusReserva = clsReserva.StatusRes.Solcitada
                dados.Origem = clsReserva.OrigemReseva.Sistema

                db.Reserva.Add(dados)
            End If

            db.SaveChanges()



            MsgBox("Reserva Cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastro de Hospedagem")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        reserva = Nothing

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub CadReserva_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadReserva_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class