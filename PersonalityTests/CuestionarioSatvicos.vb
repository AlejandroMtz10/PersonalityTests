Public Class CuestionarioSatvicos
    Public puntajeSatvicos, contador, respuestas As Integer
    Public mediosPuntos As Double

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CuestionarioRayasicos.Close()
        CuestionarioTamasicos.Close()
        Me.Close()
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
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

        If ResCorrecta7.Checked = True Or ResIncorrecta7.Checked = True Or MasMenos7.Checked = True Then
            respuestas = respuestas + 1
        Else
            respuestas = respuestas + 0
        End If
        'Conteo de respuestas correctas
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

        If ResCorrecta7.Checked = True Then
            contador = contador + 1
        End If

        'Conteo de puntos medios como respuesta
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

        If MasMenos7.Checked = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If
        avanzarSatvicos()
    End Sub
    Public Sub avanzarSatvicos()
        'Si todas las preguntas son respondidas se podra avanzar al siguiente cuestionario
        If respuestas >= 7 Then
            BtnSiguiente.Enabled = True
            puntajeSatvicos = ((contador + mediosPuntos) / 7) * 100
            Me.Hide()
            ResultadosAlimentacion.Show()
            ResultadosAlimentacion.AlimentacionBindingSource.AddNew()
            ResultadosAlimentacion.MatriculaTextBox.Text = MenuPrincipal.matricula
        ElseIf respuestas < 7 Then
            contador = 0
            MsgBox("Falta contestar una o mas preguntas.", vbCritical, "Contestar todo el cuestionario por favor.")
        End If
    End Sub
End Class