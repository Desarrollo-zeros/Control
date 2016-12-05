Imports System.Data.SqlClient

Public Class Ciudad

    Inherits ConexionBaseDeDatos
    Dim Comando As SqlCommand

    Public Function consulta() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter("SELECT Ciudades.ID, Ciudades.Ciudad FROM Ciudades", ConexionBaseDeDato)
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
