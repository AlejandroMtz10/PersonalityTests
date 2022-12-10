Public Class RegistrarPaciente
    Dim matricula, parte1, parte2 As String
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            MsgBox("Registro de paciente cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Me.PacientesBindingSource.CancelEdit()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.PacientesTableAdapter.Update(Me.PsicologiaDBDataSet.Pacientes)
            Me.Refresh()

            MsgBox("El paciente se ha guardado, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoTextBox.TextChanged
        generarMatricula()
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        generarMatricula()
    End Sub

    Private Sub generarMatricula()
        parte1 = TelefonoTextBox.Text
        parte2 = (Mid(NombreTextBox.Text, 1, 1))
        matricula = parte1 + parte2
        MatriculaTextBox.Text = matricula
    End Sub
End Class