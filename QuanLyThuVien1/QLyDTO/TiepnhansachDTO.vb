Public Class TiepnhansachDTO
    Private strBookName As String
    Private strBookID As String
    Private strBookKindID As String
    Private strAuthorID As String
    Private intPublishingDate As Date
    Private strPublishingHouseID As String
    Private intReceiptDate As Date
    Private strValue As String
    Private strStatusID As String
    Private strNumbers As String

    Public Property BookName As String
        Get
            Return strBookName
        End Get
        Set(value As String)
            strBookName = value
        End Set
    End Property

    Public Property BookID As String
        Get
            Return strBookID
        End Get
        Set(value As String)
            strBookID = value
        End Set
    End Property

    Public Property BookKindID As String
        Get
            Return strBookKindID
        End Get
        Set(value As String)
            strBookKindID = value
        End Set
    End Property

    Public Property AuthorID As String
        Get
            Return strAuthorID
        End Get
        Set(value As String)
            strAuthorID = value
        End Set
    End Property

    Public Property PublishingDate As Date
        Get
            Return intPublishingDate
        End Get
        Set(value As Date)
            intPublishingDate = value
        End Set
    End Property

    Public Property PublishingHouseID As String
        Get
            Return strPublishingHouseID
        End Get
        Set(value As String)
            strPublishingHouseID = value
        End Set
    End Property

    Public Property ReceiptDate As Date
        Get
            Return intReceiptDate
        End Get
        Set(value As Date)
            intReceiptDate = value
        End Set
    End Property

    Public Property Value As String
        Get
            Return strValue
        End Get
        Set(value As String)
            strValue = value
        End Set
    End Property

    Public Property StatusID As String
        Get
            Return strStatusID
        End Get
        Set(value As String)
            strStatusID = value
        End Set
    End Property

    Public Property Numbers As String
        Get
            Return strNumbers
        End Get
        Set(value As String)
            strNumbers = value
        End Set
    End Property
End Class
