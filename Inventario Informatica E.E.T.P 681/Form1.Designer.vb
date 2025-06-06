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
        Me.Panel1.SuspendLayout()
        CType(Me.ImagenMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenMinmizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(77, 441)
        Me.Panel3.TabIndex = 1
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImagenClose As PictureBox
    Friend WithEvents ImagenMaximizar As PictureBox
    Friend WithEvents ImagenMinmizar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
