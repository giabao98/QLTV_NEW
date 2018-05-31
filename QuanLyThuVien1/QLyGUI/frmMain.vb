Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim flogin = New frmLogin()
        flogin.ShowDialog()
    End Sub
End Class