Public Class MenuPrincipal
    Public pacient, eleccion As Integer
    'Salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
    'Accesos de pacientes
    Private Sub BtnPacientes_Click(sender As Object, e As EventArgs) Handles BtnPacientes.Click
        RegistrarPaciente.Show()
        RegistrarPaciente.PacientesBindingSource.AddNew()
    End Sub

    Private Sub BtnTemperamentos_Click(sender As Object, e As EventArgs) Handles BtnTemperamentos.Click
        pacient = 1
        AccesoPacientes.Show()
    End Sub

    Private Sub BtnAlimentacion_Click(sender As Object, e As EventArgs) Handles BtnAlimentacion.Click
        pacient = 2
        AccesoPacientes.Show()
    End Sub

    Private Sub BtnAntecedentes_Click(sender As Object, e As EventArgs) Handles BtnAntecedentes.Click
        pacient = 3
        AccesoPacientes.Show()
    End Sub
    Private Sub BtnSignosZodiaco_Click(sender As Object, e As EventArgs) Handles BtnSignosZodiaco.Click
        pacient = 4
        AccesoPacientes.Show()
    End Sub
    'Accesos de usuario
    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        eleccion = 1
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        eleccion = 2
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub
    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        eleccion = 3
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub

    Private Sub TemperamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperamentosToolStripMenuItem.Click
        eleccion = 4
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub
    Private Sub AlimentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlimentaciónToolStripMenuItem.Click
        eleccion = 5
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub
    Private Sub SignosZodiacalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignosZodiacalesToolStripMenuItem.Click
        eleccion = 6
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub
    Private Sub AntecedentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntecedentesToolStripMenuItem.Click
        eleccion = 7
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        eleccion = 8
        Login.Show()
        Login.UsuarioTxt.Focus()
    End Sub
End Class
