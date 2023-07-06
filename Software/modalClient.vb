Public Class modalClient
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAcept_Click(sender As Object, e As EventArgs) Handles btnAcept.Click
        Dim newClient As New cClient(Me.txtClientName.Text, Me.txtClientPhone.Text, Me.txtClientMail.Text)
        newClient.Create()
        Me.DialogResult() = DialogResult.OK
        Me.Close()
    End Sub
End Class