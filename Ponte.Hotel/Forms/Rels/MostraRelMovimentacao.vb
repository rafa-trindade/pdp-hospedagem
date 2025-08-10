Imports Ponte.Hotel.Dominio

Public Class MostraRelMovimentacao

    Private lstMov As New List(Of clsMovimentacao)
    Private db As New dbcontexto


    Private Sub btGerarSaida_Click(sender As Object, e As EventArgs) Handles btGerarSaida.Click


        lblNumRegistros.Text = "Número de Registros: "

        Dim dataIni As DateTime = dtInicioSaida.Value.ToShortDateString
        Dim dataFim As DateTime = dtFimSaida.Value.ToShortDateString
        dataIni = dataIni & " 00:00:00"
        dataFim = dataFim & " 23:59:59"

        If dataIni > dataFim Then
            MsgBox("A Data Fim deve ser maior ou igual que a Data Início.", MsgBoxStyle.Information, "Relatório")
            dtFimSaida.Focus()
            Exit Sub
        End If

        If cbTipoSaida.SelectedIndex = 0 Then

            Try
                lstMov = (From c In db.Movimentacao Order By c.DataMovimentacao Descending Where c.DataMovimentacao >= dataIni And c.DataMovimentacao <= dataFim And c.Tipo = clsMovimentacao.TipoMovimentacao.Saida Select c).ToList
                If lstMov.Count < 1 Then
                    MsgBox("Nenhum registro de saída no período selecionado.", MsgBoxStyle.Information, "Relatório")
                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

        Else

            Try
                lstMov = (From c In db.Movimentacao Order By c.DataMovimentacao Descending Where c.DataMovimentacao >= dataIni And c.DataMovimentacao <= dataFim And c.Tipo = clsMovimentacao.TipoMovimentacao.Saida And c.Descricao.Contains(cbTipoSaida.Text) Select c).ToList
                If lstMov.Count < 1 Then
                    MsgBox("Nenhum registro de saída do tipo '" + cbTipoSaida.Text + "' no período selecionado.", MsgBoxStyle.Information, "Relatório")
                End If
            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

        End If


        lblNumRegistros.Text += lstMov.Count.ToString
        lblNumRegistros.Visible = True
        gbResumo.Visible = True

        Dim itens = Application.StartupPath & "\Templates\RelMovimentacaoItens.html"
        Dim rel = Application.StartupPath & "\Templates\RelMovimentacao.html"

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
        Dim tipoMov As String = ""

        Dim totalbruto As Double
        lblTotalBruto.Text = ""

        Try
            For Each d In lstMov

                If d.Tipo = 0 Then
                    tipoMov = "Saída"
                Else
                    tipoMov = "Entrada"
                End If


                linha = count / 2
                If linha.ToString.Contains(",5") Then
                    ret += strItens.Replace("{{dataMovimentacao}}", d.DataMovimentacao) _
                        .Replace("{{descricaomovimentacao}}", d.Descricao) _
                        .Replace("{{valorMovimentacao}}", FormatCurrency(d.Valor, 2)) _
                        .Replace("{{tipoMovimentacao}}", tipoMov) _
                        .Replace("<linha>", "<tr style='background-color: white; color: black;'>")
                Else
                    ret += strItens.Replace("{{dataMovimentacao}}", d.DataMovimentacao) _
                        .Replace("{{descricaomovimentacao}}", d.Descricao) _
                        .Replace("{{valorMovimentacao}}", FormatCurrency(d.Valor, 2)) _
                        .Replace("{{tipoMovimentacao}}", tipoMov) _
                        .Replace("<linha>", "<tr style='background-color: #dadada; color: black;'>")
                End If

                count += 1
                totalbruto += d.Valor

            Next
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        ret = strRel.Replace("<dados></dados>", ret)

        lblTotalBruto.Text = FormatCurrency(totalbruto, 2).ToString

        Return ret

    End Function

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MostraRelMovimentacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTipoSaida.SelectedIndex = 0
    End Sub

    Private Sub MostraRelMovimentacao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class