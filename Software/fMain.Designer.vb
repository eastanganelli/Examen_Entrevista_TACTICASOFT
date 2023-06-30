<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Me.components = New System.ComponentModel.Container()
        Me.tcClientProducts = New System.Windows.Forms.TabControl()
        Me.tpClient = New System.Windows.Forms.TabPage()
        Me.tpProducts = New System.Windows.Forms.TabPage()
        Me.dsPruebademo = New Software.pruebademoDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.taClientes = New Software.pruebademoDataSetTableAdapters.clientesTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.taProductos = New Software.pruebademoDataSetTableAdapters.productosTableAdapter()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcClientProducts.SuspendLayout()
        Me.tpClient.SuspendLayout()
        Me.tpProducts.SuspendLayout()
        CType(Me.dsPruebademo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcClientProducts
        '
        Me.tcClientProducts.Controls.Add(Me.tpClient)
        Me.tcClientProducts.Controls.Add(Me.tpProducts)
        Me.tcClientProducts.Location = New System.Drawing.Point(0, 24)
        Me.tcClientProducts.Name = "tcClientProducts"
        Me.tcClientProducts.SelectedIndex = 0
        Me.tcClientProducts.Size = New System.Drawing.Size(800, 426)
        Me.tcClientProducts.TabIndex = 0
        '
        'tpClient
        '
        Me.tpClient.Controls.Add(Me.DataGridView1)
        Me.tpClient.Location = New System.Drawing.Point(4, 22)
        Me.tpClient.Name = "tpClient"
        Me.tpClient.Padding = New System.Windows.Forms.Padding(3)
        Me.tpClient.Size = New System.Drawing.Size(792, 424)
        Me.tpClient.TabIndex = 0
        Me.tpClient.Text = "Clientes"
        Me.tpClient.UseVisualStyleBackColor = True
        '
        'tpProducts
        '
        Me.tpProducts.Controls.Add(Me.DataGridView2)
        Me.tpProducts.Location = New System.Drawing.Point(4, 22)
        Me.tpProducts.Name = "tpProducts"
        Me.tpProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProducts.Size = New System.Drawing.Size(792, 400)
        Me.tpProducts.TabIndex = 1
        Me.tpProducts.Text = "Productos"
        Me.tpProducts.UseVisualStyleBackColor = True
        '
        'dsPruebademo
        '
        Me.dsPruebademo.DataSetName = "pruebademoDataSet"
        Me.dsPruebademo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsClientes
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(786, 418)
        Me.DataGridView1.TabIndex = 0
        '
        'bsClientes
        '
        Me.bsClientes.DataMember = "clientes"
        Me.bsClientes.DataSource = Me.dsPruebademo
        '
        'taClientes
        '
        Me.taClientes.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 75
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 75
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.Width = 64
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 74
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 63
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.bsProductos
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(786, 394)
        Me.DataGridView2.TabIndex = 0
        '
        'bsProductos
        '
        Me.bsProductos.DataMember = "productos"
        Me.bsProductos.DataSource = Me.dsPruebademo
        '
        'taProductos
        '
        Me.taProductos.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tcClientProducts)
        Me.Name = "fMain"
        Me.Text = "TACTISOFT"
        Me.tcClientProducts.ResumeLayout(False)
        Me.tpClient.ResumeLayout(False)
        Me.tpProducts.ResumeLayout(False)
        CType(Me.dsPruebademo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcClientProducts As TabControl
    Friend WithEvents tpClient As TabPage
    Friend WithEvents tpProducts As TabPage
    Friend WithEvents dsPruebademo As pruebademoDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bsClientes As BindingSource
    Friend WithEvents taClientes As pruebademoDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents bsProductos As BindingSource
    Friend WithEvents taProductos As pruebademoDataSetTableAdapters.productosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
