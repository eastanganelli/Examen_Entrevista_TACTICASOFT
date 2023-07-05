Public Class formClients
    Private Sub formClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cClient.GetClients(Me.gridClients)
    End Sub
    Private Sub gridClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridClients.CellContentClick
        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
            Dim _rmClient As New cClient(Me.gridClients.Rows(e.RowIndex).Cells(0).Value)
            _rmClient.Delete()
            Me.gridClients.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class