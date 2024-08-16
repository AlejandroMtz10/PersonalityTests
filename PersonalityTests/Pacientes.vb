Public Class pacientes
    Dim activos As Integer
    Dim matricula, parte1, parte2, fecha, user As String
    Private Sub pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.Fill(Me.PsicologiadbDataSet.bitacora)
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.PsicologiadbDataSet.pacientes)
        activos = 0
        habilitarBotones()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub habilitarBotones()
        If activos = 0 Then
            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
        ElseIf activos = 1 Then
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
        End If
    End Sub
    Private Sub generarMatricula()
        parte1 = TelefonoTextBox.Text
        parte2 = (Mid(NombreTextBox.Text, 1, 1))
        matricula = parte1 + parte2
        MatriculaTextBox.Text = matricula
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        activos = 1
        habilitarBotones()
        TelefonoTextBox.ReadOnly = False
        EdadTextBox.ReadOnly = False
        OrientacionSexualComboBox.Enabled = True
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        activos = 1
        habilitarBotones()
        Try
            Dim nResp As Byte
            nResp = MsgBox("¿Realmente desea eliminar esté paciente?", vbYesNo, "Eliminar paciente.")
            If nResp = vbYes Then
                'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
                fecha = Now
                user = PantallaCarga.user
                Me.BitacoraTableAdapter.insertarRegistro(user, "Pacientes", "Paciente eliminado", fecha)
                Me.PacientesTableAdapter.Delete(MatriculaTextBox.Text)
                MsgBox("Paciente eliminado exitosamente.", vbInformation, "Eliminado.")
                Me.PacientesTableAdapter.Fill(Me.PsicologiadbDataSet.pacientes)
            End If
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub
    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.PacientesTableAdapter.buscarPaciente(Me.PsicologiadbDataSet.pacientes, TxtBuscar.Text)
        End Select
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
            fecha = Now
            user = PantallaCarga.user
            Me.BitacoraTableAdapter.insertarRegistro(user, "Pacientes", "Registro actualizado", fecha)

            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.PacientesTableAdapter.Update(Me.PsicologiadbDataSet.pacientes)
            Me.Refresh()
            MsgBox("Cambios guardados exitosamente.", vbInformation, "Guardado.")
            TelefonoTextBox.ReadOnly = True
            EdadTextBox.ReadOnly = True
            OrientacionSexualComboBox.Enabled = False
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.PacientesBindingSource.CancelEdit()
            Me.PacientesTableAdapter.Fill(Me.PsicologiadbDataSet.pacientes)
            MsgBox("Cambios cancelados.", vbInformation, "Cancelar.")
            TelefonoTextBox.ReadOnly = True
            EdadTextBox.ReadOnly = True
            OrientacionSexualComboBox.Enabled = False
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub
    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        generarMatricula()
    End Sub
    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoTextBox.TextChanged
        generarMatricula()
    End Sub
End Class