Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class QuyDinhTheLoaiSachDAL
    Private dbAccess As DataBaseAccess
    Protected Con As SqlConnection
    Private ConnectionString As String
    Dim dt As New DataTable
    Dim dtAdap As SqlDataAdapter

    Public Sub New()
        Con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Con.ConnectionString = ConnectionString
    End Sub

    Public Sub New(ConnectionString As String)
        Me.ConnectionString = ConnectionString
    End Sub

    Public Function datatable()
        Dim dtSour As New DataGridView
        Dim strFind As String = "select [thoigianxuatban] from tblTHAMSO"
        dt.Clear()
        dtAdap = New SqlDataAdapter(strFind, Con)
        dtAdap.Fill(dt)
        dtSour.DataSource = dt
        Return dtSour.DataSource
    End Function

    Public Function ThemTheLoai(qdtls As QuyDinhTheLoaiSachDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTHELOAI] "
        query &= "( [matheloai], [tentheloai], [soluong])"
        query &= "VALUES (@matheloai,@tentheloai,@soluong)"

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matheloai", qdtls.MaTheLoai)
                    .Parameters.AddWithValue("@tentheloai", qdtls.TenTheLoai)
                    .Parameters.AddWithValue("@soluong", qdtls.SoLuong)

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
    Public Function CapNhatTheLoai(qdtls As QuyDinhTheLoaiSachDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblTHELOAI] SET "
        query &= "[matheloai] = @matheloai "
        query &= " ,[tentheloai] = @tentheloai "
        query &= " ,[soluong] = @soluong "
        query &= " WHERE "
        query &= " [matheloai] = @matheloai "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matheloai", qdtls.MaTheLoai)
                    .Parameters.AddWithValue("@tentheloai", qdtls.TenTheLoai)
                    .Parameters.AddWithValue("@soluong", qdtls.SoLuong)

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
    Public Function XoaTheLoai(qdtls As QuyDinhTheLoaiSachDTO)
        Dim query As String = String.Empty
        query &= "DELETE [tblTHELOAI] "
        query &= " WHERE "
        query &= " [matheloai] = @matheloai "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matheloai", qdtls.MaTheLoai)
                    .Parameters.AddWithValue("@tentheloai", qdtls.TenTheLoai)
                    .Parameters.AddWithValue("@soluong", qdtls.SoLuong)

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

    Public Function CapNhatKhoangNamXB(qdtls As QuyDinhTheLoaiSachDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblTHAMSO] SET "
        query &= "[thoigianxuatban] = @thoigianxuatban "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thoigianxuatban", qdtls.KhoangNamXB)

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