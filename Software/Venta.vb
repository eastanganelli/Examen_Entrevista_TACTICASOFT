Public Class Venta
    Public Property Cliente_ As Cliente
    Public Property Items_ As List(Of VentaItem)
    Public Sub New(ByVal cliente_ As Cliente, items_ As List(Of VentaItem))
        Me.Cliente_ = cliente_
        Me.Items_ = items_
    End Sub

End Class
