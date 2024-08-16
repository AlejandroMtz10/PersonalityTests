Public Class reporte
    Dim user, fecha As String

    Private Sub reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Now.ToString("dd / MM / yyyy")
        txtsClean()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            PrintPreviewDialog1.ShowDialog()
            'Esto genera un nuevo registro automaticamente en la tabla de bitacora similar a un trigger en sql
            fecha = Now
            user = PantallaCarga.user
            Me.BitacoraTableAdapter.insertarRegistro(user, "Reporte", "Imprimir reporte", fecha)
            BtnImprimir.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
            BtnImprimir.Enabled = True
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim existe As Integer
        existe = PacientesTableAdapter.loginPacientes(TxtMatricula.Text)

        If existe = 1 Then

            NombreTextBox.Text = PacientesTableAdapter.NombrePaciente(TxtMatricula.Text)
            Me.AlimentacionTableAdapter.BuscarPacienteAlimentacion(Me.PsicologiadbDataSet.alimentacion, TxtMatricula.Text)
            Me.TemperamentosTableAdapter.PacienteTemperamentos(Me.PsicologiadbDataSet.temperamentos, TxtMatricula.Text)
            BtnImprimir.Enabled = True
        Else
            MsgBox("No hay ningún paciente registrado con esa matrícula.", vbCritical, "Paciente no encontrado.")
            txtsClean()
            BtnImprimir.Enabled = False
        End If

    End Sub


    Private Sub ImprimirReporte(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel2.Width, Panel2.Height)
        Panel2.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub txtsClean()
        NombreTextBox.Clear()
        RayasicoTextBox.Clear()
        TamasicoTextBox.Clear()
        SatvicoTextBox.Clear()
        DescripcionTextBox.Clear()
        SanguineoTextBox.Clear()
        ColericoTextBox.Clear()
        MelancolicoTextBox.Clear()
        FlematicoTextBox.Clear()
        DescripcionTextBox1.Clear()
    End Sub
End Class