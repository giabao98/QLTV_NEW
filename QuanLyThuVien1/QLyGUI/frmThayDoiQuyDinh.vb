Public Class frmThayDoiQuyDinh
    Private Sub btnLoaiDocGia_Click(sender As Object, e As EventArgs) Handles btnQuyDinhTheLoaiSach.Click
        Dim ldg = New frmQuyDinhTheLoaiSach
        ldg.ShowDialog()
    End Sub

    Private Sub btnQuyDinhDocGia_Click(sender As Object, e As EventArgs) Handles btnQuyDinhDocGia.Click
        Dim fQuyDinhDG As New frmQuyDinhDocGia
        fQuyDinhDG.ShowDialog()
    End Sub

    Private Sub btnQuyDinhMuonSach_Click(sender As Object, e As EventArgs) Handles btnQuyDinhMuonSach.Click
        Dim fQuyDinhMuonSach As New frmQuyDinhMuonSach
        fQuyDinhMuonSach.ShowDialog()
    End Sub
End Class