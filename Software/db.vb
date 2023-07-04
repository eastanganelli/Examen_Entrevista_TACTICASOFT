Module db
    'Public myDBconnection As SqlClient.SqlConnection
    'Public Sub OpenDB()
    '    Try
    '        myDBconnection = New SqlClient.SqlConnection(My.Settings.pruebademoConnection)
    '        myDBconnection.Open()
    '    Catch ex As SqlClient.SqlException
    '        MsgBox("Error to connect to DB", MsgBoxStyle.OkOnly, "Error DB Connnection")
    '    Catch ex As Exception
    '        Debug.WriteLine(ex.Message)
    '    End Try
    '    'MsgBox("Success DB Connection")
    'End Sub
    'Public Sub CloseDB()
    '    myDBconnection.Close()
    'End Sub
End Module