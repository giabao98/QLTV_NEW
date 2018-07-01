Imports System.Configuration
Imports System.Data.SqlClient
Imports QLyDTO

Public Class DoiMatKhauDAL
    Protected Con As SqlConnection
    Private ConnectionString As String

    Public Sub New()
        Con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Con.ConnectionString = ConnectionString
    End Sub

    'Public Function datatable()
    '    Dim dt As New DataTable
    '    Dim dtAdap As SqlDataAdapter
    '    Dim strFind As String = "select * from tblADMIN"
    '    dt.Clear()
    '    dtAdap = New SqlDataAdapter(strFind, Con)
    '    dtAdap.Fill(dt)
    '    Return dt
    'End Function

    Public Function DoiMatKhau(dmk As DoiMatKhauDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblADMIN] SET "
        query &= "[password] = @newpassword "
        query &= " WHERE "
        query &= " [password] = @oldpassword "
        query &= " and [username] = @username "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@newpassword", dmk.MatKhauMoi)
                    .Parameters.AddWithValue("@oldpassword", dmk.MatKhauHienTai)
                    .Parameters.AddWithValue("@username", dmk.TenTaiKhoan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' cap nhat loai doc gia that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
End Class
