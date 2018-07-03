Public Class FrmConCliente
    Dim sql As String
    Dim objpesquisa As New ClsTipo
    Public TelaAtiva As Integer
    Dim objcontrole As New ClsControle
    Dim objcliente As New ClsCliente

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TelaAtiva = 1 Or TelaAtiva = 2 Then

            sql = "SELECT CODCLI,NOMCLI,TELCLI FROM CLIENTES where nomcli like '" & TextBox1.Text & "%'"
            dgdgrade.DataSource = objpesquisa.POPULAR_2(sql)
        ElseIf TelaAtiva = 3 Then
            dgdgrade.DataSource = objcliente.Localizar(TextBox1.Text)
        End If
    End Sub

    Private Sub dgdgrade_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
     
    End Sub

    Private Sub FrmConCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TelaAtiva = 1 Or TelaAtiva = 2 Then

            sql = "SELECT CODCLI,NOMCLI,TELCLI FROM CLIENTES where nomcli like '" & TextBox1.Text & "%'"
            dgdgrade.DataSource = objpesquisa.POPULAR_2(sql)
        ElseIf TelaAtiva = 3 Then
            dgdgrade.DataSource = objcliente.Localizar(TextBox1.Text)
        End If
    End Sub

    Private Sub dgdgrade_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        If TelaAtiva = 1 Then
            Agenda.txtCliente.Text = dgdgrade.CurrentRow.Cells(0).Value
            Agenda.txtNomcli.Text = dgdgrade.CurrentRow.Cells(1).Value
            Agenda.txtCliente.Focus()
        ElseIf TelaAtiva = 2 Then
            Dim objlocalizar As New DataTable
            Dim objanamnese As New ClsAnamnese
            objlocalizar = objanamnese.localizaranamnese(dgdgrade.CurrentRow.Cells(0).Value)
            If Anamnese.novo = True Then
                If objlocalizar.Rows.Count > 0 Then
                    MsgBox("código ja cadastrado na anamnese")
                    TextBox1.Clear()
                    Me.Close()
                    Exit Sub
                End If
                Anamnese.txtcod.Text = dgdgrade.CurrentRow.Cells(0).Value
                Anamnese.txtCliente.Text = dgdgrade.CurrentRow.Cells(1).Value
                Anamnese.Panel1.Enabled = False
                Anamnese.paneldois.Enabled = True
                Anamnese.Pndoenqual.Enabled = True
                Anamnese.Rdo1sim.Checked = True
                Anamnese.txtDoenQual.Enabled = True
                Anamnese.txtDoenQual.Select()
                Anamnese.paneldois.Visible = True
                Anamnese.NovoToolStripMenuItem.Enabled = False
            Else
                Anamnese.txtcod.Text = dgdgrade.CurrentRow.Cells(0).Value
                Anamnese.txtCliente.Text = dgdgrade.CurrentRow.Cells(1).Value
                Dim objlocalizar1 = objanamnese.localizaranamnese(dgdgrade.CurrentRow.Cells(0).Value)
                Anamnese.GravarToolStripMenuItem1.Enabled = True
                Anamnese.Panel1.Enabled = False
                Anamnese.paneldois.Visible = True
                Anamnese.paneldois.Enabled = True
                Anamnese.pnalergia.Enabled = True
                Anamnese.pncica.Enabled = True
                Anamnese.pndiab.Enabled = True
                Anamnese.Pndoenqual.Enabled = True
                Anamnese.pnFebReu.Enabled = True
                Anamnese.pnhip.Enabled = True
                Anamnese.pnoper.Enabled = True
                Anamnese.pnprobaler.Enabled = True
                Anamnese.pnprobanes.Enabled = True
                Anamnese.pnprobartreu.Enabled = True
                Anamnese.pnprobcar.Enabled = True
                Anamnese.pnprobgas.Enabled = True
                Anamnese.pnprobhemo.Enabled = True
                Anamnese.pnprobren.Enabled = True
                Anamnese.pnprobres.Enabled = True
                Anamnese.TxtOperacao.Enabled = True
                Anamnese.txtDoenQual.Enabled = True
                Anamnese.txtDescri.Enabled = True
                Anamnese.TxtObsimport.Enabled = True
                Anamnese.txtAlerQual.Enabled = True
                If objlocalizar1.Rows(0).Item("doeatusn") = True Then
                    Anamnese.Rdo1sim.Checked = True
                Else
                    Anamnese.rdo1nao.Checked = True
                    Anamnese.txtDoenQual.Enabled = False
                End If
                Anamnese.txtDoenQual.Text = objlocalizar1.Rows(0).Item("DoeAtuQ")
                If objlocalizar1.Rows(0).Item("alersn") = True Then
                    Anamnese.Rdo2sim.Checked = True
                Else
                    Anamnese.rdo2nao.Checked = True
                    Anamnese.txtAlerQual.Enabled = False
                End If
                Anamnese.txtAlerQual.Text = objlocalizar1.Rows(0).Item("alerq")
                If objlocalizar1.Rows(0).Item("opesn") = True Then
                    Anamnese.Rdo3sim.Checked = True
                Else
                    Anamnese.rdo3nao.Checked = True
                    Anamnese.TxtOperacao.Enabled = False
                End If
                Anamnese.TxtOperacao.Text = objlocalizar1.Rows(0).Item("opeq")
                If objlocalizar1.Rows(0).Item("cicasn") = True Then
                    Anamnese.rdo4sim.Checked = True
                Else
                    Anamnese.rdo4nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("anessn") = True Then
                    Anamnese.Rdo5sim.Checked = True
                Else
                    Anamnese.rdo5nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("hemosn") = True Then
                    Anamnese.Rdo6sim.Checked = True
                Else
                    Anamnese.rdo6nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("febreu") = True Then
                    Anamnese.Rdo7sim.Checked = True
                Else
                    Anamnese.rdo7nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probren") = True Then
                    Anamnese.rdo8sim.Checked = True
                Else
                    Anamnese.rdo8nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probgas") = True Then
                    Anamnese.Rdo9sim.Checked = True
                Else
                    Anamnese.rdo9nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probcar") = True Then
                    Anamnese.Rdo10sim.Checked = True
                Else
                    Anamnese.rdo10nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probres") = True Then
                    Anamnese.Rdo11sim.Checked = True
                Else
                    Anamnese.rdo11nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probale") = True Then
                    Anamnese.Rdo12sim.Checked = True
                Else
                    Anamnese.rdo12nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probar") = True Then
                    Anamnese.Rdo13sim.Checked = True
                Else
                    Anamnese.rdo13nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("probdia") = True Then
                    Anamnese.Rdo14sim.Checked = True
                Else
                    Anamnese.rdo14nao.Checked = True
                End If
                If objlocalizar1.Rows(0).Item("hipart") = True Then
                    Anamnese.Rdo15sim.Checked = True
                Else
                    Anamnese.rdo15nao.Checked = True
                End If
            End If
        End If
        TelaAtiva = 0
        TextBox1.Text = ""
        Me.Close()
    End Sub
End Class