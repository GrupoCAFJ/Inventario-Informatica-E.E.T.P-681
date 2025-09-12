Public Class modificar
    Public Property FormPadre As menuinventario
    Private Sub modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub Panelvolver_Click(sender As Object, e As EventArgs) Handles Panel3.Click, PictureBox2.Click, Label2.Click
        If FormPadre IsNot Nothing Then
            FormPadre.logoEscuela1.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub Panel7_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, PictureBox2.MouseEnter, Label2.MouseEnter
        Panel3.BackColor = Color.FromArgb(200, 200, 200) ' Color más oscuro
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave, PictureBox2.MouseLeave, Label2.MouseLeave
        Panel3.BackColor = Color.LightGray ' Color original '
    End Sub
End Class