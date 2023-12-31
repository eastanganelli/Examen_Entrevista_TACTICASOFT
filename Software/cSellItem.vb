﻿Public Class cSellItem
    Public Property _ID As Int32
    Public Property _IDSell As Int32
    Public Property _Product As cProduct
    Public Property _UnitPrice As Double
    Public Property _Count As Double
    Public Property _TotalPrice As Double
    Public Sub New(_ID As Int32)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM ventasitems WHERE ID=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", _ID)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                Me._ID = Int32.Parse(reader(0))
                Me._IDSell = Int32.Parse(reader(1))
                Me._Product = New cProduct(reader(2))
                Me._UnitPrice = Double.Parse(reader(3))
                Me._Count = Double.Parse(reader(4))
                Me._TotalPrice = Double.Parse(reader(5))
            End While
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub New(_ID As Int32, _IDSell As Int32, _Product As cProduct, _UnitPrice As Integer, _Count As Integer, _TotalPrice As Integer)
        Me._ID = _ID
        Me._IDSell = _IDSell
        Me._Product = _Product
        Me._UnitPrice = _UnitPrice
        Me._Count = _Count
        Me._TotalPrice = _TotalPrice
    End Sub
    Public Sub New(_ID As Int32, _IDSell As Int32, _IDProduct As Int32, _UnitPrice As Integer, _Count As Integer, _TotalPrice As Integer)
        Me._ID = _ID
        Me._IDSell = _IDSell
        Me._Product = New cProduct(_IDProduct)
        Me._UnitPrice = _UnitPrice
        Me._Count = _Count
        Me._TotalPrice = _TotalPrice
    End Sub
    Public Sub Create()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO [ventasitems] VALUES(@IDSell,@IDProduct,@UnitPrice,@Count,@Total)", myDBconnection)
            cmd.Parameters.AddWithValue("@IDSell", Me._IDSell)
            cmd.Parameters.AddWithValue("@IDProduct", Me._Product._ID)
            cmd.Parameters.AddWithValue("@UnitPrice", Me._UnitPrice)
            cmd.Parameters.AddWithValue("@Count", Me._Count)
            cmd.Parameters.AddWithValue("@Total", Me._TotalPrice)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub Update()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("UPDATE [ventasitems] SET [IDVenta]=@IDSell, [IDProducto]=@IDProduct,[PrecioUnitario]=@UnitPrice,[Cantidad]=@Count,[PrecioTotal]=@Total) WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@IDSell", Me._IDSell)
            cmd.Parameters.AddWithValue("@IDProduct", Me._Product._ID)
            cmd.Parameters.AddWithValue("@UnitPrice", Me._UnitPrice)
            cmd.Parameters.AddWithValue("@Count", Me._Count)
            cmd.Parameters.AddWithValue("@Total", Me._TotalPrice)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub Delete()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("DELETE FROM [ventasitems] WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Shared Sub GetData(ByRef _grid As DataGridView, ByVal idSell As Int32)

    End Sub
    Public Shared Sub Filter(ByRef _list As List(Of cSellItem))

    End Sub
End Class