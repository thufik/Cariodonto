Public Class FrmConAgendamento
    Dim objagendamento As New ClsTipo
    Dim sql As String
    Dim objagen As New ClsTipo
    Dim objcontrole As New ClsControle
    Dim objteste As New DataTable
    Public telaativa As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'dgdgrade.DataSource = Nothing
        ' sql = "SELECT Agendamento.CodAge, Agendamento.CliAge, Agendamento.ConAge, Agendamento.CodProf, Clientes.NomCli, Funcionarios.NomFun, TabTipoConsulta.DesCon, Clientes.TelCli, Agendamento.DatAge, Agendamento.HorIni, Agendamento.HorFim" & _
        '" FROM 'TabTipoConsulta INNER JOIN (Clientes INNER JOIN (Funcionarios INNER JOIN Agendamento ON Funcionarios.CodFun = Agendamento.CodProf) ON Clientes.CodCli = Agendamento.CliAge) ON TabTipoConsulta.CodCon = Agendamento.ConAge where codfun =" & CboFun.SelectedValue & " and datage =#" & DateTimePicker1.Text & "#"
        objteste = objagen.POPULAR_comStored(CboFun.SelectedValue, DateTimePicker1.Text)
        If objteste.Rows.Count > 0 Then
            dgdgrade.DataSource = objteste
            dgdgrade.Visible = True
        Else
            MsgBox("Não localizado")
        End If
    End Sub

    Private Sub FrmConAgendamento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dgdgrade.Visible = False

    End Sub

   

    Private Sub FrmConAgendamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from funcionarios where codfun > 1"
        Dim objfun As New ClsTipo()
        CboFun.DisplayMember = "nomfun"
        CboFun.ValueMember = "codfun"
        CboFun.DataSource = objfun.POPULAR_2(sql)
        If telaativa = 1 Then
            dgdgrade.Enabled = False
        ElseIf telaativa = 2 Then
            dgdgrade.Enabled = True
        End If
    End Sub

    Private Sub dgdgrade_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentDoubleClick
        ' Agenda.txtcod.Text = dgdgrade.CurrentRow.Cells(0).Value
        'Agenda.txtCliente.Text = dgdgrade.CurrentRow.Cells(1).Value
        frmexcluiragenda.cbofun.SelectedValue = CboFun.SelectedValue
        'Agenda.Cbocod.SelectedValue = dgdgrade.CurrentRow.Cells(2).Value
        frmexcluiragenda.DateTimePicker1.Text = DateTimePicker1.Text
        frmexcluiragenda.DateTimePicker2.Text = dgdgrade.CurrentRow.Cells(0).Value
        frmexcluiragenda.DateTimePicker3.Text = dgdgrade.CurrentRow.Cells(1).Value
        'Agenda.txtNomcli.Text = dgdgrade.CurrentRow.Cells(4).Value
        'Agenda.Panel1.Enabled = False
        ' CboFun.SelectedIndex = 0
        'dgdgrade.DataSource = Nothing
        objcontrole.habilitar_tela(frmexcluiragenda.Panel1, True)
        Me.Close()
    End Sub

    Private Sub dgdgrade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdgrade.CellContentClick

    End Sub
End Class