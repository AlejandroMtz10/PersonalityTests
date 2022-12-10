<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuestionarioSignosZodiacales
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
        Dim NumeroRegistroLabel As System.Windows.Forms.Label
        Dim SignoLabel As System.Windows.Forms.Label
        Dim ElementoLabel As System.Windows.Forms.Label
        Dim PlanetaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.SignosZodiacalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignosZodiacalesTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.SignosZodiacalesTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.SignoTextBox = New System.Windows.Forms.TextBox()
        Me.ElementoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanetaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.MesTxt = New System.Windows.Forms.ComboBox()
        Me.DiaTxt = New System.Windows.Forms.ComboBox()
        Me.ImgGeminis = New System.Windows.Forms.PictureBox()
        Me.ImgTauro = New System.Windows.Forms.PictureBox()
        Me.ImgAries = New System.Windows.Forms.PictureBox()
        Me.ImgSignos = New System.Windows.Forms.PictureBox()
        Me.ImgPiscis = New System.Windows.Forms.PictureBox()
        Me.ImgAcuario = New System.Windows.Forms.PictureBox()
        Me.ImgCapricornio = New System.Windows.Forms.PictureBox()
        Me.ImgSagitario = New System.Windows.Forms.PictureBox()
        Me.ImgEscorpio = New System.Windows.Forms.PictureBox()
        Me.ImgLibra = New System.Windows.Forms.PictureBox()
        Me.ImgVirgo = New System.Windows.Forms.PictureBox()
        Me.ImgLeo = New System.Windows.Forms.PictureBox()
        Me.ImgCancer = New System.Windows.Forms.PictureBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCanelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        SignoLabel = New System.Windows.Forms.Label()
        ElementoLabel = New System.Windows.Forms.Label()
        PlanetaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignosZodiacalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGeminis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgTauro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPiscis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAcuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCapricornio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSagitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEscorpio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgLibra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVirgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgLeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.BackColor = System.Drawing.Color.Transparent
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(90, 116)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(250, 31)
        NumeroRegistroLabel.TabIndex = 1
        NumeroRegistroLabel.Text = "Número de registro:"
        '
        'SignoLabel
        '
        SignoLabel.AutoSize = True
        SignoLabel.BackColor = System.Drawing.Color.Transparent
        SignoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignoLabel.Location = New System.Drawing.Point(90, 361)
        SignoLabel.Name = "SignoLabel"
        SignoLabel.Size = New System.Drawing.Size(88, 31)
        SignoLabel.TabIndex = 3
        SignoLabel.Text = "Signo:"
        '
        'ElementoLabel
        '
        ElementoLabel.AutoSize = True
        ElementoLabel.BackColor = System.Drawing.Color.Transparent
        ElementoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElementoLabel.Location = New System.Drawing.Point(535, 361)
        ElementoLabel.Name = "ElementoLabel"
        ElementoLabel.Size = New System.Drawing.Size(133, 31)
        ElementoLabel.TabIndex = 5
        ElementoLabel.Text = "Elemento:"
        '
        'PlanetaLabel
        '
        PlanetaLabel.AutoSize = True
        PlanetaLabel.BackColor = System.Drawing.Color.Transparent
        PlanetaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlanetaLabel.Location = New System.Drawing.Point(983, 361)
        PlanetaLabel.Name = "PlanetaLabel"
        PlanetaLabel.Size = New System.Drawing.Size(88, 31)
        PlanetaLabel.TabIndex = 7
        PlanetaLabel.Text = "Astro:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(90, 467)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(162, 31)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "Descripcion:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(90, 222)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(140, 31)
        MatriculaLabel.TabIndex = 11
        MatriculaLabel.Text = "Matricula:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold)
        Label3.Location = New System.Drawing.Point(541, 222)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(241, 31)
        Label3.TabIndex = 21
        Label3.Text = "Mes de nacimiento:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(541, 116)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(235, 31)
        Label2.TabIndex = 19
        Label2.Text = "Día de nacimiento:"
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SignosZodiacalesBindingSource
        '
        Me.SignosZodiacalesBindingSource.DataMember = "SignosZodiacales"
        Me.SignosZodiacalesBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'SignosZodiacalesTableAdapter
        '
        Me.SignosZodiacalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Me.SignosZodiacalesTableAdapter
        Me.TableAdapterManager.TemperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(96, 163)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(265, 39)
        Me.NumeroRegistroTextBox.TabIndex = 2
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignoTextBox
        '
        Me.SignoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Signo", True))
        Me.SignoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignoTextBox.Location = New System.Drawing.Point(96, 407)
        Me.SignoTextBox.Name = "SignoTextBox"
        Me.SignoTextBox.ReadOnly = True
        Me.SignoTextBox.Size = New System.Drawing.Size(416, 39)
        Me.SignoTextBox.TabIndex = 4
        Me.SignoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ElementoTextBox
        '
        Me.ElementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Elemento", True))
        Me.ElementoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementoTextBox.Location = New System.Drawing.Point(541, 407)
        Me.ElementoTextBox.Name = "ElementoTextBox"
        Me.ElementoTextBox.ReadOnly = True
        Me.ElementoTextBox.Size = New System.Drawing.Size(416, 39)
        Me.ElementoTextBox.TabIndex = 6
        Me.ElementoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetaTextBox
        '
        Me.PlanetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Planeta", True))
        Me.PlanetaTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetaTextBox.Location = New System.Drawing.Point(989, 407)
        Me.PlanetaTextBox.Name = "PlanetaTextBox"
        Me.PlanetaTextBox.ReadOnly = True
        Me.PlanetaTextBox.Size = New System.Drawing.Size(416, 39)
        Me.PlanetaTextBox.TabIndex = 8
        Me.PlanetaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(96, 512)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(629, 476)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(96, 276)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(420, 39)
        Me.MatriculaTextBox.TabIndex = 12
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MesTxt
        '
        Me.MesTxt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold)
        Me.MesTxt.FormattingEnabled = True
        Me.MesTxt.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesTxt.Location = New System.Drawing.Point(547, 276)
        Me.MesTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.MesTxt.Name = "MesTxt"
        Me.MesTxt.Size = New System.Drawing.Size(410, 39)
        Me.MesTxt.TabIndex = 20
        '
        'DiaTxt
        '
        Me.DiaTxt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold)
        Me.DiaTxt.FormattingEnabled = True
        Me.DiaTxt.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.DiaTxt.Location = New System.Drawing.Point(547, 163)
        Me.DiaTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.DiaTxt.Name = "DiaTxt"
        Me.DiaTxt.Size = New System.Drawing.Size(410, 39)
        Me.DiaTxt.TabIndex = 18
        '
        'ImgGeminis
        '
        Me.ImgGeminis.Image = Global.PersonalityTests.My.Resources.Resources.signoGeminis
        Me.ImgGeminis.Location = New System.Drawing.Point(768, 512)
        Me.ImgGeminis.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgGeminis.Name = "ImgGeminis"
        Me.ImgGeminis.Size = New System.Drawing.Size(637, 476)
        Me.ImgGeminis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGeminis.TabIndex = 36
        Me.ImgGeminis.TabStop = False
        '
        'ImgTauro
        '
        Me.ImgTauro.Image = Global.PersonalityTests.My.Resources.Resources.signoTauro
        Me.ImgTauro.Location = New System.Drawing.Point(768, 512)
        Me.ImgTauro.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgTauro.Name = "ImgTauro"
        Me.ImgTauro.Size = New System.Drawing.Size(637, 476)
        Me.ImgTauro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgTauro.TabIndex = 35
        Me.ImgTauro.TabStop = False
        '
        'ImgAries
        '
        Me.ImgAries.Image = Global.PersonalityTests.My.Resources.Resources.signoAries
        Me.ImgAries.Location = New System.Drawing.Point(768, 512)
        Me.ImgAries.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgAries.Name = "ImgAries"
        Me.ImgAries.Size = New System.Drawing.Size(637, 476)
        Me.ImgAries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgAries.TabIndex = 34
        Me.ImgAries.TabStop = False
        '
        'ImgSignos
        '
        Me.ImgSignos.Image = Global.PersonalityTests.My.Resources.Resources.signosZodiacales
        Me.ImgSignos.Location = New System.Drawing.Point(768, 512)
        Me.ImgSignos.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgSignos.Name = "ImgSignos"
        Me.ImgSignos.Size = New System.Drawing.Size(637, 476)
        Me.ImgSignos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignos.TabIndex = 46
        Me.ImgSignos.TabStop = False
        '
        'ImgPiscis
        '
        Me.ImgPiscis.Image = Global.PersonalityTests.My.Resources.Resources.signoPicis
        Me.ImgPiscis.Location = New System.Drawing.Point(768, 512)
        Me.ImgPiscis.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgPiscis.Name = "ImgPiscis"
        Me.ImgPiscis.Size = New System.Drawing.Size(637, 476)
        Me.ImgPiscis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPiscis.TabIndex = 45
        Me.ImgPiscis.TabStop = False
        '
        'ImgAcuario
        '
        Me.ImgAcuario.Image = Global.PersonalityTests.My.Resources.Resources.signoAcuario
        Me.ImgAcuario.Location = New System.Drawing.Point(768, 512)
        Me.ImgAcuario.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgAcuario.Name = "ImgAcuario"
        Me.ImgAcuario.Size = New System.Drawing.Size(637, 476)
        Me.ImgAcuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgAcuario.TabIndex = 44
        Me.ImgAcuario.TabStop = False
        '
        'ImgCapricornio
        '
        Me.ImgCapricornio.Image = Global.PersonalityTests.My.Resources.Resources.signoCapricornio
        Me.ImgCapricornio.Location = New System.Drawing.Point(768, 512)
        Me.ImgCapricornio.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgCapricornio.Name = "ImgCapricornio"
        Me.ImgCapricornio.Size = New System.Drawing.Size(637, 476)
        Me.ImgCapricornio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCapricornio.TabIndex = 43
        Me.ImgCapricornio.TabStop = False
        '
        'ImgSagitario
        '
        Me.ImgSagitario.Image = Global.PersonalityTests.My.Resources.Resources.signoSagitario
        Me.ImgSagitario.Location = New System.Drawing.Point(768, 512)
        Me.ImgSagitario.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgSagitario.Name = "ImgSagitario"
        Me.ImgSagitario.Size = New System.Drawing.Size(637, 476)
        Me.ImgSagitario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSagitario.TabIndex = 42
        Me.ImgSagitario.TabStop = False
        '
        'ImgEscorpio
        '
        Me.ImgEscorpio.Image = Global.PersonalityTests.My.Resources.Resources.signoEscorpio
        Me.ImgEscorpio.Location = New System.Drawing.Point(768, 512)
        Me.ImgEscorpio.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgEscorpio.Name = "ImgEscorpio"
        Me.ImgEscorpio.Size = New System.Drawing.Size(637, 476)
        Me.ImgEscorpio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgEscorpio.TabIndex = 41
        Me.ImgEscorpio.TabStop = False
        '
        'ImgLibra
        '
        Me.ImgLibra.Image = Global.PersonalityTests.My.Resources.Resources.signoLibra
        Me.ImgLibra.Location = New System.Drawing.Point(768, 512)
        Me.ImgLibra.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgLibra.Name = "ImgLibra"
        Me.ImgLibra.Size = New System.Drawing.Size(637, 476)
        Me.ImgLibra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLibra.TabIndex = 40
        Me.ImgLibra.TabStop = False
        '
        'ImgVirgo
        '
        Me.ImgVirgo.Image = Global.PersonalityTests.My.Resources.Resources.signoVirgo
        Me.ImgVirgo.Location = New System.Drawing.Point(768, 512)
        Me.ImgVirgo.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgVirgo.Name = "ImgVirgo"
        Me.ImgVirgo.Size = New System.Drawing.Size(637, 476)
        Me.ImgVirgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVirgo.TabIndex = 39
        Me.ImgVirgo.TabStop = False
        '
        'ImgLeo
        '
        Me.ImgLeo.Image = Global.PersonalityTests.My.Resources.Resources.signoLeo
        Me.ImgLeo.Location = New System.Drawing.Point(768, 512)
        Me.ImgLeo.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgLeo.Name = "ImgLeo"
        Me.ImgLeo.Size = New System.Drawing.Size(637, 476)
        Me.ImgLeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLeo.TabIndex = 38
        Me.ImgLeo.TabStop = False
        '
        'ImgCancer
        '
        Me.ImgCancer.Image = Global.PersonalityTests.My.Resources.Resources.signoCancer
        Me.ImgCancer.Location = New System.Drawing.Point(768, 512)
        Me.ImgCancer.Margin = New System.Windows.Forms.Padding(2)
        Me.ImgCancer.Name = "ImgCancer"
        Me.ImgCancer.Size = New System.Drawing.Size(637, 476)
        Me.ImgCancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancer.TabIndex = 37
        Me.ImgCancer.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Violet
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = Global.PersonalityTests.My.Resources.Resources.aceptar
        Me.BtnAceptar.Location = New System.Drawing.Point(1093, 113)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(250, 75)
        Me.BtnAceptar.TabIndex = 47
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.Location = New System.Drawing.Point(1093, 272)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 49
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCanelar
        '
        Me.BtnCanelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCanelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCanelar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCanelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCanelar.Location = New System.Drawing.Point(1093, 192)
        Me.BtnCanelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCanelar.Name = "BtnCanelar"
        Me.BtnCanelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCanelar.TabIndex = 48
        Me.BtnCanelar.Text = "Cancelar"
        Me.BtnCanelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCanelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCanelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 59)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Signos zodiacales"
        '
        'CuestionarioSignosZodiacales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.multicolor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 1000)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCanelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ImgGeminis)
        Me.Controls.Add(Me.ImgTauro)
        Me.Controls.Add(Me.ImgAries)
        Me.Controls.Add(Me.ImgSignos)
        Me.Controls.Add(Me.ImgPiscis)
        Me.Controls.Add(Me.ImgAcuario)
        Me.Controls.Add(Me.ImgCapricornio)
        Me.Controls.Add(Me.ImgSagitario)
        Me.Controls.Add(Me.ImgEscorpio)
        Me.Controls.Add(Me.ImgLibra)
        Me.Controls.Add(Me.ImgVirgo)
        Me.Controls.Add(Me.ImgLeo)
        Me.Controls.Add(Me.ImgCancer)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.MesTxt)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.DiaTxt)
        Me.Controls.Add(NumeroRegistroLabel)
        Me.Controls.Add(Me.NumeroRegistroTextBox)
        Me.Controls.Add(SignoLabel)
        Me.Controls.Add(Me.SignoTextBox)
        Me.Controls.Add(ElementoLabel)
        Me.Controls.Add(Me.ElementoTextBox)
        Me.Controls.Add(PlanetaLabel)
        Me.Controls.Add(Me.PlanetaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuestionarioSignosZodiacales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuestionarioSignosZodiacales"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignosZodiacalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGeminis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgTauro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPiscis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAcuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCapricornio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSagitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEscorpio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgLibra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVirgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgLeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents SignosZodiacalesBindingSource As BindingSource
    Friend WithEvents SignosZodiacalesTableAdapter As PsicologiaDBDataSetTableAdapters.SignosZodiacalesTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents SignoTextBox As TextBox
    Friend WithEvents ElementoTextBox As TextBox
    Friend WithEvents PlanetaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents MesTxt As ComboBox
    Friend WithEvents DiaTxt As ComboBox
    Friend WithEvents ImgGeminis As PictureBox
    Friend WithEvents ImgTauro As PictureBox
    Friend WithEvents ImgAries As PictureBox
    Friend WithEvents ImgSignos As PictureBox
    Friend WithEvents ImgPiscis As PictureBox
    Friend WithEvents ImgAcuario As PictureBox
    Friend WithEvents ImgCapricornio As PictureBox
    Friend WithEvents ImgSagitario As PictureBox
    Friend WithEvents ImgEscorpio As PictureBox
    Friend WithEvents ImgLibra As PictureBox
    Friend WithEvents ImgVirgo As PictureBox
    Friend WithEvents ImgLeo As PictureBox
    Friend WithEvents ImgCancer As PictureBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCanelar As Button
    Friend WithEvents Label1 As Label
End Class
