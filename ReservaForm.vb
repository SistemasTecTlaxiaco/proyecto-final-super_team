Public Class ReservaForm
    Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        checkinForm.MdiParent = Me
        PanelPrincipal.Controls.Add(checkinForm)
        checkinForm.Show()

        checkinForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Reserva de Habitaciones"

        VerificaSeleccionTemp()
    End Sub

    Private Sub VerificaSeleccionTemp()


        If checkinForm.DataGridView1.Rows.Count > 0 Then
            'Recorremos las filas del Datagrid para poner titulo al botón de Reservar
            For Each filaTitulo As DataGridViewRow In checkinForm.DataGridView1.Rows
                Dim BtnCell = CType(filaTitulo.Cells("RESERVAR"), DataGridViewButtonCell)
                BtnCell.Value = "RESERVAR"
            Next
            '----------------------------------------------------------------

            'Verificamos las habitaciones seleccionadas para marcarlas en el Datagrid
            Dim da As New OleDb.OleDbDataAdapter("select * from temp", Conexion)
            Dim ds As New DataSet
            da.Fill(ds)


            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                For Each filaGrid As DataGridViewRow In checkinForm.DataGridView1.Rows
                    If filaGrid.Cells("numero").Value = fila("numero") Then
                        filaGrid.Cells("checkin").Value = fila("checkin")
                        filaGrid.Cells("checkout").Value = fila("checkout")
                        Dim BtnCell = CType(filaGrid.Cells("RESERVAR"), DataGridViewButtonCell)
                        BtnCell.Value = "CANCELAR"
                    End If

                Next
            Next
        Else

        End If
    End Sub

    Public Sub CalcularSuma()
        Dim da As New OleDb.OleDbDataAdapter("select * from temp", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        lbMonto.Text = "0"

        If ds.Tables(0).Rows.Count > 0 Then
            lbNoHabitaciones.Text = ds.Tables(0).Rows.Count

            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                lbMonto.Text = CDbl(lbMonto.Text) + fila("precio")
            Next

        Else
            lbNoHabitaciones.Text = "0"
            lbMonto.Text = "0"
        End If

        lbMonto.Text = Format(lbMonto.Text, "standard")
    End Sub

    Private Sub LimpiaTemp()
        Dim cmd As New OleDb.OleDbCommand("delete * from temp", Conexion)
        cmd.ExecuteNonQuery()

        SeleccionForm.DataGridView1.DataSource = Nothing
        btnCliente.Text = "Seleccionar Cliente"
        lbNoHabitaciones.Text = "0"
        lbMonto.Text = "0"
    End Sub

    Private Sub btnReservadas_Click(sender As Object, e As EventArgs) Handles btnReservadas.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        SeleccionForm.MdiParent = Me
        PanelPrincipal.Controls.Add(SeleccionForm)
        SeleccionForm.Show()

        SeleccionForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Completar Reservación"
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub MonthCalendar1_MouseUp(sender As Object, e As MouseEventArgs) Handles MonthCalendar1.MouseUp
        checkinForm.CargaHabitacion()

        VerificaSeleccionTemp()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LimpiaTemp()
        Timer1.Enabled = False
    End Sub

    Private Sub ReservaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        GeneraReserva()
    End Sub

    Private Sub GeneraReserva()
        lbNoReserva.Text = "1"
        Dim da As New OleDb.OleDbDataAdapter("select top 1 ID from reservas order by id desc", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            lbNoReserva.Text = CInt(ds.Tables(0).Rows(0).Item("ID")) + 1
        End If
    End Sub

    Private Sub btnCompletar_Click(sender As Object, e As EventArgs) Handles btnCompletar.Click
        If lbIDcliente.Text = "0" Then
            MessageBox.Show("Seleccione un cliente primero!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("¿Seguro que desea completar esta reserva?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cmd As New OleDb.OleDbCommand("insert into reservas(id_cliente,id_reserva,fecha) values('" & lbIDcliente.Text & "','" & lbNoReserva.Text & "',@fecha)", Conexion)
            cmd.Parameters.AddWithValue("@fecha", OleDb.OleDbType.Date).Value = Now.Date

            cmd.ExecuteNonQuery()

            Dim da As New OleDb.OleDbDataAdapter("select * from temp", Conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                For Each fila In ds.Tables(0).Rows
                    cmd = New OleDb.OleDbCommand("insert into reserva_detalle(id_reserva,numero,tipo,ocupantes,precio,checkin,checkout) values('" & fila("id_reserva") & "','" & fila("numero") & "','" & fila("tipo") & "','" & fila("ocupantes") & "','" & fila("precio") & "',@checkin,@checkout)", Conexion)
                    cmd.Parameters.AddWithValue("@checkin", OleDb.OleDbType.Date).Value = fila("checkin")
                    cmd.Parameters.AddWithValue("@checkout", OleDb.OleDbType.Date).Value = fila("checkout")
                    cmd.ExecuteNonQuery()
                Next
            End If

            LimpiaTemp()
            GeneraReserva()
        End If
    End Sub

    Private Sub ReservaForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        checkinForm.WindowState = FormWindowState.Normal : checkinForm.WindowState = FormWindowState.Maximized
        SeleccionForm.WindowState = FormWindowState.Normal : SeleccionForm.WindowState = FormWindowState.Maximized
        gestionarForm.WindowState = FormWindowState.Normal : gestionarForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If checkinForm.BS IsNot Nothing Then
            If ComboBox1.Text = "TODAS" Then
                checkinForm.BS.Filter = Nothing
            Else
                checkinForm.BS.Filter = "TIPO='" & ComboBox1.Text & "'"
            End If

            VerificaSeleccionTemp()
        End If
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        clienteForm.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegistroClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroClientesToolStripMenuItem.Click
        clienteForm.Show()
    End Sub

    Private Sub RegistroHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroHabitacionesToolStripMenuItem.Click
        HabitacionesForm.Show()
    End Sub

    Private Sub GestionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        gestionarForm.MdiParent = Me
        PanelPrincipal.Controls.Add(gestionarForm)
        gestionarForm.Show()

        gestionarForm.WindowState = FormWindowState.Maximized

        LabelTop.Text = "Gestión de Reservas"
    End Sub
End Class
