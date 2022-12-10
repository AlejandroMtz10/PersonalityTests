Public Class usuarios
    Dim btnsHabilitados, txtsHabilitados As Boolean

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim cont As Byte
        cont = UsuariosTableAdapter.VerificacionUsuario(nombreTxt.Text, telefonoTxt.Text)
        If cont = 1 Then
            Me.UsuariosTableAdapter.ValidarUsuario(Me.PsicologiaDBDataSet.Usuarios, nombreTxt.Text, telefonoTxt.Text)
            btnsHabilitados = True
            habilitarBtns()
        Else
            MessageBox.Show("No hay un usuario que coincida con esas credenciales.")
            btnsHabilitados = False
            habilitarBtns()
            clearTxts()
        End If
    End Sub

    Private Sub habilitarTxts()

        If txtsHabilitados = True Then
            IdUsuarioTextBox.Enabled = True
            NombreTextBox.Enabled = True
            ApellidosTextBox.Enabled = True
            TelefonoTextBox.Enabled = True
            UsuarioTextBox.Enabled = True
            PassworTextBox.Enabled = True

        ElseIf txtsHabilitados = False

            IdUsuarioTextBox.Enabled = False
            NombreTextBox.Enabled = False
            ApellidosTextBox.Enabled = False
            TelefonoTextBox.Enabled = False
            UsuarioTextBox.Enabled = False
            PassworTextBox.Enabled = False

        End If


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub habilitarBtns()

        If btnsHabilitados = True Then

            BtnEliminar.Enabled = True
            BtnGuardar.Enabled = True
            BtnModificar.Enabled = True
            BtnCancelar.Enabled = True

        ElseIf btnsHabilitados = False

            BtnEliminar.Enabled = False
            BtnGuardar.Enabled = False
            BtnModificar.Enabled = False
            BtnCancelar.Enabled = False

        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        txtsHabilitados = True
        habilitarTxts()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            Me.UsuariosBindingSource.CancelEdit()
            txtsHabilitados = False
            habilitarTxts()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Me.Validate()
            Me.UsuariosBindingSource.EndEdit()
            Me.UsuariosTableAdapter.Update(Me.PsicologiaDBDataSet.Usuarios)
            Me.Refresh()
            MessageBox.Show("Cambios guardados exitosamente.")
            txtsHabilitados = False
            habilitarTxts()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim nResp As Byte

            nResp = MessageBox.Show("¿Estas seguro de eliminar este registro?",
                 "Eliminar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If nResp = 6 Then
                Me.UsuariosTableAdapter.Delete(IdUsuarioTextBox.Text)
                MessageBox.Show("Registro se elimino exitosamente.")
                clearTxts()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub clearTxts()
        IdUsuarioTextBox.Clear()
        NombreTextBox.Clear()
        ApellidosTextBox.Clear()
        TelefonoTextBox.Clear()
        UsuarioTextBox.Clear()
        PassworTextBox.Clear()
    End Sub
End Class