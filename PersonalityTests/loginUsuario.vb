Public Class loginUsuario
    Public opcion As Integer
    Public user As String


    'Metodo para poder ver la contrseña o no verla
    Private Sub CheckBoxViewPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxViewPassword.CheckedChanged
        If CheckBoxViewPassword.Checked = True Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
        TxtPassword.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ingresar()
    End Sub

    'Ingreso dando enter en el login
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ingresar()
        End Select
    End Sub

    'Metodo para ingresar
    Private Sub ingresar()
        Dim nTotal As Byte

        nTotal = UsuariosTableAdapter.LoginUsuario(lblUsuario.Text, TxtPassword.Text)

        If nTotal = 1 Then
            Me.Hide()
            TxtPassword.Clear()
            CheckBoxViewPassword.Checked = False
            user = lblUsuario.Text
            Select Case opcion
                Case 1
                    reporte.Show()
                    reporte.lblFecha.Text = DateTime.Now.ToString("dd / MM / yyyy")
                Case 2
                    pacientes.Show()
                Case 3
                    signosZodiacales.Show()
                Case 4
                    antecedentes.Show()
                Case 5
                    nuevoUsuario.Show()
                    nuevoUsuario.UsuariosBindingSource.AddNew()
                Case 6
                    usuarios.Show()
                Case 7
                    alimentacion.Show()
                Case 8
                    temperamentos.Show()
                Case 9
                    conexionBD.Show()
                    connectionDB.conectar()
                Case 10
                    historialDB.Show()
            End Select

        Else
            MsgBox("El usuario o la contraseña son invalidos.", vbCritical, "Credenciales no validas")
            TxtPassword.Clear()
        End If
    End Sub
End Class