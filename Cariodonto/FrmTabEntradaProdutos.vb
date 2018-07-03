Public Class FrmTabEntradaProdutos
    Dim novo As Boolean
    Dim objentrada As New ClsTabEntrada
    Dim objproduto As New ClsProdutos
    Dim QTDMIN As Integer
    Dim QTDMAX As Integer
    Dim objcontrole As New ClsControle



    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpro.Click
        FrmConProdutos.Show()

    End Sub

    Private Sub FrmTabEntradaProdutos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            SendKeys.Send("{tab}")

        End If
    End Sub

    Private Sub FrmTabEntradaProdutos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub FrmTabEntradaProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GravarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_tela(Me, False)
        objcontrole.habilitar_botoes(Me, False)
        Panel1.Visible = False
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click

        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, False)
        objcontrole.habilitar_botoes(Me, False)
        Panel1.Visible = True
        GravarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        TxtCodItm.Focus()
        TxtCodItm.Enabled = True
        novo = False
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, True)
        objcontrole.habilitar_botoes(Me, True)
        NovoToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        TxtCodItm.Enabled = False
        novo = True
        TxtcodPro.Focus()


    End Sub
    Private Sub TxtcodPro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtcodPro.KeyPress, TxtCodFor.KeyPress, TxtQtd.KeyPress, TxtCodItm.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub TxtcodPro_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtcodPro.Validated
        If TxtcodPro.Text <> "" Then
            Dim OBJPRO As New ClsProdutos
            If OBJPRO.buscarprodutocodigo(TxtcodPro.Text) = True Then
                Lblpro.Text = OBJPRO.Nome
                QTDMAX = OBJPRO.Quantidade_Maxima
                QTDMIN = OBJPRO.Quantidade_minima
                TxtQtd.Focus()
            Else
                QTDMAX = 0
                QTDMIN = 0
                Lblpro.Text = ""
                TxtcodPro.Clear()
                TxtcodPro.Focus()
            End If
        End If
        TxtCodFor.Focus()
    End Sub

    Private Sub TxtQtd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQtd.Validated
        If TxtcodPro.Text <> "" And TxtQtd.Text <> "" Then
            If TxtQtd.Text > QTDMAX Then
                MsgBox("Quantidade está além do que a quantidade máxima prevista no cadastro do produto que é " & QTDMAX)
                TxtQtd.Clear()
                TxtQtd.Focus()
                'ElseIf TxtQtd.Text < QTDMIN Then
                '    MsgBox("A Quantidade Atual deve estar dentro da quantidade minima que é " & QTDMIN)
                '    TxtQtd.Clear()
                '    TxtQtd.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = objcontrole.PermitirSónumerosVirgula(e.KeyChar)

    End Sub

    Private Sub TxtPre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCodFor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodFor.Validated
        If TxtCodFor.Text <> "" Then
            Dim OBJDTLOCALfor As New DataTable
            Dim OBJfor As New ClsFornecedores
            OBJDTLOCALfor = OBJfor.Localizar_Entrada(TxtCodFor.Text)
            If OBJDTLOCALfor.Rows.Count > 0 Then
                Lblfor.Text = OBJDTLOCALfor.Rows(0).Item("empfor")
            Else
                MessageBox.Show("Fornecedor não cadastrado")
                TxtCodFor.Clear()
                TxtCodFor.Focus()
            End If
        End If
    End Sub
    Private Sub btnfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfor.Click
        FrmConFornecedores2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmConEntrada.Show()
    End Sub

    Private Sub TxtCodItm_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodItm.Validated
        Call mioto()
    End Sub
    Public Sub mioto()
        If TxtCodItm.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim OBJentrada As New ClsTabEntrada
            OBJDTLOCAL = OBJentrada.Localizar3(TxtCodItm.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                TxtcodPro.Text = OBJDTLOCAL.Rows(0).Item("Proitm")
                TxtQtd.Text = OBJDTLOCAL.Rows(0).Item("qtditm")
                TxtCodFor.Text = OBJDTLOCAL.Rows(0).Item("foritm")
                DtpItm.Value = OBJDTLOCAL.Rows(0).Item("datitm")
                Lblpro.Text = OBJDTLOCAL.Rows(0).Item("nompro")
                Lblfor.Text = OBJDTLOCAL.Rows(0).Item("empfor")
                objcontrole.habilitar_botoes(Me, True)
                objcontrole.habilitar_tela(Me, True)
                TxtcodPro.Focus()
                OBJentrada.Codigo = TxtCodItm.Text
            Else
                MessageBox.Show("Codigo da Entrada não cadastrado")
                TxtCodItm.Clear()
                TxtCodItm.Focus()

            End If
        End If
    End Sub
    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.habilitar_tela(Me, False)
        objcontrole.habilitar_botoes(Me, False)
        Lblfor.Text = ""
        Lblpro.Text = ""
        TxtCodItm.Clear()
        AlterarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = True
        Panel1.Visible = False
    End Sub

    Private Sub TxtCodFor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodFor.TextChanged

    End Sub

    Private Sub TxtCodItm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodItm.TextChanged

    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If MessageBox.Show("Deseja Gravar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If objcontrole.Testar_vazio(Me) = True Then
                Exit Sub
            End If

            objentrada.Produto = TxtcodPro.Text
            objentrada.Fornecedor = TxtCodFor.Text
            objentrada.Quantidade = TxtQtd.Text
            objentrada.Data = DtpItm.Text
            If objproduto.Entrar_Estoque(TxtQtd.Text, TxtcodPro.Text) = True Then
                MsgBox("A quantidade atual será maior que a quantidade máxima caso grave o valor " & TxtQtd.Text & " da quantidade atual")
                TxtQtd.Clear()
                TxtQtd.Focus()
            Else
                'objproduto.Entrar_Estoque(TxtQtd.Text, TxtcodPro.Text)
                objentrada.gravar(novo)


                MsgBox("Conteúdo Gravado com sucesso")
                objcontrole.Limpar_tela(Me)
                objcontrole.habilitar_botoes(Me, False)
                objcontrole.habilitar_tela(Me, False)
                NovoToolStripMenuItem.Enabled = True
                AlterarToolStripMenuItem.Enabled = True
                Lblpro.Text = ""
                Lblfor.Text = ""
                DtpItm.Text = Now
                Panel1.Visible = False
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class