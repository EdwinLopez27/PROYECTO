Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String = "INSERT INTO LIBROS VALUES(@TITULO, @AUTOR, @CANTIDAD)"
        comando7 = New SqlClient.SqlCommand(consulta, conexion7)
        comando7.Parameters.AddWithValue("@TITULO", TextBox1.Text.ToUpper)
        comando7.Parameters.AddWithValue("@AUTOR", TextBox2.Text)
        comando7.Parameters.AddWithValue("@CANTIDAD", TextBox3.Text)
        comando7.ExecuteNonQuery()
        MsgBox("Editorial Registrada con éxito")
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace7()
        Label5.Text = estado7
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub
End Class