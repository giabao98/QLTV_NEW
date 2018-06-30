Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class LaptheDAL
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

    Public Function datatable()
        Dim dt As New DataTable
        Dim dtAdap As SqlDataAdapter
        Dim strFind As String = "select [tuoitoida],[tuoitoithieu],[hansudungthe] from tblTHAMSO"
        dt.Clear()
        dtAdap = New SqlDataAdapter(strFind, Con)
        dtAdap.Fill(dt)
        Return dt
    End Function

    Public Function ThemDocGia(dg As LaptheDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDOCGIA] "
        query &= "( [madocgia], [hoten], [loaidocgia], [ngaysinh],[email], [diachi], [ngaylapthe])"
        query &= "VALUES (@madocgia,@hoten,@loaidocgia, @ngaysinh,@email,@diachi,@ngaylapthe)"

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.ReaderID)
                    .Parameters.AddWithValue("@hoten", dg.ReaderName)
                    .Parameters.AddWithValue("@loaidocgia", dg.ReaderCategory)
                    .Parameters.AddWithValue("@ngaysinh", dg.Birthday)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@diachi", dg.Adress)
                    .Parameters.AddWithValue("@ngaylapthe", dg.DayOfCard)

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
    Public Function CapNhatDocGia(dg As LaptheDTO)
        Dim query As String = String.Empty
        query &= " UPDATE [tblDOCGIA] SET"
        query &= " [madocgia] = @madocgia "
        query &= " ,[hoten] = @hoten "
        query &= " ,[loaidocgia] = @loaidocgia "
        query &= " ,[ngaysinh] = @ngaysinh "
        query &= " ,[email] = @email "
        query &= " ,[diachi] = @diachi "
        query &= " ,[ngaylapthe] = @ngaylapthe "
        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.ReaderID)
                    .Parameters.AddWithValue("@hoten", dg.ReaderName)
                    .Parameters.AddWithValue("@loaidocgia", dg.ReaderCategory)
                    .Parameters.AddWithValue("@ngaysinh", dg.Birthday)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@diachi", dg.Adress)
                    .Parameters.AddWithValue("@ngaylapthe", dg.DayOfCard)

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
    Public Function XoaDocGia(dg As LaptheDTO)
        Dim query As String = String.Empty
        query &= " DELETE [tblDOCGIA]"
        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(ConnectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", dg.ReaderID)
                    .Parameters.AddWithValue("@hoten", dg.ReaderName)
                    .Parameters.AddWithValue("@loaidocgia", dg.ReaderCategory)
                    .Parameters.AddWithValue("@ngaysinh", dg.Birthday)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@diachi", dg.Adress)
                    .Parameters.AddWithValue("@ngaylapthe", dg.DayOfCard)

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
