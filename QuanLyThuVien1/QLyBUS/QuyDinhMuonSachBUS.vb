Imports QLyDTO

Public Class QuyDinhMuonSachBUS
    Public Function ValidSoLuongToiDa(qdms As QuyDinhMuonSachDTO)
        If (qdms.SoLuongToiDa.ToString.Length < 1) Then
            Return False
        End If
        Return True

    End Function

    Public Function ValidSoNgayToiDa(qdms As QuyDinhMuonSachDTO)
        If (qdms.SoNgayToiDa.ToString.Length < 1) Then
            Return False
        End If
        Return True

    End Function

End Class
