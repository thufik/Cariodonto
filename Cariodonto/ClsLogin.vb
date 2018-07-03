Public Class ClsLogin
    Dim m_login As String
    Dim m_senha As String
    Dim m_nome As String
    Dim m_cod As Integer
    Dim sql As String
    Dim objbanco As New ClsBanco

    Public Property login() As String
        Get
            Return m_login
        End Get
        Set(ByVal value As String)
            m_login = value
        End Set
    End Property
    Public Property senha() As String
        Get
            Return m_senha
        End Get
        Set(ByVal value As String)
            m_senha = value
        End Set
    End Property
    Public Property nome() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property
    Public Property codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into login(" & _
            "login" & _
            ",senha" & _
            ",nomfun" & _
            ",codfun" & _
            ")values" & _
            "('" & _
             m_login & "'" & _
            ",'" & m_senha & "'" & _
            ",'" & m_nome & "'" & _
            "," & m_cod & "" & _
            ")"

            objbanco.executar_comando(sql)
        Else
            sql = "update login set " & _
              " login='" & m_login & "'" & _
              " senha='" & m_senha & "'" & _
              " nomfun='" & m_nome & "'" & _
              "where codfun=" & m_cod & ""
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            ' sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from login where codfun=" & dado
        Else
            sql = "select * from login where nomfun like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
