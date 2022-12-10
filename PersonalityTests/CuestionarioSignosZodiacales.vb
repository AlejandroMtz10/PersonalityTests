Public Class CuestionarioSignosZodiacales
    Private Sub desactivarImagenes()
        ImgAries.Visible = False
        ImgTauro.Visible = False
        ImgGeminis.Visible = False
        ImgCancer.Visible = False
        ImgLeo.Visible = False
        ImgVirgo.Visible = False
        ImgLibra.Visible = False
        ImgEscorpio.Visible = False
        ImgSagitario.Visible = False
        ImgCapricornio.Visible = False
        ImgAcuario.Visible = False
        ImgPiscis.Visible = False
        ImgSignos.Visible = False
    End Sub

    Private Sub CuestionarioSignosZodiacales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiaDBDataSet.SignosZodiacales' Puede moverla o quitarla según sea necesario.
        Me.SignosZodiacalesTableAdapter.Fill(Me.PsicologiaDBDataSet.SignosZodiacales)
        desactivarImagenes()
        ImgSignos.Visible = True
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If MesTxt.Text = "Marzo" Then

            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 20 Then
                SignoTextBox.Text = "Piscis"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Neptuno y Júpiter"
                DescripcionTextBox.Text = "Dignidad y los pies"
                desactivarImagenes()
                ImgPiscis.Visible = True
            End If

            If Val(DiaTxt.Text) >= 21 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Aries"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Marte"
                DescripcionTextBox.Text = "Acción y cabeza"
                desactivarImagenes()
                ImgAries.Visible = True
            End If

        End If

        If MesTxt.Text = "Abril" Then

            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 19 Then
                SignoTextBox.Text = "Aries"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Marte"
                DescripcionTextBox.Text = "Acción y cabeza"
                desactivarImagenes()
                ImgAries.Visible = True
            End If

            If Val(DiaTxt.Text) >= 20 And Val(DiaTxt.Text) <= 30 Then
                SignoTextBox.Text = "Tauro"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Venus"
                DescripcionTextBox.Text = "Amor, cuello, nuca y oídos"
                desactivarImagenes()
                ImgTauro.Visible = True
            End If
        End If

        If MesTxt.Text = "Mayo" Then

            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 19 Then
                SignoTextBox.Text = "Tauro"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Venus"
                DescripcionTextBox.Text = "Amor, cuello, nuca y oídos"
                desactivarImagenes()
                ImgTauro.Visible = True
            End If

            If Val(DiaTxt.Text) >= 20 And Val(DiaTxt.Text) <= 30 Then
                SignoTextBox.Text = "Geminis"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Mercurio"
                DescripcionTextBox.Text = "Brazos, hombros y pulmones"
                desactivarImagenes()
                ImgGeminis.Visible = True
            End If
        End If

        If MesTxt.Text = "Junio" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 20 Then
                SignoTextBox.Text = "Geminis"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Mercurio"
                DescripcionTextBox.Text = "Brazos, hombros y pulmones"
                desactivarImagenes()
                ImgGeminis.Visible = True
            End If

            If Val(DiaTxt.Text) >= 21 And Val(DiaTxt.Text) <= 30 Then
                SignoTextBox.Text = "Cáncer"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Luna"
                DescripcionTextBox.Text = "Fecundación y estomago"
                desactivarImagenes()
                ImgCancer.Visible = True
            End If
        End If

        If MesTxt.Text = "Julio" Then

            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 22 Then
                SignoTextBox.Text = "Cáncer"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Luna"
                DescripcionTextBox.Text = "Fecundación y estomago"
                desactivarImagenes()
                ImgCancer.Visible = True
            End If

            If Val(DiaTxt.Text) >= 23 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Leo"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Sol"
                DescripcionTextBox.Text = "Vida y corazón"
                desactivarImagenes()
                ImgLeo.Visible = True
            End If

        End If


        If MesTxt.Text = "Agosto" Then

            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 22 Then
                SignoTextBox.Text = "Leo"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Sol"
                DescripcionTextBox.Text = "Vida y corazón"
                desactivarImagenes()
                ImgLeo.Visible = True
            End If

            If Val(DiaTxt.Text) >= 23 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Virgo"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Mercurio"
                DescripcionTextBox.Text = "Razón, intestinos y bajo bientre"
                desactivarImagenes()
                ImgVirgo.Visible = True
            End If
        End If

        If MesTxt.Text = "Septiembre" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 22 Then
                SignoTextBox.Text = "Virgo"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Mercurio"
                DescripcionTextBox.Text = "Razón, intestinos y bajo bientre"
                desactivarImagenes()
                ImgVirgo.Visible = True
            End If

            If Val(DiaTxt.Text) >= 23 And Val(DiaTxt.Text) <= 30 Then
                SignoTextBox.Text = "Libra"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Venus"
                DescripcionTextBox.Text = "Amor y riñones"
                desactivarImagenes()
                ImgLibra.Visible = True
            End If
        End If

        If MesTxt.Text = "Octubre" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 22 Then
                SignoTextBox.Text = "Libra"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Venus"
                DescripcionTextBox.Text = "Amor y riñones"
                desactivarImagenes()
                ImgLibra.Visible = True
            End If

            If Val(DiaTxt.Text) >= 23 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Escorpio"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Marte"
                DescripcionTextBox.Text = "Acción y órganos sexuales"
                desactivarImagenes()
                ImgEscorpio.Visible = True
            End If
        End If

        If MesTxt.Text = "Noviembre" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 22 Then
                SignoTextBox.Text = "Escorpio"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Marte"
                DescripcionTextBox.Text = "Acción y órganos sexuales"
                desactivarImagenes()
                ImgEscorpio.Visible = True
            End If

            If Val(DiaTxt.Text) >= 23 And Val(DiaTxt.Text) <= 30 Then
                SignoTextBox.Text = "Sagitario"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Júpiter"
                DescripcionTextBox.Text = "Benevolencia, caderas y múslos"
                desactivarImagenes()
                ImgSagitario.Visible = True
            End If
        End If

        If MesTxt.Text = "Diciembre" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 21 Then
                SignoTextBox.Text = "Sagitario"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Júpiter"
                DescripcionTextBox.Text = "Benevolencia, caderas y múslos"
                desactivarImagenes()
                ImgSagitario.Visible = True
            End If

            If Val(DiaTxt.Text) >= 22 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Capricornio"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Saturno"
                DescripcionTextBox.Text = "Obstrucción, rodillas y piel"
                desactivarImagenes()
                ImgCapricornio.Visible = True
            End If
        End If

        If MesTxt.Text = "Enero" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 19 Then
                SignoTextBox.Text = "Capricornio"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Saturno"
                DescripcionTextBox.Text = "Obstrucción, rodillas y piel"
                desactivarImagenes()
                ImgCapricornio.Visible = True
            End If

            If Val(DiaTxt.Text) >= 20 And Val(DiaTxt.Text) <= 31 Then
                SignoTextBox.Text = "Acuario"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Urano"
                DescripcionTextBox.Text = "Altruismo, pantorrillas y tobillos"
                desactivarImagenes()
                ImgAcuario.Visible = True
            End If
        End If

        If MesTxt.Text = "Febrero" Then
            If Val(DiaTxt.Text) >= 1 And Val(DiaTxt.Text) <= 17 Then
                SignoTextBox.Text = "Acuario"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Urano"
                DescripcionTextBox.Text = "Altruismo, pantorrillas y tobillos"
                desactivarImagenes()
                ImgAcuario.Visible = True
            End If

            If Val(DiaTxt.Text) >= 18 And Val(DiaTxt.Text) <= 29 Then
                SignoTextBox.Text = "Piscis"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Neptuno y Júpiter"
                DescripcionTextBox.Text = "Dignidad y los pies"
                desactivarImagenes()
                ImgPiscis.Visible = True
            End If
        End If
    End Sub

    Private Sub BtnCanelar_Click(sender As Object, e As EventArgs) Handles BtnCanelar.Click
        Try

            'Me.SignosZodiacalesBindingSource.CancelEdit()
            MsgBox("Se ha cancelado el registro y no se guardo, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.SignosZodiacalesBindingSource.EndEdit()
            Me.SignosZodiacalesTableAdapter.Update(Me.PsicologiaDBDataSet.SignosZodiacales)
            Me.Refresh()
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class