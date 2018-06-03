Imports QlyDTO

Public Class loginDAL
    Private db As New DataBaseAccess()
    Public Function CompareAccount(login As loginDTO) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT * FROM tblADMIN "
        query &= "Where username = '{0}' and password = '{1}' "

        query = String.Format(query, login.UserName, login.Password)

        Dim table As DataTable

        table = db.GetDataTable(query)

        Return table.Rows.Count > 0

    End Function
End Class
