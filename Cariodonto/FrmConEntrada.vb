Public Class FrmConEntrada
    Dim objcontrole As New ClsControle
    Dim objentrada As New ClsTabEntrada

    Private Sub FrmConEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objcontrole.habilitar_tela(Me, False)

    End Sub

    Private Sub RdbCod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbCod.CheckedChanged
        If RdbCod.Checked = True Then
            Txtloc.Enabled = True
        Else : Txtloc.Enabled = False
        End If
    End Sub
    Private Sub Txtloc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtloc.TextChanged
        For x = 1 To Len(Txtloc.Text)
            If IsNumeric(Mid(Txtloc.Text, x, 1)) Then
                MsgBox("Só é permitido a entrada de produtos por nome")
                Txtloc.Clear()
                Txtloc.Focus()
            Else
                dgdgrade.DataSource = objentrada.Localizar2(Txtloc.Text)
            End If
        Next
    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        FrmTabEntradaProdutos.TxtCodItm.Text = dgdgrade.CurrentRow.Cells(0).Value
        FrmTabEntradaProdutos.mioto()
        FrmTabEntradaProdutos.TxtcodPro.Focus()
        Me.Close()

    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub
End Class