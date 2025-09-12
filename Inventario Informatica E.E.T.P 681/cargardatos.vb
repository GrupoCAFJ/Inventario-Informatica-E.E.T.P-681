Public Class cargardatos
    Public Property FormPadre As menuinventario
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panelvolver_Paint(sender As Object, e As PaintEventArgs) Handles Panelvolver.Paint

    End Sub
    Private Sub Panelvolver_Click(sender As Object, e As EventArgs) Handles Panelvolver.Click, PictureBox2.Click, Label3.Click
        If FormPadre IsNot Nothing Then
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