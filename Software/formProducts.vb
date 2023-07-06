Public Class formProducts
    Public Property selectedProduct As cProduct
    Public Sub New(ByVal modal_ As Boolean)
        InitializeComponent()
        If modal_ Then
            Me.gridProducts.EditMode = False
            Me.gridProducts.Columns(4).Visible = False
            Me.btnAdd.Visible = False
            Me.gridProducts.ReadOnly = True
            Me.btnSelect.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addClientModal As New modalProduct
        Dim res = addClientModal.ShowDialog()

        If res = DialogResult.OK Then
            cProduct.GetData(Me.gridProducts)
        End If
    End Sub

    Private Sub formProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cProduct.GetData(Me.gridProducts)
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If Me.txtboxSearch.TextLength > 0 And Me.txtboxSearch.Text IsNot "" Then
            cProduct.Filter(Me.gridProducts, Me.txtboxSearch.Text)
        Else
            cProduct.GetData(Me.gridProducts)
        End If
    End Sub
    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If Me.txtboxSearch.TextLength > 0 And Me.txtboxSearch.Text IsNot "" Then
            cProduct.Filter(Me.gridProducts, Me.txtboxSearch.Text)
        Else
            cProduct.GetData(Me.gridProducts)
        End If
    End Sub
    Private Sub gridProducts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridProducts.CellEndEdit
        Dim _id As Int32 = Me.gridProducts.Rows(e.RowIndex).Cells(0).Value
        Dim _name As String = Me.gridProducts.Rows(e.RowIndex).Cells(1).Value
        Dim _price As String = Me.gridProducts.Rows(e.RowIndex).Cells(2).Value
        Dim _category As String = Me.gridProducts.Rows(e.RowIndex).Cells(3).Value
        Dim auxClient As New cProduct(_id, _name, Double.Parse(_price), _category)
        auxClient.Update()
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If Me.gridProducts.SelectedRows.Count = 1 Then
            For Each Row In Me.gridProducts.SelectedRows
                Me.selectedProduct = New cProduct(Int32.Parse(Row.Cells(0).Value), Row.Cells(1).Value, Double.Parse(Row.Cells(2).Value), Row.Cells(3).Value)
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Tiene que seleccionar un producto", MsgBoxStyle.Information, "Producto")
        End If
    End Sub
End Class