<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadApartamento
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
        Me.grdApartamentos = New System.Windows.Forms.DataGridView()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.txtDescrição = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.gbDetalhesApartamento = New System.Windows.Forms.GroupBox()
        Me.txtCapacidade = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.grdApartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalhesApartamento.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdApartamentos
        '
        Me.grdApartamentos.AllowUserToDeleteRows = False
        Me.grdApartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdApartamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdApartamentos.Location = New System.Drawing.Point(0, 0)
        Me.grdApartamentos.MultiSelect = False
        Me.grdApartamentos.Name = "grdApartamentos"
        Me.grdApartamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdApartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdApartamentos.Size = New System.Drawing.Size(422, 276)
        Me.grdApartamentos.TabIndex = 10
        '
        'btLimpar
        '
        Me.btLimpar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Location = New System.Drawing.Point(12, 391)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(92, 23)
        Me.btLimpar.TabIndex = 17
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'txtDescrição
        '
        Me.txtDescrição.Location = New System.Drawing.Point(92, 23)
        Me.txtDescrição.MaxLength = 9999
        Me.txtDescrição.Name = "txtDescrição"
        Me.txtDescrição.Size = New System.Drawing.Size(300, 20)
        Me.txtDescrição.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Descrição:"
        '
        'btSalvar
        '
        Me.btSalvar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.SystemColors.Window
        Me.btSalvar.Location = New System.Drawing.Point(231, 391)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(92, 23)
        Me.btSalvar.TabIndex = 16
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(329, 391)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 23)
        Me.btSair.TabIndex = 18
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Num. Pessoas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(273, 53)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(119, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.Text = "0,00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbDetalhesApartamento
        '
        Me.gbDetalhesApartamento.Controls.Add(Me.txtCapacidade)
        Me.gbDetalhesApartamento.Controls.Add(Me.Label1)
        Me.gbDetalhesApartamento.Controls.Add(Me.txtValor)
        Me.gbDetalhesApartamento.Controls.Add(Me.Label3)
        Me.gbDetalhesApartamento.Controls.Add(Me.txtDescrição)
        Me.gbDetalhesApartamento.Controls.Add(Me.Label2)
        Me.gbDetalhesApartamento.Location = New System.Drawing.Point(12, 282)
        Me.gbDetalhesApartamento.Name = "gbDetalhesApartamento"
        Me.gbDetalhesApartamento.Size = New System.Drawing.Size(398, 88)
        Me.gbDetalhesApartamento.TabIndex = 24
        Me.gbDetalhesApartamento.TabStop = False
        Me.gbDetalhesApartamento.Text = "INFORMAÇÕES"
        '
        'txtCapacidade
        '
        Me.txtCapacidade.Location = New System.Drawing.Point(92, 52)
        Me.txtCapacidade.MaxLength = 2
        Me.txtCapacidade.Name = "txtCapacidade"
        Me.txtCapacidade.Size = New System.Drawing.Size(119, 20)
        Me.txtCapacidade.TabIndex = 2
        Me.txtCapacidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 422)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(422, 17)
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'cadApartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(422, 439)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbDetalhesApartamento)
        Me.Controls.Add(Me.grdApartamentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cadApartamento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Apartamentos"
        CType(Me.grdApartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalhesApartamento.ResumeLayout(False)
        Me.gbDetalhesApartamento.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdApartamentos As System.Windows.Forms.DataGridView
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents txtDescrição As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents gbDetalhesApartamento As System.Windows.Forms.GroupBox
    Friend WithEvents txtCapacidade As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
