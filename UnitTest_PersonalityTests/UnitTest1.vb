Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MySql.Data.MySqlClient 'Libreria para conectarse con MySQL
<TestClass()> Public Class UnitTest1
    Public connection As New MySqlConnection("server=localhost;database=psicologiadb;user=root;password='7910'")
    'Prueba automatizada: 1
    <TestMethod()> Public Sub TestOptionsUser()
        Dim opcion As Integer
        Dim screen As String
        opcion = 3
        Select Case opcion
            Case 1
                'reporte.Show()
                'reporte.lblFecha.Text = DateTime.Now.ToString("dd / MM / yyyy")
                screen = "Reporte"
            Case 2
                'pacientes.Show()
                screen = "Pacientes"
            Case 3
                'signosZodiacales.Show()
                screen = "Signos Zodiacales"
            Case 4
                'antecedentes.Show()
                screen = "Antecedentes"
            Case 5
                'nuevoUsuario.Show()
                'nuevoUsuario.UsuariosBindingSource.AddNew()
                screen = "Nuevo Usuario"
            Case 6
                'usuarios.Show()
                screen = "Usuarios"
            Case 7
                'alimentacion.Show()
                screen = "Alimentación"
            Case 8
                'temperamentos.Show()
                screen = "Temperamentos"
            Case 9
                'conexionBD.Show()
                'connectionDB.conectar()
                screen = "Conexión Data Base"
            Case 10
                'historialDB.Show()
                screen = "Historial Data base"
        End Select
        Console.WriteLine(opcion & " " & screen)
    End Sub
    'Prueba automatizada: 2
    <TestMethod()> Public Sub TestOptionsSignoZodiaco()
        Dim Mes, Signo, Elemento, Planeta, PosiblesProblemas, Personalidad As String
        Dim Dia As Integer
        Mes = "Enero"
        Dia = 12
        If Mes = "Marzo" Then

            If Dia >= 1 And Dia <= 20 Then
                Signo = "Piscis"
                Elemento = "Agua"
                Planeta = "Neptuno y Júpiter"
                PosiblesProblemas = "Dignidad y los pies"
                Personalidad = "Son generosos, aman y perdonan con el corazón, muchas veces "“tragan entero”" y aunque las heridas los marquen de por vida no dejan de confiar en las personas.
