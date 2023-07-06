<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalClient
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
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblClientPhone = New System.Windows.Forms.Label()
        Me.lblClientMail = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAcept = New System.Windows.Forms.Button()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtClientPhone = New System.Windows.Forms.TextBox()
        Me.txtClientMail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(13, 22)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(39, 13)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Cliente"
        '
        'lblClientPhone
        '
        Me.lblClientPhone.AutoSize = True
        Me.lblClientPhone.Location = New System.Drawing.Point(12, 50)
        Me.lblClientPhone.Name = "lblClientPhone"
        Me.lblClientPhone.Size = New System.Drawing.Size(49, 13)
        Me.lblClientPhone.TabIndex = 1
        Me.lblClientPhone.Text = "Telefono"
        '
        'lblClientMail
        '
        Me.lblClientMail.AutoSize = True
        Me.lblClientMail.Location = New System.Drawing.Point(13, 77)
        Me.lblClientMail.Name = "lblClientMail"
        Me.lblClientMail.Size = New System.Drawing.Size(38, 13)
        Me.lblClientMail.TabIndex = 2
        Me.lblClientMail.Text = "Correo"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(201, 121)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAcept
        '
        Me.btnAcept.Location = New System.Drawing.Point(282, 121)
        Me.btnAcept.Name = "btnAcept"
        Me.btnAcept.Size = New System.Drawing.Size(75, 23)
        Me.btnAcept.TabIndex = 4
        Me.btnAcept.Text = "Aceptar"
        Me.btnAcept.UseVisualStyleBackColor = True
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(78, 19)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(279, 20)
        Me.txtClientName.TabIndex = 5
        '
        'txtClientPhone
        '
        Me.txtClientPhone.Location = New System.Drawing.Point(78, 47)
        Me.txtClientPhone.Name = "txtClientPhone"
        Me.txtClientPhone.Size = New System.Drawing.Size(279, 20)
        Me.txtClientPhone.TabIndex = 6
        '
        'txtClientMail
        '
        Me.txtClientMail.Location = New System.Drawing.Point(78, 74)
        Me.txtClientMail.Name = "txtClientMail"
        Me.txtClientMail.Size = New System.Drawing.Size(279, 20)
        Me.txtClientMail.TabIndex = 7
        '
        'modalClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 159)
        Me.Controls.Add(Me.txtClientMail)
        Me.Controls.Add(Me.txtClientPhone)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.btnAcept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblClientMail)
        Me.Controls.Add(Me.lblClientPhone)
        Me.Controls.Add(Me.lblClientName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modalClient"
        Me.Text = "Nuevo Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClientName As Label
    Friend WithEvents lblClientPhone As Label
    Friend WithEvents lblClientMail As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAcept As Button
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents txtClientPhone As TextBox
    Friend WithEvents txtClientMail As TextBox
End Class
