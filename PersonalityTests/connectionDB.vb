Imports MySql.Data.MySqlClient 'Libreria para conectarse con MySQL
Module connectionDB
    'Parametros para conectarse a la base de datos
    Public connection As New MySqlConnection("server=localhost;database=psicologiadb;user=root;password='7910'")

    Public Sub conectar()
        Try
            'Se inicia la conexion con la base de datos
            connection.Open()
            conexionBD.txtInformation.Text = "La conexión con la base de datos esta establecida de forma correcta."
            conexionBD.imgDB_successful.Visible = True
            conexionBD.imgDB_failed.Visible = False
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Error.")
            conexionBD.txtInformation.Text = ex.Message
            conexionBD.imgDB_successful.Visible = False
            conexionBD.imgDB_failed.Visible = True

        Finally

            If connection.State = ConnectionState.Open Then
                connection.Close() 'Cierra la conexion con la base de datos
            End If
        End Try
    End Sub
End Module
