Public Class TiepnhansachDTO
    Private strTheNameOfBook As String
    Private strBookID As String
    Private strTheKindOfBook As String
    Private strAuthor As String
    Private intPublishingDate As Integer
    Private strPublishingHouse As String
    Private intReceiptDate As Date
    Private intValue As Integer

    Public Property TheNameOfBook As String
        Get
            Return strTheNameOfBook
        End Get
        Set(value As String)
            strTheNameOfBook = value
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

    Public Property TheKindOfBook As String
        Get
            Return strTheKindOfBook
        End Get
        Set(value As String)
            strTheKindOfBook = value
        End Set
    End Property

    Public Property Author As String
        Get
            Return strAuthor
        End Get
        Set(value As String)
            strAuthor = value
        End Set
    End Property

    Public Property PublishingDate As Integer
        Get
            Return intPublishingDate
        End Get
        Set(value As Integer)
            intPublishingDate = value
        End Set
    End Property

    Public Property PublishingHouse As String
        Get
            Return strPublishingHouse
        End Get
        Set(value As String)
            strPublishingHouse = value
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
End Class
