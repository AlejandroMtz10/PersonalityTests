Public Class PantallaCarga
    Public user As String
    Public fecha As String
    'Cierra todo el programa si se presiona el boton con este metodo
    Public Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Focus()
    End Sub
    'Metodo para iniciar sesion
    Public Sub ingresar()
        Dim nTotal As Byte

        nTotal = UsuariosTableAdapter.LoginUsuario(TxtUsuario.Text, TxtPassword.Text)

        If nTotal = 1 Then
            Me.Hide()
            user = TxtUsuario.Text

            'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
            fecha = Now
            user = TxtUsuario.Text
            Me.BitacoraTableAdapter.insertarRegistro(user, "Login", "Inicio de sesión", fecha)

            MenuPrincipal.Show()
            clearTxts()
            CheckBoxViewPassword.Checked = False
        Else
            MsgBox("El usuario o la contraseña son invalidos.", vbCritical, "Credenciales no validas")
            TxtPassword.Clear()
        End If
    End Sub
    'Ingreso dando enter en el login
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ingresar()
        End Select
    End Sub

    'Metodo para poder ver la contrseña o no verla
    Private Sub CheckBoxViewPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxViewPassword.CheckedChanged
        If CheckBoxViewPassword.Checked = True Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
        TxtPassword.Focus()
    End Sub
    'Metodo para limpiar los text box
    Private Sub clearTxts()
        TxtUsuario.Clear()
        TxtPassword.Clear()
    End Sub
    'Ingreso al login con el boton
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ingresar()
        clearTxts()
    End Sub
End Class
