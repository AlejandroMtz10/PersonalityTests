<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultadosAlimentacion
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
        Dim RayasicoLabel As System.Windows.Forms.Label
        Dim TamasicoLabel As System.Windows.Forms.Label
        Dim SatvicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultadosAlimentacion))
        Dim Label1 As System.Windows.Forms.Label
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.AlimentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlimentacionTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.alimentacionTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.RayasicoTextBox = New System.Windows.Forms.TextBox()
        Me.TamasicoTextBox = New System.Windows.Forms.TextBox()
        Me.SatvicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnResultados = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        MatriculaLabel = New System.Windows.Forms.Label()
        RayasicoLabel = New System.Windows.Forms.Label()
        TamasicoLabel = New System.Windows.Forms.Label()
        SatvicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.BackColor = System.Drawing.Color.Transparent
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(56, 160)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(164, 36)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'RayasicoLabel
        '
        RayasicoLabel.AutoSize = True
        RayasicoLabel.BackColor = System.Drawing.Color.Transparent
        RayasicoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RayasicoLabel.Location = New System.Drawing.Point(56, 259)
        RayasicoLabel.Name = "RayasicoLabel"
        RayasicoLabel.Size = New System.Drawing.Size(147, 36)
        RayasicoLabel.TabIndex = 5
        RayasicoLabel.Text = "Rayasico:"
        '
        'TamasicoLabel
        '
        TamasicoLabel.AutoSize = True
        TamasicoLabel.BackColor = System.Drawing.Color.Transparent
        TamasicoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TamasicoLabel.Location = New System.Drawing.Point(56, 334)
        TamasicoLabel.Name = "TamasicoLabel"
        TamasicoLabel.Size = New System.Drawing.Size(154, 36)
        TamasicoLabel.TabIndex = 7
        TamasicoLabel.Text = "Tamasico:"
        '
        'SatvicoLabel
        '
        SatvicoLabel.AutoSize = True
        SatvicoLabel.BackColor = System.Drawing.Color.Transparent
        SatvicoLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SatvicoLabel.Location = New System.Drawing.Point(56, 418)
        SatvicoLabel.Name = "SatvicoLabel"
        SatvicoLabel.Size = New System.Drawing.Size(126, 36)
        SatvicoLabel.TabIndex = 9
        SatvicoLabel.Text = "Satvico:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(571, 254)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(187, 36)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripcion:"
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
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.BackColor = System.Drawing.Color.White
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(235, 152)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(274, 44)
        Me.MatriculaTextBox.TabIndex = 4
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RayasicoTextBox
        '
        Me.RayasicoTextBox.BackColor = System.Drawing.Color.White
        Me.RayasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Rayasico", True))
        Me.RayasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RayasicoTextBox.Location = New System.Drawing.Point(235, 251)
        Me.RayasicoTextBox.Name = "RayasicoTextBox"
        Me.RayasicoTextBox.ReadOnly = True
        Me.RayasicoTextBox.Size = New System.Drawing.Size(200, 44)
        Me.RayasicoTextBox.TabIndex = 6
        Me.RayasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TamasicoTextBox
        '
        Me.TamasicoTextBox.BackColor = System.Drawing.Color.White
        Me.TamasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Tamasico", True))
        Me.TamasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TamasicoTextBox.Location = New System.Drawing.Point(235, 326)
        Me.TamasicoTextBox.Name = "TamasicoTextBox"
        Me.TamasicoTextBox.ReadOnly = True
        Me.TamasicoTextBox.Size = New System.Drawing.Size(200, 44)
        Me.TamasicoTextBox.TabIndex = 8
        Me.TamasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SatvicoTextBox
        '
        Me.SatvicoTextBox.BackColor = System.Drawing.Color.White
        Me.SatvicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Satvico", True))
        Me.SatvicoTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SatvicoTextBox.Location = New System.Drawing.Point(235, 410)
        Me.SatvicoTextBox.Name = "SatvicoTextBox"
        Me.SatvicoTextBox.ReadOnly = True
        Me.SatvicoTextBox.Size = New System.Drawing.Size(200, 44)
        Me.SatvicoTextBox.TabIndex = 10
        Me.SatvicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.Color.White
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(577, 304)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.ReadOnly = True
        Me.DescripcionTextBox.Size = New System.Drawing.Size(669, 331)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(240, 694)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnResultados
        '
        Me.BtnResultados.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResultados.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResultados.Image = Global.PersonalityTests.My.Resources.Resources.Resultados
        Me.BtnResultados.Location = New System.Drawing.Point(761, 142)
        Me.BtnResultados.Name = "BtnResultados"
        Me.BtnResultados.Size = New System.Drawing.Size(250, 75)
        Me.BtnResultados.TabIndex = 14
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
        Me.BtnGuardar.Location = New System.Drawing.Point(791, 694)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 15
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(467, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(347, 73)
        Label1.TabIndex = 16
        Label1.Text = "Resultados."
        '
        'ResultadosAlimentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.azul2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnResultados)
        Me.Controls.Add(Me.BtnCancelar)
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
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResultadosAlimentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResultadosAlimentacion"
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents AlimentacionBindingSource As BindingSource
    Friend WithEvents AlimentacionTableAdapter As psicologiadbDataSetTableAdapters.alimentacionTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents RayasicoTextBox As TextBox
    Friend WithEvents TamasicoTextBox As TextBox
    Friend WithEvents SatvicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnResultados As Button
    Friend WithEvents BtnGuardar As Button
End Class
