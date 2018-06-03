Public Class LaptheDTO
    Private strReaderID As Integer
    Private strReaderName As String
    Private intReaderCategoryID As Integer
    Private dBirthday As Date
    Private strAdress As String
    Private dDayOfCard As Date
    Private strEmail As String
    Private intCreator As Integer

    Public Property ReaderID As Integer
        Get
            Return strReaderID
        End Get
        Set(value As Integer)
            strReaderID = value
        End Set
    End Property

    Public Property ReaderName As String
        Get
            Return strReaderName
        End Get
        Set(value As String)
            strReaderName = value
        End Set
    End Property



    Public Property Birthday As Date
        Get
            Return dBirthday
        End Get
        Set(value As Date)
            dBirthday = value
        End Set
    End Property

    Public Property Adress As String
        Get
            Return strAdress
        End Get
        Set(value As String)
            strAdress = value
        End Set
    End Property

    Public Property DayOfCard As Date
        Get
            Return dDayOfCard
        End Get
        Set(value As Date)
            dDayOfCard = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property Creator As Integer
        Get
            Return intCreator
        End Get
        Set(value As Integer)
            intCreator = value
        End Set
    End Property

    Public Property ReaderCategoryID As Integer
        Get
            Return intReaderCategoryID
        End Get
        Set(value As Integer)
            intReaderCategoryID = value
        End Set
    End Property
End Class
