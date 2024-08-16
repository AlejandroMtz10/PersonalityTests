Public Class MenuPrincipal
    Public opcion, estado As Integer
    Dim fecha As String
    Public user, matricula As String

    Private Sub BtnPantallaCarga_Click(sender As Object, e As EventArgs) Handles BtnPantallaCarga.Click
        'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
        fecha = Now
        user = PantallaCarga.user
        Me.BitacoraTableAdapter.insertarRegistro(user, "Menú principal", "Cierre de sesión", fecha)

        Me.Close()
        PantallaCarga.Show()
    End Sub
    'Metodo con el que cirra todo el programa desde el menu principal
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
        fecha = Now
        user = PantallaCarga.user
        Me.BitacoraTableAdapter.insertarRegistro(user, "Menú principal", "Cierre de sesión", fecha)

        End
    End Sub

    Private Sub BtnRegistrarPaciente_Click(sender As Object, e As EventArgs) Handles BtnRegistrarPaciente.Click
        RegistroPaciente.Show()
        RegistroPaciente.PacientesBindingSource.AddNew()
    End Sub

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        If estado = 1 Then

            loginPaciente.Show()

        ElseIf estado = 2 Then

            If MsgBox("¿Quiere cerrar su sesión?", vbYesNoCancel, "Cerrar sesión.") = vbYes Then
                estado = 1
                loginPaciente.Close()
                LblPaciente.Text = "No hay paciente activo."
            End If

        End If
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estado = 1
    End Sub
    Private Sub tests()
        If estado = 1 Then
            MsgBox("Debe iniciar sesión primero antes de realizar este test.", vbCritical, "Error.")
        ElseIf estado = 2 Then
            matricula = loginPaciente.matricula
            Select Case opcion
                Case 1
                    TestsSignosZodiaco.Show()
                    TestsSignosZodiaco.SignoszodiacalesBindingSource.AddNew()
                    TestsSignosZodiaco.MatriculaTextBox.Text = matricula
                Case 2
                    CuestionarioRayasicos.Show()
                Case 3
                    cuestionario_sanguineo.Show()
                Case 4
                    historialPaciente.Show()
                    historialPaciente.HistorialpacienteBindingSource.AddNew()
                    historialPaciente.MatriculaTextBox.Text = matricula
                    historialPaciente.FechaDateTimePicker.Value = DateTime.Now()
            End Select
        End If
    End Sub
    Private Sub BtnSignosZodiacales_Click(sender As Object, e As EventArgs) Handles BtnSignosZodiacales.Click
        opcion = 1
        tests()
    End Sub

    Private Sub BtnAlimenteación_Click(sender As Object, e As EventArgs) Handles BtnAlimenteación.Click
        opcion = 2
        tests()
    End Sub

    Private Sub BtnTemperamentos_Click(sender As Object, e As EventArgs) Handles BtnTemperamentos.Click
        opcion = 3
        tests()
    End Sub

    Private Sub BtnAntecedentes_Click(sender As Object, e As EventArgs) Handles BtnAntecedentes.Click
        opcion = 4
        tests()
    End Sub



    '----------------------------------------------------------------------------------------------------------------------------------------

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 1
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 2
    End Sub

    Private Sub SignosZodiacalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignosZodiacalesToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 3
    End Sub

    Private Sub AntecedentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntecedentesToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 4
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 5
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 6
    End Sub

    Private Sub AlimenteciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlimenteciónToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 7
    End Sub

    Private Sub TemperamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperamentosToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 8
    End Sub

    Private Sub ConexiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexiónToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 9
    End Sub


    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        loginUsuario.Show()
        loginUsuario.lblUsuario.Text = PantallaCarga.user
        loginUsuario.opcion = 10
    End Sub
End Class