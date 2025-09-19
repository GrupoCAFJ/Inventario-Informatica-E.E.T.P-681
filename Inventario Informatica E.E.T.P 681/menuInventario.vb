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

    ' Arrastre del formulario

    Private mouseDown1 As Boolean = False
    Private mouseOffset As Point

    ' Evento MouseDown: inicia el arrastre
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If Me.WindowState = FormWindowState.Normal Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    ' Evento MouseMove: mueve el panel
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If mouseDown1 Then
            Dim newLocation As Point = Panel1.Location
            newLocation.X += e.X - mouseOffset.X
            newLocation.Y += e.Y - mouseOffset.Y
            Panel1.Location = newLocation
        End If
    End Sub

    ' Evento MouseUp: termina el arrastre
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        mouseDown1 = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Ejemplo: ajustar el tamaño de un panel manualmente
        Panel1.Width = Me.Width
    End Sub

    ' API para simular el arrastre de la ventana
    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    '------------------------------------------------------------------------------------------------------------------------------'

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

    'Ocultar botones'
    Private Sub OcultarBotones()
        BotonInventario.Visible = False
        BotonModificarDatos.Visible = False
        BotonCargarDatos.Visible = False
    End Sub
    Public Sub MostrarBotones()
        BotonInventario.Visible = True
        BotonModificarDatos.Visible = True
        BotonCargarDatos.Visible = True
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

    'Botones del menu'

    Private Sub BottonInventario_Click(sender As Object, e As EventArgs) Handles BotonInventario.Click
        Dim verinventariogeneral As New inventariogeneral()
        verinventariogeneral.FormPadre = Me
        openform(verinventariogeneral)
        OcultarBotones()
    End Sub

    Private Sub BottonModificarDatos_Click(sender As Object, e As EventArgs) Handles BotonModificarDatos.Click

    End Sub

    Private Sub BottonCargarDatos_Click(sender As Object, e As EventArgs) Handles BotonCargarDatos.Click
        Dim cargardatos As New cargardatos()
        cargardatos.FormPadre = Me
        openform(cargardatos)
        OcultarBotones()
    End Sub


    '------------------------------------------------------------------------------------------------------------------------------'
End Class
