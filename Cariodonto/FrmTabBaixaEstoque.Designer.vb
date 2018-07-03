<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTabBaixaEstoque
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
        Me.txtCodB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodP = New System.Windows.Forms.TextBox
        Me.txtqtd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpBaixa = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Lblpro = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnbai = New System.Windows.Forms.Button
        Me.btnpro = New System.Windows.Forms.Button
        Me.dgdgrade = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodB
        '
        Me.txtCodB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodB.Location = New System.Drawing.Point(191, 9)
        Me.txtCodB.Name = "txtCodB"
        Me.txtCodB.Size = New System.Drawing.Size(52, 30)
        Me.txtCodB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código da Baixa:"
        '
        'txtCodP
        '
        Me.txtCodP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodP.Location = New System.Drawing.Point(203, 130)
        Me.txtCodP.Name = "txtCodP"
        Me.txtCodP.Size = New System.Drawing.Size(54, 30)
        Me.txtCodP.TabIndex = 0
        '
        'txtqtd
        '
        Me.txtqtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtd.Location = New System.Drawing.Point(242, 187)
        Me.txtqtd.Name = "txtqtd"
        Me.txtqtd.Size = New System.Drawing.Size(51, 30)
        Me.txtqtd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código do Produto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantidade do Produto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data da Baixa:"
        '
        'DtpBaixa
        '
        Me.DtpBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpBaixa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBaixa.Location = New System.Drawing.Point(162, 241)
        Me.DtpBaixa.Name = "DtpBaixa"
        Me.DtpBaixa.Size = New System.Drawing.Size(143, 30)
        Me.DtpBaixa.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.GravarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.AlterarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 32)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(67, 28)
        Me.NovoToolStripMenuItem.Text = "Novo"
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
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Enabled = False
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        Me.AlterarToolStripMenuItem.Visible = False
        '
        'Lblpro
        '
        Me.Lblpro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpro.Location = New System.Drawing.Point(315, 135)
        Me.Lblpro.Name = "Lblpro"
        Me.Lblpro.Size = New System.Drawing.Size(199, 25)
        Me.Lblpro.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnbai)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCodB)
        Me.Panel1.Location = New System.Drawing.Point(21, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 53)
        Me.Panel1.TabIndex = 17
        '
        'btnbai
        '
        Me.btnbai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbai.Location = New System.Drawing.Point(249, 8)
        Me.btnbai.Name = "btnbai"
        Me.btnbai.Size = New System.Drawing.Size(46, 31)
        Me.btnbai.TabIndex = 15
        Me.btnbai.Text = "..."
        Me.btnbai.UseVisualStyleBackColor = True
        '
        'btnpro
        '
        Me.btnpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpro.Location = New System.Drawing.Point(263, 129)
        Me.btnpro.Name = "btnpro"
        Me.btnpro.Size = New System.Drawing.Size(46, 31)
        Me.btnpro.TabIndex = 15
        Me.btnpro.Text = "..."
        Me.btnpro.UseVisualStyleBackColor = True
        '
        'dgdgrade
        '
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.Location = New System.Drawing.Point(375, 187)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(165, 86)
        Me.dgdgrade.TabIndex = 18
        Me.dgdgrade.Visible = False
        '
        'FrmTabBaixaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(608, 323)
        Me.Controls.Add(Me.dgdgrade)
        Me.Controls.Add(Me.btnpro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblpro)
        Me.Controls.Add(Me.DtpBaixa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtqtd)
        Me.Controls.Add(Me.txtCodP)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmTabBaixaEstoque"
        Me.Text = "Baixa de Estoque"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodP As System.Windows.Forms.TextBox
    Friend WithEvents txtqtd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpBaixa As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lblpro As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnbai As System.Windows.Forms.Button
    Friend WithEvents btnpro As System.Windows.Forms.Button
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
End Class
