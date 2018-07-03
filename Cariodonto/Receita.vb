Public Class Receita
    Dim objcontrole As New ClsControle
    Dim objreceita As New ClsReceita
    Dim objtipo As New ClsTipo
    Dim novo As Boolean

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        objcontrole.habilitar_botoes(Me.Panel1, True)
        objcontrole.habilitar_tela(Me.Panel1, True)
        objcontrole.Limpar_tela(Me.Panel1)
        AlterarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        TxtRec.Enabled = False
        BtnRec.Enabled = False
        LblCli.Text = ""
        TxtCli.Focus()

    End Sub

    Private Sub Receita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GravarToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.Limpar_tela2(Me.Panel1)


        CboCon.DisplayMember = "nome"
        CboCon.ValueMember = "id"
        CboCon.DataSource = objtipo.POPULAR_2("select * from tabtipocontas where tipo= 'R'")

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel1, False)
        LblCli.Text = ""
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        objcontrole.habilitar_botoes(Me.Panel1, True)
        objcontrole.habilitar_tela(Me.Panel1, True)
        TxtRec.Enabled = True
        BtnRec.Enabled = True
        LblCli.Text = ""
    End Sub

    Private Sub BtnCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCli.Click
        FrmConCliRec.ShowDialog()
    End Sub
    Private Sub TxtCli_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Validated
        If TxtCli.Text = "" Then
            MsgBox("O código do cliente esta vazio")
        End If
        If TxtCli.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim OBJRec As New ClsCliente
            OBJDTLOCAL = OBJRec.Localizar(TxtCli.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                LblCli.Text = OBJDTLOCAL.Rows(0).Item("nomcli")
            Else
                MessageBox.Show("Codigo não cadastrado")
                LblCli.Text = ""
                TxtCli.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub
    Public Sub Alterar()
        If TxtRec.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim objdtcli As New DataTable
            Dim OBJRec As New ClsReceita
            Dim objcli As New ClsCliente
            OBJDTLOCAL = OBJRec.Localizar(TxtRec.Text)
            objdtcli = objcli.Localizar(TxtCli.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                TxtCli.Text = OBJDTLOCAL.Rows(0).Item("CliRec")
                LblCli.Text = objdtcli.Rows(0).Item("nomcli")
                DtpDat.Value = OBJDTLOCAL.Rows(0).Item("datrec")
                CboCon.SelectedValue = OBJDTLOCAL.Rows(0).Item("conrec")
                If IsDBNull(OBJDTLOCAL.Rows(0).Item("histrec")) Then
                    txtHist.Text = ""
                Else
                    txtHist.Text = OBJDTLOCAL.Rows(0).Item("histrec")
                End If
                TxtVal.Text = OBJDTLOCAL.Rows(0).Item("valrec")
                objcontrole.habilitar_botoes(Me.Panel1, True)
                objcontrole.habilitar_tela(Me.Panel1, True)
                txtHist.Focus()

            Else
                MessageBox.Show("Codigo não cadastrado")
                TxtRec.Clear()
                TxtRec.Focus()

            End If
        End If
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If TxtVal.Text = "" Then
            MsgBox("O campo valor esta vazio")
            Exit Sub
        End If

        objreceita.Codigo_Cliente = TxtCli.Text
        objreceita.Data_Receita = DtpDat.Text
        objreceita.Conta = CboCon.SelectedValue
        objreceita.Historico_Receita = txtHist.Text
        objreceita.Valor_Receita = TxtVal.Text
        objreceita.Codigo_Funcionario = MenuInicial.Label1.text()
        objreceita.gravar(novo)
        MsgBox("Gravado com sucesso")


        objcontrole.habilitar_botoes(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.Limpar_tela(Me.Panel1)
        LblCli.Text = ""
        DtpDat.Value = Now

    End Sub


    Private Sub BtnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRec.Click
        FrmConReceitas.ShowDialog()
    End Sub

    Private Sub TxtRec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRec.TextChanged

    End Sub

    Private Sub TxtRec_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRec.Validated
        Call Alterar()

    End Sub
End Class