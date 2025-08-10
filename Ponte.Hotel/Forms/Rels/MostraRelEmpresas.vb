Imports Ponte.Hotel.Dominio

Public Class MostraRelEmpresas

    Private db As New DbContexto
    Private empresa As clsEmpresa
    Private listcliente As New List(Of clsCliente)
    Private listhospedagem As New List(Of clsHospedagem)

    Private Sub MostraRelEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btGerar_Click(sender As Object, e As EventArgs) Handles btGerar.Click

        Try
            empresa = (From c In db.Empresa Where c.Id.ToString = cbEmpresa.SelectedValue.ToString Select c).First
            listcliente = (From c In db.Cliente.Include("Empresa") Order By c.Nome Where c.Empresa.Id = empresa.Id Select c).ToList
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try

        Dim itens = Application.StartupPath & "\Templates\RelEmpresaItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelEmpresa.html"

        Dim str As String = IO.File.ReadAllText(rel.Replace("\bin\Debug", ""))
        Dim str1 As String = IO.File.ReadAllText(itens.Replace("\bin\Debug", ""))

        Dim dados = montaItens(str1, str)

        wbRels.Navigate("about:blank")
        If wbRels.Document IsNot Nothing Then
            wbRels.Document.Write(String.Empty)
        End If
        wbRels.DocumentText = dados

    End Sub

    ''MONTA ITENS"""""""""""""""""""""""""
    Private Function montaItens(strItens As String, strRel As String) As String
        Dim count As Integer = 1
        Dim linha As Double = 1
        Dim ret As String = ""
        Try
            For Each d In listcliente

                listhospedagem = (From c In db.Hospedagem.Include("Cliente") Where c.Cliente.Id = d.Id Select c).ToList

                linha = count / 2
                If linha.ToString.Contains(",5") Then
                    ret += strItens.Replace("{{nomecliente}}", d.Nome) _
                        .Replace("{{cpfcliente}}", d.CPF) _
                        .Replace("{{telefonecliente}}", d.Telefone) _
                        .Replace("{{celularcliente}}", d.Celular) _
                        .Replace("{{emailcliente}}", d.Email) _
                        .Replace("{{datacadastrocliente}}", d.DataCadastro) _
                        .Replace("{{qtdhospedagenscliente}}", listhospedagem.Count) _
                        .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                Else
                    ret += strItens.Replace("{{nomecliente}}", d.Nome) _
                        .Replace("{{cpfcliente}}", d.CPF) _
                        .Replace("{{telefonecliente}}", d.Telefone) _
                        .Replace("{{celularcliente}}", d.Celular) _
                        .Replace("{{emailcliente}}", d.Email) _
                        .Replace("{{datacadastrocliente}}", d.DataCadastro) _
                        .Replace("{{qtdhospedagenscliente}}", listhospedagem.Count) _
                        .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                End If

                count += 1

            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        ret = strRel.Replace("<dados></dados>", ret)

        listhospedagem = (From c In db.Hospedagem.Include("cliente") Where c.Cliente.Empresa.Id = empresa.Id Select c).ToList
        ret = ret.Replace("{{cnpjempresa}}", empresa.CPF_CNPJ) _
            .Replace("{{razaosocial}}", empresa.RazaoSocial) _
            .Replace("{{qtdhospedagensempresa}}", listhospedagem.Count)


        Return ret

    End Function


    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        listcliente = Nothing
        listhospedagem = Nothing
        empresa = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelEmpresas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        listcliente = Nothing
        listhospedagem = Nothing
        empresa = Nothing
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs)
        wbRels.ShowPrintPreviewDialog()
    End Sub

    Private Sub MostraRelEmpresas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class