Public Class FrmConCliRec
    Dim sql As String
    Dim objcliente As New ClsCliente

    Private Sub Consulta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmConCliRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgdgrade.DataSource = objcliente.Localizar(TextBox1.Text)
    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Receita.TxtCli.Text = dgdgrade.CurrentRow.Cells(0).Value
        Receita.LblCli.Text = dgdgrade.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class