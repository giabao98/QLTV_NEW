Public Class MuonTraSachDTO
    Private strMaDocGia As String
    Private strTenDocGia As String
    Private strMaSach As String
    Private strTenSach As String
    Private strTheLoai As String
    Private strTacGia As String
    Private strMaPhieuMuon As String
    Private dtpNgayMuon As Date
    Private intSoLuongMuon As Integer
    Private dtpNgayTra As Date
    Private strXacNhanTra As String
    Private strGhiChu As String

    Public Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Public Property TenDocGia As String
        Get
            Return strTenDocGia
        End Get
        Set(value As String)
            strTenDocGia = value
        End Set
    End Property

    Public Property MaSach As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property TheLoai As String
        Get
            Return strTheLoai
        End Get
        Set(value As String)
            strTheLoai = value
        End Set
    End Property

    Public Property TacGia As String
        Get
            Return strTacGia
        End Get
        Set(value As String)
            strTacGia = value
        End Set
    End Property

    Public Property MaPhieuMuon As String
        Get
            Return strMaPhieuMuon
        End Get
        Set(value As String)
            strMaPhieuMuon = value
        End Set
    End Property

    Public Property NgayMuon As Date
        Get
            Return dtpNgayMuon
        End Get
        Set(value As Date)
            dtpNgayMuon = value
        End Set
    End Property

    Public Property SoLuongMuon As Integer
        Get
            Return intSoLuongMuon
        End Get
        Set(value As Integer)
            intSoLuongMuon = value
        End Set
    End Property

    Public Property NgayTra As Date
        Get
            Return dtpNgayTra
        End Get
        Set(value As Date)
            dtpNgayTra = value
        End Set
    End Property

    Public Property XacNhanTra As String
        Get
            Return strXacNhanTra
        End Get
        Set(value As String)
            strXacNhanTra = value
        End Set
    End Property

    Public Property GhiChu As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property
End Class