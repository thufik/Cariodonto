Public Class Login
    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objpesquisar As DataTable
    Dim objpesquisar2 As DataTable
    Dim objpesquisar3 As DataTable
    Dim novo As Boolean
    Dim objaces As New ClsAcesso
    Public hora_entrada As Date
    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLogin.MouseClick
        txtLogin.Text = ""

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        novo = True
        objpesquisar = pesquisar_login(txtLogin.Text)
        objpesquisar2 = pesquisar_senha(txtSenha.Text)
        If objpesquisar.Rows.Count > 0 Then
            objpesquisar3 = pesquisar_nome(txtLogin.Text)
            If objpesquisar2.Rows.Count > 0 Then
                objaces.codigo_funcionario = objpesquisar3.Rows(0).Item("codfun")
                objaces.nome_funcionario = objpesquisar3.Rows(0).Item("nomfun")
                objaces.hora_entrada = Label3.Text
                hora_entrada = Label3.Text
                objaces.data = Today
                objaces.gravar(novo)
                MenuInicial.lblNome.Text = objpesquisar3.Rows(0).Item("nomfun")
                MenuInicial.lblhora.Text = Label3.Text
                MenuInicial.Label1.Text = objpesquisar3.Rows(0).Item("codfun")
                MenuInicial.ShowDialog()
                txtLogin.Text = "username"
                txtSenha.Text = "senha"
                PictureBox1.Image = Nothing
            Else
                MsgBox("Senha incorreta!")
                txtSenha.Text = ""
                txtSenha.Focus()
            End If
        Else
            MsgBox("Login incorreto!")
            txtLogin.Text = ""
            txtLogin.Focus()
        End If

    End Sub
    Function pesquisar_nome(ByVal dado As String) As DataTable
        sql = "SELECT Funcionarios.NomFun, Login.codfun, Login.Login, Funcionarios.fotofun" & _
" FROM Funcionarios INNER JOIN Login ON Funcionarios.CodFun = Login.codfun where login ='" & txtLogin.Text & "'"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
Function pesquisar_login(ByVal dado As String) As DataTable
        sql = "select * from login where login='" & dado & "'"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Function pesquisar_senha(ByVal dado As String) As DataTable
        sql = "select * from login where senha='" & dado & "'"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Function pesquisar_foto(ByVal dado As String) As DataTable
        sql = "select fotofun from funcionarios where codfun = " & dado
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'objpesquisar3 = pesquisar_foto(1)
        'PictureBox1.ImageLocation = objpesquisar3.Rows(0).Item("fotofun")
    End Sub
    Private Sub txtSenha_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSenha.MouseClick
        txtSenha.Text = ""
    End Sub

    Private Sub txtLogin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.Validated
        objpesquisar = pesquisar_login(txtLogin.Text)
        If txtLogin.Text <> "" Then
            If objpesquisar.Rows.Count > 0 Then
                objpesquisar3 = pesquisar_nome(txtLogin.Text)
                PictureBox1.ImageLocation = objpesquisar3.Rows(0).Item("fotofun")
            End If
        Else
            txtLogin.Focus()
        End If
    End Sub

    Private Sub txtLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
        If txtLogin.Text = "" Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class