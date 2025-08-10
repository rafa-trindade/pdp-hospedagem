<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostraRelReservas
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.ckPeriodoCliente = New System.Windows.Forms.CheckBox()
        Me.gbDataFimCliente = New System.Windows.Forms.GroupBox()
        Me.dtFimCliente = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.txtCpfCliente = New System.Windows.Forms.TextBox()
        Me.cbStatusCliente = New System.Windows.Forms.ComboBox()
        Me.gbDataInicioCliente = New System.Windows.Forms.GroupBox()
        Me.dtInicioCliente = New System.Windows.Forms.DateTimePicker()
        Me.btGerarCliente = New System.Windows.Forms.Button()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.gbCodigo = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btGerarCodigo = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.gbPeriodo = New System.Windows.Forms.GroupBox()
        Me.cbStatusPeriodo = New System.Windows.Forms.ComboBox()
        Me.btGerarPeriodo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.ckPeriodoEmpresa = New System.Windows.Forms.CheckBox()
        Me.gbDataFimEmpresa = New System.Windows.Forms.GroupBox()
        Me.dtFimEmpresa = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbStatusEmpresa = New System.Windows.Forms.ComboBox()
        Me.btGerarEmpresa = New System.Windows.Forms.Button()
        Me.gbDataInicioEmpresa = New System.Windows.Forms.GroupBox()
        Me.dtInicioEmpresa = New System.Windows.Forms.DateTimePicker()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.gbCliente.SuspendLayout()
        Me.gbDataFimCliente.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbDataInicioCliente.SuspendLayout()
        Me.gbCodigo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbPeriodo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        Me.gbEmpresa.SuspendLayout()
        Me.gbDataFimEmpresa.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbDataInicioEmpresa.SuspendLayout()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbCliente)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.Controls.Add(Me.rbCliente)
        Me.GroupBox2.Controls.Add(Me.rbPeriodo)
        Me.GroupBox2.Controls.Add(Me.rbEmpresa)
        Me.GroupBox2.Controls.Add(Me.gbCodigo)
        Me.GroupBox2.Controls.Add(Me.gbEmpresa)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(806, 138)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTROS"
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.ckPeriodoCliente)
        Me.gbCliente.Controls.Add(Me.gbDataFimCliente)
        Me.gbCliente.Controls.Add(Me.GroupBox4)
        Me.gbCliente.Controls.Add(Me.cbStatusCliente)
        Me.gbCliente.Controls.Add(Me.gbDataInicioCliente)
        Me.gbCliente.Controls.Add(Me.btGerarCliente)
        Me.gbCliente.Location = New System.Drawing.Point(144, 21)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(652, 111)
        Me.gbCliente.TabIndex = 85
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "CLIENTE HOSPEDADO"
        '
        'ckPeriodoCliente
        '
        Me.ckPeriodoCliente.AutoSize = True
        Me.ckPeriodoCliente.Checked = True
        Me.ckPeriodoCliente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPeriodoCliente.Location = New System.Drawing.Point(16, 74)
        Me.ckPeriodoCliente.Name = "ckPeriodoCliente"
        Me.ckPeriodoCliente.Size = New System.Drawing.Size(70, 30)
        Me.ckPeriodoCliente.TabIndex = 92
        Me.ckPeriodoCliente.Text = "Todas as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datas"
        Me.ckPeriodoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckPeriodoCliente.UseVisualStyleBackColor = True
        '
        'gbDataFimCliente
        '
        Me.gbDataFimCliente.Controls.Add(Me.dtFimCliente)
        Me.gbDataFimCliente.Location = New System.Drawing.Point(205, 65)
        Me.gbDataFimCliente.Name = "gbDataFimCliente"
        Me.gbDataFimCliente.Size = New System.Drawing.Size(107, 43)
        Me.gbDataFimCliente.TabIndex = 91
        Me.gbDataFimCliente.TabStop = False
        Me.gbDataFimCliente.Text = "Data Fim:"
        '
        'dtFimCliente
        '
        Me.dtFimCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFimCliente.Location = New System.Drawing.Point(5, 19)
        Me.dtFimCliente.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtFimCliente.Name = "dtFimCliente"
        Me.dtFimCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFimCliente.Size = New System.Drawing.Size(96, 20)
        Me.dtFimCliente.TabIndex = 43
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btLimpar)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtNomeCliente)
        Me.GroupBox4.Controls.Add(Me.btPesqCliente)
        Me.GroupBox4.Controls.Add(Me.txtCpfCliente)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(639, 43)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(553, 15)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(80, 23)
        Me.btLimpar.TabIndex = 59
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "RG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Nome:"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(185, 18)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(268, 20)
        Me.txtNomeCliente.TabIndex = 55
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Ponte.Hotel.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(459, 15)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 58
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'txtCpfCliente
        '
        Me.txtCpfCliente.Location = New System.Drawing.Point(38, 18)
        Me.txtCpfCliente.MaxLength = 14
        Me.txtCpfCliente.Name = "txtCpfCliente"
        Me.txtCpfCliente.Size = New System.Drawing.Size(97, 20)
        Me.txtCpfCliente.TabIndex = 54
        '
        'cbStatusCliente
        '
        Me.cbStatusCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusCliente.FormattingEnabled = True
        Me.cbStatusCliente.Items.AddRange(New Object() {"Todas", "Solicitadas", "Confirmadas", "Canceladas"})
        Me.cbStatusCliente.Location = New System.Drawing.Point(347, 83)
        Me.cbStatusCliente.Name = "cbStatusCliente"
        Me.cbStatusCliente.Size = New System.Drawing.Size(159, 21)
        Me.cbStatusCliente.TabIndex = 69
        '
        'gbDataInicioCliente
        '
        Me.gbDataInicioCliente.Controls.Add(Me.dtInicioCliente)
        Me.gbDataInicioCliente.Location = New System.Drawing.Point(92, 65)
        Me.gbDataInicioCliente.Name = "gbDataInicioCliente"
        Me.gbDataInicioCliente.Size = New System.Drawing.Size(107, 43)
        Me.gbDataInicioCliente.TabIndex = 90
        Me.gbDataInicioCliente.TabStop = False
        Me.gbDataInicioCliente.Text = "Data Início:"
        '
        'dtInicioCliente
        '
        Me.dtInicioCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioCliente.Location = New System.Drawing.Point(5, 19)
        Me.dtInicioCliente.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtInicioCliente.Name = "dtInicioCliente"
        Me.dtInicioCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtInicioCliente.Size = New System.Drawing.Size(96, 20)
        Me.dtInicioCliente.TabIndex = 43
        '
        'btGerarCliente
        '
        Me.btGerarCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarCliente.Location = New System.Drawing.Point(512, 81)
        Me.btGerarCliente.Name = "btGerarCliente"
        Me.btGerarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarCliente.Size = New System.Drawing.Size(134, 23)
        Me.btGerarCliente.TabIndex = 68
        Me.btGerarCliente.Text = "Gerar Relatório"
        Me.btGerarCliente.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(9, 21)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(101, 17)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código Reserva"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(9, 43)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 0
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Location = New System.Drawing.Point(9, 65)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(63, 17)
        Me.rbPeriodo.TabIndex = 0
        Me.rbPeriodo.TabStop = True
        Me.rbPeriodo.Text = "Período"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.Location = New System.Drawing.Point(9, 87)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(66, 17)
        Me.rbEmpresa.TabIndex = 0
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Text = "Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'gbCodigo
        '
        Me.gbCodigo.Controls.Add(Me.GroupBox3)
        Me.gbCodigo.Controls.Add(Me.gbPeriodo)
        Me.gbCodigo.Location = New System.Drawing.Point(144, 21)
        Me.gbCodigo.Name = "gbCodigo"
        Me.gbCodigo.Size = New System.Drawing.Size(277, 72)
        Me.gbCodigo.TabIndex = 86
        Me.gbCodigo.TabStop = False
        Me.gbCodigo.Text = "CÓDIGO RESERVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btGerarCodigo)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 49)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Código"
        '
        'btGerarCodigo
        '
        Me.btGerarCodigo.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarCodigo.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarCodigo.Location = New System.Drawing.Point(134, 17)
        Me.btGerarCodigo.Name = "btGerarCodigo"
        Me.btGerarCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarCodigo.Size = New System.Drawing.Size(125, 23)
        Me.btGerarCodigo.TabIndex = 67
        Me.btGerarCodigo.Text = "Gerar Relatório"
        Me.btGerarCodigo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(7, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'gbPeriodo
        '
        Me.gbPeriodo.Controls.Add(Me.cbStatusPeriodo)
        Me.gbPeriodo.Controls.Add(Me.btGerarPeriodo)
        Me.gbPeriodo.Controls.Add(Me.GroupBox1)
        Me.gbPeriodo.Controls.Add(Me.gbDataEntrada)
        Me.gbPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.gbPeriodo.Name = "gbPeriodo"
        Me.gbPeriodo.Size = New System.Drawing.Size(256, 99)
        Me.gbPeriodo.TabIndex = 84
        Me.gbPeriodo.TabStop = False
        Me.gbPeriodo.Text = "PERÍODO HOSPEDAGEM"
        '
        'cbStatusPeriodo
        '
        Me.cbStatusPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusPeriodo.FormattingEnabled = True
        Me.cbStatusPeriodo.Items.AddRange(New Object() {"Todas", "Solicitadas", "Confirmadas", "Canceladas"})
        Me.cbStatusPeriodo.Location = New System.Drawing.Point(6, 72)
        Me.cbStatusPeriodo.Name = "cbStatusPeriodo"
        Me.cbStatusPeriodo.Size = New System.Drawing.Size(119, 21)
        Me.cbStatusPeriodo.TabIndex = 70
        '
        'btGerarPeriodo
        '
        Me.btGerarPeriodo.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerarPeriodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarPeriodo.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarPeriodo.Location = New System.Drawing.Point(131, 72)
        Me.btGerarPeriodo.Name = "btGerarPeriodo"
        Me.btGerarPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarPeriodo.Size = New System.Drawing.Size(119, 23)
        Me.btGerarPeriodo.TabIndex = 66
        Me.btGerarPeriodo.Text = "Gerar Relatório"
        Me.btGerarPeriodo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFim)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 49)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Fim:"
        '
        'dtFim
        '
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(5, 19)
        Me.dtFim.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFim.Size = New System.Drawing.Size(108, 20)
        Me.dtFim.TabIndex = 43
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtInicio)
        Me.gbDataEntrada.Location = New System.Drawing.Point(6, 19)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(119, 49)
        Me.gbDataEntrada.TabIndex = 64
        Me.gbDataEntrada.TabStop = False
        Me.gbDataEntrada.Text = "Data Início:"
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(5, 19)
        Me.dtInicio.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtInicio.TabIndex = 43
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Controls.Add(Me.ckPeriodoEmpresa)
        Me.gbEmpresa.Controls.Add(Me.gbDataFimEmpresa)
        Me.gbEmpresa.Controls.Add(Me.GroupBox5)
        Me.gbEmpresa.Controls.Add(Me.cbStatusEmpresa)
        Me.gbEmpresa.Controls.Add(Me.btGerarEmpresa)
        Me.gbEmpresa.Controls.Add(Me.gbDataInicioEmpresa)
        Me.gbEmpresa.Location = New System.Drawing.Point(144, 21)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(530, 100)
        Me.gbEmpresa.TabIndex = 87
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "EMPRESA"
        '
        'ckPeriodoEmpresa
        '
        Me.ckPeriodoEmpresa.AutoSize = True
        Me.ckPeriodoEmpresa.Checked = True
        Me.ckPeriodoEmpresa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPeriodoEmpresa.Location = New System.Drawing.Point(287, 28)
        Me.ckPeriodoEmpresa.Name = "ckPeriodoEmpresa"
        Me.ckPeriodoEmpresa.Size = New System.Drawing.Size(156, 17)
        Me.ckPeriodoEmpresa.TabIndex = 95
        Me.ckPeriodoEmpresa.Text = "Todas as Datas de Entrada"
        Me.ckPeriodoEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckPeriodoEmpresa.UseVisualStyleBackColor = True
        '
        'gbDataFimEmpresa
        '
        Me.gbDataFimEmpresa.Controls.Add(Me.dtFimEmpresa)
        Me.gbDataFimEmpresa.Location = New System.Drawing.Point(415, 51)
        Me.gbDataFimEmpresa.Name = "gbDataFimEmpresa"
        Me.gbDataFimEmpresa.Size = New System.Drawing.Size(107, 43)
        Me.gbDataFimEmpresa.TabIndex = 94
        Me.gbDataFimEmpresa.TabStop = False
        Me.gbDataFimEmpresa.Text = "Data Fim:"
        '
        'dtFimEmpresa
        '
        Me.dtFimEmpresa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFimEmpresa.Location = New System.Drawing.Point(5, 19)
        Me.dtFimEmpresa.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtFimEmpresa.Name = "dtFimEmpresa"
        Me.dtFimEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFimEmpresa.Size = New System.Drawing.Size(96, 20)
        Me.dtFimEmpresa.TabIndex = 43
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbEmpresa)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(275, 44)
        Me.GroupBox5.TabIndex = 73
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Empresa"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(6, 18)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(263, 21)
        Me.cbEmpresa.TabIndex = 6
        '
        'cbStatusEmpresa
        '
        Me.cbStatusEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusEmpresa.FormattingEnabled = True
        Me.cbStatusEmpresa.Items.AddRange(New Object() {"Todas", "Solicitadas", "Confirmadas", "Canceladas"})
        Me.cbStatusEmpresa.Location = New System.Drawing.Point(12, 67)
        Me.cbStatusEmpresa.Name = "cbStatusEmpresa"
        Me.cbStatusEmpresa.Size = New System.Drawing.Size(144, 21)
        Me.cbStatusEmpresa.TabIndex = 72
        '
        'btGerarEmpresa
        '
        Me.btGerarEmpresa.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarEmpresa.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarEmpresa.Location = New System.Drawing.Point(162, 67)
        Me.btGerarEmpresa.Name = "btGerarEmpresa"
        Me.btGerarEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarEmpresa.Size = New System.Drawing.Size(119, 23)
        Me.btGerarEmpresa.TabIndex = 71
        Me.btGerarEmpresa.Text = "Gerar Relatório"
        Me.btGerarEmpresa.UseVisualStyleBackColor = True
        '
        'gbDataInicioEmpresa
        '
        Me.gbDataInicioEmpresa.Controls.Add(Me.dtInicioEmpresa)
        Me.gbDataInicioEmpresa.Location = New System.Drawing.Point(302, 51)
        Me.gbDataInicioEmpresa.Name = "gbDataInicioEmpresa"
        Me.gbDataInicioEmpresa.Size = New System.Drawing.Size(107, 43)
        Me.gbDataInicioEmpresa.TabIndex = 93
        Me.gbDataInicioEmpresa.TabStop = False
        Me.gbDataInicioEmpresa.Text = "Data Início:"
        '
        'dtInicioEmpresa
        '
        Me.dtInicioEmpresa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioEmpresa.Location = New System.Drawing.Point(5, 19)
        Me.dtInicioEmpresa.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtInicioEmpresa.Name = "dtInicioEmpresa"
        Me.dtInicioEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtInicioEmpresa.Size = New System.Drawing.Size(96, 20)
        Me.dtInicioEmpresa.TabIndex = 43
        '
        'wbRels
        '
        Me.wbRels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbRels.Location = New System.Drawing.Point(0, 272)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1121, 340)
        Me.wbRels.TabIndex = 96
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.AutoSize = True
        Me.lblNumRegistros.Location = New System.Drawing.Point(12, 619)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(58, 13)
        Me.lblNumRegistros.TabIndex = 102
        Me.lblNumRegistros.Text = "Num. Reg."
        Me.lblNumRegistros.Visible = False
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox20.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox20.Image = Global.Ponte.Hotel.My.Resources.Resources.endereco
        Me.PictureBox20.Location = New System.Drawing.Point(816, 12)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(293, 87)
        Me.PictureBox20.TabIndex = 111
        Me.PictureBox20.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox15.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image
        Me.PictureBox15.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(1121, 126)
        Me.PictureBox15.TabIndex = 110
        Me.PictureBox15.TabStop = False
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1023, 243)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(98, 23)
        Me.btSair.TabIndex = 98
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 612)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1121, 28)
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'MostraRelReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1121, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.lblNumRegistros)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.wbRels)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MostraRelReservas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Reservas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.gbDataFimCliente.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDataInicioCliente.ResumeLayout(False)
        Me.gbCodigo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbPeriodo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDataEntrada.ResumeLayout(False)
        Me.gbEmpresa.ResumeLayout(False)
        Me.gbEmpresa.PerformLayout()
        Me.gbDataFimEmpresa.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.gbDataInicioEmpresa.ResumeLayout(False)
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents ckPeriodoEmpresa As System.Windows.Forms.CheckBox
    Friend WithEvents gbDataFimEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents dtFimEmpresa As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatusEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents btGerarEmpresa As System.Windows.Forms.Button
    Friend WithEvents gbDataInicioEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents dtInicioEmpresa As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents ckPeriodoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents gbDataFimCliente As System.Windows.Forms.GroupBox
    Friend WithEvents dtFimCliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents btPesqCliente As System.Windows.Forms.Button
    Friend WithEvents txtCpfCliente As System.Windows.Forms.TextBox
    Friend WithEvents cbStatusCliente As System.Windows.Forms.ComboBox
    Friend WithEvents gbDataInicioCliente As System.Windows.Forms.GroupBox
    Friend WithEvents dtInicioCliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents btGerarCliente As System.Windows.Forms.Button
    Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents cbStatusPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btGerarPeriodo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btGerarCodigo As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents wbRels As System.Windows.Forms.WebBrowser
    Friend WithEvents lblNumRegistros As System.Windows.Forms.Label
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
End Class
