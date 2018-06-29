Public Class QuyDinhDocGiaDTO
    Private iTuoiToiThieu As Integer
    Private iTuoiToiDa As Integer
    Private iHanSuDung As Integer


    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set
            iTuoiToiThieu = Value
        End Set
    End Property

    Public Property TuoiToiDa As Integer
        Get
            Return iTuoiToiDa
        End Get
        Set
            iTuoiToiDa = Value
        End Set
    End Property

    Public Property HanSuDung As Integer
        Get
            Return iHanSuDung
        End Get
        Set
            iHanSuDung = Value
        End Set
    End Property
End Class
