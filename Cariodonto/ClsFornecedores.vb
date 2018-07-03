Public Class ClsFornecedores
    Dim objbanco As New ClsBanco
    Dim sql As String
    Dim M_cod As Integer
    Dim M_emp As String
    Dim M_end As String
    Dim M_tel As Integer
    Dim M_uff As String
    Dim M_comp As String
    Dim M_email As String
    Dim M_numero As String
    Public Property codigo() As Integer
        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property Empresa() As String
        Get
            Return M_emp
        End Get
        Set(ByVal value As String)
            M_emp = value
        End Set
    End Property
    Public Property Endereço() As String
        Get
            Return M_end

        End Get
        Set(ByVal value As String)
            M_end = value
        End Set
    End Property
    Public Property Telefone() As Integer
        Get
            Return M_tel
        End Get
        Set(ByVal value As Integer)
            M_tel = value
        End Set
    End Property
    Public Property UnidadeFederal() As String
        Get
            Return M_uff
        End Get
        Set(ByVal value As String)
            M_uff = value
        End Set
    End Property
    Public Property numero() As String
        Get
            Return M_numero
        End Get
        Set(ByVal value As String)
            M_numero = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return M_email
        End Get
        Set(ByVal value As String)
            M_email = value
        End Set
    End Property

    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into fornecedores" & _
            "(empfor" & _
            ",endfor" & _
            ",telfor" & _
            ",emafor" & _
            ",uffor" & _
            ") values" & _
            "('" & M_emp & "'" & _
            ",'" & M_end & M_comp & M_numero & "'" & _
            "," & M_tel & _
            ",'" & M_email & "'" & _
            ",'" & M_uff & "'" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update fornecedores set " & _
            " empfor='" & M_emp & "'" & _
            ",endfor='" & M_end & M_comp & M_numero & "'" & _
            ",telfor=" & M_tel & _
            ",emafor='" & M_email & "'" & _
            ",uffor='" & M_uff & "'" & _
            " where codfor=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function pesquisar_fornecedor(ByVal dado As String) As DataTable

        If Not IsNumeric(dado) Then
            sql = "select * from fornecedores where empfor like '" & dado & "%'"
        Else
            sql = "select * from fornecedores where codfor=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function pesquisa_uff(ByVal dado As String) As DataTable
        sql = "select id from tabuf where nome ='" & dado & "'"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar_Entrada(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from fornecedores where codfor=" & dado
        Else
            sql = "select * from fornecedores where empfor like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class