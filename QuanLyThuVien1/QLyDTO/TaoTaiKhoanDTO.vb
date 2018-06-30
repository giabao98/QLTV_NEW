Public Class TaoTaiKhoanDTO
    Private strTenTaiKhoan As String
    Private strMatKhau As String
    Private strNhapLaiMatKhau As String

    Public Property TenTaiKhoan As String
        Get
            Return strTenTaiKhoan
        End Get
        Set
            strTenTaiKhoan = Value
        End Set
    End Property

    Public Property MatKhau As String
        Get
            Return strMatKhau
        End Get
        Set
            strMatKhau = Value
        End Set
    End Property

    Public Property NhapLaiMatKhau As String
        Get
            Return strNhapLaiMatKhau
        End Get
        Set
            strNhapLaiMatKhau = Value
        End Set
    End Property
End Class
