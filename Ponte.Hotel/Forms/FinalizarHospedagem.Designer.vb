<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizarHospedagem
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.lblSinal = New System.Windows.Forms.Label()
        Me.txtTotalAPagar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCons = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalDiarias = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbDataEntrada = New System.Windows.Forms.GroupBox()
        Me.dtHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtHoraSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtSaida = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblbsds = New System.Windows.Forms.Label()
        Me.lblValorDiaria = New System.Windows.Forms.Label()
        Me.lblNumDiarias = New System.Windows.Forms.Label()
        Me.btFinalizar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbDataEntrada.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Ponte.Hotel.My.Resources.Resources.header_image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 72)
        Me.PictureBox1.TabIndex = 229
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 300)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(373, 17)
        Me.PictureBox2.TabIndex = 230
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
        Me.GroupBox1.Controls.Add(Me.lblSinal)
        Me.GroupBox1.Controls.Add(Me.txtTotalAPagar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCons)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTotalDiarias)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.gbDataEntrada)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 184)
        Me.GroupBox1.TabIndex = 231
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONFIRMAÇÃO"
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Location = New System.Drawing.Point(13, 166)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(56, 13)
        Me.lblDesconto.TabIndex = 236
        Me.lblDesconto.Text = "Desconto:"
        '
        'lblSinal
        '
        Me.lblSinal.AutoSize = True
        Me.lblSinal.Location = New System.Drawing.Point(8, 148)
        Me.lblSinal.Name = "lblSinal"
        Me.lblSinal.Size = New System.Drawing.Size(61, 13)
        Me.lblSinal.TabIndex = 235
        Me.lblSinal.Text = "Sinal Pago:"
        '
        'txtTotalAPagar
        '
        Me.txtTotalAPagar.Enabled = False
        Me.txtTotalAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAPagar.Location = New System.Drawing.Point(292, 154)
        Me.txtTotalAPagar.Name = "txtTotalAPagar"
        Me.txtTotalAPagar.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalAPagar.TabIndex = 232
        Me.txtTotalAPagar.Text = "0,00"
        Me.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(183, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(109, 23)
        Me.Label7.TabIndex = 233
        Me.Label7.Text = "Total a Pagar: R$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCons
        '
        Me.txtCons.Enabled = False
        Me.txtCons.Location = New System.Drawing.Point(292, 99)
        Me.txtCons.Name = "txtCons"
        Me.txtCons.Size = New System.Drawing.Size(56, 20)
        Me.txtCons.TabIndex = 231
        Me.txtCons.Text = "0,00"
        Me.txtCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Total Consumação: R$"
        '
        'txtTotalDiarias
        '
        Me.txtTotalDiarias.Enabled = False
        Me.txtTotalDiarias.Location = New System.Drawing.Point(292, 77)
        Me.txtTotalDiarias.Name = "txtTotalDiarias"
        Me.txtTotalDiarias.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalDiarias.TabIndex = 229
        Me.txtTotalDiarias.Text = "0,00"
        Me.txtTotalDiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(206, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 228
        Me.Label15.Text = "Total Diárias: R$"
        '
        'gbDataEntrada
        '
        Me.gbDataEntrada.Controls.Add(Me.dtHoraEntrada)
        Me.gbDataEntrada.Controls.Add(Me.dtEntrada)
        Me.gbDataEntrada.Location = New System.Drawing.Point(6, 19)
        Me.gbDataEntrada.Name = "gbDataEntrada"
        Me.gbDataEntrada.Size = New System.Drawing.Size(162, 49)
        Me.gbDataEntrada.TabIndex = 65
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.dtHoraSaida)
        Me.GroupBox2.Controls.Add(Me.dtSaida)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 73)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data de Saída:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(5, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 23)
        Me.Button1.TabIndex = 233
        Me.Button1.Text = "Atualzar Data Saída"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtHoraSaida
        '
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
        Me.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSaida.Location = New System.Drawing.Point(5, 19)
        Me.dtSaida.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtSaida.Name = "dtSaida"
        Me.dtSaida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtSaida.Size = New System.Drawing.Size(81, 20)
        Me.dtSaida.TabIndex = 43
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblbsds)
        Me.GroupBox3.Controls.Add(Me.lblValorDiaria)
        Me.GroupBox3.Controls.Add(Me.lblNumDiarias)
        Me.GroupBox3.Location = New System.Drawing.Point(173, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 52)
        Me.GroupBox3.TabIndex = 234
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados das Diárias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 226
        Me.Label11.Text = "Número de Diárias:"
        '
        'lblbsds
        '
        Me.lblbsds.AutoSize = True
        Me.lblbsds.Location = New System.Drawing.Point(38, 16)
        Me.lblbsds.Name = "lblbsds"
        Me.lblbsds.Size = New System.Drawing.Size(81, 13)
        Me.lblbsds.TabIndex = 225
        Me.lblbsds.Text = "Valor Diária: R$"
        '
        'lblValorDiaria
        '
        Me.lblValorDiaria.AutoSize = True
        Me.lblValorDiaria.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblValorDiaria.Location = New System.Drawing.Point(118, 16)
        Me.lblValorDiaria.Name = "lblValorDiaria"
        Me.lblValorDiaria.Size = New System.Drawing.Size(13, 13)
        Me.lblValorDiaria.TabIndex = 223
        Me.lblValorDiaria.Text = "0"
        '
        'lblNumDiarias
        '
        Me.lblNumDiarias.AutoSize = True
        Me.lblNumDiarias.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNumDiarias.Location = New System.Drawing.Point(101, 35)
        Me.lblNumDiarias.Name = "lblNumDiarias"
        Me.lblNumDiarias.Size = New System.Drawing.Size(13, 13)
        Me.lblNumDiarias.TabIndex = 227
        Me.lblNumDiarias.Text = "0"
        '
        'btFinalizar
        '
        Me.btFinalizar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.ForeColor = System.Drawing.SystemColors.Window
        Me.btFinalizar.Location = New System.Drawing.Point(175, 269)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(110, 23)
        Me.btFinalizar.TabIndex = 232
        Me.btFinalizar.Text = "Confirmar"
        Me.btFinalizar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(291, 269)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(76, 23)
        Me.btSair.TabIndex = 66
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'FinalizarHospedagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(373, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FinalizarHospedagem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalizar Hospedagem"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDataEntrada.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btFinalizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbDataEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents dtHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents lblValorDiaria As System.Windows.Forms.Label
    Friend WithEvents lblbsds As System.Windows.Forms.Label
    Friend WithEvents lblNumDiarias As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiarias As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCons As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
    Friend WithEvents lblSinal As System.Windows.Forms.Label
End Class
