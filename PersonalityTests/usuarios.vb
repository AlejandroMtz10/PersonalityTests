Public Class usuarios
    Dim activos As Integer
    Dim user, fecha As String


    Private Sub habilitarBotones()
        If activos = 0 Then

            BtnModificar.Enabled = True
            BtnEliminar.Enabled = True
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False

        ElseIf activos = 1 Then

            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        activos = 1
        habilitarBotones()
        TelefonoTextBox.ReadOnly = False
        UsuarioTextBox.ReadOnly = False
        PassworTextBox.ReadOnly = False
        TxtConfirmar.ReadOnly = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        activos = 1
        habilitarBotones()

        Try
            Dim nResp As Byte
            nResp = MsgBox("¿Realmente desea eliminar esté usuario?", vbYesNo, "Eliminar usuario.")

            If nResp = vbYes Then
                Me.UsuariosTableAdapter.Delete(UsuarioTextBox.Text)

                'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
                fecha = Now
                user = PantallaCarga.user
                Me.BitacoraTableAdapter.insertarRegistro(user, "Usuarios", "Usuario eliminado", fecha)

                MsgBox("Usuario eliminado exitosamente.", vbInformation, "Eliminado.")
            End If
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If PassworTextBox.Text = TxtConfirmar.Text Then
                Me.Validate()
                Me.UsuariosBindingSource.EndEdit()
                Me.UsuariosTableAdapter.Update(Me.PsicologiadbDataSet.usuarios)

                'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
                fecha = Now
                user = PantallaCarga.user
                Me.BitacoraTableAdapter.insertarRegistro(user, "Usuarios", "Registro actualizado", fecha)

                Me.Refresh()
                MsgBox("Cambios guardados exitosamente.", vbInformation, "Guardado.")
                TelefonoTextBox.ReadOnly = True
                UsuarioTextBox.ReadOnly = True
                PassworTextBox.ReadOnly = True
                activos = 0
                habilitarBotones()
            Else
                MsgBox("Las contraseñas no coinciden.", vbCritical, "Error de coincidencia.")
                PassworTextBox.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.UsuariosBindingSource.CancelEdit()
            MsgBox("Cambios cancelados.", vbInformation, "Cancelar.")
            TelefonoTextBox.ReadOnly = True
            UsuarioTextBox.ReadOnly = True
            PassworTextBox.ReadOnly = True
            activos = 0
            habilitarBotones()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.UsuariosTableAdapter.BuscarUsuario(Me.PsicologiadbDataSet.usuarios, TxtBuscar.Text)
        End Select
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class