Public Class ClsReceita

    Dim M_cod As Integer
    Dim M_DatRec As Date
    Dim M_conta As Integer
    Dim M_HistRec As String
    Dim M_valRec As Integer
    Dim M_CodFun As Integer
    Dim M_CodCli As Integer
    Dim sql As String
    Dim objbanco As New ClsBanco
    Public Property Codigo() As Integer
        Get
            Return M_cod

        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property Data_Receita() As Date
        Get
            Return M_DatRec
        End Get
        Set(ByVal value As Date)
            M_DatRec = value
        End Set
    End Property
    Public Property Conta() As Integer
        Get
            Return M_conta
        End Get
        Set(ByVal value As Integer)
            M_conta = value
        End Set
    End Property
    Public Property Historico_Receita() As String
        Get
            Return M_HistRec
        End Get
        Set(ByVal value As String)
            M_HistRec = value
        End Set
    End Property
    Public Property Valor_Receita() As Integer
        Get
            Return M_valRec
        End Get
        Set(ByVal value As Integer)
            M_valRec = value
        End Set
    End Property
    Public Property Codigo_Funcionario() As Integer
        Get
            Return M_CodFun
        End Get
        Set(ByVal value As Integer)
            M_CodFun = value
        End Set
    End Property
    Public Property Codigo_Cliente() As Integer
        Get
            Return M_CodCli
        End Get
        Set(ByVal value As Integer)
            M_CodCli = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into receitas(DatRec" & _
            ",conrec" & _
            ",histrec" & _
            ",valrec" & _
            ",funrec" & _
            ",clirec" & _
            ") values" & _
            "('" & M_DatRec & "'" & _
            "," & M_conta & "" & _
            ",'" & M_HistRec & "'" & _
            "," & M_valRec & "" & _
            "," & M_CodFun & "" & _
            "," & M_CodCli & "" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update receitas set" & _
            " datrec='" & M_DatRec & "'" & _
            ",conrec=" & M_conta & "" & _
            ",histrec='" & M_HistRec & "'" & _
            ",valrec=" & M_valRec & "" & _
            ",funrec=" & M_CodFun & "" & _
            ",clirec=" & M_CodCli & "" & _
            " where lanrec=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from receitas where lanrec=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
