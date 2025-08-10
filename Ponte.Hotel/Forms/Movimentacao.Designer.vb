<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimentacao
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalEntrada = New System.Windows.Forms.Label()
        Me.grdEntrada = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbDataVale = New System.Windows.Forms.GroupBox()
        Me.dtMov = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDescricao = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblTotalSaida = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.grdSaida = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.txtLucro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.btVales = New System.Windows.Forms.Button()
        Me.dtMes = New System.Windows.Forms.DateTimePicker()
        Me.txtCaixa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotSinal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFundoAnterior = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbDataVale.SuspendLayout()
        CType(Me.grdSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalEntrada)
        Me.GroupBox1.Controls.Add(Me.grdEntrada)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 485)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAIXA (ENTRADA)"
        '
        'lblTotalEntrada
        '
        Me.lblTotalEntrada.AutoSize = True
        Me.lblTotalEntrada.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEntrada.Location = New System.Drawing.Point(0, 469)
        Me.lblTotalEntrada.Name = "lblTotalEntrada"
        Me.lblTotalEntrada.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalEntrada.TabIndex = 241
        Me.lblTotalEntrada.Text = "Total: R$"
        Me.lblTotalEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdEntrada
        '
        Me.grdEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.grdEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEntrada.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdEntrada.Location = New System.Drawing.Point(0, 37)
        Me.grdEntrada.Name = "grdEntrada"
        Me.grdEntrada.Size = New System.Drawing.Size(576, 419)
        Me.grdEntrada.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox3.Location = New System.Drawing.Point(-13, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(589, 478)
        Me.PictureBox3.TabIndex = 83
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbDataVale)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbDescricao)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.lblTotalSaida)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btSalvar)
        Me.GroupBox2.Controls.Add(Me.grdSaida)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(594, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 485)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CAIXA (SAÍDA)"
        '
        'gbDataVale
        '
        Me.gbDataVale.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.gbDataVale.Controls.Add(Me.dtMov)
        Me.gbDataVale.Location = New System.Drawing.Point(429, 122)
        Me.gbDataVale.Name = "gbDataVale"
        Me.gbDataVale.Size = New System.Drawing.Size(142, 46)
        Me.gbDataVale.TabIndex = 255
        Me.gbDataVale.TabStop = False
        Me.gbDataVale.Text = "Data:"
        '
        'dtMov
        '
        Me.dtMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMov.Location = New System.Drawing.Point(10, 14)
        Me.dtMov.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtMov.Name = "dtMov"
        Me.dtMov.Size = New System.Drawing.Size(126, 21)
        Me.dtMov.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Descrição:"
        '
        'cbDescricao
        '
        Me.cbDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbDescricao.FormattingEnabled = True
        Me.cbDescricao.Items.AddRange(New Object() {"Todos", "Café da Manhã", "Despesa Pessoal", "Despesa Fixa", "Diária", "Estoque", "Gás", "Instalação/Manutenção", "Material de Escritório", "Material de Limpeza", "Retirada", "Utensilio Doméstico", "Vale", "--Outro"})
        Me.cbDescricao.Location = New System.Drawing.Point(5, 37)
        Me.cbDescricao.Name = "cbDescricao"
        Me.cbDescricao.Size = New System.Drawing.Size(418, 215)
        Me.cbDescricao.TabIndex = 245
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "R$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValor
        '
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(459, 52)
        Me.txtValor.MaxLength = 10
        Me.txtValor.Name = "txtValor"
        Me.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValor.Size = New System.Drawing.Size(112, 19)
        Me.txtValor.TabIndex = 88
        Me.txtValor.Text = "0,00"
        '
        'lblTotalSaida
        '
        Me.lblTotalSaida.AutoSize = True
        Me.lblTotalSaida.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSaida.Location = New System.Drawing.Point(0, 469)
        Me.lblTotalSaida.Name = "lblTotalSaida"
        Me.lblTotalSaida.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalSaida.TabIndex = 243
        Me.lblTotalSaida.Text = "Total: R$"
        Me.lblTotalSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Valor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btSalvar.Location = New System.Drawing.Point(429, 78)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(142, 23)
        Me.btSalvar.TabIndex = 84
        Me.btSalvar.Text = "Adicionar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'grdSaida
        '
        Me.grdSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSaida.Location = New System.Drawing.Point(0, 258)
        Me.grdSaida.Name = "grdSaida"
        Me.grdSaida.Size = New System.Drawing.Size(578, 198)
        Me.grdSaida.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox4.Location = New System.Drawing.Point(-6, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(584, 478)
        Me.PictureBox4.TabIndex = 90
        Me.PictureBox4.TabStop = False
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1085, 673)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(87, 23)
        Me.btSair.TabIndex = 84
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'txtLucro
        '
        Me.txtLucro.Enabled = False
        Me.txtLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLucro.Location = New System.Drawing.Point(90, 14)
        Me.txtLucro.MaxLength = 10
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Size = New System.Drawing.Size(86, 20)
        Me.txtLucro.TabIndex = 90
        Me.txtLucro.Text = "0,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Saldo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Movimentação do Mês de:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 700)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1179, 17)
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
        Me.PictureBox1.Size = New System.Drawing.Size(1179, 72)
        Me.PictureBox1.TabIndex = 237
        Me.PictureBox1.TabStop = False
        '
        'btnRelatorios
        '
        Me.btnRelatorios.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRelatorios.Location = New System.Drawing.Point(12, 615)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(114, 23)
        Me.btnRelatorios.TabIndex = 245
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'btVales
        '
        Me.btVales.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btVales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btVales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVales.ForeColor = System.Drawing.SystemColors.Window
        Me.btVales.Location = New System.Drawing.Point(132, 615)
        Me.btVales.Name = "btVales"
        Me.btVales.Size = New System.Drawing.Size(114, 23)
        Me.btVales.TabIndex = 246
        Me.btVales.Text = "Vales"
        Me.btVales.UseVisualStyleBackColor = True
        '
        'dtMes
        '
        Me.dtMes.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMes.Location = New System.Drawing.Point(144, 578)
        Me.dtMes.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtMes.Name = "dtMes"
        Me.dtMes.Size = New System.Drawing.Size(113, 21)
        Me.dtMes.TabIndex = 4
        '
        'txtCaixa
        '
        Me.txtCaixa.Enabled = False
        Me.txtCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaixa.Location = New System.Drawing.Point(6, 18)
        Me.txtCaixa.MaxLength = 10
        Me.txtCaixa.Name = "txtCaixa"
        Me.txtCaixa.Size = New System.Drawing.Size(86, 20)
        Me.txtCaixa.TabIndex = 247
        Me.txtCaixa.Text = "0,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 250
        Me.Label6.Text = "Total Sinal:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotSinal
        '
        Me.txtTotSinal.Enabled = False
        Me.txtTotSinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotSinal.Location = New System.Drawing.Point(90, 33)
        Me.txtTotSinal.MaxLength = 10
        Me.txtTotSinal.Name = "txtTotSinal"
        Me.txtTotSinal.Size = New System.Drawing.Size(86, 20)
        Me.txtTotSinal.TabIndex = 249
        Me.txtTotSinal.Text = "0,00"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtFundoAnterior)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtTotSinal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtLucro)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(865, 584)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 83)
        Me.GroupBox3.TabIndex = 251
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controle Fundo de Caixa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(179, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 256
        Me.Label10.Text = "="
        '
        'txtFundoAnterior
        '
        Me.txtFundoAnterior.Enabled = False
        Me.txtFundoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFundoAnterior.Location = New System.Drawing.Point(90, 51)
        Me.txtFundoAnterior.MaxLength = 10
        Me.txtFundoAnterior.Name = "txtFundoAnterior"
        Me.txtFundoAnterior.Size = New System.Drawing.Size(86, 20)
        Me.txtFundoAnterior.TabIndex = 253
        Me.txtFundoAnterior.Text = "2870,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 255
        Me.Label9.Text = "+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 254
        Me.Label8.Text = "Mês Anterior:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "+"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCaixa)
        Me.GroupBox4.Location = New System.Drawing.Point(199, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(97, 42)
        Me.GroupBox4.TabIndex = 251
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fundo de Caixa"
        '
        'Movimentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1179, 717)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtMes)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btVales)
        Me.Controls.Add(Me.btnRelatorios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Movimentacao"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentação Financeira Mensal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbDataVale.ResumeLayout(False)
        CType(Me.grdSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdSaida As System.Windows.Forms.DataGridView
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents txtLucro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalEntrada As System.Windows.Forms.Label
    Friend WithEvents lblTotalSaida As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents grdEntrada As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRelatorios As Button
    Friend WithEvents cbDescricao As ComboBox
    Friend WithEvents btVales As Button
    Friend WithEvents gbDataVale As GroupBox
    Friend WithEvents dtMov As DateTimePicker
    Friend WithEvents dtMes As DateTimePicker
    Friend WithEvents txtCaixa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotSinal As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFundoAnterior As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
End Class
