<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConReceitas
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
        Me.txtloc.Location = New System.Drawing.Point(198, 15)
        Me.txtloc.Name = "txtloc"
        Me.txtloc.Size = New System.Drawing.Size(85, 20)
        Me.txtloc.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pesquisar Receita por Codigo:"
        '
        'dgdgrade
        '
        Me.dgdgrade.BackgroundColor = System.Drawing.Color.White
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.Location = New System.Drawing.Point(12, 41)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(528, 193)
        Me.dgdgrade.TabIndex = 6
        '
        'FrmConReceitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(561, 266)
        Me.Controls.Add(Me.txtloc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdgrade)
        Me.Name = "FrmConReceitas"
        Me.ShowIcon = False
        Me.Text = "Consulta de Receita"
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtloc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
End Class