Son soñadores, pero hacen muy poco para materializar sus sueños, más bien les gustan los caminos cortos y fáciles y si sus ideas no se concretan con rapidez prefieren abandonarlas antes que trabajar duro por ellas."
            End If

            If Dia >= 21 And Dia <= 31 Then
                Signo = "Aries"
                Elemento = "Fuego"
                Planeta = "Marte"
                PosiblesProblemas = "Acción y cabeza"
                Personalidad = "Visionarios y valientes, los regidos por Aries no se detienen a pensar y masticar el pasado, por el contrario, son casi siempre los primeros en dar el primer paso, incluso a veces, sin pensar en las consecuencias. Son creativos y aportan excelentes ideas cuando trabajan en equipo, pero no les gusta que les den instrucciones, ellos prefieren liderar y difícilmente aceptan órdenes que vengan de otras personas."
            End If

        End If

        If Mes = "Abril" Then

            If Dia >= 1 And Dia <= 19 Then
                Signo = "Aries"
                Elemento = "Fuego"
                Planeta = "Marte"
                PosiblesProblemas = "Acción y cabeza"
                Personalidad = "Visionarios y valientes, los regidos por Aries no se detienen a pensar y masticar el pasado, por el contrario, son casi siempre los primeros en dar el primer paso, incluso a veces, sin pensar en las consecuencias. Son creativos y aportan excelentes ideas cuando trabajan en equipo, pero no les gusta que les den instrucciones, ellos prefieren liderar y difícilmente aceptan órdenes que vengan de otras personas."
            End If

            If Dia >= 20 And Dia <= 30 Then
                Signo = "Tauro"
                Elemento = "Tierra"
                Planeta = "Venus"
                PosiblesProblemas = "Amor, cuello, nuca y oídos"
                Personalidad = "Se caracterizan por ser amables, generosos y desinteresados, son personas en quienes se puede confiar. Son prácticos y se acomodan muy fácil a las circunstancias. Las personas que nacieron bajo la regencia de Tauro prefieren seguir un líder y pasar desapercibidos."
            End If
        End If

        If Mes = "Mayo" Then

            If Dia >= 1 And Dia <= 19 Then
                Signo = "Tauro"
                Elemento = "Tierra"
                Planeta = "Venus"
                PosiblesProblemas = "Amor, cuello, nuca y oídos"
                Personalidad = "Se caracterizan por ser amables, generosos y desinteresados, son personas en quienes se puede confiar. Son prácticos y se acomodan muy fácil a las circunstancias. Las personas que nacieron bajo la regencia de Tauro prefieren seguir un líder y pasar desapercibidos."
            End If

            If Dia >= 20 And Dia <= 31 Then
                Signo = "Geminis"
                Elemento = "Aire"
                Planeta = "Mercurio"
                PosiblesProblemas = "Brazos, hombros y pulmones"
                Personalidad = "Los geminianos, al fin y al cabo, representados por gemelos, suelen actuar según las circunstancias, camaleónicos, se adaptan y cambian conforme lo necesiten, incluso habrá quien los tache de acomodados y hasta hipócritas, máxime porque cambian de humor con mucha facilidad."
            End If
        End If

        If Mes = "Junio" Then
            If Dia >= 1 And Dia <= 20 Then
                Signo = "Geminis"
                Elemento = "Aire"
                Planeta = "Mercurio"
                PosiblesProblemas = "Brazos, hombros y pulmones"
                Personalidad = "Los geminianos, al fin y al cabo, representados por gemelos, suelen actuar según las circunstancias, camaleónicos, se adaptan y cambian conforme lo necesiten, incluso habrá quien los tache de acomodados y hasta hipócritas, máxime porque cambian de humor con mucha facilidad."
            End If

            If Dia >= 21 And Dia <= 30 Then
                Signo = "Cáncer"
                Elemento = "Agua"
                Planeta = "Luna"
                PosiblesProblemas = "Fecundación y estomago"
                Personalidad = "Son completamente sentimentales, expresan todo el tiempo sus emociones, lo que los lleva a escuchar más la intuición que la razón y a ser excelentes artistas. Son hogareños y extremadamente protectores, al nivel de sofocar a quienes los rodean pues intentan controlar todo en sus vidas."
            End If
        End If

        If Mes = "Julio" Then

            If Dia >= 1 And Dia <= 22 Then
                Signo = "Cáncer"
                Elemento = "Agua"
                Planeta = "Luna"
                PosiblesProblemas = "Fecundación y estomago"
                Personalidad = "Son completamente sentimentales, expresan todo el tiempo sus emociones, lo que los lleva a escuchar más la intuición que la razón y a ser excelentes artistas. Son hogareños y extremadamente protectores, al nivel de sofocar a quienes los rodean pues intentan controlar todo en sus vidas."
            End If

            If Dia >= 23 And Dia <= 31 Then
                Signo = "Leo"
                Elemento = "Fuego"
                Planeta = "Sol"
                PosiblesProblemas = "Vida y corazón"
                Personalidad = "Los leo son los reyes, aman el lujo y la buena vida, les encanta ser el centro de atención y ""gobernar"" a todos los que lo rodean. Inteligentes, simpáticos y seguros de sí mismos, conocen sus habilidades y las usan para lograr sus objetivos."
            End If

        End If


        If Mes = "Agosto" Then

            If Dia >= 1 And Dia <= 22 Then
                Signo = "Leo"
                Elemento = "Fuego"
                Planeta = "Sol"
                PosiblesProblemas = "Vida y corazón"
                Personalidad = "Los leo son los reyes, aman el lujo y la buena vida, les encanta ser el centro de atención y ""gobernar"" a todos los que lo rodean. Inteligentes, simpáticos y seguros de sí mismos, conocen sus habilidades y las usan para lograr sus objetivos."
            End If

            If Dia >= 23 And Dia <= 31 Then
                Signo = "Virgo"
                Elemento = "Tierra"
                Planeta = "Mercurio"
                PosiblesProblemas = "Razón, intestinos y bajo bientre"
                Personalidad = "Quienes nacieron bajo el signo de Virgo son excelentes amigos, pacientes y encantadores. Este es otro de los signos más inteligentes que hay en el zodiaco.
