Public Class ClsAnamnese
    Dim sql As String
    Dim objbanco As New ClsBanco


    Dim M_codpac As Integer
    Dim M_DoeAtuSN As Boolean
    Dim M_DoeAtuQl As String
    Dim M_AlerSN As Boolean
    Dim M_AlerQ As String
    Dim M_OpeSN As Boolean
    Dim M_OpeQ As String
    Dim M_CicaSN As Boolean
    Dim M_AnesSN As Boolean
    Dim M_HemoSN As Boolean
    Dim M_FebReu As Boolean
    Dim M_ProbRen As Boolean
    Dim M_ProbGas As Boolean
    Dim M_ProbCar As Boolean
    Dim M_ProbRes As Boolean
    Dim M_ProbAle As Boolean
    Dim M_ProbAR As Boolean
    Dim M_ProbDia As Boolean
    Dim M_HipArt As Boolean
    Dim M_AntFam As String
    Dim M_ObsImp As String


    Public Property CodDoPaciente() As Integer
        Get
            Return M_codpac
        End Get
        Set(ByVal value As Integer)
            M_codpac = value
        End Set
    End Property
    Public Property DoençaAtual() As Boolean
        Get
            Return M_DoeAtuSN
        End Get
        Set(ByVal value As Boolean)
            M_DoeAtuSN = value
        End Set
    End Property
    Public Property DoençaAtualQual() As String
        Get
            Return M_DoeAtuQl
        End Get
        Set(ByVal value As String)
            M_DoeAtuQl = value
        End Set
    End Property
    Public Property AlergiaSN() As Boolean
        Get
            Return M_AlerSN
        End Get
        Set(ByVal value As Boolean)
            M_AlerSN = value
        End Set
    End Property
    Public Property AlergiaQual() As String
        Get
            Return M_AlerQ
        End Get
        Set(ByVal value As String)
            M_AlerQ = value
        End Set
    End Property
    Public Property OperacaoSN() As Boolean
        Get
            Return M_OpeSN
        End Get
        Set(ByVal value As Boolean)
            M_OpeSN = value
        End Set
    End Property
    Public Property OperacaoQual() As String
        Get
            Return M_OpeQ
        End Get
        Set(ByVal value As String)
            M_OpeQ = value
        End Set
    End Property


    Public Property CicatrizacaoSN() As Boolean
        Get
            Return M_CicaSN
        End Get
        Set(ByVal value As Boolean)
            M_CicaSN = value
        End Set
    End Property
    Public Property AnestesiaSN() As Boolean
        Get
            Return M_AnesSN
        End Get
        Set(ByVal value As Boolean)
            M_AnesSN = value
        End Set
    End Property
    Public Property HemorragiaSN() As Boolean
        Get
            Return M_HemoSN
        End Get
        Set(ByVal value As Boolean)
            M_HemoSN = value
        End Set
    End Property
    Public Property FebreReumatica() As Boolean
        Get
            Return M_FebReu
        End Get
        Set(ByVal value As Boolean)
            M_FebReu = value
        End Set
    End Property
    Public Property ProblemaRenal() As Boolean
        Get
            Return M_ProbRen
        End Get
        Set(ByVal value As Boolean)
            M_ProbRen = value
        End Set
    End Property
    Public Property ProblemaGastrico() As Boolean
        Get
            Return M_ProbGas
        End Get
        Set(ByVal value As Boolean)
            M_ProbGas = value
        End Set
    End Property
    Public Property ProblemaCardiaco() As Boolean
        Get
            Return M_ProbCar
        End Get
        Set(ByVal value As Boolean)
            M_ProbCar = value
        End Set
    End Property
    Public Property ProblemaRespiratorio() As Boolean
        Get
            Return M_ProbRes
        End Get
        Set(ByVal value As Boolean)
            M_ProbRes = value
        End Set
    End Property
    Public Property ProblemaAlergico() As Boolean
        Get
            Return M_ProbAle
        End Get
        Set(ByVal value As Boolean)
            M_ProbAle = value
        End Set
    End Property
    Public Property ProblemasArticularesOuReumatismo() As Boolean
        Get
            Return M_ProbAR
        End Get
        Set(ByVal value As Boolean)
            M_ProbAR = value
        End Set
    End Property
    Public Property ProblemaDiabetes() As Boolean
        Get
            Return M_ProbDia
        End Get
        Set(ByVal value As Boolean)
            M_ProbDia = value
        End Set
    End Property
    Public Property HipertensaoArterial() As Boolean
        Get
            Return M_HipArt
        End Get
        Set(ByVal value As Boolean)
            M_HipArt = value
        End Set
    End Property
    Public Property AntescedentesFamiliares() As String
        Get
            Return M_AntFam
        End Get
        Set(ByVal value As String)
            M_AntFam = value
        End Set
    End Property
    Public Property ObservacoesImportantes() As String
        Get
            Return M_ObsImp
        End Get
        Set(ByVal value As String)
            M_ObsImp = value
        End Set
    End Property
    Public Sub gravar(ByVal novo As Boolean)
        If novo = True Then
            sql = " insert into Anamnese" & _
            "(CodPac" & _
            ",DoeAtuSN" & _
            ",DoeAtuQ" & _
            ",AlerSN" & _
            ",AlerQ" & _
            ",OpeSN" & _
            ",OpeQ" & _
            ",CicaSN" & _
            ",AnesSN" & _
            ",HemoSN" & _
            ",FebReu" & _
            ",probren" & _
            ",ProbGas" & _
            ",ProbCar" & _
            ",ProbRes" & _
            ",ProbAle" & _
            ",ProbAR" & _
            ",ProbDia" & _
            ",HipArt" & _
            ",AntFam" & _
            ",ObsImp)" & _
            "values" & _
            "(" & M_codpac & "" & _
            "," & M_DoeAtuSN & " " & _
            ",'" & M_DoeAtuQl & "'" & _
            "," & M_AlerSN & "" & _
            ",'" & M_AlerQ & "'" & _
            "," & M_OpeSN & "" & _
            ",'" & M_OpeQ & "'" & _
            "," & M_CicaSN & "" & _
            "," & M_AnesSN & "" & _
            "," & M_HemoSN & "" & _
            "," & M_FebReu & "" & _
            "," & M_ProbRen & "" & _
            "," & M_ProbGas & "" & _
            "," & M_ProbCar & "" & _
            "," & M_ProbRes & "" & _
            "," & M_ProbAle & "" & _
            "," & M_ProbAR & "" & _
            "," & M_ProbDia & "" & _
            "," & M_HipArt & "" & _
            ",'" & M_AntFam & "'" & _
            ",'" & M_ObsImp & "'" & _
            ")"
            objbanco.executar_comando(sql)
        Else
            sql = "update Anamnese set" & _
           " DoeAtuSN=" & M_DoeAtuSN & "" & _
           ",DoeAtuQ='" & M_DoeAtuQl & "'" & _
           ",AlerSN=" & M_DoeAtuSN & "" & _
           ",AlerQ='" & M_AlerQ & "'" & _
           ",OpeSN=" & M_OpeSN & "" & _
           ",OpeQ='" & M_OpeQ & "'" & _
           ",CicaSN=" & M_CicaSN & "" & _
           ",AnesSN=" & M_AnesSN & "" & _
           ",HemoSN=" & M_HemoSN & "" & _
           ",FebReu=" & M_FebReu & "" & _
           ",ProbRen=" & M_ProbRen & "" & _
           ",ProbGas=" & M_ProbGas & "" & _
           ",ProbCar=" & M_ProbCar & "" & _
           ",ProbRes=" & M_ProbRes & "" & _
           ",ProbAle=" & M_ProbAle & "" & _
           ",ProbAR=" & M_ProbAR & "" & _
           ",ProbDia=" & M_ProbDia & "" & _
           ",HipArt=" & M_HipArt & "" & _
            ",AntFam='" & M_AntFam & "'" & _
            ",ObsImp='" & M_ObsImp & "'" & _
            "where codpac=" & M_codpac
            objbanco.executar_comando(sql)

        End If
    End Sub
    Public Function localizar(ByVal dado As String) As DataTable
        sql = "SELECT codcli,NomCli from Clientes  where codcli=" & dado
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function localizaranamnese(ByVal dado As String) As DataTable
        sql = "SELECT * from anamnese where codpac = " & dado
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function











End Class
