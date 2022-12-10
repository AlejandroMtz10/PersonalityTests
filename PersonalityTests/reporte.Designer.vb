<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte
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
        Me.components = New System.ComponentModel.Container()
        Dim Label5 As System.Windows.Forms.Label
        Dim UsoMedicamentosLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim RayasicoLabel As System.Windows.Forms.Label
        Dim TamasicoLabel As System.Windows.Forms.Label
        Dim SatvicoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim SanguineoLabel As System.Windows.Forms.Label
        Dim MelancolicoLabel As System.Windows.Forms.Label
        Dim ColericoLabel As System.Windows.Forms.Label
        Dim FlematicoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporte))
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.MatriculaPacienteTxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecomendacionesTxt = New System.Windows.Forms.TextBox()
        Me.UsoMedicamentosTextBox = New System.Windows.Forms.TextBox()
        Me.HistorialPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.RayasicoTextBox = New System.Windows.Forms.TextBox()
        Me.AlimentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TamasicoTextBox = New System.Windows.Forms.TextBox()
        Me.SatvicoTextBox = New System.Windows.Forms.TextBox()
        Me.SanguineoTextBox = New System.Windows.Forms.TextBox()
        Me.TemperamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MelancolicoTextBox = New System.Windows.Forms.TextBox()
        Me.ColericoTextBox = New System.Windows.Forms.TextBox()
        Me.FlematicoTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.AlimentacionTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.AlimentacionTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.HistorialPacienteTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter()
        Me.PacientesTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.PacientesTableAdapter()
        Me.TemperamentosTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter()
        Label5 = New System.Windows.Forms.Label()
        UsoMedicamentosLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        RayasicoLabel = New System.Windows.Forms.Label()
        TamasicoLabel = New System.Windows.Forms.Label()
        SatvicoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        SanguineoLabel = New System.Windows.Forms.Label()
        MelancolicoLabel = New System.Windows.Forms.Label()
        ColericoLabel = New System.Windows.Forms.Label()
        FlematicoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Label5.Location = New System.Drawing.Point(11, 607)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(176, 24)
        Label5.TabIndex = 135
        Label5.Text = "Recomendaciones."
        '
        'UsoMedicamentosLabel
        '
        UsoMedicamentosLabel.AutoSize = True
        UsoMedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        UsoMedicamentosLabel.Location = New System.Drawing.Point(479, 278)
        UsoMedicamentosLabel.Name = "UsoMedicamentosLabel"
        UsoMedicamentosLabel.Size = New System.Drawing.Size(186, 24)
        UsoMedicamentosLabel.TabIndex = 132
        UsoMedicamentosLabel.Text = "Uso Medicamentos:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(49, 480)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(207, 36)
        Label4.TabIndex = 131
        Label4.Text = "Alimentación."
        '
        'RayasicoLabel
        '
        RayasicoLabel.AutoSize = True
        RayasicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        RayasicoLabel.Location = New System.Drawing.Point(13, 551)
        RayasicoLabel.Name = "RayasicoLabel"
        RayasicoLabel.Size = New System.Drawing.Size(98, 24)
        RayasicoLabel.TabIndex = 125
        RayasicoLabel.Text = "Rayasico:"
        '
        'TamasicoLabel
        '
        TamasicoLabel.AutoSize = True
        TamasicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        TamasicoLabel.Location = New System.Drawing.Point(290, 551)
        TamasicoLabel.Name = "TamasicoLabel"
        TamasicoLabel.Size = New System.Drawing.Size(101, 24)
        TamasicoLabel.TabIndex = 127
        TamasicoLabel.Text = "Tamasico:"
        '
        'SatvicoLabel
        '
        SatvicoLabel.AutoSize = True
        SatvicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        SatvicoLabel.Location = New System.Drawing.Point(557, 551)
        SatvicoLabel.Name = "SatvicoLabel"
        SatvicoLabel.Size = New System.Drawing.Size(84, 24)
        SatvicoLabel.TabIndex = 129
        SatvicoLabel.Text = "Satvico:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(49, 326)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(242, 36)
        Label3.TabIndex = 124
        Label3.Text = "Temperamentos."
        '
        'SanguineoLabel
        '
        SanguineoLabel.AutoSize = True
        SanguineoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        SanguineoLabel.Location = New System.Drawing.Point(42, 384)
        SanguineoLabel.Name = "SanguineoLabel"
        SanguineoLabel.Size = New System.Drawing.Size(110, 24)
        SanguineoLabel.TabIndex = 116
        SanguineoLabel.Text = "Sanguineo:"
        '
        'MelancolicoLabel
        '
        MelancolicoLabel.AutoSize = True
        MelancolicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        MelancolicoLabel.Location = New System.Drawing.Point(408, 379)
        MelancolicoLabel.Name = "MelancolicoLabel"
        MelancolicoLabel.Size = New System.Drawing.Size(125, 24)
        MelancolicoLabel.TabIndex = 118
        MelancolicoLabel.Text = "Melancolico:"
        '
        'ColericoLabel
        '
        ColericoLabel.AutoSize = True
        ColericoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        ColericoLabel.Location = New System.Drawing.Point(42, 433)
        ColericoLabel.Name = "ColericoLabel"
        ColericoLabel.Size = New System.Drawing.Size(92, 24)
        ColericoLabel.TabIndex = 120
        ColericoLabel.Text = "Colerico:"
        '
        'FlematicoLabel
        '
        FlematicoLabel.AutoSize = True
        FlematicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        FlematicoLabel.Location = New System.Drawing.Point(408, 433)
        FlematicoLabel.Name = "FlematicoLabel"
        FlematicoLabel.Size = New System.Drawing.Size(107, 24)
        FlematicoLabel.TabIndex = 122
        FlematicoLabel.Text = "Flematico:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(48, 110)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(160, 42)
        Label2.TabIndex = 115
        Label2.Text = "Paciente."
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(38, 184)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(104, 24)
        MatriculaLabel.TabIndex = 107
        MatriculaLabel.Text = "Matricula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(38, 235)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(89, 24)
        NombreLabel.TabIndex = 109
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(38, 278)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(98, 24)
        ApellidosLabel.TabIndex = 111
        ApellidosLabel.Text = "Apellidos:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdadLabel.Location = New System.Drawing.Point(488, 230)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(64, 24)
        EdadLabel.TabIndex = 113
        EdadLabel.Text = "Edad:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(28, 529)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(104, 24)
        Label6.TabIndex = 108
        Label6.Text = "Matricula:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(28, 270)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(199, 48)
        Label8.TabIndex = 113
        Label8.Text = "Buscar matrícula del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paciente."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.TxtApellidos)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnImprimir)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.MatriculaPacienteTxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 900)
        Me.Panel1.TabIndex = 106
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TxtApellidos.Location = New System.Drawing.Point(32, 465)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(223, 32)
        Me.TxtApellidos.TabIndex = 114
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TxtNombre.Location = New System.Drawing.Point(31, 382)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(223, 32)
        Me.TxtNombre.TabIndex = 112
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.LightPink
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.PersonalityTests.My.Resources.Resources.Salir1
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(31, 767)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(250, 75)
        Me.BtnSalir.TabIndex = 111
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.LogoPersonalityTests_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(44, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.LightPink
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Image = Global.PersonalityTests.My.Resources.Resources.Imprimir
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(31, 665)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(250, 75)
        Me.BtnImprimir.TabIndex = 109
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'MatriculaPacienteTxt
        '
        Me.MatriculaPacienteTxt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MatriculaPacienteTxt.Location = New System.Drawing.Point(32, 572)
        Me.MatriculaPacienteTxt.Name = "MatriculaPacienteTxt"
        Me.MatriculaPacienteTxt.Size = New System.Drawing.Size(223, 32)
        Me.MatriculaPacienteTxt.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.RecomendacionesTxt)
        Me.Panel2.Controls.Add(UsoMedicamentosLabel)
        Me.Panel2.Controls.Add(Me.UsoMedicamentosTextBox)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(RayasicoLabel)
        Me.Panel2.Controls.Add(Me.RayasicoTextBox)
        Me.Panel2.Controls.Add(TamasicoLabel)
        Me.Panel2.Controls.Add(Me.TamasicoTextBox)
        Me.Panel2.Controls.Add(SatvicoLabel)
        Me.Panel2.Controls.Add(Me.SatvicoTextBox)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(SanguineoLabel)
        Me.Panel2.Controls.Add(Me.SanguineoTextBox)
        Me.Panel2.Controls.Add(MelancolicoLabel)
        Me.Panel2.Controls.Add(Me.MelancolicoTextBox)
        Me.Panel2.Controls.Add(ColericoLabel)
        Me.Panel2.Controls.Add(Me.ColericoTextBox)
        Me.Panel2.Controls.Add(FlematicoLabel)
        Me.Panel2.Controls.Add(Me.FlematicoTextBox)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(MatriculaLabel)
        Me.Panel2.Controls.Add(Me.MatriculaTextBox)
        Me.Panel2.Controls.Add(NombreLabel)
        Me.Panel2.Controls.Add(Me.NombreTextBox)
        Me.Panel2.Controls.Add(ApellidosLabel)
        Me.Panel2.Controls.Add(Me.ApellidosTextBox)
        Me.Panel2.Controls.Add(EdadLabel)
        Me.Panel2.Controls.Add(Me.EdadTextBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(306, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 900)
        Me.Panel2.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(550, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 36)
        Me.Label7.TabIndex = 136
        '
        'RecomendacionesTxt
        '
        Me.RecomendacionesTxt.Location = New System.Drawing.Point(17, 645)
        Me.RecomendacionesTxt.Multiline = True
        Me.RecomendacionesTxt.Name = "RecomendacionesTxt"
        Me.RecomendacionesTxt.Size = New System.Drawing.Size(783, 224)
        Me.RecomendacionesTxt.TabIndex = 134
        '
        'UsoMedicamentosTextBox
        '
        Me.UsoMedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "UsoMedicamentos", True))
        Me.UsoMedicamentosTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.UsoMedicamentosTextBox.Location = New System.Drawing.Point(671, 270)
        Me.UsoMedicamentosTextBox.Name = "UsoMedicamentosTextBox"
        Me.UsoMedicamentosTextBox.ReadOnly = True
        Me.UsoMedicamentosTextBox.Size = New System.Drawing.Size(88, 32)
        Me.UsoMedicamentosTextBox.TabIndex = 133
        '
        'HistorialPacienteBindingSource
        '
        Me.HistorialPacienteBindingSource.DataMember = "HistorialPaciente"
        Me.HistorialPacienteBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RayasicoTextBox
        '
        Me.RayasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Rayasico", True))
        Me.RayasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RayasicoTextBox.Location = New System.Drawing.Point(127, 543)
        Me.RayasicoTextBox.Name = "RayasicoTextBox"
        Me.RayasicoTextBox.ReadOnly = True
        Me.RayasicoTextBox.Size = New System.Drawing.Size(143, 32)
        Me.RayasicoTextBox.TabIndex = 126
        Me.RayasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AlimentacionBindingSource
        '
        Me.AlimentacionBindingSource.DataMember = "Alimentacion"
        Me.AlimentacionBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'TamasicoTextBox
        '
        Me.TamasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Tamasico", True))
        Me.TamasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TamasicoTextBox.Location = New System.Drawing.Point(407, 543)
        Me.TamasicoTextBox.Name = "TamasicoTextBox"
        Me.TamasicoTextBox.ReadOnly = True
        Me.TamasicoTextBox.Size = New System.Drawing.Size(143, 32)
        Me.TamasicoTextBox.TabIndex = 128
        Me.TamasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SatvicoTextBox
        '
        Me.SatvicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Satvico", True))
        Me.SatvicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SatvicoTextBox.Location = New System.Drawing.Point(657, 543)
        Me.SatvicoTextBox.Name = "SatvicoTextBox"
        Me.SatvicoTextBox.ReadOnly = True
        Me.SatvicoTextBox.Size = New System.Drawing.Size(143, 32)
        Me.SatvicoTextBox.TabIndex = 130
        Me.SatvicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SanguineoTextBox
        '
        Me.SanguineoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Sanguineo", True))
        Me.SanguineoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SanguineoTextBox.Location = New System.Drawing.Point(186, 376)
        Me.SanguineoTextBox.Name = "SanguineoTextBox"
        Me.SanguineoTextBox.ReadOnly = True
        Me.SanguineoTextBox.Size = New System.Drawing.Size(196, 32)
        Me.SanguineoTextBox.TabIndex = 117
        Me.SanguineoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TemperamentosBindingSource
        '
        Me.TemperamentosBindingSource.DataMember = "Temperamentos"
        Me.TemperamentosBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'MelancolicoTextBox
        '
        Me.MelancolicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Melancolico", True))
        Me.MelancolicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MelancolicoTextBox.Location = New System.Drawing.Point(575, 376)
        Me.MelancolicoTextBox.Name = "MelancolicoTextBox"
        Me.MelancolicoTextBox.ReadOnly = True
        Me.MelancolicoTextBox.Size = New System.Drawing.Size(196, 32)
        Me.MelancolicoTextBox.TabIndex = 119
        Me.MelancolicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColericoTextBox
        '
        Me.ColericoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Colerico", True))
        Me.ColericoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ColericoTextBox.Location = New System.Drawing.Point(186, 425)
        Me.ColericoTextBox.Name = "ColericoTextBox"
        Me.ColericoTextBox.ReadOnly = True
        Me.ColericoTextBox.Size = New System.Drawing.Size(196, 32)
        Me.ColericoTextBox.TabIndex = 121
        Me.ColericoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlematicoTextBox
        '
        Me.FlematicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Flematico", True))
        Me.FlematicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.FlematicoTextBox.Location = New System.Drawing.Point(575, 425)
        Me.FlematicoTextBox.Name = "FlematicoTextBox"
        Me.FlematicoTextBox.ReadOnly = True
        Me.FlematicoTextBox.Size = New System.Drawing.Size(196, 32)
        Me.FlematicoTextBox.TabIndex = 123
        Me.FlematicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(161, 176)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(303, 32)
        Me.MatriculaTextBox.TabIndex = 108
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(161, 227)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(303, 32)
        Me.NombreTextBox.TabIndex = 110
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(161, 270)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.ReadOnly = True
        Me.ApellidosTextBox.Size = New System.Drawing.Size(303, 32)
        Me.ApellidosTextBox.TabIndex = 112
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Edad", True))
        Me.EdadTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadTextBox.Location = New System.Drawing.Point(558, 222)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.ReadOnly = True
        Me.EdadTextBox.Size = New System.Drawing.Size(201, 32)
        Me.EdadTextBox.TabIndex = 114
        Me.EdadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 55)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Reporte."
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'AlimentacionTableAdapter
        '
        Me.AlimentacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Me.AlimentacionTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Me.HistorialPacienteTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Me.TemperamentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'HistorialPacienteTableAdapter
        '
        Me.HistorialPacienteTableAdapter.ClearBeforeFill = True
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TemperamentosTableAdapter
        '
        Me.TemperamentosTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(28, 424)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(98, 24)
        Label9.TabIndex = 115
        Label9.Text = "Apellidos:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(28, 338)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(111, 24)
        Label10.TabIndex = 116
        Label10.Text = "Nombre(s):"
        '
        'reporte
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1119, 900)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents AlimentacionBindingSource As BindingSource
    Friend WithEvents AlimentacionTableAdapter As PsicologiaDBDataSetTableAdapters.AlimentacionTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistorialPacienteTableAdapter As PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter
    Friend WithEvents HistorialPacienteBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As PsicologiaDBDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents TemperamentosTableAdapter As PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter
    Friend WithEvents TemperamentosBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MatriculaPacienteTxt As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RecomendacionesTxt As TextBox
    Friend WithEvents UsoMedicamentosTextBox As TextBox
    Friend WithEvents RayasicoTextBox As TextBox
    Friend WithEvents TamasicoTextBox As TextBox
    Friend WithEvents SatvicoTextBox As TextBox
    Friend WithEvents SanguineoTextBox As TextBox
    Friend WithEvents MelancolicoTextBox As TextBox
    Friend WithEvents ColericoTextBox As TextBox
    Friend WithEvents FlematicoTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellidos As TextBox
End Class
