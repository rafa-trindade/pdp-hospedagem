<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MostraRelVendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbTipoVenda = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.ckProdutos = New System.Windows.Forms.CheckBox()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.btGerar = New System.Windows.Forms.Button()
        Me.btPesqProd = New System.Windows.Forms.Button()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalLucro = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalVenda = New System.Windows.Forms.Label()
        Me.gbResumo = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox20.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox20.Image = Global.Ponte.Hotel.My.Resources.Resources.endereco
        Me.PictureBox20.Location = New System.Drawing.Point(830, 12)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(293, 87)
        Me.PictureBox20.TabIndex = 113
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
        Me.PictureBox15.Size = New System.Drawing.Size(1135, 126)
        Me.PictureBox15.TabIndex = 112
        Me.PictureBox15.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 156)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTROS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.ckProdutos)
        Me.GroupBox1.Controls.Add(Me.gbDataEntrada)
        Me.GroupBox1.Controls.Add(Me.btGerar)
        Me.GroupBox1.Controls.Add(Me.btPesqProd)
        Me.GroupBox1.Controls.Add(Me.btLimpar)
        Me.GroupBox1.Controls.Add(Me.txtNomeProd)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUTO(S)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbTipoVenda)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(107, 49)
        Me.GroupBox4.TabIndex = 234
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo Venda"
        '
        'cbTipoVenda
        '
        Me.cbTipoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVenda.FormattingEnabled = True
        Me.cbTipoVenda.Items.AddRange(New Object() {"Todas", "Venda Avulsa", "Consumação"})
        Me.cbTipoVenda.Location = New System.Drawing.Point(6, 18)
        Me.cbTipoVenda.Name = "cbTipoVenda"
        Me.cbTipoVenda.Size = New System.Drawing.Size(95, 21)
        Me.cbTipoVenda.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtFim)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 49)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Fim:"
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
        'ckProdutos
        '
        Me.ckProdutos.AutoSize = True
        Me.ckProdutos.Location = New System.Drawing.Point(144, 23)
        Me.ckProdutos.Name = "ckProdutos"
        Me.ckProdutos.Size = New System.Drawing.Size(63, 17)
        Me.ckProdutos.TabIndex = 233
        Me.ckProdutos.Text = "Produto"
        Me.ckProdutos.UseVisualStyleBackColor = True
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtInicio)
        Me.gbDataEntrada.Location = New System.Drawing.Point(120, 74)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(119, 49)
        Me.gbDataEntrada.TabIndex = 66
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
        'btGerar
        '
        Me.btGerar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerar.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerar.Location = New System.Drawing.Point(367, 90)
        Me.btGerar.Name = "btGerar"
        Me.btGerar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerar.Size = New System.Drawing.Size(134, 23)
        Me.btGerar.TabIndex = 230
        Me.btGerar.Text = "Gerar Relatório"
        Me.btGerar.UseVisualStyleBackColor = True
        '
        'btPesqProd
        '
        Me.btPesqProd.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btPesqProd.Enabled = False
        Me.btPesqProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btPesqProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesqProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesqProd.Image = Global.Ponte.Hotel.My.Resources.Resources.search_folder
        Me.btPesqProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesqProd.Location = New System.Drawing.Point(319, 46)
        Me.btPesqProd.Name = "btPesqProd"
        Me.btPesqProd.Size = New System.Drawing.Size(88, 23)
        Me.btPesqProd.TabIndex = 225
        Me.btPesqProd.Text = "Pesquisar"
        Me.btPesqProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesqProd.UseVisualStyleBackColor = True
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.Enabled = False
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(413, 46)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(88, 23)
        Me.btLimpar.TabIndex = 226
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Enabled = False
        Me.txtNomeProd.Location = New System.Drawing.Point(53, 48)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(260, 20)
        Me.txtNomeProd.TabIndex = 224
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(53, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(85, 20)
        Me.txtCodigo.TabIndex = 223
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 227
        Me.Label8.Text = "Nome:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 228
        Me.Label9.Text = "Código:"
        '
        'wbRels
        '
        Me.wbRels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbRels.Location = New System.Drawing.Point(0, 294)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1135, 294)
        Me.wbRels.TabIndex = 116
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 588)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1135, 23)
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1030, 265)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(98, 23)
        Me.btSair.TabIndex = 117
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.AutoSize = True
        Me.lblNumRegistros.Location = New System.Drawing.Point(6, 20)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(58, 13)
        Me.lblNumRegistros.TabIndex = 122
        Me.lblNumRegistros.Text = "Num. Reg."
        Me.lblNumRegistros.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Total Lucro:"
        Me.Label1.Visible = False
        '
        'lblTotalLucro
        '
        Me.lblTotalLucro.AutoSize = True
        Me.lblTotalLucro.Location = New System.Drawing.Point(72, 61)
        Me.lblTotalLucro.Name = "lblTotalLucro"
        Me.lblTotalLucro.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalLucro.TabIndex = 124
        Me.lblTotalLucro.Text = "R$"
        Me.lblTotalLucro.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Total Venda:"
        Me.Label2.Visible = False
        '
        'lblTotalVenda
        '
        Me.lblTotalVenda.AutoSize = True
        Me.lblTotalVenda.Location = New System.Drawing.Point(72, 40)
        Me.lblTotalVenda.Name = "lblTotalVenda"
        Me.lblTotalVenda.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalVenda.TabIndex = 126
        Me.lblTotalVenda.Text = "R$"
        Me.lblTotalVenda.Visible = False
        '
        'gbResumo
        '
        Me.gbResumo.Controls.Add(Me.lblNumRegistros)
        Me.gbResumo.Controls.Add(Me.Label2)
        Me.gbResumo.Controls.Add(Me.lblTotalLucro)
        Me.gbResumo.Controls.Add(Me.lblTotalVenda)
        Me.gbResumo.Controls.Add(Me.Label1)
        Me.gbResumo.Location = New System.Drawing.Point(540, 151)
        Me.gbResumo.Name = "gbResumo"
        Me.gbResumo.Size = New System.Drawing.Size(200, 137)
        Me.gbResumo.TabIndex = 128
        Me.gbResumo.TabStop = False
        Me.gbResumo.Text = "RESUMO"
        Me.gbResumo.Visible = False
        '
        'MostraRelVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1135, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbResumo)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.wbRels)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MostraRelVendas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.gbDataEntrada.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResumo.ResumeLayout(False)
        Me.gbResumo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents wbRels As WebBrowser
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btSair As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckProdutos As CheckBox
    Friend WithEvents btGerar As Button
    Friend WithEvents btPesqProd As Button
    Friend WithEvents btLimpar As Button
    Friend WithEvents txtNomeProd As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtFim As DateTimePicker
    Friend WithEvents gbDataEntrada As GroupBox
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents lblNumRegistros As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalLucro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalVenda As Label
    Friend WithEvents gbResumo As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbTipoVenda As ComboBox
End Class
