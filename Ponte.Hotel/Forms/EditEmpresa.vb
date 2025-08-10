Imports Ponte.Hotel.Dominio

Public Class EditEmpresa

    Private db As New DbContexto
    Private empresa As clsEmpresa

    Private Sub btPesqEmpresa_Click(sender As Object, e As EventArgs) Handles btPesqEmpresa.Click

        Try
            Pesquisa.nome = txtNomeEmpresa.Text
            Pesquisa.pai = Me
            Pesquisa.tipo = 2
            Pesquisa.Show(Me)
        Catch ex As Exception
            MsgBox("Erro.", MsgBoxStyle.Exclamation, "Erro")

        End Try

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If String.IsNullOrEmpty(txtCnpj.Text) Then
            MsgBox("Digite o CNPJ/CPF do fornecedor.", MsgBoxStyle.Information, "Cadastro de Empresa")
            txtCnpj.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeEmpresa.Text) Then
            MsgBox("O campo Razão Social é obrigatório.", MsgBoxStyle.Information, "Cadastro de Empresa")
            txtNomeEmpresa.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtNomeFantasia.Text) Then
            MsgBox("O campo Nome Fantasia é obrigatório.", MsgBoxStyle.Information, "Cadastro de Empresa")
            txtNomeFantasia.Focus()
            Exit Sub
        End If

        Try

            If Not IsNothing(empresa) AndAlso Not String.IsNullOrEmpty(empresa.RazaoSocial) Then
                With empresa
                    .RazaoSocial = txtNomeEmpresa.Text
                    .Celular = txtCelular.Text
                    '.Codigo = txtCodigo.Text
                    .Responsavel = txtResponsavel.Text
                    .Email = txtEmail.Text
                    .NomeFantasia = txtNomeFantasia.Text
                    .Telefone = txtTelefone.Text

                End With

            Else
                empresa = New clsEmpresa
                With empresa
                    .CPF_CNPJ = txtCnpj.Text
                    .RazaoSocial = txtNomeEmpresa.Text
                    .Celular = txtCelular.Text
                    '.Codigo = IIf(String.IsNullOrWhiteSpace(txtCodigo.Text), 0, txtCodigo.Text)
                    .Responsavel = txtResponsavel.Text
                    .Email = txtEmail.Text
                    .NomeFantasia = txtNomeFantasia.Text
                    .Telefone = txtTelefone.Text

                    db.Empresa.Add(empresa)
                End With
            End If

            db.SaveChanges()

            MsgBox("Empresa atualizada com sucesso!", MsgBoxStyle.Information, "Cadastro de Empresa")

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        Me.Dispose()
        Me.Close()
    End Sub


    Private Sub buscaPorCNPJ()
        If txtCnpj.Text = "" Then Exit Sub

        'If Not TextBoxCpfCnpj(txtCnpj) Then Exit Sub

        Try
            empresa = (From u In db.Empresa Where u.CPF_CNPJ = txtCnpj.Text Select u).First

            carregaGrid()

            With empresa
                txtNomeEmpresa.Text = .RazaoSocial
                txtCelular.Text = .Celular
                'txtCodigo.Text = .Codigo
                txtResponsavel.Text = .Responsavel
                txtEmail.Text = .Email
                txtNomeFantasia.Text = .NomeFantasia
                txtTelefone.Text = .Telefone

                txtNomeEmpresa.Focus()
            End With

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            txtNomeFantasia.Enabled = True
            btSalvar.Enabled = True

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
    End Sub

    Private Sub txtCnpj_Leave(sender As Object, e As EventArgs) Handles txtCnpj.Leave
        If txtCnpj.Text = "" Then Exit Sub

        If Not TextBoxCpfCnpj(sender) Then Exit Sub

        buscaPorCNPJ()
    End Sub

    Private Sub txtCnpj_Enter(sender As Object, e As EventArgs) Handles txtCnpj.Enter
        If txtCnpj.Text = "" Then Exit Sub

        txtCnpj.Text = LeNumero(txtCnpj.Text)

        GroupBox1.Enabled = False
        btSalvar.Enabled = False

        txtNomeEmpresa.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""
        txtNomeFantasia.Text = ""
        txtResponsavel.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub txtCnpj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCnpj.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub carregaGrid()
        Try

            grdClientes.DataSource = (From c In db.Cliente.Include("Empresa") Where c.Empresa.Id = empresa.Id Select New With {Key .CPF = c.CPF, Key .Nome = c.Nome}).ToList()

        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        grdClientes.Columns("CPF").Width = 150
        grdClientes.Columns("Nome").Width = grdClientes.Width - 60
        grdClientes.Columns("CPF").HeaderText = "RG"

    End Sub

    Public Sub setaValores(cod As String)
        txtCnpj.Text = cod
        buscaPorCNPJ()
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
        txtNomeEmpresa.Text = ""
        txtNomeFantasia.Text = ""
        txtEmail.Text = ""
        txtCelular.Text = ""
        txtResponsavel.Text = ""
        txtTelefone.Text = ""
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        txtCnpj.Text = ""
        txtNomeEmpresa.Text = ""
    End Sub

    Private Sub btnCadNovoProd_Click(sender As Object, e As EventArgs) Handles btnCadNovoProd.Click
        CadEmpresa.ShowDialog(Me)
    End Sub

    Private Sub EditEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCnpj.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        btSalvar.Enabled = False

    End Sub

    Private Sub EditEmpresa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub
End Class