Public Class ClsDespesas
    Dim sql As String
    Dim objbanco As New ClsBanco

    Dim M_cod As Integer 'Codigo
    Dim M_dat As Date ' Data da despesa
    Dim M_con As Single ' Conta pra mandar a despesa
    Dim M_his As String ' Historico da despesa
    Dim M_val As Single ' Valor da despesa
    Dim M_fun As Integer ' FUncionario da despesa


    Public Property Codigo() As Integer

        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
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
    Public Property Conta() As Integer
        Get
            Return M_con
        End Get
        Set(ByVal value As Integer)
            M_con = value
        End Set
    End Property
    Public Property Historico() As String
        Get
            Return M_his
        End Get
        Set(ByVal value As String)
            M_his = value
        End Set
    End Property
    Public Property Valor() As Single
        Get
            Return M_val
        End Get
        Set(ByVal value As Single)
            M_val = value
        End Set
    End Property
    Public Property Funcionario() As Integer
        Get
            Return M_fun
        End Get
        Set(ByVal value As Integer)
            M_fun = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into Despesas" & _
            "(datdesp" & _
            ",condesp" & _
            ",histdesp" & _
            ",valdesp" & _
            ",fundesp" & _
            ")values" & _
            "(#" & M_dat & "#" & _
            "," & M_con & "" & _
            ",'" & M_his & "'" & _
            "," & M_val & "" & _
            "," & M_fun & "" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update Despesas set " & _
            " datdesp=#" & M_dat & "#" & _
            ",condesp=" & M_con & "" & _
            ",histdesp='" & M_his & "'" & _
            ",valdesp=" & M_val & "" & _
            ",fundesp=" & M_fun & "" & _
            " where landesp=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from despesas where landesp=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
