Public Class ClsTabBaixa
    Dim sql As String
    Dim objbanco As New ClsBanco

    Dim M_cod As Integer
    Dim M_pro As Integer
    Dim M_qtd As Integer
    Dim M_dat As Date
    Dim M_fun As Integer

    Public Property Codigo() As Integer
        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property CodProduto() As Integer
        Get
            Return M_pro
        End Get
        Set(ByVal value As Integer)
            M_pro = value
        End Set
    End Property
    Public Property Quantidade() As Integer
        Get
            Return M_qtd
        End Get
        Set(ByVal value As Integer)
            M_qtd = value
        End Set
    End Property
    Public Property Data() As Date
        Get
            Return M_dat
        End Get
        Set(ByVal value As Date)
            M_dat = value
        End Set
    End Property
    Public Property CodFuncionario() As Integer
        Get
            Return M_fun
        End Get
        Set(ByVal value As Integer)
            M_fun = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into tabbaixaestoque" & _
            "(codpro" & _
            ",qtdbai" & _
            ",datbai" & _
            ",funbai" & _
            ")values" & _
            "(" & M_pro & "" & _
            "," & M_qtd & "" & _
            ",'" & M_dat & "'" & _
            "," & M_fun & "" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update tabbaixaestoque set " & _
            " codpro=" & M_pro & "" & _
            ",qtdbai=" & M_qtd & "" & _
            ",datbai='" & M_dat & "'" & _
            ",funbai=" & M_fun & "" & _
            " where codbai=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub

    Public Function Localizar2(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            sql = "SELECT TabBaixaEstoque.CodBai, TabBaixaEstoque.CodPro, Produtos.NomPro, TabBaixaEstoque.QtdBai, TabBaixaEstoque.DatBai, TabBaixaEstoque.FunBai, Funcionarios.NomFun " & _
             "FROM Produtos INNER JOIN (Funcionarios INNER JOIN TabBaixaEstoque ON Funcionarios.CodFun = TabBaixaEstoque.FunBai) ON Produtos.CodPro = TabBaixaEstoque.CodPro " & _
             "where codBAI=" & dado
        Else
            sql = "SELECT TabBaixaEstoque.CodBai, TabBaixaEstoque.CodPro, Produtos.NomPro, TabBaixaEstoque.QtdBai, TabBaixaEstoque.DatBai, TabBaixaEstoque.FunBai, Funcionarios.NomFun " & _
            "FROM Produtos INNER JOIN (Funcionarios INNER JOIN TabBaixaEstoque ON Funcionarios.CodFun = TabBaixaEstoque.FunBai) ON Produtos.CodPro = TabBaixaEstoque.CodPro " & _
            "where Produtos.nompro = '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
