Imports QLyDTO

Public Class FindReaderBUS
    Public Function ValidFindCategory(fb As FindReaderDTO) As Boolean
        If (fb.FindCategory.ToString.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidFind(fb As FindReaderDTO) As Boolean
        If (fb.Find.Length < 1) Then
            Return False
        End If
        Return True
    End Function

End Class
