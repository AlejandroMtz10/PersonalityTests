
Public Class nuevoUsuario
    Dim user, fecha As String
    Private Sub nuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.PsicologiadbDataSet.usuarios)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            MsgBox("Registro de usuario cancelado, ahora esta ventana se cerrara.", vbCritical, "Cancelar.")
            Me.UsuariosBindingSource.CancelEdit()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If PassworTextBox.Text = confirmarPassword.Text Then
            Try
                Me.Validate()
                Me.UsuariosBindingSource.EndEdit()
                Me.UsuariosTableAdapter.Update(Me.PsicologiadbDataSet.usuarios)
                Me.Refresh()

                'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
                fecha = Now
                user = PantallaCarga.user
                Me.BitacoraTableAdapter.insertarRegistro(user, "Usuarios", "Nuevo usuario", fecha)

                MsgBox("El usuario se ha registrado de forma exitosa, ahora se cerrara esta ventana.", vbInformation, "Guardar.")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error.")
            End Try
        Else
            MsgBox("Las contaseñas no coinciden.", vbCritical, "Error.")
            confirmarPassword.Clear()
            confirmarPassword.Focus()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class