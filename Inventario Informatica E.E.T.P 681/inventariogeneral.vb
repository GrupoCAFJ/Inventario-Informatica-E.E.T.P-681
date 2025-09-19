Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class inventariogeneral

    'Formlario padre
    Public Property FormPadre As menuinventario
    '------------------------------------------------------------------------------------------------------------------------------'

    'Conexcion con la base de datos para la busqueda en la base de datos'
    ' Definir la cadena de conexión (puedes moverla a app.config)
    Private connectionString As String = "server=localhost;database=inventarioescuela;user id=root;password=escuela;"
    Private conexion As MySqlConnection

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar la conexión
        conexion = New MySqlConnection(connectionString)

        ' Llenar el ComboBox con las opciones
        ComboBoxFiltro.Items.AddRange(New String() {"Todos", "Herramientas", "Arduinos", "Insumos", "Dispositivos", "Periféricos"})
        ComboBoxFiltro.SelectedIndex = 0

        ' Aplicar filtros iniciales
        AplicarFiltros()
    End Sub

    Private Sub AplicarFiltros()
        Try
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Open()

            Dim query As String = "
            SELECT m.NOMBRE,
                   a.NOMBRE AS UBICACION,
                   s.NOMBRE AS SALA,
                   ma.CANTIDAD
            FROM material m
            JOIN material_almacenamiento ma ON m.ID_MATERIAL = ma.ID_MATERIAL
            JOIN almacenamiento a ON ma.ID_ALMACENAMIENTO = a.ID_ALMACENAMIENTO
            JOIN sala s ON a.ID_SALAS = s.ID_SALA
        "

            ' Lista de filtros
            Dim filtros As New List(Of String)

            ' Filtro ComboBox
            Select Case ComboBoxFiltro.SelectedItem.ToString()
                Case "Herramientas"
                    filtros.Add("m.TIPO = 'Herramienta'")
                Case "Arduinos"
                    filtros.Add("m.TIPO = 'Arduino'")
                Case "Insumos"
                    filtros.Add("m.TIPO = 'Insumo'")
                Case "Dispositivos"
                    filtros.Add("m.TIPO IN ('Dispositivos','Dispositivo')")
                Case "Periféricos"
                    filtros.Add("(m.NOMBRE LIKE '%Monitor%' OR m.NOMBRE LIKE '%Mouse%' OR m.NOMBRE LIKE '%Teclado%')")
                Case "Todos"
                    ' No se agrega filtro
            End Select

            ' Filtro CheckBox
            Dim salaCondiciones As New List(Of String)
            If CheckBoxSalaNorte.Checked Then salaCondiciones.Add("s.NOMBRE = 'Sala Norte'")
            If CheckBoxSalaEste.Checked Then salaCondiciones.Add("s.NOMBRE = 'Sala Este'")
            If CheckBoxSum.Checked Then salaCondiciones.Add("s.NOMBRE = 'Sum'")
            If CheckBoxSalaVirgi.Checked Then salaCondiciones.Add("s.NOMBRE = 'Sala Virgi'")

            ' Agregar filtro de salas si hay alguno seleccionado
            If salaCondiciones.Count > 0 Then filtros.Add("(" & String.Join(" OR ", salaCondiciones) & ")")

            ' Aplicar filtros combinados
            If filtros.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", filtros)
            End If

            ' Ejecutar consulta y llenar DataGridView
            Dim da As New MySqlDataAdapter(query, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvResultados.DataSource = dt

        Catch ex As MySqlException
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------'

    'Filtros
    Private Sub ComboBoxFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFiltro.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub CheckBoxSala_CheckedChanged(sender As Object, e As EventArgs) Handles _
    CheckBoxSalaNorte.CheckedChanged, CheckBoxSalaEste.CheckedChanged, CheckBoxSum.CheckedChanged, CheckBoxSalaVirgi.CheckedChanged

        AplicarFiltros()
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------'

    'Boton volver
    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click, Label3.Click, FlechaVolver.Click
        If FormPadre IsNot Nothing Then
            FormPadre.MostrarBotones()
            FormPadre.logoEscuela1.Visible = True
        End If
        Me.Close()
    End Sub
    Private Sub PanelVolver_MouseEnter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter, Label3.MouseEnter, FlechaVolver.MouseEnter
        Panel7.BackColor = Color.FromArgb(200, 200, 200) ' Color más oscuro
    End Sub

    Private Sub PanelVolver_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave, Label3.MouseLeave, FlechaVolver.MouseLeave
        Panel7.BackColor = Color.White ' Color original '
    End Sub
    Private Sub FormInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Liberar recursos de la conexión al cerrar el formulario
        If conexion IsNot Nothing Then
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------'
End Class