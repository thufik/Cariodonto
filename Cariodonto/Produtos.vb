Public Class Produtos
    Dim objproduto As New ClsProdutos
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Public telaativa As Integer

    Private Sub Produtos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GravarToolStripMenuItem.Enabled = False
        Panel1.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        telaativa = 0
    End Sub
    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        Panel1.Enabled = True
        TxtCod.Enabled = False
        BtnPro.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        txtNom.Focus()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        Panel1.Enabled = True
        TxtCod.Enabled = True
        BtnPro.Enabled = True
        objcontrole.Limpar_tela(Me.Panel1)
        TxtCod.Focus()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        Panel1.Enabled = False
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click

        objproduto.Nome = txtNom.Text
        objproduto.Quantidade_Atual = txtAtu.Text
        objproduto.Quantidade_Maxima = txtMax.Text
        objproduto.Quantidade_minima = txtMin.Text
        objproduto.gravar(novo)
        MsgBox("Gravado com sucesso")

        objcontrole.Limpar_tela(Me.Panel1)
        Panel1.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub TxtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCod.KeyPress, txtAtu.KeyPress, txtMax.KeyPress, txtMin.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub
    Private Sub TxtCod_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCod.Validated
        If TxtCod.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim OBJRec As New ClsProdutos
            OBJDTLOCAL = OBJRec.Localizar(TxtCod.Text)

            If OBJDTLOCAL.Rows.Count > 0 Then
                txtNom.Text = OBJDTLOCAL.Rows(0).Item("nompro")
                txtAtu.Text = OBJDTLOCAL.Rows(0).Item("qtdatual")
                txtMax.Text = OBJDTLOCAL.Rows(0).Item("qtdmax")
                txtMin.Text = OBJDTLOCAL.Rows(0).Item("qtdmin")
                txtNom.Focus()
                objproduto.Codigo = TxtCod.Text
            Else
                MessageBox.Show("Codigo não cadastrado")
                TxtCod.Clear()
                TxtCod.Focus()
            End If
        End If
    End Sub
    Private Sub txtMax_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMax.Validated
        If Val(txtAtu.Text) > Val(txtMax.Text) Then
            MsgBox("Quantidade atual é maior que a quantidade maxima permitida")
            txtMax.Clear()
            txtMax.Focus()
        End If
    End Sub

    Private Sub BtnPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPro.Click
        telaativa = 2

        FrmConProdutos.ShowDialog()
    End Sub
End Class