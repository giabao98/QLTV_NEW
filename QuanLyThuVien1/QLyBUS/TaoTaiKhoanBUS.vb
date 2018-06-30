Imports QLyDTO

Public Class TaoTaiKhoanBUS
    Public Function ValidTenTaiKhoan(ttk As TaoTaiKhoanDTO)
        If (ttk.TenTaiKhoan.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidMatKhau(ttk As TaoTaiKhoanDTO)
        If (ttk.MatKhau.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidNhapLaimatKhau(ttk As TaoTaiKhoanDTO)
        If (ttk.NhapLaiMatKhau <> ttk.MatKhau) Then
            Return False
        End If
        Return True
    End Function
End Class
