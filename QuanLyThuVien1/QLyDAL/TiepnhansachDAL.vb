Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class TiepnhansachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function ThemSach(ts As TiepnhansachDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO tblSACH"
        query &= "(masach,tensach,matheloai,matacgia,namxuatban,manhaxuatban,ngaynhap,trigia,matinhtrang,soluong)"
        query &= "VALUES (@masach,@tensach,@matheloai,@matacgia,@namxuatban,@manhaxuatban,@ngaynhap,@trigia,@matinhtrang,@soluong)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ts.BookID)
                    .Parameters.AddWithValue("@tensach", ts.BookName)
                    .Parameters.AddWithValue("@matheloai", ts.BookKindID)
                    .Parameters.AddWithValue("@matacgia", ts.AuthorID)
                    .Parameters.AddWithValue("@namxuatban", ts.PublishingDate)
                    .Parameters.AddWithValue("@manhaxuatban", ts.PublishingHouseID)
                    .Parameters.AddWithValue("@ngaynhap", ts.ReceiptDate)
                    .Parameters.AddWithValue("@trigia", ts.Value)
                    .Parameters.AddWithValue("@matinhtrang", ts.StatusID)
                    .Parameters.AddWithValue("@soluong", ts.Numbers)
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
    Public Function CapNhatSach(ts As TiepnhansachDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblSACH] SET"
        query &= "[masach] = @masach"
        query &= " ,[tensach] = @tensach"
        query &= " ,[matheloai] = @matheloai"
        query &= " ,[matacgia] = @matacgia"
        query &= " ,[namxuatban] = @namxuatban"
        query &= " ,[manhaxuatban] = @manhaxuatban"
        query &= " ,[ngaynhap] = @ngaynhap"
        query &= " ,[trigia] = @trigia"
        query &= " ,[matinhtrang] = @matinhtrang"
        query &= " ,[soluong] = @soluong"
        query &= "WHERE"
        query &= "[masach] = @masach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ts.BookID)
                    .Parameters.AddWithValue("@tensach", ts.BookName)
                    .Parameters.AddWithValue("@matheloai", ts.BookKindID)
                    .Parameters.AddWithValue("@matacgia", ts.AuthorID)
                    .Parameters.AddWithValue("@namxuatban", ts.PublishingDate)
                    .Parameters.AddWithValue("@manhaxuatban", ts.PublishingHouseID)
                    .Parameters.AddWithValue("@ngaynhap", ts.ReceiptDate)
                    .Parameters.AddWithValue("@trigia", ts.Value)
                    .Parameters.AddWithValue("@matinhtrang", ts.StatusID)
                    .Parameters.AddWithValue("@soluong", ts.Numbers)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' cap nhat that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function XoaSach(ts As TiepnhansachDTO)
        Dim query As String = String.Empty
        query &= " DELETE [tblSACH]"
        query &= " WHERE "
        query &= " [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", ts.BookID)
                    .Parameters.AddWithValue("@tensach", ts.BookName)
                    .Parameters.AddWithValue("@matheloai", ts.BookKindID)
                    .Parameters.AddWithValue("@matacgia", ts.AuthorID)
                    .Parameters.AddWithValue("@namxuatban", ts.PublishingDate)
                    .Parameters.AddWithValue("@manhaxuatban", ts.PublishingHouseID)
                    .Parameters.AddWithValue("@ngaynhap", ts.ReceiptDate)
                    .Parameters.AddWithValue("@trigia", ts.Value)
                    .Parameters.AddWithValue("@matinhtrang", ts.StatusID)
                    .Parameters.AddWithValue("@soluong", ts.Numbers)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' xoa that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
End Class
