Public Class AccesoPacientes
    Public opcion As Integer
    Public idPatient As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("La matricula esta compuesta por tu numero telefonico y la primera letra de tu nombre, si no estas registrado primero deben registrarte como paciente.", vbInformation, "Información sobre la matricula.")
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        ingresar()
    End Sub

    Private Sub ingresar()
        Dim nTotal As Byte

        opcion = MenuPrincipal.pacient
        nTotal = PacientesTableAdapter.LoginPaciente(MatriculaTxt.Text, NombreTxt.Text)

        If nTotal = 1 Then
            idPatient = MatriculaTxt.Text
            Me.Hide()
            Select Case opcion
                Case 1
                    CuestionarioSanguineo.Show()
                Case 2
                    CuestionarioRayasicos.Show()
                Case 3
                    CuestionarioAntecedentes.Show()
                    CuestionarioAntecedentes.HistorialPacienteTableAdapter.Fill(CuestionarioAntecedentes.PsicologiaDBDataSet.HistorialPaciente)
                    CuestionarioAntecedentes.HistorialPacienteBindingSource.AddNew()
                    CuestionarioAntecedentes.MatriculaTextBox.Text = idPatient
                Case 4
                    CuestionarioSignosZodiacales.Show()
                    CuestionarioSignosZodiacales.SignosZodiacalesBindingSource.AddNew()
                    CuestionarioSignosZodiacales.MatriculaTextBox.Text = idPatient
            End Select
            LimpiarTxts()
        Else
            MsgBox("La matricula o su nombre son incorrectos.", vbCritical, "Credenciales no validas")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        LimpiarTxts()
        Me.Close()
    End Sub

    Public Sub LimpiarTxts()
        MatriculaTxt.Clear()
        NombreTxt.Clear()
    End Sub

End Class