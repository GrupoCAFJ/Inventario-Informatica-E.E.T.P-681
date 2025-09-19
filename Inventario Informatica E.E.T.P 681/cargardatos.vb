Public Class cargardatos
    Public Property FormPadre As menuinventario
    Private Sub Panelvolver_Click(sender As Object, e As EventArgs) Handles Panelvolver.Click, PictureBox2.Click, Label3.Click
        If FormPadre IsNot Nothing Then
            FormPadre.MostrarBotones()
            FormPadre.logoEscuela1.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub Panel7_MouseEnter(sender As Object, e As EventArgs) Handles Panelvolver.MouseEnter, PictureBox2.MouseEnter, Label3.MouseEnter
        Panelvolver.BackColor = Color.FromArgb(200, 200, 200) ' Color más oscuro
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panelvolver.MouseLeave, PictureBox2.MouseLeave, Label3.MouseLeave
        Panelvolver.BackColor = Color.LightGray ' Color original '
    End Sub
End Class