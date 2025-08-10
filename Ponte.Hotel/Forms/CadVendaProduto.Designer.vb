<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadVendaProduto
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtValorProd = New System.Windows.Forms.TextBox()
        Me.dtAtual = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numQtd = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.grdItens = New System.Windows.Forms.DataGridView()
        Me.btSair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.txtValorProd)
        Me.GroupBox1.Controls.Add(Me.dtAtual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.numQtd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.cbProduto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbTipoProd)
        Me.GroupBox1.Controls.Add(Me.grdItens)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 329)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADICIONAR NOVA VENDA"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(461, 304)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 236
        Me.lblTotal.Text = "Total:"
        '
        'txtValorProd
        '
        Me.txtValorProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorProd.Location = New System.Drawing.Point(323, 41)
        Me.txtValorProd.Name = "txtValorProd"
        Me.txtValorProd.Size = New System.Drawing.Size(51, 20)
        Me.txtValorProd.TabIndex = 235
        Me.txtValorProd.Text = "0,00"
        Me.txtValorProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtAtual
        '
        Me.dtAtual.Enabled = False
        Me.dtAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAtual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAtual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtAtual.Location = New System.Drawing.Point(84, 301)
        Me.dtAtual.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtAtual.Name = "dtAtual"
        Me.dtAtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtAtual.Size = New System.Drawing.Size(131, 20)
        Me.dtAtual.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "*Vendas de:"
        '
        'numQtd
        '
        Me.numQtd.Location = New System.Drawing.Point(380, 41)
        Me.numQtd.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQtd.Name = "numQtd"
        Me.numQtd.Size = New System.Drawing.Size(72, 20)
        Me.numQtd.TabIndex = 226
        Me.numQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numQtd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "Quantidade:"
        '
        'btAdd
        '
        Me.btAdd.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.btAdd.Location = New System.Drawing.Point(458, 40)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 227
        Me.btAdd.Text = "Adicionar"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(131, 41)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(186, 21)
        Me.cbProduto.TabIndex = 225
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 231
        Me.Label9.Text = "Produto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 232
        Me.Label10.Text = "Tipo Produto:"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(6, 41)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(119, 21)
        Me.cbTipoProd.TabIndex = 224
        '
        'grdItens
        '
        Me.grdItens.AllowUserToAddRows = False
        Me.grdItens.AllowUserToDeleteRows = False
        Me.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItens.Location = New System.Drawing.Point(6, 68)
        Me.grdItens.MultiSelect = False
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItens.Size = New System.Drawing.Size(544, 226)
        Me.grdItens.TabIndex = 223
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(489, 414)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 23)
        Me.btSair.TabIndex = 86
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 447)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(581, 17)
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 72)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'btnRelatorios
        '
        Me.btnRelatorios.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRelatorios.Location = New System.Drawing.Point(13, 414)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(114, 23)
        Me.btnRelatorios.TabIndex = 246
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'CadVendaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(581, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRelatorios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadVendaProduto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda Avulsa de Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numQtd As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents cbProduto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents grdItens As System.Windows.Forms.DataGridView
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtAtual As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtValorProd As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRelatorios As Button
End Class
