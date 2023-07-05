Public Class formSells
    Private Sub fClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _clients As New List(Of cClient)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim diag_ As New formProducts
        If diag_.ShowDialog() Then
            '...
        End If

    End Sub
End Class