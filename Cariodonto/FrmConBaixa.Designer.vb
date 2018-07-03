<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConBaixa
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
        Me.RdbCod = New System.Windows.Forms.RadioButton
        Me.Txtloc = New System.Windows.Forms.TextBox
        Me.dgdgrade = New System.Windows.Forms.DataGridView
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RdbCod
        '
        Me.RdbCod.AutoSize = True
        Me.RdbCod.Location = New System.Drawing.Point(12, 12)
        Me.RdbCod.Name = "RdbCod"
        Me.RdbCod.Size = New System.Drawing.Size(217, 17)
        Me.RdbCod.TabIndex = 21
        Me.RdbCod.TabStop = True
        Me.RdbCod.Text = "Pesquisar Baixa de Produtos por Código:"
        Me.RdbCod.UseVisualStyleBackColor = True
        '
        'Txtloc
        '
        Me.Txtloc.Location = New System.Drawing.Point(230, 9)
        Me.Txtloc.Name = "Txtloc"
        Me.Txtloc.Size = New System.Drawing.Size(112, 20)
        Me.Txtloc.TabIndex = 20
        '
        'dgdgrade
        '
        Me.dgdgrade.BackgroundColor = System.Drawing.Color.White
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.Location = New System.Drawing.Point(12, 35)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(528, 136)
        Me.dgdgrade.TabIndex = 19
        '
        'FrmConBaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(592, 187)
        Me.Controls.Add(Me.RdbCod)
        Me.Controls.Add(Me.Txtloc)
        Me.Controls.Add(Me.dgdgrade)
        Me.Name = "FrmConBaixa"
        Me.ShowIcon = False
        Me.Text = "Consulta de Baixa de Estoque"
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RdbCod As System.Windows.Forms.RadioButton
    Friend WithEvents Txtloc As System.Windows.Forms.TextBox
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
End Class
