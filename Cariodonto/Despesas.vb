Public Class Despesas
    Dim objdesp As New ClsDespesas
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Private Sub Despesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.Limpar_tela2(Me.Panel1)
        GravarToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        Dim objtpo As New ClsTipo

        CboCon.DisplayMember = "nome"
        CboCon.ValueMember = "id"
        CboCon.DataSource = objtpo.POPULAR_2("select * from tabtipocontas where tipo= 'D'")
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_botoes(Me.Panel1, True)
        objcontrole.habilitar_tela(Me.Panel1, True)
        objcontrole.Limpar_tela(Me.Panel1)
        GravarToolStripMenuItem.Enabled = True

    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_tela(Me.Panel1, True)
        objcontrole.habilitar_botoes(Me.Panel1, True)
        objcontrole.Limpar_tela(Me.Panel1)
        GravarToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel1, False)
        NovoToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        'Dim objtpo As New ClsTipo

        'CboCon.DisplayMember = "nome"
        'CboCon.ValueMember = "id"
        'CboCon.DataSource = objtpo.POPULAR_2("select * from tabtipocontas where tipo= 'D'")
    End Sub
    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If TxtVal.Text = "" Then
            MsgBox("O campo valor está vazio")
            Exit Sub
        End If

        objdesp.Data = DtpDat.Value
        objdesp.Conta = CboCon.SelectedValue
        objdesp.Funcionario = MenuInicial.Label1.Text
        objdesp.Historico = TxtHist.Text
        objdesp.Valor = TxtVal.Text
        objdesp.gravar(novo)
        MsgBox("Gravado com Sucesso")


        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.Limpar_tela(Me.Panel1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConDespesas.Show()
    End Sub

    Private Sub TxtDesp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub
    'Private Sub TxtDesp_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If TxtDesp.Text = "" And TxtDesp.Enabled = True Then
    '        MsgBox("O Código da despesa está vazio")
    '        TxtDesp.Focus()
    '    End If
    '    If TxtDesp.Text <> "" Then
    '        Dim OBJDTLOCAL As New DataTable
    '        Dim OBJdespesas As New ClsDespesas
    '        OBJDTLOCAL = OBJdespesas.Localizar(TxtDesp.Text)
    '        If OBJDTLOCAL.Rows.Count > 0 Then
    '            DtpDat.Value = OBJDTLOCAL.Rows(0).Item("datdesp")
    '            CboCon.SelectedValue = OBJDTLOCAL.Rows(0).Item("condesp")
    '            If IsDBNull(OBJDTLOCAL.Rows(0).Item("histdesp")) Then
    '                TxtHist.Text = ""
    '            Else
    '                TxtHist.Text = OBJDTLOCAL.Rows(0).Item("histdesp")
    '            End If
    '            TxtVal.Text = OBJDTLOCAL.Rows(0).Item("valdesp")
    '            objcontrole.habilitar_botoes(Me, True)
    '            objcontrole.habilitar_tela(Me, True)
    '            TxtHist.Focus()

    '        Else
    '            MessageBox.Show("Codigo da Entrada não cadastrado")
    '            TxtDesp.Clear()
    '            TxtDesp.Focus()

    '        End If
    '    End If
    'End Sub
End Class