<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historialPaciente
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim MedicamentosLabel As System.Windows.Forms.Label
        Dim EstadoAnimoLabel As System.Windows.Forms.Label
        Dim UsoMedicamentosLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.HistorialpacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistorialpacienteTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.historialpacienteTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MedicamentosTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoAnimoTextBox = New System.Windows.Forms.TextBox()
        Me.UsoMedicamentosComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        MatriculaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        MedicamentosLabel = New System.Windows.Forms.Label()
        EstadoAnimoLabel = New System.Windows.Forms.Label()
        UsoMedicamentosLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialpacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(100, 174)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(140, 31)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matrícula:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(643, 174)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(93, 31)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'MedicamentosLabel
        '
        MedicamentosLabel.AutoSize = True
        MedicamentosLabel.BackColor = System.Drawing.Color.Transparent
        MedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicamentosLabel.Location = New System.Drawing.Point(29, 331)
        MedicamentosLabel.Name = "MedicamentosLabel"
        MedicamentosLabel.Size = New System.Drawing.Size(192, 31)
        MedicamentosLabel.TabIndex = 9
        MedicamentosLabel.Text = "Medicamentos:"
        '
        'EstadoAnimoLabel
        '
        EstadoAnimoLabel.AutoSize = True
        EstadoAnimoLabel.BackColor = System.Drawing.Color.Transparent
        EstadoAnimoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoAnimoLabel.Location = New System.Drawing.Point(560, 331)
        EstadoAnimoLabel.Name = "EstadoAnimoLabel"
        EstadoAnimoLabel.Size = New System.Drawing.Size(188, 31)
        EstadoAnimoLabel.TabIndex = 11
        EstadoAnimoLabel.Text = "Estado Animo:"
        '
        'UsoMedicamentosLabel
        '
        UsoMedicamentosLabel.AutoSize = True
        UsoMedicamentosLabel.BackColor = System.Drawing.Color.Transparent
        UsoMedicamentosLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsoMedicamentosLabel.Location = New System.Drawing.Point(100, 256)
        UsoMedicamentosLabel.Name = "UsoMedicamentosLabel"
        UsoMedicamentosLabel.Size = New System.Drawing.Size(244, 31)
        UsoMedicamentosLabel.TabIndex = 12
        UsoMedicamentosLabel.Text = "Uso Medicamentos:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(487, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(306, 55)
        Label1.TabIndex = 14
        Label1.Text = "Antecedentes."
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistorialpacienteBindingSource
        '
        Me.HistorialpacienteBindingSource.DataMember = "historialpaciente"
        Me.HistorialpacienteBindingSource.DataSource = Me.PsicologiadbDataSet
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
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(259, 166)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(308, 39)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HistorialpacienteBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(636, 245)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(453, 39)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'MedicamentosTextBox
        '
        Me.MedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicamentosTextBox.Location = New System.Drawing.Point(24, 378)
        Me.MedicamentosTextBox.Multiline = True
        Me.MedicamentosTextBox.Name = "MedicamentosTextBox"
        Me.MedicamentosTextBox.Size = New System.Drawing.Size(482, 391)
        Me.MedicamentosTextBox.TabIndex = 10
        '
        'EstadoAnimoTextBox
        '
        Me.EstadoAnimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "EstadoAnimo", True))
        Me.EstadoAnimoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoAnimoTextBox.Location = New System.Drawing.Point(566, 378)
        Me.EstadoAnimoTextBox.Multiline = True
        Me.EstadoAnimoTextBox.Name = "EstadoAnimoTextBox"
        Me.EstadoAnimoTextBox.Size = New System.Drawing.Size(394, 391)
        Me.EstadoAnimoTextBox.TabIndex = 12
        '
        'UsoMedicamentosComboBox
        '
        Me.UsoMedicamentosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HistorialpacienteBindingSource, "UsoMedicamentos", True))
        Me.UsoMedicamentosComboBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoMedicamentosComboBox.FormattingEnabled = True
        Me.UsoMedicamentosComboBox.Items.AddRange(New Object() {"Si", "No"})
        Me.UsoMedicamentosComboBox.Location = New System.Drawing.Point(361, 248)
        Me.UsoMedicamentosComboBox.Name = "UsoMedicamentosComboBox"
        Me.UsoMedicamentosComboBox.Size = New System.Drawing.Size(197, 39)
        Me.UsoMedicamentosComboBox.TabIndex = 13
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
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(1006, 357)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 38
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1006, 469)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 37
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'historialPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.azul4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Label1)
        Me.Controls.Add(UsoMedicamentosLabel)
        Me.Controls.Add(Me.UsoMedicamentosComboBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(MedicamentosLabel)
        Me.Controls.Add(Me.MedicamentosTextBox)
        Me.Controls.Add(EstadoAnimoLabel)
        Me.Controls.Add(Me.EstadoAnimoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "historialPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "historialPaciente"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialpacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents HistorialpacienteBindingSource As BindingSource
    Friend WithEvents HistorialpacienteTableAdapter As psicologiadbDataSetTableAdapters.historialpacienteTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents MedicamentosTextBox As TextBox
    Friend WithEvents EstadoAnimoTextBox As TextBox
    Friend WithEvents UsoMedicamentosComboBox As ComboBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
End Class
