Public Class cProduct
    Public Property _ID As Int32
    Public Property _Name As String
    Public Property _Price As Double
    Public Property _Category As String
    Public Sub New(_ID As Int32)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM productos WHERE ID=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", _ID)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                Me._ID = Int32.Parse(reader(0))
                Me._Name = reader(1).ToString()
                Me._Price = Double.Parse(reader(2))
                Me._Category = reader(3).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub New(_Name As String, _Price As Double, _Category As String)
        Me._Name = _Name
        Me._Price = _Price
        Me._Category = _Category
    End Sub
    Public Sub New(_ID As Int32, _Name As String, _Price As Double, _Category As String)
        Me._ID = _ID
        Me._Name = _Name
        Me._Price = _Price
        Me._Category = _Category
    End Sub
    Public Sub Create()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO [productos] VALUES(@Name,@Price,@Category)", myDBconnection)
            cmd.Parameters.AddWithValue("@Name", Me._Name)
            cmd.Parameters.AddWithValue("@Price", Me._Price)
            cmd.Parameters.AddWithValue("@Category", Me._Category)
            myDBconnection.Open()
            cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Producto agregado con Éxito", MsgBoxStyle.MsgBoxRight, "Producto Agreagado")
    End Sub
    Public Sub Update()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("UPDATE [productos] SET [Nombre]=@Name, [Precio]=@Price,[Categoria]=@Category WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@Name", Me._Name)
            cmd.Parameters.AddWithValue("@Price", Me._Price)
            cmd.Parameters.AddWithValue("@Category", Me._Category)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Producto actualizado con Éxito", MsgBoxStyle.MsgBoxRight, "Producto Actualizado")
    End Sub
    Public Sub Delete()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("DELETE FROM [productos] WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Producto eliminado con Éxito", MsgBoxStyle.MsgBoxRight, "Producto Eliminado")
    End Sub
    Public Shared Sub GetData(ByRef _grid As DataGridView)
        If _grid.Rows.Count > 0 Then
            _grid.Rows.Clear()
        End If

        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM productos", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), Double.Parse(reader(2)), reader(3), "❌"})
            End While
        Catch ex As ErrorDelete
            MessageBox.Show("Error to delete reg" & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Shared Sub Filter(ByRef _grid As DataGridView, ByVal filterValue As String)
        If _grid.Rows.Count > 0 Then
            _grid.Rows.Clear()
        End If

        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim queryValue As String = "'%" & filterValue & "%'"
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [productos] WHERE ( [Nombre] like " & queryValue & " OR [Categoria] like " & queryValue & " )", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), Double.Parse(reader(2)), reader(3), "❌"})
            End While
        Catch ex As ErrorDelete
            MessageBox.Show("Error to delete reg" & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
End Class