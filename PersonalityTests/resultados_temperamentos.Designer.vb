<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resultados_temperamentos
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
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim SanguineoLabel As System.Windows.Forms.Label
        Dim MelancolicoLabel As System.Windows.Forms.Label
        Dim ColericoLabel As System.Windows.Forms.Label
        Dim FlematicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resultados_temperamentos))
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.TemperamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TemperamentosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.temperamentosTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.SanguineoTextBox = New System.Windows.Forms.TextBox()
        Me.MelancolicoTextBox = New System.Windows.Forms.TextBox()
        Me.ColericoTextBox = New System.Windows.Forms.TextBox()
        Me.FlematicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.BtnResultados = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        MatriculaLabel = New System.Windows.Forms.Label()
        SanguineoLabel = New System.Windows.Forms.Label()
        MelancolicoLabel = New System.Windows.Forms.Label()
        ColericoLabel = New System.Windows.Forms.Label()
        FlematicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(40, 114)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(164, 36)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matrícula:"
        '
        'SanguineoLabel
        '
        SanguineoLabel.AutoSize = True
        SanguineoLabel.BackColor = System.Drawing.Color.Transparent
        SanguineoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SanguineoLabel.Location = New System.Drawing.Point(203, 204)
        SanguineoLabel.Name = "SanguineoLabel"
        SanguineoLabel.Size = New System.Drawing.Size(169, 36)
        SanguineoLabel.TabIndex = 5
        SanguineoLabel.Text = "Sanguíneo:"
        '
        'MelancolicoLabel
        '
        MelancolicoLabel.AutoSize = True
        MelancolicoLabel.BackColor = System.Drawing.Color.Transparent
        MelancolicoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MelancolicoLabel.Location = New System.Drawing.Point(180, 282)
        MelancolicoLabel.Name = "MelancolicoLabel"
        MelancolicoLabel.Size = New System.Drawing.Size(192, 36)
        MelancolicoLabel.TabIndex = 7
        MelancolicoLabel.Text = "Melancólico:"
        '
        'ColericoLabel
        '
        ColericoLabel.AutoSize = True
        ColericoLabel.BackColor = System.Drawing.Color.Transparent
        ColericoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColericoLabel.Location = New System.Drawing.Point(733, 204)
        ColericoLabel.Name = "ColericoLabel"
        ColericoLabel.Size = New System.Drawing.Size(141, 36)
        ColericoLabel.TabIndex = 9
        ColericoLabel.Text = "Colérico:"
        '
        'FlematicoLabel
        '
        FlematicoLabel.AutoSize = True
        FlematicoLabel.BackColor = System.Drawing.Color.Transparent
        FlematicoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FlematicoLabel.Location = New System.Drawing.Point(712, 282)
        FlematicoLabel.Name = "FlematicoLabel"
        FlematicoLabel.Size = New System.Drawing.Size(162, 36)
        FlematicoLabel.TabIndex = 11
        FlematicoLabel.Text = "Flemático:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(40, 343)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(187, 36)
        DescripcionLabel.TabIndex = 13
        DescripcionLabel.Text = "Descripción:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(510, 23)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(260, 55)
        Label1.TabIndex = 15
        Label1.Text = "Resultados."
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TemperamentosBindingSource
        '
        Me.TemperamentosBindingSource.DataMember = "temperamentos"
        Me.TemperamentosBindingSource.DataSource = Me.PsicologiadbDataSet
        '
        'TemperamentosTableAdapter
        '
        Me.TemperamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bitacoraTableAdapter = Nothing
        Me.TableAdapterManager.historialpacienteTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.temperamentosTableAdapter = Me.TemperamentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(252, 111)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(369, 44)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SanguineoTextBox
        '
        Me.SanguineoTextBox.BackColor = System.Drawing.Color.White
        Me.SanguineoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Sanguineo", True))
        Me.SanguineoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanguineoTextBox.Location = New System.Drawing.Point(410, 196)
        Me.SanguineoTextBox.Name = "SanguineoTextBox"
        Me.SanguineoTextBox.ReadOnly = True
        Me.SanguineoTextBox.Size = New System.Drawing.Size(188, 44)
        Me.SanguineoTextBox.TabIndex = 6
        Me.SanguineoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MelancolicoTextBox
        '
        Me.MelancolicoTextBox.BackColor = System.Drawing.Color.White
        Me.MelancolicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Melancolico", True))
        Me.MelancolicoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MelancolicoTextBox.Location = New System.Drawing.Point(410, 274)
        Me.MelancolicoTextBox.Name = "MelancolicoTextBox"
        Me.MelancolicoTextBox.ReadOnly = True
        Me.MelancolicoTextBox.Size = New System.Drawing.Size(188, 44)
        Me.MelancolicoTextBox.TabIndex = 8
        Me.MelancolicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColericoTextBox
        '
        Me.ColericoTextBox.BackColor = System.Drawing.Color.White
        Me.ColericoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Colerico", True))
        Me.ColericoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColericoTextBox.Location = New System.Drawing.Point(912, 196)
        Me.ColericoTextBox.Name = "ColericoTextBox"
        Me.ColericoTextBox.ReadOnly = True
        Me.ColericoTextBox.Size = New System.Drawing.Size(188, 44)
        Me.ColericoTextBox.TabIndex = 10
        Me.ColericoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlematicoTextBox
        '
        Me.FlematicoTextBox.BackColor = System.Drawing.Color.White
        Me.FlematicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Flematico", True))
        Me.FlematicoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlematicoTextBox.Location = New System.Drawing.Point(912, 274)
        Me.FlematicoTextBox.Name = "FlematicoTextBox"
        Me.FlematicoTextBox.ReadOnly = True
        Me.FlematicoTextBox.Size = New System.Drawing.Size(188, 44)
        Me.FlematicoTextBox.TabIndex = 12
        Me.FlematicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TemperamentosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(46, 392)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(828, 309)
        Me.DescripcionTextBox.TabIndex = 14
        '
        'BtnResultados
        '
        Me.BtnResultados.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResultados.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResultados.Image = Global.PersonalityTests.My.Resources.Resources.Resultados
        Me.BtnResultados.Location = New System.Drawing.Point(781, 95)
        Me.BtnResultados.Name = "BtnResultados"
        Me.BtnResultados.Size = New System.Drawing.Size(250, 75)
        Me.BtnResultados.TabIndex = 16
        Me.BtnResultados.Text = "Resultados"
        Me.BtnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnResultados.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(974, 575)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(974, 449)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 17
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'resultados_temperamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.azul4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnResultados)
        Me.Controls.Add(Label1)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resultados_temperamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "resultados_temperamentos"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TemperamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents TemperamentosBindingSource As BindingSource
    Friend WithEvents TemperamentosTableAdapter As psicologiadbDataSetTableAdapters.temperamentosTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents SanguineoTextBox As TextBox
    Friend WithEvents MelancolicoTextBox As TextBox
    Friend WithEvents ColericoTextBox As TextBox
    Friend WithEvents FlematicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents BtnResultados As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
End Class
