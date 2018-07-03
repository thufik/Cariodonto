Public Class Odontograma
    Dim objodontograma As New ClsOdontograma
    Dim novo As Boolean
    Dim sql As String
    Dim objcontrole As New ClsControle
    Dim objtipo As New ClsTipo


    Private Sub Odontograma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Enabled = False
        Panel2.Enabled = False
        GravarToolStripMenuItem.Enabled = False

        CboTra.DisplayMember = "Descon"
        CboTra.ValueMember = "Codcon"
        CboTra.DataSource = objtipo.POPULAR_2("select * from tabtipoconsulta where agecon= 'T'")
    End Sub

    Private Sub NovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        novo = True
        Panel1.Enabled = True
        Panel2.Enabled = True
        TxtOdo.Enabled = False
        btnOdo.Enabled = False
        GravarToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        TxtCli.Focus()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        novo = False
        Panel1.Enabled = True
        Panel2.Enabled = True
        TxtOdo.Enabled = True
        btnOdo.Enabled = True
        GravarToolStripMenuItem.Enabled = True
        AlterarToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Enabled = False
        objcontrole.Limpar_tela(Me.Panel1)
        TxtOdo.Focus()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Panel1.Enabled = False
        Panel2.Enabled = False
        TxtOdo.Enabled = False
        btnOdo.Enabled = False
        GravarToolStripMenuItem.Enabled = False
        AlterarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = True
        objcontrole.Limpar_tela(Me.Panel1)
        LblCli.Text = ""

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 18
    End Sub

    Private Sub txt17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 17
    End Sub

    Private Sub txt16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 16
    End Sub

    Private Sub txt15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 15
    End Sub

    Private Sub txt14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 14
    End Sub

    Private Sub txt13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 13
    End Sub

    Private Sub txt12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 12
    End Sub

    Private Sub txt11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 11
    End Sub

    Private Sub txt21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 21
    End Sub

    Private Sub txt22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 22
    End Sub

    Private Sub txt23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 23
    End Sub

    Private Sub txt24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 24
    End Sub

    Private Sub txt25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 25
    End Sub

    Private Sub txt26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 26
    End Sub

    Private Sub txt27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 27
    End Sub

    Private Sub txt28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 28
    End Sub

    Private Sub txt55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 55
    End Sub

    Private Sub txt54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 54
    End Sub

    Private Sub txt53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 53
    End Sub

    Private Sub txt52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 52
    End Sub

    Private Sub txt51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 51
    End Sub

    Private Sub txt61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 61
    End Sub

    Private Sub txt62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 62
    End Sub

    Private Sub txt63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 63
    End Sub

    Private Sub txt64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 64
    End Sub

    Private Sub txt65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 65
    End Sub

    Private Sub txt85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 85
    End Sub

    Private Sub txt84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 84
    End Sub

    Private Sub txt83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 83
    End Sub

    Private Sub txt82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 82
    End Sub

    Private Sub txt81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 81
    End Sub

    Private Sub txt71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 71
    End Sub

    Private Sub txt72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 72
    End Sub

    Private Sub txt73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 73
    End Sub

    Private Sub txt74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 74
    End Sub

    Private Sub txt75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 75
    End Sub

    Private Sub txt48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 48
    End Sub

    Private Sub txt47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 47
    End Sub

    Private Sub txt46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 46
    End Sub

    Private Sub txt45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 45
    End Sub

    Private Sub txt44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 44
    End Sub

    Private Sub txt43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 43
    End Sub

    Private Sub txt42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 42
    End Sub

    Private Sub txt41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 41
    End Sub

    Private Sub txt31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 31
    End Sub

    Private Sub txt32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 32
    End Sub

    Private Sub txt33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 33
    End Sub

    Private Sub txt34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 34
    End Sub

    Private Sub txt35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 35
    End Sub

    Private Sub txt36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 36
    End Sub

    Private Sub txt37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 37
    End Sub

    Private Sub txt38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDen.Text = 38
    End Sub

    Private Sub GravarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravarToolStripMenuItem.Click
        If TxtVal.Text = "" Then
            MsgBox("O valor não foi definido")
            TxtVal.Focus()
            Exit Sub
        End If
        objodontograma.Cliente = TxtCli.Text
        objodontograma.Dente = txtDen.Text
        objodontograma.Tipo = CboTra.SelectedValue
        objodontograma.Valor = TxtVal.Text
        objodontograma.Observação = TxtObs.Text
        objodontograma.gravar(novo)
        MsgBox("Gravado com Sucesso")

        objcontrole.Limpar_tela(Me.Panel1)
        Panel1.Enabled = False
        Panel2.Enabled = False
        LblCli.Text = ""
        AlterarToolStripMenuItem.Enabled = True
        NovoToolStripMenuItem.Enabled = True
        GravarToolStripMenuItem.Enabled = False

    End Sub

    Private Sub btncli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncli.Click
        FrmConCliOdo.ShowDialog()
    End Sub

    Private Sub TxtCli_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCli.Validated
        If TxtCli.Text = "" Then
            MsgBox("O código do cliente esta vazio")
        End If
        If TxtCli.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim OBJOdo As New ClsCliente
            OBJDTLOCAL = OBJOdo.Localizar(TxtCli.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                LblCli.Text = OBJDTLOCAL.Rows(0).Item("nomcli")
            Else
                MessageBox.Show("Codigo não cadastrado")
                LblCli.Text = ""
                TxtCli.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub

    Private Sub btnOdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdo.Click
        FrmConOdo.ShowDialog()
    End Sub

    Private Sub TxtOdo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOdo.KeyPress, TxtCli.KeyPress, txtDen.KeyPress
        e.Handled = objcontrole.PermitirSónumeros(e.KeyChar)
    End Sub
    Private Sub TxtVal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVal.KeyPress
        e.Handled = objcontrole.PermitirSónumerosVirgula(e.KeyChar)
    End Sub

    Private Sub TxtOdo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOdo.Validated
        If TxtOdo.Text <> "" Then
            Dim OBJDTLOCAL As New DataTable
            Dim objdtcli As New DataTable
            Dim OBJRec As New ClsOdontograma
            Dim objcli As New ClsOdontograma
            OBJDTLOCAL = OBJRec.Localizar2(TxtOdo.Text)
            If OBJDTLOCAL.Rows.Count > 0 Then
                TxtCli.Text = OBJDTLOCAL.Rows(0).Item("Clitra")
                LblCli.Text = OBJDTLOCAL.Rows(0).Item("nomcli")
                txtDen.Text = OBJDTLOCAL.Rows(0).Item("dentra")
                CboTra.SelectedValue = OBJDTLOCAL.Rows(0).Item("tpotra")
                If IsDBNull(OBJDTLOCAL.Rows(0).Item("obstra")) Then
                    TxtObs.Text = ""
                Else
                    TxtObs.Text = OBJDTLOCAL.Rows(0).Item("obstra")
                End If
                TxtVal.Text = OBJDTLOCAL.Rows(0).Item("valtra")
                objcontrole.habilitar_botoes(Me.Panel1, True)
                objcontrole.habilitar_tela(Me.Panel1, True)
                TxtCli.Focus()
                objodontograma.Codigo = TxtOdo.Text
            Else
                MessageBox.Show("Codigo não cadastrado")
                TxtOdo.Clear()
                TxtOdo.Focus()

            End If
        End If
    End Sub
End Class