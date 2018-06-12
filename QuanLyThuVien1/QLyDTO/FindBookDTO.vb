Public Class FindBookDTO
    Private strFindCategory As String
    Private strFind As String
    'Private strBookCode As String
    'Private strBookName As String
    'Private strProducerCode As String
    'Private strAuthorCode As String
    'Private strCategoryCode As String
    'Private strPublishingYear As String
    'Private strAmount As String
    Private dateInputDay As DateTime


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

    'Public Property BookCode As String
    '    Get
    '        Return strBookCode
    '    End Get
    '    Set
    '        strBookCode = Value
    '    End Set
    'End Property

    'Public Property BookName As String
    '    Get
    '        Return strBookName
    '    End Get
    '    Set
    '        strBookName = Value
    '    End Set
    'End Property

    'Public Property ProducerCode As String
    '    Get
    '        Return strProducerCode
    '    End Get
    '    Set
    '        strProducerCode = Value
    '    End Set
    'End Property

    'Public Property AuthorCode As String
    '    Get
    '        Return strAuthorCode
    '    End Get
    '    Set
    '        strAuthorCode = Value
    '    End Set
    'End Property

    'Public Property CategoryCode As String
    '    Get
    '        Return strCategoryCode
    '    End Get
    '    Set
    '        strCategoryCode = Value
    '    End Set
    'End Property

    'Public Property PublishingYear As String
    '    Get
    '        Return strPublishingYear
    '    End Get
    '    Set
    '        strPublishingYear = Value
    '    End Set
    'End Property

    'Public Property Amount As String
    '    Get
    '        Return strAmount
    '    End Get
    '    Set
    '        strAmount = Value
    '    End Set
    'End Property

    Public Property InputDay As DateTime
        Get
            Return dateInputDay
        End Get
        Set
            dateInputDay = Value
        End Set
    End Property
End Class
