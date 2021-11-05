Imports System.Data.SqlClient
Module Module7
    Public conexion7 As New SqlConnection
    Public comando7 As New SqlCommand
    Public estado7 As String

    Sub enlace7()
        Try
            conexion7.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexion7.Open()
            estado7 = "Conectado"

        Catch ex As Exception
            estado7 = "Desconectado"
        End Try
    End Sub
End Module