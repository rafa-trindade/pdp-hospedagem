<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostraRelMovimentacao
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
        Me.gbPeriodo = New System.Windows.Forms.GroupBox()
        Me.cbTipoSaida = New System.Windows.Forms.ComboBox()
        Me.btGerarSaida = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFimSaida = New System.Windows.Forms.DateTimePicker()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtInicioSaida = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbSaida = New System.Windows.Forms.RadioButton()
        Me.gbResumo = New System.Windows.Forms.GroupBox()
        Me.lblTotalBruto = New System.Windows.Forms.Label()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.lbltotbruto = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPeriodo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        Me.gbResumo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox20.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox20.Image = Global.Ponte.Hotel.My.Resources.Resources.endereco
        Me.PictureBox20.Location = New System.Drawing.Point(821, 12)
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
        Me.PictureBox15.Size = New System.Drawing.Size(1126, 126)
        Me.PictureBox15.TabIndex = 112
        Me.PictureBox15.TabStop = False
        '
        'gbPeriodo
        '
        Me.gbPeriodo.Controls.Add(Me.cbTipoSaida)
        Me.gbPeriodo.Controls.Add(Me.btGerarSaida)
        Me.gbPeriodo.Controls.Add(Me.GroupBox1)
        Me.gbPeriodo.Controls.Add(Me.gbDataEntrada)
        Me.gbPeriodo.Location = New System.Drawing.Point(123, 143)
        Me.gbPeriodo.Name = "gbPeriodo"
        Me.gbPeriodo.Size = New System.Drawing.Size(387, 99)
        Me.gbPeriodo.TabIndex = 117
        Me.gbPeriodo.TabStop = False
        Me.gbPeriodo.Text = "CAIXA (SAÍDA)"
        '
        'cbTipoSaida
        '
        Me.cbTipoSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoSaida.FormattingEnabled = True
        Me.cbTipoSaida.Items.AddRange(New Object() {"Todos", "Café da Manhã", "Despesa Pessoal", "Despesa Fixa", "Diária", "Estoque", "Gás", "Instalação/Manutenção", "Material de Escritório", "Material de Limpeza", "Retirada", "Utensilio Doméstico", "Vale", "--Outro"})
        Me.cbTipoSaida.Location = New System.Drawing.Point(6, 72)
        Me.cbTipoSaida.Name = "cbTipoSaida"
        Me.cbTipoSaida.Size = New System.Drawing.Size(245, 21)
        Me.cbTipoSaida.TabIndex = 70
        '
        'btGerarSaida
        '
        Me.btGerarSaida.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerarSaida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btGerarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarSaida.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerarSaida.Location = New System.Drawing.Point(259, 70)
        Me.btGerarSaida.Name = "btGerarSaida"
        Me.btGerarSaida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerarSaida.Size = New System.Drawing.Size(119, 23)
        Me.btGerarSaida.TabIndex = 66
        Me.btGerarSaida.Text = "Gerar Relatório"
        Me.btGerarSaida.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFimSaida)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 49)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Fim:"
        '
        'dtFimSaida
        '
        Me.dtFimSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFimSaida.Location = New System.Drawing.Point(5, 19)
        Me.dtFimSaida.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtFimSaida.Name = "dtFimSaida"
        Me.dtFimSaida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtFimSaida.Size = New System.Drawing.Size(108, 20)
        Me.dtFimSaida.TabIndex = 43
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtInicioSaida)
        Me.gbDataEntrada.Location = New System.Drawing.Point(6, 19)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(119, 49)
        Me.gbDataEntrada.TabIndex = 64
        Me.gbDataEntrada.TabStop = False
        Me.gbDataEntrada.Text = "Data Início:"
        '
        'dtInicioSaida
        '
        Me.dtInicioSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioSaida.Location = New System.Drawing.Point(5, 19)
        Me.dtInicioSaida.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtInicioSaida.Name = "dtInicioSaida"
        Me.dtInicioSaida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtInicioSaida.Size = New System.Drawing.Size(108, 20)
        Me.dtInicioSaida.TabIndex = 43
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 189)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton1.TabIndex = 116
        Me.RadioButton1.Text = "Caixa (Entrada)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbSaida
        '
        Me.rbSaida.AutoSize = True
        Me.rbSaida.Location = New System.Drawing.Point(10, 167)
        Me.rbSaida.Name = "rbSaida"
        Me.rbSaida.Size = New System.Drawing.Size(89, 17)
        Me.rbSaida.TabIndex = 115
        Me.rbSaida.Text = "Caixa (Saída)"
        Me.rbSaida.UseVisualStyleBackColor = True
        '
        'gbResumo
        '
        Me.gbResumo.Controls.Add(Me.lblTotalBruto)
        Me.gbResumo.Controls.Add(Me.lblNumRegistros)
        Me.gbResumo.Controls.Add(Me.lbltotbruto)
        Me.gbResumo.Location = New System.Drawing.Point(516, 169)
        Me.gbResumo.Name = "gbResumo"
        Me.gbResumo.Size = New System.Drawing.Size(186, 74)
        Me.gbResumo.TabIndex = 118
        Me.gbResumo.TabStop = False
        Me.gbResumo.Text = "RESUMO"
        Me.gbResumo.Visible = False
        '
        'lblTotalBruto
        '
        Me.lblTotalBruto.AutoSize = True
        Me.lblTotalBruto.Location = New System.Drawing.Point(36, 46)
        Me.lblTotalBruto.Name = "lblTotalBruto"
        Me.lblTotalBruto.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalBruto.TabIndex = 91
        Me.lblTotalBruto.Text = "R$"
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.AutoSize = True
        Me.lblNumRegistros.Location = New System.Drawing.Point(6, 22)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(61, 13)
        Me.lblNumRegistros.TabIndex = 90
        Me.lblNumRegistros.Text = "Num. Reg.:"
        Me.lblNumRegistros.Visible = False
        '
        'lbltotbruto
        '
        Me.lbltotbruto.AutoSize = True
        Me.lbltotbruto.Location = New System.Drawing.Point(6, 46)
        Me.lbltotbruto.Name = "lbltotbruto"
        Me.lbltotbruto.Size = New System.Drawing.Size(34, 13)
        Me.lbltotbruto.TabIndex = 92
        Me.lbltotbruto.Text = "Total:"
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1016, 213)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(98, 23)
        Me.btSair.TabIndex = 119
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(10, 145)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton2.TabIndex = 120
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Balanço Geral"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 556)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1126, 28)
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'wbRels
        '
        Me.wbRels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbRels.Location = New System.Drawing.Point(0, 248)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1126, 308)
        Me.wbRels.TabIndex = 122
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'MostraRelMovimentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1126, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.wbRels)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.gbResumo)
        Me.Controls.Add(Me.gbPeriodo)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.rbSaida)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MostraRelMovimentacao"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Movimentação Financeira"
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPeriodo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDataEntrada.ResumeLayout(False)
        Me.gbResumo.ResumeLayout(False)
        Me.gbResumo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents gbPeriodo As GroupBox
    Friend WithEvents cbTipoSaida As ComboBox
    Friend WithEvents btGerarSaida As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFimSaida As DateTimePicker
    Friend WithEvents gbDataEntrada As GroupBox
    Friend WithEvents dtInicioSaida As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbSaida As RadioButton
    Friend WithEvents gbResumo As GroupBox
    Friend WithEvents lblTotalBruto As Label
    Friend WithEvents lblNumRegistros As Label
    Friend WithEvents lbltotbruto As Label
    Friend WithEvents btSair As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents wbRels As WebBrowser
End Class
