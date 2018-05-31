Imports QLyDTO
Imports QLyDAL

Public Class loginBUS
    Public Function ValidUserName(login As loginDTO) As Boolean
        If (login.UserName.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidPassword(login As loginDTO) As Boolean
        If (login.Password.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function CompareAccount(ac As loginDTO)

    End Function

End Class
