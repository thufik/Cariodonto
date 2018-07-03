<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTabEntradaProdutos
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
        Me.TxtCodItm = New System.Windows.Forms.TextBox
        Me.TxtcodPro = New System.Windows.Forms.TextBox
        Me.TxtQtd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DtpItm = New System.Windows.Forms.DateTimePicker
        Me.TxtCodFor = New System.Windows.Forms.TextBox
        Me.btnpro = New System.Windows.Forms.Button
        Me.btnfor = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Lblpro = New System.Windows.Forms.Label
        Me.Lblfor = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCodItm
        '
        Me.TxtCodItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodItm.Location = New System.Drawing.Point(188, 12)
        Me.TxtCodItm.Name = "TxtCodItm"
        Me.TxtCodItm.Size = New System.Drawing.Size(46, 30)
        Me.TxtCodItm.TabIndex = 0
        '
        'TxtcodPro
        '
        Me.TxtcodPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtcodPro.Location = New System.Drawing.Point(210, 120)
        Me.TxtcodPro.Name = "TxtcodPro"
        Me.TxtcodPro.Size = New System.Drawing.Size(46, 30)
        Me.TxtcodPro.TabIndex = 0
        '
        'TxtQtd
        '
        Me.TxtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(249, 218)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(45, 30)
        Me.TxtQtd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código da Entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Código do Produto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Código do Fornecedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Data da Entrada:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantidade do Produto:"
        '
        'DtpItm
        '
        Me.DtpItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpItm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpItm.Location = New System.Drawing.Point(465, 218)
        Me.DtpItm.Name = "DtpItm"
        Me.DtpItm.Size = New System.Drawing.Size(139, 30)
        Me.DtpItm.TabIndex = 4
        '
        'TxtCodFor
        '
        Me.TxtCodFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFor.Location = New System.Drawing.Point(242, 171)
        Me.TxtCodFor.Name = "TxtCodFor"
        Me.TxtCodFor.Size = New System.Drawing.Size(50, 30)
        Me.TxtCodFor.TabIndex = 1
        '
        'btnpro
        '
        Me.btnpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpro.Location = New System.Drawing.Point(273, 119)
        Me.btnpro.Name = "btnpro"
        Me.btnpro.Size = New System.Drawing.Size(46, 31)
        Me.btnpro.TabIndex = 14
        Me.btnpro.Text = "..."
        Me.btnpro.UseVisualStyleBackColor = True
        '
        'btnfor
        '
        Me.btnfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfor.Location = New System.Drawing.Point(298, 170)
        Me.btnfor.Name = "btnfor"
        Me.btnfor.Size = New System.Drawing.Size(46, 31)
        Me.btnfor.TabIndex = 15
        Me.btnfor.Text = "..."
        Me.btnfor.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.GravarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.AlterarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 32)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(67, 28)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Enabled = False
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        Me.AlterarToolStripMenuItem.Visible = False
        '
        'GravarToolStripMenuItem
        '
        Me.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem"
        Me.GravarToolStripMenuItem.Size = New System.Drawing.Size(81, 28)
        Me.GravarToolStripMenuItem.Text = "Gravar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(99, 28)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'Lblpro
        '
        Me.Lblpro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpro.Location = New System.Drawing.Point(325, 126)
        Me.Lblpro.Name = "Lblpro"
        Me.Lblpro.Size = New System.Drawing.Size(194, 24)
        Me.Lblpro.TabIndex = 18
        '
        'Lblfor
        '
        Me.Lblfor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfor.Location = New System.Drawing.Point(350, 177)
        Me.Lblfor.Name = "Lblfor"
        Me.Lblfor.Size = New System.Drawing.Size(194, 24)
        Me.Lblfor.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 31)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCodItm)
        Me.Panel1.Location = New System.Drawing.Point(28, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 59)
        Me.Panel1.TabIndex = 21
        '
        'FrmTabEntradaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(660, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblfor)
        Me.Controls.Add(Me.Lblpro)
        Me.Controls.Add(Me.btnfor)
        Me.Controls.Add(Me.btnpro)
        Me.Controls.Add(Me.TxtCodFor)
        Me.Controls.Add(Me.DtpItm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQtd)
        Me.Controls.Add(Me.TxtcodPro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmTabEntradaProdutos"
        Me.Text = "Entrada de Produtos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCodItm As System.Windows.Forms.TextBox
    Friend WithEvents TxtcodPro As System.Windows.Forms.TextBox
    Friend WithEvents TxtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpItm As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCodFor As System.Windows.Forms.TextBox
    Friend WithEvents btnpro As System.Windows.Forms.Button
    Friend WithEvents btnfor As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lblpro As System.Windows.Forms.Label
    Friend WithEvents Lblfor As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
