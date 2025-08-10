<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostraRelEstoque
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
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckProdutos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStatusProduto = New System.Windows.Forms.ComboBox()
        Me.btGerar = New System.Windows.Forms.Button()
        Me.btPesqProd = New System.Windows.Forms.Button()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox20.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox20.Image = Global.Ponte.Hotel.My.Resources.Resources.endereco
        Me.PictureBox20.Location = New System.Drawing.Point(839, 12)
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
        Me.PictureBox15.Size = New System.Drawing.Size(1136, 126)
        Me.PictureBox15.TabIndex = 112
        Me.PictureBox15.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 592)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1136, 28)
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.AutoSize = True
        Me.lblNumRegistros.Location = New System.Drawing.Point(12, 606)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(58, 13)
        Me.lblNumRegistros.TabIndex = 115
        Me.lblNumRegistros.Text = "Num. Reg."
        Me.lblNumRegistros.Visible = False
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1026, 249)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(98, 23)
        Me.btSair.TabIndex = 117
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'wbRels
        '
        Me.wbRels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbRels.Location = New System.Drawing.Point(0, 278)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1136, 314)
        Me.wbRels.TabIndex = 116
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 143)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckProdutos)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbStatusProduto)
        Me.GroupBox2.Controls.Add(Me.btGerar)
        Me.GroupBox2.Controls.Add(Me.btPesqProd)
        Me.GroupBox2.Controls.Add(Me.btLimpar)
        Me.GroupBox2.Controls.Add(Me.txtNomeProd)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 115)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUTO(S)"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Filtrar:"
        '
        'cbStatusProduto
        '
        Me.cbStatusProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusProduto.FormattingEnabled = True
        Me.cbStatusProduto.Items.AddRange(New Object() {"Todos", "Abaixo do Mínimo", "Sem Estoque"})
        Me.cbStatusProduto.Location = New System.Drawing.Point(229, 84)
        Me.cbStatusProduto.Name = "cbStatusProduto"
        Me.cbStatusProduto.Size = New System.Drawing.Size(132, 21)
        Me.cbStatusProduto.TabIndex = 231
        '
        'btGerar
        '
        Me.btGerar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerar.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerar.Location = New System.Drawing.Point(367, 83)
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
        'MostraRelEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1136, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.wbRels)
        Me.Controls.Add(Me.lblNumRegistros)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MostraRelEstoque"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Estoque"
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumRegistros As System.Windows.Forms.Label
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents wbRels As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btPesqProd As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbStatusProduto As System.Windows.Forms.ComboBox
    Friend WithEvents btGerar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckProdutos As System.Windows.Forms.CheckBox
End Class
