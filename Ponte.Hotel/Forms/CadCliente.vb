Imports Ponte.Hotel.Dominio

Public Class CadCliente

    Private db As New DbContexto
    Private cliente As clsCliente

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If String.IsNullOrEmpty(txtCpf.Text) Then
            MsgBox("Digite o CPF do cliente.", MsgBoxStyle.Information, "Cadastro de Cliente")
            txtCpf.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeCliente.Text) Then
            MsgBox("Digite o nome do cliente.", MsgBoxStyle.Information, "Cadastro de Cliente")
            txtNomeCliente.Focus()
            Exit Sub
        End If

        Try
            If Not IsNothing(cliente) AndAlso Not String.IsNullOrEmpty(cliente.Nome) Then
                With cliente
                    .Nome = txtNomeCliente.Text
                    .Telefone = txtTelefone.Text
                    .Celular = txtCelular.Text
                    .Email = txtEmail.Text
                    Dim i As Integer = cbEmpresa.SelectedValue
                    .Empresa = (From c In db.Empresa Where c.Id = i Select c).First
                    If cbTipoCliente2.Visible = True Then
                        .Tipo = cbTipoCliente2.SelectedValue
                    Else
                        .Tipo = cbTipoCliente.SelectedValue
                    End If
                    .PlacaCarro = txtPlaca.Text
                    .ValorBase = txtValorBase.Text

                End With
            Else
                Dim dados As New clsCliente

                dados.Nome = txtNomeCliente.Text
                dados.CPF = txtCpf.Text
                dados.Telefone = txtTelefone.Text
                dados.Celular = txtCelular.Text
                dados.Email = txtEmail.Text
                Dim i As Integer = cbEmpresa.SelectedValue
                dados.Empresa = (From c In db.Empresa Where c.Id = i Select c).First
                dados.DataCadastro = Now
                If cbTipoCliente2.Visible = True Then
                    dados.Tipo = cbTipoCliente2.SelectedValue
                Else
                    dados.Tipo = cbTipoCliente.SelectedValue
                End If
                dados.PlacaCarro = txtPlaca.Text
                dados.ValorBase = txtValorBase.Text

                db.Cliente.Add(dados)

            End If

            db.SaveChanges()

            MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastro de Cliente")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        cliente = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtCPF_Leave(sender As Object, e As EventArgs) Handles txtCpf.Leave
        If txtCpf.Text = "" Then Exit Sub

        buscaPorCPF()
    End Sub

    Private Sub buscaPorCPF()
        If txtCpf.Text = "" Then Exit Sub

        'If Not TextBoxCpfCnpj(txtCnpj) Then Exit Sub

        Try
            cliente = (From u In db.Cliente.Include("Empresa") Where u.CPF = txtCpf.Text And u.Tipo = clsCliente.TipoCliente.Cadastrado Select u).First

            If IsNothing(cliente) Then
                Exit Sub
            End If

            With cliente
                Dim tip As Integer
                If .Tipo = clsProduto.StatusProd.Ativo Then
                    tip = 1
                Else
                    tip = 0
                End If

                txtNomeCliente.Text = .Nome
                txtTelefone.Text = .Telefone
                txtCelular.Text = .Celular
                txtEmail.Text = .Email
                cbEmpresa.SelectedValue = IIf(IsNothing(.Empresa), -1, .Empresa.Id)
                cbTipoCliente.SelectedValue = tip
                txtPlaca.Text = .PlacaCarro
                txtValorBase.Text = Format(.ValorBase, "0.00")

                txtNomeCliente.Focus()
            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtCpf_Enter(sender As Object, e As EventArgs) Handles txtCpf.Enter
        If txtCpf.Text = "" Then Exit Sub

        LimparCampos(txtCpf)
        LimparCampos(txtNomeCliente)
        LimparCampos(GroupBox2)
        LimparCampos(GroupBox3)
        txtNomeCliente.Text = ""
    End Sub

    Public Sub setaValores(cod As String)
        txtCpf.Text = cod
        buscaPorCPF()
    End Sub

    Private Sub txtCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpf.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCelular_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCelular.Validating
        validaCel(sender)
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
        txtEmail.Text = ""
        txtCelular.Text = ""
        txtCpf.Text = ""
        txtNomeCliente.Text = ""
        txtTelefone.Text = ""

    End Sub

    Public Sub CadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaTipo()

        cbTipoCliente2.Enabled = False
        Try
            cbEmpresa.DataSource = (From c In db.Empresa Order By c.RazaoSocial Select New With {Key .Id = c.Id, Key .Nome = c.RazaoSocial}).ToList()
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

    Private Sub carregaTipo()
        cbTipoCliente.DisplayMember = "getName"
        cbTipoCliente.ValueMember = "getId"

        Dim vals As New ArrayList
        vals.Add(New SatausP("Cadastro", 1))
        vals.Add(New SatausP("Pré-Cadastro", 0))

        cbTipoCliente.DataSource = vals

        cbTipoCliente.SelectedIndex = 0
    End Sub

    Private Sub CadCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub txtValorBase_TextChanged(sender As Object, e As EventArgs) Handles txtValorBase.TextChanged
        TextBoxMoeda(sender)
    End Sub

    Private Sub txtValorBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorBase.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class