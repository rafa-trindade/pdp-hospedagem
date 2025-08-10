<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadReserva
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
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.btnCadNovoCliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btPesqCliente = New System.Windows.Forms.Button()
        Me.txtCpfCliente = New System.Windows.Forms.TextBox()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDadosHospedagem = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodHospedagem = New System.Windows.Forms.TextBox()
        Me.numQtdPessoas = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbCliente.SuspendLayout()
        Me.gbDadosHospedagem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numQtdPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDataEntrada.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(8, 250)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(88, 23)
        Me.btLimpar.TabIndex = 86
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(410, 250)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 23)
        Me.btSair.TabIndex = 85
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
        Me.btSalvar.Location = New System.Drawing.Point(312, 250)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(92, 23)
        Me.btSalvar.TabIndex = 84
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.btnCadNovoCliente)
        Me.gbCliente.Controls.Add(Me.Label4)
        Me.gbCliente.Controls.Add(Me.btPesqCliente)
        Me.gbCliente.Controls.Add(Me.txtCpfCliente)
        Me.gbCliente.Controls.Add(Me.txtNomeCliente)
        Me.gbCliente.Controls.Add(Me.Label3)
        Me.gbCliente.Location = New System.Drawing.Point(7, 78)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(483, 81)
        Me.gbCliente.TabIndex = 87
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "CLIENTE"
        '
        'btnCadNovoCliente
        '
        Me.btnCadNovoCliente.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnCadNovoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCadNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadNovoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadNovoCliente.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCadNovoCliente.Location = New System.Drawing.Point(323, 20)
        Me.btnCadNovoCliente.Name = "btnCadNovoCliente"
        Me.btnCadNovoCliente.Size = New System.Drawing.Size(150, 23)
        Me.btnCadNovoCliente.TabIndex = 50
        Me.btnCadNovoCliente.Text = "Pré-Cadastrar Cliente"
        Me.btnCadNovoCliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 24)
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
        Me.btPesqCliente.Location = New System.Drawing.Point(229, 20)
        Me.btPesqCliente.Name = "btPesqCliente"
        Me.btPesqCliente.Size = New System.Drawing.Size(88, 23)
        Me.btPesqCliente.TabIndex = 49
        Me.btPesqCliente.Text = "Pesquisar"
        Me.btPesqCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqCliente.UseVisualStyleBackColor = True
        '
        'txtCpfCliente
        '
        Me.txtCpfCliente.Location = New System.Drawing.Point(56, 21)
        Me.txtCpfCliente.MaxLength = 11
        Me.txtCpfCliente.Name = "txtCpfCliente"
        Me.txtCpfCliente.Size = New System.Drawing.Size(167, 20)
        Me.txtCpfCliente.TabIndex = 1
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(56, 49)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(417, 20)
        Me.txtNomeCliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nome:"
        '
        'gbDadosHospedagem
        '
        Me.gbDadosHospedagem.Controls.Add(Me.GroupBox1)
        Me.gbDadosHospedagem.Controls.Add(Me.numQtdPessoas)
        Me.gbDadosHospedagem.Controls.Add(Me.Label2)
        Me.gbDadosHospedagem.Controls.Add(Me.gbDataEntrada)
        Me.gbDadosHospedagem.Location = New System.Drawing.Point(7, 165)
        Me.gbDadosHospedagem.Name = "gbDadosHospedagem"
        Me.gbDadosHospedagem.Size = New System.Drawing.Size(483, 71)
        Me.gbDadosHospedagem.TabIndex = 88
        Me.gbDadosHospedagem.TabStop = False
        Me.gbDadosHospedagem.Text = "DADOS DA HOSPEDAGEM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodHospedagem)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 46)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cód. Reserva"
        '
        'txtCodHospedagem
        '
        Me.txtCodHospedagem.Enabled = False
        Me.txtCodHospedagem.Location = New System.Drawing.Point(6, 19)
        Me.txtCodHospedagem.Name = "txtCodHospedagem"
        Me.txtCodHospedagem.Size = New System.Drawing.Size(93, 20)
        Me.txtCodHospedagem.TabIndex = 5
        '
        'numQtdPessoas
        '
        Me.numQtdPessoas.Location = New System.Drawing.Point(202, 38)
        Me.numQtdPessoas.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtdPessoas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQtdPessoas.Name = "numQtdPessoas"
        Me.numQtdPessoas.Size = New System.Drawing.Size(75, 20)
        Me.numQtdPessoas.TabIndex = 52
        Me.numQtdPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numQtdPessoas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Núm. Pessoas:"
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtHoraEntrada)
        Me.gbDataEntrada.Controls.Add(Me.dtEntrada)
        Me.gbDataEntrada.Location = New System.Drawing.Point(6, 19)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(182, 46)
        Me.gbDataEntrada.TabIndex = 49
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
        Me.dtHoraEntrada.TabIndex = 4
        '
        'dtEntrada
        '
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(9, 19)
        Me.dtEntrada.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(95, 20)
        Me.dtEntrada.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(499, 17)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 72)
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'CadReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(499, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.gbDadosHospedagem)
        Me.Controls.Add(Me.gbCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadReserva"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Reserva"
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.gbDadosHospedagem.ResumeLayout(False)
        Me.gbDadosHospedagem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numQtdPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDataEntrada.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents gbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnCadNovoCliente As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btPesqCliente As System.Windows.Forms.Button
    Friend WithEvents txtCpfCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbDadosHospedagem As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodHospedagem As System.Windows.Forms.TextBox
    Friend WithEvents gbDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numQtdPessoas As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
