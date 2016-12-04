Public Class RecuperarContraseña
    Public IDs As String
    Public correoss As String
    Public users As String


    Public Property ID As String
        Get
            Return IDs
        End Get
        Set(ByVal value As String)
            IDs = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return correoss
        End Get
        Set(ByVal value As String)
            correoss = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return users
        End Get
        Set(ByVal value As String)
            users = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(i As String, c As String, u As String)
        ID = i
        Correo = c
        Usuario = u
    End Sub
End Class
