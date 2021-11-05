Public Class Form6


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace6()
        Label3.Text = estado6


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String = "INSERT INTO EDITORIAS VALUES(@NOMBRE, @DIRECCION, @TELEFONO)"
        comando6 = New SqlClient.SqlCommand(consulta, conexion6)
        comando6.Parameters.AddWithValue("@NOMBRE", TextBox1.Text.ToUpper)
        comando6.Parameters.AddWithValue("@DIRECCION", TextBox2.Text)
        comando6.Parameters.AddWithValue("@TELEFONO", TextBox3.Text)
        comando6.ExecuteNonQuery()
        MsgBox("Editorial Registrada con éxito")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form4.Visible = True
    End Sub
End Class