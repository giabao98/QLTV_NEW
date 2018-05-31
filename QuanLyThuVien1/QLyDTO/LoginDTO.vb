Public Class loginDTO
    Private strUserName As String
    Private strPassword As String

    Public Property UserName As String
        Get
            Return strUserName
        End Get
        Set
            strUserName = Value
        End Set
    End Property

    Public Property Password As String
        Get
            Return strPassword
        End Get
        Set
            strPassword = Value
        End Set
    End Property

End Class
