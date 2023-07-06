Public Class cClient
    Property _ID As Int32
    Property _Name As String
    Property _Phone As String
    Property _Email As String
    Public Sub New(_ID As Int32)
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [clientes] WHERE [ID]=@ID", myDBconnection)
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
    Public Sub New(_Name As String, _Phone As String, _Email As String)
        Me._Name = _Name
        Me._Phone = _Phone
        Me._Email = _Email
    End Sub
    Public Sub New(_ID As Int32, _Name As String, _Phone As String, _Email As String)
        Me._ID = _ID
        Me._Name = _Name
        Me._Phone = _Phone
        Me._Email = _Email
    End Sub
    Public Sub Create()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("INSERT INTO [clientes]([Cliente],[Telefono],[Correo]) VALUES(@Name,@Phone,@eMail)", myDBconnection)
            cmd.Parameters.AddWithValue("@Name", Me._Name)
            cmd.Parameters.AddWithValue("@Phone", Me._Phone)
            cmd.Parameters.AddWithValue("@eMail", Me._Email)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Cliente agregado con Éxito", MsgBoxStyle.MsgBoxRight, "Cliente Agreagado")
    End Sub
    Public Sub Update()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("UPDATE clientes SET [Cliente]=@Name, [Telefono]=@Phone, [Correo]=@eMail WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            cmd.Parameters.AddWithValue("@Name", Me._Name)
            cmd.Parameters.AddWithValue("@Phone", Me._Phone)
            cmd.Parameters.AddWithValue("@eMail", Me._Email)
            myDBconnection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Cliente actualizado con Éxito", MsgBoxStyle.MsgBoxRight, "Cliente Actualizado")
    End Sub
    Public Sub Delete()
        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Try
            Dim cmd As New SqlClient.SqlCommand("DELETE FROM [clientes] WHERE [ID]=@ID", myDBconnection)
            cmd.Parameters.AddWithValue("@ID", Me._ID)
            myDBconnection.Open()
            MsgBox(cmd.ExecuteNonQuery().ToString())
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
        MsgBox("Cliente eliminado con Éxito", MsgBoxStyle.MsgBoxRight, "Cliente Eliminado")
    End Sub
    Public Shared Sub GetData(ByRef _grid As DataGridView)
        If _grid.Rows.Count > 0 Then
            _grid.Rows.Clear()
        End If

        Dim myDBconnection As New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
        Dim reader As SqlClient.SqlDataReader
        Try
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [clientes]", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), reader(2), reader(3), "❌"})
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
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM [clientes] WHERE ( [Telefono] like " & queryValue & " OR [Correo] like " & queryValue & " OR [Cliente] like " & queryValue & " )", myDBconnection)
            myDBconnection.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                _grid.Rows.Add({Int32.Parse(reader(0)), reader(1), reader(2), reader(3), "❌"})
            End While
        Catch ex As ErrorDelete
            MessageBox.Show("Error to delete reg" & ex.Message)
        Finally
            myDBconnection.Close()
        End Try
    End Sub
End Class