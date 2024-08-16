Public Class TestsSignosZodiaco

    Private Sub TestsSignosZodiaco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.signoszodiacales' Puede moverla o quitarla según sea necesario.
        'Me.SignoszodiacalesTableAdapter.Fill(Me.PsicologiadbDataSet.signoszodiacales)
        desactivarImagenes()
        ImgSignos.Visible = True
    End Sub

    Private Sub desactivarImagenes()
        ImgSignoAries.Visible = False
        ImgSignoTauro.Visible = False
        ImgSignoGeminis.Visible = False
        ImgSignoCancer.Visible = False
        ImgSignoLeo.Visible = False
        ImgSignoVirgo.Visible = False
        ImgSignoLibra.Visible = False
        ImgSignoEscorpio.Visible = False
        ImgSignoSagitario.Visible = False
        ImgSignoCapricornio.Visible = False
        ImgSignoAcuario.Visible = False
        ImgSignoPiscis.Visible = False
        ImgSignos.Visible = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If MesComboBox.Text = "Marzo" Then

            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 20 Then
                SignoTextBox.Text = "Piscis"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Neptuno y Júpiter"
                PosiblesProblemasTextBox.Text = "Dignidad y los pies"
                PersonalidadTextBox.Text = "Son generosos, aman y perdonan con el corazón, muchas veces "“tragan entero”" y aunque las heridas los marquen de por vida no dejan de confiar en las personas.
