Imports QLyDTO
Imports QLyBUS
Imports QLyDAL

Public Class frmTaoTaiKhoan
    Public Function resetdata()
        txbTenTaiKhoan.Text = ""
        txbMatKhau.Text = ""
        txbNhapLaiMatKhau.Text = ""
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'GUI
        Dim ttk As New TaoTaiKhoanDTO
        ttk.TenTaiKhoan = txbTenTaiKhoan.Text
        ttk.MatKhau = txbMatKhau.Text
        ttk.NhapLaiMatKhau = txbNhapLaiMatKhau.Text

        'BUS
        Dim ttkBUS As New TaoTaiKhoanBUS
        If (ttkBUS.ValidTenTaiKhoan(ttk) = False) Then
            MessageBox.Show("Bạn chưa nhập tên tài khoản!")
            txbTenTaiKhoan.Focus()
            Return
        End If

        If (ttkBUS.ValidMatKhau(ttk) = False) Then
            MessageBox.Show("Bạn chưa nhập mật khẩu!")
            txbTenTaiKhoan.Focus()
            Return
        End If

        If (ttkBUS.ValidNhapLaimatKhau(ttk) = False) Then
            MessageBox.Show("Nhập lại mật khẩu không khớp!")
            txbTenTaiKhoan.Focus()
            Return
        End If

        'DAL
        Dim ttkDAL As New TaoTaiKhoanDAL
        Dim result As String = ttkDAL.TaoTaiKhoan(ttk)
        If (result = 0) Then
            MessageBox.Show("Tạo tài khoản thành công!")
        Else
            MessageBox.Show("Tạo tài khoản thất bại!")
        End If
        resetdata()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txbMatKhau.PasswordChar = ""
            txbNhapLaiMatKhau.PasswordChar = ""
        Else
            txbMatKhau.PasswordChar = "*"
            txbNhapLaiMatKhau.PasswordChar = "*"
        End If

    End Sub
End Class