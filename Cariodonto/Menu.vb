Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Public Class MenuInicial
    Dim novo As Boolean
    Dim objaces As New ClsAcesso
    Dim objword As New Object
    Private Sub Agendamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agendamento.Click
        Agenda.ShowDialog()
    End Sub

    Private Sub AnamneseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnamneseToolStripMenuItem1.Click
        Anamnese.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem2.Click
        CadastroPaciente.ShowDialog()
    End Sub

    Private Sub FornecedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem1.Click
        CadastroFornecedor.ShowDialog()
    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem.Click
        CadastroFuncionario.ShowDialog()
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        Produtos.ShowDialog()
    End Sub

    Private Sub ReceitaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceitaToolStripMenuItem1.Click
        Receita.ShowDialog()
    End Sub

    Private Sub PesquisarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesquisarToolStripMenuItem.Click
        'Pesquisar.ShowDialog()

    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja sair ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            novo = False
            Dim objpesquisar3 As New DataTable
            objpesquisar3 = Login.pesquisar_nome(Login.txtLogin.Text)
            objaces.hora_entrada = Login.hora_entrada
            objaces.data = Today
            objaces.codigo_funcionario = objpesquisar3.Rows(0).Item("codfun")
            objaces.hora_saida = Label4.Text
            objaces.hora_entrada = lblhora.Text
            objaces.gravar(novo)
            Close()
            Login.Close()
            Exit Sub
        End If
    End Sub

    Private Sub GráficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim rpt As New CrpQtdAti
        'Impressao.Show()
        ' Impressao.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ListagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim rpt As New CrpListagemAtivos
        ' Impressao.Show()
        ' Impressao.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub MenuInicial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub MenuInicial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub MenuInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub
    Private Sub MenuInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Visible = False
        lbldata.Text = Today
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
    End Sub

    Private Sub ControleDeAcessoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControleDeAcessoToolStripMenuItem.Click
        FrmControle.ShowDialog()
    End Sub

    Private Sub AgendamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendamentosToolStripMenuItem.Click
        FrmConAgendamento.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EnviarUmEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarUmEmailToolStripMenuItem.Click
        FrmEmail.ShowDialog()
    End Sub

    Private Sub AniversariantesDoDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AniversariantesDoDiaToolStripMenuItem.Click
        frmAniversariantes.ShowDialog()
    End Sub

    Private Sub CadastroDeLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCadastroLogin.ShowDialog()
    End Sub

    Private Sub FuncionárioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem1.Click
        frmListatel.Label1.Text = "Pesquisar Funcionários pelo código ou pelo nome"
        frmListatel.telaativa = 1
        frmListatel.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        frmListatel.Label1.Text = "Pesquisar Clientes pelo código ou pelo nome"
        frmListatel.telaativa = 2
        frmListatel.ShowDialog()
    End Sub

    Private Sub GráficoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpt As New CrpGraFunAtiv
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub TratamentoOdontogramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpt As New CrpOdontograma
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub GráficoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GráficoToolStripMenuItem2.Click
        Dim rpt As New CrpGraBaixa
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ListagemToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListagemToolStripMenuItem2.Click
        Dim rpt As New CrpBaixa
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub EntradaDeEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeEstoqueToolStripMenuItem.Click
        Dim rpt As New CrpEntrada
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim rpt As New CrpFornecedor
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub AgendamentoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgendamentoToolStripMenuItem1.Click

    End Sub

    Private Sub BalançoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalançoToolStripMenuItem.Click
        FrmDatIniFin.ShowDialog()
        'Dim rpt As New CrpBalanço
        'FrmImp.Show()
        'FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaToolStripMenuItem.Click
        Dim rpt As New CrpClientes
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ListaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaToolStripMenuItem1.Click
        Dim rpt As New CrpFuncionarios
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ListaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaToolStripMenuItem2.Click
        Dim rpt As New CrpAgendamento
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub GráficoToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GráficoToolStripMenuItem1.Click
        Dim rpt As New CrpGraAgendamento
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub GráficoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BaixaDoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaDoEstoqueToolStripMenuItem.Click
        FrmConBaixa.ShowDialog()

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConCliente.ShowDialog()

    End Sub

    Private Sub DespesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesasToolStripMenuItem.Click
        FrmConDespesas.ShowDialog()

    End Sub

    Private Sub EntradaDeEstoqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeEstoqueToolStripMenuItem1.Click
        FrmConEntrada.ShowDialog()

    End Sub

    Private Sub FornecedorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem2.Click
        FrmConFornecedor.ShowDialog()

    End Sub

    Private Sub FuncionárioToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem2.Click
        FrmConFuncionário.ShowDialog()

    End Sub

    Private Sub OdontogramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConOdo.ShowDialog()

    End Sub

    Private Sub AnamneseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnamneseToolStripMenuItem2.Click

    End Sub

    Private Sub ProdutoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem1.Click
        FrmConProdutos.ShowDialog()

    End Sub

    Private Sub ReceitaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceitaToolStripMenuItem3.Click
        FrmConReceitas.ShowDialog()

    End Sub

    Private Sub DespesaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesaToolStripMenuItem.Click
        Despesas.ShowDialog()

    End Sub

    Private Sub BaixaDeEstoqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaDeEstoqueToolStripMenuItem1.Click
        FrmTabBaixaEstoque.ShowDialog()
    End Sub

    Private Sub EntradaDeProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeProdutosToolStripMenuItem.Click
        FrmTabEntradaProdutos.ShowDialog()

    End Sub

    Private Sub ReceituárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceituárioToolStripMenuItem.Click
        objword = CreateObject("Word.Application")
        'Abre o documento aviso.doc do Microsoft Word.
        objword.Documents.Open("F:\CariodontoOriginal\Cariodonto\bin\Debug\fdsafsafdasdsa.doc")
    End Sub

    Private Sub ListagemToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GraficoAtivosInativosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraficoAtivosInativosToolStripMenuItem.Click
        Dim rpt As New CrpGraFunAtiv
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub GráficoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListagemToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AtivosInativosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtivosInativosToolStripMenuItem.Click
        Dim rpt As New CrpGraClientes
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub OndontogramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OndontogramaToolStripMenuItem.Click
        Odontograma.ShowDialog()
    End Sub

    Private Sub OdontogramaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdontogramaToolStripMenuItem.Click
        Dim rpt As New CrpOdontograma
        FrmImp.Show()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "Bitmaps (*.bmp)|*.bmp"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class