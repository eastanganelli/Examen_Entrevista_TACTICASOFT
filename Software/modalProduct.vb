Public Class modalProduct
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnAcept_Click(sender As Object, e As EventArgs) Handles btnAcept.Click
        Dim newClient As New cProduct(Me.txtProductName.Text, Double.Parse(Me.txtProductPrice.Text), Me.txtProductCategory.Text)
        newClient.Create()
        Me.DialogResult() = DialogResult.OK
        Me.Close()
    End Sub
End Class