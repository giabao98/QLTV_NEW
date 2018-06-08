Public Class TiepnhansachDTO
    Private strBookName As String
    Private strBookID As Integer
    Private strBookKindID As Integer
    Private strAuthorID As Integer
    Private intPublishingDate As Date
    Private strPublishingHouseID As Integer
    Private intReceiptDate As Date
    Private intValue As Integer
    Private intStatusID As Integer
    Private intNumbers As Integer

    Public Property BookName As String
        Get
            Return strBookName
        End Get
        Set(value As String)
            strBookName = value
        End Set
    End Property

    Public Property BookID As Integer
        Get
            Return strBookID
        End Get
        Set(value As Integer)
            strBookID = value
        End Set
    End Property

    Public Property BookKindID As Integer
        Get
            Return strBookKindID
        End Get
        Set(value As Integer)
            strBookKindID = value
        End Set
    End Property

    Public Property AuthorID As Integer
        Get
            Return strAuthorID
        End Get
        Set(value As Integer)
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

    Public Property PublishingHouseID As Integer
        Get
            Return strPublishingHouseID
        End Get
        Set(value As Integer)
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

    Public Property Value As Integer
        Get
            Return intValue
        End Get
        Set(value As Integer)
            intValue = value
        End Set
    End Property

    Public Property StatusID As Integer
        Get
            Return intStatusID
        End Get
        Set(value As Integer)
            intStatusID = value
        End Set
    End Property

    Public Property Numbers As Integer
        Get
            Return intNumbers
        End Get
        Set(value As Integer)
            intNumbers = value
        End Set
    End Property
End Class
