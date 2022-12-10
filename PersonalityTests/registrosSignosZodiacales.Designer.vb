<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrosSignosZodiacales
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
        Me.SignosZodiacalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.SignoTextBox = New System.Windows.Forms.TextBox()
        Me.ElementoTextBox = New System.Windows.Forms.TextBox()
        Me.PlanetaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SignosZodiacalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignosZodiacalesTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.SignosZodiacalesTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        SignoLabel = New System.Windows.Forms.Label()
        ElementoLabel = New System.Windows.Forms.Label()
        PlanetaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.SignosZodiacalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignosZodiacalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignosZodiacalesDataGridView
        '
        Me.SignosZodiacalesDataGridView.AllowUserToAddRows = False
        Me.SignosZodiacalesDataGridView.AllowUserToDeleteRows = False
        Me.SignosZodiacalesDataGridView.AutoGenerateColumns = False
        Me.SignosZodiacalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SignosZodiacalesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SignosZodiacalesDataGridView.BackgroundColor = System.Drawing.Color.DarkOrchid
        Me.SignosZodiacalesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SignosZodiacalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SignosZodiacalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SignosZodiacalesDataGridView.DataSource = Me.SignosZodiacalesBindingSource
        Me.SignosZodiacalesDataGridView.Location = New System.Drawing.Point(12, 151)
        Me.SignosZodiacalesDataGridView.Name = "SignosZodiacalesDataGridView"
        Me.SignosZodiacalesDataGridView.ReadOnly = True
        Me.SignosZodiacalesDataGridView.Size = New System.Drawing.Size(691, 737)
        Me.SignosZodiacalesDataGridView.TabIndex = 1
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(740, 264)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(188, 24)
        NumeroRegistroLabel.TabIndex = 1
        NumeroRegistroLabel.Text = "Número de registro:"
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(950, 256)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(212, 32)
        Me.NumeroRegistroTextBox.TabIndex = 2
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignoLabel
        '
        SignoLabel.AutoSize = True
        SignoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignoLabel.Location = New System.Drawing.Point(740, 380)
        SignoLabel.Name = "SignoLabel"
        SignoLabel.Size = New System.Drawing.Size(67, 24)
        SignoLabel.TabIndex = 3
        SignoLabel.Text = "Signo:"
        '
        'SignoTextBox
        '
        Me.SignoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Signo", True))
        Me.SignoTextBox.Enabled = False
        Me.SignoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignoTextBox.Location = New System.Drawing.Point(846, 372)
        Me.SignoTextBox.Name = "SignoTextBox"
        Me.SignoTextBox.Size = New System.Drawing.Size(316, 32)
        Me.SignoTextBox.TabIndex = 4
        Me.SignoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ElementoLabel
        '
        ElementoLabel.AutoSize = True
        ElementoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElementoLabel.Location = New System.Drawing.Point(740, 438)
        ElementoLabel.Name = "ElementoLabel"
        ElementoLabel.Size = New System.Drawing.Size(102, 24)
        ElementoLabel.TabIndex = 5
        ElementoLabel.Text = "Elemento:"
        '
        'ElementoTextBox
        '
        Me.ElementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Elemento", True))
        Me.ElementoTextBox.Enabled = False
        Me.ElementoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementoTextBox.Location = New System.Drawing.Point(846, 430)
        Me.ElementoTextBox.Name = "ElementoTextBox"
        Me.ElementoTextBox.Size = New System.Drawing.Size(314, 32)
        Me.ElementoTextBox.TabIndex = 6
        Me.ElementoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlanetaLabel
        '
        PlanetaLabel.AutoSize = True
        PlanetaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlanetaLabel.Location = New System.Drawing.Point(740, 496)
        PlanetaLabel.Name = "PlanetaLabel"
        PlanetaLabel.Size = New System.Drawing.Size(86, 24)
        PlanetaLabel.TabIndex = 7
        PlanetaLabel.Text = "Planeta:"
        '
        'PlanetaTextBox
        '
        Me.PlanetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Planeta", True))
        Me.PlanetaTextBox.Enabled = False
        Me.PlanetaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanetaTextBox.Location = New System.Drawing.Point(846, 488)
        Me.PlanetaTextBox.Name = "PlanetaTextBox"
        Me.PlanetaTextBox.Size = New System.Drawing.Size(316, 32)
        Me.PlanetaTextBox.TabIndex = 8
        Me.PlanetaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(740, 549)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(121, 24)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(744, 589)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(744, 301)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(740, 322)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(104, 24)
        MatriculaLabel.TabIndex = 11
        MatriculaLabel.Text = "Matricula:"
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SignosZodiacalesBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(865, 314)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(297, 32)
        Me.MatriculaTextBox.TabIndex = 12
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1238, 310)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 44
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(1238, 216)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.Modificar
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(1238, 404)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(250, 75)
        Me.BtnModificar.TabIndex = 42
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(1238, 498)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(250, 75)
        Me.BtnEliminar.TabIndex = 41
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(735, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(786, 151)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(451, 40)
        Me.TxtBuscar.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 55)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Signos del zodiaco."
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
        Me.BtnSalir.TabIndex = 48
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'SignosZodiacalesBindingSource
        '
        Me.SignosZodiacalesBindingSource.DataMember = "SignosZodiacales"
        Me.SignosZodiacalesBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número de registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 98
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 91
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Signo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Signo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 68
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Elemento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Planeta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Astro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 68
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
        'registrosSignosZodiacales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1500, 908)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
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
        Me.Controls.Add(Me.SignosZodiacalesDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "registrosSignosZodiacales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrosSignosZodiacales"
        CType(Me.SignosZodiacalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignosZodiacalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents SignosZodiacalesBindingSource As BindingSource
    Friend WithEvents SignosZodiacalesTableAdapter As PsicologiaDBDataSetTableAdapters.SignosZodiacalesTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SignosZodiacalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents SignoTextBox As TextBox
    Friend WithEvents ElementoTextBox As TextBox
    Friend WithEvents PlanetaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
End Class
