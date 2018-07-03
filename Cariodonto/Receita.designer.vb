<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receita
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCli = New System.Windows.Forms.Label
        Me.BtnRec = New System.Windows.Forms.Button
        Me.CboCon = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpDat = New System.Windows.Forms.DateTimePicker
        Me.TxtCli = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnCli = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtRec = New System.Windows.Forms.TextBox
        Me.TxtVal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHist = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GravarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LblCli)
        Me.Panel1.Controls.Add(Me.BtnRec)
        Me.Panel1.Controls.Add(Me.CboCon)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DtpDat)
        Me.Panel1.Controls.Add(Me.TxtCli)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnCli)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtRec)
        Me.Panel1.Controls.Add(Me.TxtVal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtHist)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 303)
        Me.Panel1.TabIndex = 0
        '
        'LblCli
        '
        Me.LblCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCli.Location = New System.Drawing.Point(281, 58)
        Me.LblCli.Name = "LblCli"
        Me.LblCli.Size = New System.Drawing.Size(159, 29)
        Me.LblCli.TabIndex = 40
        '
        'BtnRec
        '
        Me.BtnRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRec.Location = New System.Drawing.Point(267, 15)
        Me.BtnRec.Name = "BtnRec"
        Me.BtnRec.Size = New System.Drawing.Size(44, 29)
        Me.BtnRec.TabIndex = 39
        Me.BtnRec.Text = "..."
        Me.BtnRec.UseVisualStyleBackColor = True
        Me.BtnRec.Visible = False
        '
        'CboCon
        '
        Me.CboCon.FormattingEnabled = True
        Me.CboCon.Location = New System.Drawing.Point(109, 138)
        Me.CboCon.Name = "CboCon"
        Me.CboCon.Size = New System.Drawing.Size(202, 32)
        Me.CboCon.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Conta:"
        '
        'DtpDat
        '
        Me.DtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDat.Location = New System.Drawing.Point(193, 103)
        Me.DtpDat.Name = "DtpDat"
        Me.DtpDat.Size = New System.Drawing.Size(116, 29)
        Me.DtpDat.TabIndex = 36
        '
        'TxtCli
        '
        Me.TxtCli.Location = New System.Drawing.Point(177, 58)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(48, 29)
        Me.TxtCli.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 24)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Código da Receita:"
        Me.Label7.Visible = False
        '
        'BtnCli
        '
        Me.BtnCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCli.Location = New System.Drawing.Point(231, 58)
        Me.BtnCli.Name = "BtnCli"
        Me.BtnCli.Size = New System.Drawing.Size(44, 29)
        Me.BtnCli.TabIndex = 31
        Me.BtnCli.Text = "..."
        Me.BtnCli.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Código Cliente:"
        '
        'TxtRec
        '
        Me.TxtRec.Location = New System.Drawing.Point(213, 15)
        Me.TxtRec.Name = "TxtRec"
        Me.TxtRec.Size = New System.Drawing.Size(48, 29)
        Me.TxtRec.TabIndex = 28
        Me.TxtRec.Visible = False
        '
        'TxtVal
        '
        Me.TxtVal.Location = New System.Drawing.Point(200, 235)
        Me.TxtVal.Name = "TxtVal"
        Me.TxtVal.Size = New System.Drawing.Size(94, 29)
        Me.TxtVal.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Valor da Receita:"
        '
        'txtHist
        '
        Me.txtHist.Location = New System.Drawing.Point(123, 174)
        Me.txtHist.Multiline = True
        Me.txtHist.Name = "txtHist"
        Me.txtHist.Size = New System.Drawing.Size(188, 55)
        Me.txtHist.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Histórico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Data da Receita:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.GravarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.AlterarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 31)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(64, 27)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Enabled = False
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(77, 27)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        Me.AlterarToolStripMenuItem.Visible = False
        '
        'GravarToolStripMenuItem
        '
        Me.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem"
        Me.GravarToolStripMenuItem.Size = New System.Drawing.Size(78, 27)
        Me.GravarToolStripMenuItem.Text = "Gravar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(94, 27)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'Receita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(541, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Receita"
        Me.ShowIcon = False
        Me.Text = "Receita"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCli As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtRec As System.Windows.Forms.TextBox
    Friend WithEvents TxtVal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHist As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GravarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboCon As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRec As System.Windows.Forms.Button
    Friend WithEvents LblCli As System.Windows.Forms.Label
End Class
