<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultadosTemperamentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NumeroRegistroLabel As System.Windows.Forms.Label
        Dim SanguineoLabel As System.Windows.Forms.Label
        Dim MelancolicoLabel As System.Windows.Forms.Label
        Dim ColericoLabel As System.Windows.Forms.Label
        Dim FlematicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Resultados = New System.Windows.Forms.Button()
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.TemperamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TemperamentosTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.SanguineoTextBox = New System.Windows.Forms.TextBox()
        Me.MelancolicoTextBox = New System.Windows.Forms.TextBox()
        Me.ColericoTextBox = New System.Windows.Forms.TextBox()
        Me.FlematicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        SanguineoLabel = New System.Windows.Forms.Label()
        MelancolicoLabel = New System.Windows.Forms.Label()
        ColericoLabel = New System.Windows.Forms.Label()
        FlematicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.BackColor = System.Drawing.Color.Transparent
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(99, 137)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(285, 40)
        NumeroRegistroLabel.TabIndex = 16
        NumeroRegistroLabel.Text = "Numero Registro:"
        '
        'SanguineoLabel
        '
        SanguineoLabel.AutoSize = True
        SanguineoLabel.BackColor = System.Drawing.Color.Transparent
        SanguineoLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SanguineoLabel.Location = New System.Drawing.Point(99, 319)
        SanguineoLabel.Name = "SanguineoLabel"
        SanguineoLabel.Size = New System.Drawing.Size(184, 40)
        SanguineoLabel.TabIndex = 18
        SanguineoLabel.Text = "Sanguineo:"
        '
        'MelancolicoLabel
        '
        MelancolicoLabel.AutoSize = True
        MelancolicoLabel.BackColor = System.Drawing.Color.Transparent
        MelancolicoLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MelancolicoLabel.Location = New System.Drawing.Point(588, 319)
        MelancolicoLabel.Name = "MelancolicoLabel"
        MelancolicoLabel.Size = New System.Drawing.Size(211, 40)
        MelancolicoLabel.TabIndex = 20
        MelancolicoLabel.Text = "Melancolico:"
        '
        'ColericoLabel
        '
        ColericoLabel.AutoSize = True
        ColericoLabel.BackColor = System.Drawing.Color.Transparent
        ColericoLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColericoLabel.Location = New System.Drawing.Point(99, 392)
        ColericoLabel.Name = "ColericoLabel"
        ColericoLabel.Size = New System.Drawing.Size(156, 40)
        ColericoLabel.TabIndex = 22
        ColericoLabel.Text = "Colerico:"
        '
        'FlematicoLabel
        '
        FlematicoLabel.AutoSize = True
        FlematicoLabel.BackColor = System.Drawing.Color.Transparent
        FlematicoLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FlematicoLabel.Location = New System.Drawing.Point(588, 392)
        FlematicoLabel.Name = "FlematicoLabel"
        FlematicoLabel.Size = New System.Drawing.Size(176, 40)
        FlematicoLabel.TabIndex = 24
        FlematicoLabel.Text = "Flematico:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(99, 490)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(206, 40)
        DescripcionLabel.TabIndex = 26
        DescripcionLabel.Text = "Descripcion:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(99, 213)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(180, 40)
        MatriculaLabel.TabIndex = 28
        MatriculaLabel.Text = "Matricula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(458, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resultados."
        '
        'Resultados
        '
        Me.Resultados.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Resultados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Resultados.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultados.Image = Global.PersonalityTests.My.Resources.Resources.Resultados
        Me.Resultados.Location = New System.Drawing.Point(837, 205)
        Me.Resultados.Margin = New System.Windows.Forms.Padding(2)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(250, 75)
        Me.Resultados.TabIndex = 15
        Me.Resultados.Text = "Resultados"
        Me.Resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Resultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Resultados.UseVisualStyleBackColor = False
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TemperamentosBindingSource
        '
        Me.TemperamentosBindingSource.DataMember = "Temperamentos"
        Me.TemperamentosBindingSource.DataSource = Me.PsicologiaDBDataSet
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
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(435, 129)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.ReadOnly = True
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(143, 48)
        Me.NumeroRegistroTextBox.TabIndex = 17
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SanguineoTextBox
        '
        Me.SanguineoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Sanguineo", True))
        Me.SanguineoTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanguineoTextBox.Location = New System.Drawing.Point(319, 311)
        Me.SanguineoTextBox.Name = "SanguineoTextBox"
        Me.SanguineoTextBox.ReadOnly = True
        Me.SanguineoTextBox.Size = New System.Drawing.Size(230, 48)
        Me.SanguineoTextBox.TabIndex = 19
        Me.SanguineoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MelancolicoTextBox
        '
        Me.MelancolicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Melancolico", True))
        Me.MelancolicoTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MelancolicoTextBox.Location = New System.Drawing.Point(857, 311)
        Me.MelancolicoTextBox.Name = "MelancolicoTextBox"
        Me.MelancolicoTextBox.ReadOnly = True
        Me.MelancolicoTextBox.Size = New System.Drawing.Size(230, 48)
        Me.MelancolicoTextBox.TabIndex = 21
        Me.MelancolicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColericoTextBox
        '
        Me.ColericoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Colerico", True))
        Me.ColericoTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColericoTextBox.Location = New System.Drawing.Point(319, 384)
        Me.ColericoTextBox.Name = "ColericoTextBox"
        Me.ColericoTextBox.ReadOnly = True
        Me.ColericoTextBox.Size = New System.Drawing.Size(230, 48)
        Me.ColericoTextBox.TabIndex = 23
        Me.ColericoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlematicoTextBox
        '
        Me.FlematicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Flematico", True))
        Me.FlematicoTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlematicoTextBox.Location = New System.Drawing.Point(857, 392)
        Me.FlematicoTextBox.Name = "FlematicoTextBox"
        Me.FlematicoTextBox.ReadOnly = True
        Me.FlematicoTextBox.Size = New System.Drawing.Size(230, 48)
        Me.FlematicoTextBox.TabIndex = 25
        Me.FlematicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(347, 487)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(740, 144)
        Me.DescripcionTextBox.TabIndex = 27
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(304, 205)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(452, 48)
        Me.MatriculaTextBox.TabIndex = 29
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.Location = New System.Drawing.Point(293, 671)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 31
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Constantia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.Location = New System.Drawing.Point(664, 671)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 30
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'ResultadosTemperamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.multicolor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1206, 775)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
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
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResultadosTemperamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResultadosTemperamentos"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Resultados As Button
    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents TemperamentosBindingSource As BindingSource
    Friend WithEvents TemperamentosTableAdapter As PsicologiaDBDataSetTableAdapters.TemperamentosTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents SanguineoTextBox As TextBox
    Friend WithEvents MelancolicoTextBox As TextBox
    Friend WithEvents ColericoTextBox As TextBox
    Friend WithEvents FlematicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
End Class
