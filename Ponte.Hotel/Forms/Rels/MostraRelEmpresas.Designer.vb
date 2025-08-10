<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostraRelEmpresas
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
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.wbRels = New System.Windows.Forms.WebBrowser()
        Me.btSair = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.btGerar = New System.Windows.Forms.Button()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox20
        '
        Me.PictureBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox20.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_headerprinc
        Me.PictureBox20.Image = Global.Ponte.Hotel.My.Resources.Resources.endereco
        Me.PictureBox20.Location = New System.Drawing.Point(840, 12)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(293, 87)
        Me.PictureBox20.TabIndex = 115
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
        Me.PictureBox15.Size = New System.Drawing.Size(1137, 126)
        Me.PictureBox15.TabIndex = 114
        Me.PictureBox15.TabStop = False
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.AutoSize = True
        Me.lblNumRegistros.Location = New System.Drawing.Point(12, 599)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(58, 13)
        Me.lblNumRegistros.TabIndex = 117
        Me.lblNumRegistros.Text = "Num. Reg."
        Me.lblNumRegistros.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.bg_header
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 593)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1137, 28)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'wbRels
        '
        Me.wbRels.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wbRels.Location = New System.Drawing.Point(0, 241)
        Me.wbRels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbRels.Name = "wbRels"
        Me.wbRels.Size = New System.Drawing.Size(1137, 352)
        Me.wbRels.TabIndex = 118
        Me.wbRels.Url = New System.Uri("", System.UriKind.Relative)
        '
        'btSair
        '
        Me.btSair.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_cinza
        Me.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = Global.Ponte.Hotel.My.Resources.Resources.exit_icon
        Me.btSair.Location = New System.Drawing.Point(1031, 216)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(98, 23)
        Me.btSair.TabIndex = 122
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btGerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 106)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbEmpresa)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 51)
        Me.GroupBox3.TabIndex = 232
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Empresa"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(6, 18)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(191, 21)
        Me.cbEmpresa.TabIndex = 6
        '
        'btGerar
        '
        Me.btGerar.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.btn_azul
        Me.btGerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerar.ForeColor = System.Drawing.SystemColors.Window
        Me.btGerar.Location = New System.Drawing.Point(76, 74)
        Me.btGerar.Name = "btGerar"
        Me.btGerar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btGerar.Size = New System.Drawing.Size(134, 23)
        Me.btGerar.TabIndex = 231
        Me.btGerar.Text = "Gerar Relatório"
        Me.btGerar.UseVisualStyleBackColor = True
        '
        'MostraRelEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ponte.Hotel.My.Resources.Resources.white_texture
        Me.ClientSize = New System.Drawing.Size(1137, 621)
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
        Me.Name = "MostraRelEmpresas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Empresas"
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumRegistros As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents wbRels As System.Windows.Forms.WebBrowser
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btGerar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
End Class
