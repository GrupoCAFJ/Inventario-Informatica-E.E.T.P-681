Imports System.Runtime.InteropServices

Public Class menuinventario

    'Botones cerrar, maximizar y minimizar'
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles ImagenClose.Click
        Me.Close()
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles ImagenMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles ImagenMinmizar.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = True
    End Sub


    'Contormo de los botones'
    Private Sub close_mouseenter(sender As Object, e As EventArgs) Handles ImagenClose.MouseEnter
        ImagenClose.BackColor = Color.FromArgb(255, 128, 128)
    End Sub
    Private Sub close_mouseleave(sender As Object, e As EventArgs) Handles ImagenClose.MouseLeave
        ImagenClose.BackColor = Color.FromArgb(22, 71, 115)
    End Sub

    Private Sub maximizar_mouseenter(sender As Object, e As EventArgs) Handles ImagenMaximizar.MouseEnter
        ImagenMaximizar.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub maximizar_mouseleave(sender As Object, e As EventArgs) Handles ImagenMaximizar.MouseLeave
        ImagenMaximizar.BackColor = Color.FromArgb(22, 71, 115)
    End Sub

    Private Sub minimizar_mouseenter(sender As Object, e As EventArgs) Handles ImagenMinmizar.MouseEnter
        ImagenMinmizar.BackColor = Color.FromArgb(128, 255, 128)
    End Sub
    Private Sub minimizar_mouseleave(sender As Object, e As EventArgs) Handles ImagenMinmizar.MouseLeave
        ImagenMinmizar.BackColor = Color.FromArgb(22, 71, 115)
    End Sub

    '-----------------------------------------------------------------------------------------------------------'

    'Ocultar el menu/mostrar el menu'
    Private Sub hidenSubmenu()
        InventarioSubMenu.Visible = False
        SubMenuDatos.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidenSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------'

    'Formulario hijo'
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

    '------------------------------------------------------------------------------------------------------------------------------'

    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        showSubmenu(InventarioSubMenu)
    End Sub

    Private Sub VerInventarioGeneral_Click(sender As Object, e As EventArgs) Handles verinventariogeneral.Click
        Dim verinventariogeneral As New inventariogeneral()
        verinventariogeneral.FormPadre = Me
        openform(verinventariogeneral)
        hidenSubmenu()
    End Sub
    Private Sub CargarDatos_Click(sender As Object, e As EventArgs) Handles Datos.Click
        showSubmenu(SubMenuDatos)
    End Sub
End Class
