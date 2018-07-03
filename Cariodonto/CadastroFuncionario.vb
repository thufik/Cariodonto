Public Class CadastroFuncionario
    Dim objfun As New ClsFuncionarios
    Dim objcontrole As New ClsControle
    Dim objimg As ArImgCamera.clsArImgCam
    Dim testar As Integer
    Dim novo As Boolean
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CadastroFuncionario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cbbEspFun.Items.Clear()
        cbbSexFun.Items.Clear()
    End Sub
    Private Sub CadastroFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbEspFun.Items.Add("Secretária(o)")
        cbbEspFun.Items.Add("Dentista Geral")
        cbbEspFun.Items.Add("Odontopediatra")
        cbbEspFun.Items.Add("Dentista Odonto Geriatra")
        cbbEspFun.Items.Add("Dentista Restaurador")
        cbbSexFun.Items.Add("Masculino")
        cbbSexFun.Items.Add("Feminino")
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        txtCroFun.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        objcontrole.habilitar_tela(Me.Panel1, False)
        objcontrole.habilitar_tela(Me.Panel2, False)
        Panel1.Visible = False
    End Sub

    Private Sub txtNunFun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Picfoto.Image = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        testar = 2
        OpenFileDialog1.Filter = "Arquivos de imagem|*.jpg; *.bmp; *.gif;|Todos os Arquivos|*.*"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Picfoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        testar = 1
        Dim objpf As New Frmpegarfoto
        Picfoto.Image = objpf.Instanciar
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If objcontrole.Testar_vazio(Me.Panel2) = True Then
            Exit Sub
        ElseIf lblCurriculo.Text = "" Then
            MsgBox("Carregue o Curriculum do Funcionário")
            btnCurFun.Focus()
            Exit Sub
        ElseIf Picfoto.Image Is Nothing Then
            MsgBox("Tire ou carregue uma foto do funcionário")
            Exit Sub
        End If
        objfun.Nome = txtNomFun.Text
        objfun.Sexo = cbbSexFun.Text
        objfun.Data_Nascimento = DateTimePicker1.Text
        objfun.Telefone = txtTelFun.Text
        objfun.Endereço = txtEndFun.Text & " " & txtNunFun.Text & " " & txtComFun.Text
        objfun.Especialidade = cbbEspFun.Text
        objfun.Admissao = DateTimePicker2.Text
        objfun.Carga_Horaria = DateTimePicker3.text
        objfun.Salario = txtSalFun.Text
        objfun.Conselho_Regional = txtCroFun.Text
        objfun.Email = txtEmaFun.Text
        objfun.Ativo = chkativo.CheckState
        If testar = 1 Then
            objcontrole.BufferIMG(Picfoto.Image, txtNomFun.Text)
            objfun.foto = Application.StartupPath & "/" & txtNomFun.Text & ".jpg"
        Else
            objfun.foto = OpenFileDialog1.FileName
        End If
        objfun.Curriculo = Label14.Text
        objfun.Gravar(novo)

    End Sub

    Private Sub btnCurFun_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurFun.Click
        OpenFileDialog2.Filter = "Arquivos Pdf|*.pdf;"
        OpenFileDialog2.InitialDirectory = Application.StartupPath & "/curriculum"
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FrmCurriculum.AxAcroPDF1.LoadFile(OpenFileDialog2.FileName)
            FrmCurriculum.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCurriculum.Show()
    End Sub

    Private Sub txtTelFun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelFun.KeyPress, txtNunFun.KeyPress, txtSalFun.KeyPress, txtCroFun.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        objcontrole.Limpar_tela(Me.Panel1)
        objcontrole.Limpar_tela(Me.Panel2)
        lblCurriculo.Text = ""
        Panel1.Visible = False
        objcontrole.habilitar_tela(Me.Panel2, True)
        objcontrole.habilitar_tela(Me.Panel1, False)
        AlterarToolStripMenuItem.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        txtCroFun.Enabled = False
        txtNomFun.Focus()
    End Sub

    Private Sub cbbEspFun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbEspFun.SelectedIndexChanged
        If cbbEspFun.Text = "Secretária(o)" Then
            txtCroFun.Enabled = False
        Else
            txtCroFun.Enabled = True
        End If
    End Sub

    Private Sub txtEmaFun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmaFun.TextChanged
       
    End Sub

    Private Sub txtEmaFun_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmaFun.Validated
        Dim VALID As Boolean
        VALID = objcontrole.ValidEMail(txtEmaFun.Text)
        If VALID = True Then
            lblemail.Text = "Email válido"
            lblemail.ForeColor = Color.Green
        Else
            lblemail.Text = "Email Inválido"
            lblemail.ForeColor = Color.Red
            txtEmaFun.Focus()
            Exit Sub
        End If
    End Sub
End Class