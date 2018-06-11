Imports QLyDTO
Imports QLyDAL


Public Class LaptheBUS
    Public Function ValidReaderName(lt As LaptheDTO) As Boolean

        If (lt.ReaderName.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidReaderID(lt As LaptheDTO) As Boolean

        If (lt.ReaderID.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidAdress(lt As LaptheDTO) As Boolean

        If (lt.Adress.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidReaderCategory(lt As QLyDTO.LaptheDTO) As Boolean

        If (lt.ReaderCategory.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidBirthday(lt As QLyDTO.LaptheDTO) As Boolean

        If (lt.Birthday.ToString().Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidDayOfCard(lt As QLyDTO.LaptheDTO) As Boolean

        If (lt.DayOfCard.ToString.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidEmail(lt As QLyDTO.LaptheDTO) As Boolean

        If (lt.Email.Length < 1) Then
            Return False
        End If

        Return True
    End Function


End Class
