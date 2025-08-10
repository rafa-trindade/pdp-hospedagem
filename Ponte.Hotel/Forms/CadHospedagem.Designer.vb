<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadHospedagem
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
        Me.btSair = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCpfCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCadNovoCliente = New System.Windows.Forms.Button()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValorBase = New System.Windows.Forms.TextBox()
        Me.gbDadosHospedagem = New System.Windows.Forms.GroupBox()
        Me.txtCodHospedagem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCadApartamento = New System.Windows.Forms.Button()
        Me.cbApartamento = New System.Windows.Forms.ComboBox()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSinal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.gbCliente.SuspendLayout()
        Me.gbDadosHospedagem.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(387, 401)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 23)
        Me.btSair.TabIndex = 3
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btSalvar.Location = New System.Drawing.Point(289, 401)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(92, 23)
        Me.btSalvar.TabIndex = 2
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(12, 401)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(88, 23)
        Me.btLimpar.TabIndex = 4
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'dtEntrada
        '
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(9, 19)
        Me.dtEntrada.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(95, 20)
        Me.dtEntrada.TabIndex = 0
        '
        'btPesqCliente
        '
        Me.btPesqCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btPesqCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqCliente.Image = Global.Ponte.Hotel.My.Resources.Resources.search_folder
        Me.btPesqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqCliente.Location = New System.Drawing.Point(204, 19)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 2
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(56, 49)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(266, 20)
        Me.txtNomeCliente.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome:"
        '
        'txtCpfCliente
        '
        Me.txtCpfCliente.Location = New System.Drawing.Point(56, 21)
        Me.txtCpfCliente.MaxLength = 14
        Me.txtCpfCliente.Name = "txtCpfCliente"
        Me.txtCpfCliente.Size = New System.Drawing.Size(142, 20)
        Me.txtCpfCliente.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RG:"
        '
        'btnCadNovoCliente
        '
        Me.btnCadNovoCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnCadNovoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadNovoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadNovoCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCadNovoCliente.Location = New System.Drawing.Point(298, 20)
        Me.btnCadNovoCliente.Name = "btnCadNovoCliente"
        Me.btnCadNovoCliente.Size = New System.Drawing.Size(150, 23)
        Me.btnCadNovoCliente.TabIndex = 3
        Me.btnCadNovoCliente.Text = "Cadastrar Novo Cliente"
        Me.btnCadNovoCliente.UseVisualStyleBackColor = True
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.Label8)
        Me.gbCliente.Controls.Add(Me.btnCadNovoCliente)
        Me.gbCliente.Controls.Add(Me.txtValorBase)
        Me.gbCliente.Controls.Add(Me.Label4)
        Me.gbCliente.Controls.Add(Me.btPesqCliente)
        Me.gbCliente.Controls.Add(Me.txtCpfCliente)
        Me.gbCliente.Controls.Add(Me.txtNomeCliente)
        Me.gbCliente.Controls.Add(Me.Label3)
        Me.gbCliente.Location = New System.Drawing.Point(12, 79)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(456, 81)
        Me.gbCliente.TabIndex = 0
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "CLIENTE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Valor Base:"
        '
        'txtValorBase
        '
        Me.txtValorBase.Location = New System.Drawing.Point(393, 49)
        Me.txtValorBase.Name = "txtValorBase"
        Me.txtValorBase.Size = New System.Drawing.Size(55, 20)
        Me.txtValorBase.TabIndex = 7
        '
        'gbDadosHospedagem
        '
        Me.gbDadosHospedagem.Controls.Add(Me.txtCodHospedagem)
        Me.gbDadosHospedagem.Controls.Add(Me.Label1)
        Me.gbDadosHospedagem.Controls.Add(Me.btCadApartamento)
        Me.gbDadosHospedagem.Controls.Add(Me.cbApartamento)
        Me.gbDadosHospedagem.Controls.Add(Me.gbDataEntrada)
        Me.gbDadosHospedagem.Controls.Add(Me.Label5)
        Me.gbDadosHospedagem.Location = New System.Drawing.Point(12, 166)
        Me.gbDadosHospedagem.Name = "gbDadosHospedagem"
        Me.gbDadosHospedagem.Size = New System.Drawing.Size(456, 108)
        Me.gbDadosHospedagem.TabIndex = 1
        Me.gbDadosHospedagem.TabStop = False
        Me.gbDadosHospedagem.Text = "DADOS DA HOSPEDAGEM"
        '
        'txtCodHospedagem
        '
        Me.txtCodHospedagem.Enabled = False
        Me.txtCodHospedagem.Location = New System.Drawing.Point(328, 70)
        Me.txtCodHospedagem.Name = "txtCodHospedagem"
        Me.txtCodHospedagem.Size = New System.Drawing.Size(73, 20)
        Me.txtCodHospedagem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cód. Hospedagem:"
        '
        'btCadApartamento
        '
        Me.btCadApartamento.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btCadApartamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCadApartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCadApartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadApartamento.ForeColor = System.Drawing.SystemColors.Window
        Me.btCadApartamento.Location = New System.Drawing.Point(255, 20)
        Me.btCadApartamento.Name = "btCadApartamento"
        Me.btCadApartamento.Size = New System.Drawing.Size(193, 23)
        Me.btCadApartamento.TabIndex = 2
        Me.btCadApartamento.Text = "Configurar Apartamento"
        Me.btCadApartamento.UseVisualStyleBackColor = True
        '
        'cbApartamento
        '
        Me.cbApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbApartamento.FormattingEnabled = True
        Me.cbApartamento.Location = New System.Drawing.Point(88, 21)
        Me.cbApartamento.Name = "cbApartamento"
        Me.cbApartamento.Size = New System.Drawing.Size(161, 21)
        Me.cbApartamento.TabIndex = 0
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtHoraEntrada)
        Me.gbDataEntrada.Controls.Add(Me.dtEntrada)
        Me.gbDataEntrada.Location = New System.Drawing.Point(4, 51)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(182, 46)
        Me.gbDataEntrada.TabIndex = 3
        Me.gbDataEntrada.TabStop = False
        Me.gbDataEntrada.Text = "Data de Entrada"
        '
        'dtHoraEntrada
        '
        Me.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraEntrada.Location = New System.Drawing.Point(110, 19)
        Me.dtHoraEntrada.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtHoraEntrada.Name = "dtHoraEntrada"
        Me.dtHoraEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtHoraEntrada.ShowUpDown = True
        Me.dtHoraEntrada.Size = New System.Drawing.Size(64, 20)
        Me.dtHoraEntrada.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Apartamento:"
        '
        'txtSinal
        '
        Me.txtSinal.Location = New System.Drawing.Point(391, 280)
        Me.txtSinal.Name = "txtSinal"
        Me.txtSinal.Size = New System.Drawing.Size(77, 20)
        Me.txtSinal.TabIndex = 1
        Me.txtSinal.Text = "0,00"
        Me.txtSinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Sinal: R$"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 428)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(476, 17)
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 72)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'txtObs
        '
        Me.txtObs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObs.Location = New System.Drawing.Point(12, 279)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(326, 116)
        Me.txtObs.TabIndex = 1
        Me.txtObs.Text = "Acompanhantes e Observações:"
        '
        'CadHospedagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(476, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbDadosHospedagem)
        Me.Controls.Add(Me.gbCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadHospedagem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Hospedagem"
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.gbDadosHospedagem.ResumeLayout(False)
        Me.gbDadosHospedagem.PerformLayout()
        Me.gbDataEntrada.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents dtEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents btPesqCliente As System.Windows.Forms.Button
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCpfCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCadNovoCliente As System.Windows.Forms.Button
    Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbDadosHospedagem As System.Windows.Forms.GroupBox
    Friend WithEvents btCadApartamento As System.Windows.Forms.Button
    Friend WithEvents cbApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodHospedagem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSinal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValorBase As TextBox
    Friend WithEvents txtObs As TextBox
End Class
