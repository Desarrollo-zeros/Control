Public Class Clientes
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Cedula As String
    Public Property edad As Integer
    Public Property Genero As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property totalCompra As Double
    Public Property cliente As String
    Public Property Direcion As String
    Public Property ciudad As String
    Public Property imagen As Byte()

    Sub New()

    End Sub

    Sub New(i As Integer, n As String, c As String, e As String, g As String, t As String, co As String, tot As String, cl As String, d As String, ci As String, im As Byte())
        ID = i
        Nombre = n
        Cedula = c
        edad = e
        Genero = g
        Telefono = t
        Correo = co
        totalCompra = tot
        cliente = cl
        Direcion = d
        ciudad = ci
        imagen = im
    End Sub

   
End Class
