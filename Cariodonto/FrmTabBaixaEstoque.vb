Public Class FrmTabBaixaEstoque
    Dim objproduto As New ClsProdutos
    Dim objbaixa As New ClsTabBaixa
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Dim QTDATU As Integer
    Dim qtdmin As Integer
    Dim qtdatual As Integer


    Private Sub FrmTabBaixaEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_tela(Me, False)
        objcontrole.habilitar_botoes(Me, False)
        Panel1.Visible = False
    End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGra.Click
    '    If objcontrole.Testar_vazio(Me) = True Then
    '        txtCodP.Focus()
    '        Exit Sub
    '    End If
    '    objbaixa.CodProduto = txtCodP.Text
    '    objbaixa.Quantidade = txtqtd.Text
    '    objbaixa.Data = DtpBaixa.Text
    '    objbaixa.CodFuncionario = txtCodFun.Text
    '    objbaixa.gravar(novo)
    '    objproduto.Baixar_Estoque(txtqtd.Text, txtCodP.Text)
    '    MsgBox("Gravado com sucesso!")
    '    objcontrole.habilitar_botoes(Me, False)
    '    objcontrole.habilitar_tela(Me, False)
    '    AlterarToolStripMenuItem.Enabled = True
    '    NovoToolStripMenuItem.Enabled = True
    '    GravarToolStripMenuItem.Enabled = False

    'End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConProdutos.Show()
    End Sub


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        objcontrole.habilitar_tela(Me, True)
        objcontrole.habilitar_botoes(Me, True)
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        objcontrole.Limpar_tela(Me)
        Panel1.Visible = False
        txtCodP.Focus()

    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_botoes(Me, True)
        objcontrole.habilitar_tela(Me, True)
        Panel1.Visible = True
        Panel1.Enabled = True
        txtCodB.Focus()
    End Sub

    Private Sub btnbai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbai.Click
        FrmConBaixa.Show()

    End Sub
    Private Sub txtCodP_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodP.Validated
        If txtCodP.Text <> "" Then
            Dim OBJPRO As New ClsProdutos
            If OBJPRO.buscarprodutocodigo(txtCodP.Text) = True Then
                Lblpro.Text = OBJPRO.Nome
                QTDATU = OBJPRO.Quantidade_Atual
                txtqtd.Focus()
            Else
                QTDATU = 0
                Lblpro.Text = ""
                MsgBox("Codigo não encontrado")
                txtCodP.Clear()
                txtCodP.Focus()
            End If
        End If
    End Sub
    Private Sub txtqtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqtd.KeyPress, txtCodB.KeyPress, txtCodP.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub txtqtd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqtd.Validated
        If txtCodP.Text <> "" And txtqtd.Text <> "" Then
            If txtqtd.Text > QTDATU Then
                MsgBox("A quantidade retirada deve ser menor ou igual a quantidade atual que é " & QTDATU)
                txtqtd.Clear()
                txtqtd.Focus()
                'ElseIf TxtQtd.Text < QTDMIN Then
                '    MsgBox("A Quantidade Atual deve estar dentro da quantidade minima que é " & QTDMIN)
                '    TxtQtd.Clear()
                '    TxtQtd.Focus()
            End If
        End If
    End Sub
    Private Sub txtCodB_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodB.Validated
        Call ChamarBD()
    End Sub
    Public Sub ChamarBD()
        If txtCodB.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim OBJBaixa As New ClsTabBaixa
            OBJDTLOCAL = OBJBaixa.Localizar2(txtCodB.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                txtCodP.Text = OBJDTLOCAL.Rows(0).Item("codpro")
                txtqtd.Text = OBJDTLOCAL.Rows(0).Item("qtdbai")
                DtpBaixa.Text = OBJDTLOCAL.Rows(0).Item("datbai")
                objcontrole.habilitar_botoes(Me, True)
                objcontrole.habilitar_tela(Me, True)
                txtCodP.Focus()
                OBJBaixa.Codigo = txtCodB.Text
                objproduto.EntrarAlt(txtqtd.Text, txtCodB.Text)
            Else
                MessageBox.Show("Codigo da Entrada não cadastrado")
                txtCodB.Clear()
                txtCodB.Focus()
            End If
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        objcontrole.habilitar_botoes(Me, False)
        objcontrole.habilitar_tela(Me, False)
        objcontrole.Limpar_tela(Me)
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        Panel1.Enabled = False
        Panel1.Visible = False
        Lblpro.Text = ""
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click

        If MessageBox.Show("Deseja Gravar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If objcontrole.Testar_vazio(Me) = True Then
                txtCodP.Focus()
                Exit Sub
            End If
            objbaixa.CodProduto = txtCodP.Text
            objbaixa.Quantidade = txtqtd.Text
            objbaixa.Data = DtpBaixa.Text
            objbaixa.CodFuncionario = MenuInicial.Label1.Text()
            objbaixa.gravar(novo)
            objproduto.Baixar_Estoque(txtqtd.Text, txtCodP.Text)
            Dim objteste As New DataTable
            objteste = objproduto.pesquisar_qtd(txtCodP.Text)
            If objteste.Rows.Count > 0 Then
                dgdgrade.DataSource = objteste
                qtdmin = dgdgrade.Rows(0).Cells(3).Value
                qtdatual = dgdgrade.Rows(0).Cells(2).Value
                MsgBox("Gravado com sucesso!")
            Else
                MsgBox("Xabu")
                Exit Sub
            End If

            If qtdmin > qtdatual Then
                If MessageBox.Show("Quantidade atual está menor que a quantidade minima. Deseja avisar o fornecedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    FrmEmail.ShowDialog()
                    objcontrole.habilitar_botoes(Me, False)
                    objcontrole.habilitar_tela(Me, False)
                    AlterarToolStripMenuItem.Enabled = False
                    NovoToolStripMenuItem.Enabled = True
                    GravarToolStripMenuItem.Enabled = False
                Else
                    objcontrole.habilitar_botoes(Me, False)
                    objcontrole.habilitar_tela(Me, False)
                    AlterarToolStripMenuItem.Enabled = False
                    NovoToolStripMenuItem.Enabled = True
                    GravarToolStripMenuItem.Enabled = False
                End If
            Else
                objcontrole.habilitar_botoes(Me, False)
                objcontrole.habilitar_tela(Me, False)
                AlterarToolStripMenuItem.Enabled = False
                NovoToolStripMenuItem.Enabled = True
                GravarToolStripMenuItem.Enabled = False
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class