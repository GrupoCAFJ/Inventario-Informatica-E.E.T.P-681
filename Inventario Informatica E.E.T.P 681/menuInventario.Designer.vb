<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuinventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuinventario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ImagenClose = New System.Windows.Forms.PictureBox()
        Me.ImagenMaximizar = New System.Windows.Forms.PictureBox()
        Me.ImagenMinmizar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.logoEscuela1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SubMenuDatos = New System.Windows.Forms.Panel()
        Me.Cargar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.Button()
        Me.InventarioSubMenu = New System.Windows.Forms.Panel()
        Me.verinventariogeneral = New System.Windows.Forms.Button()
        Me.ver = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.logoEscuela1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SubMenuDatos.SuspendLayout()
        Me.InventarioSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 38)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ImagenClose)
        Me.Panel5.Controls.Add(Me.ImagenMaximizar)
        Me.Panel5.Controls.Add(Me.ImagenMinmizar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1227, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 38)
        Me.Panel5.TabIndex = 3
        '
        'ImagenClose
        '
        Me.ImagenClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenClose.Image = CType(resources.GetObject("ImagenClose.Image"), System.Drawing.Image)
        Me.ImagenClose.Location = New System.Drawing.Point(94, 0)
        Me.ImagenClose.Name = "ImagenClose"
        Me.ImagenClose.Size = New System.Drawing.Size(44, 38)
        Me.ImagenClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenClose.TabIndex = 0
        Me.ImagenClose.TabStop = False
        '
        'ImagenMaximizar
        '
        Me.ImagenMaximizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenMaximizar.Image = CType(resources.GetObject("ImagenMaximizar.Image"), System.Drawing.Image)
        Me.ImagenMaximizar.Location = New System.Drawing.Point(53, 0)
        Me.ImagenMaximizar.Name = "ImagenMaximizar"
        Me.ImagenMaximizar.Size = New System.Drawing.Size(44, 38)
        Me.ImagenMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenMaximizar.TabIndex = 2
        Me.ImagenMaximizar.TabStop = False
        '
        'ImagenMinmizar
        '
        Me.ImagenMinmizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenMinmizar.Image = CType(resources.GetObject("ImagenMinmizar.Image"), System.Drawing.Image)
        Me.ImagenMinmizar.Location = New System.Drawing.Point(12, 0)
        Me.ImagenMinmizar.Name = "ImagenMinmizar"
        Me.ImagenMinmizar.Size = New System.Drawing.Size(44, 38)
        Me.ImagenMinmizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenMinmizar.TabIndex = 1
        Me.ImagenMinmizar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 768)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.logoEscuela1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1166, 730)
        Me.Panel4.TabIndex = 2
        '
        'logoEscuela1
        '
        Me.logoEscuela1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoEscuela1.Image = CType(resources.GetObject("logoEscuela1.Image"), System.Drawing.Image)
        Me.logoEscuela1.Location = New System.Drawing.Point(515, 274)
        Me.logoEscuela1.Name = "logoEscuela1"
        Me.logoEscuela1.Size = New System.Drawing.Size(245, 183)
        Me.logoEscuela1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoEscuela1.TabIndex = 2
        Me.logoEscuela1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.SubMenuDatos)
        Me.Panel3.Controls.Add(Me.Datos)
        Me.Panel3.Controls.Add(Me.InventarioSubMenu)
        Me.Panel3.Controls.Add(Me.ver)
        Me.Panel3.Controls.Add(Me.panel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 730)
        Me.Panel3.TabIndex = 1
        '
        'SubMenuDatos
        '
        Me.SubMenuDatos.BackColor = System.Drawing.Color.LightGray
        Me.SubMenuDatos.Controls.Add(Me.Cargar)
        Me.SubMenuDatos.Controls.Add(Me.Modificar)
        Me.SubMenuDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuDatos.Location = New System.Drawing.Point(0, 163)
        Me.SubMenuDatos.Name = "SubMenuDatos"
        Me.SubMenuDatos.Size = New System.Drawing.Size(200, 80)
        Me.SubMenuDatos.TabIndex = 3
        Me.SubMenuDatos.Visible = False
        '
        'Cargar
        '
        Me.Cargar.BackColor = System.Drawing.Color.DarkGray
        Me.Cargar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Cargar.FlatAppearance.BorderSize = 0
        Me.Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Cargar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Cargar.Location = New System.Drawing.Point(0, 40)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(200, 41)
        Me.Cargar.TabIndex = 4
        Me.Cargar.Text = "Cargar"
        Me.Cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cargar.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.DarkGray
        Me.Modificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Modificar.FlatAppearance.BorderSize = 0
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Modificar.Location = New System.Drawing.Point(0, 0)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(200, 40)
        Me.Modificar.TabIndex = 3
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Datos
        '
        Me.Datos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Datos.FlatAppearance.BorderSize = 0
        Me.Datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Datos.ForeColor = System.Drawing.Color.Black
        Me.Datos.Location = New System.Drawing.Point(0, 123)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(200, 40)
        Me.Datos.TabIndex = 3
        Me.Datos.Text = "Datos"
        Me.Datos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Datos.UseVisualStyleBackColor = True
        '
        'InventarioSubMenu
        '
        Me.InventarioSubMenu.BackColor = System.Drawing.Color.LightGray
        Me.InventarioSubMenu.Controls.Add(Me.verinventariogeneral)
        Me.InventarioSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.InventarioSubMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.InventarioSubMenu.Location = New System.Drawing.Point(0, 88)
        Me.InventarioSubMenu.Name = "InventarioSubMenu"
        Me.InventarioSubMenu.Size = New System.Drawing.Size(200, 35)
        Me.InventarioSubMenu.TabIndex = 2
        Me.InventarioSubMenu.Visible = False
        '
        'verinventariogeneral
        '
        Me.verinventariogeneral.BackColor = System.Drawing.Color.DarkGray
        Me.verinventariogeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.verinventariogeneral.FlatAppearance.BorderSize = 0
        Me.verinventariogeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verinventariogeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verinventariogeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.verinventariogeneral.Location = New System.Drawing.Point(0, 0)
        Me.verinventariogeneral.Name = "verinventariogeneral"
        Me.verinventariogeneral.Size = New System.Drawing.Size(200, 35)
        Me.verinventariogeneral.TabIndex = 2
        Me.verinventariogeneral.Text = "Inventario general"
        Me.verinventariogeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.verinventariogeneral.UseVisualStyleBackColor = False
        '
        'ver
        '
        Me.ver.Dock = System.Windows.Forms.DockStyle.Top
        Me.ver.FlatAppearance.BorderSize = 0
        Me.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver.ForeColor = System.Drawing.Color.Black
        Me.ver.Location = New System.Drawing.Point(0, 48)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(200, 40)
        Me.ver.TabIndex = 2
        Me.ver.Text = "Ver inventario"
        Me.ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ver.UseVisualStyleBackColor = True
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Gray
        Me.panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(200, 48)
        Me.panel.TabIndex = 2
        '
        'menuinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuinventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "menuinventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.logoEscuela1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.SubMenuDatos.ResumeLayout(False)
        Me.InventarioSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImagenClose As PictureBox
    Friend WithEvents ImagenMaximizar As PictureBox
    Friend WithEvents ImagenMinmizar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panel As Panel
    Friend WithEvents ver As Button
    Friend WithEvents InventarioSubMenu As Panel
    Friend WithEvents verinventariogeneral As Button
    Friend WithEvents logoEscuela1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Datos As Button
    Friend WithEvents SubMenuDatos As Panel
    Friend WithEvents Cargar As Button
    Friend WithEvents Modificar As Button
End Class
