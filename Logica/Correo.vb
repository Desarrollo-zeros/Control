Public Class Correo

    Dim lus As New BaseDeDatos.Correos
    Public Function listados() As DataTable
        Dim dt As New DataTable
        dt = lus.consulta
        Return dt
    End Function
    Public Function BuscarCorreos(u As String) As Entidades.Correos
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Correos
            filtro = String.Format("[User]='{0}'", u)
            dr = listados().Select(filtro)(0)
            usu.user = dr.Item("User")
            usu.Contraseña = dr.Item("Contraseña")
            usu.Host = dr.Item("Host")
            usu.Nombre = dr.Item("Nombre")
            Return usu
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function
End Class
