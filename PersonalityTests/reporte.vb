Public Class reporte
    Private Sub SearchPatient()
        Dim validar As Byte
        validar = PacientesTableAdapter.ConfirmarPaciente(MatriculaPacienteTxt.Text)

        If validar = 1 Then
            Me.PacientesTableAdapter.ReportePaciente(Me.PsicologiaDBDataSet.Pacientes, MatriculaPacienteTxt.Text)
            Me.HistorialPacienteTableAdapter.ReporteHistorial(Me.PsicologiaDBDataSet.HistorialPaciente, MatriculaPacienteTxt.Text)
            Me.TemperamentosTableAdapter.ReporteTemperamentos(Me.PsicologiaDBDataSet.Temperamentos, MatriculaPacienteTxt.Text)
            Me.AlimentacionTableAdapter.ReporteAlimentacion(Me.PsicologiaDBDataSet.Alimentacion, MatriculaPacienteTxt.Text)
        Else
            MsgBox("No existe un paciente con esa matrícula en la base de datos.", vbCritical, "Matrícula no valida.")
            ClearTxts()
        End If
    End Sub
    Private Sub reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = DateTime.Now.ToString("dd / MM / yyyy")
    End Sub
    Private Sub ClearTxts()
        MatriculaTextBox.Clear()
        NombreTextBox.Clear()
        ApellidosTextBox.Clear()
        EdadTextBox.Clear()
        UsoMedicamentosTextBox.Clear()
        RecomendacionesTxt.Clear()
        SanguineoTextBox.Clear()
        MelancolicoTextBox.Clear()
        ColericoTextBox.Clear()
        FlematicoTextBox.Clear()
        SatvicoTextBox.Clear()
        TamasicoTextBox.Clear()
        RayasicoTextBox.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MatriculaPacienteTxt_KeyDown_1(sender As Object, e As KeyEventArgs) Handles MatriculaPacienteTxt.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                SearchPatient()
        End Select
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error.")
        End Try
    End Sub

    Private Sub ImprimirReporte(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)
        Panel2.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub TxtApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtApellidos.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim validar As Byte
                validar = PacientesTableAdapter.ValidarNombre(TxtNombre.Text, TxtApellidos.Text)

                If validar = 1 Then
                    MatriculaPacienteTxt.Text = PacientesTableAdapter.BuscarMatriculaPaciente(TxtNombre.Text, TxtApellidos.Text)
                    MatriculaPacienteTxt.Focus()
                Else
                    MsgBox("No existe el paciente en la base de datos.", vbCritical, "Nombre desconocido.")
                    ClearTxts()
                End If
        End Select
    End Sub
End Class