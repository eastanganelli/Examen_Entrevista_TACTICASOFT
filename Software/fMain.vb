Public Class fMain
    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PruebademoDataSet1.productos' table. You can move, or remove it, as needed.
        Me.taProductos.Fill(Me.dsPruebademo.productos)
        'TODO: This line of code loads data into the 'PruebademoDataSet1.clientes' table. You can move, or remove it, as needed.
        Me.taClientes.Fill(Me.dsPruebademo.clientes)

    End Sub
End Class
