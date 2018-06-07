Public Class frmFind
    Private Sub frmFind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click
        Dim fFindBook = New frmFindBook
        Me.Close()
        fFindBook.ShowDialog()
    End Sub

    Private Sub btnFindReader_Click(sender As Object, e As EventArgs) Handles btnFindReader.Click
        Dim fFindReader = New frmFindReader
        Me.Close()
        fFindReader.ShowDialog()
    End Sub
End Class