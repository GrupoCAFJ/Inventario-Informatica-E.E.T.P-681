Public Class Form1
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles ImagenClose.Click
        Me.Close()
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles ImagenMaximizar.Click

    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles ImagenMinmizar.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cargardatos_Click(sender As Object, e As EventArgs) Handles cargardatos.Click

    End Sub
End Class
