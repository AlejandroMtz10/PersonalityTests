﻿Public Class cuestionario_colerico
    Public puntajeColerico, contador, respuestas As Integer
    Public mediosPuntos As Double

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        cuestionario_sanguineo.Close()
        cuestionario_melancolico.Close()
        Me.Close()
    End Sub
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

        promediarColerico()
    End Sub

    Public Sub promediarColerico()
        'Si todas las preguntas son respondidas se podra avanzar al siguiente cuestionario
        If respuestas >= 6 Then
            puntajeColerico = ((contador + mediosPuntos) / 6) * 100
            Me.Hide()
            cuestionario_flematico.Show()
        ElseIf respuestas < 6 Then
            contador = 0
            MsgBox("Falta contestar una o mas preguntas.", vbCritical, "Contestar todo el cuestionario por favor.")
        End If
    End Sub
End Class