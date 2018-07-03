Public Class ClsProdutos
    Dim M_cod As Integer
    Dim M_nome As String
    Dim M_qtdatual As Integer
    Dim M_qtdmax As Integer
    Dim M_qtdmin As Integer
    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim LINHA As Integer
    Dim objds As New DataSet
    Public Property Codigo() As Integer
        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return M_nome
        End Get
        Set(ByVal value As String)
            M_nome = value
        End Set
    End Property
    Public Property Quantidade_Atual() As Integer
        Get
            Return M_qtdatual
        End Get
        Set(ByVal value As Integer)
            M_qtdatual = value
        End Set
    End Property
    Public Property Quantidade_Maxima() As Integer
        Get
            Return M_qtdmax
        End Get
        Set(ByVal value As Integer)
            M_qtdmax = value
        End Set
    End Property
    Public Property Quantidade_minima() As Integer
        Get
            Return M_qtdmin
        End Get
        Set(ByVal value As Integer)
            M_qtdmin = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into produtos " & _
            "(nompro" & _
            ",qtdatual" & _
            ",qtdmin" & _
            ",qtdmax" & _
            ")values" & _
            "('" & M_nome & "'" & _
            "," & M_qtdatual & "" & _
            "," & M_qtdmax & "" & _
            "," & M_qtdmin & "" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update produtos set" & _
            " nompro='" & M_nome & "'" & _
            ",qtdatual=" & M_qtdatual & "" & _
            ",qtdmin=" & M_qtdmin & "" & _
            ",qtdmax=" & M_qtdmax & "" & _
            " where codpro=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Sub Baixar_Estoque(ByVal qtd As Integer, ByVal codigo As Integer)
        sql = " update produtos set qtdatual = qtdatual -" & qtd & " where codpro=" & codigo
        objbanco.executar_comando(sql)
    End Sub
    Public Function Entrar_Estoque(ByVal qtd As Integer, ByVal codigo As Integer) As Boolean
        Dim QtdMax As Integer
        Dim QtdAtu As Integer
        Call buscarprodutocodigo(codigo)
        QtdMax = M_qtdmax
        QtdAtu = M_qtdatual
        If Quantidade_Atual + qtd > Quantidade_Maxima Then
            Return True
        Else
            sql = "update produtos set qtdatual = qtdatual +" & qtd & " where codpro=" & codigo
            objbanco.executar_comando(sql)
        End If

    End Function
    Public Sub EntrarAlt(ByVal qtd As Integer, ByVal codigo As Integer)
        sql = "update produtos set qtdatual = qtdatual +" & qtd & " where codpro=" & codigo
        objbanco.executar_comando(sql)
    End Sub
    Public Function buscarprodutocodigo(ByVal codigo As Integer) As Boolean
        sql = "select * from produtos where codpro=" & codigo

        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Call mostrar_DADOS_NA_CLASSE()
            LINHA = 0
            Return True

        Else
            MessageBox.Show("Registro nao contrado")
        End If


    End Function

    Public Sub mostrar_DADOS_NA_CLASSE()
        M_cod = objds.Tables(0).Rows(LINHA).Item(0)
        M_nome = objds.Tables(0).Rows(LINHA).Item(1)
        M_qtdatual = objds.Tables(0).Rows(LINHA).Item(2)
        M_qtdmax = objds.Tables(0).Rows(LINHA).Item(4)
        M_qtdmin = objds.Tables(0).Rows(LINHA).Item(3)

    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from Produtos where codpro=" & dado
        Else
            sql = "select * from produtos where nompro like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function pesquisar_qtd(ByVal dado As String) As DataTable
        sql = "select * from produtos where codpro =" & dado
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
