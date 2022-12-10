<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuarios
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
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim PassworLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.PsicologiaDBDataSet = New PersonalityTests.PsicologiaDBDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PersonalityTests.PsicologiaDBDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager()
        Me.IdUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PassworTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmarContrasenaTxt = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        PassworLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdUsuarioLabel.Location = New System.Drawing.Point(425, 174)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(248, 31)
        IdUsuarioLabel.TabIndex = 1
        IdUsuarioLabel.Text = "Número de usuario:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(34, 286)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(118, 31)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(602, 286)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(133, 31)
        ApellidosLabel.TabIndex = 5
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(34, 375)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(123, 31)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "Telefono:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(602, 375)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(117, 31)
        UsuarioLabel.TabIndex = 9
        UsuarioLabel.Text = "Usuario:"
        '
        'PassworLabel
        '
        PassworLabel.AutoSize = True
        PassworLabel.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PassworLabel.Location = New System.Drawing.Point(123, 451)
        PassworLabel.Name = "PassworLabel"
        PassworLabel.Size = New System.Drawing.Size(159, 31)
        PassworLabel.TabIndex = 11
        PassworLabel.Text = "Contraseña:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(123, 576)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(284, 31)
        Label1.TabIndex = 13
        Label1.Text = "Confirmar contraseña:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(375, 28)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(528, 73)
        Label2.TabIndex = 15
        Label2.Text = "Registrar usuario."
        '
        'PsicologiaDBDataSet
        '
        Me.PsicologiaDBDataSet.DataSetName = "PsicologiaDBDataSet"
        Me.PsicologiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.PsicologiaDBDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistorialPacienteTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.SignosZodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.TemperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.PsicologiaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'IdUsuarioTextBox
        '
        Me.IdUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "IdUsuario", True))
        Me.IdUsuarioTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUsuarioTextBox.Location = New System.Drawing.Point(690, 166)
        Me.IdUsuarioTextBox.Name = "IdUsuarioTextBox"
        Me.IdUsuarioTextBox.ReadOnly = True
        Me.IdUsuarioTextBox.Size = New System.Drawing.Size(163, 39)
        Me.IdUsuarioTextBox.TabIndex = 2
        Me.IdUsuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(182, 278)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(403, 39)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(753, 278)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(473, 39)
        Me.ApellidosTextBox.TabIndex = 6
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(182, 367)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(403, 39)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(753, 372)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(473, 39)
        Me.UsuarioTextBox.TabIndex = 10
        '
        'PassworTextBox
        '
        Me.PassworTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Passwor", True))
        Me.PassworTextBox.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassworTextBox.Location = New System.Drawing.Point(129, 505)
        Me.PassworTextBox.Name = "PassworTextBox"
        Me.PassworTextBox.Size = New System.Drawing.Size(420, 39)
        Me.PassworTextBox.TabIndex = 12
        '
        'ConfirmarContrasenaTxt
        '
        Me.ConfirmarContrasenaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Passwor", True))
        Me.ConfirmarContrasenaTxt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmarContrasenaTxt.Location = New System.Drawing.Point(129, 635)
        Me.ConfirmarContrasenaTxt.Name = "ConfirmarContrasenaTxt"
        Me.ConfirmarContrasenaTxt.Size = New System.Drawing.Size(420, 39)
        Me.ConfirmarContrasenaTxt.TabIndex = 14
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Violet
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.PersonalityTests.My.Resources.Resources.Cancelar1
        Me.BtnCancelar.Location = New System.Drawing.Point(808, 599)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
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
        Me.BtnGuardar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.PersonalityTests.My.Resources.Resources.Guardar
        Me.BtnGuardar.Location = New System.Drawing.Point(808, 490)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 75)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'RegistrarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1278, 799)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ConfirmarContrasenaTxt)
        Me.Controls.Add(Label1)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(Me.IdUsuarioTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(PassworLabel)
        Me.Controls.Add(Me.PassworTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarUsuarios"
        CType(Me.PsicologiaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PsicologiaDBDataSet As PsicologiaDBDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As PsicologiaDBDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As PsicologiaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdUsuarioTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents PassworTextBox As TextBox
    Friend WithEvents ConfirmarContrasenaTxt As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
End Class
