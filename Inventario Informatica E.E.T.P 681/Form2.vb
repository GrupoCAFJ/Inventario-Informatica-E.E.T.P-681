Imports System.Data.SqlClient

Public Class inventariogeneral

    'Conexcion con la base de datos para la busqueda en la base de datos'
    Private Sub BuscarEnBaseDeDatos(termino As String)
        Dim conexion As New SqlConnection("TU_CADENA_DE_CONEXION")
        Dim consulta As String = "SELECT * FROM TuTabla WHERE TuCampo LIKE @busqueda"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.SelectCommand.Parameters.AddWithValue("@busqueda", "%" & termino & "%")
        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        dgvResultados.DataSource = tabla
    End Sub
    Public Property FormPadre As Form1

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        BuscarEnBaseDeDatos(TextBox1.Text)
    End Sub
    Private Sub Panel6_MouseEnter(sender As Object, e As EventArgs) Handles Panel6.MouseEnter, PictureBox1.MouseEnter, Label2.MouseEnter
        Panel6.BackColor = Color.FromArgb(200, 200, 200) ' Color más oscuro
    End Sub

    Private Sub Panel6_MouseLeave(sender As Object, e As EventArgs) Handles Panel6.MouseLeave, PictureBox1.MouseLeave, Label2.MouseLeave
        Panel6.BackColor = Color.White ' Color original
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click, PictureBox2.Click, Label3.Click
        If FormPadre IsNot Nothing Then
            FormPadre.logoEscuela1.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub Panel7_MouseEnter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter, PictureBox2.MouseEnter, Label3.MouseEnter
        Panel7.BackColor = Color.FromArgb(200, 200, 200) ' Color más oscuro
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave, PictureBox2.MouseLeave, Label3.MouseLeave
        Panel7.BackColor = Color.White ' Color original '
    End Sub

End Class