Public Class historialDB

    Private Sub hitorialDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'PsicologiadbDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            Me.UsuariosTableAdapter.Fill(Me.PsicologiadbDataSet.usuarios)
            Me.BitacoraTableAdapter.Fill(Me.PsicologiadbDataSet.bitacora)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
        Dim fecha = Now
        Dim user = PantallaCarga.user

        Me.BitacoraTableAdapter.insertarRegistro(user, "Historial", "Revisión de la base de datos", fecha)
        Me.Close()
    End Sub
End Class