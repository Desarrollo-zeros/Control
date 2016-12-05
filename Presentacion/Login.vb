Public Class Login
    Public lu As New Logica.LogicaUsuario
    Dim usuario As New Entidades.EntidadesUsuarios
    Dim des As New Logica.Enciptar
    Dim vaemail As New Logica.Correo
    Dim cont As Integer = 0
    Public correo As String
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        validar()      
    End Sub

    Sub validar()
            Dim numericCheck As Boolean
            numericCheck = IsNumeric(txtUser.Text)
            If numericCheck = True Then
            cedu()
        Else
            If vaemail.ValidateEmail(txtUser.Text) = True Then
                email()
            Else
                users()
            End If
        End If
    End Sub
    Sub email()
        usuario = lu.BuscarCorreo(txtUser.Text)
        Try
            If (txtUser.Text = "" Or TxtPass.Text = "") Then
                MsgBox("Ingrese los datos")
            Else
                If usuario Is Nothing Then
                    MsgBox("Usuario No existe")
                    cont += 1
                Else
                    Dim con As String = des.Desencriptar(usuario.ContraseñaID)
                    If con = TxtPass.Text Then
                        MsgBox("Bienvenido " & usuario.NombreID)
                        txtUser.Text = ""
                        TxtPass.Text = ""
                        ListadoDeUsarios.rbacname.DropDownStyle = ComboBoxStyle.DropDownList
                        If usuario.Rbacs = 1 Then
                            ListadoDeUsarios.BtnEditar.Enabled = False
                            ListadoDeUsarios.BtnGuardar.Enabled = False
                            ListadoDeUsarios.BtnEliminar.Enabled = False
                            ListadoDeUsarios.BtnSfoto.Enabled = False
                            ListadoDeUsarios.BtnTfoto.Enabled = False
                            ListadoDeUsarios.BtnStart.Enabled = False
                        Else
                            If usuario.Rbacs = 2 Then
                                ListadoDeUsarios.BtnEditar.Enabled = False
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = False
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            Else
                                ListadoDeUsarios.BtnEditar.Enabled = True
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = True
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            End If

                        End If
                        Principal.Show()


                    Else
                        MsgBox("Contraseña invalidad")
                        cont += 1
                    End If
                End If
                If cont = 3 Then
                    MsgBox("3 intentos Fallidos.. Programa se cerrará")
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cedu()
        usuario = lu.buscarCedula(txtUser.Text)
        Try
            If (txtUser.Text = "" Or TxtPass.Text = "") Then
                MsgBox("Ingrese los datos")
            Else
                If usuario Is Nothing Then
                    MsgBox("Usuario No existe")
                    cont += 1
                Else
                    Dim con As String = des.Desencriptar(usuario.ContraseñaID)
                    If con = TxtPass.Text Then
                        MsgBox("Bienvenido " & usuario.NombreID)
                        txtUser.Text = ""
                        TxtPass.Text = ""
                        ListadoDeUsarios.rbacname.DropDownStyle = ComboBoxStyle.DropDownList
                        If usuario.Rbacs = 1 Then
                            ListadoDeUsarios.BtnEditar.Enabled = False
                            ListadoDeUsarios.BtnGuardar.Enabled = False
                            ListadoDeUsarios.BtnEliminar.Enabled = False
                            ListadoDeUsarios.BtnSfoto.Enabled = False
                            ListadoDeUsarios.BtnTfoto.Enabled = False
                            ListadoDeUsarios.BtnStart.Enabled = False
                        Else
                            If usuario.Rbacs = 2 Then
                                ListadoDeUsarios.BtnEditar.Enabled = False
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = False
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            Else
                                ListadoDeUsarios.BtnEditar.Enabled = True
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = True
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            End If

                        End If
                        Principal.Show()


                    Else
                        MsgBox("Contraseña invalidad")
                        cont += 1
                    End If
                End If
                If cont = 3 Then
                    MsgBox("3 intentos Fallidos.. Programa se cerrará")
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub users()
        usuario = lu.buscarPorUser(txtUser.Text)
        Try
            If (txtUser.Text = "" Or TxtPass.Text = "") Then
                MsgBox("Ingrese los datos")
            Else
                If usuario Is Nothing Then
                    MsgBox("Usuario No existe")
                    cont += 1
                Else
                    Dim con As String = des.Desencriptar(usuario.ContraseñaID)
                    If con = TxtPass.Text Then
                        MsgBox("Bienvenido " & usuario.NombreID)
                        txtUser.Text = ""
                        TxtPass.Text = ""
                        ListadoDeUsarios.rbacname.DropDownStyle = ComboBoxStyle.DropDownList
                        If usuario.Rbacs = 1 Then
                            ListadoDeUsarios.BtnEditar.Enabled = False
                            ListadoDeUsarios.BtnGuardar.Enabled = False
                            ListadoDeUsarios.BtnEliminar.Enabled = False
                            ListadoDeUsarios.BtnSfoto.Enabled = False
                            ListadoDeUsarios.BtnTfoto.Enabled = False
                            ListadoDeUsarios.BtnStart.Enabled = False
                        Else
                            If usuario.Rbacs = 2 Then
                                ListadoDeUsarios.BtnEditar.Enabled = False
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = False
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            Else
                                ListadoDeUsarios.BtnEditar.Enabled = True
                                ListadoDeUsarios.BtnGuardar.Enabled = True
                                ListadoDeUsarios.BtnEliminar.Enabled = True
                                ListadoDeUsarios.BtnSfoto.Enabled = True
                                ListadoDeUsarios.BtnTfoto.Enabled = True
                                ListadoDeUsarios.BtnStart.Enabled = True
                            End If

                        End If
                        Principal.Show()


                    Else
                        MsgBox("Contraseña invalidad")
                        cont += 1
                    End If
                End If
                If cont = 3 Then
                    MsgBox("3 intentos Fallidos.. Programa se cerrará")
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)
        Clipboard.Clear()
    End Sub


    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs)
        Clipboard.Clear()
    End Sub


    Private Sub txtUser_MouseDown(sender As Object, e As MouseEventArgs) Handles txtUser.MouseDown
        If (e.Button = MouseButtons.Right) Then
            TxtPass.ReadOnly = True
            txtUser.ReadOnly = True
            Clipboard.Clear()
        Else
            TxtPass.ReadOnly = False
            txtUser.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub

    Private Sub TxtPass_MouseDown(sender As Object, e As MouseEventArgs) Handles TxtPass.MouseDown
        If (e.Button = MouseButtons.Right) Then

            TxtPass.ReadOnly = True
            txtUser.ReadOnly = True
            Clipboard.Clear()
        Else
            TxtPass.ReadOnly = False
            txtUser.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' xtPass.PasswordChar = "*"
    End Sub

    Sub recuperar()
        Presentacion.RecuperarContraseña.Show()
    End Sub

    Private Sub BtnRecupear_Click(sender As Object, e As EventArgs) Handles BtnRecupear.Click
        recuperar()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class
