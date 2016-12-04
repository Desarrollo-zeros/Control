Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Correos
    Inherits ConexionBaseDeDatos
    Dim Comando As SqlCommand
    Public Function consulta() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT * FROM envioEmail", ConexionBaseDeDato)
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
