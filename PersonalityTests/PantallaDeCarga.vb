Public Class PantallaDeCarga
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static contar As Integer
        If contar <= 200 Then
            contar = contar + 5
        Else
            Timer1.Enabled = False
            Me.Hide()
            MenuPrincipal.Show()
        End If
    End Sub

End Class