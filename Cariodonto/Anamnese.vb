Public Class Anamnese
    'tem que programar o botão para pesquisar o código do cliente
    Dim objAnamnese As New ClsAnamnese
    Public novo As Boolean
    Dim objcontrole As New ClsControle
    Dim objlocalizar1 As New DataTable
    Dim objlocalizar As New DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        objAnamnese.CodDoPaciente = txtcod.Text
        If Rdo1sim.Checked = True Then
            objAnamnese.DoençaAtual = True
        Else
            objAnamnese.DoençaAtual = False
        End If
        objAnamnese.DoençaAtualQual = txtDoenQual.Text
        If Rdo2sim.Checked = True Then
            objAnamnese.AlergiaSN = True
        Else
            objAnamnese.AlergiaSN = False
        End If
        objAnamnese.AlergiaQual = txtAlerQual.Text
        If Rdo3sim.Checked = True Then
            objAnamnese.OperacaoSN = True
        Else
            objAnamnese.OperacaoSN = False
        End If
        If rdo4sim.Checked = True Then
            objAnamnese.CicatrizacaoSN = True
        Else
            objAnamnese.CicatrizacaoSN = False
        End If
        If Rdo5sim.Checked = True Then
            objAnamnese.AnestesiaSN = True
        Else
            objAnamnese.AnestesiaSN = False
        End If
        If Rdo6sim.Checked = True Then
            objAnamnese.HemorragiaSN = True
        Else
            objAnamnese.HemorragiaSN = False
        End If
        If Rdo7sim.Checked = True Then
            objAnamnese.FebreReumatica = True
        Else
            objAnamnese.FebreReumatica = False
        End If
        If rdo8sim.Checked = True Then
            objAnamnese.ProblemaRenal = True
        Else
            objAnamnese.ProblemaRenal = False
        End If
        If Rdo9sim.Checked = True Then
            objAnamnese.ProblemaGastrico = True
        Else
            objAnamnese.ProblemaGastrico = False
        End If
        If Rdo10sim.Checked = True Then
            objAnamnese.ProblemaCardiaco = True
        Else
            objAnamnese.ProblemaCardiaco = False
        End If
        If Rdo11sim.Checked = True Then
            objAnamnese.ProblemaRespiratorio = True
        Else
            objAnamnese.ProblemaRespiratorio = False
        End If
        If Rdo12sim.Checked = True Then
            objAnamnese.ProblemaAlergico = True
        Else
            objAnamnese.ProblemaAlergico = False
        End If

        If Rdo15sim.Checked = True Then
            objAnamnese.ProblemasArticularesOuReumatismo = True
        Else
            objAnamnese.ProblemasArticularesOuReumatismo = False
        End If
        If Rdo3sim.Checked = True Then
            objAnamnese.ProblemaGastrico = True
        Else
            objAnamnese.ProblemaGastrico = False
        End If
        If Rdo14sim.Checked = True Then
            objAnamnese.ProblemaDiabetes = True
        Else
            objAnamnese.ProblemaDiabetes = False
        End If
        If Rdo13sim.Checked = True Then
            objAnamnese.HipertensaoArterial = True
        Else
            objAnamnese.HipertensaoArterial = False
        End If
        objAnamnese.AntescedentesFamiliares = txtDescri.Text
        objAnamnese.ObservacoesImportantes = TxtObsimport.Text
        objAnamnese.gravar(True)
        MsgBox("Gravado!")
    End Sub


    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmConCliente.TelaAtiva = 2
        txtcod.Text = ""
        FrmConCliente.ShowDialog()
    End Sub

    Private Sub Anamnese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objcontrole.habilitar_tela(Me, False)
        NovoToolStripMenuItem1.Enabled = True
        AlterarToolStripMenuItem1.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.paneldois)
        Panel1.Enabled = True
        Rdo1sim.Checked = False
        rdo1nao.Checked = False
        Rdo2sim.Checked = False
        rdo2nao.Checked = False
        Rdo3sim.Checked = False
        rdo3nao.Checked = False
        rdo4sim.Checked = False
        rdo4nao.Checked = False
        Rdo5sim.Checked = False
        rdo5nao.Checked = False
        Rdo6sim.Checked = False
        rdo6nao.Checked = False
        Rdo7sim.Checked = False
        rdo7nao.Checked = False
        rdo8sim.Checked = False
        rdo8nao.Checked = False
        Rdo9sim.Checked = False
        rdo9nao.Checked = False
        Rdo10sim.Checked = False
        rdo10nao.Checked = False
        Rdo11sim.Checked = False
        rdo11nao.Checked = False
        Rdo12sim.Checked = False
        rdo12nao.Checked = False
        Rdo13sim.Checked = False
        rdo13nao.Checked = False
        Rdo14sim.Checked = False
        rdo14nao.Checked = False
        Rdo15sim.Checked = False
        rdo15nao.Checked = False
        Panel1.Enabled = False
        paneldois.Enabled = False
        paneldois.Visible = True
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown

        If txtcod.Text <> "" Then
           If e.KeyCode = Keys.Enter Then
                objlocalizar = objAnamnese.localizar(txtcod.Text)
                If objlocalizar.Rows.Count > 0 Then
                    If novo = True Then
                        objlocalizar1 = objAnamnese.localizaranamnese(txtcod.Text)
                        If objlocalizar1.Rows.Count > 0 Then
                            MsgBox("Código Já Cadastrado Na Anamnese,Clique Na Aba Alterar")
                            txtcod.Text = ""
                            NovoToolStripMenuItem1.Enabled = False
                            AlterarToolStripMenuItem1.Enabled = True
                            Panel1.Enabled = False
                            Exit Sub
                        Else
                            txtCliente.Text = objlocalizar.Rows(0).Item("nomcli")
                            paneldois.Visible = True
                            Panel1.Enabled = False
                            objcontrole.habilitar_tela(Me.paneldois, False)
                            paneldois.Enabled = True
                            Rdo1sim.Checked = True
                            Pndoenqual.Enabled = True
                            txtDoenQual.Enabled = True
                            txtDoenQual.Focus()
                        End If
                    Else
                        pnalergia.Enabled = True
                        pncica.Enabled = True
                        pndiab.Enabled = True
                        Pndoenqual.Enabled = True
                        pnFebReu.Enabled = True
                        pnhip.Enabled = True
                        pnoper.Enabled = True
                        pnprobaler.Enabled = True
                        pnprobanes.Enabled = True
                        pnprobartreu.Enabled = True
                        pnprobcar.Enabled = True
                        pnprobgas.Enabled = True
                        pnprobhemo.Enabled = True
                        pnprobren.Enabled = True
                        pnprobres.Enabled = True
                        TxtOperacao.Enabled = True
                        txtDoenQual.Enabled = True
                        txtDescri.Enabled = True
                        TxtObsimport.Enabled = True
                        txtAlerQual.Enabled = True
                        objlocalizar1 = objAnamnese.localizaranamnese(txtcod.Text)
                        If objlocalizar1.Rows.Count > 0 Then
                            txtCliente.Text = objlocalizar.Rows(0).Item("nomcli")
                            If objlocalizar1.Rows(0).Item("doeatusn") = True Then
                                Rdo1sim.Checked = True
                            Else
                                rdo1nao.Checked = True
                                txtDoenQual.Enabled = False
                            End If
                            txtDoenQual.Text = objlocalizar1.Rows(0).Item("DoeAtuQ")
                            If objlocalizar1.Rows(0).Item("alersn") = True Then
                                Rdo2sim.Checked = True
                            Else
                                rdo2nao.Checked = True
                                txtAlerQual.Enabled = False
                            End If
                            txtAlerQual.Text = objlocalizar1.Rows(0).Item("alerq")
                            If objlocalizar1.Rows(0).Item("opesn") = True Then
                                Rdo3sim.Checked = True
                            Else
                                rdo3nao.Checked = True
                                TxtOperacao.Enabled = False
                            End If
                            TxtOperacao.Text = objlocalizar1.Rows(0).Item("opeq")
                            txtDescri.Text = objlocalizar1.Rows(0).Item("antfam")
                            TxtObsimport.Text = objlocalizar1.Rows(0).Item("obsimp")
                            If objlocalizar1.Rows(0).Item("cicasn") = True Then
                                rdo4sim.Checked = True
                            Else
                                rdo4nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("anessn") = True Then
                                Rdo5sim.Checked = True
                            Else
                                rdo5nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("hemosn") = True Then
                                Rdo6sim.Checked = True
                            Else
                                rdo6nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("febreu") = True Then
                                Rdo7sim.Checked = True
                            Else
                                rdo7nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probren") = True Then
                                rdo8sim.Checked = True
                            Else
                                rdo8nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probgas") = True Then
                                Rdo9sim.Checked = True
                            Else
                                rdo9nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probcar") = True Then
                                Rdo10sim.Checked = True
                            Else
                                rdo10nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probres") = True Then
                                Rdo11sim.Checked = True
                            Else
                                rdo11nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probale") = True Then
                                Rdo12sim.Checked = True
                            Else
                                rdo12nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probar") = True Then
                                Rdo13sim.Checked = True
                            Else
                                rdo13nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("probdia") = True Then
                                Rdo14sim.Checked = True
                            Else
                                rdo14nao.Checked = True
                            End If
                            If objlocalizar1.Rows(0).Item("hipart") = True Then
                                Rdo15sim.Checked = True
                            Else
                                rdo15nao.Checked = True
                            End If
                            Panel1.Enabled = False
                            paneldois.Visible = True
                            paneldois.Enabled = True
                            GravarToolStripMenuItem.Enabled = True
                            Exit Sub
                        Else
                            MsgBox("Código não cadastrado na Anamnese")
                            txtcod.Text = ""
                            txtcod.Focus()
                        End If
                End If
                Else
                    MsgBox("Código não localizado")
                    txtcod.Text = ""
                    txtcod.Focus()
                End If

            End If
        End If
    End Sub


    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtDoenQual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDoenQual.KeyDown

        If txtDoenQual.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                pnalergia.Enabled = True
                If rdo2nao.Checked = True Then
                    rdo2nao.Checked = True
                    rdo2nao.Focus()
                Else
                    Rdo2sim.Checked = True
                    txtAlerQual.Enabled = True
                    txtAlerQual.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Rdo1sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo1sim.Click
        txtDoenQual.Enabled = True
        txtDoenQual.Focus()
    End Sub
    Private Sub rdo1nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo1nao.Click
        txtDoenQual.Enabled = False
        txtDoenQual.Text = ""
        pnalergia.Enabled = True
        If rdo2nao.Checked = True Then
        Else
            Rdo2sim.Checked = True
            txtAlerQual.Enabled = True
            txtAlerQual.Focus()
        End If
    End Sub
    Private Sub Rdo2sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo2sim.Click
        txtAlerQual.Enabled = True
        txtAlerQual.Focus()
    End Sub

    Private Sub rdo2nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo2nao.Click
        txtAlerQual.Enabled = False
        txtAlerQual.Text = ""
        pnoper.Enabled = True
        If rdo3nao.Checked = True Then
        Else
            Rdo3sim.Checked = True
            TxtOperacao.Enabled = True
            txtAlerQual.Focus()
        End If
    End Sub

    Private Sub Rdo3sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo3sim.Click
        TxtOperacao.Enabled = True
        TxtOperacao.Focus()
    End Sub

    Private Sub rdo3nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo3nao.Click
        TxtOperacao.Enabled = False
        txtDescri.Enabled = True
        TxtOperacao.Text = ""
        txtDescri.Focus()
    End Sub

    Private Sub txtAlerQual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlerQual.KeyDown
        If txtAlerQual.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                pnoper.Enabled = True
                If rdo3nao.Checked = True Then
                    rdo3nao.Checked = True
                    rdo3nao.Focus()
                Else
                    Rdo3sim.Checked = True
                    TxtOperacao.Enabled = True
                    TxtOperacao.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TxtOperacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOperacao.KeyDown
        If TxtOperacao.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                txtDescri.Enabled = True
                txtDescri.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescri_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescri.Validated
        TxtObsimport.Enabled = True
        TxtObsimport.Focus()
    End Sub

    Private Sub rdo4sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo4sim.Click
        If rdo5nao.Checked = False Then
            Rdo5sim.Checked = True
            pnprobanes.Enabled = True
        End If
    End Sub

    Private Sub rdo4nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo4nao.Click
        If rdo5nao.Checked = False Then
            Rdo5sim.Checked = True
            pnprobanes.Enabled = True
        End If
    End Sub

    Private Sub Rdo5sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo5sim.Click
        If rdo6nao.Checked = False Then
            Rdo6sim.Checked = True
            pnprobhemo.Enabled = True
        End If
    End Sub

    Private Sub rdo5nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo5nao.Click
        If rdo6nao.Checked = False Then
            Rdo6sim.Checked = True
            pnprobhemo.Enabled = True
        End If
    End Sub
    Private Sub Rdo6sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo6sim.Click
        If rdo7nao.Checked = False Then
            Rdo7sim.Checked = True
            pnFebReu.Enabled = True
        End If
    End Sub


    Private Sub rdo6nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo6nao.Click
        If rdo7nao.Checked = False Then
            Rdo7sim.Checked = True
            pnFebReu.Enabled = True
        End If
    End Sub



    Private Sub Rdo7sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo7sim.Click
        If rdo8nao.Checked = False Then
            rdo8sim.Checked = True
            pnprobren.Enabled = True
        End If
    End Sub
    Private Sub rdo7nao_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo7nao.Click
        If rdo8nao.Checked = False Then
            rdo8sim.Checked = True
            pnprobren.Enabled = True
        End If
    End Sub
    Private Sub Rdo8sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo8sim.Click
        If rdo9nao.Checked = False Then
            Rdo9sim.Checked = True
            pnprobgas.Enabled = True
        End If
    End Sub
    Private Sub Rdo8nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo8nao.Click
        If rdo9nao.Checked = False Then
            Rdo9sim.Checked = True
            pnprobgas.Enabled = True
        End If
    End Sub
    Private Sub Rdo9sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo9sim.Click
        If rdo10nao.Checked = False Then
            Rdo10sim.Checked = True
            pnprobcar.Enabled = True
        End If
    End Sub
    Private Sub Rdo9nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo9nao.Click
        If rdo10nao.Checked = False Then
            Rdo10sim.Checked = True
            pnprobcar.Enabled = True
        End If
    End Sub
    Private Sub Rdo10sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo10sim.Click
        If rdo11nao.Checked = False Then
            Rdo11sim.Checked = True
            pnprobres.Enabled = True
        End If
    End Sub
    Private Sub Rdo10nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo10nao.Click
        If rdo11nao.Checked = False Then
            Rdo11sim.Checked = True
            pnprobres.Enabled = True
        End If
    End Sub
    Private Sub Rdo11sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo11sim.Click
        If rdo12nao.Checked = False Then
            Rdo12sim.Checked = True
            pnprobaler.Enabled = True
        End If
    End Sub
    Private Sub Rdo11nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo11nao.Click
        If rdo12nao.Checked = False Then
            Rdo12sim.Checked = True
            pnprobaler.Enabled = True
        End If
    End Sub
    Private Sub Rdo12sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo12sim.Click
        If rdo13nao.Checked = False Then
            Rdo13sim.Checked = True
            pnprobartreu.Enabled = True
        End If
    End Sub
    Private Sub Rdo12nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo12nao.Click
        If rdo13nao.Checked = False Then
            Rdo13sim.Checked = True
            pnprobartreu.Enabled = True
        End If
    End Sub
    Private Sub Rdo13sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo13sim.Click
        If rdo14nao.Checked = False Then
            Rdo14sim.Checked = True
            pndiab.Enabled = True
        End If
    End Sub
    Private Sub Rdo13nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo13nao.Click
        If rdo14nao.Checked = False Then
            Rdo14sim.Checked = True
            pndiab.Enabled = True
        End If
    End Sub
    Private Sub Rdo14sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo14sim.Click
        If rdo15nao.Checked = False Then
            Rdo15sim.Checked = True
            pnhip.Enabled = True
        End If
    End Sub
    Private Sub Rdo14nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo14nao.Click
        If rdo15nao.Checked = False Then
            Rdo15sim.Checked = True
            pnhip.Enabled = True
        End If
    End Sub




    Private Sub TxtObsimport_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtObsimport.Validated
        pncica.Enabled = True
        rdo4sim.Checked = True
    End Sub
    Private Sub Rdo15sim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdo15sim.Click
        GravarToolStripMenuItem.Enabled = True
    End Sub
    Private Sub Rdo15nao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdo15nao.Click
        GravarToolStripMenuItem.Enabled = True
    End Sub
    Private Sub NovoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem1.Click
        novo = True
        GravarToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem1.Enabled = False
        Panel1.Enabled = True
        Rdo1sim.Checked = False
        rdo1nao.Checked = False
        Rdo2sim.Checked = False
        rdo2nao.Checked = False
        Rdo3sim.Checked = False
        rdo3nao.Checked = False
        rdo4sim.Checked = False
        rdo4nao.Checked = False
        Rdo5sim.Checked = False
        rdo5nao.Checked = False
        Rdo6sim.Checked = False
        rdo6nao.Checked = False
        Rdo7sim.Checked = False
        rdo7nao.Checked = False
        rdo8sim.Checked = False
        rdo8nao.Checked = False
        Rdo9sim.Checked = False
        rdo9nao.Checked = False
        Rdo10sim.Checked = False
        rdo10nao.Checked = False
        Rdo11sim.Checked = False
        rdo11nao.Checked = False
        Rdo12sim.Checked = False
        rdo12nao.Checked = False
        Rdo13sim.Checked = False
        rdo13nao.Checked = False
        Rdo14sim.Checked = False
        rdo14nao.Checked = False
        Rdo15sim.Checked = False
        rdo15nao.Checked = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.paneldois)
        Panel1.Enabled = True
        paneldois.Enabled = False
        txtcod.Focus()
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        'If objcontrole.Testar_vazio(Me.Panel1) Or objcontrole.Testar_vazio(Me.paneldois) = True Then
        ' MsgBox("Preencha os campos necessários")
        'Exit Sub
        ' End If

        objAnamnese.CodDoPaciente = txtcod.Text
        If Rdo1sim.Checked = True Then
            objAnamnese.DoençaAtual = True
        Else
            objAnamnese.DoençaAtual = False
        End If
        objAnamnese.DoençaAtualQual = txtDoenQual.Text
        If Rdo2sim.Checked = True Then
            objAnamnese.AlergiaSN = True
        Else
            objAnamnese.AlergiaSN = False
        End If
        objAnamnese.AlergiaQual = txtAlerQual.Text
        If Rdo3sim.Checked = True Then
            objAnamnese.OperacaoSN = True
        Else
            objAnamnese.OperacaoSN = False
        End If

        objAnamnese.OperacaoQual = TxtOperacao.Text
        objAnamnese.AntescedentesFamiliares = txtDescri.Text
        objAnamnese.ObservacoesImportantes = TxtObsimport.Text
        If rdo4sim.Checked = True Then
            objAnamnese.CicatrizacaoSN = True
        Else
            objAnamnese.CicatrizacaoSN = False
        End If
        If Rdo5sim.Checked = True Then
            objAnamnese.AnestesiaSN = True
        Else
            objAnamnese.AnestesiaSN = False
        End If
        If Rdo6sim.Checked = True Then
            objAnamnese.HemorragiaSN = True
        Else
            objAnamnese.HemorragiaSN = False
        End If
        If Rdo7sim.Checked = True Then
            objAnamnese.FebreReumatica = True
        Else
            objAnamnese.FebreReumatica = False
        End If
        If rdo8sim.Checked = True Then
            objAnamnese.ProblemaRenal = True
        Else
            objAnamnese.ProblemaRenal = False
        End If
        If Rdo9sim.Checked = True Then
            objAnamnese.ProblemaGastrico = True
        Else
            objAnamnese.ProblemaGastrico = False
        End If
        If Rdo10sim.Checked = True Then
            objAnamnese.ProblemaCardiaco = True
        Else
            objAnamnese.ProblemaCardiaco = False
        End If
        If Rdo11sim.Checked = True Then
            objAnamnese.ProblemaRespiratorio = True
        Else
            objAnamnese.ProblemaRespiratorio = False
        End If
        If Rdo12sim.Checked = True Then
            objAnamnese.ProblemaAlergico = True
        Else
            objAnamnese.ProblemaAlergico = False
        End If
        If Rdo13sim.Checked = True Then
            objAnamnese.ProblemasArticularesOuReumatismo = True
        Else
            objAnamnese.ProblemasArticularesOuReumatismo = False
        End If
        If Rdo14sim.Checked = True Then
            objAnamnese.ProblemaDiabetes = True
        Else
            objAnamnese.ProblemaDiabetes = False
        End If
        If Rdo15sim.Checked = True Then
            objAnamnese.HipertensaoArterial = True
        Else
            objAnamnese.HipertensaoArterial = False
        End If
        objAnamnese.gravar(novo)
        MsgBox("Cadastro Efetuado com sucesso!")
        Rdo1sim.Checked = False
        rdo1nao.Checked = False
        Rdo2sim.Checked = False
        rdo2nao.Checked = False
        Rdo3sim.Checked = False
        rdo3nao.Checked = False
        rdo4sim.Checked = False
        rdo4nao.Checked = False
        Rdo5sim.Checked = False
        rdo5nao.Checked = False
        Rdo6sim.Checked = False
        rdo6nao.Checked = False
        Rdo7sim.Checked = False
        rdo7nao.Checked = False
        rdo8sim.Checked = False
        rdo8nao.Checked = False
        Rdo9sim.Checked = False
        rdo9nao.Checked = False
        Rdo10sim.Checked = False
        rdo10nao.Checked = False
        Rdo11sim.Checked = False
        rdo11nao.Checked = False
        Rdo12sim.Checked = False
        rdo12nao.Checked = False
        Rdo13sim.Checked = False
        rdo13nao.Checked = False
        Rdo14sim.Checked = False
        rdo14nao.Checked = False
        Rdo15sim.Checked = False
        rdo15nao.Checked = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.paneldois)
        Panel1.Enabled = False
        paneldois.Enabled = False
        NovoToolStripMenuItem1.Enabled = True
        AlterarToolStripMenuItem1.Enabled = True
        GravarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CancelarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem1.Click
        NovoToolStripMenuItem1.Enabled = True
        AlterarToolStripMenuItem1.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.paneldois)
        Panel1.Enabled = True
        Rdo1sim.Checked = False
        rdo1nao.Checked = False
        Rdo2sim.Checked = False
        rdo2nao.Checked = False
        Rdo3sim.Checked = False
        rdo3nao.Checked = False
        rdo4sim.Checked = False
        rdo4nao.Checked = False
        Rdo5sim.Checked = False
        rdo5nao.Checked = False
        Rdo6sim.Checked = False
        rdo6nao.Checked = False
        Rdo7sim.Checked = False
        rdo7nao.Checked = False
        rdo8sim.Checked = False
        rdo8nao.Checked = False
        Rdo9sim.Checked = False
        rdo9nao.Checked = False
        Rdo10sim.Checked = False
        rdo10nao.Checked = False
        Rdo11sim.Checked = False
        rdo11nao.Checked = False
        Rdo12sim.Checked = False
        rdo12nao.Checked = False
        Rdo13sim.Checked = False
        rdo13nao.Checked = False
        Rdo14sim.Checked = False
        rdo14nao.Checked = False
        Rdo15sim.Checked = False
        rdo15nao.Checked = False
        Panel1.Enabled = False
        paneldois.Enabled = False
        paneldois.Visible = True
    End Sub

    Private Sub AlterarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem1.Click
        novo = False
        Panel1.Enabled = True
        paneldois.Enabled = False
        paneldois.Visible = False
        NovoToolStripMenuItem1.Enabled = False
        AlterarToolStripMenuItem1.Enabled = False
        txtcod.Focus()
    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub Rdo15sim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdo15sim.CheckedChanged

    End Sub

    Private Sub CadastrarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarClienteToolStripMenuItem.Click
    End Sub
End Class