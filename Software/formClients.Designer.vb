<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClients
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
        Me.gridClients = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        CType(Me.gridClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridClients
        '
        Me.gridClients.AllowUserToAddRows = False
        Me.gridClients.AllowUserToDeleteRows = False
        Me.gridClients.AllowUserToResizeColumns = False
        Me.gridClients.AllowUserToResizeRows = False
        Me.gridClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Client, Me.Phone, Me.Email, Me._delete})
        Me.gridClients.Location = New System.Drawing.Point(12, 34)
        Me.gridClients.Name = "gridClients"
        Me.gridClients.Size = New System.Drawing.Size(848, 415)
        Me.gridClients.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 43
        '
        'Client
        '
        Me.Client.HeaderText = "Cliente"
        Me.Client.Name = "Client"
        Me.Client.Width = 64
        '
        'Phone
        '
        Me.Phone.HeaderText = "Telefono"
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 74
        '
        'Email
        '
        Me.Email.HeaderText = "Correo"
        Me.Email.Name = "Email"
        Me.Email.Width = 63
        '
        '_delete
        '
        Me._delete.HeaderText = ""
        Me._delete.Name = "_delete"
        Me._delete.Text = ""
        Me._delete.Width = 5
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(64, 7)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(169, 20)
        Me.txtboxSearch.TabIndex = 6
        '
        'btnFind
        '
        Me.btnFind.AutoSize = True
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Location = New System.Drawing.Point(239, 4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(31, 25)
        Me.btnFind.TabIndex = 5
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
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "➕"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.AutoSize = True
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Location = New System.Drawing.Point(785, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 25)
        Me.btnSelect.TabIndex = 7
        Me.btnSelect.Text = "Seleccionar"
        Me.btnSelect.UseVisualStyleBackColor = True
        Me.btnSelect.Visible = False
        '
        'formClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 461)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtboxSearch)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gridClients)
        Me.MinimumSize = New System.Drawing.Size(888, 500)
        Me.Name = "formClients"
        Me.Text = "Clientes"
        CType(Me.gridClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridClients As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents _delete As DataGridViewButtonColumn
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSelect As Button
End Class
