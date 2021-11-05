Imports System.Data.SqlClient
Module Module3
    Public conexion3 As New SqlConnection
    Public comando3 As New SqlCommand
    Public estado3 As String

    Sub enlace3()
        Try
            conexion3.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexion3.Open()
            estado3 = "Conectado"

        Catch ex As Exception
            estado3 = "Desconectado"
        End Try
    End Sub

End Module
