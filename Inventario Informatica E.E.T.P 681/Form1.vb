Public Class Form1
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles ImagenClose.Click
        Me.Close()
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles ImagenMaximizar.Click

    End Sub

    Private Sub hidenSubmenu()
        InventarioSubMenu.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidenSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub openform(formhijo As Form)
        logoEscuela1.Visible = False
        For Each contr As Control In Panel4.Controls.OfType(Of Form)().ToList()
            Panel4.Controls.Remove(contr)
            contr.Dispose()
        Next
        With formhijo
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel4.Controls.Add(formhijo)
            Panel4.Tag = formhijo
            .Show()
        End With
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles ImagenMinmizar.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cargardatos_Click(sender As Object, e As EventArgs) Handles cargardatos.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        showSubmenu(InventarioSubMenu)
    End Sub

    Private Sub vermedioteca_Click(sender As Object, e As EventArgs) Handles vermedioteca.Click
        Dim inventariomedioteca As New inventariomedioteca()
        inventariomedioteca.FormPadre = Me
        openform(inventariomedioteca)
        hidenSubmenu()
    End Sub

    Private Sub verinventariogeneral_Click(sender As Object, e As EventArgs) Handles verinventariogeneral.Click

    End Sub
End Class
