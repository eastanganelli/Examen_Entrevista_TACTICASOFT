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
        Me.gbClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbClient
        '
        Me.gbClient.Controls.Add(Me.lblClientMail)
        Me.gbClient.Controls.Add(Me.lblClientPhone)
        Me.gbClient.Controls.Add(Me.lblClientName)
        Me.gbClient.Location = New System.Drawing.Point(12, 30)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(245, 88)
        Me.gbClient.TabIndex = 0
        Me.gbClient.TabStop = False
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(6, 16)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(45, 13)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Cliente: "
        '
        'lblClientPhone
        '
        Me.lblClientPhone.AutoSize = True
        Me.lblClientPhone.Location = New System.Drawing.Point(6, 37)
        Me.lblClientPhone.Name = "lblClientPhone"
        Me.lblClientPhone.Size = New System.Drawing.Size(55, 13)
        Me.lblClientPhone.TabIndex = 1
        Me.lblClientPhone.Text = "Telefono: "
        '
        'lblClientMail
        '
        Me.lblClientMail.AutoSize = True
        Me.lblClientMail.Location = New System.Drawing.Point(6, 58)
        Me.lblClientMail.Name = "lblClientMail"
        Me.lblClientMail.Size = New System.Drawing.Size(38, 13)
        Me.lblClientMail.TabIndex = 2
        Me.lblClientMail.Text = "Correo"
        '
        'modalSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 550)
        Me.Controls.Add(Me.gbClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "modalSell"
        Me.Text = "Venta"
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbClient As GroupBox
    Friend WithEvents lblClientMail As Label
    Friend WithEvents lblClientPhone As Label
    Friend WithEvents lblClientName As Label
End Class
