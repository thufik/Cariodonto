Public Class FrmCurriculum

    Private Sub FrmCurriculum_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CadastroFuncionario.lblCurriculo.Text = CadastroFuncionario.OpenFileDialog2.FileName
        AxAcroPDF1.LoadFile(Nothing)
        CadastroFuncionario.OpenFileDialog2.Reset()
        MsgBox("Curriculum carregado com sucesso")
    End Sub

    Private Sub FrmCurriculum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AxAcroPDF1_OnError(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxAcroPDF1.OnError

    End Sub
End Class