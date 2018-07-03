Public Class ClsCliente
    Dim objbanco As New ClsBanco
    Dim sql As String 'localizar dados do banco

    Dim m_cod As Integer 'Codigo do cliente 
    Dim m_nom As String ' Nome do cliente
    Dim m_nas As Date ' data de nascimento
    Dim m_sex As String 'sexo do cliente
    Dim m_tel As String 'telefone do cliente
    Dim m_end As String 'endereço do cliente
    Dim m_ema As String 'email do cliente
    Dim m_ati As Boolean 'atividade do cliente
    Dim m_est As String 'estado civil do cliente
    Dim m_ind As String 'indicação do cliente
    Dim m_uff As String 'unidade federal do cliente
    Dim m_cid As String 'cidade do cliente
    Dim m_cep As Integer 'CEP do cliente
    Dim m_foto As String
    Public Property Unidade_Federal() As String
        Get
            Return m_uff
        End Get
        Set(ByVal value As String)
            m_uff = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return m_cid
        End Get
        Set(ByVal value As String)
            m_cid = value
        End Set
    End Property
    Public Property CEP() As Integer
        Get
            Return m_cep
        End Get
        Set(ByVal value As Integer)
            m_cep = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
        End Set
    End Property
    Public Property Nascimento() As Date
        Get
            Return m_nas
        End Get
        Set(ByVal value As Date)
            m_nas = value
        End Set
    End Property
    Public Property Sexo() As String
        Get
            Return m_sex
        End Get
        Set(ByVal value As String)
            m_sex = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property
    Public Property Endereço() As String
        Get
            Return m_end
        End Get
        Set(ByVal value As String)
            m_end = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return m_ema
        End Get
        Set(ByVal value As String)
            m_ema = value
        End Set
    End Property
    Public Property Ativo() As Boolean
        Get
            Return m_ati
        End Get
        Set(ByVal value As Boolean)
            m_ati = value
        End Set
    End Property
    Public Property Estado_Civil() As String
        Get
            Return m_est
        End Get
        Set(ByVal value As String)
            m_est = value
        End Set
    End Property
    Public Property Indicação() As String
        Get
            Return m_ind
        End Get
        Set(ByVal value As String)
            m_ind = value
        End Set
    End Property
    Public Property foto() As String
        Get
            Return m_foto
        End Get
        Set(ByVal value As String)
            m_foto = value
        End Set
    End Property
    Public Sub Gravar(ByVal novo As Boolean)
        If novo = True Then
            'sql = "insert into tabclientes (nomcli,telcli,endcli) values ('MARIA','(11) 5555-2211','AV Liberdade,80')"
            'sql = "insert into tabclientes (nomcli.telcli,endcli) values ('" & m_nom & "','" & m_tel & "','" & m_end & "')"

            sql = "insert into clientes " & _
            "(nomcli" & _
            ",nascli" & _
            ",sexcli" & _
            ",telcli" & _
            ",endcli" & _
            ",emacli" & _
            ",aticli" & _
            ",esccli" & _
            ",ufcli" & _
            ",cidcli" & _
            ",cepcli" & _
            ",fotocli" & _
            ") values " & _
            "('" & m_nom & "'" & _
            "," & m_nas & "" & _
            ",'" & m_sex & "'" & _
            ",'" & m_tel & "'" & _
            ",'" & m_end & "'" & _
            ",'" & m_ema & "'" & _
            "," & m_ati & "" & _
            ",'" & m_est & "'" & _
            ",'" & m_uff & "'" & _
            ",'" & m_cid & "'" & _
            "," & m_cep & "" & _
            ",'" & m_foto & "'" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            'sql = "update tabclientes set nomcli='maria silva', telcli='(21)3333-2211', endcli='AV MOEMA,123' where codcli=13"
            'sql = "update tabclientes set nomcli='" & m_nom & "', telcli='" & m_tel & "', endcli='" & m_end & "' where codcli=13"
            sql = "update clientes set " & _
            " nomcli='" & m_nom & "'" & _
            ",nascli='" & m_nas & "'" & _
            ",sexcli='" & m_sex & "'" & _
            ",telcli='" & m_tel & "'" & _
            ",endcli='" & m_end & "'" & _
            ",emacli='" & m_ema & "'" & _
            ",aticli=" & m_ati & "" & _
            ",estcli='" & m_est & "'" & _
            ",ufcli='" & m_uff & "'" & _
            ",cidcli='" & m_cid & "'" & _
            ",cepcli='" & m_cep & "'" & _
            ",fotocli='" & m_foto & "'" & _
            " where codcli=" & m_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from clientes where codcli =" & dado
        Else
            sql = "select * from clientes where nomcli like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar2(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "SELECT Agendamento.CodAge, Agendamento.CliAge, Clientes.NomCli, Agendamento.CodProf, Agendamento.DatAge, Agendamento.ConAge, Agendamento.HorIni, Agendamento.HorFim" & _
" FROM Clientes INNER JOIN Agendamento ON Clientes.[CodCli] = Agendamento.[CliAge] where codcli = " & dado
        Else
            sql = "SELECT Agendamento.CodAge, Agendamento.CliAge, Clientes.NomCli, Agendamento.CodProf, Agendamento.DatAge, Agendamento.ConAge, Agendamento.HorIni, Agendamento.HorFim" & _
" FROM Clientes INNER JOIN Agendamento ON Clientes.[CodCli] = Agendamento.[CliAge] where nomcli like '" & dado & "%'"
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
    Public Function pesquisar_telefone(ByVal dado As String) As DataTable

        If Not IsNumeric(dado) Then
            sql = "select codcli,nomcli,telcli from clientes where nomcli like '" & dado & "%'"
        Else
            sql = "select codcli,nomcli,telcli from clientes where codcli=" & dado
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

End Class
