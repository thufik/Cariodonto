<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConFornecedor
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnomfor = New System.Windows.Forms.TextBox
        Me.dgdgrade = New System.Windows.Forms.DataGridView
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o Nome do Fornecedor"
        '
        'txtnomfor
        '
        Me.txtnomfor.Location = New System.Drawing.Point(293, 19)
        Me.txtnomfor.Name = "txtnomfor"
        Me.txtnomfor.Size = New System.Drawing.Size(384, 20)
        Me.txtnomfor.TabIndex = 1
        '
        'dgdgrade
        '
        Me.dgdgrade.BackgroundColor = System.Drawing.Color.White
        Me.dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdgrade.Location = New System.Drawing.Point(15, 46)
        Me.dgdgrade.Name = "dgdgrade"
        Me.dgdgrade.Size = New System.Drawing.Size(662, 287)
        Me.dgdgrade.TabIndex = 2
        '
        'FrmConFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 351)
        Me.Controls.Add(Me.dgdgrade)
        Me.Controls.Add(Me.txtnomfor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConFornecedor"
        Me.ShowIcon = False
        Me.Text = "Consulta de Fornecedor"
        CType(Me.dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnomfor As System.Windows.Forms.TextBox
    Friend WithEvents dgdgrade As System.Windows.Forms.DataGridView
End Class
