Public Class RegistroPaciente
    Dim matricula, parte1, parte2, user, fecha As String

    Private Sub RegistroPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.Fill(Me.PsicologiadbDataSet.bitacora)
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.PsicologiadbDataSet.pacientes)

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged
        generarMatricula()
    End Sub

    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonoTextBox.TextChanged
        generarMatricula()
    End Sub

    'Metodo para generar la matricula del paciente toma el numero telefonico del paciente y
    'toma la primera letra de su nombre
    Private Sub generarMatricula()
        parte1 = TelefonoTextBox.Text
        parte2 = (Mid(NombreTextBox.Text, 1, 1))
        matricula = parte1 & parte2
        MatriculaTextBox.Text = matricula
    End Sub

    'Cancelación del registro
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            MsgBox("Registro de paciente cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar.")
            Me.PacientesBindingSource.CancelEdit()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    'Guardado del registro
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
            fecha = Now
            user = PantallaCarga.user
            Me.BitacoraTableAdapter.insertarRegistro(user, "Pacientes", "Nuevo paciente", fecha)

            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.PacientesTableAdapter.Update(Me.PsicologiadbDataSet.pacientes)
            Me.Refresh()

            MsgBox("El paciente se ha registrado de forma exitosa, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub
End Class