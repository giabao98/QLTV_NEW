Imports QLyDTO
Imports QLyDAL

Public Class LoaiDocGiaBUS
    Public Function ValidMaLoaiDocGia(ldg As LoaiDocGiaDTO) As Boolean

        If (ldg.MaLoaiDocGia.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidTenLoaiDocGia(ldg As LoaiDocGiaDTO) As Boolean

        If (ldg.TenLoaiDocGia.Length < 1) Then
            Return False
        End If

        Return True
    End Function
End Class