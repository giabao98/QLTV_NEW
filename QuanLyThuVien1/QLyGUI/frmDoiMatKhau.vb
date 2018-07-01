Imports QLyBUS
Imports QLyDAL
Imports QLyDTO

Public Class frmDoiMatKhau
    Public Function resetdata()
        txbTenTaiKhoan.Text = ""
        txbMatKhauHienTai.Text = ""
        txbMatKhauMoi.Text = ""
        txbNhapLaiMatKhau.Text = ""
    End Function


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txbMatKhauHienTai.PasswordChar = ""
            txbMatKhauMoi.PasswordChar = ""
            txbNhapLaiMatKhau.PasswordChar = ""
        Else
            txbMatKhauHienTai.PasswordChar = "*"
            txbMatKhauMoi.PasswordChar = "*"
            txbNhapLaiMatKhau.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dmk As New DoiMatKhauDTO
        'GUI
        dmk.TenTaiKhoan = txbTenTaiKhoan.Text
        dmk.MatKhauHienTai = txbMatKhauHienTai.Text
        dmk.MatKhauMoi = txbMatKhauMoi.Text
        dmk.NhapLaiMatKhau = txbNhapLaiMatKhau.Text

        'BUS
        Dim dmkBUS As New DoiMatKhauBUS
        If (dmkBUS.ValidTenTaiKhoan(dmk) = False) Then
            MessageBox.Show("Tên tài khoản chưa được nhập!")
            txbTenTaiKhoan.Focus()
            Return
        End If

        If (dmkBUS.ValidMatKhauHienTai(dmk) = False) Then
            MessageBox.Show("Mật khẩu hiện tại chưa được nhập!")
            txbMatKhauHienTai.Focus()
            Return
        End If

        If (dmkBUS.ValiMatKhauMoi(dmk) = False) Then
            MessageBox.Show("Mật khẩu mới chưa được nhập!")
            txbMatKhauMoi.Focus()
            Return
        End If

        If (dmkBUS.ValidNhapLaiMatKhau(dmk) = False) Then
            MessageBox.Show("Chưa nhập lại mật khẩu!")
            txbNhapLaiMatKhau.Focus()
            Return
        End If

        If (dmkBUS.NhapLaiDung(dmk) = False) Then
            MessageBox.Show("Nhập lại mật khẩu không chính xác!")
            txbNhapLaiMatKhau.Focus()
            Return
        End If

        'DAL
        Dim dmkDAL As New DoiMatKhauDAL
        Dim result As Integer = dmkDAL.DoiMatKhau(dmk)
        If (result = 0) Then
            MessageBox.Show("Đổi mật khẩu thành cônng!")
        Else
            MessageBox.Show("Mật khẩu hoặc tên tài khoản không chính xác!")
        End If
        resetdata()

    End Sub
End Class