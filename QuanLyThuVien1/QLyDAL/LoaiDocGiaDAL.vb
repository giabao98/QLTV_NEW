Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class LoaiDocGiaDAL
    Private dbAccess As DataBaseAccess
    Protected Con As SqlConnection
    Private ConnectionString As String

    Public Sub New()
        Con = New SqlConnection
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Con.ConnectionString = ConnectionString
    End Sub

    Public Sub New(ConnectionString As String)
        Me.ConnectionString = ConnectionString
    End Sub

    Public Function ThemLoaiDocGia(ldg As LoaiDocGiaDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLOAIDOCGIA] "
        query &= "( [maloaidocgia], [tenloaidocgia])"
        query &= "VALUES (@maloaidocgia,@tenloaidocgia)"

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)

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
    Public Function CapNhatLoaiDocGia(ldg As LoaiDocGiaDTO)
        Dim query As String = String.Empty
        query &= "UPDATE [tblLOAIDOCGIA] SET "
        query &= "[maloaidocgia] = @maloaidocgia "
        query &= " ,[tenloaidocgia] = @tenloaidocgia "
        query &= " WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)

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
    Public Function XoaLoaiDocGia(ldg As LoaiDocGiaDTO)
        Dim query As String = String.Empty
        query &= "DELETE [tblLOAIDOCGIA] "
        query &= " WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoaiDocGia)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoaiDocGia)

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