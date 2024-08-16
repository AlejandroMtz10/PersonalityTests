<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signosZodiacales
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
        Me.SignoszodiacalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.SignoTextBox = New System.Windows.Forms.TextBox()
        Me.ElementoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanetaTextBox = New System.Windows.Forms.TextBox()
        Me.PosiblesProblemasTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalidadTextBox = New System.Windows.Forms.TextBox()
        Me.MesTextBox = New System.Windows.Forms.TextBox()
        Me.DiaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.bitacoraTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.usuariosTableAdapter()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
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
        CType(Me.SignoszodiacalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(294, 210)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(174, 22)
        NumeroRegistroLabel.TabIndex = 1
        NumeroRegistroLabel.Text = "Número de registro:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(294, 251)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(96, 22)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'SignoLabel
        '
        SignoLabel.AutoSize = True
        SignoLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignoLabel.Location = New System.Drawing.Point(559, 251)
        SignoLabel.Name = "SignoLabel"
        SignoLabel.Size = New System.Drawing.Size(61, 22)
        SignoLabel.TabIndex = 9
        SignoLabel.Text = "Signo:"
        '
        'ElementoLabel
        '
        ElementoLabel.AutoSize = True
        ElementoLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElementoLabel.Location = New System.Drawing.Point(1049, 251)
        ElementoLabel.Name = "ElementoLabel"
        ElementoLabel.Size = New System.Drawing.Size(92, 22)
        ElementoLabel.TabIndex = 11
        ElementoLabel.Text = "Elemento:"
        '
        'PlanetaLabel
        '
        PlanetaLabel.AutoSize = True
        PlanetaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlanetaLabel.Location = New System.Drawing.Point(804, 251)
        PlanetaLabel.Name = "PlanetaLabel"
        PlanetaLabel.Size = New System.Drawing.Size(77, 22)
        PlanetaLabel.TabIndex = 13
        PlanetaLabel.Text = "Planeta:"
        '
        'PosiblesProblemasLabel
        '
        PosiblesProblemasLabel.AutoSize = True
        PosiblesProblemasLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PosiblesProblemasLabel.Location = New System.Drawing.Point(660, 327)
        PosiblesProblemasLabel.Name = "PosiblesProblemasLabel"
        PosiblesProblemasLabel.Size = New System.Drawing.Size(174, 22)
        PosiblesProblemasLabel.TabIndex = 15
        PosiblesProblemasLabel.Text = "Posibles Problemas:"
        '
        'PersonalidadLabel
        '
        PersonalidadLabel.AutoSize = True
        PersonalidadLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersonalidadLabel.Location = New System.Drawing.Point(660, 508)
        PersonalidadLabel.Name = "PersonalidadLabel"
        PersonalidadLabel.Size = New System.Drawing.Size(122, 22)
        PersonalidadLabel.TabIndex = 17
        PersonalidadLabel.Text = "Personalidad:"
        '
        'MesLabel
        '
        MesLabel.AutoSize = True
        MesLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        MesLabel.Location = New System.Drawing.Point(731, 213)
        MesLabel.Name = "MesLabel"
        MesLabel.Size = New System.Drawing.Size(50, 22)
        MesLabel.TabIndex = 18
        MesLabel.Text = "Mes:"
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        DiaLabel.Location = New System.Drawing.Point(1008, 213)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(44, 22)
        DiaLabel.TabIndex = 19
        DiaLabel.Text = "Día:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(340, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(643, 55)
        Label1.TabIndex = 44
        Label1.Text = "Registros de signos zodiacales."
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
        'SignoszodiacalesDataGridView
        '
        Me.SignoszodiacalesDataGridView.AllowUserToAddRows = False
        Me.SignoszodiacalesDataGridView.AllowUserToDeleteRows = False
        Me.SignoszodiacalesDataGridView.AutoGenerateColumns = False
        Me.SignoszodiacalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SignoszodiacalesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SignoszodiacalesDataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.SignoszodiacalesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SignoszodiacalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SignoszodiacalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SignoszodiacalesDataGridView.DataSource = Me.SignoszodiacalesBindingSource
        Me.SignoszodiacalesDataGridView.Location = New System.Drawing.Point(12, 327)
        Me.SignoszodiacalesDataGridView.Name = "SignoszodiacalesDataGridView"
        Me.SignoszodiacalesDataGridView.ReadOnly = True
        Me.SignoszodiacalesDataGridView.Size = New System.Drawing.Size(625, 461)
        Me.SignoszodiacalesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número de registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Matrícula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 89
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Signo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Signo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Elemento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Planeta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Planeta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 77
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.BackColor = System.Drawing.Color.White
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(479, 210)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(226, 29)
        Me.NumeroRegistroTextBox.TabIndex = 2
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(298, 286)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(240, 29)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignoTextBox
        '
        Me.SignoTextBox.BackColor = System.Drawing.Color.White
        Me.SignoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Signo", True))
        Me.SignoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignoTextBox.Location = New System.Drawing.Point(561, 286)
        Me.SignoTextBox.Name = "SignoTextBox"
        Me.SignoTextBox.ReadOnly = True
        Me.SignoTextBox.Size = New System.Drawing.Size(220, 29)
        Me.SignoTextBox.TabIndex = 10
        Me.SignoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ElementoTextBox
        '
        Me.ElementoTextBox.BackColor = System.Drawing.Color.White
        Me.ElementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Elemento", True))
        Me.ElementoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementoTextBox.Location = New System.Drawing.Point(1053, 286)
        Me.ElementoTextBox.Name = "ElementoTextBox"
        Me.ElementoTextBox.ReadOnly = True
        Me.ElementoTextBox.Size = New System.Drawing.Size(215, 29)
        Me.ElementoTextBox.TabIndex = 12
        Me.ElementoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetaTextBox
        '
        Me.PlanetaTextBox.BackColor = System.Drawing.Color.White
        Me.PlanetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Planeta", True))
        Me.PlanetaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetaTextBox.Location = New System.Drawing.Point(808, 286)
        Me.PlanetaTextBox.Name = "PlanetaTextBox"
        Me.PlanetaTextBox.ReadOnly = True
        Me.PlanetaTextBox.Size = New System.Drawing.Size(215, 29)
        Me.PlanetaTextBox.TabIndex = 14
        Me.PlanetaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PosiblesProblemasTextBox
        '
        Me.PosiblesProblemasTextBox.BackColor = System.Drawing.Color.White
        Me.PosiblesProblemasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "PosiblesProblemas", True))
        Me.PosiblesProblemasTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosiblesProblemasTextBox.Location = New System.Drawing.Point(664, 368)
        Me.PosiblesProblemasTextBox.Multiline = True
        Me.PosiblesProblemasTextBox.Name = "PosiblesProblemasTextBox"
        Me.PosiblesProblemasTextBox.ReadOnly = True
        Me.PosiblesProblemasTextBox.Size = New System.Drawing.Size(604, 123)
        Me.PosiblesProblemasTextBox.TabIndex = 16
        '
        'PersonalidadTextBox
        '
        Me.PersonalidadTextBox.BackColor = System.Drawing.Color.White
        Me.PersonalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Personalidad", True))
        Me.PersonalidadTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalidadTextBox.Location = New System.Drawing.Point(664, 551)
        Me.PersonalidadTextBox.Multiline = True
        Me.PersonalidadTextBox.Name = "PersonalidadTextBox"
        Me.PersonalidadTextBox.ReadOnly = True
        Me.PersonalidadTextBox.Size = New System.Drawing.Size(604, 237)
        Me.PersonalidadTextBox.TabIndex = 18
        '
        'MesTextBox
        '
        Me.MesTextBox.BackColor = System.Drawing.Color.White
        Me.MesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Mes", True))
        Me.MesTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MesTextBox.Location = New System.Drawing.Point(808, 210)
        Me.MesTextBox.Name = "MesTextBox"
        Me.MesTextBox.ReadOnly = True
        Me.MesTextBox.Size = New System.Drawing.Size(184, 29)
        Me.MesTextBox.TabIndex = 19
        Me.MesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiaTextBox
        '
        Me.DiaTextBox.BackColor = System.Drawing.Color.White
        Me.DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignoszodiacalesBindingSource, "Dia", True))
        Me.DiaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.DiaTextBox.Location = New System.Drawing.Point(1084, 210)
        Me.DiaTextBox.Name = "DiaTextBox"
        Me.DiaTextBox.ReadOnly = True
        Me.DiaTextBox.Size = New System.Drawing.Size(184, 29)
        Me.DiaTextBox.TabIndex = 20
        Me.DiaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(624, 110)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(200, 75)
        Me.BtnCancelar.TabIndex = 40
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Violet
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(216, 110)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(200, 75)
        Me.BtnEliminar.TabIndex = 39
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(420, 110)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(200, 75)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Violet
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.notas45p
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(12, 110)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(200, 75)
        Me.BtnModificar.TabIndex = 37
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(848, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(842, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 32)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Busqueda por matrícula:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(894, 144)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(374, 41)
        Me.TxtBuscar.TabIndex = 41
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.PersonalityTests.My.Resources.Resources.cancelar
        Me.BtnClose.Location = New System.Drawing.Point(1229, 9)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 45
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'signosZodiacales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1299, 808)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(DiaLabel)
        Me.Controls.Add(Me.DiaTextBox)
        Me.Controls.Add(MesLabel)
        Me.Controls.Add(Me.MesTextBox)
        Me.Controls.Add(NumeroRegistroLabel)
        Me.Controls.Add(Me.NumeroRegistroTextBox)
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
        Me.Controls.Add(Me.SignoszodiacalesDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "signosZodiacales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "signosZodiacales"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignoszodiacalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignoszodiacalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents SignoszodiacalesBindingSource As BindingSource
    Friend WithEvents SignoszodiacalesTableAdapter As psicologiadbDataSetTableAdapters.signoszodiacalesTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SignoszodiacalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents SignoTextBox As TextBox
    Friend WithEvents ElementoTextBox As TextBox
    Friend WithEvents PlanetaTextBox As TextBox
    Friend WithEvents PosiblesProblemasTextBox As TextBox
    Friend WithEvents PersonalidadTextBox As TextBox
    Friend WithEvents MesTextBox As TextBox
    Friend WithEvents DiaTextBox As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BitacoraBindingSource As BindingSource
    Friend WithEvents BitacoraTableAdapter As psicologiadbDataSetTableAdapters.bitacoraTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As psicologiadbDataSetTableAdapters.usuariosTableAdapter
End Class
