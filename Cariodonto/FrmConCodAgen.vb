Public Class FrmConCodAgen
    Dim objpesquisa As New ClsCliente
    Dim objcontrole As New ClsControle
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DgDgrade.DataSource = objpesquisa.Localizar2(TextBox1.Text)
    End Sub
    Private Sub DgDgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgDgrade.CellContentDoubleClick
        Agenda.txtcod.Text = DgDgrade.CurrentRow.Cells(0).Value
        Agenda.txtCliente.Text = DgDgrade.CurrentRow.Cells(1).Value
        Agenda.txtNomcli.Text = DgDgrade.CurrentRow.Cells(2).Value
        Agenda.CboProf.SelectedValue = DgDgrade.CurrentRow.Cells(3).Value
        Agenda.Cbocod.SelectedValue = DgDgrade.CurrentRow.Cells(5).Value
        Agenda.DateTimePicker1.Value = DgDgrade.CurrentRow.Cells(4).Value
        Agenda.DateTimePicker2.Value = DgDgrade.CurrentRow.Cells(6).Value
        Agenda.DateTimePicker3.Value = DgDgrade.CurrentRow.Cells(7).Value
        TextBox1.Text = ""
        DgDgrade.DataSource = Nothing
        objcontrole.habilitar_tela(Agenda, True)
        Agenda.Panel1.Enabled = False
        Agenda.GravarToolStripMenuItem.Enabled = True
        Agenda.AlterarToolStripMenuItem.Enabled = False
        Me.Close()
    End Sub
    Private Sub FrmConCodAgen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TextBox1.Text = ""
    End Sub
    Private Sub FrmConCodAgen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub
End Class