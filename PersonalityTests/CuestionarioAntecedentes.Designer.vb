<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuestionarioAntecedentes
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
        Dim AntecedentesLabel As System.Windows.Forms.Label
        Dim UsoMedicamentosLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.HistorialPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorialPacienteTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.NumeroHistorialTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.AntecedentesTextBox = New System.Windows.Forms.TextBox()
        Me.UsoMedicamentosComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnInformacion = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        NumeroHistorialLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        AntecedentesLabel = New System.Windows.Forms.Label()
        UsoMedicamentosLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroHistorialLabel
        '
        NumeroHistorialLabel.AutoSize = True
        NumeroHistorialLabel.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroHistorialLabel.ForeColor = System.Drawing.Color.White
        NumeroHistorialLabel.Location = New System.Drawing.Point(31, 114)
        NumeroHistorialLabel.Name = "NumeroHistorialLabel"
        NumeroHistorialLabel.Size = New System.Drawing.Size(330, 42)
        NumeroHistorialLabel.TabIndex = 1
        NumeroHistorialLabel.Text = "Numero de registro:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.ForeColor = System.Drawing.Color.White
        MatriculaLabel.Location = New System.Drawing.Point(584, 114)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(189, 42)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'AntecedentesLabel
        '
        AntecedentesLabel.AutoSize = True
        AntecedentesLabel.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AntecedentesLabel.ForeColor = System.Drawing.Color.White
        AntecedentesLabel.Location = New System.Drawing.Point(149, 338)
        AntecedentesLabel.Name = "AntecedentesLabel"
        AntecedentesLabel.Size = New System.Drawing.Size(238, 42)
        AntecedentesLabel.TabIndex = 7
        AntecedentesLabel.Text = "Antecedentes:"
        '
        'UsoMedicamentosLabel
        '
        UsoMedicamentosLabel.AutoSize = True
        UsoMedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsoMedicamentosLabel.ForeColor = System.Drawing.Color.White
        UsoMedicamentosLabel.Location = New System.Drawing.Point(29, 263)
        UsoMedicamentosLabel.Name = "UsoMedicamentosLabel"
        UsoMedicamentosLabel.Size = New System.Drawing.Size(365, 42)
        UsoMedicamentosLabel.TabIndex = 8
        UsoMedicamentosLabel.Text = "Uso de medicamentos:"
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistorialPacienteBindingSource
        '
        Me.HistorialPacienteBindingSource.DataMember = "HistorialPaciente"
        Me.HistorialPacienteBindingSource.DataSource = Me.PsicologiaDBDataSet
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
        'NumeroHistorialTextBox
        '
        Me.NumeroHistorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "NumeroHistorial", True))
        Me.NumeroHistorialTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroHistorialTextBox.Location = New System.Drawing.Point(398, 111)
        Me.NumeroHistorialTextBox.Name = "NumeroHistorialTextBox"
        Me.NumeroHistorialTextBox.ReadOnly = True
        Me.NumeroHistorialTextBox.Size = New System.Drawing.Size(139, 44)
        Me.NumeroHistorialTextBox.TabIndex = 2
        Me.NumeroHistorialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(799, 111)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(403, 44)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AntecedentesTextBox
        '
        Me.AntecedentesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "Antecedentes", True))
        Me.AntecedentesTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AntecedentesTextBox.Location = New System.Drawing.Point(74, 394)
        Me.AntecedentesTextBox.Multiline = True
        Me.AntecedentesTextBox.Name = "AntecedentesTextBox"
        Me.AntecedentesTextBox.Size = New System.Drawing.Size(1128, 361)
        Me.AntecedentesTextBox.TabIndex = 8
        '
        'UsoMedicamentosComboBox
        '
        Me.UsoMedicamentosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialPacienteBindingSource, "UsoMedicamentos", True))
        Me.UsoMedicamentosComboBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoMedicamentosComboBox.FormattingEnabled = True
        Me.UsoMedicamentosComboBox.Items.AddRange(New Object() {"Si", "No"})
        Me.UsoMedicamentosComboBox.Location = New System.Drawing.Point(412, 261)
        Me.UsoMedicamentosComboBox.Name = "UsoMedicamentosComboBox"
        Me.UsoMedicamentosComboBox.Size = New System.Drawing.Size(182, 44)
        Me.UsoMedicamentosComboBox.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.Location = New System.Drawing.Point(796, 191)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 33
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.Location = New System.Drawing.Point(796, 288)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 32
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnInformacion
        '
        Me.BtnInformacion.FlatAppearance.BorderSize = 0
        Me.BtnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformacion.Image = Global.PersonalityTests.My.Resources.Resources.Acerca_de
        Me.BtnInformacion.Location = New System.Drawing.Point(74, 335)
        Me.BtnInformacion.Name = "BtnInformacion"
        Me.BtnInformacion.Size = New System.Drawing.Size(45, 45)
        Me.BtnInformacion.TabIndex = 10
        Me.BtnInformacion.UseVisualStyleBackColor = True
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold)
        FechaLabel.ForeColor = System.Drawing.Color.White
        FechaLabel.Location = New System.Drawing.Point(31, 187)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(125, 42)
        FechaLabel.TabIndex = 33
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HistorialPacienteBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold)
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(187, 181)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(572, 50)
        Me.FechaDateTimePicker.TabIndex = 34
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(431, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(409, 73)
        Label1.TabIndex = 35
        Label1.Text = "Antecedentes."
        Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CuestionarioAntecedentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1270, 775)
        Me.Controls.Add(Label1)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnInformacion)
        Me.Controls.Add(UsoMedicamentosLabel)
        Me.Controls.Add(Me.UsoMedicamentosComboBox)
        Me.Controls.Add(NumeroHistorialLabel)
        Me.Controls.Add(Me.NumeroHistorialTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(AntecedentesLabel)
        Me.Controls.Add(Me.AntecedentesTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CuestionarioAntecedentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuestionarioAntecedentes"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents HistorialPacienteBindingSource As BindingSource
    Friend WithEvents HistorialPacienteTableAdapter As PsicologiaDBDataSetTableAdapters.HistorialPacienteTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumeroHistorialTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents AntecedentesTextBox As TextBox
    Friend WithEvents UsoMedicamentosComboBox As ComboBox
    Friend WithEvents BtnInformacion As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents FechaDateTimePicker As DateTimePicker
End Class
