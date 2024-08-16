Imports connectionDB
Public Class conexionBD
    Dim user, fecha As String
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        fecha = Now
        user = PantallaCarga.user

        Me.BitacoraTableAdapter.insertarRegistro(user, "Base de datos", "Estatus de la conexión.", fecha)
        Me.Close()
    End Sub
End Class