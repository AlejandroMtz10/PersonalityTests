Public Class Login
    Dim opcion As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.PsicologiaDBDataSet.Usuarios)
        UsuarioTxt.Focus()
    End Sub

    Private Sub ingresar()
        Dim nTotal As Byte

        opcion = MenuPrincipal.eleccion
        nTotal = UsuariosTableAdapter.LoginUsuario(UsuarioTxt.Text, ContrasenaTxt.Text)

        If nTotal = 1 Then
            Me.Hide()
            Select Case opcion
                Case 1
                    RegistrarUsuarios.Show()
                    RegistrarUsuarios.UsuariosBindingSource.AddNew()
                Case 2
                    usuarios.Show()
                Case 3
                    Pacientes.Show()
                Case 4
                    registroTemperamentos.Show()
                Case 5
                    registrosAlimentacion.Show()
                Case 6
                    registrosSignosZodiacales.Show()
                Case 7
                    registrosAntecedentes.Show()
                Case 8
                    reporte.Show()
            End Select

        Else
            MsgBox("El usuario o la contraseña son invalidos.", vbCritical, "Credenciales no validas")
            ContrasenaTxt.Clear()
        End If
        ContrasenaTxt.Clear()
        UsuarioTxt.Clear()
        VerContrasena.Checked = False
    End Sub

    Private Sub ContrasenaTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles ContrasenaTxt.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ingresar()
        End Select
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ingresar()
        clearTxts()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        clearTxts()
    End Sub

    Private Sub VerContrasena_CheckedChanged(sender As Object, e As EventArgs) Handles VerContrasena.CheckedChanged
        If VerContrasena.Checked = True Then
            ContrasenaTxt.PasswordChar = ""
        Else
            ContrasenaTxt.PasswordChar = "*"
        End If
    End Sub

    Private Sub clearTxts()
        ContrasenaTxt.Clear()
        UsuarioTxt.Clear()
    End Sub
End Class