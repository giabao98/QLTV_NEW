Imports QLyDTO
Imports QLyDAL


Public Class LaptheBUS
    Dim ltdal As New LaptheDAL

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
    Public Function ValidReaderCategory(lt As LaptheDTO) As Boolean

        If (lt.ReaderCategory.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidBirthday(lt As LaptheDTO) As Boolean
        Dim dtsource = ltdal.datatable
        Dim TuoiToiDa As Integer = Convert.ToInt32(dtsource.rows(0).item("tuoitoida").ToString())
        Dim TuoiToiThieu As Integer = Convert.ToInt32(dtsource.rows(0).item("tuoitoithieu").ToString())
        Dim nam As Integer = Convert.ToInt32(DateTime.Now.Year.ToString)
        If ((lt.Birthday.ToString().Length < 1) Or ((nam - lt.Birthday.Year) > TuoiToiDa) Or ((nam - lt.Birthday.Year) < TuoiToiThieu)) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidDayOfCard(lt As LaptheDTO) As Boolean
        Dim dtsource = ltdal.datatable
        Dim HanSuDung As Integer = Convert.ToInt32(dtsource.rows(0).item("hansudungthe").ToString())
        Dim nam As Integer = Convert.ToInt32(DateTime.Now.Year.ToString)
        If ((lt.DayOfCard.ToString.Length < 1) Or ((nam - lt.DayOfCard.Year) > HanSuDung)) Then
            Return False
        End If

        Return True
    End Function
    Public Function ValidEmail(lt As LaptheDTO) As Boolean

        If (lt.Email.Length < 1) Then
            Return False
        End If

        Return True
    End Function


End Class
