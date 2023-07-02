Public Class VentaItem
    Public Property _ID As UInt32
    Public Property _Name As String
    Public Property _Price As Double
    Public Property _Category As String
    Public Sub New(_ID As UInt32, _Name As String, _Price As Double, _Category As String)
        Me._ID = _ID
        Me._Name = _Name
        Me._Price = _Price
        Me._Category = _Category
    End Sub
    Public Sub Update_reg()

    End Sub
End Class

Public Class VentaItemData
    Private listVentaItems As List(Of VentaItem)
    Private Sub VentaItemData_Load(sender As Object, e As EventArgs)

    End Sub
End Class
