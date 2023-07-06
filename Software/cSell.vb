Public Class cSell
    Public Property _ID As Int32
    Public Property _Date As Date
    Public Property _Total As Integer
    Public Property _Client As cClient
    Public Property _Items As List(Of cSellItem)
    Public Sub New(_ID As Int32)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [ventas] WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", _ID)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                Me._ID = Int32.Parse(reader(0))
                Me._Client = New cClient(reader(1))
                Me._Date = Date.Parse(reader(2))
                Me._Total = Double.Parse(reader(3))
                Me._Items = 
            End While
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub New(_ID As Int32, _Date As Date, _Total As Integer, _Client As cClient, _Items As List(Of cSellItem))
        Me._ID = _ID
        Me._Date = _Date
        Me._Client = _Client
        Me._Items = _Items
        Me._Total = _Total
    End Sub
    Public Sub New(_ID As Int32, _Date As Date, _Client As cClient, _Items As List(Of cSellItem))
        Me._ID = _ID
        Me._Date = _Date
        Me._Client = _Client
        Me._Items = _Items
        Me._Total = 0

        For Each _Item As cSellItem In _Items
            Me._Total += _Item._TotalPrice
        Next

    End Sub
    Public Sub CreateSell()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO [ventas] VALUES(@IDClient,@Date,@Total)", myDBconnection)
            cmd.Parameters.AddWithValue("@IDClient", Me._Client._ID)
            cmd.Parameters.AddWithValue("@Date", Me._Date)
            cmd.Parameters.AddWithValue("@Total", Me._Total)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            If Me._Items.Count > 0 Then
                For Each _item As cSellItem In Me._Items
                    _item.Create()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub Update()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("UPDATE [ventas] SET [IDCliente]=@IDClient, [Fecha]=@Date, [Total]=@Total WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@IDClient", Me._Client._ID)
            cmd.Parameters.AddWithValue("@Date", Me._Date)
            cmd.Parameters.AddWithValue("@Total", Me._Total)
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
            If Me._Items.Count > 0 Then
                For Each _item As cSellItem In Me._Items
                    _item.Delete()
                Next
            End If

            Dim cmd As New SqlClient.SqlCommand("DELETE FROM [ventas] WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Shared Sub GetData(ByRef _grid As DataGridView)
        If _grid.Rows.Count > 0 Then
            _grid.Rows.Clear()
        End If

        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [ventas]", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), reader(2), reader(3), "👁", "✏", "❌"})
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
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [ventas] WHERE ( [Nombre] like " & queryValue & " OR [Categoria] like " & queryValue & " )", myDBconnection)
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
