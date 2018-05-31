Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class LaptheDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insertDocGia(dg As LaptheDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO TVDataBs"
        query &= "(madocgia,hoten,maloaidocgai,ngaysinh,ngaylapthe,email,diachi)"
        query &= "VALUES (@madocgia,@hoten,@maloaidocgia,@ngaysinh,@email,@diachi,@ngaylapthe)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.ReaderID)
                    .Parameters.AddWithValue("@hoten", dg.ReaderName)
                    .Parameters.AddWithValue("@maloaidocgia", dg.ReaderCategoryID)
                    .Parameters.AddWithValue("@ngaysinh", dg.Birthday)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@diachi", dg.Adress)
                    .Parameters.AddWithValue("@ngaylapthe", dg.DayOfCard)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function

End Class
