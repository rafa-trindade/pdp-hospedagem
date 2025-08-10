Imports Ponte.Hotel.Dominio
Imports System.Globalization
Imports System.Threading

Public Class CadVale

    Private db As New DbContexto
    Private lst As New List(Of Integer)
    Private lst2 As New List(Of Integer)
    Private totalVales As Double = 0


    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        Dim vale As New clsVale
    
        Try

            With vale
                .DataVale = dtVale.Text
                .ValorVale = txtValorVale.Text
                Dim i As Integer = cbFuncionario.SelectedValue
                .Funcionario = (From c In db.Funcionario Where c.Id = i Select c).First
            End With

            db.Vale.Add(vale)
            db.SaveChanges()

            MsgBox("Vale cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastro de Vales")
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
        End Try
        vale = Nothing
        txtValorVale.Text = "0,00"

        carregaGridVales()


    End Sub

    Private Sub carregaGridVales()
        Try
            grdVales.DataSource = (From c In db.Vale.Include("Funcionario") Order By c.DataVale Descending Where c.Funcionario.Id = cbFuncionario.SelectedValue.ToString And c.DataVale.Month.ToString = Now.Month.ToString Select New With
            {Key .Id = c.Id, Key .DataVale = c.DataVale, Key .ValorVale = c.ValorVale}).ToList()
        Catch ex As Exception
        End Try

        txtTotalVales.Text = FormatCurrency(0, 2)

        If grdVales.Rows.Count <= 0 Then Exit Sub


        grdVales.Columns("DataVale").HeaderText = "Data"
        grdVales.Columns("ValorVale").HeaderText = "Valor Vale"

        grdVales.Columns("DataVale").Width = 100
        grdVales.Columns("ValorVale").Width = grdVales.Width - 143

        grdVales.Columns("ValorVale").DefaultCellStyle.Format = "c"

        grdVales.Columns("Id").Visible = False

        preencheLstVales()

    End Sub

    Private Sub preencheLstVales()

        totalVales = 0
        lst.Clear()
        For Each i As DataGridViewRow In grdVales.Rows
            lst.Add(i.Cells("Id").Value)
            totalVales += i.Cells("ValorVale").Value
        Next

        txtTotalVales.Text = FormatCurrency(totalVales, 2)
    End Sub




    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CadVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        lblMes.Text = "*vales do mês de " + Now.ToString("MMMM").ToUpper

        Try
            cbFuncionario.DataSource = (From c In db.Funcionario Select New With {Key .Id = c.Id, Key .Nome = c.Nome}).ToList()
        Catch ex As Exception
            MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            Me.Dispose()
            Me.Close()
        End Try
        cbFuncionario.SelectedIndex = -1

        cbFuncionario.DisplayMember = "Nome"
        cbFuncionario.ValueMember = "Id"

        carregaGridVales()


    End Sub

    Private Sub grdVales_DoubleClick(sender As Object, e As EventArgs) Handles grdVales.DoubleClick
        If grdVales.Rows.Count <= 0 Then Exit Sub

        If MsgBox("Deseja exclir esse Registro?", MsgBoxStyle.YesNoCancel, "Gerenciar Vales") = MsgBoxResult.Yes Then

            Dim cod = grdVales.SelectedRows(0).Cells(0).Value()

            Try
                Dim ret = (From c In db.Vale Where c.Id.Equals(CType(cod.ToString, Integer)) Select c).FirstOrDefault

                db.Vale.Remove(ret)

                db.SaveChanges()

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados. Verifique sua conexão com a internet.", MsgBoxStyle.Critical, "Erro de Conexão")
            End Try

            carregaGridVales()
        End If

    End Sub

    Private Sub cbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged

        carregaGridVales()

    End Sub

    Private Sub txtValorVale_TextChanged(sender As Object, e As EventArgs) Handles txtValorVale.TextChanged
        TextBoxMoeda(sender)

    End Sub

    Private Sub txtValorVale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorVale.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub CadVale_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

    End Sub
End Class