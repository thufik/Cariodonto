
Public Class ClsAgendamento
    Dim objbanco As New ClsBanco
    Dim sql As String

    Dim M_cod As Integer
    Dim M_codcli As Integer 'cod do cliente
    Dim M_codprof As Integer ' cod do profissional
    Dim M_dat As Date ' data do agendamento
    Dim M_codcon As Integer 'codigo da consulta
    Dim M_horini As Date 'Horario do inicio da consulta
    Dim M_horfim As Date 'horario do fim da consuta
    Public Property codigo() As Integer
        Get
            Return M_cod
        End Get
        Set(ByVal value As Integer)
            M_cod = value
        End Set
    End Property
    Public Property Codigo_Cliente() As Integer
        Get
            Return M_codcli
        End Get
        Set(ByVal value As Integer)
            M_codcli = value
        End Set
    End Property
    Public Property codigo_profissional() As Integer
        Get
            Return M_codprof
        End Get
        Set(ByVal value As Integer)
            M_codprof = value
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
    Public Property Cod_Consulta() As Integer
        Get
            Return M_codcon
        End Get
        Set(ByVal value As Integer)
            M_codcon = value
        End Set
    End Property
    Public Property Horario_Inicial() As Date
        Get
            Return M_horini
        End Get
        Set(ByVal value As Date)
            M_horini = value
        End Set
    End Property
    Public Property Horario_final() As Date
        Get
            Return M_horfim
        End Get
        Set(ByVal value As Date)
            M_horfim = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = "insert into agendamento" & _
            "(cliage" & _
            ",codprof" & _
            ",datage" & _
            ",conage" & _
            ",horini" & _
            ",horfim" & _
            ")values" & _
            "(" & M_codcli & _
            "," & M_codprof & _
            ",'" & M_dat & "'" & _
            "," & M_codcon & _
            ",#" & M_horini & "#" & _
            ",#" & M_horfim & "#" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update agendamento set " & _
             "cliage=" & M_codcli & _
            ",codprof=" & M_codprof & _
            ",datage=#" & M_dat & "#" & _
            ",conage=" & M_codcon & _
            ",horini=#" & M_horini & "#" & _
            ",horfim=#" & M_horfim & "#" & _
            " where codage=" & M_cod
            objbanco.executar_comando(sql)
        End If
    End Sub
    Public Function Localizar(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            ' sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "select * from Agendamento where codage=" & dado
        Else
            sql = "select * from agendamento where nom like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar2(ByVal dado As String) As DataTable
        If IsNumeric(dado) Then
            '  sql = "select codcli as Código, nomcli as [Nome do Cliente], Telcli as Telefone, Endcli as Endereço from tabclientes where codcli=" & dado
            sql = "SELECT Agendamento.CodAge, Clientes.CodCli, Funcionarios.NomFun, TabTipoConsulta.CodCon, Agendamento.DatAge, Agendamento.HorIni, Agendamento.HorFim " & _
"FROM Funcionarios, TabTipoConsulta INNER JOIN (Clientes INNER JOIN Agendamento ON Clientes.CodCli = Agendamento.CliAge) ON TabTipoConsulta.CodCon = Agendamento.ConAge" & _
            " where codcli = " & dado
        Else
            sql = "SELECT Agendamento.CodAge, Agendamento.CliAge, Clientes.NomCli, Agendamento.CodProf, Agendamento.DatAge, Agendamento.HorIni, Agendamento.HorFim " & _
" FROM Clientes INNER JOIN Agendamento ON Clientes.CodCli = Agendamento.CliAge WHERE nomcli like '" & dado & "%'"
        End If
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function localizar3(ByVal dado As String) As DataTable
        sql = "SELECT Agendamento.CliAge, Clientes.NomCli from Clientes INNER JOIN Agendamento ON Clientes.[CodCli] = Agendamento.[CliAge] where codcli=" & dado
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function localizar4(ByVal dado As Date, ByVal dado2 As Date, ByVal dado3 As Date) As DataTable
        sql = "select DatAge, HorIni, HorFim FROM Agendamento where datage =#" & dado & "#" & "and horini=#" & dado2 & "#" & " and horfim =#" & dado3 & "#"
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Excluir(ByVal meucod As Long) As Boolean
        If MessageBox.Show("Deseja excluir o Código:" & meucod & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            sql = "Delete from agendamento where codage=" & meucod
            objbanco.Executar_Comando(sql)
            Return True
        End If
    End Function
End Class
