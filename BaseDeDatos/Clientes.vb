Imports System.Data.SqlClient

Public Class Clientes
    Inherits ConexionBaseDeDatos
    Dim Comando As SqlCommand
    Const sqlDelete As String = "DELETE FROM Cliente WHERE ID = @ID"

    Public Function InsertarNuevoUsuario(pr As Entidades.Clientes)
        If Me.validaruser(pr.Cedula) Then

            Try

                ConectarBaseDeDatos()
                Comando = New SqlCommand
                Comando.Connection = ConexionBaseDeDato
                Comando.CommandText = "INSERT INTO Cliente VALUES(@Nombre,@Cedula, @Edad,@Telefono,@Correo,@TotalCompra,@Cliente_Fruecuente,@Direcion,@ciudad, @Genero,@imagen)"

                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
                Comando.Parameters.Add("@Cedula", SqlDbType.VarChar)
                Comando.Parameters.Add("@Edad", SqlDbType.Int)
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
                Comando.Parameters.Add("@Correo", SqlDbType.VarChar)
                Comando.Parameters.Add("@TotalCompra", SqlDbType.VarChar)
                Comando.Parameters.Add("@Cliente_Fruecuente", SqlDbType.VarChar)
                Comando.Parameters.Add("@Direcion", SqlDbType.Int)
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar)
                Comando.Parameters.Add("@Genero", SqlDbType.VarChar)
                Comando.Parameters.Add("@Imagen", SqlDbType.Image)

                Comando.Parameters("@Nombre").Value = CStr(pr.Nombre)
                Comando.Parameters("@Cedula").Value = CStr(pr.Cedula)
                Comando.Parameters("@Edad").Value = CInt(pr.edad)
                Comando.Parameters("@Telefono").Value = CStr(pr.Telefono)
                Comando.Parameters("@Correo").Value = CStr(pr.Correo)
                Comando.Parameters("@TotalCompra").Value = CStr(pr.totalCompra)
                Comando.Parameters("@Cliente_Fruecuente").Value = CStr(pr.cliente)
                Comando.Parameters("@Direcion").Value = CInt(pr.Direcion)
                Comando.Parameters("@ciudad").Value = CStr(pr.ciudad)
                Comando.Parameters("@Genero").Value = CStr(pr.Genero)
                Comando.Parameters("@Imagen").Value = (pr.imagen)
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

    End Function

    Public Function eliminarr(b As Entidades.Clientes) As Boolean
        'Dim b As New Entidades.EntidadesUsuarios
        Try
            Dim cmd As New SqlCommand(sqlDelete, ConexionBaseDeDato)
            cmd.Parameters.AddWithValue("@Cedula", b.Cedula)
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

            Comando = New SqlCommand("DELETE FROM Cliente WHERE ID='" & cc & "'", ConexionBaseDeDato)
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


    Public Function EditarUsuario(pr As Entidades.Clientes) As String
        If Me.validaruser(pr.Cedula) Then
            Try
                ConectarBaseDeDatos()
                Comando = New SqlCommand
                Comando.Connection = ConexionBaseDeDato
                Comando.CommandText = "UPDATE Cliente set [Nombre] = @Nombre, [Cedula ] = @Cedula,[Edad]= @Edad,[Telefono] =@Telefono,[Correo] = @Correo,[TotalCompra] =@TotalCompra,[Cliente_Fruecuente] = @Cliente_Fruecuente,[Direcion] = @Direcion,[Ciudad] = @ciudad, [Genero] = @Genero,[Imagen] = @imagen WHERE ID=" & pr.ID & ";"
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
                Comando.Parameters.Add("@Cedula", SqlDbType.VarChar)
                Comando.Parameters.Add("@Edad", SqlDbType.Int)
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
                Comando.Parameters.Add("@Correo", SqlDbType.VarChar)
                Comando.Parameters.Add("@TotalCompra", SqlDbType.VarChar)
                Comando.Parameters.Add("@Cliente_Fruecuente", SqlDbType.VarChar)
                Comando.Parameters.Add("@Direcion", SqlDbType.Int)
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar)
                Comando.Parameters.Add("@Genero", SqlDbType.VarChar)
                Comando.Parameters.Add("@Imagen", SqlDbType.Image)

                Comando.Parameters("@Nombre").Value = CStr(pr.Nombre)
                Comando.Parameters("@Cedula").Value = CStr(pr.Cedula)
                Comando.Parameters("@Edad").Value = CInt(pr.edad)
                Comando.Parameters("@Telefono").Value = CStr(pr.Telefono)
                Comando.Parameters("@Correo").Value = CStr(pr.Correo)
                Comando.Parameters("@TotalCompra").Value = CStr(pr.totalCompra)
                Comando.Parameters("@Cliente_Fruecuente").Value = CStr(pr.cliente)
                Comando.Parameters("@Direcion").Value = CInt(pr.Direcion)
                Comando.Parameters("@ciudad").Value = CStr(pr.ciudad)
                Comando.Parameters("@Genero").Value = CStr(pr.Genero)
                Comando.Parameters("@Imagen").Value = (pr.imagen)
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
            consult = String.Format("SELECT * FROM Cliente WHERE [Cedula]='{0}'", ID)
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
            consult = String.Format("SELECT * FROM Cliente WHERE [Cedula]='{0}'", ID)
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
            Dim da As New SqlDataAdapter("SELECT Cliente.ID, Cliente.Nombre,Cliente.Cedula,Cliente.Edad,Cliente.Correo,Cliente.TotalCompra,Cliente.Cliente_Fruecuente,Cliente.Direcion,Cliente.Ciudad, Cliente.Genero, Cliente.imagen FROM Cliente", ConexionBaseDeDato)
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
