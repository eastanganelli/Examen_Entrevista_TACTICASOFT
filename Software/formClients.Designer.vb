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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtsearchClient = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearchClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.addClient = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.gridClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridClients
        '
        Me.gridClients.AllowUserToAddRows = False
        Me.gridClients.AllowUserToDeleteRows = False
        Me.gridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Client, Me.Phone, Me.Email, Me._delete})
        Me.gridClients.Location = New System.Drawing.Point(0, 27)
        Me.gridClients.Name = "gridClients"
        Me.gridClients.Size = New System.Drawing.Size(800, 423)
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
        Me._delete.HeaderText = "Eliminar"
        Me._delete.Name = "_delete"
        Me._delete.Text = "Eliminar"
        Me._delete.Width = 49
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ToolStripMenuItem2, Me.addClient, Me.ToolStripMenuItem1, Me.txtsearchClient, Me.btnSearchClient})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtsearchClient
        '
        Me.txtsearchClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearchClient.Name = "txtsearchClient"
        Me.txtsearchClient.Size = New System.Drawing.Size(200, 23)
        '
        'btnSearchClient
        '
        Me.btnSearchClient.Name = "btnSearchClient"
        Me.btnSearchClient.Size = New System.Drawing.Size(54, 23)
        Me.btnSearchClient.Text = "Buscar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 23)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 23)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'addClient
        '
        Me.addClient.Name = "addClient"
        Me.addClient.Size = New System.Drawing.Size(40, 23)
        Me.addClient.Text = "Alta"
        '
        'formClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gridClients)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formClients"
        Me.Text = "Clientes"
        CType(Me.gridClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridClients As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents _delete As DataGridViewButtonColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtsearchClient As ToolStripTextBox
    Friend WithEvents btnSearchClient As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents addClient As ToolStripMenuItem
End Class