Sin embargo, el desorden, la pereza y la procrastinación no permite que los Virgo brillen siempre como se lo merecen y por esto, otras personas se aprovechan de la situación y se llevan los laureles que les correspondía a ellos."

            End If
        End If

        If Mes = "Septiembre" Then
            If Dia >= 1 And Dia <= 22 Then
                Signo = "Virgo"
                Elemento = "Tierra"
                Planeta = "Mercurio"
                PosiblesProblemas = "Razón, intestinos y bajo bientre"
                Personalidad = "Quienes nacieron bajo el signo de Virgo son excelentes amigos, pacientes y encantadores. Este es otro de los signos más inteligentes que hay en el zodiaco.
Sin embargo, el desorden, la pereza y la procrastinación no permite que los Virgo brillen siempre como se lo merecen y por esto, otras personas se aprovechan de la situación y se llevan los laureles que les correspondía a ellos."

            End If

            If Dia >= 23 And Dia <= 30 Then
                Signo = "Libra"
                Elemento = "Aire"
                Planeta = "Venus"
                PosiblesProblemas = "Amor y riñones"
                Personalidad = "Este es tal vez de los signos más amistosos, los regidos por la balanza logran hacer amigos con facilidad y no tiene un segmento para definir sus amistades, desde niños, en la escuela, puede ser amigos de los más pequeños hasta los más grandes y así continúan el resto de sus vidas."

            End If
        End If

        If Mes = "Octubre" Then
            If Dia >= 1 And Dia <= 22 Then
                Signo = "Libra"
                Elemento = "Aire"
                Planeta = "Venus"
                PosiblesProblemas = "Amor y riñones"
                Personalidad = "Este es tal vez de los signos más amistosos, los regidos por la balanza logran hacer amigos con facilidad y no tiene un segmento para definir sus amistades, desde niños, en la escuela, puede ser amigos de los más pequeños hasta los más grandes y así continúan el resto de sus vidas."


            End If

            If Dia >= 23 And Dia <= 31 Then
                Signo = "Escorpio"
                Elemento = "Agua"
                Planeta = "Marte"
                PosiblesProblemas = "Acción y órganos sexuales"
                Personalidad = "La fuerza de voluntad y la tenacidad son los elementos que más caracterizan a los Escorpio y por esta razón es que logran todo lo que se proponen, pues nunca desfallecen y solo abandonan un proyecto cuando ya están seguros que no es lo que están buscando."

            End If
        End If

        If Mes = "Noviembre" Then
            If Dia >= 1 And Dia <= 22 Then
                Signo = "Escorpio"
                Elemento = "Agua"
                Planeta = "Marte"
                PosiblesProblemas = "Acción y órganos sexuales"
                Personalidad = "La fuerza de voluntad y la tenacidad son los elementos que más caracterizan a los Escorpio y por esta razón es que logran todo lo que se proponen, pues nunca desfallecen y solo abandonan un proyecto cuando ya están seguros que no es lo que están buscando."
            End If

            If Dia >= 23 And Dia <= 30 Then
                Signo = "Sagitario"
                Elemento = "Fuego"
                Planeta = "Júpiter"
                PosiblesProblemas = "Benevolencia, caderas y múslos"
                Personalidad = "Honestos, honrados, correctos y trabajadores, quienes están regidos por Sagitario se caracterizan por su honorabilidad, por esta razón, cuando son traicionados o son víctimas de un abuso o injusticia se tornan rencorosos y vengativos. Si bien son tranquilos, cuando los hacen enfadar son muy malhumorados e incluso violentos.
Son muy trabajadores y autodidactas y tienen la capacidad de aprender con facilidad casi cualquier tema, especialmente si tienen que ver con la naturaleza o con proyectos productivos."
            End If
        End If

        If Mes = "Diciembre" Then
            If Dia >= 1 And Dia <= 21 Then
                Signo = "Sagitario"
                Elemento = "Fuego"
                Planeta = "Júpiter"
                PosiblesProblemas = "Benevolencia, caderas y múslos"
                Personalidad = "Honestos, honrados, correctos y trabajadores, quienes están regidos por Sagitario se caracterizan por su honorabilidad, por esta razón, cuando son traicionados o son víctimas de un abuso o injusticia se tornan rencorosos y vengativos. Si bien son tranquilos, cuando los hacen enfadar son muy malhumorados e incluso violentos.
