Imports System.Data.SqlClient
Module Module6
    Public conexion6 As New SqlConnection
    Public comando6 As New SqlCommand
    Public estado6 As String

    Sub enlace6()
        Try
            conexion6.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexion6.Open()
            estado6 = "Conectado"

        Catch ex As Exception
            estado6 = "Desconectado"
        End Try
    End Sub
End Module

