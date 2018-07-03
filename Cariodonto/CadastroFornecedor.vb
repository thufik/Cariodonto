Public Class CadastroFornecedor
    Dim objfor As New ClsFornecedores
    Dim objcontrole As New ClsControle
    Dim variavel As Integer
    Dim novo As Boolean
    Private Sub CadastroFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objuf As New ClsTipo()
        cboUfFor.DisplayMember = "Nome"
        cboUfFor.ValueMember = "ID"
        cboUfFor.DataSource = objuf.POPULAR("tabuf")
        objcontrole.Limpar_tela(Me.Panel2)
        txtendefor.Focus()
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        AlterarToolStripMenuItem.Enabled = True
        Panel2.Enabled = False
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        lblemail.Text = ""
        GravarToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel2)
        Panel2.Enabled = True
        txtnomefor.Focus()
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If objcontrole.Testar_vazio(Me.Panel2) = True Then
            Exit Sub
        ElseIf lblemail.Text = "Email Inválido" Then
            MsgBox("Verifique o email")
            txtemafor.Focus()
            Exit Sub
        End If
        objfor.codigo = Val(txtcod.Text)
        objfor.Empresa = txtnomefor.Text
        objfor.Endereço = txtendefor.Text & " " & txtnumfor.Text & " " & txtcomfor.Text
        objfor.Telefone = txttel.Text
        objfor.email = txtemafor.Text
        objfor.UnidadeFederal = cboUfFor.Text
        objfor.gravar(novo)
        MsgBox("Cadastro efetuado com sucesso!")
        objcontrole.Limpar_tela(Me.Panel2)
        objcontrole.Limpar_tela(Me.Panel1)
        Panel2.Enabled = False
        Panel1.Visible = False
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        lblemail.Text = ""
    End Sub

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = False
        Panel1.Visible = True
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel2.Visible = False
        txtcod.Text = ""
        txtcod.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmConFornecedor.ShowDialog()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        lblemail.Text = ""
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        AlterarToolStripMenuItem.Enabled = True
        Panel2.Enabled = False
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If txtcod.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                Dim objpesquisa As New DataTable
                objpesquisa = objfor.pesquisar_fornecedor(txtcod.Text)
                If objpesquisa.Rows.Count > 0 Then
                    Panel1.Enabled = False
                    Panel2.Visible = True
                    Panel2.Enabled = True
                    GravarToolStripMenuItem.Enabled = True
                    txtnomefor.Text = objpesquisa.Rows(0).Item("empfor")
                    Dim endereco = objpesquisa.Rows(0).Item("endfor")
                    For x = 1 To Len(endereco)
                        If IsNumeric(Mid(endereco, x, 1)) = True Then
                            variavel = x
                            Exit For
                        Else
                            txtendefor.Text &= Mid(endereco, x, 1)
                        End If
                    Next
                    For y = variavel To Len(endereco)
                        If Mid(endereco, y, 1) = " " Then
                            variavel = y
                            For z = variavel To Len(endereco)
                                txtcomfor.Text &= Mid(endereco, z, 1)
                            Next
                            Exit For

                        Else
                            txtnumfor.Text &= Mid(endereco, y, 1)
                        End If
                    Next
                    txttel.Text = objpesquisa.Rows(0).Item("telfor")
                    txtemafor.Text = objpesquisa.Rows(0).Item("emafor")
                    Dim objpesquisa2 As New DataTable
                    objpesquisa2 = objfor.pesquisa_uff(objpesquisa.Rows(0).Item("uffor"))
                    cboUfFor.SelectedValue = objpesquisa2.Rows(0).Item("id")
                    AlterarToolStripMenuItem.Enabled = False
                    variavel = 0
                Else
                    MsgBox("Fornecedor não localizado")
                    txtcod.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub txtnumfor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumfor.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub


    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub txtendefor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtendefor.KeyPress
        e.Handled = objcontrole.PermitirSóletas(e.KeyChar)
    End Sub

    Private Sub txtendefor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtendefor.TextChanged

    End Sub

    Private Sub txtemafor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemafor.TextChanged

    End Sub

    Private Sub txtemafor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemafor.Validated
        Dim VALID As Boolean
        VALID = objcontrole.ValidEMail(txtemafor.Text)
        If VALID = True Then
            lblemail.Text = "Email válido"
            lblemail.ForeColor = Color.Green
        Else
            lblemail.Text = "Email Inválido"
            lblemail.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

End Class