<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alimentacion
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
        Dim RayasicoLabel As System.Windows.Forms.Label
        Dim TamasicoLabel As System.Windows.Forms.Label
        Dim SatvicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.AlimentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlimentacionTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.alimentacionTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.AlimentacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.RayasicoTextBox = New System.Windows.Forms.TextBox()
        Me.TamasicoTextBox = New System.Windows.Forms.TextBox()
        Me.SatvicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.bitacoraTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.usuariosTableAdapter()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        RayasicoLabel = New System.Windows.Forms.Label()
        TamasicoLabel = New System.Windows.Forms.Label()
        SatvicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(700, 210)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(188, 24)
        NumeroRegistroLabel.TabIndex = 1
        NumeroRegistroLabel.Text = "Número de registro:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(700, 256)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(104, 24)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matrícula:"
        '
        'RayasicoLabel
        '
        RayasicoLabel.AutoSize = True
        RayasicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RayasicoLabel.Location = New System.Drawing.Point(700, 297)
        RayasicoLabel.Name = "RayasicoLabel"
        RayasicoLabel.Size = New System.Drawing.Size(98, 24)
        RayasicoLabel.TabIndex = 5
        RayasicoLabel.Text = "Rayasico:"
        '
        'TamasicoLabel
        '
        TamasicoLabel.AutoSize = True
        TamasicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TamasicoLabel.Location = New System.Drawing.Point(887, 297)
        TamasicoLabel.Name = "TamasicoLabel"
        TamasicoLabel.Size = New System.Drawing.Size(101, 24)
        TamasicoLabel.TabIndex = 7
        TamasicoLabel.Text = "Tamasico:"
        '
        'SatvicoLabel
        '
        SatvicoLabel.AutoSize = True
        SatvicoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SatvicoLabel.Location = New System.Drawing.Point(1074, 297)
        SatvicoLabel.Name = "SatvicoLabel"
        SatvicoLabel.Size = New System.Drawing.Size(84, 24)
        SatvicoLabel.TabIndex = 9
        SatvicoLabel.Text = "Satvico:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(700, 383)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(121, 24)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripción:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(360, 23)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(561, 55)
        Label1.TabIndex = 13
        Label1.Text = "Registros de alimentación."
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlimentacionBindingSource
        '
        Me.AlimentacionBindingSource.DataMember = "alimentacion"
        Me.AlimentacionBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'AlimentacionTableAdapter
        '
        Me.AlimentacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Me.AlimentacionTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.historialpacienteTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.temperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'AlimentacionDataGridView
        '
        Me.AlimentacionDataGridView.AllowUserToAddRows = False
        Me.AlimentacionDataGridView.AllowUserToDeleteRows = False
        Me.AlimentacionDataGridView.AutoGenerateColumns = False
        Me.AlimentacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AlimentacionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AlimentacionDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.AlimentacionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlimentacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlimentacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AlimentacionDataGridView.DataSource = Me.AlimentacionBindingSource
        Me.AlimentacionDataGridView.GridColor = System.Drawing.Color.PaleGreen
        Me.AlimentacionDataGridView.Location = New System.Drawing.Point(11, 210)
        Me.AlimentacionDataGridView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AlimentacionDataGridView.Name = "AlimentacionDataGridView"
        Me.AlimentacionDataGridView.ReadOnly = True
        Me.AlimentacionDataGridView.Size = New System.Drawing.Size(671, 578)
        Me.AlimentacionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroRegistro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número de registro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Matrícula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Rayasico"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rayasico"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tamasico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tamasico"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 97
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Satvico"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Satvico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 83
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.BackColor = System.Drawing.Color.White
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(913, 202)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(259, 32)
        Me.NumeroRegistroTextBox.TabIndex = 2
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(826, 248)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(346, 32)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RayasicoTextBox
        '
        Me.RayasicoTextBox.BackColor = System.Drawing.Color.White
        Me.RayasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Rayasico", True))
        Me.RayasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RayasicoTextBox.Location = New System.Drawing.Point(704, 330)
        Me.RayasicoTextBox.Name = "RayasicoTextBox"
        Me.RayasicoTextBox.ReadOnly = True
        Me.RayasicoTextBox.Size = New System.Drawing.Size(150, 32)
        Me.RayasicoTextBox.TabIndex = 6
        Me.RayasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TamasicoTextBox
        '
        Me.TamasicoTextBox.BackColor = System.Drawing.Color.White
        Me.TamasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Tamasico", True))
        Me.TamasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TamasicoTextBox.Location = New System.Drawing.Point(891, 330)
        Me.TamasicoTextBox.Name = "TamasicoTextBox"
        Me.TamasicoTextBox.ReadOnly = True
        Me.TamasicoTextBox.Size = New System.Drawing.Size(150, 32)
        Me.TamasicoTextBox.TabIndex = 8
        Me.TamasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SatvicoTextBox
        '
        Me.SatvicoTextBox.BackColor = System.Drawing.Color.White
        Me.SatvicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Satvico", True))
        Me.SatvicoTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SatvicoTextBox.Location = New System.Drawing.Point(1078, 330)
        Me.SatvicoTextBox.Name = "SatvicoTextBox"
        Me.SatvicoTextBox.ReadOnly = True
        Me.SatvicoTextBox.Size = New System.Drawing.Size(150, 32)
        Me.SatvicoTextBox.TabIndex = 10
        Me.SatvicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.Color.White
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(704, 424)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ReadOnly = True
        Me.DescripcionTextBox.Size = New System.Drawing.Size(564, 364)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(842, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 32)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Busqueda por matrícula:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(894, 144)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(374, 41)
        Me.TxtBuscar.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(848, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(623, 110)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(200, 75)
        Me.BtnCancelar.TabIndex = 27
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(215, 110)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(200, 75)
        Me.BtnEliminar.TabIndex = 26
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(419, 110)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(200, 75)
        Me.BtnGuardar.TabIndex = 25
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.notas45p
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(11, 110)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(200, 75)
        Me.BtnModificar.TabIndex = 24
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.PersonalityTests.My.Resources.Resources.cancelar
        Me.BtnClose.Location = New System.Drawing.Point(1221, 9)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 17
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
        'alimentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1291, 808)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NumeroRegistroLabel)
        Me.Controls.Add(Me.NumeroRegistroTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(RayasicoLabel)
        Me.Controls.Add(Me.RayasicoTextBox)
        Me.Controls.Add(TamasicoLabel)
        Me.Controls.Add(Me.TamasicoTextBox)
        Me.Controls.Add(SatvicoLabel)
        Me.Controls.Add(Me.SatvicoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.AlimentacionDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "alimentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "alimentacion"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents AlimentacionBindingSource As BindingSource
    Friend WithEvents AlimentacionTableAdapter As psicologiadbDataSetTableAdapters.alimentacionTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlimentacionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents RayasicoTextBox As TextBox
    Friend WithEvents TamasicoTextBox As TextBox
    Friend WithEvents SatvicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BitacoraBindingSource As BindingSource
    Friend WithEvents BitacoraTableAdapter As psicologiadbDataSetTableAdapters.bitacoraTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As psicologiadbDataSetTableAdapters.usuariosTableAdapter
End Class
