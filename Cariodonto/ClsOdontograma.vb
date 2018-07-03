Public Class ClsOdontograma
    Dim objbanco As New ClsBanco
    Dim sql As String

    Dim M_Cod As Integer
    Dim M_Cli As Integer
    Dim M_Den As Integer
    Dim M_Tpo As Integer
    Dim M_Val As Single
    Dim M_Obs As String

    Public Property Codigo() As Integer
        Get
            Return M_Cod
        End Get
        Set(ByVal value As Integer)
            M_Cod = value
        End Set
    End Property
    Public Property Cliente() As Integer
        Get
            Return M_Cli
        End Get
        Set(ByVal value As Integer)
            M_Cli = value
        End Set
    End Property
    Public Property Dente() As Integer
        Get
            Return M_Den
        End Get
        Set(ByVal value As Integer)
            M_Den = value
        End Set
    End Property
    Public Property Tipo() As Integer
        Get
            Return M_Tpo
        End Get
        Set(ByVal value As Integer)
            M_Tpo = value
        End Set
    End Property
    Public Property Valor() As Single
        Get
            Return M_Val
        End Get
        Set(ByVal value As Single)
            M_Val = value
        End Set
    End Property
    Public Property Observação() As String
        Get
            Return M_Obs
        End Get
        Set(ByVal value As String)
            M_Obs = value
        End Set
    End Property

    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into tratamento " & _
            "(CliTra" & _
            ",DenTra" & _
            ",TpoTra" & _
            ",ValTra" & _
            ",ObsTra" & _
            ")values" & _
            "(" & M_Cli & "" & _
            "," & M_Den & "" & _
            "," & M_Tpo & "" & _
            ",'" & M_Val & "'" & _
            ",'" & M_Obs & "'" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update tratamento set " & _
            " CliTra=" & M_Cli & "" & _
            ",DenTra=" & M_Den & "" & _
            ",TpoTra=" & M_Tpo & "" & _
            ",ValTra='" & M_Val & "'" & _
            ",ObsTra='" & M_Obs & "'" & _
            " where CodTra=" & M_Cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from Tratamento where CodTra=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar2(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "SELECT Tratamento.CodTra, Tratamento.CliTra, Tratamento.DenTra, Tratamento.TpoTra, Tratamento.ValTra, Tratamento.ObsTra, Clientes.NomCli " & _
            "FROM Clientes INNER JOIN Tratamento ON Clientes.CodCli = Tratamento.CliTra " & _
            "where CodTra = " & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
