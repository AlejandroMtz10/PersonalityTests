Public Class loginPaciente
    Public matricula As String
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        MenuPrincipal.estado = 1
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim nTotal As Byte
        Dim nombre, apellidos As String
        nTotal = PacientesTableAdapter.loginPacientes(TxtMatricula.Text)

        If nTotal = 1 Then
            nombre = PacientesTableAdapter.recuperarNombre(TxtMatricula.Text)
            apellidos = PacientesTableAdapter.recuperarApellidos(TxtMatricula.Text)
            matricula = TxtMatricula.Text

            Me.Hide()
            MenuPrincipal.LblPaciente.Text = nombre + " " + apellidos
            MenuPrincipal.estado = 2
        Else
            MsgBox("La matrícula no existe en la base de datos, recuerda que la matrícula es tu número teléfonico y la primera letra de tu nombre.", vbCritical, "Matrícula incorrecta.")
            TxtMatricula.Clear()
        End If
    End Sub
End Class