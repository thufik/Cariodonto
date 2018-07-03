Imports System
Imports System.Net
Imports System.Net.Mail
Public Class FrmEmail
    Dim cliente As New SmtpClient
    Dim objcontrole As New ClsControle
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim emailorigem As New MailAddress("imaginaerumideais@gmail.com".Trim.ToString)
            Dim emaildestino As New MailAddress(txtdestino.Text.Trim.ToString)
            Dim mensagem As New MailMessage
            mensagem.To.Add(emaildestino)
            mensagem.From = emailorigem
            mensagem.Subject = txtassunto.Text.Trim.ToString
            mensagem.Body = txtcorpo.Text.Trim.ToString
            mensagem.IsBodyHtml = True
            cliente.Host = "smtp.gmail.com".Trim.ToString
            cliente.Port = 587
            Dim creds As New System.Net.NetworkCredential
            creds.UserName = "imaginaerumideais".Trim.ToString
            creds.Password = "iideais2626".Trim.ToString
            cliente.EnableSsl = True
            cliente.Credentials = creds
            cliente.Send(mensagem)
            MsgBox("Email enviado com sucesso")
            objcontrole.Limpar_tela(Me)
            Me.Close()
        Catch ex As Exception
            MsgBox("Não foi possível enviar o email.Mais detalhes:" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Erro ao enviar")

        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objcontrole.Limpar_tela(Me)
        Me.Close()
    End Sub
End Class