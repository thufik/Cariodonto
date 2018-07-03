Public Class CadastroPaciente
    Dim objcli As New ClsCliente
    ' falta abrir o diálogo para consultar o código do cliente
    Dim sql As String
    Dim novo As Boolean
    Public testar As Integer
    Dim objcontrole As New ClsControle
    Dim variavel As Integer
    Private Sub CadastroPaciente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CboEstCiv.Items.Clear()
        cboSexPac.Items.Clear()
    End Sub
    Public Sub CadastroPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboSexPac.Items.Add("Masculino")
        cboSexPac.Items.Add("Feminino")
        CboEstCiv.Items.Add("Casado(a)")
        CboEstCiv.Items.Add("Solteiro(a)")
        CboEstCiv.Items.Add("Viúvo(a)")
        CboEstCiv.Items.Add("Divorciado(a)")
        Dim objuf As New ClsTipo()
        CboUfPac.DisplayMember = "Nome"
        CboUfPac.ValueMember = "ID"
        CboUfPac.DataSource = objuf.POPULAR("tabuf")
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        GravarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel2, False)
        Panel1.Visible = False
        lblemail.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Anamnese.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Odontograma.ShowDialog()

    End Sub

    Private Sub cancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        testar = 0
        AlterarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        Panel1.Visible = False
        Panel2.Visible = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        Picfoto.Image = Nothing
        objcontrole.habilitar_tela(Me, False)
        lblemail.Text = ""
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        Panel1.Visible = False
        Panel2.Enabled = True
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel2, True)
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        txtNomPac.Focus()
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If objcontrole.Testar_vazio(Me.Panel2) = True Then
            Exit Sub
        ElseIf Picfoto.Image Is Nothing Then
            MsgBox("Tire ou carregue uma foto do Cliente")
            Exit Sub
        ElseIf lblemail.Text = "Email Inválido" Then
            MsgBox("Verifique o email")
            txtEmaPac.Focus()
            Exit Sub
        End If
        If testar = 1 Then
            objcontrole.BufferIMG(Picfoto.Image, txtNomPac.Text)
            objcli.foto = Application.StartupPath & "\fotos\" & txtNomPac.Text & ".jpg"
        End If
        If testar = 2 Then
            objcli.foto = OpenFileDialog1.FileName
        End If
        If testar = 0 Then
            objcli.foto = Application.StartupPath & "\fotos\" & txtNomPac.Text & ".jpg"
        End If
        objcli.Nome = txtNomPac.Text
        objcli.Nascimento = DateTimePicker1.Text
        objcli.Sexo = cboSexPac.Text
        objcli.Telefone = txtTelPac.Text
        ' If novo = True Then
        objcli.Endereço = txtEndPac.Text & " " & txtNumcli.Text & " " & txtComcli.Text
        ' Else
        ' objcli.Endereço = txtEndPac.Text & txtNumcli.Text & txtComcli.Text
        ' End If
        objcli.Email = txtEmaPac.Text
        objcli.Ativo = chkativo.CheckState
        objcli.Estado_Civil = CboEstCiv.Text
        objcli.Unidade_Federal = CboUfPac.Text
        objcli.Cidade = txtCidPac.Text
        objcli.CEP = txtCepPac.Text
        objcli.Gravar(novo)
        MsgBox("Cadastro efetuado com sucesso!")
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel2, False)
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        lblemail.Text = ""
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Picfoto.Image = Nothing
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim objpf As New Frmpegarfoto
        Picfoto.Image = objpf.Instanciar

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "Arquivos de imagem|*.jpg; *.bmp; *.gif;|Todos os Arquivos|*.*"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\fotos\"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Picfoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            testar = 2
        End If
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        testar = 0
        NovoToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        Panel1.Enabled = True
        Panel1.Visible = True
        Panel2.Enabled = False
        Panel2.Visible = False
        objcontrole.habilitar_tela(Me.Panel1, True)
        txtcod.Focus()
        lblemail.Text = ""
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If txtcod.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                Dim objpesquisa As New DataTable
                objpesquisa = objcli.Localizar(txtcod.Text)
                If objpesquisa.Rows.Count > 0 Then
                    Panel1.Enabled = False
                    Panel2.Visible = True
                    Panel2.Enabled = True
                    objcontrole.habilitar_tela(Me.Panel2, True)
                    GravarToolStripMenuItem.Enabled = True
                    txtNomPac.Text = objpesquisa.Rows(0).Item("nomcli")
                    Dim endereco = objpesquisa.Rows(0).Item("endcli")
                    For x = 1 To Len(endereco)
                        If IsNumeric(Mid(endereco, x, 1)) = True Then
                            variavel = x
                            Exit For
                        Else
                            txtEndPac.Text &= Mid(endereco, x, 1)
                        End If
                    Next
                    For y = variavel To Len(endereco)
                        If Mid(endereco, y, 1) = " " Then
                            variavel = y
                            For z = variavel To Len(endereco)
                                txtComcli.Text &= Mid(endereco, z, 1)
                            Next
                            Exit For

                        Else
                            txtNumcli.Text &= Mid(endereco, y, 1)
                        End If
                    Next
                    DateTimePicker1.Text = objpesquisa.Rows(0).Item("nascli")
                    cboSexPac.Text = objpesquisa.Rows(0).Item("sexcli")
                    CboEstCiv.Text = objpesquisa.Rows(0).Item("esccli")
                    txtTelPac.Text = objpesquisa.Rows(0).Item("telcli")
                    txtCidPac.Text = objpesquisa.Rows(0).Item("cidcli")
                    Dim objpesquisa2 As New DataTable
                    objpesquisa2 = objcli.pesquisa_uff(objpesquisa.Rows(0).Item("ufcli"))
                    CboUfPac.SelectedValue = objpesquisa2.Rows(0).Item("id")
                    txtCepPac.Text = objpesquisa.Rows(0).Item("cepcli")
                    txtEmaPac.Text = objpesquisa.Rows(0).Item("emacli")
                    Picfoto.ImageLocation = objpesquisa.Rows(0).Item("fotocli")
                    chkativo.Checked = objpesquisa.Rows(0).Item("aticli")
                    AlterarToolStripMenuItem.Enabled = False
                    variavel = 0
                    testar = 0
                Else
                    MsgBox("Cliente não localizado")
                    txtcod.Clear()
                    txtcod.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtNumcli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumcli.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtNumcli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumcli.TextChanged

    End Sub

    Private Sub txtEmaPac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmaPac.KeyPress

    End Sub

    Private Sub txtEmaPac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmaPac.TextChanged
        Dim VALID As Boolean
        VALID = objcontrole.ValidEMail(txtEmaPac.Text)
        If VALID = True Then
            lblemail.Text = "Email válido"
            lblemail.ForeColor = Color.Green
        Else
            lblemail.Text = "Email Inválido"
            lblemail.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub txtCepPac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCepPac.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtCepPac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCepPac.TextChanged

    End Sub

    Private Sub txtEndPac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEndPac.KeyPress
        e.Handled = objcontrole.PermitirSóletas(e.KeyChar)
    End Sub

    Private Sub txtEndPac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndPac.TextChanged

    End Sub

    Private Sub txtNomPac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomPac.KeyPress
        e.Handled = objcontrole.PermitirSóletas(e.KeyChar)
    End Sub

    Private Sub txtNomPac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomPac.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmConCliente.TelaAtiva = 3
        FrmConCliente.ShowDialog()
    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub
End Class