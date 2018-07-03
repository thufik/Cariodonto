Public Class FrmConReceitas
    Dim objrec As New ClsReceita
    Private Sub txtloc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloc.TextChanged
        dgdgrade.DataSource = objrec.Localizar(txtloc.Text)
    End Sub
    Private Sub dgdgrade_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellDoubleClick
        Receita.TxtRec.Text = dgdgrade.CurrentRow.Cells(0).Value
        Receita.DtpDat.Value = dgdgrade.CurrentRow.Cells(1).Value
        Receita.CboCon.SelectedValue = dgdgrade.CurrentRow.Cells(2).Value
        If IsDBNull(dgdgrade.CurrentRow.Cells(3).Value) Then
            Receita.txtHist.Text = ""
        Else
            Receita.txtHist.Text = dgdgrade.CurrentRow.Cells(3).Value
        End If
        Receita.TxtVal.Text = dgdgrade.CurrentRow.Cells(4).Value
        Receita.TxtCli.Text = dgdgrade.CurrentRow.Cells(6).Value
        Me.Close()
    End Sub

    Private Sub FrmConReceitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDatIniFin.ShowDialog()
    End Sub
End Class