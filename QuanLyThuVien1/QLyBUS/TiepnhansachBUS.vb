Imports QLyDTO
Imports QLyDAL

Public Class TiepnhansachBUS
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

        If (ts.PublishingDate.ToString.Length < 1) Then
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

        If (ts.Numbers.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function

End Class
