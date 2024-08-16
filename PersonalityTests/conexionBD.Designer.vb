<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conexionBD
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
        Me.imgDB_successful = New System.Windows.Forms.PictureBox()
        Me.imgDB_failed = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStateConnection = New System.Windows.Forms.Label()
        Me.txtInformation = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PsicologiadbDataSet = New PersonalityTests.psicologiadbDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraTableAdapter = New PersonalityTests.psicologiadbDataSetTableAdapters.bitacoraTableAdapter()
        CType(Me.imgDB_successful, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDB_failed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgDB_successful
        '
        Me.imgDB_successful.Image = Global.PersonalityTests.My.Resources.Resources.databaseConection
        Me.imgDB_successful.Location = New System.Drawing.Point(46, 258)
        Me.imgDB_successful.Name = "imgDB_successful"
        Me.imgDB_successful.Size = New System.Drawing.Size(200, 200)
        Me.imgDB_successful.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDB_successful.TabIndex = 0
        Me.imgDB_successful.TabStop = False
        Me.imgDB_successful.Visible = False
        '
        'imgDB_failed
        '
        Me.imgDB_failed.Image = Global.PersonalityTests.My.Resources.Resources.databaseFailedConection
        Me.imgDB_failed.Location = New System.Drawing.Point(46, 258)
        Me.imgDB_failed.Name = "imgDB_failed"
        Me.imgDB_failed.Size = New System.Drawing.Size(200, 200)
        Me.imgDB_failed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDB_failed.TabIndex = 1
        Me.imgDB_failed.TabStop = False
        Me.imgDB_failed.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Conexión con la base de datos."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Conexión:"
        '
        'lblStateConnection
        '
        Me.lblStateConnection.AutoSize = True
        Me.lblStateConnection.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateConnection.Location = New System.Drawing.Point(430, 132)
        Me.lblStateConnection.Name = "lblStateConnection"
        Me.lblStateConnection.Size = New System.Drawing.Size(255, 36)
        Me.lblStateConnection.TabIndex = 4
        Me.lblStateConnection.Text = "Conexión exitosa."
        '
        'txtInformation
        '
        Me.txtInformation.BackColor = System.Drawing.Color.White
        Me.txtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInformation.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformation.Location = New System.Drawing.Point(274, 192)
        Me.txtInformation.Multiline = True
        Me.txtInformation.Name = "txtInformation"
        Me.txtInformation.ReadOnly = True
        Me.txtInformation.Size = New System.Drawing.Size(719, 357)
        Me.txtInformation.TabIndex = 5
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.PersonalityTests.My.Resources.Resources.cancelar
        Me.BtnClose.Location = New System.Drawing.Point(979, 9)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(50, 50)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PsicologiadbDataSet
        '
        Me.PsicologiadbDataSet.DataSetName = "psicologiadbDataSet"
        Me.PsicologiadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.alimentacionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bitacoraTableAdapter = Nothing
        Me.TableAdapterManager.historialpacienteTableAdapter = Nothing
        Me.TableAdapterManager.pacientesTableAdapter = Nothing
        Me.TableAdapterManager.signoszodiacalesTableAdapter = Nothing
        Me.TableAdapterManager.temperamentosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PersonalityTests.psicologiadbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
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
        'conexionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1038, 574)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.txtInformation)
        Me.Controls.Add(Me.lblStateConnection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgDB_failed)
        Me.Controls.Add(Me.imgDB_successful)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "conexionBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "conexionBD"
        CType(Me.imgDB_successful, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDB_failed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsicologiadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgDB_successful As PictureBox
    Friend WithEvents imgDB_failed As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStateConnection As Label
    Friend WithEvents txtInformation As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents PsicologiadbDataSet As psicologiadbDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As psicologiadbDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As psicologiadbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BitacoraTableAdapter As psicologiadbDataSetTableAdapters.bitacoraTableAdapter
    Friend WithEvents BitacoraBindingSource As BindingSource
End Class
