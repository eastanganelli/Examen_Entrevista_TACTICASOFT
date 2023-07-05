Public Class ErrorDelete
    Inherits System.ApplicationException
    Public Sub New(ByVal message As String)
        MyBase.New(message)
        MsgBox(message)
    End Sub
End Class
