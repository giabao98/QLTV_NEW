Imports QLyBUS
Imports QLyDTO


Public Class frmFindBook
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnFind1_Click(sender As Object, e As EventArgs) Handles btnFind1.Click

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim fb As FindBookDTO
        fb = New FindBookDTO

        fb.Kind = cbbKind.Text
        fb.Find = txbFind.Text

        'BUS kiem tra
        Dim ValidFindBook As FindBookBUS
        ValidFindBook = New FindBookBUS

        If (ValidFindBook.ValidKindOfFind(fb) = False) Then

        End If


    End Sub
End Class