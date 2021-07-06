Public Class HabitacionesForm
    Private Sub HabitacionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        poblar

    End Sub

    Private Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select * from habitaciones where numero like'%" & txtBuscar.Text & "%' or tipo like'%" & txtBuscar.Text & "%'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtID.Text = "0"
        txtNumero.Clear()
        cboTipo.SelectedIndex = -1
        txtOcupantes.Clear()
        txtPrecio.Clear()

        txtNumero.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("insert into habitaciones(numero,tipo,ocupantes,precio) values('" & txtNumero.Text & "','" & cboTipo.Text & "','" & txtOcupantes.Text & "','" & txtPrecio.Text & "')", Conexion)
                cmd.ExecuteNonQuery()


                Poblar()
                Limpiar()

            End If
        Else
            If MessageBox.Show("¿Seguro que modificar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("update habitaciones set numero='" & txtNumero.Text & "',tipo='" & cboTipo.Text & "',ocupantes='" & txtOcupantes.Text & "',precio='" & txtPrecio.Text & "' where ID= " & txtID.Text, Conexion)
                cmd.ExecuteNonQuery()

                Poblar()

            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cmd As New OleDb.OleDbCommand("delete * from habitaciones where id=" & txtID.Text, Conexion)
            cmd.ExecuteNonQuery()

            Poblar()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Poblar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows.Count > 0 Then
            txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
            cboTipo.Text = DataGridView1.CurrentRow.Cells("TIPO").Value.ToString
            txtNumero.Text = DataGridView1.CurrentRow.Cells("NUMERO").Value.ToString
            txtOcupantes.Text = DataGridView1.CurrentRow.Cells("OCUPANTES").Value.ToString
            txtPrecio.Text = DataGridView1.CurrentRow.Cells("PRECIO").Value.ToString
        End If
    End Sub
End Class