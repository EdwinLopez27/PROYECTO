Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form4.Visible = True

        Me.Visible = False
        Form5.Visible = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace3()
        Label1.Text = estado
    End Sub
End Class