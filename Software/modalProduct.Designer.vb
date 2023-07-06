<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalProduct
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
        Me.txtProductCategory = New System.Windows.Forms.TextBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnAcept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblProductCategory = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtProductCategory
        '
        Me.txtProductCategory.Location = New System.Drawing.Point(79, 72)
        Me.txtProductCategory.Name = "txtProductCategory"
        Me.txtProductCategory.Size = New System.Drawing.Size(279, 20)
        Me.txtProductCategory.TabIndex = 15
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(79, 45)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(279, 20)
        Me.txtProductPrice.TabIndex = 14
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(79, 17)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(279, 20)
        Me.txtProductName.TabIndex = 13
        '
        'btnAcept
        '
        Me.btnAcept.Location = New System.Drawing.Point(283, 119)
        Me.btnAcept.Name = "btnAcept"
        Me.btnAcept.Size = New System.Drawing.Size(75, 23)
        Me.btnAcept.TabIndex = 12
        Me.btnAcept.Text = "Aceptar"
        Me.btnAcept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(202, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblProductCategory
        '
        Me.lblProductCategory.AutoSize = True
        Me.lblProductCategory.Location = New System.Drawing.Point(14, 75)
        Me.lblProductCategory.Name = "lblProductCategory"
        Me.lblProductCategory.Size = New System.Drawing.Size(52, 13)
        Me.lblProductCategory.TabIndex = 10
        Me.lblProductCategory.Text = "Categoria"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(13, 48)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(37, 13)
        Me.lblProductPrice.TabIndex = 9
        Me.lblProductPrice.Text = "Precio"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(14, 20)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(44, 13)
        Me.lblProductName.TabIndex = 8
        Me.lblProductName.Text = "Nombre"
        '
        'modalProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 159)
        Me.Controls.Add(Me.txtProductCategory)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.btnAcept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblProductCategory)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modalProduct"
        Me.Text = "Nuevo Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductCategory As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnAcept As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductName As Label
End Class
