Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexion
    Public conexion1 As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion1 = New SqlConnection("")
            conexion1.Open()
        Catch ex As Exception
            MsgBox("No se pudo Conectar" + ex.ToString)
        End Try
    End Sub
End Module
