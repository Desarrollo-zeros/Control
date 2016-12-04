Imports System.IO

Public Class EntidadesUsuarios
    Private ID As Integer
    Private Usuario As String
    Private Contraseña As String
    Private Nombre As String
    Private Apellido As String
    Private celular As String
    Private correo As String
    Private Cedula As String
    Private rbac As Integer
    Private ima As Byte()
    Public Property IDENTIFICACION As Integer
        Get
            Return ID
        End Get
        Set(ByVal value As Integer)
            ID = value
        End Set
    End Property


    Public Property imagen As Byte()
        Get
            Return ima
        End Get
        Set(ByVal value As Byte())
            ima = value
        End Set
    End Property

    Public Property UsuarioID As String
        Get
            Return Usuario
        End Get
        Set(ByVal value As String)
            Usuario = value
        End Set
    End Property


    Public Property ContraseñaID As String
        Get
            Return Contraseña
        End Get
        Set(ByVal value As String)
            Contraseña = value
        End Set
    End Property

    Public Property CedulaID As String
        Get
            Return Cedula
        End Get
        Set(ByVal value As String)
            Cedula = value
        End Set
    End Property


    Public Property NombreID As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property ApellidID As String
        Get
            Return Apellido
        End Get
        Set(ByVal value As String)
            Apellido = value
        End Set
    End Property

    Public Property TelefonoID As String
        Get
            Return celular
        End Get
        Set(ByVal value As String)
            celular = value
        End Set
    End Property

    Public Property CorreID As String
        Get
            Return correo
        End Get
        Set(ByVal value As String)
            correo = value
        End Set
    End Property



    Public Property Rbacs As Integer
        Get
            Return rbac
        End Get
        Set(ByVal value As Integer)
            rbac = value
        End Set
    End Property

    Public Sub New()

    End Sub

    


    Public Sub New(ids As String, user As String, pass As String, nom As String, cel As String, corr As String, cc As String, r As String, imag As Byte())
        IDENTIFICACION = ids
        UsuarioID = user
        ContraseñaID = pass
        NombreID = nom
        TelefonoID = cel
        CorreID = corr
        CedulaID = cc
        Rbacs = r
        imagen = imag
    End Sub
End Class
