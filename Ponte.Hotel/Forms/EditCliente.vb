Imports Ponte.Hotel.Dominio

Public Class EditCliente

    Private db As New DbContexto
    Private cliente As clsCliente

    Private Sub btPesqCliente_Click(sender As Object, e As EventArgs) Handles btPesqCliente.Click
        Try
            Pesquisa.nome = txtNomeCliente.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 1
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")
        End Try


    End Sub

    Private Sub buscaPorCPF()
        ' If txtCpfCliente.Text = "" Then Exit Sub
        txtNomeCliente.Enabled = True
        Try
            cliente = (From u In db.Cliente.Include("Empresa") Where u.CPF = txtCpfCliente.Text Select u).First

            carregaGrid()

            With cliente
                Dim tip As Integer
                If .Tipo = clsProduto.StatusProd.Ativo Then
                    tip = 1
                Else
                    tip = 0
                End If
                txtNomeCliente.Text = .Nome
                txtTelefoneCliente.Text = .Telefone
                txtCelularCliente.Text = .Celular
                txtEmailCliente.Text = .Email
                cbEmpresa.SelectedValue = IIf(IsNothing(.Empresa), -1, .Empresa.Id)
                cbTipoCliente.SelectedValue = tip
                txtValorBase.Text = Format(.ValorBase, "0.00")

                txtTelefoneCliente.Focus()
                txtPlaca.Text = .PlacaCarro
            End With

            GroupBox2.Enabled = True
            btSalvar.Enabled = True
            cbTipoCliente.Enabled = True


        Catch ex As Exception
        End Try
    End Sub



    Private Sub txtCpfCliente_Enter(sender As Object, e As EventArgs) Handles txtCpfCliente.Enter
        If txtCpfCliente.Text = "" Then Exit Sub

        GroupBox2.Enabled = False
        btSalvar.Enabled = False
        cbTipoCliente.Enabled = False

        txtNomeCliente.Text = ""
        txtCelularCliente.Text = ""
        txtEmailCliente.Text = ""
        txtTelefoneCliente.Text = ""
        txtPlaca.Text = ""
    End Sub

    Public Sub setaValores(cod As String)
        txtCpfCliente.Text = cod
        buscaPorCPF()
    End Sub

    Private Sub txtCelularCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        validaCel(sender)
    End Sub

    Private Sub carregaGrid()
        Try

            grdHistoricoCliente.DataSource = (From c In db.Hospedagem.Include("Cliente") Where c.Cliente.Id = cliente.Id Select New With {Key .Codigo = c.Codigo, Key .DataEntrada = c.DataEntrada, Key .DataSaida = c.DataSaida, Key .Apartamento = c.Apartamento.Descricao, Key .ValorPago = c.ValorPago}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdHistoricoCliente.Columns("Codigo").Width = 50
        grdHistoricoCliente.Columns("Codigo").HeaderText = "Código"
        grdHistoricoCliente.Columns("DataEntrada").Width = 130
        grdHistoricoCliente.Columns("DataEntrada").HeaderText = "Checkin"
        grdHistoricoCliente.Columns("DataSaida").Width = 130
        grdHistoricoCliente.Columns("DataSaida").HeaderText = "Checkout"
        grdHistoricoCliente.Columns("Apartamento").Width = 100
        grdHistoricoCliente.Columns("ValorPago").HeaderText = "Valor Pago"
        grdHistoricoCliente.Columns("ValorPago").Width = 200

        grdHistoricoCliente.Columns("ValorPago").DefaultCellStyle.Format = "c"

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If IsNothing(cliente) Then
            MsgBox("Selecione um cliente.", MsgBoxStyle.Information, "Gerenciar Clientes")
            btPesqCliente.PerformClick()
            Exit Sub
        End If

        Try

            If Not IsNothing(cliente) AndAlso Not String.IsNullOrEmpty(cliente.Nome) Then
                With cliente
                    .Nome = txtNomeCliente.Text
                    .Telefone = txtTelefoneCliente.Text
                    .Celular = txtCelularCliente.Text
                    .Email = txtEmailCliente.Text
                    Dim i As Integer = cbEmpresa.SelectedValue
                    .Empresa = (From c In db.Empresa Where c.Id = i Select c).First
                    .Tipo = cbTipoCliente.SelectedValue
                    .PlacaCarro = txtPlaca.Text
                    .ValorBase = txtValorBase.Text

                End With
            Else
                Dim dados As New clsCliente

                dados.Nome = txtNomeCliente.Text
                dados.CPF = txtCpfCliente.Text
                dados.Telefone = txtTelefoneCliente.Text
                dados.Celular = txtCelularCliente.Text
                dados.Email = txtEmailCliente.Text
                Dim i As Integer = cbEmpresa.SelectedValue
                dados.Empresa = (From c In db.Empresa Where c.Id = i Select c).First
                dados.DataCadastro = Now
                dados.Tipo = cbTipoCliente.SelectedValue
                dados.PlacaCarro = txtPlaca.Text
                dados.ValorBase = txtValorBase.Text

                db.Cliente.Add(dados)
            End If

            db.SaveChanges()

            MsgBox("Cliente atualizado com sucesso!", MsgBoxStyle.Information, "Cadastro de Cliente")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        cliente = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtCpfCliente_Leave(sender As Object, e As EventArgs) Handles txtCpfCliente.Leave
        If txtCpfCliente.Text = "" Then Exit Sub
        buscaPorCPF()
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
        txtCpfCliente.Text = ""
        txtNomeCliente.Text = ""
        txtCpfCliente.Enabled = False
        GroupBox2.Enabled = False
        cbTipoCliente.Enabled = False
        btSalvar.Enabled = False
        txtTelefoneCliente.Text = ""
        txtCelularCliente.Text = ""
        txtEmailCliente.Text = ""
        cbEmpresa.SelectedIndex = 0
    End Sub

    Private Sub CadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaTipo()
        txtCpfCliente.Enabled = False
        GroupBox2.Enabled = False
        cbTipoCliente.Enabled = False
        btSalvar.Enabled = False
        Try

            cbEmpresa.DataSource = (From c In db.Empresa Select New With {Key .Id = c.Id, Key .Nome = c.RazaoSocial}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbEmpresa.SelectedIndex = -1

        cbEmpresa.DisplayMember = "Nome"
        cbEmpresa.ValueMember = "Id"



    End Sub

    Private Sub btnNovaEmpresa_Click(sender As Object, e As EventArgs) Handles btnNovaEmpresa.Click
        CadEmpresa.ShowDialog(Me)
    End Sub



    Private Sub txtCnpj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpfCliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCadNovoProd_Click(sender As Object, e As EventArgs) Handles btnCadNovoProd.Click
        CadCliente.ShowDialog(Me)
    End Sub

    Private Sub carregaTipo()
        cbTipoCliente.DisplayMember = "getName"
        cbTipoCliente.ValueMember = "getId"

        Dim vals As New ArrayList
        vals.Add(New SatausP("Cadastrado", 1))
        vals.Add(New SatausP("Pré-Cadastrado", 0))

        cbTipoCliente.DataSource = vals

        cbTipoCliente.SelectedIndex = 0
    End Sub

    Private Sub EditCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtValorBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorBase.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorBase_TextChanged(sender As Object, e As EventArgs) Handles txtValorBase.TextChanged
        TextBoxMoeda(sender)
    End Sub
End Class