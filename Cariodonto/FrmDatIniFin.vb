Public Class FrmDatIniFin
    Dim objbanco As New ClsBanco

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rpt As New CrpBalanço
        rpt.ParameterFields(0).CurrentValues.AddValue(dtpini.Value)
        rpt.ParameterFields(1).CurrentValues.AddValue(dtpfin.Value)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        FrmImp.ShowDialog()
        Me.Close()
    End Sub
End Class