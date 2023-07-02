Public Class Product
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
End Class

Public Class ProductData
    Private listProducts As List(Of Product)
    Private Sub ProductData_Load(sender As Object, e As EventArgs)

    End Sub
End Class