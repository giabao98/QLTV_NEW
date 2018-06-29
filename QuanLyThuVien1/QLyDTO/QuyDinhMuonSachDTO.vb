Public Class QuyDinhMuonSachDTO
    Private iSoLuongToiDa As Integer
    Private iSoNgayToiDa As Integer

    Public Property SoLuongToiDa As Integer
        Get
            Return iSoLuongToiDa
        End Get
        Set
            iSoLuongToiDa = Value
        End Set
    End Property

    Public Property SoNgayToiDa As Integer
        Get
            Return iSoNgayToiDa
        End Get
        Set
            iSoNgayToiDa = Value
        End Set
    End Property
End Class
