Public Class cClient
    Property _ID As Int32
    Property _Name As String
    Property _Phone As String
    Property _Email As String
    Public Sub New(_ID As Int32)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM clientes WHERE ID=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", _ID)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                Me._ID = Int32.Parse(reader(0))
                Me._Name = reader(1).ToString()
                Me._Phone = reader(2).ToString()
                Me._Email = reader(3).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub New(_ID As Int32, _Name As String, _Phone As String, _Email As String)
        Me._ID = _ID
        Me._Name = _Name
        Me._Phone = _Phone
        Me._Email = _Email
    End Sub
    Public Sub Create()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO ventasitems VALUES(@ID,@Client,@Phone,@eMail)", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@Client", Me._Name)
            cmd.Parameters.AddWithValue("@Phone", Me._Phone)
            cmd.Parameters.AddWithValue("@eMail", Me._Email)
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
            Dim cmd As New SqlClient.SqlCommand("UPDATE FROM clientes SET(@Name,@Phone,@eMail) WHERE ID=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@Name", Me._Name)
            cmd.Parameters.AddWithValue("@Phone", Me._Phone)
            cmd.Parameters.AddWithValue("@eMail", Me._Email)
            myDBconnection.Open()
            cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Sub Delete()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("DELETE FROM clientes WHERE ID=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            myDBconnection.Open()
            cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
    Public Shared Sub GetClients(ByRef _grid As DataGridView)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM clientes", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), reader(2), reader(3), "Baja"})
            End While
        Catch ex As ErrorDelete
            MessageBox.Show("Error to delete reg" & ex.Message)
        Finally
            myDBconnection.Close()

        End Try
    End Sub
    Public Shared Sub FilterClients(ByRef _grid As DataGridView)

    End Sub
    Public Function to_String() As String
        Return ("[" + Me._ID + "] " + Me._Name + "\nTelefono: " + Me._Phone + "\neMail: " + Me._Email).ToString()
    End Function
End Class