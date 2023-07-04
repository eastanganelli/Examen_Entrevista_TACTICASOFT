﻿Public Class Product
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
    Public Sub New(_ID As Int32, _Name As String, _Price As Double, _Category As String)
        Me._ID = _ID
        Me._Name = _Name
        Me._Price = _Price
        Me._Category = _Category
    End Sub
    Public Function to_String() As String
        Return ("[" + Me._ID + "] " + Me._Category + " - " + Me._Name + " $" + Me._Price).ToString()
    End Function
End Class