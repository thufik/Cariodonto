Public Class FrmConBaixa

    Private Sub FrmConBaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim objcontrole As New ClsControle
    Dim objbaixa As New ClsTabBaixa

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

        dgdgrade.DataSource = objbaixa.Localizar2(Txtloc.Text)

    End Sub

    Private Sub DtpDat_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        ' dgdgrade.DataSource = objentrada.Localizar(DtpDat.Value)
    End Sub

    Private Sub DtpDat_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        FrmTabBaixaEstoque.txtCodB.Text = dgdgrade.CurrentRow.Cells(0).Value
        FrmTabBaixaEstoque.txtCodB.Focus()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpt As New CrpBaixa
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        FrmImp.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpt As New CrpGraBaixa
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        FrmImp.ShowDialog()
    End Sub
End Class