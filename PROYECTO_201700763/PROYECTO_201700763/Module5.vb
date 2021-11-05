Imports System.Data.SqlClient
Module Module5
    Public conexion5 As New SqlConnection
    Public comando5 As New SqlCommand
    Public estado5 As String
    Sub enlace5()
        Try
            conexion5.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexion5.Open()
            estado5 = "Conectado"

        Catch ex As Exception
            estado5 = "Desconectado"
        End Try
    End Sub

End Module