Son soñadores, pero hacen muy poco para materializar sus sueños, más bien les gustan los caminos cortos y fáciles y si sus ideas no se concretan con rapidez prefieren abandonarlas antes que trabajar duro por ellas."
                desactivarImagenes()
                ImgSignoPiscis.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 21 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Aries"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Marte"
                PosiblesProblemasTextBox.Text = "Acción y cabeza"
                desactivarImagenes()
                PersonalidadTextBox.Text = "Visionarios y valientes, los regidos por Aries no se detienen a pensar y masticar el pasado, por el contrario, son casi siempre los primeros en dar el primer paso, incluso a veces, sin pensar en las consecuencias. Son creativos y aportan excelentes ideas cuando trabajan en equipo, pero no les gusta que les den instrucciones, ellos prefieren liderar y difícilmente aceptan órdenes que vengan de otras personas."
                ImgSignoAries.Visible = True
            End If

        End If

        If MesComboBox.Text = "Abril" Then

            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 19 Then
                SignoTextBox.Text = "Aries"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Marte"
                PosiblesProblemasTextBox.Text = "Acción y cabeza"
                PersonalidadTextBox.Text = "Visionarios y valientes, los regidos por Aries no se detienen a pensar y masticar el pasado, por el contrario, son casi siempre los primeros en dar el primer paso, incluso a veces, sin pensar en las consecuencias. Son creativos y aportan excelentes ideas cuando trabajan en equipo, pero no les gusta que les den instrucciones, ellos prefieren liderar y difícilmente aceptan órdenes que vengan de otras personas."
                desactivarImagenes()
                ImgSignoAries.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 20 And Val(DiaComboBox.Text) <= 30 Then
                SignoTextBox.Text = "Tauro"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Venus"
                PosiblesProblemasTextBox.Text = "Amor, cuello, nuca y oídos"
                PersonalidadTextBox.Text = "Se caracterizan por ser amables, generosos y desinteresados, son personas en quienes se puede confiar. Son prácticos y se acomodan muy fácil a las circunstancias. Las personas que nacieron bajo la regencia de Tauro prefieren seguir un líder y pasar desapercibidos."
                desactivarImagenes()
                ImgSignoTauro.Visible = True
            End If
        End If

        If MesComboBox.Text = "Mayo" Then

            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 19 Then
                SignoTextBox.Text = "Tauro"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Venus"
                PosiblesProblemasTextBox.Text = "Amor, cuello, nuca y oídos"
                PersonalidadTextBox.Text = "Se caracterizan por ser amables, generosos y desinteresados, son personas en quienes se puede confiar. Son prácticos y se acomodan muy fácil a las circunstancias. Las personas que nacieron bajo la regencia de Tauro prefieren seguir un líder y pasar desapercibidos."
                desactivarImagenes()
                ImgSignoTauro.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 20 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Geminis"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Mercurio"
                PosiblesProblemasTextBox.Text = "Brazos, hombros y pulmones"
                PersonalidadTextBox.Text = "Los geminianos, al fin y al cabo, representados por gemelos, suelen actuar según las circunstancias, camaleónicos, se adaptan y cambian conforme lo necesiten, incluso habrá quien los tache de acomodados y hasta hipócritas, máxime porque cambian de humor con mucha facilidad."
                desactivarImagenes()
                ImgSignoGeminis.Visible = True
            End If
        End If

        If MesComboBox.Text = "Junio" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 20 Then
                SignoTextBox.Text = "Geminis"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Mercurio"
                PosiblesProblemasTextBox.Text = "Brazos, hombros y pulmones"
                PersonalidadTextBox.Text = "Los geminianos, al fin y al cabo, representados por gemelos, suelen actuar según las circunstancias, camaleónicos, se adaptan y cambian conforme lo necesiten, incluso habrá quien los tache de acomodados y hasta hipócritas, máxime porque cambian de humor con mucha facilidad."
                desactivarImagenes()
                ImgSignoGeminis.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 21 And Val(DiaComboBox.Text) <= 30 Then
                SignoTextBox.Text = "Cáncer"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Luna"
                PosiblesProblemasTextBox.Text = "Fecundación y estomago"
                PersonalidadTextBox.Text = "Son completamente sentimentales, expresan todo el tiempo sus emociones, lo que los lleva a escuchar más la intuición que la razón y a ser excelentes artistas. Son hogareños y extremadamente protectores, al nivel de sofocar a quienes los rodean pues intentan controlar todo en sus vidas."
                desactivarImagenes()
                ImgSignoCancer.Visible = True
            End If
        End If

        If MesComboBox.Text = "Julio" Then

            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 22 Then
                SignoTextBox.Text = "Cáncer"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Luna"
                PosiblesProblemasTextBox.Text = "Fecundación y estomago"
                PersonalidadTextBox.Text = "Son completamente sentimentales, expresan todo el tiempo sus emociones, lo que los lleva a escuchar más la intuición que la razón y a ser excelentes artistas. Son hogareños y extremadamente protectores, al nivel de sofocar a quienes los rodean pues intentan controlar todo en sus vidas."
                desactivarImagenes()
                ImgSignoCancer.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 23 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Leo"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Sol"
                PosiblesProblemasTextBox.Text = "Vida y corazón"
                PersonalidadTextBox.Text = "Los leo son los reyes, aman el lujo y la buena vida, les encanta ser el centro de atención y ""gobernar"" a todos los que lo rodean. Inteligentes, simpáticos y seguros de sí mismos, conocen sus habilidades y las usan para lograr sus objetivos."
                desactivarImagenes()
                ImgSignoLeo.Visible = True
            End If

        End If


        If MesComboBox.Text = "Agosto" Then

            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 22 Then
                SignoTextBox.Text = "Leo"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Sol"
                PosiblesProblemasTextBox.Text = "Vida y corazón"
                PersonalidadTextBox.Text = "Los leo son los reyes, aman el lujo y la buena vida, les encanta ser el centro de atención y ""gobernar"" a todos los que lo rodean. Inteligentes, simpáticos y seguros de sí mismos, conocen sus habilidades y las usan para lograr sus objetivos."
                desactivarImagenes()
                ImgSignoLeo.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 23 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Virgo"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Mercurio"
                PosiblesProblemasTextBox.Text = "Razón, intestinos y bajo bientre"
                PersonalidadTextBox.Text = "Quienes nacieron bajo el signo de Virgo son excelentes amigos, pacientes y encantadores. Este es otro de los signos más inteligentes que hay en el zodiaco.
Sin embargo, el desorden, la pereza y la procrastinación no permite que los Virgo brillen siempre como se lo merecen y por esto, otras personas se aprovechan de la situación y se llevan los laureles que les correspondía a ellos."
                desactivarImagenes()
                ImgSignoVirgo.Visible = True
            End If
        End If

        If MesComboBox.Text = "Septiembre" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 22 Then
                SignoTextBox.Text = "Virgo"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Mercurio"
                PosiblesProblemasTextBox.Text = "Razón, intestinos y bajo bientre"
                PersonalidadTextBox.Text = "Quienes nacieron bajo el signo de Virgo son excelentes amigos, pacientes y encantadores. Este es otro de los signos más inteligentes que hay en el zodiaco.
