<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditHospedagem
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
        Me.components = New System.ComponentModel.Container()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.cbStatusPesq = New System.Windows.Forms.CheckBox()
        Me.txtCodHospedagem = New System.Windows.Forms.TextBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.txtCpfCliente = New System.Windows.Forms.TextBox()
        Me.btnCadNovoHosp = New System.Windows.Forms.Button()
        Me.gbDadosHospedagem = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.lblValorDiaria = New System.Windows.Forms.Label()
        Me.txtTotalDiarias = New System.Windows.Forms.TextBox()
        Me.txtCons = New System.Windows.Forms.TextBox()
        Me.lblbsds = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblNumDiarias = New System.Windows.Forms.Label()
        Me.numQtd = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.grdItens = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.gbDetalhesHosp = New System.Windows.Forms.GroupBox()
        Me.lblNumPessoas = New System.Windows.Forms.Label()
        Me.btConfAp = New System.Windows.Forms.Button()
        Me.btAtualizarSinal = New System.Windows.Forms.Button()
        Me.txtSinal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btTrocarAp = New System.Windows.Forms.Button()
        Me.cbApartamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtHoraSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtSaida = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalAPagar = New System.Windows.Forms.TextBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btFinalizar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btApDesc = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtMostraSinal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsExcluirHosp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbCliente.SuspendLayout()
        Me.gbDadosHospedagem.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.numQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbDetalhesHosp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        Me.cmsExcluirHosp.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.cbStatusPesq)
        Me.gbCliente.Controls.Add(Me.txtCodHospedagem)
        Me.gbCliente.Controls.Add(Me.btLimpar)
        Me.gbCliente.Controls.Add(Me.Label1)
        Me.gbCliente.Controls.Add(Me.Label4)
        Me.gbCliente.Controls.Add(Me.Label3)
        Me.gbCliente.Controls.Add(Me.txtNomeCliente)
        Me.gbCliente.Controls.Add(Me.btPesqCliente)
        Me.gbCliente.Controls.Add(Me.txtCpfCliente)
        Me.gbCliente.Location = New System.Drawing.Point(10, 107)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(568, 81)
        Me.gbCliente.TabIndex = 222
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "PESQUISA"
        '
        'cbStatusPesq
        '
        Me.cbStatusPesq.AutoSize = True
        Me.cbStatusPesq.Checked = True
        Me.cbStatusPesq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusPesq.Location = New System.Drawing.Point(11, 22)
        Me.cbStatusPesq.Name = "cbStatusPesq"
        Me.cbStatusPesq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbStatusPesq.Size = New System.Drawing.Size(124, 17)
        Me.cbStatusPesq.TabIndex = 222
        Me.cbStatusPesq.Text = "Hospedagens Ativas"
        Me.cbStatusPesq.UseVisualStyleBackColor = True
        '
        'txtCodHospedagem
        '
        Me.txtCodHospedagem.Enabled = False
        Me.txtCodHospedagem.Location = New System.Drawing.Point(472, 19)
        Me.txtCodHospedagem.Name = "txtCodHospedagem"
        Me.txtCodHospedagem.Size = New System.Drawing.Size(88, 20)
        Me.txtCodHospedagem.TabIndex = 63
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(480, 46)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(80, 23)
        Me.btLimpar.TabIndex = 53
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Cód. Hospedagem:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "RG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nome:"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(200, 48)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(180, 20)
        Me.txtNomeCliente.TabIndex = 2
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Ponte.Hotel.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(386, 46)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 49
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'txtCpfCliente
        '
        Me.txtCpfCliente.Location = New System.Drawing.Point(41, 48)
        Me.txtCpfCliente.MaxLength = 11
        Me.txtCpfCliente.Name = "txtCpfCliente"
        Me.txtCpfCliente.Size = New System.Drawing.Size(111, 20)
        Me.txtCpfCliente.TabIndex = 1
        '
        'btnCadNovoHosp
        '
        Me.btnCadNovoHosp.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnCadNovoHosp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadNovoHosp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadNovoHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadNovoHosp.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCadNovoHosp.Location = New System.Drawing.Point(389, 80)
        Me.btnCadNovoHosp.Name = "btnCadNovoHosp"
        Me.btnCadNovoHosp.Size = New System.Drawing.Size(188, 23)
        Me.btnCadNovoHosp.TabIndex = 11
        Me.btnCadNovoHosp.Text = "Cadastrar Nova Hospedagem"
        Me.btnCadNovoHosp.UseVisualStyleBackColor = True
        '
        'gbDadosHospedagem
        '
        Me.gbDadosHospedagem.Controls.Add(Me.TabControl1)
        Me.gbDadosHospedagem.Location = New System.Drawing.Point(10, 199)
        Me.gbDadosHospedagem.Name = "gbDadosHospedagem"
        Me.gbDadosHospedagem.Size = New System.Drawing.Size(568, 327)
        Me.gbDadosHospedagem.TabIndex = 222
        Me.gbDadosHospedagem.TabStop = False
        Me.gbDadosHospedagem.Text = "DADOS DA HOSPEDAGEM"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(562, 308)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.lbl01)
        Me.TabPage1.Controls.Add(Me.lblValorDiaria)
        Me.TabPage1.Controls.Add(Me.txtTotalDiarias)
        Me.TabPage1.Controls.Add(Me.txtCons)
        Me.TabPage1.Controls.Add(Me.lblbsds)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lblNumDiarias)
        Me.TabPage1.Controls.Add(Me.numQtd)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btAdd)
        Me.TabPage1.Controls.Add(Me.cbProduto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cbTipoProd)
        Me.TabPage1.Controls.Add(Me.grdItens)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(554, 282)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consumação"
        '
        'lbl01
        '
        Me.lbl01.AutoSize = True
        Me.lbl01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl01.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl01.Location = New System.Drawing.Point(125, 236)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(29, 13)
        Me.lbl01.TabIndex = 79
        Me.lbl01.Text = "lbl01"
        Me.lbl01.Visible = False
        '
        'lblValorDiaria
        '
        Me.lblValorDiaria.AutoSize = True
        Me.lblValorDiaria.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblValorDiaria.Location = New System.Drawing.Point(86, 237)
        Me.lblValorDiaria.Name = "lblValorDiaria"
        Me.lblValorDiaria.Size = New System.Drawing.Size(13, 13)
        Me.lblValorDiaria.TabIndex = 77
        Me.lblValorDiaria.Text = "0"
        '
        'txtTotalDiarias
        '
        Me.txtTotalDiarias.Enabled = False
        Me.txtTotalDiarias.Location = New System.Drawing.Point(491, 258)
        Me.txtTotalDiarias.Name = "txtTotalDiarias"
        Me.txtTotalDiarias.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalDiarias.TabIndex = 78
        Me.txtTotalDiarias.Text = "0,00"
        Me.txtTotalDiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCons
        '
        Me.txtCons.Enabled = False
        Me.txtCons.Location = New System.Drawing.Point(491, 234)
        Me.txtCons.Name = "txtCons"
        Me.txtCons.Size = New System.Drawing.Size(56, 20)
        Me.txtCons.TabIndex = 67
        Me.txtCons.Text = "0,00"
        Me.txtCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblbsds
        '
        Me.lblbsds.AutoSize = True
        Me.lblbsds.Location = New System.Drawing.Point(6, 237)
        Me.lblbsds.Name = "lblbsds"
        Me.lblbsds.Size = New System.Drawing.Size(81, 13)
        Me.lblbsds.TabIndex = 222
        Me.lblbsds.Text = "Valor Diária: R$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(405, 259)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Total Diárias: R$"
        '
        'lblNumDiarias
        '
        Me.lblNumDiarias.AutoSize = True
        Me.lblNumDiarias.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNumDiarias.Location = New System.Drawing.Point(101, 259)
        Me.lblNumDiarias.Name = "lblNumDiarias"
        Me.lblNumDiarias.Size = New System.Drawing.Size(13, 13)
        Me.lblNumDiarias.TabIndex = 64
        Me.lblNumDiarias.Text = "0"
        '
        'numQtd
        '
        Me.numQtd.Location = New System.Drawing.Point(377, 34)
        Me.numQtd.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQtd.Name = "numQtd"
        Me.numQtd.Size = New System.Drawing.Size(72, 20)
        Me.numQtd.TabIndex = 5
        Me.numQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numQtd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Número de Diárias:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Quantidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Total Consumação: R$"
        '
        'btAdd
        '
        Me.btAdd.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.btAdd.Location = New System.Drawing.Point(455, 32)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "Adicionar"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(153, 33)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(218, 21)
        Me.cbProduto.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(153, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "Produto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 222
        Me.Label10.Text = "Tipo Produto:"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(6, 33)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(141, 21)
        Me.cbTipoProd.TabIndex = 3
        '
        'grdItens
        '
        Me.grdItens.AllowUserToAddRows = False
        Me.grdItens.AllowUserToDeleteRows = False
        Me.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItens.Location = New System.Drawing.Point(6, 60)
        Me.grdItens.MultiSelect = False
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItens.Size = New System.Drawing.Size(541, 168)
        Me.grdItens.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.Controls.Add(Me.txtObs)
        Me.TabPage2.Controls.Add(Me.gbDetalhesHosp)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(554, 282)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados da Hospedagem"
        '
        'txtObs
        '
        Me.txtObs.Enabled = False
        Me.txtObs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObs.Location = New System.Drawing.Point(11, 193)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(537, 83)
        Me.txtObs.TabIndex = 87
        Me.txtObs.Text = "Acompanhantes e Observações:"
        '
        'gbDetalhesHosp
        '
        Me.gbDetalhesHosp.Controls.Add(Me.lblNumPessoas)
        Me.gbDetalhesHosp.Controls.Add(Me.btConfAp)
        Me.gbDetalhesHosp.Controls.Add(Me.btAtualizarSinal)
        Me.gbDetalhesHosp.Controls.Add(Me.txtSinal)
        Me.gbDetalhesHosp.Controls.Add(Me.GroupBox3)
        Me.gbDetalhesHosp.Controls.Add(Me.GroupBox2)
        Me.gbDetalhesHosp.Controls.Add(Me.Label5)
        Me.gbDetalhesHosp.Controls.Add(Me.gbDataEntrada)
        Me.gbDetalhesHosp.Location = New System.Drawing.Point(6, 13)
        Me.gbDetalhesHosp.Name = "gbDetalhesHosp"
        Me.gbDetalhesHosp.Size = New System.Drawing.Size(348, 175)
        Me.gbDetalhesHosp.TabIndex = 52
        Me.gbDetalhesHosp.TabStop = False
        Me.gbDetalhesHosp.Text = "DETALHES"
        '
        'lblNumPessoas
        '
        Me.lblNumPessoas.AutoSize = True
        Me.lblNumPessoas.Location = New System.Drawing.Point(8, 101)
        Me.lblNumPessoas.Name = "lblNumPessoas"
        Me.lblNumPessoas.Size = New System.Drawing.Size(75, 13)
        Me.lblNumPessoas.TabIndex = 82
        Me.lblNumPessoas.Text = "Num. Pessoas"
        '
        'btConfAp
        '
        Me.btConfAp.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btConfAp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btConfAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfAp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfAp.ForeColor = System.Drawing.SystemColors.Window
        Me.btConfAp.Location = New System.Drawing.Point(11, 72)
        Me.btConfAp.Name = "btConfAp"
        Me.btConfAp.Size = New System.Drawing.Size(183, 23)
        Me.btConfAp.TabIndex = 81
        Me.btConfAp.Text = "Configurar Apartamento"
        Me.btConfAp.UseVisualStyleBackColor = True
        '
        'btAtualizarSinal
        '
        Me.btAtualizarSinal.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btAtualizarSinal.Enabled = False
        Me.btAtualizarSinal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btAtualizarSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtualizarSinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizarSinal.ForeColor = System.Drawing.SystemColors.Window
        Me.btAtualizarSinal.Location = New System.Drawing.Point(204, 91)
        Me.btAtualizarSinal.Name = "btAtualizarSinal"
        Me.btAtualizarSinal.Size = New System.Drawing.Size(130, 23)
        Me.btAtualizarSinal.TabIndex = 81
        Me.btAtualizarSinal.Text = "Atualizar Sinal"
        Me.btAtualizarSinal.UseVisualStyleBackColor = True
        '
        'txtSinal
        '
        Me.txtSinal.Location = New System.Drawing.Point(252, 68)
        Me.txtSinal.Name = "txtSinal"
        Me.txtSinal.Size = New System.Drawing.Size(82, 20)
        Me.txtSinal.TabIndex = 65
        Me.txtSinal.Text = "0,00"
        Me.txtSinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btTrocarAp)
        Me.GroupBox3.Controls.Add(Me.cbApartamento)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 46)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Apartamento"
        '
        'btTrocarAp
        '
        Me.btTrocarAp.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btTrocarAp.Enabled = False
        Me.btTrocarAp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btTrocarAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTrocarAp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTrocarAp.ForeColor = System.Drawing.SystemColors.Window
        Me.btTrocarAp.Location = New System.Drawing.Point(194, 17)
        Me.btTrocarAp.Name = "btTrocarAp"
        Me.btTrocarAp.Size = New System.Drawing.Size(135, 23)
        Me.btTrocarAp.TabIndex = 80
        Me.btTrocarAp.Text = "Atalizar Apartamento"
        Me.btTrocarAp.UseVisualStyleBackColor = True
        '
        'cbApartamento
        '
        Me.cbApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbApartamento.FormattingEnabled = True
        Me.cbApartamento.Location = New System.Drawing.Point(6, 19)
        Me.cbApartamento.Name = "cbApartamento"
        Me.cbApartamento.Size = New System.Drawing.Size(182, 21)
        Me.cbApartamento.TabIndex = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtHoraSaida)
        Me.GroupBox2.Controls.Add(Me.dtSaida)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 49)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data de Saída:"
        '
        'dtHoraSaida
        '
        Me.dtHoraSaida.Enabled = False
        Me.dtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraSaida.Location = New System.Drawing.Point(92, 19)
        Me.dtHoraSaida.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtHoraSaida.Name = "dtHoraSaida"
        Me.dtHoraSaida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtHoraSaida.ShowUpDown = True
        Me.dtHoraSaida.Size = New System.Drawing.Size(65, 20)
        Me.dtHoraSaida.TabIndex = 44
        '
        'dtSaida
        '
        Me.dtSaida.Enabled = False
        Me.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSaida.Location = New System.Drawing.Point(5, 19)
        Me.dtSaida.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtSaida.Name = "dtSaida"
        Me.dtSaida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtSaida.Size = New System.Drawing.Size(81, 20)
        Me.dtSaida.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Sinal: R$"
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtHoraEntrada)
        Me.gbDataEntrada.Controls.Add(Me.dtEntrada)
        Me.gbDataEntrada.Location = New System.Drawing.Point(5, 120)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(162, 49)
        Me.gbDataEntrada.TabIndex = 49
        Me.gbDataEntrada.TabStop = False
        Me.gbDataEntrada.Text = "Data de Entrada"
        '
        'dtHoraEntrada
        '
        Me.dtHoraEntrada.Enabled = False
        Me.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraEntrada.Location = New System.Drawing.Point(92, 19)
        Me.dtHoraEntrada.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtHoraEntrada.Name = "dtHoraEntrada"
        Me.dtHoraEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtHoraEntrada.ShowUpDown = True
        Me.dtHoraEntrada.Size = New System.Drawing.Size(65, 20)
        Me.dtHoraEntrada.TabIndex = 44
        '
        'dtEntrada
        '
        Me.dtEntrada.Enabled = False
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(5, 19)
        Me.dtEntrada.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtEntrada.Size = New System.Drawing.Size(81, 20)
        Me.dtEntrada.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Desconto: R$"
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(102, 552)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(77, 20)
        Me.txtDesconto.TabIndex = 7
        Me.txtDesconto.Text = "0,00"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 576)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Total a Pagar: R$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalAPagar
        '
        Me.txtTotalAPagar.Enabled = False
        Me.txtTotalAPagar.Location = New System.Drawing.Point(102, 573)
        Me.txtTotalAPagar.Name = "txtTotalAPagar"
        Me.txtTotalAPagar.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalAPagar.TabIndex = 57
        Me.txtTotalAPagar.Text = "0,00"
        Me.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(456, 605)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(120, 23)
        Me.btSair.TabIndex = 10
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btFinalizar
        '
        Me.btFinalizar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.ForeColor = System.Drawing.SystemColors.Window
        Me.btFinalizar.Location = New System.Drawing.Point(14, 605)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(166, 23)
        Me.btFinalizar.TabIndex = 9
        Me.btFinalizar.Text = "Finalizar Hospedagem"
        Me.btFinalizar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(457, 534)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Total: R$"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(508, 531)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(56, 20)
        Me.txtTotal.TabIndex = 79
        Me.txtTotal.Text = "0,00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btApDesc
        '
        Me.btApDesc.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btApDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btApDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btApDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btApDesc.ForeColor = System.Drawing.SystemColors.Window
        Me.btApDesc.Location = New System.Drawing.Point(185, 552)
        Me.btApDesc.Name = "btApDesc"
        Me.btApDesc.Size = New System.Drawing.Size(69, 23)
        Me.btApDesc.TabIndex = 8
        Me.btApDesc.Text = "Aplicar"
        Me.btApDesc.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblStatus.Location = New System.Drawing.Point(14, 85)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 65
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'txtMostraSinal
        '
        Me.txtMostraSinal.Enabled = False
        Me.txtMostraSinal.Location = New System.Drawing.Point(102, 531)
        Me.txtMostraSinal.Name = "txtMostraSinal"
        Me.txtMostraSinal.Size = New System.Drawing.Size(77, 20)
        Me.txtMostraSinal.TabIndex = 223
        Me.txtMostraSinal.Text = "0,00"
        Me.txtMostraSinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(11, 534)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 224
        Me.Label12.Text = "Sinal Pago: R$"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Enabled = False
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir Hospedagem"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'cmsExcluirHosp
        '
        Me.cmsExcluirHosp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.cmsExcluirHosp.Name = "Excluir"
        Me.cmsExcluirHosp.Size = New System.Drawing.Size(184, 70)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 631)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(579, 17)
        Me.PictureBox2.TabIndex = 227
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(579, 72)
        Me.PictureBox1.TabIndex = 228
        Me.PictureBox1.TabStop = False
        '
        'EditHospedagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(579, 648)
        Me.ContextMenuStrip = Me.cmsExcluirHosp
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.txtMostraSinal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btApDesc)
        Me.Controls.Add(Me.txtTotalAPagar)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbDadosHospedagem)
        Me.Controls.Add(Me.btnCadNovoHosp)
        Me.Controls.Add(Me.gbCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditHospedagem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Hospedagens"
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.gbDadosHospedagem.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.numQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbDetalhesHosp.ResumeLayout(False)
        Me.gbDetalhesHosp.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbDataEntrada.ResumeLayout(False)
        Me.cmsExcluirHosp.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btPesqCliente As System.Windows.Forms.Button
    Friend WithEvents txtCpfCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCadNovoHosp As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents gbDadosHospedagem As System.Windows.Forms.GroupBox
    Friend WithEvents cbApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents gbDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents grdItens As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAPagar As System.Windows.Forms.TextBox
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btFinalizar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gbDetalhesHosp As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodHospedagem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents cbProduto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatusPesq As System.Windows.Forms.CheckBox
    Friend WithEvents numQtd As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNumDiarias As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblValorDiaria As System.Windows.Forms.Label
    Friend WithEvents lblbsds As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiarias As System.Windows.Forms.TextBox
    Friend WithEvents txtCons As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btApDesc As System.Windows.Forms.Button
    Friend WithEvents lbl01 As System.Windows.Forms.Label
    Friend WithEvents btTrocarAp As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dtHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents btAtualizarSinal As System.Windows.Forms.Button
    Friend WithEvents txtSinal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMostraSinal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsExcluirHosp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btConfAp As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNumPessoas As Label
    Friend WithEvents txtObs As TextBox
End Class
