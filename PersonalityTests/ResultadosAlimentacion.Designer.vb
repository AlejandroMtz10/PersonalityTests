<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultadosAlimentacion
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
        Dim Label1 As System.Windows.Forms.Label
        Dim NumeroRegistroLabel As System.Windows.Forms.Label
        Dim RayasicoLabel As System.Windows.Forms.Label
        Dim TamasicoLabel As System.Windows.Forms.Label
        Dim SatvicoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Me.Resultados = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.AlimentacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlimentacionTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.AlimentacionTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.NumeroRegistroTextBox = New System.Windows.Forms.TextBox()
        Me.RayasicoTextBox = New System.Windows.Forms.TextBox()
        Me.TamasicoTextBox = New System.Windows.Forms.TextBox()
        Me.SatvicoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        NumeroRegistroLabel = New System.Windows.Forms.Label()
        RayasicoLabel = New System.Windows.Forms.Label()
        TamasicoLabel = New System.Windows.Forms.Label()
        SatvicoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(444, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(409, 42)
        Label1.TabIndex = 13
        Label1.Text = "Resultados alimentación."
        '
        'Resultados
        '
        Me.Resultados.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Resultados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Resultados.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultados.Image = Global.PersonalityTests.My.Resources.Resources.Resultados
        Me.Resultados.Location = New System.Drawing.Point(803, 163)
        Me.Resultados.Margin = New System.Windows.Forms.Padding(2)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Resultados.Size = New System.Drawing.Size(250, 75)
        Me.Resultados.TabIndex = 16
        Me.Resultados.Text = "Resultados"
        Me.Resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Resultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Resultados.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.Location = New System.Drawing.Point(53, 612)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 75)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Violet
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.Location = New System.Drawing.Point(339, 612)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlimentacionBindingSource
        '
        Me.AlimentacionBindingSource.DataMember = "Alimentacion"
        Me.AlimentacionBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'AlimentacionTableAdapter
        '
        Me.AlimentacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Me.AlimentacionTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'NumeroRegistroLabel
        '
        NumeroRegistroLabel.AutoSize = True
        NumeroRegistroLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroRegistroLabel.Location = New System.Drawing.Point(92, 186)
        NumeroRegistroLabel.Name = "NumeroRegistroLabel"
        NumeroRegistroLabel.Size = New System.Drawing.Size(224, 31)
        NumeroRegistroLabel.TabIndex = 20
        NumeroRegistroLabel.Text = "Numero Registro:"
        '
        'NumeroRegistroTextBox
        '
        Me.NumeroRegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "NumeroRegistro", True))
        Me.NumeroRegistroTextBox.Enabled = False
        Me.NumeroRegistroTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRegistroTextBox.Location = New System.Drawing.Point(339, 183)
        Me.NumeroRegistroTextBox.Name = "NumeroRegistroTextBox"
        Me.NumeroRegistroTextBox.Size = New System.Drawing.Size(279, 39)
        Me.NumeroRegistroTextBox.TabIndex = 21
        Me.NumeroRegistroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RayasicoLabel
        '
        RayasicoLabel.AutoSize = True
        RayasicoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RayasicoLabel.Location = New System.Drawing.Point(107, 384)
        RayasicoLabel.Name = "RayasicoLabel"
        RayasicoLabel.Size = New System.Drawing.Size(129, 31)
        RayasicoLabel.TabIndex = 22
        RayasicoLabel.Text = "Rayasico:"
        '
        'RayasicoTextBox
        '
        Me.RayasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Rayasico", True))
        Me.RayasicoTextBox.Enabled = False
        Me.RayasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RayasicoTextBox.Location = New System.Drawing.Point(297, 376)
        Me.RayasicoTextBox.Name = "RayasicoTextBox"
        Me.RayasicoTextBox.Size = New System.Drawing.Size(279, 39)
        Me.RayasicoTextBox.TabIndex = 23
        Me.RayasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TamasicoLabel
        '
        TamasicoLabel.AutoSize = True
        TamasicoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TamasicoLabel.Location = New System.Drawing.Point(107, 440)
        TamasicoLabel.Name = "TamasicoLabel"
        TamasicoLabel.Size = New System.Drawing.Size(134, 31)
        TamasicoLabel.TabIndex = 24
        TamasicoLabel.Text = "Tamasico:"
        '
        'TamasicoTextBox
        '
        Me.TamasicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Tamasico", True))
        Me.TamasicoTextBox.Enabled = False
        Me.TamasicoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TamasicoTextBox.Location = New System.Drawing.Point(297, 432)
        Me.TamasicoTextBox.Name = "TamasicoTextBox"
        Me.TamasicoTextBox.Size = New System.Drawing.Size(279, 39)
        Me.TamasicoTextBox.TabIndex = 25
        Me.TamasicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SatvicoLabel
        '
        SatvicoLabel.AutoSize = True
        SatvicoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SatvicoLabel.Location = New System.Drawing.Point(107, 492)
        SatvicoLabel.Name = "SatvicoLabel"
        SatvicoLabel.Size = New System.Drawing.Size(109, 31)
        SatvicoLabel.TabIndex = 26
        SatvicoLabel.Text = "Satvico:"
        '
        'SatvicoTextBox
        '
        Me.SatvicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Satvico", True))
        Me.SatvicoTextBox.Enabled = False
        Me.SatvicoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SatvicoTextBox.Location = New System.Drawing.Point(297, 484)
        Me.SatvicoTextBox.Name = "SatvicoTextBox"
        Me.SatvicoTextBox.Size = New System.Drawing.Size(279, 39)
        Me.SatvicoTextBox.TabIndex = 27
        Me.SatvicoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(678, 263)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(162, 31)
        DescripcionLabel.TabIndex = 28
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(684, 310)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(575, 377)
        Me.DescripcionTextBox.TabIndex = 29
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(92, 245)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(140, 31)
        MatriculaLabel.TabIndex = 30
        MatriculaLabel.Text = "Matricula:"
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlimentacionBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Enabled = False
        Me.MatriculaTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(98, 297)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(520, 39)
        Me.MatriculaTextBox.TabIndex = 31
        Me.MatriculaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultadosAlimentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(1296, 715)
        Me.Controls.Add(NumeroRegistroLabel)
        Me.Controls.Add(Me.NumeroRegistroTextBox)
        Me.Controls.Add(RayasicoLabel)
        Me.Controls.Add(Me.RayasicoTextBox)
        Me.Controls.Add(TamasicoLabel)
        Me.Controls.Add(Me.TamasicoTextBox)
        Me.Controls.Add(SatvicoLabel)
        Me.Controls.Add(Me.SatvicoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResultadosAlimentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResultadosAlimentacion"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Resultados As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents AlimentacionBindingSource As BindingSource
    Friend WithEvents AlimentacionTableAdapter As PsicologiaDBDataSetTableAdapters.AlimentacionTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumeroRegistroTextBox As TextBox
    Friend WithEvents RayasicoTextBox As TextBox
    Friend WithEvents TamasicoTextBox As TextBox
    Friend WithEvents SatvicoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents MatriculaTextBox As TextBox
End Class
