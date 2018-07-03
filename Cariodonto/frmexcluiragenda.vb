Public Class frmexcluiragenda
    Dim sql As String
    Dim objtipo As New ClsTipo
    Dim objteste As New DataTable
    Dim objagenda As New ClsAgendamento
    Dim objcontrole As New ClsControle
    Private Sub frmexcluiragenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from funcionarios where codfun > 1"
        Dim objfun As New ClsTipo()
        cbofun.DisplayMember = "nomfun"
        cbofun.ValueMember = "codfun"
        cbofun.DataSource = objfun.POPULAR_2(sql)
        OkToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = False
        Panel1.Enabled = True
    End Sub


    Private Sub OkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkToolStripMenuItem.Click
        objteste = objtipo.POPULAR_comStored4(cbofun.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text)
        If objteste.Rows.Count > 0 Then
            dgdgrade.DataSource = objtipo.POPULAR_comStored4(cbofun.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text)
            OkToolStripMenuItem.Enabled = False
            ExcluirToolStripMenuItem.Enabled = True
            Panel1.Enabled = False
            dgdgrade.Visible = True
        Else
            MsgBox("não encontrado")
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        objcontrole.Limpar_tela(Me.Panel1)
        ExcluirToolStripMenuItem.Enabled = False
        OkToolStripMenuItem.Enabled = True
        Panel1.Enabled = True
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        objagenda.Excluir(dgdgrade.CurrentRow.Cells(0).Value)
        OkToolStripMenuItem.Enabled = True
        ExcluirToolStripMenuItem.Enabled = False
        dgdgrade.Visible = False
        Panel1.Enabled = True
    End Sub

    Private Sub PesquisarAgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesquisarAgendaToolStripMenuItem.Click
        FrmConAgendamento.telaativa = 2
        FrmConAgendamento.ShowDialog()
    End Sub
End Class