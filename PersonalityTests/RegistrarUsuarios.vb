Public Class RegistrarUsuarios

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If PassworTextBox.Text = ConfirmarContrasenaTxt.Text Then

                Me.Validate()
                Me.UsuariosBindingSource.EndEdit()
                Me.UsuariosTableAdapter.Update(Me.PsicologiaDBDataSet.Usuarios)
                Me.Refresh()

                MsgBox("El usuario se ha guardado, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
                Login.Close()
                Me.Close()
            Else
                MsgBox("Las contraseñas no coinciden.", vbCritical, "Error.")
                PassworTextBox.Clear()
                ConfirmarContrasenaTxt.Clear()
                PassworTextBox.Focus()
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            MsgBox("Registro de usuario cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar")
            Login.Close()
            Me.UsuariosBindingSource.CancelEdit()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub RegistrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.PsicologiaDBDataSet.Usuarios)
    End Sub
End Class