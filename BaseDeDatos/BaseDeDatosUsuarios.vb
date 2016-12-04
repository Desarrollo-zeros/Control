Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class BaseDeDatosUsuarios
    Inherits ConexionBaseDeDatos
    Dim Comando As SqlCommand
    Const sqlDelete As String = "DELETE FROM account WHERE ID = @ID"
    
    Public Function InsertarNuevoUsuario(pr As Entidades.EntidadesUsuarios)
        If Me.validaruser(pr.UsuarioID) Then
            If Me.validarUsuario(pr.CedulaID) Then
                Try

                    ConectarBaseDeDatos()
                    Comando = New SqlCommand
                    Comando.Connection = ConexionBaseDeDato
                    Comando.CommandText = "INSERT INTO account VALUES(@Usuario,@Contraseña,@Nombre,@Apellido,@Telefono,@Correo,@Cedula,@rbac,@imagen)"
                    Comando.Parameters.Add("@Usuario", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Contraseña", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Apellido", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Correo", SqlDbType.VarChar)
                    Comando.Parameters.Add("@Cedula", SqlDbType.VarChar)
                    Comando.Parameters.Add("@rbac", SqlDbType.Int)
                    Comando.Parameters.Add("@imagen", SqlDbType.Image)

                    Comando.Parameters("@Usuario").Value = CStr(pr.UsuarioID)
                    Comando.Parameters("@Contraseña").Value = (pr.ContraseñaID)
                    Comando.Parameters("@Nombre").Value = CStr(pr.NombreID)
                    Comando.Parameters("@Apellido").Value = CStr(pr.ApellidID)
                    Comando.Parameters("@Telefono").Value = CStr(pr.TelefonoID)
                    Comando.Parameters("@Correo").Value = CStr(pr.CorreID)
                    Comando.Parameters("@Cedula").Value = CStr(pr.CedulaID)
                    Comando.Parameters("@rbac").Value = CInt(pr.Rbacs)
                    Comando.Parameters("@imagen").Value = (pr.imagen)
                    If Comando.ExecuteNonQuery Then
                        Return 1
                    Else
                        Return 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return 0
                Finally
                    DesconetarseBaseDeDatos()
                End Try
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    Public Function eliminarr(b As Entidades.EntidadesUsuarios) As Boolean
        'Dim b As New Entidades.EntidadesUsuarios
        Try
            Dim cmd As New SqlCommand(sqlDelete, ConexionBaseDeDato)
            cmd.Parameters.AddWithValue("@Cedula", b.CedulaID)
            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            DesconetarseBaseDeDatos()
        End Try

    End Function


    Public Function eliminar(cc As String) As Boolean
        Try
            ConectarBaseDeDatos()

            Comando = New SqlCommand("DELETE FROM account WHERE ID='" & cc & "'", ConexionBaseDeDato)
            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DesconetarseBaseDeDatos()
        End Try



    End Function


    Public Function EditarUsuario(pr As Entidades.EntidadesUsuarios) As String
        If Me.validaruser(pr.UsuarioID) Then
            Try
                ConectarBaseDeDatos()
                Comando = New SqlCommand
                Comando.Connection = ConexionBaseDeDato
                Comando.CommandText = "UPDATE account set [Usuario] = @Usuario, [Contraseña] = @Contraseña," & _
                "[Nombre] = @Nombre, [Apellido] = @Apellido,[Telefono] = @Telefono,[Correo] = @Correo, [Cedula] = @Cedula, " & _
                "[rbac] = @rbac,[imagen] = @imagen WHERE ID=" & pr.IDENTIFICACION & ";"
                Comando.Parameters.Add("@Usuario", SqlDbType.VarChar)
                Comando.Parameters.Add("@Contraseña", SqlDbType.VarChar)
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
                Comando.Parameters.Add("@Apellido", SqlDbType.VarChar)
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
                Comando.Parameters.Add("@Correo", SqlDbType.VarChar)
                Comando.Parameters.Add("@Cedula", SqlDbType.VarChar)
                Comando.Parameters.Add("@rbac", SqlDbType.Int)
                Comando.Parameters.Add("@imagen", SqlDbType.Image)
                Comando.Parameters("@Usuario").Value = CStr(pr.UsuarioID)
                Comando.Parameters("@Contraseña").Value = (pr.ContraseñaID)
                Comando.Parameters("@Nombre").Value = CStr(pr.NombreID)
                Comando.Parameters("@Apellido").Value = CStr(pr.ApellidID)
                Comando.Parameters("@Telefono").Value = CStr(pr.TelefonoID)
                Comando.Parameters("@Correo").Value = CStr(pr.CorreID)
                Comando.Parameters("@Cedula").Value = CStr(pr.CedulaID)
                Comando.Parameters("@rbac").Value = CInt(pr.Rbacs)
                Comando.Parameters("@imagen").Value = (pr.imagen)
                If Comando.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            Finally
                DesconetarseBaseDeDatos()
            End Try
        Else
            Return 0
        End If

    End Function


    Public Function validarUsuario(ID As Integer) As Boolean
        Try
            ConectarBaseDeDatos()
            Dim tabla As SqlDataReader
            Dim consult As String
            consult = String.Format("SELECT * FROM account WHERE [Cedula]='{0}'", ID)
            Comando = New SqlCommand(consult, ConexionBaseDeDato)
            tabla = Comando.ExecuteReader
            If tabla.HasRows Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function validaruser(ID As String) As Boolean
        Try
            ConectarBaseDeDatos()
            Dim tabla As SqlDataReader
            Dim consult As String
            consult = String.Format("SELECT * FROM account WHERE [Usuario]='{0}'", ID)
            Comando = New SqlCommand(consult, ConexionBaseDeDato)
            tabla = Comando.ExecuteReader
            If tabla.HasRows Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function consulta() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT account.ID, account.Usuario,account.Contraseña,account.Nombre,account.Apellido,account.Telefono,account.Correo,account.Cedula,account.rbac, account.imagen FROM account", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

End Class
