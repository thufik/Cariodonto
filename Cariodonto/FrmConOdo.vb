Public Class FrmConOdo

    Dim objodontograma As New ClsOdontograma

    Private Sub textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgdgrade.DataSource = objodontograma.Localizar(TextBox1.Text)
    End Sub
    Private Sub dgdgrade_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Odontograma.TxtOdo.Text = dgdgrade.CurrentRow.Cells(0).Value
        Odontograma.TxtCli.Text = dgdgrade.CurrentRow.Cells(1).Value
        Odontograma.txtDen.Text = dgdgrade.CurrentRow.Cells(2).Value
        Odontograma.CboTra.SelectedValue = dgdgrade.CurrentRow.Cells(3).Value
        Odontograma.TxtVal.Text = dgdgrade.CurrentRow.Cells(4).Value
        If IsDBNull(dgdgrade.CurrentRow.Cells(5).Value) Then
            Odontograma.TxtObs.Text = ""
        Else
            Odontograma.TxtObs.Text = dgdgrade.CurrentRow.Cells(5).Value
        End If
        Me.Close()
    End Sub

End Class