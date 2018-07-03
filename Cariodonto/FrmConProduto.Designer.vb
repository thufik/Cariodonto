<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConProdutos
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
        Me.txtloc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgdgrade = New System.Windows.Forms.DataGridView
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtloc
        '
        Me.txtloc.Location = New System.Drawing.Point(258, 14)
        Me.txtloc.Name = "txtloc"
        Me.txtloc.Size = New System.Drawing.Size(293, 20)
        Me.txtloc.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(23, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pesquisar o Produto por Código ou por Nome:"
        '
        'dgdgrade
        '
        Me.dgdgrade.BackgroundColor = System.Drawing.Color.White
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.Location = New System.Drawing.Point(23, 43)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(528, 175)
        Me.dgdgrade.TabIndex = 3
        '
        'FrmConProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(573, 230)
        Me.Controls.Add(Me.txtloc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdgrade)
        Me.Name = "FrmConProdutos"
        Me.ShowIcon = False
        Me.Text = "Consulta de Produtos"
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtloc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
End Class
