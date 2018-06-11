Public Class LaptheDTO
    Private strReaderID As String
    Private strReaderName As String
    Private strReaderCategory As String
    Private dBirthday As Date
    Private strAdress As String
    Private dDayOfCard As Date
    Private strEmail As String
    Private strCreator As String

    Public Property ReaderID As String
        Get
            Return strReaderID
        End Get
        Set(value As String)
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

    Public Property Creator As String
        Get
            Return strCreator
        End Get
        Set(value As String)
            strCreator = value
        End Set
    End Property

    Public Property ReaderCategory As String
        Get
            Return strReaderCategory
        End Get
        Set(value As String)
            strReaderCategory = value
        End Set
    End Property
End Class
