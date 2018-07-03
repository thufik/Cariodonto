Public Class ClsFuncionarios
    Dim objbanco As New ClsBanco
    Dim sql As String

    Dim M_cod As Integer
    Dim M_nom As String
    Dim M_esp As String
    Dim M_sal As Integer
    Dim M_hor As Date
    Dim M_nas As Date
    Dim M_cur As String
    Dim M_ati As Boolean
    Dim M_end As String
    Dim M_adm As Date 'data de admissão do funcionário
    Dim M_sex As String
    Dim M_tel As String
    Dim M_ema As String
    Dim M_cro As Integer
    Dim M_foto As String
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
            Return M_nom
        End Get
        Set(ByVal value As String)
            M_nom = value
        End Set
    End Property
    Public Property Especialidade() As String
        Get
            Return M_esp
        End Get
        Set(ByVal value As String)
            M_esp = value
        End Set
    End Property
    Public Property Salario() As Integer
        Get
            Return M_sal
        End Get
        Set(ByVal value As Integer)
            M_sal = value
        End Set
    End Property
    Public Property Carga_Horaria() As Date

        Get
            Return M_hor
        End Get
        Set(ByVal value As Date)
            M_hor = value
        End Set
    End Property
    Public Property Data_Nascimento() As Date
        Get
            Return M_nas
        End Get
        Set(ByVal value As Date)
            M_nas = value
        End Set
    End Property
    Public Property Curriculo() As String
        Get
            Return M_cur
        End Get
        Set(ByVal value As String)
            M_cur = value
        End Set
    End Property
    Public Property Ativo() As Boolean
        Get
            Return M_ati
        End Get
        Set(ByVal value As Boolean)
            M_ati = value
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

    Public Property Admissao() As Date
        Get
            Return M_adm
        End Get
        Set(ByVal value As Date)
            M_adm = value
        End Set
    End Property
    Public Property Sexo() As String
        Get
            Return M_sex
        End Get
        Set(ByVal value As String)
            M_sex = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return M_tel
        End Get
        Set(ByVal value As String)
            M_tel = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return M_ema
        End Get
        Set(ByVal value As String)
            M_ema = value
        End Set
    End Property
    Public Property Conselho_Regional() As String
        Get
            Return M_cro
        End Get
        Set(ByVal value As String)
            m_cro = value
        End Set
    End Property
    Public Property foto() As String
        Get
            Return M_foto
        End Get
        Set(ByVal value As String)
            M_foto = value
        End Set
    End Property

    Public Sub Gravar(ByVal novo As Boolean)
        If novo = True Then
            'sql = "insert into tabclientes (nomcli,telcli,endcli) values ('MARIA','(11) 5555-2211','AV Liberdade,80')"
            'sql = "insert into tabclientes (nomcli.telcli,endcli) values ('" & m_nom & "','" & m_tel & "','" & m_end & "')"

            sql = "insert into Funcionarios " & _
            "(Nomfun" & _
            ",Espfun" & _
            ",Salfun" & _
            ",Horfun" & _
            ",Nasfun" & _
            ",Curfun" & _
            ",Atifun" & _
            ",Endfun" & _
            ",Admfun" & _
            ",Sexfun" & _
            ",Telfun" & _
            ",Emafun" & _
            ",CROfun" & _
            ",fotofun" & _
            ") values " & _
            "('" & M_nom & "'" & _
            ",'" & M_esp & "'" & _
            "," & M_sal & "" & _
            ",#" & M_hor & "#" & _
            ",#" & M_nas & "#" & _
            ",'" & M_cur & "'" & _
            "," & M_ati & "" & _
            ",'" & M_end & "'" & _
            ",#" & M_adm & "#" & _
            ",'" & M_sex & "'" & _
            ",'" & M_tel & "'" & _
            ",'" & M_ema & "'" & _
            "," & M_cro & "" & _
            ",'" & M_foto & "'" & _
            ")"
            objbanco.executar_comando(sql)


        Else
            'sql = "update tabclientes set nomcli='maria silva', telcli='(21)3333-2211', endcli='AV MOEMA,123' where codcli=13"
            'sql = "update tabclientes set nomcli='" & m_nom & "', telcli='" & m_tel & "', endcli='" & m_end & "' where codcli=13"
            sql = "update Funcionarios set " & _
            " nomfun='" & M_nom & "'" & _
            ",espfun='" & M_esp & "'" & _
            ",salfun=" & M_sal & "" & _
            ",horfun=" & M_hor & "" & _
            ",nasfun=#" & M_nas & "#" & _
            ",curfun='" & M_cur & "'" & _
            ",atifun='" & M_ati & "'" & _
            ",endfun='" & M_end & "'" & _
            ",admfun=#" & M_adm & "#" & _
            ",sexfun='" & M_sex & "'" & _
            ",telfun='" & M_tel & "'" & _
            ",emafun='" & M_ema & "'" & _
            ",crofun='" & M_cro & "'" & _
            " where codfun=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from funcionarios where codfun=" & dado
        Else
            sql = "select * from funcionarios where nomfun like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function pesquisar_telefone(ByVal dado As String) As DataTable

        If Not IsNumeric(dado) Then
            sql = "select codfun,nomfun,telfun from funcionarios where nomfun like '" & dado & "%'"
        Else
            sql = "select codfun,nomfun,telfun from funcionarios where codfun=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function pesquisar_funcionario(ByVal dado As String) As DataTable

        If Not IsNumeric(dado) Then
            sql = "select * from funcionarios where nomfun like '" & dado & "%'"
        Else
            sql = "select * from funcionarios where codfun=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
