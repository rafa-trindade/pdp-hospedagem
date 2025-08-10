<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadVale
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.btCadFun = New System.Windows.Forms.Button()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.gbVales = New System.Windows.Forms.GroupBox()
        Me.grdVales = New System.Windows.Forms.DataGridView()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.gbValor = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorVale = New System.Windows.Forms.TextBox()
        Me.gbDataVale = New System.Windows.Forms.GroupBox()
        Me.dtVale = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalVales = New System.Windows.Forms.TextBox()
        Me.lblTotalVale = New System.Windows.Forms.Label()
        Me.lblTotalEntrada = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbVales.SuspendLayout()
        CType(Me.grdVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbValor.SuspendLayout()
        Me.gbDataVale.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 72)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 557)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(344, 17)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFuncionario)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 47)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FUNCIONÁRIO"
        '
        'cbFuncionario
        '
        Me.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(6, 19)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(307, 21)
        Me.cbFuncionario.TabIndex = 28
        '
        'btCadFun
        '
        Me.btCadFun.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btCadFun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCadFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCadFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadFun.ForeColor = System.Drawing.SystemColors.Window
        Me.btCadFun.Location = New System.Drawing.Point(183, 83)
        Me.btCadFun.Name = "btCadFun"
        Me.btCadFun.Size = New System.Drawing.Size(150, 23)
        Me.btCadFun.TabIndex = 90
        Me.btCadFun.Text = "Gerenciar Funcionários"
        Me.btCadFun.UseVisualStyleBackColor = True
        '
        'btnRelatorios
        '
        Me.btnRelatorios.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRelatorios.Location = New System.Drawing.Point(16, 528)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(114, 23)
        Me.btnRelatorios.TabIndex = 247
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMes.Location = New System.Drawing.Point(13, 505)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(89, 13)
        Me.lblMes.TabIndex = 246
        Me.lblMes.Text = "Vales do Mês de:"
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(246, 528)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(87, 23)
        Me.btSair.TabIndex = 248
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'gbVales
        '
        Me.gbVales.Controls.Add(Me.grdVales)
        Me.gbVales.Controls.Add(Me.btAdd)
        Me.gbVales.Controls.Add(Me.gbValor)
        Me.gbVales.Controls.Add(Me.gbDataVale)
        Me.gbVales.Controls.Add(Me.txtTotalVales)
        Me.gbVales.Controls.Add(Me.lblTotalVale)
        Me.gbVales.Controls.Add(Me.lblTotalEntrada)
        Me.gbVales.Controls.Add(Me.PictureBox3)
        Me.gbVales.Location = New System.Drawing.Point(13, 165)
        Me.gbVales.Name = "gbVales"
        Me.gbVales.Size = New System.Drawing.Size(320, 337)
        Me.gbVales.TabIndex = 249
        Me.gbVales.TabStop = False
        Me.gbVales.Text = "VALES"
        '
        'grdVales
        '
        Me.grdVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVales.Location = New System.Drawing.Point(0, 65)
        Me.grdVales.Name = "grdVales"
        Me.grdVales.Size = New System.Drawing.Size(320, 247)
        Me.grdVales.TabIndex = 257
        '
        'btAdd
        '
        Me.btAdd.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.btAdd.Location = New System.Drawing.Point(199, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(114, 23)
        Me.btAdd.TabIndex = 256
        Me.btAdd.Text = "Adicionar"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'gbValor
        '
        Me.gbValor.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.gbValor.Controls.Add(Me.Label1)
        Me.gbValor.Controls.Add(Me.txtValorVale)
        Me.gbValor.Location = New System.Drawing.Point(-2, 23)
        Me.gbValor.Name = "gbValor"
        Me.gbValor.Size = New System.Drawing.Size(95, 46)
        Me.gbValor.TabIndex = 255
        Me.gbValor.TabStop = False
        Me.gbValor.Text = "Valor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 253
        Me.Label1.Text = "R$"
        '
        'txtValorVale
        '
        Me.txtValorVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorVale.Location = New System.Drawing.Point(24, 14)
        Me.txtValorVale.Name = "txtValorVale"
        Me.txtValorVale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValorVale.Size = New System.Drawing.Size(65, 21)
        Me.txtValorVale.TabIndex = 252
        Me.txtValorVale.Text = "0,00"
        Me.txtValorVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbDataVale
        '
        Me.gbDataVale.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.gbDataVale.Controls.Add(Me.dtVale)
        Me.gbDataVale.Location = New System.Drawing.Point(85, 23)
        Me.gbDataVale.Name = "gbDataVale"
        Me.gbDataVale.Size = New System.Drawing.Size(111, 46)
        Me.gbDataVale.TabIndex = 254
        Me.gbDataVale.TabStop = False
        Me.gbDataVale.Text = "Data:"
        '
        'dtVale
        '
        Me.dtVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtVale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVale.Location = New System.Drawing.Point(10, 14)
        Me.dtVale.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtVale.Name = "dtVale"
        Me.dtVale.Size = New System.Drawing.Size(95, 21)
        Me.dtVale.TabIndex = 3
        '
        'txtTotalVales
        '
        Me.txtTotalVales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVales.Location = New System.Drawing.Point(272, 318)
        Me.txtTotalVales.MaxLength = 10
        Me.txtTotalVales.Name = "txtTotalVales"
        Me.txtTotalVales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalVales.Size = New System.Drawing.Size(48, 13)
        Me.txtTotalVales.TabIndex = 251
        Me.txtTotalVales.Text = "0,00"
        '
        'lblTotalVale
        '
        Me.lblTotalVale.AutoSize = True
        Me.lblTotalVale.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVale.Location = New System.Drawing.Point(222, 318)
        Me.lblTotalVale.Name = "lblTotalVale"
        Me.lblTotalVale.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalVale.TabIndex = 250
        Me.lblTotalVale.Text = "Total: R$"
        Me.lblTotalVale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox3.Location = New System.Drawing.Point(-13, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(370, 323)
        Me.PictureBox3.TabIndex = 83
        Me.PictureBox3.TabStop = False
        '
        'CadVale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(344, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbVales)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btnRelatorios)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.btCadFun)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadVale"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vales de Funcionários"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbVales.ResumeLayout(False)
        Me.gbVales.PerformLayout()
        CType(Me.grdVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbValor.ResumeLayout(False)
        Me.gbValor.PerformLayout()
        Me.gbDataVale.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents btCadFun As Button
    Friend WithEvents btnRelatorios As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents btSair As Button
    Friend WithEvents gbVales As GroupBox
    Friend WithEvents lblTotalEntrada As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblTotalVale As Label
    Friend WithEvents txtTotalVales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorVale As TextBox
    Friend WithEvents gbValor As GroupBox
    Friend WithEvents gbDataVale As GroupBox
    Friend WithEvents dtVale As DateTimePicker
    Friend WithEvents btAdd As Button
    Friend WithEvents grdVales As DataGridView
End Class
