Public Class frmAniversariantes
    Dim objtipo As New ClsTipo
    Dim aniversario As String
    Private Sub frmAniversariantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = objtipo.POPULAR_comStored6(MenuInicial.lbldata.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        aniversario = "Olá," & DataGridView1.CurrentRow.Cells(1).Value & vbNewLine & "Nós do consultório odontológico estamos lhe enviando esse email para lhe desejar um feliz aniversário. Também gostaríamos de parabenizá-lo por ser um de nossos clientes. Gostaríamos de esse mês lhe dar um desconto para um de nossos tratamentos. Como por exemplo limpeza. Daremos 20% de desconto como forma de carinho e presente por essa data tão especial. Afinal, 'a saúde começa pela boca'." & _
 vbNewLine & vbNewLine & "Obrigado e Parabéns!"
        FrmEmail.txtcorpo.Text = aniversario
        FrmEmail.txtdestino.Text = DataGridView1.CurrentRow.Cells(4).Value
        FrmEmail.txtassunto.Text = "Feliz Aniversário"
        FrmEmail.ShowDialog()

    End Sub
End Class