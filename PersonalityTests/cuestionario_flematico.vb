Public Class cuestionario_flematico
    Public puntajeFlematico, contador, respuestas As Integer
    Public mediosPuntos As Double

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        'Valida que todas las preguntas esten contestadas
        If ResCorrecta1.Checked = True Or ResIncorrecta1.Checked = True Or MasMenos1.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta2.Checked = True Or ResIncorrecta2.Checked = True Or MasMenos2.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta3.Checked = True Or ResIncorrecta3.Checked = True Or MasMenos3.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta4.Checked = True Or ResIncorrecta4.Checked = True Or MasMenos4.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta5.Checked = True Or ResIncorrecta5.Checked = True Or MasMenos5.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta6.Checked = True Or ResIncorrecta6.Checked = True Or MasMenos6.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta1.Checked = True Then
            contador = contador + 1
        End If

        If ResCorrecta2.Checked = True Then
            contador = contador + 1
        End If

        If ResCorrecta3.Checked = True Then
            contador = contador + 1
        End If

        If ResCorrecta4.Checked = True Then
            contador = contador + 1
        End If

        If ResCorrecta5.Checked = True Then
            contador = contador + 1
        End If

        If ResCorrecta6.Checked = True Then
            contador = contador + 1
        End If

        'Validacion de puntos medios
        If MasMenos1.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If MasMenos2.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If MasMenos3.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If MasMenos4.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If MasMenos5.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If MasMenos6.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If
        promediarFlematico()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        cuestionario_sanguineo.Close()
        cuestionario_melancolico.Close()
        cuestionario_colerico.Close()
        Me.Close()
    End Sub

    Public Sub promediarFlematico()
        'Si todas las preguntas son respondidas se podra avanzar al siguiente cuestionario
        If respuestas >= 6 Then
            puntajeFlematico = ((contador + mediosPuntos) / 6) * 100
            Me.Hide()
            resultados_temperamentos.Show()
            'resultados_temperamentos.TemperamentosTableAdapter.Fill(resultados_temperamentos.PsicologiadbDataSet.temperamentos)
            resultados_temperamentos.TemperamentosBindingSource.AddNew()
            resultados_temperamentos.MatriculaTextBox.Text = MenuPrincipal.matricula
        ElseIf respuestas < 6 Then
            contador = 0
            MsgBox("Falta contestar una o mas preguntas.", vbCritical, "Contestar todo el cuestionario por favor.")
        End If
    End Sub
End Class