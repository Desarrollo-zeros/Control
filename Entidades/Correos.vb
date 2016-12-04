Public Class Correos
    Public Property user As String
    Public Property Contraseña As String
    Public Property Host As String

    Public Property Nombre As String

    Sub New()

    End Sub

    Sub New(u As String, c As String, h As String, n As String)
        user = u
        Contraseña = c
        Host = h
        Nombre = n
    End Sub
End Class
