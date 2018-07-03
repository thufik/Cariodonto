Public Class Agenda
    Dim objagenda As New ClsAgendamento
    Dim sql As String
    Dim novo As Boolean
    Dim objcontrole As New ClsControle
    Dim objtipo As New ClsTipo
    Dim hora1 As Date
    Dim hora2 As Date
    Dim diferenca As Long
    Dim difteste As Long
    Dim teste1 As Date
    Dim teste2 As Date
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmConCliente.TelaAtiva = 1
        FrmConCliente.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmConCodAgen.ShowDialog()
    End Sub
    Private Sub Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from funcionarios where codfun > 1 "
        Dim objfun As New ClsTipo
        CboProf.DataSource = objfun.POPULAR_2(sql)
        CboProf.DisplayMember = "nomfun"
        CboProf.ValueMember = "codfun"
        Cbocod.DataSource = objfun.POPULAR("tabtipoconsulta")
        Cbocod.DisplayMember = "descon"
        Cbocod.ValueMember = "codcon"
        AlterarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        Panel1.Visible = False
        objcontrole.Limpar_tela(Me)
        Panel1.Visible = False
        objcontrole.habilitar_tela(Me, False)
    End Sub
    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = False
        Panel1.Visible = False
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, True)
        sql = "select * from funcionarios where codfun > 1 "
        Dim objfun As New ClsTipo
        CboProf.DataSource = objfun.POPULAR_2(sql)
        CboProf.DisplayMember = "nomfun"
        CboProf.ValueMember = "codfun"
        Cbocod.DataSource = objfun.POPULAR("tabtipoconsulta")
        Cbocod.DisplayMember = "descon"
        Cbocod.ValueMember = "codcon"
        txtCliente.Focus()
    End Sub

    Private Sub txtCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Validated
        'permitir ´só números
        Dim objlocalizar As New DataTable
        Dim objagenda As New ClsAgendamento
        If txtCliente.Text <> "" Then
            sql = "SELECT CODCLI,NOMCLI,TELCLI FROM CLIENTES where codcli=" & txtCliente.Text
            objlocalizar = objtipo.POPULAR_2(sql)
            If objlocalizar.Rows.Count > 0 Then
                txtNomcli.Text = objlocalizar.Rows(0).Item("nomcli")
            Else
                MsgBox("Código não localizado")
                txtCliente.Text = ""
                txtCliente.Focus()
            End If
        Else
        End If
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If txtcod.Text <> "" Then
            If e.KeyCode = Keys.Enter Then
                Dim objlocalizar As New DataTable
                Dim objagenda As New ClsAgendamento
                objlocalizar = objagenda.Localizar(txtcod.Text)
                If objlocalizar.Rows.Count > 0 Then
                    Dim objlocalizar3 As New DataTable
                    Dim objcliente As New ClsCliente
                    DateTimePicker1.Value = objlocalizar.Rows(0).Item("datage")
                    txtCliente.Text = objlocalizar.Rows(0).Item("cliage")
                    CboProf.SelectedValue = objlocalizar.Rows(0).Item("codprof")
                    Cbocod.SelectedValue = objlocalizar.Rows(0).Item("conage")
                    DateTimePicker2.Value = objlocalizar.Rows(0).Item("horini")
                    DateTimePicker3.Value = objlocalizar.Rows(0).Item("horfim")
                    objlocalizar3 = objagenda.localizar3(txtCliente.Text)
                    objcontrole.habilitar_tela(Me, True)
                    Panel1.Enabled = False
                    GravarToolStripMenuItem.Enabled = True
                    AlterarToolStripMenuItem.Enabled = False
                    If objlocalizar3.Rows.Count > 0 Then
                        txtNomcli.Text = objlocalizar3.Rows(0).Item("nomcli")
                    End If
                Else
                    MsgBox("código não localizado")
                    txtcod.Clear()
                    txtcod.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress, txtCliente.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        AlterarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        ExcluirToolStripMenuItem.Enabled = True
        Panel1.Visible = False
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, False)
        sql = "select * from funcionarios where codfun > 1 "
        Dim objfun As New ClsTipo
        CboProf.DataSource = objfun.POPULAR_2(sql)
        CboProf.DisplayMember = "nomfun"
        CboProf.ValueMember = "codfun"
        Cbocod.DataSource = objfun.POPULAR("tabtipoconsulta")
        Cbocod.DisplayMember = "descon"
        Cbocod.ValueMember = "codcon"
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        Dim objlocalizar As New DataTable
        If txtCliente.Text = "" Then
            MsgBox("Preencha os campos obrigatórios")
            txtCliente.Focus()
            Exit Sub
        End If
        If DateTimePicker3.Text < DateTimePicker2.Text Then
            MsgBox("A hora Inicial não pode ser maior do que a hora final")
            Exit Sub
        ElseIf DateTimePicker2.Text = DateTimePicker3.Text Then
            MsgBox("Altere os horários,eles estão iguais")
            Exit Sub
        End If
        objlocalizar = objtipo.POPULAR_comStored2(CboProf.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text)
        If objlocalizar.Rows.Count > 0 Then
            MsgBox("Este horário ja está reservado")
            Exit Sub
        End If
        hora1 = DateTimePicker2.Text
        hora2 = DateTimePicker3.Text
        diferenca = DateDiff(DateInterval.Minute, hora1, hora2)
        If diferenca < 30 Or diferenca > 30 Then
            MsgBox("A diferença entre os horários tem que ser de meia hora")
            Exit Sub
        End If

        DataGridView1.DataSource = objtipo.POPULAR_comStored(CboProf.SelectedValue, DateTimePicker1.Text)
        If DataGridView1.Rows.Count > 1 Then

            For x = 0 To Val(datagridview1.Rows.Count) - 2
                teste1 = datagridview1.Rows(x).Cells(0).FormattedValue
                teste2 = DateTimePicker2.Text
                If teste1 > teste2 Then
                    difteste = DateDiff(DateInterval.Minute, teste2, teste1)
                Else
                    difteste = DateDiff(DateInterval.Minute, teste1, teste2)
                End If

                If difteste < 30 Then
                    MsgBox("Verifique a agenda,esse horário está muito próximo a um horário ja marcado")
                    Exit Sub
                End If
            Next
        End If
        objagenda.codigo = Val(txtcod.Text)
        objagenda.Codigo_Cliente = txtCliente.Text
        objagenda.codigo_profissional = CboProf.SelectedValue
        objagenda.Cod_Consulta = Cbocod.SelectedValue
        objagenda.Data = DateTimePicker1.Text
        objagenda.Horario_Inicial = DateTimePicker2.Text
        objagenda.Horario_final = DateTimePicker3.Text
        objagenda.gravar(novo)
        MsgBox("Cadastro Efetuado Com Sucesso!!")

        txtcod.Text = ""
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, False)
        Panel1.Enabled = True
        txtcod.Focus()
    End Sub

 
    Private Sub AlterarToolStripMenuItem_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        NovoToolStripMenuItem.Enabled = False
        ExcluirToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, False)
        Panel1.Visible = True
        Panel1.Enabled = True
        txtcod.Clear()
        txtcod.Focus()

    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        If txtCliente.Text = "" Then
            txtNomcli.Text = ""
        End If
    End Sub

    Private Sub VerAgendaDoDiaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAgendaDoDiaToolStripMenuItem1.Click
        FrmConAgendamento.telaativa = 1
        FrmConAgendamento.ShowDialog()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        frmexcluiragenda.ShowDialog()
    End Sub
End Class