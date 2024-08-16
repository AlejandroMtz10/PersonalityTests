<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtnPantallaCarga = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlimenteciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignosZodiacalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntecedentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRegistrarPaciente = New System.Windows.Forms.Button()
        Me.BtnTemperamentos = New System.Windows.Forms.Button()
        Me.BtnAlimenteación = New System.Windows.Forms.Button()
        Me.BtnAntecedentes = New System.Windows.Forms.Button()
        Me.BtnSignosZodiacales = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnIniciarSesion = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LblPaciente = New System.Windows.Forms.Label()
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.bitacoraTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.usuariosTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 150)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.PersonalityTests.My.Resources.Resources.cancelar
        Me.BtnClose.Location = New System.Drawing.Point(1038, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.LogoPersonalityTests_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personality Tests."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 100)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPantallaCarga, Me.RegistrosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1088, 100)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnPantallaCarga
        '
        Me.BtnPantallaCarga.AutoSize = False
        Me.BtnPantallaCarga.BackColor = System.Drawing.Color.Transparent
        Me.BtnPantallaCarga.Image = Global.PersonalityTests.My.Resources.Resources.Menu
        Me.BtnPantallaCarga.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnPantallaCarga.MergeIndex = 0
        Me.BtnPantallaCarga.Name = "BtnPantallaCarga"
        Me.BtnPantallaCarga.Size = New System.Drawing.Size(122, 96)
        Me.BtnPantallaCarga.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesToolStripMenuItem, Me.AlimenteciónToolStripMenuItem, Me.TemperamentosToolStripMenuItem, Me.SignosZodiacalesToolStripMenuItem, Me.AntecedentesToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Registro
        Me.RegistrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(218, 96)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PacientesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Pacientes
        Me.PacientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'AlimenteciónToolStripMenuItem
        '
        Me.AlimenteciónToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.AlimenteciónToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.alimentacion
        Me.AlimenteciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlimenteciónToolStripMenuItem.Name = "AlimenteciónToolStripMenuItem"
        Me.AlimenteciónToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.AlimenteciónToolStripMenuItem.Text = "Alimenteción"
        '
        'TemperamentosToolStripMenuItem
        '
        Me.TemperamentosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TemperamentosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.feel
        Me.TemperamentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TemperamentosToolStripMenuItem.Name = "TemperamentosToolStripMenuItem"
        Me.TemperamentosToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.TemperamentosToolStripMenuItem.Text = "Temperamentos"
        '
        'SignosZodiacalesToolStripMenuItem
        '
        Me.SignosZodiacalesToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SignosZodiacalesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.zodiaco
        Me.SignosZodiacalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SignosZodiacalesToolStripMenuItem.Name = "SignosZodiacalesToolStripMenuItem"
        Me.SignosZodiacalesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.SignosZodiacalesToolStripMenuItem.Text = "Signos zodiacales"
        '
        'AntecedentesToolStripMenuItem
        '
        Me.AntecedentesToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.AntecedentesToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Paciente
        Me.AntecedentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AntecedentesToolStripMenuItem.Name = "AntecedentesToolStripMenuItem"
        Me.AntecedentesToolStripMenuItem.Size = New System.Drawing.Size(383, 54)
        Me.AntecedentesToolStripMenuItem.Text = "Antecedentes"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.configuracion
        Me.ConfiguraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(292, 96)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.AgregarUsuarioToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.AgregarUsuario
        Me.AgregarUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(373, 54)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar usuario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.UsuariosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.Usuarios
        Me.UsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(373, 54)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'BaseDeDatosToolStripMenuItem
        '
        Me.BaseDeDatosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BaseDeDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexiónToolStripMenuItem, Me.HistorialToolStripMenuItem})
        Me.BaseDeDatosToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.database_settings_48px
        Me.BaseDeDatosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        Me.BaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(373, 54)
        Me.BaseDeDatosToolStripMenuItem.Text = "Base de datos"
        '
        'ConexiónToolStripMenuItem
        '
        Me.ConexiónToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ConexiónToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.estadoconexion48px
        Me.ConexiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConexiónToolStripMenuItem.Name = "ConexiónToolStripMenuItem"
        Me.ConexiónToolStripMenuItem.Size = New System.Drawing.Size(268, 54)
        Me.ConexiónToolStripMenuItem.Text = "Conexión"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.HistorialToolStripMenuItem.Image = Global.PersonalityTests.My.Resources.Resources.historial_48px
        Me.HistorialToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(268, 54)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'BtnRegistrarPaciente
        '
        Me.BtnRegistrarPaciente.BackColor = System.Drawing.Color.Violet
        Me.BtnRegistrarPaciente.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRegistrarPaciente.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarPaciente.Image = Global.PersonalityTests.My.Resources.Resources.Registrar_paciente
        Me.BtnRegistrarPaciente.Location = New System.Drawing.Point(126, 282)
        Me.BtnRegistrarPaciente.Name = "BtnRegistrarPaciente"
        Me.BtnRegistrarPaciente.Size = New System.Drawing.Size(350, 75)
        Me.BtnRegistrarPaciente.TabIndex = 2
        Me.BtnRegistrarPaciente.Text = "Registrar paciente"
        Me.BtnRegistrarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRegistrarPaciente.UseVisualStyleBackColor = False
        '
        'BtnTemperamentos
        '
        Me.BtnTemperamentos.BackColor = System.Drawing.Color.Violet
        Me.BtnTemperamentos.FlatAppearance.BorderSize = 0
        Me.BtnTemperamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTemperamentos.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTemperamentos.Image = Global.PersonalityTests.My.Resources.Resources.feel
        Me.BtnTemperamentos.Location = New System.Drawing.Point(604, 282)
        Me.BtnTemperamentos.Name = "BtnTemperamentos"
        Me.BtnTemperamentos.Size = New System.Drawing.Size(350, 75)
        Me.BtnTemperamentos.TabIndex = 3
        Me.BtnTemperamentos.Text = "Temperamentos"
        Me.BtnTemperamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTemperamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTemperamentos.UseVisualStyleBackColor = False
        '
        'BtnAlimenteación
        '
        Me.BtnAlimenteación.BackColor = System.Drawing.Color.Violet
        Me.BtnAlimenteación.FlatAppearance.BorderSize = 0
        Me.BtnAlimenteación.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAlimenteación.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlimenteación.Image = Global.PersonalityTests.My.Resources.Resources.alimentacion
        Me.BtnAlimenteación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlimenteación.Location = New System.Drawing.Point(604, 392)
        Me.BtnAlimenteación.Name = "BtnAlimenteación"
        Me.BtnAlimenteación.Size = New System.Drawing.Size(350, 75)
        Me.BtnAlimenteación.TabIndex = 5
        Me.BtnAlimenteación.Text = "Alimentación"
        Me.BtnAlimenteación.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlimenteación.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAlimenteación.UseVisualStyleBackColor = False
        '
        'BtnAntecedentes
        '
        Me.BtnAntecedentes.BackColor = System.Drawing.Color.Violet
        Me.BtnAntecedentes.FlatAppearance.BorderSize = 0
        Me.BtnAntecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAntecedentes.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAntecedentes.Image = Global.PersonalityTests.My.Resources.Resources.notas45p
        Me.BtnAntecedentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAntecedentes.Location = New System.Drawing.Point(126, 392)
        Me.BtnAntecedentes.Name = "BtnAntecedentes"
        Me.BtnAntecedentes.Size = New System.Drawing.Size(350, 75)
        Me.BtnAntecedentes.TabIndex = 4
        Me.BtnAntecedentes.Text = "Antecedentes"
        Me.BtnAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAntecedentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAntecedentes.UseVisualStyleBackColor = False
        '
        'BtnSignosZodiacales
        '
        Me.BtnSignosZodiacales.BackColor = System.Drawing.Color.Violet
        Me.BtnSignosZodiacales.FlatAppearance.BorderSize = 0
        Me.BtnSignosZodiacales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSignosZodiacales.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignosZodiacales.Image = Global.PersonalityTests.My.Resources.Resources.zodiaco
        Me.BtnSignosZodiacales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignosZodiacales.Location = New System.Drawing.Point(604, 502)
        Me.BtnSignosZodiacales.Name = "BtnSignosZodiacales"
        Me.BtnSignosZodiacales.Size = New System.Drawing.Size(350, 75)
        Me.BtnSignosZodiacales.TabIndex = 7
        Me.BtnSignosZodiacales.Text = "Signos zodiacales"
        Me.BtnSignosZodiacales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSignosZodiacales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSignosZodiacales.UseVisualStyleBackColor = False
        '
        'BtnReporte
        '
        Me.BtnReporte.BackColor = System.Drawing.Color.Violet
        Me.BtnReporte.FlatAppearance.BorderSize = 0
        Me.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReporte.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.Image = Global.PersonalityTests.My.Resources.Resources.Reporte
        Me.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.Location = New System.Drawing.Point(126, 502)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(350, 75)
        Me.BtnReporte.TabIndex = 6
        Me.BtnReporte.Text = "Generar reporte"
        Me.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReporte.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnIniciarSesion)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.LblPaciente)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 654)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1056, 134)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paciente."
        '
        'BtnIniciarSesion
        '
        Me.BtnIniciarSesion.FlatAppearance.BorderSize = 0
        Me.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciarSesion.Image = Global.PersonalityTests.My.Resources.Resources.salir
        Me.BtnIniciarSesion.Location = New System.Drawing.Point(983, 56)
        Me.BtnIniciarSesion.Name = "BtnIniciarSesion"
        Me.BtnIniciarSesion.Size = New System.Drawing.Size(50, 50)
        Me.BtnIniciarSesion.TabIndex = 10
        Me.BtnIniciarSesion.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.PersonalityTests.My.Resources.Resources.Usuario
        Me.PictureBox3.Location = New System.Drawing.Point(19, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'LblPaciente
        '
        Me.LblPaciente.AutoSize = True
        Me.LblPaciente.BackColor = System.Drawing.Color.Transparent
        Me.LblPaciente.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaciente.ForeColor = System.Drawing.Color.Black
        Me.LblPaciente.Location = New System.Drawing.Point(108, 62)
        Me.LblPaciente.Name = "LblPaciente"
        Me.LblPaciente.Size = New System.Drawing.Size(331, 36)
        Me.LblPaciente.TabIndex = 8
        Me.LblPaciente.Text = "No hay paciente activo."
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataMember = "bitacora"
        Me.BitacoraBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'BitacoraTableAdapter
        '
        Me.BitacoraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.historialpacienteTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.temperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 819)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSignosZodiacales)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.BtnAlimenteación)
        Me.Controls.Add(Me.BtnAntecedentes)
        Me.Controls.Add(Me.BtnTemperamentos)
        Me.Controls.Add(Me.BtnRegistrarPaciente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnPantallaCarga As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlimenteciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemperamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignosZodiacalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AntecedentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnRegistrarPaciente As Button
    Friend WithEvents BtnTemperamentos As Button
    Friend WithEvents BtnAlimenteación As Button
    Friend WithEvents BtnAntecedentes As Button
    Friend WithEvents BtnSignosZodiacales As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConexiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnIniciarSesion As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblPaciente As Label
    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents BitacoraBindingSource As BindingSource
    Friend WithEvents BitacoraTableAdapter As psicologiadbDataSetTableAdapters.bitacoraTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosTableAdapter As psicologiadbDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
End Class
