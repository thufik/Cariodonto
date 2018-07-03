Public Class FrmConFuncionário
    Public telaativa As Integer
    Dim objfun As New ClsFuncionarios
    Dim variavel As Integer
    Dim objcontrole As New ClsControle
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFun.TextChanged
        Dim objfunc As New ClsFuncionarios
        dgdgrade.DataSource = objfunc.Localizar(txtFun.Text)

    End Sub
    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        If telaativa = 1 Then
            'FrmTabBaixaEstoque.txtCodFun.Text = dgdgrade.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf telaativa = 2 Then
            CadastroFuncionario.txtcod.Text = dgdgrade.CurrentRow.Cells(0).Value
            CadastroFuncionario.cbbSexFun.Text = dgdgrade.CurrentRow.Cells(10).Value
            CadastroFuncionario.DateTimePicker1.Text = dgdgrade.CurrentRow.Cells(5).Value
            CadastroFuncionario.txtTelFun.Text = dgdgrade.CurrentRow.Cells(11).Value
            CadastroFuncionario.txtNomFun.Text = dgdgrade.CurrentRow.Cells(1).Value
            Dim objpesquisa = objfun.pesquisar_funcionario(dgdgrade.CurrentRow.Cells(0).Value)
            Dim endereco = objpesquisa.Rows(0).Item("endfun")
            For x = 1 To Len(endereco)
                If IsNumeric(Mid(endereco, x, 1)) = True Then
                    variavel = x
                    Exit For
                Else
                    CadastroFuncionario.txtEndFun.Text &= Mid(endereco, x, 1)
                End If
            Next
            For y = variavel To Len(endereco)
                If Mid(endereco, y, 1) = " " Then
                    variavel = y
                    For z = variavel To Len(endereco)
                        CadastroFuncionario.txtComFun.Text &= Mid(endereco, z, 1)
                    Next
                    Exit For

                Else
                    CadastroFuncionario.txtNunFun.Text &= Mid(endereco, y, 1)
                End If
            Next
            CadastroFuncionario.cbbEspFun.Text = dgdgrade.CurrentRow.Cells(2).Value
            If CadastroFuncionario.cbbEspFun.Text = "Secretária(o)" Then
                CadastroFuncionario.txtCroFun.Enabled = False
            Else
                CadastroFuncionario.txtCroFun.Enabled = True
            End If
            CadastroFuncionario.DateTimePicker2.Text = dgdgrade.CurrentRow.Cells(9).Value
            CadastroFuncionario.DateTimePicker3.Text = dgdgrade.CurrentRow.Cells(4).Value
            CadastroFuncionario.txtSalFun.Text = dgdgrade.CurrentRow.Cells(3).Value
            CadastroFuncionario.txtCroFun.Text = dgdgrade.CurrentRow.Cells(13).Value
            CadastroFuncionario.txtEmaFun.Text = dgdgrade.CurrentRow.Cells(12).Value
            CadastroFuncionario.lblCurriculo.Text = dgdgrade.CurrentRow.Cells(6).Value
            CadastroFuncionario.Picfoto.ImageLocation = dgdgrade.CurrentRow.Cells(14).Value
            objcontrole.habilitar_tela(CadastroFuncionario.Panel2, True)
            CadastroFuncionario.Panel2.Visible = True
            CadastroFuncionario.Panel2.Enabled = True
            objcontrole.habilitar_tela(CadastroFuncionario.Panel1, False)
            CadastroFuncionario.NovoToolStripMenuItem.Enabled = False
            CadastroFuncionario.GravarToolStripMenuItem.Enabled = True
            CadastroFuncionario.AlterarToolStripMenuItem.Enabled = False
            Me.Close()
        ElseIf telaativa = 3 Then
            FrmCadastroLogin.txtcod.Text = dgdgrade.CurrentRow.Cells(0).Value
            FrmCadastroLogin.txtNomfun.Text = dgdgrade.CurrentRow.Cells(1).Value
            Me.Close()
        End If

    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub

    Private Sub FrmConFuncionário_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFun.Select()
    End Sub
End Class