Imports QLyDTO

Public Class QuyDinhDocGiaBUS
    Public Function ValidTuoiToiDa(qddg As QuyDinhDocGiaDTO)
        If (qddg.TuoiToiDa.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidTuoiToiThieu(qddg As QuyDinhDocGiaDTO)
        If (qddg.TuoiToiThieu.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidHanSuDung(qddg As QuyDinhDocGiaDTO)
        If (qddg.HanSuDung.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function
End Class
