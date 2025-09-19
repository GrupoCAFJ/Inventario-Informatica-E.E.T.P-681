<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventariogeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventariogeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InventarioG = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CheckBoxSalaVirgi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSum = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSalaEste = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSalaNorte = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBoxFiltro = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.FlechaVolver = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.InventarioG.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.FlechaVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.InventarioG)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 700)
        Me.Panel1.TabIndex = 0
        '
        'InventarioG
        '
        Me.InventarioG.Controls.Add(Me.Panel9)
        Me.InventarioG.Controls.Add(Me.Panel8)
        Me.InventarioG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventarioG.Location = New System.Drawing.Point(0, 118)
        Me.InventarioG.Name = "InventarioG"
        Me.InventarioG.Size = New System.Drawing.Size(1100, 582)
        Me.InventarioG.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.dgvResultados)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(351, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(749, 582)
        Me.Panel9.TabIndex = 7
        '
        'dgvResultados
        '
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResultados.Location = New System.Drawing.Point(0, 0)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowHeadersVisible = False
        Me.dgvResultados.Size = New System.Drawing.Size(749, 582)
        Me.dgvResultados.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(351, 582)
        Me.Panel8.TabIndex = 6
        '
        'CheckBoxSalaVirgi
        '
        Me.CheckBoxSalaVirgi.AutoSize = True
        Me.CheckBoxSalaVirgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CheckBoxSalaVirgi.Location = New System.Drawing.Point(20, 82)
        Me.CheckBoxSalaVirgi.Name = "CheckBoxSalaVirgi"
        Me.CheckBoxSalaVirgi.Size = New System.Drawing.Size(115, 29)
        Me.CheckBoxSalaVirgi.TabIndex = 8
        Me.CheckBoxSalaVirgi.Text = "Sala Virgi"
        Me.CheckBoxSalaVirgi.UseVisualStyleBackColor = True
        '
        'CheckBoxSum
        '
        Me.CheckBoxSum.AutoSize = True
        Me.CheckBoxSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CheckBoxSum.Location = New System.Drawing.Point(20, 152)
        Me.CheckBoxSum.Name = "CheckBoxSum"
        Me.CheckBoxSum.Size = New System.Drawing.Size(72, 29)
        Me.CheckBoxSum.TabIndex = 7
        Me.CheckBoxSum.Text = "Sum"
        Me.CheckBoxSum.UseVisualStyleBackColor = True
        '
        'CheckBoxSalaEste
        '
        Me.CheckBoxSalaEste.AutoSize = True
        Me.CheckBoxSalaEste.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CheckBoxSalaEste.Location = New System.Drawing.Point(20, 117)
        Me.CheckBoxSalaEste.Name = "CheckBoxSalaEste"
        Me.CheckBoxSalaEste.Size = New System.Drawing.Size(115, 29)
        Me.CheckBoxSalaEste.TabIndex = 6
        Me.CheckBoxSalaEste.Text = "Sala Este"
        Me.CheckBoxSalaEste.UseVisualStyleBackColor = True
        '
        'CheckBoxSalaNorte
        '
        Me.CheckBoxSalaNorte.AutoSize = True
        Me.CheckBoxSalaNorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CheckBoxSalaNorte.Location = New System.Drawing.Point(20, 47)
        Me.CheckBoxSalaNorte.Name = "CheckBoxSalaNorte"
        Me.CheckBoxSalaNorte.Size = New System.Drawing.Size(123, 29)
        Me.CheckBoxSalaNorte.TabIndex = 5
        Me.CheckBoxSalaNorte.Text = "Sala Norte"
        Me.CheckBoxSalaNorte.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ComboBoxFiltro)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(349, 118)
        Me.Panel4.TabIndex = 4
        '
        'ComboBoxFiltro
        '
        Me.ComboBoxFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ComboBoxFiltro.FormattingEnabled = True
        Me.ComboBoxFiltro.Location = New System.Drawing.Point(101, 40)
        Me.ComboBoxFiltro.Name = "ComboBoxFiltro"
        Me.ComboBoxFiltro.Size = New System.Drawing.Size(210, 39)
        Me.ComboBoxFiltro.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1100, 118)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 118)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 55)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Inventario"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(887, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(213, 118)
        Me.Panel5.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.FlechaVolver)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Location = New System.Drawing.Point(31, 38)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(150, 43)
        Me.Panel7.TabIndex = 5
        '
        'FlechaVolver
        '
        Me.FlechaVolver.Image = CType(resources.GetObject("FlechaVolver.Image"), System.Drawing.Image)
        Me.FlechaVolver.Location = New System.Drawing.Point(96, 0)
        Me.FlechaVolver.Name = "FlechaVolver"
        Me.FlechaVolver.Size = New System.Drawing.Size(54, 44)
        Me.FlechaVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FlechaVolver.TabIndex = 16
        Me.FlechaVolver.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 43)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Volver"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(565, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Filtrar por salas"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.CheckBoxSalaNorte)
        Me.Panel6.Controls.Add(Me.CheckBoxSalaVirgi)
        Me.Panel6.Controls.Add(Me.CheckBoxSalaEste)
        Me.Panel6.Controls.Add(Me.CheckBoxSum)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 118)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(349, 462)
        Me.Panel6.TabIndex = 10
        '
        'inventariogeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventariogeneral"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.InventarioG.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.FlechaVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents InventarioG As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ComboBoxFiltro As ComboBox
    Friend WithEvents CheckBoxSalaVirgi As CheckBox
    Friend WithEvents CheckBoxSum As CheckBox
    Friend WithEvents CheckBoxSalaEste As CheckBox
    Friend WithEvents CheckBoxSalaNorte As CheckBox
    Friend WithEvents FlechaVolver As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
End Class
