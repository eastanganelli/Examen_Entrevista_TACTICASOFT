<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSells
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridSells = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me._ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._View = New System.Windows.Forms.DataGridViewButtonColumn()
        Me._SellItems = New System.Windows.Forms.DataGridViewButtonColumn()
        Me._Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.gridSells, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridSells
        '
        Me.gridSells.AllowUserToAddRows = False
        Me.gridSells.AllowUserToDeleteRows = False
        Me.gridSells.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSells.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSells.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ID, Me._IDCliente, Me._Date, Me._Total, Me._View, Me._SellItems, Me._Delete})
        Me.gridSells.Location = New System.Drawing.Point(12, 34)
        Me.gridSells.Name = "gridSells"
        Me.gridSells.ReadOnly = True
        Me.gridSells.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSells.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gridSells.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gridSells.Size = New System.Drawing.Size(848, 415)
        Me.gridSells.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(12, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 25)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "➕"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.AutoSize = True
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Location = New System.Drawing.Point(239, 5)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(31, 25)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "🔍"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(64, 8)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtboxSearch.TabIndex = 3
        '
        '_ID
        '
        Me._ID.HeaderText = "Codigo"
        Me._ID.Name = "_ID"
        Me._ID.ReadOnly = True
        Me._ID.Width = 65
        '
        '_IDCliente
        '
        Me._IDCliente.HeaderText = "Codigo Cliente"
        Me._IDCliente.Name = "_IDCliente"
        Me._IDCliente.ReadOnly = True
        '
        '_Date
        '
        Me._Date.HeaderText = "Fecha"
        Me._Date.Name = "_Date"
        Me._Date.ReadOnly = True
        Me._Date.Width = 62
        '
        '_Total
        '
        Me._Total.HeaderText = "Total"
        Me._Total.Name = "_Total"
        Me._Total.ReadOnly = True
        Me._Total.Width = 56
        '
        '_View
        '
        Me._View.HeaderText = ""
        Me._View.Name = "_View"
        Me._View.ReadOnly = True
        Me._View.Text = "Ver"
        Me._View.ToolTipText = "Ver"
        Me._View.Width = 5
        '
        '_SellItems
        '
        Me._SellItems.HeaderText = ""
        Me._SellItems.Name = "_SellItems"
        Me._SellItems.ReadOnly = True
        Me._SellItems.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._SellItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me._SellItems.Text = "Modificar"
        Me._SellItems.ToolTipText = "Modificar"
        Me._SellItems.Width = 19
        '
        '_Delete
        '
        Me._Delete.HeaderText = ""
        Me._Delete.Name = "_Delete"
        Me._Delete.ReadOnly = True
        Me._Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me._Delete.Text = "Baja"
        Me._Delete.ToolTipText = "Baja"
        Me._Delete.Width = 19
        '
        'formSells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 461)
        Me.Controls.Add(Me.txtboxSearch)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gridSells)
        Me.MinimumSize = New System.Drawing.Size(888, 500)
        Me.Name = "formSells"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.gridSells, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridSells As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents _ID As DataGridViewTextBoxColumn
    Friend WithEvents _IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents _Date As DataGridViewTextBoxColumn
    Friend WithEvents _Total As DataGridViewTextBoxColumn
    Friend WithEvents _View As DataGridViewButtonColumn
    Friend WithEvents _SellItems As DataGridViewButtonColumn
    Friend WithEvents _Delete As DataGridViewButtonColumn
End Class
