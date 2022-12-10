Public Class registroTemperamentos
    Dim estado As Boolean
    Private Sub HabilitarTxts()
        If estado = True Then
            DescripcionTextBox.Enabled = True
        ElseIf estado = False
            DescripcionTextBox.Enabled = False
        End If

    End Sub
    Private Sub registroTemperamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiaDBDataSet.Temperamentos' Puede moverla o quitarla según sea necesario.
        Me.TemperamentosTableAdapter.Fill(Me.PsicologiaDBDataSet.Temperamentos)
        estado = False
        HabilitarTxts()
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.TemperamentosBindingSource.CancelEdit()
            Me.TemperamentosTableAdapter.Fill(Me.PsicologiaDBDataSet.Temperamentos)
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.TemperamentosBindingSource.EndEdit()
            Me.TemperamentosTableAdapter.Update(Me.PsicologiaDBDataSet.Temperamentos)
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
                Me.TemperamentosTableAdapter.Delete(NumeroRegistroTextBox.Text)
                MessageBox.Show("Registro se elimino exitosamente.")
                Me.TemperamentosTableAdapter.Fill(Me.PsicologiaDBDataSet.Temperamentos)
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
                Me.TemperamentosTableAdapter.BuscarRegistroTemperamentos(Me.PsicologiaDBDataSet.Temperamentos, TxtBuscar.Text)
                If TxtBuscar.Text = "" Then
                    Me.TemperamentosTableAdapter.Fill(Me.PsicologiaDBDataSet.Temperamentos)
                End If
        End Select
    End Sub
End Class