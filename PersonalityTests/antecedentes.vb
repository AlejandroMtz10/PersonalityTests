Public Class antecedentes
    Dim activos As Integer
    Dim user, fechaReg As String

    Private Sub antecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.Fill(Me.PsicologiadbDataSet.bitacora)
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.PsicologiadbDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.historialpaciente' Puede moverla o quitarla según sea necesario.
        Me.HistorialpacienteTableAdapter.Fill(Me.PsicologiadbDataSet.historialpaciente)

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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        activos = 1
        habilitarBotones()
        MatriculaTextBox.ReadOnly = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        activos = 1
        habilitarBotones()

        Try
            Dim nResp As Byte
            nResp = MsgBox("¿Realmente desea eliminar esté registro?", vbYesNo, "Eliminar registro.")

            If nResp = vbYes Then
                Me.HistorialpacienteTableAdapter.Delete(NumeroHistorialTextBox.Text)

                'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
                fechaReg = Now
                user = PantallaCarga.user
                Me.BitacoraTableAdapter.insertarRegistro(user, "Historial de los pacientes", "Registro eliminado", fechaReg)

                MsgBox("Registro eliminado exitosamente.", vbInformation, "Eliminado.")
                Me.HistorialpacienteTableAdapter.Fill(Me.PsicologiadbDataSet.historialpaciente)
            End If
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Me.Validate()
            Me.HistorialpacienteBindingSource.EndEdit()
            Me.HistorialpacienteTableAdapter.Update(Me.PsicologiadbDataSet.historialpaciente)

            'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
            fechaReg = Now
            user = PantallaCarga.user
            Me.BitacoraTableAdapter.insertarRegistro(user, "Historial de pacientes", "Registro actualizado", fechaReg)

            Me.Refresh()
            MsgBox("Cambios guardados exitosamente.", vbInformation, "Guardado.")
            MatriculaTextBox.ReadOnly = True
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.HistorialpacienteBindingSource.CancelEdit()
            Me.HistorialpacienteTableAdapter.Fill(Me.PsicologiadbDataSet.historialpaciente)
            MsgBox("Cambios cancelados.", vbInformation, "Cancelar.")
            MatriculaTextBox.ReadOnly = True
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.HistorialpacienteTableAdapter.buscarRegistroHistorialPaciente(Me.PsicologiadbDataSet.historialpaciente, TxtBuscar.Text)
        End Select
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class