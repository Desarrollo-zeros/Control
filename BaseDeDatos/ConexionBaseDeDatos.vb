﻿Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class ConexionBaseDeDatos

    Private ruta As String
    Private conexion As SqlConnection

    Sub New()
        ruta = My.Settings.cnx
        conexion = New SqlConnection(ruta)
    End Sub

    Public ReadOnly Property ConexionBaseDeDato As SqlConnection
        Get
            Return conexion
        End Get
    End Property

    Public Function ConectarBaseDeDatos() As Boolean
        Try
            conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function DesconetarseBaseDeDatos() As Boolean
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function EjecutarConsulta(ssql As String) As DataTable
        Try
            Dim da As New SqlDataAdapter(ssql, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


End Class
