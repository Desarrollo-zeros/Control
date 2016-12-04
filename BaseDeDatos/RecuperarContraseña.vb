Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class RecuperarContraseña
    Inherits ConexionBaseDeDatos
    Dim Comando As SqlCommand
    Public Function Recuperar(pr As Entidades.RecuperarContraseña)

        Try
            ConectarBaseDeDatos()
            Comando = New SqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "INSERT INTO Recovery_account VALUES(@ID,@Correo,@Usuario)"
            Comando.Parameters.Add("@ID", SqlDbType.VarChar)
            Comando.Parameters.Add("@Correo", SqlDbType.VarChar)
            Comando.Parameters.Add("@Usuario", SqlDbType.VarChar)
            Comando.Parameters("@ID").Value = (pr.ID.ToString)
            Comando.Parameters("@Correo").Value = (pr.Correo.ToString)
            Comando.Parameters("@Usuario").Value = (pr.Usuario.ToString)
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
    End Function
End Class
