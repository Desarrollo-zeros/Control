Imports System.Data.SqlClient

Public Class LogicaUsuario
    Inherits BaseDeDatos.ConexionBaseDeDatos
    Dim lu As New BaseDeDatos.BaseDeDatosUsuarios


    Dim selet As String = "SELECT ID, Usuario, Contraseña, Nombre, Apellido, Telefono, Correo, Cedula, rbac " & _
    "FROM account WHERE Usuario = @Usuario  AND Contraseña = @Contraseña"


    Public Function listado() As DataTable
        Dim dt As New DataTable
        dt = lu.consulta
        Return dt
    End Function

 


    Public Function buscarPorUser(u As String) As Entidades.EntidadesUsuarios
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.EntidadesUsuarios
            filtro = String.Format("[Usuario]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.IDENTIFICACION = dr.Item("ID")
            usu.UsuarioID = dr.Item("Usuario")
            usu.ContraseñaID = dr.Item("Contraseña")
            usu.NombreID = dr.Item("Nombre")
            usu.ApellidID = dr.Item("Apellido")
            usu.TelefonoID = dr.Item("Telefono")
            usu.CorreID = dr.Item("Correo")
            usu.CedulaID = dr.Item("Cedula")
            usu.Rbacs = dr.Item("rbac")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function buscarCedula(u As String) As Entidades.EntidadesUsuarios
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.EntidadesUsuarios
            filtro = String.Format("[Cedula]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.IDENTIFICACION = dr.Item("ID")
            usu.UsuarioID = dr.Item("Usuario")
            usu.ContraseñaID = dr.Item("Contraseña")
            usu.NombreID = dr.Item("Nombre")
            usu.ApellidID = dr.Item("Apellido")
            usu.TelefonoID = dr.Item("Telefono")
            usu.CorreID = dr.Item("Correo")
            usu.CedulaID = dr.Item("Cedula")
            usu.Rbacs = dr.Item("rbac")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function BuscarCorreo(u As String) As Entidades.EntidadesUsuarios
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.EntidadesUsuarios
            filtro = String.Format("[Correo]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.IDENTIFICACION = dr.Item("ID")
            usu.UsuarioID = dr.Item("Usuario")
            usu.ContraseñaID = dr.Item("Contraseña")
            usu.NombreID = dr.Item("Nombre")
            usu.ApellidID = dr.Item("Apellido")
            usu.TelefonoID = dr.Item("Telefono")
            usu.CorreID = dr.Item("Correo")
            usu.CedulaID = dr.Item("Cedula")
            usu.Rbacs = dr.Item("rbac")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function BuscarID(u As String) As Entidades.EntidadesUsuarios
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.EntidadesUsuarios
            filtro = String.Format("[ID]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.IDENTIFICACION = dr.Item("ID")
            usu.UsuarioID = dr.Item("Usuario")
            usu.ContraseñaID = dr.Item("Contraseña")
            usu.NombreID = dr.Item("Nombre")
            usu.ApellidID = dr.Item("Apellido")
            usu.TelefonoID = dr.Item("Telefono")
            usu.CorreID = dr.Item("Correo")
            usu.CedulaID = dr.Item("Cedula")
            usu.Rbacs = dr.Item("rbac")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GuardarUsuario(us As Entidades.EntidadesUsuarios) As String
        Dim i As Integer = lu.InsertarNuevoUsuario(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE " & us.NombreID
        Else
            Return "USUARIO YA REGISTRADO"
        End If

    End Function

    Public Function actualizarUsuario(u As Entidades.EntidadesUsuarios) As String
        If lu.EditarUsuario(u) Then
            Return "ACTUALIZADO CORRECTAMENTE"
        Else
            Return "ERROR AL ACTUALIZAR"
        End If
    End Function

    Public Function eliminarUsuario(cc As String) As String
        If lu.eliminar(cc) Then
            Return "ELIMINADO CORRECTAMENTE"
        Else
            Return "ERROR AL ELIMINAR"
        End If

    End Function
   
End Class
