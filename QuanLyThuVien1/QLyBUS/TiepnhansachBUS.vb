Imports QLyDTO
Imports QLyDAL

Public Class TiepnhansachBUS
    Dim tnsDAL As New TiepnhansachDAL
    Public Function ValidBookID(ts As TiepnhansachDTO) As Boolean

        If (ts.BookID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidBookName(ts As TiepnhansachDTO) As Boolean

        If (ts.BookName.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidBookKindID(ts As TiepnhansachDTO) As Boolean

        If (ts.BookKindID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidAuthorID(ts As TiepnhansachDTO) As Boolean

        If (ts.AuthorID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidPublishingDate(ts As TiepnhansachDTO) As Boolean
        Dim dtsource = tnsDAL.datatable
        Dim ThoiGianToiDa As Integer = Convert.ToInt32(dtsource.rows(0).item("thoigianxuatban").ToString())
        Dim nam As Integer = Convert.ToInt32(DateTime.Now.Year.ToString)
        If ((ts.PublishingDate.ToString.Length < 1) Or ((nam - ts.PublishingDate.Year) > ThoiGianToiDa)) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidPublishingHouseID(ts As TiepnhansachDTO) As Boolean

        If (ts.PublishingHouseID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidReceiptDate(ts As TiepnhansachDTO) As Boolean

        If (ts.ReceiptDate.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidValue(ts As TiepnhansachDTO) As Boolean

        If (ts.Value.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidStatusID(ts As TiepnhansachDTO) As Boolean

        If (ts.StatusID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidNumbers(ts As TiepnhansachDTO) As Boolean
        Dim dtsource = tnsDAL.datatable
        Dim SoLuong As Integer = Convert.ToInt32(dtsource.rows(0).item("soluongsachtoida").ToString())

        If ((ts.Numbers.ToString.Length < 1) Or (ts.Numbers > SoLuong)) Then
            Return False
        End If

        Return True
    End Function

End Class
