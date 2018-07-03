Public Class ClsTipo
    Dim sql As String
    Dim M_tabe As String
    Dim objbanco As New ClsBanco

    'ESTA CLASSE USA O POLIMORFISMO CONCEITO QUE UMA MESMA CLASSE FAZ
    'COISAS DIFERENTES BASTANDO APENAS TROCAR O PARÂMETRO NA INSTANCIA DA CLASSE

    Public Function Excluir(ByVal codigo As Integer) As Boolean
        sql = "delete from " & M_tabe & " where id=" & codigo
        objbanco.executar_comando(sql)
        Return True
    End Function


    'CONSTRUTOR

    'Public Sub New(ByVal tabela As String)
    'M_tabe = tabela

    ' End Sub

    Public Function POPULAR(ByVal tabela) As DataTable
        sql = "SELECT * FROM " & tabela
        Dim objda As New OleDb.OleDbDataAdapter(sql, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function


    Public Function POPULAR_2(ByVal SQL) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(SQL, objbanco.objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function


    Public Function POPULAR_comStored(ByVal fun As Integer, ByVal dia As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("StrBuscaAgendamento", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = fun
        objda.SelectCommand.Parameters("ope2").Value = dia
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function POPULAR_comStored2(ByVal fun As Integer, ByVal dia As Date, ByVal horainicial As Date, ByVal horafinal As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("Strconsulta2", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope3", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope4", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = fun
        objda.SelectCommand.Parameters("ope2").Value = dia
        objda.SelectCommand.Parameters("ope3").Value = horainicial
        objda.SelectCommand.Parameters("ope4").Value = horafinal
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function POPULAR_comStored3(ByVal dia As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("teste", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = dia
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function POPULAR_comStored4(ByVal fun As Integer, ByVal dia As Date, ByVal horainicial As Date, ByVal horafinal As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("consultaexcluir", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope3", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope4", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = fun
        objda.SelectCommand.Parameters("ope2").Value = dia
        objda.SelectCommand.Parameters("ope3").Value = horainicial
        objda.SelectCommand.Parameters("ope4").Value = horafinal
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function POPULAR_comStored5(ByVal fun As Integer, ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("controleacesso", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope3", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = fun
        objda.SelectCommand.Parameters("ope2").Value = dataini
        objda.SelectCommand.Parameters("ope3").Value = datafim
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function POPULAR_comStored6(ByVal data As Date) As DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("clientesniver", objbanco.objconexao))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("ope1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("ope1").Value = Data
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
