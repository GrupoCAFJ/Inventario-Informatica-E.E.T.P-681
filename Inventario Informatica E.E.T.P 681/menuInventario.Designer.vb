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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BotonModificarDatos = New System.Windows.Forms.Button()
        Me.BotonCargarDatos = New System.Windows.Forms.Button()
        Me.BotonInventario = New System.Windows.Forms.Button()
        Me.logoEscuela1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.logoEscuela1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 768)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 728)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 40)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BotonModificarDatos)
        Me.Panel4.Controls.Add(Me.BotonCargarDatos)
        Me.Panel4.Controls.Add(Me.BotonInventario)
        Me.Panel4.Controls.Add(Me.logoEscuela1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1366, 730)
        Me.Panel4.TabIndex = 2
        '
        'BotonModificarDatos
        '
        Me.BotonModificarDatos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BotonModificarDatos.Location = New System.Drawing.Point(620, 453)
        Me.BotonModificarDatos.Name = "BotonModificarDatos"
        Me.BotonModificarDatos.Size = New System.Drawing.Size(127, 74)
        Me.BotonModificarDatos.TabIndex = 5
        Me.BotonModificarDatos.Text = "Modificar datos"
        Me.BotonModificarDatos.UseVisualStyleBackColor = True
        '
        'BotonCargarDatos
        '
        Me.BotonCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BotonCargarDatos.Location = New System.Drawing.Point(753, 453)
        Me.BotonCargarDatos.Name = "BotonCargarDatos"
        Me.BotonCargarDatos.Size = New System.Drawing.Size(127, 74)
        Me.BotonCargarDatos.TabIndex = 4
        Me.BotonCargarDatos.Text = "Cargar datos"
        Me.BotonCargarDatos.UseVisualStyleBackColor = True
        '
        'BotonInventario
        '
        Me.BotonInventario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BotonInventario.Location = New System.Drawing.Point(487, 453)
        Me.BotonInventario.Name = "BotonInventario"
        Me.BotonInventario.Size = New System.Drawing.Size(127, 74)
        Me.BotonInventario.TabIndex = 3
        Me.BotonInventario.Text = "Inventario"
        Me.BotonInventario.UseVisualStyleBackColor = True
        '
        'logoEscuela1
        '
        Me.logoEscuela1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoEscuela1.Image = CType(resources.GetObject("logoEscuela1.Image"), System.Drawing.Image)
        Me.logoEscuela1.Location = New System.Drawing.Point(543, 203)
        Me.logoEscuela1.Name = "logoEscuela1"
        Me.logoEscuela1.Size = New System.Drawing.Size(281, 227)
        Me.logoEscuela1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoEscuela1.TabIndex = 2
        Me.logoEscuela1.TabStop = False
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
        Me.Text = "+"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.logoEscuela1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImagenClose As PictureBox
    Friend WithEvents ImagenMaximizar As PictureBox
    Friend WithEvents ImagenMinmizar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoEscuela1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BotonModificarDatos As Button
    Friend WithEvents BotonCargarDatos As Button
    Friend WithEvents BotonInventario As Button
    Friend WithEvents Panel3 As Panel
End Class
