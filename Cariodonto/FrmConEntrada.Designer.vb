<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConEntrada
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
        Me.Txtloc = New System.Windows.Forms.TextBox
        Me.dgdgrade = New System.Windows.Forms.DataGridView
        Me.RdbCod = New System.Windows.Forms.RadioButton
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtloc
        '
        Me.Txtloc.Location = New System.Drawing.Point(236, 16)
        Me.Txtloc.Name = "Txtloc"
        Me.Txtloc.Size = New System.Drawing.Size(112, 20)
        Me.Txtloc.TabIndex = 5
        '
        'dgdgrade
        '
        Me.dgdgrade.BackgroundColor = System.Drawing.Color.White
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.GridColor = System.Drawing.Color.White
        Me.dgdgrade.Location = New System.Drawing.Point(12, 42)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(528, 161)
        Me.dgdgrade.TabIndex = 3
        '
        'RdbCod
        '
        Me.RdbCod.AutoSize = True
        Me.RdbCod.Location = New System.Drawing.Point(12, 19)
        Me.RdbCod.Name = "RdbCod"
        Me.RdbCod.Size = New System.Drawing.Size(223, 17)
        Me.RdbCod.TabIndex = 6
        Me.RdbCod.TabStop = True
        Me.RdbCod.Text = "Pesquisar Entrada de Produtos por Nome:"
        Me.RdbCod.UseVisualStyleBackColor = True
        '
        'FrmConEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(562, 215)
        Me.Controls.Add(Me.RdbCod)
        Me.Controls.Add(Me.Txtloc)
        Me.Controls.Add(Me.dgdgrade)
        Me.Name = "FrmConEntrada"
        Me.ShowIcon = False
        Me.Text = "Consulta de Entrada"
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtloc As System.Windows.Forms.TextBox
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
    Friend WithEvents RdbCod As System.Windows.Forms.RadioButton
End Class
