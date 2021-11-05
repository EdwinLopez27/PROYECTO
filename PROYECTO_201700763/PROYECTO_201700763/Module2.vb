Imports System.Data.SqlClient
Module Module2
    Public conexio As New SqlConnection
    Public comand As New SqlCommand
    Public estad As String

    Sub enlac()
        Try
            conexio.ConnectionString = "Data Source = localhost;Initial Catalog=BD_201700763;Integrated Security=True"
            conexio.Open()
            estad = "Conectado"

        Catch ex As Exception
            estad = "Desconectado"
        End Try
    End Sub

End Module
