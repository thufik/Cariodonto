<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomfun = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hora_inicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hora_final = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CboFun = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.nomfun, Me.data, Me.hora_inicial, Me.hora_final})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(597, 314)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.Visible = False
        '
        'Código
        '
        Me.Código.DataPropertyName = "codfun"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Width = 50
        '
        'nomfun
        '
        Me.nomfun.DataPropertyName = "nomfun"
        Me.nomfun.HeaderText = "Nome"
        Me.nomfun.Name = "nomfun"
        Me.nomfun.ReadOnly = True
        '
        'data
        '
        Me.data.DataPropertyName = "data"
        Me.data.HeaderText = "Data"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'hora_inicial
        '
        Me.hora_inicial.DataPropertyName = "horaini"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.hora_inicial.DefaultCellStyle = DataGridViewCellStyle1
        Me.hora_inicial.HeaderText = "Hora_inicial"
        Me.hora_inicial.Name = "hora_inicial"
        Me.hora_inicial.ReadOnly = True
        '
        'hora_final
        '
        Me.hora_final.DataPropertyName = "horafim"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.hora_final.DefaultCellStyle = DataGridViewCellStyle2
        Me.hora_final.HeaderText = "Hora_final"
        Me.hora_final.Name = "hora_final"
        Me.hora_final.ReadOnly = True
        '
        'CboFun
        '
        Me.CboFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFun.FormattingEnabled = True
        Me.CboFun.Location = New System.Drawing.Point(12, 36)
        Me.CboFun.Name = "CboFun"
        Me.CboFun.Size = New System.Drawing.Size(146, 21)
        Me.CboFun.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(309, 37)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(185, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data Inicial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(309, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data Final"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CboFun)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmControle"
        Me.ShowIcon = False
        Me.Text = "Controle de Acesso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CboFun As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_inicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_final As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
