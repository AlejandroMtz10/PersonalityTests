Public Class ResultadosTemperamentos

    Private Sub Resultados_Click(sender As Object, e As EventArgs) Handles Resultados.Click
        SanguineoTextBox.Text = CuestionarioSanguineo.puntajeSanguineo & "%"
        MelancolicoTextBox.Text = CuestionarioMelancolico.puntajeMelancolico & "%"
        ColericoTextBox.Text = CuestionarioColerico.puntajeColerico & "%"
        FlematicoTextBox.Text = CuestionarioFlematico.puntajeFlematico & "%"
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.TemperamentosBindingSource.CancelEdit()
            MsgBox("Registro cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            cerrarTodo()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.TemperamentosBindingSource.EndEdit()
            Me.TemperamentosTableAdapter.Update(Me.PsicologiaDBDataSet.Temperamentos)
            Me.Refresh()
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            cerrarTodo()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    'Este metodo cierra todos los formularios que se quedaron abiertos
    'en segundo plano
    Public Sub cerrarTodo()
        CuestionarioSanguineo.Close()
        CuestionarioMelancolico.Close()
        CuestionarioColerico.Close()
        CuestionarioFlematico.Close()
        Me.Close()
    End Sub
End Class