<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class antecedentes
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
        Dim NumeroHistorialLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim UsoMedicamentosLabel As System.Windows.Forms.Label
        Dim MedicamentosLabel As System.Windows.Forms.Label
        Dim EstadoAnimoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.HistorialpacienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoMedicamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorialpacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.NumeroHistorialTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsoMedicamentosComboBox = New System.Windows.Forms.ComboBox()
        Me.MedicamentosTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoAnimoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.HistorialpacienteTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.historialpacienteTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.usuariosTableAdapter()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.bitacoraTableAdapter()
        NumeroHistorialLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        UsoMedicamentosLabel = New System.Windows.Forms.Label()
        MedicamentosLabel = New System.Windows.Forms.Label()
        EstadoAnimoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.HistorialpacienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialpacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroHistorialLabel
        '
        NumeroHistorialLabel.AutoSize = True
        NumeroHistorialLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroHistorialLabel.Location = New System.Drawing.Point(550, 338)
        NumeroHistorialLabel.Name = "NumeroHistorialLabel"
        NumeroHistorialLabel.Size = New System.Drawing.Size(220, 26)
        NumeroHistorialLabel.TabIndex = 1
        NumeroHistorialLabel.Text = "Número de registro:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(550, 387)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(124, 26)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matrícula:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(550, 438)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(199, 26)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha de registro:"
        '
        'UsoMedicamentosLabel
        '
        UsoMedicamentosLabel.AutoSize = True
        UsoMedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsoMedicamentosLabel.Location = New System.Drawing.Point(550, 481)
        UsoMedicamentosLabel.Name = "UsoMedicamentosLabel"
        UsoMedicamentosLabel.Size = New System.Drawing.Size(239, 26)
        UsoMedicamentosLabel.TabIndex = 7
        UsoMedicamentosLabel.Text = "Uso de medicamentos:"
        '
        'MedicamentosLabel
        '
        MedicamentosLabel.AutoSize = True
        MedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicamentosLabel.Location = New System.Drawing.Point(550, 576)
        MedicamentosLabel.Name = "MedicamentosLabel"
        MedicamentosLabel.Size = New System.Drawing.Size(169, 26)
        MedicamentosLabel.TabIndex = 9
        MedicamentosLabel.Text = "Medicamentos:"
        '
        'EstadoAnimoLabel
        '
        EstadoAnimoLabel.AutoSize = True
        EstadoAnimoLabel.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoAnimoLabel.Location = New System.Drawing.Point(835, 481)
        EstadoAnimoLabel.Name = "EstadoAnimoLabel"
        EstadoAnimoLabel.Size = New System.Drawing.Size(189, 26)
        EstadoAnimoLabel.TabIndex = 11
        EstadoAnimoLabel.Text = "Estado de ánimo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(276, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(728, 55)
        Label1.TabIndex = 51
        Label1.Text = "Registros de historial de pacientes."
        '
        'HistorialpacienteDataGridView
        '
        Me.HistorialpacienteDataGridView.AllowUserToAddRows = False
        Me.HistorialpacienteDataGridView.AllowUserToDeleteRows = False
        Me.HistorialpacienteDataGridView.AutoGenerateColumns = False
        Me.HistorialpacienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.HistorialpacienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HistorialpacienteDataGridView.BackgroundColor = System.Drawing.Color.Coral
        Me.HistorialpacienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistorialpacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialpacienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Fecha, Me.UsoMedicamentos})
        Me.HistorialpacienteDataGridView.DataSource = Me.HistorialpacienteBindingSource
        Me.HistorialpacienteDataGridView.Location = New System.Drawing.Point(12, 227)
        Me.HistorialpacienteDataGridView.Name = "HistorialpacienteDataGridView"
        Me.HistorialpacienteDataGridView.ReadOnly = True
        Me.HistorialpacienteDataGridView.Size = New System.Drawing.Size(537, 561)
        Me.HistorialpacienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroHistorial"
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
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 69
        '
        'UsoMedicamentos
        '
        Me.UsoMedicamentos.DataPropertyName = "UsoMedicamentos"
        Me.UsoMedicamentos.HeaderText = "Uso de medicamentos"
        Me.UsoMedicamentos.Name = "UsoMedicamentos"
        Me.UsoMedicamentos.ReadOnly = True
        Me.UsoMedicamentos.Width = 149
        '
        'HistorialpacienteBindingSource
        '
        Me.HistorialpacienteBindingSource.DataMember = "historialpaciente"
        Me.HistorialpacienteBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumeroHistorialTextBox
        '
        Me.NumeroHistorialTextBox.BackColor = System.Drawing.Color.White
        Me.NumeroHistorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "NumeroHistorial", True))
        Me.NumeroHistorialTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroHistorialTextBox.Location = New System.Drawing.Point(803, 329)
        Me.NumeroHistorialTextBox.Name = "NumeroHistorialTextBox"
        Me.NumeroHistorialTextBox.ReadOnly = True
        Me.NumeroHistorialTextBox.Size = New System.Drawing.Size(237, 35)
        Me.NumeroHistorialTextBox.TabIndex = 2
        Me.NumeroHistorialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(712, 378)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(328, 35)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HistorialpacienteBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(774, 429)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(441, 35)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'UsoMedicamentosComboBox
        '
        Me.UsoMedicamentosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "UsoMedicamentos", True))
        Me.UsoMedicamentosComboBox.Enabled = False
        Me.UsoMedicamentosComboBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoMedicamentosComboBox.FormattingEnabled = True
        Me.UsoMedicamentosComboBox.Location = New System.Drawing.Point(555, 525)
        Me.UsoMedicamentosComboBox.Name = "UsoMedicamentosComboBox"
        Me.UsoMedicamentosComboBox.Size = New System.Drawing.Size(237, 34)
        Me.UsoMedicamentosComboBox.TabIndex = 8
        '
        'MedicamentosTextBox
        '
        Me.MedicamentosTextBox.BackColor = System.Drawing.Color.White
        Me.MedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicamentosTextBox.Location = New System.Drawing.Point(555, 624)
        Me.MedicamentosTextBox.Multiline = True
        Me.MedicamentosTextBox.Name = "MedicamentosTextBox"
        Me.MedicamentosTextBox.ReadOnly = True
        Me.MedicamentosTextBox.Size = New System.Drawing.Size(713, 164)
        Me.MedicamentosTextBox.TabIndex = 10
        '
        'EstadoAnimoTextBox
        '
        Me.EstadoAnimoTextBox.BackColor = System.Drawing.Color.White
        Me.EstadoAnimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "EstadoAnimo", True))
        Me.EstadoAnimoTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoAnimoTextBox.Location = New System.Drawing.Point(840, 524)
        Me.EstadoAnimoTextBox.Multiline = True
        Me.EstadoAnimoTextBox.Name = "EstadoAnimoTextBox"
        Me.EstadoAnimoTextBox.ReadOnly = True
        Me.EstadoAnimoTextBox.Size = New System.Drawing.Size(428, 78)
        Me.EstadoAnimoTextBox.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(564, 262)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(558, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 32)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Busqueda por matrícula:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(610, 261)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(528, 41)
        Me.TxtBuscar.TabIndex = 48
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(621, 134)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(200, 75)
        Me.BtnCancelar.TabIndex = 47
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
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(213, 134)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(200, 75)
        Me.BtnEliminar.TabIndex = 46
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
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(417, 134)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(200, 75)
        Me.BtnGuardar.TabIndex = 45
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
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.notas45p
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(9, 134)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(200, 75)
        Me.BtnModificar.TabIndex = 44
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
        Me.BtnClose.TabIndex = 52
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'HistorialpacienteTableAdapter
        '
        Me.HistorialpacienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.historialpacienteTableAdapter = Me.HistorialpacienteTableAdapter
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.temperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
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
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataMember = "bitacora"
        Me.BitacoraBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'BitacoraTableAdapter
        '
        Me.BitacoraTableAdapter.ClearBeforeFill = True
        '
        'antecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1291, 808)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(NumeroHistorialLabel)
        Me.Controls.Add(Me.NumeroHistorialTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(UsoMedicamentosLabel)
        Me.Controls.Add(Me.UsoMedicamentosComboBox)
        Me.Controls.Add(MedicamentosLabel)
        Me.Controls.Add(Me.MedicamentosTextBox)
        Me.Controls.Add(EstadoAnimoLabel)
        Me.Controls.Add(Me.EstadoAnimoTextBox)
        Me.Controls.Add(Me.HistorialpacienteDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "antecedentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "antecedentes"
        CType(Me.HistorialpacienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialpacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents HistorialpacienteBindingSource As BindingSource
    Friend WithEvents HistorialpacienteTableAdapter As psicologiadbDataSetTableAdapters.historialpacienteTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistorialpacienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents UsoMedicamentos As DataGridViewTextBoxColumn
    Friend WithEvents NumeroHistorialTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents UsoMedicamentosComboBox As ComboBox
    Friend WithEvents MedicamentosTextBox As TextBox
    Friend WithEvents EstadoAnimoTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As psicologiadbDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents BitacoraBindingSource As BindingSource
    Friend WithEvents BitacoraTableAdapter As psicologiadbDataSetTableAdapters.bitacoraTableAdapter
End Class
