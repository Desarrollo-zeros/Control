Public Class RecuperarContraseña

    Dim lu As New BaseDeDatos.RecuperarContraseña
    Public Function GuardarRecovery(us As Entidades.RecuperarContraseña) As String
        Dim i As Integer = lu.Recuperar(us)
        If i = 1 Then
            Return ""
        Else
            Return ""
        End If

    End Function
End Class
