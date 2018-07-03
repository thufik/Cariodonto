Public Class FrmConCliOdo
    Dim objcliente As New ClsCliente

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgdgrade.DataSource = objcliente.Localizar(TextBox1.Text)
    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Odontograma.TxtCli.Text = dgdgrade.CurrentRow.Cells(0).Value
        Odontograma.LblCli.Text = dgdgrade.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub

End Class