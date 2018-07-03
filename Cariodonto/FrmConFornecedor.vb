Public Class FrmConFornecedor
    Dim objfornecedor As New ClsFornecedores
    Dim objfor As New ClsFornecedores
    Dim variavel
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomfor.TextChanged
        dgdgrade.DataSource = objfornecedor.pesquisar_fornecedor(txtnomfor.Text)
    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        CadastroFornecedor.txtnomefor.Text = dgdgrade.CurrentRow.Cells(1).Value
        Dim objpesquisa = objfor.pesquisar_fornecedor(dgdgrade.CurrentRow.Cells(0).Value)
        Dim endereco = objpesquisa.Rows(0).Item("endfor")
        For x = 1 To Len(endereco)
            If IsNumeric(Mid(endereco, x, 1)) = True Then
                variavel = x
                Exit For
            Else
                CadastroFornecedor.txtendefor.Text &= Mid(endereco, x, 1)
            End If
        Next
        For y = variavel To Len(endereco)
            If Mid(endereco, y, 1) = " " Then
                variavel = y
                For z = variavel To Len(endereco)
                    CadastroFornecedor.txtcomfor.Text &= Mid(endereco, z, 1)
                Next
                Exit For

            Else
                CadastroFornecedor.txtnumfor.Text &= Mid(endereco, y, 1)
            End If
        Next
        CadastroFornecedor.txttel.Text = dgdgrade.CurrentRow.Cells(3).Value
        CadastroFornecedor.txtemafor.Text = dgdgrade.CurrentRow.Cells(4).Value
        Dim objpesquisa2 As New DataTable
        objpesquisa2 = objfor.pesquisa_uff(dgdgrade.CurrentRow.Cells(5).Value)
        CadastroFornecedor.cboUfFor.SelectedValue = objpesquisa2.Rows(0).Item("id")
        txtnomfor.Text = ""
        Me.Close()
        CadastroFornecedor.Panel2.Visible = True
        CadastroFornecedor.Panel2.Enabled = True
        CadastroFornecedor.Panel1.Enabled = False
        CadastroFornecedor.GravarToolStripMenuItem.Enabled = True
        CadastroFornecedor.AlterarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub FrmConFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnomfor.Focus()
    End Sub
End Class