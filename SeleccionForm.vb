Public Class SeleccionForm
    Private Sub SeleccionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        poblar
    End Sub

    Public Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select * from temp", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing

        End If
    End Sub
End Class