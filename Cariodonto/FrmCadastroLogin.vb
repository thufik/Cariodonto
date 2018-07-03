Public Class FrmCadastroLogin
    Dim sql As String
    Dim objtipo As New ClsTipo
    Dim objcontrole As New ClsControle
    Dim objlogin As New ClsLogin
    Dim novo As Boolean
    Dim objfun As New ClsFuncionarios
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmConFuncionário.telaativa = 3
        FrmConFuncionário.ShowDialog()
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If txtcod.Text <> "" And novo = False Then
            If e.KeyCode = Keys.Enter Then
                Dim objlocalizar As New DataTable
                Dim objlogin As New ClsLogin
                objlocalizar = objlogin.Localizar(txtcod.Text)
                If objlocalizar.Rows.Count > 0 Then
                    txtNomfun.Text = objlocalizar.Rows(0).Item("nomfun")
                    txtlogin.Text = objlocalizar.Rows(0).Item("login")
                    txtsenha.Text = objlocalizar.Rows(0).Item("senha")
                    txtconfsenha.Text = objlocalizar.Rows(0).Item("senha")
                    Panel1.Enabled = False
                    Panel2.Visible = True
                    Panel2.Enabled = True
                    GravarToolStripMenuItem.Enabled = True
                    AlterarToolStripMenuItem.Enabled = False
                    NovoToolStripMenuItem.Enabled = False
                Else
                    MsgBox("código não localizado")
                    txtcod.Clear()
                    txtcod.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged
        If txtcod.Text = "" Then
            txtNomfun.Text = ""
        End If
    End Sub

    Private Sub txtcod_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcod.Validated
        Dim objlocalizar As New DataTable
        Dim objfun As New ClsFuncionarios
        If txtcod.Text <> "" Then
            sql = "SELECT * FROM funcionarios where codfun=" & txtcod.Text
            objlocalizar = objtipo.POPULAR_2(Sql)
            If objlocalizar.Rows.Count > 0 Then
                txtNomfun.Text = objlocalizar.Rows(0).Item("nomfun")
            Else
                MsgBox("Código não localizado")
                txtcod.Text = ""
                txtcod.Focus()
            End If
        Else
        End If
    End Sub

    Private Sub FrmCadastroLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        Panel1.Enabled = False
        Panel2.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        Panel2.Visible = True
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        Panel1.Enabled = True
        Panel2.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        Panel2.Visible = True
        GravarToolStripMenuItem.Enabled = True
        txtcod.Focus()
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If objcontrole.Testar_vazio(Me.Panel1) = True Then
            Exit Sub
        ElseIf objcontrole.Testar_vazio(Me.Panel2) = True Then
            Exit Sub
        End If
        If txtsenha.Text <> txtconfsenha.Text Then
            MsgBox("Verifique se vc digitou senhas iguais")
            Exit Sub
        End If
        objlogin.login = txtlogin.Text
        objlogin.senha = txtconfsenha.Text
        objlogin.nome = txtNomfun.Text
        objlogin.codigo = txtcod.Text
        objlogin.gravar(novo)
        MsgBox("Login Cadastrado com sucesso")
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        Panel1.Enabled = False
        Panel2.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = True
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        NovoToolStripMenuItem.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        Panel2.Visible = False
        Panel1.Enabled = True
        txtcod.Focus()
        

    End Sub

    Private Sub CANCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCToolStripMenuItem.Click
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        Panel1.Enabled = False
        Panel2.Enabled = False

    End Sub
End Class