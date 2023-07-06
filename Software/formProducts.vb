Public Class formProducts
    Private _SelectMode As Boolean
    Public Sub New(ByVal mode_ As Boolean)
        If mode_ Then
            Me.gridProducts.Columns(5).Visible = False
            Me.gridProducts.EditMode = False
            Me.gridProducts.ReadOnly = True
            Me.btnAdd.Visible = False
        End If
        InitializeComponent()
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
End Class