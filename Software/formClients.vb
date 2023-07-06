Public Class formClients
    Public Sub New(ByVal modal_ As Boolean)
        InitializeComponent()
        If modal_ Then
            Me.gridClients.EditMode = False
            Me.gridClients.Columns(4).Visible = False
            Me.btnAdd.Visible = False
        End If
    End Sub
    Private Sub formClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cClient.GetData(Me.gridClients)
    End Sub
    Private Sub gridClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridClients.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim _rmClient As New cClient(Me.gridClients.Rows(e.RowIndex).Cells(0).Value)
            _rmClient.Delete()
            cClient.GetData(Me.gridClients)
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addClientModal As New modalClient
        Dim res = addClientModal.ShowDialog()

        If res = DialogResult.OK Then
            cClient.GetData(Me.gridClients)
        End If
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If Me.txtboxSearch.TextLength > 0 And Me.txtboxSearch.Text IsNot "" Then
            cClient.Filter(Me.gridClients, Me.txtboxSearch.Text)
        Else
            cClient.GetData(Me.gridClients)
        End If
    End Sub
    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If Me.txtboxSearch.TextLength > 0 And Me.txtboxSearch.Text IsNot "" Then
            cClient.Filter(Me.gridClients, Me.txtboxSearch.Text)
        Else
            cClient.GetData(Me.gridClients)
        End If
    End Sub
    Private Sub gridClients_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridClients.CellEndEdit
        Dim _id As Int32 = Me.gridClients.Rows(e.RowIndex).Cells(0).Value
        Dim _client As String = Me.gridClients.Rows(e.RowIndex).Cells(1).Value
        Dim _phone As String = Me.gridClients.Rows(e.RowIndex).Cells(2).Value
        Dim _mail As String = Me.gridClients.Rows(e.RowIndex).Cells(3).Value
        Dim auxClient As New cClient(_id, _client, _phone, _mail)
        auxClient.Update()
    End Sub
End Class