<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroTemperamentos
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
        Dim SanguineoLabel As System.Windows.Forms.Label
        Dim MelancolicoLabel As System.Windows.Forms.Label
        Dim ColericoLabel As System.Windows.Forms.Label
        Dim FlematicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Me.TemperamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.SanguineoTextBox = New System.Windows.Forms.TextBox()
        Me.MelancolicoTextBox = New System.Windows.Forms.TextBox()
        Me.ColericoTextBox = New System.Windows.Forms.TextBox()
        Me.FlematicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TemperamentosTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        SanguineoLabel = New System.Windows.Forms.Label()
        MelancolicoLabel = New System.Windows.Forms.Label()
        ColericoLabel = New System.Windows.Forms.Label()
        FlematicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.TemperamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(751, 239)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(196, 26)
        NumeroRegistroLabel.TabIndex = 1
        NumeroRegistroLabel.Text = "Numero Registro:"
        '
        'SanguineoLabel
        '
        SanguineoLabel.AutoSize = True
        SanguineoLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SanguineoLabel.Location = New System.Drawing.Point(759, 373)
        SanguineoLabel.Name = "SanguineoLabel"
        SanguineoLabel.Size = New System.Drawing.Size(126, 26)
        SanguineoLabel.TabIndex = 3
        SanguineoLabel.Text = "Sanguineo:"
        '
        'MelancolicoLabel
        '
        MelancolicoLabel.AutoSize = True
        MelancolicoLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MelancolicoLabel.Location = New System.Drawing.Point(759, 439)
        MelancolicoLabel.Name = "MelancolicoLabel"
        MelancolicoLabel.Size = New System.Drawing.Size(146, 26)
        MelancolicoLabel.TabIndex = 5
        MelancolicoLabel.Text = "Melancolico:"
        '
        'ColericoLabel
        '
        ColericoLabel.AutoSize = True
        ColericoLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColericoLabel.Location = New System.Drawing.Point(759, 498)
        ColericoLabel.Name = "ColericoLabel"
        ColericoLabel.Size = New System.Drawing.Size(108, 26)
        ColericoLabel.TabIndex = 7
        ColericoLabel.Text = "Colerico:"
        '
        'FlematicoLabel
        '
        FlematicoLabel.AutoSize = True
        FlematicoLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FlematicoLabel.Location = New System.Drawing.Point(759, 556)
        FlematicoLabel.Name = "FlematicoLabel"
        FlematicoLabel.Size = New System.Drawing.Size(122, 26)
        FlematicoLabel.TabIndex = 9
        FlematicoLabel.Text = "Flematico:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(759, 617)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(142, 26)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripcion:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(751, 303)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(124, 26)
        MatriculaLabel.TabIndex = 13
        MatriculaLabel.Text = "Matricula:"
        '
        'TemperamentosDataGridView
        '
        Me.TemperamentosDataGridView.AllowUserToAddRows = False
        Me.TemperamentosDataGridView.AllowUserToDeleteRows = False
        Me.TemperamentosDataGridView.AutoGenerateColumns = False
        Me.TemperamentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TemperamentosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TemperamentosDataGridView.BackgroundColor = System.Drawing.Color.Violet
        Me.TemperamentosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TemperamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TemperamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TemperamentosDataGridView.DataSource = Me.TemperamentosBindingSource
        Me.TemperamentosDataGridView.GridColor = System.Drawing.Color.Violet
        Me.TemperamentosDataGridView.Location = New System.Drawing.Point(19, 140)
        Me.TemperamentosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TemperamentosDataGridView.Name = "TemperamentosDataGridView"
        Me.TemperamentosDataGridView.ReadOnly = True
        Me.TemperamentosDataGridView.Size = New System.Drawing.Size(706, 701)
        Me.TemperamentosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número de registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sanguineo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sanguineo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 103
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Melancolico"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Melancolico"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 116
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Colerico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Colerico"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Flematico"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Flematico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 99
        '
        'TemperamentosBindingSource
        '
        Me.TemperamentosBindingSource.DataMember = "Temperamentos"
        Me.TemperamentosBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(964, 230)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(171, 35)
        Me.NumeroRegistroTextBox.TabIndex = 2
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SanguineoTextBox
        '
        Me.SanguineoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Sanguineo", True))
        Me.SanguineoTextBox.Enabled = False
        Me.SanguineoTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanguineoTextBox.Location = New System.Drawing.Point(913, 364)
        Me.SanguineoTextBox.Name = "SanguineoTextBox"
        Me.SanguineoTextBox.Size = New System.Drawing.Size(199, 35)
        Me.SanguineoTextBox.TabIndex = 4
        Me.SanguineoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MelancolicoTextBox
        '
        Me.MelancolicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Melancolico", True))
        Me.MelancolicoTextBox.Enabled = False
        Me.MelancolicoTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MelancolicoTextBox.Location = New System.Drawing.Point(913, 430)
        Me.MelancolicoTextBox.Name = "MelancolicoTextBox"
        Me.MelancolicoTextBox.Size = New System.Drawing.Size(199, 35)
        Me.MelancolicoTextBox.TabIndex = 6
        Me.MelancolicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColericoTextBox
        '
        Me.ColericoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Colerico", True))
        Me.ColericoTextBox.Enabled = False
        Me.ColericoTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColericoTextBox.Location = New System.Drawing.Point(913, 489)
        Me.ColericoTextBox.Name = "ColericoTextBox"
        Me.ColericoTextBox.Size = New System.Drawing.Size(199, 35)
        Me.ColericoTextBox.TabIndex = 8
        Me.ColericoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlematicoTextBox
        '
        Me.FlematicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Flematico", True))
        Me.FlematicoTextBox.Enabled = False
        Me.FlematicoTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlematicoTextBox.Location = New System.Drawing.Point(913, 547)
        Me.FlematicoTextBox.Name = "FlematicoTextBox"
        Me.FlematicoTextBox.Size = New System.Drawing.Size(199, 35)
        Me.FlematicoTextBox.TabIndex = 10
        Me.FlematicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(756, 656)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(725, 185)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(881, 294)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(254, 35)
        Me.MatriculaTextBox.TabIndex = 14
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(756, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(807, 145)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(451, 40)
        Me.TxtBuscar.TabIndex = 35
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1208, 337)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 40
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(1208, 230)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.Modificar
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(1208, 444)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(250, 75)
        Me.BtnModificar.TabIndex = 38
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(1208, 551)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(250, 75)
        Me.BtnEliminar.TabIndex = 37
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 55)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Temperamentos."
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.PersonalityTests.My.Resources.Resources.Salir1
        Me.BtnSalir.Location = New System.Drawing.Point(1438, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(50, 53)
        Me.BtnSalir.TabIndex = 42
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TemperamentosTableAdapter
        '
        Me.TemperamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Me.TemperamentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'registroTemperamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(1500, 900)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(NumeroRegistroLabel)
        Me.Controls.Add(Me.NumeroRegistroTextBox)
        Me.Controls.Add(SanguineoLabel)
        Me.Controls.Add(Me.SanguineoTextBox)
        Me.Controls.Add(MelancolicoLabel)
        Me.Controls.Add(Me.MelancolicoTextBox)
        Me.Controls.Add(ColericoLabel)
        Me.Controls.Add(Me.ColericoTextBox)
        Me.Controls.Add(FlematicoLabel)
        Me.Controls.Add(Me.FlematicoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.TemperamentosDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registroTemperamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registroTemperamentos"
        CType(Me.TemperamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents TemperamentosBindingSource As BindingSource
    Friend WithEvents TemperamentosTableAdapter As PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TemperamentosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents SanguineoTextBox As TextBox
    Friend WithEvents MelancolicoTextBox As TextBox
    Friend WithEvents ColericoTextBox As TextBox
    Friend WithEvents FlematicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
End Class
