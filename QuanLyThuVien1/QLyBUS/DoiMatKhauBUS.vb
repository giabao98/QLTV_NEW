Imports QLyDTO
Imports QLyDAL

Public Class DoiMatKhauBUS
    Dim dmkDAL As New DoiMatKhauDAL

    Public Function ValidMatKhauHienTai(dmk As DoiMatKhauDTO)
        If (dmk.MatKhauHienTai.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValiMatKhauMoi(dmk As DoiMatKhauDTO)
        If (dmk.MatKhauMoi.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidNhapLaiMatKhau(dmk As DoiMatKhauDTO)
        If (dmk.NhapLaiMatKhau.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidTenTaiKhoan(dmk As DoiMatKhauDTO)
        If (dmk.TenTaiKhoan.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function NhapLaiDung(dmk As DoiMatKhauDTO)
        If (dmk.MatKhauMoi <> dmk.NhapLaiMatKhau) Then
            Return False
        End If
        Return True
    End Function

End Class
