Public Class ResultadosAlimentacion
    Public rayasico, tamasico, satvico As Integer
    Private Sub ResultadosAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.alimentacion' Puede moverla o quitarla según sea necesario.
        Me.AlimentacionTableAdapter.Fill(Me.PsicologiadbDataSet.alimentacion)
    End Sub

    Private Sub Resultados_Click(sender As Object, e As EventArgs) Handles BtnResultados.Click

        SatvicoTextBox.Text = CuestionarioSatvicos.puntajeSatvicos & "%"
        TamasicoTextBox.Text = CuestionarioTamasicos.puntajeTamasicos & "%"
        RayasicoTextBox.Text = CuestionarioRayasicos.puntajeRayasicos & "%"

        rayasico = Val(RayasicoTextBox.Text)
        tamasico = Val(TamasicoTextBox.Text)
        satvico = Val(SatvicoTextBox.Text)

        If rayasico > tamasico And rayasico > satvico Then
            DescripcionTextBox.Text = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)."
        End If

        If tamasico > rayasico And tamasico > satvico Then
            DescripcionTextBox.Text = "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If satvico > rayasico And satvico > tamasico Then
            DescripcionTextBox.Text = "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If

        If rayasico = tamasico And rayasico > satvico And tamasico > satvico Then
            DescripcionTextBox.Text = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If rayasico = satvico And rayasico > tamasico And satvico > tamasico Then
            DescripcionTextBox.Text = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If

        If satvico = tamasico And satvico > rayasico And tamasico > rayasico Then
            DescripcionTextBox.Text = "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If satvico = tamasico And tamasico = rayasico Then
            DescripcionTextBox.Text = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)." & vbCrLf & "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.AlimentacionBindingSource.EndEdit()
            Me.AlimentacionTableAdapter.Update(Me.PsicologiadbDataSet.alimentacion)
            Me.Refresh()
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            cerrarTodo()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.AlimentacionBindingSource.CancelEdit()
            MsgBox("Registro cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            cerrarTodo()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub cerrarTodo()
        CuestionarioRayasicos.Close()
        CuestionarioSatvicos.Close()
        CuestionarioTamasicos.Close()
        Me.Close()
    End Sub

End Class