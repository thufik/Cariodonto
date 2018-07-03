Public Class frmListatel
    Public telaativa As Integer
    Dim objfun As New ClsFuncionarios
    Dim objcli As New ClsCliente
    Dim objlocalizar As New DataTable

    Private Sub frmListatel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtPesquisar.Text = ""
        DataGridView1.Visible = False
    End Sub
    Private Sub txtPesquisar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisar.TextChanged
        If telaativa = 1 Then
            objlocalizar = objfun.pesquisar_telefone(txtPesquisar.Text)
            If objlocalizar.Rows.Count > 0 Then
                DataGridView1.DataSource = objlocalizar
                DataGridView1.Visible = True
            Else
                DataGridView1.Visible = False
            End If
        ElseIf telaativa = 2 Then
            objlocalizar = objcli.pesquisar_telefone(txtPesquisar.Text)
            If objlocalizar.Rows.Count > 0 Then
                DataGridView1.DataSource = objlocalizar
                DataGridView1.Visible = True
            Else
                DataGridView1.Visible = False
            End If
        End If

    End Sub

    Private Sub frmListatel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class