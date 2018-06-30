Imports QLyDTO
Imports QLyDAL

Public Class QuyDinhTheLoaiSachBUS
    Public Function ValidMaTheLoai(qdtls As QuyDinhTheLoaiSachDTO) As Boolean

        If (qdtls.MaTheLoai.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTenTheLoai(qdtls As QuyDinhTheLoaiSachDTO) As Boolean

        If (qdtls.TenTheLoai.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidSoLuong(qdtls As QuyDinhTheLoaiSachDTO) As Boolean

        If (qdtls.SoLuong.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidKhoangNamXB(qdtls As QuyDinhTheLoaiSachDTO) As Boolean

        If (qdtls.KhoangNamXB.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
End Class