Public Class ClsAcesso
    Dim m_cod As Integer
    Dim m_nome As String
    Dim m_ini As Date
    Dim m_fim As Date
    Dim m_dat As Date
    Dim sql As String
    Dim objbanco As New ClsBanco
    Public Property codigo_funcionario() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property
    Public Property nome_funcionario() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property
    Public Property hora_entrada() As Date
        Get
            Return m_ini
        End Get
        Set(ByVal value As Date)
            m_ini = value
        End Set
    End Property
    Public Property hora_saida() As Date
        Get
            Return m_fim
        End Get
        Set(ByVal value As Date)
            m_fim = value
        End Set
    End Property
    Public Property data() As Date
        Get
            Return m_dat
        End Get
        Set(ByVal value As Date)
            m_dat = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into controle(" & _
            "codfun" & _
            ",nomfun" & _
            ",data" & _
            ",horaini" & _
            ")values" & _
            "(" & _
            m_cod & _
            ",'" & m_nome & "'" & _
            ",#" & m_dat & "#" & _
            ",#" & m_ini & "#" & _
            ")"

            objbanco.executar_comando(sql)
        Else
            sql = "update controle set " & _
              " horafim=#" & m_fim & "#" & _
             "where horaini=#" & m_ini & "#" & _
             "and data=#" & m_dat & "#"
            objbanco.executar_comando(sql)
        End If
    End Sub
End Class
