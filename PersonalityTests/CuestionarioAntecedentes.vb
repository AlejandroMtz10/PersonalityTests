Public Class CuestionarioAntecedentes

    Private Sub BtnInformacion_Click(sender As Object, e As EventArgs) Handles BtnInformacion.Click
        MsgBox("En el apartado de antecedentes puedes escribir tus problemas del pasado, actuales, fobias, gustos o los medicamentos que usas si es que hace uso de medicamentos.", vbInformation, "Información.")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            ' Me.HistorialPacienteBindingSource.CancelEdit()
            MsgBox("Registro cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Me.Close()

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
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub CuestionarioAntecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.HistorialPacienteTableAdapter.Fill(Me.PsicologiaDBDataSet.HistorialPaciente)
    End Sub
End Class