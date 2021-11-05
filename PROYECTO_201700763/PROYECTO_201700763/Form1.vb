Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        MsgBox("La base de datos esta conectada correctamente")
        Label1.Text = estado

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sql As String
        sql = "SELECT * FROM USUARIO WHERE USUARIO= '" & TextBox1.Text & "' AND CONTRASEÑA='" & TextBox2.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, conexion)
        Dim dr As SqlClient.SqlDataReader

        dr = cmd.ExecuteReader

        If dr.Read = True Then
            MessageBox.Show("Bienvenido")
            Me.Hide()
            Form3.Show()

        End If

        TextBox1.Text = ""
        TextBox2.Text = ""






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        enlace()
        MsgBox("La base de datos esta conectada correctamente")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("¿ Deseas salir del sistema?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then

            End
        End If
    End Sub
End Class
