Public Class modalSell
    Private Property _Venta As cSell
    'Public Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub
    Private Sub modalSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._Venta = New cSell(Me.dpickerSell.Value)
    End Sub
    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        Dim selectClient As New formClients(True),
            res = selectClient.ShowDialog()

        If res = DialogResult.OK Then
            Me._Venta._Client = selectClient.selectedClient
            Me.txtClientName.Text = Me._Venta._Client._Name
            Me.txtClientPhone.Text = Me._Venta._Client._Phone
            Me.txtClientMail.Text = Me._Venta._Client._Email
        End If
    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim selectProduct As New formProducts(True)
        Dim res = selectProduct.ShowDialog()

        If res = DialogResult.OK Then
            Dim auxProduct As cProduct = selectProduct.selectedProduct,
                auxItem As cSellItem = New cSellItem(Me._Venta._Items.Count, -1, auxProduct, Double.Parse(auxProduct._Price), 1, Double.Parse(auxProduct._Price * 1))
            Me._Venta._Items.Add(auxItem)
            Me.gridItems.Rows.Add({auxItem._ID, auxItem._IDSell, auxItem._Product._Name, Double.Parse(auxItem._UnitPrice), auxItem._Count, Double.Parse(auxItem._TotalPrice), "❌"})
            Me._Venta._Total += auxItem._TotalPrice
            Me.txtSellTotal.Text = Me._Venta._Total.ToString()
        End If
    End Sub
    Private Sub gridItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridItems.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim reg_ = Me.gridItems.Rows(e.RowIndex),
                total As Double = 0
            For Each item_ As cSellItem In Me._Venta._Items
                If item_._ID = reg_.Cells(0).Value Then
                    Dim total_ As Double = reg_.Cells(3).Value * reg_.Cells(4).Value
                    reg_.Cells(5).Value = total_
                    item_._Count = reg_.Cells(3).Value
                    item_._TotalPrice = total_
                End If
                total += item_._TotalPrice
            Next
            Me.txtSellTotal.Text = total.ToString("##.##")
        End If
    End Sub
    Private Function TotalCalculation() As Double
        Return 00.00
    End Function
End Class