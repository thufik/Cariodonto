Public Class Frmpegarfoto
    Dim ret As Image
    Dim objimg As New ArImgCamera.clsArImgCam
    Dim objcontrole As New ClsControle
    Public Function Instanciar() As Image
        Me.ShowDialog()
        Return ret
    End Function

    Private Sub Frmpegarfoto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            objimg.FecharCamera()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frmpegarfoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            objimg = New ArImgCamera.clsArImgCam
            objimg.IniciarCamera(picpegafoto.Handle.ToInt32)
        Catch ex As Exception
            MessageBox.Show("Não foi possível acionar a câmera. Tente reconectá-la ao computador." & vbCrLf & vbCrLf & "Error " & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ret = objimg.CopiarQuadro(Me.picpegafoto, New RectangleF(0, 0, Me.picpegafoto.Width * 2, Me.picpegafoto.Height * 2))

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        objimg.ConfiguraCamera()
    End Sub
End Class