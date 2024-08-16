<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestsSignosZodiaco
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
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim SignoLabel As System.Windows.Forms.Label
        Dim ElementoLabel As System.Windows.Forms.Label
        Dim PlanetaLabel As System.Windows.Forms.Label
        Dim PosiblesProblemasLabel As System.Windows.Forms.Label
        Dim PersonalidadLabel As System.Windows.Forms.Label
        Dim MesLabel As System.Windows.Forms.Label
        Dim DiaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.SignoszodiacalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignoszodiacalesTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.signoszodiacalesTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.SignoTextBox = New System.Windows.Forms.TextBox()
        Me.ElementoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanetaTextBox = New System.Windows.Forms.TextBox()
        Me.PosiblesProblemasTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalidadTextBox = New System.Windows.Forms.TextBox()
        Me.MesComboBox = New System.Windows.Forms.ComboBox()
        Me.DiaComboBox = New System.Windows.Forms.ComboBox()
        Me.ImgSignos = New System.Windows.Forms.PictureBox()
        Me.ImgSignoAries = New System.Windows.Forms.PictureBox()
        Me.ImgSignoTauro = New System.Windows.Forms.PictureBox()
        Me.ImgSignoGeminis = New System.Windows.Forms.PictureBox()
        Me.ImgSignoCancer = New System.Windows.Forms.PictureBox()
        Me.ImgSignoLeo = New System.Windows.Forms.PictureBox()
        Me.ImgSignoVirgo = New System.Windows.Forms.PictureBox()
        Me.ImgSignoLibra = New System.Windows.Forms.PictureBox()
        Me.ImgSignoEscorpio = New System.Windows.Forms.PictureBox()
        Me.ImgSignoSagitario = New System.Windows.Forms.PictureBox()
        Me.ImgSignoCapricornio = New System.Windows.Forms.PictureBox()
        Me.ImgSignoAcuario = New System.Windows.Forms.PictureBox()
        Me.ImgSignoPiscis = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        MatriculaLabel = New System.Windows.Forms.Label()
        SignoLabel = New System.Windows.Forms.Label()
        ElementoLabel = New System.Windows.Forms.Label()
        PlanetaLabel = New System.Windows.Forms.Label()
        PosiblesProblemasLabel = New System.Windows.Forms.Label()
        PersonalidadLabel = New System.Windows.Forms.Label()
        MesLabel = New System.Windows.Forms.Label()
        DiaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignoszodiacalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoAries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoTauro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoGeminis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoCancer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoLeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoVirgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoLibra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoEscorpio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoSagitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoCapricornio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoAcuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSignoPiscis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(31, 144)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(148, 32)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'SignoLabel
        '
        SignoLabel.AutoSize = True
        SignoLabel.BackColor = System.Drawing.Color.Transparent
        SignoLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignoLabel.Location = New System.Drawing.Point(31, 325)
        SignoLabel.Name = "SignoLabel"
        SignoLabel.Size = New System.Drawing.Size(94, 32)
        SignoLabel.TabIndex = 9
        SignoLabel.Text = "Signo:"
        '
        'ElementoLabel
        '
        ElementoLabel.AutoSize = True
        ElementoLabel.BackColor = System.Drawing.Color.Transparent
        ElementoLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElementoLabel.Location = New System.Drawing.Point(449, 325)
        ElementoLabel.Name = "ElementoLabel"
        ElementoLabel.Size = New System.Drawing.Size(142, 32)
        ElementoLabel.TabIndex = 11
        ElementoLabel.Text = "Elemento:"
        '
        'PlanetaLabel
        '
        PlanetaLabel.AutoSize = True
        PlanetaLabel.BackColor = System.Drawing.Color.Transparent
        PlanetaLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlanetaLabel.Location = New System.Drawing.Point(894, 319)
        PlanetaLabel.Name = "PlanetaLabel"
        PlanetaLabel.Size = New System.Drawing.Size(118, 32)
        PlanetaLabel.TabIndex = 13
        PlanetaLabel.Text = "Planeta:"
        '
        'PosiblesProblemasLabel
        '
        PosiblesProblemasLabel.AutoSize = True
        PosiblesProblemasLabel.BackColor = System.Drawing.Color.Transparent
        PosiblesProblemasLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PosiblesProblemasLabel.Location = New System.Drawing.Point(31, 399)
        PosiblesProblemasLabel.Name = "PosiblesProblemasLabel"
        PosiblesProblemasLabel.Size = New System.Drawing.Size(152, 64)
        PosiblesProblemasLabel.TabIndex = 15
        PosiblesProblemasLabel.Text = "Posibles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "problemas:"
        '
        'PersonalidadLabel
        '
        PersonalidadLabel.AutoSize = True
        PersonalidadLabel.BackColor = System.Drawing.Color.Transparent
        PersonalidadLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersonalidadLabel.Location = New System.Drawing.Point(31, 480)
        PersonalidadLabel.Name = "PersonalidadLabel"
        PersonalidadLabel.Size = New System.Drawing.Size(185, 32)
        PersonalidadLabel.TabIndex = 17
        PersonalidadLabel.Text = "Personalidad:"
        '
        'MesLabel
        '
        MesLabel.AutoSize = True
        MesLabel.BackColor = System.Drawing.Color.Transparent
        MesLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesLabel.Location = New System.Drawing.Point(653, 218)
        MesLabel.Name = "MesLabel"
        MesLabel.Size = New System.Drawing.Size(77, 32)
        MesLabel.TabIndex = 18
        MesLabel.Text = "Mes:"
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.BackColor = System.Drawing.Color.Transparent
        DiaLabel.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiaLabel.Location = New System.Drawing.Point(653, 144)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(68, 32)
        DiaLabel.TabIndex = 19
        DiaLabel.Text = "Dia:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(506, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(388, 55)
        Label1.TabIndex = 38
        Label1.Text = "Signos zodiacales."
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SignoszodiacalesBindingSource
        '
        Me.SignoszodiacalesBindingSource.DataMember = "signoszodiacales"
        Me.SignoszodiacalesBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'SignoszodiacalesTableAdapter
        '
        Me.SignoszodiacalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.historialpacienteTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Me.SignoszodiacalesTableAdapter
        Me.TableAdapterManager.temperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(37, 210)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(337, 41)
        Me.MatriculaTextBox.TabIndex = 4
        '
        'SignoTextBox
        '
        Me.SignoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.SignoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Signo", True))
        Me.SignoTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignoTextBox.Location = New System.Drawing.Point(134, 316)
        Me.SignoTextBox.Name = "SignoTextBox"
        Me.SignoTextBox.ReadOnly = True
        Me.SignoTextBox.Size = New System.Drawing.Size(287, 41)
        Me.SignoTextBox.TabIndex = 10
        '
        'ElementoTextBox
        '
        Me.ElementoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ElementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Elemento", True))
        Me.ElementoTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementoTextBox.Location = New System.Drawing.Point(620, 316)
        Me.ElementoTextBox.Name = "ElementoTextBox"
        Me.ElementoTextBox.ReadOnly = True
        Me.ElementoTextBox.Size = New System.Drawing.Size(232, 41)
        Me.ElementoTextBox.TabIndex = 12
        '
        'PlanetaTextBox
        '
        Me.PlanetaTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.PlanetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Planeta", True))
        Me.PlanetaTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetaTextBox.Location = New System.Drawing.Point(1052, 316)
        Me.PlanetaTextBox.Name = "PlanetaTextBox"
        Me.PlanetaTextBox.ReadOnly = True
        Me.PlanetaTextBox.Size = New System.Drawing.Size(232, 41)
        Me.PlanetaTextBox.TabIndex = 14
        '
        'PosiblesProblemasTextBox
        '
        Me.PosiblesProblemasTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.PosiblesProblemasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "PosiblesProblemas", True))
        Me.PosiblesProblemasTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosiblesProblemasTextBox.Location = New System.Drawing.Point(202, 394)
        Me.PosiblesProblemasTextBox.Multiline = True
        Me.PosiblesProblemasTextBox.Name = "PosiblesProblemasTextBox"
        Me.PosiblesProblemasTextBox.ReadOnly = True
        Me.PosiblesProblemasTextBox.Size = New System.Drawing.Size(583, 83)
        Me.PosiblesProblemasTextBox.TabIndex = 16
        '
        'PersonalidadTextBox
        '
        Me.PersonalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Personalidad", True))
        Me.PersonalidadTextBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalidadTextBox.Location = New System.Drawing.Point(37, 520)
        Me.PersonalidadTextBox.Multiline = True
        Me.PersonalidadTextBox.Name = "PersonalidadTextBox"
        Me.PersonalidadTextBox.ReadOnly = True
        Me.PersonalidadTextBox.Size = New System.Drawing.Size(748, 330)
        Me.PersonalidadTextBox.TabIndex = 18
        '
        'MesComboBox
        '
        Me.MesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Mes", True))
        Me.MesComboBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesComboBox.FormattingEnabled = True
        Me.MesComboBox.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesComboBox.Location = New System.Drawing.Point(739, 210)
        Me.MesComboBox.Name = "MesComboBox"
        Me.MesComboBox.Size = New System.Drawing.Size(289, 40)
        Me.MesComboBox.TabIndex = 19
        '
        'DiaComboBox
        '
        Me.DiaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Dia", True))
        Me.DiaComboBox.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaComboBox.FormattingEnabled = True
        Me.DiaComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.DiaComboBox.Location = New System.Drawing.Point(739, 136)
        Me.DiaComboBox.Name = "DiaComboBox"
        Me.DiaComboBox.Size = New System.Drawing.Size(289, 40)
        Me.DiaComboBox.TabIndex = 20
        '
        'ImgSignos
        '
        Me.ImgSignos.Image = Global.PersonalityTests.My.Resources.Resources.signosZodiacales
        Me.ImgSignos.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignos.Name = "ImgSignos"
        Me.ImgSignos.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignos.TabIndex = 22
        Me.ImgSignos.TabStop = False
        '
        'ImgSignoAries
        '
        Me.ImgSignoAries.Image = Global.PersonalityTests.My.Resources.Resources.signoAries
        Me.ImgSignoAries.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoAries.Name = "ImgSignoAries"
        Me.ImgSignoAries.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoAries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoAries.TabIndex = 23
        Me.ImgSignoAries.TabStop = False
        '
        'ImgSignoTauro
        '
        Me.ImgSignoTauro.Image = Global.PersonalityTests.My.Resources.Resources.signoTauro
        Me.ImgSignoTauro.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoTauro.Name = "ImgSignoTauro"
        Me.ImgSignoTauro.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoTauro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoTauro.TabIndex = 24
        Me.ImgSignoTauro.TabStop = False
        '
        'ImgSignoGeminis
        '
        Me.ImgSignoGeminis.Image = Global.PersonalityTests.My.Resources.Resources.signoGeminis
        Me.ImgSignoGeminis.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoGeminis.Name = "ImgSignoGeminis"
        Me.ImgSignoGeminis.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoGeminis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoGeminis.TabIndex = 25
        Me.ImgSignoGeminis.TabStop = False
        '
        'ImgSignoCancer
        '
        Me.ImgSignoCancer.Image = Global.PersonalityTests.My.Resources.Resources.signoCancer
        Me.ImgSignoCancer.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoCancer.Name = "ImgSignoCancer"
        Me.ImgSignoCancer.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoCancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoCancer.TabIndex = 26
        Me.ImgSignoCancer.TabStop = False
        '
        'ImgSignoLeo
        '
        Me.ImgSignoLeo.Image = Global.PersonalityTests.My.Resources.Resources.signoLeo
        Me.ImgSignoLeo.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoLeo.Name = "ImgSignoLeo"
        Me.ImgSignoLeo.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoLeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoLeo.TabIndex = 27
        Me.ImgSignoLeo.TabStop = False
        '
        'ImgSignoVirgo
        '
        Me.ImgSignoVirgo.Image = Global.PersonalityTests.My.Resources.Resources.signoVirgo
        Me.ImgSignoVirgo.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoVirgo.Name = "ImgSignoVirgo"
        Me.ImgSignoVirgo.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoVirgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoVirgo.TabIndex = 28
        Me.ImgSignoVirgo.TabStop = False
        '
        'ImgSignoLibra
        '
        Me.ImgSignoLibra.Image = Global.PersonalityTests.My.Resources.Resources.signoLibra
        Me.ImgSignoLibra.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoLibra.Name = "ImgSignoLibra"
        Me.ImgSignoLibra.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoLibra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoLibra.TabIndex = 29
        Me.ImgSignoLibra.TabStop = False
        '
        'ImgSignoEscorpio
        '
        Me.ImgSignoEscorpio.Image = Global.PersonalityTests.My.Resources.Resources.signoEscorpio
        Me.ImgSignoEscorpio.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoEscorpio.Name = "ImgSignoEscorpio"
        Me.ImgSignoEscorpio.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoEscorpio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoEscorpio.TabIndex = 30
        Me.ImgSignoEscorpio.TabStop = False
        '
        'ImgSignoSagitario
        '
        Me.ImgSignoSagitario.Image = Global.PersonalityTests.My.Resources.Resources.signoSagitario
        Me.ImgSignoSagitario.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoSagitario.Name = "ImgSignoSagitario"
        Me.ImgSignoSagitario.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoSagitario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoSagitario.TabIndex = 31
        Me.ImgSignoSagitario.TabStop = False
        '
        'ImgSignoCapricornio
        '
        Me.ImgSignoCapricornio.Image = Global.PersonalityTests.My.Resources.Resources.signoCapricornio
        Me.ImgSignoCapricornio.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoCapricornio.Name = "ImgSignoCapricornio"
        Me.ImgSignoCapricornio.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoCapricornio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoCapricornio.TabIndex = 32
        Me.ImgSignoCapricornio.TabStop = False
        '
        'ImgSignoAcuario
        '
        Me.ImgSignoAcuario.Image = Global.PersonalityTests.My.Resources.Resources.signoAcuario
        Me.ImgSignoAcuario.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoAcuario.Name = "ImgSignoAcuario"
        Me.ImgSignoAcuario.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoAcuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoAcuario.TabIndex = 33
        Me.ImgSignoAcuario.TabStop = False
        '
        'ImgSignoPiscis
        '
        Me.ImgSignoPiscis.Image = Global.PersonalityTests.My.Resources.Resources.signoPicis
        Me.ImgSignoPiscis.Location = New System.Drawing.Point(833, 520)
        Me.ImgSignoPiscis.Name = "ImgSignoPiscis"
        Me.ImgSignoPiscis.Size = New System.Drawing.Size(540, 330)
        Me.ImgSignoPiscis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSignoPiscis.TabIndex = 34
        Me.ImgSignoPiscis.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1123, 418)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 35
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(858, 418)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 36
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Violet
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = Global.PersonalityTests.My.Resources.Resources.aceptar
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(1126, 162)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(250, 75)
        Me.BtnAceptar.TabIndex = 21
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.PersonalityTests.My.Resources.Resources.cancelar
        Me.BtnSalir.Location = New System.Drawing.Point(1349, 1)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(50, 50)
        Me.BtnSalir.TabIndex = 37
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TestsSignosZodiaco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.multicolor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1400, 900)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.ImgSignoPiscis)
        Me.Controls.Add(Me.ImgSignoAcuario)
        Me.Controls.Add(Me.ImgSignoCapricornio)
        Me.Controls.Add(Me.ImgSignoSagitario)
        Me.Controls.Add(Me.ImgSignoEscorpio)
        Me.Controls.Add(Me.ImgSignoLibra)
        Me.Controls.Add(Me.ImgSignoVirgo)
        Me.Controls.Add(Me.ImgSignoLeo)
        Me.Controls.Add(Me.ImgSignoCancer)
        Me.Controls.Add(Me.ImgSignoGeminis)
        Me.Controls.Add(Me.ImgSignoTauro)
        Me.Controls.Add(Me.ImgSignoAries)
        Me.Controls.Add(Me.ImgSignos)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(DiaLabel)
        Me.Controls.Add(Me.DiaComboBox)
        Me.Controls.Add(MesLabel)
        Me.Controls.Add(Me.MesComboBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(SignoLabel)
        Me.Controls.Add(Me.SignoTextBox)
        Me.Controls.Add(ElementoLabel)
        Me.Controls.Add(Me.ElementoTextBox)
        Me.Controls.Add(PlanetaLabel)
        Me.Controls.Add(Me.PlanetaTextBox)
        Me.Controls.Add(PosiblesProblemasLabel)
        Me.Controls.Add(Me.PosiblesProblemasTextBox)
        Me.Controls.Add(PersonalidadLabel)
        Me.Controls.Add(Me.PersonalidadTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TestsSignosZodiaco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestsSignosZodiaco"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignoszodiacalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoAries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoTauro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoGeminis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoCancer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoLeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoVirgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoLibra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoEscorpio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoSagitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoCapricornio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoAcuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSignoPiscis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents SignoszodiacalesBindingSource As BindingSource
    Friend WithEvents SignoszodiacalesTableAdapter As psicologiadbDataSetTableAdapters.signoszodiacalesTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents SignoTextBox As TextBox
    Friend WithEvents ElementoTextBox As TextBox
    Friend WithEvents PlanetaTextBox As TextBox
    Friend WithEvents PosiblesProblemasTextBox As TextBox
    Friend WithEvents PersonalidadTextBox As TextBox
    Friend WithEvents MesComboBox As ComboBox
    Friend WithEvents DiaComboBox As ComboBox
    Friend WithEvents ImgSignos As PictureBox
    Friend WithEvents ImgSignoAries As PictureBox
    Friend WithEvents ImgSignoTauro As PictureBox
    Friend WithEvents ImgSignoGeminis As PictureBox
    Friend WithEvents ImgSignoCancer As PictureBox
    Friend WithEvents ImgSignoLeo As PictureBox
    Friend WithEvents ImgSignoVirgo As PictureBox
    Friend WithEvents ImgSignoLibra As PictureBox
    Friend WithEvents ImgSignoEscorpio As PictureBox
    Friend WithEvents ImgSignoSagitario As PictureBox
    Friend WithEvents ImgSignoCapricornio As PictureBox
    Friend WithEvents ImgSignoAcuario As PictureBox
    Friend WithEvents ImgSignoPiscis As PictureBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnSalir As Button
End Class
