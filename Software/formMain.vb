Imports System.Windows.Forms

Public Class formMain
    Private Sub fMain__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub formMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each f As Form In Application.OpenForms
            f.Close()
        Next
    End Sub
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is formProducts Then
                f.Activate()
                Return
            End If
        Next

        Dim _child As New formProducts
        _child.MdiParent = Me
        _child.Show()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is formClients Then
                f.Activate()
                Return
            End If
        Next

        Dim _child As New formClients
        _child.MdiParent = Me
        _child.Show()
    End Sub
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is formSells Then
                f.Activate()
                Return
            End If
        Next

        Dim _child As New formSells
        _child.MdiParent = Me
        _child.Show()
    End Sub
End Class
