Public Class FrmConDespesas
    Dim objcontrole As New ClsControle
    Dim objdespesas As New ClsDespesas
    'Private Sub txtloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtloc.KeyPress
    '    e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    'End Sub

    'Private Sub txtloc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloc.TextChanged
    '    dgdgrade.DataSource = objdespesas.Localizar(txtloc.Text)
    'End Sub
    'Private Sub dgdgrade_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellDoubleClick
    '    Despesas.TxtDesp.Text = dgdgrade.CurrentRow.Cells(0).Value
    '    Despesas.DtpDat.Value = dgdgrade.CurrentRow.Cells(1).Value
    '    Despesas.CboCon.Text = dgdgrade.CurrentRow.Cells(2).Value
    '    If IsDBNull(dgdgrade.CurrentRow.Cells(3).Value) Then
    '        Despesas.TxtHist.Text = ""
    '    Else
    '        Despesas.TxtHist.Text = dgdgrade.CurrentRow.Cells(3).Value
    '    End If
    '    Despesas.TxtVal.Text = dgdgrade.CurrentRow.Cells(4).Value
    '    Me.Close()
    'End Sub

    'Private Sub FrmConDespesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub
End Class
