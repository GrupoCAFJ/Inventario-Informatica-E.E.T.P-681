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
        Me.ImagenMaximizar = New System.Windows.Forms.PictureBox()
        Me.ImagenMinmizar = New System.Windows.Forms.PictureBox()
        Me.ImagenClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panel = New System.Windows.Forms.Panel()
        Me.ver = New System.Windows.Forms.Button()
        Me.submenuver = New System.Windows.Forms.Panel()
        Me.verinventariogeneral = New System.Windows.Forms.Button()
        Me.versalanorte = New System.Windows.Forms.Button()
        Me.versalaeste = New System.Windows.Forms.Button()
        Me.versum = New System.Windows.Forms.Button()
        Me.versalavirgi = New System.Windows.Forms.Button()
        Me.cargardatos = New System.Windows.Forms.Button()
        Me.vermedioteca = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.submenuver.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ImagenMaximizar)
        Me.Panel1.Controls.Add(Me.ImagenMinmizar)
        Me.Panel1.Controls.Add(Me.ImagenClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 38)
        Me.Panel1.TabIndex = 0
        '
        'ImagenMaximizar
        '
        Me.ImagenMaximizar.Image = CType(resources.GetObject("ImagenMaximizar.Image"), System.Drawing.Image)
        Me.ImagenMaximizar.Location = New System.Drawing.Point(717, 0)
        Me.ImagenMaximizar.Name = "ImagenMaximizar"
        Me.ImagenMaximizar.Size = New System.Drawing.Size(44, 38)
        Me.ImagenMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenMaximizar.TabIndex = 2
        Me.ImagenMaximizar.TabStop = False
        '
        'ImagenMinmizar
        '
        Me.ImagenMinmizar.Image = CType(resources.GetObject("ImagenMinmizar.Image"), System.Drawing.Image)
        Me.ImagenMinmizar.Location = New System.Drawing.Point(676, 0)
        Me.ImagenMinmizar.Name = "ImagenMinmizar"
        Me.ImagenMinmizar.Size = New System.Drawing.Size(44, 38)
        Me.ImagenMinmizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenMinmizar.TabIndex = 1
        Me.ImagenMinmizar.TabStop = False
        '
        'ImagenClose
        '
        Me.ImagenClose.Image = CType(resources.GetObject("ImagenClose.Image"), System.Drawing.Image)
        Me.ImagenClose.Location = New System.Drawing.Point(758, 0)
        Me.ImagenClose.Name = "ImagenClose"
        Me.ImagenClose.Size = New System.Drawing.Size(44, 38)
        Me.ImagenClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenClose.TabIndex = 0
        Me.ImagenClose.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 479)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.cargardatos)
        Me.Panel3.Controls.Add(Me.submenuver)
        Me.Panel3.Controls.Add(Me.ver)
        Me.Panel3.Controls.Add(Me.panel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 441)
        Me.Panel3.TabIndex = 1
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
        'ver
        '
        Me.ver.Dock = System.Windows.Forms.DockStyle.Top
        Me.ver.FlatAppearance.BorderSize = 0
        Me.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ver.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver.ForeColor = System.Drawing.Color.Black
        Me.ver.Location = New System.Drawing.Point(0, 95)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(200, 40)
        Me.ver.TabIndex = 2
        Me.ver.Text = "Ver inventario"
        Me.ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ver.UseVisualStyleBackColor = True
        '
        'submenuver
        '
        Me.submenuver.BackColor = System.Drawing.Color.LightGray
        Me.submenuver.Controls.Add(Me.vermedioteca)
        Me.submenuver.Controls.Add(Me.versalavirgi)
        Me.submenuver.Controls.Add(Me.versum)
        Me.submenuver.Controls.Add(Me.versalaeste)
        Me.submenuver.Controls.Add(Me.versalanorte)
        Me.submenuver.Controls.Add(Me.verinventariogeneral)
        Me.submenuver.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuver.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.submenuver.Location = New System.Drawing.Point(0, 135)
        Me.submenuver.Name = "submenuver"
        Me.submenuver.Size = New System.Drawing.Size(200, 221)
        Me.submenuver.TabIndex = 2
        '
        'verinventariogeneral
        '
        Me.verinventariogeneral.BackColor = System.Drawing.Color.DarkGray
        Me.verinventariogeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.verinventariogeneral.FlatAppearance.BorderSize = 0
        Me.verinventariogeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verinventariogeneral.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verinventariogeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.verinventariogeneral.Location = New System.Drawing.Point(0, 0)
        Me.verinventariogeneral.Name = "verinventariogeneral"
        Me.verinventariogeneral.Size = New System.Drawing.Size(200, 35)
        Me.verinventariogeneral.TabIndex = 2
        Me.verinventariogeneral.Text = "Inventario general"
        Me.verinventariogeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.verinventariogeneral.UseVisualStyleBackColor = False
        '
        'versalanorte
        '
        Me.versalanorte.BackColor = System.Drawing.Color.DarkGray
        Me.versalanorte.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalanorte.FlatAppearance.BorderSize = 0
        Me.versalanorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalanorte.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalanorte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalanorte.Location = New System.Drawing.Point(0, 35)
        Me.versalanorte.Name = "versalanorte"
        Me.versalanorte.Size = New System.Drawing.Size(200, 35)
        Me.versalanorte.TabIndex = 2
        Me.versalanorte.Text = "Inventario Sala Norte"
        Me.versalanorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalanorte.UseVisualStyleBackColor = False
        '
        'versalaeste
        '
        Me.versalaeste.BackColor = System.Drawing.Color.DarkGray
        Me.versalaeste.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalaeste.FlatAppearance.BorderSize = 0
        Me.versalaeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalaeste.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalaeste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalaeste.Location = New System.Drawing.Point(0, 70)
        Me.versalaeste.Name = "versalaeste"
        Me.versalaeste.Size = New System.Drawing.Size(200, 35)
        Me.versalaeste.TabIndex = 2
        Me.versalaeste.Text = "Inventario Sala Este"
        Me.versalaeste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalaeste.UseVisualStyleBackColor = False
        '
        'versum
        '
        Me.versum.BackColor = System.Drawing.Color.DarkGray
        Me.versum.Dock = System.Windows.Forms.DockStyle.Top
        Me.versum.FlatAppearance.BorderSize = 0
        Me.versum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versum.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versum.Location = New System.Drawing.Point(0, 105)
        Me.versum.Name = "versum"
        Me.versum.Size = New System.Drawing.Size(200, 35)
        Me.versum.TabIndex = 2
        Me.versum.Text = "Inventario Sum"
        Me.versum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versum.UseVisualStyleBackColor = False
        '
        'versalavirgi
        '
        Me.versalavirgi.BackColor = System.Drawing.Color.DarkGray
        Me.versalavirgi.Dock = System.Windows.Forms.DockStyle.Top
        Me.versalavirgi.FlatAppearance.BorderSize = 0
        Me.versalavirgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.versalavirgi.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.versalavirgi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.versalavirgi.Location = New System.Drawing.Point(0, 140)
        Me.versalavirgi.Name = "versalavirgi"
        Me.versalavirgi.Size = New System.Drawing.Size(200, 40)
        Me.versalavirgi.TabIndex = 2
        Me.versalavirgi.Text = "Inventario Sala Virgi"
        Me.versalavirgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.versalavirgi.UseVisualStyleBackColor = False
        '
        'cargardatos
        '
        Me.cargardatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.cargardatos.FlatAppearance.BorderSize = 0
        Me.cargardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cargardatos.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargardatos.Location = New System.Drawing.Point(0, 356)
        Me.cargardatos.Name = "cargardatos"
        Me.cargardatos.Size = New System.Drawing.Size(200, 40)
        Me.cargardatos.TabIndex = 2
        Me.cargardatos.Text = "Cargar datos"
        Me.cargardatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cargardatos.UseVisualStyleBackColor = True
        '
        'vermedioteca
        '
        Me.vermedioteca.BackColor = System.Drawing.Color.DarkGray
        Me.vermedioteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.vermedioteca.FlatAppearance.BorderSize = 0
        Me.vermedioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vermedioteca.Font = New System.Drawing.Font("Futura Md BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.vermedioteca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.vermedioteca.Location = New System.Drawing.Point(0, 180)
        Me.vermedioteca.Name = "vermedioteca"
        Me.vermedioteca.Size = New System.Drawing.Size(200, 40)
        Me.vermedioteca.TabIndex = 3
        Me.vermedioteca.Text = "Inventario medioteca"
        Me.vermedioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.vermedioteca.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(293, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(802, 479)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.submenuver.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents submenuver As Panel
    Friend WithEvents verinventariogeneral As Button
    Friend WithEvents versalavirgi As Button
    Friend WithEvents versum As Button
    Friend WithEvents versalaeste As Button
    Friend WithEvents cargardatos As Button
    Friend WithEvents vermedioteca As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
