Public Class LoaiDocGiaDTO
    Private strMaLoaiDocGia As String
    Private strTenLoaiDocGia As String

    Public Property MaLoaiDocGia As String
        Get
            Return strMaLoaiDocGia
        End Get
        Set(value As String)
            strMaLoaiDocGia = value
        End Set
    End Property

    Public Property TenLoaiDocGia As String
        Get
            Return strTenLoaiDocGia
        End Get
        Set(value As String)
            strTenLoaiDocGia = value
        End Set
    End Property
End Class