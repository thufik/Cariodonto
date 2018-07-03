Public Class ClsTabEntrada
    Dim sql As String
    Dim objbanco As New ClsBanco

    Dim M_cod As Integer
    Dim M_pro As Integer
    Dim M_for As Integer
    Dim M_dat As Date
    Dim M_qtd As Integer
    Dim M_not As String

    Public Property Codigo() As Integer
        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property Produto() As Integer
        Get
            Return M_pro
        End Get
        Set(ByVal value As Integer)
            M_pro = value
        End Set
    End Property
    Public Property Fornecedor() As Integer
        Get
            Return M_for
        End Get
        Set(ByVal value As Integer)
            M_for = value
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
    Public Property Quantidade() As Integer
        Get
            Return M_qtd
        End Get
        Set(ByVal value As Integer)
            M_qtd = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into tabentradadeprodutos " & _
            "(proitm" & _
            ",foritm" & _
            ",datitm" & _
            ",qtditm" & _
            ")values" & _
            "(" & M_pro & "" & _
            "," & M_for & "" & _
            ",'" & M_dat & "'" & _
            "," & M_qtd & "" & _
            ")"
            objbanco.executar_comando(sql)

            'M_cod = 'buscar ultimo
        Else
            sql = "update tabentradadeprodutos set" & _
            " proitm=" & M_pro & "" & _
            ",foritm=" & M_for & "" & _
            ",datitm='" & M_dat & "'" & _
            ",qtditm=" & M_qtd & "" & _
            " where coditm=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from tabentradadeprodutos where coditm=" & dado
        Else
            sql = "select * from tabentradadeprodutos where datitm=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar2(ByVal dado As String) As DataTable
        sql = "SELECT TabentradadeProdutos.CodItm, Produtos.NomPro, TabentradadeProdutos.DatItm, TabentradadeProdutos.QtdItm, TabentradadeProdutos.ForItm " & _
        "FROM Produtos INNER JOIN TabentradadeProdutos ON Produtos.CodPro = TabentradadeProdutos.ProItm where produtos.nompro like '" & dado & "%'"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar3(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "SELECT TabentradadeProdutos.CodItm, TabentradadeProdutos.ProItm, TabentradadeProdutos.ForItm, TabentradadeProdutos.DatItm, TabentradadeProdutos.QtdItm, Produtos.NomPro, Fornecedores.empfor " & _
            "FROM Fornecedores INNER JOIN (Produtos INNER JOIN TabentradadeProdutos ON Produtos.CodPro = TabentradadeProdutos.ProItm) ON Fornecedores.codfor = TabentradadeProdutos.ForItm " & _
            "where tabentradadeprodutos.coditm=" & dado
        Else
            sql = "SELECT TabentradadeProdutos.CodItm, TabentradadeProdutos.ProItm, TabentradadeProdutos.ForItm, TabentradadeProdutos.DatItm, TabentradadeProdutos.QtdItm, Produtos.NomPro, Fornecedores.empfor " & _
            "FROM Fornecedores INNER JOIN (Produtos INNER JOIN TabentradadeProdutos ON Produtos.CodPro = TabentradadeProdutos.ProItm) ON Fornecedores.codfor = TabentradadeProdutos.ForItm " & _
            "where datitm= " & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
