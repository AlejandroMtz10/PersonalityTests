Public Class registrosAntecedentes
    Dim estado As Boolean
    Private Sub registrosAntecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiaDBDataSet.HistorialPaciente' Puede moverla o quitarla según sea necesario.
        Me.HistorialPacienteTableAdapter.Fill(Me.PsicologiaDBDataSet.HistorialPaciente)
        estado = False
        habilitarTxts()
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
        BtnEliminar.Enabled = True
        BtnModificar.Enabled = True
    End Sub

    Private Sub habilitarTxts()
        If estado = True Then
            FechaDateTimePicker.Enabled = True
            UsoMedicamentosComboBox.Enabled = True
            AntecedentesTextBox.Enabled = True
        ElseIf estado = False
            FechaDateTimePicker.Enabled = False
            UsoMedicamentosComboBox.Enabled = False
            AntecedentesTextBox.Enabled = False
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.HistorialPacienteTableAdapter.BuscarRegistroHistorial(PsicologiaDBDataSet.HistorialPaciente, TxtBuscar.Text)
                If TxtBuscar.Text = "" Then
                    Me.HistorialPacienteTableAdapter.Fill(Me.PsicologiaDBDataSet.HistorialPaciente)
                End If
        End Select
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.HistorialPacienteBindingSource.CancelEdit()
            Me.HistorialPacienteTableAdapter.Fill(Me.PsicologiaDBDataSet.HistorialPaciente)
            estado = False
            habilitarTxts()
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.HistorialPacienteBindingSource.EndEdit()
            Me.HistorialPacienteTableAdapter.Update(Me.PsicologiaDBDataSet.HistorialPaciente)
            Me.Refresh()
            estado = False
            habilitarTxts()
            MessageBox.Show("Cambios guardados exitosamente.")
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
        habilitarTxts()
        BtnCancelar.Enabled = True
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim nResp As Byte

            nResp = MessageBox.Show("¿Estas seguro de eliminar este registro?",
                 "Eliminar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If nResp = 6 Then

                Me.HistorialPacienteTableAdapter.Delete(NumeroHistorialTextBox.Text)
                MessageBox.Show("Registro se elimino exitosamente.")
                Me.HistorialPacienteTableAdapter.Fill(Me.PsicologiaDBDataSet.HistorialPaciente)
            End If
            BtnCancelar.Enabled = True
            BtnGuardar.Enabled = True
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class