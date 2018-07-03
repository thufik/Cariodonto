Public Class ClsBanco
    Dim conexao As String = "provider=Microsoft.jet.oledb.4.0;data source=BancoCariOdonto.mdb"
    Public objconexao As New OleDb.OleDbConnection(conexao)
    Public Sub abrir_banco()
        Try
            objconexao.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub fechar_banco()
        If objconexao.State = ConnectionState.Open Then
            objconexao.Close()
        End If
    End Sub
    Public Sub executar_comando(ByVal mysql As String)
        Dim objCOMANDO As New OleDb.OleDbCommand(mysql, objconexao)
        Call abrir_banco()
        objCOMANDO.ExecuteNonQuery()
        Call fechar_banco()

    End Sub
    Public Function Navegar(ByVal tabela As String) As DataTable
        Dim sql As String = "select * from " & tabela
        Dim objda As New OleDb.OleDbDataAdapter(sql, objconexao)
        Dim objds As New DataSet
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function
    Public Function CONSULTA(ByVal SQL As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(SQL, objconexao)
        Dim objds As New DataSet
        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
End Class
