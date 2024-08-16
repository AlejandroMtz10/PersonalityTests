Public Class resultados_temperamentos
    Dim sanguineo, melancolico, colerico, flematico As Integer

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
            Me.TemperamentosTableAdapter.Update(Me.PsicologiadbDataSet.temperamentos)
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
        Cuestionario_Sanguineo.Close()
        Cuestionario_Melancolico.Close()
        Cuestionario_Colerico.Close()
        Cuestionario_Flematico.Close()
        Me.Close()
    End Sub

    Private Sub BtnResultados_Click(sender As Object, e As EventArgs) Handles BtnResultados.Click
        SanguineoTextBox.Text = cuestionario_sanguineo.puntajeSanguineo & "%"
        MelancolicoTextBox.Text = cuestionario_melancolico.puntajeMelancolico & "%"
        ColericoTextBox.Text = cuestionario_colerico.puntajeColerico & "%"
        FlematicoTextBox.Text = cuestionario_flematico.puntajeFlematico & "%"
        comparaciones()
    End Sub

    Private Sub comparaciones()
        'Las variables de los temperamentos se igualan a los puntajes obtenidos
        sanguineo = cuestionario_sanguineo.puntajeSanguineo
        melancolico = cuestionario_melancolico.puntajeMelancolico
        colerico = cuestionario_colerico.puntajeColerico
        flematico = cuestionario_flematico.puntajeFlematico

        'Se compara si sanguineo es el mayor
        If (sanguineo > melancolico) And (sanguineo > colerico) And (sanguineo > flematico) Then
            DescripcionTextBox.Text = "Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas."
        End If

        'Se compara si melancolico es el mayor
        If (melancolico > sanguineo) And (melancolico > colerico) And (melancolico > flematico) Then
            DescripcionTextBox.Text = "Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas."
        End If

        'Se compara si colerico es el mayor
        If (colerico > sanguineo) And (colerico > melancolico) And (colerico > flematico) Then
            DescripcionTextBox.Text = "Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si colerico es el mayor
        If (flematico > sanguineo) And (flematico > melancolico) And (flematico > colerico) Then
            DescripcionTextBox.Text = "Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Para empate de dos temperamenteos altos
        'Se compara si sanguineo y melancolico son los mayores
        If (sanguineo = melancolico) And (sanguineo > colerico) And (sanguineo > flematico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas."
        End If

        'Se compara si sanguineo y colerico son los mayores
        If (sanguineo = colerico) And (sanguineo > melancolico) And (sanguineo > flematico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si sanguineo y flematico son los mayores
        If (sanguineo = flematico) And (sanguineo > melancolico) And (sanguineo > colerico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si melancolico y colericoco son los mayores
        If (melancolico = colerico) And (melancolico > sanguineo) And (melancolico > flematico) Then
            DescripcionTextBox.Text = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si melancolico y flematico son los mayores
        If (melancolico = flematico) And (melancolico > sanguineo) And (melancolico > colerico) Then
            DescripcionTextBox.Text = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si colerico y flematico son los mayores
        If (colerico = flematico) And (colerico > sanguineo) And (colerico > melancolico) Then
            DescripcionTextBox.Text = "- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son sanguineo, melancolico y colerico
        If (sanguineo = melancolico) And (sanguineo = colerico) And (sanguineo > flematico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si las mayores son sanguineo, melancolico y flematico
        If (sanguineo = melancolico) And (sanguineo = flematico) And (sanguineo > colerico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son sanguineo, colerico y flematico
        If (sanguineo = colerico) And (sanguineo = flematico) And (sanguineo > melancolico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son melancolico, colerico y flematico
        If (melancolico = colerico) And (melancolico = flematico) And (melancolico > sanguineo) Then
            DescripcionTextBox.Text = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Todos los temperamentos son altos
        If (sanguineo = melancolico) And (sanguineo = colerico) And (sanguineo = flematico) Then
            DescripcionTextBox.Text = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If
    End Sub
End Class