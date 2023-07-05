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
        Me.gridSells = New System.Windows.Forms.DataGridView()
        Me._ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._SellItems = New System.Windows.Forms.DataGridViewButtonColumn()
        Me._Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.gridSells, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridSells
        '
        Me.gridSells.AllowUserToAddRows = False
        Me.gridSells.AllowUserToDeleteRows = False
        Me.gridSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSells.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ID, Me._Total, Me._IDCliente, Me._Date, Me._SellItems, Me._Delete})
        Me.gridSells.Location = New System.Drawing.Point(12, 45)
        Me.gridSells.Name = "gridSells"
        Me.gridSells.Size = New System.Drawing.Size(886, 393)
        Me.gridSells.TabIndex = 0
        '
        '_ID
        '
        Me._ID.HeaderText = "ID"
        Me._ID.Name = "_ID"
        Me._ID.Width = 43
        '
        '_Total
        '
        Me._Total.HeaderText = "Total"
        Me._Total.Name = "_Total"
        Me._Total.ReadOnly = True
        Me._Total.Width = 56
        '
        '_IDCliente
        '
        Me._IDCliente.HeaderText = "ID Cliente"
        Me._IDCliente.Name = "_IDCliente"
        Me._IDCliente.Width = 78
        '
        '_Date
        '
        Me._Date.HeaderText = "Fecha"
        Me._Date.Name = "_Date"
        Me._Date.Width = 62
        '
        '_SellItems
        '
        Me._SellItems.HeaderText = "Items"
        Me._SellItems.Name = "_SellItems"
        Me._SellItems.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._SellItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me._SellItems.Width = 57
        '
        '_Delete
        '
        Me._Delete.HeaderText = "Baja"
        Me._Delete.Name = "_Delete"
        Me._Delete.ReadOnly = True
        Me._Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me._Delete.Width = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formSells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gridSells)
        Me.MinimumSize = New System.Drawing.Size(926, 489)
        Me.Name = "formSells"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.gridSells, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridSells As DataGridView
    Friend WithEvents _ID As DataGridViewTextBoxColumn
    Friend WithEvents _Total As DataGridViewTextBoxColumn
    Friend WithEvents _IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents _Date As DataGridViewTextBoxColumn
    Friend WithEvents _SellItems As DataGridViewButtonColumn
    Friend WithEvents _Delete As DataGridViewButtonColumn
    Friend WithEvents Button1 As Button
End Class
