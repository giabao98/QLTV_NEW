Public Class frmHeThong
    Private Sub btnTaoTaiKhoan_Click(sender As Object, e As EventArgs) Handles btnTaoTaiKhoan.Click
        Dim fttk As New frmTaoTaiKhoan
        fttk.ShowDialog()
    End Sub

    Private Sub btnDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btnDoiMatKhau.Click
        Dim fdmk As New frmDoiMatKhau
        fdmk.ShowDialog()
    End Sub
End Class