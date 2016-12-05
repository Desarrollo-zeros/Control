Public Class Cliente

    Inherits BaseDeDatos.ConexionBaseDeDatos
    Dim lu As New BaseDeDatos.Clientes


  

    Public Function listado() As DataTable
        Dim dt As New DataTable
        dt = lu.consulta
        Return dt
    End Function




    Public Function buscarCedula(u As String) As Entidades.Clientes
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Clientes
            filtro = String.Format("[Cedula]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.ID = dr.Item("ID")
            usu.Nombre = dr.Item("Nombre")
            usu.Cedula = dr.Item("Cedula")
            usu.edad = dr.Item("Edad")
            usu.Telefono = dr.Item("Telefono")
            usu.Correo = dr.Item("Telefono")
            usu.totalCompra = dr.Item("totalCompra")
            usu.cliente = dr.Item("Cliente_Fruecuente")
            usu.Direcion = dr.Item("Direcion")
            usu.ciudad = dr.Item("ciudad")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function BuscarCorreo(u As String) As Entidades.Clientes
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Clientes
            filtro = String.Format("[Correo]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.ID = dr.Item("ID")
            usu.Nombre = dr.Item("Nombre")
            usu.Cedula = dr.Item("Cedula")
            usu.edad = dr.Item("Edad")
            usu.Telefono = dr.Item("Telefono")
            usu.Correo = dr.Item("Telefono")
            usu.totalCompra = dr.Item("totalCompra")
            usu.cliente = dr.Item("Cliente_Fruecuente")
            usu.Direcion = dr.Item("Direcion")
            usu.ciudad = dr.Item("ciudad")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function BuscarID(u As String) As Entidades.Clientes
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Clientes
            filtro = String.Format("[ID]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.ID = dr.Item("ID")
            usu.Nombre = dr.Item("Nombre")
            usu.Cedula = dr.Item("Cedula")
            usu.edad = dr.Item("Edad")
            usu.Telefono = dr.Item("Telefono")
            usu.Correo = dr.Item("Telefono")
            usu.totalCompra = dr.Item("totalCompra")
            usu.cliente = dr.Item("Cliente_Fruecuente")
            usu.Direcion = dr.Item("Direcion")
            usu.ciudad = dr.Item("ciudad")
            usu.imagen = dr.Item("Imagen")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function GuardarUsuario(us As Entidades.Clientes) As String
        Dim i As Integer = lu.InsertarNuevoUsuario(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE " & us.Nombre
        Else
            Return "USUARIO YA REGISTRADO"
        End If

    End Function

    Public Function actualizarUsuario(u As Entidades.Clientes) As String
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
