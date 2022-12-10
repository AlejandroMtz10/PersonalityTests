Public Class registrosAlimentacion
    Dim estado As Boolean
    Private Sub HabilitarTxts()
        If estado = True Then
            DescripcionTextBox.Enabled = True
        ElseIf estado = False
            DescripcionTextBox.Enabled = False
        End If
    End Sub
    Private Sub registrosAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiaDBDataSet.Alimentacion' Puede moverla o quitarla según sea necesario.
        Me.AlimentacionTableAdapter.Fill(Me.PsicologiaDBDataSet.Alimentacion)
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.AlimentacionBindingSource.CancelEdit()
            Me.AlimentacionTableAdapter.Fill(Me.PsicologiaDBDataSet.Alimentacion)
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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.AlimentacionBindingSource.EndEdit()
            Me.AlimentacionTableAdapter.Update(Me.PsicologiaDBDataSet.Alimentacion)
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        estado = True
        HabilitarTxts()
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
                Me.AlimentacionTableAdapter.Delete(NumeroRegistroTextBox.Text)
                MessageBox.Show("Registro se elimino exitosamente.")
                Me.AlimentacionTableAdapter.Fill(Me.PsicologiaDBDataSet.Alimentacion)
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
                Me.AlimentacionTableAdapter.BuscarRegistroAlimentacion(Me.PsicologiaDBDataSet.Alimentacion, TxtBuscar.Text)
                If TxtBuscar.Text = "" Then
                    Me.AlimentacionTableAdapter.Fill(Me.PsicologiaDBDataSet.Alimentacion)
                End If
        End Select
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class