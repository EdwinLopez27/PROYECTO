
Public Class Form2
        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Me.Visible = False
            Form1.Visible = True
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim consulta As String = "INSERT INTO USUARIO VALUES(@NOMBRE, @APELLIDO, @USUARIO, @TIPO_USR, @NACIMIENTO, @CONTRASEÑA)"
            comand = New SqlClient.SqlCommand(consulta, conexion)
            comand.Parameters.AddWithValue("@NOMBRE", TextBox1.Text.ToUpper)
            comand.Parameters.AddWithValue("@APELLIDO", TextBox2.Text.ToUpper)
            comand.Parameters.AddWithValue("@USUARIO", TextBox3.Text.ToUpper)
            comand.Parameters.AddWithValue("@TIPO_USR", TextBox4.Text.ToUpper)
            comand.Parameters.AddWithValue("@NACIMIENTO", TextBox5.Text)
            comand.Parameters.AddWithValue("@CONTRASEÑA", TextBox6.Text.ToUpper)
            comand.ExecuteNonQuery()
            MsgBox("Usuario Registrado con éxito")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

        End Sub


        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            enlac()
            Label8.Text = estado
        End Sub
    End Class
