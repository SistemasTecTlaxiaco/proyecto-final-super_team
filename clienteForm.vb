Public Class clienteForm
    Private Sub clienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()
    End Sub


    Private Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select * from cliente where nombre like'%" & txtBuscar.Text & "%'", Conexion)
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
        txtNombre.Clear()
        txtTelefono.Clear()

        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("insert into cliente(nombre,telefono) values('" & txtNombre.Text & "','" & txtTelefono.Text & "')", Conexion)
                cmd.ExecuteNonQuery()


                Poblar()
                Limpiar()
            End If
        Else
            If MessageBox.Show("¿Seguro que modificar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cmd As New OleDb.OleDbCommand("update cliente set nombre='" & txtNombre.Text & "',telefono='" & txtTelefono.Text & "' where ID= " & txtID.Text, Conexion)
                cmd.ExecuteNonQuery()

                Poblar()

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim cmd As New OleDb.OleDbCommand("delete * from cliente where id=" & txtID.Text, Conexion)
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
            txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
            txtTelefono.Text = DataGridView1.CurrentRow.Cells("TELEFONO").Value.ToString
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        ReservaForm.lbIDcliente.Text = txtID.Text
        ReservaForm.btnCliente.Text = txtNombre.Text
        Me.Close()
    End Sub
End Class