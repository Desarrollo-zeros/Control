Imports System.Net
Imports System.Net.Mail
Public Class RecuperarContraseña

    Public lu As New Logica.LogicaUsuario
    Dim usuario As New Entidades.EntidadesUsuarios
    Dim contraseña As String
    Dim Nombre As String
    Dim User As String
    Dim des As New Logica.Enciptar
    Dim Corr As New Logica.Correo
    Dim rec As New Logica.RecuperarContraseña
    Dim recv As New Entidades.RecuperarContraseña



    Private Sub BtnRecuperar_Click(sender As Object, e As EventArgs) Handles BtnRecuperar.Click
        recuperar()

    End Sub



    Sub recuperar()
        Try
            If Corr.ValidateEmail(txtCorreo.Text) = True Then
                usuario = lu.BuscarCorreo(txtCorreo.Text)
                If (txtCorreo.Text = "") Then
                    MsgBox("Debes rellenar bien los datos")
                Else
                    If usuario Is Nothing Then
                        MsgBox("correo no existe")
                    Else
                        MsgBox("en minutos llegara a su correo electronico su contraseña")
                        contraseña = des.Desencriptar(usuario.ContraseñaID)
                        Nombre = usuario.NombreID
                        User = usuario.UsuarioID
                        correo()
                      


                    End If
                End If
            Else
                MsgBox("El correo ingresado no tiene valores reconocidos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Sub correo()
        Try
            Dim usuarios As New Entidades.Correos
            Dim s As String = "carlos-ac97"
            usuarios = Corr.BuscarCorreos(s)
            If usuarios Is Nothing Then
                MsgBox("Problemas tecnico")
                MsgBox(usuarios.user)
            Else
                Dim Puerto As Integer = 25
                Dim SMTP As String = "smtp.live.com"
                Dim mastercorreo As String = usuarios.user
                Dim direcion As String = usuarios.Host
                Dim correoenviar As String
                Dim pass As String = des.Desencriptar(usuarios.Contraseña)
                Dim asusnto As String = "Recuperacion de contraseña"
                correoenviar = txtCorreo.Text
                Dim asunto As String = "Recuperacion de contraseña"
                Dim mensaje As String = "Buenas señor(A) " & Nombre & " Usted a perdido su contraseña, esto son " & _
                    " Lo siguientes datos de tu cuenta " & _
                     vbCr & " Su usuario es : " & User & _
                     vbCr & " Su Contraseña es: " & contraseña & _
                     vbCr & " Pedimos el favor ser mas atento y no olvidar tu contraseña o dejarla ver de alguien mas "
                Dim zeros As String = usuarios.Nombre
                Dim _Message As New System.Net.Mail.MailMessage()
                Dim _SMTP As New System.Net.Mail.SmtpClient
                _SMTP.Credentials = New System.Net.NetworkCredential(mastercorreo + direcion, pass)
                _SMTP.Host = SMTP
                _SMTP.Port = Puerto
                _SMTP.EnableSsl = True
                _Message.[To].Add(correoenviar.ToString)
                _Message.From = New System.Net.Mail.MailAddress(mastercorreo.ToString + direcion.ToString, zeros.ToString, System.Text.Encoding.UTF8)
                _Message.Subject = asunto.ToString
                _Message.SubjectEncoding = System.Text.Encoding.UTF8
                _Message.Body = mensaje.ToString
                _Message.BodyEncoding = System.Text.Encoding.UTF8
                _Message.Priority = System.Net.Mail.MailPriority.Normal
                _Message.IsBodyHtml = False
                _Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                Try
                    _SMTP.Send(_Message)
                    MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
                    recv.ID = usuario.IDENTIFICACION
                    recv.Correo = usuario.CorreID
                    recv.Usuario = usuario.UsuarioID
                    rec.GuardarRecovery(recv)
                Catch ex As System.Net.Mail.SmtpException
                    MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
                End Try
                _Message = Nothing
                _SMTP = Nothing
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub RecuperarContraseña_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class