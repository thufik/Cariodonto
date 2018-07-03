Public Class FrmControle
    Dim sql As String
    Dim objpesquisar As New DataTable
    Dim objtipo As New ClsTipo

    Private Sub FrmControle_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        DataGridView1.Visible = False
    End Sub
    Private Sub FrmControle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from funcionarios"
        Dim objfun As New ClsTipo()
        CboFun.DisplayMember = "nomfun"
        CboFun.ValueMember = "codfun"
        CboFun.DataSource = objfun.POPULAR_2(sql)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objpesquisar = objtipo.POPULAR_comStored5(CboFun.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text)
        If objpesquisar.Rows.Count > 0 Then
            DataGridView1.DataSource = objpesquisar
            DataGridView1.Visible = True
        Else
            MsgBox("Não localizado")
            DataGridView1.Visible = False
        End If
    End Sub
End Class