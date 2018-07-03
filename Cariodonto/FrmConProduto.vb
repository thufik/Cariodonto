Public Class FrmConProdutos
    Dim objpro As New ClsProdutos
    Private Sub txtloc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub FrmConProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Consulta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtloc_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloc.TextChanged
        dgdgrade.DataSource = objpro.Localizar(txtloc.Text)
    End Sub

    Private Sub dgdgrade_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick

        If Produtos.telaativa = 2 Then
            Produtos.TxtCod.Text = dgdgrade.CurrentRow.Cells(0).Value
            Produtos.txtNom.Text = dgdgrade.CurrentRow.Cells(1).Value
            Produtos.txtAtu.Text = dgdgrade.CurrentRow.Cells(2).Value
            Produtos.txtMin.Text = dgdgrade.CurrentRow.Cells(3).Value
            Produtos.txtMax.Text = dgdgrade.CurrentRow.Cells(4).Value
        Else
            FrmTabEntradaProdutos.TxtcodPro.Text = dgdgrade.CurrentRow.Cells(0).Value
            FrmTabEntradaProdutos.Lblpro.Text = dgdgrade.CurrentRow.Cells(1).Value
            FrmTabEntradaProdutos.TxtcodPro.Focus()
        End If

        Me.Close()
    End Sub
End Class