Son muy trabajadores y autodidactas y tienen la capacidad de aprender con facilidad casi cualquier tema, especialmente si tienen que ver con la naturaleza o con proyectos productivos."
            End If

            If Dia >= 22 And Dia <= 31 Then
                Signo = "Capricornio"
                Elemento = "Tierra"
                Planeta = "Saturno"
                PosiblesProblemas = "Obstrucción, rodillas y piel"
                Personalidad = "Los regidos por Capricornio aman la lectura, tienen excelente memoria y son lógicos y racionales, pero sin dejar nunca de lado el romanticismo, pues son unos sentimentales empedernidos.
Son responsables y saben que la palabra se cumple y se respeta, sin embargo, algunos Capricornio mal prospectados tienen una alta tendencia a ser ludópatas y mitómanos, lo que los puede llevar a meterse en muchos problemas."
            End If
        End If

        If Mes = "Enero" Then
            If Dia >= 1 And Dia <= 19 Then
                Signo = "Capricornio"
                Elemento = "Tierra"
                Planeta = "Saturno"
                PosiblesProblemas = "Obstrucción, rodillas y piel"
                Personalidad = "Los regidos por Capricornio aman la lectura, tienen excelente memoria y son lógicos y racionales, pero sin dejar nunca de lado el romanticismo, pues son unos sentimentales empedernidos.
Son responsables y saben que la palabra se cumple y se respeta, sin embargo, algunos Capricornio mal prospectados tienen una alta tendencia a ser ludópatas y mitómanos, lo que los puede llevar a meterse en muchos problemas."
            End If

            If Dia >= 20 And Dia <= 31 Then
                Signo = "Acuario"
                Elemento = "Aire"
                Planeta = "Urano"
                PosiblesProblemas = "Altruismo, pantorrillas y tobillos"
                Personalidad = "Si hay algo que caracteriza a los regidos por Acuario es su terquedad, siempre quieren tener la razón, no admiten argumentos de ningún tipo y la última palabra debe salir de ellos. Aman la soledad, son de pocos amigos y la vida social y las aglomeraciones no son para ellos, pues terminan exaltándose y poniéndose de muy mal humor. La monotonía los afecta hasta los huesos, por eso prefieren trabajos que les exija estar viajando o cambiando de ambiente."
            End If
        End If

        If Mes = "Febrero" Then
            If Dia >= 1 And Dia <= 17 Then
                Signo = "Acuario"
                Elemento = "Aire"
                Planeta = "Urano"
                PosiblesProblemas = "Altruismo, pantorrillas y tobillos"
                Personalidad = "Si hay algo que caracteriza a los regidos por Acuario es su terquedad, siempre quieren tener la razón, no admiten argumentos de ningún tipo y la última palabra debe salir de ellos. Aman la soledad, son de pocos amigos y la vida social y las aglomeraciones no son para ellos, pues terminan exaltándose y poniéndose de muy mal humor. La monotonía los afecta hasta los huesos, por eso prefieren trabajos que les exija estar viajando o cambiando de ambiente."
            End If

            If Dia >= 18 And Dia <= 29 Then
                Signo = "Piscis"
                Elemento = "Agua"
                Planeta = "Neptuno y Júpiter"
                PosiblesProblemas = "Dignidad y los pies"
                Personalidad = "Son generosos, aman y perdonan con el corazón, muchas veces "“tragan entero”" y aunque las heridas los marquen de por vida no dejan de confiar en las personas.
