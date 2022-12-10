<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccesoPacientes
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
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.PacientesTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MatriculaTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MatriculaTxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Matricula:"
        '
        'MatriculaTxt
        '
        Me.MatriculaTxt.Location = New System.Drawing.Point(18, 44)
        Me.MatriculaTxt.Name = "MatriculaTxt"
        Me.MatriculaTxt.Size = New System.Drawing.Size(419, 44)
        Me.MatriculaTxt.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.NombreTxt)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(72, 453)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 108)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre:"
        '
        'NombreTxt
        '
        Me.NombreTxt.Location = New System.Drawing.Point(18, 43)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(419, 44)
        Me.NombreTxt.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.PersonalityTests.My.Resources.Resources.cerrarSesion
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(27, 603)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(250, 75)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnAcceder
        '
        Me.BtnAcceder.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcceder.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcceder.Image = Global.PersonalityTests.My.Resources.Resources.ingresar
        Me.BtnAcceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAcceder.Location = New System.Drawing.Point(297, 603)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(250, 75)
        Me.BtnAcceder.TabIndex = 3
        Me.BtnAcceder.Text = "Acceder"
        Me.BtnAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAcceder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAcceder.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PersonalityTests.My.Resources.Resources.Pacientes__2_
        Me.PictureBox1.Location = New System.Drawing.Point(193, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Acceso de pacientes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.PersonalityTests.My.Resources.Resources.Acerca_de
        Me.Button1.Location = New System.Drawing.Point(513, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AccesoPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PersonalityTests.My.Resources.Resources.FondoVerdePacientes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 750)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAcceder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccesoPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccesoPaciente"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As PsicologiaDBDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAcceder As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents MatriculaTxt As TextBox
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
