Public Class gestionarForm
    Dim Bsource As BindingSource

    Private Sub gestionarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()
    End Sub

    Private Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select reserva_detalle.id,reservas.id_cliente,reserva_detalle.id_reserva,reserva_detalle.numero,reserva_detalle.tipo,reserva_detalle.ocupantes,reserva_detalle.precio,reserva_detalle.checkin,reserva_detalle.checkout from reserva_detalle " &
                                             "inner join reservas on reserva_detalle.id_reserva=reservas.id_reserva group by  reserva_detalle.id,reservas.id_cliente,reserva_detalle.id_reserva,reserva_detalle.numero,reserva_detalle.tipo,reserva_detalle.ocupantes,reserva_detalle.precio,reserva_detalle.checkin,reserva_detalle.checkout", Conexion)

        Dim ds As New DataSet
        da.Fill(ds)
        Bsource = New BindingSource
        Bsource.DataSource = ds.Tables(0)
        DataGridView1.DataSource = Bsource
    End Sub

    Private Sub VerificaDisponibilidad()
        If DataGridView1.Rows.Count > 0 Then

            Dim da As New OleDb.OleDbDataAdapter(" Select * FROM Reserva_detalle where numero='" & DataGridView1.CurrentRow.Cells("numero").Value.ToString & "'", Conexion)
            Dim dst As New DataSet
            da.Fill(dst)


            Dim Compara As String = "0"

            Dim Fecha1 As Date = DateTimePicker1.Value
            Dim Fecha2 As Date = DateTimePicker2.Value

            txtSeleccion.Text = ""


            'En la verficacion de la disponibilidad, si coincide con una fecha cruzada,  la marca como no disponible
            If dst.Tables(0).Rows.Count > 0 Then
                Dim filadetalle As DataRow
                For Each filadetalle In dst.Tables(0).Rows
                    If Fecha1 >= filadetalle("checkin") And Fecha2 <= filadetalle("checkout") Then
                        If filadetalle("id_reserva") = DataGridView1.CurrentRow.Cells("id_reserva").Value.ToString Then
                            txtSeleccion.Text = ""
                        Else
                            txtSeleccion.Text = "Esta habitación no está disponible para esta fecha!"
                            Exit For
                        End If

                    ElseIf Fecha1 < filadetalle("checkin") And Fecha2 > filadetalle("checkout") Then
                        If filadetalle("id_reserva") = DataGridView1.CurrentRow.Cells("id_reserva").Value.ToString Then
                            txtSeleccion.Text = ""
                        Else
                            txtSeleccion.Text = "Esta habitación no está disponible para esta fecha!"
                            Exit For
                        End If

                    ElseIf Fecha1 <= filadetalle("checkin") And Fecha2 >= filadetalle("checkin") Then

                        If filadetalle("id_reserva") = DataGridView1.CurrentRow.Cells("id_reserva").Value.ToString Then
                            txtSeleccion.Text = ""
                        Else
                            txtSeleccion.Text = "Esta habitación no está disponible para esta fecha!"
                            Exit For
                        End If

                    ElseIf Fecha1 >= filadetalle("checkin") And Fecha1 < filadetalle("checkout") Then 'En la fecha de checkout la habitación está disponible, de lo contrario puede poner Fecha1 <= filadetalle("checkout")
                        If filadetalle("id_reserva") = DataGridView1.CurrentRow.Cells("id_reserva").Value.ToString Then
                            txtSeleccion.Text = ""
                        Else
                            txtSeleccion.Text = "Esta habitación no está disponible para esta fecha!"
                            Exit For '
                        End If

                    End If

                Next
            End If

        End If
    End Sub

    Private Sub BuscaCliente(ByVal Tipo As Integer, ByVal Cadena As String)
        Dim da As New OleDb.OleDbDataAdapter
        If Tipo = 1 Then
            da = New OleDb.OleDbDataAdapter("select cliente.id,cliente.nombre,cliente.telefono from cliente  where cliente.nombre like'%" & Cadena & "%'", Conexion)
        Else
            da = New OleDb.OleDbDataAdapter("select cliente.id,cliente.nombre,cliente.telefono from cliente  where cliente.id=" & Cadena, Conexion)
        End If

        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            If txtBuscar.Text.Length = 0 Then
                Bsource.Filter = Nothing
            Else
                Bsource.Filter = "ID_CLIENTE=" & ds.Tables(0).Rows(0).Item("ID")
            End If

            txtCliente.Text = ds.Tables(0).Rows(0).Item("NOMBRE")
            txtTelefono.Text = ds.Tables(0).Rows(0).Item("TELEFONO")
        Else
            Bsource.Filter = "ID_CLIENTE=0"
            txtCliente.Clear()
            txtTelefono.Clear()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        VerificaDisponibilidad()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        VerificaDisponibilidad()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscaCliente(1, txtBuscar.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows.Count > 0 Then
            DateTimePicker1.Value = DataGridView1.CurrentRow.Cells("checkin").Value
            DateTimePicker2.Value = DataGridView1.CurrentRow.Cells("checkout").Value
            BuscaCliente(2, DataGridView1.CurrentRow.Cells("ID_CLIENTE").Value)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If DataGridView1.Rows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea cambiar esta reserva?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("update reserva_detalle set checkin=@fecha1, checkout=@fecha2 where id=" & DataGridView1.CurrentRow.Cells("ID").Value.ToString, Conexion)
                cmd.Parameters.AddWithValue("@fecha1", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@fecha2", DateTimePicker2.Value)
                cmd.ExecuteNonQuery()

                Poblar()
                VerificaDisponibilidad()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If DataGridView1.Rows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea cambiar esta reserva?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("delete * from reserva_detalle where id=" & DataGridView1.CurrentRow.Cells("ID").Value.ToString, Conexion)
                cmd.ExecuteNonQuery()

                Poblar()
                VerificaDisponibilidad()
            End If

        End If
    End Sub
End Class