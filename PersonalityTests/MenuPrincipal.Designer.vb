<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlimentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignosZodiacalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPacientes = New System.Windows.Forms.Button()
        Me.BtnTemperamentos = New System.Windows.Forms.Button()
        Me.BtnSignosZodiaco = New System.Windows.Forms.Button()
        Me.BtnAlimentacion = New System.Windows.Forms.Button()
        Me.BtnAntecedentes = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 150)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PersonalityTests.My.Resources.Resources.LogoPersonalityTests_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(925, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personality Tests"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Menu
        Me.PictureBox1.Location = New System.Drawing.Point(25, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 75)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1062, 75)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesToolStripMenuItem, Me.AlimentaciónToolStripMenuItem, Me.TemperamentosToolStripMenuItem, Me.SignosZodiacalesToolStripMenuItem, Me.AntecedentesToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Registro
        Me.RegistrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(218, 71)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.PacientesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Pacientes
        Me.PacientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'AlimentaciónToolStripMenuItem
        '
        Me.AlimentaciónToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.AlimentaciónToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.alimentacion
        Me.AlimentaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlimentaciónToolStripMenuItem.Name = "AlimentaciónToolStripMenuItem"
        Me.AlimentaciónToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.AlimentaciónToolStripMenuItem.Text = "Alimentación"
        '
        'TemperamentosToolStripMenuItem
        '
        Me.TemperamentosToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.TemperamentosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.feel
        Me.TemperamentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TemperamentosToolStripMenuItem.Name = "TemperamentosToolStripMenuItem"
        Me.TemperamentosToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.TemperamentosToolStripMenuItem.Text = "Temperamentos"
        '
        'SignosZodiacalesToolStripMenuItem
        '
        Me.SignosZodiacalesToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.SignosZodiacalesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.zodiaco
        Me.SignosZodiacalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SignosZodiacalesToolStripMenuItem.Name = "SignosZodiacalesToolStripMenuItem"
        Me.SignosZodiacalesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.SignosZodiacalesToolStripMenuItem.Text = "Signos zodiacales"
        '
        'AntecedentesToolStripMenuItem
        '
        Me.AntecedentesToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.AntecedentesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Paciente
        Me.AntecedentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AntecedentesToolStripMenuItem.Name = "AntecedentesToolStripMenuItem"
        Me.AntecedentesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.AntecedentesToolStripMenuItem.Text = "Antecedentes"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraciónToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.configuracion
        Me.ConfiguraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(292, 71)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise
        Me.AgregarUsuarioToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.AgregarUsuario
        Me.AgregarUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(373, 54)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar usuario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise
        Me.UsuariosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Usuarios
        Me.UsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(373, 54)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'BtnPacientes
        '
        Me.BtnPacientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnPacientes.FlatAppearance.BorderSize = 0
        Me.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacientes.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPacientes.Image = Global.PersonalityTests.My.Resources.Resources.Registrar_paciente
        Me.BtnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPacientes.Location = New System.Drawing.Point(143, 277)
        Me.BtnPacientes.Name = "BtnPacientes"
        Me.BtnPacientes.Size = New System.Drawing.Size(300, 75)
        Me.BtnPacientes.TabIndex = 2
        Me.BtnPacientes.Text = "Registrar paciente"
        Me.BtnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPacientes.UseVisualStyleBackColor = False
        '
        'BtnTemperamentos
        '
        Me.BtnTemperamentos.BackColor = System.Drawing.Color.Transparent
        Me.BtnTemperamentos.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnTemperamentos.FlatAppearance.BorderSize = 0
        Me.BtnTemperamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTemperamentos.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTemperamentos.Image = Global.PersonalityTests.My.Resources.Resources.feel
        Me.BtnTemperamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTemperamentos.Location = New System.Drawing.Point(601, 273)
        Me.BtnTemperamentos.Name = "BtnTemperamentos"
        Me.BtnTemperamentos.Size = New System.Drawing.Size(300, 75)
        Me.BtnTemperamentos.TabIndex = 3
        Me.BtnTemperamentos.Text = "Temperamentos"
        Me.BtnTemperamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTemperamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTemperamentos.UseVisualStyleBackColor = False
        '
        'BtnSignosZodiaco
        '
        Me.BtnSignosZodiaco.BackColor = System.Drawing.Color.Transparent
        Me.BtnSignosZodiaco.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSignosZodiaco.FlatAppearance.BorderSize = 0
        Me.BtnSignosZodiaco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignosZodiaco.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignosZodiaco.Image = Global.PersonalityTests.My.Resources.Resources.zodiaco
        Me.BtnSignosZodiaco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignosZodiaco.Location = New System.Drawing.Point(601, 537)
        Me.BtnSignosZodiaco.Name = "BtnSignosZodiaco"
        Me.BtnSignosZodiaco.Size = New System.Drawing.Size(300, 75)
        Me.BtnSignosZodiaco.TabIndex = 4
        Me.BtnSignosZodiaco.Text = "Signos zodiacales"
        Me.BtnSignosZodiaco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignosZodiaco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSignosZodiaco.UseVisualStyleBackColor = False
        '
        'BtnAlimentacion
        '
        Me.BtnAlimentacion.BackColor = System.Drawing.Color.Transparent
        Me.BtnAlimentacion.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnAlimentacion.FlatAppearance.BorderSize = 0
        Me.BtnAlimentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlimentacion.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlimentacion.Image = Global.PersonalityTests.My.Resources.Resources.alimentacion
        Me.BtnAlimentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlimentacion.Location = New System.Drawing.Point(601, 405)
        Me.BtnAlimentacion.Name = "BtnAlimentacion"
        Me.BtnAlimentacion.Size = New System.Drawing.Size(300, 75)
        Me.BtnAlimentacion.TabIndex = 5
        Me.BtnAlimentacion.Text = "Alimentación"
        Me.BtnAlimentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlimentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAlimentacion.UseVisualStyleBackColor = False
        '
        'BtnAntecedentes
        '
        Me.BtnAntecedentes.BackColor = System.Drawing.Color.Transparent
        Me.BtnAntecedentes.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnAntecedentes.FlatAppearance.BorderSize = 0
        Me.BtnAntecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAntecedentes.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAntecedentes.Image = Global.PersonalityTests.My.Resources.Resources.notas45p
        Me.BtnAntecedentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAntecedentes.Location = New System.Drawing.Point(143, 414)
        Me.BtnAntecedentes.Name = "BtnAntecedentes"
        Me.BtnAntecedentes.Size = New System.Drawing.Size(300, 75)
        Me.BtnAntecedentes.TabIndex = 6
        Me.BtnAntecedentes.Text = "Antecedentes"
        Me.BtnAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAntecedentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAntecedentes.UseVisualStyleBackColor = False
        '
        'BtnReporte
        '
        Me.BtnReporte.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporte.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnReporte.FlatAppearance.BorderSize = 0
        Me.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporte.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.Image = Global.PersonalityTests.My.Resources.Resources.Reporte
        Me.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.Location = New System.Drawing.Point(143, 537)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(300, 75)
        Me.BtnReporte.TabIndex = 7
        Me.BtnReporte.Text = "Generar reporte"
        Me.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReporte.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.PersonalityTests.My.Resources.Resources.salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(12, 663)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(128, 75)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.BtnAntecedentes)
        Me.Controls.Add(Me.BtnAlimentacion)
        Me.Controls.Add(Me.BtnSignosZodiaco)
        Me.Controls.Add(Me.BtnTemperamentos)
        Me.Controls.Add(Me.BtnPacientes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlimentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemperamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignosZodiacalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnPacientes As Button
    Friend WithEvents BtnTemperamentos As Button
    Friend WithEvents BtnSignosZodiaco As Button
    Friend WithEvents BtnAlimentacion As Button
    Friend WithEvents AntecedentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnAntecedentes As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
