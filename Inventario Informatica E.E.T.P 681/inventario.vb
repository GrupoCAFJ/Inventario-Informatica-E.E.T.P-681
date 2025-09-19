Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class inventariogeneral

    'Conexcion con la base de datos para la busqueda en la base de datos'
    ' Definir la cadena de conexión (puedes moverla a app.config)
    Private connectionString As String = "server=localhost;database=inventarioescuela;user id=root;password=escuela;"
    Private conexion As MySqlConnection

        Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inicializar la conexión
            conexion = New MySqlConnection(connectionString)

            ' Llenar el ComboBox con las opciones
            ComboBoxFiltro.Items.Add("Todos")
            ComboBoxFiltro.Items.Add("Herramientas")
            ComboBoxFiltro.Items.Add("Arduinos")
            ComboBoxFiltro.Items.Add("Insumos")
            ComboBoxFiltro.Items.Add("Dispositivos")
            ComboBoxFiltro.Items.Add("Periféricos")
            ComboBoxFiltro.SelectedIndex = 0

            ' Cargar los datos iniciales
            CargarInventario("Todos")
        End Sub

        Private Sub CargarInventario(filtro As String)
            Try
                ' Asegurarse de que la conexión esté cerrada antes de abrirla
                If conexion.State = ConnectionState.Open Then conexion.Close()

                ' Abrir la conexión
                conexion.Open()

                ' Construir la consulta SQL
                Dim query As String = "
                SELECT m.ID_MATERIAL,
                       m.NOMBRE,
                       a.NOMBRE AS UBICACION,
                       s.NOMBRE AS SALA,
                       ma.CANTIDAD
                FROM material m
                JOIN material_almacenamiento ma ON m.ID_MATERIAL = ma.ID_MATERIAL
                JOIN almacenamiento a ON ma.ID_ALMACENAMIENTO = a.ID_ALMACENAMIENTO
                JOIN sala s ON a.ID_SALAS = s.ID_SALA
            "

                ' Agregar filtro según la selección
                Select Case filtro
                    Case "Herramientas"
                        query &= " WHERE m.TIPO = 'Herramienta'"
                    Case "Arduinos"
                        query &= " WHERE m.TIPO = 'Arduino'"
                    Case "Insumos"
                        query &= " WHERE m.TIPO = 'Insumo'"
                    Case "Dispositivos"
                        query &= " WHERE m.TIPO IN ('Dispositivos', 'Dispositivo')"
                    Case "Periféricos"
                        query &= " WHERE m.NOMBRE LIKE '%Monitor%' OR m.NOMBRE LIKE '%Mouse%' OR m.NOMBRE LIKE '%Teclado%'"
                End Select

                ' Crear adaptador y llenar DataTable
                Dim da As New MySqlDataAdapter(query, conexion)
                Dim dt As New DataTable()
                da.Fill(dt)

            ' Asignar los datos al DataGridView
            dgvResultados.DataSource = dt

        Catch ex As MySqlException
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Cerrar la conexión si está abierta
                If conexion.State = ConnectionState.Open Then conexion.Close()
            End Try
        End Sub

        Private Sub ComboBoxFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFiltro.SelectedIndexChanged
            Dim opcion As String = ComboBoxFiltro.SelectedItem.ToString()
            CargarInventario(opcion)
        End Sub

    Private Sub FormInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Liberar recursos de la conexión al cerrar el formulario
        If conexion IsNot Nothing Then
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------'
    Public Property FormPadre As menuinventario

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click, PictureBox2.Click, Label3.Click
        If FormPadre IsNot Nothing Then
            FormPadre.MostrarBotones()
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