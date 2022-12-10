Public Class Pacientes
    Dim estado As Boolean
    Dim matricula, parte1, parte2 As String
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacientesTableAdapter.Fill(Me.PsicologiaDBDataSet.Pacientes)
        estado = False
        HabilitarTxts()
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub HabilitarTxts()
        If estado = True Then
            NombreTextBox.Enabled = True
            ApellidosTextBox.Enabled = True
            TelefonoTextBox.Enabled = True
            EdadTextBox.Enabled = True
        ElseIf estado = False
            NombreTextBox.Enabled = False
            ApellidosTextBox.Enabled = False
            TelefonoTextBox.Enabled = False
            EdadTextBox.Enabled = False
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.PacientesBindingSource.CancelEdit()
            Me.PacientesTableAdapter.Fill(Me.PsicologiaDBDataSet.Pacientes)
            estado = False
            HabilitarTxts()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        estado = True
        HabilitarTxts()
        BtnCancelar.Enabled = True
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.PacientesTableAdapter.Update(Me.PsicologiaDBDataSet.Pacientes)
            Me.Refresh()
            estado = False
            HabilitarTxts()
            MessageBox.Show("Cambios guardados exitosamente.")
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim nResp As Byte

            nResp = MessageBox.Show("¿Estas seguro de eliminar este registro?",
                 "Eliminar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If nResp = 6 Then
                Me.PacientesTableAdapter.Delete(MatriculaTextBox.Text)
                MessageBox.Show("Registro se elimino exitosamente.")
                Me.PacientesTableAdapter.Fill(Me.PsicologiaDBDataSet.Pacientes)
            End If
            BtnCancelar.Enabled = True
            BtnGuardar.Enabled = True
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.PacientesTableAdapter.BuscarPaciente(Me.PsicologiaDBDataSet.Pacientes, TxtBuscar.Text)
        End Select
    End Sub

    Private Sub generarMatricula()
        parte1 = TelefonoTextBox.Text
        parte2 = (Mid(NombreTextBox.Text, 1, 1))
        matricula = parte1 + parte2
        MatriculaTextBox.Text = matricula
    End Sub

    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoTextBox.TextChanged
        generarMatricula()
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        generarMatricula()
    End Sub
End Class