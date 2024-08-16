Public Class historialPaciente

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            MsgBox("Se ha cancelado el registro y no se guardo, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Me.Close()
            Me.HistorialpacienteBindingSource.CancelEdit()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.HistorialpacienteBindingSource.EndEdit()
            Me.HistorialpacienteTableAdapter.Update(Me.PsicologiadbDataSet.historialpaciente)
            Me.Refresh()
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class