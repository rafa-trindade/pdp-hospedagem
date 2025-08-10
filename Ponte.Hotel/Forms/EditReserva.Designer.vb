<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btConfHos = New System.Windows.Forms.Button()
        Me.gbResSinal = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorSinalRes = New System.Windows.Forms.TextBox()
        Me.cbStatusSinalRes = New System.Windows.Forms.ComboBox()
        Me.cbStatusRes = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDtCadastro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numQtdPessoasRes = New System.Windows.Forms.NumericUpDown()
        Me.gbResDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraEntradaRes = New System.Windows.Forms.DateTimePicker()
        Me.dtEntradaRes = New System.Windows.Forms.DateTimePicker()
        Me.gbResCliente = New System.Windows.Forms.GroupBox()
        Me.cbPesStatusRes = New System.Windows.Forms.ComboBox()
        Me.txtCodRes = New System.Windows.Forms.TextBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeClienteRes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.txtCpfClienteRes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAtualizarRes = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodHos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbHosCliente = New System.Windows.Forms.GroupBox()
        Me.txtNomeClienteHos = New System.Windows.Forms.TextBox()
        Me.txtCPFClienteHos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbHosApartamento = New System.Windows.Forms.GroupBox()
        Me.cbApartamentoHos = New System.Windows.Forms.ComboBox()
        Me.btCadApartamentoHos = New System.Windows.Forms.Button()
        Me.gbHosSinal = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorSinalHos = New System.Windows.Forms.TextBox()
        Me.gbHosDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraHos = New System.Windows.Forms.DateTimePicker()
        Me.dtDataHos = New System.Windows.Forms.DateTimePicker()
        Me.ckConfHos = New System.Windows.Forms.CheckBox()
        Me.btnCadNovoRes = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbResSinal.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numQtdPessoasRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResDataEntrada.SuspendLayout()
        Me.gbResCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbHosCliente.SuspendLayout()
        Me.gbHosApartamento.SuspendLayout()
        Me.gbHosSinal.SuspendLayout()
        Me.gbHosDataEntrada.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btConfHos
        '
        Me.btConfHos.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btConfHos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btConfHos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfHos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfHos.ForeColor = System.Drawing.SystemColors.Window
        Me.btConfHos.Location = New System.Drawing.Point(300, 157)
        Me.btConfHos.Name = "btConfHos"
        Me.btConfHos.Size = New System.Drawing.Size(166, 23)
        Me.btConfHos.TabIndex = 10
        Me.btConfHos.Text = "Confirmar Hospedagem"
        Me.btConfHos.UseVisualStyleBackColor = True
        '
        'gbResSinal
        '
        Me.gbResSinal.Controls.Add(Me.Label6)
        Me.gbResSinal.Controls.Add(Me.txtValorSinalRes)
        Me.gbResSinal.Controls.Add(Me.cbStatusSinalRes)
        Me.gbResSinal.Location = New System.Drawing.Point(205, 106)
        Me.gbResSinal.Name = "gbResSinal"
        Me.gbResSinal.Size = New System.Drawing.Size(261, 46)
        Me.gbResSinal.TabIndex = 65
        Me.gbResSinal.TabStop = False
        Me.gbResSinal.Text = "Sinal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Valor Sinal:"
        '
        'txtValorSinalRes
        '
        Me.txtValorSinalRes.Location = New System.Drawing.Point(68, 16)
        Me.txtValorSinalRes.MaxLength = 10
        Me.txtValorSinalRes.Name = "txtValorSinalRes"
        Me.txtValorSinalRes.Size = New System.Drawing.Size(72, 20)
        Me.txtValorSinalRes.TabIndex = 55
        Me.txtValorSinalRes.Text = "0,00"
        '
        'cbStatusSinalRes
        '
        Me.cbStatusSinalRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusSinalRes.FormattingEnabled = True
        Me.cbStatusSinalRes.Location = New System.Drawing.Point(141, 16)
        Me.cbStatusSinalRes.Name = "cbStatusSinalRes"
        Me.cbStatusSinalRes.Size = New System.Drawing.Size(111, 21)
        Me.cbStatusSinalRes.TabIndex = 57
        '
        'cbStatusRes
        '
        Me.cbStatusRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusRes.FormattingEnabled = True
        Me.cbStatusRes.Location = New System.Drawing.Point(212, 158)
        Me.cbStatusRes.Name = "cbStatusRes"
        Me.cbStatusRes.Size = New System.Drawing.Size(102, 21)
        Me.cbStatusRes.TabIndex = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDtCadastro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.numQtdPessoasRes)
        Me.GroupBox3.Controls.Add(Me.gbResDataEntrada)
        Me.GroupBox3.Controls.Add(Me.gbResSinal)
        Me.GroupBox3.Controls.Add(Me.gbResCliente)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btAtualizarRes)
        Me.GroupBox3.Controls.Add(Me.cbStatusRes)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(473, 190)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DADOS DA RESERVA"
        '
        'lblDtCadastro
        '
        Me.lblDtCadastro.AutoSize = True
        Me.lblDtCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtCadastro.Location = New System.Drawing.Point(294, 13)
        Me.lblDtCadastro.Name = "lblDtCadastro"
        Me.lblDtCadastro.Size = New System.Drawing.Size(49, 13)
        Me.lblDtCadastro.TabIndex = 226
        Me.lblDtCadastro.Text = "Cadastro"
        Me.lblDtCadastro.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 224
        Me.Label7.Text = "Status:"
        '
        'numQtdPessoasRes
        '
        Me.numQtdPessoasRes.Location = New System.Drawing.Point(92, 157)
        Me.numQtdPessoasRes.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtdPessoasRes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQtdPessoasRes.Name = "numQtdPessoasRes"
        Me.numQtdPessoasRes.Size = New System.Drawing.Size(57, 20)
        Me.numQtdPessoasRes.TabIndex = 66
        Me.numQtdPessoasRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numQtdPessoasRes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gbResDataEntrada
        '
        Me.gbResDataEntrada.Controls.Add(Me.dtHoraEntradaRes)
        Me.gbResDataEntrada.Controls.Add(Me.dtEntradaRes)
        Me.gbResDataEntrada.Location = New System.Drawing.Point(6, 106)
        Me.gbResDataEntrada.Name = "gbResDataEntrada"
        Me.gbResDataEntrada.Size = New System.Drawing.Size(182, 46)
        Me.gbResDataEntrada.TabIndex = 58
        Me.gbResDataEntrada.TabStop = False
        Me.gbResDataEntrada.Text = "Data de Entrada"
        '
        'dtHoraEntradaRes
        '
        Me.dtHoraEntradaRes.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraEntradaRes.Location = New System.Drawing.Point(110, 19)
        Me.dtHoraEntradaRes.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtHoraEntradaRes.Name = "dtHoraEntradaRes"
        Me.dtHoraEntradaRes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtHoraEntradaRes.ShowUpDown = True
        Me.dtHoraEntradaRes.Size = New System.Drawing.Size(64, 20)
        Me.dtHoraEntradaRes.TabIndex = 4
        '
        'dtEntradaRes
        '
        Me.dtEntradaRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntradaRes.Location = New System.Drawing.Point(9, 19)
        Me.dtEntradaRes.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtEntradaRes.Name = "dtEntradaRes"
        Me.dtEntradaRes.Size = New System.Drawing.Size(95, 20)
        Me.dtEntradaRes.TabIndex = 3
        '
        'gbResCliente
        '
        Me.gbResCliente.Controls.Add(Me.cbPesStatusRes)
        Me.gbResCliente.Controls.Add(Me.txtCodRes)
        Me.gbResCliente.Controls.Add(Me.btLimpar)
        Me.gbResCliente.Controls.Add(Me.Label1)
        Me.gbResCliente.Controls.Add(Me.Label3)
        Me.gbResCliente.Controls.Add(Me.txtNomeClienteRes)
        Me.gbResCliente.Controls.Add(Me.Label4)
        Me.gbResCliente.Controls.Add(Me.btPesqCliente)
        Me.gbResCliente.Controls.Add(Me.txtCpfClienteRes)
        Me.gbResCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResCliente.Location = New System.Drawing.Point(6, 23)
        Me.gbResCliente.Name = "gbResCliente"
        Me.gbResCliente.Size = New System.Drawing.Size(460, 76)
        Me.gbResCliente.TabIndex = 223
        Me.gbResCliente.TabStop = False
        Me.gbResCliente.Text = "PESQUISA"
        '
        'cbPesStatusRes
        '
        Me.cbPesStatusRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPesStatusRes.FormattingEnabled = True
        Me.cbPesStatusRes.Location = New System.Drawing.Point(149, 44)
        Me.cbPesStatusRes.Name = "cbPesStatusRes"
        Me.cbPesStatusRes.Size = New System.Drawing.Size(122, 21)
        Me.cbPesStatusRes.TabIndex = 225
        '
        'txtCodRes
        '
        Me.txtCodRes.Enabled = False
        Me.txtCodRes.Location = New System.Drawing.Point(365, 18)
        Me.txtCodRes.Name = "txtCodRes"
        Me.txtCodRes.Size = New System.Drawing.Size(88, 20)
        Me.txtCodRes.TabIndex = 63
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(371, 43)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(80, 23)
        Me.btLimpar.TabIndex = 53
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Cód. Reserva:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nome:"
        '
        'txtNomeClienteRes
        '
        Me.txtNomeClienteRes.Location = New System.Drawing.Point(47, 18)
        Me.txtNomeClienteRes.Name = "txtNomeClienteRes"
        Me.txtNomeClienteRes.Size = New System.Drawing.Size(224, 20)
        Me.txtNomeClienteRes.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "RG:"
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Ponte.Hotel.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(277, 43)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 49
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'txtCpfClienteRes
        '
        Me.txtCpfClienteRes.Location = New System.Drawing.Point(47, 45)
        Me.txtCpfClienteRes.MaxLength = 11
        Me.txtCpfClienteRes.Name = "txtCpfClienteRes"
        Me.txtCpfClienteRes.Size = New System.Drawing.Size(93, 20)
        Me.txtCpfClienteRes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Núm. Pessoas:"
        '
        'btAtualizarRes
        '
        Me.btAtualizarRes.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btAtualizarRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btAtualizarRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarRes.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarRes.Location = New System.Drawing.Point(321, 158)
        Me.btAtualizarRes.Name = "btAtualizarRes"
        Me.btAtualizarRes.Size = New System.Drawing.Size(136, 23)
        Me.btAtualizarRes.TabIndex = 10
        Me.btAtualizarRes.Text = "Atualizar"
        Me.btAtualizarRes.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(378, 505)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(109, 23)
        Me.btSair.TabIndex = 224
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodHos)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.gbHosCliente)
        Me.GroupBox2.Controls.Add(Me.gbHosApartamento)
        Me.GroupBox2.Controls.Add(Me.gbHosSinal)
        Me.GroupBox2.Controls.Add(Me.gbHosDataEntrada)
        Me.GroupBox2.Controls.Add(Me.btConfHos)
        Me.GroupBox2.Controls.Add(Me.ckConfHos)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 187)
        Me.GroupBox2.TabIndex = 224
        Me.GroupBox2.TabStop = False
        '
        'txtCodHos
        '
        Me.txtCodHos.Enabled = False
        Me.txtCodHos.Location = New System.Drawing.Point(369, 15)
        Me.txtCodHos.Name = "txtCodHos"
        Me.txtCodHos.Size = New System.Drawing.Size(88, 20)
        Me.txtCodHos.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Cód. Hospedagem:"
        '
        'gbHosCliente
        '
        Me.gbHosCliente.Controls.Add(Me.txtNomeClienteHos)
        Me.gbHosCliente.Controls.Add(Me.txtCPFClienteHos)
        Me.gbHosCliente.Controls.Add(Me.Label9)
        Me.gbHosCliente.Controls.Add(Me.Label8)
        Me.gbHosCliente.Location = New System.Drawing.Point(6, 34)
        Me.gbHosCliente.Name = "gbHosCliente"
        Me.gbHosCliente.Size = New System.Drawing.Size(460, 47)
        Me.gbHosCliente.TabIndex = 232
        Me.gbHosCliente.TabStop = False
        Me.gbHosCliente.Text = "Cliente"
        '
        'txtNomeClienteHos
        '
        Me.txtNomeClienteHos.Enabled = False
        Me.txtNomeClienteHos.Location = New System.Drawing.Point(206, 21)
        Me.txtNomeClienteHos.Name = "txtNomeClienteHos"
        Me.txtNomeClienteHos.Size = New System.Drawing.Size(245, 20)
        Me.txtNomeClienteHos.TabIndex = 224
        '
        'txtCPFClienteHos
        '
        Me.txtCPFClienteHos.Enabled = False
        Me.txtCPFClienteHos.Location = New System.Drawing.Point(47, 21)
        Me.txtCPFClienteHos.MaxLength = 11
        Me.txtCPFClienteHos.Name = "txtCPFClienteHos"
        Me.txtCPFClienteHos.Size = New System.Drawing.Size(113, 20)
        Me.txtCPFClienteHos.TabIndex = 223
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 226
        Me.Label9.Text = "Nome:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "RG:"
        '
        'gbHosApartamento
        '
        Me.gbHosApartamento.Controls.Add(Me.cbApartamentoHos)
        Me.gbHosApartamento.Controls.Add(Me.btCadApartamentoHos)
        Me.gbHosApartamento.Location = New System.Drawing.Point(197, 87)
        Me.gbHosApartamento.Name = "gbHosApartamento"
        Me.gbHosApartamento.Size = New System.Drawing.Size(269, 46)
        Me.gbHosApartamento.TabIndex = 231
        Me.gbHosApartamento.TabStop = False
        Me.gbHosApartamento.Text = "Apartamento"
        '
        'cbApartamentoHos
        '
        Me.cbApartamentoHos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbApartamentoHos.FormattingEnabled = True
        Me.cbApartamentoHos.Location = New System.Drawing.Point(6, 19)
        Me.cbApartamentoHos.Name = "cbApartamentoHos"
        Me.cbApartamentoHos.Size = New System.Drawing.Size(162, 21)
        Me.cbApartamentoHos.TabIndex = 228
        '
        'btCadApartamentoHos
        '
        Me.btCadApartamentoHos.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btCadApartamentoHos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCadApartamentoHos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCadApartamentoHos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadApartamentoHos.ForeColor = System.Drawing.SystemColors.Window
        Me.btCadApartamentoHos.Location = New System.Drawing.Point(174, 19)
        Me.btCadApartamentoHos.Name = "btCadApartamentoHos"
        Me.btCadApartamentoHos.Size = New System.Drawing.Size(89, 23)
        Me.btCadApartamentoHos.TabIndex = 229
        Me.btCadApartamentoHos.Text = "Configurar"
        Me.btCadApartamentoHos.UseVisualStyleBackColor = True
        '
        'gbHosSinal
        '
        Me.gbHosSinal.Controls.Add(Me.Label12)
        Me.gbHosSinal.Controls.Add(Me.txtValorSinalHos)
        Me.gbHosSinal.Location = New System.Drawing.Point(9, 134)
        Me.gbHosSinal.Name = "gbHosSinal"
        Me.gbHosSinal.Size = New System.Drawing.Size(182, 46)
        Me.gbHosSinal.TabIndex = 230
        Me.gbHosSinal.TabStop = False
        Me.gbHosSinal.Text = "Sinal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Valor Sinal:"
        '
        'txtValorSinalHos
        '
        Me.txtValorSinalHos.Enabled = False
        Me.txtValorSinalHos.Location = New System.Drawing.Point(68, 16)
        Me.txtValorSinalHos.MaxLength = 10
        Me.txtValorSinalHos.Name = "txtValorSinalHos"
        Me.txtValorSinalHos.Size = New System.Drawing.Size(106, 20)
        Me.txtValorSinalHos.TabIndex = 55
        Me.txtValorSinalHos.Text = "0,00"
        '
        'gbHosDataEntrada
        '
        Me.gbHosDataEntrada.Controls.Add(Me.dtHoraHos)
        Me.gbHosDataEntrada.Controls.Add(Me.dtDataHos)
        Me.gbHosDataEntrada.Location = New System.Drawing.Point(9, 87)
        Me.gbHosDataEntrada.Name = "gbHosDataEntrada"
        Me.gbHosDataEntrada.Size = New System.Drawing.Size(182, 46)
        Me.gbHosDataEntrada.TabIndex = 59
        Me.gbHosDataEntrada.TabStop = False
        Me.gbHosDataEntrada.Text = "Data de Entrada"
        '
        'dtHoraHos
        '
        Me.dtHoraHos.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraHos.Location = New System.Drawing.Point(110, 19)
        Me.dtHoraHos.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtHoraHos.Name = "dtHoraHos"
        Me.dtHoraHos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtHoraHos.ShowUpDown = True
        Me.dtHoraHos.Size = New System.Drawing.Size(64, 20)
        Me.dtHoraHos.TabIndex = 4
        '
        'dtDataHos
        '
        Me.dtDataHos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataHos.Location = New System.Drawing.Point(9, 19)
        Me.dtDataHos.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtDataHos.Name = "dtDataHos"
        Me.dtDataHos.Size = New System.Drawing.Size(95, 20)
        Me.dtDataHos.TabIndex = 3
        '
        'ckConfHos
        '
        Me.ckConfHos.AutoSize = True
        Me.ckConfHos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConfHos.Location = New System.Drawing.Point(9, 0)
        Me.ckConfHos.Name = "ckConfHos"
        Me.ckConfHos.Size = New System.Drawing.Size(189, 17)
        Me.ckConfHos.TabIndex = 11
        Me.ckConfHos.Text = "CONFIRMAR HOSPEDAGEM"
        Me.ckConfHos.UseVisualStyleBackColor = True
        '
        'btnCadNovoRes
        '
        Me.btnCadNovoRes.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnCadNovoRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadNovoRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadNovoRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadNovoRes.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCadNovoRes.Location = New System.Drawing.Point(299, 81)
        Me.btnCadNovoRes.Name = "btnCadNovoRes"
        Me.btnCadNovoRes.Size = New System.Drawing.Size(188, 23)
        Me.btnCadNovoRes.TabIndex = 233
        Me.btnCadNovoRes.Text = "Cadastrar Nova Reserva"
        Me.btnCadNovoRes.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblStatus.Location = New System.Drawing.Point(17, 86)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 224
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 536)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(495, 17)
        Me.PictureBox2.TabIndex = 236
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 72)
        Me.PictureBox1.TabIndex = 237
        Me.PictureBox1.TabStop = False
        '
        'EditReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(495, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCadNovoRes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditReserva"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Reservas"
        Me.gbResSinal.ResumeLayout(False)
        Me.gbResSinal.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numQtdPessoasRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResDataEntrada.ResumeLayout(False)
        Me.gbResCliente.ResumeLayout(False)
        Me.gbResCliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbHosCliente.ResumeLayout(False)
        Me.gbHosCliente.PerformLayout()
        Me.gbHosApartamento.ResumeLayout(False)
        Me.gbHosSinal.ResumeLayout(False)
        Me.gbHosSinal.PerformLayout()
        Me.gbHosDataEntrada.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btConfHos As System.Windows.Forms.Button
    Friend WithEvents gbResSinal As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorSinalRes As System.Windows.Forms.TextBox
    Friend WithEvents cbStatusSinalRes As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatusRes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btAtualizarRes As System.Windows.Forms.Button
    Friend WithEvents gbResCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodRes As System.Windows.Forms.TextBox
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeClienteRes As System.Windows.Forms.TextBox
    Friend WithEvents btPesqCliente As System.Windows.Forms.Button
    Friend WithEvents txtCpfClienteRes As System.Windows.Forms.TextBox
    Friend WithEvents gbResDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraEntradaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEntradaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents numQtdPessoasRes As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNomeClienteHos As System.Windows.Forms.TextBox
    Friend WithEvents txtCPFClienteHos As System.Windows.Forms.TextBox
    Friend WithEvents gbHosDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraHos As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDataHos As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodHos As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbHosSinal As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValorSinalHos As System.Windows.Forms.TextBox
    Friend WithEvents btCadApartamentoHos As System.Windows.Forms.Button
    Friend WithEvents cbApartamentoHos As System.Windows.Forms.ComboBox
    Friend WithEvents gbHosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbHosApartamento As System.Windows.Forms.GroupBox
    Friend WithEvents ckConfHos As System.Windows.Forms.CheckBox
    Friend WithEvents btnCadNovoRes As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPesStatusRes As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDtCadastro As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