Sin embargo, el desorden, la pereza y la procrastinación no permite que los Virgo brillen siempre como se lo merecen y por esto, otras personas se aprovechan de la situación y se llevan los laureles que les correspondía a ellos."
                desactivarImagenes()
                ImgSignoVirgo.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 23 And Val(DiaComboBox.Text) <= 30 Then
                SignoTextBox.Text = "Libra"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Venus"
                PosiblesProblemasTextBox.Text = "Amor y riñones"
                PersonalidadTextBox.Text = "Este es tal vez de los signos más amistosos, los regidos por la balanza logran hacer amigos con facilidad y no tiene un segmento para definir sus amistades, desde niños, en la escuela, puede ser amigos de los más pequeños hasta los más grandes y así continúan el resto de sus vidas."
                desactivarImagenes()
                ImgSignoLibra.Visible = True
            End If
        End If

        If MesComboBox.Text = "Octubre" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 22 Then
                SignoTextBox.Text = "Libra"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Venus"
                PosiblesProblemasTextBox.Text = "Amor y riñones"
                PersonalidadTextBox.Text = "Este es tal vez de los signos más amistosos, los regidos por la balanza logran hacer amigos con facilidad y no tiene un segmento para definir sus amistades, desde niños, en la escuela, puede ser amigos de los más pequeños hasta los más grandes y así continúan el resto de sus vidas."
                desactivarImagenes()
                ImgSignoLibra.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 23 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Escorpio"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Marte"
                PosiblesProblemasTextBox.Text = "Acción y órganos sexuales"
                PersonalidadTextBox.Text = "La fuerza de voluntad y la tenacidad son los elementos que más caracterizan a los Escorpio y por esta razón es que logran todo lo que se proponen, pues nunca desfallecen y solo abandonan un proyecto cuando ya están seguros que no es lo que están buscando."
                desactivarImagenes()
                ImgSignoEscorpio.Visible = True
            End If
        End If

        If MesComboBox.Text = "Noviembre" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 22 Then
                SignoTextBox.Text = "Escorpio"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Marte"
                PosiblesProblemasTextBox.Text = "Acción y órganos sexuales"
                PersonalidadTextBox.Text = "La fuerza de voluntad y la tenacidad son los elementos que más caracterizan a los Escorpio y por esta razón es que logran todo lo que se proponen, pues nunca desfallecen y solo abandonan un proyecto cuando ya están seguros que no es lo que están buscando."
                desactivarImagenes()
                ImgSignoEscorpio.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 23 And Val(DiaComboBox.Text) <= 30 Then
                SignoTextBox.Text = "Sagitario"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Júpiter"
                PosiblesProblemasTextBox.Text = "Benevolencia, caderas y múslos"
                PersonalidadTextBox.Text = "Honestos, honrados, correctos y trabajadores, quienes están regidos por Sagitario se caracterizan por su honorabilidad, por esta razón, cuando son traicionados o son víctimas de un abuso o injusticia se tornan rencorosos y vengativos. Si bien son tranquilos, cuando los hacen enfadar son muy malhumorados e incluso violentos.
Son muy trabajadores y autodidactas y tienen la capacidad de aprender con facilidad casi cualquier tema, especialmente si tienen que ver con la naturaleza o con proyectos productivos."
                desactivarImagenes()
                ImgSignoSagitario.Visible = True
            End If
        End If

        If MesComboBox.Text = "Diciembre" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 21 Then
                SignoTextBox.Text = "Sagitario"
                ElementoTextBox.Text = "Fuego"
                PlanetaTextBox.Text = "Júpiter"
                PosiblesProblemasTextBox.Text = "Benevolencia, caderas y múslos"
                PersonalidadTextBox.Text = "Honestos, honrados, correctos y trabajadores, quienes están regidos por Sagitario se caracterizan por su honorabilidad, por esta razón, cuando son traicionados o son víctimas de un abuso o injusticia se tornan rencorosos y vengativos. Si bien son tranquilos, cuando los hacen enfadar son muy malhumorados e incluso violentos.
Son muy trabajadores y autodidactas y tienen la capacidad de aprender con facilidad casi cualquier tema, especialmente si tienen que ver con la naturaleza o con proyectos productivos."
                desactivarImagenes()
                ImgSignoSagitario.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 22 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Capricornio"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Saturno"
                PosiblesProblemasTextBox.Text = "Obstrucción, rodillas y piel"
                PersonalidadTextBox.Text = "Los regidos por Capricornio aman la lectura, tienen excelente memoria y son lógicos y racionales, pero sin dejar nunca de lado el romanticismo, pues son unos sentimentales empedernidos.
