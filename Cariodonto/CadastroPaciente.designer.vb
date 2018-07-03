<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroPaciente))
        Me.CboUfPac = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCepPac = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCidPac = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CboEstCiv = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEmaPac = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEndPac = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTelPac = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSexPac = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNomPac = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblemail = New System.Windows.Forms.Label
        Me.txtComcli = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNumcli = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.chkativo = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Picfoto = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        CType(Me.Picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboUfPac
        '
        Me.CboUfPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUfPac.FormattingEnabled = True
        Me.CboUfPac.Location = New System.Drawing.Point(325, 234)
        Me.CboUfPac.Name = "CboUfPac"
        Me.CboUfPac.Size = New System.Drawing.Size(70, 32)
        Me.CboUfPac.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(406, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "CEP"
        '
        'txtCepPac
        '
        Me.txtCepPac.Location = New System.Drawing.Point(460, 237)
        Me.txtCepPac.Name = "txtCepPac"
        Me.txtCepPac.Size = New System.Drawing.Size(124, 29)
        Me.txtCepPac.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(251, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 24)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Cidade"
        '
        'txtCidPac
        '
        Me.txtCidPac.Location = New System.Drawing.Point(101, 239)
        Me.txtCidPac.Name = "txtCidPac"
        Me.txtCidPac.Size = New System.Drawing.Size(134, 29)
        Me.txtCidPac.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Estado Civil"
        '
        'CboEstCiv
        '
        Me.CboEstCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstCiv.FormattingEnabled = True
        Me.CboEstCiv.Location = New System.Drawing.Point(128, 106)
        Me.CboEstCiv.Name = "CboEstCiv"
        Me.CboEstCiv.Size = New System.Drawing.Size(121, 32)
        Me.CboEstCiv.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(557, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Paciente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'txtEmaPac
        '
        Me.txtEmaPac.Location = New System.Drawing.Point(90, 278)
        Me.txtEmaPac.Name = "txtEmaPac"
        Me.txtEmaPac.Size = New System.Drawing.Size(412, 29)
        Me.txtEmaPac.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Endereço"
        '
        'txtEndPac
        '
        Me.txtEndPac.Location = New System.Drawing.Point(128, 147)
        Me.txtEndPac.Name = "txtEndPac"
        Me.txtEndPac.Size = New System.Drawing.Size(397, 29)
        Me.txtEndPac.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefone"
        '
        'txtTelPac
        '
        Me.txtTelPac.Location = New System.Drawing.Point(387, 106)
        Me.txtTelPac.Mask = "(00)0000-0000"
        Me.txtTelPac.Name = "txtTelPac"
        Me.txtTelPac.Size = New System.Drawing.Size(133, 29)
        Me.txtTelPac.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sexo"
        '
        'cboSexPac
        '
        Me.cboSexPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexPac.FormattingEnabled = True
        Me.cboSexPac.Location = New System.Drawing.Point(412, 66)
        Me.cboSexPac.Name = "cboSexPac"
        Me.cboSexPac.Size = New System.Drawing.Size(121, 32)
        Me.cboSexPac.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome "
        '
        'txtNomPac
        '
        Me.txtNomPac.Location = New System.Drawing.Point(80, 24)
        Me.txtNomPac.Name = "txtNomPac"
        Me.txtNomPac.Size = New System.Drawing.Size(453, 29)
        Me.txtNomPac.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblemail)
        Me.Panel2.Controls.Add(Me.txtComcli)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtNumcli)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.chkativo)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Picfoto)
        Me.Panel2.Controls.Add(Me.CboUfPac)
        Me.Panel2.Controls.Add(Me.txtNomPac)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCepPac)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cboSexPac)
        Me.Panel2.Controls.Add(Me.txtCidPac)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtTelPac)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtEndPac)
        Me.Panel2.Controls.Add(Me.CboEstCiv)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtEmaPac)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 343)
        Me.Panel2.TabIndex = 1
        '
        'lblemail
        '
        Me.lblemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblemail.Location = New System.Drawing.Point(522, 279)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(150, 26)
        Me.lblemail.TabIndex = 92
        '
        'txtComcli
        '
        Me.txtComcli.Location = New System.Drawing.Point(339, 189)
        Me.txtComcli.Name = "txtComcli"
        Me.txtComcli.Size = New System.Drawing.Size(56, 29)
        Me.txtComcli.TabIndex = 89
        Me.txtComcli.Tag = "x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 24)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Complemento"
        '
        'txtNumcli
        '
        Me.txtNumcli.Location = New System.Drawing.Point(128, 191)
        Me.txtNumcli.Name = "txtNumcli"
        Me.txtNumcli.Size = New System.Drawing.Size(69, 29)
        Me.txtNumcli.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Número"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(211, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 29)
        Me.DateTimePicker1.TabIndex = 87
        '
        'chkativo
        '
        Me.chkativo.AutoSize = True
        Me.chkativo.Location = New System.Drawing.Point(646, 193)
        Me.chkativo.Name = "chkativo"
        Me.chkativo.Size = New System.Drawing.Size(70, 28)
        Me.chkativo.TabIndex = 85
        Me.chkativo.Text = "Ativo"
        Me.chkativo.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(665, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 32)
        Me.Button4.TabIndex = 81
        Me.Button4.Text = "Procurar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(665, 63)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 32)
        Me.Button5.TabIndex = 80
        Me.Button5.Text = "Fotografar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(626, 34)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 12)
        Me.LinkLabel2.TabIndex = 84
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Limpar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(557, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Foto"
        '
        'Picfoto
        '
        Me.Picfoto.BackColor = System.Drawing.Color.Transparent
        Me.Picfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picfoto.Location = New System.Drawing.Point(561, 49)
        Me.Picfoto.Name = "Picfoto"
        Me.Picfoto.Size = New System.Drawing.Size(98, 109)
        Me.Picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picfoto.TabIndex = 82
        Me.Picfoto.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.GravarToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(807, 31)
        Me.MenuStrip1.TabIndex = 30
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
        Me.AlterarToolStripMenuItem.Image = CType(resources.GetObject("AlterarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'GravarToolStripMenuItem
        '
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtcod)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 65)
        Me.Panel1.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(310, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = ". . ."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 35)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Código do Cliente"
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(204, 11)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 29)
        Me.txtcod.TabIndex = 33
        '
        'CadastroPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(807, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CadastroPaciente"
        Me.Text = "Cadastro de Pacientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSexPac As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomPac As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmaPac As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEndPac As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelPac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboEstCiv As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCidPac As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCepPac As System.Windows.Forms.TextBox
    Friend WithEvents CboUfPac As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkativo As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtComcli As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumcli As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
End Class
