Public Class DoiMatKhauDTO
    Private strMatKhauHienTai As String
    Private strMatKhauMoi As String
    Private strNhapLaiMatKhau As String
    Private strTenTaiKhoan As String

    Public Property MatKhauHienTai As String
        Get
            Return strMatKhauHienTai
        End Get
        Set
            strMatKhauHienTai = Value
        End Set
    End Property

    Public Property MatKhauMoi As String
        Get
            Return strMatKhauMoi
        End Get
        Set
            strMatKhauMoi = Value
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

    Public Property TenTaiKhoan As String
        Get
            Return strTenTaiKhoan
        End Get
        Set
            strTenTaiKhoan = Value
        End Set
    End Property
End Class
