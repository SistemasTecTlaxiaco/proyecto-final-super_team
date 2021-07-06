Public Class checkinForm
    Public dt As DataTable
    Public BS As BindingSource


    Private Sub checkinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaHabitacion()
    End Sub

    Public Sub CargaHabitacion()
        'Verficamos la disponibilidad de las habitaciones que no están dentro del rango de reserva
        '-------------------------------------------------------------------------------------------
        dt = New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("NUMERO")
        dt.Columns.Add("TIPO")
        dt.Columns.Add("OCUPANTES", GetType(Integer))
        dt.Columns.Add("PRECIO", GetType(Double))

        Dim da As New OleDb.OleDbDataAdapter("select * from habitaciones", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        BS = New BindingSource


        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            Dim cmdp As New OleDb.OleDbCommand(" Select * FROM Reserva_detalle where numero ='" & fila("numero") & "'", Conexion)

            cmdp.Parameters.AddWithValue("@fecha1", ReservaForm.MonthCalendar1.SelectionStart)
            cmdp.Parameters.AddWithValue("@fecha2", ReservaForm.MonthCalendar1.SelectionEnd)
            Dim dap As New OleDb.OleDbDataAdapter(cmdp)

            Dim dst As New DataSet
            dap.Fill(dst)

            Dim Compara As String = "0"

            Dim Fecha1 As Date = ReservaForm.MonthCalendar1.SelectionRange.Start
            Dim Fecha2 As Date = ReservaForm.MonthCalendar1.SelectionRange.End

            If dst.Tables(0).Rows.Count > 0 Then
                Dim filadetalle As DataRow
                For Each filadetalle In dst.Tables(0).Rows
                    If Fecha1 >= filadetalle("checkin") And Fecha2 <= filadetalle("checkout") Then
                        Compara = fila("numero")
                        Exit For
                    ElseIf Fecha1 < filadetalle("checkin") And Fecha2 > filadetalle("checkout") Then
                        Compara = fila("numero")
                        Exit For
                    ElseIf Fecha1 <= filadetalle("checkin") And Fecha2 >= filadetalle("checkin") Then
                        Compara = fila("numero")
                        Exit For
                    ElseIf Fecha1 >= filadetalle("checkin") And Fecha1 < filadetalle("checkout") Then
                        Compara = fila("numero")
                        Exit For
                    End If

                Next
            End If


            If fila("numero") <> Compara Then
                Dim row As DataRow = dt.NewRow()
                row("ID") = fila("ID")
                row("NUMERO") = fila("NUMERO")
                row("TIPO") = fila("TIPO")
                row("OCUPANTES") = fila("OCUPANTES")
                row("PRECIO") = fila("PRECIO")
                dt.Rows.Add(row)


            End If



        Next

        BS.DataSource = dt
        DataGridView1.DataSource = BS

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "RESERVAR" Then
            'Insertar habitacion seleccionada en la tabla temp
            '-------------------------------------------------------------------------------------------------
            If DataGridView1.CurrentRow.Cells("CHECKIN").Value Is Nothing Then
                DataGridView1.CurrentRow.Cells("CHECKIN").Value = ReservaForm.MonthCalendar1.SelectionRange.Start
                DataGridView1.CurrentRow.Cells("CHECKOUT").Value = ReservaForm.MonthCalendar1.SelectionRange.End



                Dim da As New OleDb.OleDbDataAdapter("select * from temp where numero='" & DataGridView1.CurrentRow.Cells("numero").Value.ToString & "'", Conexion)
                Dim ds As New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    Dim cmd As New OleDb.OleDbCommand("insert into temp(id_reserva,numero,tipo,ocupantes,precio,checkin,checkout) values('" & ReservaForm.lbNoReserva.Text & "','" & DataGridView1.CurrentRow.Cells("numero").Value.ToString & "','" & DataGridView1.CurrentRow.Cells("tipo").Value.ToString & "','" & DataGridView1.CurrentRow.Cells("ocupantes").Value.ToString & "','" & DataGridView1.CurrentRow.Cells("precio").Value & "','" & DataGridView1.CurrentRow.Cells("checkin").Value.ToString & "','" & DataGridView1.CurrentRow.Cells("checkout").Value.ToString & "')", Conexion)
                    cmd.ExecuteNonQuery()

                    Dim BtnCell = CType(DataGridView1.CurrentRow.Cells("RESERVAR"), DataGridViewButtonCell)
                    BtnCell.Value = "CANCELAR"
                End If


            Else
                'Remover la habitacion de la tabla temp
                '----------------------------------------------------------------
                DataGridView1.CurrentRow.Cells("CHECKIN").Value = Nothing
                DataGridView1.CurrentRow.Cells("CHECKOUT").Value = Nothing

                Dim cmd As New OleDb.OleDbCommand("delete * from temp where numero='" & DataGridView1.CurrentRow.Cells("NUMERO").Value & "'", Conexion)
                cmd.ExecuteNonQuery()

                Dim BtnCell = CType(DataGridView1.CurrentRow.Cells("RESERVAR"), DataGridViewButtonCell)
                BtnCell.Value = "RESERVAR"

            End If

            ReservaForm.CalcularSuma()
        End If
    End Sub
End Class