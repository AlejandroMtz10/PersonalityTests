Public Class CuestionarioMelancolico
    Public puntajeMelancolico, contador, respuestas As Integer
    Public mediosPuntos As Double
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CuestionarioSanguineo.Close()
        Me.Close()
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        'Valida que todas las preguntas esten contestadas
        If ResCorrecta1.Checked = True Or ResIncorrecta1.Checked = True Or TalVez1.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta2.Checked = True Or ResIncorrecta2.Checked = True Or TalVez2.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta3.Checked = True Or ResIncorrecta3.Checked = True Or TalVez3.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta4.Checked = True Or ResIncorrecta4.Checked = True Or TalVez4.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta5.Checked = True Or ResIncorrecta5.Checked = True Or TalVez5.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If

        If ResCorrecta6.Checked = True Or ResIncorrecta6.Checked = True Or TalVez6.Checked = True Then
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
        If TalVez1.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If TalVez2.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If TalVez3.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If TalVez4.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If TalVez5.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If TalVez6.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        avanzarMelancolico()
    End Sub

    Public Sub avanzarMelancolico()
        'Si todas las preguntas son respondidas se podra avanzar al siguiente cuestionario
        If respuestas >= 6 Then
            puntajeMelancolico = ((contador + mediosPuntos) / 6) * 100
            Me.Hide()
            CuestionarioColerico.Show()
        ElseIf respuestas < 6
            contador = 0
            MsgBox("Falta contestar una o mas preguntas.", vbCritical, "Contestar todo el cuestionario por favor.")
        End If
    End Sub
End Class