Son responsables y saben que la palabra se cumple y se respeta, sin embargo, algunos Capricornio mal prospectados tienen una alta tendencia a ser ludópatas y mitómanos, lo que los puede llevar a meterse en muchos problemas."
                desactivarImagenes()
                ImgSignoCapricornio.Visible = True
            End If
        End If

        If MesComboBox.Text = "Enero" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 19 Then
                SignoTextBox.Text = "Capricornio"
                ElementoTextBox.Text = "Tierra"
                PlanetaTextBox.Text = "Saturno"
                PosiblesProblemasTextBox.Text = "Obstrucción, rodillas y piel"
                PersonalidadTextBox.Text = "Los regidos por Capricornio aman la lectura, tienen excelente memoria y son lógicos y racionales, pero sin dejar nunca de lado el romanticismo, pues son unos sentimentales empedernidos.
Son responsables y saben que la palabra se cumple y se respeta, sin embargo, algunos Capricornio mal prospectados tienen una alta tendencia a ser ludópatas y mitómanos, lo que los puede llevar a meterse en muchos problemas."
                desactivarImagenes()
                ImgSignoCapricornio.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 20 And Val(DiaComboBox.Text) <= 31 Then
                SignoTextBox.Text = "Acuario"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Urano"
                PosiblesProblemasTextBox.Text = "Altruismo, pantorrillas y tobillos"
                PersonalidadTextBox.Text = "Si hay algo que caracteriza a los regidos por Acuario es su terquedad, siempre quieren tener la razón, no admiten argumentos de ningún tipo y la última palabra debe salir de ellos. Aman la soledad, son de pocos amigos y la vida social y las aglomeraciones no son para ellos, pues terminan exaltándose y poniéndose de muy mal humor. La monotonía los afecta hasta los huesos, por eso prefieren trabajos que les exija estar viajando o cambiando de ambiente."
                desactivarImagenes()
                ImgSignoAcuario.Visible = True
            End If
        End If

        If MesComboBox.Text = "Febrero" Then
            If Val(DiaComboBox.Text) >= 1 And Val(DiaComboBox.Text) <= 17 Then
                SignoTextBox.Text = "Acuario"
                ElementoTextBox.Text = "Aire"
                PlanetaTextBox.Text = "Urano"
                PosiblesProblemasTextBox.Text = "Altruismo, pantorrillas y tobillos"
                PersonalidadTextBox.Text = "Si hay algo que caracteriza a los regidos por Acuario es su terquedad, siempre quieren tener la razón, no admiten argumentos de ningún tipo y la última palabra debe salir de ellos. Aman la soledad, son de pocos amigos y la vida social y las aglomeraciones no son para ellos, pues terminan exaltándose y poniéndose de muy mal humor. La monotonía los afecta hasta los huesos, por eso prefieren trabajos que les exija estar viajando o cambiando de ambiente."
                desactivarImagenes()
                ImgSignoAcuario.Visible = True
            End If

            If Val(DiaComboBox.Text) >= 18 And Val(DiaComboBox.Text) <= 29 Then
                SignoTextBox.Text = "Piscis"
                ElementoTextBox.Text = "Agua"
                PlanetaTextBox.Text = "Neptuno y Júpiter"
                PosiblesProblemasTextBox.Text = "Dignidad y los pies"
                PersonalidadTextBox.Text = "Son generosos, aman y perdonan con el corazón, muchas veces "“tragan entero”" y aunque las heridas los marquen de por vida no dejan de confiar en las personas.
Son soñadores, pero hacen muy poco para materializar sus sueños, más bien les gustan los caminos cortos y fáciles y si sus ideas no se concretan con rapidez prefieren abandonarlas antes que trabajar duro por ellas."
                desactivarImagenes()
                ImgSignoPiscis.Visible = True
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            MsgBox("Se ha cancelado el registro y no se guardo, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Me.Close()
            Me.SignoszodiacalesBindingSource.CancelEdit()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.SignoszodiacalesBindingSource.EndEdit()
            Me.SignoszodiacalesTableAdapter.Update(Me.PsicologiadbDataSet.signoszodiacales)
            Me.Refresh()
            MsgBox("Se ha guardado con exito, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class