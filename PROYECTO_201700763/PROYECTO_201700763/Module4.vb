Imports System.Data.SqlClient
Module Module4

    Public conexion4 As New SqlConnection
    Public comando4 As New SqlCommand
    Public estado4 As String

    Sub enlace4()
        Try
            conexion4.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexion4.Open()
            estado4 = "Conectado"

        Catch ex As Exception
            estado4 = "Desconectado"
        End Try
    End Sub

End Module

