Imports QLyDTO
Imports QLyDAL

Public Class MuonTraSachBUS
    Public Function ValidMaPhieuMuon(mt As MuonTraSachDTO) As Boolean

        If (mt.MaPhieuMuon.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidMaDocGia(mt As MuonTraSachDTO) As Boolean

        If (mt.MaDocGia.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTenDocGia(mt As MuonTraSachDTO) As Boolean

        If (mt.TenDocGia.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidMaSach(mt As MuonTraSachDTO) As Boolean

        If (mt.MaSach.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTenSach(mt As MuonTraSachDTO) As Boolean

        If (mt.TenSach.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTheLoai(mt As MuonTraSachDTO) As Boolean

        If (mt.TheLoai.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTacGia(mt As MuonTraSachDTO) As Boolean

        If (mt.TacGia.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidNgayMuon(mt As MuonTraSachDTO) As Boolean

        If (mt.NgayMuon.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidSoLuongMuon(mt As MuonTraSachDTO) As Boolean

        If (mt.SoLuongMuon.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidNgayTra(mt As MuonTraSachDTO) As Boolean

        If (mt.NgayTra.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidXacNhanTra(mt As MuonTraSachDTO) As Boolean

        If (mt.XacNhanTra.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidGhiChu(mt As MuonTraSachDTO) As Boolean

        If (mt.GhiChu.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
End Class