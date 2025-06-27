<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ImagenClose = New System.Windows.Forms.PictureBox()
        Me.ImagenMaximizar = New System.Windows.Forms.PictureBox()
        Me.ImagenMinmizar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.logoEscuela1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cargardatos = New System.Windows.Forms.Button()
        Me.InventarioSubMenu = New System.Windows.Forms.Panel()
        Me.vermedioteca = New System.Windows.Forms.Button()
        Me.versalavirgi = New System.Windows.Forms.Button()
        Me.versum = New System.Windows.Forms.Button()
        Me.versalaeste = New System.Windows.Forms.Button()
        Me.versalanorte = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(1200, 38)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ImagenClose)
        Me.Panel5.Controls.Add(Me.ImagenMaximizar)
        Me.Panel5.Controls.Add(Me.ImagenMinmizar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1061, 0)
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
        Me.Panel2.Size = New System.Drawing.Size(1200, 720)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.logoEscuela1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 682)
        Me.Panel4.TabIndex = 2
        '
        'logoEscuela1
        '
        Me.logoEscuela1.Image = CType(resources.GetObject("logoEscuela1.Image"), System.Drawing.Image)
        Me.logoEscuela1.Location = New System.Drawing.Point(378, 250)
        Me.logoEscuela1.Name = "logoEscuela1"
        Me.logoEscuela1.Size = New System.Drawing.Size(245, 183)
        Me.logoEscuela1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoEscuela1.TabIndex = 2
        Me.logoEscuela1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.cargardatos)
        Me.Panel3.Controls.Add(Me.InventarioSubMenu)
        Me.Panel3.Controls.Add(Me.ver)
        Me.Panel3.Controls.Add(Me.panel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 682)
        Me.Panel3.TabIndex = 1
        '
        'cargardatos
        '
        Me.cargardatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.cargardatos.FlatAppearance.BorderSize = 0
        Me.cargardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cargardatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargardatos.Location = New System.Drawing.Point(0, 356)
        Me.cargardatos.Name = "cargardatos"
        Me.cargardatos.Size = New System.Drawing.Size(200, 40)
        Me.cargardatos.TabIndex = 2
        Me.cargardatos.Text = "Cargar datos"
        Me.cargardatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cargardatos.UseVisualStyleBackColor = True
        '
        'InventarioSubMenu
        '
        Me.InventarioSubMenu.BackColor = System.Drawing.Color.LightGray
        Me.InventarioSubMenu.Controls.Add(Me.vermedioteca)
        Me.InventarioSubMenu.Controls.Add(Me.versalavirgi)
        Me.InventarioSubMenu.Controls.Add(Me.versum)
        Me.InventarioSubMenu.Controls.Add(Me.versalaeste)
        Me.InventarioSubMenu.Controls.Add(Me.versalanorte)
        Me.InventarioSubMenu.Controls.Add(Me.verinventariogeneral)
        Me.InventarioSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.InventarioSubMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.InventarioSubMenu.Location = New System.Drawing.Point(0, 135)
        Me.InventarioSubMenu.Name = "InventarioSubMenu"
        Me.InventarioSubMenu.Size = New System.Drawing.Size(200, 221)
        Me.InventarioSubMenu.TabIndex = 2
        Me.InventarioSubMenu.Visible = False
        '
        'vermedioteca
        '
        Me.vermedioteca.BackColor = System.Drawing.Color.DarkGray
        Me.vermedioteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.vermedioteca.FlatAppearance.BorderSize = 0
        Me.vermedioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vermedioteca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.vermedioteca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.vermedioteca.Location = New System.Drawing.Point(0, 180)
        Me.vermedioteca.Name = "vermedioteca"
        Me.vermedioteca.Size = New System.Drawing.Size(200, 41)
        Me.vermedioteca.TabIndex = 3
        Me.vermedioteca.Text = "Inventario medioteca"
        Me.vermedioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.vermedioteca.UseVisualStyleBackColor = False
        '
        'versalavirgi
        '
        Me.versalavirgi.BackColor = System.Drawing.Color.DarkGray
        Me.versalavirgi.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalavirgi.FlatAppearance.BorderSize = 0
        Me.versalavirgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalavirgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalavirgi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalavirgi.Location = New System.Drawing.Point(0, 140)
        Me.versalavirgi.Name = "versalavirgi"
        Me.versalavirgi.Size = New System.Drawing.Size(200, 40)
        Me.versalavirgi.TabIndex = 2
        Me.versalavirgi.Text = "Inventario Sala Virgi"
        Me.versalavirgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalavirgi.UseVisualStyleBackColor = False
        '
        'versum
        '
        Me.versum.BackColor = System.Drawing.Color.DarkGray
        Me.versum.Dock = System.Windows.Forms.DockStyle.Top
        Me.versum.FlatAppearance.BorderSize = 0
        Me.versum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versum.Location = New System.Drawing.Point(0, 105)
        Me.versum.Name = "versum"
        Me.versum.Size = New System.Drawing.Size(200, 35)
        Me.versum.TabIndex = 2
        Me.versum.Text = "Inventario Sum"
        Me.versum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versum.UseVisualStyleBackColor = False
        '
        'versalaeste
        '
        Me.versalaeste.BackColor = System.Drawing.Color.DarkGray
        Me.versalaeste.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalaeste.FlatAppearance.BorderSize = 0
        Me.versalaeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalaeste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalaeste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalaeste.Location = New System.Drawing.Point(0, 70)
        Me.versalaeste.Name = "versalaeste"
        Me.versalaeste.Size = New System.Drawing.Size(200, 35)
        Me.versalaeste.TabIndex = 2
        Me.versalaeste.Text = "Inventario Sala Este"
        Me.versalaeste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalaeste.UseVisualStyleBackColor = False
        '
        'versalanorte
        '
        Me.versalanorte.BackColor = System.Drawing.Color.DarkGray
        Me.versalanorte.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalanorte.FlatAppearance.BorderSize = 0
        Me.versalanorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalanorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalanorte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalanorte.Location = New System.Drawing.Point(0, 35)
        Me.versalanorte.Name = "versalanorte"
        Me.versalanorte.Size = New System.Drawing.Size(200, 35)
        Me.versalanorte.TabIndex = 2
        Me.versalanorte.Text = "Inventario Sala Norte"
        Me.versalanorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalanorte.UseVisualStyleBackColor = False
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
        Me.ver.Location = New System.Drawing.Point(0, 95)
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
        Me.panel.Size = New System.Drawing.Size(200, 95)
        Me.panel.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.logoEscuela1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents versalanorte As Button
    Friend WithEvents InventarioSubMenu As Panel
    Friend WithEvents verinventariogeneral As Button
    Friend WithEvents versalavirgi As Button
    Friend WithEvents versum As Button
    Friend WithEvents versalaeste As Button
    Friend WithEvents cargardatos As Button
    Friend WithEvents vermedioteca As Button
    Friend WithEvents logoEscuela1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
