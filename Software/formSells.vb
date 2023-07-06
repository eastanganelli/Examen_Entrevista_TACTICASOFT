Public Class formSells
    Private Sub fClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cSell.GetData(Me.gridSells)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim _modalSell As New modalSell
        _modalSell.ShowDialog()
        'Dim diag_ As New formProducts(True)
        'If diag_.ShowDialog() Then
        '    '...
        'End If

    End Sub
End Class