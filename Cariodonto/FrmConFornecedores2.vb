Public Class FrmConFornecedores2

    Private Sub txtloc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objforn As New ClsFornecedores
        dgdgrade.DataSource = objforn.Localizar_Entrada(txtloc.Text)

    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        FrmTabEntradaProdutos.TxtCodFor.Text = dgdgrade.CurrentRow.Cells(0).Value
        FrmTabEntradaProdutos.TxtCodFor.Focus()
        Me.Close()
    End Sub
End Class