Son soñadores, pero hacen muy poco para materializar sus sueños, más bien les gustan los caminos cortos y fáciles y si sus ideas no se concretan con rapidez prefieren abandonarlas antes que trabajar duro por ellas."
            End If
        End If
        Console.WriteLine(Signo)
        Console.WriteLine(Elemento)
        Console.WriteLine(Planeta)
        Console.WriteLine(PosiblesProblemas)
        Console.WriteLine(Personalidad)
    End Sub

    'Prueba automatizada: 3
    <TestMethod()> Public Sub TestResultadosTemperamentos()
        Dim sanguineo, melancolico, colerico, flematico As Integer
        Dim Descripcion As String
        'Las variables de los temperamentos se igualan a los puntajes obtenidos
        sanguineo = 50
        melancolico = 55
        colerico = 80
        flematico = 100

        'Se compara si sanguineo es el mayor
        If (sanguineo > melancolico) And (sanguineo > colerico) And (sanguineo > flematico) Then
            Descripcion = "Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas."
        End If

        'Se compara si melancolico es el mayor
        If (melancolico > sanguineo) And (melancolico > colerico) And (melancolico > flematico) Then
            Descripcion = "Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas."
        End If

        'Se compara si colerico es el mayor
        If (colerico > sanguineo) And (colerico > melancolico) And (colerico > flematico) Then
            Descripcion = "Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si colerico es el mayor
        If (flematico > sanguineo) And (flematico > melancolico) And (flematico > colerico) Then
            Descripcion = "Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Para empate de dos temperamenteos altos
        'Se compara si sanguineo y melancolico son los mayores
        If (sanguineo = melancolico) And (sanguineo > colerico) And (sanguineo > flematico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas."
        End If

        'Se compara si sanguineo y colerico son los mayores
        If (sanguineo = colerico) And (sanguineo > melancolico) And (sanguineo > flematico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si sanguineo y flematico son los mayores
        If (sanguineo = flematico) And (sanguineo > melancolico) And (sanguineo > colerico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si melancolico y colericoco son los mayores
        If (melancolico = colerico) And (melancolico > sanguineo) And (melancolico > flematico) Then
            Descripcion = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si melancolico y flematico son los mayores
        If (melancolico = flematico) And (melancolico > sanguineo) And (melancolico > colerico) Then
            Descripcion = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si colerico y flematico son los mayores
        If (colerico = flematico) And (colerico > sanguineo) And (colerico > melancolico) Then
            Descripcion = "- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son sanguineo, melancolico y colerico
        If (sanguineo = melancolico) And (sanguineo = colerico) And (sanguineo > flematico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente."
        End If

        'Se compara si las mayores son sanguineo, melancolico y flematico
        If (sanguineo = melancolico) And (sanguineo = flematico) And (sanguineo > colerico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son sanguineo, colerico y flematico
        If (sanguineo = colerico) And (sanguineo = flematico) And (sanguineo > melancolico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Se compara si las mayores son melancolico, colerico y flematico
        If (melancolico = colerico) And (melancolico = flematico) And (melancolico > sanguineo) Then
            Descripcion = "- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If

        'Todos los temperamentos son altos
        If (sanguineo = melancolico) And (sanguineo = colerico) And (sanguineo = flematico) Then
            Descripcion = "- Sanguíneo: alegre, optimista y en busqueda siempre de la compañia de los demas.
- Melancólico: Emocionalmente sensible, creativas, introvertidas, abnegadas y perfeccionistas.
- Colérico: Enérgico, proactivo e independiente.
- Flemático: Propensión a comportarse de un modo sereno, tranquilo y un modode acercarse a las metas perseverante y basado en la racionalidad."
        End If
        Console.WriteLine(Descripcion)
    End Sub

    'Prueba automatizada: 4
    <TestMethod()> Public Sub TestResultadosAlimentacion()
        Dim rayasico, tamasico, satvico As String
        Dim Descripcion As String
        rayasico = 50
        tamasico = 95
        satvico = 95

        If rayasico > tamasico And rayasico > satvico Then
            Descripcion = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)."
        End If

        If tamasico > rayasico And tamasico > satvico Then
            Descripcion = "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If satvico > rayasico And satvico > tamasico Then
            Descripcion = "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If

        If rayasico = tamasico And rayasico > satvico And tamasico > satvico Then
            Descripcion = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If rayasico = satvico And rayasico > tamasico And satvico > tamasico Then
            Descripcion = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If

        If satvico = tamasico And satvico > rayasico And tamasico > rayasico Then
            Descripcion = "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)."
        End If

        If satvico = tamasico And tamasico = rayasico Then
            Descripcion = "Rayasicos: Alimentación irritante, son personas viserales, crea apegos y pasión (actividad)." & vbCrLf & "Tamasicos: Alimentación grasosa y recalentada, adormece la mente, los sentidos y lleva a la calma (obscuridad y destrucción)." & vbCrLf & "Satvicos: Alimentación buena y sana para la salud, beneficia la salud mental y la memoria (espiritualidad)."
        End If

        Console.WriteLine(Descripcion)
    End Sub

    'Prueba automatizada: 5
    <TestMethod()> Public Sub TestOpcionesPacientes()
        Dim estado, opcion As Integer
        estado = 2
        opcion = 2
        If estado = 1 Then
            Console.WriteLine("Debe iniciar sesión primero antes de realizar este test.")
        ElseIf estado = 2 Then
            Select Case opcion
                Case 1
                    'TestsSignosZodiaco.Show()
                    'TestsSignosZodiaco.SignoszodiacalesBindingSource.AddNew()
                    'TestsSignosZodiaco.MatriculaTextBox.Text = matricula
                    Console.WriteLine("Test Signos Zodiacales.")
                Case 2
                    'CuestionarioRayasicos.Show()
                    Console.WriteLine("Test Alimentacion.")
                Case 3
                    'cuestionario_sanguineo.Show()
                    Console.WriteLine("Test Temperamentos.")
                Case 4
                    'historialPaciente.Show()
                    'historialPaciente.HistorialpacienteBindingSource.AddNew()
                    'historialPaciente.MatriculaTextBox.Text = matricula
                    'historialPaciente.FechaDateTimePicker.Value = DateTime.Now()
                    Console.WriteLine("Test Historial Del Paciente.")
            End Select
        End If
    End Sub

    'Prueba automatizada: 6
    <TestMethod()> Public Sub TestConectionDB()
        Dim informationDB As String
        Try
            'Se inicia la conexion con la base de datos
            connection.Open()
            informationDB = "La conexión con la base de datos esta establecida de forma correcta."
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Error.")
            informationDB = ex.Message

        Finally
            Console.WriteLine(informationDB)
            If connection.State = ConnectionState.Open Then
                connection.Close() 'Cierra la conexion con la base de datos
            End If
        End Try
    End Sub

    'Prueba automatizada: 7
    <TestMethod()> Public Sub TestCalculoFlematico()
        Dim respuestas, puntajeFlematico, contador, mediosPuntos As Integer
        respuestas = 6
        contador = 4
        mediosPuntos = 1

        'Si todas las preguntas son respondidas se podra avanzar al siguiente cuestionario
        If respuestas >= 6 Then
            puntajeFlematico = ((contador + mediosPuntos) / 6) * 100
            'Me.Hide()
            'resultados_temperamentos.Show()
            'resultados_temperamentos.TemperamentosTableAdapter.Fill(resultados_temperamentos.PsicologiadbDataSet.temperamentos)
            'resultados_temperamentos.TemperamentosBindingSource.AddNew()
            'resultados_temperamentos.MatriculaTextBox.Text = MenuPrincipal.matricula
            Console.WriteLine(puntajeFlematico)
        ElseIf respuestas < 6 Then
            contador = 0
            Console.WriteLine("Falta contestar una o mas preguntas.")
        End If
    End Sub

    'Prueba automatizada: 8
    <TestMethod()> Public Sub TestSumarPuntos()
        Dim total, mediosPuntos As Double
        Dim contador As Integer
        Dim ResCorrecta1, ResCorrecta2, ResCorrecta3, ResCorrecta4, ResCorrecta5, ResCorrecta6, masMenos1, masMenos2, masMenos3, masMenos4, masMenos5, masMenos6 As Boolean

        ResCorrecta1 = True
        ResCorrecta2 = True
        ResCorrecta3 = True
        ResCorrecta4 = False
        ResCorrecta5 = False
        ResCorrecta6 = False

        masMenos1 = False
        masMenos2 = False
        masMenos3 = False
        masMenos4 = False
        masMenos5 = True
        masMenos6 = True

        If ResCorrecta1 = True Then
            contador = contador + 1
        End If

        If ResCorrecta2 = True Then
            contador = contador + 1
        End If

        If ResCorrecta3 = True Then
            contador = contador + 1
        End If

        If ResCorrecta4 = True Then
            contador = contador + 1
        End If

        If ResCorrecta5 = True Then
            contador = contador + 1
        End If

        If ResCorrecta6 = True Then
            contador = contador + 1
        End If

        'Validacion de puntos medios
        If masMenos1 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If masMenos2 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If masMenos3 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If masMenos4 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If masMenos5 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        If masMenos6 = True Then
            mediosPuntos = mediosPuntos + 0.5
        End If

        total = contador + mediosPuntos

        Console.WriteLine("Puntos totales: " & total)
    End Sub
End Class