Public Class frmThayDoiQuyDinh
    Private Sub btnLoaiDocGia_Click(sender As Object, e As EventArgs) Handles btnLoaiDocGia.Click
        Dim ldg = New frmLoaiDocGia
        ldg.ShowDialog()
    End Sub
End Class