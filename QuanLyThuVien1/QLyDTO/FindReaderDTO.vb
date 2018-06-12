Public Class FindReaderDTO
    Private strFindCategory As String
    Private strFind As String

    Public Property FindCategory As String
        Get
            Return strFindCategory
        End Get
        Set
            strFindCategory = Value
        End Set
    End Property

    Public Property Find As String
        Get
            Return strFind
        End Get
        Set
            strFind = Value
        End Set
    End Property
End Class
