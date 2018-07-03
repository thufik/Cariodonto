﻿Public Class ClsControle
    Dim objimg As New ArImgCamera.clsArImgCam
    Public Function PermitirSónumeros(ByVal tecla As String) As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Then

        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            Return True
        End If
    End Function
    Public Function PermitirSóletas(ByVal tecla As String) As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Or Asc(tecla) = 32 Then
        ElseIf Asc(tecla) <= 65 Or Asc(tecla) > 90 And Asc(tecla) < 97 Or Asc(tecla) > 122 Then
            Return True
        End If
    End Function
    Public Function Testar_vazio(ByVal umatela As Object) As Boolean
        Dim controle As Object
        For Each controle In umatela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is RadioButton Or TypeOf controle Is MaskedTextBox Then
                If controle.text = "" And controle.tag <> "x" Then
                    MessageBox.Show("Preencha os campos Obrigatórios")
                    controle.focus()
                    Return True
                End If
            End If
        Next
    End Function
    Public Sub Limpar_tela(ByVal umatela As Object)
        Dim controle As Object
        For Each controle In umatela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Then
                controle.text = ""
            ElseIf TypeOf controle Is CheckBox Then
                controle.checked = False
            ElseIf TypeOf controle Is ComboBox Then
                controle.selectedindex = 0
            ElseIf TypeOf controle Is RadioButton Then
                controle.checked = False
            ElseIf TypeOf controle Is DateTimePicker Then
                controle.value = Now
            ElseIf TypeOf controle Is PictureBox Then
                controle.image = Nothing
            End If

        Next
    End Sub
    Public Sub habilitar_tela(ByVal umatela As Object, ByVal tipo As Boolean)
        Dim controle As Object
        For Each controle In umatela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Or TypeOf controle Is CheckBox Or TypeOf controle Is ComboBox Or TypeOf controle Is DateTimePicker Or TypeOf controle Is Button Or TypeOf controle Is Panel Then
                If controle.tag <> "X" Then
                    controle.enabled = tipo
                End If
            End If
        Next
    End Sub
    Public Sub BufferIMG(ByVal imagem As Image, ByVal nomefun As String)
        Dim strIMG As String = Application.StartupPath & "\fotos\" & nomefun & ".jpg"
        imagem.Save(strIMG)
        Dim valor As Byte() = objimg.BufferizaIMG(strIMG)
    End Sub


    'Public Sub habilitar_botoes(ByVal umatela As Object, ByVal tipo As Boolean)
    'Dim controle As Object
    'For Each controle In umatela.controls
    'If TypeOf controle Is Button Then
    'If controle.name = "btngravar" Then
    'controle.enabled = Not tipo
    'ElseIf controle.name = "BTNSAI" Or controle.name.ToString.ToUpper = "BTNCAN" Then
    'controle.ENABLED = True
    'Else
    'controle.ENABLED = tipo
    'End If
    'End If

    '        Next
    '   End Sub


    Public Function ValidEMail(ByVal sEMail As String) As Boolean
        Dim nCharacter As Integer
        Dim Count As Integer
        Dim sLetra As String
        'Verifica se o e-mail tem no MÍNIMO 5
        'caracteres (a@b.c)
        If Len(sEMail) < 5 Then
            'O e-mail é inválido, pois tem menos
            'de 5 caracteres
            ValidEMail = False
            ' MsgBox("O e-mail digitado tem menos de 5 " & _
            '"caracteres!!!")
            Exit Function
            'Verificar a existencia de arrobas http://www.babooforum.com.br/idealbb/images/smilies/22.gif'>!!! Exit Function
        ElseIf InStr(sEMail, "@") = Len(sEMail) Then
            'O e-mail é inválido, pois termina
            'com uma @
            ValidEMail = False
            'MsgBox("O e-mail termina com uma arroba!!!")
            Exit Function
        End If
        nCharacter = 0
        Count = 0
        'Verificar a existencia de pontos (.) no e-mail
        For nCharacter = 1 To Len(sEMail)
            If Mid(sEMail, nCharacter, 1) = "." Then
                'OPA!!! Achou um ponto!!!
                'Soma 1 ao contador
                Count = Count + 1
            End If
        Next
        'Verifica o número de pontos.
        'TEM que ter PELO MENOS UM ponto.
        If Count < 1 Then
            'O e-mail é inválido, pois não tem pontos.
            ValidEMail = False
            ' MsgBox("O e-mail é inválido, pois não contém " & _
            ' "pontos (.)!!!")
            Exit Function
        Else
            'O e-mail tem pelo menos 1 ponto.
            'Verificar a posição do ponto:
            If InStr(sEMail, ".") = 1 Then
                'O e-mail é inválido, pois começa
                'com um ponto
                ValidEMail = False
                ' MsgBox("O e-mail foi iniciado com um ponto (.)!!!")
                Exit Function
            ElseIf InStr(sEMail, ".") = Len(sEMail) Then
                'O e-mail é inválido, pois termina
                'com um ponto.
                ValidEMail = False
                'MsgBox("O e-mail termina com um ponto (.)!!!")
                Exit Function
                'ElseIf InStr(InStr(sEMail, "@"), sEMail, ".") = 0 Then
                'O e-mail é inválido, pois termina
                'com um ponto.
                ValidEMail = False
                ' MsgBox("O e-mail não tem nenhum ponto (.) após " & _
                ' "a arroba !!! ")
                Exit Function
            End If
        End If
        nCharacter = 0
        Count = 0
        'Verifica se o e-mail não tem pontos
        'consecutivos (..) após a arroba http://www.babooforum.com.br/idealbb/images/smilies/22.gif'>!!! Exit Function
        'Verifica se o e-mail tem caracteres
        'inválidos
        For nCharacter = 1 To Len(sEMail)
            sLetra = Mid$(sEMail, nCharacter, 1)
            If Not (LCase(sLetra) Like "[a-z]" Or sLetra = _
            "@" Or sLetra = "." Or sLetra = "-" Or _
            sLetra = "_" Or IsNumeric(sLetra)) Then
                'O e-mail é inválido, pois tem
                'caracteres inválidos
                ValidEMail = False
                'MsgBox("Foi digitado um caracter inválido " & _
                '"no e-mail!!!")
                Exit Function
            End If
        Next
        nCharacter = 0
        'Bem, se a verificação chegou até aqui
        'é porque o e-mail é válido, então...
        ValidEMail = True
    End Function

    Public Sub habilitar_botoes(ByVal umatela As Object, ByVal tipo As Boolean)
        Dim controle As Object
        For Each controle In umatela.controls
            If TypeOf controle Is Button Then
                If controle.name.ToString.ToUpper = "BTNGRAVAR" Then
                    controle.enabled = Not tipo
                ElseIf controle.name.ToString.ToUpper = "BTNSAI" Or controle.name.ToString.ToUpper = "BTNCAN" Then
                    controle.ENABLED = True
                Else
                    controle.ENABLED = tipo
                End If
            End If

        Next
    End Sub
    Public Function PermitirSónumerosVirgula(ByVal tecla As String) As Boolean
        If Asc(tecla) = 8 Or Asc(tecla) = 13 Or Asc(tecla) = 44 Then

        ElseIf Asc(tecla) < 48 Or Asc(tecla) > 57 Then
            Return True
        End If
    End Function
    Public Sub Limpar_tela2(ByVal umatela As Object)
        Dim controle As Object
        For Each controle In umatela.controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Then
                controle.text = ""
            ElseIf TypeOf controle Is CheckBox Then
                controle.checked = False
            ElseIf TypeOf controle Is RadioButton Then
                controle.checked = False
            ElseIf TypeOf controle Is DateTimePicker Then
                controle.value = Now
            ElseIf TypeOf controle Is PictureBox Then
                controle.image = Nothing
            End If

        Next
    End Sub
End Class
