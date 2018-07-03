<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFuncionario
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblemail = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblCurriculo = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.chkativo = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Picfoto = New System.Windows.Forms.PictureBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtCroFun = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtEmaFun = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTelFun = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbbSexFun = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtComFun = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNunFun = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEndFun = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnCurFun = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSalFun = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbbEspFun = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNomFun = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.GravarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Image = Global.Cariodonto.My.Resources.Resources.add_1_
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(80, 27)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Image = Global.Cariodonto.My.Resources.Resources.edit_icon
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'GravarToolStripMenuItem
        '
        Me.GravarToolStripMenuItem.Enabled = False
        Me.GravarToolStripMenuItem.Image = Global.Cariodonto.My.Resources.Resources.disquete
        Me.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem"
        Me.GravarToolStripMenuItem.Size = New System.Drawing.Size(94, 27)
        Me.GravarToolStripMenuItem.Text = "Gravar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = Global.Cariodonto.My.Resources.Resources.Delete_icon
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(110, 27)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblemail)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lblCurriculo)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.Panel2.Controls.Add(Me.chkativo)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Picfoto)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.txtCroFun)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtEmaFun)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtTelFun)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cbbSexFun)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtComFun)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtNunFun)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtEndFun)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnCurFun)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtSalFun)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbbEspFun)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtNomFun)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(11, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 463)
        Me.Panel2.TabIndex = 2
        '
        'lblemail
        '
        Me.lblemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblemail.Location = New System.Drawing.Point(412, 224)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(150, 26)
        Me.lblemail.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(445, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(298, 22)
        Me.Label14.TabIndex = 88
        Me.Label14.Visible = False
        '
        'lblCurriculo
        '
        Me.lblCurriculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurriculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculo.Location = New System.Drawing.Point(445, 334)
        Me.lblCurriculo.Name = "lblCurriculo"
        Me.lblCurriculo.Size = New System.Drawing.Size(205, 22)
        Me.lblCurriculo.TabIndex = 87
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(431, 284)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(180, 24)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Carregar Curriculum"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "HH:mm"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(158, 179)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(76, 29)
        Me.DateTimePicker3.TabIndex = 10
        '
        'chkativo
        '
        Me.chkativo.AutoSize = True
        Me.chkativo.Location = New System.Drawing.Point(134, 423)
        Me.chkativo.Name = "chkativo"
        Me.chkativo.Size = New System.Drawing.Size(70, 28)
        Me.chkativo.TabIndex = 17
        Me.chkativo.Text = "Ativo"
        Me.chkativo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(125, 367)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 32)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Procurar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(125, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Fotografar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(86, 285)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 12)
        Me.LinkLabel2.TabIndex = 79
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Limpar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 273)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Foto"
        '
        'Picfoto
        '
        Me.Picfoto.BackColor = System.Drawing.Color.Transparent
        Me.Picfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picfoto.Location = New System.Drawing.Point(21, 300)
        Me.Picfoto.Name = "Picfoto"
        Me.Picfoto.Size = New System.Drawing.Size(98, 109)
        Me.Picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picfoto.TabIndex = 76
        Me.Picfoto.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(506, 139)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(117, 29)
        Me.DateTimePicker2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(202, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 29)
        Me.DateTimePicker1.TabIndex = 2
        '
        'txtCroFun
        '
        Me.txtCroFun.Location = New System.Drawing.Point(524, 178)
        Me.txtCroFun.Name = "txtCroFun"
        Me.txtCroFun.Size = New System.Drawing.Size(126, 29)
        Me.txtCroFun.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(472, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 24)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "CRO"
        '
        'txtEmaFun
        '
        Me.txtEmaFun.Location = New System.Drawing.Point(80, 221)
        Me.txtEmaFun.Name = "txtEmaFun"
        Me.txtEmaFun.Size = New System.Drawing.Size(312, 29)
        Me.txtEmaFun.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 24)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Email"
        '
        'txtTelFun
        '
        Me.txtTelFun.Location = New System.Drawing.Point(422, 56)
        Me.txtTelFun.Mask = "(99) 0000-0000"
        Me.txtTelFun.Name = "txtTelFun"
        Me.txtTelFun.Size = New System.Drawing.Size(168, 29)
        Me.txtTelFun.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(338, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 24)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Telefone"
        '
        'cbbSexFun
        '
        Me.cbbSexFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSexFun.FormattingEnabled = True
        Me.cbbSexFun.Location = New System.Drawing.Point(531, 16)
        Me.cbbSexFun.Name = "cbbSexFun"
        Me.cbbSexFun.Size = New System.Drawing.Size(150, 32)
        Me.cbbSexFun.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(469, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 24)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Sexo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Data de Admissão"
        '
        'txtComFun
        '
        Me.txtComFun.Location = New System.Drawing.Point(687, 96)
        Me.txtComFun.Name = "txtComFun"
        Me.txtComFun.Size = New System.Drawing.Size(56, 29)
        Me.txtComFun.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(552, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 24)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Complemento"
        '
        'txtNunFun
        '
        Me.txtNunFun.Location = New System.Drawing.Point(476, 98)
        Me.txtNunFun.Name = "txtNunFun"
        Me.txtNunFun.Size = New System.Drawing.Size(69, 29)
        Me.txtNunFun.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Número"
        '
        'txtEndFun
        '
        Me.txtEndFun.Location = New System.Drawing.Point(112, 98)
        Me.txtEndFun.Name = "txtEndFun"
        Me.txtEndFun.Size = New System.Drawing.Size(278, 29)
        Me.txtEndFun.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 24)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Endereço"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Funcionário"
        '
        'btnCurFun
        '
        Me.btnCurFun.Location = New System.Drawing.Point(634, 282)
        Me.btnCurFun.Name = "btnCurFun"
        Me.btnCurFun.Size = New System.Drawing.Size(47, 28)
        Me.btnCurFun.TabIndex = 14
        Me.btnCurFun.Text = "..."
        Me.btnCurFun.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 24)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Data de Nascimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Carga Horária"
        '
        'txtSalFun
        '
        Me.txtSalFun.Location = New System.Drawing.Point(344, 178)
        Me.txtSalFun.Name = "txtSalFun"
        Me.txtSalFun.Size = New System.Drawing.Size(112, 29)
        Me.txtSalFun.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Salário"
        '
        'cbbEspFun
        '
        Me.cbbEspFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbEspFun.FormattingEnabled = True
        Me.cbbEspFun.Location = New System.Drawing.Point(152, 136)
        Me.cbbEspFun.Name = "cbbEspFun"
        Me.cbbEspFun.Size = New System.Drawing.Size(158, 32)
        Me.cbbEspFun.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Especialidade"
        '
        'txtNomFun
        '
        Me.txtNomFun.Location = New System.Drawing.Point(80, 19)
        Me.txtNomFun.Name = "txtNomFun"
        Me.txtNomFun.Size = New System.Drawing.Size(372, 29)
        Me.txtNomFun.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nome"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtCod)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 61)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(358, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = ". . ."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(237, 18)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 29)
        Me.txtCod.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(216, 35)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Código do Funcionário"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'CadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(803, 595)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CadastroFuncionario"
        Me.Text = "Cadastro de Funcionário"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCroFun As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEmaFun As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTelFun As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbSexFun As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEndFun As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCurFun As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSalFun As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbEspFun As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomFun As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComFun As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNunFun As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkativo As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblCurriculo As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
End Class
