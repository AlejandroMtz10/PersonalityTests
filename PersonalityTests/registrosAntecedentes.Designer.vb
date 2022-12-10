<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrosAntecedentes
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
        Dim UsoMedicamentosLabel As System.Windows.Forms.Label
        Dim AntecedentesLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Me.HistorialPacienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorialPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.NumeroHistorialTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.UsoMedicamentosComboBox = New System.Windows.Forms.ComboBox()
        Me.AntecedentesTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.HistorialPacienteTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        NumeroHistorialLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        UsoMedicamentosLabel = New System.Windows.Forms.Label()
        AntecedentesLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.HistorialPacienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroHistorialLabel
        '
        NumeroHistorialLabel.AutoSize = True
        NumeroHistorialLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroHistorialLabel.Location = New System.Drawing.Point(587, 172)
        NumeroHistorialLabel.Name = "NumeroHistorialLabel"
        NumeroHistorialLabel.Size = New System.Drawing.Size(299, 36)
        NumeroHistorialLabel.TabIndex = 1
        NumeroHistorialLabel.Text = "Numero de historial:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(587, 228)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(164, 36)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'UsoMedicamentosLabel
        '
        UsoMedicamentosLabel.AutoSize = True
        UsoMedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsoMedicamentosLabel.Location = New System.Drawing.Point(587, 468)
        UsoMedicamentosLabel.Name = "UsoMedicamentosLabel"
        UsoMedicamentosLabel.Size = New System.Drawing.Size(285, 36)
        UsoMedicamentosLabel.TabIndex = 5
        UsoMedicamentosLabel.Text = "Uso Medicamentos:"
        '
        'AntecedentesLabel
        '
        AntecedentesLabel.AutoSize = True
        AntecedentesLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AntecedentesLabel.Location = New System.Drawing.Point(587, 529)
        AntecedentesLabel.Name = "AntecedentesLabel"
        AntecedentesLabel.Size = New System.Drawing.Size(207, 36)
        AntecedentesLabel.TabIndex = 7
        AntecedentesLabel.Text = "Antecedentes:"
        '
        'HistorialPacienteDataGridView
        '
        Me.HistorialPacienteDataGridView.AllowUserToAddRows = False
        Me.HistorialPacienteDataGridView.AllowUserToDeleteRows = False
        Me.HistorialPacienteDataGridView.AutoGenerateColumns = False
        Me.HistorialPacienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.HistorialPacienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HistorialPacienteDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.HistorialPacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialPacienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.HistorialPacienteDataGridView.DataSource = Me.HistorialPacienteBindingSource
        Me.HistorialPacienteDataGridView.Location = New System.Drawing.Point(12, 123)
        Me.HistorialPacienteDataGridView.Name = "HistorialPacienteDataGridView"
        Me.HistorialPacienteDataGridView.ReadOnly = True
        Me.HistorialPacienteDataGridView.Size = New System.Drawing.Size(554, 765)
        Me.HistorialPacienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroHistorial"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UsoMedicamentos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Uso de medicamentos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 163
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
        'NumeroHistorialTextBox
        '
        Me.NumeroHistorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "NumeroHistorial", True))
        Me.NumeroHistorialTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroHistorialTextBox.Location = New System.Drawing.Point(902, 164)
        Me.NumeroHistorialTextBox.Name = "NumeroHistorialTextBox"
        Me.NumeroHistorialTextBox.ReadOnly = True
        Me.NumeroHistorialTextBox.Size = New System.Drawing.Size(223, 44)
        Me.NumeroHistorialTextBox.TabIndex = 2
        Me.NumeroHistorialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(593, 284)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(532, 44)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsoMedicamentosComboBox
        '
        Me.UsoMedicamentosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "UsoMedicamentos", True))
        Me.UsoMedicamentosComboBox.Enabled = False
        Me.UsoMedicamentosComboBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoMedicamentosComboBox.FormattingEnabled = True
        Me.UsoMedicamentosComboBox.Location = New System.Drawing.Point(902, 460)
        Me.UsoMedicamentosComboBox.Name = "UsoMedicamentosComboBox"
        Me.UsoMedicamentosComboBox.Size = New System.Drawing.Size(223, 44)
        Me.UsoMedicamentosComboBox.TabIndex = 6
        '
        'AntecedentesTextBox
        '
        Me.AntecedentesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "Antecedentes", True))
        Me.AntecedentesTextBox.Enabled = False
        Me.AntecedentesTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AntecedentesTextBox.Location = New System.Drawing.Point(593, 583)
        Me.AntecedentesTextBox.Multiline = True
        Me.AntecedentesTextBox.Name = "AntecedentesTextBox"
        Me.AntecedentesTextBox.Size = New System.Drawing.Size(895, 305)
        Me.AntecedentesTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Buscar
        Me.PictureBox1.Location = New System.Drawing.Point(593, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Times New Roman", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(644, 112)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(481, 40)
        Me.TxtBuscar.TabIndex = 45
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1238, 271)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 52
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(1238, 164)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 51
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.PersonalityTests.My.Resources.Resources.Modificar
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(1238, 378)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(250, 75)
        Me.BtnModificar.TabIndex = 50
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.PersonalityTests.My.Resources.Resources.Eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(1238, 485)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(250, 75)
        Me.BtnEliminar.TabIndex = 49
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 55)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Antecedentes del paciente."
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
        Me.BtnSalir.TabIndex = 54
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'HistorialPacienteTableAdapter
        '
        Me.HistorialPacienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Me.HistorialPacienteTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        FechaLabel.Location = New System.Drawing.Point(587, 343)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(108, 36)
        FechaLabel.TabIndex = 54
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HistorialPacienteBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(593, 388)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(532, 44)
        Me.FechaDateTimePicker.TabIndex = 55
        '
        'registrosAntecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1508, 908)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(NumeroHistorialLabel)
        Me.Controls.Add(Me.NumeroHistorialTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(UsoMedicamentosLabel)
        Me.Controls.Add(Me.UsoMedicamentosComboBox)
        Me.Controls.Add(AntecedentesLabel)
        Me.Controls.Add(Me.AntecedentesTextBox)
        Me.Controls.Add(Me.HistorialPacienteDataGridView)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registrosAntecedentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrosAntecedentes"
        CType(Me.HistorialPacienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents HistorialPacienteBindingSource As BindingSource
    Friend WithEvents HistorialPacienteTableAdapter As PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistorialPacienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroHistorialTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents UsoMedicamentosComboBox As ComboBox
    Friend WithEvents AntecedentesTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
End Class
