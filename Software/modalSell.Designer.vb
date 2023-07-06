<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalSell
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
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblClientPhone = New System.Windows.Forms.Label()
        Me.lblClientMail = New System.Windows.Forms.Label()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtClientPhone = New System.Windows.Forms.TextBox()
        Me.txtClientMail = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSellTotal = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblSellTotal = New System.Windows.Forms.Label()
        Me.lblSellDate = New System.Windows.Forms.Label()
        Me.lblIDSell = New System.Windows.Forms.Label()
        Me.dpickerSell = New System.Windows.Forms.DateTimePicker()
        Me.gridItems = New System.Windows.Forms.DataGridView()
        Me.btnAddSell = New System.Windows.Forms.Button()
        Me._ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._IDSell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.gbClient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbClient
        '
        Me.gbClient.Controls.Add(Me.txtClientMail)
        Me.gbClient.Controls.Add(Me.txtClientPhone)
        Me.gbClient.Controls.Add(Me.txtClientName)
        Me.gbClient.Controls.Add(Me.lblClientMail)
        Me.gbClient.Controls.Add(Me.lblClientPhone)
        Me.gbClient.Controls.Add(Me.lblClientName)
        Me.gbClient.Location = New System.Drawing.Point(331, 41)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(253, 97)
        Me.gbClient.TabIndex = 0
        Me.gbClient.TabStop = False
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClientName.Location = New System.Drawing.Point(6, 18)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(45, 13)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Cliente: "
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClientPhone
        '
        Me.lblClientPhone.AutoSize = True
        Me.lblClientPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClientPhone.Location = New System.Drawing.Point(6, 44)
        Me.lblClientPhone.Name = "lblClientPhone"
        Me.lblClientPhone.Size = New System.Drawing.Size(55, 13)
        Me.lblClientPhone.TabIndex = 1
        Me.lblClientPhone.Text = "Telefono: "
        Me.lblClientPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClientMail
        '
        Me.lblClientMail.AutoSize = True
        Me.lblClientMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClientMail.Location = New System.Drawing.Point(6, 70)
        Me.lblClientMail.Name = "lblClientMail"
        Me.lblClientMail.Size = New System.Drawing.Size(38, 13)
        Me.lblClientMail.TabIndex = 2
        Me.lblClientMail.Text = "Correo"
        Me.lblClientMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddClient
        '
        Me.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClient.Location = New System.Drawing.Point(331, 12)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(75, 23)
        Me.btnAddClient.TabIndex = 3
        Me.btnAddClient.Text = "🔍 Cliente"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'txtClientName
        '
        Me.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientName.Location = New System.Drawing.Point(73, 15)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(166, 20)
        Me.txtClientName.TabIndex = 4
        '
        'txtClientPhone
        '
        Me.txtClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientPhone.Location = New System.Drawing.Point(73, 41)
        Me.txtClientPhone.Name = "txtClientPhone"
        Me.txtClientPhone.ReadOnly = True
        Me.txtClientPhone.Size = New System.Drawing.Size(166, 20)
        Me.txtClientPhone.TabIndex = 5
        '
        'txtClientMail
        '
        Me.txtClientMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientMail.Location = New System.Drawing.Point(73, 67)
        Me.txtClientMail.Name = "txtClientMail"
        Me.txtClientMail.ReadOnly = True
        Me.txtClientMail.Size = New System.Drawing.Size(166, 20)
        Me.txtClientMail.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dpickerSell)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.lblSellDate)
        Me.GroupBox1.Controls.Add(Me.lblIDSell)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 83)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txtSellTotal
        '
        Me.txtSellTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSellTotal.Location = New System.Drawing.Point(98, 535)
        Me.txtSellTotal.Name = "txtSellTotal"
        Me.txtSellTotal.ReadOnly = True
        Me.txtSellTotal.Size = New System.Drawing.Size(205, 20)
        Me.txtSellTotal.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(73, 22)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(205, 20)
        Me.TextBox3.TabIndex = 4
        '
        'lblSellTotal
        '
        Me.lblSellTotal.AutoSize = True
        Me.lblSellTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSellTotal.Location = New System.Drawing.Point(31, 538)
        Me.lblSellTotal.Name = "lblSellTotal"
        Me.lblSellTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblSellTotal.TabIndex = 2
        Me.lblSellTotal.Text = "Total $:"
        Me.lblSellTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSellDate
        '
        Me.lblSellDate.AutoSize = True
        Me.lblSellDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSellDate.Location = New System.Drawing.Point(6, 51)
        Me.lblSellDate.Name = "lblSellDate"
        Me.lblSellDate.Size = New System.Drawing.Size(55, 13)
        Me.lblSellDate.TabIndex = 1
        Me.lblSellDate.Text = "Telefono: "
        Me.lblSellDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIDSell
        '
        Me.lblIDSell.AutoSize = True
        Me.lblIDSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIDSell.Location = New System.Drawing.Point(6, 25)
        Me.lblIDSell.Name = "lblIDSell"
        Me.lblIDSell.Size = New System.Drawing.Size(46, 13)
        Me.lblIDSell.TabIndex = 0
        Me.lblIDSell.Text = "Codigo: "
        Me.lblIDSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dpickerSell
        '
        Me.dpickerSell.Location = New System.Drawing.Point(73, 48)
        Me.dpickerSell.Name = "dpickerSell"
        Me.dpickerSell.Size = New System.Drawing.Size(205, 20)
        Me.dpickerSell.TabIndex = 5
        '
        'gridItems
        '
        Me.gridItems.AllowUserToAddRows = False
        Me.gridItems.AllowUserToDeleteRows = False
        Me.gridItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ID, Me._IDSell, Me._ProductName, Me._UnitPrice, Me._Count, Me._Price, Me._delete})
        Me.gridItems.Location = New System.Drawing.Point(12, 169)
        Me.gridItems.Name = "gridItems"
        Me.gridItems.Size = New System.Drawing.Size(660, 350)
        Me.gridItems.TabIndex = 5
        '
        'btnAddSell
        '
        Me.btnAddSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSell.Location = New System.Drawing.Point(537, 533)
        Me.btnAddSell.Name = "btnAddSell"
        Me.btnAddSell.Size = New System.Drawing.Size(135, 23)
        Me.btnAddSell.TabIndex = 7
        Me.btnAddSell.Text = "Generar Venta"
        Me.btnAddSell.UseVisualStyleBackColor = True
        '
        '_ID
        '
        Me._ID.HeaderText = "Codigo Item"
        Me._ID.Name = "_ID"
        Me._ID.ReadOnly = True
        Me._ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me._ID.Visible = False
        '
        '_IDSell
        '
        Me._IDSell.HeaderText = "Codigo Venta"
        Me._IDSell.Name = "_IDSell"
        Me._IDSell.ReadOnly = True
        Me._IDSell.Visible = False
        '
        '_ProductName
        '
        Me._ProductName.HeaderText = "Producto"
        Me._ProductName.Name = "_ProductName"
        Me._ProductName.ReadOnly = True
        Me._ProductName.ToolTipText = "Nombre Producto"
        Me._ProductName.Width = 75
        '
        '_UnitPrice
        '
        Me._UnitPrice.HeaderText = "Precio Unitario"
        Me._UnitPrice.Name = "_UnitPrice"
        Me._UnitPrice.ReadOnly = True
        Me._UnitPrice.Width = 101
        '
        '_Count
        '
        Me._Count.HeaderText = "Cantidad"
        Me._Count.Name = "_Count"
        Me._Count.Width = 74
        '
        '_Price
        '
        Me._Price.HeaderText = "Total"
        Me._Price.Name = "_Price"
        Me._Price.ReadOnly = True
        Me._Price.ToolTipText = "Precio Total"
        Me._Price.Width = 56
        '
        '_delete
        '
        Me._delete.HeaderText = ""
        Me._delete.Name = "_delete"
        Me._delete.Width = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Location = New System.Drawing.Point(12, 140)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 8
        Me.btnAddItem.Text = "🔍 Producto"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'modalSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 570)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnAddSell)
        Me.Controls.Add(Me.gridItems)
        Me.Controls.Add(Me.txtSellTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.lblSellTotal)
        Me.Controls.Add(Me.gbClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(700, 900)
        Me.MinimumSize = New System.Drawing.Size(700, 0)
        Me.Name = "modalSell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbClient As GroupBox
    Friend WithEvents lblClientMail As Label
    Friend WithEvents lblClientPhone As Label
    Friend WithEvents lblClientName As Label
    Friend WithEvents txtClientMail As TextBox
    Friend WithEvents txtClientPhone As TextBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents btnAddClient As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dpickerSell As DateTimePicker
    Friend WithEvents txtSellTotal As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblSellTotal As Label
    Friend WithEvents lblSellDate As Label
    Friend WithEvents lblIDSell As Label
    Friend WithEvents gridItems As DataGridView
    Friend WithEvents _ID As DataGridViewTextBoxColumn
    Friend WithEvents _IDSell As DataGridViewTextBoxColumn
    Friend WithEvents _ProductName As DataGridViewTextBoxColumn
    Friend WithEvents _UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents _Count As DataGridViewTextBoxColumn
    Friend WithEvents _Price As DataGridViewTextBoxColumn
    Friend WithEvents _delete As DataGridViewButtonColumn
    Friend WithEvents btnAddSell As Button
    Friend WithEvents btnAddItem As Button
End Class
