<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gridProducts = New System.Windows.Forms.DataGridView()
        Me._ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridProducts
        '
        Me.gridProducts.AllowUserToAddRows = False
        Me.gridProducts.AllowUserToDeleteRows = False
        Me.gridProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ID, Me._Name, Me._Price, Me._Category, Me._Delete})
        Me.gridProducts.Location = New System.Drawing.Point(12, 34)
        Me.gridProducts.Name = "gridProducts"
        Me.gridProducts.Size = New System.Drawing.Size(848, 415)
        Me.gridProducts.TabIndex = 1
        '
        '_ID
        '
        Me._ID.HeaderText = "ID"
        Me._ID.Name = "_ID"
        Me._ID.Width = 43
        '
        '_Name
        '
        Me._Name.HeaderText = "Nombre"
        Me._Name.Name = "_Name"
        Me._Name.Width = 69
        '
        '_Price
        '
        Me._Price.HeaderText = "Precio"
        Me._Price.Name = "_Price"
        Me._Price.Width = 62
        '
        '_Category
        '
        Me._Category.HeaderText = "Category"
        Me._Category.Name = "_Category"
        Me._Category.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._Category.Width = 74
        '
        '_Delete
        '
        Me._Delete.HeaderText = ""
        Me._Delete.Name = "_Delete"
        Me._Delete.ReadOnly = True
        Me._Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me._Delete.Width = 19
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(64, 7)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtboxSearch.TabIndex = 9
        '
        'btnFind
        '
        Me.btnFind.AutoSize = True
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Location = New System.Drawing.Point(239, 4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(31, 25)
        Me.btnFind.TabIndex = 8
        Me.btnFind.Text = "🔍"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(12, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "➕"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'formProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 461)
        Me.Controls.Add(Me.txtboxSearch)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gridProducts)
        Me.MinimumSize = New System.Drawing.Size(888, 500)
        Me.Name = "formProducts"
        Me.Text = "Productos"
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridProducts As DataGridView
    Friend WithEvents _ID As DataGridViewTextBoxColumn
    Friend WithEvents _Name As DataGridViewTextBoxColumn
    Friend WithEvents _Price As DataGridViewTextBoxColumn
    Friend WithEvents _Category As DataGridViewTextBoxColumn
    Friend WithEvents _Delete As DataGridViewButtonColumn
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnAdd As Button
End Class
