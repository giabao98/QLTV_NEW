Public Class QuyDinhTheLoaiSachDTO
    Private strMaTheLoai As String
    Private strTenTheLoai As String
    Private iSoLuong As Integer
    Private iKhoangNamXB As Integer

    Public Property MaTheLoai As String
        Get
            Return strMaTheLoai
        End Get
        Set(value As String)
            strMaTheLoai = value
        End Set
    End Property

    Public Property TenTheLoai As String
        Get
            Return strTenTheLoai
        End Get
        Set(value As String)
            strTenTheLoai = value
        End Set
    End Property

    Public Property SoLuong As Integer
        Get
            Return iSoLuong
        End Get
        Set
            iSoLuong = Value
        End Set
    End Property

    Public Property KhoangNamXB As Integer
        Get
            Return iKhoangNamXB
        End Get
        Set
            iKhoangNamXB = Value
        End Set
    End Property
End Class