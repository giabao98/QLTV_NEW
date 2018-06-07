Public Class FindBookDTO
    Private iKind As Integer
    Private strFind As String
    Private iBookCode As Integer
    Private strBookName As String
    Private iProducerCode As Integer
    Private iAuthorCode As Integer
    Private iKindCode As Integer
    Private iPublishingYear As Integer
    Private iAmount As Integer
    Private dateInputDay As DateTime


    Public Property Kind As Integer
        Get
            Return iKind
        End Get
        Set
            iKind = Value
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

    Public Property BookCode As Integer
        Get
            Return iBookCode
        End Get
        Set
            iBookCode = Value
        End Set
    End Property

    Public Property BookName As String
        Get
            Return strBookName
        End Get
        Set
            strBookName = Value
        End Set
    End Property

    Public Property ProducerCode As Integer
        Get
            Return iProducerCode
        End Get
        Set
            iProducerCode = Value
        End Set
    End Property

    Public Property AuthorCode As Integer
        Get
            Return iAuthorCode
        End Get
        Set
            iAuthorCode = Value
        End Set
    End Property

    Public Property KindCode As Integer
        Get
            Return iKindCode
        End Get
        Set
            iKindCode = Value
        End Set
    End Property

    Public Property PublishingYear As Integer
        Get
            Return iPublishingYear
        End Get
        Set
            iPublishingYear = Value
        End Set
    End Property

    Public Property Amount As Integer
        Get
            Return iAmount
        End Get
        Set
            iAmount = Value
        End Set
    End Property

    Public Property InputDay As DateTime
        Get
            Return dateInputDay
        End Get
        Set
            dateInputDay = Value
        End Set
    End Property
End Class
