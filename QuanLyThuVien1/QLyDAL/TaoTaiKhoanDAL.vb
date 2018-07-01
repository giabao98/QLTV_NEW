Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports QLyDTO

Public Class TaoTaiKhoanDAL
    Protected Con As SqlConnection
    Private ConnectionString As String

    Public Sub New()
        Con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Con.ConnectionString = ConnectionString
    End Sub

    Public Function TaoTaiKhoan(ttk As TaoTaiKhoanDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblADMIN] "
        query &= "( [username], [password])"
        query &= "VALUES (@username,@password)"

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", ttk.TenTaiKhoan)
                    .Parameters.AddWithValue("@password", ttk.MatKhau)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function

End Class
